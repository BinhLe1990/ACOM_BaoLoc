using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using DevExpress.XtraGrid;

namespace BSC_EMIS.NET.FrHT
{
    public partial class frmDGridDMConfig : DevExpress.XtraEditors.XtraForm
    {
        private string _sFormName = string.Empty;
        private string _sDataTable = string.Empty;
        private bool Flag = false;
        private DataTable dtDataTable = new DataTable();
        BSC_Class.BSCConnection cnn = new BSC_Class.BSCConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        public frmDGridDMConfig(string sFormName, string sDataTable)
        {
            InitializeComponent();
            sDataTable = sDataTable.ToUpper();
            _sFormName = sFormName;
            _sDataTable = sDataTable;
            StyleFormatCondition cn  = new StyleFormatCondition(FormatConditionEnum.NotEqual, gridViewMain.Columns["TABLE_NAME"], null, sDataTable);
            cn.Appearance.BackColor = Color.Red;
            cn.Appearance.ForeColor = Color.White;
            cn.Appearance.Font = new Font(DevExpress.Utils.AppearanceObject.DefaultFont, FontStyle.Bold);
            gridViewMain.FormatConditions.Add(cn);
            cn = new StyleFormatCondition(FormatConditionEnum.NotEqual, gridViewMain.Columns["TAB_VALUE"], null, string.Empty);
            cn.Appearance.BackColor = Color.Yellow;
            cn.Appearance.Font = new Font(DevExpress.Utils.AppearanceObject.DefaultFont, FontStyle.Bold);
            gridViewMain.FormatConditions.Add(cn);
            cn = new StyleFormatCondition(FormatConditionEnum.NotEqual, gridViewMain.Columns["TAB_REF"], null, string.Empty);
            cn.Appearance.BackColor = Color.YellowGreen;
            cn.Appearance.Font = new Font(DevExpress.Utils.AppearanceObject.DefaultFont, FontStyle.Bold);
            gridViewMain.FormatConditions.Add(cn);
            DataTable dtDGConfig = new DataTable();
            dtDGConfig.Columns.Add("STT", Type.GetType("System.Int32"));
            dtDGConfig.Columns.Add("TABLE_NAME", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("MAPPING_NAME", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("HEADER_TEXT", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("WIDTH", Type.GetType("System.Int32"));
            dtDGConfig.Columns.Add("ALIGNMENT", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("VISIBLE", Type.GetType("System.Boolean"));
            dtDGConfig.Columns.Add("FORMAT", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("VIEW_ADD", Type.GetType("System.Boolean"));
            dtDGConfig.Columns.Add("TAB_REF", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("TAB_VALUE", Type.GetType("System.String"));
            try
            {
                Hashtable Val = new Hashtable();
                Val.Add("TABLE_NAME", sDataTable);
                Val.Add("FORM_NAME", sFormName);
                DataRow drTmpVal = cnn.SelectRows(Val, "HT_TABLE_TITLE").Rows[0];
                txtTIEU_DE.Text = drTmpVal["CAPTION_TEXT"].ToString();
                try
                {
                    if (!DBNull.Value.Equals(drTmpVal["COLORROW1"]))
                    {
                        ckC1.Checked = true;
                        gridViewMain.Appearance.OddRow.Options.UseBackColor = true;
                        gridViewMain.OptionsView.EnableAppearanceOddRow = true;
                        color1.Color = Color.FromArgb(int.Parse(drTmpVal["COLORROW1"].ToString()));
                        gridViewMain.Appearance.OddRow.BackColor = color1.Color;
                    }
                }
                catch { }
                try
                {
                    if (!DBNull.Value.Equals(drTmpVal["COLORROW2"]))
                    {
                        ckC2.Checked = true;
                        gridViewMain.Appearance.EvenRow.Options.UseBackColor = true;
                        gridViewMain.OptionsView.EnableAppearanceEvenRow = true;
                        color2.Color = Color.FromArgb(int.Parse(drTmpVal["COLORROW2"].ToString()));
                        gridViewMain.Appearance.EvenRow.BackColor = color2.Color;
                    }
                }
                catch { }
                int iSTT = int.Parse(drTmpVal["TABLE_TITLE"].ToString());
                DataTable dtView = cnn.SelectRows("SELECT * FROM HT_TABLE_COLUMN WHERE TABLE_TITLE = " + iSTT + " ORDER BY STT ASC");
                foreach (DataRow drTmp in dtView.Rows)
                {
                    dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, drTmp["TABLE_NAME"].ToString().ToUpper(), drTmp["MAPPING_NAME"].ToString().ToUpper(), drTmp["HEADER_TEXT"].ToString().ToUpper(), int.Parse(drTmp["WIDTH"].ToString().ToUpper()), drTmp["ALIGNMENT"].ToString().ToUpper(), drTmp["VISIBLE"].ToString().ToUpper() == "TRUE" ? true : false, drTmp["FORMAT"].ToString().ToUpper(), drTmp["VIEW_ADD"].ToString().ToUpper() == "TRUE" ? true : false, drTmp["TAB_VALUE"].ToString().ToUpper(), drTmp["TAB_REF"].ToString().ToUpper() });
                }
            }
            catch { }
            dtDataTable = cnn.SelectRows("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.Columns where TABLE_NAME = '" + _sDataTable + "'");
            for (int i = 0; i < dtDataTable.Rows.Count; i++)
            {
                if (!FindRow(dtDataTable.Rows[i]["COLUMN_NAME"].ToString().ToUpper(), dtDGConfig))
                    dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, _sDataTable, dtDataTable.Rows[i]["COLUMN_NAME"].ToString().ToUpper(), dtDataTable.Rows[i]["COLUMN_NAME"].ToString().ToUpper(), 75, "Trái", true, "", true, "", "" });
            }
            gridMain.DataSource = dtDGConfig;
        }
        private bool FindRow(string sColumnName, DataTable dtVal)
        {
            if (dtVal == null || dtVal.Rows.Count <= 0)
                return false;
            for (int i = 0; i < dtVal.Rows.Count; i++)
            {
                if ((dtVal.Rows[i]["TABLE_NAME"].ToString().Equals(_sDataTable)) && (dtVal.Rows[i]["MAPPING_NAME"].ToString().Equals(sColumnName)))
                    return true;
            }
            return false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Hashtable Val = new Hashtable();
            Val.Add("TABLE_NAME", _sDataTable);
            Val.Add("FORM_NAME", _sFormName);
            int iSTT = 0;
            cnn.BeginTransaction();
            try
            {
                iSTT = int.Parse(cnn.SelectRows(Val, "HT_TABLE_TITLE").Rows[0]["TABLE_TITLE"].ToString());
                Val.Add("TABLE_TITLE", iSTT);
                cnn.DeleteRows(Val, "HT_TABLE_COLUMN");
            }
            catch { }
            Val.Clear();
            Val.Add("TABLE_NAME", _sDataTable);
            Val.Add("FORM_NAME", _sFormName);
            cnn.DeleteRows(Val, "HT_TABLE_TITLE");
            if (ckC1.Checked)
                Val.Add("COLORROW1", color1.Color.ToArgb());
            if (ckC2.Checked)
                Val.Add("COLORROW2", color2.Color.ToArgb());
            Val.Add("CAPTION_TEXT", txtTIEU_DE.Text);
            if (!cnn.InsertNewRow(Val, "HT_TABLE_TITLE"))
            {
                cnn.RollbackTransaction();
                XtraMessageBox.Show(this, "Thông tin mà bạn nhập không thể cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            iSTT = int.Parse(cnn.SelectRows(Val, "HT_TABLE_TITLE").Rows[0]["TABLE_TITLE"].ToString());
            Val.Clear();
            Val.Add("TABLE_TITLE", iSTT);
            cnn.DeleteRows(Val, "HT_TABLE_COLUMN");
            foreach (DataRow drTmp in ((DataTable)gridMain.DataSource).Rows)
            {
                Val.Clear();
                Val.Add("TABLE_TITLE", iSTT);
                Val.Add("STT", drTmp["STT"].ToString());
                Val.Add("TABLE_NAME", drTmp["TABLE_NAME"].ToString());
                Val.Add("MAPPING_NAME", drTmp["MAPPING_NAME"].ToString());
                Val.Add("HEADER_TEXT", drTmp["HEADER_TEXT"].ToString());
                Val.Add("WIDTH", drTmp["WIDTH"].ToString());
                int iAli = 0;
                if (drTmp["ALIGNMENT"].ToString().Equals("Giữa"))
                    iAli = 1;
                if (drTmp["ALIGNMENT"].ToString().Equals("Phải"))
                    iAli = 2;
                Val.Add("ALIGNMENT", iAli);
                Val.Add("VISIBLE", drTmp["VISIBLE"].ToString());
                Val.Add("FORMAT", drTmp["FORMAT"].ToString());
                Val.Add("VIEW_ADD", drTmp["VIEW_ADD"].ToString());
                Val.Add("TAB_VALUE", drTmp["TAB_VALUE"].ToString());
                Val.Add("TAB_REF", drTmp["TAB_REF"].ToString());
                if (!cnn.InsertNewRow(Val, "HT_TABLE_COLUMN"))
                {
                    cnn.RollbackTransaction();
                    XtraMessageBox.Show(this, "Thông tin mà bạn nhập không thể cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            cnn.EndTransaction();
            XtraMessageBox.Show(this, "Thông tin mà bạn nhập đã được cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Flag = true;
        }

        private void ckC1_CheckedChanged(object sender, EventArgs e)
        {
            color1.Enabled = ckC1.Checked;
            gridViewMain.Appearance.OddRow.Options.UseBackColor = ckC1.Checked;
            gridViewMain.OptionsView.EnableAppearanceOddRow = ckC1.Checked;
            if (ckC1.Checked)
                gridViewMain.Appearance.OddRow.BackColor = color1.Color;
        }

        private void ckC2_CheckedChanged(object sender, EventArgs e)
        {
            color2.Enabled = ckC2.Checked;
            gridViewMain.Appearance.EvenRow.Options.UseBackColor = ckC2.Checked;
            gridViewMain.OptionsView.EnableAppearanceEvenRow = ckC2.Checked;
            if (ckC2.Checked)
                gridViewMain.Appearance.EvenRow.BackColor = color2.Color;
        }

        private void color1_EditValueChanged(object sender, EventArgs e)
        {
            gridViewMain.Appearance.OddRow.BackColor = color1.Color;
        }

        private void color2_EditValueChanged(object sender, EventArgs e)
        {
            gridViewMain.Appearance.EvenRow.BackColor = color2.Color;
        }

        private void frmDGridDMConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Flag)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (gridViewMain.RowCount <= 0)
                return;
            DataTable dtView = (DataTable)gridMain.DataSource;
            DataRow drTmp = gridViewMain.GetFocusedDataRow();
            int ik = gridViewMain.GetFocusedDataSourceRowIndex();
            if (ik >= gridViewMain.RowCount - 1)
                return;
            DataTable dtTmp = dtView.Copy();
            dtTmp.Rows.RemoveAt(ik);
            DataRow drAdd;
            drAdd = dtTmp.NewRow();
            for (int i = 0; i < drTmp.ItemArray.Length; i++)
            {
                drAdd[i] = drTmp[i];
            }
            object objTmp = drAdd["STT"];
            drAdd["STT"] = dtTmp.Rows[ik]["STT"];
            dtTmp.Rows[ik]["STT"] = objTmp;
            dtTmp.Rows.InsertAt(drAdd, ik + 1);
            gridMain.DataSource = dtTmp;
            gridViewMain.MoveBy(ik + 1);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (gridViewMain.RowCount <= 0)
                return; 
            DataTable dtView = (DataTable)gridMain.DataSource;
            DataRow drTmp = gridViewMain.GetFocusedDataRow();
            int ik = gridViewMain.GetFocusedDataSourceRowIndex();
            if (ik == 0)
                return;
            DataTable dtTmp = dtView.Copy();
            dtTmp.Rows.RemoveAt(ik);
            DataRow drAdd;
            drAdd = dtTmp.NewRow();
            for (int i = 0; i < drTmp.ItemArray.Length; i++)
            {
                drAdd[i] = drTmp[i];
            }
            object objTmp = drAdd["STT"];
            drAdd["STT"] = dtTmp.Rows[ik - 1]["STT"];
            dtTmp.Rows[ik - 1]["STT"] = objTmp;
            dtTmp.Rows.InsertAt(drAdd, ik - 1);
            gridMain.DataSource = dtTmp;
            gridViewMain.MoveBy(ik - 1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPopupGridAdd frm = new frmPopupGridAdd(_sDataTable);
            for (int i = 0; i < dtDataTable.Rows.Count; i++)
            {
                frm.cbxTAB_REF.Properties.Items.Add(dtDataTable.Rows[i]["COLUMN_NAME"].ToString().ToUpper());
            }
            if (frm.cbxTAB_REF.Properties.Items.Capacity > 0)
                frm.cbxTAB_REF.SelectedIndex = 0;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                gridViewMain.AddNewRow();
                gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, "STT", gridViewMain.RowCount);
                gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, "TABLE_NAME", frm.cbxTABLE_NAME.Text);
                gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, "MAPPING_NAME",frm.cbxTAB_DISPLAY.Text);
                gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, "HEADER_TEXT", frm.txtTEXT_HEADER.Text);
                gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, "WIDTH",frm.txtWith.Value);
                gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, "ALIGNMENT", frm.cbxCANH.Text.Substring(5, 1).Trim().ToUpper() + frm.cbxCANH.Text.Substring(6));
                gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, "VISIBLE", frm.cbxVISIBLE.Text == "Hiển thị" ? true : false);
                gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, "FORMAT", frm.txtFORMAT.Text);
                gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, "VIEW_ADD", true);
                gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, "TAB_VALUE", frm.cbxTAB_VALUE.Text);
                gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, "TAB_REF", frm.cbxTAB_REF.Text);
                gridViewMain.UpdateCurrentRow();
                gridViewMain.ShowEditor();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridViewMain.RowCount <= 0)
                return;
            DataRow drTmp = gridViewMain.GetFocusedDataRow();
            if (!drTmp["TABLE_NAME"].ToString().Equals(_sDataTable))
                drTmp.Delete();
        }
    }
}