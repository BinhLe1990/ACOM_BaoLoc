using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BSC_HRM.NET.BSC_User_Control
{
    public partial class frmDefineCondition : DevExpress.XtraEditors.XtraForm
    {
        public frmDefineCondition()
        {
            InitializeComponent();
        }
        public frmDefineCondition(DataTable data, string sColumn)
        {
            InitializeComponent();
            _dt = data;
            _cl = sColumn;
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        private DataTable _dt = new DataTable();
        private string _cl;
        public string sCondition = "";
        public string sValueType = "";
        private void LoadPhepSS()
        {
            cbxPhepSoSanh.SetValue(new string[] { "=", "<>", "<", "<=", ">", ">=", "Like", "Not Like" });
            if (sValueType == "System.DateTime")
            {
                txtDate.Visible = true;
                cbxGiaTri.Visible = false;
            }
            else
            {
                txtDate.Visible = false;
                cbxGiaTri.Visible = true;
                cbxGiaTri.sField = _cl;
                cbxGiaTri.uDisplayMember = _cl;
                cbxGiaTri.uValueMember = _cl;
                cbxGiaTri.uDataSource = _dt;
                
            }
        }

        private void frmDefineCondition_Load(object sender, EventArgs e)
        {
            LoadPhepSS();
        }

        private void btnAnd_Click(object sender, EventArgs e)
        {
            if (txtKetQua.uText.Trim().Length == 0)
            {
                if (sValueType == "System.String")
                    txtKetQua.uText = _cl + " " + cbxPhepSoSanh.uText + " " + cnn.sUnicode(cbxGiaTri.uText, true);
                else if (sValueType == "System.DateTime")
                {
                    if(txtDate.uValue!=DBNull.Value)
                        txtKetQua.uText = _cl + " " + cbxPhepSoSanh.uText + " '" + txtDate.uDateTime.ToString("MM/dd/yyyy") + "'";
                }
                else if (sValueType == "System.Boolean")
                    txtKetQua.uText = _cl + " " + cbxPhepSoSanh.uText + " " + (cbxGiaTri.uText.Trim() == "True" ? "1" : "0");
                else
                    txtKetQua.uText = _cl + " " + cbxPhepSoSanh.uText + " " + cbxGiaTri.uText;
            }
            else
            {
                if (sValueType == "System.String")
                    txtKetQua.uText += " AND " + _cl + " " + cbxPhepSoSanh.uText + " " + cnn.sUnicode(cbxGiaTri.uText, true);
                else if (sValueType == "System.DateTime")
                {
                    if (txtDate.uValue != DBNull.Value)
                        txtKetQua.uText += " AND " + _cl + " " + cbxPhepSoSanh.uText + " '" + txtDate.uDateTime.ToString("MM/dd/yyyy") + "'";
                }
                else if (sValueType == "System.Boolean")
                    txtKetQua.uText += " AND " + _cl + " " + cbxPhepSoSanh.uText + " " + (cbxGiaTri.uText.Trim() == "True" ? "1" : "0");
                else
                    txtKetQua.uText += " AND " + _cl + " " + cbxPhepSoSanh.uText + " " + cbxGiaTri.uText;
            }
        }

        private void btnOR_Click(object sender, EventArgs e)
        {
            if (sValueType == "System.String")
                txtKetQua.uText += " OR " + _cl + " " + cbxPhepSoSanh.uText + " " + cnn.sUnicode(cbxGiaTri.uText, true);
            else if (sValueType == "System.DateTime")
            {
                if (txtDate.uValue != DBNull.Value)
                    txtKetQua.uText += " OR " + _cl + " " + cbxPhepSoSanh.uText + " '" + txtDate.uDateTime.ToString("MM/dd/yyyy") + "'";
            }
            else if (sValueType == "System.Boolean")
                txtKetQua.uText += " OR " + _cl + " " + cbxPhepSoSanh.uText + " " + (cbxGiaTri.uText.Trim() == "True" ? "1" : "0");
            else
                txtKetQua.uText += " OR " + _cl + " " + cbxPhepSoSanh.uText + " " + cbxGiaTri.uText;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtKetQua.uText.Trim().Length == 0)
            {
                if (cbxGiaTri.uText.Trim().Length != 0)
                {
                    if (sValueType == "System.String")
                        sCondition = _cl + " " + cbxPhepSoSanh.uText + " " + cnn.sUnicode(cbxGiaTri.uText, true);
                    else if (sValueType == "System.DateTime")
                    {
                        if (txtDate.uValue != DBNull.Value)
                            sCondition = _cl + " " + cbxPhepSoSanh.uText + " '" + txtDate.uDateTime.ToString("MM/dd/yyyy") + "'";
                    }
                    else if (sValueType == "System.Boolean")
                        sCondition = _cl + " " + cbxPhepSoSanh.uText + " " + (cbxGiaTri.uText.Trim() == "True" ? "1" : "0");
                    else
                        sCondition = _cl + " " + cbxPhepSoSanh.uText + " " + cbxGiaTri.uText;
                }
                else
                    sCondition = "";
            }
            else
                sCondition = txtKetQua.uText;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtKetQua_uEditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKetQua.uText = "";
        }

        private void txtKetQua_uTextChanged(object sender, EventArgs e)
        {
            if (txtKetQua.uText.Trim().Length == 0)
            {
                btnOR.Enabled = false;
                btnAnd.Text = "ADD";
                btnAnd.Size = new Size(98, 23);
            }
            else
            {
                btnOR.Enabled = true;
                btnAnd.Text = "AND";
                btnAnd.Size = new Size(44, 23);
            }
        }

    }
}