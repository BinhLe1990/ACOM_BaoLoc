using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using BSC_HRM.NET.BSC_Class;
using System.Drawing.Drawing2D;
using DevExpress.XtraExport;
using System.Data.SqlClient;
using DevExpress.XtraGrid;

namespace BSC_HRM.NET.BSC_User_Control
{
    [ToolboxBitmap(typeof(DevExpress.XtraGrid.GridControl))]
    public partial class uDataGrid : DevExpress.XtraEditors.XtraUserControl
    {
        public uDataGrid()
        {
            InitializeComponent();
            if (Properties.Settings.Default.USER_NAME != "Administrator" && Properties.Settings.Default.USER_NAME != "Supervisor")
                btnViewThamSo_SQL.Enabled = false;
            
            //if (!Properties.Settings.Default.PER_SYSTEM.Contains("|HT|=1"))
            //    btnViewThamSo_SQL.Enabled = false;
            //if (!Properties.Settings.Default.PER_MENU_NGANG.Contains("|btnThamSoSQL|=1|"))
            //    btnViewThamSo_SQL.Enabled = false;
        }

        private string uKEY;
        public string sKEY
        {
            set
            {
                uKEY = value;
                txtThamSo.EditValue = value;
            }
            get
            { return uKEY; }
        }
        [Browsable(false)]
        private string _where = "";
        public string swhere
        {
            set
            {
                _where = value;
            }
        }
        private string sSQL;

        public string sQuery
        {
            set
            {
                sSQL = value;
            }
        }

        private DataTable DT = new DataTable();
        public bool bFromXetHocPhiTinChi = false;
        private BSCConnection cnn;
        public BSCConnection BSCConn
        {
            set
            {
                if (value != null)
                {
                    cnn = value;
                    //if (cnn.bLength(uKEY))
                    //{
                    //    sSQL = cnn.GetSQLString(uKEY);
                    //    if (_where.Trim() != "")
                    //        sSQL = "select * from (" + sSQL + ")A where " + _where;
                    //    DT = cnn.SelectRows(sSQL);
                    //}
                }
            }
        }
        private string sConnect = "";
        public string uConnect
        {
            set
            {
                if (value != null)
                {
                    sConnect = value;
                    if (cnn.bLength(uKEY))
                    {
                        sSQL = cnn.GetSQLString(uKEY);
                        if (_where.Trim() != "")
                            sSQL = "select * from ("+sSQL+")A where " + _where;
                        DT = cnn.SelectRows(sSQL);
                    }
                }
            }
        }

        ////////////////////////////////
         //////////Dao Viet Duy//////////
        ////////////////////////////////

        [Browsable(false), Category("UserDefine"), Description("DataGrid name")]
        public string sGridName
        {
            get { return this.Name; }
        }

        [Browsable(false), Description("Đếm số dòng trên lưới")]
        public int RowCount
        {
            get { return gridViewMain.RowCount; }
        }

        [Browsable(false), Description("Đếm dòng được chọn")]
        public int SelectRowCount
        {
            get { return gridViewMain.SelectedRowsCount; }
        }
        /// <summary>
        /// Returns the edit value of the specified cell within the focused row.
        /// </summary>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public object uGetFocusedRowCellValue(string fieldName)
        {
            return gridViewMain.GetFocusedRowCellValue(fieldName);
        }

        /// <summary>
        /// Returns the edit value of the specified cell within the focused row.
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        public object uGetFocusedRowCellValue(DevExpress.XtraGrid.Columns.GridColumn column)
        {
            return gridViewMain.GetFocusedRowCellValue(column);
            
        }
        

        [Browsable(false), Category("UserDefine"), Description("Form cha chứa DataGrid")]
        public string sFormName
        {
            get { return this.FindForm().Name; }
        }

        string sCommandSelect = "";
        private object oDataSource = null;
        [Browsable(false)]
        public object uDataSource
        {
            get
            {
                return gridMain.DataSource;
            }
            set
            {
                oDataSource = value;
                gridMain.DataSource = value; 
            }
        }
        string sQuerySelect = "";
        public void SetDataSource(string sQuery)
        {
            if (_where.Trim() != "")
                sQuerySelect = "select * from (" + sQuery + ")A where " + _where;
            else
                sQuerySelect = sQuery;
            gridMain.DataSource = cnn.SelectRows(sQuery);
        }

