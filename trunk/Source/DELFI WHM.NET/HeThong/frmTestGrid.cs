using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BSC_EMIS.NET.FrHT
{
    public partial class frmTestGrid : DevExpress.XtraEditors.XtraForm
    {
        BSC_Class.BSCConnection cnn = new BSC_Class.BSCConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        public frmTestGrid()
        {
            InitializeComponent();
        }

        private void frmTestGrid_Load(object sender, EventArgs e)
        {
        }

        private void bscEmisNamHoc1_Load(object sender, EventArgs e)
        {

        }
    }
}