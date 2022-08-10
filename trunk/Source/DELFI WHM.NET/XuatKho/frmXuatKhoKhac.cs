using DELFI_WHM.NET.DELFI_Class;
using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DELFI_WHM.NET.XuatKho
{
    public partial class frmXuatKhoKhac : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string _Loai, _QuiCach, _MaSanPham, _Lot;
        string _Vitri = "RECEIVING";
        string _Cer = "NONE";
        DateTime Ngay = DateTime.Now;
        decimal _Trongluong = 0;
        string _LocationCode = "";
        string _LocationName = "";
        int _Ca;
        string _ID = "";
        public frmXuatKhoKhac()
        {
            InitializeComponent();
        }

        public void Form_Load()
        {
            Load_cboMaSanPham();
            Load_cboVitri();
            Load_Cer();
            Load_LoaiPhieuGiam();
            Load_Lot();
            Load_Quicach();
            if (!cnn.bComboIsNull(cboLoaiGiam))
            {
                _ID = cboLoaiGiam.uEditValue.ToString();
            }
            string Tungay = Convert.ToDateTime(dtpTungay.uValue).ToString("yyyy-MM-dd");
            string Denngay = Convert.ToDateTime(dtpDenngay.uValue).ToString("yyyy-MM-dd");
            var Thamso = new Dictionary<String, String>() { { "Tungay", Tungay }, { "Denngay", Denngay } , { "ID_LoaiPhieuGiam" , _ID} };
            griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_XuatKhac", Thamso);
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                gridView1.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }

            var Thamso_1 = new Dictionary<String, String>() { { "Ngay", Convert.ToDateTime(cnn.GetDateServer()).ToString("yyyy-MM-dd") }, { "BinCode", "" }, { "ItemNo", "" }, { "Lot", "" }, { "Type", "5" } };
            grid_XacNhan.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_TonKho", Thamso_1);
            gridView_XacNhan.BestFitColumns();
        }

        private void frmXuatKhoKhac_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                btnLuu_Click(sender, e);
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void cboLot_uEditValueChanged(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboLot))
            {
                _Lot = cboLot.uEditValue.ToString();
                using (DBACOMEntities DB = new DBACOMEntities())
                {
                    var qc = DB.DM_Lot.Where(c => c.Lot == _Lot).ToArray();
                    if (qc != null)
                    {
                        txtCropYear.Text = qc[0].CropYear;
                        cboMaSanPham.uEditValue = qc[0].ItemCode;
                        cboQuicach.uEditValue = qc[0].PackingUnitCode;
                    }
                }
            }
            else
            {
                txtCropYear.Text = "";
            }
        }

        private void frmXuatKhoKhac_Load(object sender, EventArgs e)
        {
            dtpTungay.uValue = cnn.GetDateServer();
            dtpDenngay.uValue = cnn.GetDateServer();
            Form_Load();
        }

        private bool Check_Cond()
        {
            if (txtQRCode.uText.Trim() != "")
            {
                if (cnn.DT_DataTable("SELECT QRCode FROM WH_TonKho WHERE QRCode = '" + txtQRCode.uText + "' AND Exported = 0").Rows.Count == 0)
                {
                    txtQRCode.Focus();
                    XtraMessageBox.Show("QRCode không hợp lệ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);                   
                    return false;
                }
            }
            if (cnn.bComboIsNull(cboLot))
            {
                cboLot.Focus();
                XtraMessageBox.Show("Bạn chưa chọn Lot", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false;
            }
            if (cnn.bComboIsNull(cboMaSanPham))
            {
                cboMaSanPham.Focus();
                XtraMessageBox.Show("Bạn chưa chọn Sản phẩm", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cnn.bComboIsNull(cboQuicach))
            {
                cboQuicach.Focus();
                XtraMessageBox.Show("Bạn chưa chọn Loại bao bì", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false;
            }
            if (cnn.bComboIsNull(cboVitri))
            {
                cboVitri.Focus();
                XtraMessageBox.Show("Bạn chưa chọn Cây hàng", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!cnn.bComboIsNull(cboLot))
            {
                if (cnn.Check_Lot(cnn.sNull2String(cboLot.uEditValue)) == false)
                {
                    XtraMessageBox.Show("Mã Lot không tồn tại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void Check()
        {
            if (!cnn.bComboIsNull(cboCer))
            {
                _Cer = cboCer.uEditValue.ToString();
            }
            else
            {
                _Cer = "NONE";
            }
            _QuiCach = cboQuicach.uEditValue.ToString();
            _MaSanPham = cboMaSanPham.uEditValue.ToString();
            if (!cnn.bComboIsNull(cboVitri))
            {
                _Vitri = cboVitri.uEditValue.ToString();
            }
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var L = db.DM_Packing.Where(c => c.PackageCode == _QuiCach).ToList();
                _Loai = L[0].PackageType.ToString();
            }
        }

        private void Location_Code()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                DM_Location lc = db.DM_Location.Where(c => c.Status == true).FirstOrDefault();
                _LocationCode = lc.Code;
                _LocationName = lc.LocationName;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Check_Cond())
                return;
            Check();
            using (DBACOMEntities db = new DBACOMEntities())
            {
                //Khởi tạo WeightNote
                DM_Location lc = db.DM_Location.Where(c => c.Status == true).FirstOrDefault();
                _LocationCode = lc.Code;
                _LocationName = lc.LocationName;

                _Ca = cnn.Shift();
                Random RAN = new Random();
                string abc =cnn.GetDateServer().ToString("ddMMyyHHmmss");
                int bcd = RAN.Next(1000, 9999);
                string result = _LocationCode + "-" + abc.ToString() + "-" + bcd.ToString();
                //Lưu danh mục xuất kho
                    db.DM_PhieuXuat.Add(new DM_PhieuXuat
                    {
                        PostingDate = Ngay,
                        WeightNote = result,
                        Lot = _Lot,
                        BinCode = _Vitri,
                        UserName = Properties.Settings.Default.USER_NAME,
                        Type = "Other",
                        ContractNo = "",
                        ID_LenhSX = 0
                    });
                    db.SaveChanges();

                    //Lưu chi tiết xuất kho
                    var list = db.DM_PhieuXuat.Where(c => c.WeightNote == result).ToList();
                    int ID = Convert.ToInt32(list[0].ID);
                db.WH_ChiTietXuatKho.Add(new WH_ChiTietXuatKho
                {
                    WeightNote = result,
                    DocumentNo = "",
                    Date = Ngay,
                    ItemNo = _MaSanPham,
                    QRCode = txtQRCode.uText,
                    QRCodeQty = spnTrongluong.uValue,
                    Lot = _Lot,
                    Certificate = _Cer,
                    BinCode = _Vitri,
                    PackageType = _Loai,
                    GrossWeight = Convert.ToDecimal(spnTrongluong.uValue),
                    TruckQty = spnSoBao.uValue,
                    PackageQty = 0,
                    TotalPackageQty = 0,
                    PackageCode = _QuiCach,
                    Note = txtGhichu.uText,
                    Type = "Other",
                    IDPhieuXuat = ID,
                    IDLenhSanXuat = 0,
                    LocationCode = _LocationCode,
                    LocationName = _LocationName,
                    Thoigian = cnn.GetDateServer().TimeOfDay,
                    Ca = _Ca,
                    LoaiXuat = cboLoaiPhieuGiam.uEditValue.ToString(),
                    UserName = Properties.Settings.Default.USER_NAME,
                    CreateDate = cnn.GetDateServer()
                });
                db.SaveChanges();
                
                cnn.ExecuteNonQuery("UPDATE WH_Tonkho Set Exported = 1 WHERE QRCode  = '" + txtQRCode.uText + "'");

                Form_Load();
                XtraMessageBox.Show("Lưu thông tin thành công", "Thông báo");
            }
        } 

        private void Load_cboMaSanPham()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var it = db.tblItems.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ItemNo");
                dt.Columns.Add("ItemName");
                dt = cnn.ConvertToDataTable(it);
                cboMaSanPham.uDataSource = dt;
            }
        }

        private void Load_Cer()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Cer = db.DM_Certificate.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Ten");
                dt = cnn.ConvertToDataTable(Cer);
                cboCer.uDataSource = dt;
            }
        }

        private void Load_Quicach()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                {
                    var Quicach = db.DM_Packing.ToList();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("PackageCode");
                    dt = cnn.ConvertToDataTable(Quicach);
                    cboQuicach.uDataSource = dt;
                }
            }
        }

        private void Load_Lot()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Lot = db.DM_Lot.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Lot");
                dt.Columns.Add("ItemCode");
                dt = cnn.ConvertToDataTable(Lot);
                cboLot.uDataSource = dt;
            }
        }

        private void Load_cboVitri()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Vitri = db.DM_Pile.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("BinCode");
                dt = cnn.ConvertToDataTable(Vitri);
                cboVitri.uDataSource = dt;
            }
        }

        private void Load_LoaiPhieuGiam()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var LoaiPhieu = db.DM_LoaiPhieuGiam.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("LoaiGiamKho");
                dt = cnn.ConvertToDataTable(LoaiPhieu);
                cboLoaiGiam.uDataSource = dt;
                cboLoaiPhieuGiam.uDataSource = dt;
                cboLoaiXuat_XN.uDataSource = dt;
            }
        }

        private void cboMaSanPham_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboMaSanPham();
        }

        private void cboCer_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_Cer();
        }

        private void cboQuicach_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_Quicach();
        }

        private void cboLoaiPhieuGiam_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_LoaiPhieuGiam();
        }

        private void cboLoaiGiam_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_LoaiPhieuGiam();
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
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Connect_Excel();
            DataTable dt = new DataTable();
            try
            {
                DataTable dtTABLE_NAME = cnnExcel.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                OleDbDataAdapter data = new OleDbDataAdapter("SELECT * FROM [" + dtTABLE_NAME.Rows[0]["TABLE_NAME"].ToString() + "]", sExcel);
                DataSet ds = new DataSet();
                data.Fill(ds);
                dt = ds.Tables[0];
                cnnExcel.Close();

                if (dt.Rows.Count > 0)
                {
                    gridControl1.DataSource = dt;
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            for (int i= 0; i< gridView2.DataRowCount; i ++)
            {
                cboLot.uEditValue = gridView2.GetRowCellValue(i, "Lot");
                cboMaSanPham.uEditValue = gridView2.GetRowCellValue(i, "ItemNo");
                cboQuicach.uEditValue = gridView2.GetRowCellValue(i, "PackageCode");
                cboVitri.uEditValue = gridView2.GetRowCellValue(i, "BinCode");
                cboCer.uEditValue = "NONE";
                spnTrongluong.uValue = 0;
                spnSoBao.uValue = Convert.ToDecimal(gridView2.GetRowCellValue(i, "SoBao"));
                txtGhichu.uText = "Điều chỉnh số bao tồn kho 09/09/2020";
                cboLoaiPhieuGiam.uEditValue = "1";
                btnLuu_Click(sender, e);
            }
            XtraMessageBox.Show("Thành công", "Thông báo");
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView1.OptionsSelection.MultiSelect = true;
                gridView1.SelectAll();
            }
        }

        private void txtQRCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = new DataTable();
                dt = cnn.DT_DataTable("SELECT TOP (1) * FROM WH_Tonkho WHERE QRCode = '" + txtQRCode.uText + "' AND Exported = 0");
                if (dt.Rows.Count > 0)
                {
                    cboLot.uEditValue = dt.Rows[0]["Lot"].ToString();
                    cboMaSanPham.uEditValue = dt.Rows[0]["ItemNo"].ToString();
                    cboQuicach.uEditValue = dt.Rows[0]["PackageCode"].ToString();
                    cboVitri.uEditValue = dt.Rows[0]["BinCode"].ToString();
                    cboCer.uEditValue = dt.Rows[0]["Certificate"].ToString();
                }
                else
                {
                    XtraMessageBox.Show("QRCode không hợp lệ", "Thông báo");
                }
            }
        }

        private void gridView_XacNhan_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            cnn.clearControl(group);
            if (cnn.bComboIsNull(cboLoaiXuat_XN))
            {
                cboLoaiXuat_XN.Focus();
                XtraMessageBox.Show("Vui lòng chọn Loại giảm kho", "Thông báo");
            }
            else
            {

                for (int i = 0; i < gridView_XacNhan.RowCount; i++)
                {
                    if (gridView_XacNhan.GetRowCellValue(i, "Chon").ToString() == "True")
                    {
                        if (gridView_XacNhan.GetRowCellValue(i, "Cer").ToString() != "")
                        {
                            _Cer = gridView_XacNhan.GetRowCellValue(i, "Cer").ToString();
                        }
                        else
                        {
                            _Cer = "NONE";
                        }
                        _QuiCach = gridView_XacNhan.GetRowCellValue(i, "PackageCode").ToString();
                        _MaSanPham = gridView_XacNhan.GetRowCellValue(i, "ItemNo").ToString();
                        _Lot = gridView_XacNhan.GetRowCellValue(i, "Lot").ToString();
                        if (gridView_XacNhan.GetRowCellValue(i, "BinCode").ToString() != "")
                        {
                            _Vitri = gridView_XacNhan.GetRowCellValue(i, "BinCode").ToString();
                        }
                        else
                        {
                            _Vitri = "RECEIVING";
                        }
                        using (DBACOMEntities db = new DBACOMEntities())
                        {
                            var L = db.DM_Packing.Where(c => c.PackageCode == _QuiCach).ToList();
                            _Loai = L[0].PackageType.ToString();
                        }

                        using (DBACOMEntities db = new DBACOMEntities())
                        {
                            //Khởi tạo WeightNote
                            DM_Location lc = db.DM_Location.Where(c => c.Status == true).FirstOrDefault();
                            _LocationCode = lc.Code;
                            _LocationName = lc.LocationName;

                            _Ca = cnn.Shift();
                            Random RAN = new Random();
                            string abc = cnn.GetDateServer().ToString("ddMMyyHHmmss");
                            int bcd = RAN.Next(1000, 9999);
                            string result = _LocationCode + "-" + abc.ToString() + "-" + bcd.ToString();
                            //Lưu danh mục xuất kho
                            db.DM_PhieuXuat.Add(new DM_PhieuXuat
                            {
                                PostingDate = Ngay,
                                WeightNote = result,
                                Lot = _Lot,
                                BinCode = _Vitri,
                                UserName = Properties.Settings.Default.USER_NAME,
                                Type = "Other",
                                ContractNo = "",
                                ID_LenhSX = 0
                            });
                            db.SaveChanges();

                            //Lưu chi tiết xuất kho
                            var list = db.DM_PhieuXuat.Where(c => c.WeightNote == result).ToList();
                            int ID = Convert.ToInt32(list[0].ID);
                            db.WH_ChiTietXuatKho.Add(new WH_ChiTietXuatKho
                            {
                                WeightNote = result,
                                DocumentNo = "",
                                Date = Ngay,
                                ItemNo = _MaSanPham,
                                QRCode = "",
                                QRCodeQty = Convert.ToDecimal(gridView_XacNhan.GetRowCellValue(i, "NetWeight").ToString()),
                                Lot = _Lot,
                                Certificate = _Cer,
                                BinCode = _Vitri,
                                PackageType = _Loai,
                                GrossWeight = Convert.ToDecimal(gridView_XacNhan.GetRowCellValue(i, "NetWeight").ToString()),
                                TruckQty = 0,
                                PackageQty = 0,
                                TotalPackageQty = 0,
                                PackageCode = _QuiCach,
                                Note = txtGhichu_XN.uText,
                                Type = "Other",
                                IDPhieuXuat = ID,
                                IDLenhSanXuat = 0,
                                LocationCode = _LocationCode,
                                LocationName = _LocationName,
                                Thoigian = cnn.GetDateServer().TimeOfDay,
                                Ca = _Ca,
                                LoaiXuat = cboLoaiXuat_XN.uEditValue.ToString(),
                                UserName = Properties.Settings.Default.USER_NAME,
                                CreateDate = cnn.GetDateServer()
                            });
                            db.SaveChanges();
                        }
                    }
                }
                Form_Load();
                XtraMessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
            }
        }

        private void cboLoaiXuat_XN_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_LoaiPhieuGiam();
        }

        private void cboLot_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_Lot();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Form_Load();
        }

        private void cboVitri_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboVitri();
        }
    }
}