        [Browsable(false)]
        public int[] uGetSelectRows()
        {
            return gridViewMain.GetSelectedRows();
        }

        [Browsable(false)]
        public void AddNewRow()
        {
            gridViewMain.AddNewRow();
        }

        [Browsable(false)]
        public bool bExistCol(string sCompare)
        {
            bool bExist = false;
            try
            {
                foreach (DataColumn col in ((DataTable)gridViewMain.DataSource).Columns)
                {
                    string tmp = col.ColumnName;
                    if (sCompare.Equals(tmp))
                    {
                        bExist = true;
                        break;
                    }
                    else
                    {
                        bExist = false;
                    }
                }
            }
            catch
            {
                throw;
            }
            return (bExist);
        }

        public void DeleteRows(int rowHandle)
        {
            gridViewMain.DeleteRow(rowHandle);
        }

        public void DeleteSelectionRows()
        {
            gridViewMain.DeleteSelectedRows();
        }

        private void LoadData(string strQuery)
        {
            try
            {
                gridViewMain.Columns.Clear();
                Hashtable Val = new Hashtable();
                string sSELECT = "SELECT ";
                //string TextCommand_Key = cnn.GetSQLString(uKEY);
                string TextCommand_Key = strQuery;
                if (TextCommand_Key == null)
                    return;
                string sCON = "";
                if (_where.Trim() == "")
                    sCON = " FROM (" + TextCommand_Key + ")A";
                else
                    sCON = " FROM (" + TextCommand_Key + " where " + _where + ")A";
                string sValueMain = "select * from ht_datagrid_title where datagrid_name=" + N_text_(sGridName) + " and form_name=" + N_text_(sFormName) + " and parameter = " + N_text_(uKEY);
                sSQL = "SELECT HT_DATAGRID.DATAGRID_TITLE,HT_DATAGRID_TITLE.DATAGRID_NAME, HT_DATAGRID.STT, HT_DATAGRID.MAPPING_NAME, HT_DATAGRID.HEADER_TEXT, HT_DATAGRID.VISIBLE, HT_DATAGRID.READONLY, \n" +
                    "HT_DATAGRID.ALIGNMENT, HT_DATAGRID.WIDTH, HT_DATAGRID.SEARCH, HT_DATAGRID.FORMAT, HT_DATAGRID.VALUE_TYPE, HT_DATAGRID_TITLE.FORM_NAME, HT_DATAGRID_TITLE.PARAMETER\n" +
                    "FROM HT_DATAGRID INNER JOIN HT_DATAGRID_TITLE ON HT_DATAGRID.DATAGRID_TITLE = HT_DATAGRID_TITLE.DATAGRID_TITLE \n" +
                    "WHERE (HT_DATAGRID_TITLE.DATAưGRID_NAME=" + N_text_(sGridName) + ") AND (HT_DATAGRID_TITLE.FORM_NAME=" + N_text_(sFormName) + ") AND (HT_DATAGRID_TITLE.PARAMETER=" + N_text_(uKEY) + ")\n" +
                    "ORDER BY HT_DATAGRID.STT";
                DataTable dtTmp = cnn.SelectRows(sValueMain);
                if (dtTmp.Rows.Count != 0)
                {
                    DataRow drTmpVal = dtTmp.Rows[0];
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
                    int iSTT = int.Parse(drTmpVal["DATAGRID_TITLE"].ToString());
                    DataTable dtView = cnn.SelectRows("SELECT * FROM HT_DATAGRID WHERE DATAGRID_TITLE = " + iSTT + " ORDER BY STT ASC");
                    int i = 1;
                    foreach (DataRow drTmp in dtView.Rows)
                    {
                        sSELECT += /*uKEY + "." +*/ drTmp["MAPPING_NAME"].ToString() + ", ";
                        DevExpress.XtraGrid.Columns.GridColumn gcTmp = new DevExpress.XtraGrid.Columns.GridColumn();
                        gcTmp.Tag = uKEY;
                        gcTmp.AppearanceCell.Options.UseTextOptions = true;
                        if (int.Parse(drTmp["ALIGNMENT"].ToString()) == 1)
                            gcTmp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        if (int.Parse(drTmp["ALIGNMENT"].ToString()) == 2)
                            gcTmp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                        gcTmp.FieldName = drTmp["MAPPING_NAME"].ToString();
                        gcTmp.Caption = drTmp["HEADER_TEXT"].ToString();
                        gcTmp.Name = drTmp["MAPPING_NAME"].ToString();
                        gcTmp.Width = int.Parse(drTmp["WIDTH"].ToString());
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
                        gridMain.DataSource = cnn.SelectRows(sSELECT, BSCConnection.BSCLoadType.UseLoadProcess);
                    }
                    else
                    {
                        //sSELECT = cnn.GetSQLString(uKEY);
                        if (_where.Trim() == "")
                            sSELECT = TextCommand_Key;
                        else
                            sSELECT = "SELECT * FROM (" + TextCommand_Key + ")A where " + _where;
                        gridMain.DataSource = cnn.SelectRows(sSELECT, BSCConnection.BSCLoadType.UseLoadProcess);
                    }
                }
                else
                {
                    if (_where.Trim() == "")
                        sSELECT = TextCommand_Key;
                    else
                        sSELECT = "SELECT * FROM (" + TextCommand_Key + ")A where " + _where;
                    gridMain.DataSource = cnn.SelectRows(sSELECT, BSCConnection.BSCLoadType.UseLoadProcess);
                }
            }
            catch
            {
                //gridMain.DataSource = cnn.SelectRows("SELECT * FROM " + sTable);
            }
            
        }

