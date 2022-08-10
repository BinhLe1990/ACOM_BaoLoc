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
    public partial class frmThongKeNghiPhep : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKeNghiPhep()
        {
            InitializeComponent();
            clRun.SetValueToControl(this);
            dtg.sKEY = sKEY;

        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clRun = new clsRun();
        string sKEY = "THONGKENGHIPHEP";

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            string sSQL = cnn.GetSQLString("THONGKENGHIPHEP");
            sSQL = sSQL.Replace("2011", spinNam.uText);
            if (!cnn.bComboIsNull(cboPhongBan))
            {
                sSQL = "Select * from (" + sSQL + ") A where PhongBan=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "'";
            }
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = DT;
        }        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        private void btnIn_Click(object sender, EventArgs e)
        {
            DataTable dt = dtg.GetDataSource();
            if (dt.Rows.Count == 0)
                return;
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\TK_ThongKeNghiPhep.repx", dt);
            string [] NAM=new string[]{spinNam.uText};
            frm.bXoayDiem = true;
            frm.MonHoc = NAM;
            frm.Show();
        }
        private void frmThongKeNghiPhep_Load(object sender, EventArgs e)
        {
            spinNam.uText = DateTime.Now.Year.ToString();
        }
    }
}