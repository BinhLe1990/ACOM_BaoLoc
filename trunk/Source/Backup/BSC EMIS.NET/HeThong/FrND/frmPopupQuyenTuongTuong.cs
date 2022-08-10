using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace BSC_HRM.NET.HeThong.FrND
{
    public partial class frmPopupQuyenTuongTuong : DevExpress.XtraEditors.XtraForm
    {
        public frmPopupQuyenTuongTuong()
        {
            InitializeComponent();
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clRun = new clsRun();
        public string NguoiDung = "";

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (cbxNGUOIDUNG.EditValue.ToString() == "")
            {
                XtraMessageBox.Show(this, "Bạn chưa chọn người dùng tương đương", "Chọn quyền tương đương", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Hashtable Col = new Hashtable();
            Col.Add("NGUOIDUNG", NguoiDung);
            DataTable dt = cnn.SelectRows("SELECT * FROM dbo.HT_NGUOIDUNG WHERE NGUOIDUNG='" + cbxNGUOIDUNG.EditValue.ToString() + "'");
            if (dt.Rows.Count > 0)
            {
                Hashtable Val = new Hashtable();
                Val.Add("HOATDONG", dt.Rows[0]["HOATDONG"]);
                Val.Add("KIEUGIAODIEN", dt.Rows[0]["KIEUGIAODIEN"]);
                Val.Add("QUYEN", dt.Rows[0]["QUYEN"]);
                Val.Add("MENU_NGANG", dt.Rows[0]["MENU_NGANG"]);
                Val.Add("MENU_DOC", dt.Rows[0]["MENU_DOC"]);
                Val.Add("DANH_MUC", dt.Rows[0]["DANH_MUC"]);
                Val.Add("LINH_VUC", dt.Rows[0]["LINH_VUC"]);
                cnn.UpdateRows(Val, Col, "HT_NGUOIDUNG");
                XtraMessageBox.Show(this, "Phân quyền đã được lưu thành công", "Chọn quyền tương đương", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show(this, "Không tìm thấy thông tin người dùng", "Chọn quyền tương đương", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void frmPopupQuyenTuongTuong_Load(object sender, EventArgs e)
        {
            DataTable dtVal = cnn.SelectRows("SELECT * FROM HT_NGUOIDUNG WHERE NGUOIDUNG NOT IN ('1','2','3','" + NguoiDung + "')");
            cbxNGUOIDUNG.DataBindings.Add("EditValue", dtVal, "NGUOIDUNG");
            cbxNGUOIDUNG.Properties.DataSource = dtVal;
        }
    }
}