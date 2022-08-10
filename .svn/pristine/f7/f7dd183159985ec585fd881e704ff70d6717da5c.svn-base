using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BSC_HRM.NET.BSC_User_Control
{
    public partial class uNumPad : DevExpress.XtraEditors.XtraUserControl
    {
        public uNumPad()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            SendKeys.Send("{" + btn.Text + "}");
        }
    }
}
