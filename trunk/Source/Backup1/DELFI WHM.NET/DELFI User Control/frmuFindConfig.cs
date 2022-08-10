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
    public partial class frmUFINDConfig : DevExpress.XtraEditors.XtraForm
    {
        private string _sFormName = string.Empty;
        private string _sDataTable = string.Empty;
        private bool Flag = false;
        private string _uFindName;
        private DataTable dtDataTable = new DataTable();
        DELFI_Class.DELFIConnection cnn = new DELFI_Class.DELFIConnection(Program.sConnection);
        public frmUFINDConfig(string sFormName, string sDataTable, String uFindName)
        {
            InitializeComponent();
            sDataTable = sDataTable.ToUpper();
            _sFormName = sFormName;
            _sDataTable = sDataTable;
            _uFindName = uFindName;
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
                string sValueMain = "select * from ht_UFIND_title where UFIND_name=" + N_text_(uFindName) + " and form_name=" + N_text_(sFormName) + " and parameter = " + N_text_(sDataTable);
                string sSQL = "SELECT HT_UFIND.UFIND_TITLE,HT_UFIND_TITLE.UFIND_NAME, HT_UFIND.STT, HT_UFIND.MAPPING_NAME, HT_UFIND.HEADER_TEXT, HT_UFIND.VISIBLE, HT_UFIND.READONLY, \n" +
                     "HT_UFIND.ALIGNMENT, HT_UFIND.WIDTH, HT_UFIND.SEARCH, HT_UFIND.FORMAT, HT_UFIND.VALUE_TYPE, HT_UFIND_TITLE.FORM_NAME, HT_UFIND_TITLE.PARAMETER\n" +
                     "FROM HT_UFIND INNER JOIN HT_UFIND_TITLE ON HT_UFIND.UFIND_TITLE = HT_UFIND_TITLE.UFIND_TITLE \n" +
                     "WHERE (HT_UFIND_TITLE.UFIND_NAME=" + N_text_(uFindName) + ") AND (HT_UFIND_TITLE.FORM_NAME=" + N_text_(sFormName) + ") AND (HT_UFIND_TITLE.PARAMETER=" + N_text_(sDataTable) + ")\n" +
                     "ORDER BY HT_UFIND.STT";
                DataTable dtTmp = cnn.SelectRows(sValueMain);
                if (dtTmp.Rows.Count != 0)
                {
                    DataRow drTmpVal = dtTmp.Rows[0];
                    txtTIEU_DE.Text = drTmpVal["CAPTION_TEXT"].ToString();

                    int iSTT = int.Parse(drTmpVal["UFIND_TITLE"].ToString());
                    DataTable dtView = cnn.SelectRows("SELECT * FROM HT_UFIND WHERE UFIND_TITLE = " + iSTT + " ORDER BY STT ASC");
                    foreach (DataRow drTmp in dtView.Rows)
                    {
                        string sCANH = "Trái";
                        if (int.Parse(drTmp["ALIGNMENT"].ToString()) == 1)
                            sCANH = "Giữa";
                        if (int.Parse(drTmp["ALIGNMENT"].ToString()) == 2)
                            sCANH = "Phải";
                        dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, drTmp["MAPPING_NAME"], drTmp["HEADER_TEXT"], drTmp["WIDTH"], sCANH, drTmp["VISIBLE"], drTmp["FORMAT"], drTmp["VALUE_TYPE"] });
                    }
                }
                else
                {
                    DataTable dt = cnn.SelectRows("select top 1 * from (" + cnn.GetSQLString(sDataTable) + ")A");
                    foreach (DataColumn col in dt.Columns)
                    {
                        dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, col.Caption, col.Caption, 100, "Trái", true, "", col.DataType });
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
        private void LoadUFindConfig(string sFormName, string sDataTable, String uFindName)
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
                string sValueMain = "select * from ht_UFIND_title where UFIND_name=" + N_text_(uFindName) + " and form_name=" + N_text_(sFormName) + " and parameter = " + N_text_(sDataTable);
                string sSQL = "SELECT HT_UFIND.UFIND_TITLE,HT_UFIND_TITLE.UFIND_NAME, HT_UFIND.STT, HT_UFIND.MAPPING_NAME, HT_UFIND.HEADER_TEXT, HT_UFIND.VISIBLE, HT_UFIND.READONLY, \n" +
                     "HT_UFIND.ALIGNMENT, HT_UFIND.WIDTH, HT_UFIND.SEARCH, HT_UFIND.FORMAT, HT_UFIND.VALUE_TYPE, HT_UFIND_TITLE.FORM_NAME, HT_UFIND_TITLE.PARAMETER\n" +
                     "FROM HT_UFIND INNER JOIN HT_UFIND_TITLE ON HT_UFIND.UFIND_TITLE = HT_UFIND_TITLE.UFIND_TITLE \n" +
                     "WHERE (HT_UFIND_TITLE.UFIND_NAME=" + N_text_(uFindName) + ") AND (HT_UFIND_TITLE.FORM_NAME=" + N_text_(sFormName) + ") AND (HT_UFIND_TITLE.PARAMETER=" + N_text_(sDataTable) + ")\n" +
                     "ORDER BY HT_UFIND.STT";
                DataTable dtTmp = cnn.SelectRows(sValueMain);
                if (dtTmp.Rows.Count != 0)
                {
                    DataRow drTmpVal = dtTmp.Rows[0];
                    txtTIEU_DE.Text = drTmpVal["CAPTION_TEXT"].ToString();

                    int iSTT = int.Parse(drTmpVal["UFIND_TITLE"].ToString());
                    DataTable dtView = cnn.SelectRows("SELECT * FROM HT_UFIND WHERE UFIND_TITLE = " + iSTT + " ORDER BY STT ASC");
                    foreach (DataRow drTmp in dtView.Rows)
                    {
                        string sCANH = "Trái";
                        if (int.Parse(drTmp["ALIGNMENT"].ToString()) == 1)
                            sCANH = "Giữa";
                        if (int.Parse(drTmp["ALIGNMENT"].ToString()) == 2)
                            sCANH = "Phải";
                        dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, drTmp["MAPPING_NAME"], drTmp["HEADER_TEXT"], drTmp["WIDTH"], sCANH, drTmp["VISIBLE"], drTmp["FORMAT"], drTmp["VALUE_TYPE"] });
                    }
                }
                else
                {
                    DataTable dt = cnn.SelectRows("select top 1 * from (" + cnn.GetSQLString(sDataTable) + ")A");
                    foreach (DataColumn col in dt.Columns)
                    {
                        dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, col.Caption, col.Caption, 100, "Trái", true, "", col.DataType });
                    }
                }
            }
            catch
            {
            }
            gridMain.DataSource = dtDGConfig;
        }

        public frmUFINDConfig(string sFormName, string sDataTable, String uFindName, DataTable dtDaTa)
        {
            InitializeComponent();
            sDataTable = sDataTable.ToUpper();
            _sFormName = sFormName;
            _sDataTable = sDataTable;
            _uFindName = uFindName;
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
                string sValueMain = "select * from ht_UFIND_title where UFIND_name=" + N_text_(uFindName) + " and form_name=" + N_text_(sFormName) + " and parameter = " + N_text_(sDataTable);
                string sSQL = "SELECT HT_UFIND.UFIND_TITLE,HT_UFIND_TITLE.UFIND_NAME, HT_UFIND.STT, HT_UFIND.MAPPING_NAME, HT_UFIND.HEADER_TEXT, HT_UFIND.VISIBLE, HT_UFIND.READONLY, \n" +
                     "HT_UFIND.ALIGNMENT, HT_UFIND.WIDTH, HT_UFIND.SEARCH, HT_UFIND.FORMAT, HT_UFIND.VALUE_TYPE, HT_UFIND_TITLE.FORM_NAME, HT_UFIND_TITLE.PARAMETER\n" +
                     "FROM HT_UFIND INNER JOIN HT_UFIND_TITLE ON HT_UFIND.UFIND_TITLE = HT_UFIND_TITLE.UFIND_TITLE \n" +
                     "WHERE (HT_UFIND_TITLE.UFIND_NAME=" + N_text_(uFindName) + ") AND (HT_UFIND_TITLE.FORM_NAME=" + N_text_(sFormName) + ") AND (HT_UFIND_TITLE.PARAMETER=" + N_text_(sDataTable) + ")\n" +
                     "ORDER BY HT_UFIND.STT";
                DataTable dtTmp = cnn.SelectRows(sValueMain);
                if (dtTmp.Rows.Count != 0)
                {
                    DataRow drTmpVal = dtTmp.Rows[0];
                    txtTIEU_DE.Text = drTmpVal["CAPTION_TEXT"].ToString();

                    int iSTT = int.Parse(drTmpVal["UFIND_TITLE"].ToString());
                    DataTable dtView = cnn.SelectRows("SELECT * FROM HT_UFIND WHERE UFIND_TITLE = " + iSTT + " ORDER BY STT ASC");
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
                            dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, drCol.ColumnName, drCol.Caption, 100, "Trái", true, "", drCol.DataType });
                        }
                    }
                }
                else
                {
                    txtTIEU_DE.Text = _sDataTable;
                    foreach (DataColumn col in dtDataTable_Grid.Columns)
                    {
                        dtDGConfig.Rows.Add(new object[] { dtDGConfig.Rows.Count + 1, col.Caption, col.Caption, 100, "Trái", true, "", col.DataType });
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

            Hashtable Val = new Hashtable();
            int iSTT = 0;
            try
            {
                Val.Add("PARAMETER", _sDataTable);
                Val.Add("UFIND_NAME", _uFindName);
                Val.Add("FORM_NAME", _sFormName);
                iSTT = cnn.sNull2Int(cnn.SelectRows(Val, "HT_UFIND_TITLE").Rows[0]["UFIND_TITLE"].ToString());
                Val.Clear();
                Val.Add("TABLE_TITLE", iSTT);
                cnn.BeginTransaction();
                cnn.DeleteRows(Val, "HT_UFIND");
            }
            catch
            {
                cnn.BeginTransaction(); 
            }
            Val.Clear();
            Val.Add("PARAMETER", _sDataTable);
            Val.Add("UFIND_NAME", _uFindName);
            Val.Add("FORM_NAME", _sFormName);
            cnn.DeleteRows(Val, "HT_UFIND_TITLE");

            Val.Add("CAPTION_TEXT", txtTIEU_DE.Text);
            if (!cnn.InsertNewRow(Val, "HT_UFIND_TITLE"))
            {
                cnn.RollbackTransaction();
                XtraMessageBox.Show(this, "Thông tin mà bạn nhập không thể cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //DataTable tmp = cnn.SelectRows(Val, "HT_UFIND_TITLE");
            DataTable tmp = cnn.SelectRows("SELECT IDENT_CURRENT('HT_UFIND_TITLE')");
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
                Val.Add("UFIND_TITLE", iSTT);
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
                if (!cnn.InsertNewRow(Val, "HT_UFIND"))
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

        private void btnXoaDinhDang_Click(object sender, EventArgs e)
        {
            Hashtable Val = new Hashtable();
            int iSTT = 0;
            try
            {
                Val.Add("PARAMETER", _sDataTable);
                Val.Add("uFind_NAME", _uFindName);
                Val.Add("FORM_NAME", _sFormName);
                iSTT = cnn.sNull2Int(cnn.SelectRows(Val, "HT_uFind_TITLE").Rows[0]["uFind_TITLE"].ToString());
                Val.Clear();
                Val.Add("uFind_Title", iSTT);
                cnn.BeginTransaction();
                cnn.DeleteRows(Val, "HT_uFind");
            }
            catch
            {
                cnn.RollbackTransaction();
            }
            Val.Clear();
            Val.Add("PARAMETER", _sDataTable);
            Val.Add("uFind_NAME", _uFindName);
            Val.Add("FORM_NAME", _sFormName);
            cnn.DeleteRows(Val, "HT_uFind_TITLE");
            cnn.EndTransaction();
            LoadUFindConfig(_sFormName, _sDataTable, _uFindName);
        }
    }
}