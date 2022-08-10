using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace DELFI_WHM.NET.DELFI_User_Control
{
    public partial class BSCComboBox : UserControl
    {
        public BSCComboBox()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(240, 20);
        }
        public BSCComboBox(object[] sValue)
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(240, 20);
            this.cbxValue.Properties.Items.AddRange(sValue);
            if (sValue.Length > 0)
                this.cbxValue.SelectedIndex = 0;
        }
        public BSCComboBox(ArrayList arrValue)
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(240, 20);
            foreach (object objTmp in arrValue)
            {
                this.cbxValue.Properties.Items.Add(objTmp.ToString());
            }
            if (arrValue.Capacity > 0)
                this.cbxValue.SelectedIndex = 0;
        }
        public void SetValue(object[] sValue)
        {
            this.cbxValue.Properties.Items.Clear();
            this.cbxValue.Properties.Items.AddRange(sValue);
            if (sValue.Length > 0)
                this.cbxValue.SelectedIndex = 0;
        }
        /// <summary>
        /// Kiểm tra sự tồn tại của giá trị sValue trong danh sách Combobox
        /// </summary>
        /// <param name="sValue">Giá trị kiểm tra</param>
        /// <returns>Trả về kiểu bool</returns>
        private bool Check_Exist(object sValue)// true: Đã tồn tại giá trị sValue
        {
            if (cbxValue.Properties.Items.Count == 0)
                return false;
            for (int i = 0; i < cbxValue.Properties.Items.Count; i++)
            {
                if (cbxValue.Properties.Items[i].ToString() == sValue.ToString())
                    return true;
            }
            return false;
        }

        public void AddValue(object[] sValue)
        {
            foreach (object ob in sValue)
            {
                if(!Check_Exist(ob))
                    this.cbxValue.Properties.Items.Add(ob);
            }
            if (sValue.Length > 0)
            {
                this.cbxValue.SelectedIndex = 0;
            }
        }

        public void AddValue(object sValue)
        {
            if (!Check_Exist(sValue))
                this.cbxValue.Properties.Items.Add(sValue);
            cbxValue.SelectedIndex = -1;
        }
        [Category("UserDefine"), DefaultValue("Caption")]
        public string Caption
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
        [Category("UserDefine")]
        public int bSelectedIndex
        {
            get
            {
                return this.cbxValue.SelectedIndex;
            }
            set
            {
                if (this.cbxValue.SelectedIndex == value)
                    return;
                this.cbxValue.SelectedIndex = value;
            }
        }
        [Category("UserDefine")]
        public string uText
        {
            get
            {
                return this.cbxValue.Text;
            }
            set
            {
                if (this.cbxValue.Text == value)
                    return;
                this.cbxValue.Text = value;
            }
        }
        [Category("UserDefine"), DefaultValue(true), Description("Sắp xếp")]
        public bool bSort
        {
            get { return cbxValue.Properties.Sorted; }
            set { cbxValue.Properties.Sorted = value; }
        }
        [Category("UserDefine")]
        public event DevExpress.XtraEditors.Controls.ChangingEventHandler uEditValueChanging;
        private void cbxValue_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (uEditValueChanging != null)
                uEditValueChanging(sender, e);
        }
    }
}
