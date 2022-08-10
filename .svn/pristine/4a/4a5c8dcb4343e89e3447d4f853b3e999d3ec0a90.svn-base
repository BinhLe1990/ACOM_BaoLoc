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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_Class.DELFIConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        public frmDoiMatKhau()
        {
            InitializeComponent();
            DataTable dtVal = new DataTable();
            if (Properties.Settings.Default.USER_NAME == "Administrator")
            {
                dtVal = cnn.SelectRows("SELECT * FROM HT_NGUOIDUNG where TaiKhoan <> N'Supervisor' ORDER BY HoTEN, TAIKHOAN");
            }
            else if (Properties.Settings.Default.USER_NAME == "Supervisor")
            {
                dtVal = cnn.SelectRows("SELECT * FROM HT_NGUOIDUNG ORDER BY HoTEN, TAIKHOAN");
            }
            else
            {
                dtVal = cnn.SelectRows("SELECT * FROM HT_NGUOIDUNG where TaiKhoan not in (N'Administrator', N'Supervisor') ORDER BY HoTEN, TAIKHOAN");
            }
            cbxNGUOIDUNG.DataBindings.Add("EditValue", dtVal, "NGUOIDUNG");
            cbxNGUOIDUNG.Properties.DataSource = dtVal;
        }

        private void btnLuuQuyen_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.uText.Length <= 0)
            {
                XtraMessageBox.Show(this, "Mật khẩu của người dùng không được để trống", "Đổi mật khẩu người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            if (!txtMatKhau.uText.Equals(txtXacNhan.uText))
            {
                XtraMessageBox.Show(this, "Mật khẩu xác nhận không đúng với mật khẩu mà bạn đã nhập", "Đổi mật khẩu người dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }
            Hashtable Con = new Hashtable();
            Con.Add("NGUOIDUNG", cbxNGUOIDUNG.EditValue.ToString());
            Hashtable Val = new Hashtable();
            Val.Add("MATKHAU", DELFI_Class.EncryptAndDecrypt.Encrypt(txtMatKhau.uText, "Delfi VN"));
            if (cnn.UpdateRows(Val, Con, "HT_NGUOIDUNG"))
                XtraMessageBox.Show(this, "Mật khẩu của người dùng đã được thay đổi", "Đổi mật khẩu người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(this, "Không thể thay đổi mật khẩu cho người dùng mà bạn đã chọn được", "Đổi mật khẩu người dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}