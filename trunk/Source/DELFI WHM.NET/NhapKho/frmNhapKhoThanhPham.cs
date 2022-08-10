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

namespace DELFI_WHM.NET.NhapKho
{
    public partial class frmNhapKhoThanhPham : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string _Loai = "";
        string _QuiCach = "";
        string _Vitri = "RECEIVING";
        string _Lot = "";
        string _Cer = "NONE";
        string _SoPhieu = "";
        string _MaSanPham = "";
        string _NhaVanChuyen = "";
        string _SoXe = "";
        string _MaKhachHang = "";
        string _TenKhachHang = "";
        DateTime _NgayTao;
        string Chungtu = "";
        string Tungay = "";
        string Denngay = "";
        string _QRCode = "";

        public frmNhapKhoThanhPham()
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

        private void Search()
        {
            Tungay = Convert.ToDateTime(dtpTungay.uValue).ToString("yyyy-MM-dd");
            Denngay = Convert.ToDateTime(dtpDenngay.uValue).ToString("yyyy-MM-dd");
            _SoPhieu = txtPhieucan.uText.Trim();
            var Thamso = new Dictionary<String, String>() { { "Tungay", Tungay }, { "Denngay", Denngay }, { "WeightNote", _SoPhieu } };
            griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_NhapTuNCC", Thamso);
        }

