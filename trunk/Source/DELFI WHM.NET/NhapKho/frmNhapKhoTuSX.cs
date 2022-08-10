using DELFI_WHM.NET.DELFI_Class;
using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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

namespace DELFI_WHM.NET.NhapKho
{
    public partial class frmNhapKhoTuSX : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        public static string Access_Connection = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Database.mdb";
        string _Loai, _QuiCach, _MaSanPham, _CropYear, _Ghichu, _Chungtu_LSX; 
        string _Vitri = "RECEIVING";
        string _Cer = "NONE";
        string _Lot = "";
        DateTime Ngay;
        DateTime _Ngaynhap = DateTime.Now;
        string _QRCode = "";
        string _Sophieu = "";
        string _LSX = "";
        decimal _Trongluong = 0;
        string _LocationCode = "";
        string _LocationName = "";
        string PrinterName = "";
        int TrongLuongCan = 0;
        int _Ca;
        bool CanHang = false;
        public frmNhapKhoTuSX(frmDS_NhapKhoTuSX parent)
        {
            InitializeComponent();
        }
        public string Chungtu {get { return _Sophieu; } set { _Sophieu = value; } }
        public DateTime Ngaynhap {get { return _Ngaynhap; } set { _Ngaynhap = value; }}
        public string QR {get { return _QRCode; } set { _QRCode = value; }}
        public string Chungtu_LSX { get { return _Chungtu_LSX; } set { _Chungtu_LSX = value; } }

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

