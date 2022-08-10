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

namespace DELFI_WHM.NET.DELFI_User_Control
{
    public partial class frmDataGridConfig : DevExpress.XtraEditors.XtraForm
    {
        private string _sFormName = string.Empty;
        private string _sDataTable = string.Empty;
        private bool Flag = false;
        private string _sGridName;
        private DataTable dtDataTable = new DataTable();
        DELFI_Class.DELFIConnection cnn = new DELFI_Class.DELFIConnection(Program.sConnection);
        public frmDataGridConfig(string sFormName, string sDataTable, String sGridName)
        {
            InitializeComponent();
            sDataTable = sDataTable.ToUpper();
            _sFormName = sFormName;
            _sDataTable = sDataTable;
            _sGridName = sGridName;
            DataTable dtDGConfig = new DataTable();
            dtDGConfig.Columns.Add("STT", Type.GetType("System.Int32"));
            dtDGConfig.Columns.Add("MAPPING_NAME", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("HEADER_TEXT", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("WIDTH", Type.GetType("System.Int32"));
            dtDGConfig.Columns.Add("ALIGNMENT", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("VISIBLE", Type.GetType("System.Boolean"));
            dtDGConfig.Columns.Add("FORMAT", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("VALUE_TYPE", Type.GetType("System.String"));
            try
            {
               string sValueMain = "select * from ht_datagrid_title where datagrid_name=" + N_text_(sGridName) + " and form_name=" + N_text_(sFormName) + " and parameter = " + N_text_(sDataTable);
               string sSQL = "SELECT HT_DATAGRID.DATAGRID_TITLE,HT_DATAGRID_TITLE.DATAGRID_NAME, HT_DATAGRID.STT, HT_DATAGRID.MAPPING_NAME, HT_DATAGRID.HEADER_TEXT, HT_DATAGRID.VISIBLE, HT_DATAGRID.READONLY, \n" +
                    "HT_DATAGRID.ALIGNMENT, HT_DATAGRID.WIDTH, HT_DATAGRID.SEARCH, HT_DATAGRID.FORMAT, HT_DATAGRID.VALUE_TYPE, HT_DATAGRID_TITLE.FORM_NAME, HT_DATAGRID_TITLE.PARAMETER\n" +
                    "FROM HT_DATAGRID INNER JOIN HT_DATAGRID_TITLE ON HT_DATAGRID.DATAGRID_TITLE = HT_DATAGRID_TITLE.DATAGRID_TITLE \n" +
                    "WHERE (HT_DATAGRID_TITLE.DATAGRID_NAME=" + N_text_(sGridName) + ") AND (HT_DATAGRID_TITLE.FORM_NAME=" + N_text_(sFormName) + ") AND (HT_DATAGRID_TITLE.PARAMETER=" + N_text_(sDataTable) + ")\n" +
                    "ORDER BY HT_DATAGRID.STT";
                DataTable dtTmp = cnn.SelectRows(sValueMain);
                DataTable dt = cnn.SelectRows("select top 1 * from (" + cnn.GetSQLString(sDataTable) + ")A");
                if (dtTmp.Rows.Count != 0)
                {
                    DataRow drTmpVal = dtTmp.Rows[0];
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
                    int iSTT = int.Parse(drTmpVal["DATAGRID_TITLE"].ToString());
                    DataTable dtView = cnn.SelectRows("SELECT * FROM HT_DATAGRID WHERE DATAGRID_TITLE = " + iSTT + " ORDER BY STT ASC");
                    string sFieldIn_HT = ",";//List các field trongh HT_Datagrid Column, dùng để so sánh với các field trong câu tham số (xem có thừa hay thiếu field hay ko??)
                    foreach (DataRow drTmp in dtView.Rows)
                    {
                        string sCANH = "Trái";
                        if (int.Parse(drTmp["ALIGNMENT"].ToString()) == 1)
                            sCANH = "Giữa";
                        if (int.Parse(drTmp["ALIGNMENT"].ToString()) == 2)
                            sCANH = "Phải";
                        sFieldIn_HT += drTmp["MAPPING_NAME"].ToString() + ",";
                        dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, drTmp["MAPPING_NAME"], drTmp["HEADER_TEXT"], drTmp["WIDTH"], sCANH, drTmp["VISIBLE"], drTmp["FORMAT"], drTmp["VALUE_TYPE"] });
                    }
                    foreach (DataColumn col in dt.Columns)
                    {
                        if (!sFieldIn_HT.Contains("," + col.ColumnName + ","))
                        {
                            dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, col.Caption, col.Caption, 75, "Trái", true, "", col.DataType });
                        }
                    }
                }
                else
                {
                    foreach(DataColumn col in dt.Columns)
                    {
                        dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, col.Caption, col.Caption, 75, "Trái", true, "", col.DataType});
                    }
                }
            }
            catch
            {
            }

