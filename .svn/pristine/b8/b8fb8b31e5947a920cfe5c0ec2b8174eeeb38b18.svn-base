using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET
{
    public partial class frmWebBrowser : DevExpress.XtraEditors.XtraForm
    {
        public frmWebBrowser()
        {
            InitializeComponent();
            txtAdr.Text = "www.google.com.vn";
            Cursor.Current = Cursors.WaitCursor;
            webBrowser1.Navigate(txtAdr.Text);
            Cursor.Current = Cursors.Default;
        }

        private string[] History = new string[100];
        private int count = 0;

        public frmWebBrowser(string sLink)
        {
            InitializeComponent();
            txtAdr.Text = sLink;
            Cursor.Current = Cursors.WaitCursor;
            webBrowser1.Navigate(txtAdr.Text);
            Cursor.Current = Cursors.Default;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            webBrowser1.Navigate(txtAdr.Text);
            Cursor.Current = Cursors.Default;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == btnBack.Name)
            {
                if (count > 0)                                  
                {
                    count = count - 1;                          
                    txtAdr.Text = History[count];   
                    //webBrowser1.Navigate(txtAdr.Text);       
                    webBrowser1.GoBack();
                    btnPrevious.Enabled = true;
                }
            }
            if (e.ClickedItem == btnRefresh)
            {
                webBrowser1.Refresh();
            }
            if (e.ClickedItem == btnHome)
            {
                webBrowser1.GoHome();
            }
            if (e.ClickedItem == btnPrevious)
            {
                if (count < 100)
                {
                    count = count + 1;
                    txtAdr.Text = History[count];
                    //webBrowser1.Navigate(txtAdr.Text);
                    webBrowser1.GoForward();
                    btnBack.Enabled = true;

                    count = count + 1;
                    if (History[count] == null)
                    {
                        btnPrevious.Enabled = false;
                        //btnListBack.DropDownItems.Add();
                    }
                    count = count - 1;
                }
            }
            if (e.ClickedItem == btnStop)
            {
                webBrowser1.Stop();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txtAdr.Text = webBrowser1.Url.ToString();
            this.Text = webBrowser1.Document.Title;
            toolStripProgressBar1.Step = 10;
            toolStripProgressBar1.PerformStep();
            toolStripProgressBar1.Visible = false;
            lblOpenning.Visible = false;
            lbDone.Visible = true;

            if (History[count].ToString() != webBrowser1.Url.ToString())
            {
                count = count + 1;
                History[count] = txtAdr.Text;
            }
            if (count > 0)
            {
                btnBack.Enabled = true;
            }
            else
            {
                btnBack.Enabled = false;
            }
        }

        private void webBrowser1_LocationChanged(object sender, EventArgs e)
        {
            //this.Text = webBrowser1.Document.Title;
            //txtAdr.Text = webBrowser1.Url.ToString();
        }

        private void txtAdr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cursor.Current = Cursors.WaitCursor;
                webBrowser1.Navigate(txtAdr.Text);
                Cursor.Current = Cursors.Default;
            }
        }

        private void frmWebBrowser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                txtAdr.Focus();
            }
        }

        private void webBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                txtAdr.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                webBrowser1.Refresh();
            }
            else if (e.KeyCode == Keys.F3)
            {
                webBrowser1.GoHome();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                webBrowser1.Stop();
            }
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
           toolStripProgressBar1.Visible = true;
           toolStripProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
           toolStripProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);
           toolStripProgressBar1.Visible = false;
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            toolStripProgressBar1.Step = 80;
            toolStripProgressBar1.PerformStep();
            txtAdr.Text = webBrowser1.Url.ToString();
            lblOpenning.Text = "Đang mở trang: " + txtAdr.Text;
            lblOpenning.Visible = true;
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            lbDone.Visible = false;
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = 100;
            toolStripProgressBar1.Step = 10;
            toolStripProgressBar1.PerformStep();
        }
    }
}