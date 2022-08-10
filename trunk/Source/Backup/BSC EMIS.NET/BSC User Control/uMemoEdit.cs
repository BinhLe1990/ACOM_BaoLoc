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
    public partial class uMemoEdit : DevExpress.XtraEditors.XtraUserControl
    {
        public uMemoEdit()
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
                    lblCaption.Size = new System.Drawing.Size(lblCaption.Size.Width, 20);
                }
                else
                {
                    lblCaption.Dock = DockStyle.Left;
                    lblCaption.Width = 80;
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
        [Category("UserDefine"), DefaultValue("Default")]
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

        [Category("UserDefine"), DefaultValue("Normal"), Description("Gets or sets the character casing appliied to the editer's content.")]
        public System.Windows.Forms.CharacterCasing uCharacterCasing
        {
            get { return txtValue.Properties.CharacterCasing; }
            set { txtValue.Properties.CharacterCasing = value; }
        }


        #region Event

        [Category("UserDefine")]
        public event System.EventHandler uTextChanged;
        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            if (uTextChanged != null)
                uTextChanged(this, e);
        }

        [Category("UserDefine")]
        public event System.EventHandler uValidated;
        private void txtValue_Validated(object sender, EventArgs e)
        {
            if (uValidated != null)
                uValidated(this, e);
        }

        [Category("UserDefine")]
        public event System.ComponentModel.CancelEventHandler uValidating;
        private void txtValue_Validating(object sender, CancelEventArgs e)
        {
            if (uValidating != null)
                uValidating(this, e);
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
        public event System.EventHandler uEditValueChanged;
        private void txtValue_EditValueChanged(object sender, EventArgs e)
        {

            if (uEditValueChanged != null)
                uEditValueChanged(this, e);
        }

        [Category("UserDefine")]
        public event System.EventHandler uDoubleClick;
        private void txtValue_DoubleClick(object sender, EventArgs e)
        {
            if (uDoubleClick != null)
                uDoubleClick(this, e);
        }
        #endregion
    }
}
