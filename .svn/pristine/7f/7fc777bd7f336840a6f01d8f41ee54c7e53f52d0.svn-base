using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace DELFI_WHM.NET.KhoHang
{
    public partial class frmImportDanhSachKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmImportDanhSachKhachHang()
        {
            InitializeComponent();
            clRun.SetValueToControl(this);
            dtg.sKEY = sKey;
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clRun = new clsRun();
        string sKey = "Customer";

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtg_uDataSourceChanged(object sender, EventArgs e)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn gc in dtg.Columns)
            {
                if (gc.FieldName != "Chon")
                    gc.OptionsColumn.AllowEdit = false;
            }
        }     


        private void btnInDS_Click(object sender, EventArgs e)
        {
            string str = cnn.GetSQLString("Customer");

            DataTable dT = cnn.SelectRows(str);
            BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\KH_DanhSachKhachHang.repx", dT);
            frm.Show();
        }
        private void btnLuuDanhSach_Click(object sender, EventArgs e)
        {
            //if (!check())
            //{
            //    XtraMessageBox.Show("Không kết nối được dữ liệu! Vui lòng kiểm tra kết nối mạng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            ////DELFI_Class.DELFIConnectionMySql cmm = new DELFI_WHM.NET.DELFI_Class.DELFIConnectionMySql(Program.sServerMySql, Program.sPortMySql, Program.sUserMySql, Program.SPasswordMySql, Program.sDatabaseMySql);
            if(cnn.bComboIsNull(cboSuKien))
            {
                XtraMessageBox.Show("Bạn chưa chọn sự kiện!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSuKien.Focus();
                return;
            }
            DataRow[] dr = dtg.GetDataSource().Select();
            if (dr.Length > 0)
            {
                if (XtraMessageBox.Show("Bạn có chắc muốn lưu danh sách khách hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
                cnn.BeginTransaction();
               // cmm.BeginTransaction();
                int i = 0;
                try
                {
                    
                    string TenMay = System.Net.Dns.GetHostName();
                    string U_ID = Properties.Settings.Default.USER_ID;
                    string cur_time = cnn.GetDateServer().ToString("MM/dd/yyyy");
                    Hashtable Val = new Hashtable();
                    Hashtable Cond = new Hashtable();
                    foreach (DataRow r in dr)
                    {
                        /// Tao ma Khach Hang
                        string MaID;
                        string str;
                        DataTable dt = new DataTable();
                        do
                        {
                            MaID = TaoMaNgauNhien();

                            str = "Select * from Customer where IDCustomer = N'" + MaID + "'";

                            dt = cnn.SelectRows(str);
                        }
                        while (dt.Rows.Count > 0);
                        /// 

                        i++;
                        string IDCustomer = cnn.sNull2String(MaID);
                        string HoDem = cnn.sNull2String(r["HoDem"]);
                        string Ten = cnn.sNull2String(r["Ten"]);
                        string DiaChi = cnn.sNull2String(r["DiaChi"]);
                        string MaSuKien = cboSuKien.uEditValue.ToString();
                                                
                        Val.Clear();
                        Val.Add("IDCustomer", IDCustomer);
                        Val.Add("HoDem", HoDem);
                        Val.Add("Ten", Ten);
                        Val.Add("DiaChi", DiaChi);
                        Val.Add("DienThoai", cnn.sNull2String(r["DienThoai"]));
                        Val.Add("Email", cnn.sNull2String(r["Email"]));
                        Val.Add("ChucVu", cnn.sNull2String(r["ChucVu"]));
                        Val.Add("NamKinhNghiem", cnn.sNull2Int(r["NamKinhNghiem"]));
                        Val.Add("NganhNghe", cnn.sNull2String(r["NganhNghe"]));
                        Val.Add("LoaiSuKien", cnn.sNull2String(r["LoaiSuKien"]));
                        Val.Add("LoaiNganhNghe", cnn.sNull2String(r["LoaiNganhNghe"]));
                        Val.Add("MaSuKien", cnn.sNull2String(cboSuKien.uEditValue));
                        Val.Add("TenCongTy", cnn.sNull2String(r["TenCongTy"]));
                        Val.Add("DiaDiem", cnn.sNull2String(r["DiaDiem"]));
                        Val.Add("Ngay1", cur_time);
                        Val.Add("NguoiDung1", U_ID);
                        Val.Add("May1", cur_time);

                        if(chkImport.Checked == true)
                            Val.Add("Checked", 1);

                        cnn.InsertNewRow(Val, "Customer");
                        Val.Remove("Ngay1");
                        Val.Remove("NguoiDung1");
                        Val.Remove("NguoiDung1");
                        //cmm.InsertNewRowMySql(Val, "customer");
                    }
                    cnn.EndTransaction();
                    //cmm.EndTransaction();
                    XtraMessageBox.Show("Cập nhật thông tin thành công");
                    
                }
                catch(Exception ex)
                {
                    cnn.RollbackTransaction();
                    //cmm.RollbackTransaction();
                    XtraMessageBox.Show("Lỗi ở dòng " + i.ToString() + ": " + ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnChonFile_Click(object sender, EventArgs e)
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
                    DataTable dtTABLE_NAME = cnnExcel.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT * FROM [" + dtTABLE_NAME.Rows[0]["TABLE_NAME"].ToString() + "]", sExcel);
                    DataSet ds = new DataSet();
                    data.Fill(ds);
                    dt = ds.Tables[0];
                    dtg.uDataSource = dt;
                    cnnExcel.Close();
                }
                catch
                {
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
        private string TaoMaNgauNhien()
        {
            string str = "";
            int Num1, Num2, Num3, Num4, Num5, Num6;

            string Num11, Num22, Num33, Num44, Num55, Num66;

            Random rd = new Random();

            Num1 = rd.Next(0, 999);

            Num11 = Num1.ToString().PadLeft(3,'0');

            Num2 = rd.Next(0, 999);

            Num22 = Num2.ToString().PadLeft(3, '0');

            Num3 = rd.Next(0, 999);

            Num33 = Num3.ToString().PadLeft(3, '0');

            Num4 = rd.Next(0, 99);

            Num44 = Num4.ToString().PadLeft(2, '0');

            Num5 = rd.Next(1, 9);

            Num55 = Num5.ToString();

            Num6 = rd.Next(0, 999);

            Num66 = Num1.ToString().PadLeft(3, '0');

            str = Num55 + Num11 + Num22 + Num33 + Num44 + Num66;

            return str;
        }

        private void btnCheckConnect_Click(object sender, EventArgs e)
        {
            if ((new DELFI_Class.DELFIConnectionMySql()).TestConnectMySql(Program.sServerMySql, Program.sPortMySql, Program.sUserMySql, Program.SPasswordMySql, Program.sDatabaseMySql))
            {
                XtraMessageBox.Show("Kết nối thành công");
            }
            else
            {
                XtraMessageBox.Show("Kết nối không thành công");
            }
        }
        private bool check()
        {
            if ((new DELFI_Class.DELFIConnectionMySql()).TestConnectMySql(Program.sServerMySql, Program.sPortMySql, Program.sUserMySql, Program.SPasswordMySql, Program.sDatabaseMySql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void frmImportDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            string str = cnn.GetSQLString("SuKien");
            DataTable dt = new DataTable();
            dt = cnn.SelectRows(str);
            cboSuKien.uDataSource = dt;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cboSuKien))
            {
                XtraMessageBox.Show("Bạn chưa chọn sự kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string str = "Select * from Customer where MaSuKien = N'" + cboSuKien.uEditValue + "'";

            DataTable DT = cnn.SelectRows(str);
            if (DT.Rows.Count == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để xuất Excel", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string XLSfileName = ShowSaveFileDialog();
            if (XLSfileName != "")
            {
                Export(XLSfileName, DT);
            }
        }
        private void Export(string _sDir, DataTable DT)
        {

            string sourceFileName = Application.StartupPath + @"\FileMau\Export.xls";
            if (!Directory.Exists(Application.StartupPath + @"\FileMau\"))
                Directory.CreateDirectory(Application.StartupPath + @"\FileMau\");
            string sServerPath = Program.sPathServer + @"FileMau\Export.xls";
            clRun.CheckVersionReports(sServerPath, sourceFileName);

            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Excel.ApplicationClass xlApp = new Excel.ApplicationClass();
            Excel.Workbook xlBook;
            Excel.Worksheet xlSheet;
            try
            {
                File.Copy(sourceFileName, _sDir, true);
                xlBook = xlApp.Workbooks.Open(_sDir, 0, false, 5, null, null, false, Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                xlSheet = (Excel.Worksheet)xlBook.Worksheets.get_Item(1);
                xlSheet.Activate();
                xlApp.Visible = false;

                if (DT.Rows.Count > 0)
                {

                    int iStart = 2, iSTT = 1;
                    foreach (DataRow dr in DT.Rows)
                    {
                        string link = "";
                        //string MySql = "";
                        /////////////////
                        //MySql = "INSERT INTO customer (IDCustomer, HoDem, Ten, DiaChi, CMND, Checked, DienThoai, Gender, Email, ChucVu, LoaiSuKien, NamKinhNghiem, NganhNghe, LoaiNganhNghe, MaSuKien, TenCongTy, DiaDiem) VALUES";
                        //MySql = MySql + " ('" + dr["IDCustomer"] + "','" + dr["HoDem"] + "','" + dr["Ten"] + "','" + dr["DiaChi"] + "','" + dr["CMND"] + "','" + dr["Checked"] + "','" + dr["DienThoai"] + "','" + dr["Gender"] + "','" + dr["Email"] + "','" + dr["ChucVu"] +
                        //    "','" + dr["LoaiSuKien"] + "','" + dr["NamKinhNghiem"] + "','" + dr["NganhNghe"] + "','" + dr["LoaiNganhNghe"] + "','" + dr["MaSuKien"] + "','" + dr["TenCongTy"] + "','" + dr["DiaDiem"] + "')";
                        /////////////////////
                        if (txtLink.uText.Trim() != "")
                            link = txtLink.uText.Trim() + dr["IDCustomer"];
                        xlSheet.Cells[iStart, 1] = iSTT;
                        xlSheet.Cells[iStart, 2] = cnn.sNull2String(dr["IDCustomer"]);
                        xlSheet.Cells[iStart, 3] = cnn.sNull2String(dr["HoDem"]);
                        xlSheet.Cells[iStart, 4] = cnn.sNull2String(dr["Ten"]);
                        xlSheet.Cells[iStart, 5] = cnn.sNull2String(dr["TenCongTy"]);
                        xlSheet.Cells[iStart, 6] = cnn.sNull2String(dr["DienThoai"]);
                        xlSheet.Cells[iStart, 7] = cnn.sNull2String(dr["Email"]);
                        xlSheet.Cells[iStart, 8] = cnn.sNull2String(dr["ChucVu"]);
                        xlSheet.Cells[iStart, 9] = cnn.sNull2String(dr["DiaChi"]);
                        xlSheet.Cells[iStart, 10] = cnn.sNull2String(dr["LoaiSuKien"]);
                        xlSheet.Cells[iStart, 11] = cnn.sNull2String(dr["NamKinhNghiem"]);
                        xlSheet.Cells[iStart, 12] = cnn.sNull2String(dr["NganhNghe"]);
                        xlSheet.Cells[iStart, 13] = cnn.sNull2String(dr["LoaiNganhNghe"]);
                        xlSheet.Cells[iStart, 14] = cnn.sNull2String(dr["DiaDiem"]);
                        xlSheet.Cells[iStart, 15] = link;

                        ///////
                        //xlSheet.Cells[iStart, 16] = MySql;
                        ///////

                        iStart++;
                        iSTT++;
                    }
                    iStart--;

                    xlBook.Save();
                }
                xlApp.Visible = true;
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                Cursor.Current = currentCursor;
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("Bạn phải đóng file Excel", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                xlApp.Workbooks.Close();
                xlApp.Quit();
            }
        }
        private string ShowSaveFileDialog()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Export To Microsoft Excel Document";
            dlg.OverwritePrompt = true;
            dlg.FileName = "DanhSachKhachHang";
            dlg.Filter = "Excel Files|*.xls";
            if (dlg.ShowDialog() == DialogResult.OK) return dlg.FileName;// +".xls";
            return "";
        }
    }
}