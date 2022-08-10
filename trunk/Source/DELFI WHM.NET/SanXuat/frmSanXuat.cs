using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DELFI_WHM.NET.DELFI_Class;
using System.Net.Sockets;
using System.Threading;
using System.IO.Ports;
using System.IO;
using System.Data.OleDb;

namespace DELFI_WHM.NET.SanXuat
{
    public partial class frmSanXuat : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        public static string Access_Connection = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Database.mdb";
        string _QuiCach, _Lot, _MaSanPham, _LenhSanXuat, _TLYeuCau, _Packing, _Loai, _Location, _LineNo, _NgayXuat;
        int _Trongluong, _Soluong, _TLTruBi, _TLHang, _PalletQty, _ID;
        DateTime Ngay;
        string _LocationCode = "";
        string _LocationName = "";
        int LineNo = 0;
        int ID_PhieuXuat = 0;
        int TrongLuongCan = 0;
        int TLCu = 0;
        int _Ca;
        string _Cer = "NONE";
        string _Vitri = "RECEIVING";
        public frmSanXuat(frmDS_SanXuat parent)
        {
            InitializeComponent();
        }

        public string Chungtu
        {
            get { return _LenhSanXuat; }
            set { _LenhSanXuat = value; }
        }

        public DateTime NgayTao
        {
            get { return Ngay; }
            set { Ngay = value; }
        }

