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
    public partial class frmNhanSuChuaTangLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanSuChuaTangLuong()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            dtg.sKEY = sKey;
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKey = "NHANSUCHUATANGLUONG";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable dt;
        private void btnIn_Click(object sender, EventArgs e)
        {
            string[] sNgay = new string[] { Convert.ToDateTime(dtpNgay.uValue).ToString("dd/MM/yyyy")};
            if (dt == null || dt.Rows.Count == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để in ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\DS_NhanSuChuaTangLuong.repx", dt);
            frm.bXoayDiem = true;
            frm.MonHoc = sNgay;
            frm.Show();

        }
        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            string sSQL = cnn.GetSQLString(sKey);
            sSQL = sSQL.Replace("1=1", "DATEDIFF(mm,NS_QuaTrinhLuong.NgayHuong,'"+Convert.ToDateTime(dtpNgay.uValue).ToString("MM/dd/yyyy")+"')>="+txtSoThang.uText);
            dt = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = dt;
        }

        private void frmNhanSuChuaTangLuong_Load(object sender, EventArgs e)
        {
            dtpNgay.uValue = DateTime.Now;
        }
    }
}