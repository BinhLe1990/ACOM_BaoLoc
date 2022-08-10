using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BSC_HRM.NET.Luong
{
    public partial class frmTruyThu : DevExpress.XtraEditors.XtraForm
    {
        public frmTruyThu()
        {
            InitializeComponent();
            clsrun.SetValueToControl(this);
            dtg.sKEY = sKEY;
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsrun = new clsRun();
        string sKEY = "TRUYTHUNHAPKHAC";

        private void frmTruyThu_Load(object sender, EventArgs e)
        {
            txtThang.uValue = DateTime.Now.Month;
            txtNam.uValue = DateTime.Now.Year;
        }
        int iNhanSu = 0;
        int iThuNhapKhac = 0;

        private void uNhanSu1_Click(object sender, EventArgs e)
        {
            iNhanSu = uNhanSu1.iNhanSuID;
            txtHeSoLuong.uText = cnn.sNull2String(cnn.sNull2Number(cnn.SQL_ExecuteScalar("Select HeSoLuong from NS_NhanSu where NhanSu=" + iNhanSu)));
        }
        
        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            string sSQL = cnn.GetSQLString(sKEY);
            try
            {
                iNhanSu = uNhanSu1.iNhanSuID;
            }
            catch { iNhanSu = 0; }
            string sCond = " NS_TruyThuKhac.Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND NS_TruyThuKhac.Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND ";
            if (iNhanSu > 0)
                sCond += "NS_TruyThuKhac.NhanSu=" + iNhanSu + " AND ";
            if (!cnn.bComboIsNull(cbxLoaiTruyThu))
                sCond += "NS_TruyThuKhac.MaTruyThuKhac=N'" + cnn.sNull2String(cbxLoaiTruyThu.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxCoSo))
                sCond += "NS_NhanSu.CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxPhanHe))
                sCond += "NS_NhanSu.PHANHE=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxPhongBan))
                sCond += "NS_NhanSu.PhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
            sCond = sCond.Substring(0, sCond.Length - 4);
            sSQL = sSQL.Replace("1 = 0", sCond);
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = DT;
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
            {
                if (col.FieldName != "Chon")
                    col.OptionsColumn.AllowEdit = false;
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            iNhanSu = 0;
            iThuNhapKhac = 0;
            txtNoiDung.uText = "";
            txtLuongThaiSan.uText = "";
            txtTroCapThaiSan.uText = "";
            txtNgayCong.uText = "";
            txtHeSo.uText = "";
            txtSoThang.uText = "";
            txtMucPhuCap.uText = "";
            txtThanhTien.uText = "";
            txtMucChiHeSo.uText = "";
            txtBHXH.uText = txtBHXH_Truong.uText = "";
            txtBHTN.uText = txtBHTN_Truong.uText = "";
            txtBHYT.uText = txtBHYT_Truong.uText = "";
            txtKPCD.uText = txtKPCD_Truong.uText = "";
            txtTyLe.uText = "";
            txtThucLanh.uText = "";
            txtHeSoLuong.uText = "";
            cbxCoSo.uEditValue = "";
            cbxPhanHe.uEditValue = "";
            cbxPhongBan.uEditValue = "";
            //cbxLoaiTruyThu.uEditValue = "";
            cnn.clearControl(uNhanSu1);
            uNhanSu1.iNhanSuID = 0;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (iNhanSu == 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn nhân sự cần thực hiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.bComboIsNull(cbxLoaiTruyThu))
            {
                XtraMessageBox.Show("Bạn chưa chọn loại thu nhập khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool bExist = false;
            cnn.BeginTransaction();
            try
            {
                TextBox txt = new TextBox();
                txt.Text = iNhanSu.ToString();
                txt.Tag = "..NhanSu";
                panelControl1.Controls.Add(txt);
                string sSQL = cnn.UpdateDataSQLComm(panelControl1, "NS_TruyThuKhac", "TruyThuKhac=" + iThuNhapKhac, ref bExist, true);
                panelControl1.Controls.Remove(txt);
                cnn.SQL_ExecuteNonQuery(sSQL);
                if (!bExist)
                {
                    iThuNhapKhac = cnn.sNull2Int(cnn.SQL_ExecuteScalar("SELECT @@IDENTITY"));
                }
                cnn.EndTransaction();
                btnThemMoi_Click(null, null);
                btnLocDuLieu_Click(null, null);
            }
            catch (Exception ex)
            {
                cnn.RollbackTransaction();
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            popupMenu1.ShowPopup(MousePosition);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa phiếu thu nhập khác này không?\nCHÚ Ý: Dữ liệu đã xóa sẽ không thể khôi phục lại được", "Xóa phiếu thu nhập khác", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            try
            {
                DataTable DT = dtg.GetDataSource();
                if (DT.Rows.Count <= 0)
                    return;
                else
                {
                    DataRow delete = dtg.CurRow;
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                        if (DT.Rows[i]["TruyThuKhac"].ToString().ToUpper().Equals(delete["TruyThuKhac"].ToString().ToUpper()))
                        {
                            bool SQL = cnn.DeleteRows("DELETE dbo.NS_TruyThuKhac WHERE TruyThuKhac=" + cnn.sNull2Number(DT.Rows[i]["TruyThuKhac"].ToString()));
                            if (SQL == true)
                            {
                                XtraMessageBox.Show("Đã xóa thành công!");
                                //cnn.clearControl(this);
                                break;
                            }

                        }
                    }
                    btnLocDuLieu_Click(sender, e);

                }

            }
            catch
            { XtraMessageBox.Show("Xóa thất bại", "Vui lòng kiểm tra lại"); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxLoaiTruyThu_uEditValueChanged(object sender, EventArgs e)
        {
            if (cnn.sNull2String(cbxLoaiTruyThu.uEditValue) == "01") //Ngoài giờ
            {
                txtNoiDung.bIsReadOnly = false;
                txtLuongThaiSan.bIsReadOnly = true;
                txtLuongThaiSan.uText = "0";
                txtTroCapThaiSan.bIsReadOnly = true;
                txtTroCapThaiSan.uText = "0";
                txtHeSoLuong.bIsReadOnly = true;
                //txtHeSoLuong.uText = "0";
                txtNgayCong.bIsReadOnly = true;
                txtNgayCong.uText = "0";
                txtHeSo.bIsReadOnly = true;
                txtHeSo.uText = "0";
                txtSoThang.bIsReadOnly = true;
                txtSoThang.uText = "0";
                txtMucPhuCap.bIsReadOnly = true;
                txtMucPhuCap.uText = "0";
                txtThanhTien.bIsReadOnly = true;
                txtThanhTien.uText = "0";
                txtMucChiHeSo.bIsReadOnly = true;
                txtMucChiHeSo.uText = "0";
                txtBHXH.bIsReadOnly = txtBHXH_Truong.bIsReadOnly = true;
                txtBHXH.uText = txtBHXH_Truong.uText = "0";
                txtBHYT.bIsReadOnly = txtBHYT_Truong.bIsReadOnly = true;
                txtBHYT.uText=txtBHYT_Truong.uText = "0";
                txtBHTN.bIsReadOnly = txtBHTN_Truong.bIsReadOnly = true;
                txtBHTN.uText = txtBHTN_Truong.uText = "0";
                txtKPCD.bIsReadOnly = txtKPCD_Truong.bIsReadOnly = true;
                txtKPCD.uText = txtKPCD_Truong.uText = "0";
                txtTyLe.bIsReadOnly = true;
                txtTyLe.uText = "0";
                txtThucLanh.bIsReadOnly = false;
            }
            else if (cnn.sNull2String(cbxLoaiTruyThu.uEditValue) == "02")//Phúc lợi HD và Thai sản
            {
                txtNoiDung.bIsReadOnly = false;
                txtLuongThaiSan.bIsReadOnly = false;
                //txtLuongThaiSan.uText = "0";
                txtTroCapThaiSan.bIsReadOnly = false;
                //txtTroCapThaiSan.uText = "0";
                txtHeSoLuong.bIsReadOnly = true;
                //txtHeSoLuong.uText = "0";
                txtNgayCong.bIsReadOnly = true;
                txtNgayCong.uText = "0";
                txtHeSo.bIsReadOnly = true;
                txtHeSo.uText = "0";
                txtSoThang.bIsReadOnly = true;
                txtSoThang.uText = "0";
                txtMucPhuCap.bIsReadOnly = true;
                txtMucPhuCap.uText = "0";
                txtThanhTien.bIsReadOnly = true;
                txtThanhTien.uText = "0";
                txtMucChiHeSo.bIsReadOnly = true;
                txtMucChiHeSo.uText = "0";
                txtBHXH.bIsReadOnly = txtBHXH_Truong.bIsReadOnly = true;
                txtBHXH.uText = txtBHXH_Truong.uText = "0";
                txtBHYT.bIsReadOnly = txtBHYT_Truong.bIsReadOnly = true;
                txtBHYT.uText = txtBHYT_Truong.uText = "0";
                txtBHTN.bIsReadOnly = txtBHTN_Truong.bIsReadOnly = true;
                txtBHTN.uText = txtBHTN_Truong.uText = "0";
                txtKPCD.bIsReadOnly = txtKPCD_Truong.bIsReadOnly = true;
                txtKPCD.uText = txtKPCD_Truong.uText = "0";
                txtTyLe.bIsReadOnly = true;
                txtTyLe.uText = "0";
                txtThucLanh.bIsReadOnly = false;
            }
            else if (cnn.sNull2String(cbxLoaiTruyThu.uEditValue) == "03")//Bổ sung phúc lợi
            {
                txtNoiDung.bIsReadOnly = false;
                txtLuongThaiSan.bIsReadOnly = true;
                txtLuongThaiSan.uText = "0";
                txtTroCapThaiSan.bIsReadOnly = true;
                txtTroCapThaiSan.uText = "0";
                txtHeSoLuong.bIsReadOnly = true;
                //txtHeSoLuong.uText = "0";
                txtNgayCong.bIsReadOnly = true;
                txtNgayCong.uText = "0";
                txtHeSo.bIsReadOnly = true;
                txtHeSo.uText = "0";
                txtSoThang.bIsReadOnly = true;
                txtSoThang.uText = "0";
                txtMucPhuCap.bIsReadOnly = true;
                txtMucPhuCap.uText = "0";
                txtThanhTien.bIsReadOnly = true;
                txtThanhTien.uText = "0";
                txtMucChiHeSo.bIsReadOnly = true;
                txtMucChiHeSo.uText = "0";
                txtBHXH.bIsReadOnly = txtBHXH_Truong.bIsReadOnly = true;
                txtBHXH.uText = txtBHXH_Truong.uText = "0";
                txtBHYT.bIsReadOnly = txtBHYT_Truong.bIsReadOnly = true;
                txtBHYT.uText = txtBHYT_Truong.uText = "0";
                txtBHTN.bIsReadOnly = txtBHTN_Truong.bIsReadOnly = true;
                txtBHTN.uText = txtBHTN_Truong.uText = "0";
                txtKPCD.bIsReadOnly = txtKPCD_Truong.bIsReadOnly = true;
                txtKPCD.uText = txtKPCD_Truong.uText = "0";
                txtTyLe.bIsReadOnly = true;
                txtTyLe.uText = "0";
                txtThucLanh.bIsReadOnly = false;
            }
            else if (cnn.sNull2String(cbxLoaiTruyThu.uEditValue) == "04")//Tổ tài xế
            {
                txtNoiDung.bIsReadOnly = false;
                txtLuongThaiSan.bIsReadOnly = true;
                txtLuongThaiSan.uText = "0";
                txtTroCapThaiSan.bIsReadOnly = true;
                txtTroCapThaiSan.uText = "0";
                txtHeSoLuong.bIsReadOnly = true;
                //txtHeSoLuong.uText = "0";
                txtNgayCong.bIsReadOnly = false;
                //txtNgayCong.uText = "0";
                txtHeSo.bIsReadOnly = false;
                //txtHeSo.uText = "0";
                txtSoThang.bIsReadOnly = true;
                txtSoThang.uText = "0";
                txtMucPhuCap.bIsReadOnly = true;
                txtMucPhuCap.uText = "0";
                txtThanhTien.bIsReadOnly = true;
                txtThanhTien.uText = "0";
                txtMucChiHeSo.bIsReadOnly = true;
                txtMucChiHeSo.uText = "0";
                txtBHXH.bIsReadOnly = txtBHXH_Truong.bIsReadOnly = true;
                txtBHXH.uText = txtBHXH_Truong.uText = "0";
                txtBHYT.bIsReadOnly = txtBHYT_Truong.bIsReadOnly = true;
                txtBHYT.uText = txtBHYT_Truong.uText = "0";
                txtBHTN.bIsReadOnly = txtBHTN_Truong.bIsReadOnly = true;
                txtBHTN.uText = txtBHTN_Truong.uText = "0";
                txtKPCD.bIsReadOnly = txtKPCD_Truong.bIsReadOnly = true;
                txtKPCD.uText = txtKPCD_Truong.uText = "0";
                txtTyLe.bIsReadOnly = true;
                txtTyLe.uText = "0";
                txtThucLanh.bIsReadOnly = false;
            }
            else if (cnn.sNull2String(cbxLoaiTruyThu.uEditValue) == "05")//Truy lĩnh và bảo hiểm
            {
                txtNoiDung.bIsReadOnly = false;
                txtLuongThaiSan.bIsReadOnly = true;
                txtLuongThaiSan.uText = "0";
                txtTroCapThaiSan.bIsReadOnly = true;
                txtTroCapThaiSan.uText = "0";
                txtHeSoLuong.bIsReadOnly = false;
                //txtHeSoLuong.uText = "0";
                txtNgayCong.bIsReadOnly = true;
                txtNgayCong.uText = "0";
                txtHeSo.bIsReadOnly = true;
                txtHeSo.uText = "0";
                txtSoThang.bIsReadOnly = false;
                //txtSoThang.uText = "0";
                txtMucPhuCap.bIsReadOnly = true;
                txtMucPhuCap.uText = "0";
                txtThanhTien.bIsReadOnly = true;
                //txtThanhTien.uText = "0";
                txtMucChiHeSo.bIsReadOnly = false;
                //txtMucChiHeSo.uText = "0";
                txtBHXH.bIsReadOnly = txtBHXH_Truong.bIsReadOnly = false;
                //txtBHXH.uText = txtBHXH_Truong.uText = "0";
                txtBHYT.bIsReadOnly = txtBHYT_Truong.bIsReadOnly = false;
                //txtBHYT.uText = txtBHYT_Truong.uText = "0";
                txtBHTN.bIsReadOnly = txtBHTN_Truong.bIsReadOnly = false;
                //txtBHTN.uText = txtBHTN_Truong.uText = "0";
                txtKPCD.bIsReadOnly = txtKPCD_Truong.bIsReadOnly = false;
                //txtKPCD.uText = txtKPCD_Truong.uText = "0";
                txtTyLe.bIsReadOnly = false;
                //txtTyLe.uText = "0";
                txtThucLanh.bIsReadOnly = true;
                txtThucLanh.uText = "0";
            }
            else if (cnn.sNull2String(cbxLoaiTruyThu.uEditValue) == "06")//Phụ cấp độc hại
            {
                txtNoiDung.bIsReadOnly = false;
                txtLuongThaiSan.bIsReadOnly = true;
                txtLuongThaiSan.uText = "0";
                txtTroCapThaiSan.bIsReadOnly = true;
                txtTroCapThaiSan.uText = "0";
                txtHeSoLuong.bIsReadOnly = true;
                //txtHeSoLuong.uText = "0";
                txtNgayCong.bIsReadOnly = true;
                txtNgayCong.uText = "0";
                txtHeSo.bIsReadOnly = true;
                txtHeSo.uText = "0";
                txtSoThang.bIsReadOnly = false;
                //txtSoThang.uText = "0";
                txtMucPhuCap.bIsReadOnly = false;
                //txtMucPhuCap.uText = "0";
                txtThanhTien.bIsReadOnly = true;
                txtThanhTien.uText = "0";
                txtMucChiHeSo.bIsReadOnly = true;
                txtMucChiHeSo.uText = "0";
                txtBHXH.bIsReadOnly = txtBHXH_Truong.bIsReadOnly = true;
                txtBHXH.uText = txtBHXH_Truong.uText = "0";
                txtBHYT.bIsReadOnly = txtBHYT_Truong.bIsReadOnly = true;
                txtBHYT.uText = txtBHYT_Truong.uText = "0";
                txtBHTN.bIsReadOnly = txtBHTN_Truong.bIsReadOnly = true;
                txtBHTN.uText = txtBHTN_Truong.uText = "0";
                txtKPCD.bIsReadOnly = txtKPCD_Truong.bIsReadOnly = true;
                txtKPCD.uText = txtKPCD_Truong.uText = "0";
                txtTyLe.bIsReadOnly = true;
                txtTyLe.uText = "0";
                txtThucLanh.bIsReadOnly = false;
            }
            else
            {
                txtNoiDung.bIsReadOnly = false;
                txtLuongThaiSan.bIsReadOnly = true;
                txtLuongThaiSan.uText = "0";
                txtTroCapThaiSan.bIsReadOnly = true;
                txtTroCapThaiSan.uText = "0";
                txtHeSoLuong.bIsReadOnly = true;
                txtNgayCong.bIsReadOnly = true;
                txtNgayCong.uText = "0";
                txtHeSo.bIsReadOnly = true;
                txtHeSo.uText = "0";
                txtSoThang.bIsReadOnly = true;
                txtSoThang.uText = "0";
                txtMucPhuCap.bIsReadOnly = true;
                txtMucPhuCap.uText = "0";
                txtThanhTien.bIsReadOnly = true;
                txtThanhTien.uText = "0";
                txtMucChiHeSo.bIsReadOnly = true;
                txtMucChiHeSo.uText = "0";
                txtBHXH.bIsReadOnly = txtBHXH_Truong.bIsReadOnly = true;
                txtBHXH.uText = txtBHXH_Truong.uText = "0";
                txtBHYT.bIsReadOnly = txtBHYT_Truong.bIsReadOnly = true;
                txtBHYT.uText = txtBHYT_Truong.uText = "0";
                txtBHTN.bIsReadOnly = txtBHTN_Truong.bIsReadOnly = true;
                txtBHTN.uText = txtBHTN_Truong.uText = "0";
                txtKPCD.bIsReadOnly = txtKPCD_Truong.bIsReadOnly = true;
                txtKPCD.uText = txtKPCD_Truong.uText = "0";
                txtTyLe.bIsReadOnly = true;
                txtTyLe.uText = "0";
                txtThucLanh.bIsReadOnly = false;
            }
        }

        private void txtNoiDung_uValidated(object sender, EventArgs e)
        {
            if (cnn.sNull2String(cbxLoaiTruyThu.uEditValue) == "01")
            { }
            else if (cnn.sNull2String(cbxLoaiTruyThu.uEditValue) == "02")
            {
                txtThucLanh.uText = cnn.sNull2Number(cnn.sNull2Number(txtLuongThaiSan.uText) + cnn.sNull2Number(txtTroCapThaiSan.uText)).ToString("N00");
            }
            else if (cnn.sNull2String(cbxLoaiTruyThu.uEditValue) == "03")
            { }
            else if (cnn.sNull2String(cbxLoaiTruyThu.uEditValue) == "04")
            {
                decimal dLuongCoBan = cnn.sNull2Number(cnn.SQL_ExecuteScalar("SELECT LuongCoBan FROM dbo.NS_SoLuong WHERE Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND	Nam=" + cnn.sNull2Int(txtNam.uValue)));
                decimal dLuong1Ngay = dLuongCoBan * cnn.sNull2Number(txtHeSoLuong.uText) / 26;
                txtThucLanh.uText = cnn.sNull2Number(dLuong1Ngay * cnn.sNull2Number(txtNgayCong.uText) * cnn.sNull2Number(txtHeSo.uText)).ToString("N00");

            }
            else if (cnn.sNull2String(cbxLoaiTruyThu.uEditValue) == "05")
            {
                string sMaPhanHe = cnn.sNull2String(cnn.SQL_ExecuteScalar("select PhanHe from NS_NhanSu where NhanSu=" + iNhanSu));
                decimal dPTTru = 100;
                dPTTru = cnn.sNull2Number(txtTyLe.uText);
                //if (sMaPhanHe == "02")
                //{
                //    dPTTru = cnn.sNull2Number(txtTyLe.uText);//cnn.sNull2Number(cnn.SQL_ExecuteScalar("SELECT TYLEHUONGLUONG_HDDH FROM  dbo.DM_TINHTRANG WHERE MATINHTRANG= (SELECT TINHTRANG FROM  dbo.NS_NHANSU WHERE NHANSU="+iNhanSu+")"));
                //}
                txtThanhTien.uText = cnn.sNull2Number(cnn.sNull2Number(txtSoThang.uText) * cnn.sNull2Number(txtHeSoLuong.uText) * cnn.sNull2Number(txtMucChiHeSo.uText) * cnn.sNull2Number(txtTyLe.uText) / 100).ToString("N00");
                decimal dBHYT = cnn.sNull2Number(cnn.SQL_ExecuteScalar("SELECT BHYT FROM dbo.NS_SoLuong WHERE Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND	Nam=" + cnn.sNull2Int(txtNam.uValue)));
                decimal dBHYT_Truong = cnn.sNull2Number(cnn.SQL_ExecuteScalar("SELECT BHYT_Truong FROM dbo.NS_SoLuong WHERE Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND	Nam=" + cnn.sNull2Int(txtNam.uValue)));
                decimal dBHXH = cnn.sNull2Number(cnn.SQL_ExecuteScalar("SELECT BHXH FROM dbo.NS_SoLuong WHERE Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND	Nam=" + cnn.sNull2Int(txtNam.uValue)));
                decimal dBHXH_Truong = cnn.sNull2Number(cnn.SQL_ExecuteScalar("SELECT BHXH_Truong FROM dbo.NS_SoLuong WHERE Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND	Nam=" + cnn.sNull2Int(txtNam.uValue)));
                decimal dBHTN = cnn.sNull2Number(cnn.SQL_ExecuteScalar("SELECT BHTN FROM dbo.NS_SoLuong WHERE Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND	Nam=" + cnn.sNull2Int(txtNam.uValue)));
                decimal dBHTN_Truong = cnn.sNull2Number(cnn.SQL_ExecuteScalar("SELECT BHTN_Truong FROM dbo.NS_SoLuong WHERE Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND	Nam=" + cnn.sNull2Int(txtNam.uValue)));
                decimal dKPCD = cnn.sNull2Number(cnn.SQL_ExecuteScalar("SELECT KinhPhiCongDoan FROM dbo.NS_SoLuong WHERE Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND	Nam=" + cnn.sNull2Int(txtNam.uValue)));
                decimal dKPCD_Truong = cnn.sNull2Number(cnn.SQL_ExecuteScalar("SELECT KinhPhiCongDoan_Truong FROM dbo.NS_SoLuong WHERE Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND	Nam=" + cnn.sNull2Int(txtNam.uValue)));
                txtBHYT.uText = cnn.sNull2Number(cnn.sNull2Number(txtSoThang.uText) * cnn.sNull2Number(txtHeSoLuong.uText) * cnn.sNull2Number(txtMucChiHeSo.uText) * (dPTTru / 100) * dBHYT / 100).ToString("N00");
                txtBHYT_Truong.uText = cnn.sNull2Number(cnn.sNull2Number(txtSoThang.uText) * cnn.sNull2Number(txtHeSoLuong.uText) * cnn.sNull2Number(txtMucChiHeSo.uText) * (dPTTru / 100) * dBHYT_Truong / 100).ToString("N00");
                txtBHXH.uText = cnn.sNull2Number(cnn.sNull2Number(txtSoThang.uText) * cnn.sNull2Number(txtHeSoLuong.uText) * cnn.sNull2Number(txtMucChiHeSo.uText) * (dPTTru / 100) * dBHXH / 100).ToString("N00");
                txtBHXH_Truong.uText = cnn.sNull2Number(cnn.sNull2Number(txtSoThang.uText) * cnn.sNull2Number(txtHeSoLuong.uText) * cnn.sNull2Number(txtMucChiHeSo.uText) * (dPTTru / 100) * dBHXH_Truong / 100).ToString("N00");
                txtBHTN.uText = cnn.sNull2Number(cnn.sNull2Number(txtSoThang.uText) * cnn.sNull2Number(txtHeSoLuong.uText) * cnn.sNull2Number(txtMucChiHeSo.uText) * (dPTTru / 100) * dBHTN / 100).ToString("N00");
                txtBHTN_Truong.uText = cnn.sNull2Number(cnn.sNull2Number(txtSoThang.uText) * cnn.sNull2Number(txtHeSoLuong.uText) * cnn.sNull2Number(txtMucChiHeSo.uText) * (dPTTru / 100) * dBHTN_Truong / 100).ToString("N00");
                txtKPCD.uText = cnn.sNull2Number(cnn.sNull2Number(txtSoThang.uText) * cnn.sNull2Number(txtHeSoLuong.uText) * cnn.sNull2Number(txtMucChiHeSo.uText) * (dPTTru / 100) * dKPCD / 100).ToString("N00");
                txtKPCD_Truong.uText = cnn.sNull2Number(cnn.sNull2Number(txtSoThang.uText) * cnn.sNull2Number(txtHeSoLuong.uText) * cnn.sNull2Number(txtMucChiHeSo.uText) * (dPTTru / 100) * dKPCD_Truong / 100).ToString("N00");
                txtThucLanh.uText = cnn.sNull2Number(cnn.sNull2Number(txtThanhTien.uText) - cnn.sNull2Number(txtBHYT.uText) - cnn.sNull2Number(txtBHXH.uText) - cnn.sNull2Number(txtBHTN.uText) - cnn.sNull2Number(txtKPCD.uText)).ToString("N00");
            }
            else if (cnn.sNull2String(cbxLoaiTruyThu.uEditValue) == "06")
            {
                decimal dLuongCoBan = cnn.sNull2Number(cnn.SQL_ExecuteScalar("SELECT LuongCoBan FROM dbo.NS_SoLuong WHERE Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND	Nam=" + cnn.sNull2Int(txtNam.uValue)));
                txtThucLanh.uText = cnn.sNull2Number(dLuongCoBan * cnn.sNull2Number(txtMucPhuCap.uText) * cnn.sNull2Number(txtSoThang.uText)).ToString("N00");
            }
        }

        private void txtBHXH_uValidated(object sender, EventArgs e)
        {
            if (cnn.sNull2String(cbxLoaiTruyThu.uEditValue) == "05")
            {
                txtThucLanh.uText = cnn.sNull2Number(cnn.sNull2Number(txtThanhTien.uText) - cnn.sNull2Number(txtBHYT.uText) - cnn.sNull2Number(txtBHXH.uText) - cnn.sNull2Number(txtBHTN.uText) - cnn.sNull2Number(txtKPCD.uText)).ToString("N00");
            }
        }

        private void dtg_uDoubleClick(object sender, EventArgs e)
        {
            try
            {
                iThuNhapKhac = cnn.sNull2Int(dtg.CurRow["TruyThuKhac"]);
                iNhanSu = cnn.sNull2Int(dtg.CurRow["NhanSu"]);
            }
            catch
            {
                iThuNhapKhac = 0;
                iNhanSu = 0;
            }
            if (iThuNhapKhac == 0)
                return;
            string sql = "select * from NS_TruyThuKhac where TruyThuKhac = " + iThuNhapKhac;
            DataRow r = cnn.SelectRows(sql).Rows[0];
            cnn.DR_DataReader(this, r);
            string sqlns = "select * from NS_NhanSu where NhanSu = " + iNhanSu;
            DataRow r_ns = cnn.SelectRows(sqlns).Rows[0];
            cnn.DR_DataReader(uNhanSu1, r_ns);
        }

        private void menuInToanBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable dt = dtg.GetDataSource();
            decimal TongThucLanh = 0;
            foreach (DataRow r in dt.Rows)
            {
                TongThucLanh += cnn.sNull2Number(r["ThucLanh"]);
            }
            BSC_Class.Doctien doctien = new BSC_HRM.NET.BSC_Class.Doctien();
            if (dt.Rows.Count == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để in.");
                return;
            }
            if (cnn.bComboIsNull(cbxLoaiTruyThu))
            {
                XtraMessageBox.Show("Bạn chưa chọn loại thu nhập khác.");
                return;
            }
            string sReportName = "";
            switch (cbxLoaiTruyThu.uEditValue.ToString())
            {
                case "01":
                    sReportName = "DanhSachTruyThuKhac.repx";
                    break;
                case "02":
                    sReportName = "DanhSachTruyThuKhac.repx";
                    break;
                case "03":
                    sReportName = "DanhSachTruyThuKhac.repx";
                    break;
                case "04":
                    sReportName = "DanhSachTruyThuKhac.repx";
                    break;
                case "05":
                    sReportName = "DanhSachTruyThuKhac_TLVaBH.repx";
                    break;
                case "06":
                    sReportName = "DanhSachTruyThuKhac.repx";
                    break;
                default:
                    break;
            }
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\" + sReportName, dt);
            frm.sSoTienBangChu = doctien.Convert_NumtoText(TongThucLanh.ToString());
            frm.iNam = cnn.sNull2Int(txtNam.uValue);
            frm.iThang = cnn.sNull2Int(txtThang.uValue);
            frm.sThuNhapKhac = cbxLoaiTruyThu.uText;
            frm.Show();
        }

        private void menuInTungCanBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable dt = dtg.GetDataSource();
            if (dt.Rows.Count == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để in.");
                return;
            }
            if (cnn.bComboIsNull(cbxLoaiTruyThu))
            {
                XtraMessageBox.Show("Bạn chưa chọn loại thu nhập khác.");
                return;
            }
            string sReportName = "";
            switch (cbxLoaiTruyThu.uEditValue.ToString())
            {
                case "01":
                    sReportName = "DanhSachTruyThuKhac.repx";
                    break;
                case "02":
                    sReportName = "DanhSachTruyThuKhac.repx";
                    break;
                case "03":
                    sReportName = "DanhSachTruyThuKhac.repx";
                    break;
                case "04":
                    sReportName = "DanhSachTruyThuKhac.repx";
                    break;
                case "05":
                    sReportName = "DanhSachTruyThuKhac_TLVaBH_1.repx";
                    break;
                case "06":
                    sReportName = "DanhSachTruyThuKhac.repx";
                    break;
                default:
                    break;
            }
            DataRow[] Row = dtg.GetDataSource().Select("Chon=1");
            if (Row.Length > 0)
            {
                DataTable DT = dtg.GetDataSource().Copy().Clone();
                foreach (DataRow r in Row)
                    DT.ImportRow(r);
                decimal TongThucLanh = 0;
                foreach (DataRow r in dt.Rows)
                {
                    TongThucLanh += cnn.sNull2Number(r["ThucLanh"]);
                }
                BSC_Class.Doctien doctien = new BSC_HRM.NET.BSC_Class.Doctien();
                BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\" + sReportName, DT);
                frm.sSoTienBangChu = doctien.Convert_NumtoText(TongThucLanh.ToString());
                frm.iNam = cnn.sNull2Int(txtNam.uValue);
                frm.iThang = cnn.sNull2Int(txtThang.uValue);
                frm.sThuNhapKhac = cbxLoaiTruyThu.uText;
                frm.Show();
            }
        }
    }
}