        public int __ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private void frmSanXuat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
            if (e.KeyCode == Keys.F4)
            {
                btnLuu_Click(sender, e);
            }
        }

        private void txtCode_uTextChanged(object sender, EventArgs e)
        {

        }

        private void cboMaSanPham_uEditValueChanged(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cboMaSanPham))
            {
                txtQRCode.Enabled = false;
            }
            else
            {
                txtQRCode.Enabled = true;
            }
        }

        private void repositoryItemCheckEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (gridView_DaCan.GetFocusedRowCellValue("ExportNAV").ToString() == "True")
            {
                gridView_DaCan.SetFocusedRowCellValue("Chon", false);
                XtraMessageBox.Show("Dữ liệu đã được Export NAV, không thể chọn", "Thông báo");
            }
            else
            {
                gridView_DaCan.PostEditor();
                DataTable dt = new DataTable();
                dt.Columns.Add("Chon");
                dt.Columns.Add("Date", typeof(DateTime));
                dt.Columns.Add("DocumentNo");
                for (int i = 0; i < gridView_DaCan.RowCount; i++)
                {
                    if (gridView_DaCan.GetRowCellValue(i, "Chon").ToString() == "True")
                    {
                        dt.Rows.Add(gridView_DaCan.GetRowCellValue(i, "Chon").ToString(), gridView_DaCan.GetRowCellValue(i, "Date"), gridView_DaCan.GetRowCellValue(i, "DocumentNo").ToString());
                    }
                }
                if (dt.Rows.Count > 0)
                {
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    btnCantrubi.Enabled = false;
                    dtpNgayxuat.uValue = Convert.ToDateTime(dt.Rows[0]["Date"]);
                    cboLSX.uEditValue = dt.Rows[0]["DocumentNo"].ToString();
                }
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView3_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void txtQRCode_uKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LaySoCan();
                dtpNgayxuat.uValue = cnn.GetDateServer();
                if (!Check_QRCode())
                    return;
                if (!Check_Cond())
                    return;
                LaySoCan();
            }
        }

        private void ExportNAV()
        {
            DataTable dt = new DataTable();
            using (DBACOMEntities db = new DBACOMEntities())
            {
                try
                {
                    var f = db.tblConfigLinkSync.Where(c => c.Value == "EX_PHIEUCANCAU").Select(p => p.Description).First();
                    if (f == null)
                    {
                        XtraMessageBox.Show("Không tìm thấy đường dẫn export", "Thông báo");
                    }
                    else
                    {
                        Ngay = Convert.ToDateTime(dtpNgayxuat.uValue);
                        _LenhSanXuat = cboLSX.uEditValue.ToString();

                        //Khởi tạo WeightNote
                        DM_Location lc = db.DM_Location.Where(c => c.Status == true).FirstOrDefault();
                        _LocationCode = lc.Code;
                        _LocationName = lc.LocationName;

                        Random RAN = new Random();
                        string abc = cnn.GetDateServer().ToString("ddMMyyHHmmss");
                        int bcd = RAN.Next(100000, 999999);
                        string result = "";

                        //Load ID Phiếu xuất
                        var y = db.DM_PhieuXuat.Where(id => id.PostingDate == Ngay.Date && id.ContractNo == _LenhSanXuat).First();
                        int _ID = Convert.ToInt32(y.ID);

                        //Update lại WeightNote cho DM_PhieuXuat                        
                        var x = db.DM_PhieuXuat.Where(id => id.PostingDate == Ngay.Date && id.ContractNo == _LenhSanXuat && id.WeightNote != "").ToList();
                        if (x.Count == 0)
                        {
                            result = _LocationCode + "-" + abc.ToString() + "-" + bcd.ToString();
                            DM_PhieuXuat px = db.DM_PhieuXuat.Where(c => c.ID == _ID).First();
                            px.WeightNote = result;
                            db.SaveChanges();
                        }
                        else
                        {
                            result = x[0].WeightNote;
                        }

                        for (int i = 0; i < gridView_DaCan.RowCount; i++)
                        {
                            if (gridView_DaCan.GetRowCellValue(i, "Chon").ToString() == "True")
                            {
                                string QR = gridView_DaCan.GetRowCellValue(i, "QRCode").ToString();

                                //Update lại WeightNote cho Chi tiết xuất kho
                                {
                                    WH_ChiTietXuatKho ctx = db.WH_ChiTietXuatKho.Where(p => p.QRCode == QR && p.IDPhieuXuat == _ID).First();
                                    ctx.WeightNote = result;
                                    db.SaveChanges();
                                }

                                //Update tồn kho
                                {
                                    WH_TonKho tk = db.WH_TonKho.Where(c => c.QRCode == QR).FirstOrDefault();
                                    tk.Exported = true;
                                    db.SaveChanges();
                                    decimal TLCan = Convert.ToDecimal(gridView_DaCan.GetRowCellValue(i, "GrossWeight"));
                                    decimal TLTruBi = Convert.ToDecimal(gridView_DaCan.GetRowCellValue(i, "TotalPackageQty"));
                                    decimal QRQty = Math.Round((decimal)TLCan - TLTruBi, 2);
                                    _Vitri = gridView_DaCan.GetRowCellValue(i, "BinCode").ToString();
                                    _Lot = gridView_DaCan.GetRowCellValue(i, "Lot").ToString();
                                    var Thamso = new Dictionary<String, String>() { { "Lot", _Lot }, { "BinCode", _Vitri }, { "Nhap", "0" }, { "Xuat", QRQty.ToString() } };
                                    cnn.SQL_ExecuteStoredProcedure("SP_TonKhoTucThoi", Thamso);
                                }
                            }
                        }

                        //Load lại thông tin chứng từ
                        var list = db.WH_ChiTietXuatKho.Where(c => c.IDPhieuXuat == _ID).ToList();
                        gridDaCan.DataSource = list;
                        cnn.clearControl(groupbox);
                        //Export Nav
                        {
                            SaveFileDialog filename = new SaveFileDialog();
                            filename.FileName = f;
                            var Thamso = new Dictionary<String, String>() { { "ID", _ID.ToString() } };
                            dt = cnn.SQL_GetStoredProcedure("SP_ExportNAV_SX", Thamso);
                            dt.Columns.Add("Chuoi");
                            foreach (DataRow dr in dt.Rows)
                            {
                                dr["Chuoi"] =
                                "\"" + dr["WeightNote"] + "\";" +
                                "\"" + Convert.ToDateTime(dr["Date"]).ToString("dd/MM/yyyy") + "\";" +
                                "\"" + dr["VendorNo"] + "\";" +
                                "\"" + dr["ItemNo"] + "\";" +
                                "\"" + dr["Code"] + "\";" +
                                "\"" + dr["LocationName"] + "\";" +
                                "\"" + dr["Vehicle"] + "\";" +
                                "\"" + Convert.ToInt32(dr["GrossWeight"]) + "\";" +
                                "\"" + Convert.ToInt32(dr["TruckTare"]) + "\";" +
                                "\"" + Convert.ToInt32(dr["NetWeight"]) + "\";" +
                                "\"" + Convert.ToInt32(dr["TruckQty"]) + "\";" +
                                "\"" + dr["TotalBagWeight"] + "\";" +
                                "\"" + Convert.ToInt32(dr["QRCodeQty"]) + "\";" +
                                "\"" + dr["WeightType"] + "\";" +
                                "\"" + dr["TransportCode"] + "\"";
                            }
                            for (int i = dt.Columns.Count - 1; i >= 0; i--)
                            {
                                if (dt.Columns[i].ColumnName != "Chuoi")
                                    dt.Columns.RemoveAt(i);
                            }
                        }
                        new frmExport(dt, f, "txt").ShowDialog();
                    }
                }
                catch { }
            }
        }

        private void spnSoluong_uValueChanged(object sender, EventArgs e)
        {
            if (spnSoluong.uValue < 0)
            {
                spnSoluong.uValue = 0;
                XtraMessageBox.Show("Số bao không được âm", "Thông báo");
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

        private void LSX_Load()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                string _Ngay = Convert.ToDateTime(dtpNgay.uValue).ToString("yyyy-MM-dd");
                var thamso = new Dictionary<String, String>() { { "Ngay", _Ngay } };
                gridDSLSX.DataSource = cnn.SQL_GetStoredProcedure("SP_ListLSX", thamso);
            }
        }

        private void LSX_Chitiet(string LenhSanXuat)
        {
            if (LenhSanXuat != null)
            {
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    var ChuaHoanThanh = new Dictionary<String, String>() { { "DocumentNo", LenhSanXuat } };
                    grid_ChuaHoanThanh.DataSource = cnn.SQL_GetStoredProcedure("SP_LSX_ChuaHoanThanh", ChuaHoanThanh);

                    if (LenhSanXuat != "")
                    {
                        var Chitiet = db.WH_ChiTietXuatKho.Where(c => c.DocumentNo == LenhSanXuat).ToList();
                        gridDaCan.DataSource = Chitiet;
                    }
                }
            }
        }

        private void Load_cboLSX()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var LSX = db.Chitiet_LenhSanXuat.OrderByDescending(c => c.PostingDate).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("BatchNo");
                dt.Columns.Add("ItemNo");
                dt.Columns.Add("Note");
                dt = ConvertToDataTable(LSX);
                cboLSX.uDataSource = dt;
            }
        }

        private void Load_cboMaSanPham()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var SP = db.tblItems.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ItemNo");
                dt.Columns.Add("ItemName");
                dt = ConvertToDataTable(SP);
                cboMaSanPham.uDataSource = dt;
            }
        }

        private void Load_cboLot()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Lot = db.DM_Lot.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Lot");
                dt.Columns.Add("CropYear");
                dt = ConvertToDataTable(Lot);
                cboLot.uDataSource = dt;
            }
        }

        private void Load_cboLocation()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Location = db.DM_Location.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Code");
                dt.Columns.Add("LocationName");
                dt = ConvertToDataTable(Location);
                cboLocation.uDataSource = dt;
            }
        }

        private void Load_cboQuicach()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Packing = db.DM_Packing.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("PackageCode");
                dt.Columns.Add("PackageDesc");
                dt = ConvertToDataTable(Packing);
                cboQuicach.uDataSource = dt;
            }
        }

        private void Load_cboCer()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Cer = db.DM_Certificate.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Ten");
                dt = ConvertToDataTable(Cer);
                cboCer.uDataSource = dt;
            }
        }

        private void Load_cboVitri()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Vt = db.DM_Pile.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("BinCode");
                dt = ConvertToDataTable(Vt);
                cboVitri.uDataSource = dt;
            }
        }

        private void Load_cboLoai()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Loai = db.DM_LoaiBao.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Loai");
                dt = ConvertToDataTable(Loai);
                cboLoai.uDataSource = dt;
            }
        }

        private void Form_Load()
        {
            groupbox.Select();
            dtpNgayxuat.uValue =cnn.GetDateServer();

            LSX_Load();

            Load_cboLSX();
            Load_cboCer();
            Load_cboLoai();
            Load_cboLocation();
            Load_cboLot();
            Load_cboMaSanPham();
            Load_cboQuicach();
            Load_cboVitri();

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnCantrubi.Enabled = false;
            
            griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_CapNhatLSX_Danhsach");
            grid_NoiBo.DataSource = cnn.SQL_GetStoredProcedure("SP_HangNoiBo");
        }

        private void dtpNgay_uEditValueChanged(object sender, EventArgs e)
        {
            LSX_Load();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            if (gridView2.RowCount > 0)
            {
                LSX_Chitiet(gridView2.GetFocusedRowCellValue("BatchNo").ToString());
                cboLSX.uEditValue = gridView2.GetFocusedRowCellValue("BatchNo").ToString();
                spnID_LSX.uValue = 0;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnCantrubi.Enabled = false;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView_ChuaHoanThanh.RowCount > 0)
            {
                if (gridView_ChuaHoanThanh.GetFocusedRowCellValue("TrangThai").ToString().ToLower() != "hoàn thành")
                {
                    griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_CapNhatLSX_Danhsach");
                    spnTrangthaican.uValue = 0;
                    cboLSX.uEditValue = gridView_ChuaHoanThanh.GetFocusedRowCellValue("BatchNo").ToString();
                    cboMaSanPham.uEditValue = gridView_ChuaHoanThanh.GetFocusedRowCellValue("ItemNo").ToString();
                    _MaSanPham = cboMaSanPham.uEditValue.ToString();
                    if (cnn.sNull2String(gridView_ChuaHoanThanh.GetFocusedRowCellValue("Lot")) != "")
                    {
                        cboLot.uEditValue = gridView_ChuaHoanThanh.GetFocusedRowCellValue("Lot").ToString();
                    }
                    else
                    {
                        cnn.clearControl(cboLot);
                    }
                    spnTLYeuCau.uValue = Convert.ToDecimal(gridView_ChuaHoanThanh.GetFocusedRowCellValue("Quantity"));
                    cboLocation.uEditValue = gridView_ChuaHoanThanh.GetFocusedRowCellValue("LocationCode").ToString();
                    if (cnn.sNull2String(gridView_ChuaHoanThanh.GetFocusedRowCellValue("BinCode")) != "" &&
                        gridView_ChuaHoanThanh.GetFocusedRowCellValue("BinCode").ToString().ToLower() != " chuaxacdinh")
                    {
                        cboVitri.uEditValue = gridView_ChuaHoanThanh.GetFocusedRowCellValue("BinCode").ToString();
                    }
                    else
                    {
                        cnn.clearControl(cboVitri);
                    }

                    LineNo = Convert.ToInt32(gridView_ChuaHoanThanh.GetFocusedRowCellValue("ID"));
                    spnID_LSX.uValue = LineNo;
                    cnn.clearControl(txtQRCode);
                    txtQRCode.Focus();

                    spnTLDaCan.uValue = Convert.ToInt32(gridView_ChuaHoanThanh.GetFocusedRowCellValue("DaCan"));

                    using (DBACOMEntities db = new DBACOMEntities())
                    {
                        var sh = db.ChiTietSoanHang.Where(c => c.IDBatchDetail == LineNo && c.DocumentType.ToLower() == "processing").ToList();
                        if (sh.Count > 0)
                        {
                            gridDaSoan.DataSource = sh;
                        }
                    }

                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    btnCantrubi.Enabled = true;
                    btnXuatNoiBo.Enabled = true;
                }
                else
                {
                    cnn.clearControl(cboLocation);
                    cnn.clearControl(cboVitri);
                    cnn.clearControl(cboQuicach);
                    cnn.clearControl(cboCer);
                    cnn.clearControl(cboLoai);
                    cnn.clearControl(cboLot);
                    cnn.clearControl(txtQRCode);
                    cnn.clearControl(cboMaSanPham);
                    spnTLCan.uValue = 0;
                    spnTrangthaican.uValue = 0;
                    cboLSX.Focus();
                    XtraMessageBox.Show("Dữ liệu đã hoàn thành, không thể chỉnh sửa", "Thông báo");
                }
            }
        }

        private void txtCode_uKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cnn.clearControl(groupbox);
            dtpNgayxuat.uValue = cnn.GetDateServer();
        }

        private void frmSanXuat_Load(object sender, EventArgs e)
        {
            dtpNgay.uValue = cnn.GetDateServer();
            dtpNgayxuat.uValue = cnn.GetDateServer();
            spnID.uValue = __ID;
            Form_Load();
            LSX_Chitiet(Chungtu);
            dtpNgayxuat.uValue = Convert.ToDateTime(dtpNgayxuat.uValue);
            btnHoanThanh.Enabled = false;

            for (int i = 0; i < gridView_NoiBo.Columns.Count; i++)
            {
                gridView_NoiBo.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
        }

        private bool Check_QRCode()
        {
            if (!cnn.bComboIsNull(cboLSX))
            {
                _LenhSanXuat = cboLSX.uEditValue.ToString();
                string QRCode = txtQRCode.uText;
                _MaSanPham = cboMaSanPham.uEditValue.ToString();
                _Vitri = cboVitri.uEditValue.ToString();
                _Lot = cboLot.uEditValue.ToString();
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    DataTable dt1 = new DataTable();
                    if (!cnn.bComboIsNull(cboLot))
                    {
                        var qr = db.WH_TonKho.Where(p => p.QRCode == QRCode && p.Exported == false && p.ItemNo == _MaSanPham && p.Lot == _Lot).ToList();
                        dt1 = ConvertToDataTable(qr);
                    }
                    else
                    {
                        var qr = db.WH_TonKho.Where(p => p.QRCode == QRCode && p.Exported == false && p.ItemNo == _MaSanPham).ToList();
                        dt1 = ConvertToDataTable(qr);
                    }
                    if (dt1.Rows.Count > 0)
                    {
                        var q = db.WH_TonKho.Where(c => c.QRCode == QRCode).ToArray();
                        cboLot.uEditValue = q[0].Lot;
                        cboVitri.uEditValue = q[0].BinCode;
                        cboQuicach.uEditValue = q[0].PackageCode;
                        cboCer.uEditValue = q[0].Certificate;
                        cboLoai.uEditValue = q[0].PackageType;

                        _Vitri = cboVitri.uEditValue.ToString();
                        _Lot = cboLot.uEditValue.ToString();

                        var Thamso = new Dictionary<String, String>() { { "DocumentNo", _LenhSanXuat }, { "ItemNo", _MaSanPham }, { "IDLenhSanXuat", spnID_LSX.uValue.ToString() } };
                        DataTable dt = new DataTable();
                        dt.Columns.Add("QRCodeQty");
                        dt = cnn.SQL_GetStoredProcedure("SP_CheckSoanHang", Thamso);
                        int DaSoan = Convert.ToInt32(dt.Rows[0][0]);
                        if (DaSoan > spnTLYeuCau.uValue)
                        {
                            XtraMessageBox.Show("Lưu ý: Trọng lượng đã cân vượt quá yêu cầu \n Yêu cầu: " + spnTLYeuCau.uValue.ToString() + "\n Đã cân: " + DaSoan.ToString(), "Thông báo");
                            spnTLTruBi.Focus();
                        }
                    }
                    else
                    {
                        cboLSX.Focus();
                        XtraMessageBox.Show("Mã QRCode không hợp lệ \n Vui lòng kiểm tra lại Sản phẩm, Lot yêu cầu", "Thông báo");
                        return false;
                    }
                    var sample = db.WH_TonKho.Where(c => c.QRCode == txtQRCode.uText).ToList();
                    if (sample.Count == 0)
                    {
                        cboLSX.Focus();
                        XtraMessageBox.Show("Mã QR Code không hợp lệ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cnn.clearControl(txtQRCode);
                        return false;
                    }
                    else if (sample[0].Sample.ToString() == "True")
                    {
                        cboLSX.Focus();
                        XtraMessageBox.Show("Hàng sample không thể xuất", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cnn.clearControl(txtQRCode);
                        return false;
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn Lệnh sản xuất", "Thông báo");
                groupbox.Select();
                return false;
            }
            return true;
        }

        private void spnTLTruBi_uValueChanged(object sender, EventArgs e)
        {
            if (spnTLTruBi.uValue < 0)
            {
                spnTLTruBi.uValue = 0;
                XtraMessageBox.Show("Trọng lượng trừ bì không được âm", "Thông báo");
            }
        }

        private void gridView_Chitiet_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private bool Check()
        {
            if (spnID_LSX.uValue == 0)
            {
                XtraMessageBox.Show("Vui lòng chọn Lệnh sản xuất", "Thông báo");
                return false;
            }            
            int dem = 0;
            for (int i = 0; i < gridView_Chitiet.DataRowCount; i ++)
            {
                if (gridView_Chitiet.GetRowCellValue(i, "Chon").ToString() == "True" &&
                    gridView_Chitiet.GetRowCellValue(i, "ItemNo").ToString() == cboMaSanPham.uEditValue.ToString())
                {
                    dem++;
                }
            }
            if (dem == 0)
            {
                XtraMessageBox.Show("Chưa chọn Phiếu cân hoặc Sản phẩm không đúng", "Thông báo");
                return false;
            }
            return true;
        }

        private void bt_CapNhat_LSX_Click(object sender, EventArgs e)
        {
            if (!Check())
                return;
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn Cập nhật LSX cho các phiếu cân đã chọn?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                for (int i =0; i < gridView_Chitiet.DataRowCount; i ++)
                {
                    if (gridView_Chitiet.GetRowCellValue(i, "Chon").ToString() == "True")
                    {
                        string W = gridView_Chitiet.GetRowCellValue(i, "WeightNote").ToString();
                        string ID_LSX = spnID_LSX.uValue.ToString();
                        string LSX = cboLSX.uEditValue.ToString();
                        var Thamso = new Dictionary<String, String>() { { "WeightNote", W}, { "ID_LSX", ID_LSX }, { "LSX", LSX } };
                        cnn.SQL_ExecuteStoredProcedure("SP_CapNhatLSX_Update", Thamso);
                    }
                }
                cnn.clearControl(cboLocation);
                cnn.clearControl(cboVitri);
                cnn.clearControl(cboQuicach);
                cnn.clearControl(cboCer);
                cnn.clearControl(cboLoai);
                cnn.clearControl(cboLot);
                cnn.clearControl(txtQRCode);
                spnTLCan.uValue = 0;
                spnTrangthaican.uValue = 0;
                griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_CapNhatLSX_Danhsach");
                XtraMessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
            }
        }

        private void gridView_ChuaHoanThanh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView_ChuaHoanThanh.OptionsSelection.MultiSelect = true;
                gridView_ChuaHoanThanh.SelectAll();
            }
        }

        private void gridView_DaCan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView_DaCan.OptionsSelection.MultiSelect = true;
                gridView_DaCan.SelectAll();
            }
        }

        private void gridView_Chitiet_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView_Chitiet.OptionsSelection.MultiSelect = true;
                gridView_Chitiet.SelectAll();
            }
        }

        public void LaySoCan()
        {
            if (chkNhanDuLieu.Checked == true)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                spnTLCan.uValue = 0;
                spnSoluong.uValue = 0;
                DataTable dt = new DataTable();
                if (txtQRCode.uText.Trim().Length > 0)
                {
                    var thamso = new Dictionary<String, String>() { { "QRCode", txtQRCode.uText } };
                    dt = cnn.SQL_GetStoredProcedure("SP_BarCode_Info_ThuaKeCan", thamso);
                    if (dt.Rows.Count > 0)
                    {
                        spnTLCan.uValue = Convert.ToInt32(dt.Rows[0]["QRCodeQty"]);
                        spnSoluong.uValue = Convert.ToInt32(dt.Rows[0]["TruckQty"]);
                        spnTLTruBi.uValue = 0;
                    }
                }
            }
        }

        private void chkNhanDuLieu_CheckedChanged(object sender, EventArgs e)
        {
            LaySoCan();
        }

        private bool Check_Soanhang()
        {
            string QRCode = txtQRCode.uText;
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var sh = db.ChiTietSoanHang.Where(c => c.QRCode == QRCode && c.IDBatchDetail == spnID_LSX.uValue).ToList();
                if (sh.Count == 0)
                {
                    XtraMessageBox.Show("Mã QR Code không hợp lệ hoặc chưa phát sinh soạn hàng", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cnn.clearControl(txtQRCode);
                    return false;
                }
            }
            return true;
        }


        private bool Check_Cond()
        {
            if (cnn.bComboIsNull(cboLSX))
            {
                XtraMessageBox.Show("Bạn chưa nhập Lệnh sản xuất", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupbox.Select();
                return false;
            }
            if (cnn.sNull2Int(spnID_LSX.uValue) == 0)
            {
                XtraMessageBox.Show("Vui lòng Double click vào dòng muốn cân", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupbox.Select();
                return false;
            }
            if (txtQRCode.uText.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập mã QR Code", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQRCode.SelectAll();
                return false;
            }
            using (DBACOMEntities db = new DBACOMEntities())
            {
                _LenhSanXuat = cboLSX.uEditValue.ToString();
                var list = db.DM_LenhSanXuat.Where(c => c.BatchNo == _LenhSanXuat).ToList();
                if (list.Count == 0)
                {
                    XtraMessageBox.Show("Lệnh sản xuất không hợp lệ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    groupbox.Select();
                    return false;
                }
                var list_2 = db.WH_ChiTietXuatKho.Where(c => c.DocumentNo == _LenhSanXuat && c.WeightNote != "" && c.IDLenhSanXuat == spnID_LSX.uValue && c.IDPhieuXuat == spnID.uValue).ToList();
                if (list_2.Count > 0)
                {
                    XtraMessageBox.Show("Lệnh sản xuất đã được Export NAV, không thể tiếp tục", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    groupbox.Select();
                    return false;
                }
                var sample = db.WH_TonKho.Where(c => c.QRCode == txtQRCode.uText).ToList();
                if (sample.Count == 0)
                {
                    XtraMessageBox.Show("Mã QR Code không hợp lệ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQRCode.SelectAll();
                    return false;
                }
                else if (sample[0].Sample.ToString() == "True")
                {
                    XtraMessageBox.Show("Hàng sample không thể xuất", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQRCode.SelectAll();
                    return false;
                }
            }
            if (spnTLCan.uValue == 0)
            {
                XtraMessageBox.Show("Chưa có Số liệu cân", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQRCode.Focus();
                return false;
            }
            if (spnSoluong.uValue == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập số bao của QRCode", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spnSoluong.Focus();
                return false;
            }
            return true;
        }

        public void PhieuXuatKhac(decimal TrongLuong)
        {
            if (TrongLuong != 0)
            {
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    //Khởi tạo WeightNote
                    DM_Location lc = db.DM_Location.Where(c => c.Status == true).FirstOrDefault();
                    _LocationCode = lc.Code;
                    _LocationName = lc.LocationName;

                    string QR = txtQRCode.uText;
                    _LenhSanXuat = cboLSX.uEditValue.ToString();
                    Ngay = Convert.ToDateTime(dtpNgayxuat.uValue);
                    LineNo = Convert.ToInt32(spnID_LSX.uValue);

                    var Thongtin = db.WH_TonKho.Where(c => c.QRCode == QR).ToList();
                    _Lot        = Thongtin[0].Lot;
                    _Vitri      = Thongtin[0].BinCode;
                    _Cer        = Thongtin[0].Certificate;
                    _MaSanPham  = Thongtin[0].ItemNo;
                    _Loai       = Thongtin[0].PackageType;
                    _QuiCach    = Thongtin[0].PackageCode;

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
                        QRCode = txtQRCode.uText,
                        QRCodeQty = TrongLuong,
                        Lot = _Lot,
                        Certificate = _Cer,
                        BinCode = _Vitri,
                        PackageType = _Loai,
                        GrossWeight = TrongLuong,
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
                        LoaiXuat = "8",
                        UserName = Properties.Settings.Default.USER_NAME,
                        CreateDate = cnn.GetDateServer()
                    });
                    db.SaveChanges();
                    cnn.ExecuteNonQuery("UPDATE WH_Tonkho Set Exported = 1 WHERE QRCode  = '" + txtQRCode.uText + "'");
                }
            }
        }


        private void Luu()
        {
            if (!cnn.bComboIsNull(cboLSX))
            {
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    DM_Location lc = db.DM_Location.Where(c => c.Status == true).FirstOrDefault();
                    _LocationCode = lc.Code;
                    _LocationName = lc.LocationName;

                    string QR = txtQRCode.uText;
                    _LenhSanXuat = cboLSX.uEditValue.ToString();
                    Ngay = Convert.ToDateTime(dtpNgayxuat.uValue);
                    LineNo = Convert.ToInt32(spnID_LSX.uValue);
                    
                    var list = db.WH_TonKho.Where(c => c.QRCode == QR).ToList();
                    _Lot = list[0].Lot;
                    _Vitri = list[0].BinCode;
                    _Cer = list[0].Certificate;
                    _MaSanPham = list[0].ItemNo;
                    _Loai = list[0].PackageType;
                    _QuiCach = list[0].PackageCode;

                    var q = db.WH_ChiTietXuatKho.Where(c => c.IDLenhSanXuat == LineNo && c.Date == Ngay.Date).ToList();
                    if (q.Count == 0)
                    {
                        db.DM_PhieuXuat.Add(new DM_PhieuXuat
                        {
                            PostingDate = Ngay,
                            WeightNote = "",
                            Lot = _Lot,
                            BinCode = _Vitri,
                            UserName = Properties.Settings.Default.USER_NAME,
                            Type = "Processing",
                            ContractNo = _LenhSanXuat,
                            ID_LenhSX = LineNo,
                            Del = false
                        });
                        db.SaveChanges();
                    }
                    {
                        _Ca = cnn.Shift();

                        spnID.uValue = Convert.ToInt32((from id in db.DM_PhieuXuat where id.PostingDate == Ngay.Date && id.ContractNo == _LenhSanXuat && id.ID_LenhSX == LineNo select id.ID).Take(1).FirstOrDefault());
                        var p = db.WH_ChiTietXuatKho.Where(c => c.QRCode == QR && c.DocumentNo == _LenhSanXuat && c.IDLenhSanXuat == LineNo).ToList();
                        if (p.Count == 0)
                        {
                            decimal QRQty = Math.Round((decimal)spnTLCan.uEditValue - spnTLTruBi.uValue, 2);
                            int ID = Convert.ToInt32(spnID.uValue);

                            //Lưu Log
                            string sql = "INSERT INTO tblHisXuatKho (WeightNote, DocumentNo, Date, ItemNo, QRCode, QRCodeQty, Lot, Certificate, BinCode, PackageType, GrossWeight, TruckQty, PackageQty, TotalPackageQty, PackageCode, Note, Type, IDPhieuXuat, LocationCode, IDLenhSanXuat, LocationName, Thoigian, Ca, LoaiXuat, UserName) VALUES (" +
                                            " '', " +
                                            " '" + cboLSX.uEditValue.ToString().Replace("'", "''") + "', " +
                                            " '" + Convert.ToDateTime(dtpNgayxuat.uValue).ToString("yyyy-MM-dd") + "', " +
                                            " '" + _MaSanPham.Replace("'", "''") + "', " +
                                            " '" + txtQRCode.uText + "', " +
                                            " '" + QRQty + "', " +
                                            " '" + _Lot.Replace("'", "''") + "', " +
                                            " '" + _Cer.Replace("'", "''") + "', " +
                                            " '" + _Vitri.Replace("'", "''") + "', " +
                                            " '" + _Loai.Replace("'", "''") + "', " +
                                            " '" + Convert.ToDecimal(spnTLCan.uValue) + "', " +
                                            " '" + spnSoluong.uValue + "', " +
                                            " '" + 0 + "', " +
                                            " '" + Convert.ToDecimal(spnTLTruBi.uValue) + "', " +
                                            " '" + _QuiCach.Replace("'", "''") + "', " +
                                            " '" + txtGhichu.uText.Replace("'", "''") + "', " +
                                            " '" + "Processing" + "', " +
                                            " '" + ID + "', " +
                                            " '" + _LocationCode + "', " +
                                            " '" + Convert.ToInt32(spnID_LSX.uValue) + "', " +                                            
                                            " '" + _LocationName + "_PRODUCTION" + "', " +
                                            " '" + cnn.GetDateServer().TimeOfDay + "', " +
                                            " '" + _Ca + "', " +
                                            " '" + txtLoaiCan.uText + "', '" + Properties.Settings.Default.USER_NAME + "')";
                            cnn.ExecuteNonQuery(sql);

                            db.WH_ChiTietXuatKho.Add(new WH_ChiTietXuatKho
                            {
                                WeightNote = "",
                                DocumentNo = cboLSX.uEditValue.ToString(),
                                Date = Convert.ToDateTime(dtpNgayxuat.uValue),
                                ItemNo = _MaSanPham,
                                QRCode = txtQRCode.uText,
                                QRCodeQty = QRQty,
                                Lot = _Lot,
                                Certificate = _Cer,
                                BinCode = _Vitri,
                                PackageType = _Loai,
                                GrossWeight = Convert.ToDecimal(spnTLCan.uValue),
                                TruckQty = spnSoluong.uValue,
                                PackageQty = 0,
                                TotalPackageQty = Convert.ToDecimal(spnTLTruBi.uValue),
                                PackageCode = _QuiCach,
                                Note = txtGhichu.uText,
                                Type = "Processing",
                                IDPhieuXuat = ID,
                                IDLenhSanXuat = Convert.ToInt32(spnID_LSX.uValue),
                                LocationCode = _LocationCode,
                                LocationName = _LocationName + "_PRODUCTION",
                                Thoigian = cnn.GetDateServer().TimeOfDay,
                                Ca = _Ca,
                                LoaiXuat = txtLoaiCan.uText,
                                Del = false,
                                UserName = Properties.Settings.Default.USER_NAME,
                                CreateDate = cnn.GetDateServer()
                            });
                            if (db.SaveChanges() > 0)
                            {
                                WH_TonKho tk = db.WH_TonKho.Where(c => c.QRCode == QR).FirstOrDefault();
                                tk.Exported = true;
                                db.SaveChanges();

                                if (TLCu > 0)
                                {
                                    PhieuXuatKhac(Math.Round(TLCu - QRQty, 2));
                                }

                                LSX_Chitiet(cboLSX.uEditValue.ToString());
                                cnn.clearControl(cboLocation);
                                cnn.clearControl(cboVitri);
                                cnn.clearControl(cboQuicach);
                                cnn.clearControl(cboCer);
                                cnn.clearControl(cboLoai);
                                cnn.clearControl(cboLot);
                                cnn.clearControl(txtQRCode);
                                spnTLCan.uValue = 0;
                                spnTrangthaican.uValue = 0;
                                cboLSX.Focus();
                                XtraMessageBox.Show("Cập nhật danh sách thành công", "Thông báo");
                            }
                        }
                        else
                        {
                            cboLSX.Focus();
                            XtraMessageBox.Show("Mã QRCode đã được sử dụng", "Thông báo");
                            cnn.clearControl(txtQRCode);
                        }
                    }
                }
            }
        }

        private void _Update()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                string QR = txtQRCode.uText;
                _LenhSanXuat = cboLSX.uEditValue.ToString();
                LineNo = Convert.ToInt32(spnID_LSX.uValue);

                var gr = db.WH_ChiTietXuatKho.Where(c => c.QRCode == QR).ToList();
                WH_ChiTietXuatKho ctx = db.WH_ChiTietXuatKho.Where(p => p.QRCode == QR).First();
                ctx.QRCodeQty = Math.Round((decimal)gr[0].GrossWeight - spnTLTruBi.uValue, 2);
                ctx.TotalPackageQty = spnTLTruBi.uValue;

                if (TLCu > 0)
                {
                    PhieuXuatKhac(spnTLTruBi.uValue);
                    //Lưu Log
                    string sql = "INSERT INTO tblHisXuatKho (WeightNote, DocumentNo, Date, ItemNo, QRCode, QRCodeQty, Lot, Certificate, BinCode, PackageType, GrossWeight, TruckQty, PackageQty, TotalPackageQty, PackageCode, Note, Type, IDPhieuXuat, LocationCode, IDLenhSanXuat, LocationName, Thoigian, Ca, LoaiXuat, UserName) VALUES (" +
                                    " '', " +
                                    " '" + cboLSX.uEditValue.ToString().Replace("'", "''") + "', " +
                                    " '" + Convert.ToDateTime(dtpNgayxuat.uValue).ToString("yyyy-MM-dd") + "', " +
                                    " '" + _MaSanPham.Replace("'", "''") + "', " +
                                    " '" + txtQRCode.uText + "', " +
                                    " '" + Math.Round((decimal)gr[0].GrossWeight - spnTLTruBi.uValue, 2) + "', " +
                                    " '" + _Lot.Replace("'", "''") + "', " +
                                    " '" + _Cer.Replace("'", "''") + "', " +
                                    " '" + _Vitri.Replace("'", "''") + "', " +
                                    " '" + _Loai.Replace("'", "''") + "', " +
                                    " '" + Convert.ToDecimal(spnTLCan.uValue) + "', " +
                                    " '" + spnSoluong.uValue + "', " +
                                    " '" + 0 + "', " +
                                    " '" + Convert.ToDecimal(spnTLTruBi.uValue) + "', " +
                                    " '" + _QuiCach.Replace("'", "''") + "', " +
                                    " '" + txtGhichu.uText.Replace("'", "''") + "', " +
                                    " '" + "Processing" + "', " +
                                    " '" + 0 + "', " +
                                    " '" + _LocationCode + "', " +
                                    " '" + Convert.ToInt32(spnID_LSX.uValue) + "', " +
                                    " '" + _LocationName + "_PRODUCTION" + "', " +
                                    " '" + cnn.GetDateServer().TimeOfDay + "', " +
                                    " '" + _Ca + "', " +
                                    " '" + txtLoaiCan.uText + "', '" + Properties.Settings.Default.USER_NAME + "')";
                    cnn.ExecuteNonQuery(sql);
                }
                if (db.SaveChanges() > 0)
                {
                    LSX_Chitiet(cboLSX.uEditValue.ToString());
                }
                XtraMessageBox.Show("Cập nhật Trọng lượng trừ bì thành công", "Thông báo");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (txtQRCode.uText.Trim().Length > 0)
            {
                dt = cnn.DT_DataTable("SELECT QRCodeQty FROM WH_TonKho WHERE QRCode = '" + txtQRCode.uText + "'");
                TLCu = Convert.ToInt32(dt.Rows[0]["QRCodeQty"]);
            }
            if (spnTrangthaican.uValue == 0)
            {
                if (!Check_QRCode())
                    return;
                if (!Check_Cond())
                    return;
                if (!Check_Soanhang())
                    return;
                txtLoaiCan.uText = "";
                Luu();
            }
            else if (spnTrangthaican.uValue == 1)
            {
                _Update();
            }
            spnSoluong.uValue = 0;
        }


        private void btnXuatNoiBo_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn Lưu?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataTable dt = new DataTable();
                if (txtQRCode.uText.Trim().Length > 0)
                {
                    dt = cnn.DT_DataTable("SELECT QRCodeQty FROM WH_TonKho WHERE QRCode = '" + txtQRCode.uText + "'");
                    TLCu = Convert.ToInt32(dt.Rows[0]["QRCodeQty"]);
                }

                if (spnTrangthaican.uValue == 0)
                {
                    txtLoaiCan.uText = "NoiBo";
                    if (!Check_QRCode())
                        return;
                    if (!Check_Cond())
                        return;
                    Luu();
                }
                else if (spnTrangthaican.uValue == 1)
                {
                    _Update();
                }
                spnSoluong.uValue = 0;
            }
        }

        private void btnCantrubi_Click(object sender, EventArgs e)
        {
            spnTrangthaican.uValue = 1;
            chkNhanDuLieu.Checked = true;
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (DBACOMEntities db = new DBACOMEntities())
            {
                try
                {
                    for (int i = 0; i < gridView_ChuaHoanThanh.RowCount; i++)
                    {
                        if (gridView_ChuaHoanThanh.GetRowCellValue(i, "Chon").ToString() == "True")
                        {
                            Ngay = Convert.ToDateTime(gridView_ChuaHoanThanh.GetRowCellValue(i, "PostingDate"));
                            _LenhSanXuat = gridView_ChuaHoanThanh.GetRowCellValue(i, "BatchNo").ToString();
                            LineNo = Convert.ToInt32(gridView_ChuaHoanThanh.GetRowCellValue(i, "ID"));
                        }
                    }

                    //Khởi tạo WeightNote
                    DM_Location lc = db.DM_Location.Where(c => c.Status == true).FirstOrDefault();
                    _LocationCode = lc.Code;
                    _LocationName = lc.LocationName;
                    var LSX = db.WH_ChiTietXuatKho.Where(c => c.IDLenhSanXuat == LineNo && c.DocumentNo == _LenhSanXuat).ToList();
                    for (int a = 0; a < LSX.Count; a++)
                    {
                        ID_PhieuXuat = Convert.ToInt32(LSX[a].IDPhieuXuat);
                        Random RAN = new Random();
                        string abc = cnn.GetDateServer().ToString("ddMMyyHHmmss");
                        int bcd = RAN.Next(100000, 999999);
                        string result = result = _LocationCode + "-" + abc.ToString() + "-" + bcd.ToString();

                        //Update lại WeightNote cho DM_PhieuXuat 
                        var Update_WeightNote = new Dictionary<String, String>() { { "WeightNote", result }, { "ID_PhieuXuat", ID_PhieuXuat.ToString() } };
                        cnn.SQL_ExecuteStoredProcedure("SP_UpDate_WeightNote_SX", Update_WeightNote);

                        var list = db.WH_ChiTietXuatKho.Where(c => c.IDLenhSanXuat == LineNo && c.IDPhieuXuat == ID_PhieuXuat).ToList();

                        for (int i = 0; i < list.Count; i++)
                        {
                            string QR = list[i].QRCode;

                            //Update lại WeightNote cho Chi tiết xuất kho
                            {
                                WH_ChiTietXuatKho ctx = db.WH_ChiTietXuatKho.Where(p => p.QRCode == QR && p.IDLenhSanXuat == LineNo).First();
                                ctx.WeightNote = result;
                                db.SaveChanges();
                            }

                            //Update tồn kho
                            {
                                WH_TonKho tk = db.WH_TonKho.Where(c => c.QRCode == QR).FirstOrDefault();
                                tk.Exported = true;
                                db.SaveChanges();
                                decimal TLCan = Convert.ToDecimal(list[i].GrossWeight);
                                decimal TLTruBi = Convert.ToDecimal(list[i].TotalPackageQty);
                                decimal QRQty = Math.Round((decimal)TLCan - TLTruBi, 2);
                                _Vitri = list[i].BinCode;
                                _Lot = list[i].Lot;
                                //var Thamso = new Dictionary<String, String>() { { "Lot", _Lot }, { "BinCode", _Vitri }, { "Nhap", "0" }, { "Xuat", QRQty.ToString() } };
                                //cnn.SQL_ExecuteStoredProcedure("SP_TonKhoTucThoi", Thamso);
                            }
                        }
                    }
                    LSX_Chitiet(_LenhSanXuat);
                    btnHoanThanh.Enabled = false;
                    XtraMessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                   
                }
                catch { }
            }
        }

        private void repositoryItemCheckEdit2_EditValueChanged(object sender, EventArgs e)
        {
            gridView_ChuaHoanThanh.PostEditor();
            using (DBACOMEntities db = new DBACOMEntities())
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Chon");
                for (int i = 0; i < gridView_ChuaHoanThanh.RowCount; i++)
                {
                    _ID = Convert.ToInt32(gridView_ChuaHoanThanh.GetRowCellValue(i, "ID"));
                    var list = db.WH_ChiTietXuatKho.Where(c => c.IDLenhSanXuat == _ID && c.WeightNote == "").ToList();
                    if (gridView_ChuaHoanThanh.GetRowCellValue(i, "Chon").ToString() == "True" &&
                        Convert.ToInt32(gridView_ChuaHoanThanh.GetRowCellValue(i, "DaCan")) > 0 &&
                        list.Count > 0)
                    {
                        dt.Rows.Add(gridView_ChuaHoanThanh.GetRowCellValue(i, "Chon").ToString());
                    }
                }
                if (dt.Rows.Count == 1)
                {
                    btnHoanThanh.Enabled = true;
                }
                else
                {
                    btnHoanThanh.Enabled = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random RAN = new Random();
            if (spnTrangthaican.uValue == 0)
            {
                spnTLCan.uValue = RAN.Next(1000, 1500);
            }
            else
            {
                spnTLTruBi.uValue = RAN.Next(5, 20);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (spnTrangthaican.uValue == 0)
            {
                spnTLCan.uValue = frmMain.SoCanBan;
            }
            else if (spnTrangthaican.uValue == 1)
            {
                spnTLTruBi.uValue = frmMain.SoCanBan;
            }
        }

        private void cboLSX_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboLSX();
        }

        private void cboQuicach_uEditValueChanged(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboQuicach))
            {
                _QuiCach = cboQuicach.uEditValue.ToString();
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    var list = db.DM_Packing.Where(c => c.PackageCode == _QuiCach).ToList();
                    spnTLTruBi.uValue = Convert.ToDecimal(list[0].PackageQty);
                    if (list[0].PackageType == "BIGBAG")
                    {
                        spnSoluong.uValue = 1;
                    }
                    else
                    {
                        spnSoluong.uValue = 0;
                    }
                }
            }
            else
            {
                spnTLTruBi.uValue = 0;
                spnSoluong.uValue = 0;
            }
        }

        private void cboLSX_uEditValueChanged(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cboLSX))
            {
                panel1.Enabled = false;
            }
            else
            {
                panel1.Enabled = true;
                LSX_Chitiet(cboLSX.uEditValue.ToString());
            }
        }


        private void gridView_NoiBo_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }


        private void chkCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheckAll.Checked == true)
            {
                for (int i = 0; i < gridView_NoiBo.RowCount; i++)
                {
                    gridView_NoiBo.SetRowCellValue(i, "Chon", true);
                }
            }
            else
            {
                for (int i = 0; i < gridView_NoiBo.RowCount; i++)
                {
                    gridView_NoiBo.SetRowCellValue(i, "Chon", false);
                }
            }
        }


        private void btnNhapXuatNB_Click(object sender, EventArgs e)
        {

            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn Lưu?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                spnTrangthaican.uValue = 0;
                txtLoaiCan.uText = "NoiBo";
                if (!cnn.bComboIsNull(cboLSX) && cnn.sNull2Int(spnID_LSX.uValue) > 0)
                {
                    using (DBACOMEntities db = new DBACOMEntities())
                    {
                        _LenhSanXuat = cboLSX.uEditValue.ToString();
                        var list = db.DM_LenhSanXuat.Where(c => c.BatchNo == _LenhSanXuat).ToList();
                        if (list.Count == 0)
                        {
                            XtraMessageBox.Show("Lệnh sản xuất không hợp lệ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            groupbox.Select(); return;
                        }                        
                        var list_2 = db.WH_ChiTietXuatKho.Where(c => c.DocumentNo == _LenhSanXuat && c.WeightNote != "" && c.IDLenhSanXuat == spnID_LSX.uValue && c.IDPhieuXuat == spnID.uValue).ToList();
                        if (list_2.Count > 0)
                        {
                            XtraMessageBox.Show("Lệnh sản xuất đã được Export NAV, không thể tiếp tục", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            groupbox.Select();
                            return;
                        }
                    }
                    for (int i = 0; i < gridView_NoiBo.RowCount; i ++)
                    { 
                        if (gridView_NoiBo.GetRowCellValue(i, "Chon").ToString() == "True")
                        {
                            
                                string QR = gridView_NoiBo.GetRowCellValue(i, "QRCode").ToString();

                            cnn.ExecuteNonQuery("UPDATE WH_ChiTietNhapKho SET Ca = ([dbo].[Get_Shift]()), Thoigian = GETDATE(), Date = GETDATE(), BinCode = 'TC' WHERE QRCode = '" + QR + "'");
                            cnn.ExecuteNonQuery("UPDATE WH_ChiTietNhapKho SET Certificate = 'NONE' WHERE QRCode = '" + QR + "' AND ISNULL(Certificate, '') = ''");
                            cnn.ExecuteNonQuery("UPDATE WH_TonKho SET BinCode = 'TC' WHERE QRCode = '" + QR + "'");
                            cnn.ExecuteNonQuery("UPDATE WH_TonKho SET Certificate = 'NONE' WHERE QRCode = '" + QR + "' AND ISNULL(Certificate, '') = ''");

                            using (DBACOMEntities db = new DBACOMEntities())
                            {
                                DM_Location lc = db.DM_Location.Where(c => c.Status == true).FirstOrDefault();
                                _LocationCode = lc.Code;
                                _LocationName = lc.LocationName;
                                
                                _LenhSanXuat = cboLSX.uEditValue.ToString();
                                Ngay = Convert.ToDateTime(dtpNgayxuat.uValue);
                                LineNo = Convert.ToInt32(spnID_LSX.uValue);

                                var list = db.WH_TonKho.Where(c => c.QRCode == QR).ToList();
                                _Lot = list[0].Lot;
                                _Vitri = list[0].BinCode;
                                _Cer = list[0].Certificate;
                                _MaSanPham = list[0].ItemNo;
                                _Loai = list[0].PackageType;
                                _QuiCach = list[0].PackageCode;

                                var q = db.WH_ChiTietXuatKho.Where(c => c.IDLenhSanXuat == LineNo && c.Date == Ngay.Date).ToList();
                                if (q.Count == 0)
                                {
                                    db.DM_PhieuXuat.Add(new DM_PhieuXuat
                                    {
                                        PostingDate = Ngay,
                                        WeightNote = "",
                                        Lot = _Lot,
                                        BinCode = _Vitri,
                                        UserName = Properties.Settings.Default.USER_NAME,
                                        Type = "Processing",
                                        ContractNo = _LenhSanXuat,
                                        ID_LenhSX = LineNo,
                                        Del = false
                                    });
                                    db.SaveChanges();
                                }
                                {
                                    _Ca = cnn.Shift();

                                    spnID.uValue = Convert.ToInt32((from id in db.DM_PhieuXuat where id.PostingDate == Ngay.Date && id.ContractNo == _LenhSanXuat && id.ID_LenhSX == LineNo select id.ID).Take(1).FirstOrDefault());
                                    var p = db.WH_ChiTietXuatKho.Where(c => c.QRCode == QR && c.DocumentNo == _LenhSanXuat && c.IDLenhSanXuat == LineNo).ToList();
                                    if (p.Count == 0)
                                    {
                                        int QRQty = Convert.ToInt32(gridView_NoiBo.GetRowCellValue(i, "QRCodeQty"));
                                        int SoBao = Convert.ToInt32(gridView_NoiBo.GetRowCellValue(i, "TruckQty"));
                                        int ID = Convert.ToInt32(spnID.uValue);
                                        db.WH_ChiTietXuatKho.Add(new WH_ChiTietXuatKho
                                        {
                                            WeightNote = "",
                                            DocumentNo = cboLSX.uEditValue.ToString(),
                                            Date = Convert.ToDateTime(dtpNgayxuat.uValue),
                                            ItemNo = _MaSanPham,
                                            QRCode = QR,
                                            QRCodeQty = QRQty,
                                            Lot = _Lot,
                                            Certificate = _Cer,
                                            BinCode = _Vitri,
                                            PackageType = _Loai,
                                            GrossWeight = QRQty,
                                            TruckQty = SoBao,
                                            PackageQty = 0,
                                            TotalPackageQty = 0,
                                            PackageCode = _QuiCach,
                                            Note = txtGhichu.uText,
                                            Type = "Processing",
                                            IDPhieuXuat = ID,
                                            IDLenhSanXuat = Convert.ToInt32(spnID_LSX.uValue),
                                            LocationCode = _LocationCode,
                                            LocationName = _LocationName + "_PRODUCTION",
                                            Thoigian = cnn.GetDateServer().TimeOfDay,
                                            Ca = _Ca,
                                            LoaiXuat = txtLoaiCan.uText,
                                            Del = false,
                                            UserName = Properties.Settings.Default.USER_NAME,
                                            CreateDate = cnn.GetDateServer()
                                        });
                                        if (db.SaveChanges() > 0)
                                        {
                                            WH_TonKho tk = db.WH_TonKho.Where(c => c.QRCode == QR).FirstOrDefault();
                                            tk.Exported = true;
                                            db.SaveChanges();
                                            
                                            cnn.clearControl(cboLocation);
                                            cnn.clearControl(cboVitri);
                                            cnn.clearControl(cboQuicach);
                                            cnn.clearControl(cboCer);
                                            cnn.clearControl(cboLoai);
                                            cnn.clearControl(cboLot);
                                            cnn.clearControl(txtQRCode);
                                            spnTLCan.uValue = 0;
                                            spnTrangthaican.uValue = 0;
                                            cboLSX.Focus();
                                        }
                                    }
                                    else
                                    {
                                        cboLSX.Focus();
                                        XtraMessageBox.Show("Mã QRCode đã được sử dụng", "Thông báo");
                                        cnn.clearControl(txtQRCode);
                                    }
                                }
                            }
                        }
                    }
                    grid_NoiBo.DataSource = cnn.SQL_GetStoredProcedure("SP_HangNoiBo");
                    LSX_Chitiet(cboLSX.uEditValue.ToString());
                    XtraMessageBox.Show("Đã cập nhật", "Thông báo");
                }                
                else
                {
                    Tab.SelectedTabPage = Tab1;
                    XtraMessageBox.Show("Bạn chưa chọn Lệnh sản xuất", "Thông báo");
                }
            }
        }
    }
}

