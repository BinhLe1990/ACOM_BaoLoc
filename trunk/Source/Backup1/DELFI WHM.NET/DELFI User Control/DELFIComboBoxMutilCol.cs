using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DELFI_WHM.NET.DELFI_User_Control
{
    public partial class BSCComboBoxMutilCol : UserControl
    {
        public BSCComboBoxMutilCol()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(240, 20);
        }
        public string bCaption
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
        public string bNullText
        {
            get
            {
                return lookUpEditValue.Properties.NullText;
            }
            set
            {
                if (lookUpEditValue.Properties.NullText == value)
                    return;
                lookUpEditValue.Properties.NullText = value;
            }
        }
        public string bValueMember
        {
            get
            {
                return lookUpEditValue.Properties.ValueMember;
            }
            set
            {
                if (lookUpEditValue.Properties.ValueMember == value)
                    return;
                lookUpEditValue.Properties.ValueMember = value;
            }
        }
        public object bValue
        {
            get
            {
                return lookUpEditValue.EditValue;
            }
            set
            {
                if (lookUpEditValue.EditValue == value)
                    return;
                lookUpEditValue.EditValue = value;
                bText = lookUpEditValue.Properties.GetDisplayValueByKeyValue(value).ToString();
            }
        }
        public string bText
        {
            get
            {
                return lookUpEditValue.Text;
            }
            set
            {
                if (lookUpEditValue.Text == value)
                    return;
                lookUpEditValue.Text = value;
            }
        }
        public string bDisplayMember
        {
            get
            {
                return lookUpEditValue.Properties.DisplayMember;
            }
            set
            {
                if (lookUpEditValue.Properties.DisplayMember == value)
                    return;
                lookUpEditValue.Properties.DisplayMember = value;
            }
        }
        public int bWith
        {
            get
            {
                return lblCaption.Width;
            }
            set
            {
                if (lblCaption.Width == value)
                    return;
                lblCaption.Width = value;
            }
        }
        public object bDataSource
        {
            get
            {
                return this.lookUpEditValue.Properties.DataSource;
            }
            set
            {
                if (null == value) return;
                if (DBNull.Value.Equals(value)) return;
                this.lookUpEditValue.Properties.Columns.Clear();
                this.lookUpEditValue.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
                lookUpEditValue.DataBindings.Add("EditValue", value, lookUpEditValue.Properties.ValueMember);
                lookUpEditValue.Properties.DataSource = value;
            }
        }
    }
}
