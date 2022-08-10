using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BSC_HRM.NET.HeThong.FrHT
{
    public partial class frmBackup : DevExpress.XtraEditors.XtraForm
    {
        public frmBackup()
        {
            InitializeComponent();
            txtMK.Properties.PasswordChar = '\u25CF';
            txtXNMK.Properties.PasswordChar = '\u25CF';
        }
        BSC_Class.BSCConnection cnn = new BSC_Class.BSCConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string ShowSaveFileDialog(string title, string filter)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = title;
            dlg.FileName = title + " [" + DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss") + "]";
            dlg.Filter = filter;
            if (dlg.ShowDialog() == DialogResult.OK) return dlg.FileName;
            return "";
        }
        private void btnDir_Click(object sender, EventArgs e)
        {
            string TXTfileName = ShowSaveFileDialog("Save File", "BSC Backup Files (*.bscbk)|*.bscbk|Microsoft SQL Backup Files (*.bak)|*.bak|All Files (*.*)|*.*");
            if (TXTfileName != "")
                txtDir.Text = TXTfileName;
            else
                txtDir.Text = "";
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            if ((txtMK.Text.Length > 0) || (txtXNMK.Text.Length > 0))
            {
                if (!txtMK.Text.Equals(txtXNMK.Text))
                {
                    XtraMessageBox.Show("Mật khẩu xác nhận không đúng với mật khẩu mà bạn đã nhập");
                    return;
                }
            }
            string sPass = "";
            if (txtMK.Text.Length > 0)
                sPass = "PASSWORD = '" + txtMK.Text + "', ";
            string sBackup = "BACKUP DATABASE [" + Program.sDatabaseName + "] TO DISK = '" + txtDir.Text + "' WITH " + sPass + "FORMAT";
            cnn.ExecuteNonQuery(sBackup);
            if (null == cnn.LastError)
                XtraMessageBox.Show(this, "Dữ liệu đã được sao lưu thành công", "Sao lưu dự phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                XtraMessageBox.Show(this, "Chưa thể sao lưu dữ liệu dự phòng được", "Sao lưu dự phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                XtraMessageBox.Show(cnn.LastError.ToString());
            }
        }
    }
}