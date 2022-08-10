using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BSC_HRM.NET.NhanSu
{
    public partial class frmQuaTrinhTangThamNienGD : DevExpress.XtraEditors.XtraForm
    {
        public frmQuaTrinhTangThamNienGD()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            dtg.sKEY = sKey;
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKey = "QUATRINHTANGTHAMNIENGIAODUC";
        private int iQuaTrinhKhenThuong = 0;
        public int iNhanSu = 0;   
     

        private void frmQuaTrinhKhenThuong_Load(object sender, EventArgs e)
        {
            uNhanSu1.LoadHS(iNhanSu);
            LoadQuaTrinhTangThamNien();
        }
        private void LoadQuaTrinhTangThamNien()
        {
            string sSQL = cnn.GetSQLString(sKey);
            sSQL = "Select * from (" + sSQL + ")A where Nhansu=" + iNhanSu;
            dtg.uDataSource = cnn.DT_DataTable(sSQL);
        }
        

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}