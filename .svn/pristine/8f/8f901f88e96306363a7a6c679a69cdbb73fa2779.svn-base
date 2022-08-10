using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace DELFI_WHM.NET.FrHT.FrND
{
    public partial class frmTaoNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_Class.DELFIConnection(Program.sConnection);
        public frmTaoNguoiDung(DevExpress.XtraBars.Ribbon.RibbonControl ribControl)
        {
            InitializeComponent();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnTaoNguoiDung_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.uText.Length <= 0)
            {
                XtraMessageBox.Show(this, "Mật khẩu của người dùng không được để trống", "Tạo người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            if (!txtMatKhau.uText.Equals(txtXacNhan.uText))
            {
                XtraMessageBox.Show(this, "Mật khẩu xác nhận không đúng với mật khẩu mà bạn đã nhập", "Tạo người dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }
            if (cnn.SelectRows("select * from HT_NGUOIDUNG where lower(taikhoan) = N'" + txtTaiKhoan.uText.ToLower() + "'").Rows.Count > 0)
            {
                XtraMessageBox.Show("Tài khoản này đã có người sử dụng, bạn hãy chọn tên tài khoản khác.");
                return;
            }
            string sMa = cnn.SelectRows("SELECT MAX(CONVERT(INT, ISNULL(NGUOIDUNG, 0)))+1 ID FROM ht_nguoidung").Rows[0][0].ToString();

            Hashtable Val = new Hashtable();
            Val.Add("NGUOIDUNG", sMa);
            Val.Add("TAIKHOAN", txtTaiKhoan.uText);
            Val.Add("HOTEN", txtHoTen.uText);
            Val.Add("QUYENPHANQUYEN", chkQuyenPhanQuyen.Checked);
            Val.Add("KIEUGIAODIEN", "Money Twins");
            Val.Add("MATKHAU", DELFI_Class.EncryptAndDecrypt.Encrypt(txtMatKhau.uText, "Delfi VN"));
            if (cnn.InsertNewRow(Val, "HT_NGUOIDUNG"))
                XtraMessageBox.Show(this, "Tài khoản người dùng đã được tạo thành công", "Tạo người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(this, "Không thể lưu tài khoản người dùng mà bạn đã chọn được", "Tạo người dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmTaoNguoiDung_Load(object sender, EventArgs e)
        {

        }

    }
}