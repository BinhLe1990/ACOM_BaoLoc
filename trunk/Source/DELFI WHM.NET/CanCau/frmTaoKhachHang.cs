using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DELFI_WHM.NET;
using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.CanCau
{
    public partial class frmTaoKhachHang : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string _MaKhachHang = "";

        public frmTaoKhachHang()
        {
            InitializeComponent();
        }


        private bool Check_Cond()
        {
            if (txtMaKhachHang.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Mã khách hàng không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTenKhachHang.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Tên khách hàng không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            _MaKhachHang = txtMaKhachHang.uText;
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var kh = db.DM_KhachHang.Where(c => c.MaKhachHang == _MaKhachHang).ToList();
                if (kh.Count> 0)
                {
                    XtraMessageBox.Show("Mã khách hàng đã tồn tại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }               
            }
                return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Check_Cond())
                return;

            using (DBACOMEntities db = new DBACOMEntities())
            { db.DM_KhachHang.Add(new DM_KhachHang
            {
                        MaKhachHang = txtMaKhachHang.uText,
                        TenKhachHang = txtTenKhachHang.uText
                    });
                  if(  db.SaveChanges() > 0)
                {
                    XtraMessageBox.Show("Thêm mới thành công", "Thông báo");
                }
            }
        }  
    }
}
