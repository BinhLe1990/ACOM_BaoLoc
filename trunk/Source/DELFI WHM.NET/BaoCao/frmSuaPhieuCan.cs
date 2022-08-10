using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.BaoCao
{

    public partial class frmSuaPhieuCan : DevExpress.XtraEditors.XtraForm
    {
        private readonly CanCau.frmCanCau frm1;
        private readonly BaoCao.fmPhieuCan frm2;
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string _ID = "";
        string PCC = "";
        string Trangthai = "";
        int LanCan;
        int SoCan1 = 0;
        int SoCan2 = 0;
        string _ItemCode = "";
        string _VendorCode = "";
        string _LocationCode = "";
        string _TrangThai = "";

        public frmSuaPhieuCan(CanCau.frmCanCau frm)
        {
            InitializeComponent();
            frm1 = frm;
        }
        public frmSuaPhieuCan(BaoCao.fmPhieuCan frm)
        {
            InitializeComponent();
            frm2 = frm;
        }
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string NghiepVu
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

        decimal Canlan1 = 0;
        decimal Canlan2 = 0;
        decimal _TLHang = 0;
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

        private void XacDinhTL()
        {
            Canlan1 = spnSoCan1.uValue;
            Canlan2 = spnSoCan2.uValue;
            _TLHang = Math.Round((decimal)Canlan1 - Canlan2, 2);

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

        private void frmSuaPhieuCan_Load(object sender, EventArgs e)
        {
            TrangThai_Load();
            Load_cboContractNo();
            Load_cboItemCode();
            Load_cboLocationCode();
            Load_cboLot();
            Load_cboTransporterCode();
            Load_cboVendorCode();
            spnID.uValue = Convert.ToInt32(ID);

            using (DBACOMEntities db = new DBACOMEntities())
            {
                DataTable data = new DataTable();
                var Thamso = new Dictionary<String, String>() { { "WeightNote", "" }, { "ID", spnID.uValue.ToString() } };
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
                    txtGhichu.Text = data.Rows[0]["Note"].ToString();
                    spnSoCan1.uValue = Convert.ToDecimal(data.Rows[0]["FirstWeight"]);
                    spnSoCan2.uValue = Convert.ToDecimal(data.Rows[0]["SecondWeight"]);
                    if (spnSoCan2.uValue > 0)
                    {
                        spnSoCan2.bIsReadOnly = false;
                        spnTruckQty.bIsReadOnly = false;
                        spnPackageQty.bIsReadOnly = false;
                    }
                    else
                    {
                        spnSoCan2.bIsReadOnly = true;
                        spnTruckQty.bIsReadOnly = true;
                        spnPackageQty.bIsReadOnly = true;
                    }
                    spnTruckQty.uValue = Convert.ToDecimal(data.Rows[0]["TruckQty"]);
                    spnPackageQty.uValue = Convert.ToDecimal(data.Rows[0]["PackageQty"]);
                    spnTLHang.uValue = Convert.ToDecimal(data.Rows[0]["NetWeight"]);
                    cboLot.uEditValue = data.Rows[0]["Lot"];
                }
                if (NghiepVu == "Xoa")
                {
                    spnSoCan1.bIsReadOnly = true;
                    spnSoCan2.bIsReadOnly = true;
                    spnTruckQty.bIsReadOnly = true;
                    spnPackageQty.bIsReadOnly = true;
                    btnSave.Visible = false;
                }
                else
                {
                    btnXoa.Visible = false;
                }
            }
        }

        string _ChungTu = "";
        string _MaNhaVanChuyen = "";
        string _Lot = "";
        private void Check()
        {
            if (!cnn.bComboIsNull(cboContractNo))
            {
                _ChungTu = cboContractNo.uEditValue.ToString();
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
        }

        private bool CheckCond()
        {
            PCC = txtWeightNote.uText;
            if (txtLyDoSua.uText.Trim().Length == 0)
            {
                XtraMessageBox.Show("Lý do sửa không được bỏ trống", "Không thể sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            var Thamso = new Dictionary<String, String>() { { "WeightNote", PCC } };
            if (cnn.SQL_GetStoredProcedure("SP_Check_WN_EX", Thamso).Rows.Count > 0 &&
                (cboWeightType.uEditValue.ToString() == "Purchase" || cboWeightType.uEditValue.ToString() == "Receive"))
            {
                XtraMessageBox.Show("Đã phát sinh phiếu xuất cho QRCode thuộc phiếu cân này", "Không thể sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.DM_PhieuCanCau.Where(c => c.WeightNote == PCC && c.ExportNav == true).ToList();
                if (list.Count > 0)
                {
                    XtraMessageBox.Show("Phiếu cân đã Export NAV", "Không thể sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void History()
        {
            string chuoi = "";
            Check();
            int ID_Phieucan = Convert.ToInt32(spnID.uValue);
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var pc = db.DM_PhieuCanCau.Where(c => c.ID == ID_Phieucan).ToArray().FirstOrDefault();
                if (pc != null)
                {
                    if (pc.FirstWeight != spnSoCan1.uValue)
                    {
                        chuoi += "Sửa số cân lần 1 " + Convert.ToInt32(pc.FirstWeight).ToString("N0") + " thành " + Convert.ToInt32(spnSoCan1.uValue).ToString("N0") + "\n";
                    }
                    if (pc.SecondWeight != spnSoCan2.uValue)
                    {
                        chuoi += "Sửa số cân lần 2 " + Convert.ToInt32(pc.SecondWeight).ToString("N0") + " thành " + Convert.ToInt32(spnSoCan2.uValue).ToString("N0") + "\n";
                    }
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
                        chuoi += " Sửa lot " + pc.Lot + " thành " + _Lot + "\n";
                    }
                    if (pc.VendorCode != _VendorCode)
                    {
                        chuoi += " Sửa khách hàng " + pc.VendorCode + " thành " + _VendorCode + "\n";
                    }
                    if (pc.LocationCode != _LocationCode)
                    {
                        chuoi += " Sửa Location " + pc.LocationCode + " thành " + _LocationCode + "\n";
                    }
                    if (pc.Note != txtGhichu.uText)
                    {
                        chuoi += " Sửa Ghi chú " + pc.Note + " thành " + txtGhichu.uText + "\n";
                    }
                    if (pc.TruckQty != spnTruckQty.uValue)
                    {
                        chuoi += " Sửa Số bao " + pc.TruckQty + " thành " + spnTruckQty.uValue + "\n";
                    }
                    if (pc.PackageQty != spnPackageQty.uValue)
                    {
                        chuoi += " Sửa Trọng lượng 1 bao " + pc.PackageQty + " thành " + spnPackageQty.uValue + "\n";
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
                        Loai = "PhieuCanCau",
                        Ghichu = txtLyDoSua.uText
                    });
                    db.SaveChanges();
                }
            }
        }

        private void History_Sua()
        {
            int ID_Phieucan = Convert.ToInt32(spnID.uValue);
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var pc = db.DM_PhieuCanCau.Where(c => c.ID == ID_Phieucan).ToArray().FirstOrDefault();
                if (pc != null)
                {
                    if (pc.FirstWeight != spnSoCan1.uValue)
                    {
                        db.Log_PhieuCanCau.Add(new Log_PhieuCanCau
                        {
                            WeightNote = txtWeightNote.uText,
                            ThoiGian = cnn.GetDateServer(),
                            UserName = Properties.Settings.Default.USER_NAME,
                            LanCan = 1,
                            SoCanBanDau = pc.FirstWeight,
                            SoSauKhiSua = spnSoCan1.uValue,
                            Ghichu = txtLyDoSua.uText,
                            Loai = 1
                        });
                        db.SaveChanges();
                    }
                    if (pc.SecondWeight != spnSoCan2.uValue)
                    {
                        db.Log_PhieuCanCau.Add(new Log_PhieuCanCau
                        {
                            WeightNote = txtWeightNote.uText,
                            ThoiGian = cnn.GetDateServer(),
                            UserName = Properties.Settings.Default.USER_NAME,
                            LanCan = 2,
                            SoCanBanDau = pc.SecondWeight,
                            SoSauKhiSua = spnSoCan2.uValue,
                            Ghichu = txtLyDoSua.uText,
                            Loai = 1
                        });
                        db.SaveChanges();
                    }
                    if (pc.TruckQty != spnTruckQty.uValue)
                    {
                        db.Log_PhieuCanCau.Add(new Log_PhieuCanCau
                        {
                            WeightNote = txtWeightNote.uText,
                            ThoiGian = cnn.GetDateServer(),
                            UserName = Properties.Settings.Default.USER_NAME,
                            LanCan = 0,
                            SoCanBanDau = pc.TruckQty,
                            SoSauKhiSua = spnTruckQty.uValue,
                            Ghichu = txtLyDoSua.uText,
                            Loai = 2
                        });
                        db.SaveChanges();
                    }
                    if (pc.PackageQty != spnPackageQty.uValue)
                    {
                        db.Log_PhieuCanCau.Add(new Log_PhieuCanCau
                        {
                            WeightNote = txtWeightNote.uText,
                            ThoiGian = cnn.GetDateServer(),
                            UserName = Properties.Settings.Default.USER_NAME,
                            LanCan = 0,
                            SoCanBanDau = pc.PackageQty,
                            SoSauKhiSua = spnPackageQty.uValue,
                            Ghichu = txtLyDoSua.uText,
                            Loai = 3
                        });
                        db.SaveChanges();
                    }
                }
            }
        }

        private void History_Xoa()
        {
            int ID_Phieucan = Convert.ToInt32(spnID.uValue);
            using (DBACOMEntities db = new DBACOMEntities())
            {
                db.HIS_Phieucancau.Add(new HIS_Phieucancau
                {
                    ID_WeightNote = Convert.ToInt32(spnID.uValue),
                    Dateupdate = cnn.GetDateServer(),
                    UserName = Properties.Settings.Default.USER_NAME,
                    Desc = "Xóa phiếu cân",
                    Loai = "PhieuCanCau",
                    Ghichu = txtLyDoSua.uText
                });
                db.SaveChanges();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn Lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            if (!CheckCond())
                return;
            PCC = txtWeightNote.uText;
            Trangthai = cboWeightType.uEditValue.ToString();
            Check();

            History_Sua();

            //Update lại thông tin các table liên quan
            var Thamso = new Dictionary<String, String>() {{ "LocationName", txtLocationName.uText },
                                                           { "WeightNote", PCC },
                                                           { "VehicleNo", txtVehicleNo.uText },
                                                           { "WeightType", Trangthai },
                                                           { "ContractNo", _ChungTu },
                                                           { "TransporterCode", _MaNhaVanChuyen },
                                                           { "ItemCode", _ItemCode },
                                                           { "VendorCode", _VendorCode },
                                                           { "VendorName", txtTenKhachHang.Text },
                                                           { "LocationCode", _LocationCode },
                                                           { "FirstWeight", spnSoCan1.uValue.ToString() },
                                                           { "SecondWeight", spnSoCan2.uValue.ToString() },
                                                           { "GrossWeight", spnGrossWeight.uValue.ToString() },
                                                           { "TruckTare", spnTruckTare.uValue.ToString() },
                                                           { "TruckQty", spnTruckQty.uValue.ToString() },
                                                           { "PackageQty", spnPackageQty.uValue.ToString() },
                                                           { "TotalPackageQty", spnTongTLBao.uValue.ToString() },
                                                           { "Note", txtGhichu.uText },
                                                           { "Lot",  _Lot},
                                                           { "UserName", Properties.Settings.Default.USER_NAME} };

            cnn.SQL_ExecuteStoredProcedure("SP_Update_PCC_Nhap", Thamso);

            XtraMessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
        }

        private void cboWeightType_uEditValueChanged(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboWeightType))
            {
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

        private void cboContractNo_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboContractNo();
        }

        private void cboTransporterCode_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboTransporterCode();
        }

        private void cboItemCode_uEditValueChanged(object sender, EventArgs e)
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

        private void cboLot_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboLot();
        }

        private void cboVendorCode_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboVendorCode();
        }

        private void cboLocationCode_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboLocationCode();
        }

        private void cboVendorCode_uEditValueChanged(object sender, EventArgs e)
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

        private void spnSoCan2_uValueChanged(object sender, EventArgs e)
        {
            XacDinhTL();
        }

        private void spnSoCan1_uValueChanged(object sender, EventArgs e)
        {
            XacDinhTL(); 
        }

        private void TLHang()
        {
            spnTLHang.uValue = Math.Round((decimal)(spnGrossWeight.uValue - spnTruckTare.uValue), 2);
        }

        private void TLBao()
        {
            spnTongTLBao.uValue = Math.Round((decimal)(spnTruckQty.uValue * spnPackageQty.uValue), 2);
        }

        private void TLHangTruBi()
        {
            spnTLSauTruBi.uValue = Math.Round((decimal)(spnGrossWeight.uValue - spnTruckTare.uValue - spnTongTLBao.uValue), 2);
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
            }
        }

        private void spnTongTLBao_uValueChanged(object sender, EventArgs e)
        {
            TLHangTruBi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa Phiếu cân này ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (txtLyDoSua.uText.Trim().Length == 0)
                {
                    XtraMessageBox.Show("Vui lòng nhập Lý do xóa phiếu cân", "Thông báo");
                }
                else
                {
                    using (DBACOMEntities db = new DBACOMEntities())
                    {
                        History_Xoa();
                        int i = Convert.ToInt32(spnID.uValue);
                        var Thamso = new Dictionary<String, String>() { { "ID", spnID.uValue.ToString() } };
                        cnn.SQL_ExecuteStoredProcedure("SP_Del_WeightNote", Thamso);
                        frm1.LoadForm();
                        this.Close();
                        XtraMessageBox.Show("Xóa phiếu cân thành công", "Thông báo");
                    }
                }
            }
        }
    }
}
