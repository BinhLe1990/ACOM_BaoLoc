using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace BSC_HRM.NET
{
    public partial class frmAbout : DevExpress.XtraEditors.XtraForm
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start(lbWebsite.Text);
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lbProductName.Text = "Product Name: " + Application.ProductName;
            lbVersion.Text = "Version: "+Application.ProductVersion;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Process.Start("MSInfo32");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Process.Start(lbWebsite.Text);
        }
    }
}