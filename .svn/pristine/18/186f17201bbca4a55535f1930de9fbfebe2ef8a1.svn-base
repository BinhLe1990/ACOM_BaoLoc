using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.DELFI_User_Control
{
    public partial class BSCEmisNganhDaoTao : UserControl
    {
        public BSCEmisNganhDaoTao()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(240, 20);
            //DELFI_Class.DELFIConnection cnn = new DELFI_Class.DELFIConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
            //DataTable dtVal = cnn.SelectRows("Select * from DM_Nganh");
            //lookUpEditValue.DataBindings.Add("EditValue", dtVal, "MaNganh");
            //lookUpEditValue.Properties.DataSource = dtVal;
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
        public object bValue
        {
            get
            {
                return lookUpEditValue.EditValue;
            }
            set
            {
                try
                {
                    if (lookUpEditValue.EditValue == value)
                        return;
                    lookUpEditValue.EditValue = value;
                    bText = lookUpEditValue.Properties.GetDisplayValueByKeyValue(value).ToString();
                }
                catch { }
            }
        }
    }
}
