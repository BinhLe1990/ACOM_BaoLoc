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
    public partial class BSCEmisNamHoc : UserControl
    {
        public BSCEmisNamHoc()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(240, 20);
            int NamBatDau = DateTime.Now.Month < 6 ? DateTime.Now.Year - 1 : DateTime.Now.Year;
            udNamHoc.EditValue = (NamBatDau + " - " + (NamBatDau + 1));
        }


        [Category("UserDefine"), DefaultValue("Caption")]
        public string sCaption
        {
            get
            {
                return this.lblCaption.Text;
            }
            set
            {
                if (this.lblCaption.Text == value)
                    return;
                this.lblCaption.Text = value;
            }
        }
        [Category("UserDefine"), DefaultValue(false)]
        public bool bIsReadOnly
        {
            get
            {
                return udNamHoc.Properties.ReadOnly;
            }
            set
            {
                if (udNamHoc.Properties.ReadOnly == value)
                    return;
                udNamHoc.Properties.ReadOnly = value;
            }
        }

        [Category("UserDefine"), DefaultValue(100)]
        public int iWidth
        {
            get
            {
                return this.lblCaption.Width;
            }
            set
            {
                if (this.lblCaption.Width == value)
                    return;
                this.lblCaption.Width = value;
            }
        }


        [Category("UserDefine"), DefaultValue(DevExpress.Utils.HorzAlignment.Default)]
        public DevExpress.Utils.HorzAlignment bLabelAlignment
        {
            get
            {
                return this.lblCaption.Appearance.TextOptions.HAlignment;
            }
            set
            {
                lblCaption.Appearance.TextOptions.HAlignment = value;
            }
        }

        [Category("UserDefine"), DefaultValue(DevExpress.Utils.HorzAlignment.Default)]
        public DevExpress.Utils.HorzAlignment bHAlignment
        {
            get
            {
                return this.udNamHoc.Properties.Appearance.TextOptions.HAlignment;
            }
            set
            {
                if (this.udNamHoc.Properties.Appearance.TextOptions.HAlignment == value)
                    return;
                this.udNamHoc.Properties.Appearance.TextOptions.HAlignment = value;
            }
        }

        [Category("UserDefine"), DefaultValue(false)]
        public bool bLabelTopDock
        {
            get
            {
                return (lblCaption.Dock == DockStyle.Top);
            }
            set
            {
                if (value == true)
                {
                    lblCaption.Dock = DockStyle.Top;
                    this.Height = 42;
                }
                else
                {
                    lblCaption.Dock = DockStyle.Left;
                    this.iWidth = 80;
                    this.Height = 22;
                }
            }
        }

        public int iYear
        {
            get
            {
                int _Year = DateTime.Now.Month < 6 ? DateTime.Now.Year - 1 : DateTime.Now.Year;
                try
                {
                    _Year = int.Parse(udNamHoc.EditValue.ToString().Substring(0, 4));
                }
                catch { }
                return _Year;
            }
            set
            {
                udNamHoc.EditValue = (value + " - " + (value + 1));
            }
        }
        private void udNamHoc_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit edit = sender as ButtonEdit;
            int iYear = DateTime.Now.Month < 6 ? DateTime.Now.Year - 1 : DateTime.Now.Year;
            try
            {
                iYear = int.Parse(udNamHoc.EditValue.ToString().Substring(0, 4));
            }
            catch { }
            switch (edit.Properties.Buttons.IndexOf(e.Button))
            {
                case 0:
                    udNamHoc.EditValue = ((iYear - 1) + " - " + iYear);
                    break;
                case 1:
                    udNamHoc.EditValue = ((iYear + 1) + " - " + (iYear + 2));
                    break;
            }
        }
        public event System.EventHandler uEditValueChanged;
        private void udNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if(uEditValueChanged != null)
                this.uEditValueChanged(this, e);
        }

        private void udNamHoc_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void udNamHoc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down || e.KeyData == Keys.Left)
                udNamHoc_ButtonPressed(udNamHoc, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(udNamHoc.Properties.Buttons[0]));
            else if (e.KeyData == Keys.Up || e.KeyData == Keys.Right)
                udNamHoc_ButtonPressed(udNamHoc, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(udNamHoc.Properties.Buttons[1]));
        }

        private void udNamHoc_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void udNamHoc_Properties_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                udNamHoc_ButtonPressed(udNamHoc, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(udNamHoc.Properties.Buttons[1]));
            }
            else
                udNamHoc_ButtonPressed(udNamHoc, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(udNamHoc.Properties.Buttons[0]));
        }
    }
}