using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace DELFI_WHM.NET
{
    public partial class frmThayDoiHinhNem : DevExpress.XtraEditors.XtraForm
    {
        public frmThayDoiHinhNem()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clsRun = new clsRun();

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            txtPathHinhAnh.uText = ShowOpenFileDialog();
            try
            {
                picHinhAnh.Image = clsRun.GetHinhAnh(txtPathHinhAnh.uText).Image;
                btnLuuThongTin.Enabled = true;
            }
            catch (System.Exception ex)
            {
                picHinhAnh.Image = null;
                btnLuuThongTin.Enabled = false;
            }
        }

        private string ShowOpenFileDialog()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Image Files";
            dlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK) return dlg.FileName;
            return "";
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            Hashtable Val = new Hashtable();
            Hashtable Con = new Hashtable();
            Val.Add("PathHinhAnh", txtPathHinhAnh.uText);
            Con.Add("NGUOIDUNG", Properties.Settings.Default.USER_ID);
            if (cnn.UpdateRows(Val, Con, "HT_NGUOIDUNG"))
                XtraMessageBox.Show(this, "Quyền cho người dùng đã được lưu lại thành công", "Lưu quyền người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(this, "Không thể lưu quyền cho người dùng mà bạn đã chọn được", "Lưu quyền người dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}