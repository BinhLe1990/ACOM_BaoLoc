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

namespace DELFI_WHM.NET.NhapKho
{
    public partial class frmNhapKhoKhac : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        public static string Access_Connection = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Database.mdb";
        string _Loai, _QuiCach, _MaSanPham; 
        string _Vitri = "RECEIVING";
        string _Cer = "NONE";
        string _Lot = "";
        DateTime Ngay;
        decimal _Trongluong = 0;
        string _LocationCode = "";
        string _LocationName = "";
        string PrinterName = "";
        int _Ca;
        string Chungtu = "";

        public frmNhapKhoKhac()
        {
            InitializeComponent();
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

        public void Form_Load()
        {
            string Tungay = Convert.ToDateTime(dtpTungay.uValue).ToString("yyyy-MM-dd");
            string Denngay = Convert.ToDateTime(dtpDenngay.uValue).ToString("yyyy-MM-dd");
            var Thamso = new Dictionary<String, String>() { { "QrCode", txtPhieucan.uText }, { "Tungay", Tungay }, { "Denngay", Denngay } };
            griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_NhapKhac", Thamso);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {            
            groupbox.Enabled = true;
            dtpNgayTao.uValue = cnn.GetDateServer();
            Form_Load();
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cnn.clearControl(groupbox);
            dtpNgayTao.uValue = cnn.GetDateServer();
        }

        private void frmNhapKhoKhac_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
                SendKeys.Send("{F4}");
            }
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
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var pr = db.tblConfigScale.Where(c => c.ID == 15).ToList();
                PrinterName = pr[0].Description;
                BaoCaoTK.frmViewReport_Directc frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport_Directc(Application.StartupPath + @"\Report\PhieuNhapTuSX.repx", dt, true, PrinterName);
            }
        }

        private void btnInTem_Click(object sender, EventArgs e)
        {
            Intem();
        }

        private void cboQuicach_uEditValueChanged(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboQuicach))
            {
                string Quicach = cboQuicach.uEditValue.ToString();
                using (DBACOMEntities DB = new DBACOMEntities())
                {
                    var qc = DB.DM_Packing.Where(c => c.PackageCode == Quicach).First();
                    if (qc != null)
                    {
                        cboLoai.uEditValue = qc.PackageType;
                        spnTLTrubi.uValue = Convert.ToDecimal(qc.PackageQty);
                    }
                }
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
                Load_cboMaSanPham();
                Load_cboVitri();
                Load_Cer();
                Load_Lot();
                Load_Quicach();
                _Lot = cboLot.uEditValue.ToString();
                using (DBACOMEntities DB = new DBACOMEntities())
                {
                    var qc = DB.DM_Lot.Where(c => c.Lot == _Lot).ToArray();
                    if (qc != null)
                    {
                        txtCropYear.Text = qc[0].CropYear;
                        cboMaSanPham.uEditValue = qc[0].ItemCode;
                        cboQuicach.uEditValue = qc[0].PackingUnitCode;
                        cboCer.uEditValue = qc[0].Cer;
                    }
                }
            }
            else
            {
                txtCropYear.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random RAN = new Random();
            try
            {
                int a = RAN.Next(1000, 1500);
                spnTrongluong.uValue = a;

            }
            catch { };
        }

        private void frmNhapKhoKhac_Load(object sender, EventArgs e)
        {
            Load_Lot();
            cboLot.uEditValue = Chungtu;

            dtpNgayTao.uValue = cnn.GetDateServer();
            dtpTungay.uValue = cnn.GetDateServer();
            dtpDenngay.uValue = cnn.GetDateServer();         
            Form_Load();
            timer1.Start();
        }

        private bool Check_Cond()
        {
            if (cnn.bComboIsNull(cboLot))
            {
                XtraMessageBox.Show("Bạn chưa chọn Lot", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupbox.Select();
                return false;
            }
            if (txtGhichu.uText.Trim().Length == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập Ghi chú", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGhichu.SelectAll();
                return false;
            }
            if (cnn.bComboIsNull(cboMaSanPham))
            {
                XtraMessageBox.Show("Bạn chưa chọn Sản phẩm", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cnn.bComboIsNull(cboQuicach))
            {
                XtraMessageBox.Show("Bạn chưa chọn Loại bao bì", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCer.Focus();
                return false;
            }
            if (cnn.bComboIsNull(cboVitri))
            {
                _Vitri = "RECEIVING";
            }
            if (spnTrongluong.uValue < spnTLTrubi.uValue)
            {
                XtraMessageBox.Show("Trọng lượng QRCode không được nhỏ hơn Trọng lượng trừ bì", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spnTLTrubi.Focus();
                return false;
            }
            if (spnSoBao.uValue == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập số bao của QRCode", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spnSoBao.Focus();
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
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var f = db.tblConfigLinkSync.Where(c => c.Value == "EX_PHIEUCANCAU").Select(p => p.Description).First();
                if (f == null)
                {
                    return false;
                }
            }
            return true;
        }

        private void Check()
        {
            if (!cnn.bComboIsNull(cboLoai))
            {
                _Loai = cboLoai.uEditValue.ToString();
            }
            if (!cnn.bComboIsNull(cboQuicach))
            {
                _QuiCach = cboQuicach.uEditValue.ToString();
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
            Ngay = Convert.ToDateTime(dtpNgayTao.uValue);
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

        private void ExportNAV()
        {
            Location_Code();
            SaveFileDialog filename = new SaveFileDialog();
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var f = db.tblConfigLinkSync.Where(c => c.Value == "EX_PHIEUCANCAU").Select(p => p.Description).First();

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
            using (DBACOMEntities db = new DBACOMEntities())
            {
                //Khởi tạo WeightNote
                DM_Location lc = db.DM_Location.Where(c => c.Status == true).FirstOrDefault();
                _LocationCode = lc.Code;
                _LocationName = lc.LocationName;

                Random RAN = new Random();
                string abc = cnn.GetDateServer().ToString("ddMMyyHHmmss");
                int bcd = RAN.Next(1000, 9999);
                string result = _LocationCode + "-" + abc.ToString() + "-" + bcd.ToString();
                txtWeightNote.uText = result;
                //txtQRCode.uText = Convert.ToDateTime(DateTime.Now).ToString("yyyyMMddHHmmssffff");
                txtQRCode.uText = Convert.ToDateTime(cnn.DT_DataTable("SELECT GETDATE() as Thoigian").Rows[0]["Thoigian"]).ToString("yyyyMMddHHmmssffff");
                _Trongluong = Convert.ToDecimal(spnTrongluong.uValue - spnTLTrubi.uValue);
                _Ca = cnn.Shift();
                string NgayNhap = cnn.GetDateServer().ToString("yyyy-MM-dd");

                //Lưu danh mục nhập kho
                //db.DM_PhieuNhap.Add(new DM_PhieuNhap
                //{
                //    PostingDate = Ngay,
                //    WeightNote = result,
                //    VendorName = "",
                //    VendorCode = "",
                //    Lot = _Lot,
                //    BinCode = _Vitri,
                //    ContractNo = "",
                //    VehicleNo = "",
                //    UserName = Properties.Settings.Default.USER_NAME,
                //    Type = "Other",
                //    NetWeight = spnTrongluong.uValue - spnTLTrubi.uValue
                //});
                //db.SaveChanges();

                //Lưu danh mục nhập kho
                {
                    var Thamso_DM = new Dictionary<String, String>() { { "PostingDate", NgayNhap},
                                                                    { "WeightNote", result },
                                                                    { "VendorName", "" },
                                                                    { "VendorCode", "" },
                                                                    { "Lot", _Lot },
                                                                    { "BinCode", _Vitri },
                                                                    { "ContractNo", "" },
                                                                    { "VehicleNo", "" },
                                                                    { "UserName", Properties.Settings.Default.USER_NAME },
                                                                    { "Type", "Other" },
                                                                    { "NetWeight", _Trongluong.ToString() }
                                                                   };
                    cnn.SQL_ExecuteStoredProcedure("SP_INSERT_DMPhieuNhap", Thamso_DM);
                }

                //Lưu chi tiết nhập kho                    
                //var ch = db.DM_PhieuNhap.Where(c => c.WeightNote == result).ToList();
                //    int ID = Convert.ToInt32(ch[0].ID);

                DataTable dt = new DataTable();
                dt = cnn.DT_DataTable("SELECT * FROM DM_PhieuNhap WHERE WeightNote = '" + result + "'");
                int ID = Convert.ToInt32(dt.Rows[0]["ID"]);

                //Lưu chi tiết phiếu nhập
                {
                    var Thamso_CT = new Dictionary<String, String>() {  {"Document", result },
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
                                                                    {"Type", "Other" },
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
        }
        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //int a = 0;
            //using (DBACOMEntities db = new DBACOMEntities())
            //{
            //    var list = db.tblConfigScale.Where(c => c.ID == 18).ToList();
            //    a = Convert.ToInt32(list[0].MaxSpeed);
            //}
            //spnTrongluong.uEditValue = a;
            spnTrongluong.uValue = frmMain.SoCanBan;
        }

        private void Load_cboMaSanPham()
        {
            cboMaSanPham.uDataSource = cnn.dt_ItemCode();
            //using (DBACOMEntities db = new DBACOMEntities())
            //{
            //    var it = db.tblItems.ToList();
            //    DataTable dt = new DataTable();
            //    dt.Columns.Add("ItemNo");
            //    dt.Columns.Add("ItemName");
            //    dt = ConvertToDataTable(it);
            //    cboMaSanPham.uDataSource = dt;
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
            cboLot.uDataSource = cnn.dt_Lot();
            //using (DBACOMEntities db = new DBACOMEntities())
            //{
            //    var Lot = db.DM_Lot.ToList();
            //    DataTable dt = new DataTable();
            //    dt.Columns.Add("Lot");
            //    dt.Columns.Add("ItemCode");
            //    dt = ConvertToDataTable(Lot);
            //    cboLot.uDataSource = dt;
            //}
        }

        private void Load_cboVitri()
        {
            cboVitri.uDataSource = cnn.dt_BinCode();
            //using (DBACOMEntities db = new DBACOMEntities())
            //{
            //    var Vitri = db.DM_Pile.ToList();
            //    DataTable dt = new DataTable();
            //    dt.Columns.Add("BinCode");
            //    dt = ConvertToDataTable(Vitri);
            //    cboVitri.uDataSource = dt;
            //}
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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Form_Load();
        }

        private void chk_All_EditValueChanged(object sender, EventArgs e)
        {
            if (chk_All.Checked == true)
            {
                for (int i = 0; i < gridView1.DataRowCount; i ++)
                {
                    gridView1.SetRowCellValue(i, "Chon", true);
                }
            }
            else
            {
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    gridView1.SetRowCellValue(i, "Chon", false);
                }
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
    }
}
