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
using DELFI_WHM.NET.Models;
using System.Linq;

namespace DELFI_WHM.NET.FrHT.FrND
{
    public partial class frmTaoNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_Class.DELFIConnection(Program.sConnection);
        int _ID = 0;
        public frmTaoNguoiDung()
        {
            InitializeComponent();
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnTaoNguoiDung_Click(object sender, EventArgs e)
        {
            if (spnID.uValue == 0)
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

                Hashtable Val = new Hashtable();
                Val.Add("TAIKHOAN", txtTaiKhoan.uText);
                Val.Add("HOTEN", txtHoTen.uText);
                Val.Add("QUYENPHANQUYEN", chkQuyenPhanQuyen.Checked);
                Val.Add("KIEUGIAODIEN", "Money Twins");
                Val.Add("GHICHU", txtGhichu.uText + " ");
                Val.Add("MATKHAU", DELFI_Class.EncryptAndDecrypt.Encrypt(txtMatKhau.uText, "Delfi VN"));
                if (cnn.InsertNewRow(Val, "HT_NGUOIDUNG"))
                    XtraMessageBox.Show(this, "Tài khoản người dùng đã được tạo thành công", "Tạo người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show(this, "Không thể lưu tài khoản người dùng mà bạn đã chọn được", "Tạo người dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    var list = db.HT_NGUOIDUNG.Where(c => c.NGUOIDUNG == spnID.uValue).FirstOrDefault();
                    list.HOATDONG = chkActive.Checked;
                    if (db.SaveChanges() > 0)
                    {
                        XtraMessageBox.Show("Cập nhật trạng thái thành công", "Thông báo");
                    }
                }
            }
        }

        private void frmTaoNguoiDung_Load(object sender, EventArgs e)
        {
            spnID.uValue = ID;
            if (ID != 0)
            {
                txtTaiKhoan.bIsReadOnly = true;
                txtHoTen.bIsReadOnly = true;
                txtMatKhau.bIsReadOnly = true;
                txtXacNhan.bIsReadOnly = true;
                txtGhichu.bIsReadOnly = true;
                chkQuyenPhanQuyen.ReadOnly = true;
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    var list = db.HT_NGUOIDUNG.Where(c => c.NGUOIDUNG == ID).ToList();
                    txtTaiKhoan.uText = list[0].TAIKHOAN;
                    txtHoTen.uText = list[0].HOTEN;
                    txtMatKhau.uText = list[0].MATKHAU;
                    txtXacNhan.uText = list[0].MATKHAU;
                    txtGhichu.uText = list[0].GHICHU;
                    chkQuyenPhanQuyen.Checked = Convert.ToBoolean(list[0].QUYENPHANQUYEN);
                    chkActive.Checked = Convert.ToBoolean(list[0].HOATDONG);
                }
            }
            else
            {
                chkActive.Checked = true;
            }
        }

    }
}