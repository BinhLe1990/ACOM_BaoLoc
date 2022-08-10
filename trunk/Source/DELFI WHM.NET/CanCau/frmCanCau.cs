using DELFI_WHM.NET.DELFI_Class;
using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;
using DevExpress.XtraExport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.Objects;
using System.Threading;
using System.Data.OleDb;
using DevExpress.Utils;
using DevExpress.XtraGrid;

namespace DELFI_WHM.NET.CanCau
{
    public partial class frmCanCau : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        public static string Access_Connection = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Database.mdb";
        clsRun clRun = new clsRun();
        int TrongLuongCan = 0;
        string Footer = "";
        string Footer2 = "";
        public frmCanCau()
        {
            clRun.SetPermit(this);
            InitializeComponent();
            clRun.SetValueToControl(this);
        }

        #region Giả lập

        public static DataTable Getdata_Access(string sql)
        {
            OleDbConnection cnn = new OleDbConnection(Access_Connection);
            cnn.Close();
            cnn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static bool Excute_Access(string sql)
        {
            OleDbConnection cnn = new OleDbConnection(Access_Connection);
            cnn.Close();
            cnn.Open();
            OleDbCommand command = new OleDbCommand(sql, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random RAN = new Random();
            try
            {
                if (cboWeightType.uEditValue.ToString() == "Purchase" || cboWeightType.uEditValue.ToString() == "Receive")
                {
                    if (chkNhanDuLieu.Checked == false)
                    {
                        int a = RAN.Next(50000, 60000);
                        spnFirstWeight.Value = a;
                        spnSecondWeight.Value = 0;
                    }
                    else
                    {
                        int a = RAN.Next(1000, 1500);
                        spnSecondWeight.Value = a;
                    }
                }
                if (cboWeightType.uEditValue.ToString() == "Ship" || cboWeightType.uEditValue.ToString() == "Sale")
                {
                    if (chkNhanDuLieu.Checked == false)
                    {
                        int a = RAN.Next(1000, 1500);
                        spnFirstWeight.Value = a;
                        spnSecondWeight.Value = 0;
                    }
                    else
                    {
                        int a = RAN.Next(50000, 60000);
                        spnSecondWeight.Value = a;
                    }
                }
            }
            catch { };
        }


        #endregion Giả lập

        string _ChungTu = "";
        string _MaNhaVanChuyen = "";
        string _ItemCode = "";
        string _VendorCode = "";
        string _LocationCode = "";
        string _LocationName = "";
        string TenCty = "";
        string Diachi = "";
        string SDT = "";
        string _Lot = "";
        string _Bincode = "RECEIVING";
        string _Loai = "";
        string _Quicach = "";
        DateTime? _NgayRa = null;
        string _ArrayQRCode = "";
        string PrinterName = "";
        string Sophieucan = "";
        decimal _TLHang = 0;
        decimal SoCanLan2 = 0;

        #region Thanh tác vụ        

        private void Location_Code()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                DM_Location lc = db.DM_Location.Where(c => c.Status == true).FirstOrDefault();
                _LocationCode = lc.Code;
                _LocationName = lc.LocationName;
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            clRun.SetValueToControl(this);
            spnID.uValue = 0;
            spnFirstWeight.Value = 0;
            spnSecondWeight.Value = 0;
            cnn.clearControl(groupBox1);
            NgayTaoPhieu();
            LoadForm();
            Location_Code();
            cboWeightType.bIsReadOnly = false;
            cboItemCode.bIsReadOnly = false;
            spnTruckQty.bIsReadOnly = false;
            spnPackageQty.bIsReadOnly = false;
            txtVehicleNo.bIsReadOnly = false;
            groupBox1.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnIntem.Enabled = false;
            btnInPhieu.Enabled = false;
            btnSave.Enabled = true;
            btnHuy.Enabled = true;
            groupBox1.Focus();
            numericUpDown1.Value = 0;
            chkNhanDuLieu.Checked = false;
        }

        private bool Check_Cond()
        {
            if (spnFirstWeight.Value == 0)
            {
                XtraMessageBox.Show("Bạn chưa có số cân lần 1", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cnn.bComboIsNull(cboWeightType))
            {
                XtraMessageBox.Show("Bạn chưa chọn kiểu cân", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtVehicleNo.uText.Trim() == "")
            {
                XtraMessageBox.Show("Số xe không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cnn.bComboIsNull(cboTransporterCode))
            {
                XtraMessageBox.Show("Nhà vận chuyển không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cnn.bComboIsNull(cboItemCode))
            {
                XtraMessageBox.Show("Mã sản phẩm không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cnn.bComboIsNull(cboVendorCode))
            {
                XtraMessageBox.Show("Khách hàng không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (spnSecondWeight.Value > 0)
                {
                    var l = db.DM_PhieuCanCau.Where(c => c.WeightNote == txtWeightNote.uText && (c.WeightType == "Sale" || c.WeightType == "Ship")).ToList();
                    if (l.Count > 0)
                    {
                        Sophieucan = txtWeightNote.uText;
                        _ChungTu = cboContractNo.uEditValue.ToString();
                        var Sh = db.ChiTietSoanHang.Where(c => c.WeightNote == Sophieucan).ToList();
                        if (Sh.Count == 0 || Sh == null)
                        {                            
                            XtraMessageBox.Show("Không thể lưu, chưa phát sinh chi tiết soạn hàng", "Thông báo");
                            return false;
                        }
                        else
                        {
                            var list = db.ChiTietSoanHang.Where(c => c.WeightNote == Sophieucan && c.DocumentNo == _ChungTu).ToList();
                            if (list.Count == 0)
                            {
                                XtraMessageBox.Show("Số Lệnh giao hàng không đúng", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        private bool Check_Canlan2()
        {
            if (cnn.bComboIsNull(cboItemCode) || cboItemCode.uEditValue.ToString().ToLower() == " chuaxacdinh")
            {
                XtraMessageBox.Show("Mã sản phẩm không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cnn.bComboIsNull(cboLot) && (cboWeightType.uEditValue.ToString() == "Purchase" || cboWeightType.uEditValue.ToString() == "Receive"))
            {
                XtraMessageBox.Show("Bạn chưa chọn Lot", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLot.Focus();
                return false;
            }
            return true;
        }


        private void Check()
        {
            if (dtpDateOut.Text.Trim() != "")
            {
                _NgayRa = Convert.ToDateTime(dtpDateOut.EditValue);
            }
            if (!cnn.bComboIsNull(cboContractNo))
            {
                _ChungTu = cboContractNo.uEditValue.ToString();
            }
            else
            {
                _ChungTu = "";
            }
            if (!cnn.bComboIsNull(cboTransporterCode))
            {
                _MaNhaVanChuyen = cboTransporterCode.uEditValue.ToString();
            }            
            if (!cnn.bComboIsNull(cboItemCode))
            {
                _ItemCode = cboItemCode.uEditValue.ToString();
            }
            if (!cnn.bComboIsNull(cboVendorCode))
            {
                _VendorCode = cboVendorCode.uEditValue.ToString();
            }
            if (!cnn.bComboIsNull(cboLocationCode))
            {
                _LocationCode = cboLocationCode.uEditValue.ToString();
            }
            if (!cnn.bComboIsNull(cboLot))
            {
                _Lot = cboLot.uEditValue.ToString();
            }
            else
            {
                _Lot = "";
            }
        } 

        private void Luu()
        {
            if (!Check_Cond())
                return;
            if (!cnn.bComboIsNull(cboWeightType))
            {
                Check();
                Location_Code();
                string[] code = txtWeightNote.uText.Split('-');
                
                //Lấy số tiếp theo của WeightNote trong tháng
                    int data = 0;
                    data = Convert.ToInt32(cnn.SQL_GetStoredProcedure("SP_Create_WeightNote").Rows[0][0]);                    
                    txtWeightNote.uText = _LocationCode + "-" + Convert.ToDateTime(dtpCreateDate.uValue).ToString("yyMM") + "-" + data.ToString("00000");
                
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    var query = (from s in db.DM_PhieuCanCau
                                 where s.WeightNote == txtWeightNote.Text
                                 select s).FirstOrDefault<DM_PhieuCanCau>();
                    if (query == null)
                    {
                        db.DM_PhieuCanCau.Add(new DM_PhieuCanCau
                        {
                            LocationName = txtLocationName.uText,
                            WeightNote = txtWeightNote.uText,
                            CreateDate = Convert.ToDateTime(dtpCreateDate.uValue),
                            VehicleNo = txtVehicleNo.uText,
                            WeightType = cboWeightType.uEditValue.ToString(),
                            ContractNo = _ChungTu,
                            TransporterCode = _MaNhaVanChuyen,
                            ItemCode = _ItemCode,
                            VendorCode = _VendorCode,
                            VendorName = txtTenKhachHang.EditValue.ToString(),
                            LocationCode = _LocationCode,
                            DateIn = Convert.ToDateTime(dtpDateIn.EditValue),
                            //DateOut = _NgayRa,
                            FirstWeight = spnFirstWeight.Value,
                            SecondWeight = spnSecondWeight.Value,
                            GrossWeight = spnGrossWeight.uValue,
                            TruckTare = spnTruckTare.uValue,
                            TruckQty = spnTruckQty.uValue,
                            PackageQty = spnPackageQty.uValue,
                            TotalPackageQty = spnTongTLBao.uValue,
                            NetWeight = spnTLSauTruBi.uValue,
                            Note = txtNote.Text,
                            ExportNav = false,
                            Del = false,
                            UserName = Properties.Settings.Default.USER_NAME,
                            PackageType = "",
                            Lot = _Lot,
                            BinCode = "",
                            Certificate = "NONE",
                            PackageCode = "",
                            ArrayQRCode = ""
                        });
                        db.SaveChanges();

                        MemoryStream ms = new MemoryStream();
                        Byte[] bytBLOBData = new Byte[ms.Length];
                        ms.Position = 0;
                        ms.Read(bytBLOBData, 0, Convert.ToInt32(ms.Length));
                        db.IMG_PhieuCanCau.Add(new IMG_PhieuCanCau
                        {
                            WeightNote = txtWeightNote.uText,
                            IMG1 = converImgToByte(Picture_Cam(panel1)),
                            IMG2 = converImgToByte(Picture_Cam(panel2))
                        });
                        db.SaveChanges();
                        LoadForm();
                        Khoa_Button();

                        var Thamso = new Dictionary<String, String>() { { "WeightNote", txtWeightNote.uText }};
                        spnID.uValue = Convert.ToInt32(cnn.SQL_GetStoredProcedure("SP_Call_WeightNote", Thamso).Rows[0][0]);

                        Intem(Convert.ToInt32(spnID.uValue));
                        spnID.uValue = 0;
                        spnFirstWeight.Value = 0;
                        spnSecondWeight.Value = 0;
                        cnn.clearControl(groupBox1);
                        groupBox1.Enabled = false;
                        dtpDateIn.Text = "";
                        dtpDateOut.Text = "";
                        clRun.SetPermit(this);
                        XtraMessageBox.Show("Thêm phiếu cân thành công");
                    }
                }
            }
        }


        private void History()
        {
            string chuoi = "";
            Check();
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var pc = db.DM_PhieuCanCau.Where(c => c.ID == spnID.uValue).ToArray().FirstOrDefault();
                if (pc != null)
                {
                    if (pc.VehicleNo != txtVehicleNo.uText)
                    {
                        chuoi += "Sửa số xe " + pc.VehicleNo + " thành " + txtVehicleNo.uText + "\n";
                    }
                    if (pc.WeightType != cboWeightType.uEditValue.ToString())
                    {
                        chuoi += " Sửa trạng thái " + pc.WeightType + " thành " + cboWeightType.uEditValue + "\n";
                    }
                    if (pc.ContractNo != _ChungTu)
                    {
                        chuoi += " Sửa hợp đồng/chỉ thị " + pc.ContractNo + " thành " + _ChungTu + "\n";
                    }
                    if (pc.TransporterCode != _MaNhaVanChuyen)
                    {
                        chuoi += " Sửa nhà vận chuyển " + pc.TransporterCode + " thành " + _MaNhaVanChuyen + "\n";
                    }
                    if (pc.ItemCode != _ItemCode)
                    {
                        chuoi += " Sửa sản phẩm " + pc.ItemCode + " thành " + _ItemCode + "\n";
                    }
                    if (pc.Lot != _Lot)
                    {
                        chuoi += " Sửa Lot " + pc.Lot + " thành " + _Lot + "\n";
                    }
                    if (pc.VendorCode != _VendorCode)
                    {
                        chuoi += " Sửa Khách hàng " + pc.VendorCode + " thành " + _VendorCode + "\n";
                    }
                    if (pc.LocationCode != _LocationCode)
                    {
                        chuoi += " Sửa Location " + pc.LocationCode + " thành " + _LocationCode + "\n";
                    }
                    if (pc.Note != txtNote.uText)
                    {
                        chuoi += " Sửa Ghi chú " + pc.Note + " thành " + txtNote.uText + "\n";
                    }
                }
                if (chuoi != "")
                {
                    db.HIS_Phieucancau.Add(new HIS_Phieucancau
                    {
                        ID_WeightNote = Convert.ToInt32(spnID.uValue),
                        Dateupdate = cnn.GetDateServer(),
                        UserName = Properties.Settings.Default.USER_NAME,
                        Desc = chuoi.TrimStart().TrimEnd(),
                        Loai = "PhieuCanCau"
                    });
                    db.SaveChanges();
                }
            }
        }

        //Tạo phiếu xuất
        private void TaoPhieuXuat()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Sh = db.ChiTietSoanHang.Where(c => c.WeightNote == txtWeightNote.uText).ToList();
                if (Sh.Count > 0)
                {
                    var Taophieuxuat = new Dictionary<String, String>() { { "WeightNote", txtWeightNote.uText }, { "DocumentNo", _ChungTu }, {"UserName", Properties.Settings.Default.USER_NAME } };
                    cnn.SQL_ExecuteStoredProcedure("SP_InsertChiTietXuatKho", Taophieuxuat);
                    var XK = db.WH_ChiTietXuatKho.Where(c => c.WeightNote == txtWeightNote.uText && c.DocumentNo == _ChungTu).ToList();
                    if (XK.Count > 0)
                    {
                        _Lot = XK[0].Lot;
                        _Bincode = XK[0].BinCode;
                    }
                    //Tính tồn kho tức thời
                    //{
                    //    var Thamso = new Dictionary<String, String>() { { "Lot", _Lot }, { "BinCode", _Bincode }, { "Nhap", "0" }, { "Xuat", spnTLSauTruBi.uValue.ToString() } };
                    //    cnn.SQL_ExecuteStoredProcedure("SP_TonKhoTucThoi", Thamso);
                    //}
                }
                else
                {
                    var Taophieuxuat = new Dictionary<String, String>() { { "WeightNote", txtWeightNote.uText }, { "DocumentNo", _ChungTu }, { "UserName", Properties.Settings.Default.USER_NAME } };
                    cnn.SQL_ExecuteStoredProcedure("SP_InsertChiTietXuatKho", Taophieuxuat);
                    var XK = db.WH_ChiTietXuatKho.Where(c => c.WeightNote == txtWeightNote.uText && c.DocumentNo == _ChungTu).ToList();
                    if (XK.Count > 0)
                    {
                        _Lot = XK[0].Lot;
                        _Bincode = XK[0].BinCode;
                    }
                }
            }
        }

        //Tạo phiếu nhập từ NCC
        private void TaoPhieuNhap_NCC()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                //Tạo danh sách nhập kho
                {
                    var Thamso = new Dictionary<String, String>() { { "WeightNote", txtWeightNote.uText }, { "User", Properties.Settings.Default.USER_NAME } };
                    cnn.SQL_ExecuteStoredProcedure("SP_Create_DM_NhapKho", Thamso);
                }
                //Tạo chi tiết nhập kho
                {
                    var ArrayQRCode = db.DM_PhieuCanCau.Where(c => c.WeightNote == txtWeightNote.uText).Select(p => p.ArrayQRCode).ToArray();
                    string[] chuoi = ArrayQRCode[0].Split(',');
                    foreach (string QRCode in chuoi)
                    {
                        var Thamso = new Dictionary<String, String>() { { "WeightNote", txtWeightNote.uText }, { "QRCode", QRCode }, { "UserName", Properties.Settings.Default.USER_NAME } };
                        cnn.SQL_ExecuteStoredProcedure("SP_Create_Chitiet_NhapKho", Thamso);
                    }
                }
                ////Tính tồn kho tức thời
                //{
                //    var Thamso = new Dictionary<String, String>() { { "Lot", _Lot }, { "BinCode", _Bincode }, { "Nhap", spnTLSauTruBi.uValue.ToString() }, { "Xuat", "0" } };
                //    cnn.SQL_ExecuteStoredProcedure("SP_TonKhoTucThoi", Thamso);
                //}
            }
        }

        //Tạo phiếu nhập thẳng vào Sản Xuất
        private void TaoPhieuNhap_SX()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                string QRCode = Convert.ToDateTime(dtpCreateDate.uValue).ToString("yyyyMMddHHmmss") + "0001";
                DM_PhieuCanCau lc2 = db.DM_PhieuCanCau.Where(c => c.ID == spnID.uValue).FirstOrDefault();
                lc2.ArrayQRCode = QRCode;
                lc2.BinCode = "SANXUAT";
                db.SaveChanges();
                //Tạo danh sách nhập kho
                {
                    var Thamso = new Dictionary<String, String>() { { "WeightNote", txtWeightNote.uText }, { "User", Properties.Settings.Default.USER_NAME } };
                    cnn.SQL_ExecuteStoredProcedure("SP_Create_DM_NhapKho", Thamso);
                }
                //Tạo chi tiết nhập kho
                {
                    var Thamso = new Dictionary<String, String>() { { "WeightNote", txtWeightNote.uText }, { "QRCode", QRCode }, { "UserName", Properties.Settings.Default.USER_NAME } };
                    cnn.SQL_ExecuteStoredProcedure("SP_Create_Chitiet_NhapKho", Thamso);
                }

                cnn.ExecuteNonQuery("UPDATE DM_PhieuNhap SET NhapTrucTiep = 1 WHERE WeightNote = '" + txtWeightNote.uText + "'");

                //Tạo chi tiết soạn hàng
                {
                    db.ChiTietSoanHang.Add(new ChiTietSoanHang
                    {
                        QRCode = QRCode,
                        ItemCode = _ItemCode,
                        Datetime = Convert.ToDateTime(dtpCreateDate.uValue),
                        WeightNote = txtWeightNote.uText,
                        DocumentNo = _ChungTu,
                        UserName = Properties.Settings.Default.USER_NAME
                    });
                    db.SaveChanges();
                }
                //Tạo danh mục, chi tiết xuất kho
                {
                    var Taophieuxuat = new Dictionary<String, String>() { { "WeightNote", txtWeightNote.uText }, { "DocumentNo", _ChungTu }, { "UserName", Properties.Settings.Default.USER_NAME } };
                    cnn.SQL_ExecuteStoredProcedure("SP_InsertChiTietXuatKho", Taophieuxuat);
                }
                //Tính tồn kho tức thời
                //{
                //    var Thamso = new Dictionary<String, String>() { { "Lot", "" }, { "BinCode", "SANXUAT" }, { "Nhap", "0" }, { "Xuat", "0" } };
                //    cnn.SQL_ExecuteStoredProcedure("SP_TonKhoTucThoi", Thamso);
                //}
            }
        }

        //Update thông tin cân lần 1: trong trường hợp chưa có số cân lần 2, chưa tạo phiếu Nhập, Xuất
        private void Update_Lan1()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Lot = db.DM_PhieuCanCau.Where(c => c.ID == spnID.uValue).First();                
                _Bincode = cnn.sNull2String(Lot.BinCode);
                _ArrayQRCode = Lot.ArrayQRCode;
                _Loai = Lot.PackageType;
                _Quicach = Lot.PackageCode;

                if ((_ArrayQRCode.Length > 0 && (cboWeightType.uEditValue.ToString() == "Purchase" || cboWeightType.uEditValue.ToString() == "Receive")) || (cboWeightType.uEditValue.ToString() == "Ship" || cboWeightType.uEditValue.ToString() == "Sale"))
                {
                    //Update thông tin cân lần 2 cho Phiếu cân cầu
                    DM_PhieuCanCau lc = db.DM_PhieuCanCau.Where(c => c.ID == spnID.uValue).FirstOrDefault();
                    lc.VehicleNo = txtVehicleNo.uText;
                    lc.WeightType = cboWeightType.uEditValue.ToString();
                    lc.ContractNo = _ChungTu;
                    lc.TransporterCode = _MaNhaVanChuyen;
                    lc.ItemCode = _ItemCode;
                    lc.VendorCode = _VendorCode;
                    lc.VendorName = txtTenKhachHang.EditValue.ToString();
                    lc.LocationCode = _LocationCode;
                    lc.LocationName = txtLocationName.uText;
                    lc.DateIn = Convert.ToDateTime(dtpDateIn.EditValue);
                    lc.DateOut = Convert.ToDateTime(dtpDateOut.EditValue);
                    lc.FirstWeight = spnFirstWeight.Value;
                    lc.SecondWeight = spnSecondWeight.Value;
                    lc.GrossWeight = spnGrossWeight.uValue;
                    lc.TruckTare = spnTruckTare.uValue;
                    lc.TruckQty = spnTruckQty.uValue;
                    lc.PackageQty = spnPackageQty.uValue;
                    lc.TotalPackageQty = spnTongTLBao.uValue;
                    lc.NetWeight = spnTLSauTruBi.uValue;
                    lc.Note = txtNote.Text;
                    lc.Lot = cboLot.uEditValue.ToString();
                    lc.UserName2 = Properties.Settings.Default.USER_NAME;
                    //Cập nhật lại PackageType trong DM_PhieuCanCau dựa vào PackageCode
                    if (_Loai.Length == 0 && _Quicach.Length > 0)
                    {
                        var Loai = db.DM_Packing.Where(c => c.PackageCode == _Quicach).ToList();
                        if (Loai.Count > 0)
                        {
                            lc.PackageType = Loai[0].PackageType;
                        }
                        else
                        {
                            lc.PackageType = "";
                        }

                    }
                    if (db.SaveChanges() > 0)
                    {
                        //Nếu trạng thái phiếu cân là Ship hoặc Sale thì tạo ra phiếu xuất
                        if (cboWeightType.uEditValue.ToString() == "Ship" || cboWeightType.uEditValue.ToString() == "Sale")
                        {
                            TaoPhieuXuat();
                        }

                        //Nếu trạng thái phiếu cân là Purchase hoặc Receive thì tạo ra phiếu Nhập
                        if (cboWeightType.uEditValue.ToString() == "Purchase" || cboWeightType.uEditValue.ToString() == "Receive")
                        {
                            string pc = txtWeightNote.uText;

                            //Kiểm tra xem Phiếu cân này có phải nhập thẳng vào sản xuất hay không
                            var list = db.DM_PhieuCanCau.Where(c => c.WeightNote == pc && c.ArrayQRCode != "PROCESS").ToList();

                            //Nếu không đúng thì tạo phiếu nhập từ NCC
                            if (list.Count > 0)
                            {
                                TaoPhieuNhap_NCC();
                            }

                            //Nếu đúng thì tạo phiếu nhập thẳng SX
                            else
                            {
                                TaoPhieuNhap_SX();
                            }
                        }

                        if (spnSecondWeight.Value > 0)
                        {
                            string pc = txtWeightNote.uText;
                            IMG_PhieuCanCau img = db.IMG_PhieuCanCau.Where(c => c.WeightNote == pc).FirstOrDefault();
                            img.IMG3 = converImgToByte(Picture_Cam(panel1));
                            img.IMG4 = converImgToByte(Picture_Cam(panel2));
                            db.SaveChanges();
                        }

                        LoadForm();
                        Khoa_Button();
                        spnID.uValue = 0;
                        spnFirstWeight.Value = 0;
                        spnSecondWeight.Value = 0;
                        cnn.clearControl(groupBox1);
                        groupBox1.Enabled = false;
                        dtpDateIn.Text = "";
                        dtpDateOut.Text = "";
                        clRun.SetPermit(this);
                        XtraMessageBox.Show("Cập nhật thông tin thành công");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Chưa phát sinh QRCode cho phiếu cân này", "Thông báo");
                }
            }
        }

        //Update thông tin cân lần 2: trong trường hợp đã có số cân lần 2, đã tạo phiếu Nhập, Xuất
        private void Update_Lan2()
        {
            var Thamso = new Dictionary<String, String>() {{ "LocationName", txtLocationName.uText },
                                                           { "WeightNote", txtWeightNote.uText },
                                                           { "VehicleNo", txtVehicleNo.uText },
                                                           { "WeightType", cboWeightType.uEditValue.ToString() },
                                                           { "ContractNo", _ChungTu },
                                                           { "TransporterCode", _MaNhaVanChuyen },
                                                           { "ItemCode", _ItemCode },
                                                           { "VendorCode", _VendorCode },
                                                           { "VendorName", txtTenKhachHang.Text },
                                                           { "LocationCode", _LocationCode },
                                                           { "FirstWeight", spnFirstWeight.Value.ToString() },
                                                           { "SecondWeight", spnSecondWeight.Value.ToString() },
                                                           { "GrossWeight", spnGrossWeight.uValue.ToString() },
                                                           { "TruckTare", spnTruckTare.uValue.ToString() },
                                                           { "TruckQty", spnTruckQty.uValue.ToString() },
                                                           { "PackageQty", spnPackageQty.uValue.ToString() },
                                                           { "TotalPackageQty", spnTongTLBao.uValue.ToString() },
                                                           { "Note", txtNote.uText },
                                                           { "Lot",  cboLot.uEditValue.ToString()},
                                                           { "UserName", Properties.Settings.Default.USER_NAME }};

            cnn.SQL_ExecuteStoredProcedure("SP_Update_PCC_Nhap", Thamso);
                    LoadForm();
                    Khoa_Button();
                    spnID.uValue = 0;
                    spnFirstWeight.Value = 0;
                    spnSecondWeight.Value = 0;
                    cnn.clearControl(groupBox1);
                    groupBox1.Enabled = false;
                    dtpDateIn.Text = "";
                    dtpDateOut.Text = "";
                    clRun.SetPermit(this);
                    XtraMessageBox.Show("Cập nhật thông tin thành công");           
        }

        public bool Update_TrangThai()
        {
            if (spnSecondWeight.Value == 0)
            {
                var Thamso = new Dictionary<String, String>() { { "WeightNote", txtWeightNote.uText } };
                DataTable dt = new DataTable();
                dt = cnn.SQL_GetStoredProcedure("SP_Update_PCC_TrangThai", Thamso);

                DataTable dt2 = cnn.DT_DataTable("SELECT WeightType FROM DM_PhieuCanCau WHERE WeightNote = '" + txtWeightNote.uText + "'");

                if (dt.Rows.Count > 0 && dt2.Rows[0]["WeightType"].ToString() != cnn.sNull2String(cboWeightType.uEditValue).ToString())
                {
                    XtraMessageBox.Show("Đã phát sinh dữ liệu, không thể chuyển Trạng thái phiếu cân", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboWeightType.Focus();
                    return false;
                }
                else
                {
                    cnn.ExecuteNonQuery("UPDATE DM_PhieuCanCau SET WeightType = '" + cboWeightType.uEditValue + "' WHERE WeightNote = '" + txtWeightNote.uText + "'");
                }
            }
            return true;
        }

        private void Update()
        {
            if (!Check_Cond())
                return;
            if (!Check_Canlan2())
                return;
            Check();

            if (!Update_TrangThai())
            return;
            if (spnSecondWeight.Value > 0 && dtpDateOut.EditValue.ToString().Length > 0)
            {
                History();
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    //Kiểm tra xem đã tạo phiếu nhập, xuất cho phiếu cân này chưa
                    var check_NK = db.DM_PhieuNhap.Where(c => c.WeightNote == txtWeightNote.uText).ToList();
                    var check_XK = db.DM_PhieuXuat.Where(c => c.WeightNote == txtWeightNote.uText).ToList();

                    //Nếu chưa tạo thì tạo
                    if (check_NK.Count == 0 && check_XK.Count == 0)
                    {
                        Update_Lan1();
                    }
                    //Nếu đã tạo rồi thì chỉ update lại 1 số thông tin cơ bản trong DM_PhieuCanCau
                    else
                    {
                        Update_Lan2();
                    }
                }
            }
            else
            {
                Update_Lan2();
            }
        }

        private byte[] converImgToByte(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            Byte[] bytBLOBData = new Byte[ms.Length];
            ms.Position = 0;
            ms.Read(bytBLOBData, 0, Convert.ToInt32(ms.Length));
            return bytBLOBData;
        }

        private Image ByteToImg(byte[] byteString)
        {
            Byte[] i = (byte[])byteString;
            MemoryStream stmBLOBData = new MemoryStream(i);
            Image Image = Image.FromStream(stmBLOBData);
            return Image;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (spnID.uValue == 0)
            {
                Luu();
            }
            else
            {
                Update();
            }
        }

        private void Data_Load(int Maphieu)
        {
            int _MaPhieu = 0;
            DataTable _dt = new DataTable();
            _dt.Columns.Add("MaPhieu");
            _MaPhieu = Maphieu;
            spnID.uValue = _MaPhieu;
            using (DBACOMEntities db = new DBACOMEntities())
            {
                DataTable data = new DataTable();
                var Thamso = new Dictionary<String, String>() { { "WeightNote", "" }, { "ID", Maphieu.ToString() } };
                data = cnn.SQL_GetStoredProcedure("SP_GetHinhAnhPCC", Thamso);
                if (data.Rows.Count > 0)
                {
                    txtWeightNote.uText = data.Rows[0]["WeightNote"].ToString();
                    dtpCreateDate.uValue = Convert.ToDateTime(data.Rows[0]["CreateDate"]);
                    txtVehicleNo.uText = data.Rows[0]["VehicleNo"].ToString();
                    cboWeightType.uEditValue = data.Rows[0]["WeightType"].ToString();
                    Load_cboContractNo();
                    Load_cboItemCode();
                    Load_cboLocationCode();
                    Load_cboTransporterCode();
                    Load_cboVendorCode();
                    Load_cboLot();
                    cboContractNo.uEditValue = data.Rows[0]["ContractNo"].ToString();
                    cboTransporterCode.uEditValue = data.Rows[0]["TransporterCode"].ToString();
                    cboItemCode.uEditValue = data.Rows[0]["ItemCode"].ToString();
                    cboVendorCode.uEditValue = data.Rows[0]["VendorCode"].ToString();
                    cboLocationCode.uEditValue = data.Rows[0]["LocationCode"].ToString();
                    txtNote.Text = data.Rows[0]["Note"].ToString();
                    spnFirstWeight.Value = Convert.ToDecimal(data.Rows[0]["FirstWeight"]);
                    spnSecondWeight.Value = Convert.ToDecimal(data.Rows[0]["SecondWeight"]);
                    dtpDateIn.EditValue = data.Rows[0]["DateIn"];
                    dtpDateOut.EditValue = data.Rows[0]["DateOut"];
                    spnTruckQty.uValue = Convert.ToDecimal(data.Rows[0]["TruckQty"]);
                    spnPackageQty.uValue = Convert.ToDecimal(data.Rows[0]["PackageQty"]);
                    spnTLHang.uValue = Convert.ToDecimal(data.Rows[0]["NetWeight"]);
                    cboLot.uEditValue = data.Rows[0]["Lot"];
                }
            }
        }

        private void txtTimphieunhanh_uKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTimphieunhanh.Text.Trim() != "")
                {
                    using (DBACOMEntities db = new DBACOMEntities())
                    {
                        var data = db.DM_PhieuCanCau.Where(c => c.WeightNote == txtTimphieunhanh.Text).ToList();
                        if (data.Count > 0)
                        {
                            Data_Load(Convert.ToInt32(data[0].ID));
                            btnSave.Enabled = true;
                            groupBox1.Enabled = true;
                            txtVehicleNo.bIsReadOnly = true;
                            int ID = Convert.ToInt32(Convert.ToInt32(data[0].ID));
                            try
                            {
                                    var list = db.DM_PhieuCanCau.Where(c => c.ID == ID).ToList();
                                    SoCanLan2 = Convert.ToInt32(list[0].SecondWeight);
                            }
                            catch { }
                        }
                        else
                        {
                            XtraMessageBox.Show("Không tìm thấy phiếu cân!", "Thông báo");
                        }

                        //Nếu đã có số lượng cân lần 2, chỉ cho sửa 1 vài control cơ bản
                        if (SoCanLan2 > 0)
                        {
                            cboWeightType.bIsReadOnly = true;
                            cboItemCode.bIsReadOnly = true;
                            spnTruckQty.bIsReadOnly = true;
                            spnPackageQty.bIsReadOnly = true;
                            if (cboWeightType.uEditValue.ToString() == "Sale" || cboWeightType.uEditValue.ToString() == "Ship")
                            {
                                cboContractNo.bIsReadOnly = true;
                            }
                            else
                            {
                                cboContractNo.bIsReadOnly = false;
                            }
                        }
                        else
                        {
                            cboWeightType.bIsReadOnly = false;
                            cboItemCode.bIsReadOnly = false;
                            spnTruckQty.bIsReadOnly = false;
                            spnPackageQty.bIsReadOnly = false;
                            cboContractNo.bIsReadOnly = false;
                        }
                    }
                }
                else
                {
                    spnID.uValue = 0;
                    spnFirstWeight.Value = 0;
                    spnSecondWeight.Value = 0;
                    cnn.clearControl(groupBox1);
                    groupBox1.Enabled = false;
                    dtpDateIn.Text = "";
                    dtpDateOut.Text = "";
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Load_cboContractNo();
            Load_cboItemCode();
            Load_cboLocationCode();
            Load_cboTransporterCode();
            Load_cboVendorCode();
            Load_cboLot();
            chkNhanDuLieu.Checked = false;
            clRun.SetPermit(this);
            DataTable _dt = new DataTable();
            _dt.Columns.Add("MaPhieu", typeof(Int32));
            _dt.Columns.Add("WeightNote");
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, "ExportNav").ToString() == "True")
                {
                    _dt.Rows.Add(gridView1.GetRowCellValue(i, "ID"), gridView1.GetRowCellValue(i, "WeightNote"));
                }
            }
            if (_dt.Rows.Count == 0)
            {
                XtraMessageBox.Show("Vui lòng chọn phiếu cần sửa", "Thông báo");
            }
            else if (_dt.Rows.Count > 1)
            {
                XtraMessageBox.Show("Chỉ được chọn 1 phiếu cân", "Thông báo");
            }
            else
            {
                spnID.uValue = Convert.ToInt32(_dt.Rows[0][0]);
                Data_Load(Convert.ToInt32(spnID.uValue));
                int  ID = Convert.ToInt32(_dt.Rows[0][0]);
                try
                {
                    using (DBACOMEntities db = new DBACOMEntities())
                    {
                        var list = db.DM_PhieuCanCau.Where(c => c.ID == ID).ToList();
                        SoCanLan2 = Convert.ToInt32(list[0].SecondWeight);
                    }
                }
                catch { }
            }
            btnSave.Enabled = true;
            btnHuy.Enabled = true;
            groupBox1.Enabled = true;
            txtVehicleNo.bIsReadOnly = true;
            //Nếu đã có số lượng cân lần 2, chỉ cho sửa 1 vài control cơ bản
            if (SoCanLan2 > 0)
            {
                cboWeightType.bIsReadOnly = true;
                cboItemCode.bIsReadOnly = true;
                spnTruckQty.bIsReadOnly = true;
                spnPackageQty.bIsReadOnly = true;
                if (cboWeightType.uEditValue.ToString() == "Sale" || cboWeightType.uEditValue.ToString() == "Ship")
                {
                    cboContractNo.bIsReadOnly = true;
                }
                else
                {
                    cboContractNo.bIsReadOnly = false;
                }
                chkNhanDuLieu.Enabled = false;                
            }
            else
            {
                cboWeightType.bIsReadOnly = false;
                cboItemCode.bIsReadOnly = false;
                spnTruckQty.bIsReadOnly = false;
                spnPackageQty.bIsReadOnly = false;
                chkNhanDuLieu.Enabled = true;
                cboContractNo.bIsReadOnly = false;
            }
        }

        private void Intem(int MaPhieu)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var pc = db.DM_PhieuCanCau.Where(c => c.ID == MaPhieu).ToArray();
                if (pc != null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("WeightNote");
                    dt.Columns.Add("CreateDate");
                    dt.Columns.Add("VehicleNo");
                    dt.Columns.Add("WeightType");
                    dt.Columns.Add("ContractNo");
                    dt.Columns.Add("TransporterCode");
                    dt.Columns.Add("ItemCode");
                    dt.Columns.Add("VendorCode");
                    dt.Columns.Add("LocationCode");
                    dt.Columns.Add("DateIn");
                    dt.Columns.Add("DateOut");
                    dt.Columns.Add("FirstWeight");
                    dt.Columns.Add("SecondWeight");
                    dt.Columns.Add("GrossWeight");
                    dt.Columns.Add("TruckTare");
                    dt.Columns.Add("TruckQty");
                    dt.Columns.Add("PackageQty");
                    dt.Columns.Add("Note");
                    dt.Columns.Add("User");
                    dt.Rows.Add(pc[0].WeightNote,
                                cnn.GetDateServer().ToString("dd/MM/yyyy HH:mm:ss"),
                                pc[0].VehicleNo,
                                pc[0].WeightType,
                                pc[0].ContractNo,
                                pc[0].TransporterCode,
                                pc[0].ItemCode,
                                pc[0].VendorCode,
                                pc[0].LocationCode,
                                Convert.ToDateTime(pc[0].DateIn).ToString("dd/MM/yyyy HH:mm:ss"),
                                Convert.ToDateTime(pc[0].DateOut).ToString("dd/MM/yyyy HH:mm:ss"),
                                pc[0].FirstWeight,
                                pc[0].SecondWeight,
                                pc[0].GrossWeight,
                                pc[0].TruckTare,
                                pc[0].TruckQty,
                                pc[0].PackageQty,
                                pc[0].Note,
                                Properties.Settings.Default.FULL_NAME);
                    var pr = db.tblConfigScale.Where(c => c.ID == 14).ToList();
                    PrinterName = pr[0].Description;
                    BaoCaoTK.frmViewReport_Directc frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport_Directc(Application.StartupPath + @"\Report\PhieuCan_Lan1.repx", dt, true, PrinterName);
                }
            }
        }

        private void InPhieuCan(int ID)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                DataTable dt = new DataTable();
                var Thamso = new Dictionary<String, String>() { { "WeightNote", "" }, { "ID", ID.ToString() } };
                dt = cnn.SQL_GetStoredProcedure("SP_GetHinhAnhPCC", Thamso);
                dt.Columns.Add("Nguoidung");
                dt.Columns.Add("TenCty");
                dt.Columns.Add("Diachi");
                dt.Columns.Add("SDT");
                dt.Columns.Add("NgayTao");                
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        dr["Nguoidung"] = Properties.Settings.Default.USER_NAME;
                        dr["TenCty"]            = TenCty;
                        dr["Diachi"]            = Diachi;
                        dr["SDT"]               = SDT;
                        dr["NgayTao"]           = "Ngày " + cnn.GetDateServer().Day + " tháng " + cnn.GetDateServer().Month + " năm " + cnn.GetDateServer().Year;
                        dr["TransporterCode"]   = dr["TransporterCode"].ToString().Replace(" ChuaXacDinh", "");
                        dr["ItemCode"]          = dr["ItemCode"].ToString().Replace(" Chuaxacdinh", "");
                        dr["VendorCode"]        = dr["VendorCode"].ToString().Replace(" ChuaXacDinh", "");
                        dr["VendorName"]        = dr["VendorName"].ToString().Replace("Chưa xác định", "");
                        dr["Lot"]               = dr["Lot"].ToString();
                    }
                    BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\PhieuCan.repx", dt);
                    frm.Show();
                }
            }
        }

        private void btnIntem_Click(object sender, EventArgs e)
        {
            DataTable _dt = new DataTable();
            _dt.Columns.Add("MaPhieu");
            if (xtraTabControl1.SelectedTabPage == xtraTabThongTinChinh)
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.GetRowCellValue(i, "ExportNav").ToString() == "True")
                    {
                        _dt.Rows.Add(gridView1.GetRowCellValue(i, "ID"));
                    }
                }
                if (_dt.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn phiếu cần in", "Thông báo");
                }
                else if (_dt.Rows.Count > 1)
                {
                    XtraMessageBox.Show("Chỉ được chọn 1 phiếu cân", "Thông báo");
                }
                else
                {
                    Intem(Convert.ToInt32(_dt.Rows[0][0]));
                }
            }
            else if (xtraTabControl1.SelectedTabPage == xtraTabThongTinThem)
            {
                for (int i = 0; i < gridView_Export.RowCount; i++)
                {
                    if (gridView_Export.GetRowCellValue(i, "Del").ToString() == "True")
                    {
                        _dt.Rows.Add(gridView_Export.GetRowCellValue(i, "ID"));
                    }
                }
                if (_dt.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn phiếu cần in", "Thông báo");
                }
                else if (_dt.Rows.Count > 1)
                {
                    XtraMessageBox.Show("Chỉ được chọn 1 phiếu cân", "Thông báo");
                }
                else
                {
                    Intem(Convert.ToInt32(_dt.Rows[0][0]));
                }
            }
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            Location_Code();
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var c = db.HT_HETHONG.Where(p => p.LOCATIONCODE == _LocationCode).ToList();
                if (c != null)
                {
                    TenCty = c[0].TENCOQUAN;
                    Diachi = c[0].DIACHI;
                    SDT = c[0].DIENTHOAI;
                }
                DataTable _dt = new DataTable();
                _dt.Columns.Add("ID");
                if (xtraTabControl1.SelectedTabPage == xtraTabThongTinChinh)
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        if (gridView1.GetRowCellValue(i, "ExportNav").ToString() == "True")
                        {
                            _dt.Rows.Add(gridView1.GetRowCellValue(i, "ID"));
                        }
                    }
                    if (_dt.Rows.Count == 0)
                    {
                        XtraMessageBox.Show("Vui lòng chọn phiếu cần in", "Thông báo");
                    }
                    else if (_dt.Rows.Count > 1)
                    {
                        XtraMessageBox.Show("Chỉ được chọn 1 phiếu cân", "Thông báo");
                    }
                    else
                    {
                        InPhieuCan(Convert.ToInt32(_dt.Rows[0][0]));
                    }
                }
                else if (xtraTabControl1.SelectedTabPage == xtraTabThongTinThem)
                {
                    for (int i = 0; i < gridView_Export.RowCount; i++)
                    {
                        if (gridView_Export.GetRowCellValue(i, "Del").ToString() == "True")
                        {
                            _dt.Rows.Add(gridView_Export.GetRowCellValue(i, "ID"));
                        }
                    }
                    if (_dt.Rows.Count == 0)
                    {
                        XtraMessageBox.Show("Vui lòng chọn phiếu cần in", "Thông báo");
                    }
                    else if (_dt.Rows.Count > 1)
                    {
                        XtraMessageBox.Show("Chỉ được chọn 1 phiếu cân", "Thông báo");
                    }
                    else
                    {
                        InPhieuCan(Convert.ToInt32(_dt.Rows[0][0]));
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //OpenPort();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                cnn.clearControl(groupBox1);
                groupBox1.Enabled = false;
                spnFirstWeight.Value = 0;
                spnSecondWeight.Value = 0;
                spnID.uValue = 0;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                chkNhanDuLieu.Checked = false;
            }
        }

        private void btnXoaPhieuCan_Click(object sender, EventArgs e)
        {
            //DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa Phiếu cân này ?", "Thông báo", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
                DataTable _dt = new DataTable();
                _dt.Columns.Add("MaPhieu");
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.GetRowCellValue(i, "ExportNav").ToString() == "True")
                    {
                        _dt.Rows.Add(gridView1.GetRowCellValue(i, "ID"));
                    }
                }
                if (_dt.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn phiếu cần xóa", "Thông báo");
                }
                else
                {
                    BaoCao.frmSuaPhieuCan frm = new BaoCao.frmSuaPhieuCan(this);
                    frm.NghiepVu = "Xoa";
                    frm.ID = _dt.Rows[0][0].ToString();
                    frm.ShowDialog();
                    //using (DBACOMEntities db = new DBACOMEntities())
                    //{
                    //    for (int i = 0; i < _dt.Rows.Count; i++)
                    //    {
                    //        int ID = Convert.ToInt32(_dt.Rows[i][0]);
                    //        DM_PhieuCanCau lc = db.DM_PhieuCanCau.Where(c => c.ID == ID).FirstOrDefault();
                    //        lc.Del = true;
                    //    }
                    //    if (db.SaveChanges() > 0)
                    //    {
                    //        LoadForm();
                    //        XtraMessageBox.Show("Xóa phiếu cân thành công", "Thông báo");
                    //    }
                    //}
                //}
                clRun.SetPermit(this);
            }
        }

        private void btnExportToNav_Click(object sender, EventArgs e)
        {
            Location_Code();
            SaveFileDialog filename = new SaveFileDialog();
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var f = db.tblConfigLinkSync.Where(c => c.Value == "EX_PHIEUCANCAU").Select(p => p.Description).First();
                if (f == null)
                {
                    XtraMessageBox.Show("Không tìm thấy đường dẫn export", "Thông báo");
                }
                else
                {
                    filename.FileName = f;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("WeightNote");
                    dt.Columns.Add("ID");
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        if (gridView1.GetRowCellValue(i, "ExportNav").ToString() == "True" &&
                            Convert.ToInt32(gridView1.GetRowCellValue(i, "FirstWeight")) != 0 &&
                            Convert.ToInt32(gridView1.GetRowCellValue(i, "SecondWeight")) != 0)
                        {
                            var Thamso = new Dictionary<String, String>() { { "ID", gridView1.GetRowCellValue(i, "ID").ToString()} };

                            dt.Rows.Add(cnn.SQL_GetStoredProcedure("SP_txt_PCC", Thamso).Rows[0][0], gridView1.GetRowCellValue(i, "ID"));
                            //int TLHang = Convert.ToInt32(gridView1.GetRowCellValue(i, "GrossWeight")) - Convert.ToInt32(gridView1.GetRowCellValue(i, "TruckTare"));
                            //dt.Rows.Add("\"" + gridView1.GetRowCellValue(i, "WeightNote") + "\";" +
                            //            "\"" + Convert.ToDateTime(gridView1.GetRowCellValue(i, "CreateDate")).ToString("dd/MM/yyyy") + "\";" +
                            //            "\"" + gridView1.GetRowCellValue(i, "VendorCode") + "\";" +
                            //            "\"" + gridView1.GetRowCellValue(i, "ItemCode") + "\";" +
                            //            "\"" + _LocationCode + "\";" +
                            //            "\"" + _LocationName + "\";" +
                            //            "\"" + gridView1.GetRowCellValue(i, "VehicleNo") + "\";" +
                            //            "\"" + Convert.ToInt32(gridView1.GetRowCellValue(i, "GrossWeight")) + "\";" +
                            //            "\"" + Convert.ToInt32(gridView1.GetRowCellValue(i, "TruckTare")) + "\";" +
                            //            "\"" + TLHang + "\";" +
                            //            "\"" + Convert.ToInt32(gridView1.GetRowCellValue(i, "TruckQty")) + "\";" +
                            //            "\"" + gridView1.GetRowCellValue(i, "TotalPackageQty") + "\";" +
                            //            "\"" + Convert.ToInt32(gridView1.GetRowCellValue(i, "NetWeight")) + "\";" +
                            //            "\"" + gridView1.GetRowCellValue(i, "WeightType") + "\";" +
                            //            "\"" + gridView1.GetRowCellValue(i, "TransporterCode") + "\"", gridView1.GetRowCellValue(i, "ID"));
                        }
                    }
                    if (dt.Rows.Count == 0)
                    {
                        XtraMessageBox.Show("Vui lòng chọn phiếu cần Export" + "\n" + "Chỉ Export được những phiếu cân đã hoàn thành", "Thông báo");
                    }
                    else
                    {
                        foreach (DataRow r in dt.Rows)
                        {
                            int ID = Convert.ToInt32(r["ID"]);
                            DM_PhieuCanCau lc = db.DM_PhieuCanCau.Where(c => c.ID == ID).FirstOrDefault();
                            lc.ExportNav = true;
                            db.SaveChanges();
                        }
                        cnn.Export_NAV("WeightNotes.txt", dt);
                        dt.Columns.Remove("ID");
                        //new frmExport(dt, f, "txt");
                        LoadForm();
                        XtraMessageBox.Show("Export thành công", "Thông báo");
                    }
                }
            }
        }

        private void PC_HoanThanh_Load()
        {
            //DateTime Tungay = Convert.ToDateTime(dtpTuNgay.uValue).Date;
            //DateTime Denngay = Convert.ToDateTime(dtpDenNgay.uValue).AddDays(1).Date;
            //string Timkiem = txtSearch.uText.Trim();
            //using (DBACOMEntities db = new DBACOMEntities())
            //{
            //    var data = db.DM_PhieuCanCau
            //            .Where(c => c.ExportNav == true && c.Del == false && c.CreateDate >= Tungay && c.CreateDate < Denngay && (c.WeightNote.Contains(Timkiem) ||
            //                        c.VehicleNo.Contains(Timkiem) ||
            //                        c.VendorCode.Contains(Timkiem) ||
            //                        c.ItemCode.Contains(Timkiem)))
            //           .OrderByDescending(p => p.CreateDate).ToList();
            //    if (data.Count > 0)
            //    {
            //        gridExport.DataSource = data;
            //    }
            //}
            string Tungay = Convert.ToDateTime(dtpTuNgay.uValue).ToString("yyyy-MM-dd");
            string Denngay = Convert.ToDateTime(dtpDenNgay.uValue).ToString("yyyy-MM-dd");

            var Thamso = new Dictionary<String, String>() { { "Tungay", Tungay } , { "Denngay", Denngay } };
            gridExport.DataSource = cnn.SQL_GetStoredProcedure("SP_DMPhieuCanCau_ExportNAV", Thamso);

            for (int i = 0; i < gridView_Export.Columns.Count; i++)
            {
                gridView_Export.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PC_HoanThanh_Load();
        }

        #endregion Thanh tác vụ


        #region Load thông tin đến các Control


        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void cboNhaVanChuyen_Load(object sender, EventArgs e)
        {
            
        }

        private void TrangThai_Load()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("WeightType");
            dt.Rows.Add("Purchase"); //Nhập mua theo hợp đồng
            dt.Rows.Add("Receive"); //Nhập chuyển kho nội bộ
            dt.Rows.Add("Ship"); //Xuất chuyển kho nội bộ
            dt.Rows.Add("Sale"); //Xuất bán hàng          
            cboWeightType.uDataSource = dt;
        }

        private void cboTrangThai_uEditValueChanged(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboWeightType))
            {
                SoHopDong_Load(cboWeightType.uEditValue.ToString());
                if (cboWeightType.uEditValue.ToString() == "Purchase" || cboWeightType.uEditValue.ToString() == "Receive")
                {
                    cboContractNo.sCaption = "Số hợp đồng/SO:";
                }
                else
                {
                    cboContractNo.sCaption = "Số hợp đồng/SO (*):";
                }
            }
        }

        private void cboSanPham_Load(object sender, EventArgs e)
        {
            
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

        private void cboSanPham_uEditValueChanged(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cboItemCode))
            {
                txtTenSanPham.Text = "";
            }
            else
            {
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    _ItemCode = cboItemCode.uEditValue.ToString();
                    var data = db.tblItems
                        .Where(c => c.ItemNo == _ItemCode).Select(p => p.ItemName).ToList();
                    if (data != null)
                    {
                        txtTenSanPham.Text = data[0];
                    }
                }
            }

        }

        private void cboKhachHang_Load(object sender, EventArgs e)
        {
            
        }

        private void cboKhachHang_uEditValueChanged(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cboVendorCode))
            {
                txtTenKhachHang.Text = "";
            }
            else
            {
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    _VendorCode = cboVendorCode.uEditValue.ToString();
                    var data = db.DM_KhachHang
                        .Where(c => c.MaKhachHang == _VendorCode).Select(p => p.TenKhachHang).ToList();
                    if (data != null)
                    {
                        txtTenKhachHang.Text = data[0];
                    }
                }
            }
        }

        private void SoHopDong_Load(string Trangthai)
        {
            
        }

        private void cboLocationCode_Load(object sender, EventArgs e)
        {
            
        }

        private void cboLocationCode_uEditValueChanged(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cboLocationCode))
            {
                txtLocationName.Text = "";
            }
            else
            {
                _LocationCode = cboLocationCode.uEditValue.ToString();
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    var data = db.DM_Location
                        .Where(c => c.Code == _LocationCode).Select(p => p.LocationName).ToList();
                    if (data != null)
                    {
                        txtLocationName.Text = data[0];
                    }
                }
            }
        }

        #endregion Load thông tin đến các Combobox


        #region Tính trọng lượng hàng, bao bì

        private void TLHang()
        {
            spnTLHang.uValue = Math.Round((decimal)(spnGrossWeight.uValue - spnTruckTare.uValue), 2);
        }

        private void TLBao()
        {
            var TL = spnTruckQty.uValue * spnPackageQty.uValue;
            spnTongTLBao.uValue = Convert.ToDecimal(TL.ToString("N0"));
        }

        private void TLHangTruBi()
        {
            spnTLSauTruBi.uValue = Math.Round((decimal)(spnGrossWeight.uValue - spnTruckTare.uValue - spnTongTLBao.uValue), 0);
        }

        private void spnTLHangXe_uValueChanged(object sender, EventArgs e)
        {
            TLHang();
        }

        private void spnTLXe_uValueChanged(object sender, EventArgs e)
        {
            TLHang();
        }

        private void spnTLHang_uValueChanged(object sender, EventArgs e)
        {
            TLHangTruBi();
        }

        private void spnSobao_uValueChanged(object sender, EventArgs e)
        {
            if (spnTruckQty.uValue < 0)
            {
                XtraMessageBox.Show("Số lượng bao không được âm");
                spnTruckQty.uValue = 0;
            }
            else
            {
                TLBao();
                try
                {
                    spnTLBinhQuan.uValue = spnTLSauTruBi.uValue / spnTruckQty.uValue;
                }
                catch { spnTLBinhQuan.uValue = 0; }
            }
        }

        private void spnTLBao_uValueChanged(object sender, EventArgs e)
        {
            if (spnPackageQty.uValue < 0)
            {
                XtraMessageBox.Show("Trọng lượng bao không được âm");
                spnPackageQty.uValue = 0;
            }
            else
            {
                TLBao();
                try
                {
                    spnTLBinhQuan.uValue = spnTLSauTruBi.uValue / spnTruckQty.uValue;
                }
                catch { spnTLBinhQuan.uValue = 0; }
            }
        }

        private void spnTongTLBao_uValueChanged(object sender, EventArgs e)
        {
            TLHangTruBi();
        }

        private void txtCanLan1_TextChanged(object sender, EventArgs e)
        {
        }

        decimal Canlan1, Canlan2;

        private void XacDinhTL()
        {
            Canlan1 = spnFirstWeight.Value;
            Canlan2 = spnSecondWeight.Value;
            _TLHang = Math.Round((decimal)Canlan1 - Canlan2, 2);

            spnCan.Value = Math.Abs(_TLHang);
            
            if (_TLHang >= 0)
            {
                spnGrossWeight.uValue = Canlan1;
                spnTruckTare.uValue = Canlan2;
            }
            else
            {
                spnGrossWeight.uValue = Canlan2;
                spnTruckTare.uValue = Canlan1;
            }
        }

        private void cboSoHopDong_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cnn.bComboIsNull(cboWeightType))
            {
                SoHopDong_Load(cboWeightType.uEditValue.ToString());
            }
        }

        private void spnCanlan1_EditValueChanged(object sender, EventArgs e)
        {
            if (spnFirstWeight.Value != 0)
            {
                dtpDateIn.EditValue = cnn.GetDateServer();
            }
            else
            {
                dtpDateIn.Text = "";
            }
            XacDinhTL();

        }

        private void spnCanlan2_EditValueChanged(object sender, EventArgs e)
        {
            if (spnSecondWeight.Value != 0)
            {
                dtpDateOut.EditValue = cnn.GetDateServer();
            }
            else
            {
                dtpDateOut.Text = "";
            }
            XacDinhTL();
        }

        private void NgayTaoPhieu()
        {
            dtpCreateDate.uValue = Convert.ToDateTime(cnn.GetDateServer());
        }

        #endregion Tính trọng lượng hàng, bao bì        


        #region Load Form

        public void LoadForm()
        {
            Load_cboLocationCode();
            Location_Code();
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var data = (from c in db.DM_PhieuCanCau
                            where c.ExportNav == false && c.Del == false
                            orderby c.CreateDate descending
                            select c).ToList();

                if (data.Count > 0)
                {
                    griDanhSach.DataSource = data;
                }

            }
            Camera1();
            Camera2();
            cboLocationCode.uEditValue = _LocationCode;
            PC_HoanThanh_Load();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //OpenPort();
        }

        private void Camera1()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var c1 = db.tblConfigScale.Where(c => c.ID == 16).ToList();
                Cam1.playlist.items.clear();
                Cam1.playlist.add(c1[0].Description);
                Cam1.playlist.play();
            }
        }

        private void Camera2()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var c2 = db.tblConfigScale.Where(c => c.ID == 17).ToList();
                Cam2.playlist.items.clear();
                Cam2.playlist.add(c2[0].Description);
                Cam2.playlist.play();
            }
        }

        private void Khoa_Button()
        {
            groupBox1.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnSave.Enabled = false;
            btnIntem.Enabled = false;
            btnInPhieu.Enabled = false;
            btnHuy.Enabled = false;
            btnXoaPhieuCan.Enabled = false;
            btnThem.Select();
            spnFirstWeight.Value = 0;
            spnSecondWeight.Value = 0;
        }

        private void frmCanCau_KeyUp(object sender, KeyEventArgs e)
        {           
            if (e.KeyCode == Keys.F1)
            {
                btnThem_Click(sender, e);
            }
            if (e.KeyCode == Keys.F2)
            {
                btnSua_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                btnSave_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnRefresh_Click(sender, e);
            }
        }

        private void repositoryItemCheckEdit1_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.PostEditor();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaPhieu");
            //Sửa, in phiếu, in tem
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.GetRowCellValue(i, "ExportNav").ToString() == "True")
                    {
                        dt.Rows.Add(gridView1.GetRowCellValue(i, "ID").ToString());
                    }
                }
                if (dt.Rows.Count == 1)
                {
                    btnIntem.Enabled = true;
                    btnInPhieu.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoaPhieuCan.Enabled = true;
                    spnID.uValue = Convert.ToInt32(dt.Rows[0][0]);
                    clRun.SetValueToControl(this);
                    btnThem.Enabled = false;
                }
                else
                {
                    btnThem.Enabled = true;
                    clRun.SetValueToControl(this);
                    btnSua.Enabled = false;
                    btnXoaPhieuCan.Enabled = false;
                    btnIntem.Enabled = false;
                    btnInPhieu.Enabled = false;
                }
            }
            //Button Export Nav
            {
                DataTable dt2 = new DataTable();
                dt2.Columns.Add("MaPhieu");
                DataTable dt3 = new DataTable();
                dt3.Columns.Add("MaPhieu");
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.GetRowCellValue(i, "ExportNav").ToString() == "True" &&
                            Convert.ToInt32(gridView1.GetRowCellValue(i, "FirstWeight")) != 0 &&
                            Convert.ToInt32(gridView1.GetRowCellValue(i, "SecondWeight")) != 0)
                    {
                        dt2.Rows.Add(gridView1.GetRowCellValue(i, "ID").ToString());
                    }
                    else if (gridView1.GetRowCellValue(i, "ExportNav").ToString() == "True" &&
                            (Convert.ToInt32(gridView1.GetRowCellValue(i, "FirstWeight")) != 0 ||
                            Convert.ToInt32(gridView1.GetRowCellValue(i, "SecondWeight")) != 0))
                    {
                        dt3.Rows.Add(gridView1.GetRowCellValue(i, "ID").ToString());
                    }
                }
                if (dt2.Rows.Count > 0 && dt3.Rows.Count == 0)
                {
                    btnExportToNav.Enabled = true;
                }
                else if (dt3.Rows.Count > 0 || dt2.Rows.Count == 0)
                {
                    btnExportToNav.Enabled = false;
                }
            }
        }

        private void repositoryItemCheckEdit2_EditValueChanged(object sender, EventArgs e)
        {
            gridView_Export.PostEditor();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaPhieu");
            //Sửa, in phiếu, in tem
            {
                for (int i = 0; i < gridView_Export.RowCount; i++)
                {
                    if (gridView_Export.GetRowCellValue(i, "Del").ToString() == "True")
                    {
                        dt.Rows.Add(gridView_Export.GetRowCellValue(i, "Del").ToString());
                    }
                }
                if (dt.Rows.Count == 1)
                {
                    btnInPhieu.Enabled = true;
                    clRun.SetValueToControl(this);
                }
                else
                {
                    btnInPhieu.Enabled = false;
                }
            }
        }


        private void frmCanCau_Load(object sender, EventArgs e)
        {
            clRun.SetValueToControl(this);
            dtpTuNgay.uValue = Convert.ToDateTime(cnn.GetDateServer()).AddDays(-7);
            dtpDenNgay.uValue = cnn.GetDateServer();
            NgayTaoPhieu();
            LoadForm();
            TrangThai_Load();
            Khoa_Button();
            timer1.Start();
        }

        private Image Picture_Cam(PanelControl Cam)
        {
            System.Drawing.Image ret = null;
            try
            {
                // take picture BEFORE saveFileDialog pops up!!
                Bitmap bitmap = new Bitmap(Cam.Width, Cam.Height);
                {
                    Graphics g = Graphics.FromImage(bitmap);
                    {
                        Graphics gg = Cam.CreateGraphics();
                        {
                            //timerTakePicFromVideo.Start();
                            this.BringToFront();
                            g.CopyFromScreen(
                                Cam.PointToScreen(new System.Drawing.Point()).X,
                                Cam.PointToScreen(new System.Drawing.Point()).Y,
                                0, 0,
                                new System.Drawing.Size(Cam.Width, Cam.Height)
                                );
                        }
                    }

                    using (MemoryStream ms = new MemoryStream())
                    {
                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        ret = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return ret;
        }

        #endregion Load Form


        #region Connect Cân
        private TcpListener _tcplistener;
        private Thread _listenThread;
        private static Thread _threadConnect;
        private TcpClient _tcpClient;
        private TcpClient _myClient;

        private void txtResultCom1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] tempArray = txtResultCom1.Lines;
                if (tempArray.Length >= 4)
                {
                    for (int i = tempArray.Length - 1; i >= tempArray.Length - 4; i--)
                    {
                        if (tempArray[i].Length >= 13 && !tempArray[i].Contains("99"))
                        {
                            textBox1.Text = tempArray[i].Replace(" ", "").Replace("[R]:", "").Replace("?", "");
                            try
                            {
                                TrongLuongCan = Convert.ToInt32(textBox1.Text);
                            }
                            catch { }
                            if (spnID.uValue == 0)
                            {
                                spnFirstWeight.Value = TrongLuongCan;
                            }
                            else if (spnID.uValue != 0 && chkNhanDuLieu.Checked == true)
                            {
                                spnSecondWeight.Value = TrongLuongCan;
                            }
                        }
                        else
                        {
                            spnFirstWeight.Value = spnFirstWeight.Value;
                            spnSecondWeight.Value = spnSecondWeight.Value;
                        }
                    }
                }
            }
            catch { }
        }

        string _bufferincmessage;
        private int _typeConnect;
        private SerialPort _serialPort;
        private void ThongsoCan()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.tblConfigScale.Where(c => c.ID == 2).FirstOrDefault();
                txtcom1.Text = list.IPServer;
                txtparity.Text = list.Parity;
                txtstopbits.Text = list.StopBits.ToString();
                txtmaxspeed.Text = list.MaxSpeed.ToString();
                txtdatabits.Text = list.DataBits.ToString();
            }
        }

        private void btnstopcom_Click(object sender, EventArgs e)
        {
            _ClosePort();
        }

        private void btnstartcom_Click(object sender, EventArgs e)
        {
            _OpenPort();
            btnBatDau.Enabled = false;
            timer1.Start();
        }

        /// <summary>
        /// Mở port cho cổng COM1
        /// </summary>
        private void OpenPort()
        {
            try
            {
                ThongsoCan();
                bool portExists = SerialPort.GetPortNames().Any(x => x == txtcom1.Text);
                if (portExists)
                {
                    _serialPort = new SerialPort
                    {
                        RtsEnable = true,
                        DtrEnable = true,
                        PortName = txtcom1.Text,
                        BaudRate = int.Parse(txtmaxspeed.Text),
                        Parity = GetParity(txtparity.Text),
                        DataBits = int.Parse(txtdatabits.Text),
                        StopBits = GetStopBits(txtstopbits.Text),
                        ReadBufferSize = 10240,
                        WriteBufferSize = 10240,
                        ReadTimeout = 500,
                    };
                    _typeConnect = 3;
                    _serialPort.DataReceived += serialPort_DataReceived;
                    _serialPort.Open();
                    if (_serialPort.IsOpen)
                    {
                        SetStatus(2, lblStatus);
                    }
                    else
                    {
                        SetStatus(0, lblStatus);
                    }
                }
                else
                {
                    ClosePort();
                    lblStatus.Text = "COM note existed.";
                    lblStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                ClosePort();
                MessageBox.Show(ex.Message);
            }
        }

        private Parity GetParity(string parity)
        {
            var parityFullName = Parity.None;
            switch (parity)
            {
                case ParityContant.NoneKey:
                    parityFullName = Parity.None;
                    break;
                case ParityContant.EvenKey:
                    parityFullName = Parity.Even;
                    break;
                case ParityContant.OddKey:
                    parityFullName = Parity.Odd;
                    break;
                case ParityContant.MarkKey:
                    parityFullName = Parity.Mark;
                    break;
                case ParityContant.SpaceKey:
                    parityFullName = Parity.Space;
                    break;
            }

            return parityFullName;
        }

        private StopBits GetStopBits(string stopBits)
        {
            var stopBitsFullName = StopBits.One;
            switch (stopBits)
            {
                case "1":
                    stopBitsFullName = StopBits.One;
                    break;
                case "1.5":
                    stopBitsFullName = StopBits.OnePointFive;
                    break;
                case "2":
                    stopBitsFullName = StopBits.Two;
                    break;
                default:
                    stopBitsFullName = StopBits.None;
                    break;
            }

            return stopBitsFullName;
        }

        void SetStatus(int _status, TextBox lbl)
        {
            this.Invoke(new EventHandler(delegate
            {
                if (_status == 0)
                {//Stop
                    lbl.Text = "Disconnected";
                    lbl.ForeColor = Color.Red;
                }
                else if (_status == 1)
                { //Waitting...
                    lbl.Text = "Waiting...";
                    lbl.ForeColor = Color.Yellow;
                }
                else if (_status == 2)
                { //Opening...
                    lbl.Text = "Connected";
                    lbl.ForeColor = Color.Lime;
                }
            }));
        }

        private void Receive(Socket handler, string msg)
        {
            Invoke(new EventHandler(delegate
            {
                ReceiveData(msg);
            }));
        }
        bool receiving = false;

        private void Receive(string msg)
        {
            Invoke(new EventHandler(delegate
            {
                ReceiveData(msg);
            }));
        }

        private void ReceiveData(string msg)
        {
            txtLogDecrypt.AppendText(string.Format("[R]: {0}{1}", msg, Environment.NewLine));
            txtLogDecrypt.SelectionStart = txtLogDecrypt.Text.Length - 1;
            txtLogDecrypt.ScrollToCaret();
            receiving = true;
        }

        void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var serialPort = (SerialPort)sender;
            if (!serialPort.IsOpen || serialPort.BytesToRead <= 0) return;
            var array = new byte[serialPort.BytesToRead];
            serialPort.Read(array, 0, array.Length);
            _bufferincmessage = Encoding.ASCII.GetString(array);            
            Receive(_bufferincmessage);
        }
        
        private void ClosePort()
        {
            if (_serialPort != null)
            {
                _serialPort.Close();
            }

            SetStatus(0, lblStatus);
        }

        private void chkNhanDuLieu_EditValueChanged(object sender, EventArgs e)
        {
            if (chkNhanDuLieu.Checked == false)
            {
                spnSecondWeight.Value = 0;
                dtpDateOut.Text = "";
            }
        }

        private void txtSearch_uKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PC_HoanThanh_Load();
            }
        }

        private void _OpenPort()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.tblConfigScale.Where(c => c.ID == 2).ToList();
                textBox2.Text = list[0].IPServer + ":" +
                                list[0].MaxSpeed + ":" +
                                list[0].Parity + ":" +
                                list[0].DataBits + ":" +
                                list[0].StopBits;
            }
            try
            {
                if (string.IsNullOrEmpty(textBox2.Text)) return;
                var split = textBox2.Text.Split(':');
                if (split.Length <= 0) return;
                _serialPort = new SerialPort
                {
                    RtsEnable = true,
                    DtrEnable = true,
                    PortName = split[0],
                    BaudRate = int.Parse(split[1]),
                    Parity = GetParity(split[2]),
                    DataBits = int.Parse(split[3]),
                    StopBits = GetStopBits(split[4]),
                    ReadBufferSize = 10240,
                    WriteBufferSize = 10240,
                    ReadTimeout = 500,
                };
                _typeConnect = 3;
                _serialPort.DataReceived += serialPort_DataReceived;
                _serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtLogDecrypt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] tempArray = txtLogDecrypt.Lines;
                if (tempArray.Length >= 4)
                {
                    for (int i = tempArray.Length - 1; i >= tempArray.Length - 4; i--)
                    {
                        if (tempArray[i].Contains("k"))
                        {
                            textBox3.Text = tempArray[i].Replace(" ", "").Replace("[R]:", "").Replace("k", "");
                            try
                            {
                                TrongLuongCan = Convert.ToInt32(textBox3.Text);
                                numericUpDown2.Value = TrongLuongCan;
                            }
                            catch { }
                        }
                    }
                }
            }
            catch { }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //int a = 0;
            //using (DBACOMEntities db = new DBACOMEntities())
            //{
            //    var list = db.tblConfigScale.Where(c => c.ID == 19).ToList();
            //    a = Convert.ToInt32(list[0].MaxSpeed);
            //}

            if (spnID.uValue == 0)
            {
                spnFirstWeight.Value = frmMain.SoCanCau ;
            }
            else if (spnID.uValue != 0 && chkNhanDuLieu.Checked == true)
            {
                spnSecondWeight.Value = frmMain.SoCanCau;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                tblConfigScale cb = db.tblConfigScale.Where(c => c.ID == 19).FirstOrDefault();
                cb.MaxSpeed = Convert.ToInt32(numericUpDown2.Value);
                db.SaveChanges();
            }
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CanCau.frmTaoKhachHang frm = new CanCau.frmTaoKhachHang();
            frm.ShowDialog();
        }

        private void _ClosePort()
        {
            if (_serialPort != null)
            {
                _serialPort.Close();
            }
        }
        #endregion Connect Cân


        #region Load data đến Combobox

        private void Load_cboContractNo()
        {
            cboContractNo.Columns.Clear();
            cnn.clearControl(cboContractNo);
            if (!cnn.bComboIsNull(cboWeightType))
            {
                string Trangthai = cboWeightType.uEditValue.ToString();
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    if (Trangthai == "Purchase" || Trangthai == "Receive")
                    {
                        var data = (from c in db.DM_PurchaseContract
                                    select new { Ma = c.ContractNo, Ten = c.VendorName }).ToList();
                        if (data != null)
                        {
                            cboContractNo.uDataSource = ConvertToDataTable(data);
                            cboContractNo.Enabled = true;
                        }
                    }
                    else if (Trangthai == "Sale" || Trangthai == "Ship")
                    {
                        var data = (from c in db.DM_LenhGiaoHang
                                    select new { Ma = c.SaleOrderCalNo, Ten = c.SaleContractNo }).ToList();
                        if (data != null)
                        {
                            cboContractNo.uDataSource = ConvertToDataTable(data);
                            cboContractNo.Enabled = true;
                        }
                    }
                }
            }
        }

        private void Load_cboTransporterCode()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var data = db.DM_NhaVanChuyen.ToList();
                if (data != null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("MaNhaVanChuyen");
                    dt.Columns.Add("TenNhaVanChuyen");
                    dt = ConvertToDataTable(data);
                    cboTransporterCode.uDataSource = dt;
                }
            }
        }

        private void Load_cboItemCode()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var data = db.tblItems.ToList();
                if (data != null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ItemNo");
                    dt.Columns.Add("ItemName");
                    dt = ConvertToDataTable(data);
                    cboItemCode.uDataSource = dt;
                }
            }
        }

        private void Load_cboVendorCode()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var data = db.DM_KhachHang.ToList();
                if (data != null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("MaKhachHang");
                    dt.Columns.Add("TenKhachHang");
                    dt = ConvertToDataTable(data);
                    cboVendorCode.uDataSource = dt;
                }
            }
        }

        private void Load_cboLocationCode()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var data = db.DM_Location.ToList();
                if (data != null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Code");
                    dt.Columns.Add("LocationName");
                    dt = ConvertToDataTable(data);
                    cboLocationCode.uDataSource = dt;
                }
            }
        }

        private void Load_cboLot()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Lot = db.DM_Lot.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Lot");
                dt = ConvertToDataTable(Lot);
                cboLot.uDataSource = dt;
            }
        }

        private void cboTransporterCode_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboTransporterCode();
        }

        private void cboItemCode_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboItemCode();
        }

        private void cboVendorCode_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboVendorCode();
        }

        private void cboLocationCode_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboLocationCode();
        }

        private void cboLot_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboLot();
        }

        private void spnSecondWeight_ValueChanged(object sender, EventArgs e)
        {
            if (spnSecondWeight.Value != 0)
            {
                dtpDateOut.EditValue = cnn.GetDateServer();
            }
            else
            {
                dtpDateOut.Text = "";
            }
            XacDinhTL();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i< gridView1.DataRowCount; i++)
            {
                gridView1.SetRowCellValue(i, "ExportNav", 0);
            }
            gridView1.SetFocusedRowCellValue("ExportNav", 1);
            btnSua_Click(sender, e);
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                Footer = "Trọng lượng trung bình 1 bao chứa: " +
                        (Math.Round((Convert.ToDecimal(gridView1.GetFocusedRowCellValue("NetWeight")) / Convert.ToDecimal(gridView1.GetFocusedRowCellValue("TruckQty"))), 2)).ToString("N2");
            }
            catch { Footer = ""; }
            lbfoodter1.Text = Footer;           
        }

        private void gridView2_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                Footer2 = "Trọng lượng trung bình 1 bao chứa: " +
                        (Math.Round((Convert.ToDecimal(gridView_Export.GetFocusedRowCellValue("NetWeight")) / Convert.ToDecimal(gridView_Export.GetFocusedRowCellValue("TruckQty"))), 2)).ToString("N2");
            }
            catch { Footer2 = ""; }
            lbfoodter2.Text = Footer2;
        }

        private void gridView1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Footer = "Trọng lượng trung bình 1 bao chứa: " +
                        (Math.Round((Convert.ToDecimal(gridView1.GetFocusedRowCellValue("NetWeight")) / Convert.ToDecimal(gridView1.GetFocusedRowCellValue("TruckQty"))), 2)).ToString("N2");
            }
            catch { Footer = ""; }
            lbfoodter1.Text = Footer;
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView1.OptionsSelection.MultiSelect = true;
                gridView1.SelectAll();
            }
        }

        private void gridView2_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Footer2 = "Trọng lượng trung bình 1 bao chứa: " +
                        (Math.Round((Convert.ToDecimal(gridView_Export.GetFocusedRowCellValue("NetWeight")) / Convert.ToDecimal(gridView_Export.GetFocusedRowCellValue("TruckQty"))), 2)).ToString("N2");
            }
            catch { Footer2 = ""; }
            lbfoodter2.Text = Footer2;
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView_Export.OptionsSelection.MultiSelect = true;
                gridView_Export.SelectAll();
            }
        }

        private void spnTLSauTruBi_uValueChanged(object sender, EventArgs e)
        {
            try
            {
                spnTLBinhQuan.uValue = spnTLSauTruBi.uValue / spnTruckQty.uValue;
            }
            catch { spnTLBinhQuan.uValue = 0; }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("WeightNote");
            DataView dv = new DataView((DataTable)gridExport.DataSource).ToTable().DefaultView;
            dv.RowFilter = "Chon = True";
            if (dv.Count > 0)
            {
                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn lấy lại Phiếu cân này?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int dem = 0;
                    for (int i = 0; i < gridView_Export.RowCount; i++)
                    {
                        if (gridView_Export.GetRowCellValue(i, "Chon").ToString() == "True")
                        {
                            cnn.ExecuteNonQuery("UPDATE DM_PhieuCanCau SET ExportNav = 0 WHERE WeightNote = '" + gridView_Export.GetRowCellValue(i, "WeightNote") + "'");
                            dt.Rows.Add(gridView_Export.GetRowCellValue(i, "WeightNote").ToString());
                            dem++;
                        }
                    }
                    if (dem > 0)
                    {
                        cnn.Undo_NAV("WeightNotes.txt", dt);
                        LoadForm();
                        XtraMessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn phiếu cần Undo", "Thông báo");
            }
        }

        private void cboContractNo_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboContractNo();
        }

        #endregion Load data đến Combobox
    }
}
