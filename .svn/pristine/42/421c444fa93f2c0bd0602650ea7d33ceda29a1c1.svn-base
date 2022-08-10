using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace BSC_HRM.NET.HeThong.FrHT
{
    public partial class frmRestore : DevExpress.XtraEditors.XtraForm
    {
        public frmRestore()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (OpenFileBackup.ShowDialog() == DialogResult.Cancel)
                return;
            txtFileDir.uText = OpenFileBackup.FileName;
        }

        private void ckbPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.Enabled = ckbPass.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MainErr.Clear();
            string Dir = "";
            if (txtFileDir.uText.Trim().Length <= 0)
            {
                MainErr.SetError(txtFileDir, "Bạn chưa chọn đường dẫn chứa File sao lưu cần phục hồi");
                return;
            }
            Dir = txtFileDir.uText.Trim();
            string Pass = "";
            if (ckbPass.Checked)
            {
                if (txtPass.uText.Length <= 0)
                {
                    MainErr.SetError(ckbPass, "Bạn đã Check chọn File sao lưu đòi hỏi phải có mật khẩu để mở mà bạn chưa nhập mật khẩu.");
                    return;
                }
                if (txtPass.uText.Contains(" "))
                {
                    MainErr.SetError(txtPass, "Mật khẩu không được chứa khoảng trắng");
                    return;
                }
                Pass = " PASSWORD ='" + txtPass.uText.Trim().Replace("'", "''") + "', ";
            }
            string strRestore = "RESTORE DATABASE [" + Program.sDatabaseName + "] FROM DISK = '" + Dir + "' WITH " + Pass + " REPLACE";
            if (!Restores(strRestore))
            {
                return;
            }
            XtraMessageBox.Show("Dữ liệu đã được phục hồi thành công. Bạn hãy thoát ra để đăng nhập vào chương trình.", "Phục hồi dữ liệu");
        }
        private bool Restores(string strRestore)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = new SqlConnection("Server = " + Program.sServerName + " ; " + " User ID = " + Program.sUserName + " ; " + " Password = " + Program.SPassword);
                try
                {
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                SqlCommand cmd = new SqlCommand(strRestore, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 3279:
                        {
                            XtraMessageBox.Show("Chương trình phát hiện lỗi trong quá trình phịc hồi sữ liệu vởi một trong các nguyên nhân sau:\n\t\t - Bạn nhập mật khẩu không đúng.\n\t\t - Tập tin chứa mật khẩu nhưng bạn không nhập.\n=t=t - Tập tin không chứa mật khẩu nhưng bạn nhập.\nBanj hãy kiểm tra lại", "Phục hồi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    case 3101:
                        {
                            XtraMessageBox.Show("Chương trình không thể tiếp tục được vì cơ sở dữ liệu đang được sử dụng. Bạn nên kiểm tra lại để chương trình được tiếp tục.", "Phục hồi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    case 3201:
                        {
                            XtraMessageBox.Show("File không tồn tại. Bạn hãy kiểm tra lại." + ex.Number, "Phục hồi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    default:
                        {
                            XtraMessageBox.Show("Chương trình phát hiện lỗi trong quá trình phục hồi dữ liệu. Bạn hãy kiểm tra lại.\nLỗi phát hiện được có ID là: " + ex.Number, "Phục hồi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                }
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Restore_Mode = false;
            Properties.Settings.Default.Save();
            if (XtraMessageBox.Show("Bạn có muốn quay lại chương trình chính hay không?", "Phục hồi dữ liệu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
                Application.Exit();
        }
    }
}