using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace DELFI_WHM.NET.Luong
{
    public partial class frmViewHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public frmViewHoaDon()
        {
            InitializeComponent();
            clsrun.SetValueToControl(this);
            dtg.sKEY = "NS_LUONG_VIEWTHULAO";
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clsrun = new clsRun();        
        public int iHoaDon = 0;
        private int iNhanSu = 0;
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Control ctr in panelControl1.Controls)
            {
                ctr.Width = panelControl1.Width / panelControl1.Controls.Count;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void InHoaDon()
        {
            string sSQL = cnn.GetSQLString("INHOADONDON");
            sSQL = sSQL.Replace("1 = 0", "HoaDon=" + iHoaDon);
            DataTable DT = cnn.DT_DataTable(sSQL);
            BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\HoaDonDo.repx", DT);
            frm.Show();
        }
        
        private void frmViewHoaDon_Load(object sender, EventArgs e)
        {
            string sSQL = "Select * from NS_HoaDonDo where HoaDon=" + iHoaDon;
            DataTable DT = cnn.DT_DataTable(sSQL);
            if (DT != null && DT.Rows.Count > 0)
            {
                iNhanSu = cnn.sNull2Int(DT.Rows[0]["NhanSu"]);
                LoadNhanSu(iNhanSu);
                DataTable dtb = cnn.SelectRows("select * from (" + cnn.GetSQLString("NS_LUONG_VIEWTHULAO") + ")A where NhanSu =" + iNhanSu + " And SoHoaDon=N'" + DT.Rows[0]["SoHoaDon"].ToString () + "'");
                if (dtb != null)
                {
                    dtg.uDataSource = dtb;
                }
                cnn.DR_DataReader(grpThongTinHoaDon, DT.Rows[0]);
                if ((bool)DT.Rows[0]["IsDaIn"] == true)
                    btnIn.Enabled = false;
                else btnIn.Enabled = true;
            }
        }        
        private void LoadNhanSu(int iNS)
        { 
            string sSQL="SELECT 	NHANSU,	MA,	HODEM+' '+TEN HOTEN,	SOCMND,	CASE WHEN GIOITINH=1 THEN N'Nam' ELSE N'Nữ' END GIOITINH,	MST,	DCLL,	DIENTHOAI,	DIDONG,	PHANHE,"+
	                    " CASE 		WHEN ISNULL(MST,' ')=' ' AND ISNULL(PHANHE,'')='04' THEN 20 		WHEN ISNULL(MST,' ')<>' ' AND ISNULL(PHANHE,'')='04' THEN 10 ELSE 0 END PTThue "+
                        " FROM  dbo.NS_NHANSU WHERE Del=0 AND NhanSu="+iNS;
            DataTable DT = cnn.DT_DataTable(sSQL);
            if (DT != null && DT.Rows.Count > 0)
            {
                txtMaSo.uText = cnn.sNull2String(DT.Rows[0]["MA"]);

                txtSoCMND.uText = cnn.sNull2String(DT.Rows[0]["SOCMND"]);
                txtHoTen.uText = cnn.sNull2String(DT.Rows[0]["HOTEN"]);
                txtGioiTinh.uText = cnn.sNull2String(DT.Rows[0]["GIOITINH"]);
                txtMaSoThue.uText = cnn.sNull2String(DT.Rows[0]["MST"]);
                txtDCLL.uText = cnn.sNull2String(DT.Rows[0]["DCLL"]);
                txtDiDong.uText = cnn.sNull2String(DT.Rows[0]["DIDONG"]);
                txtDienThoai.uText = cnn.sNull2String(DT.Rows[0]["DIENTHOAI"]);
                txtPTThue.uText = cnn.sNull2String(DT.Rows[0]["PTThue"]);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            InHoaDon();
        }

        private void txtNoiDung_Load(object sender, EventArgs e)
        {

        }             
        
    }
}