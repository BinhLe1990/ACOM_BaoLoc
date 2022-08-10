using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace BSC_EMIS.NET.HeThong
{
    public partial class frmTSHeThong : DevExpress.XtraEditors.XtraForm
    {
        public frmTSHeThong()
        {
            InitializeComponent();
        }
        BSC_Class.BSCConnection cnn = new BSC_Class.BSCConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            Hashtable Val = new Hashtable();
            Val.Add("COQUANCHUQUAN", txtCoQuan.Text);
            Val.Add("TENCOQUAN", txtTenTruong.Text);
            Val.Add("DIACHI", txtDiaChi.Text);
            Val.Add("DIENTHOAI", txtDienThoai.Text);
            Val.Add("MAIL", txtEmail.Text);
            Val.Add("DIADIEM", txtDiaDiem.Text);

            if (cnn.InsertNewRow(Val, "HT_HETHONG"))
            {
                XtraMessageBox.Show(this, "Thông số hệ thống đã được cập nhật thành công", "Thông số hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                XtraMessageBox.Show(this, "Thông số hệ thống mà bạn nhập không thể cập nhật được", "Thông số hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}