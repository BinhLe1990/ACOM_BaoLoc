using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using System.Drawing.Drawing2D;
using DevExpress.Utils.Drawing;
using DevExpress.XtraExport;
using DELFI_WHM.NET.DELFI_Class;

namespace DELFI_WHM.NET.FrDM
{
    public partial class frmDM_DanhMucHeThong : DevExpress.XtraEditors.XtraForm
    {
        private DELFIConnection cnn = new DELFIConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        clsRun clRun = new clsRun();
        private Hashtable ConEdit = new Hashtable();
        private string sTable = string.Empty;
        public frmDM_DanhMucHeThong()
        {
            InitializeComponent();
            DataTable dtGroup = cnn.SelectRows("SELECT MaNhom, NhomDanhMuc FROM HT_NhomDanhMuc WHERE MaNhom IN (SELECT MaNhom FROM HT_DanhSachDanhMuc) ORDER BY MaNhom");
            DataTable dtItem = cnn.SelectRows("SELECT MaNhom, MaDanhMuc, DanhMuc, TableLink FROM HT_DanhSachDanhMuc WHERE MaNhom IN (SELECT MaNhom FROM HT_NhomDanhMuc) ORDER BY MaNhom, MaDanhMuc");
            string sPermit = Properties.Settings.Default.PER_DANH_MUC;
            string sPTmp="";
            string DM_Not_Config = "";
            foreach (DataRow drGroup in dtGroup.Rows)
            {
                  sPTmp = "|" + "G" + drGroup["MaNhom"].ToString()+ "|";
                  if (sPermit.IndexOf(sPTmp) >= 0)
                  {
                      DevExpress.XtraNavBar.NavBarGroup nvGroup = new DevExpress.XtraNavBar.NavBarGroup(drGroup["NhomDanhMuc"].ToString());
                      nvGroup.Name = "G" + drGroup["MaNhom"].ToString();
                      nvGroup.Tag = drGroup["MaNhom"].ToString();
                      navBarMain.Groups.Add(nvGroup);
                      foreach (DataRow drItem in dtItem.Rows)
                      {
                          DM_Not_Config += "'" + drItem["TableLink"].ToString() + "',";
                          sPTmp = "|" + "I" + drItem["MaDanhMuc"].ToString() + "|";
                           if (sPermit.IndexOf(sPTmp) >= 0)
                           {
                               if (drItem["MaNhom"].ToString().Equals(drGroup["MaNhom"].ToString()))
                               {
                                   DevExpress.XtraNavBar.NavBarItem nvItem = new DevExpress.XtraNavBar.NavBarItem(drItem["DanhMuc"].ToString());
                                   nvItem.Name = "I" + drItem["MaDanhMuc"].ToString();
                                   try
                                   {
                                       nvItem.Tag = drItem["TableLink"].ToString();
                                   }
                                   catch { nvItem.Tag = string.Empty; }
                                   nvItem.CanDrag = false;
                                   nvGroup.ItemLinks.Add(nvItem);
                               }
                           }
                      }
                  }
            }
        }
        private void LoadData()
        {
            #region Quyen Cap nhat Danh Muc
            if (Properties.Settings.Default.PER_DANH_MUC.Contains("|" + navBarMain.SelectedLink.Item.Name + "|=1-1|"))
                gridViewMain.OptionsBehavior.Editable = true;
            else
                gridViewMain.OptionsBehavior.Editable = false;
            #endregion
            try
            {
                #region GridMain
                Hashtable Val = new Hashtable();
                Val.Add("TABLE_NAME", sTable);
                Val.Add("FORM_NAME", Name);
                DataTable dtTmp = cnn.SelectRows(Val, "HT_DM_TABLE_TITLE");
                //if (dtTmp.Rows.Count == 0)
                //{
                //    gridMain.DataSource = cnn.SelectRows("SELECT * FROM " + sTable);
                //    return;
                //}
                gridViewMain.Columns.Clear();
                DataRow drTmpVal = dtTmp.Rows[0];
                gridViewMain.ViewCaption = drTmpVal["CAPTION_TEXT"].ToString();
                gridViewMain.Appearance.OddRow.Options.UseBackColor = false;
                gridViewMain.OptionsView.EnableAppearanceOddRow = false;
                gridViewMain.Appearance.EvenRow.Options.UseBackColor = false;
                gridViewMain.OptionsView.EnableAppearanceEvenRow = false;
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
                #endregion
                int iSTT = int.Parse(drTmpVal["TABLE_TITLE"].ToString());
                DataTable dtView = cnn.SelectRows("SELECT * FROM HT_DM_TABLE_COLUMN WHERE TABLE_TITLE = " + iSTT + " ORDER BY STT ASC");
                int i = 1;
                string sSELECT = "SELECT ";
                string sCON = " FROM " + sTable;
                foreach (DataRow drTmp in dtView.Rows)
                {
                    if (drTmp["TABLE_REF"].ToString().Trim().Length > 0)
                    {
                        sSELECT += sTable + "." + drTmp["MAPPING_NAME"].ToString() + ", ";
                        DevExpress.XtraGrid.Columns.GridColumn gcTmp_D = new DevExpress.XtraGrid.Columns.GridColumn();
                        gcTmp_D.Tag = drTmp["MAPPING_NAME"].ToString();
                        DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilTmp = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
                        rilTmp.NullText = "";//drTmp["HEADER_TEXT_D"].ToString();
                        rilTmp.DisplayMember = drTmp["HEADER_TEXT_D"].ToString();
                        rilTmp.ValueMember = drTmp["HEADER_TEXT"].ToString();
                        DataTable dtRef = cnn.SelectRows("SELECT " + drTmp["TAB_REF"].ToString() + " AS '" + drTmp["HEADER_TEXT"].ToString() + "', " + drTmp["TAB_DISPLAY"].ToString() + " AS '" + drTmp["HEADER_TEXT_D"].ToString() + "' FROM " + drTmp["TABLE_REF"].ToString());
                        dtRef.Rows.Add(new object[] { null, null });
                        rilTmp.DataSource = dtRef;
                        gcTmp_D.ColumnEdit = rilTmp;
                        gcTmp_D.AppearanceCell.Options.UseTextOptions = true;
                        if (int.Parse(drTmp["ALIGNMENT_D"].ToString()) == 1)
                            gcTmp_D.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        if (int.Parse(drTmp["ALIGNMENT_D"].ToString()) == 2)
                            gcTmp_D.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                        gcTmp_D.FieldName = drTmp["MAPPING_NAME"].ToString();
                        gcTmp_D.Caption = drTmp["HEADER_TEXT_D"].ToString();
                        gcTmp_D.Name = drTmp["MAPPING_NAME"].ToString();
                        gcTmp_D.Width = int.Parse(drTmp["WIDTH_D"].ToString());
                        if (drTmp["FORMAT_D"].ToString().Length > 0)
                        {
                            gcTmp_D.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                            gcTmp_D.DisplayFormat.FormatString = drTmp["FORMAT_D"].ToString();
                        }
                        gcTmp_D.Visible = true;
                        gcTmp_D.VisibleIndex = i++;
                        gridViewMain.Columns.Add(gcTmp_D);
                    }
                    else
                    {
                        sSELECT += sTable + "." + drTmp["MAPPING_NAME"].ToString() + ", ";
                        DevExpress.XtraGrid.Columns.GridColumn gcTmp = new DevExpress.XtraGrid.Columns.GridColumn();
                        gcTmp.Tag = sTable;
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
                }
                if (sSELECT.Length > 10)
                {
                    sSELECT = sSELECT.Substring(0, sSELECT.Length - 2) + sCON;
                    gridMain.DataSource = cnn.SelectRows(sSELECT, DELFIConnection.BSCLoadType.UseLoadProcess);
                }
            }
            catch
            {
                gridViewMain.ViewCaption = "";
                gridMain.DataSource = cnn.SelectRows("SELECT * FROM " + sTable); 
            }
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

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
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
            e.Graphics.DrawString("Delfi VN", new Font("Tahoma", 11, FontStyle.Bold), new SolidBrush(Color.Blue), rect, outStringFormat);
            e.Graphics.ResetTransform();
            e.Handled = true;
        }

        private void gridViewMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMnu.ShowPopup(MousePosition);
        }

