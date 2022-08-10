using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BSC_HRM.NET.NhanSu
{
    public partial class frmNhanSuSapHetHanHD : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanSuSapHetHanHD()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            dtg.sKEY = sKey;
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKey = "HOPDONGHETHAN";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable dt;
        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            string sSQL = cnn.GetSQLString(sKey);
            sSQL = sSQL.Replace("1=1", " DenNgay<='" + Convert.ToDateTime(dtpNgay.uValue).ToString("MM/dd/yyyy") + "'");
            dt = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = dt;
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dt == null || dt.Rows.Count == 0) return;
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\TK_HopDongSapHetHan.repx", dt);
            frm.Show();
        }
        private void frmNhanSuSapHetHanHD_Load(object sender, EventArgs e)
        {
            dtpNgay.uValue = DateTime.Now;
        }
    }
}