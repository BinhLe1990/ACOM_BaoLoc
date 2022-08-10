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
    public partial class frmHT_DM_DMHETHONG_InGrid : DevExpress.XtraEditors.XtraForm
    {
        public frmHT_DM_DMHETHONG_InGrid()
        {
            InitializeComponent();
        }
        BSC_Class.BSCConnection cnn = new BSC_Class.BSCConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        private Hashtable ConEdit = new Hashtable();
        string sTable = string.Empty;
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadData()
        {
            try
            {
                #region GridMain
                gridViewMain.Columns.Clear();
                Hashtable Val = new Hashtable();
                Val.Add("TABLE_NAME", sTable);
                Val.Add("FORM_NAME", Name);
                DataRow drTmpVal = cnn.SelectRows(Val, "HT_DM_TABLE_TITLE").Rows[0];
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
                        rilTmp.NullText = drTmp["HEADER_TEXT_D"].ToString();
                        rilTmp.DisplayMember = drTmp["HEADER_TEXT_D"].ToString();
                        rilTmp.ValueMember = drTmp["HEADER_TEXT"].ToString();
                        rilTmp.DataSource = cnn.SelectRows("SELECT " + drTmp["TAB_REF"].ToString() + " AS '" + drTmp["HEADER_TEXT"].ToString() + "', " + drTmp["TAB_DISPLAY"].ToString() + " AS '" + drTmp["HEADER_TEXT_D"].ToString() + "' FROM " + drTmp["TABLE_REF"].ToString());
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
                    gridMain.DataSource = cnn.SelectRows(sSELECT);
                }
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
            if ((new frmHT_DM_DataGridConfig(this.Name, sTable)).ShowDialog() == DialogResult.OK)
                LoadData();
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
            if (XtraMessageBox.Show(this, "Bạn có chắc chắn muốn xóa dữ liệu mà bạn đang chọn hay không ?", "Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            if (gridViewMain.FocusedRowHandle < 0)
                return;
            DataRow drTmp = gridViewMain.GetFocusedDataRow();
            int iVT = gridViewMain.GetFocusedDataSourceRowIndex();
            Hashtable Con = new Hashtable();
            foreach (DevExpress.XtraGrid.Columns.GridColumn gcTmp in gridViewMain.Columns)
                Con.Add(gcTmp.Name, drTmp[gcTmp.Name]);
            if (!cnn.DeleteRows(Con, sTable))
            {
                XtraMessageBox.Show(this, "Không thể thêm dữ liệu mà bạn đã nhập được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            drTmp.Delete();
        }
        private void gridViewMain_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Hashtable Val = new Hashtable();
            System.Data.DataRowView drvTmp = (System.Data.DataRowView)e.Row;
            foreach (DevExpress.XtraGrid.Columns.GridColumn gcTmp in gridViewMain.Columns)
                Val.Add(gcTmp.Name, drvTmp[gcTmp.Name]);
            if (drvTmp.Row.RowState == DataRowState.Added)
                if (!cnn.InsertNewRow(Val, sTable))
                {
                    XtraMessageBox.Show(this, "Không thể thêm dữ liệu mà bạn đã nhập được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    drvTmp.Delete();
                    return;
                }
            if (drvTmp.Row.RowState == DataRowState.Modified)
            {
                if (!cnn.UpdateRows(Val, ConEdit, sTable))
                {
                    XtraMessageBox.Show(this, "Không thể cập nhật dữ liệu mà bạn đã hiệu chỉnh được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void gridMain_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Control)
                btnDelete_Click(null, null);
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
            catch { }
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
    }
}