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
    public partial class frmXuatKho : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string _QuiCach, _Lot, _MaSanPham, _LenhSanXuat, _TLYeuCau, _Packing, _Loai, _Location, _SoPhieuCan;
        int _Trongluong, _Soluong, _TLTruBi, _TLHang, _PalletQty, _ID;
        DateTime Ngay;
        string _Cer = "NONE";
        string _Vitri = "RECEIVING";
        public frmXuatKho(frmDS_XuatKho parent)
        {
            InitializeComponent();
        }
        public string Chungtu
        {
            get { return _LenhSanXuat; }
            set { _LenhSanXuat = value; }
        }
        public DateTime NgayTao
        {
            get { return Ngay; }
            set { Ngay = value; }
        }
        private void txtQRCode_uTextChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView3_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void frmXuatKho_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                btnLuu_Click(sender, e);
            }
        }

        private void txtQRCode_uKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    {
                        var SP = db.tblItems.ToList();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("ItemNo");
                        dt.Columns.Add("ItemName");
                        dt = ConvertToDataTable(SP);
                        cboMaSanPham.uDataSource = dt;
                    }
                    _LenhSanXuat = cboLGH.uEditValue.ToString();
                    _MaSanPham = cboMaSanPham.uEditValue.ToString();
                    string QRCode = txtQRCode.uText;
                    var qr = db.WH_TonKho.Where(p => p.QRCode == QRCode && p.Exported == false && p.ItemNo == _MaSanPham).ToList();
                    
                    if (qr.Count == 0)
                    {
                        XtraMessageBox.Show("Mã QRCode không hợp lệ \nVui lòng kiểm tra lại Sản phẩm", "Thông báo");
                        cnn.clearControl(txtQRCode);
                        cboLGH.Focus();
                    }

                    var sample = db.WH_TonKho.Where(c => c.QRCode == txtQRCode.uText).ToList();
                    if (sample.Count == 0)
                    {
                        XtraMessageBox.Show("Mã QR Code không hợp lệ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQRCode.SelectAll();
                    }
                    else if (sample[0].Sample.ToString() == "True")
                    {
                        XtraMessageBox.Show("Hàng sample không thể xuất", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQRCode.SelectAll();
                    }
                }
            }
        }

        private void cboLGH_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_LGH();
        }

        private void cboLGH_uEditValueChanged(object sender, EventArgs e)
        {
            LSX_Chitiet(cboLGH.uEditValue.ToString());
            cnn.clearControl(cboMaSanPham);
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
           
                string QRCode = gridView3.GetFocusedRowCellValue("QRCode").ToString();
                txtSoPhieuCan.uText = gridView3.GetFocusedRowCellValue("WeightNote").ToString();
                cboLGH.uEditValue = gridView3.GetFocusedRowCellValue("DocumentNo").ToString();
                txtQRCode.uText = QRCode;
                cboMaSanPham.uEditValue = gridView3.GetFocusedRowCellValue("ItemCode").ToString();
                dtpNgayxuat.uValue = Convert.ToDateTime(gridView3.GetFocusedRowCellValue("Datetime"));
                spnID.uValue = Convert.ToInt32(gridView3.GetFocusedRowCellValue("ID"));
                txtSoPhieuCan.bIsReadOnly = false;
                btnLuu.Enabled = false;
                txtQRCode.bIsReadOnly = true;  
        }

        private void rpt_Chon_EditValueChanged(object sender, EventArgs e)
        {
            //gridView3.PostEditor();
            //if (gridView3.GetFocusedRowCellValue("WeightNote").ToString().Length > 0)
            //{
            //    gridView3.SetFocusedRowCellValue("Chon", false);
            //}  
        }

        private void gridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView1.OptionsSelection.MultiSelect = true;
                gridView1.SelectAll();
            }
        }

        private void gridView3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView3.OptionsSelection.MultiSelect = true;
                gridView3.SelectAll();
            }
        }

        private void chkCheckAll_EditValueChanged(object sender, EventArgs e)
        {
            if (gridView3.RowCount > 0)
            {
                if (chkCheckAll.Checked == true)
                {
                    for (int i = 0; i < gridView3.RowCount; i++)
                    {
                        gridView3.SetRowCellValue(i, "Chon", true);
                    }
                }
                else
                {
                    for (int i = 0; i < gridView3.RowCount; i++)
                    {
                        gridView3.SetRowCellValue(i, "Chon", false);
                    }
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn Hủy?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                for (int i = 0; i < gridView3.DataRowCount; i++)
                {
                    if (gridView3.GetRowCellValue(i, "Chon").ToString() == "True")
                    {
                        dt.Rows.Add(gridView3.GetRowCellValue(i, "ID"));
                    }
                }
                if (dt.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn dòng cần hủy phiếu cân", "Thông báo");
                }
                else
                {
                    string _LGH = gridView3.GetRowCellValue(0, "DocumentNo").ToString();
                    for (int i = 0; i < gridView3.DataRowCount; i++)
                    {
                        if (gridView3.GetRowCellValue(i, "Chon").ToString() == "True")
                        {
                            _ID = Convert.ToInt32(gridView3.GetRowCellValue(i, "ID"));
                            string PhieuCan = cnn.sNull2String(gridView3.GetRowCellValue(i, "WeightNote"));
                            if (cnn.sNull2Number(cnn.DT_DataTable("SELECT SecondWeight FROM DM_PhieuCanCau WHERE WeightNote = '" + PhieuCan + "'").Rows[0]["SecondWeight"]) == 0)
                            {
                                cnn.ExecuteNonQuery("UPDATE ChiTietSoanHang SET WeightNote = '' WHERE ID = '" + _ID + "'");
                            }
                            else
                            {
                                XtraMessageBox.Show("Đã phát sinh cân lần 2, không thể hủy", "Thông báo");
                                return;
                            }
                        }
                    }
                    LSX_Chitiet(_LGH);
                    chkCheckAll.Checked = false;
                    XtraMessageBox.Show("Đã hủy phiếu cân theo danh sách đã chọn", "Thông báo");
                }
            }
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

        private void rptDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa QRCode này ra khỏi danh sách Đã soạn?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string QRCode = cnn.sNull2String(gridView3.GetFocusedRowCellValue("QRCode"));

                DataTable dt = new DataTable();
                dt = cnn.DT_DataTable("SELECT QRCode FROM WH_TonKho WHERE QRCode = '" + QRCode + "' AND Exported = 0");
                if (dt.Rows.Count == 1)
                {
                    cnn.ExecuteNonQuery("DELETE FROM ChitietSoanHang WHERE QRCode = '" + QRCode + "'");
                    LSX_Chitiet(cboLGH.uEditValue.ToString());
                    XtraMessageBox.Show("Đã xóa QRCode '" + QRCode + "' khỏi danh sách Đã soạn", "Thông báo");
                }
                else
                {
                    XtraMessageBox.Show("QRCode đã phát sinh xuất hàng, không thể xóa", "Thông báo");
                    return;
                }
            }
        }

        private void Load_LGH()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var LGH = db.ChiTiet_LenhGiaoHang.OrderByDescending(c => c.PostingDate).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("SaleOrderCalNo");
                dt.Columns.Add("SaleContractNo");
                dt.Columns.Add("ItemNo");
                dt = ConvertToDataTable(LGH);
                cboLGH.uDataSource = dt;
            }
        }

        private void LSX_Load()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                Ngay = Convert.ToDateTime(dtpNgay.uValue).Date;
                var LGH = db.DM_LenhGiaoHang.Where(c => c.PostingDate == Ngay).ToList();
                if (LGH != null)
                {
                    gridDSLSX.DataSource = LGH;
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {   
            if (cnn.sNull2Number(cnn.DT_DataTable("SELECT SecondWeight FROM DM_PhieuCanCau WHERE WeightNote = '" + txtSoPhieuCan.uText + "'").Rows[0]["SecondWeight"]) > 0)
            {            
                XtraMessageBox.Show("Đã phát sinh cân lần 2, không thể Cập nhật", "Thông báo");
                return;
            }

            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn Cập nhật số phiếu cân?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                for (int i = 0; i < gridView3.DataRowCount; i++)
                {
                    if (gridView3.GetRowCellValue(i, "Chon").ToString() == "True")
                    {
                        dt.Rows.Add(gridView3.GetRowCellValue(i, "ID"));
                    }
                }
                if (dt.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn dòng cần Update số phiếu cân", "Thông báo");
                }
                else if (txtSoPhieuCan.uText != "")
                {
                    _SoPhieuCan = txtSoPhieuCan.uText;
                    string _LGH = gridView3.GetRowCellValue(0, "DocumentNo").ToString();

                    //Kiểm tra phiếu cân có Apply cho SO nào chưa
                    DataTable dt_SO = new DataTable();
                    dt_SO = cnn.DT_DataTable("SELECT WeightNote FROM ChiTietSoanHang WHERE WeightNote = '" + _SoPhieuCan + "' AND DocumentNo <> '" + _LGH + "'");
                    if (dt_SO.Rows.Count == 0)
                    {
                        //Kiểm tra xem Phiếu cân có tồn tại k và loại phiếu có phải xuất k
                        DataTable dt_W = new DataTable();
                        dt_W = cnn.DT_DataTable("SELECT WeightNote, WeightType FROM DM_PhieuCanCau WHERE WeightNote = '" + _SoPhieuCan + "' AND (WeightType = 'Sale' OR WeightType = 'Ship')");
                        if (dt_W.Rows.Count > 0)
                        {
                            for (int i = 0; i < gridView3.DataRowCount; i++)
                            {
                                if (gridView3.GetRowCellValue(i, "Chon").ToString() == "True")
                                {
                                    _ID = Convert.ToInt32(gridView3.GetRowCellValue(i, "ID"));
                                    string PhieuCan = cnn.sNull2String(gridView3.GetRowCellValue(i, "WeightNote"));
                                    if (PhieuCan != "")
                                    {
                                        if (cnn.sNull2Number(cnn.DT_DataTable("SELECT SecondWeight FROM DM_PhieuCanCau WHERE WeightNote = '" + PhieuCan + "'").Rows[0]["SecondWeight"]) == 0)
                                        {
                                            cnn.ExecuteNonQuery("UPDATE ChiTietSoanHang SET WeightNote = '" + _SoPhieuCan + "', DocumentType = '" + dt_W.Rows[0]["WeightType"].ToString() + "' WHERE ID = '" + _ID + "'");
                                        }
                                        else
                                        {
                                            XtraMessageBox.Show("Đã phát sinh cân lần 2, không thể Cập nhật", "Thông báo");
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        cnn.ExecuteNonQuery("UPDATE ChiTietSoanHang SET WeightNote = '" + _SoPhieuCan + "', DocumentType = '" + dt_W.Rows[0]["WeightType"].ToString() + "' WHERE ID = '" + _ID + "'");
                                    }
                                }
                            }
                            LSX_Chitiet(_LGH);
                            chkCheckAll.Checked = false;
                            XtraMessageBox.Show("Cập nhật Số phiếu cân thành công", "Thông báo");
                        }
                        else
                        {
                            XtraMessageBox.Show("Mã phiếu cân không hợp lệ", "Thông báo");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Phiếu cân này đã được dùng cho Lệnh giao hàng khác, vui lòng kiểm tra lại", "Thông báo");
                    }
                }
                else if (txtSoPhieuCan.uText == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập Số phiếu cân", "Thông báo");
                }
            }
        }

        private void LSX_Chitiet(string LenhGH)
        {
            if (LenhGH != null)
            {
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    var LSX = db.ChiTiet_LenhGiaoHang.Where(c => c.SaleOrderCalNo == LenhGH).ToList();

                    griDanhSach.DataSource = LSX;

                    var Up = new Dictionary<String, String>() { { "DocumentNo", LenhGH} };
                    gridDaCan.DataSource = cnn.SQL_GetStoredProcedure("SP_SoanHang_SaleShip", Up);
                }
            }
        }

        private void Form_Load()
        {
            dtpNgay.uValue = cnn.GetDateServer();
            dtpNgayxuat.uValue = cnn.GetDateServer();
            LSX_Load();
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var SP = db.tblItems.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ItemNo");
                dt.Columns.Add("ItemName");
                dt = ConvertToDataTable(SP);
                cboMaSanPham.uDataSource = dt;
            }
            txtSoPhieuCan.bIsReadOnly = false;
            txtQRCode.bIsReadOnly = false;
            groupbox.Select();
        }

        private void dtpNgay_uEditValueChanged(object sender, EventArgs e)
        {
            LSX_Load();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            if (gridView2.RowCount > 0)
            {
                LSX_Chitiet(gridView2.GetFocusedRowCellValue("SaleOrderCalNo").ToString());
                txtSoPhieuCan.bIsReadOnly = false;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Load_LGH();
            if (gridView1.RowCount > 0)
            {
                cboLGH.uEditValue = gridView1.GetFocusedRowCellValue("SaleOrderCalNo").ToString();
                cboMaSanPham.uEditValue = gridView1.GetFocusedRowCellValue("ItemNo").ToString();
                spn_ID_LineNo.uValue = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                spnSoLuongYeuCau.uValue = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Quantity"));
                cnn.clearControl(txtQRCode);
                txtQRCode.Focus();
                txtSoPhieuCan.bIsReadOnly = true;
                cnn.clearControl(txtSoPhieuCan);
                txtQRCode.bIsReadOnly = false;
                btnLuu.Enabled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cnn.clearControl(groupbox);
        }

        private void frmXuatKho_Load(object sender, EventArgs e)
        {
            dtpNgayxuat.uValue = cnn.GetDateServer();
            Load_LGH();
            Form_Load();
        }

        private bool Check_Cond()
        {
            if (cnn.bComboIsNull(cboLGH))
            {
                XtraMessageBox.Show("Bạn chưa nhập Lệnh giao hàng", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLGH.Focus();
                return false;
            }
            if (txtQRCode.uText.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập Mã QR Code", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQRCode.SelectAll();
                return false;
            }
            if (cnn.bComboIsNull(cboMaSanPham))
            {
                XtraMessageBox.Show("Bạn chưa nhập Mã hàng", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaSanPham.Focus();
                return false;
            }

            using (DBACOMEntities db = new DBACOMEntities())
            {
                string _QRCode = txtQRCode.uText;
                int ID_LGH = Convert.ToInt32(spn_ID_LineNo.uValue);
                var sample = db.WH_TonKho.Where(c => c.QRCode == _QRCode && c.Exported == false).ToList();
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
                var list = db.ChiTietSoanHang.Where(b => b.QRCode == _QRCode).ToList();
                if (list.Count > 0)
                {
                    XtraMessageBox.Show("Mã QR Code không hợp lệ, Đã phát sinh soạn hàng", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQRCode.SelectAll();
                    return false;
                }
                var LGH = db.ChiTiet_LenhGiaoHang.Where(c => c.ID == ID_LGH).ToList();
                if (LGH.Count > 0)
                {
                    if (sample[0].ItemNo.ToString() != LGH[0].ItemNo.ToString())
                    {
                        XtraMessageBox.Show("Mã sản phẩm không đúng với Lệnh giao hàng", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQRCode.SelectAll();
                        return false;
                    }
                    if (cnn.sNull2String(LGH[0].Lot) != "")
                    {
                        if (sample[0].Lot.ToString() != LGH[0].Lot.ToString())
                        {
                            XtraMessageBox.Show("Lot không đúng với Lệnh giao hàng", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtQRCode.SelectAll();
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public void SoanHang()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                db.ChiTietSoanHang.Add(new ChiTietSoanHang
                {
                    QRCode = txtQRCode.uText,
                    ItemCode = cboMaSanPham.uEditValue.ToString(),
                    Datetime = Convert.ToDateTime(dtpNgayxuat.uValue),
                    WeightNote = txtSoPhieuCan.uText,
                    DocumentNo = cboLGH.uEditValue.ToString(),
                    UserName = Properties.Settings.Default.USER_NAME,
                    IDBatchDetail = Convert.ToInt32(spn_ID_LineNo.uValue)
                });
                if (db.SaveChanges() > 0)
                {
                    txtQRCode.uText = "";
                    LSX_Chitiet(cboLGH.uEditValue.ToString());
                    txtQRCode.Focus();
                    spnTLQrCode.uValue = 0;
                    XtraMessageBox.Show("Cập nhật danh sách thành công", "Thông báo");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Check_Cond())
                return;
            if (!cnn.bComboIsNull(cboLGH))
            {
                spnTLQrCode.uValue = Convert.ToInt32(cnn.DT_DataTable("SELECT TOP(1) QRCodeQty FROM WH_TonKho WHERE QRCode = '" + txtQRCode.uText + "'").Rows[0]["QRCodeQty"]);

                DataTable dt = new DataTable();
                dt = (DataTable)gridDaCan.DataSource;

                int DaSoan = Convert.ToInt32(spnTLQrCode.uValue) + cnn.sNull2Int(dt.Compute("SUM(QRCodeQty)", "IDBatchDetail = '" + spn_ID_LineNo.uValue + "'"));

                if (DaSoan > spnSoLuongYeuCau.uValue)
                {
                    DialogResult result = XtraMessageBox.Show("Trọng lượng Soạn hàng (" + DaSoan + ") > Trọng lượng Yêu cầu (" + spnSoLuongYeuCau.uValue + ")\n Bạn có chắc chắn muốn Lưu?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        SoanHang();
                    }
                    else
                    {
                        spnTLQrCode.uValue = 0;
                    }
                }
                else
                {
                    SoanHang();
                }                
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn Lệnh Giao Hàng trước", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}

