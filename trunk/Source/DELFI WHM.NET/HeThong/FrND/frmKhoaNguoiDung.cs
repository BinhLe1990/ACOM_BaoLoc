using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using DELFI_WHM.NET.Models;

namespace DELFI_WHM.NET.HeThong.FrND
{
    public partial class frmKhoaNguoiDung : Form
    {
        public frmKhoaNguoiDung()
        {
            InitializeComponent();
        }

        private void frmKhoaNguoiDung_Load(object sender, EventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var data = db.HT_NGUOIDUNG.ToList();
                if (data != null)
                {
                    cbxNGUOIDUNG.Properties.DataSource = data;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                HT_NGUOIDUNG nd = db.HT_NGUOIDUNG.Where(c => c.TAIKHOAN == cbxNGUOIDUNG.EditValue.ToString()).FirstOrDefault();
                if (nd != null)
                {
                    nd.HOATDONG = chkKhoa.Checked;
                    nd.QUYENPHANQUYEN = nd.QUYENPHANQUYEN;
                    if (db.SaveChanges() > 0)
                    {
                        XtraMessageBox.Show("Cập nhật thông tin thành công.", "Thông báo");
                    }
                }
            }
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