        private void btnDesignGrid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(sTable))
                return;
            if ((new frmDM_DM_DataGridConfig(this.Name, sTable)).ShowDialog() == DialogResult.OK)
                LoadData();
        }
        private string ShowSaveFileDialog(string title, string filter)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Export To " + title;
            dlg.FileName = clRun.LoaiBoDauTiengViet(gridViewMain.ViewCaption);
            dlg.Filter = filter;
            if (dlg.ShowDialog() == DialogResult.OK) return dlg.FileName;
            return "";
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

        private void btnExportXml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string XMLfileName = ShowSaveFileDialog("XML Document", "XML Files|*.XML");
            if (XMLfileName != "")
                (new frmExport(new ExportXmlProvider(XMLfileName), gridViewMain, XMLfileName)).ShowDialog();
        }

        private void btnExportHtml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string HTMLfileName = ShowSaveFileDialog("HTML Document", "HTML Files|*.HTML");
            if (HTMLfileName != "")
                (new frmExport(new ExportHtmlProvider(HTMLfileName), gridViewMain, HTMLfileName)).ShowDialog();
        }

        private void gridViewMain_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Hashtable Val = new Hashtable();
            Hashtable Con = new Hashtable();
            System.Data.DataRowView drvTmp = (System.Data.DataRowView)e.Row;
            foreach (DevExpress.XtraGrid.Columns.GridColumn gcTmp in gridViewMain.Columns)
            {
                if (drvTmp[gcTmp.FieldName] != DBNull.Value)
                    Val.Add(gcTmp.FieldName, drvTmp[gcTmp.FieldName]);
                else
                {
                    if (drvTmp.Row.RowState == DataRowState.Modified)
                        Val.Add(gcTmp.FieldName, null);
                }
            }
            if (drvTmp.Row.RowState == DataRowState.Added)
                if (!cnn.InsertNewRow(Val, sTable))
                {
                    XtraMessageBox.Show(this, "Không thể thêm dữ liệu mà bạn đã nhập được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    drvTmp.Delete();
                    return;
                }
            if (drvTmp.Row.RowState == DataRowState.Modified)
            {
                Con.Clear();
                if (sTable == "EM_HS_GiaoVien")
                {
                    Con.Add("MaGiaoVien", drvTmp["MaGiaoVien"]);
                    Val.Remove("GIAOVIEN");
                }
                else
                    Con.Add(sTable.Replace("DM_", "Ma"), drvTmp[sTable.Replace("DM_", "Ma")]);
                if (!cnn.UpdateRows(Val, Con, sTable))
                {
                    XtraMessageBox.Show(this, "Không thể cập nhật dữ liệu mà bạn đã hiệu chỉnh được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(this, "Bạn có chắc chắn là muốn xóa dữ liệu mà bạn đã chọn hay không ?", "Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            if (gridViewMain.FocusedRowHandle < 0)
                return;
            DataRow drTmp = gridViewMain.GetFocusedDataRow();
            int iVT = gridViewMain.GetFocusedDataSourceRowIndex();
            Hashtable Con = new Hashtable();
            foreach (DevExpress.XtraGrid.Columns.GridColumn gcTmp in gridViewMain.Columns)
                if (cnn.sNull2String(drTmp[gcTmp.FieldName]) != "")
                    Con.Add(gcTmp.FieldName, drTmp[gcTmp.FieldName]);
            if (!cnn.DeleteRows(Con, sTable))
            {
                XtraMessageBox.Show(this, "Không thể xóa dữ liệu mà bạn đã chọn được", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            drTmp.Delete();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (gridViewMain.OptionsView.NewItemRowPosition == DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top)
            {
                gridViewMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                btnAdd.Text = "Thêm vào";
            }
            else
            {
                gridViewMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
                btnAdd.Text = "Bỏ qua";
            }
        }

        private void gridViewMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                ConEdit.Clear();
                DataRowView drTmp = (DataRowView)gridViewMain.GetFocusedRow();
                foreach (DevExpress.XtraGrid.Columns.GridColumn gcTmp in gridViewMain.Columns)
                    ConEdit.Add(gcTmp.Name, drTmp[gcTmp.Name]);
            }
            catch{}
        }

        private void gridMain_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Control)
                btnDelete_Click(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            string XLSfileName = ShowSaveFileDialog("Microsoft Excel Document", "Excel Files|*.XLS");
            if (XLSfileName != "")
                (new frmExport(new ExportXlsProvider(XLSfileName), gridViewMain, XLSfileName)).ShowDialog();
        }

        private void gridViewMain_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            try
            {
                int iwidth = e.Column.Width;
                string sql = "select table_title from HT_DM_TABLE_TITLE " +
                    " where table_name = '" + sTable + "' and form_name = '" + this.Name + "'";
                int itable = cnn.sNull2Int(cnn.SelectRows(sql).Rows[0][0].ToString());
                if (itable == 0)
                    return;
                cnn.SQL_ExecuteNonQuery("update HT_DM_TABLE_COLUMN set width = " + iwidth + " where mapping_name = N'" + e.Column.FieldName + "' and table_title = " + itable);
            }
            catch { }
        }
    }
}