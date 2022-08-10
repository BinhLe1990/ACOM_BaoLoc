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
    public partial class uSpinEdit : DevExpress.XtraEditors.XtraUserControl
    {
        public uSpinEdit()
        {
            InitializeComponent();
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

        [Category("UserDefine"), DefaultValue(false)]
        public bool bIsPassword
        {
            get
            {
                return txtValue.Properties.PasswordChar == '\u25CF' ? true : false;
            }
            set
            {
                if (value)
                    txtValue.Properties.PasswordChar = '\u25CF';
                else
                    txtValue.Properties.PasswordChar = new char();
            }
        }
        [Category("UserDefine"), DefaultValue(false)]
        public bool bIsReadOnly
        {
            get
            {
                return txtValue.Properties.ReadOnly;
            }
            set
            {
                if (txtValue.Properties.ReadOnly == value)
                    return;
                txtValue.Properties.ReadOnly = value;
            }
        }
        [Category("UserDefine"), DefaultValue("")]
        public string sNullText
        {
            get
            {
                return txtValue.Properties.NullText;
            }
            set
            {
                if (txtValue.Properties.NullText == value)
                    return;
                txtValue.Properties.NullText = value;
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
                    lblCaption.Width = 80;
                    this.Height = 22;
                }
            }
        }

        [Category("UserDefine"), DefaultValue("")]
        public string uText
        {
            get
            {
                return txtValue.Text;
            }
            set
            {
                if (txtValue.Text == value)
                    return;
                txtValue.Text = value;
            }
        }

        [Category("UserDefine"), DefaultValue(0)]
        public int iMaxLength
        {
            get
            {
                return this.txtValue.Properties.MaxLength;
            }
            set
            {
                if (this.txtValue.Properties.MaxLength == value)
                    return;
                this.txtValue.Properties.MaxLength = value;
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
        public DevExpress.Utils.HorzAlignment bHAlignment
        {
            get
            {
                return this.txtValue.Properties.Appearance.TextOptions.HAlignment;
            }
            set
            {
                if (this.txtValue.Properties.Appearance.TextOptions.HAlignment == value)
                    return;
                this.txtValue.Properties.Appearance.TextOptions.HAlignment = value;
            }
        }
        [Category("UserDefine"), DefaultValue(false)]
        public bool bUseMask
        {
            get
            {
                return txtValue.Properties.Mask.UseMaskAsDisplayFormat;
            }
            set
            {
                if (txtValue.Properties.Mask.UseMaskAsDisplayFormat == value)
                    return;
                txtValue.Properties.Mask.UseMaskAsDisplayFormat = value;
            }
        }

        [Category("UserDefine"), DefaultValue("")]
        public string sEditMask
        {
            get
            {
                return txtValue.Properties.Mask.EditMask;
            }
            set
            {
                if (txtValue.Properties.Mask.EditMask == value)
                    return;
                txtValue.Properties.Mask.EditMask = value;
            }
        }

        [Category("UserDefine"), DefaultValue("None")]
        public DevExpress.XtraEditors.Mask.MaskType uMaskType
        {
            get
            {
                return txtValue.Properties.Mask.MaskType;
            }
            set
            {
                txtValue.Properties.Mask.MaskType = value;
            }
        }
        [Category("UserDefine"), DefaultValue(0)]
        public decimal uMaxValue
        {
            get
            {
                return txtValue.Properties.MaxValue;
            }
            set
            {
                txtValue.Properties.MaxValue = value;
            }
        }

        [Category("UserDefine"), DefaultValue(0)]
        public decimal uMinValue
        {
            get
            {
                return txtValue.Properties.MinValue;
            }
            set
            {
                txtValue.Properties.MinValue = value;
            }
        }

        [Browsable(false)]
        public decimal uValue
        {
            get { return txtValue.Value; }
            set { txtValue.Value = value; }
        }

        [Browsable(false)]
        public object uEditValue
        {
            get { return txtValue.EditValue; }
            set { txtValue.EditValue = value; }
        }

        #region Event
        [Category("UserDefine")]
        public event System.EventHandler uDoubleClick;
        private void txtValue_DoubleClick(object sender, EventArgs e)
        {
            if (uDoubleClick != null)
                uDoubleClick(this, e);
        }

        [Category("UserDefine")]
        public event System.Windows.Forms.KeyEventHandler uKeyDown;
        private void txtValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (uKeyDown != null)
                uKeyDown(this, e);
        }

        [Category("UserDefine")]
        public event System.Windows.Forms.KeyPressEventHandler uKeyPress;
        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (uKeyPress != null)
                uKeyPress(this, e);
        }

        [Category("UserDefine")]
        public event System.Windows.Forms.KeyEventHandler uKeyUp;
        private void txtValue_KeyUp(object sender, KeyEventArgs e)
        {

            if (uKeyUp != null)
                uKeyUp(this, e);
        }

        [Category("UserDefine")]
        public event System.Windows.Forms.MouseEventHandler uMouseDown;
        private void txtValue_MouseDown(object sender, MouseEventArgs e)
        {
            if (uMouseDown != null)
                uMouseDown(this, e);
        }

        [Category("UserDefine")]
        public event System.Windows.Forms.MouseEventHandler uMouseUp;
        private void txtValue_MouseUp(object sender, MouseEventArgs e)
        {
            if (uMouseUp != null)
                uMouseUp(this, e);
        }

        [Category("UserDefine")]
        public event System.EventHandler uValueChanged;
        private void txtValue_ValueChanged(object sender, EventArgs e)
        {

            if (uValueChanged != null)
                uValueChanged(this, e);
        }

        [Category("UserDefine")]
        public event System.EventHandler uValidated;
        private void txtValue_Validated(object sender, EventArgs e)
        {
            if (uValidated!= null)
                uValidated(this, e);
        }

        [Category("UserDefine")]
        public event DevExpress.XtraEditors.Controls.SpinEventHandler uSpin;
        private void txtValue_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            if (uSpin != null)
                uSpin(this, e);
        }
        #endregion

        [Category("UserDefine")]
        public event System.EventHandler uEditValueChanged;
        private void txtValue_EditValueChanged(object sender, EventArgs e)
        {
            if (uEditValueChanged != null)
                uEditValueChanged(this, e);
        }
    }
}