        private void frmNhapKhoThanhPham_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                gridView1.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }

            txtSoPhieuCan.uText = _SoPhieu;
            dtpTungay.uValue = cnn.GetDateServer();
            dtpDenngay.uValue = cnn.GetDateServer();
            Form_Load();
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
            {
                if (col.FieldName != gridView1.Columns["Chon"].FieldName)
                    col.OptionsColumn.AllowEdit = false;
            }
            groupControl.Focus();
            btnThemmoi.Enabled = false;
            btnLuu.Enabled = true;
            btnInthem.Enabled = false;
            spnInThem.Visible = false;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            txtQRCode.uText = gridView1.GetFocusedRowCellValue("QRCode").ToString();
            if (gridView1.GetFocusedRowCellValue("ItemNo") !=null)
            {
                cboMaSanPham.uEditValue = gridView1.GetFocusedRowCellValue("ItemNo").ToString();
            }            
            if (gridView1.GetFocusedRowCellValue("PackageType") != null)
            {
                txtLoaibao.uText = gridView1.GetFocusedRowCellValue("PackageType").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("PackageCode") != null)
            {
                cboQuiCach.uEditValue = gridView1.GetFocusedRowCellValue("PackageCode").ToString();
            }            
            if (gridView1.GetFocusedRowCellValue("Lot") != null)
            {
                cboLot.uEditValue = gridView1.GetFocusedRowCellValue("Lot").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("Certificate") != null)
            {
                cboCer.uEditValue = gridView1.GetFocusedRowCellValue("Certificate").ToString();
            }            
            spnTruckQty.uValue = Convert.ToInt32(gridView1.GetFocusedRowCellValue("TruckQty"));
            spnPackageQty.uValue = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("PackageQty"));
            if (gridView1.GetFocusedRowCellValue("BinCode") != null)
            {
                cboVitri.uEditValue = gridView1.GetFocusedRowCellValue("BinCode").ToString();
            }            
            
            chbHangmau.Checked = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("Sample"));
            using (DBACOMEntities db = new DBACOMEntities())
            {
                _SoPhieu = txtSoPhieuCan.uText;
                var data = db.DM_PhieuCanCau.Where(c => c.WeightNote == _SoPhieu).ToArray();
                if (data != null)
                {
                    cboNhaVanChuyen.uEditValue = data[0].TransporterCode;
                    cboKhachHang.uEditValue = data[0].VendorCode;
                    txtSoXe.uText = data[0].VehicleNo;
                    spnTLHangXe.uValue = Convert.ToDecimal(data[0].GrossWeight);
                    txtTrangThai.uText = data[0].WeightType;
                    txtContractNo.uText = data[0].ContractNo;
                }
            }
        }

        private void Form_Load()
        {
            cboNhaVanChuyen.uDataSource = cnn.dt_NhaVanChuyen();
            cboKhachHang.uDataSource = cnn.dt_KhachHang();

            txtQRCode.uText = "";
            Search();
        }

        private void cboMaSanPham_uEditValueChanged(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboMaSanPham))
            {
                _MaSanPham = cboMaSanPham.uEditValue.ToString();                
            }            
        }

        private void frmNhapKhoThanhPham_KeyUp(object sender, KeyEventArgs e)
        {           
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
                SendKeys.Send("{F4}");
            }
            if (e.KeyCode == Keys.F1)
            {
                btnThemmoi_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                btnLuu_Click(sender, e);
            }

        }

        private void cboQuiCach_uEditValueChanged(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboQuiCach))
            {
                DataTable dt = new DataTable();
                dt = cnn.dt_PackageCode_TimKiem(cboQuiCach.uEditValue.ToString());
                txtLoaibao.uText = dt.Rows[0]["PackageType"].ToString();
                spnPackageQty.uValue = Convert.ToDecimal(dt.Rows[0]["TLTruBi"]);
            }
        }

        private void txtLoaibao_uTextChanged(object sender, EventArgs e)
        {
            if (txtLoaibao.uText == "BIGBAG")
            {
                spnTruckQty.Enabled = false;
                spnTruckQty.uValue = spnSoLuong.uValue;
            }
            else
            {
                spnTruckQty.Enabled = true;
                spnTruckQty.uValue = 0;
            }
        }

        private void spnSoLuong_uValueChanged(object sender, EventArgs e)
        {
            if (spnSoLuong.uValue < 0)
            {
                XtraMessageBox.Show("Số lượng không được âm", "Thông báo");
            }
            else
            {
                if (txtLoaibao.uText == "BIGBAG")
                {
                    spnTruckQty.Enabled = false;
                    spnTruckQty.uValue = spnSoLuong.uValue;
                }
                else
                {
                    spnTruckQty.Enabled = true;
                    spnTruckQty.uValue = 0;
                }
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cnn.clearControl(groupControl);
            cnn.clearControl(groupBox_Thongtinxe);
        }

        public void Intem()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("QRCode");
            dt.Columns.Add("Date");
            dt.Columns.Add("ItemNo");
            dt.Columns.Add("Lot");
            dt.Columns.Add("BinCode");
            dt.Columns.Add("VendorName");
            dt.Columns.Add("VehicleNo");
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, "Chon").ToString() == "True")
                {
                    dt.Rows.Add(gridView1.GetRowCellValue(i, "QRCode"),
                                Convert.ToDateTime(gridView1.GetRowCellValue(i, "Date")).ToString("dd/MM/yyyy"),
                                gridView1.GetRowCellValue(i, "ItemNo").ToString().ToLower().Replace("chuaxacdinh", ""),
                                gridView1.GetRowCellValue(i, "Lot"),
                                gridView1.GetRowCellValue(i, "BinCode"),
                                gridView1.GetRowCellValue(i, "VendorName").ToString().ToLower().Replace("chưa xác định", ""),
                                gridView1.GetRowCellValue(i, "VehicleNo"));
                }
            }            
            BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\PhieuNhapKho.repx", dt);
            frm.Show();
        }

        private void btnInTem_Click(object sender, EventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                string _QR = txtCode.uText;
                var list = db.DM_PhieuCanCau.Where(c => c.WeightNote == _QR).ToList();
                var ArrayQRCode = db.DM_PhieuCanCau.Where(c => c.WeightNote == _QR).Select(p => p.ArrayQRCode).ToArray();
                string[] chuoi = ArrayQRCode[0].Split(',');
                DataTable dt = new DataTable();                
                dt.Columns.Add("Date");
                dt.Columns.Add("ItemNo").ToString().ToLower().Replace("chuaxacdinh", "");
                dt.Columns.Add("Lot");
                dt.Columns.Add("BinCode");
                dt.Columns.Add("VendorName").ToString().ToLower().Replace("chưa xác định", "");
                dt.Columns.Add("VehicleNo");
                dt.Columns.Add("QRCode");               
                foreach (string line in chuoi)
                {
                    dt.Rows.Add(Convert.ToDateTime(list[0].CreateDate).ToString("dd/MM/yyyy"),
                                list[0].ItemCode,
                                list[0].Lot,
                                list[0].BinCode,
                                list[0].VendorName,
                                list[0].VehicleNo,
                                line);
                }
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\PhieuNhapKho.repx", dt);
                frm.Show();
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
                        spnBag.uValue = Convert.ToInt32(qc[0].Bag);
                        if (cnn.bComboIsNull(cboMaSanPham))
                        {
                            cboMaSanPham.uEditValue = qc[0].ItemCode;
                        }
                    }
                }
            }
            else
            {
                txtCropYear.Text = "";
            }
        }

        private bool Check_Phieucan()
        {
            if (txtCode.Text.Trim() != "")
            {
                txtSoPhieuCan.uText = txtCode.uText;
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    var pc = db.DM_PhieuCanCau.Where(c => c.WeightNote == txtSoPhieuCan.uText && c.Del == false).FirstOrDefault();
                    if (pc != null)
                    {
                        var NK = db.DM_PhieuNhap.Where(c => c.WeightNote == txtSoPhieuCan.uText).ToList();
                        if (NK.Count == 0)
                        {
                            _SoPhieu = txtSoPhieuCan.uText;
                            var data = db.DM_PhieuCanCau.Where(c => c.WeightNote == _SoPhieu).ToList();
                            var ArrayQRCode = db.DM_PhieuCanCau.Where(c => c.WeightNote == _SoPhieu).Select(p => p.ArrayQRCode).ToList();
                            _QRCode = ArrayQRCode[0];
                            if (data.Count > 0 && _QRCode == "")
                            {
                                txtSoPhieuCan.Text = data[0].WeightNote;
                                if (cnn.bComboIsNull(cboMaSanPham))
                                {
                                    cboMaSanPham.uEditValue = data[0].ItemCode;
                                }
                                cboNhaVanChuyen.uEditValue = data[0].TransporterCode;
                                cboKhachHang.uEditValue = data[0].VendorCode;
                                txtSoXe.uText = data[0].VehicleNo;
                                spnTLHangXe.uValue = Convert.ToDecimal(data[0].GrossWeight);
                                txtTrangThai.uText = data[0].WeightType;
                                txtContractNo.uText = data[0].ContractNo;
                                cboLot.uEditValue = data[0].Lot;
                            }
                            else if (data.Count > 0 && _QRCode != "")
                            {
                                btnInthem.Enabled = true;
                                spnInThem.Visible = true;
                                btnLuu.Enabled = false;
                            }
                        }
                        if (NK.Count > 0)
                        {
                            XtraMessageBox.Show("Phiếu nhập đã tồn tại", "Thông báo");
                            groupControl.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Mã phiếu không tồn tại", "Thông báo");
                        groupControl.Focus();
                        return false;
                    }
                }
            }
            else
            {
                btnThemmoi.Enabled = true;
                btnLuu.Enabled = false;
                btnInthem.Enabled = false;
                spnInThem.Visible = false;
            }
            return true;
        }

        public bool Check_TrangThai_PhieuCan()
        {
            DataTable dt = new DataTable();
            dt = cnn.DT_DataTable("SELECT WeightType FROM DM_PhieuCanCau WHERE WeightNote = '" + txtCode.uText + "'");
            if (dt.Rows.Count == 0)
            {
                XtraMessageBox.Show("Không tìm thấy phiếu cân", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhieucan.Focus();
                return false;
            }
            else
            {
                string LoaiPhieu = dt.Rows[0]["WeightType"].ToString();
                if (LoaiPhieu == "Sale" || LoaiPhieu == "Ship")
                {
                    XtraMessageBox.Show("Vui lòng kiểm tra lại Loại phiếu", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhieucan.Focus();
                    return false;
                }
            }
            return true;
        }

        private void txtCode_uKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!Check_TrangThai_PhieuCan())
                    return;
                Load_cboCer();
                Load_cboMaSanPham();
                Load_cboQuiCach();
                Load_cboVitri();
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    var Lot = db.DM_Lot.ToList();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Lot");
                    dt.Columns.Add("CropYear");
                    dt = ConvertToDataTable(Lot);
                    cboLot.uDataSource = dt;
                }
                if (!Check_Phieucan())
                return;
            }
        }

        private bool Check_Cond()
        {
            if (Check_Phieucan() == false)
            {
                return false;
            }
            else
            {
                if (txtSoPhieuCan.uText.Trim() == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập Số phiếu cân", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    groupControl.Focus();
                    return false;
                }
                if (cnn.bComboIsNull(cboQuiCach))
                {
                    XtraMessageBox.Show("Bạn chưa chọn Loại bao bì", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCode.Focus();
                    return false;
                }
                if (cnn.bComboIsNull(cboMaSanPham))
                {
                    XtraMessageBox.Show("Bạn chưa chọn Sản phẩm", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboQuiCach.Focus();
                    return false;
                }
                if (spnSoLuong.uValue == 0)
                {
                    XtraMessageBox.Show("Bạn chưa nhập Số lượng", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaSanPham.Focus();
                    return false;
                }
                if (cnn.bComboIsNull(cboVitri))
                {
                    _Vitri = "RECEIVING";
                }
                if (cnn.bComboIsNull(cboLot))
                {
                    _Lot = "";
                }
                if (txtCode.Text.Trim() != "")
                {
                    txtSoPhieuCan.uText = txtCode.uText;
                    using (DBACOMEntities db = new DBACOMEntities())
                    {
                        var pc = db.DM_PhieuCanCau.Where(c => c.WeightNote == txtSoPhieuCan.uText).FirstOrDefault();
                        if (pc != null)
                        {
                            var NK = db.DM_PhieuCanCau.Where(c => c.WeightNote == txtSoPhieuCan.uText && c.SecondWeight > 0).FirstOrDefault();
                            if (NK != null)
                            {
                                XtraMessageBox.Show("Phiếu nhập đã tồn tại", "Thông báo");
                                return false;
                            }
                            var NK2 = db.DM_PhieuNhap.Where(c => c.WeightNote == txtSoPhieuCan.uText).FirstOrDefault();
                            if (NK2 != null)
                            {
                                XtraMessageBox.Show("Phiếu nhập đã tồn tại", "Thông báo");
                                return false;
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Mã phiếu không tồn tại", "Thông báo");
                            return false;
                        }
                    }
                }
                return true;
            }
        }

        private void Check()
        {            
            if (!cnn.bComboIsNull(cboQuiCach))
            {
                _QuiCach = cboQuiCach.uEditValue.ToString();
            }
            if (txtLoaibao.uText.Length > 0)
            {
                _Loai = txtLoaibao.uText;
            }
            else
            {
                _Loai = "";
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
            if (!cnn.bComboIsNull(cboKhachHang))
            {
                _MaKhachHang = cboKhachHang.uEditValue.ToString();
                _TenKhachHang = cboKhachHang.uText;
            }
            
        }

        private void Luu()
        {
            if (!Check_TrangThai_PhieuCan())
                return;
            if (!Check_Cond())
                return;            
            Check();
            using (DBACOMEntities db = new DBACOMEntities())
            {
                _SoPhieu = txtSoPhieuCan.uText;
                {
                    //Update thông tin phiếu cân cầu
                    DM_PhieuCanCau lc = db.DM_PhieuCanCau.Where(c => c.WeightNote == _SoPhieu).FirstOrDefault();
                    lc.ItemCode = _MaSanPham;
                    lc.TruckQty = spnTruckQty.uValue;
                    lc.PackageQty = spnPackageQty.uValue;
                    lc.TotalPackageQty = Math.Round((decimal)spnTruckQty.uValue * spnPackageQty.uValue, 2);
                    lc.PackageType = _Loai;
                    lc.BinCode = _Vitri;
                    if (db.SaveChanges() > 0)
                    {
                        string chuoi = "";
                        DataTable dt = new DataTable();
                        dt.Columns.Add("QRCode");
                        dt.Columns.Add("Date");
                        dt.Columns.Add("ItemNo");
                        dt.Columns.Add("Lot");
                        dt.Columns.Add("BinCode");
                        dt.Columns.Add("VendorName");
                        dt.Columns.Add("VehicleNo");
                        for (int i = 0; i < spnSoLuong.uValue; i++)
                        {
                            dt.Rows.Add(cnn.GetDateServer().ToString("yyyyMMddHHmmss") + (i + 1).ToString("000"),
                                        cnn.GetDateServer().ToString("dd/MM/yyyy"),
                                        _MaSanPham,
                                       _Lot,
                                       _Vitri,
                                       _TenKhachHang,
                                       txtSoXe.uText);
                        }
                        if (chkNhapDirect.Checked == false)
                        {
                            for (int i = 0; i < spnSoLuong.uValue - 1; i++)
                            {
                                chuoi += cnn.GetDateServer().ToString("yyyyMMddHHmmss") + (i + 1).ToString("000") + ",";

                            }
                            chuoi += cnn.GetDateServer().ToString("yyyyMMddHHmmss") + (spnSoLuong.uValue).ToString("000");
                        }
                        else
                        {
                            chuoi = "PROCESS";
                        }
                        lc.ArrayQRCode = chuoi;
                        lc.Certificate = _Cer;
                        lc.PackageCode = _QuiCach;
                        db.SaveChanges();
                        Form_Load();
                        XtraMessageBox.Show("Cập nhật thành công", "Thông báo");
                        cnn.clearControl(groupControl);
                        btnLuu.Enabled = false;
                        btnThemmoi.Enabled = true;
                        if (chkNhapDirect.Checked == false)
                        {
                            BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\PhieuNhapKho.repx", dt);
                            frm.Show();
                        }
                    }
                }
            }
        }

        private void Update()
        {
            Check();
            using (DBACOMEntities db = new DBACOMEntities())
            {
                WH_ChiTietNhapKho lc = db.WH_ChiTietNhapKho.Where(c => c.QRCode == txtQRCode.uText).FirstOrDefault();
                lc.BinCode = _Vitri;
                lc.Lot = _Lot;
                if (db.SaveChanges() > 0)
                {
                    WH_TonKho tk = db.WH_TonKho.Where(c => c.QRCode == txtQRCode.uText).FirstOrDefault();
                    tk.BinCode = _Vitri;
                    //tk.Lot = _Lot;
                    tk.CropYear = txtCropYear.uText;
                    db.SaveChanges();
                    Form_Load();
                    txtQRCode.uText = "";
                    XtraMessageBox.Show("Cập nhật danh sách thành công");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {  
                Luu();                     
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Search();            
        }

        private void repositoryItemCheckEdit1_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.PostEditor();
            DataTable dt = new DataTable();
            dt.Columns.Add("WeightNote");
            //Sửa, in phiếu, in tem
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.GetRowCellValue(i, "Chon").ToString() == "True")
                    {
                        dt.Rows.Add(gridView1.GetRowCellValue(i, "WeightNote").ToString());
                    }
                }
                if (dt.Rows.Count == 1)
                {
                    txtCode.uText = dt.Rows[0]["WeightNote"].ToString();
                    btnInthem.Enabled = false;
                    spnInThem.Visible = false;
                }
                else
                {
                    XtraMessageBox.Show("Mỗi lần chỉ in lại được 1 phiếu cân", "Thông báo");
                    txtCode.uText = "";
                }
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            cnn.clearControl(groupControl);
            btnThemmoi.Enabled = false;
            btnLuu.Enabled = true;            
        }

        private void btnInthem_Click(object sender, EventArgs e)
        {
            if (spnInThem.uValue <= 10)
            {
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    if (!Check_Phieucan())
                        return;
                    var _ArrayQRCode = db.DM_PhieuCanCau.Where(c => c.WeightNote == txtCode.uText).Select(p => p.ArrayQRCode).ToArray();
                    string[] _chuoi = _ArrayQRCode[0].Split(',');
                    int old_tem = _chuoi.Count();
                    var list = db.DM_PhieuCanCau.Where(c => c.WeightNote == txtCode.uText).ToList();
                    string chuoi = list[0].ArrayQRCode + ",";
                    for (int i = 1; i < spnInThem.uValue; i++)
                    {
                        chuoi += cnn.GetDateServer().ToString("yyyyMMddHHmmss") + (i + old_tem).ToString("000") + ",";

                    }
                    chuoi += cnn.GetDateServer().ToString("yyyyMMddHHmmss") + (spnInThem.uValue + old_tem).ToString("000");
                    DM_PhieuCanCau lc = db.DM_PhieuCanCau.Where(c => c.WeightNote == _SoPhieu).FirstOrDefault();
                    lc.ArrayQRCode = chuoi;
                    db.SaveChanges();
                    Form_Load();
                    XtraMessageBox.Show("Cập nhật thành công", "Thông báo");
                    cnn.clearControl(groupControl);
                    btnLuu.Enabled = false;
                    btnThemmoi.Enabled = true;

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Date");
                    dt.Columns.Add("ItemNo");
                    dt.Columns.Add("Lot");
                    dt.Columns.Add("BinCode");
                    dt.Columns.Add("VendorName");
                    dt.Columns.Add("VehicleNo");
                    dt.Columns.Add("QRCode");
                    for (int i = 1; i<= spnInThem.uValue; i++)
                    {
                        dt.Rows.Add(Convert.ToDateTime(list[0].CreateDate).ToString("dd/MM/yyyy"),
                                    list[0].ItemCode,
                                    list[0].Lot,
                                    list[0].BinCode,
                                    list[0].VendorName,
                                    list[0].VehicleNo,
                                    cnn.GetDateServer().ToString("yyyyMMddHHmmss") + (i + old_tem).ToString("000"));
                    }
                    BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\PhieuNhapKho.repx", dt);
                    frm.Show();
                }
            }
            else
            {
                XtraMessageBox.Show("Chỉ được in thêm 10 tem", "Thông báo");
            }
        }

        private void spnTruckQty_uValueChanged(object sender, EventArgs e)
        {
            if (spnTruckQty.uValue < 0)
            {
                XtraMessageBox.Show("Số lượng bao không được âm", "Thông báo");
            }
        }

        private void spnPackageQty_uValueChanged(object sender, EventArgs e)
        {
            if (spnPackageQty.uValue < 0)
            {
                XtraMessageBox.Show("Trọng lượng trừ bì không được âm", "Thông báo");
            }
        }

        private void Load_cboQuiCach()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.DM_Packing.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("PackageCode");
                dt = ConvertToDataTable(list);
                cboQuiCach.uDataSource = dt;
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

        private void Load_cboVitri()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Vitri = db.DM_Pile.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("BinCode");
                dt = ConvertToDataTable(Vitri);
                cboVitri.uDataSource = dt;
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

        private void cboQuiCach_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboQuiCach();
        }

        private void cboMaSanPham_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboMaSanPham();
        }

        private void cboVitri_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboVitri();
        }
        
        private void cboCer_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboCer();
        }

        private void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckEdit chk = (CheckEdit)sender;
                if (chk.Checked == true)
                {
                    txtCode.uText = gridView1.GetFocusedRowCellValue("WeightNote").ToString();
                    btnInthem.Enabled = false;
                    spnInThem.Visible = false;
                    for (int i = 0; i < gridView1.RowCount; i ++)
                    {
                        if (gridView1.GetRowCellValue(i, "WeightNote").ToString() != txtCode.uText)
                        {
                            gridView1.SetRowCellValue(i, "Chon", false);
                        }
                    }
                }
                else
                {
                    txtCode.uText = "";
                }
            }
            catch { }
        }

        private void txtCode_uTextChanged(object sender, EventArgs e)
        {
            if (txtCode.uText == "")
            {
                btnInthem.Enabled = false;
                spnInThem.Visible = false;
            }
        }
    }
}
