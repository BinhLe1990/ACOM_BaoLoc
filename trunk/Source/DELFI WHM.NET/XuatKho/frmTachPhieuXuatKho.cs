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
using DELFI_WHM.NET.DELFI_Class;
using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.XuatKho
{
    public partial class frmTachPhieuXuatKho : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        public static string Access_Connection = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Database.mdb";
        string _Loai = "";
        string _QuiCach = "";
        string _Lot = "";
        string _Cer = "NONE";
        string _Maphieu = "";
        string _MaSanPham = "";
        string _CropYear = "";
        string _Ghichu = "";
        string _MaPhieuMoi = "";
        string _Vitri = "RECEIVING";
        string _OldLot = "";
        string _OldBin = "RECEIVING";
        decimal _OldQRCodeQty = 0;
        decimal _NewQRCodeQty = 0;
        DateTime Ngay;
        int TrongLuongCan = 0;
        int _Ca;

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
                                Convert.ToInt32(gridView1.GetRowCellValue(i, "QRCodeQty")),
                                gridView1.GetRowCellValue(i, "PackageType"));
                }
            }

            BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\PhieuNhapTach.repx", dt);
            frm.Show();
        }

        private void btnInTem_Click(object sender, EventArgs e)
        {
            Intem();
        }

        public string Chungtu
        {
            get { return _Maphieu; }
            set { _Maphieu = value; }
        }       

        public DateTime NgayTao
        {
            get { return Ngay; }
            set { Ngay = value; }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void spnTLTrubi_uEditValueChanged(object sender, EventArgs e)
        {
            if (spnTLTrubi.uValue <0)
            {
                spnTLTrubi.uValue = 0;
                XtraMessageBox.Show("Trọng lượng trừ bì không thể âm", "Thông báo");
            }
        }

        public frmTachPhieuXuatKho(frmDS_TachPallet parent)
        {
            InitializeComponent();
        }

        private bool Check_Cond(string LoaiTach)
        {
            if (txtMaPallet.uText.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập Mã QR Code", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPallet.SelectAll();
                return false;
            }
            if (spnTLCan.uValue ==0 )
            {
                XtraMessageBox.Show("Chưa có trọng lượng cân", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false;
            }
            if (spnTLCan.uValue <=  spnTLTrubi.uValue)
            {
                XtraMessageBox.Show("Trọng lượng cân phải lớn hơn Trọng lượng trừ bì", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cnn.bComboIsNull(cboSanPham))
            {
                XtraMessageBox.Show("Bạn chưa chọn Sản phẩm", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSanPham.Select();
                return false;
            }
            if (cnn.bComboIsNull(cboQuicach))
            {
                XtraMessageBox.Show("Bạn chưa chọn Loại bao bì", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboQuicach.Focus();
                return false;
            }
            if (spnTruckQty.uValue == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập số bao của QRCode", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spnTruckQty.Focus();
                return false;
            }
            using (DBACOMEntities db = new DBACOMEntities())
            {               
                var sample = db.WH_TonKho.Where(c => c.QRCode == txtMaPallet.uText).ToList();
                if (sample.Count == 0)
                { 
                    XtraMessageBox.Show("Mã QR Code không hợp lệ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaPallet.SelectAll();
                    return false;
                }
                else if (sample[0].Sample.ToString() == "True")
                {
                    XtraMessageBox.Show("Hàng sample không thể xuất", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaPallet.SelectAll();
                    return false;
                }
                var Spe = db.WH_ChiTietNhapKho.Where(c => c.Document == txtMaPallet.uText && c.Type == "Separate").ToList();
                if (Spe.Count >0)
                {
                    XtraMessageBox.Show("Mã QR Code không hợp lệ, mỗi QRCode chỉ tách 1 lần", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaPallet.SelectAll();
                    return false;
                }
            }
            if (Convert.ToInt32(cnn.DT_DataTable("SELECT COUNT(QRCode) FROM WH_ChiTietNhapKho WHERE QRCode = '" + txtMaPallet.uText.Trim() + "' AND Del = 1").Rows[0][0]) > 0)
            {
                XtraMessageBox.Show("Mã QR Code này đã bị khóa", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPallet.SelectAll();
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
            if (LoaiTach == "CanCau")
            {
                var Thamso_CanCau = new Dictionary<String, String>() { { "QRCode", txtMaPallet.uText } };
                DataTable dt = new DataTable();
                dt = cnn.SQL_GetStoredProcedure("SP_TachCanCau", Thamso_CanCau);
                if (dt.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Mã QR Code không hợp lệ (Không có trong Danh sách xuất hàng Cân cầu)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaPallet.SelectAll();
                    return false;
                }
            }
            else if (LoaiTach == "SanXuat")
            {
                var Thamso_SX = new Dictionary<String, String>() { { "QRCode", txtMaPallet.uText } };
                DataTable dt = new DataTable();
                dt = cnn.SQL_GetStoredProcedure("SP_TachSX", Thamso_SX);
                if (dt.Rows.Count > 0)
                {
                    XtraMessageBox.Show("Mã QR Code không hợp lệ (Có trong Danh sách xuất hàng Cân cầu)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaPallet.SelectAll();
                    return false;
                }
            }

            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn Tách QRCode này cho Phiếu Cân Cầu?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (!Check_Cond("CanCau"))
                    return;
                using (DBACOMEntities db = new DBACOMEntities())
                {
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
                    if (!cnn.bComboIsNull(cboSanPham))
                    {
                        _MaSanPham = cboSanPham.uEditValue.ToString();
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
                    string[] c = txtMaPallet.uText.Split('.');
                    _Maphieu = txtMaPallet.uText;
                    _MaPhieuMoi = cnn.GetDateServer().ToString("yyyyMMddHHmmssffff");
                    var Old = db.WH_TonKho.Where(p => p.QRCode == _Maphieu).ToList();
                    _OldLot = Old[0].Lot;
                    _OldBin = Old[0].BinCode;
                    _OldQRCodeQty = Convert.ToDecimal(Old[0].QRCodeQty);

                    //Lưu danh sách nhập kho
                    //var NK = db.DM_PhieuNhap.Where(p => p.WeightNote == _Maphieu).FirstOrDefault();
                    //if (NK == null)
                    //{
                    //    db.DM_PhieuNhap.Add(new DM_PhieuNhap
                    //    {
                    //        PostingDate = Convert.ToDateTime(dtpNgaytao.uValue),
                    //        WeightNote = _Maphieu,
                    //        VendorCode = "",
                    //        VendorName = "",
                    //        Lot = _Lot,
                    //        BinCode = _Vitri,
                    //        ContractNo = "",
                    //        VehicleNo = "",
                    //        Type = "Separate",
                    //        UserName = Properties.Settings.Default.USER_NAME,
                    //        NetWeight = Math.Round((decimal)spnTLCan.uValue - spnTLTrubi.uValue, 2),
                    //        Del = false
                    //    });
                    //    db.SaveChanges();
                    //}

                    //Lưu danh mục nhập kho
                    {
                        var Thamso_DM = new Dictionary<String, String>() { { "PostingDate", Convert.ToDateTime(cnn.GetDateServer()).ToString("yyyy-MM-dd") },
                                                                    { "WeightNote", _Maphieu },
                                                                    { "VendorName", "" },
                                                                    { "VendorCode", "" },
                                                                    { "Lot", _Lot },
                                                                    { "BinCode", _Vitri },
                                                                    { "ContractNo", "" },
                                                                    { "VehicleNo", "" },
                                                                    { "UserName", Properties.Settings.Default.USER_NAME },
                                                                    { "Type", "Separate" },
                                                                    { "NetWeight", Math.Round((decimal)spnTLCan.uValue - spnTLTrubi.uValue, 2).ToString() }
                                                                   };
                        cnn.SQL_ExecuteStoredProcedure("SP_INSERT_DMPhieuNhap", Thamso_DM);
                    }

                    //Xác định Ca làm việc
                    _Ca = cnn.Shift();

                    var x = db.DM_PhieuNhap.Where(p => p.WeightNote == _Maphieu).ToArray();
                    int ID = Convert.ToInt32(x[0].ID);
                    { 

                        //Lưu chi tiết phiếu nhập
                        {
                            var Thamso_CT = new Dictionary<String, String>() {  {"Document", _Maphieu },
                                                                    {"Date", Convert.ToDateTime(cnn.GetDateServer()).ToString("yyyy-MM-dd") },
                                                                    {"QRCode", _MaPhieuMoi },
                                                                    {"ItemNo", _MaSanPham },
                                                                    {"Lot", _Lot },
                                                                    {"Certificate", _Cer },
                                                                    {"PackageType", _Loai },
                                                                    {"PackageCode", _QuiCach },
                                                                    {"GrossWeight", spnTLCan.uValue.ToString() },
                                                                    {"TruckQty", spnTruckQty.uValue.ToString() },
                                                                    {"PackageQty", "0" },
                                                                    {"TotalPackageQty", spnTLTrubi.uValue.ToString() },
                                                                    {"NetWeight", Math.Round((decimal)spnTLCan.uValue - spnTLTrubi.uValue, 2).ToString() },
                                                                    {"QRCodeQty", Math.Round((decimal)spnTLCan.uValue - spnTLTrubi.uValue, 2).ToString() },
                                                                    {"BinCode", _Vitri },
                                                                    {"Note", txtGhichu.uText },
                                                                    {"Sample", "0" },
                                                                    {"Type", "Separate" },
                                                                    {"IDPhieuNhap", ID.ToString() },
                                                                    {"UserName", Properties.Settings.Default.USER_NAME }};
                            cnn.SQL_ExecuteStoredProcedure("SP_INSERT_ChiTietPhieuNhap", Thamso_CT);
                        }

                        //Lưu tồn kho
                        {
                            var Thamso_TonKho = new Dictionary<String, String>() {  {"QRCode", _MaPhieuMoi},
                                                                        {"ItemNo", _MaSanPham},
                                                                        {"Lot", _Lot},
                                                                        {"Certificate", _Cer},
                                                                        {"PackageType", _Loai},
                                                                        {"PackageCode", _QuiCach},
                                                                        {"BinCode", _Vitri},
                                                                        {"CropYear", txtCrop.uText},
                                                                        {"Sample", "0"},
                                                                        {"QRCodeQty", Math.Round((decimal)spnTLCan.uValue - spnTLTrubi.uValue, 2).ToString()},
                                                                        {"Exported", "0"},
                                                                        {"TruckQty", Convert.ToInt32(spnTruckQty.uValue).ToString()}};
                            cnn.SQL_ExecuteStoredProcedure("SP_INSERT_TonKho", Thamso_TonKho);
                        }

                        //if (db.SaveChanges() > 0)
                        //{
                        //Lưu tồn kho
                        //db.WH_TonKho.Add(new WH_TonKho
                        //{
                        //    QRCode = _MaPhieuMoi,
                        //    ItemNo = _MaSanPham,
                        //    Lot = _Lot,
                        //    Certificate = _Cer,
                        //    PackageType = _Loai,
                        //    PackageCode = _QuiCach,
                        //    BinCode = _Vitri,
                        //    CropYear = txtCrop.uText,
                        //    Sample = false,
                        //    QRCodeQty = Math.Round((decimal)spnTLCan.uValue - spnTLTrubi.uValue, 2),
                        //    Exported = false,
                        //    TruckQty = Convert.ToInt32(spnTruckQty.uValue)
                        //});
                        //db.SaveChanges();


                        if (_OldQRCodeQty > 0)
                        {
                            _NewQRCodeQty = Math.Round((decimal)spnTLCan.uValue - spnTLTrubi.uValue, 2);

                            WH_TonKho sh = db.WH_TonKho.Where(q => q.QRCode == _Maphieu).FirstOrDefault();
                            if (sh.QRCodeQty - _NewQRCodeQty > 0)
                            {
                                sh.QRCodeQty = sh.QRCodeQty - _NewQRCodeQty;
                            }
                            else
                            {
                                sh.QRCodeQty = 0;
                            }
                            db.SaveChanges();
                        }

                        ////Tính tồn kho tức thời cho QRCode cũ
                        //{
                        //    var TonKho = new Dictionary<String, String>() { { "Lot", _OldLot }, { "BinCode", _OldBin }, { "Nhap", "0" }, { "Xuat", _NewQRCodeQty.ToString() } };
                        //    cnn.SQL_ExecuteStoredProcedure("SP_TonKhoTucThoi", TonKho);
                        //}

                        ////Tính tồn kho tức thời cho QRCode mới
                        //{
                        //    var TonKho = new Dictionary<String, String>() { { "Lot", _Lot }, { "BinCode", _Vitri }, { "Nhap", spnTLCan.uValue.ToString() }, { "Xuat", "0" } };
                        //    cnn.SQL_ExecuteStoredProcedure("SP_TonKhoTucThoi", TonKho);
                        //}

                        PhieuXuatKhac(true);

                        var Thamso = new Dictionary<String, String>() { { "Document", txtMaPallet.Text }, { "Loai", "Separate" } };
                        griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_ChitietNhapTuNCC", Thamso);

                        XtraMessageBox.Show("Cập nhật danh sách thành công");
                        //Tạo tem in                                       
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            if (gridView1.GetRowCellValue(i, "QRCode").ToString() == _MaPhieuMoi)
                                gridView1.SetRowCellValue(i, "Chon", true);
                        }
                        Intem();
                        //}
                    }
                }
            }
        }

        string _LocationCode, _LocationName;
        public void PhieuXuatKhac(bool XuatKho)
        {
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
                    QRCode = txtMaPallet.uText,
                    QRCodeQty = Math.Round((decimal)spnTLCan.uValue - spnTLTrubi.uValue, 2),
                    Lot = _Lot,
                    Certificate = _Cer,
                    BinCode = _Vitri,
                    PackageType = _Loai,
                    GrossWeight = spnTLCan.uValue,
                    TruckQty = 0,
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
                    LoaiXuat = "7",
                    UserName = Properties.Settings.Default.USER_NAME,
                    CreateDate = cnn.GetDateServer()
                });
                db.SaveChanges();
                if (XuatKho == true)
                {
                    cnn.ExecuteNonQuery("UPDATE WH_Tonkho Set Exported = 1 WHERE QRCode  = '" + txtMaPallet.uText + "'");
                }
            }
        }

        private void txtMaPallet_uKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Load_cboQuicach();
                Load_cboSanPham();
                Load_cboVitri();
                Load_Cer();
                Load_Lot();
                if (txtMaPallet.uText != "")
                {
                    _Maphieu = txtMaPallet.uText;

                    using (DBACOMEntities db = new DBACOMEntities())
                    {
                        //var qr = db.WH_TonKho.Where(p => p.QRCode == _Maphieu && p.Exported == false).ToList();
                        var qr = db.WH_TonKho.Where(p => p.QRCode == _Maphieu).ToList();
                        if (qr.Count > 0)
                        {
                            var q = db.WH_TonKho.Where(a => a.QRCode == _Maphieu).ToList();
                            if (q.Count > 0)
                            {
                                cboSanPham.uEditValue = q[0].ItemNo;
                                cboLot.uEditValue = q[0].Lot;
                                cboCer.uEditValue = q[0].Certificate;
                                cboLoai.uEditValue = q[0].PackageType;
                                cboQuicach.uEditValue = q[0].PackageCode;
                                cboVitri.uEditValue = q[0].BinCode;
                                dtpNgaytao.uValue = Convert.ToDateTime(cnn.GetDateServer()).ToString("dd/MM/yyyy HH:mm:ss");
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Mã QRCode không hợp lệ", "Thông báo");
                            cnn.clearControl(txtMaPallet);
                        }
                    }
                }
            }
        }

        private void frmTachPhieuXuatKho_Load(object sender, EventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {           
                {
                    if (Chungtu != null)
                    {
                        var Thamso = new Dictionary<String, String>() { { "Document", Chungtu } , { "Loai", "Separate" } };
                        griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_ChitietNhapTuNCC", Thamso);
                    }
                }
                foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
                {
                    if (col.FieldName != gridView1.Columns["Chon"].FieldName)
                        col.OptionsColumn.AllowEdit = false;
                }
            }
            timer1.Start();
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
                        txtCrop.uText = qc[0].CropYear;
                    }
                }
            }
            else
            {
                txtCrop.uText = "";
            }
        }

        private void frmTachPhieuXuatKho_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                btnLuu_Click(sender, e);
            }
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

        private void spnTruckQty_uValueChanged(object sender, EventArgs e)
        {
            if (spnTruckQty.uValue < 0)
            {
                spnTruckQty.uValue = 0;
                XtraMessageBox.Show("Số lượng bao không được âm", "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cnn.clearControl(groupControl1);
        }

        private void Load_cboSanPham()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var SP = db.tblItems.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ItemNo");
                dt.Columns.Add("ItemName");
                dt = cnn.ConvertToDataTable(SP);
                cboSanPham.uDataSource = dt;
            }
        }

        private void Load_cboQuicach()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                {
                    var qc = db.DM_Packing.ToList();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("PackageCode");
                    dt.Columns.Add("PackageDesc");
                    dt = cnn.ConvertToDataTable(qc);
                    cboQuicach.uDataSource = dt;
                }
                {
                    var Loai = db.DM_LoaiBao.ToList();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Loai");
                    dt = cnn.ConvertToDataTable(Loai);
                    cboLoai.uDataSource = dt;
                }
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

        private void Load_Lot()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Lot = db.DM_Lot.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Lot");
                dt.Columns.Add("Bag");
                dt.Columns.Add("CropYear");
                dt = cnn.ConvertToDataTable(Lot);
                cboLot.uDataSource = dt;
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

        private void cboSanPham_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboSanPham();
        }

        private void cboQuicach_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboQuicach();
        }

        private void cboVitri_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboVitri();
        }

        private void cboLot_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_Lot();
        }

        private void cboCer_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_Cer();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //int a = 0;
            //using (DBACOMEntities db = new DBACOMEntities())
            //{
            //    var list = db.tblConfigScale.Where(c => c.ID == 18).ToList();
            //    a = Convert.ToInt32(list[0].MaxSpeed);
            //}
            //spnTLCan.uEditValue = a;
            spnTLCan.uValue = frmMain.SoCanBan;
        }

        private void btnTachSX_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn Tách QRCode này cho Phiếu Sản Xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (!Check_Cond("SanXuat"))
                    return;
                using (DBACOMEntities db = new DBACOMEntities())
                {
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
                    if (!cnn.bComboIsNull(cboSanPham))
                    {
                        _MaSanPham = cboSanPham.uEditValue.ToString();
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
                    string[] c = txtMaPallet.uText.Split('.');
                    _Maphieu = txtMaPallet.uText;
                    _MaPhieuMoi = cnn.GetDateServer().ToString("yyyyMMddHHmmssffff");
                    var Old = db.WH_TonKho.Where(p => p.QRCode == _Maphieu).ToList();
                    _OldLot = Old[0].Lot;
                    _OldBin = Old[0].BinCode;
                    _OldQRCodeQty = Convert.ToDecimal(Old[0].QRCodeQty);

                    //Lưu danh sách nhập kho
                    //var NK = db.DM_PhieuNhap.Where(p => p.WeightNote == _Maphieu).FirstOrDefault();
                    //if (NK == null)
                    //{
                    //    db.DM_PhieuNhap.Add(new DM_PhieuNhap
                    //    {
                    //        PostingDate = Convert.ToDateTime(dtpNgaytao.uValue),
                    //        WeightNote = _Maphieu,
                    //        VendorCode = "",
                    //        VendorName = "",
                    //        Lot = _Lot,
                    //        BinCode = _Vitri,
                    //        ContractNo = "",
                    //        VehicleNo = "SANXUAT",
                    //        Type = "Separate",
                    //        UserName = Properties.Settings.Default.USER_NAME,
                    //        NetWeight = Math.Round((decimal)spnTLCan.uValue - spnTLTrubi.uValue, 2),
                    //        Del = false
                    //    });
                    //    db.SaveChanges();
                    //}

                    {
                        var Thamso_DM = new Dictionary<String, String>() { { "PostingDate", Convert.ToDateTime(cnn.GetDateServer()).ToString("yyyy-MM-dd") },
                                                                    { "WeightNote", _Maphieu },
                                                                    { "VendorName", "" },
                                                                    { "VendorCode", "" },
                                                                    { "Lot", _Lot },
                                                                    { "BinCode", _Vitri },
                                                                    { "ContractNo", "" },
                                                                    { "VehicleNo", "SANXUAT" },
                                                                    { "UserName", Properties.Settings.Default.USER_NAME },
                                                                    { "Type", "Separate" },
                                                                    { "NetWeight", Math.Round((decimal)spnTLCan.uValue - spnTLTrubi.uValue, 2).ToString() }
                                                                   };
                        cnn.SQL_ExecuteStoredProcedure("SP_INSERT_DMPhieuNhap", Thamso_DM);
                    }

                    //Xác định Ca làm việc
                    _Ca = cnn.Shift();

                    var x = db.DM_PhieuNhap.Where(p => p.WeightNote == _Maphieu).ToArray();
                    int ID = Convert.ToInt32(x[0].ID);
                    {
                        ////Lưu chi tiết nhập kho
                        //db.WH_ChiTietNhapKho.Add(new WH_ChiTietNhapKho
                        //{
                        //    Document = _Maphieu,
                        //    Date = Convert.ToDateTime(dtpNgaytao.uValue),
                        //    QRCode = _MaPhieuMoi,
                        //    ItemNo = _MaSanPham,
                        //    Lot = _Lot,
                        //    Certificate = _Cer,
                        //    PackageType = _Loai,
                        //    PackageCode = _QuiCach,
                        //    GrossWeight = spnTLCan.uValue,
                        //    TruckQty = spnTruckQty.uValue,
                        //    PackageQty = 0,
                        //    TotalPackageQty = spnTLTrubi.uValue,
                        //    NetWeight = Math.Round((decimal)spnTLCan.uValue - spnTLTrubi.uValue, 2),
                        //    QRCodeQty = Math.Round((decimal)spnTLCan.uValue - spnTLTrubi.uValue, 2),
                        //    BinCode = _Vitri,
                        //    Note = txtGhichu.uText,
                        //    Sample = false,
                        //    Type = "Separate",
                        //    IDPhieuNhap = ID,
                        //    Thoigian = DateTime.Now.TimeOfDay,
                        //    Ca = _Ca,
                        //    Del = false,
                        //    CreateDate = DateTime.Now
                        //});

                        //Lưu chi tiết phiếu nhập
                        {
                            var Thamso_CT = new Dictionary<String, String>() {  {"Document", _Maphieu },
                                                                    {"Date", Convert.ToDateTime(cnn.GetDateServer()).ToString("yyyy-MM-dd") },
                                                                    {"QRCode", _MaPhieuMoi },
                                                                    {"ItemNo", _MaSanPham },
                                                                    {"Lot", _Lot },
                                                                    {"Certificate", _Cer },
                                                                    {"PackageType", _Loai },
                                                                    {"PackageCode", _QuiCach },
                                                                    {"GrossWeight", spnTLCan.uValue.ToString() },
                                                                    {"TruckQty", spnTruckQty.uValue.ToString() },
                                                                    {"PackageQty", "0" },
                                                                    {"TotalPackageQty", spnTLTrubi.uValue.ToString() },
                                                                    {"NetWeight", Math.Round((decimal)spnTLCan.uValue - spnTLTrubi.uValue, 2).ToString() },
                                                                    {"QRCodeQty", Math.Round((decimal)spnTLCan.uValue - spnTLTrubi.uValue, 2).ToString() },
                                                                    {"BinCode", _Vitri },
                                                                    {"Note", txtGhichu.uText },
                                                                    {"Sample", "0" },
                                                                    {"Type", "Separate" },
                                                                    {"IDPhieuNhap", ID.ToString() },
                                                                    {"UserName", Properties.Settings.Default.USER_NAME }};
                            cnn.SQL_ExecuteStoredProcedure("SP_INSERT_ChiTietPhieuNhap", Thamso_CT);
                        }

                        //Lưu tồn kho
                        {
                            var Thamso_TonKho = new Dictionary<String, String>() {  {"QRCode", _MaPhieuMoi},
                                                                        {"ItemNo", _MaSanPham},
                                                                        {"Lot", _Lot},
                                                                        {"Certificate", _Cer},
                                                                        {"PackageType", _Loai},
                                                                        {"PackageCode", _QuiCach},
                                                                        {"BinCode", _Vitri},
                                                                        {"CropYear", txtCrop.uText},
                                                                        {"Sample", "0"},
                                                                        {"QRCodeQty", Math.Round((decimal)spnTLCan.uValue - spnTLTrubi.uValue, 2).ToString()},
                                                                        {"Exported", "0"},
                                                                        {"TruckQty", Convert.ToInt32(spnTruckQty.uValue).ToString()}};
                            cnn.SQL_ExecuteStoredProcedure("SP_INSERT_TonKho", Thamso_TonKho);
                        }

                        //if (db.SaveChanges() > 0)
                        //{
                        //Lưu tồn kho
                        //db.WH_TonKho.Add(new WH_TonKho
                        //    {
                        //        QRCode = _MaPhieuMoi,
                        //        ItemNo = _MaSanPham,
                        //        Lot = _Lot,
                        //        Certificate = _Cer,
                        //        PackageType = _Loai,
                        //        PackageCode = _QuiCach,
                        //        BinCode = _Vitri,
                        //        CropYear = txtCrop.uText,
                        //        Sample = false,
                        //        QRCodeQty = Math.Round((decimal)spnTLCan.uValue - spnTLTrubi.uValue, 2),
                        //        Exported = false,
                        //        TruckQty = Convert.ToInt32(spnTruckQty.uValue)
                        //    });
                        //    db.SaveChanges();


                        if (_OldQRCodeQty > 0)
                        {
                            _NewQRCodeQty = Math.Round((decimal)spnTLCan.uValue - spnTLTrubi.uValue, 2);

                            WH_TonKho sh = db.WH_TonKho.Where(q => q.QRCode == _Maphieu).FirstOrDefault();
                            if (sh.QRCodeQty - _NewQRCodeQty > 0)
                            {
                                sh.QRCodeQty = sh.QRCodeQty - _NewQRCodeQty;
                            }
                            else
                            {
                                sh.QRCodeQty = 0;
                            }
                            db.SaveChanges();
                        }

                        PhieuXuatKhac(false);

                        var Thamso = new Dictionary<String, String>() { { "Document", txtMaPallet.Text }, { "Loai", "Separate" } };
                        griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_ChitietNhapTuNCC", Thamso);

                        XtraMessageBox.Show("Cập nhật danh sách thành công");
                        //Tạo tem in cho QRCode mới                                   
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            if (gridView1.GetRowCellValue(i, "QRCode").ToString() == _MaPhieuMoi)
                                gridView1.SetRowCellValue(i, "Chon", true);
                        }
                        Intem();
                        //}
                    }
                }
            }
        }

        private void gridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView1.OptionsSelection.MultiSelect = true;
                gridView1.SelectAll();
            }
        }
    }
}
