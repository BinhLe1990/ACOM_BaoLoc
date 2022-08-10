using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace DELFI_WHM.NET.FrHT.FrND
{
    public partial class frmNDDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmNDDoiMatKhau()
        {
            InitializeComponent();
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_Class.DELFIConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuuQuyen_Click(object sender, EventArgs e)
        {
            if (txtMKCu.uText.Trim().Length <= 0)
            {
                XtraMessageBox.Show(this, "Bạn chưa nhập mật khẩu cũ", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMKCu.Focus();
                return;
            }
            if (txtMatKhau.uText.Length <= 0)
            {
                XtraMessageBox.Show(this, "Mật khẩu của người dùng không được để trống", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            if (!txtMatKhau.uText.Equals(txtXacNhan.uText))
            {
                XtraMessageBox.Show(this, "Mật khẩu xác nhận không đúng với mật khẩu mà bạn đã nhập", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }
            Hashtable Con = new Hashtable();
            Con.Add("TAIKHOAN", Properties.Settings.Default.USER_NAME);
            Hashtable Val = new Hashtable();
            Con.Add("MATKHAU", DELFI_Class.EncryptAndDecrypt.Encrypt(txtMKCu.uText, "Delfi VN"));
            try
            {
                if (cnn.SelectRows(Con, "HT_NGUOIDUNG").Rows.Count<=0)
                {
                    XtraMessageBox.Show(this, "Mật khẩu cũ mà bạn đã nhập không đúng", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMKCu.Focus();
                    return;
                }
            }
            catch
            {
                XtraMessageBox.Show(this, "Mật khẩu cũ mà bạn đã nhập không đúng", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKCu.Focus();
                return;
            }
            Con.Clear();
            Con.Add("TAIKHOAN", Properties.Settings.Default.USER_NAME);
            Val.Add("MATKHAU", DELFI_Class.EncryptAndDecrypt.Encrypt(txtMatKhau.uText, "Delfi VN"));
            if (cnn.UpdateRows(Val, Con, "HT_NGUOIDUNG"))
                XtraMessageBox.Show(this, "Mật khẩu của người dùng đã được thay đổi", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(this, "Không thể thay đổi mật khẩu cho người dùng mà bạn đã chọn được", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}