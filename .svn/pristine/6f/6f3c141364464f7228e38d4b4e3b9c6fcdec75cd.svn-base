using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.NhanSu
{
    public partial class frmTongHopQuaTrinh : DevExpress.XtraEditors.XtraForm
    {
        public frmTongHopQuaTrinh()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
        }

        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKey = "";
        private void frmTongHopQuaTrinh_Load(object sender, EventArgs e)
        {
            LoadQuaTrinh();
        }
        private void LoadQuaTrinh()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Filter");            
            dt.Rows.Add(new object[] { "1", "Quá trình lương" });
            dt.Rows.Add(new object[] { "2", "Quá trình chức vụ" });           
            dt.Rows.Add(new object[] { "3", "quá trình công tác" });
            dt.Rows.Add(new object[] { "4", "Quá trình khen thưởng" });
            dt.Rows.Add(new object[] { "5", "Quá trình kỷ luật" });
            dt.Rows.Add(new object[] { "6", "Quá trình đào tạo" });            
            dt.Rows.Add(new object[] { "7", "Quá trình chuyển công tác" });
            dt.Rows.Add(new object[] { "8", "Tai nạn lao động" });
            dt.Rows.Add(new object[] { "9", "Văn bằng chứng chỉ" });
            dt.Rows.Add(new object[] { "10", "Quan hệ gia đình" });
            cboQuaTrinh.uDataSource = dt;
            cboQuaTrinh.uDisplayMember = "Filter";
            cboQuaTrinh.uValueMember = "ID";
        }

        private void cboQuaTrinh_uEditValueChanged(object sender, EventArgs e)
        {
            switch (cboQuaTrinh.uEditValue.ToString())
            {                
                case "1":
                    sKey = "QUATRINHLUONG";
                    break;

                case "2":
                    sKey = "QUATRINHCHUCVU";
                    break;
                
                case "3":
                    sKey = "QUATRINHCONGTAC";
                    break;
                case "4":
                    sKey = "QUATRINHKHENTHUONG";
                    break;
                case "5":
                    sKey = "QUATRINHKYLUAT";
                    break;
                case "6":
                    sKey = "QUATRINHDAOTAO";
                    break;
                
                case "7":
                    sKey = "QUATRINHCHUYENCONGTAC";
                    break;
                case "8":
                    sKey = "TAINANLAODONG";
                    break;

                case "9":
                    sKey = "VANBANGCHUNGCHI";
                    break;
                case "10":
                    sKey = "QUANHEGIADINH";
                    break;
                default:
                    sKey = "";
                    break;                    
            }
            if (sKey == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn loại quá trình", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dtg.sKEY = sKey;
                uFind1.sKEY = sKey;
            }
        }

        private void uFind1_uClick(object sender, EventArgs e, DataTable dt)
        {
            if (sKey == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn loại quá trình", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }   
            dtg.uDataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            if (sKey == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn loại quá trình", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dt = dtg.GetDataSource();
            BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\" + sKey + ".repx",dt);
            frm.Show();
        }            
    }
}