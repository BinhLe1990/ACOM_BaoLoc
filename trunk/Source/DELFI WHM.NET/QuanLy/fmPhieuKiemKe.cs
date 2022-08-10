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

namespace DELFI_WHM.NET.QuanLy
{
    public partial class fmPhieuKiemKe : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn_Offline; 
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string Tungay, Denngay, Ngay;
        string SoPhieuKiemKe, QRCode, ItemNo, BinCode, Lot, Cer, PackageCode, CropYear;
        int SoBao, New_SoBao, SoLot, SoCayHang, Check_QRCode;
        decimal TrongLuong, New_TrongLuong, New_TLTruBi, TLCan, Lot_Qty;
        string New_QRCode, New_ItemNo, New_BinCode, New_Lot, New_Cer, New_PackageCode, PackageType, New_CropYear;
        clsRun clRun = new clsRun();
        public fmPhieuKiemKe()
        {
            clRun.SetPermit(this);
            InitializeComponent();
            clRun.SetValueToControl(this); 
        }

        private void Search()
        {
            Tungay = Convert.ToDateTime(dtpTuNgay.uValue).ToString("yyyy-MM-dd");
            Denngay = Convert.ToDateTime(dtpDenNgay.uValue).ToString("yyyy-MM-dd");
            string sql = "SELECT CONVERT(Bit, 0) as Chon, * FROM DM_PhieuKiemKe WHERE Ngay BETWEEN '" + Tungay + "' AND '" + Denngay + "' AND Del = 0 ORDER BY Ngay DESC, SoPhieuKK DESC";
            griDanhSach.DataSource = cnn.DT_DataTable(sql);
            gridView_Danhsach.BestFitColumns();
            for (int i = 0; i < gridView_Danhsach.Columns.Count; i++)
            {
                gridView_Danhsach.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
        }

        private void Load_Data(string PhieuKiemKe)
        {
            string sql = "SELECT CONVERT(Bit, 0) as Chon, tbl.*, DM_Lot.CropYear as New_CropYear " +
                                                       " FROM (SELECT Chitiet_PhieuKK.*, DM_Lot.CropYear " +
                                                       "FROM Chitiet_PhieuKK " +
                                                       "LEFT JOIN DM_Lot ON DM_Lot.Lot = Chitiet_PhieuKK.Lot  " +
                                                       "WHERE SoPhieuKK = '" + PhieuKiemKe + "') as tbl " +
                                                       "LEFT JOIN DM_Lot ON DM_Lot.Lot = tbl.New_Lot";
            grid_Chitiet.DataSource = cnn.DT_DataTable(sql);
            gridView_Chitiet.BestFitColumns();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)griDanhSach.DataSource;
            dt.Columns.Add("Tungay");
            dt.Columns.Add("Denngay");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dr["Tungay"] = Convert.ToDateTime(dtpTuNgay.uValue).ToString("dd/MM/yyyy");
                    dr["Denngay"] = Convert.ToDateTime(dtpDenNgay.uValue).ToString("dd/MM/yyyy");
                }
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_PhieuCan.repx", dt);
                frm.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            spnTLCan.uValue = frmMain.SoCanBan;
        }

        private void cboLoaibaobi_uEditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!cnn.bComboIsNull(cboLoaibaobi))
                {
                    spnTLTruBi.uValue = Convert.ToInt32(cnn.DT_DataTable("SELECT TOP(1) PackageQty FROM DM_Packing WHERE PackageCode ='" + cboLoaibaobi.uEditValue + "'").Rows[0][0]);
                }
                else
                {
                    spnTLTruBi.uValue = 0;
                }
            }
            catch
            {
                spnTLTruBi.uValue = 0;
            }
        }

        private void chkCheckAll_EditValueChanged(object sender, EventArgs e)
        {
            if (gridView_Chitiet.RowCount > 0)
            {
                if (chkCheckAll.Checked == true)
                {
                    for (int i = 0; i< gridView_Chitiet.RowCount; i ++)
                    {
                        gridView_Chitiet.SetRowCellValue(i, "Chon", true);
                    }
                }
                else
                {
                    for (int i = 0; i < gridView_Chitiet.RowCount; i++)
                    {
                        gridView_Chitiet.SetRowCellValue(i, "Chon", false);
                    }
                }
            }
        }

        private void cboLotKK_uQueryPopUp(object sender, CancelEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cnn.DT_DataTable("SELECT Lot FROM DM_Lot");
            cboLotKK.uDataSource = dt;
        }

        private void cboBinCodeKK_uQueryPopUp(object sender, CancelEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cnn.DT_DataTable("SELECT BinCode FROM DM_Pile");
            cboBinCodeKK.uDataSource = dt;
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            cnn.clearControl(groupControl2);
            cnn.clearControl(groupControl3);
            Load_Data("");
            dtpNgay.uValue = cnn.GetDateServer();
        }

        private void btnDongBo_Click(object sender, EventArgs e)
        {
            cnn_Offline = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(".", Program.sUserName, Program.SPassword, "DBACOM_Offline");
            if (txtSoPhieu.uText != "")
            {
                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn Chuyển dữ liệu lên Server?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var Thamso = new Dictionary<String, String>() { { "SoPhieuKK", txtSoPhieu.uText } };

                    if (cnn.SQL_GetStoredProcedure("SP_KiemKe_CheckCanDoi", Thamso).Rows.Count > 0)
                    {
                        XtraMessageBox.Show("Phiếu kiểm kê đã phát sinh Cân đối, không thể chỉnh sửa", "Thông báo");
                    }
                    else
                    {
                        cnn.SQL_ExecuteStoredProcedure("SP_KiemKe_XoaPhieu", Thamso);
                        DataTable dt = new DataTable();
                        dt = cnn_Offline.DT_DataTable("SELECT * FROM Chitiet_PhieuKK WHERE SoPhieuKK = '" + txtSoPhieu.uText + "'");
                        cnn.SqlBulkCopy(dt, "Chitiet_PhieuKK");
                        Load_Data(txtSoPhieu.uText);
                        XtraMessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                    }
                }
            }
        }

        private void btnOffline_Click(object sender, EventArgs e)
        {
            cnn_Offline = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(".", Program.sUserName, Program.SPassword, "DBACOM_Offline");
            int dem = 0;
            string KK = "";
            for (int i = 0; i < gridView_Danhsach.RowCount; i ++)
            {
                if (gridView_Danhsach.GetRowCellValue(i, "Chon").ToString() == "True")
                {
                    DataTable dt = new DataTable();
                    dt = cnn_Offline.DT_DataTable("SELECT QRCode FROM Chitiet_PhieuKK WHERE SoPhieuKK = '" + gridView_Danhsach.GetRowCellValue(i, "SoPhieuKK").ToString() + "' AND (New_QRCodeQty > 0 OR New_Qty > 0) ");
                    if (dt.Rows.Count > 0)
                    {
                        KK = gridView_Danhsach.GetRowCellValue(i, "SoPhieuKK").ToString();
                    }
                }
            }
            if (KK != "")
            {
                XtraMessageBox.Show("Đã có phát sinh cho Phiếu kiểm kê " + KK + ", không thể chuyển sang Offline", "Thông báo");
            }
            else
            {
                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn Chuyển dữ liệu sang Offline?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Tungay = Convert.ToDateTime(dtpTuNgay.uValue).ToString("yyyy-MM-dd");
                    Denngay = Convert.ToDateTime(dtpDenNgay.uValue).ToString("yyyy-MM-dd");
                    cnn_Offline.SQL_ExecuteStoredProcedure("SP_Refresh");
                    {
                        DataTable dt = new DataTable();
                        dt = cnn.DT_DataTable("SELECT * FROM DM_Certificate");
                        cnn_Offline.SqlBulkCopy_Offline(dt, "DM_Certificate");
                    }
                    {
                        DataTable dt = new DataTable();
                        dt = cnn.DT_DataTable("SELECT * FROM DM_CropYear");
                        cnn_Offline.SqlBulkCopy_Offline(dt, "DM_CropYear");
                    }
                    {
                        DataTable dt = new DataTable();
                        dt = cnn.DT_DataTable("SELECT * FROM DM_LoaiBao");
                        cnn_Offline.SqlBulkCopy_Offline(dt, "DM_LoaiBao");
                    }
                    {
                        DataTable dt = new DataTable();
                        dt = cnn.DT_DataTable("SELECT * FROM DM_Location");
                        cnn_Offline.SqlBulkCopy_Offline(dt, "DM_Location");
                    }
                    {
                        DataTable dt = new DataTable();
                        dt = cnn.DT_DataTable("SELECT * FROM DM_Lot");
                        cnn_Offline.SqlBulkCopy_Offline(dt, "DM_Lot");
                    }
                    {
                        DataTable dt = new DataTable();
                        dt = cnn.DT_DataTable("SELECT * FROM DM_Packing");
                        cnn_Offline.SqlBulkCopy_Offline(dt, "DM_Packing");
                    }
                    {
                        DataTable dt = new DataTable();
                        dt = cnn.DT_DataTable("SELECT * FROM DM_Pile");
                        cnn_Offline.SqlBulkCopy_Offline(dt, "DM_Pile");
                    }
                    {
                        DataTable dt = new DataTable();
                        dt = cnn.DT_DataTable("SELECT * FROM HT_NGUOIDUNG");
                        cnn_Offline.SqlBulkCopy_Offline(dt, "HT_NGUOIDUNG");
                    }
                    {
                        DataTable dt = new DataTable();
                        dt = cnn.DT_DataTable("SELECT * FROM HT_QuyenHeThong");
                        cnn_Offline.SqlBulkCopy_Offline(dt, "HT_QuyenHeThong");
                    }
                    {
                        DataTable dt = new DataTable();
                        dt = cnn.DT_DataTable("SELECT * FROM tblConfigScales");
                        cnn_Offline.SqlBulkCopy_Offline(dt, "tblConfigScales");
                    }
                    {
                        DataTable dt = new DataTable();
                        dt = cnn.DT_DataTable("SELECT * FROM tblItems");
                        cnn_Offline.SqlBulkCopy_Offline(dt, "tblItems");
                    }
                    {
                        DataTable dt = new DataTable();
                        dt = cnn.DT_DataTable("SELECT * FROM WH_TonKho");
                        cnn_Offline.SqlBulkCopy_Offline(dt, "WH_TonKho");
                    }
                    for (int i = 0; i < gridView_Danhsach.RowCount; i++)
                    {
                        if (gridView_Danhsach.GetRowCellValue(i, "Chon").ToString() == "True")
                        {
                            KK = gridView_Danhsach.GetRowCellValue(i, "SoPhieuKK").ToString();
                            var Thamso = new Dictionary<String, String>() { { "SoPhieuKK", KK } };
                            cnn_Offline.SQL_ExecuteStoredProcedure("SP_Refresh_PKK", Thamso);
                            {
                                DataTable dt = new DataTable();
                                dt = cnn.DT_DataTable("SELECT * FROM DM_PhieuKiemKe WHERE SoPhieuKK = '" + KK + "'");
                                cnn_Offline.SqlBulkCopy_Offline(dt, "DM_PhieuKiemKe");
                            }
                            {
                                DataTable dt = new DataTable();
                                dt = cnn.DT_DataTable("SELECT * FROM Chitiet_PhieuKK WHERE SoPhieuKK = '" + KK + "'");
                                cnn_Offline.SqlBulkCopy_Offline(dt, "Chitiet_PhieuKK");
                            }
                        }
                    }
                    XtraMessageBox.Show("Chuyển dữ liệu thành công", "Thông báo");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtSoPhieu.uText.Length> 0)
            {
                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn Cập nhật lại phiếu kiểm kê?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    dt = cnn.DT_DataTable("SELECT QRCode FROM Chitiet_PhieuKK WHERE SoPhieuKK = '" + txtSoPhieu.uText + "' AND (New_QRCodeQty > 0 OR New_Qty > 0) ");
                    if (dt.Rows.Count == 0)
                    {
                        cnn.ExecuteNonQuery("DELETE FROM DM_PhieuKiemKe WHERE SoPhieuKK = '" + txtSoPhieu.uText + "'");
                        cnn.ExecuteNonQuery("DELETE FROM Chitiet_PhieuKK WHERE SoPhieuKK = '" + txtSoPhieu.uText + "' AND New_QRCodeQty = 0 AND New_Qty = 0 ");
                        TaoPhieu();
                    }
                    else
                    {
                        XtraMessageBox.Show("Đã có phát sinh cho Phiếu kiểm kê này, không thể sửa", "Thông báo");
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn phiếu kiểm kê trước");
            }
        }

        private void gridView_Danhsach_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i< gridView_Chitiet.RowCount; i ++)
            {
                if (gridView_Chitiet.GetRowCellValue(i, "Chon").ToString() == "True")
                    txtQRCode.uText = gridView_Chitiet.GetRowCellValue(i, "QRCode").ToString();
            }
            InTem();
        }
        DataTable d = new DataTable();

        private void gridView_Danhsach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView_Danhsach.OptionsSelection.MultiSelect = true;
                gridView_Danhsach.SelectAll();
            }
        }

        private void cboLot_QueryPopUp(object sender, CancelEventArgs e)
        {
            var Thamso_1 = new Dictionary<String, String>()
            {
                { "Ngay", Convert.ToDateTime(dtpNgay.uValue).ToString("yyyy-MM-dd")},
                { "BinCode", cboCheckList.EditValue.ToString() },
                { "ItemNo", cboSanpham.uEditValue.ToString() },
                { "Lot", "" },
                { "Type", "4" }
            };
            cboLot.Properties.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_TonKho", Thamso_1);
            cboLot.Properties.ValueMember = "Lot";
            cboLot.Properties.DisplayMember = "Lot";            
        }

        private void cboCheckList_QueryPopUp(object sender, CancelEventArgs e)
        {
            var Thamso_1 = new Dictionary<String, String>()
            {
                { "Ngay", Convert.ToDateTime(dtpNgay.uValue).ToString("yyyy-MM-dd")},
                { "BinCode", "" },
                { "ItemNo", cboSanpham.uEditValue.ToString() },
                { "Lot", "" },
                { "Type", "3" }
            };
            cboCheckList.Properties.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_TonKho", Thamso_1);
        }

        public void TaoPhieu()
        {
            //Tạo danh mục phiếu kiểm kê
            if (txtSoPhieu.uText == "")
            {
                dtpNgay.uValue = cnn.GetDateServer();
                txtSoPhieu.uText = cnn.SQL_GetStoredProcedure("SP_Create_PKK").Rows[0][0].ToString();
            }
            Lot = cnn.sNull2String(cboLot.EditValue).ToString();
            BinCode = cnn.sNull2String(cboCheckList.EditValue).ToString();
            New_Lot = cnn.sNull2String(cboLotKK.uEditValue).ToString();
            New_BinCode = cnn.sNull2String(cboBinCodeKK.uEditValue).ToString();
            New_Cer = cnn.sNull2String(cboChungNhanKK.uEditValue).ToString();

            var Thamso1 = new Dictionary<String, String>()
                    {
                        { "SoPhieuKK", txtSoPhieu.uText.ToString() },
                        { "Ngay", Convert.ToDateTime(dtpNgay.uValue).ToString("yyyy-MM-dd") },
                        { "Lot", Lot},
                        { "BinCode", BinCode},
                        { "ItemNo", cboSanpham.uEditValue.ToString()},
                        { "Ghichu", txtGhichu.uText.ToString()},
                        { "New_Lot", New_Lot},
                        { "New_BinCode", New_BinCode},
                        { "New_Cer", New_Cer}
                    };
            cnn.SQL_ExecuteStoredProcedure("SP_INSERT_PKK", Thamso1);

            var Thamso2 = new Dictionary<String, String>()
                    {
                        { "SoPhieuKK", txtSoPhieu.uText.ToString() },
                        { "Lot", cboLot.EditValue.ToString()},
                        { "BinCode", cboCheckList.EditValue.ToString()},
                        { "ItemNo", cboSanpham.uEditValue.ToString()}
                    };
            cnn.SQL_ExecuteStoredProcedure("SP_INSERT_List_KiemKe", Thamso2);
            //Lấy danh sách tồn kho tức thời                
            Load_Data(txtSoPhieu.uText);
            Search();
            XtraMessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
        }

        private void btnTaolist_Click(object sender, EventArgs e)
        {
            if (txtSoPhieu.uText != "")
            {
                XtraMessageBox.Show("Phiếu kiểm kê đã tồn tại, vui lòng chọn Thêm mới trước", "Thông báo");
            }
            else
            {
                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn Tạo danh sách kiểm kê?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    TaoPhieu();
                }
            }
        }

        private void gridView_Chitiet_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void cboSanpham_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.tblItems.ToList();
                cboSanpham.uDataSource = cnn.ConvertToDataTable(list);
            }
        }

        private void cboMaSanPham_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.tblItems.ToList();
                cboMaSanPham.uDataSource = cnn.ConvertToDataTable(list);
            }
        }

        private void cboMaLot_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.DM_Lot.ToList();
                cboMaLot.uDataSource = cnn.ConvertToDataTable(list);
            }
        }

        private void cboVitri_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.DM_Pile.ToList();
                cboVitri.uDataSource = cnn.ConvertToDataTable(list);
            }
        }

        private void cboCer_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.DM_Certificate.ToList();
                cboCer.uDataSource = cnn.ConvertToDataTable(list);
            }
        }

        private void fmPhieuKiemKe_Load(object sender, EventArgs e)
        {
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    {
                        var list = db.DM_Lot.ToList();
                        cboLot.Properties.DataSource = cnn.ConvertToDataTable(list);
                        cboLot.Properties.ValueMember = "Lot";
                        cboLot.Properties.DisplayMember = "Lot";
                        cboMaLot.uDataSource = cnn.ConvertToDataTable(list);

                        cboLotKK.uDataSource = cnn.ConvertToDataTable(list);
                    }
                    {
                        var list = db.tblItems.ToList();
                        cboSanpham.uDataSource = cnn.ConvertToDataTable(list);
                        cboMaSanPham.uDataSource = cnn.ConvertToDataTable(list);
                    }
                    {
                        var list = db.DM_Pile.ToList();
                        cboVitri.uDataSource = cnn.ConvertToDataTable(list);
                        cboCheckList.Properties.DataSource = cnn.ConvertToDataTable(list);
                        cboCheckList.Properties.ValueMember = "BinCode";
                        cboCheckList.Properties.DisplayMember = "BinCode";

                        cboBinCodeKK.uDataSource = cnn.ConvertToDataTable(list);
                    }
                    {
                        var list = db.DM_Certificate.ToList();
                        cboCer.uDataSource = cnn.ConvertToDataTable(list);

                        cboChungNhanKK.uDataSource = cnn.ConvertToDataTable(list);
                        cboChungNhanKK.uDisplayMember = "Ten";
                        cboChungNhanKK.uValueMember = "Ten";
                    }
                    {
                        var list = db.DM_Packing.ToList();
                        cboLoaibaobi.uDataSource = cnn.ConvertToDataTable(list);
                    }
                }            
            dtpTuNgay.uValue = cnn.GetDateServer();
            dtpDenNgay.uValue = cnn.GetDateServer();
            dtpNgay.uValue = cnn.GetDateServer();
            Search();
            timer1.Start();            
        }

        private void btnCandoi_Click(object sender, EventArgs e)
        {
            int dem = 0;

            for (int i = 0; i < gridView_Chitiet.DataRowCount; i ++)
            {
                if (gridView_Chitiet.GetRowCellValue(i, "Chon").ToString() == "True")
                {
                    dem++;
                }
            }
            if (dem == 0)
            {
                XtraMessageBox.Show("Vui lòng chọn dòng cần Cân đối trước", "Thông báo");
            }
            else
            {
                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn Cân đối lại kho theo danh sách đã chọn?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    for (int i = 0; i < gridView_Chitiet.DataRowCount; i++)
                    {
                        if (gridView_Chitiet.GetRowCellValue(i, "Chon").ToString() == "True" &&
                            gridView_Chitiet.GetRowCellValue(i, "CanDoi").ToString() == "False")
                        {
                            SoPhieuKiemKe = txtSoPhieu.uText;
                            Ngay = Convert.ToDateTime(dtpNgay.uValue).ToString("yyyy-MM-dd");

                            //Thông tin cũ
                            QRCode = gridView_Chitiet.GetRowCellValue(i, "QRCode").ToString();
                            ItemNo = gridView_Chitiet.GetRowCellValue(i, "ItemNo").ToString();
                            BinCode = gridView_Chitiet.GetRowCellValue(i, "BinCode").ToString();
                            Lot = gridView_Chitiet.GetRowCellValue(i, "Lot").ToString();
                            Cer = gridView_Chitiet.GetRowCellValue(i, "Cer").ToString();
                            PackageCode = gridView_Chitiet.GetRowCellValue(i, "PackageCode").ToString();
                            SoBao = Convert.ToInt32(gridView_Chitiet.GetRowCellValue(i, "Qty"));
                            TrongLuong = Convert.ToDecimal(gridView_Chitiet.GetRowCellValue(i, "QRCodeQty"));
                            Lot_Qty = Convert.ToDecimal(gridView_Chitiet.GetRowCellValue(i, "Lot_Qty"));
                            

                            //Thông tin mới
                            New_BinCode = gridView_Chitiet.GetRowCellValue(i, "New_BinCode").ToString();
                            New_Cer = gridView_Chitiet.GetRowCellValue(i, "New_Cer").ToString();
                            New_PackageCode = gridView_Chitiet.GetRowCellValue(i, "New_PackageCode").ToString();
                            New_Lot = gridView_Chitiet.GetRowCellValue(i, "New_Lot").ToString();
                            New_ItemNo = gridView_Chitiet.GetRowCellValue(i, "New_Item").ToString();
                            New_SoBao = Convert.ToInt32(gridView_Chitiet.GetRowCellValue(i, "New_Qty"));
                            New_TLTruBi = 0;
                            New_TrongLuong = Convert.ToDecimal(gridView_Chitiet.GetRowCellValue(i, "New_QRCodeQty"));
                            TLCan = New_TrongLuong + New_TLTruBi;
                            try
                            {
                                CropYear = cnn.DT_DataTable("SELECT CropYear FROM DM_Lot WHERE Lot = '" + Lot + "'").Rows[0][0].ToString();
                            }
                            catch { }

                            try
                            {
                                PackageType = cnn.DT_DataTable("SELECT PackageType FROM DM_Packing WHERE PackageCode = '" + New_PackageCode + "'").Rows[0][0].ToString();
                            }
                            catch { }

                            try
                            { 
                                New_CropYear = cnn.DT_DataTable("SELECT CropYear FROM DM_Lot WHERE Lot = '" + New_Lot + "'").Rows[0][0].ToString();
                            }
                            catch { }
                            
                            //Nếu không có QRCode thì làm Giảm kho theo Lot
                            if (QRCode == "")
                            {
                                using (DBACOMEntities db = new DBACOMEntities())
                                {
                                    //Khởi tạo WeightNote
                                    DM_Location lc = db.DM_Location.Where(c => c.Status == true).FirstOrDefault();
                                   string _LocationCode = lc.Code;
                                    string _LocationName = lc.LocationName;
                                    int _Ca = cnn.Shift();
                                    Random RAN = new Random();
                                    string abc = cnn.GetDateServer().ToString("ddMMyyHHmmss");
                                    int bcd = RAN.Next(1000, 9999);
                                    string Phieucan = _LocationCode + "-" + abc.ToString() + "-" + bcd.ToString();
                                    //Lưu danh mục xuất kho
                                    db.DM_PhieuXuat.Add(new DM_PhieuXuat
                                    {
                                        PostingDate = Convert.ToDateTime(dtpNgay.uValue),
                                        WeightNote = Phieucan,
                                        Lot = Lot,
                                        BinCode = BinCode,
                                        UserName = Properties.Settings.Default.USER_NAME,
                                        Type = "Other",
                                        ContractNo = "",
                                        ID_LenhSX = 0
                                    });
                                    db.SaveChanges();

                                    //Lưu chi tiết xuất kho
                                    var list = db.DM_PhieuXuat.Where(c => c.WeightNote == Phieucan).ToList();
                                    int ID = Convert.ToInt32(list[0].ID);
                                    db.WH_ChiTietXuatKho.Add(new WH_ChiTietXuatKho
                                    {
                                        WeightNote = Phieucan,
                                        DocumentNo = "",
                                        Date = Convert.ToDateTime(dtpNgay.uValue),
                                        ItemNo = ItemNo,
                                        QRCode = "",
                                        QRCodeQty = Lot_Qty,
                                        Lot = Lot,
                                        Certificate = Cer,
                                        BinCode = BinCode,
                                        PackageType = PackageType,
                                        GrossWeight = Lot_Qty,
                                        TruckQty = New_SoBao,
                                        PackageQty = 0,
                                        TotalPackageQty = 0,
                                        PackageCode = PackageCode,
                                        Note = "",
                                        Type = "Other",
                                        IDPhieuXuat = ID,
                                        IDLenhSanXuat = 0,
                                        LocationCode = _LocationCode,
                                        LocationName = _LocationName,
                                        Thoigian = cnn.GetDateServer().TimeOfDay,
                                        Ca = _Ca,
                                        LoaiXuat = "5",
                                        UserName = Properties.Settings.Default.USER_NAME,
                                        CreateDate = cnn.GetDateServer()
                                    });
                                    db.SaveChanges();
                                }
                            }

                            //Nếu chưa có QRCode thì phát sinh theo hình thức nhập khác
                          else  if (cnn.DT_DataTable("SELECT QRCode FROM WH_TonKho WHERE QRCode = '" + QRCode + "' GROUP BY QRCode").Rows.Count  == 0 && QRCode != "")
                            {
                                using (DBACOMEntities db = new DBACOMEntities())
                                {
                                    //Khởi tạo WeightNote
                                    DM_Location lc = db.DM_Location.Where(c => c.Status == true).FirstOrDefault();
                                    string  _LocationCode = lc.Code;

                                    Random RAN = new Random();
                                    string abc = cnn.GetDateServer().ToString("ddMMyyHHmmssf");
                                    int bcd = RAN.Next(1000, 9999);
                                    string SoPhieuCan = _LocationCode + "-" + abc.ToString() + "-" + bcd.ToString();                                   
                                    int _Ca = cnn.Shift();

                                    //Lưu danh mục nhập kho
                                    db.DM_PhieuNhap.Add(new DM_PhieuNhap
                                    {
                                        PostingDate = Convert.ToDateTime(Ngay),
                                        WeightNote = SoPhieuCan,
                                        VendorName = "",
                                        VendorCode = "",
                                        Lot = New_Lot,
                                        BinCode = New_BinCode,
                                        ContractNo = "",
                                        VehicleNo = "",
                                        UserName = Properties.Settings.Default.USER_NAME,
                                        Type = "Other",
                                        NetWeight = New_TrongLuong
                                    });
                                    db.SaveChanges();

                                    //Lưu chi tiết nhập kho                    
                                    var ch = db.DM_PhieuNhap.Where(c => c.WeightNote == SoPhieuCan).ToList();
                                    int ID = Convert.ToInt32(ch[0].ID);
                                    db.WH_ChiTietNhapKho.Add(new WH_ChiTietNhapKho
                                    {
                                        Document = SoPhieuCan,
                                        Date = Convert.ToDateTime(Ngay),
                                        QRCode = QRCode,
                                        ItemNo = New_ItemNo,
                                        Lot = New_Lot,
                                        Certificate = New_Cer,
                                        PackageType = PackageType,
                                        PackageCode = New_PackageCode,
                                        GrossWeight = TLCan,
                                        TruckQty = New_SoBao,
                                        PackageQty = 0,
                                        TotalPackageQty = New_TLTruBi,
                                        NetWeight = New_TrongLuong,
                                        QRCodeQty = New_TrongLuong,
                                        BinCode = New_BinCode,
                                        Note = "",
                                        Sample = false,
                                        Type = "Other",
                                        IDPhieuNhap = ID,
                                        Thoigian = cnn.GetDateServer().TimeOfDay,
                                        Ca = _Ca,
                                        CreateDate = cnn.GetDateServer(),
                                        UserName = Properties.Settings.Default.USER_NAME
                                    });
                                    if (db.SaveChanges() > 0)
                                    {
                                        //Lưu tồn kho
                                        db.WH_TonKho.Add(new WH_TonKho
                                        {
                                            QRCode = QRCode,
                                            ItemNo = New_ItemNo,
                                            Lot = New_Lot,
                                            Certificate = New_Cer,
                                            PackageType = PackageType,
                                            PackageCode = New_PackageCode,
                                            BinCode = New_BinCode,
                                            CropYear = New_CropYear,
                                            Sample = false,
                                            QRCodeQty = New_TrongLuong,
                                            Exported = false,
                                            TruckQty = New_SoBao
                                        });
                                        db.SaveChanges();
                                        //var Thamso = new Dictionary<String, String>() { { "Lot", New_Lot }, { "BinCode", New_BinCode }, { "Nhap", New_TrongLuong.ToString() }, { "Xuat", "0" } };
                                        //cnn.SQL_ExecuteStoredProcedure("SP_TonKhoTucThoi", Thamso);
                                    }
                                }
                            }

                            //Kiểm tra QRCode đã export hoặc có bị khóa không
                           else if (QRCode != "" && cnn.DT_DataTable("SELECT QRCode FROM WH_TonKho WHERE QRCode = '" + QRCode + "' AND Exported = 0").Rows.Count > 0 &&
                                cnn.DT_DataTable("SELECT QRCode FROM Chitiet_PhieuKK WHERE QRCode = '" + QRCode + "' AND SoPhieuKK = '" + SoPhieuKiemKe + "' AND CanDoi = 0").Rows.Count > 0)
                            {
                                //Cập nhật lại Trọng lượng, số bao -> Gọi store từ form Cân lại
                                if (TrongLuong != New_TrongLuong || SoBao != New_SoBao)
                                {
                                    var Up = new Dictionary<String, String>() { { "QRCode", QRCode},
                                                        { "TLCan", TLCan.ToString()},
                                                        { "TLTruBi", New_TLTruBi.ToString()},
                                                        { "SoBao", New_SoBao.ToString()},
                                                        { "UserName", Properties.Settings.Default.USER_NAME}};
                                    cnn.SQL_ExecuteStoredProcedure("SP_UPDATE_TLCan", Up);
                                }

                                //Cập nhật lại BinCode, Cer, Loại bao bì -> Gọi store từ form Cập nhật thông tin sản phẩm
                                if (BinCode != New_BinCode || Cer != New_Cer || PackageCode != New_PackageCode)
                                {
                                    var Up = new Dictionary<String, String>()
                                {
                                                        { "QRCode", QRCode },
                                                        { "Lot", Lot},
                                                        { "Cer", New_Cer},
                                                        { "PackageCode", New_PackageCode },
                                                        { "BinCode", New_BinCode},
                                                        { "Sample", false.ToString()},
                                                        { "GrossWeight", TLCan.ToString()},
                                                        { "TotalPackageQty", New_TLTruBi.ToString()},
                                                        { "QRCodeQty", New_TrongLuong.ToString() },
                                                        { "UserName", Properties.Settings.Default.USER_NAME}
                                };
                                    cnn.SQL_ExecuteStoredProcedure("SP_UPDATE_ThongTinSP", Up);
                                }

                                //Cập nhật lại sản phẩm, Lot
                                if (Lot != New_Lot || ItemNo != New_ItemNo)
                                {
                                    if (New_TrongLuong != 0 || New_SoBao != 0)
                                    {
                                        var Up = new Dictionary<String, String>()
                                {
                                                        { "QRCode", QRCode },
                                                        { "SoPhieuKK", txtSoPhieu.uText },
                                                        { "UserName", Properties.Settings.Default.USER_NAME}
                                };
                                        cnn.SQL_ExecuteStoredProcedure("SP_UPDATE_Lot", Up);
                                    }
                                }

                                //Nếu Trọng lượng = 0, Số bao = 0, và không thay đổi bất kỳ thông tin nào -> Khóa QRCode
                                if (QRCode != "" &&
                                    BinCode == New_BinCode &&
                                    Cer == New_Cer &&
                                    PackageCode == New_PackageCode &&
                                    ItemNo == New_ItemNo &&
                                    Lot == New_Lot &&
                                    New_TrongLuong == 0 && New_SoBao == 0)
                                {
                                    using (DBACOMEntities db = new DBACOMEntities())
                                    {
                                        var list = db.WH_TonKho.Where(c => c.QRCode == QRCode).ToList();
                                        if (list.Count > 0)
                                        {
                                            WH_TonKho tk = db.WH_TonKho.Where(c => c.QRCode == QRCode).FirstOrDefault();
                                            tk.Exported = true;
                                            db.SaveChanges();
                                        }
                                    }
                                }
                                gridView_Chitiet.SetRowCellValue(i, "CanDoi", true);
                            }
                            if (QRCode != "")
                            {
                                cnn.ExecuteNonQuery("UPDATE Chitiet_PhieuKK SET CanDoi = 1 WHERE QRCode = '" + QRCode + "' AND SoPhieuKK = '" + SoPhieuKiemKe + "'");
                            }
                        }                        
                    }
                    XtraMessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                }
            }
        }

        private void gridView_Danhsach_DoubleClick(object sender, EventArgs e)
        {
            cboCheckList.EditValue = gridView_Danhsach.GetFocusedRowCellValue("BinCode");
            string SoPhieuKK        = gridView_Danhsach.GetFocusedRowCellValue("SoPhieuKK").ToString();
            txtSoPhieu.uText        = SoPhieuKK;
            dtpNgay.uValue          = Convert.ToDateTime(gridView_Danhsach.GetFocusedRowCellValue("Ngay"));            
            cboLot.EditValue        = gridView_Danhsach.GetFocusedRowCellValue("Lot");
            cboSanpham.uEditValue   = gridView_Danhsach.GetFocusedRowCellValue("ItemNo");
            cboLotKK.uEditValue     = gridView_Danhsach.GetFocusedRowCellValue("New_Lot");
            cboBinCodeKK.uEditValue = gridView_Danhsach.GetFocusedRowCellValue("New_BinCode");
            cboChungNhanKK.uEditValue = gridView_Danhsach.GetFocusedRowCellValue("New_Cer");
            txtGhichu.uText         = gridView_Danhsach.GetFocusedRowCellValue("Ghichu").ToString();
            Load_Data(SoPhieuKK);
            Tab.SelectedTabPage     = Tab_Chitiet;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void InTem()
        {
            
            if (txtQRCode.uText != "")
            {                
                DataTable dt = new DataTable();
                var Thamso = new Dictionary<String, String>()
                    {
                        { "QRCode", txtQRCode.uText.ToString() },
                        { "SoPhieuKK", txtSoPhieu.uText.ToString()}
                    };
                dt = cnn.SQL_GetStoredProcedure("SP_InTem_KK", Thamso);
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\PhieuNhapTuSX.repx", dt, false);
                frm.Show();
            }
            else
            {
                XtraMessageBox.Show("Mã QRCode không được bỏ trống", "Thông báo");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            spnTaoMoiQRCode.uValue = 0;
            if (txtSoPhieu.uText == "")
            {
                XtraMessageBox.Show("Vui lòng chọn Phiếu kiểm kê trước", "Thông báo");
                return;
            } 
            else if (spnTLCan.uValue == 0)
            {
                spnTLCan.Focus();
                XtraMessageBox.Show("Chưa có Trọng lượng QRCode", "Thông báo");
                return;
            }
            else if (spnTLCan.uValue <= spnTLTruBi.uValue)
            {
                spnTLTruBi.Focus();
                XtraMessageBox.Show("Trọng lượng trừ bì không được lớn hơn hoặc bằng Trọng lượng QRCode", "Thông báo");
                return;
            }
            else if (spnSoluong.uValue == 0)
            {
                spnSoluong.Focus();
                XtraMessageBox.Show("Vui lòng nhập Số lượng bao", "Thông báo");
                return;
            } 
            else if (cnn.bComboIsNull(cboMaSanPham))
            {
                cboMaSanPham.Focus();
                XtraMessageBox.Show("Sản phẩm không được bỏ trống", "Thông báo");
                return;
            }
            else if (cnn.bComboIsNull(cboLotKK))
            {
                cboLotKK.Focus();
                XtraMessageBox.Show("Lot không được bỏ trống", "Thông báo");
                return;
            }
            else if (cnn.bComboIsNull(cboBinCodeKK))
            {
                cboBinCodeKK.Focus();
                XtraMessageBox.Show("Cây hàng không được bỏ trống", "Thông báo");
                return;
            }
            else if (cnn.bComboIsNull(cboLoaibaobi))
            {
                cboLoaibaobi.Focus();
                XtraMessageBox.Show("Loại bao bì không được bỏ trống", "Thông báo");
                return;
            }
            else
            {
                if (txtQRCode.uText.ToString() == "")
                {
                    spnTaoMoiQRCode.uValue = 1;
                    txtQRCode.uText = cnn.GetDateServer().ToString("yyyyMMddHHmmssffff");
                }
                if (cnn.bComboIsNull(cboChungNhanKK))
                {
                    cboChungNhanKK.uEditValue = "NONE";
                }

                var c = new Dictionary<String, String>()
                    {
                        { "QRCode", txtQRCode.uText },
                        { "SoPhieuKK", txtSoPhieu.uText}
                    };

                Check_QRCode = Convert.ToInt32(cnn.SQL_GetStoredProcedure("SP_KiemKe_CheckQRCode", c).Rows[0][0]);
                
                var Thamso = new Dictionary<String, String>()
                    {
                        { "SoPhieuKK", txtSoPhieu.uText.ToString() },
                        { "Ngay", Convert.ToDateTime(dtpNgay.uValue).ToString("yyyy-MM-dd")},
                        { "QRCode", txtQRCode.uText.ToString() },
                        { "TLHang", spnTLCan.uValue.ToString() },
                        { "TLTruBi", spnTLTruBi.uValue.ToString() },
                        { "SoBao", spnSoluong.uValue.ToString() },
                        { "Lot", cboLotKK.uEditValue.ToString()},
                        { "BinCode", cboBinCodeKK.uEditValue.ToString()},
                        { "ItemNo", cboMaSanPham.uEditValue.ToString()},
                        { "Cer", cboChungNhanKK.uEditValue.ToString()},
                        { "PackageCode", cboLoaibaobi.uEditValue.ToString()},
                        { "Ghichu", txtNote.uText.ToString()},
                        { "UserName", Properties.Settings.Default.USER_NAME.ToString()}
                    };
                if (Check_QRCode > 0)
                {
                    DialogResult result = XtraMessageBox.Show("QRCode này đã Kiểm kê, bạn có muốn Update lại?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        cnn.SQL_ExecuteStoredProcedure("SP_UPDATE_PKK", Thamso);
                        New_Lot = cboLotKK.uEditValue.ToString();
                        New_BinCode = cboBinCodeKK.uEditValue.ToString();
                        Load_Data(txtSoPhieu.uText);
                        InTem();
                        cnn.clearControl(groupControl3);
                        spnTaoMoiQRCode.uValue = 0;
                        XtraMessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                    }
                }
                else
                {
                    cnn.SQL_ExecuteStoredProcedure("SP_UPDATE_PKK", Thamso);
                    New_Lot = cboLotKK.uEditValue.ToString();
                    New_BinCode = cboBinCodeKK.uEditValue.ToString();
                    Load_Data(txtSoPhieu.uText);
                    InTem();
                    cnn.clearControl(groupControl3);
                    spnTaoMoiQRCode.uValue = 0;
                    XtraMessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                }
            }
        }

        private void cboLoaibaobi_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.DM_Packing.ToList();
                cboLoaibaobi.uDataSource = cnn.ConvertToDataTable(list);
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

        private void btn_TaoQRCode_Click(object sender, EventArgs e)
        {
            
        }

        private void txtQRCode_uKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                dt = cnn.DT_DataTable("SELECT * FROM Chitiet_PhieuKK WHERE SoPhieuKK = '" + txtSoPhieu.uText + "' AND QRCode = '" + txtQRCode.uText + "'");
                dt2 = cnn.DT_DataTable("SELECT TOP(1) * FROM WH_Tonkho WHERE QRCode  = '" + txtQRCode.uText + "' AND Exported = 0");
                if (dt.Rows.Count > 0)
                {
                    spnSoluong.uValue = Convert.ToInt32(dt.Rows[0]["Qty"]);
                    cboMaLot.uEditValue = dt.Rows[0]["Lot"].ToString();
                    cboVitri.uEditValue = dt.Rows[0]["BinCode"].ToString();
                    cboMaSanPham.uEditValue = dt.Rows[0]["ItemNo"].ToString();
                    cboCer.uEditValue = dt.Rows[0]["Cer"].ToString();
                    cboLoaibaobi.uEditValue = dt.Rows[0]["PackageCode"].ToString();
                }
                else if (dt2.Rows.Count > 0)
                {
                    DialogResult result = XtraMessageBox.Show("QRCode không nằm trong danh sách kiểm kê\nBạn có chắc chắn muốn thêm QRCode này vào danh sách?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        spnSoluong.uValue = Convert.ToInt32(dt2.Rows[0]["TruckQty"]);
                        cboMaLot.uEditValue = dt2.Rows[0]["Lot"].ToString();
                        cboVitri.uEditValue = dt2.Rows[0]["BinCode"].ToString();
                        cboMaSanPham.uEditValue = dt2.Rows[0]["ItemNo"].ToString();
                        cboCer.uEditValue = dt2.Rows[0]["Certificate"].ToString();
                        cboLoaibaobi.uEditValue = dt2.Rows[0]["PackageCode"].ToString();
                    }
                }
            }
        }
    }
}
