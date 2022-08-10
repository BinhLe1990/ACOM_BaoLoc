using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.FrDM
{
    public partial class frmDM_DM_PopupGridAdd : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_Class.DELFIConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        public frmDM_DM_PopupGridAdd(string sTable)
        {
            InitializeComponent();
            DataTable dtTABLE_NAME = cnn.SelectRows("SELECT [NAME] FROM sys.Tables WHERE [NAME] <> '" + sTable + "'");
            foreach (DataRow drTmp in dtTABLE_NAME.Rows)
            {
                cbxTABLE_REF.Properties.Items.Add(drTmp["NAME"].ToString());
            }
            if (cbxTABLE_REF.Properties.Items.Capacity > 0)
                cbxTABLE_REF.SelectedIndex = 0;
            cbxCANH.SelectedIndex = 0;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {

        }

        private void cbxTABLE_NAME_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtCOLUMN_NAME = cnn.SelectRows("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.Columns where TABLE_NAME = '" + cbxTABLE_REF.Text + "'");
            cbxTAB_REF.Properties.Items.Clear();
            cbxTAB_DISPLAY.Properties.Items.Clear();
            foreach (DataRow drTmp in dtCOLUMN_NAME.Rows)
            {
                cbxTAB_REF.Properties.Items.Add(drTmp["COLUMN_NAME"].ToString());
                cbxTAB_DISPLAY.Properties.Items.Add(drTmp["COLUMN_NAME"].ToString());
            }
            if (cbxTAB_REF.Properties.Items.Capacity > 0)
            {
                cbxTAB_REF.SelectedIndex = 0;
                cbxTAB_DISPLAY.SelectedIndex = 0;
            }
        }

        private void cbxTAB_DISPLAY_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTEXT_HEADER.Text = cbxTAB_DISPLAY.Text;
        }
    }
}