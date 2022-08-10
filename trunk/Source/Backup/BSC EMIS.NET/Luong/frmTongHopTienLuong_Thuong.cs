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
    public partial class frmTongHopTienLuong_Thuong : DevExpress.XtraEditors.XtraForm
    {
        public frmTongHopTienLuong_Thuong()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            dtg.sKEY = sKey;
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKey = "TongHopTienLuongThuong";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTongHopTienLuong_Thuong_Load(object sender, EventArgs e)
        {
            txtNam.uText = DateTime.Now.Year.ToString();
        }

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            string sSQL = cnn.GetSQLString(sKey);
            sSQL = sSQL.Replace("1=1", "NS_BangLuongKy2.Nam=" + cnn.sNull2Int(txtNam.uText));
            dtg.uDataSource = cnn.DT_DataTable(sSQL);
        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            DataTable dt = dtg.GetDataSource();
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath+@"\Report\DS_TongHopTienLuongThuong.repx",dt);
            frm.Show();
        }
    }
}