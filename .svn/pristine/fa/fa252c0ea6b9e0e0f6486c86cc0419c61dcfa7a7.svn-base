using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace BSC_EMIS.NET.FrHT
{
    public partial class frmDM_DMHETHONG : DevExpress.XtraEditors.XtraForm
    {
        public frmDM_DMHETHONG()
        {
            InitializeComponent();
        }
        BSC_Class.BSCConnection cnn = new BSC_Class.BSCConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        string sTable = string.Empty;
        private void CreateItemView()
        {
            int iLabelWith = 140;
            this.tblMain.Visible = false;
            this.tblMain.Controls.Clear();
            this.tblMain.RowStyles.Clear();
            Hashtable Val = new Hashtable();
            Val.Add("TABLE_NAME", sTable);
            Val.Add("FORM_NAME", Name);
            DataRow drTmpVal = cnn.SelectRows(Val, "HT_TABLE_TITLE").Rows[0];
            int iSTT = int.Parse(drTmpVal["TABLE_TITLE"].ToString());
            DataTable dtValue = cnn.SelectRows("SELECT * FROM HT_TABLE_COLUMN WHERE TABLE_TITLE = " + iSTT + " ORDER BY STT ASC");
            int iIVal = 0;
            DataTable dtDataTable = cnn.SelectRows("SELECT DATA_TYPE, COLUMN_NAME, CHARACTER_MAXIMUM_LENGTH FROM INFORMATION_SCHEMA.Columns where TABLE_NAME = '" + sTable + "'");
            foreach (DataRow drTmp in dtValue.Rows)
            {
                
                if (drTmp["TABLE_NAME"].ToString().ToUpper().Equals(sTable.ToUpper()))
                {
                    if (drTmp["VIEW_ADD"].ToString().ToUpper().Equals("TRUE"))
                    {
                        int iVT = iFindRow(drTmp["MAPPING_NAME"].ToString(), dtDataTable);
                        if (iVT >= 0)
                        {
                            tblMain.Controls.Add(uControl(iLabelWith, drTmp["MAPPING_NAME"].ToString(), drTmp["HEADER_TEXT"].ToString(), dtDataTable, iVT), iIVal % 2 + iIVal % 2, iIVal / 2);
                            iIVal++;
                        }
                    }
                }
                else
                {
                    if (drTmp["VIEW_ADD"].ToString().ToUpper().Equals("TRUE"))
                    {
                        BSC_User_Control.BSCComboBoxMutilCol uCbxVal = new BSC_User_Control.BSCComboBoxMutilCol();
                        uCbxVal.Dock = DockStyle.Fill;
                        uCbxVal.bCaption = drTmp["HEADER_TEXT"].ToString();
                        uCbxVal.bNullText = "Bạn hãy chọn giá trị";
                        uCbxVal.Tag = drTmp["TAB_REF"].ToString();
                        uCbxVal.bWith = iLabelWith;
                        string sMa_View = drTmp["TAB_REF"].ToString();
                        for (int i = 0; i < dtValue.Rows.Count; i++)
                        {
                            if (sMa_View.ToUpper().Equals(dtValue.Rows[i]["MAPPING_NAME"].ToString().ToUpper()))
                            {
                                sMa_View = dtValue.Rows[i]["HEADER_TEXT"].ToString();
                                break;
                            }
                        }
                        string sSelect = "SELECT " + drTmp["TAB_VALUE"].ToString() + " AS '" + sMa_View + "', " + drTmp["MAPPING_NAME"].ToString() + " AS '" + drTmp["HEADER_TEXT"].ToString() + "' FROM " + drTmp["TABLE_NAME"].ToString();
                        uCbxVal.bDisplayMember = drTmp["HEADER_TEXT"].ToString();
                        uCbxVal.bValueMember = sMa_View;
                        uCbxVal.bDataSource = cnn.SelectRows(sSelect);
                        tblMain.Controls.Add(uCbxVal, iIVal % 2 + iIVal % 2, iIVal / 2);
                        iIVal++;
                    }
                }
            }
            tblMain.RowCount = (iIVal / 2 + iIVal % 2);
            tblMain.Height = (iIVal / 2 + iIVal % 2) * 26;
            this.tblMain.Visible = true;
            pnlMain.Height = (iIVal / 2 + iIVal % 2) * 26 + 60;
        }
        private int iFindRow(string sColumnName, DataTable dtVal)
        {
            if (dtVal == null || dtVal.Rows.Count <= 0)
                return -1;
            for (int i = 0; i < dtVal.Rows.Count; i++)
            {
                if (dtVal.Rows[i]["COLUMN_NAME"].ToString().ToUpper().Equals(sColumnName.ToUpper()))
                    return i;
            }
            return -1;
        }
        private Control uControl(int iLabelWith, string sCOLUMN_NAME,string sCaption, DataTable dtValue, int iVT)
        {
            if (dtValue.Rows[iVT]["DATA_TYPE"].ToString().ToLower().IndexOf("datetime") >= 0)
            {
                BSC_User_Control.BSCDateTimePicker uDateVal = new BSC_User_Control.BSCDateTimePicker();
                uDateVal.Dock = DockStyle.Fill;
                uDateVal.bCaption = sCaption;
                uDateVal.Tag = sCOLUMN_NAME;
                uDateVal.bWith = iLabelWith;
                return uDateVal;
            }
            BSC_User_Control.BSCTextBox uTxtVal = new BSC_User_Control.BSCTextBox();
            uTxtVal.Dock = DockStyle.Fill;
            uTxtVal.bCaption = sCaption;
            uTxtVal.Tag = sCOLUMN_NAME;
            uTxtVal.bWith = iLabelWith;
            return uTxtVal;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadData()
        {
            try
            {
                gridViewMain.Columns.Clear();
                Hashtable Val = new Hashtable();
                Val.Add("TABLE_NAME", sTable);
                Val.Add("FORM_NAME", Name);
                DataRow drTmpVal = cnn.SelectRows(Val, "HT_TABLE_TITLE").Rows[0];
                gridViewMain.ViewCaption = drTmpVal["CAPTION_TEXT"].ToString();
                try
                {
                    if (!DBNull.Value.Equals(drTmpVal["COLORROW1"]))
                    {
                        gridViewMain.Appearance.OddRow.Options.UseBackColor = true;
                        gridViewMain.OptionsView.EnableAppearanceOddRow = true;
                        gridViewMain.Appearance.OddRow.BackColor = Color.FromArgb(int.Parse(drTmpVal["COLORROW1"].ToString()));
                    }
                }
                catch { }
                try
                {
                    if (!DBNull.Value.Equals(drTmpVal["COLORROW2"]))
                    {
                        gridViewMain.Appearance.EvenRow.Options.UseBackColor = true;
                        gridViewMain.OptionsView.EnableAppearanceEvenRow = true;
                        gridViewMain.Appearance.EvenRow.BackColor = Color.FromArgb(int.Parse(drTmpVal["COLORROW2"].ToString()));
                    }
                }
                catch { }
                int iSTT = int.Parse(drTmpVal["TABLE_TITLE"].ToString());
                DataTable dtView = cnn.SelectRows("SELECT * FROM HT_TABLE_COLUMN WHERE TABLE_TITLE = " + iSTT + " ORDER BY STT ASC");
                int i = 1;
                string sSELECT = "SELECT ";
                string sCON = " FROM " + sTable;
                foreach (DataRow drTmp in dtView.Rows)
                {
                    if (!drTmp["TABLE_NAME"].ToString().Equals(sTable))
                    {
                        sCON += " INNER JOIN " + drTmp["TABLE_NAME"].ToString() + " ON " + sTable + "." + drTmp["TAB_REF"].ToString() + " = " + drTmp["TABLE_NAME"].ToString() + "." + drTmp["TAB_VALUE"].ToString();
                    }
                    sSELECT += drTmp["TABLE_NAME"].ToString() + "." + drTmp["MAPPING_NAME"].ToString() + ", ";
                    DevExpress.XtraGrid.Columns.GridColumn gcTmp = new DevExpress.XtraGrid.Columns.GridColumn();
                    gcTmp.AppearanceCell.Options.UseTextOptions = true;
                    if (int.Parse(drTmp["ALIGNMENT"].ToString()) == 1)
                        gcTmp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    if (int.Parse(drTmp["ALIGNMENT"].ToString()) == 2)
                        gcTmp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                    gcTmp.FieldName = drTmp["MAPPING_NAME"].ToString();
                    gcTmp.Caption = drTmp["HEADER_TEXT"].ToString();
                    gcTmp.Name = drTmp["MAPPING_NAME"].ToString();
                    gcTmp.Width = int.Parse(drTmp["WIDTH"].ToString());
                    gcTmp.OptionsColumn.ReadOnly = true;
                    if (drTmp["FORMAT"].ToString().Length > 0)
                    {
                        gcTmp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        gcTmp.DisplayFormat.FormatString = drTmp["FORMAT"].ToString();
                    }
                    if (drTmp["VISIBLE"].ToString().ToUpper().Equals("TRUE"))
                    {
                        gcTmp.Visible = true;
                        gcTmp.VisibleIndex = i++;
                    }
                    else
                    {
                        gcTmp.Visible = false;
                        gcTmp.VisibleIndex = -1;
                    }
                    gridViewMain.Columns.Add(gcTmp);
                }
                if (sSELECT.Length > 10)
                {
                    sSELECT = sSELECT.Substring(0, sSELECT.Length - 2) + sCON;
                    gridMain.DataSource = cnn.SelectRows(sSELECT);
                }
                CreateItemView();
            }
            catch { gridMain.DataSource = cnn.SelectRows("SELECT * FROM " + sTable); }
        }
        private void navBarMain_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                sTable = e.Link.Item.Tag.ToString();
            }
            catch { }
            LoadData();
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sTable))
                return;
            if ((new frmDGridDMConfig(this.Name, sTable)).ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hashtable Val = new Hashtable();
            foreach (Control ctrlTmp in tblMain.Controls)
            {
                switch (ctrlTmp.GetType().Name)
                {
                    case"BSCTextBox":
                        BSC_User_Control.BSCTextBox TxtTmp = (BSC_User_Control.BSCTextBox)ctrlTmp;
                        Val.Add(TxtTmp.Tag, TxtTmp.bValue);
                        break;
                    case "BSCComboBoxMutilCol":
                        BSC_User_Control.BSCComboBoxMutilCol CbxTmp = (BSC_User_Control.BSCComboBoxMutilCol)ctrlTmp;
                        Val.Add(CbxTmp.Tag, CbxTmp.bValue);
                        break;
                    default:
                        break;
                }   
            }
            if (!cnn.InsertNewRow(Val, sTable))
            {
                XtraMessageBox.Show(this, "Thông tin mà bạn nhập không thể cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int iVT = gridViewMain.GetFocusedDataSourceRowIndex();
            DataRow drTmp = gridViewMain.GetFocusedDataRow();
            foreach (DataColumn dcTmp in drTmp.Table.Columns)
            {
                foreach (Control ctrlTmp in tblMain.Controls)
                {
                    switch (ctrlTmp.GetType().Name)
                    {
                        case "BSCTextBox":
                            BSC_User_Control.BSCTextBox TxtTmp = (BSC_User_Control.BSCTextBox)ctrlTmp;
                            if (TxtTmp.Tag.ToString().ToUpper().Equals(dcTmp.Caption.ToUpper()))
                                TxtTmp.bValue = drTmp[dcTmp.Caption].ToString();
                            break;
                        case "BSCComboBoxMutilCol":
                            BSC_User_Control.BSCComboBoxMutilCol CbxTmp = (BSC_User_Control.BSCComboBoxMutilCol)ctrlTmp;
                            if (CbxTmp.Tag.ToString().ToUpper().Equals(dcTmp.Caption.ToUpper()))
                                CbxTmp.bValue = drTmp[dcTmp.Caption].ToString();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        private bool FindRow(string sColumnName, DataTable dtVal)
        {
            if (dtVal == null || dtVal.Rows.Count <= 0)
                return false;
            for (int i = 0; i < dtVal.Rows.Count; i++)
            {
                if (dtVal.Rows[i]["COLUMN_NAME"].ToString().ToUpper().Equals(sColumnName))
                    return true;
            }
            return false;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow drTmp = gridViewMain.GetFocusedDataRow();
            int iVT = gridViewMain.GetFocusedDataSourceRowIndex();
            Hashtable Con = new Hashtable();
            DataTable dtDataTable = cnn.SelectRows("SELECT DATA_TYPE, COLUMN_NAME, CHARACTER_MAXIMUM_LENGTH FROM INFORMATION_SCHEMA.Columns where TABLE_NAME = '" + sTable + "'");
            foreach (DataColumn dcTmp in drTmp.Table.Columns)
            {
                if (FindRow(dcTmp.Caption.ToUpper(), dtDataTable))
                    Con.Add(dcTmp.Caption.ToUpper(), drTmp[dcTmp.Caption].ToString());
            }
            if (!cnn.DeleteRows(Con, sTable))
            {
                XtraMessageBox.Show(this, "Không thể xóa thông tin mà bạn chọn được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                LoadData();
                gridViewMain.MoveBy((iVT - 1) >= 0 ? (iVT - 1) : 0);
            }
        }
    }
}