        private void LoadData()
        {
            try
            {
                gridViewMain.Columns.Clear();
                Hashtable Val = new Hashtable();
                string sSELECT = "SELECT ";
                string TextCommand_Key = cnn.GetSQLString(uKEY);
                string TextCommand_Key_One_Row = "select top 1 * from(" + TextCommand_Key + ")A";
                if (TextCommand_Key == null)
                    return;
                string sCON = "";
                if (_where.Trim() == "")
                    sCON = " FROM (" + TextCommand_Key + ")A";
                else
                    sCON = " FROM (" + TextCommand_Key + " where " + _where + ")A";
                string sValueMain = "select * from ht_datagrid_title where datagrid_name=" + N_text_(sGridName) + " and form_name=" + N_text_(sFormName) + " and parameter = " + N_text_(uKEY);
                sSQL = "SELECT HT_DATAGRID.DATAGRID_TITLE,HT_DATAGRID_TITLE.DATAGRID_NAME, HT_DATAGRID.STT, HT_DATAGRID.MAPPING_NAME, HT_DATAGRID.HEADER_TEXT, HT_DATAGRID.VISIBLE, HT_DATAGRID.READONLY, \n" +
                    "HT_DATAGRID.ALIGNMENT, HT_DATAGRID.WIDTH, HT_DATAGRID.SEARCH, HT_DATAGRID.FORMAT, HT_DATAGRID.VALUE_TYPE, HT_DATAGRID_TITLE.FORM_NAME, HT_DATAGRID_TITLE.PARAMETER\n" +
                    "FROM HT_DATAGRID INNER JOIN HT_DATAGRID_TITLE ON HT_DATAGRID.DATAGRID_TITLE = HT_DATAGRID_TITLE.DATAGRID_TITLE \n" +
                    "WHERE (HT_DATAGRID_TITLE.DATAưGRID_NAME=" + N_text_(sGridName) + ") AND (HT_DATAGRID_TITLE.FORM_NAME=" + N_text_(sFormName) + ") AND (HT_DATAGRID_TITLE.PARAMETER=" + N_text_(uKEY) + ")\n" +
                    "ORDER BY HT_DATAGRID.STT";
                DataTable dtTmp = cnn.SelectRows(sValueMain);
                if (dtTmp.Rows.Count != 0)
                {
                    DataRow drTmpVal = dtTmp.Rows[0];
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
                    int iSTT = int.Parse(drTmpVal["DATAGRID_TITLE"].ToString());
                    DataTable dtView = cnn.SelectRows("SELECT * FROM HT_DATAGRID WHERE DATAGRID_TITLE = " + iSTT + " ORDER BY STT ASC");
                    int i = 1;
                    string sFieldIn_HT = ",";//List các field trongh HT_Datagrid Column, dùng để so sánh với các field trong câu tham số (xem có thừa hay thiếu field hay ko??)
                    foreach (DataRow drTmp in dtView.Rows)
                    {
                        sSELECT += /*uKEY + "." +*/ drTmp["MAPPING_NAME"].ToString() + ", ";
                        DevExpress.XtraGrid.Columns.GridColumn gcTmp = new DevExpress.XtraGrid.Columns.GridColumn();
                        gcTmp.Tag = uKEY;
                        gcTmp.AppearanceCell.Options.UseTextOptions = true;
                        if (int.Parse(drTmp["ALIGNMENT"].ToString()) == 1)
                            gcTmp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        if (int.Parse(drTmp["ALIGNMENT"].ToString()) == 2)
                            gcTmp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                        gcTmp.FieldName = drTmp["MAPPING_NAME"].ToString();
                        gcTmp.Caption = drTmp["HEADER_TEXT"].ToString();
                        gcTmp.Name = drTmp["MAPPING_NAME"].ToString();
                        gcTmp.Width = int.Parse(drTmp["WIDTH"].ToString());
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
                        sFieldIn_HT += gcTmp.FieldName + ",";
                        gridViewMain.Columns.Add(gcTmp);
                    }
                    foreach (DataColumn dc in cnn.SelectRows(TextCommand_Key_One_Row).Columns)
                    {
                        if (!sFieldIn_HT.Contains(","+dc.ColumnName + ","))
                        {
                            DevExpress.XtraGrid.Columns.GridColumn gcTmp2 = new DevExpress.XtraGrid.Columns.GridColumn();
                            gcTmp2.Tag = uKEY;
                            gcTmp2.AppearanceCell.Options.UseTextOptions = true;
                            gcTmp2.FieldName = dc.ColumnName;
                            gcTmp2.Caption = dc.ColumnName;
                            gcTmp2.Name = dc.ColumnName;
                            gcTmp2.Width = 75;
                            gridViewMain.Columns.Add(gcTmp2);
                        }
                    }
                    if (sSELECT.Length > 10)
                    {
                        sSELECT = sSELECT.Substring(0, sSELECT.Length - 2) + sCON;
                        //gridMain.DataSource = cnn.SelectRows(sSELECT, BSCConnection.BSCLoadType.UseLoadProcess);
                    }
                    else
                    {
                        if (_where.Trim() == "")
                            sSELECT = TextCommand_Key;
                        else
                            sSELECT = "SELECT * FROM (" + TextCommand_Key + ")A where " + _where;
                        //gridMain.DataSource = cnn.SelectRows(sSELECT, BSCConnection.BSCLoadType.UseLoadProcess);
                    }
                }
                else
                {
                    DataTable dtDataTable_Grid = cnn.SelectRows(TextCommand_Key);
                    gridMain.Text = uKEY;
                    foreach (DataColumn col in dtDataTable_Grid.Columns)
                    {
                        gridViewMain.Columns.AddField(col.Caption).Visible = true;
                    }
                }
            }
            catch
            {
                //gridMain.DataSource = cnn.SelectRows("SELECT * FROM " + sTable);
            }            
            if (_sFieldSummary != null && _sFieldSummary != "")
            {
                _sFieldSummary = _sFieldSummary.Replace(" ", "");
                string[] sField = _sFieldSummary.Split(new string[] { "," }, StringSplitOptions.None);
                if (sField.Length > 0)
                {                  
                    foreach (string str in sField)
                    {
                        try
                        {
                            gridViewMain.Columns[str].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                            gridViewMain.Columns[str].SummaryItem.DisplayFormat = "{0:n00}";
                        }
                        catch
                        {                            
                        }
                    }
                }                
            }            
        }        
        public void InitData()
        {
            LoadData();
            if (oDataSource != null)
            {
                gridMain.DataSource = (DataTable)oDataSource;
            }
            else
            {
                string sSELECT = "";
                if (_where.Trim() != "")
                    sSELECT = "SELECT * FROM (" + cnn.GetSQLString(uKEY) + ")A where " + _where;
                else
                    sSELECT = cnn.GetSQLString(uKEY);
                gridMain.DataSource = cnn.SelectRows(sSELECT);
            }
        }

