using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace BSC_HRM.NET.NhanSu
{
    public partial class frmQuaTrinhLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmQuaTrinhLuong()
        {
            InitializeComponent();
            clRun.SetValueToControl(this);
            dtg.sKEY = sKEY;
        }

        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clRun = new clsRun();
        string sKEY = "QuaTrinhLuong";
        public int NhanSuID = 0;
        private int iQuaTrinhLuong = 0;      

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa bỏ bậc lương của nhân viên này?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = cnn.SQL_ExecuteNonQuery("Delete NS_QuaTrinhLuong where QuaTrinhLuong=" + iQuaTrinhLuong);
                if (i > 0)
                {
                    XtraMessageBox.Show("Đã xóa thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cnn.clearControl(panelThongTin);
                    LoadQuaTrinhLuong();
                }
                else
                {
                    XtraMessageBox.Show("Xóa thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }           
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            cnn.clearControl(panelThongTin);
            iQuaTrinhLuong = 0;            
            clRun.SetPermit(this);

        }  
        private void btnLuuHoSo_Click(object sender, EventArgs e)
        {
            if (txtSoQuyetDinh.uText.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập số quyết định", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoQuyetDinh.Focus();
                return;
            }
            if (cnn.bComboIsNull(cboNgachCongChuc))
            {
                XtraMessageBox.Show("Bạn chưa chọn ngạch công chức", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.bComboIsNull(cboBacCongChuc))
            {
                XtraMessageBox.Show("Bạn chưa chọn bậc công chức", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cnn.BeginTransaction();
            bool bExist = false;
            TextBox txt = new TextBox();
            txt.Text = NhanSuID.ToString();
            txt.Tag = "..NhanSu";
            panelThongTin.Controls.Add(txt);
            string sSQL = cnn.UpdateDataSQLComm(panelThongTin, "NS_QuaTrinhLuong", "QuaTrinhLuong=" + iQuaTrinhLuong, ref bExist, true);
            CapNhatXetTangLuong();
            CapNhatLuong();
            panelThongTin.Controls.Remove(txt);
            int i = cnn.SQL_ExecuteNonQuery(sSQL);
            if (i > 0)
            {
                if (!bExist)
                {
                    iQuaTrinhLuong = cnn.sNull2Int(cnn.SQL_ExecuteScalar("Select MAX(QuaTrinhLuong) from NS_QuaTrinhLuong"));
                }
                XtraMessageBox.Show("Cập nhật thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnn.EndTransaction();
                LoadQuaTrinhLuong();
            }
            else
            {
                XtraMessageBox.Show("Cập nhật thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnn.RollbackTransaction();
            }            
        }

        private void CapNhatXetTangLuong()
        {
            cnn.DeleteRows("DELETE FROM dbo.NS_XetTangLuong WHERE NhanSu=" + NhanSuID);
            string sWhere = "NhanSu=" + NhanSuID;
            DataTable DT = cnn.DT_DataTable(cnn.GetSQLString("THONGTINTHAYDOILUONG").Replace("1 = 0", sWhere));
            DataRow r = DT.Rows[0];
            Hashtable Val = new Hashtable();
            Val.Add("Ngay", dtpNgayKy.uValue);
            Val.Add("NhanSu", r["NhanSu"]);
            Val.Add("MaChucVu", r["MaChucVu"]);
            Val.Add("NgachHienTai", r["NgachHienTai"]);
            Val.Add("BacHienTai", r["BacHienTai"]);
            Val.Add("HSLuongHienTai", r["HSLuongHienTai"]);
            Val.Add("ThoiDiemXepLuong", r["ThoiDiemXepLuong"]);
            Val.Add("NgachTiepTheo", cnn.sNull2String(cboNgachCongChuc.uEditValue));
            Val.Add("BacTiepTheo", cnn.sNull2String(cboBacCongChuc.uEditValue));
            Val.Add("HeSoLuongTiepTheo", txtHeSoLuong.uText);
            Val.Add("ThoiGianTinhNangBacLanSau", r["ThoiGianTinhNangBacLanSau"]);
            Val.Add("VuotKhung", r["VuotKhung"]);
            Val.Add("HeSoVuotKhungHienTai", cnn.sNull2Int(r["HeSoVuotKhungHienTai"]));
            Val.Add("HeSoVuotKhungTiepTheo", cnn.sNull2Int(txtPhanTramVK.uText));
            Val.Add("ThoiGianVuotKhungLanSau", r["ThoiGianVuotKhungLanSau"]);
            Val.Add("OK", true);
            Val.Add("GhiChu", r["GhiChu"]);
            Val.Add("IsTangLuongTruocThoiHan", true);
            cnn.InsertNewRow(Val, "NS_XetTangLuong");
        }

        private void CapNhatLuong()
        {
            Hashtable Val = new Hashtable();
            Val.Add("Ngach_CongChuc", cboNgachCongChuc.uEditValue);
            Val.Add("BacCongChuc", cboBacCongChuc.uEditValue);
            Val.Add("NgayHuongLuong", dtpNgayHuong.uValue);
            Val.Add("HeSoLuong", txtHeSoLuong.uText);
            Val.Add("LuongHDKhoan", txtLuongKhoan.uText);
            Val.Add("PhanTramVuotKhung", txtPhanTramVK.uText);
            Val.Add("PhanTramThamNienGD", txtPhanTramThamNienGD.uText);
            Val.Add("HeSoPhuCapHCCB", txtHeSoPhuCapHCCB.uText);
            Val.Add("HeSoPhuCapThemGio", txtHeSoPhuCapThemGio.uText);
            Val.Add("IsGiamTruGiaCanh", chkGiamTruGiaCanh.Checked);
            Val.Add("IsTuQuyetToanThueNam", chkTuQuyetToanThueNam.Checked);
            Val.Add("PhuCapUuDai", chkPhuCapUuDai.Checked);
            Val.Add("PhuCapTrachNhiem", chkPhuCapTrachNhiem.Checked);
            Val.Add("PhuCapChiTieuNoiBo", chkPhuCapChiTieuNoiBo.Checked);
            Val.Add("IsPhuCapGioPhuTroi", chkPhuCapGioPhuTroi.Checked);
            Hashtable Cond = new Hashtable();
            Cond.Add("NHANSU", NhanSuID);
            cnn.UpdateRows(Val, Cond, "NS_NhanSu");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmQuaTrinhLuong_Load(object sender, EventArgs e)
        {
            uNhanSu1.LoadHS(NhanSuID);
            cnn.DR_DataReader(panelThongTin, cnn.DT_DataTable("SELECT Ngach_CongChuc,BacCongChuc,HeSoLuong,LuongHDKhoan AS LuongKhoan,NgayHuongLuong,PhanTramVuotKhung,PhanTramThamNienGD,HeSoPhuCapHCCB,HeSoPhuCapThemGio,IsGiamTruGiaCanh,IsTuQuyetToanThueNam,PhuCapUuDai,PhuCapTrachNhiem,PhuCapChiTieuNoiBo,IsPhuCapGioPhuTroi,CONVERT(BIT,1)IsTangLuongTruocThoiHan, CONVERT(BIT,0)PhuCapGiaoDuc,''NgayKy,''NguoiKy,''SoQuyetDinh FROM dbo.NS_NHANSU WHERE NHANSU=" + NhanSuID).Rows[0]);
            LoadQuaTrinhLuong();
        }

        private void LoadQuaTrinhLuong()
        {
            string sSQL = cnn.GetSQLString("QuaTrinhLuong");
            sSQL = "Select * from (" + sSQL + ")A where NhanSu=" + NhanSuID +" order by QuaTrinhLuong DESC";
            dtg.uDataSource = cnn.DT_DataTable(sSQL);
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
                DataTable DT = cnn.DT_DataTable("SELECT * FROM  dbo.DM_BACLUONG WHERE MABACLUONG=" + cnn.sNull2Int(cboBacCongChuc.uEditValue) +" And Ngach_CongChuc='"+cboNgachCongChuc.uEditValue+"'");
                txtHeSoLuong.uText = cnn.sNull2String(DT.Rows[0]["HeSo"]);
            }
            catch
            { }
        }

        private void dtg_uDoubleClick(object sender, EventArgs e)
        {
            try
            {
                iQuaTrinhLuong = cnn.sNull2Int(dtg.CurRow["QuaTrinhLuong"]);
            }
            catch
            {
                iQuaTrinhLuong = 0;
            }
            if (iQuaTrinhLuong == 0) return;
            DataRow r = cnn.DT_DataTable("Select * from NS_QuaTrinhLuong where QuaTrinhLuong=" + iQuaTrinhLuong).Rows[0];
            cnn.DR_DataReader(panelThongTin, r);
            cboBacCongChuc.uEditValue = cnn.sNull2Int(r["BacCongChuc"]);
        } 
    }
}