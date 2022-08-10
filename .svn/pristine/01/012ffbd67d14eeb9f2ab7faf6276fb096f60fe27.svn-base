using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace BSC_HRM.NET.Luong
{
    public partial class frmXetTangLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmXetTangLuong()
        {
            InitializeComponent();
            clRun.SetValueToControl(this);
            dtg.sKEY = sKEY;
            cnn.clearControl(this);
        }
        BSC_Class.BSCConnection cnn = new BSC_Class.BSCConnection(Program.sConnection);
        clsRun clRun = new clsRun();
        string sKEY = "XETTANGLUONG_CANBO";

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            LoadXetTangLuong();
            SetAllowEdit();
            //if (Properties.Settings.Default.USER_NAME == "Administrator" || Properties.Settings.Default.USER_NAME == "Supervisor")
            //{
            //    btnUpDateHoSo.Enabled = true;
            //}
            //else
            //    btnUpDateHoSo.Enabled = false;
        }
        private void SetAllowEdit()
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
            {
                if (col.FieldName != "Chon" && col.FieldName != "GhiChu")
                {
                    col.OptionsColumn.AllowEdit = false;
                }
            }
        } 
        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            popupMenu1.ShowPopup(MousePosition);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Hashtable Val = new Hashtable();
                Hashtable Cond = new Hashtable();
                DataTable DT = dtg.GetDataSource();                
                cnn.BeginTransaction();
                Cond.Clear();
                Cond.Add("Ngay", dateDenNgay.uDateTime.ToString("MM/dd/yyyy"));
                cnn.DeleteRows(Cond, "NS_XetTangLuong");
                foreach (DataRow r in DT.Rows)
                {
                    Val.Clear();
                    Val.Add("Ngay", dateDenNgay.uDateTime.ToString("MM/dd/yyyy"));
                    Val.Add("NhanSu", r["NhanSu"]);
                    Val.Add("MaChucVu", r["MaChucVu"]);
                    Val.Add("NgachHienTai", r["NgachHienTai"]);
                    Val.Add("BacHienTai", r["BacHienTai"]);
                    Val.Add("HSLuongHienTai", r["HSLuongHienTai"]);
                    Val.Add("ThoiDiemXepLuong", r["ThoiDiemXepLuong"]);
                    Val.Add("NgachTiepTheo", r["NgachTiepTheo"]);
                    Val.Add("BacTiepTheo", r["BacTiepTheo"]);
                    Val.Add("HeSoLuongTiepTheo", r["HeSoLuongTiepTheo"]);
                    Val.Add("ThoiGianTinhNangBacLanSau", r["ThoiGianTinhNangBacLanSau"]);
                    Val.Add("VuotKhung", r["VuotKhung"]);
                    Val.Add("HeSoVuotKhungHienTai", r["HeSoVuotKhungHienTai"]);
                    Val.Add("HeSoVuotKhungTiepTheo", r["HeSoVuotKhungTiepTheo"]);
                    Val.Add("ThoiGianVuotKhungLanSau", r["ThoiGianVuotKhungLanSau"]);
                    Val.Add("OK", r["Chon"]);
                    Val.Add("GhiChu", r["GhiChu"]);
                    cnn.InsertNewRow(Val,"NS_XetTangLuong");
                }
                cnn.EndTransaction();
                XtraMessageBox.Show("Cập nhật thành công", "Xét tăng lương", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadXetTangLuong();
                SetAllowEdit();
                //if (Properties.Settings.Default.USER_NAME == "Administrator" || Properties.Settings.Default.USER_NAME == "Supervisor")
                //{
                //    btnUpDateHoSo.Enabled = true;
                //}
                //else
                //    btnUpDateHoSo.Enabled = false;
            }
            catch(Exception ex)
            {
                cnn.RollbackTransaction();
                XtraMessageBox.Show("Cập nhật không thành công :\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadXetTangLuong()
        {
            try
            {
                string sSQL = cnn.GetSQLString("VIEW_XETTANGLUONG");
                if (!cnn.bComboIsNull(cbxPhongBan))
                {
                    sSQL += " WHERE Ngay='" + Convert.ToDateTime(dateDenNgay.uValue).ToString("MM/dd/yyyy") + "' AND DM_PHONGBAN.MAPHONGBAN=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' Order by Ten";
                }
                else
                {
                    sSQL += " WHERE Ngay='" + Convert.ToDateTime(dateDenNgay.uValue).ToString("MM/dd/yyyy") + "' order By Ten";
                }
                DataTable DT = cnn.DT_DataTable(sSQL);
                dtg.uDataSource = DT;
                dtg.Columns["Chon"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                dtg.Columns["MA"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                dtg.Columns["HoDem"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                dtg.Columns["Ten"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            }
            catch
            { }
        }
        private void dateDenNgay_uEditValueChanged(object sender, EventArgs e)
        {
            LoadXetTangLuong();
            SetAllowEdit();
        }

        private void btnUpDateHoSo_Click(object sender, EventArgs e)
        {
            if (txtSoQuyetDinh.uText.Trim().Length == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập số quyết định!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoQuyetDinh.Focus();
                return;
            }
            if (txtNguoiKy.uText.Trim().Length == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập người ký quyết định !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNguoiKy.Focus();
                return;
            }
            if (dtpNgayKy.uDateTime < dateDenNgay.uDateTime)
            {
                XtraMessageBox.Show("Bạn chưa chọn ngày ký quyết định", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Hashtable Val = new Hashtable();
            Hashtable Cond = new Hashtable();
            DataRow[] row = dtg.GetDataSource().Select("Chon=1");
            if (row.Length == 0)
            {
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc muốn cập nhật hệ số lương vào quá trình lương", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cnn.BeginTransaction();
                try
                {
                    foreach (DataRow r in row)
                    {
                        Cond.Clear();
                        Cond.Add("NhanSu", r["NhanSu"]);
                        Cond.Add("NgayHuongLuong", (bool)r["VuotKhung"] == true ? r["ThoiGianVuotKhungLanSau"] : r["ThoiGianVuotKhungLanSau"]);
                        if (cnn.SelectRows(Cond, "NS_QuaTrinhLuong").Rows.Count > 0)
                        { }
                        else
                        {
                            #region Update NS_QuaTrinhLuong
                            string BacLuongMoi = cnn.sNull2String(r["BacTiepTheo"]);
                            BacLuongMoi = BacLuongMoi.Split(new string[] { "/" }, StringSplitOptions.None)[0].ToString();
                            Val.Clear();
                            Val.Add("NhanSu", r["NhanSu"]);
                            Val.Add("SoQuyetDinh", txtSoQuyetDinh.uText);
                            Val.Add("NguoiKy", txtNguoiKy.uText);
                            Val.Add("NgayKy", dtpNgayKy.uDateTime.ToString("MM/dd/yyyy"));
                            Val.Add("Ngach_CongChuc", r["NgachTiepTheo"]);
                            Val.Add("BacCongChuc", cnn.sNull2Int(BacLuongMoi));
                            Val.Add("HeSoLuong", r["HeSoLuongTiepTheo"]);
                            Val.Add("NgayHuongLuong", (bool)r["VuotKhung"] == true ? r["ThoiGianVuotKhungLanSau"] : r["ThoiGianVuotKhungLanSau"]);
                            Val.Add("NGUOIDUNG1", Properties.Settings.Default.USER_ID);
                            Val.Add("NGAY1", cnn.GetDateServer().ToString("MM/dd/yyyy"));
                            Val.Add("MAY1", System.Net.Dns.GetHostName());
                            Val.Add("PhanTramVuotKhung", r["HeSoVuotKhungTiepTheo"]);
                            ///Val.Add("PhuCapDienThoai", 0);
                            cnn.InsertNewRow(Val, "NS_QuaTrinhLuong");
                            #endregion
                            #region Update NS_NhanSu
                            Val.Clear();
                            Cond.Clear();
                            Cond.Add("NhanSu", r["NhanSu"]);
                            Val.Add("BacCongChuc", cnn.sNull2Int(BacLuongMoi));
                            Val.Add("HeSoLuong", r["HeSoLuongTiepTheo"]);
                            Val.Add("NgayHuongLuong", (bool)r["VuotKhung"] == true ? r["ThoiGianVuotKhungLanSau"] : r["ThoiGianVuotKhungLanSau"]);
                            Val.Add("PhanTramVuotKhung", r["HeSoVuotKhungTiepTheo"]);
                            cnn.UpdateRows(Val, Cond, "NS_NhanSu");
                        #endregion
                        }
                    }
                    cnn.EndTransaction();
                    XtraMessageBox.Show("Cập nhật thành công", "Update hệ số lương vào hồ sơ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    cnn.RollbackTransaction();
                    XtraMessageBox.Show("Cập nhật hồ sơ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void bar_NangBacLuongThuongXuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            DataRow[] Row = DT.Select("Chon=1 And VuotKhung=0");
            DataTable DTTX = DT.Clone();
            foreach (DataRow rr in Row)
            {
                DTTX.ImportRow(rr);               
            }
            BaoCaoTK.frmViewReport frm = new BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\NS_DSNangBacLuongThuongXuyen.repx", DTTX);
            frm.bXoayDiem = true;
            string[] Nam = new string[] { Convert.ToDateTime(dateDenNgay.uValue).Year.ToString() };
            frm.MonHoc = Nam;
            frm.Show();
        }
        private void bar_PhuCapVuotKhung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            DataRow[] Row = DT.Select("Chon=1 And VuotKhung=1");
            DataTable DTTX = DT.Clone();
            foreach (DataRow rr in Row)
            {
                DTTX.ImportRow(rr);
            }
            BaoCaoTK.frmViewReport frm = new BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\NS_BaoCaoPhuCapThamNienVuotKhung.repx", DTTX);
            frm.bXoayDiem = true;
            string[] Nam = new string[] { Convert.ToDateTime(dateDenNgay.uValue).Year.ToString() };
            frm.MonHoc = Nam;
            frm.Show();
        }

        private void bar_KhongDuocNangBac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            DataRow[] Row = DT.Select("Chon=0 And VuotKhung=0");
            DataTable DTTX = DT.Clone();
            foreach (DataRow rr in Row)
            {
                DTTX.ImportRow(rr);
            }
            BaoCaoTK.frmViewReport frm = new BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\NS_DSKhongNangBacLuong.repx", DTTX);
            frm.bXoayDiem = true;
            string[] Nam = new string[] { Convert.ToDateTime(dateDenNgay.uValue).Year.ToString() };
            frm.MonHoc = Nam;
            frm.Show();
        }

        private void frmXetTangLuong_Load(object sender, EventArgs e)
        {
            dateDenNgay.uValue = Convert.ToDateTime("01/"+DateTime.Now.Month + "/" + DateTime.Now.Year);
            //if (Properties.Settings.Default.USER_NAME == "Administrator" || Properties.Settings.Default.USER_NAME == "Supervisor")
            //{
            //    btnUpDateHoSo.Enabled = true;
            //}
            //else
            //    btnUpDateHoSo.Enabled = false;
        }

        private void btnXetTangLuong_Click(object sender, EventArgs e)
        {
            if (dtg.GetDataSource().Rows.Count > 0)
            {
                if (XtraMessageBox.Show("Bạn có chắc muốn làm mới lại danh sách", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string sql = "";
                    sql = cnn.GetSQLString(sKEY);
                    if (!cnn.bComboIsNull(cbxPhongBan))
                    {
                        sql = "Select * from (" + sql + ")A WHERE A.MAPHONGBAN=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ((VuotKhung=1 AND ThoiGianVuotKhungLanSau<='" + Convert.ToDateTime(dateDenNgay.uValue).ToString("MM/dd/yyyy") + "') OR (VuotKhung=0 AND ThoiGianTinhNangBacLanSau<='" + Convert.ToDateTime(dateDenNgay.uValue).ToString("MM/dd/yyyy") + "')) Order by Ten";
                    }
                    else
                    {
                        sql = "Select * from (" + sql + ")A WHERE (VuotKhung=1 AND ThoiGianVuotKhungLanSau<='" + Convert.ToDateTime(dateDenNgay.uValue).ToString("MM/dd/yyyy") + "') OR (VuotKhung=0 AND ThoiGianTinhNangBacLanSau<='" + Convert.ToDateTime(dateDenNgay.uValue).ToString("MM/dd/yyyy") + "') Order By Ten";
                    }
                    dtg.uDataSource = cnn.SelectRows(sql);
                    dtg.Columns["Chon"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                    dtg.Columns["MA"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                    dtg.Columns["HoDem"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                    dtg.Columns["Ten"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                    SetAllowEdit();
                    //btnUpDateHoSo.Enabled = false;
                }
            }
            else
            {
                string sql = "";
                sql = cnn.GetSQLString(sKEY);
                if (!cnn.bComboIsNull(cbxPhongBan))
                {
                    sql = "Select * from (" + sql + ")A WHERE A.MAPHONGBAN=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ((VuotKhung=1 AND ThoiGianVuotKhungLanSau<='" + Convert.ToDateTime(dateDenNgay.uValue).ToString("MM/dd/yyyy") + "') OR (VuotKhung=0 AND ThoiGianTinhNangBacLanSau<='" + Convert.ToDateTime(dateDenNgay.uValue).ToString("MM/dd/yyyy") + "'))";
                }
                else
                {
                    sql = "Select * from (" + sql + ")A WHERE (VuotKhung=1 AND ThoiGianVuotKhungLanSau<='" + Convert.ToDateTime(dateDenNgay.uValue).ToString("MM/dd/yyyy") + "') OR (VuotKhung=0 AND ThoiGianTinhNangBacLanSau<='" + Convert.ToDateTime(dateDenNgay.uValue).ToString("MM/dd/yyyy") + "')";
                }
                dtg.uDataSource = cnn.SelectRows(sql);
                dtg.Columns["Chon"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                dtg.Columns["MA"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                dtg.Columns["HoDem"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                dtg.Columns["Ten"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                SetAllowEdit();
                //btnUpDateHoSo.Enabled = false;
            }
        }

        private void btnDanhSachTangLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            BaoCaoTK.frmViewReport frm = new BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\NS_DSTangLuong.repx", DT);
            frm.bXoayDiem = true;
            string[] Nam = new string[] { Convert.ToDateTime(dateDenNgay.uValue).Year.ToString() };
            frm.MonHoc = Nam;
            frm.Show();
        }
    }
}