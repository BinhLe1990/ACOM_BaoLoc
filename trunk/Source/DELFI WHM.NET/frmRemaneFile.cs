using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BSC_EMIS.NET
{
    public partial class frmRemaneFile : Form
    {
        public frmRemaneFile()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DirectoryInfo dInf = new DirectoryInfo(txtDir.Text);
            foreach (FileInfo fi in dInf.GetFiles())
            {
                File.Move(fi.FullName, fi.FullName.Replace("%20", " "));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                listFile.Items.Clear();
                txtDir.Text = folderBrowserDialog1.SelectedPath;
                DirectoryInfo dInf = new DirectoryInfo(txtDir.Text);
                foreach (FileInfo fi in dInf.GetFiles())
                {
                    listFile.Items.Add(fi.Name);
                }
            }
        }
    }
}