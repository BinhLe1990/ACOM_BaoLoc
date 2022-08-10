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
    public partial class frmTongHopLuongTheoPhongBan : DevExpress.XtraEditors.XtraForm
    {
        public frmTongHopLuongTheoPhongBan()
        {
            InitializeComponent();
            clsrun.SetValueToControl(this);
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsrun = new clsRun();
        string sKEY_BIENCHE = "TONGHOPLUONG_PHONGBAN";
        string sKEY_HOPDONG68 = "TONGHOPLUONG_PHONGBAN_HOPDONG68";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\TongHopLuong_PhongBan.repx", DT);
            frm.iThang = cnn.sNull2Int(txtThang.uValue);
            frm.iNam = cnn.sNull2Int(txtNam.uValue);
            if (!cnn.bComboIsNull(cboPhongBan))
                frm.sPhongBan = cboPhongBan.uText;
            if (!cnn.bComboIsNull(cbxCoSo))
                frm.sCoSo = cbxCoSo.uText;
            if (!cnn.bComboIsNull(cbxPhanHe))
                frm.sPhanHe = cbxPhanHe.uText;
            frm.Show();
        }

        private void frmTongHopLuongTheoPhongBan_Load(object sender, EventArgs e)
        {
            txtThang.uValue = DateTime.Now.Month;
            txtNam.uValue = DateTime.Now.Year;
        }

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cbxPhanHe))
            {
                string sSQL = "";
                if (cnn.sNull2String(cbxPhanHe.uEditValue) == "01" || cnn.sNull2String(cbxPhanHe.uEditValue) == "02")
                {
                     sSQL= cnn.GetSQLString(sKEY_BIENCHE);
                     dtg.sKEY = sKEY_BIENCHE;
                }
                if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")
                {
                    sSQL = cnn.GetSQLString(sKEY_HOPDONG68);
                    dtg.sKEY = sKEY_HOPDONG68;
                }
                string sCond = "Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND ";
                if (!cnn.bComboIsNull(cbxCoSo))
                    sCond += "NS_NhanSu.CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
                if (!cnn.bComboIsNull(cbxPhanHe))
                    sCond += "NS_NhanSu.PhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
                if (!cnn.bComboIsNull(cboPhongBan))
                    sCond += "NS_NhanSu.PhongBan=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "' AND ";
                sCond = sCond.Substring(0, sCond.Length - 4);
                sSQL = sSQL.Replace("1 = 0", sCond);
                DataTable DT = cnn.DT_DataTable(sSQL);
                dtg.uDataSource = DT;
            }

        }
    }
}