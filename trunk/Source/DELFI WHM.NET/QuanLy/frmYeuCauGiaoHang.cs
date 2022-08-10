using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DELFI_WHM.NET;
using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.QuanLy
{
    public partial class frmYeuCauGiaoHang : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        public frmYeuCauGiaoHang()
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
            this.Cursor = Cursors.WaitCursor;
            string Trangthai = cnn.sNull2String(cboTrangThai);
            DateTime Tungay = Convert.ToDateTime(dtpTuNgay.uValue).Date;
            DateTime Denngay = Convert.ToDateTime(dtpDenNgay.uValue).Date;
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var data = db.ChiTiet_LenhGiaoHang
                    .Where(c => c.SaleOrderCalNo.Contains(txtSO_Contract.Text) &&
                                c.Status.Contains(Trangthai) &&
                                c.PostingDate >= Tungay && c.PostingDate <= Denngay ||
                                c.SaleContractNo.Contains(txtSO_Contract.Text) &&
                                c.Status.Contains(Trangthai) &&
                                c.PostingDate >= Tungay && c.PostingDate <= Denngay).OrderByDescending(c => c.PostingDate).ToList();
                if (data != null)
                {
                    griDanhSach.DataSource = ConvertToDataTable(data);
                    for (int i =0; i < gridView1.Columns.Count; i ++)
                    {
                        if (gridView1.Columns[i].FieldName.ToString() != "Del")
                        {
                            gridView1.Columns[i].OptionsColumn.AllowEdit = false;
                        }
                    }
                }
            }
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                gridView1.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
            this.Cursor = Cursors.Default;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnDongBo_Click(object sender, EventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                this.Cursor = Cursors.WaitCursor;
                OpenFileDialog openFD = new OpenFileDialog();
                var link = db.tblConfigLinkSync.Where(c => c.Value.Equals("DM_LenhGiaoHang")).Select(p => p.Description).ToArray();
                string[] lines = cnn.Import_NAV(link[0]);
                foreach (string line in lines)
                {
                    if (line != "")
                    {
                        string[] PO = line.Replace("\",", "\";").Split(';');
                        string _PostingDate = PO[0].Replace("\"", "");
                        string _SaleOrderCalNo = PO[1].Replace("\"", "");
                        string _SaleContractNo = PO[2].Replace("\"", "");
                        string _ItemNo = PO[3].Replace("\"", "");
                        string _LocationName = PO[4].Replace("\"", "");
                        string _BinCode = PO[5].Replace("\"", "");
                        string _PackingUnit = PO[6].Replace("\"", "");
                        string _PackingUnitName = PO[7].Replace("\"", "");
                        string _Quantity = PO[8].Replace("\"", "");
                        string _Status = PO[9].Replace("\"", "");
                        string _LineNo = PO[10].Replace("\"", "");

                        string _LocationCode = "";
                        var lc = db.DM_Location.Where(c => c.LocationName == _LocationName).ToList();
                        if (lc.Count > 0)
                        {
                            _LocationCode = lc[0].Code;
                        }
                        var query = (from s in db.ChiTiet_LenhGiaoHang
                                     where s.SaleOrderCalNo == _SaleOrderCalNo && s.LineNo == _LineNo
                                     select s).FirstOrDefault<ChiTiet_LenhGiaoHang>();
                        if (query == null)
                        {
                            db.ChiTiet_LenhGiaoHang.Add(new ChiTiet_LenhGiaoHang
                            {
                                PostingDate = Convert.ToDateTime(_PostingDate),
                                SaleOrderCalNo = _SaleOrderCalNo,
                                SaleContractNo = _SaleContractNo,
                                ItemNo = _ItemNo,
                                LocationCode = _LocationCode,
                                BinCode = _BinCode,
                                PackingUnit = cnn.sNull2Int(_PackingUnit),
                                PackingUnitName = _PackingUnitName,
                                Quantity = Convert.ToDecimal(_Quantity),
                                Status = _Status,
                                LineNo = _LineNo

                            });
                            db.SaveChanges();
                        }
                        {
                            var q = (from s in db.DM_LenhGiaoHang
                                     where s.SaleOrderCalNo == _SaleOrderCalNo
                                     select s).FirstOrDefault<DM_LenhGiaoHang>();
                            if (q == null)
                            {
                                db.DM_LenhGiaoHang.Add(new DM_LenhGiaoHang
                                {
                                    PostingDate = Convert.ToDateTime(_PostingDate),
                                    SaleOrderCalNo = _SaleOrderCalNo,
                                    SaleContractNo = _SaleContractNo,
                                });
                                db.SaveChanges();
                            }
                        }
                    }
                }
                Search();
            }
            this.Cursor = Cursors.Default;
            XtraMessageBox.Show("Cập nhật danh sách thành công");
        }

        private void frmYeuCauGiaoHang_Load(object sender, EventArgs e)
        {
            dtpTuNgay.uValue = cnn.GetDateServer().AddDays(-7);
            dtpDenNgay.uValue = cnn.GetDateServer();
            dtpNgay.uValue = cnn.GetDateServer();
            Search();
            btnThemmoi.Enabled = true;
            btnLuu.Enabled = false;
            groupBox1.Enabled = false;
        }
        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
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
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\LenhGiaoHang.repx", dt);

                frm.Show();
                dt.Columns.Remove("Tungay");
                dt.Columns.Remove("Denngay");
            }
        }

        
        string _LocationCode = "";
        string _LocationName = "";

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnThemmoi.Enabled = false;
            dtpNgay.uValue = cnn.GetDateServer();
            using (DBACOMEntities db = new DBACOMEntities())
            {
                DM_Location lc = db.DM_Location.Where(c => c.Status == true).FirstOrDefault();
                _LocationCode = lc.Code;
                _LocationName = lc.LocationName;
            }
            cboLocationCode.uDataSource = cnn.DT_DataTable("SELECT Code, LocationName FROM DM_Location WHERE Status = 1");
            cboLocationCode.uEditValue = _LocationCode;
            cnn.clearControl(cboItemCode);
            cnn.clearControl(cboVitri);
            cnn.clearControl(cboQuiCach);
            spnQTy.uValue = 0;
            groupBox1.Enabled = true;
        }

        string _SaleOrderCalNo = "";
        string _ItemNo = "";
        string _BinCode = "RECEIVING";
        string _SaleContractNo = "";
        string _PackingUnitCode = "";
        int _Quantity = 0;
        string _LineNo = "";
        string _Status = "";

        private bool Check_Cond()
        {
            if (txtLGH.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Sale order call không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cnn.bComboIsNull(cboItemCode))
            {
                XtraMessageBox.Show("Sản phẩm không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cnn.bComboIsNull(cboLot))
            {
                XtraMessageBox.Show("Lot không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpNgay.uValue.ToString().Length == 0)
            {
                XtraMessageBox.Show("Ngày không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Check_Cond())
                return;
            DateTime _PostingDate = Convert.ToDateTime(dtpNgay.uValue);
            if (txtLGH.uText != "")
            {
                _SaleOrderCalNo = txtLGH.uText;
            }
            if (txtHopDong.uText != "")
            {
                _SaleContractNo = txtHopDong.uText;
            }
            if (!cnn.bComboIsNull(cboItemCode))
            {
                _ItemNo = cboItemCode.uEditValue.ToString();
            }
            if (!cnn.bComboIsNull(cboLocationCode))
            {
                _LocationCode = cboLocationCode.uEditValue.ToString();
            }
            if (!cnn.bComboIsNull(cboVitri))
            {
                _BinCode = cboVitri.uEditValue.ToString();
            }
            if (!cnn.bComboIsNull(cboQuiCach))
            {
                _PackingUnitCode = cboQuiCach.uEditValue.ToString();
            }
            _Quantity = Convert.ToInt32(spnQTy.uValue);

            DataTable dt = new DataTable();
            dt = cnn.DT_DataTable("SELECT MAX([LineNo]) as [LineNo] FROM ChiTiet_LenhGiaoHang WHERE SaleOrderCalNo = '" + _SaleOrderCalNo + "' GROUP BY SaleOrderCalNo");
            if (dt.Rows.Count > 0)
            {
                _LineNo = (Convert.ToInt32(dt.Rows[0]["LineNo"]) + 1).ToString();
            }
            else
            {
                _LineNo = "1";
            }

            using (DBACOMEntities db = new DBACOMEntities())
            {
                this.Cursor = Cursors.WaitCursor;

                //Lưu danh mục Lệnh giao hàng
                var q = (from s in db.DM_LenhGiaoHang
                         where s.SaleOrderCalNo == _SaleOrderCalNo
                         select s).FirstOrDefault<DM_LenhGiaoHang>();
                if (q == null)
                {
                    db.DM_LenhGiaoHang.Add(new DM_LenhGiaoHang
                    {
                        PostingDate = Convert.ToDateTime(_PostingDate),
                        SaleOrderCalNo = _SaleOrderCalNo,
                        SaleContractNo = _SaleContractNo,
                    });
                    db.SaveChanges();
                }

                //Lưu chi tiết Lệnh giao hàng
                db.ChiTiet_LenhGiaoHang.Add(new ChiTiet_LenhGiaoHang
                {
                    PostingDate = Convert.ToDateTime(_PostingDate),
                    SaleOrderCalNo = _SaleOrderCalNo,
                    SaleContractNo = _SaleContractNo,
                    ItemNo = _ItemNo,
                    LocationCode = _LocationCode,
                    BinCode = _BinCode,
                    PackingUnit = Convert.ToInt32(spnQTy.uValue),
                    PackingUnitName = _PackingUnitCode,
                    Quantity = Convert.ToDecimal(_Quantity),
                    Status = _Status,
                    LineNo = _LineNo,
                    Lot = cboLot.uEditValue.ToString()
                });
                if (db.SaveChanges() > 0)
                {
                    this.Cursor = Cursors.Default;
                    btnLuu.Enabled = false;
                    btnThemmoi.Enabled = true;
                    cnn.clearControl(groupBox1);
                    txtLGH.uText = _SaleOrderCalNo;
                    txtHopDong.uText = _SaleContractNo;
                    dtpNgay.uValue = cnn.GetDateServer();
                    XtraMessageBox.Show("Cập nhật danh sách thành công");
                }
            }
            Search();
        }

        private void cboLocationCode_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var data = db.DM_Location.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Code");
                dt.Columns.Add("LocationName");
                dt = ConvertToDataTable(data);
                cboLocationCode.uDataSource = dt;

            }
        }

        private void cboItemCode_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var data = db.tblItems.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ItemNo");
                dt.Columns.Add("ItemName");
                dt = ConvertToDataTable(data);
                cboItemCode.uDataSource = dt;
            }
        }

        private void cboVitri_uQueryPopUp(object sender, CancelEventArgs e)
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

        private void cboQuiCach_uQueryPopUp(object sender, CancelEventArgs e)
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

        private void gridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView1.OptionsSelection.MultiSelect = true;
                gridView1.SelectAll();
            }
        }

        private void cboLot_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Lot = db.DM_Lot.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Lot");
                dt.Columns.Add("ItemCode");
                dt = ConvertToDataTable(Lot);
                cboLot.uDataSource = dt;
            }
        }

        private void cboLot_uEditValueChanged(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboLot))
            {
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    {
                        var list = db.DM_Packing.ToList();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("PackageCode");
                        dt = ConvertToDataTable(list);
                        cboQuiCach.uDataSource = dt;
                    }
                    {
                        var data = db.tblItems.ToList();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("ItemNo");
                        dt.Columns.Add("ItemName");
                        dt = ConvertToDataTable(data);
                        cboItemCode.uDataSource = dt;
                    }
                }
              string  _Lot = cboLot.uEditValue.ToString();
                using (DBACOMEntities DB = new DBACOMEntities())
                {
                    var qc = DB.DM_Lot.Where(c => c.Lot == _Lot).ToArray();
                    if (qc != null)
                    {
                        cboItemCode.uEditValue = qc[0].ItemCode;
                        cboQuiCach.uEditValue = qc[0].PackingUnitCode;
                    }
                }
            }
        }

        private void rptDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa Lệnh giao hàng này?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string _LenhGH = gridView1.GetFocusedRowCellValue("SaleOrderCalNo").ToString();
                string _LineNo = gridView1.GetFocusedRowCellValue("ID").ToString();
                var Thamso = new Dictionary<String, String>() { { "LenhGH", _LenhGH }, { "LineNo", _LineNo } };
                if (cnn.SQL_GetStoredProcedure("SP_LenhGiaoHang_Del", Thamso).Rows.Count > 0)
                {
                    XtraMessageBox.Show("Không thể xóa\nĐã có phát sinh cho Lệnh giao hàng này", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cnn.ExecuteNonQuery("DELETE FROM ChiTiet_LenhGiaoHang WHERE ID = '" + _LineNo + "'");
                    if (cnn.DT_DataTable("SELECT SaleOrderCalNo FROM ChiTiet_LenhGiaoHang WHERE SaleOrderCalNo = '" + _LenhGH + "'").Rows.Count == 0)
                    {
                        cnn.ExecuteNonQuery("DELETE FROM DM_LenhGiaoHang WHERE SaleOrderCalNo = '" + _LenhGH + "'");
                    }
                    Search();
                    XtraMessageBox.Show("Đã xóa", "Thông báo");
                }
            }
        }
    }
}
