using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BSC_HRM.NET.HeThong
{
    public partial class frmHeThong : DevExpress.XtraEditors.XtraForm
    {
        public frmHeThong()
        {
            InitializeComponent();
            txtPassword.Properties.PasswordChar = '\u25CF';
        }
        public frmHeThong(bool KhoiTao)
        {
            InitializeComponent();
            bKhoiTao = KhoiTao;
            txtPassword.Properties.PasswordChar = '\u25CF';
        }
        bool OK = false;
        public bool bKhoiTao = false;
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!bKhoiTao)
            {
                Close();
                return;
            }
            else
            {
                if (OK)
                    Application.Restart();
                else
                    Application.Exit();
            }
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            BSC_Class.BSCRegistry.WriteRegistry("SYS", "ServerName", txtServerName.Text, "BSC Soft");
            BSC_Class.BSCRegistry.WriteRegistry("SYS", "UserName", txtUserName.Text, "BSC Soft");
            BSC_Class.BSCRegistry.WriteRegistry("SYS", "Password", txtPassword.Text, "BSC Soft");
            BSC_Class.BSCRegistry.WriteRegistry("SYS", "Database", txtDatabase.Text, "BSC Soft");
            if(bKhoiTao)
                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "Thông tin đã được cập nhật!", this.Text);
            else
                if (XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "Thông tin đã được lưu lại! Bạn có muốn khởi động lại chương trình để thay đổi có hiệu lực", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Dispose();
                    Application.Restart();
                }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if ((new BSC_Class.BSCConnection()).TestConnect(txtServerName.Text, txtUserName.Text, txtPassword.Text, txtDatabase.Text))
            {
                XtraMessageBox.Show("Kết nối thành công");
                OK = true;
            }
            else
            {
                XtraMessageBox.Show("Kết nối không thành công");
                OK = false;
            }
        }

        private void frmHeThong_Load(object sender, EventArgs e)
        {
            string sTmp = "";
            BSC_Class.BSCRegistry.ReadRegistry("SYS", "ServerName",  out sTmp, "BSC Soft");
            txtServerName.Text = sTmp;
            BSC_Class.BSCRegistry.ReadRegistry("SYS", "UserName", out sTmp, "BSC Soft");
            txtUserName.Text = sTmp;
            BSC_Class.BSCRegistry.ReadRegistry("SYS", "Password", out sTmp, "BSC Soft");
            txtPassword.Text = sTmp;
            BSC_Class.BSCRegistry.ReadRegistry("SYS", "Database",out sTmp, "BSC Soft");
            txtDatabase.Text = sTmp;
        }
    }
}