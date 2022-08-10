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
    public partial class frmInTemLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmInTemLuong()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);                      
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKEY_BIENCHE = "INTEMLUONG_BIENCHE";
        string sKEY_BIENCHE_3T = "INTEMLUONG_BIENCHE_3T";
        string sKEY_BIENCHE_12T = "INTEMLUONG_BIENCHE_12T";
        string sKEY_LUONGKHOAN = "INTEMLUONG_LUONGKHOAN";
        string sKEY_LUONGKHOAN_3T = "INTEMLUONG_LUONGKHOAN_3T";
        string sKEY_HOPDONG68 = "INTEMLUONG_HOPDONG68";
        string sKEY_HOPDONG68_3T = "INTEMLUONG_HOPDONG68_3T";
        string sKEY_HOPDONG68_12T = "INTEMLUONG_HOPDONG68_12T";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInTemLuong_Load(object sender, EventArgs e)
        {
            txtTuNam.uValue = DateTime.Now.Year;
            txtDenNam.uValue = DateTime.Now.Year;
            txtTuThang.uValue = DateTime.Now.Month;
            txtDenThang.uValue = DateTime.Now.Month;
        }      

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            //if (cnn.bComboIsNull(cbxCoSo))
            //{
            //    XtraMessageBox.Show("Bạn chưa chọn cơ sở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            if (cnn.bComboIsNull(cbxPhanHe))
            {
                XtraMessageBox.Show("Bạn chưa chọn phân hệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sSQL = "";
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "01" || cnn.sNull2String(cbxPhanHe.uEditValue) == "02")
            {
                if (cnn.sNull2Int(raTemLuong.EditValue) == 1)
                {
                    sSQL = cnn.GetSQLString(sKEY_BIENCHE);
                    dtg.sKEY = sKEY_BIENCHE;
                }
                else if (cnn.sNull2Int(raTemLuong.EditValue) == 2)
                {
                    sSQL = cnn.GetSQLString(sKEY_BIENCHE_3T);
                    dtg.sKEY = sKEY_BIENCHE_3T;
                    sSQL = sSQL.Replace("1 = 2013", "NS_BangLuongHopDongBienChe.Thang=" + cnn.sNull2Int(txtTuThang.uValue) + " AND NS_BangLuongHopDongBienChe.Nam=" + cnn.sNull2Int(txtTuNam.uValue));
                    sSQL = sSQL.Replace("2 = 2013", "NS_BangLuongHopDongBienChe.Thang=" + cnn.sNull2Int(cnn.sNull2Int(txtDenThang.uValue) - 1) + " AND NS_BangLuongHopDongBienChe.Nam=" + cnn.sNull2Int(txtDenNam.uValue));
                    sSQL = sSQL.Replace("3 = 2013", "NS_BangLuongHopDongBienChe.Thang=" + cnn.sNull2Int(txtDenThang.uValue) + " AND NS_BangLuongHopDongBienChe.Nam=" + cnn.sNull2Int(txtDenNam.uValue));
                }
                else
                {
                    sSQL = cnn.GetSQLString(sKEY_BIENCHE_12T);
                    dtg.sKEY = sKEY_BIENCHE_12T;
                    sSQL = sSQL.Replace("2013", cnn.sNull2String(cnn.sNull2Int(txtTuNam.uValue)));
                }

            }
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "03")
            {
                if (cnn.sNull2Int(raTemLuong.EditValue) == 1)
                {
                    sSQL = cnn.GetSQLString(sKEY_LUONGKHOAN);
                    dtg.sKEY = sKEY_LUONGKHOAN;
                }
                else
                {
                    sSQL = cnn.GetSQLString(sKEY_LUONGKHOAN_3T);
                    dtg.sKEY = sKEY_LUONGKHOAN_3T; 
                }
            }

            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")
            {
                if (cnn.sNull2Int(raTemLuong.EditValue) == 1)
                {
                    sSQL = cnn.GetSQLString(sKEY_HOPDONG68);
                    dtg.sKEY = sKEY_HOPDONG68;
                }
                else if (cnn.sNull2Int(raTemLuong.EditValue) == 2)
                {
                    sSQL = cnn.GetSQLString(sKEY_HOPDONG68_3T);
                    dtg.sKEY = sKEY_HOPDONG68_3T;
                    sSQL = sSQL.Replace("1 = 2013", "NS_BangLuongHopDong68.Thang=" + cnn.sNull2Int(txtTuThang.uValue) + " AND NS_BangLuongHopDong68.Nam=" + cnn.sNull2Int(txtTuNam.uValue));
                    sSQL = sSQL.Replace("2 = 2013", "NS_BangLuongHopDong68.Thang=" + cnn.sNull2Int(cnn.sNull2Int(txtDenThang.uValue) - 1) + " AND NS_BangLuongHopDong68.Nam=" + cnn.sNull2Int(txtDenNam.uValue));
                    sSQL = sSQL.Replace("3 = 2013", "NS_BangLuongHopDong68.Thang=" + cnn.sNull2Int(txtDenThang.uValue) + " AND NS_BangLuongHopDong68.Nam=" + cnn.sNull2Int(txtDenNam.uValue));
                }
                else
                {
                    sSQL = cnn.GetSQLString(sKEY_HOPDONG68_12T);
                    dtg.sKEY = sKEY_HOPDONG68_12T;
                    sSQL = sSQL.Replace("2013", cnn.sNull2String(cnn.sNull2Int(txtTuNam.uValue)));
                }
            }

            string sCond = "";
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")
            {
                if (cnn.sNull2Int(raTemLuong.EditValue) == 1)
                {
                    sCond = " NS_BangLuongHopDong68.Thang=" + cnn.sNull2Int(txtTuThang.uValue) + " AND NS_BangLuongHopDong68.Nam=" + cnn.sNull2Int(txtTuNam.uValue) + " AND ";
                }
                else if (cnn.sNull2Int(raTemLuong.EditValue) == 2)
                {
                    sCond = " NS_BangLuongHopDong68.Thang>=" + cnn.sNull2Int(txtTuThang.uValue) + " AND NS_BangLuongHopDong68.Nam>=" + cnn.sNull2Int(txtTuNam.uValue) + " AND NS_BangLuongHopDong68.Thang<=" + cnn.sNull2Int(txtDenThang.uValue) + " AND NS_BangLuongHopDong68.Nam<=" + cnn.sNull2Int(txtDenNam.uValue) + " AND ";
                }
            }
            else
            {
                if (cnn.sNull2Int(raTemLuong.EditValue) == 1)
                {
                    sCond = " NS_BangLuongHopDongBienChe.Thang=" + cnn.sNull2Int(txtTuThang.uValue) + " AND NS_BangLuongHopDongBienChe.Nam=" + cnn.sNull2Int(txtTuNam.uValue) + " AND ";
                }
                else if (cnn.sNull2Int(raTemLuong.EditValue) == 2)
                {
                    sCond = " NS_BangLuongHopDongBienChe.Thang>=" + cnn.sNull2Int(txtTuThang.uValue) + " AND NS_BangLuongHopDongBienChe.Nam>=" + cnn.sNull2Int(txtTuNam.uValue) + " AND NS_BangLuongHopDongBienChe.Thang<=" + cnn.sNull2Int(txtDenThang.uValue) + " AND NS_BangLuongHopDongBienChe.Nam<=" + cnn.sNull2Int(txtDenNam.uValue) + " AND ";
                }
            }


            if (!cnn.bComboIsNull(cboPhongBan))
            {
                sCond += " NS_NhanSu.PHONGBAN=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxDonVi))
            {
                sCond += " NS_NhanSu.DONVI=N'" + cnn.sNull2String(cbxDonVi.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxCoSo))
            {
                sCond += " NS_NhanSu.CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxPhanHe) && cnn.sNull2String(cbxPhanHe.uEditValue) != "03")
            {
                sCond += " NS_NhanSu.PhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            }
            if (txtMaCanBo.uText.Trim().Length > 0)
            {
                sCond += " NS_NhanSu.Ma=N'" + txtMaCanBo.uText + "' AND ";
            }
            if (txtHoDem.uText.Trim().Length > 0)
            {
                sCond += " NS_NhanSu.HoDem like N'%" + txtHoDem.uText + "%' AND ";
            }
            if (txtTen.uText.Trim().Length > 0)
            {
                sCond += " NS_NhanSu.Ten like N'%" + txtTen.uText + "%' AND ";
            }
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
        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            string sReportName = "";
            string sSQL = "";
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "01")                
            {
                if (cnn.sNull2Int(raTemLuong.EditValue) == 1)
                    sReportName = "TemLuongBienChe.repx";
                else if (cnn.sNull2Int(raTemLuong.EditValue) == 2)    
                    sReportName = "TemLuongBienChe_3T.repx";
                else
                    sReportName = "TemLuongBienChe_12T.repx";

            }
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "02") 
            {
                if (cnn.sNull2Int(raTemLuong.EditValue) == 1)
                    sReportName = "TemLuongHopDong.repx";
                else if(cnn.sNull2Int(raTemLuong.EditValue) == 2)
                    sReportName = "TemLuongHopDong_3T.repx";
                else
                    sReportName = "TemLuongHopDong_12T.repx";
            }
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "03")
            {
                if (cnn.sNull2Int(raTemLuong.EditValue) == 1)
                    sReportName = "TemLuongKhoan.repx";
                else if (cnn.sNull2Int(raTemLuong.EditValue) == 2)
                    sReportName = "TemLuongKhoan_3T.repx";
                else
                    sReportName = "TemLuongKhoan_12T.repx";
       
            }
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")
            {
                if (cnn.sNull2Int(raTemLuong.EditValue) == 1)
                    sReportName = "TemLuongHopDong68.repx";
                else if (cnn.sNull2Int(raTemLuong.EditValue) == 2)
                    sReportName = "TemLuongHopDong68_3T.repx";
                else
                    sReportName = "TemLuongHopDong68_12T.repx";

            }
            DataRow[] Row = dtg.GetDataSource().Select("Chon=1");
            if (Row.Length > 0)
            {
                DataTable DT = dtg.GetDataSource().Copy().Clone();
                foreach (DataRow r in Row)
                    DT.ImportRow(r);
                BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\" + sReportName, DT);
                frm.iNam = cnn.sNull2Int(txtTuNam.uValue);
                frm.iThang = cnn.sNull2Int(txtTuThang.uValue);
                frm.sTuThangNam = cnn.sNull2String(txtTuThang.uValue) + "/" + cnn.sNull2String(txtTuNam.uValue);
                frm.sDenThangNam = cnn.sNull2String(txtDenThang.uValue) + "/" + cnn.sNull2String(txtDenNam.uValue);
                frm.sCoSo = cbxCoSo.uText;
                frm.sPhanHe = cbxPhanHe.uText;
                if (!cnn.bComboIsNull(cboPhongBan))
                    frm.sPhongBan = cboPhongBan.uText;
                frm.Show();
            }          

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            
        }
        public string ReplaceMucLuong(int Thang,int Nam)
        {
            string KetQua;
            DataTable dt_MucLuong = cnn.SelectRows("select LuongCoBan,SONGAYCHUAN from NS_SoLuong where Thang=" + Thang + " And Nam=" + Nam);

            if (dt_MucLuong.Rows.Count == 0)
                return "0 as MUCLUONG, 0 as SONGAYCHUAN,";
            else return cnn.sNull2String(dt_MucLuong.Rows[0]["LuongCoBan"]) + " as MUCLUONG,"+ cnn.sNull2String(dt_MucLuong.Rows[0]["SONGAYCHUAN"])+" as SONGAYCHUAN,";             
            return KetQua;
        }        

        private void cboPhongBan_uEditValueChanged(object sender, EventArgs e)
        {
            string sSQL = "Select MaDonVi,TenDonVi From DM_DonVi where MaPhongBan=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "'";
            DataTable DT = cnn.DT_DataTable(sSQL);
            cbxDonVi.uDataSource = DT;
        }

        private void raTemLuong_EditValueChanged(object sender, EventArgs e)
        {
            if (cnn.sNull2Int(raTemLuong.EditValue) == 1)
            {
                txtTuThang.bIsReadOnly = false;
                txtTuNam.bIsReadOnly = false;
                txtDenThang.bIsReadOnly = true;
                txtDenNam.bIsReadOnly = true;

            }
            else if (cnn.sNull2Int(raTemLuong.EditValue) == 2)
            {

                txtTuThang.bIsReadOnly = false;
                txtTuNam.bIsReadOnly = false;
                txtDenThang.bIsReadOnly = false;
                txtDenNam.bIsReadOnly = false;
            }
            else if (cnn.sNull2Int(raTemLuong.EditValue) == 3)
            {
                txtTuThang.bIsReadOnly = true;
                txtTuNam.bIsReadOnly = false;
                txtDenThang.bIsReadOnly = true;
                txtDenNam.bIsReadOnly = true;
            }
        }        
    }
}