        private object N_text_(string stext)
        {
            string textvao = stext;
            if (textvao == null || textvao.Length == 0) return "N''";
            else { textvao = textvao.Replace("'", "''"); return "N'" + textvao + "'"; }
        }

        private void popupMnu_PaintMenuBar(object sender, DevExpress.XtraBars.BarCustomDrawEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(e.Bounds, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, e.Bounds);
            StringFormat outStringFormat = new StringFormat();
            outStringFormat.Alignment = StringAlignment.Near;
            outStringFormat.LineAlignment = StringAlignment.Center;
            outStringFormat.FormatFlags |= StringFormatFlags.DirectionVertical;
            e.Graphics.RotateTransform(180);
            Rectangle rect = e.Bounds;
            rect.Offset(-rect.Width, -rect.Height);
            e.Graphics.DrawString("Công ty cổ phần phần mềm BSC", new Font("Tahoma", 11, FontStyle.Bold), new SolidBrush(Color.Blue), rect, outStringFormat);
            e.Graphics.ResetTransform();
            e.Handled = true;
        }

        private void gridViewMain_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //    popupMnu.ShowPopup(MousePosition);
        }

        private string ShowSaveFileDialog(string title, string filter)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Export To " + title;
            dlg.FileName = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");
            dlg.Filter = filter;
            if (dlg.ShowDialog() == DialogResult.OK) return dlg.FileName;
            return "";
        }

        private void btnDesignGrid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(uKEY))
                return;
            if ((new frmDataGridConfig(sFormName, uKEY, sGridName)).ShowDialog() == DialogResult.OK)
                LoadData();
        }
        private void btnExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string XLSfileName = ShowSaveFileDialog("Microsoft Excel Document", "Excel Files|*.XLS");
            if (XLSfileName != "")
                (new frmExport(new ExportXlsProvider(XLSfileName), gridViewMain, XLSfileName)).ShowDialog();
        }
        private void btnExportTxt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string TXTfileName = ShowSaveFileDialog("Text Document", "Text Files|*.TXT");
            if (TXTfileName != "")
                (new frmExport(new ExportTxtProvider(TXTfileName), gridViewMain, TXTfileName)).ShowDialog();
        }

        private System.Data.DataTable DT_DataTable_Filter_Dtg()
        {
            System.Data.DataTable DTT = new System.Data.DataTable();
            try
            {
                DataView dv = null;
                if (gridViewMain.DataSource is DataView)
                {
                    dv = (DataView)gridViewMain.DataSource;
                }
                else if (gridViewMain.DataSource is DataTable)
                {
                    dv = ((System.Data.DataTable)(gridViewMain.DataSource)).DefaultView;
                }
                if (dv != null)
                {
                    //DTT = dv.Table.Clone();
                    //for (int ii = 0; ii < dv.Count; ii++)
                    //{
                    //    DTT.ImportRow(dv[ii].Row);
                    //}
                    //DTT.DefaultView.AllowNew = false;
                    DTT = dv.Table;
                }
                else
                {
                    DTT = null;
                }
            }
            catch
            {
            }
            return (DTT);
        }

        public void ExportExcel()
        {
            string XLSfileName = ShowSaveFileDialog("Microsoft Excel Document", "Excel Files|*.XLS");
            if (XLSfileName != "")
                (new frmExport(new ExportXlsProvider(XLSfileName), gridViewMain, XLSfileName)).ShowDialog();
        }

        public DataTable GetDataSource()
        {
            return DT_DataTable();
        }

        public int FocusedRowHandle
        {
            get { return gridViewMain.FocusedRowHandle; }
            set { gridViewMain.FocusedRowHandle = value; }
        }

        public object uGetFocusedRow()
        {
            return gridViewMain.GetFocusedRow();
        }

        public void uSetRowCellValue(int rowHandle, DevExpress.XtraGrid.Columns.GridColumn column, object _value)
        {
            gridViewMain.SetRowCellValue(rowHandle, column, _value);
        }

        public void uSetRowCellValue(int rowHandle, string fieldName, object _value)
        {
            gridViewMain.SetRowCellValue(rowHandle, fieldName, _value);
        }

        public StyleFormatConditionCollection FormatConditions
        {
            get
            {
                return gridViewMain.FormatConditions;
            }
        }

        private System.Data.DataTable DT_DataTable()
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
            return (DTT);
        }

        private System.Data.DataSet DS_DataSet()
        {
            System.Data.DataSet ds = new System.Data.DataSet("BAOCAO");
            System.Data.DataTable DTT = DT_DataTable_Filter_Dtg();
            try
            {
                ds.Tables.Add(DTT);
            }
            catch
            {
            }
            finally
            {
                //ds.Tables.Remove(DTT);
            }
            return (ds);
        }

        private void btnExportXml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string XMLfileName = ShowSaveFileDialog("XML Document", "XML Files|*.XML");
            if (XMLfileName == "")
                return;
            //(new frmExport(new ExportXmlProvider(XMLfileName), gridViewMain, XMLfileName)).ShowDialog();
            #region Tạo file XML để đưa vào CrystalReport (cách của .NET 2003)
            if (gridViewMain.DataSource == null)
                return;
            DataTable dt = DT_DataTable_Filter_Dtg();
            if (dt == null) return;
            DataSet DS = new DataSet();
            if (dt.DataSet == null)
            {
                DS = DS_DataSet();
            }
            else
            {
                DS = dt.DataSet;
                DS.Tables[0].TableName = "BAOCAO";
            }
            if (DS == null)
            {
                return;
            }
            DS.WriteXml(XMLfileName);
            DS.WriteXmlSchema(XMLfileName + ".xsd");
            #endregion
        }
        private void btnExportHtml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string HTMLfileName = ShowSaveFileDialog("HTML Document", "HTML Files|*.HTML");
            if (HTMLfileName != "")
                (new frmExport(new ExportHtmlProvider(HTMLfileName), gridViewMain, HTMLfileName)).ShowDialog();
        }
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
            if (oDataSource != null)
            {
                gridMain.DataSource = (DataTable)oDataSource;
            }
            else
            {
                //string sSELECT = "";
                //if (_where.Trim() != "")
                //    sSELECT = "SELECT * FROM (" + cnn.GetSQLString(uKEY) + ")A where " + _where;
                //else
                //    sSELECT = cnn.GetSQLString(uKEY);
                //gridMain.DataSource = cnn.SelectRows(sSELECT);
            }
        }

        #region Properties
        [DefaultValue("Tiêu đề lưới"), Category("UserDefine"), Description("Tiêu đề lưới.")]
        public string sTieuDeLuoi
        {
            get
            {
                return gridViewMain.ViewCaption;
            }
            set
            {
                gridViewMain.ViewCaption = value;
            }
        }

        [DefaultValue("Kéo thả tiêu đề cột lên để tạo nhóm"), Category("UserDefine"), Description("Tiêu đề lưới.")]
        public string sGroupPanelText
        {
            get
            {
                return gridViewMain.GroupPanelText;
            }
            set
            {
                gridViewMain.GroupPanelText = value;
            }
        }
        
        [DefaultValue(true), Category("UserDefine")]
        public bool bUseEmbeddedNavigator
        {
            get { return gridMain.UseEmbeddedNavigator; }
            set { gridMain.UseEmbeddedNavigator = value; }
        }

        [DefaultValue(false), Category("UserDefine")]
        public bool bAllowCellMerge
        {
            get { return gridViewMain.OptionsView.AllowCellMerge; }
            set { gridViewMain.OptionsView.AllowCellMerge = value; }
        }
        
        [DefaultValue(false), Category("UserDefine"), Description("Bật / tắt hiển thị dòng Group.")]
        public bool bShowGroupPanel
        {
            get { return gridViewMain.OptionsView.ShowGroupPanel; }
            set { gridViewMain.OptionsView.ShowGroupPanel = value; }
        }

        [DefaultValue(true), Category("UserDefine"), Description("Bật / tắt hiển thị tiêu đề lưới.")]
        public bool bShowViewCaption
        {
            get { return gridViewMain.OptionsView.ShowViewCaption; }
            set { gridViewMain.OptionsView.ShowViewCaption = value; }
        }
        
        [DefaultValue(false), Category("UserDefine")]
        public bool bShowPreview
        {
            get { return gridViewMain.OptionsView.ShowPreview; }
            set { gridViewMain.OptionsView.ShowPreview = value; }
            
        }

        [DefaultValue(true), Category("UserDefine")]
        public bool bEnableColumnMenu
        {
            get { return gridViewMain.OptionsMenu.EnableColumnMenu; }
            set { gridViewMain.OptionsMenu.EnableColumnMenu = value; }
        }

        [DefaultValue(false), Category("UserDefine"), Description("Cho phép chọn nhiều dòng.")]
        public bool bMultiSelect
        {
            get { return gridViewMain.OptionsSelection.MultiSelect; }
            set { gridViewMain.OptionsSelection.MultiSelect = value; }
        }

        [DefaultValue(DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect), Category("UserDefine"), Description("Chế độ dòng chọn")]
        public DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode uMultiSelectMode
        {
            get { return gridViewMain.OptionsSelection.MultiSelectMode; }
            set { gridViewMain.OptionsSelection.MultiSelectMode = value; }
        }

        [DefaultValue(false), Category("UserDefine")]
        public bool bAllowEdit
        {
            get { return gridViewMain.OptionsBehavior.Editable; }
            set { gridViewMain.OptionsBehavior.Editable = value; }
        }
        [DefaultValue(false), Category("UserDefine")]
        public bool bShowFooter
        {
            get { return gridViewMain.OptionsView.ShowFooter;}
            set { gridViewMain.OptionsView.ShowFooter = value; }
        }
        private string _sFieldSummary;
        [DefaultValue(null), Category("UserDefine"),Description("Nhập danh sách các Field cần sum, cách nhau bằng dấu phẩy (,)")]
        public string sFieldSummary
        {
            get { return _sFieldSummary; }
            set { _sFieldSummary = value; }
        }       
        [DefaultValue(true), Category("UserDefine")]
        public bool bShowAutoFilterRow
        {
            get { return gridViewMain.OptionsView.ShowAutoFilterRow; }
            set { gridViewMain.OptionsView.ShowAutoFilterRow = value; }
        }

        [DefaultValue(DevExpress.Utils.DefaultBoolean.False), Category("UserDefine")]
        public DevExpress.Utils.DefaultBoolean bAllowAddRows
        {
            get { return gridViewMain.OptionsBehavior.AllowAddRows; }
            set { gridViewMain.OptionsBehavior.AllowAddRows = value; }
        }

        [DefaultValue(DevExpress.Utils.DefaultBoolean.False), Category("UserDefine")]
        public DevExpress.Utils.DefaultBoolean bAllowDeleteRows
        {
            get { return gridViewMain.OptionsBehavior.AllowDeleteRows; }
            set { gridViewMain.OptionsBehavior.AllowDeleteRows = value; }
        }

        [Browsable(false)]
        public DataRow CurRow
        {
            get
            {
                return gridViewMain.GetFocusedDataRow();
            }
        }
        /// <summary>
        /// Returns the System.Data.DataRow object that represents the specified row.
        /// </summary>
        /// <param name="Index">An integer value representing the row handle</param>
        /// <returns></returns>
        public DataRow GetDaTaRow(int rowHandle)
        {
                return gridViewMain.GetDataRow(rowHandle);
        }
        /// <summary>
        /// Gets or sets the focused column field
        /// </summary>
        /// 
        [Browsable(false)]
        public DevExpress.XtraGrid.Columns.GridColumn CurColumn
        {
            get
            {
                return gridViewMain.FocusedColumn;
            }
        }

        public DevExpress.XtraGrid.Columns.GridColumnCollection Columns
        {
            get 
            {
                return gridViewMain.Columns; 
            }
        }

        #endregion

        private void CheckAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int i = 0; i < gridViewMain.RowCount; i++)
            {
                gridViewMain.SetRowCellValue(i, "Chon", true);
            }
            gridViewMain.MoveLast();
        }

        private void UncheckedAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int i = 0; i < gridViewMain.RowCount; i++)
            {
                gridViewMain.SetRowCellValue(i, "Chon", false);
            }
            gridViewMain.MoveLast();
        }
        
        private void uDataGrid_Load(object sender, EventArgs e)
        {
            gridViewMain.Invalidate();
            gridViewMain.IndicatorWidth = 30;
            //LoadData();
            //if (this.FindForm().Name == "frmCapNhatDiemThi")
            //    popupMnu.AddItem(btnTTND);
        }

        private void gridViewMain_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewMain.RowCount < 1)
                return;
            string sText = gridViewMain.GetFocusedValue().ToString();
            Clipboard.SetText(sText);
        }

        [Category("UserDefine"), Description("Occurs when the mouse pointer is over a View and a mouse button is pressed.")]
        public event DevExpress.XtraGrid.Views.Base.RowObjectEventHandler uRowUpdated;
        private void gridViewMain_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (this.uRowUpdated!= null)
            {
                this.uRowUpdated(this, e);
            }
        }

        [Category("UserDefine"),Description("Occurs when the data source of the curent View changes.")]
        public event System.EventHandler uDataSourceChanged;
        private void gridViewMain_DataSourceChanged(object sender, EventArgs e)
        {
            LoadData();
            if (this.uDataSourceChanged != null)
                this.uDataSourceChanged(this, e);
        }

        [Category("UserDefine")]
        public event System.EventHandler uClick;
        private void gridViewMain_Click(object sender, EventArgs e)
        {
            if (this.uClick != null)
                this.uClick(this, e);
        }

        [Category("UserDefine")]
        public event System.EventHandler uDoubleClick;
        private void gridViewMain_DoubleClick(object sender, EventArgs e)
        {
            if (uDoubleClick != null)
                this.uDoubleClick(this, e);
        }

        [Category("UserDefine")]
        public event DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler uCellValueChanged;
        private void gridViewMain_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (this.uCellValueChanged != null)
                this.uCellValueChanged(this, e);
        }

        [Category("UserDefine")]
        public event DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler uFocusedRowChanged;        
        private void gridViewMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.uFocusedRowChanged != null)
                this.uFocusedRowChanged(this, e);
        }

        [Category("UserDefine")]
        public event DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler uValidateRow;
        private void gridViewMain_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (this.uValidateRow != null)
                this.uValidateRow(sender, e);
        }

        private void btnThamSo_SQL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrSYS.frmThamSoSQL frm = new BSC_HRM.NET.FrSYS.frmThamSoSQL(txtThamSo.EditValue.ToString());
            frm.MdiParent = this.FindForm().MdiParent;
            frm.Show();
        }

        private void gridViewMain_ColumnPositionChanged(object sender, EventArgs e)
        {
            //DevExpress.XtraGrid.Columns.GridColumn col = (DevExpress.XtraGrid.Columns.GridColumn)sender;
            //int ipos = gridViewMain.Columns.IndexOf(col);
            //string sql = "select datagrid_title from ht_datagrid " +
            //    " where datagrid_title in " +
            //    " (select datagrid_title from HT_DATAGRID_TITLE " +
            //    " where datagrid_name = '" + this.Name + "' and form_name = '" + this.FindForm().Name + "')";
            //int iDatagrid = cnn.sNull2Int(cnn.SelectRows(sql).Rows[0][0].ToString());
            //if (iDatagrid == 0)
            //    return;
            //cnn.SQL_ExecuteNonQuery("update HT_DATAGRID set STT = " + ipos + " where mapping_name = N'"+col.FieldName+"' and datagrid_title = " + iDatagrid);
            
        }

        private void gridViewMain_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            try
            {
                int iwidth = e.Column.Width;
                string sql = "select datagrid_title from HT_DATAGRID_TITLE " +
                    " where datagrid_name = '" + this.Name + "' and form_name = '" + this.FindForm().Name + "' and parameter = '" + uKEY + "'";
                int iDatagrid = cnn.sNull2Int(cnn.SelectRows(sql).Rows[0][0].ToString());
                if (iDatagrid == 0)
                    return;
                cnn.SQL_ExecuteNonQuery("update HT_DATAGRID set width = " + iwidth + " where mapping_name = N'" + e.Column.FieldName + "' and datagrid_title = " + iDatagrid);
            }
            catch { }
        }
        
        private void gridViewMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (!bFromXetHocPhiTinChi)
                barbtnXemChiTiet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            if (e.Button == MouseButtons.Right)
                popupMnu.ShowPopup(MousePosition);
        }
        //private void AddSumaryField()
        //{
        //    DataTable dt;
        //    foreach (DataRow x in dt.Rows)
        //    {               
        //        DevExpress.XtraGrid.GridGroupSummaryItem item = new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, x[0].ToString(), null, "")});
        //        this.gridViewMain.GroupSummary.AddRange(item);
        //    }      
            
        //}

    }
}