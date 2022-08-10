using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;
namespace DELFI_WHM.NET
{
    public partial class frmProcess : Form
    {
        public frmProcess()
        {
            InitializeComponent();
        }
        /// <summary>
        /// frmProcess: Form đợi trong khi đang Load 1 Form khác
        /// </summary>
        /// <param name="ff">Form cần load</param>
        /// <param name="Dialog">Kiểu mở (Show (false), ShowDialog(true))</param>
        public frmProcess(Form ff, bool Dialog)
        {
            this.bDialog = Dialog;
            frm = ff;
            InitializeComponent();
        }

        public frmProcess(Form ff, bool Dialog, Form Parent)
        {
            this.bDialog = Dialog;
            frm = ff;
            frParent = Parent;
            InitializeComponent();
        }
        Form frParent = new Form();
        /// <summary>
        /// Form đợi trong khi đang Load 1 Form khác
        /// </summary>
        /// <param name="ff">Form cần load, form này sẽ mở ra theo kiểu Tab, với Mdiparent là frmMain</param>
        public frmProcess(Form ff)
        {
            frm = ff;
            InitializeComponent();
        }
        bool bDialog = false;
        Form frm = new Form();
        private void frmProcess_Load(object sender, EventArgs e)
        {
            bkwProcess.RunWorkerAsync(sender);
        }
        private void bkwProcess_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void bkwProcess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!bDialog)
            {
                if (frParent.Name == "")
                    frm.MdiParent = this.MdiParent;
                frm.Show();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                //DialogResult = DialogResult.OK;
                this.Hide();
                this.Close();
                frm.ShowDialog();
            }
        }
    }
}