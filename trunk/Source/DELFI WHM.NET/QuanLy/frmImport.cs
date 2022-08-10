using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DELFI_WHM.NET;
using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;
using DELFI_WHM.NET.DELFI_Class;
using System.Data.OleDb;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;

namespace DELFI_WHM.NET.QuanLy
{
    public partial class frmImport : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        int Dongdangchon = -1;
        string _LocationCode = "";
        string _LocationName = "";
        string _QRCode = "";

        public frmImport()
        {
            InitializeComponent();
        }
        System.Data.OleDb.OleDbConnection cnnExcel = new System.Data.OleDb.OleDbConnection();
        string sExcel;
        public void Connect_Excel()
        {
            try
            {
                OpenFileDialog openFD = new OpenFileDialog();
                openFD.Title = "Open Microsoft Excel Document";
                //openFD.Filter = "Excel Files|*.xlsx";
                openFD.Filter = "Excel Files|*.*";
                if (openFD.ShowDialog() != DialogResult.OK)
                    return;
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
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }


        #region Import_Lot

        public void Import_DMLOT()
        {
            Connect_Excel();
            DataTable dt = new DataTable();
            try
            {
                DataTable dtTABLE_NAME = cnnExcel.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                OleDbDataAdapter data = new OleDbDataAdapter("SELECT *, '" + cnn.Shift() + "' as Shift, '" + DateTime.Now + "' as CreateDate FROM [" + dtTABLE_NAME.Rows[0]["TABLE_NAME"].ToString() + "]", sExcel);
                DataSet ds = new DataSet();
                data.Fill(ds);
                dt = ds.Tables[0];
                cnnExcel.Close();

                if (dt.Rows.Count > 0)
                {
                    grid_DMLOT.DataSource = dt;
                    Dongdangchon = -1;
                    XtraMessageBox.Show("Đã nhận dữ liệu!", "Thông báo");
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu để Import!", "Thông báo");
                }
            }
            catch
            {
                XtraMessageBox.Show("Chương trình không thể kết nối đến file mà bạn chọn được.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnnExcel.Close();
                return;
            }
        }

        public void Import_Nhapkho()
        {
            Connect_Excel();
            DataTable dt = new DataTable();
            try
            {
                DataTable dtTABLE_NAME = cnnExcel.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                OleDbDataAdapter data = new OleDbDataAdapter("SELECT *, '" + cnn.Shift() + "' as Ca, '" + DateTime.Now + "' as Thoigian FROM [" + dtTABLE_NAME.Rows[0]["TABLE_NAME"].ToString() + "]", sExcel);
                DataSet ds = new DataSet();
                data.Fill(ds);
                dt = ds.Tables[0];
                cnnExcel.Close();

                if (dt.Rows.Count > 0)
                {
                    grid_Nhapkho.DataSource = dt;
                    Dongdangchon = -1;
                    XtraMessageBox.Show("Đã nhận dữ liệu!", "Thông báo");
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu để Import!", "Thông báo");
                }
            }
            catch
            {
                XtraMessageBox.Show("Chương trình không thể kết nối đến file mà bạn chọn được.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnnExcel.Close();
                return;
            }
        }

        #endregion Import_Lot

        #region Check lỗi

        private bool Check_DMLOT()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                gridView_DMLOT.FocusedRowHandle = -1;
                for (int i = 0; i < gridView_DMLOT.DataRowCount; i++)
                {
                    gridView_DMLOT.FocusedRowHandle = i;
                    Dongdangchon = i;
                    string a = gridView_DMLOT.GetRowCellValue(i, "Lot").ToString();
                    string b = gridView_DMLOT.GetRowCellValue(i, "Date").ToString();
                    string c = gridView_DMLOT.GetRowCellValue(i, "Bag").ToString();
                    string d = gridView_DMLOT.GetRowCellValue(i, "CropYear").ToString();
                    string e = gridView_DMLOT.GetRowCellValue(i, "ItemCode").ToString();
                    string f = gridView_DMLOT.GetRowCellValue(i, "PackingUnitCode").ToString();

                    var Lot = db.DM_Lot.Where(m => m.Lot == a).ToList();
                    var Ite = db.tblItems.Where(p => p.ItemNo == e).ToList();
                    var Cro = db.DM_CropYear.Where(q => q.Ten == d).ToList();
                    var Pac = db.DM_Packing.Where(r => r.PackageCode == f).ToList();
                    if (Lot.Count > 0)
                    {
                        XtraMessageBox.Show("Lot đã tồn tại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (Ite.Count == 0)
                    {
                        XtraMessageBox.Show("Không tìm thấy Sản phẩm", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (Cro.Count == 0)
                    {
                        XtraMessageBox.Show("Không tìm thấy CropYear", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (Pac.Count == 0)
                    {
                        XtraMessageBox.Show("Không tìm thấy Loại bao bì", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (c.ToString().Length == 0)
                    {
                        XtraMessageBox.Show("Số bao không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (b.ToString().Length == 0)
                    {
                        XtraMessageBox.Show("Ngày không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }

        private bool Check_Nhapkho()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                gridView_Nhapkho.FocusedRowHandle = -1;
                for (int i = 0; i < gridView_Nhapkho.DataRowCount; i++)
                {
                    gridView_Nhapkho.FocusedRowHandle = i;
                    Dongdangchon = i;
                    string a = gridView_Nhapkho.GetRowCellValue(i, "Lot").ToString();
                    string b = gridView_Nhapkho.GetRowCellValue(i, "Date").ToString();
                    int c = Convert.ToInt32(gridView_Nhapkho.GetRowCellValue(i, "TruckQty"));
                    string d = gridView_Nhapkho.GetRowCellValue(i, "CropYear").ToString();
                    string e = gridView_Nhapkho.GetRowCellValue(i, "ItemNo").ToString();
                    string f = gridView_Nhapkho.GetRowCellValue(i, "PackageCode").ToString();
                    int g = Convert.ToInt32(gridView_Nhapkho.GetRowCellValue(i, "NetWeight"));


                    var Lot = db.DM_Lot.Where(m => m.Lot == a).ToList();
                    var Ite = db.tblItems.Where(p => p.ItemNo == e).ToList();
                    var Cro = db.DM_CropYear.Where(q => q.Ten == d).ToList();
                    var Pac = db.DM_Packing.Where(r => r.PackageCode == f).ToList();
                    
                    if (Lot.Count == 0)
                    {
                        XtraMessageBox.Show("Không tìm thấy Lot", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (Ite.Count == 0)
                    {
                        XtraMessageBox.Show("Không tìm thấy Sản phẩm", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (Cro.Count == 0)
                    {
                        XtraMessageBox.Show("Không tìm thấy Chứng nhận", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (Pac.Count == 0)
                    {
                        XtraMessageBox.Show("Không tìm thấy Loại bao bì", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (c.ToString().Length == 0)
                    {
                        XtraMessageBox.Show("Số bao không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (b.ToString().Length == 0)
                    {
                        XtraMessageBox.Show("Ngày không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }                  
                }
            }
            return true;
        }

        #endregion Check lỗi

        #region Lưu

        public void Luu_DMLOT()
        {
            if (!Check_DMLOT())
                return;
            DataTable dt = new DataTable();
            dt = cnn.DT_DataTable("SELECT * FROM dbo.DM_Lot WHERE Lot = ''");
            dt = cnn.GetDataTable(gridView_DMLOT, dt);
            cnn.SqlBulkCopy(dt, "DM_Lot");
            Dongdangchon = -1;
            XtraMessageBox.Show("Import thành công", "Thông báo");
        }

        private void Luu_DM_NhapKho()
        {
            if (!Check_Nhapkho())
                return;
            this.Cursor = Cursors.WaitCursor;
            using (DBACOMEntities db = new DBACOMEntities())
            {
                DM_Location lc = db.DM_Location.Where(c => c.Status == true).FirstOrDefault();
                _LocationCode = lc.Code;
                _LocationName = lc.LocationName;

                for (int i = 0; i < gridView_Nhapkho.DataRowCount; i++)
                {
                    DateTime Ngay = Convert.ToDateTime(gridView_Nhapkho.GetRowCellValue(i, "Date"));
                    Random RAN = new Random();
                    
                    string _Lot = gridView_Nhapkho.GetRowCellValue(i, "Lot").ToString();
                    string _Vitri = gridView_Nhapkho.GetRowCellValue(i, "BinCode").ToString();
                    string _MaSanPham = gridView_Nhapkho.GetRowCellValue(i, "ItemNo").ToString();
                    string _Cer = gridView_Nhapkho.GetRowCellValue(i, "Certificate").ToString();
                    string _Loai = gridView_Nhapkho.GetRowCellDisplayText(i, "PackageCode");
                    string _QuiCach = gridView_Nhapkho.GetRowCellValue(i, "PackageCode").ToString();
                    string _Note = gridView_Nhapkho.GetRowCellValue(i, "Note").ToString();
                    string _CropYear = gridView_Nhapkho.GetRowCellValue(i, "CropYear").ToString();
                    bool _Sample = Convert.ToBoolean(gridView_Nhapkho.GetRowCellValue(i, "Sample"));
                                  
                    int _Trongluong = Convert.ToInt32(gridView_Nhapkho.GetRowCellValue(i, "NetWeight"));
                    int _Ca = cnn.Shift();
                    int Sobao = Convert.ToInt32(gridView_Nhapkho.GetRowCellValue(i, "TruckQty"));
                    var _Tyle = db.DM_Packing.Where(c => c.PackageCode == _QuiCach).ToList();
                    int _Format = Convert.ToInt32(_Tyle[0].Format);

                    for (int j = 1; j <= Sobao; j ++)
                    {
                        string abc = DateTime.Now.ToString("ddMMyyHHmmssff");
                        string bcd = i.ToString("0000");
                        string result = _LocationCode + "-" + abc.ToString() + "-" + bcd.ToString();
                        _QRCode = Convert.ToDateTime(DateTime.Now).ToString("yyyyMMddHHmmssff") + j.ToString();                        
                        //Lưu danh mục nhập kho
                        var q = db.DM_PhieuNhap.Where(c => c.PostingDate == Ngay.Date && c.Lot == _Lot && c.BinCode == _Vitri).ToList();
                        if (q.Count == 0)
                        {
                            db.DM_PhieuNhap.Add(new DM_PhieuNhap
                            {
                            PostingDate = Ngay,
                            WeightNote = result,
                            VendorName = "",
                            VendorCode = "",
                            Lot = _Lot,
                            BinCode = _Vitri,
                            ContractNo = "",
                            VehicleNo = "",
                            UserName = Properties.Settings.Default.USER_NAME,
                            Type = "Other",
                            NetWeight = _Trongluong,
                            Del = false
                            });
                        db.SaveChanges();
                        }
                        var Qr = db.WH_ChiTietNhapKho.Where(c => c.QRCode == _QRCode).ToList();
                        if (Qr.Count == 0)
                        {
                            //Lưu chi tiết nhập kho
                            var ch = db.DM_PhieuNhap.Where(c => c.PostingDate == Ngay.Date && c.Lot == _Lot && c.BinCode == _Vitri).Take(1).ToList();
                            int ID = Convert.ToInt32(ch[0].ID);
                            string _WeightNote = ch[0].WeightNote;
                            db.WH_ChiTietNhapKho.Add(new WH_ChiTietNhapKho
                            {
                                Document = _WeightNote,
                                Date = Convert.ToDateTime(Ngay),
                                QRCode = _QRCode,
                                ItemNo = _MaSanPham,
                                Lot = _Lot,
                                Certificate = _Cer,
                                PackageType = _Loai,
                                PackageCode = _QuiCach,
                                GrossWeight = _Trongluong,
                                TruckQty = 1,
                                PackageQty = 0,
                                TotalPackageQty = 0,
                                NetWeight = _Trongluong,
                                QRCodeQty = 0,
                                BinCode = _Vitri,
                                Note = _Note,
                                Sample = _Sample,
                                Type = "Other",
                                IDPhieuNhap = ID,
                                Thoigian = DateTime.Now.TimeOfDay,
                                Ca = _Ca,
                                Del = false
                            });
                            if (db.SaveChanges() > 0)
                            {
                                //Lưu tồn kho
                                db.WH_TonKho.Add(new WH_TonKho
                                {
                                    QRCode = _QRCode,
                                    ItemNo = _MaSanPham,
                                    Lot = _Lot,
                                    Certificate = _Cer,
                                    PackageType = _Loai,
                                    PackageCode = _QuiCach,
                                    BinCode = _Vitri,
                                    CropYear = _CropYear,
                                    Sample = _Sample,
                                    QRCodeQty = 0,
                                    Exported = false
                                });
                                db.SaveChanges();
                                var Thamso = new Dictionary<String, String>() { { "Lot", _Lot }, { "BinCode", _Vitri }, { "Nhap", _Trongluong.ToString() }, { "Xuat", "0" } };
                                cnn.SQL_ExecuteStoredProcedure("SP_TonKhoTucThoi", Thamso);
                            }
                        }
                    }
                }
                Dongdangchon = -1;
                this.Cursor = Cursors.Default;
                XtraMessageBox.Show("Import thành công", "Thông báo");
            }
        } 

        #endregion Lưu

        #region Chức năng

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView_Nhapkho_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (Tab.SelectedTabPage == Tab_DMLot)
            {
                Import_DMLOT();
            }
            if (Tab.SelectedTabPage == Tab_NhapKho)
            {
                Import_Nhapkho();
            }

            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Loaibao = db.DM_Packing.ToList();
                rptLoai.DataSource = ConvertToDataTable(Loaibao);
                rptLoai.DisplayMember = "PackageType";
                rptLoai.ValueMember = "PackageCode";
            }
        }

        private void btnLuu_Import_Click(object sender, EventArgs e)
        {
            if (Tab.SelectedTabPage == Tab_DMLot)
            {
                Luu_DMLOT();
            }
            if (Tab.SelectedTabPage == Tab_NhapKho)
            {
                Luu_DM_NhapKho();
            }
        }

        private void btnFilemau_Click(object sender, EventArgs e)
        {
            if (Tab.SelectedTabPage == Tab_DMLot)
            {
                string tb = "SELECT Lot, Bag, CropYear, ItemCode, Note, Date, BatchNo, PackingUnitCode FROM dbo.DM_Lot WHERE Lot = ''";
                Hashtable Val = new Hashtable();
                cnn.GetValue(btnFilemau, ref Val);
                DataTable dt = cnn.SearchRows(Val, tb, DELFI_WHM.NET.DELFI_Class.DELFIConnection.BSCLoadType.UseLoadProcess);
                SaveFileDialog filename = new SaveFileDialog();
                filename.Title = "Export To Microsoft Excel Document";
                filename.OverwritePrompt = true;
                filename.FileName = "DM_LOT.xls";
                filename.Filter = "Excel Files|*.xls;";
                if (filename.ShowDialog() == DialogResult.OK)
                {
                    new frmExport(dt, filename.FileName, "Excel").ShowDialog();
                }
            }
            if (Tab.SelectedTabPage == Tab_NhapKho)
            {
                string tb = "SELECT Date, ItemNo, Lot, Certificate, PackageCode, '' as CropYear, GrossWeight, TruckQty, PackageQty, TotalPackageQty, NetWeight, QRCodeQty, BinCode, Note, Sample, Type, IDPhieuNhap, Thoigian, Ca FROM dbo.WH_ChiTietNhapKho WHERE ItemNo = ' '";
                Hashtable Val = new Hashtable();
                cnn.GetValue(btnFilemau, ref Val);
                DataTable dt = cnn.SearchRows(Val, tb, DELFI_WHM.NET.DELFI_Class.DELFIConnection.BSCLoadType.UseLoadProcess);
                SaveFileDialog filename = new SaveFileDialog();
                filename.Title = "Export To Microsoft Excel Document";
                filename.OverwritePrompt = true;
                filename.FileName = "NhapKho.xls";
                filename.Filter = "Excel Files|*.xls;";
                if (filename.ShowDialog() == DialogResult.OK)
                {
                    new frmExport(dt, filename.FileName, "Excel").ShowDialog();
                }
            }
        }

        private void gridView_DMLOT_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;
            if (e.RowHandle == Dongdangchon)
                e.Appearance.ForeColor = Color.Red;
        }

        private void gridView_Nhapkho_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;
            if (e.RowHandle == Dongdangchon)
                e.Appearance.ForeColor = Color.Red;
        }

        #endregion Chức năng
        
    }
}
