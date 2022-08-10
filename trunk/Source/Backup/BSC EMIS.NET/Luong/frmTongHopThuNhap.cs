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
    public partial class frmTongHopThuNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmTongHopThuNhap()
        {
            InitializeComponent();
            clsrun.SetValueToControl(this);
            dtg.sKEY = sKEY;
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsrun = new clsRun();
        string sKEY = "TONGHOPTHUNHAP_NHANSU";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
           
            decimal TongThucLanh = 0;
            foreach (DataRow r in DT.Rows)
            {
                TongThucLanh += cnn.sNull2Number(r["TongCong"]);
            }
            BSC_Class.Doctien doctien = new BSC_HRM.NET.BSC_Class.Doctien();
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_TongHopThuNhap.repx", DT);
            frm.sSoTienBangChu = doctien.Convert_NumtoText(TongThucLanh.ToString());
            if (!cnn.bComboIsNull(cbxCoSo))
                frm.sCoSo = cbxCoSo.uText;
            if (!cnn.bComboIsNull(cbxPhanHe))
                frm.sPhanHe = cbxPhanHe.uText;
            if (!cnn.bComboIsNull(cbxPhongBan))
                frm.sPhongBan = cbxPhongBan.uText;
            frm.sTuThangNam = cnn.sNull2String(txtTuThang.uValue) + "/" + cnn.sNull2String(txtTuNam.uValue);
            frm.sDenThangNam = cnn.sNull2String(txtDenThang.uValue) + "/" + cnn.sNull2String(txtDenNam.uValue);
            frm.Show();
        }

        private void frmTongHopThuNhap_Load(object sender, EventArgs e)
        {
            txtTuThang.uValue = DateTime.Now.Month;
            txtDenThang.uValue = DateTime.Now.Month;
            txtTuNam.uValue = DateTime.Now.Year;
            txtDenNam.uValue = DateTime.Now.Year;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            string sSQL = cnn.GetSQLString(sKEY);
            string sReplace10 = " ( Thang>=" + txtTuThang.uValue + " AND Thang<=" + txtDenThang.uValue + ") AND (Nam>=" + txtTuNam.uValue + " AND Nam<=" + txtDenNam.uValue + ")";
            string sReplace11 = "";
            if(!cnn.bComboIsNull(cbxCoSo))
                sReplace11 += " NS_NhanSu.COSO=N'"+cnn.sNull2String(cbxCoSo.uEditValue)+"' AND ";
            if(!cnn.bComboIsNull(cbxPhanHe))
                sReplace11 += "NS_NhanSu.PhanHe=N'"+cnn.sNull2String(cbxPhanHe.uEditValue)+"' AND ";
            if (!cnn.bComboIsNull(cbxPhongBan))
                sReplace11 += "NS_NhanSu.PhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
            if (sReplace11 != "")
            {
                sReplace11 = sReplace11.Substring(0, sReplace11.Length - 4);
                sSQL = sSQL.Replace("1 = 1", sReplace11);
            }
            sSQL = sSQL.Replace("1 = 0", sReplace10);
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = DT;
        }
    }
}