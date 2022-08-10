using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BSC_HRM.NET.ThamSoSQL
{
    public partial class frmPopupNhapThamSo : DevExpress.XtraEditors.XtraForm
    {
        public frmPopupNhapThamSo()
        {
            InitializeComponent();
            srun.SetValueToControl(this);
        }
        BSC_Class.BSCConnection cnn = new BSC_Class.BSCConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        clsRun srun = new clsRun();

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            return;
        }
    }
}