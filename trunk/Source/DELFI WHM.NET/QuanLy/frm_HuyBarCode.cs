using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DELFI_WHM.NET.DELFI_Class;
using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.QuanLy
{
    public partial class frm_HuyBarCode : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string _QRCode = "";

        public frm_HuyBarCode()
        {
            InitializeComponent();
        }

        private void Search()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.WH_TonKho.Where(c => c.Exported == false).ToList();
                if (list.Count > 0)
                {
                    griDanhSach.DataSource = list;
                }
            }
        }

        private bool Check_QR()
        {
            if (txtGhichu.uText.Trim() == "")
            {
                XtraMessageBox.Show("Lý do không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGhichu.SelectAll();
                return false;
            }
            return true;
        }

        private void History()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                for (int i = 0; i < gridView_DaChon.DataRowCount; i++)
                {
                    if (gridView_DaChon.GetRowCellValue(i, "Exported").ToString() == "True")
                    {
                        db.HIS_Phieucancau.Add(new HIS_Phieucancau
                        {
                            ID_WeightNote = 0,
                            Dateupdate = cnn.GetDateServer(),
                            UserName = Properties.Settings.Default.USER_NAME,
                            Desc = gridView_DaChon.GetRowCellValue(i, "QRCode").ToString(),
                            Loai = "KhoaQRCode",
                            Ghichu = txtGhichu.uText
                        });
                        db.SaveChanges();
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (gridView_DaChon.DataRowCount > 0)
            {
                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn khóa các QRCode này ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (!Check_QR())
                        return;
                    History();
                    using (DBACOMEntities db = new DBACOMEntities())
                    {
                        for (int i = 0; i < gridView_DaChon.DataRowCount; i++)
                        {
                            if (gridView_DaChon.GetRowCellValue(i, "Exported").ToString() == "True")
                            {
                                _QRCode = gridView_DaChon.GetRowCellValue(i, "QRCode").ToString();
                                //{
                                //    WH_TonKho tk = db.WH_TonKho.Where(c => c.QRCode == _QRCode).FirstOrDefault();
                                //    tk.Exported = true;
                                //    db.SaveChanges();
                                //}
                                //{
                                    //WH_ChiTietNhapKho nk = db.WH_ChiTietNhapKho.Where(c => c.QRCode == _QRCode).FirstOrDefault();
                                    //nk.Del = true;
                                    //db.SaveChanges();
                                    cnn.ExecuteNonQuery("UPDATE WH_TonKho SET Exported = 1 WHERE QRCode = '" + _QRCode + "'");
                                    cnn.ExecuteNonQuery("UPDATE WH_ChiTietNhapKho SET Del = 1 WHERE QRCode = '" + _QRCode + "'");
                                    cnn.ExecuteNonQuery("UPDATE WH_ChiTietXuatKho SET Del = 1 WHERE QRCode = '" + _QRCode + "'");
                                //}
                                //var list = db.WH_ChiTietXuatKho.Where(c => c.QRCode == _QRCode).ToList();
                                //if (list.Count > 0)
                                //{
                                //    WH_ChiTietXuatKho xk = db.WH_ChiTietXuatKho.Where(c => c.QRCode == _QRCode).FirstOrDefault();
                                //    xk.Del = true;
                                //    db.SaveChanges();
                                //}
                            }
                        }
                    }

                    Search();

                    cnn.clearControl(groupBox1);
                    grid_DaChon.DataSource = "";
                    XtraMessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                }
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu phát sinh", "Thông báo");
            }
        }

        private void gridView_DanhSach_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void frm_HuyBarCode_Load(object sender, EventArgs e)
        {
            dtpTuNgay.uValue = cnn.GetDateServer();
            dtpDenNgay.uValue = cnn.GetDateServer();
            Search();
            Search_LS();
        }

        private void txtMaPallet_uKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _QRCode = txtMaPallet.uText;
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    var list = db.WH_TonKho.Where(c => c.QRCode == _QRCode).ToList();
                    if (list.Count > 0)
                    {
                        txtSanPham.uText = list[0].ItemNo;
                        txtLot.uText = list[0].Lot;
                        txtLoaibaobi.uText = list[0].PackageCode;
                        txtCayhang.uText = list[0].BinCode;
                        txtChungchi.uText = list[0].Certificate;
                    }
                }
                        Loc(_QRCode);
            }
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            txtMaPallet.uText = gridView_DanhSach.GetFocusedRowCellValue("QRCode").ToString();
            txtSanPham.uText = gridView_DanhSach.GetFocusedRowCellValue("ItemNo").ToString();
            txtLot.uText = gridView_DanhSach.GetFocusedRowCellValue("Lot").ToString();
            txtChungchi.uText = gridView_DanhSach.GetFocusedRowCellValue("Certificate").ToString();
            txtLoaibaobi.uText = gridView_DanhSach.GetFocusedRowCellValue("PackageCode").ToString();
            txtCayhang.uText = gridView_DanhSach.GetFocusedRowCellValue("BinCode").ToString();
        }

        private void Loc(string QR)
        {
            int dem = 0;
            DataTable dt = new DataTable();
            dt.Columns.Add("Exported", typeof(Boolean));
            dt.Columns.Add("QRCode");
            dt.Columns.Add("ItemNo");
            dt.Columns.Add("Lot");
            dt.Columns.Add("PackageCode");
            dt.Columns.Add("BinCode");
            dt.Columns.Add("Certificate");

            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.WH_TonKho.Where(c => c.QRCode == QR && c.Exported == false).ToList();
                if (list.Count > 0)
                {
                    if (gridView_DaChon.RowCount > 0)
                    {
                        dt = (DataTable)grid_DaChon.DataSource;
                    }

                    for (int j = 0; j < gridView_DaChon.DataRowCount; j++)
                    {
                        if (QR == gridView_DaChon.GetRowCellValue(j, "QRCode").ToString())
                        {
                            dem++;
                        }
                    }
                    if (dem == 0)
                    {
                        dt.Rows.Add(true,
                                    list[0].QRCode,
                                    list[0].ItemNo,
                                    list[0].Lot,
                                    list[0].PackageCode,
                                    list[0].BinCode,
                                    list[0].Certificate);
                    }
                    dem = 0;
                    grid_DaChon.DataSource = dt;
                    txtMaPallet.SelectAll();
                }
                else
                {
                    txtMaPallet.SelectAll();
                    XtraMessageBox.Show("Mã QRCode không hợp lệ", "Thông báo");                    
                }
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (gridView_DanhSach.RowCount > 0)
            {
                for (int i = 0; i < gridView_DanhSach.DataRowCount; i++)
                {
                    if (gridView_DanhSach.GetRowCellValue(i, "Exported").ToString() == "True")
                    {
                        Loc(gridView_DanhSach.GetRowCellValue(i, "QRCode").ToString());
                    }
                }
                Tab.SelectedTabPage = Tab_DaChon;
            }
        }

        private void gridView_DaChon_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }
        string Tungay, Denngay;

        private void Search_LS()
        {
            Tungay = Convert.ToDateTime(dtpTuNgay.uValue).ToString("yyyy-MM-dd");
            Denngay = Convert.ToDateTime(dtpDenNgay.uValue).AddDays(1).ToString("yyyy-MM-dd");

            var Thamso = new Dictionary<String, String>() { { "Tungay", Tungay }, { "Denngay", Denngay }, { "WeightNote", txtQRCode.uText }, { "Loai", "KhoaQRCode" } };
            grid_LichSu.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_SuaPhieuCan", Thamso);
            gridView_LichSu.BestFitColumns();
            for (int i = 0; i < gridView_LichSu.Columns.Count; i++)
            {
                gridView_LichSu.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)grid_LichSu.DataSource;
            if (dt != null)
            {
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_KhoaBarCode.repx", dt);
                frm.Show();
            }
        }

        private void gridView_LichSu_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView_DanhSach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView_DanhSach.OptionsSelection.MultiSelect = true;
                gridView_DanhSach.SelectAll();
            }
        }

        private void gridView_DaChon_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView_DaChon.OptionsSelection.MultiSelect = true;
                gridView_DaChon.SelectAll();
            }
        }

        private void gridView_LichSu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView_LichSu.OptionsSelection.MultiSelect = true;
                gridView_LichSu.SelectAll();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search_LS();
        }
    }
}
