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
    public partial class frmHT_DM_DataGridConfig : DevExpress.XtraEditors.XtraForm
    {
        private string _sFormName = string.Empty;
        private string _sDataTable = string.Empty;
        private bool Flag = false;
        private DataTable dtDataTable = new DataTable();
        BSC_Class.BSCConnection cnn = new BSC_Class.BSCConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        public frmHT_DM_DataGridConfig(string sFormName, string sDataTable)
        {
            InitializeComponent();
            sDataTable = sDataTable.ToUpper();
            _sFormName = sFormName;
            _sDataTable = sDataTable;
            StyleFormatCondition cn = new StyleFormatCondition(FormatConditionEnum.NotEqual, gridViewMain.Columns["TABLE_REF"], null, string.Empty);
            cn.Appearance.BackColor = Color.Red;
            cn.Appearance.ForeColor = Color.White;
            cn.Appearance.Font = new Font(DevExpress.Utils.AppearanceObject.DefaultFont, FontStyle.Bold | FontStyle.Italic);
            gridViewMain.FormatConditions.Add(cn);
            DataTable dtDGConfig = new DataTable();
            dtDGConfig.Columns.Add("STT", Type.GetType("System.Int32"));
            dtDGConfig.Columns.Add("MAPPING_NAME", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("HEADER_TEXT", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("WIDTH", Type.GetType("System.Int32"));
            dtDGConfig.Columns.Add("ALIGNMENT", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("VISIBLE", Type.GetType("System.Boolean"));
            dtDGConfig.Columns.Add("FORMAT", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("VALUE_TYPE", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("TABLE_REF", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("TAB_REF", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("TAB_DISPLAY", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("HEADER_TEXT_D", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("WIDTH_D", Type.GetType("System.Int32"));
            dtDGConfig.Columns.Add("ALIGNMENT_D", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("FORMAT_D", Type.GetType("System.String"));
            try
            {
                Hashtable Val = new Hashtable();
                Val.Add("TABLE_NAME", sDataTable);
                Val.Add("FORM_NAME", sFormName);
                DataRow drTmpVal = cnn.SelectRows(Val, "HT_DM_TABLE_TITLE").Rows[0];
                txtTIEU_DE.Text = drTmpVal["CAPTION_TEXT"].ToString();
                #region Color
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
                #endregion
                int iSTT = int.Parse(drTmpVal["TABLE_TITLE"].ToString());
                DataTable dtView = cnn.SelectRows("SELECT * FROM HT_DM_TABLE_COLUMN WHERE TABLE_TITLE = " + iSTT + " ORDER BY STT ASC");
                foreach (DataRow drTmp in dtView.Rows)
                {
                    string sCANH = "Trái";
                    if (int.Parse(drTmp["ALIGNMENT"].ToString()) == 1)
                        sCANH = "Giữa";
                    if (int.Parse(drTmp["ALIGNMENT"].ToString()) == 2)
                        sCANH = "Phải";
                    string sCANH_D = "Trái";
                    if (int.Parse(drTmp["ALIGNMENT_D"].ToString()) == 1)
                        sCANH_D = "Giữa";
                    if (int.Parse(drTmp["ALIGNMENT_D"].ToString()) == 2)
                        sCANH_D = "Phải";
                    dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, drTmp["MAPPING_NAME"], drTmp["HEADER_TEXT"], drTmp["WIDTH"], sCANH, drTmp["VISIBLE"], drTmp["FORMAT"], drTmp["VALUE_TYPE"], drTmp["TABLE_REF"], drTmp["TAB_REF"], drTmp["TAB_DISPLAY"], drTmp["HEADER_TEXT_D"], drTmp["WIDTH_D"], sCANH_D, drTmp["FORMAT_D"]});
                }
            }
            catch { }
            dtDataTable = cnn.SelectRows("SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.Columns WHERE TABLE_NAME = '" + _sDataTable + "'");
            for (int i = 0; i < dtDataTable.Rows.Count; i++)
            {
                if (!FindRow(dtDataTable.Rows[i]["COLUMN_NAME"].ToString().ToUpper(), dtDGConfig))
                    dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, dtDataTable.Rows[i]["COLUMN_NAME"].ToString().ToUpper(), dtDataTable.Rows[i]["COLUMN_NAME"].ToString().ToUpper(), 75, "Trái", true, "", dtDataTable.Rows[i]["DATA_TYPE"].ToString(), "", "", "", "", 75, "Trái", "" });
            }
            gridMain.DataSource = dtDGConfig;
        }
        private bool FindRow(string sColumnName, DataTable dtVal)
        {
            if (dtVal == null || dtVal.Rows.Count <= 0)
                return false;
            for (int i = 0; i < dtVal.Rows.Count; i++)
            {
                if (dtVal.Rows[i]["MAPPING_NAME"].ToString().Equals(sColumnName))
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
            if (txtTIEU_DE.Text.Trim().Length <= 0)
            {
                XtraMessageBox.Show(this, "Bạn chưa nhập thông tin tiêu đề hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTIEU_DE.Focus();
                return;
            }
            Hashtable Val = new Hashtable();
            int iSTT = 0;
            try
            {
                Val.Add("TABLE_NAME", _sDataTable);
                Val.Add("FORM_NAME", _sFormName);
                iSTT = int.Parse(cnn.SelectRows(Val, "HT_DM_TABLE_TITLE").Rows[0]["TABLE_TITLE"].ToString());
                Val.Clear();
                Val.Add("TABLE_TITLE", iSTT);
                cnn.BeginTransaction();
                cnn.DeleteRows(Val, "HT_DM_TABLE_COLUMN");
            }
            catch { cnn.BeginTransaction(); }
            Val.Clear();
            Val.Add("TABLE_NAME", _sDataTable);
            Val.Add("FORM_NAME", _sFormName);
            cnn.DeleteRows(Val, "HT_DM_TABLE_TITLE");
            if (ckC1.Checked)
                Val.Add("COLORROW1", color1.Color.ToArgb());
            if (ckC2.Checked)
                Val.Add("COLORROW2", color2.Color.ToArgb());
            Val.Add("CAPTION_TEXT", txtTIEU_DE.Text);
            if (!cnn.InsertNewRow(Val, "HT_DM_TABLE_TITLE"))
            {
                cnn.RollbackTransaction();
                XtraMessageBox.Show(this, "Thông tin mà bạn nhập không thể cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            iSTT = int.Parse(cnn.SelectRows(Val, "HT_DM_TABLE_TITLE").Rows[0]["TABLE_TITLE"].ToString());
            foreach (DataRow drTmp in ((DataTable)gridMain.DataSource).Rows)
            {
                Val.Clear();
                Val.Add("TABLE_TITLE", iSTT);
                Val.Add("STT", drTmp["STT"].ToString());
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
                Val.Add("VALUE_TYPE", drTmp["VALUE_TYPE"].ToString());
                Val.Add("TABLE_REF", drTmp["TABLE_REF"].ToString());
                Val.Add("TAB_REF", drTmp["TAB_REF"].ToString());
                Val.Add("TAB_DISPLAY", drTmp["TAB_DISPLAY"].ToString());
                Val.Add("HEADER_TEXT_D", drTmp["HEADER_TEXT_D"].ToString());
                Val.Add("WIDTH_D", drTmp["WIDTH_D"].ToString());
                iAli = 0;
                if (drTmp["ALIGNMENT_D"].ToString().Equals("Giữa"))
                    iAli = 1;
                if (drTmp["ALIGNMENT_D"].ToString().Equals("Phải"))
                    iAli = 2;
                Val.Add("ALIGNMENT_D", iAli);
                Val.Add("FORMAT_D", drTmp["FORMAT_D"].ToString());
                if (!cnn.InsertNewRow(Val, "HT_DM_TABLE_COLUMN"))
                {
                    cnn.RollbackTransaction();
                    XtraMessageBox.Show(this, "Thông tin cấu hình mà bạn nhập không thể cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            cnn.EndTransaction();
            XtraMessageBox.Show(this, "Thông tin mà bạn nhập đã được cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Flag = true;
        }
        #region Color
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
        #endregion
        private void frmDGridDMConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Flag)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;
        }
        #region Up - Down
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
        #endregion
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmHT_DM_PopupGridAdd frm = new frmHT_DM_PopupGridAdd(_sDataTable);
            frm.txtTAB_REF.Text = gridViewMain.GetRowCellValue(gridViewMain.FocusedRowHandle, "MAPPING_NAME").ToString();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, "TABLE_REF", frm.cbxTABLE_REF.Text);
                gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, "TAB_REF", frm.cbxTAB_REF.Text);
                gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, "TAB_DISPLAY", frm.cbxTAB_DISPLAY.Text);
                gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, "HEADER_TEXT_D", frm.txtTEXT_HEADER.Text);
                gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, "WIDTH_D", frm.txtWith.Value);
                gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, "ALIGNMENT_D", frm.cbxCANH.Text.Substring(5, 1).Trim().ToUpper() + frm.cbxCANH.Text.Substring(6));
                gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, "FORMAT_D", frm.txtFORMAT.Text);
                gridViewMain.UpdateCurrentRow();
                gridViewMain.ShowEditor();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridViewMain.RowCount <= 0)
                return;
            try
            {
                DataRow drTmp = gridViewMain.GetFocusedDataRow();
                drTmp["TABLE_REF"] = "";
                drTmp["TAB_REF"] = "";
                drTmp["TAB_DISPLAY"] = "";
                drTmp["HEADER_TEXT_D"] = "";
                drTmp["WIDTH_D"] = "";
                drTmp["ALIGNMENT_D"] = "Trái";
                drTmp["FORMAT_D"] = "";
            }
            catch { }
        }
    }
}