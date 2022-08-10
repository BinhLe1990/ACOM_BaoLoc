using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace DELFI_WHM.NET.NhanSu
{
    public partial class frmHoSoNhanSu : DevExpress.XtraEditors.XtraForm
    {
        public frmHoSoNhanSu()
        {
            InitializeComponent();
            clRun.SetValueToControl(this);
            dtg.sKEY = sKEY;
        }

        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clRun = new clsRun();
        string sKEY = "HOSONHANSU";
        int NhanSuID = 0;

        public string TenVietTat(string HoDem, string Ten)
        {
            string KetQua = "";
            char[] s = HoDem.ToCharArray();
            if (s.Length == 0)
            {
                return "";
            }
            KetQua = s[0] + ".";
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    try
                    {
                        KetQua += s[i + 1] + ".";
                    }
                    catch { }
                }
            }
            KetQua = KetQua.ToUpper();
            KetQua = KetQua.Substring(0, KetQua.Length - 1);
            KetQua += " " + Ten;
            return KetQua;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dtg.RowCount == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để xóa!");
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa thông tin nhân sự này khỏi cơ sở dữ liệu?\nCHÚ Ý: Dữ liệu đã xóa sẽ không thể khôi phục lại được", "Xóa thông tin Nhân sự", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            int ID = cnn.sNull2Int(dtg.CurRow["NhanSu"]);
            cnn.ExecuteNonQuery("UPDATE NS_NhanSu Set Del = 1 where NhanSu = " + ID);
            XtraMessageBox.Show("Đã xóa thành công!");
            Hashtable Val = new Hashtable();
            cnn.GetValue(pnMain, ref Val);
            DataTable dt = cnn.SearchRows(Val, cnn.GetSQLString(sKEY));
            dtg.uDataSource = dt;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            cnn.clearControl(pnMain);
            NhanSuID = 0;
            clRun.SetPermit(this);
        }
        private string MaGiaoVien(string DonVi, string Ten)
        {
            if (DonVi == "")
                return "";
            if (Ten == "")
                return "";
            string KQ = DonVi.ToUpper();
            Ten = clRun.LoaiBoDauTiengViet(Ten).ToUpper();
            if (Ten.Length > 3)
                Ten = Ten.Substring(0, 3);
            else if (Ten.Length == 2)
                Ten = Ten + Ten.Substring(Ten.Length - 1, 1);
            else if (Ten.Length == 1)
                Ten = Ten + Ten + Ten;
            KQ += Ten;
            if (NhanSuID != 0)
            {
                string IDOld = cnn.SelectRows("select MaGiaoVien from EM_HS_GiaoVien where GiaoVien = " + NhanSuID).Rows[0][0].ToString();
                if (KQ == IDOld.Substring(0, 4))
                    return IDOld;
            }
            string sql = "select top 1 MaGiaoVien from EM_HS_GiaoVien where Left(MaGiaoVien, 4) = N'" + KQ + "' order by MaGiaoVien Desc";
            DataTable dt = cnn.SelectRows(sql);
            if (dt.Rows.Count == 0)
                return KQ + "01";
            else
            {
                int STT = cnn.sNull2Int(dt.Rows[0][0].ToString().Substring(dt.Rows[0][0].ToString().Length - 2, 2)) + 1;
                return KQ + STT.ToString().PadLeft(2, '0');
            }
        }

        private void btnSuaHoSo_Click(object sender, EventArgs e)
        {
            try
            {
                NhanSuID = cnn.sNull2Int(dtg.CurRow["NhanSu"]);
            }
            catch
            {
                NhanSuID = 0;
            }
            if (NhanSuID == 0)
                return;
            string sql = "select * from NS_NhanSu where NhanSu = " + NhanSuID;
            DataRow r = cnn.SelectRows(sql).Rows[0];
            cnn.DR_DataReader(this, r);
            radioGroup1.EditValue = cnn.sNull2Int(r["GioiTinh"]);
            cboBacCongChuc.uEditValue = cnn.sNull2Int(r["BacCongChuc"]);
            picHinhAnh.Image = clRun.GetAnhSV(dtg.CurRow["Ma"].ToString()).Image;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            chkGiamTruGiaCanh.Tag = "";
            chkTuQuyetToanThueNam.Tag = "";
            chkPhuCapUuDai.Tag = "";
            //chkPhuCapUuDai.Tag = "";
            chkPhuCapChiTieuNoiBo.Tag = "";
            chkPhuCapGioPhuTroi.Tag = "";
            chkIsKhongDongBH.Tag = "";
            ckPhiCongDoanHDKhoan.Tag = "";
            Hashtable Val = new Hashtable();
            cnn.GetValue(pnMain, ref Val);
            foreach (Control ctrl in panelControl1.Controls)
            {
                if (ctrl is DevExpress.XtraEditors.CheckEdit)
                {
                    DevExpress.XtraEditors.CheckEdit chk = (DevExpress.XtraEditors.CheckEdit)ctrl;
                    if (!chk.Checked)
                    {
                        Val.Remove(chk.Tag.ToString().Substring(2));
                    }
                }
            }
            Val.Remove(ckHDKhoanBienChe.Tag.ToString().Substring(2));
            DataTable dt = cnn.SearchRows(Val, cnn.GetSQLString(sKEY), DELFI_WHM.NET.DELFI_Class.DELFIConnection.BSCLoadType.UseLoadProcess);
            dtg.uDataSource = dt;
            chkGiamTruGiaCanh.Tag = "..IsGiamTruGiaCanh";
            chkTuQuyetToanThueNam.Tag = "..IsTuQuyetToanThueNam";
            chkPhuCapUuDai.Tag = "..PhuCapUuDai";
            //chkPhuCapUuDai.Tag = "..PhuCapTrachNhiem";
            chkPhuCapChiTieuNoiBo.Tag = "..PhuCapChiTieuNoiBo";
            chkPhuCapGioPhuTroi.Tag = "..IsPhuCapGioPhuTroi";
            chkIsKhongDongBH.Tag = "..IsKhongDongTienBH";
            ckPhiCongDoanHDKhoan.Tag = "..isPhiCongDoanHDKhoan";
            txtLuongKhoanCB.Tag = "..LuongKhoanCB";
        }
        private bool Check_Cond()
        {
            //if (txtMaSo.uText.Trim() == "")
            //{
            //    XtraMessageBox.Show("Bạn chưa nhập mã số nhân sự", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtMaSo.Focus();
            //    return false;
            //}
            if (txtHoDem.uText.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập họ tên nhân sự", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoDem.Focus();
                return false;
            }
            if (txtTen.uText.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập họ tên nhân sự", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return false;
            }
            if (txtSoCMND.uText.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập số CMND", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoCMND.Focus();
                return false;
            }
            return true;
        }

        private void btnLuuHoSo_Click(object sender, EventArgs e)
        {

            if (!Check_Cond())
                return;
            if (NhanSuID == 0)
            {
                if (cnn.DT_DataTable("Select 1 from NS_NHANSU where Ma=N'" + txtMaSo.uText + "' And Del=0").Rows.Count > 0)
                {
                    XtraMessageBox.Show("Mã nhân sự này đã được sử dụng", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSo.uText = "";
                    txtMaSo.Focus();
                    return;
                }
            }
            else
            {
                int iTonTai = cnn.sNull2Int(cnn.SQL_ExecuteScalar("Select 1 from NS_NhanSu where Ma=N'" + txtMaSo.uText + "' AND NhanSu<>" + NhanSuID));
                if (iTonTai > 0)
                {
                    XtraMessageBox.Show("Mã nhân sự này đã được sử dụng", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSo.uText = "";
                    txtMaSo.Focus();
                    return;
                }
            }
            if (cnn.bComboIsNull(cboTinhTrangHoSo))
            {
                //XtraMessageBox.Show("Bạn chưa chọn tình trạng!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //cboTinhTrangHoSo.Focus();
                //return;
            }
            bool bExits = false;
            cnn.BeginTransaction();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string sSQL = cnn.UpdateDataSQLComm(pnMain, "NS_NHANSU", "NhanSu = " + NhanSuID, ref bExits, true);
                cnn.ExecuteNonQuery(sSQL);
                if (!bExits)
                {
                    NhanSuID = cnn.sNull2Int(cnn.SQL_ExecuteScalar("SELECT @@IDENTITY"));
                }
                cnn.EndTransaction();
                this.Cursor = Cursors.Default;
                XtraMessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clRun.SetPermit(this);
            }
            catch (Exception ex)
            {
                cnn.RollbackTransaction();
                this.Cursor = Cursors.Default;
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtg_uDataSourceChanged(object sender, EventArgs e)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
            {
                if (col.Name != dtg.Columns["Chon"].Name)
                    col.OptionsColumn.AllowEdit = false;
            }
        }

        private void dtg_uFocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //if (radioGroup3.EditValue.ToString() != "1")
            //    return;
            //btnSuaHoSo_Click(btnSuaHoSo, new EventArgs());
        }

        private void frmHoSoGiaoVien_Load(object sender, EventArgs e)
        {
            cnn.clearControl(this);
            NhanSuID = 0;
            //chkDangVien.CheckState = CheckState.Indeterminate;
        }

        private void cbxDonVi_uEditValueChanged(object sender, EventArgs e)
        {
            //txtTenVietTat.uText = TenVietTat(txtHoDem.uText, txtTen.uText);
        }

        private void btnInHoSo_Click(object sender, EventArgs e)
        {
            DataTable dt = dtg.GetDataSource();
            if (dt.Rows.Count == 0)
                return;
            DataRow[] dr = dt.Select("Chon = 1");
            if (dr.Length == 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn nhân sự cần in hồ sơ!");
                return;
            }
            string ID = "";
            foreach (DataRow r in dr)
            {
                ID += "'" + r["NhanSu"] + "',";
            }
            ID = ID.Substring(0, ID.Length - 1);
            DataTable dtRep = cnn.SelectRows("select * from (" + cnn.GetSQLString("HOSONHANSU") + ")A where NhanSu IN(" + ID + ")");
            BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\NS_HoSoNhanSu.repx", dtRep);
            frm.Show();
        }
        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            DataTable dt = dtg.GetDataSource();
            if (dt.Rows.Count == 0)
                return;
            BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\NS_DanhSachNhanSu.repx", dt);
            frm.Show();
        }

        private void picHinhAnh_DoubleClick(object sender, EventArgs e)
        {
            picHinhAnh.LoadImage();
        }
        private void dtg_uDoubleClick(object sender, EventArgs e)
        {
            try
            {
                NhanSuID = cnn.sNull2Int(dtg.CurRow["NhanSu"]);
            }
            catch
            {
                NhanSuID = 0;
            }
            if (NhanSuID == 0)
                return;
            string sql = "select * from NS_NhanSu where NhanSu = " + NhanSuID;
            DataRow r = cnn.SelectRows(sql).Rows[0];
            cnn.DR_DataReader(this, r);
            radioGroup1.EditValue = cnn.sNull2Int(r["GioiTinh"]);
            cboBacCongChuc.uEditValue = cnn.sNull2Int(r["BacCongChuc"]);
            picHinhAnh.Image = clRun.GetAnhSV(dtg.CurRow["Ma"].ToString()).Image;
        }

        private void cboTinh_uEditValueChanged(object sender, EventArgs e)
        {
            string sSQL = "SELECT * FROM dbo.DM_QuanHuyen WHERE MaTinhThanhPho='" + cnn.sNull2String(cboTinh.uEditValue) + "'";
            DataTable DT = cnn.DT_DataTable(sSQL);
            cboQuanHuyen.uDataSource = DT;
            cboQuanHuyen.sField = "MaQuanHuyen,TenQuanHuyen";
            cboQuanHuyen.sColumnCaption = "Mã quận huyện,Tên quận huyện";
        }

        private void btnQuaTrinh_Click(object sender, EventArgs e)
        {
            popupMenu1.ShowPopup(MousePosition);
        }

        private void btnQuaTrinhLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (NhanSuID == 0) return;
            frmQuaTrinhLuong frm = new frmQuaTrinhLuong();
            frm.NhanSuID = NhanSuID;
            frm.ShowDialog();
        }
        private void btnQuaTrinhChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (NhanSuID == 0) return;
            frmQuaTrinhChucVu frm = new frmQuaTrinhChucVu();
            frm.NhanSuID = NhanSuID;
            frm.ShowDialog();

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (NhanSuID == 0) return;
            frmQuaTrinhCongTac frm = new frmQuaTrinhCongTac();
            frm.iNhanSu = NhanSuID;
            frm.ShowDialog();
        }

        private void btnQuaTrinhKhenThuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (NhanSuID == 0) return;
            frmQuaTrinhKhenThuong frm = new frmQuaTrinhKhenThuong();
            frm.iNhanSu = NhanSuID;
            frm.ShowDialog();
        }

        private void btnQuaTrinhKyLuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (NhanSuID == 0) return;
            frmQuaTrinhKyLuat frm = new frmQuaTrinhKyLuat();
            frm.iNhanSu = NhanSuID;
            frm.ShowDialog();
        }

        private void btnQuaTrinhDaoTao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (NhanSuID == 0) return;
            frmQuaTrinhDaoTao frm = new frmQuaTrinhDaoTao();
            frm.iNhanSu = NhanSuID;
            frm.ShowDialog();
        }

        private void btnChuyenCongTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (NhanSuID == 0) return;
            frmQuaTrinhChuyenCongTac frm = new frmQuaTrinhChuyenCongTac();
            frm.iNhanSu = NhanSuID;
            frm.ShowDialog();
        }

        private void btnTaiNanLaoDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (NhanSuID == 0) return;
            frmTaiNanLaoDong frm = new frmTaiNanLaoDong();
            frm.iNhanSu = NhanSuID;
            frm.ShowDialog();
        }

        private void btnVanBang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (NhanSuID == 0) return;
            frmVanBangChungChi frm = new frmVanBangChungChi();
            frm.iNhanSu = NhanSuID;
            frm.ShowDialog();
        }
        private void cboNgachCongChuc_uEditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable DT = cnn.DT_DataTable("SELECT * FROM  dbo.DM_BACLUONG WHERE NGACH_CONGCHUC=N'" + cnn.sNull2String(cboNgachCongChuc.uEditValue) + "'");
                cboBacCongChuc.uDataSource = DT;
            }
            catch
            { }
        }

        private void cboBacCongChuc_uEditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable DT = cnn.DT_DataTable("SELECT * FROM  dbo.DM_BACLUONG WHERE MABACLUONG=" + cnn.sNull2Int(cboBacCongChuc.uEditValue) + " And Ngach_CongChuc='" + cboNgachCongChuc.uEditValue + "'");
                txtHeSoLuong.uText = cnn.sNull2String(DT.Rows[0]["HeSo"]);
            }
            catch
            { }
        }

        private void cbxChucVu_uEditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable DT = cnn.DT_DataTable("SELECT ISNULL(HeSoChucVu,0) HeSoChucVu FROM dbo.DM_ChucVu WHERE MaChucVu = N'" + cbxChucVu.uEditValue.ToString() + "'");
                txtHeSoChucVu.uText = cnn.sNull2String(DT.Rows[0]["HeSoChucVu"]);
            }
            catch
            { }
        }

        private void cboPhongBan_uEditValueChanged(object sender, EventArgs e)
        {
            string sSQL = "SELECT MADONVI,TENDONVI from DM_DONVI WHERE MAPHONGBAN=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "'";
            DataTable DT = cnn.DT_DataTable(sSQL);
            cboDonViCongTac.uDataSource = DT;
        }

        private void gLuongKhoan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTangThamNienGD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (NhanSuID == 0) return;
            frmQuaTrinhTangThamNienGD frm = new frmQuaTrinhTangThamNienGD();
            frm.iNhanSu = NhanSuID;
            frm.ShowDialog();
        }        
    }
}