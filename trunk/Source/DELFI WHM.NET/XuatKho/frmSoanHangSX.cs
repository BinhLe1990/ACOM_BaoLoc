using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace DELFI_WHM.NET.XuatKho
{
    public partial class frmSoanHangSX : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string _MaSanPham = "";
        string _LenhSanXuat = "";
        int ID = 0;
        string QRCode = "";
        string _Lot = "";
        DateTime Ngay = DateTime.Now;

        public frmSoanHangSX()
        {
            InitializeComponent();
        }

        public string Chungtu
        {
            get { return _LenhSanXuat; }
            set { _LenhSanXuat = value; }
        }

        private void gridView_ChitietLSX_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView_DaSoan_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView_DangSoan_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private bool Check_QRCode()
        {
            if (!cnn.bComboIsNull(cboLSX))
            {
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    _LenhSanXuat = cboLSX.uText;
                    _MaSanPham = cboMaSanPham.uEditValue.ToString();
                    QRCode = txtQRCode.uText;
                    _Lot = txtLot.uText;
                    if (_Lot.Trim().Length > 0)
                    {
                        var qr = db.WH_TonKho.Where(p => p.QRCode == QRCode && p.Exported == false && p.ItemNo == _MaSanPham && p.Lot == _Lot).ToList();
                        if (qr.Count == 0)
                        {
                            XtraMessageBox.Show("Mã QRCode không hợp lệ \n Vui lòng kiểm tra lại Sản phẩm, Lot", "Thông báo");
                            cnn.clearControl(txtQRCode);
                            txtQRCode.SelectAll();
                            return false;
                        }
                    }
                    else
                    {
                        var sample = db.WH_TonKho.Where(c => c.QRCode == txtQRCode.uText && c.Exported == false && c.ItemNo == _MaSanPham).ToList();
                        if (sample.Count == 0)
                        {
                            XtraMessageBox.Show("Mã QR Code không hợp lệ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtQRCode.SelectAll();
                            return false;
                        }
                        else if (sample[0].Sample.ToString() == "True")
                        {
                            XtraMessageBox.Show("Hàng sample không thể xuất", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtQRCode.SelectAll();
                            return false;
                        }
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Lệnh sản xuất không được bỏ trống", "Thông báo");
                return false;
            }
            return true;
        }

        private void txtQRCode_uKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!Check_QRCode())
                    return;
                int dem = 0;
                DataTable dt = new DataTable();
                dt.Columns.Add("Xoa");
                dt.Columns.Add("DocumentNo");
                dt.Columns.Add("Datetime", typeof(DateTime));
                dt.Columns.Add("QRCode");
                dt.Columns.Add("ItemCode");
                dt.Columns.Add("ID");
                if (gridView_DangSoan.RowCount > 0)
                {
                    for (int i = 0; i < gridView_DangSoan.RowCount; i++)
                    {
                        dt.Rows.Add("", gridView_DangSoan.GetRowCellValue(i, "DocumentNo"),
                                        gridView_DangSoan.GetRowCellValue(i, "Datetime"),
                                        gridView_DangSoan.GetRowCellValue(i, "QRCode"),
                                        gridView_DangSoan.GetRowCellValue(i, "ItemCode"),
                                        gridView_DangSoan.GetRowCellValue(i, "ID"));

                        if (gridView_DangSoan.GetRowCellValue(i, "QRCode").ToString() == QRCode)
                        {
                            dem++;
                        }
                    }
                    if (dem == 0)
                    {
                        dt.Rows.Add("", _LenhSanXuat, cnn.GetDateServer(), QRCode, _MaSanPham, Convert.ToInt32(spnID.uValue));
                    }
                }
                else
                {
                    dt.Rows.Add("", _LenhSanXuat, cnn.GetDateServer(), QRCode, _MaSanPham, Convert.ToInt32(spnID.uValue));
                }
                grid_DangSoan.DataSource = dt;
                Tab.SelectedTabPage = TabDangSoan;
                txtLot.uText = "";
                txtQRCode.SelectAll();
            }
        }

        private void cboLSX_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_LSX();
        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

        private void Load_LSX()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var LSX = db.Chitiet_LenhSanXuat.OrderByDescending(c => c.PostingDate).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("BatchNo");
                dt.Columns.Add("ItemNo");
                dt.Columns.Add("Note");
                dt = ConvertToDataTable(LSX);
                cboLSX.uDataSource = dt;
            }
        }

        private void Load_Item()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var SP = db.tblItems.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ItemNo");
                dt.Columns.Add("ItemName");
                dt = ConvertToDataTable(SP);
                cboMaSanPham.uDataSource = dt;
            }
        }

        private void LSX_Chitiet(string LenhSanXuat)
        {
            if (LenhSanXuat != null)
            {
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    var ChuaHoanThanh = new Dictionary<String, String>() { { "DocumentNo", LenhSanXuat } };
                    grid_ChuaHoanThanh.DataSource = cnn.SQL_GetStoredProcedure("SP_LSX_ChuaHoanThanh", ChuaHoanThanh);

                    var sh = db.ChiTietSoanHang.Where(c => c.DocumentNo == LenhSanXuat).ToList();
                    gridDaSoan.DataSource = sh;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cnn.clearControl(groupbox);
        }

        private void cboLSX_uEditValueChanged(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboLSX))
                Load_Item();
            LSX_Chitiet(cboLSX.uEditValue.ToString());
            spnID.uValue = 0;
            //using (DBACOMEntities db = new DBACOMEntities())
            //{
            //    ID = Convert.ToInt32(cboLSX.uEditValue);
            //    if (ID > 0)
            //    {
            //        {
            //            var LSX = db.Chitiet_LenhSanXuat.Where(c => c.ID == ID).ToList();
            //            cboMaSanPham.uEditValue = LSX[0].ItemNo;
            //            txtLot.uText = LSX[0].Lot;
            //            txtQRCode.Focus();
            //        }
            //        {
            //            var sh = db.ChiTietSoanHang.Where(c => c.IDBatchDetail == ID).ToList();
            //            if (sh.Count> 0)
            //            {
            //                btnHoanThanh.Enabled = false;
            //            }
            //            else
            //            {
            //                btnHoanThanh.Enabled = true;
            //            }
            //            gridDaSoan.DataSource = sh;
            //        }
            //    }
            //}
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn Hoàn thành?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            using (DBACOMEntities db = new DBACOMEntities())
            {
                if (gridView_DangSoan.RowCount > 0)
                {
                    for (int i = 0; i < gridView_DangSoan.RowCount; i++)
                    {
                        _LenhSanXuat = gridView_DangSoan.GetRowCellValue(i, "DocumentNo").ToString();
                        ID = Convert.ToInt32(gridView_DangSoan.GetRowCellValue(i, "ID"));
                        QRCode = gridView_DangSoan.GetRowCellValue(i, "QRCode").ToString();
                        var check = db.ChiTietSoanHang.Where(p => p.IDBatchDetail == ID && p.DocumentNo == _LenhSanXuat && p.QRCode == QRCode).ToList();
                        if (check.Count == 0)
                        {
                            db.ChiTietSoanHang.Add(new ChiTietSoanHang
                            {
                                QRCode = gridView_DangSoan.GetRowCellValue(i, "QRCode").ToString(),
                                ItemCode = gridView_DangSoan.GetRowCellValue(i, "ItemCode").ToString(),
                                Datetime = cnn.GetDateServer(),
                                DocumentType = "processing",
                                DocumentNo = gridView_DangSoan.GetRowCellValue(i, "DocumentNo").ToString(),
                                UserName = Properties.Settings.Default.USER_NAME,
                                IDBatchDetail = Convert.ToInt32(gridView_DangSoan.GetRowCellValue(i, "ID"))
                            });
                            db.SaveChanges();
                        }
                    }
                    var sh = db.ChiTietSoanHang.Where(c => c.IDBatchDetail == ID).ToList();
                    gridDaSoan.DataSource = sh;
                    Tab.SelectedTabPage = TabDaSoan;
                    XtraMessageBox.Show("Cập nhật thành công", "Thông báo");
                }
                else
                {
                    XtraMessageBox.Show("Chưa phát sinh soạn hàng, không thể hoàn thành", "Thông báo");
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            gridView_DangSoan.DeleteRow(gridView_DangSoan.FocusedRowHandle);            
        }

        private void gridView_ChuaHoanThanh_DoubleClick(object sender, EventArgs e)
        {
            spnID.uValue = Convert.ToInt32(gridView_ChuaHoanThanh.GetFocusedRowCellValue("ID"));
            ID = Convert.ToInt32(gridView_ChuaHoanThanh.GetFocusedRowCellValue("ID"));
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.Chitiet_LenhSanXuat.Where(c => c.ID == ID).ToList();
                cboMaSanPham.uEditValue = list[0].ItemNo;
                txtLot.uText = list[0].Lot;
            }
        }

        private void spnID_uValueChanged(object sender, EventArgs e)
        {
            if (spnID.uValue > 0)
            {
                txtQRCode.bIsReadOnly = false;
            }
            else
            {
                txtQRCode.bIsReadOnly = true;
            }
        }

        private void frmSoanHangSX_Load(object sender, EventArgs e)
        {
            txtQRCode.bIsReadOnly = true;
        }

        private void gridView_ChuaHoanThanh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView_ChuaHoanThanh.OptionsSelection.MultiSelect = true;
                gridView_ChuaHoanThanh.SelectAll();
            }
        }

        private void gridView_DaSoan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView_DaSoan.OptionsSelection.MultiSelect = true;
                gridView_DaSoan.SelectAll();
            }
        }

        private void gridView_DangSoan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView_DangSoan.OptionsSelection.MultiSelect = true;
                gridView_DangSoan.SelectAll();
            }
        }
    }
}

