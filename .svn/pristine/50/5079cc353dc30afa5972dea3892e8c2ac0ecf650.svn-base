using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BSC_HRM.NET.BSC_User_Control
{
    public partial class BSCDateTimePicker : UserControl
    {
        public BSCDateTimePicker()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(240, 20);
            dateValue.DateTime = DateTime.Now;
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
                return dateValue.Properties.NullText;
            }
            set
            {
                if (dateValue.Properties.NullText == value)
                    return;
                dateValue.Properties.NullText = value;
            }
        }
        public DateTime bValue
        {
            get
            {
                return dateValue.DateTime;
            }
            set
            {
                if (dateValue.DateTime == value)
                    return;
                dateValue.DateTime = value;
            }
        }
        public int bWith
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
    }
}
