using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using System.Collections;

namespace BSC_HRM.NET.FrHT
{
    public partial class frmImportData : DevExpress.XtraEditors.XtraForm
    {
        BSC_Class.BSCConnection cnn = new BSC_Class.BSCConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        BSC_Class.BSCConnection cnnSQL;
        public frmImportData()
        {
            InitializeComponent();
            txtPass.Properties.PasswordChar = '\u25CF';
            txtAcessPass.Properties.PasswordChar = '\u25CF';
            DataTable dtTABLE_NAME = cnn.SelectRows("SELECT [NAME] FROM sys.Tables ORDER BY [NAME]");
            groupControl2.Text = "BẢNG DỮ LIỆU IMPORT LIÊN KẾT (" + dtTABLE_NAME.Rows.Count.ToString("N0") + " BẢNG)";
            foreach (DataRow drTmp in dtTABLE_NAME.Rows)
            {
                ckTB2.Items.Add(drTmp["NAME"].ToString());
            }
        }
        int iType = 0;
        string sExcel = "";

        private void frmConvertFontDB_Load(object sender, EventArgs e)
        {

        }

        private void btnSQLConnect_Click(object sender, EventArgs e)
        {
            iType = 0;
            if (txtDatabase.Text.Trim().Length <= 0)
                return;
            cnnSQL = new BSC_Class.BSCConnection(txtServer.Text, txtUser.Text, txtPass.Text, txtDatabase.Text);
            string sql = cnnSQL.ConnectionString;
            try
            {
                DataTable dtTABLE_NAME = cnnSQL.SelectRows("SELECT * FROM sysobjects WHERE (xtype = 'U') ORDER BY name");
                ckTB1.Items.Clear();
                groupControl1.Text = "BẢNG DỮ LIỆU CẦN IMPORT (" + dtTABLE_NAME.Rows.Count.ToString("N0") + " BẢNG)";
                foreach (DataRow drTmp in dtTABLE_NAME.Rows)
                {
                    ckTB1.Items.Add(drTmp["NAME"].ToString());
                }
            }
            catch
            {
                XtraMessageBox.Show("Chương trình không thể kết nối đến Database mà bạn chọn được.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ckTB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridViewSource.OptionsView.ShowViewCaption = false;
            DataTable dtDGConfig = new DataTable();
            dtDGConfig.Columns.Add("CHON", Type.GetType("System.Boolean"));
            dtDGConfig.Columns.Add("COL1", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("DTYPE1", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("COL2", Type.GetType("System.String"));
            dtDGConfig.Columns.Add("FONT", Type.GetType("System.Boolean"));
            DataTable dtDataTable = cnn.SelectRows("SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.Columns WHERE TABLE_NAME = '" + ckTB2.Text + "'");
            for (int i = 0; i < dtDataTable.Rows.Count; i++)
            {
                dtDGConfig.Rows.Add(new object[] { false, dtDataTable.Rows[i]["COLUMN_NAME"].ToString(), dtDataTable.Rows[i]["DATA_TYPE"].ToString(), dtDataTable.Rows[i]["COLUMN_NAME"].ToString(), false });
            }
            gridMain.DataSource = dtDGConfig;
            gridViewSource.Columns.Clear();
            gridControlViewSource.DataSource = cnn.SelectRows("Select * from " + ckTB2.Text);
            if (ckTB2.Text.ToUpper() == "EM_HS_SINHVIEN")
            {
                btnSuLyNS.Enabled = true;
            }
            else
            {
                btnSuLyNS.Enabled = false;
            }

        }

        private void ckTB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (iType)
            {
                case 0:
                    try
                    {
                        DataTable dtVal = cnnSQL.SelectRows("SELECT COLUMN_NAME AS COL2, DATA_TYPE AS DTYPE2 FROM INFORMATION_SCHEMA.Columns WHERE TABLE_NAME = '" + ckTB1.Text + "'");
                        dtVal.Rows.Add();
                        repositoryItemLookUpEdit1.DataSource = dtVal;
                        repositoryItemLookUpEdit1.NullText = "";
                    }
                    catch { }
                    gridView2.Columns.Clear();
                    gridControl2.DataSource = cnnSQL.SelectRows("Select * from " + ckTB1.Text);
                    break;
                case 3:
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [" + ckTB1.Text + "$]", sExcel);
                    
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataTable dtValex = new DataTable();
                    dtValex.Columns.Add("COL2");
                    dtValex.Columns.Add("DTYPE2");
                    for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                    {
                        dtValex.Rows.Add(new object[] { ds.Tables[0].Columns[i].Caption, "Text" });
                    }
                    dtValex.Rows.Add();
                    repositoryItemLookUpEdit1.DataSource = dtValex;
                    repositoryItemLookUpEdit1.NullText = "";
                    gridView2.Columns.Clear();
                    gridControl2.DataSource = ds.Tables[0].DefaultView;
                    break;
                default:
                    break;
            }
        }

        private void btnView1_Click(object sender, EventArgs e)
        {
            if (ckTB1.Items.Count < 1)
                return;
            if (ckTB1.Text.Length <= 0)
                return;
            switch (iType)
            {
                case 0:
                    gridView2.Columns.Clear();
                    gridControl2.DataSource = cnnSQL.SelectRows("Select * from " + ckTB1.Text);
                    //gridView2.BestFitColumns();
                    string strSelect = "";
                    string strSelectVni = "";
                    foreach (DataRow drTmp in ((DataTable)gridMain.DataSource).Rows)
                    {
                        if (drTmp["CHON"].ToString().ToLower().Equals("true"))
                        {
                            if (drTmp["COL2"].ToString().Trim().Length > 0)
                            {
                                strSelect += ", " + drTmp["COL2"].ToString();
                                if (drTmp["FONT"].ToString().ToLower().Equals("true"))
                                    strSelectVni += ", [" + Program.sDatabaseName + "].dbo.TCVN3ToUni(" + drTmp["COL2"].ToString() + ") as " + drTmp["COL2"].ToString();
                                else
                                    strSelectVni += ", " + drTmp["COL2"].ToString();
                            }
                        }
                    }
                    if (strSelect.Length <= 0)
                    {
                        XtraMessageBox.Show(this, "Bạn chưa chọn thông tin dữ liệu để xem thông tin", "Import dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    gridView3.Columns.Clear();
                    gridControl3.DataSource = cnnSQL.SelectRows("Select " + strSelect.Substring(2) + " from " + ckTB1.Text);
                    gridView4.Columns.Clear();
                    strSelectVni = "Select " + strSelectVni.Substring(2) + " from " + ckTB1.Text;
                    gridControl4.DataSource = cnnSQL.SelectRows(strSelectVni, BSC_HRM.NET.BSC_Class.BSCConnection.BSCLoadType.UseLoadProcess);
                    break;
                default:
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnView2_Click(object sender, EventArgs e)
        {
            gridViewSource.Columns.Clear();
            gridViewSource.OptionsView.ShowViewCaption = true;
            DataTable dtView= cnn.SelectRows("Select * from " + ckTB2.Text);
            gridControlViewSource.DataSource = dtView;
            gridViewSource.ViewCaption = "DỮ LIỆU BẢNG \"" + ckTB2.Text.ToUpper() + "\" (" + dtView.Rows.Count.ToString("N0") + " DÒNG)";
        }

        private void Import_From_SQL_Server()
        {
            string sImport = "";
            string sSelectVni = "";
            foreach (DataRow drTmp in ((DataTable)gridMain.DataSource).Rows)
            {
                if (drTmp["CHON"].ToString().ToLower().Equals("true"))
                {
                    if (drTmp["COL2"].ToString().Trim().Length > 0)
                    {
                        sImport += ", " + drTmp["COL1"].ToString();
                        if (drTmp["FONT"].ToString().ToLower().Equals("true"))
                            sSelectVni += ", [" + Program.sDatabaseName + "].dbo.TCVN3ToUni([" + txtDatabase.Text + "].[dbo].[" + ckTB1.Text + "]." + drTmp["COL2"].ToString() + ") as " + drTmp["COL1"].ToString();
                        else
                            sSelectVni += ", ["+txtServer.Text+"].[" + txtDatabase.Text + "].[dbo].[" + ckTB1.Text + "]." + drTmp["COL2"].ToString();
                    }
                }
            }
            if (sImport.Length <= 0)
            {
                XtraMessageBox.Show(this, "Bạn chưa chọn thông tin dữ liệu để Import dữ liệu", "Import dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cnn.BeginTransaction();
            sImport = "INSERT INTO [" + Program.sDatabaseName + "].[dbo].[" + ckTB2.Text + "] (" + sImport.Substring(2) + ") ( SELECT " + sSelectVni.Substring(2) + " FROM  [" + txtServer.Text + "].[" + txtDatabase.Text + "].[dbo].[" + ckTB1.Text + "])";
            int iRExe = cnn.ExecuteNonQuery(sImport);
            if (iRExe <= 0)
            {
                if (null != cnn.LastError)
                {
                    XtraMessageBox.Show(this, "Không thể Import dữ liệu mà bạn chọn được", "Thông tin Import", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cnn.RollbackTransaction();
                    return;
                }
                else
                    XtraMessageBox.Show(this, "Dữ liệu import của bạn không có", "Thông tin Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show(this, "Dữ liệu mà bạn chọn đã được Import thành công.\nSố dòng thực hiện được là : " + iRExe.ToString("N0") + " dòng.", "Thông tin Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cnn.EndTransaction();
        }

        private void ImportData()
        {
            Hashtable Val = new Hashtable();
            string sImport = "";
            string sSelectVni = "";
            int iNotSucceed = 0;
            cnn.BeginTransaction();
            int i = 0;
            try
            {
                for (i=0; i < gridView2.RowCount; i++) // i = RowsIndex duyet qua cac dong muon Import
                {
                    Val.Clear();
                    foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView2.Columns)//Duyet qua tung cot cua lưới chứa dữ liệu import
                    {
                        foreach (DataRow drTmp in ((DataTable)gridMain.DataSource).Rows)//Duyet qua tung dong cua luoi so sanh su lieu giua field trong database với các field của dữ liệu import
                        {
                            if (drTmp["CHON"].ToString().ToLower().Equals("true"))
                            {
                                if (col.FieldName == drTmp["COL2"].ToString())
                                {
                                    if (!drTmp["FONT"].ToString().ToLower().Equals("true"))
                                    {
                                        if (gridView2.GetDataRow(i)[col.FieldName].ToString() != "") //  neu du lieu trong o trong (=null)
                                            Val.Add(drTmp["COL1"].ToString(), gridView2.GetDataRow(i)[col.FieldName]);// Lay du lieu
                                    }
                                    else
                                    {
                                        if (gridView2.GetDataRow(i)[col.FieldName].ToString() != "") //  neu du lieu trong o trong (=null)
                                            Val.Add(drTmp["COL1"].ToString(), "dbo.TCVN3ToUni('" + gridView2.GetDataRow(i)[col.FieldName] + "')");// Lay du lieu
                                    }
                                }
                            }
                        }
                    }
                    if(Val.Count != 0)
                        if (cnn.SelectRows(Val, ckTB2.Text).Rows.Count < 1) // Kiem tra xem dong nay da duoc insert vao Database thanh cong hay chua?
                        {
                            if (!cnn.InsertNewRow(Val, ckTB2.Text))//Them vao dong moi
                            {
                                XtraMessageBox.Show("Cập nhật không thành công. Lỗi phát sinh ở dòng thứ " + i + ". Bạn vui lòng kiểm tra lại!");
                                iNotSucceed++;
                            }
                        }
                }
                if (iNotSucceed > 0)
                    XtraMessageBox.Show("Có" + iNotSucceed.ToString() + " dòng chưa Import vào được.");
                else
                {
                    cnn.EndTransaction();
                    XtraMessageBox.Show("Đã cập nhật thành công");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Cập nhật không thành công. Lỗi phát sinh ở dòng thứ " + (i+1) + ". Bạn vui lòng kiểm tra lại!");
                                
                cnn.RollbackTransaction();
                throw ex; 
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportData();
            //if (iType == 0)
            //    Import_From_SQL_Server();
        }

        private void btnDelImport_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(this, "Bạn có chắc là xóa hết dữ liệu trong bảng \"" + ckTB2.Text.ToUpper() + "\" trước khi Import hay không?", "Xóa và Import dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            cnn.ExecuteNonQuery("DELETE FROM " + ckTB2.Text);
            ImportData();
        }
        private void btnCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (int iRow in gridViewMain.GetSelectedRows())
            {
                gridViewMain.SetRowCellValue(iRow, "CHON", true);
            }
        }
        private void btnUnCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (int iRow in gridViewMain.GetSelectedRows())
            {
                gridViewMain.SetRowCellValue(iRow, "CHON", false);
            }
        }
        private void btnCheckAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int iRow = 0; iRow < gridViewMain.RowCount; iRow++)
            {
                gridViewMain.SetRowCellValue(iRow, "CHON", true);
            }
        }
        private void btnUnCheckAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int iRow = 0; iRow < gridViewMain.RowCount; iRow++)
            {
                gridViewMain.SetRowCellValue(iRow, "CHON", false);
            }
        }

        private void gridViewMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMnu.ShowPopup(MousePosition);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if ((new BSC_Class.BSCConnection()).TestConnect(txtServer.Text, txtUser.Text, txtPass.Text, txtDatabase.Text))
                XtraMessageBox.Show("Kết nối thành công", "Kiểm tra kết nối", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show("Kết nối không thành công", "Kiểm tra kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAddAccess_Click(object sender, EventArgs e)
        {
            OpenFileDialog opTmp = new OpenFileDialog();
            opTmp.Title = "Chọn file Access cần import";
            opTmp.Filter = "Access file|*.mdb|Tất cả các file|*.*";
            if (opTmp.ShowDialog() == DialogResult.OK)
            {
                txtAccessFile.Text = opTmp.FileName;
            }
        }

        private void btnExcelLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog opTmp = new OpenFileDialog();
            opTmp.Title = "Chọn file Excel cần import";
            opTmp.Filter = "Excel file|*.xls|Tất cả các file|*.*";
            if (opTmp.ShowDialog() == DialogResult.OK)
            {
                txtExcelDir.Text = opTmp.FileName;
            }
        }

        private void btnConnectExcel_Click(object sender, EventArgs e)
        {
            iType = 3;
            sExcel = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtExcelDir.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\"";
            System.Data.OleDb.OleDbConnection cnnExcel = new System.Data.OleDb.OleDbConnection(sExcel);
            cnnExcel.Open();
            try
            {
                DataTable dtTABLE_NAME = cnnExcel.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                ckTB1.Items.Clear();
                groupControl1.Text = "BẢNG DỮ LIỆU CẦN IMPORT (" + dtTABLE_NAME.Rows.Count.ToString("N0") + " BẢNG)";
                foreach (DataRow drTmp in dtTABLE_NAME.Rows)
                {
                    string sTable = drTmp["TABLE_NAME"].ToString().Trim();
                    ckTB1.Items.Add(sTable.Substring(0, sTable.Length - 1));
                }
            }
            catch
            {
                XtraMessageBox.Show("Chương trình không thể kết nối đến Database mà bạn chọn được.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTestExcel_Click(object sender, EventArgs e)
        {
            iType = -1;
            ckTB1.Items.Clear();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {

        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            //SinhVien.frmXoaLop frm = new BSC_HRM.NET.SinhVien.frmXoaLop();
            //frm.ShowDialog();
        }

        private void btnSuLyNS_Click(object sender, EventArgs e)
        {
            DataTable dt = cnn.SelectRows("SELECT SinhVien FROM dbo.EM_HS_SinhVien WHERE NS IS NOT NULL");
            string sqlUpdate = "UPDATE dbo.EM_HS_SinhVien SET " +
                            " NgaySinh = CASE WHEN LEN(NS)> 4 AND ISNULL(NgaySinh,' ') = ' '  THEN LEFT(NS,2) ELSE NgaySinh END, " +
                            " ThangSinh = CASE WHEN LEN(NS)>4 AND ISNULL(ThangSinh,' ') = ' ' THEN SUBSTRING(NS,4,2) ELSE ThangSinh END," +
                            " NamSinh = CASE WHEN LEN(NS)>4 AND ISNULL(ThangSinh,' ') = ' ' THEN SUBSTRING(NS,7,4) ELSE NamSinh END " +
                            " WHERE SinhVien = N'";
            cnn.BeginTransaction();
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cnn.UpdateRows(sqlUpdate + dt.Rows[i][0].ToString() + "'");
                }
            }
            catch
            {
                cnn.RollbackTransaction();
                XtraMessageBox.Show(this, "Đã có lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cnn.EndTransaction();
            XtraMessageBox.Show(this, "Đã chuyển ngày tháng năm sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}