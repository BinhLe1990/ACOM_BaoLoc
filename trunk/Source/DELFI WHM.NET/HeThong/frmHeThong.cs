using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.HeThong
{
    public partial class frmHeThong : DevExpress.XtraEditors.XtraForm
    {
        public frmHeThong()
        {
            InitializeComponent();
            txtPassword.Properties.PasswordChar = '\u25CF';
            txtPasswordMysql.Properties.PasswordChar = '\u25CF';
        }
        public frmHeThong(bool KhoiTao)
        {
            InitializeComponent();
            bKhoiTao = KhoiTao;
            txtPassword.Properties.PasswordChar = '\u25CF';
            txtPasswordMysql.Properties.PasswordChar = '\u25CF';
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
            DELFI_Class.DELFIRegistry.WriteRegistry("SYS", "ServerName", txtServerName.Text, "Delfi VN");
            DELFI_Class.DELFIRegistry.WriteRegistry("SYS", "UserName", txtUserName.Text, "Delfi VN");
            DELFI_Class.DELFIRegistry.WriteRegistry("SYS", "Password", txtPassword.Text, "Delfi VN");
            DELFI_Class.DELFIRegistry.WriteRegistry("SYS", "Database", txtDatabase.Text, "Delfi VN");
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
            if ((new DELFI_Class.DELFIConnection()).TestConnect(txtServerName.Text, txtUserName.Text, txtPassword.Text, txtDatabase.Text))
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
            DELFI_Class.DELFIRegistry.ReadRegistry("SYS", "ServerName", out sTmp, "Delfi VN");
            txtServerName.Text = sTmp;
            DELFI_Class.DELFIRegistry.ReadRegistry("SYS", "UserName", out sTmp, "Delfi VN");
            txtUserName.Text = sTmp;
            DELFI_Class.DELFIRegistry.ReadRegistry("SYS", "Password", out sTmp, "Delfi VN");
            txtPassword.Text = sTmp;
            DELFI_Class.DELFIRegistry.ReadRegistry("SYS", "Database", out sTmp, "Delfi VN");
            txtDatabase.Text = sTmp;

            DELFI_Class.DELFIRegistry.ReadRegistry("SYS", "ServerMySql", out sTmp, "Delfi VN");
            txtServerMySQL.Text = sTmp;
            DELFI_Class.DELFIRegistry.ReadRegistry("SYS", "PortMySql", out sTmp, "Delfi VN");
            txtPortMysql.Text = sTmp;
            DELFI_Class.DELFIRegistry.ReadRegistry("SYS", "UserMySql", out sTmp, "Delfi VN");
            txtUserMysql.Text = sTmp;
            DELFI_Class.DELFIRegistry.ReadRegistry("SYS", "PasswordMySql", out sTmp, "Delfi VN");
            txtPasswordMysql.Text = sTmp;
            DELFI_Class.DELFIRegistry.ReadRegistry("SYS", "DatabaseMySql", out sTmp, "Delfi VN");
            txtDatabaseMysql.Text = sTmp;
        }

        private void btnCheckMysql_Click(object sender, EventArgs e)
        {
            //if ((new DELFI_Class.DELFIConnectionMySql()).TestConnectMySql(txtServerMySQL.Text.Trim(), txtPortMysql.Text.Trim(), txtUserMysql.Text.Trim(), txtPasswordMysql.Text.Trim(), txtDatabaseMysql.Text.Trim()))
            //{
            //    XtraMessageBox.Show("Kết nối thành công");
            //}
            //else
            //{
            //    XtraMessageBox.Show("Kết nối không thành công");
            //}
        }

        private void btnSaveMysql_Click(object sender, EventArgs e)
        {
            DELFI_Class.DELFIRegistry.WriteRegistry("SYS", "ServerMySql", txtServerMySQL.Text, "Delfi VN");
            DELFI_Class.DELFIRegistry.WriteRegistry("SYS", "PortMySql", txtPortMysql.Text, "Delfi VN");
            DELFI_Class.DELFIRegistry.WriteRegistry("SYS", "UserMySql", txtUserMysql.Text, "Delfi VN");
            DELFI_Class.DELFIRegistry.WriteRegistry("SYS", "PasswordMySql", txtPasswordMysql.Text, "Delfi VN");
            DELFI_Class.DELFIRegistry.WriteRegistry("SYS", "DatabaseMySql", txtDatabaseMysql.Text, "Delfi VN");
            if (bKhoiTao)
                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "Thông tin đã được cập nhật!", this.Text);
            else
                if (XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "Thông tin đã được lưu lại! Bạn có muốn khởi động lại chương trình để thay đổi có hiệu lực", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Dispose();
                    Application.Restart();
                }
        }

        private void frmHeThong_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}