using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BSC_HRM.NET
{
    public partial class frmThongTinCoQuan : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinCoQuan()
        {
            InitializeComponent();
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);

        private void txtReset_Click(object sender, EventArgs e)
        {
            cnn.clearControl(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtID.Tag = "";
            string sql = cnn.UpdateDataSQLComm(this, "HT_HETHONG", "ID = " + txtID.uText);
            cnn.ExecuteNonQuery(sql);
            txtID.Tag = "..ID";
            XtraMessageBox.Show("Đã cập nhật thành công");
        }

        private void frmThongTinCoQuan_Load(object sender, EventArgs e)
        {
            DataTable dt = cnn.SelectRows("select * from HT_HETHONG");
            if (dt.Rows.Count == 0)
                return;
            cnn.DR_DataReader(this, dt.Rows[0]);
        }

        private void txtTenCoQuan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

    }
}