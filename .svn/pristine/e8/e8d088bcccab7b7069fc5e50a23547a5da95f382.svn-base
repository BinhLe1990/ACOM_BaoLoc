using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.ThamSoSQL
{
    public partial class frmPopupNhapThamSo : DevExpress.XtraEditors.XtraForm
    {
        public frmPopupNhapThamSo()
        {
            InitializeComponent();
            srun.SetValueToControl(this);
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_Class.DELFIConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        clsRun srun = new clsRun();

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            return;
        }
    }
}