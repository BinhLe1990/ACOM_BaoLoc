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
    public partial class frmTimKiemNhanSu : DevExpress.XtraEditors.XtraForm
    {
        public frmTimKiemNhanSu()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            dtg.sKEY = sKey;
            uFind1.sKEY = sKey;
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection();
        clsRun clsRun = new clsRun();
        string sKey = "HOSONHANSU";
        public int iNhanSu;
        public string sNhanSu;

        private void uFind1_uClick(object sender, EventArgs e, DataTable dt)
        {
            dtg.uDataSource = dt;
        }

        private void dtg_uDoubleClick(object sender, EventArgs e)
        {
            iNhanSu = cnn.sNull2Int(dtg.CurRow["NhanSu"]);
            sNhanSu = cnn.sNull2String(dtg.CurRow["MA"]);
            this.DialogResult = DialogResult.OK;
        }
    }
}