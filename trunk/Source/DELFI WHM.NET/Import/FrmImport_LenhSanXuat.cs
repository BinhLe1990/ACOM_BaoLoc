using DELFI_WHM.NET.DELFI_Class;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DELFI_WHM.NET.Import
{
    public partial class FrmImport_LenhSanXuat : DevExpress.XtraEditors.XtraForm
    {
        public FrmImport_LenhSanXuat()
        {
            InitializeComponent();
        }

        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFD = new OpenFileDialog();
            openFD.Title = "Open Microsoft Excel Document";
            //openFD.Filter = "Excel Files|*.xlsx";
            openFD.Filter = "Excel Files|*.*";
            if (openFD.ShowDialog() != DialogResult.OK)
                return;
            string sExcel;
            System.Data.OleDb.OleDbConnection cnnExcel = new System.Data.OleDb.OleDbConnection();
            try
            {
                sExcel = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + openFD.FileName + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\"";
                //string sExcel = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + openFD.FileName + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=1\"";
                cnnExcel = new System.Data.OleDb.OleDbConnection(sExcel);
                cnnExcel.Open();
            }
            catch
            {
                //string sExcel = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + openFD.FileName + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\"";
                sExcel = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + openFD.FileName + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=1\"";
                cnnExcel = new System.Data.OleDb.OleDbConnection(sExcel);
                cnnExcel.Open();
            }
            DataTable dt = new DataTable();
            try
            {
                SplashScreenManager.ShowDefaultWaitForm();
                DataTable dtTABLE_NAME = cnnExcel.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                OleDbDataAdapter data = new OleDbDataAdapter("SELECT  [" + dtTABLE_NAME.Rows[0]["TABLE_NAME"].ToString() + "].*, " +
                                                              " '" + Properties.Settings.Default.USER_NAME + "' as UserName, '200' as LocationCode " +
                                                              " FROM [" + dtTABLE_NAME.Rows[0]["TABLE_NAME"].ToString() + "]", sExcel);
                DataSet ds = new DataSet();
                data.Fill(ds);
                dt = ds.Tables[0];
                cnnExcel.Close();
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows.Count > 0)
                    {
                        cnn.ExecuteNonQuery("DELETE FROM Import_LenhSanXuat");
                        cnn.SqlBulkCopy(dt, "Import_LenhSanXuat");
                        DataTable dt2 = new DataTable();
                        dt2 = cnn.SQL_GetStoredProcedure("SP_Import_LenhSanXuat");
                        grid.DataSource = dt2;
                        gridView.BestFitColumns();
                        SplashScreenManager.CloseDefaultWaitForm();
                        XtraMessageBox.Show(dt2.Rows[0]["ThongBao"].ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SplashScreenManager.CloseDefaultWaitForm();
                        XtraMessageBox.Show("Không có dữ liệu để lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }                    
                }
                else
                {
                    SplashScreenManager.CloseDefaultWaitForm();
                    XtraMessageBox.Show("Không có dữ liệu để Import!", "Thông báo");
                }
            }
            catch
            {
                SplashScreenManager.CloseDefaultWaitForm();
                XtraMessageBox.Show("Chương trình không thể kết nối đến file mà bạn chọn được.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnnExcel.Close();
                return;
            }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnFileMau_Click(object sender, EventArgs e)
        {
            SaveFileDialog filename = new SaveFileDialog();
            filename.Title = "Export To Microsoft Excel Document";
            filename.OverwritePrompt = true;
            filename.FileName = "Import_LSX.xls";
            filename.Filter = "Excel Files|*.*";
            if (filename.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                    if (xlApp == null)
                    {
                        MessageBox.Show("Excel is not properly installed!!");
                        return;
                    }


                    Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;

                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    xlWorkSheet.Cells[1, 1] = "PostingDate";
                    xlWorkSheet.Cells[1, 2] = "BatchNo";
                    xlWorkSheet.Cells[1, 3] = "ItemNo";
                    xlWorkSheet.Cells[1, 4] = "BinCode";
                    xlWorkSheet.Cells[1, 5] = "Lot";
                    xlWorkSheet.Cells[1, 6] = "PalletQty";
                    xlWorkSheet.Cells[1, 7] = "PackingUnitCode";
                    xlWorkSheet.Cells[1, 8] = "Quantity";
                    xlWorkSheet.Cells[1, 9] = "Note";

                    xlWorkBook.SaveAs(filename.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    Marshal.ReleaseComObject(xlWorkSheet);
                    Marshal.ReleaseComObject(xlWorkBook);
                    Marshal.ReleaseComObject(xlApp);
                    XtraMessageBox.Show("Đã tạo file mẫu");
                }
                catch
                {
                    XtraMessageBox.Show("Không thể tạo file");
                }
            }

            
        }
    }
}