        public void Form_Load()
        {
            if (!cnn.bComboIsNull(cboLot))
            using (DBACOMEntities db = new DBACOMEntities())
            {
                Ngay = cnn.GetDateServer().AddDays(-15);

                foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
                {
                    if (col.FieldName != gridView1.Columns["Chon"].FieldName)
                        col.OptionsColumn.AllowEdit = false;
                }
                var Thamso = new Dictionary<String, String>() { { "Document", Chungtu }, { "Loai", "Processing" } };
                griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_ChitietNhapTuNCC", Thamso);
                groupControl.Select();
                if (Chungtu.Length > 0)
                {
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    btnInTem.Enabled = true;
                }
                else
                {
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    btnInTem.Enabled = false;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {            
            groupControl.Enabled = true;
            dtpNgayTao.uValue = cnn.GetDateServer();            
            Form_Load();
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cnn.clearControl(groupControl);
        }

        private void frmNhapKhoTuSX_KeyUp(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.F4)
            {
                btnLuu_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnRefresh_Click(sender, e);
            }
        }

        public void Intem()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("QRCode");
            dt.Columns.Add("Date");
            dt.Columns.Add("ItemNo");
            dt.Columns.Add("Lot");
            dt.Columns.Add("CropYear");
            dt.Columns.Add("QRCodeQty");
            dt.Columns.Add("PackageType");
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, "Chon").ToString() == "True")
                {
                    dt.Rows.Add(gridView1.GetRowCellValue(i, "QRCode"),
                                Convert.ToDateTime(gridView1.GetRowCellValue(i, "Date")).ToString("dd/MM/yyyy"),
                                gridView1.GetRowCellValue(i, "ItemNo"),
                                gridView1.GetRowCellValue(i, "Lot"),
                                gridView1.GetRowCellValue(i, "CropYear"),
                                gridView1.GetRowCellValue(i, "QRCodeQty"),
                                gridView1.GetRowCellValue(i, "PackageType"));
                }
            }
            //using (DBACOMEntities db = new DBACOMEntities())
            //{
            //    var pr = db.tblConfigScale.Where(c => c.ID == 15).ToList();
            //    PrinterName = pr[0].Description;
            PrinterName = cnn.DT_DataTable("SELECT Description FROM tblConfigScales WHERE ID = 15").Rows[0]["Description"].ToString();
            BaoCaoTK.frmViewReport_Directc frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport_Directc(Application.StartupPath + @"\Report\PhieuNhapTuSX.repx", dt, true, PrinterName);
            //}
        }

        private void btnInTem_Click(object sender, EventArgs e)
        {
            Intem();
        }

        private void cboQuicach_uEditValueChanged(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboQuicach))
            {
                DataTable dt = new DataTable();
                dt = cnn.DT_DataTable("SELECT PackageType, PackageQty FROM DM_Packing WHERE PackageCode = '" + cboQuicach.uEditValue.ToString() + "'");
                if (dt.Rows.Count > 0)
                {
                    cboLoai.uEditValue = dt.Rows[0]["PackageType"].ToString();
                    spnTLTrubi.uValue = Convert.ToDecimal(dt.Rows[0]["PackageQty"]);
                }
                //string Quicach = cboQuicach.uEditValue.ToString();
                //using (DBACOMEntities DB = new DBACOMEntities())
                //{
                //    var qc = DB.DM_Packing.Where(c => c.PackageCode == Quicach).First();
                //    if (qc != null)
                //    {
                //        cboLoai.uEditValue = qc.PackageType;
                //        spnTLTrubi.uValue = Convert.ToDecimal(qc.PackageQty);
                //    }
                //}
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

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
                Load_cboLSX();
                Load_cboMaSanPham();
                Load_cboVitri();
                Load_Cer();
                Load_Lot();
                Load_Quicach();
                _Lot = cboLot.uEditValue.ToString();

                DataTable dt = new DataTable();
                dt = cnn.DT_DataTable("SELECT * FROM DM_Lot WHERE Lot = '" + cboLot.uEditValue.ToString() + "'");
                if (dt.Rows.Count > 0)
                {
                    txtCropYear.Text = dt.Rows[0]["CropYear"].ToString();
                    cboLSX.uEditValue = dt.Rows[0]["BatchNo"].ToString();
                    cboMaSanPham.uEditValue = dt.Rows[0]["ItemCode"].ToString();
                    cboQuicach.uEditValue = dt.Rows[0]["PackingUnitCode"].ToString();
                    cboCer.uEditValue = dt.Rows[0]["Cer"].ToString();
                }
                //using (DBACOMEntities DB = new DBACOMEntities())
                //{
                //    var qc = DB.DM_Lot.Where(c => c.Lot == _Lot).ToArray();
                //    if (qc != null)
                //    {
                //        txtCropYear.Text = qc[0].CropYear;
                //        cboLSX.uEditValue = qc[0].BatchNo;
                //        cboMaSanPham.uEditValue = qc[0].ItemCode;
                //        cboQuicach.uEditValue = qc[0].PackingUnitCode;
                //        cboCer.uEditValue = qc[0].Cer;
                //    }
                //}
            }
            else
            {                
                txtCropYear.Text = "";
            }
        }

        private void frmNhapKhoTuSX_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                gridView1.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
            Load_Lot();
            Load_cboLSX();
            cboLot.uEditValue = Chungtu;
            cboLSX.uEditValue = Chungtu_LSX;
            gridView1.SetRowCellValue(GridControl.AutoFilterRowHandle, gridView1.Columns["Document"], Chungtu_LSX);
            dtpNgayTao.uValue = cnn.GetDateServer();       
            Form_Load();
            timer1.Start();
        }

        private bool Check_Cond()
        {
            if (cnn.bComboIsNull(cboLot))
            {
                XtraMessageBox.Show("Bạn chưa chọn Lot", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupControl.Select();
                return false;
            }            
            if (cnn.bComboIsNull(cboLSX))
            {
                XtraMessageBox.Show("Bạn chưa chọn Lệnh sản xuất", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupControl.Select();
                return false;
            }
            if (cnn.bComboIsNull(cboMaSanPham))
            {
                XtraMessageBox.Show("Bạn chưa chọn Sản phẩm", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLSX.Focus();
                return false;
            }
            if (cnn.bComboIsNull(cboQuicach))
            {
                XtraMessageBox.Show("Bạn chưa chọn Loại bao bì", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCer.Focus();
                return false;
            }
            if (cnn.bComboIsNull(cboLot))
            {
                _Lot = "";
            }
            if (cnn.bComboIsNull(cboVitri))
            {
                _Vitri = "RECEIVING";
            }
            if (spnTrongluong.uValue == 0)
            {
                XtraMessageBox.Show("Chưa có số Cân", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spnTrongluong.Focus();
                return false;
            }
            if (spnSoBao.uValue == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập số bao của QRCode", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spnSoBao.Focus();
                return false;
            }
            if (CanHang == true)
            {
                XtraMessageBox.Show("Vui lòng trả số cân về 0 trước", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);             
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

            //using (DBACOMEntities db = new DBACOMEntities())
            //{
            //    var f = db.tblConfigLinkSync.Where(c => c.Value == "EX_PHIEUCANCAU").Select(p => p.Description).First();
            //    if (f == null)
            //    {
            //        return false;
            //    }
            //}
            return true;
        }

        private void Check()
        {
            if (!cnn.bComboIsNull(cboLSX))
            {
                _Sophieu = cboLSX.uEditValue.ToString();
            }
            if (!cnn.bComboIsNull(cboLoai))
            {
                _Loai = cboLoai.uEditValue.ToString();
            }
            else
            {
                _Loai = "";
            }
            if (!cnn.bComboIsNull(cboQuicach))
            {
                _QuiCach = cboQuicach.uEditValue.ToString();
            }
            else
            {
                _QuiCach = "";
            }
            if (!cnn.bComboIsNull(cboLot))
            {
                _Lot = cboLot.uEditValue.ToString();
            }
            else
            {
                _Lot = "";
            }
            if (!cnn.bComboIsNull(cboCer))
            {
                _Cer = cboCer.uEditValue.ToString();
            }
            else
            {
                _Cer = "NONE";
            }
            if (!cnn.bComboIsNull(cboMaSanPham))
            {
                _MaSanPham = cboMaSanPham.uEditValue.ToString();
            }
            if (!cnn.bComboIsNull(cboVitri))
            {
                _Vitri = cboVitri.uEditValue.ToString();
            }
            else
            {
                _Vitri = "RECEIVING";
            }
            Ngay = Convert.ToDateTime(cnn.GetDateServer());
        }

        private void Location_Code()
        {
            DataTable dt = new DataTable();
            dt = cnn.dt_Location();
            _LocationCode = dt.Rows[0]["Code"].ToString();
            _LocationName = dt.Rows[0]["LocationName"].ToString();
            //using (DBACOMEntities db = new DBACOMEntities())
            //{
            //    DM_Location lc = db.DM_Location.Where(c => c.Status == true).FirstOrDefault();
            //    _LocationCode = lc.Code;
            //    _LocationName = lc.LocationName;
            //}
        }

        private void ExportNAV()
        {
            Location_Code();
            SaveFileDialog filename = new SaveFileDialog();
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var f = db.tblConfigLinkSync.Where(c => c.Value == "EX_NHAPSX").Select(p => p.Description).First();

                filename.FileName = f;
                DataTable dt = new DataTable();
                dt.Columns.Add("");
                dt.Rows.Add("\"" + txtWeightNote.uText + "\";" +
                            "\"" + Convert.ToDateTime(dtpNgayTao.uValue).ToString("dd/MM/yyyy") + "\";" +
                            "\"" + "" + "\";" +
                            "\"" + _MaSanPham + "\";" +
                            "\"" + _LocationCode + "\";" +
                            "\"" + _LocationName + "\";" +
                            "\"" + "" + "\";" +
                            "\"" + Convert.ToInt32(spnTrongluong.uValue - spnTLTrubi.uValue) + "\";" +
                            "\"" + 0 + "\";" +
                            "\"" + 0 + "\";" +
                            "\"" + spnTLTrubi.uValue + "\";" +
                            "\"" + spnTLTrubi.uValue + "\";" +
                            "\"" + Convert.ToInt32(spnTrongluong.uValue - spnTLTrubi.uValue) + "\";" +
                            "\"" + "Receive" + "\";" +
                            "\"" + "" + "\"");
                new frmExport(dt, f, "txt");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {            
            if (!Check_Cond())
                return;
            Check();
            txtQRCode.uText = Convert.ToDateTime(cnn.DT_DataTable("SELECT GETDATE() as Thoigian").Rows[0]["Thoigian"]).ToString("yyyyMMddHHmmssffff");

            Location_Code();

            Random RAN = new Random();
            string abc = cnn.GetDateServer().ToString("ddMMyyHHmmss");
            int bcd = RAN.Next(1000, 9999);
            string result = _LocationCode + "-" + abc.ToString() + "-" + bcd.ToString();
            txtWeightNote.uText = result;
            _Trongluong = Convert.ToDecimal(spnTrongluong.uValue - spnTLTrubi.uValue);
            string NgayNhap = cnn.GetDateServer().ToString("yyyy-MM-dd");
            _Ca = cnn.Shift();

            //Lưu danh mục nhập kho
            {
                var Thamso_DM = new Dictionary<String, String>() { { "PostingDate", NgayNhap },
                                                                    { "WeightNote", result },
                                                                    { "VendorName", "" },
                                                                    { "VendorCode", "" },
                                                                    { "Lot", _Lot },
                                                                    { "BinCode", _Vitri },
                                                                    { "ContractNo", cboLSX.uEditValue.ToString() },
                                                                    { "VehicleNo", "" },
                                                                    { "UserName", Properties.Settings.Default.USER_NAME },
                                                                    { "Type", "Processing" },
                                                                    { "NetWeight", _Trongluong.ToString() }
                                                                   };
                cnn.SQL_ExecuteStoredProcedure("SP_INSERT_DMPhieuNhap", Thamso_DM);
            }

            //Lấy ID phiếu nhập vừa tạo
            DataTable dt = new DataTable();
            dt = cnn.DT_DataTable("SELECT * FROM DM_PhieuNhap WHERE WeightNote = '" + result + "'");
            int ID = Convert.ToInt32(dt.Rows[0]["ID"]);

            //Lưu chi tiết phiếu nhập
            {
                var Thamso_CT = new Dictionary<String, String>() {  {"Document", cboLSX.uEditValue.ToString() },
                                                                    {"Date", NgayNhap },
                                                                    {"QRCode", txtQRCode.uText },
                                                                    {"ItemNo", _MaSanPham },
                                                                    {"Lot", _Lot },
                                                                    {"Certificate", _Cer },
                                                                    {"PackageType", _Loai },
                                                                    {"PackageCode", _QuiCach },
                                                                    {"GrossWeight", spnTrongluong.uValue.ToString() },
                                                                    {"TruckQty", spnSoBao.uValue.ToString() },
                                                                    {"PackageQty", spnTLTrubi.uValue.ToString() },
                                                                    {"TotalPackageQty", spnTLTrubi.uValue.ToString() },
                                                                    {"NetWeight", _Trongluong.ToString() },
                                                                    {"QRCodeQty", _Trongluong.ToString() },
                                                                    {"BinCode", _Vitri },
                                                                    {"Note", txtGhichu.uText },
                                                                    {"Sample", chbHangmau.Checked.ToString() },
                                                                    {"Type", "Processing" },
                                                                    {"IDPhieuNhap", ID.ToString() },
                                                                    {"UserName", Properties.Settings.Default.USER_NAME } };
                cnn.SQL_ExecuteStoredProcedure("SP_INSERT_ChiTietPhieuNhap", Thamso_CT);
            }

            //Lưu tồn kho
            {
                var Thamso_TonKho = new Dictionary<String, String>() {  {"QRCode", txtQRCode.uText},
                                                                        {"ItemNo", _MaSanPham},
                                                                        {"Lot", _Lot},
                                                                        {"Certificate", _Cer},
                                                                        {"PackageType", _Loai},
                                                                        {"PackageCode", _QuiCach},
                                                                        {"BinCode", _Vitri},
                                                                        {"CropYear", txtCropYear.uText},
                                                                        {"Sample", chbHangmau.Checked.ToString()},
                                                                        {"QRCodeQty", _Trongluong.ToString()},
                                                                        {"Exported", "0"},
                                                                        {"TruckQty", spnSoBao.uValue.ToString()}};
                cnn.SQL_ExecuteStoredProcedure("SP_INSERT_TonKho", Thamso_TonKho);
            }

            Chungtu = cboLot.uEditValue.ToString();
            spnSoBao.uValue = 0;
            CanHang = true;
            XtraMessageBox.Show("Cập nhật danh sách thành công");
            Form_Load();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, "QRCode").ToString() == txtQRCode.uText)
                    gridView1.SetRowCellValue(i, "Chon", true);
            }
            Intem();
            btnThem_Click(sender, e);

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            spnTrongluong.uValue = frmMain.SoCanBan;
            if (spnTrongluong.uValue <= 0)
            {
                CanHang = false;
            }
        }

        private void Load_cboLSX()
        {
            var Thamso = new Dictionary<String, String>() { { "LenhSanXuat", Chungtu_LSX } };
            cboLSX.uDataSource = cnn.SQL_GetStoredProcedure("SP_List_NhapSX_LSX_GioiHan", Thamso);
        }

        private void Load_cboMaSanPham()
        {
            cboMaSanPham.uDataSource = cnn.dt_ItemCode();
            //using (DBACOMEntities db = new DBACOMEntities())
            //{
            //    {
            //        var it = db.tblItems.ToList();
            //        DataTable dt = new DataTable();
            //        dt.Columns.Add("ItemNo");
            //        dt.Columns.Add("ItemName");
            //        dt = ConvertToDataTable(it);
            //        cboMaSanPham.uDataSource = dt;
            //    }
            //}
        }

        private void Load_Cer()
        {
            cboCer.uDataSource = cnn.dt_Cer();
            //using (DBACOMEntities db = new DBACOMEntities())
            //{
            //    var Cer = db.DM_Certificate.ToList();
            //    DataTable dt = new DataTable();
            //    dt.Columns.Add("Ten");
            //    dt = ConvertToDataTable(Cer);
            //    cboCer.uDataSource = dt;
            //}
        }

        private void Load_Quicach()
        {
            cboQuicach.uDataSource = cnn.dt_PackageCode();
            cboLoai.uDataSource = cnn.dt_PackageType();
            //using (DBACOMEntities db = new DBACOMEntities())
            //{
            //    {
            //        var Quicach = db.DM_Packing.ToList();
            //        DataTable dt = new DataTable();
            //        dt.Columns.Add("PackageCode");
            //        dt = ConvertToDataTable(Quicach);
            //        cboQuicach.uDataSource = dt;
            //    }
            //    {
            //        var Loai = db.DM_LoaiBao.ToList();
            //        DataTable dt = new DataTable();
            //        dt.Columns.Add("Loai");
            //        dt = ConvertToDataTable(Loai);
            //        cboLoai.uDataSource = dt;
            //    }
            //}
        }

        private void Load_Lot()
        {
            var Thamso = new Dictionary<String, String>() { { "Lot", Chungtu }};
            cboLot.uDataSource = cnn.SQL_GetStoredProcedure("SP_List_NhapSX_Lot_GioiHan", Thamso);
        }

        private void Load_cboVitri()
        {
            cboVitri.uDataSource = cnn.dt_BinCode();
            //cboVitri.uDataSource = cnn.DT_DataTable("SELECT BinCode FROM DM_Pile");
        }

        private void cboLSX_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboLSX();
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

        private void cboLot_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_Lot();
        }

        private void cboVitri_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboVitri();
        }

        private void spnTLTrubi_uValueChanged(object sender, EventArgs e)
        {
            if (spnTLTrubi.uValue <0)
            {
                XtraMessageBox.Show("Trọng lượng trừ bì không được nhỏ hơn 0", "Thông báo");
                spnTLTrubi.uValue = 0;
            }
        }

        private void spnSoBao_uValueChanged(object sender, EventArgs e)
        {
            if (spnSoBao.uValue < 0)
            {
                spnSoBao.uValue = 0;
                XtraMessageBox.Show("Số bao không được âm", "Thông báo");
            }
        }
    }
}