            gridMain.DataSource = dtDGConfig;
        }

        public frmDataGridConfig(string sFormName, string sDataTable, String sGridName, DataTable dtDaTa)
        {
            InitializeComponent();
            sDataTable = sDataTable.ToUpper();
            _sFormName = sFormName;
            _sDataTable = sDataTable;
            _sGridName = sGridName;
            DataTable dtDataTable_Grid = cnn.SelectRows("select top 1 * from (" + cnn.GetSQLString(sDataTable) + ")A");
            DataTable dtDGConfig = new DataTable();
            dtDGConfig.Columns.Add("STT", Type.GetType("System.Int32"));
            dtDGConfig.Columns.Add("MAPPING_NAME", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("HEADER_TEXT", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("WIDTH", Type.GetType("System.Int32"));
            dtDGConfig.Columns.Add("ALIGNMENT", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("VISIBLE", Type.GetType("System.Boolean"));
            dtDGConfig.Columns.Add("FORMAT", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("VALUE_TYPE", Type.GetType("System.String"));
            try
            {
                string sValueMain = "select * from ht_datagrid_title where datagrid_name=" + N_text_(sGridName) + " and form_name=" + N_text_(sFormName) + " and parameter = " + N_text_(sDataTable);
                string sSQL = "SELECT HT_DATAGRID.DATAGRID_TITLE,HT_DATAGRID_TITLE.DATAGRID_NAME, HT_DATAGRID.STT, HT_DATAGRID.MAPPING_NAME, HT_DATAGRID.HEADER_TEXT, HT_DATAGRID.VISIBLE, HT_DATAGRID.READONLY, \n" +
                     "HT_DATAGRID.ALIGNMENT, HT_DATAGRID.WIDTH, HT_DATAGRID.SEARCH, HT_DATAGRID.FORMAT, HT_DATAGRID.VALUE_TYPE, HT_DATAGRID_TITLE.FORM_NAME, HT_DATAGRID_TITLE.PARAMETER\n" +
                     "FROM HT_DATAGRID INNER JOIN HT_DATAGRID_TITLE ON HT_DATAGRID.DATAGRID_TITLE = HT_DATAGRID_TITLE.DATAGRID_TITLE \n" +
                     "WHERE (HT_DATAGRID_TITLE.DATAGRID_NAME=" + N_text_(sGridName) + ") AND (HT_DATAGRID_TITLE.FORM_NAME=" + N_text_(sFormName) + ") AND (HT_DATAGRID_TITLE.PARAMETER=" + N_text_(sDataTable) + ")\n" +
                     "ORDER BY HT_DATAGRID.STT";
                DataTable dtTmp = cnn.SelectRows(sValueMain);
                if (dtTmp.Rows.Count != 0)
                {
                    DataRow drTmpVal = dtTmp.Rows[0];
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
                    catch
                    {
                    }
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
                    int iSTT = int.Parse(drTmpVal["DATAGRID_TITLE"].ToString());
                    DataTable dtView = cnn.SelectRows("SELECT * FROM HT_DATAGRID WHERE DATAGRID_TITLE = " + iSTT + " ORDER BY STT ASC");
                    foreach (DataRow drTmp in dtView.Rows)
                    {
                        if (Test_ColumnExists(dtDataTable_Grid, drTmp["MAPPING_NAME"].ToString()))
                        {
                            string sCANH = "Trái";
                            if (int.Parse(drTmp["ALIGNMENT"].ToString()) == 1)
                                sCANH = "Giữa";
                            if (int.Parse(drTmp["ALIGNMENT"].ToString()) == 2)
                                sCANH = "Phải";
                            dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, drTmp["MAPPING_NAME"], drTmp["HEADER_TEXT"], drTmp["WIDTH"], sCANH, drTmp["VISIBLE"], drTmp["FORMAT"], drTmp["VALUE_TYPE"] });
                        }
                    }
                    foreach (DataColumn drCol in dtDataTable_Grid.Columns)
                    {
                        if (!Test_RecordExists(dtView, "MAPPING_NAME", drCol.ColumnName))
                        {
                            dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, drCol.ColumnName, drCol.Caption, 75, "Trái", true, "", drCol.DataType });
                        }
                    }
                }
                else
                {
                    txtTIEU_DE.Text = _sDataTable;
                    foreach (DataColumn col in dtDataTable_Grid.Columns)
                    {
                        dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, col.Caption, col.Caption, 75, "Trái", true, "", col.DataType });
                    }
                }
            }
            catch
            {
            }
            //Xem xét lại, từ đoạn này...
            //dtDataTable = cnn.SelectRows("SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.Columns WHERE TABLE_NAME = '" + _sDataTable + "'");
            //for (int i = 0; i < dtDataTable.Rows.Count; i++)
            //{
            //    if (!FindRow(dtDataTable.Rows[i]["COLUMN_NAME"].ToString().ToUpper(), dtDGConfig))
            //        dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, dtDataTable.Rows[i]["COLUMN_NAME"].ToString().ToUpper(), dtDataTable.Rows[i]["HEADER_TEXT"].ToString().ToUpper(), 75, "Trái", true, "", dtDataTable.Rows[i]["DATA_TYPE"].ToString() });
            //}
            // ... đến đoạn này

            gridMain.DataSource = dtDGConfig;
        }

        public void LoadDataGridConfig(string sFormName, string sDataTable, String sGridName)
        {
            DataTable dtDGConfig = new DataTable();
            dtDGConfig.Columns.Add("STT", Type.GetType("System.Int32"));
            dtDGConfig.Columns.Add("MAPPING_NAME", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("HEADER_TEXT", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("WIDTH", Type.GetType("System.Int32"));
            dtDGConfig.Columns.Add("ALIGNMENT", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("VISIBLE", Type.GetType("System.Boolean"));
            dtDGConfig.Columns.Add("FORMAT", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("VALUE_TYPE", Type.GetType("System.String"));

            try
            {
                string sValueMain = "select * from ht_datagrid_title where datagrid_name=" + N_text_(sGridName) + " and form_name=" + N_text_(sFormName) + " and parameter = " + N_text_(sDataTable);
                string sSQL = "SELECT HT_DATAGRID.DATAGRID_TITLE,HT_DATAGRID_TITLE.DATAGRID_NAME, HT_DATAGRID.STT, HT_DATAGRID.MAPPING_NAME, HT_DATAGRID.HEADER_TEXT, HT_DATAGRID.VISIBLE, HT_DATAGRID.READONLY, \n" +
                     "HT_DATAGRID.ALIGNMENT, HT_DATAGRID.WIDTH, HT_DATAGRID.SEARCH, HT_DATAGRID.FORMAT, HT_DATAGRID.VALUE_TYPE, HT_DATAGRID_TITLE.FORM_NAME, HT_DATAGRID_TITLE.PARAMETER\n" +
                     "FROM HT_DATAGRID INNER JOIN HT_DATAGRID_TITLE ON HT_DATAGRID.DATAGRID_TITLE = HT_DATAGRID_TITLE.DATAGRID_TITLE \n" +
                     "WHERE (HT_DATAGRID_TITLE.DATAGRID_NAME=" + N_text_(sGridName) + ") AND (HT_DATAGRID_TITLE.FORM_NAME=" + N_text_(sFormName) + ") AND (HT_DATAGRID_TITLE.PARAMETER=" + N_text_(sDataTable) + ")\n" +
                     "ORDER BY HT_DATAGRID.STT";
                DataTable dtTmp = cnn.SelectRows(sValueMain);
                DataTable dt = cnn.SelectRows("select top 1 * from (" + cnn.GetSQLString(sDataTable) + ")A");
                if (dtTmp.Rows.Count != 0)
                {
                    DataRow drTmpVal = dtTmp.Rows[0];
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
                    int iSTT = int.Parse(drTmpVal["DATAGRID_TITLE"].ToString());
                    DataTable dtView = cnn.SelectRows("SELECT * FROM HT_DATAGRID WHERE DATAGRID_TITLE = " + iSTT + " ORDER BY STT ASC");
                    string sFieldIn_HT = ",";//List các field trongh HT_Datagrid Column, dùng để so sánh với các field trong câu tham số (xem có thừa hay thiếu field hay ko??)
                    foreach (DataRow drTmp in dtView.Rows)
                    {
                        string sCANH = "Trái";
                        if (int.Parse(drTmp["ALIGNMENT"].ToString()) == 1)
                            sCANH = "Giữa";
                        if (int.Parse(drTmp["ALIGNMENT"].ToString()) == 2)
                            sCANH = "Phải";
                        sFieldIn_HT += drTmp["MAPPING_NAME"].ToString() + ",";
                        dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, drTmp["MAPPING_NAME"], drTmp["HEADER_TEXT"], drTmp["WIDTH"], sCANH, drTmp["VISIBLE"], drTmp["FORMAT"], drTmp["VALUE_TYPE"] });
                    }
                    foreach (DataColumn col in dt.Columns)
                    {
                        if (!sFieldIn_HT.Contains("," + col.ColumnName + ","))
                        {
                            dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, col.Caption, col.Caption, 75, "Trái", true, "", col.DataType });
                        }
                    }
                }
                else
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, col.Caption, col.Caption, 75, "Trái", true, "", col.DataType });
                    }
                }
            }
            catch
            {
            }
            gridMain.DataSource = dtDGConfig;
        }
        
        private bool Test_ColumnExists(DataTable dt, string Col_Name)
        {
            foreach (DataColumn col in dt.Columns)
            {
                if (col.ColumnName == Col_Name)
                    return true;
            }
            return false;
        }

        private bool Test_RecordExists(DataTable dt, string ColumName, string Val)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[ColumName].ToString() == Val)
                    return true;
            }
            return false;
        }
        private string N_text_(string stext)
        {
            string textvao = stext;
            if (textvao == null || textvao.Length == 0) return "N''";
            else { textvao = textvao.Replace("'", "''"); return "N'" + textvao + "'"; }
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
            cnn.BeginTransaction();
            try
            {
                Val.Add("PARAMETER", _sDataTable);
                Val.Add("DATAGRID_NAME", _sGridName);
                Val.Add("FORM_NAME", _sFormName);
                DataTable dt = cnn.SelectRows(Val, "HT_DATAGRID_TITLE");
                if (dt.Rows.Count > 0)
                {
                    iSTT = cnn.sNull2Int(dt.Rows[0]["DATAGRID_TITLE"].ToString());
                    Val.Clear();
                    Val.Add("DATAGRID_TITLE", iSTT);
                    cnn.DeleteRows(Val, "HT_DATAGRID");
                }
            }
            catch
            {
                cnn.RollbackTransaction();
            }
            cnn.EndTransaction();
            cnn.BeginTransaction();
            Val.Clear();
            Val.Add("PARAMETER", _sDataTable);
            Val.Add("DATAGRID_NAME", _sGridName);
            Val.Add("FORM_NAME", _sFormName);
            cnn.DeleteRows(Val, "HT_DATAGRID_TITLE");
            if (ckC1.Checked)
                Val.Add("COLORROW1", color1.Color.ToArgb());
            if (ckC2.Checked)
                Val.Add("COLORROW2", color2.Color.ToArgb());
            Val.Add("CAPTION_TEXT", txtTIEU_DE.Text);
            if (!cnn.InsertNewRow(Val, "HT_DATAGRID_TITLE"))
            {
                cnn.RollbackTransaction();
                XtraMessageBox.Show(this, "Thông tin mà bạn nhập không thể cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //DataTable tmp = cnn.SelectRows(Val, "HT_DATAGRID_TITLE");
            DataTable tmp = cnn.SelectRows("SELECT IDENT_CURRENT('HT_DATAGRID_TITLE')");
            if (tmp == null)
                iSTT = 0;
            else
                if (tmp.Rows.Count > 0)
                    iSTT = cnn.sNull2Int(tmp.Rows[0][0].ToString());
                else
                    iSTT = 0;
            foreach (DataRow drTmp in ((DataTable)gridMain.DataSource).Rows)
            {
                Val.Clear();
                Val.Add("DATAGRID_TITLE", iSTT);
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
                if (!cnn.InsertNewRow(Val, "HT_DATAGRID"))
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

        private void gridMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(MousePosition);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            System.Data.DataTable DTT = new System.Data.DataTable();
            try
            {
                DataView dv = null;
                if (gridViewMain.DataSource is DataView)
                {
                    dv = (DataView)gridViewMain.DataSource;
                    if (dv != null)
                    {
                        DTT = dv.Table;
                    }
                }
                else if (gridViewMain.DataSource is DataTable)
                {
                    DTT = (System.Data.DataTable)(gridViewMain.DataSource);
                }
            }
            catch
            {
            }
            foreach (DataRow r in DTT.Rows)
            {
                r["VISIBLE"] = true;
            }
        }

        private void btnHideAll_Click(object sender, EventArgs e)
        {
            System.Data.DataTable DTT = new System.Data.DataTable();
            try
            {
                DataView dv = null;
                if (gridViewMain.DataSource is DataView)
                {
                    dv = (DataView)gridViewMain.DataSource;
                    if (dv != null)
                    {
                        DTT = dv.Table;
                    }
                }
                else if (gridViewMain.DataSource is DataTable)
                {
                    DTT = (System.Data.DataTable)(gridViewMain.DataSource);
                }
            }
            catch
            {
            }
            foreach (DataRow r in DTT.Rows)
            {
                r["VISIBLE"] = false;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(this, "Bạn có chắc muốn xóa định dạng lưới này không", "Xóa định dạng lưới", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Hashtable Val = new Hashtable();
            int iSTT = 0;
            try
            {
                Val.Add("PARAMETER", _sDataTable);
                Val.Add("DATAGRID_NAME", _sGridName);
                Val.Add("FORM_NAME", _sFormName);
                iSTT = cnn.sNull2Int(cnn.SelectRows(Val, "HT_DATAGRID_TITLE").Rows[0]["DATAGRID_TITLE"].ToString());
                Val.Clear();
                Val.Add("DATAGRID_TITLE", iSTT);
                cnn.BeginTransaction();
                cnn.DeleteRows(Val, "HT_DATAGRID");
            }
            catch
            {
                cnn.RollbackTransaction();
            }
            Val.Clear();
            Val.Add("PARAMETER", _sDataTable);
            Val.Add("DATAGRID_NAME", _sGridName);
            Val.Add("FORM_NAME", _sFormName);
            cnn.DeleteRows(Val, "HT_DATAGRID_TITLE");
            cnn.EndTransaction();
            LoadDataGridConfig(_sFormName, _sDataTable, _sGridName);
        }
    }
}