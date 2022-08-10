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
using DELFI_WHM.NET.DELFI_Class;

namespace DELFI_WHM.NET.QuanLy
{
    public partial class frmLenhSanXuat : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string _LocationCode = "";
        string _LocationName = "";

        public frmLenhSanXuat()
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
            string Tungay = Convert.ToDateTime(dtpTuNgay.uValue).ToString("yyyy-MM-dd");
            string Denngay = Convert.ToDateTime(dtpDenNgay.uValue).ToString("yyyy-MM-dd");            
            griDanhSach.DataSource = cnn.DT_DataTable("SELECT Chitiet_LenhSanXuat.*, '' as Del FROM Chitiet_LenhSanXuat " +
                                                      " WHERE BatchNo Like '%" + txtBatch.Text + "%' AND PostingDate BETWEEN '" + Tungay + "' AND '" + Denngay +"' " +
                                                      " ORDER BY PostingDate DESC, BatchNo");
            for (int i = 0; i< gridView1.Columns.Count; i ++)
            {
                if (gridView1.Columns[i].FieldName != "Del")
                {
                    gridView1.Columns[i].OptionsColumn.AllowEdit = false;
                }
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
                var link = db.tblConfigLinkSync.Where(c => c.Value.Equals("DM_LenhSanXuat")).Select(p => p.Description).ToArray();
                string[] lines = cnn.Import_NAV(link[0]);
                foreach (string line in lines)
                {
                    string[] PO = line.Replace("\",", "\";").Split(';');
                    string _PostingDate = PO[0].Replace("\"", "");
                    string _BatchNo = PO[1].Replace("\"", "");
                    string _ItemNo = PO[2].Replace("\"", "");
                    string _LocationName = PO[3].Replace("\"", "");
                    string _BinCode = PO[4].Replace("\"", "");
                    string _PalletQty = PO[5].Replace("\"", "");
                    string _PackingUnitCode = PO[6].Replace("\"", "");
                    string _Quantity = PO[7].Replace("\"", "");
                    int _LineNo = Convert.ToInt32(PO[8].Replace("\"", ""));

                    //Lưu danh mục lệnh sản xuất
                    var query2 = (from p in db.DM_LenhSanXuat
                                  where p.BatchNo == _BatchNo
                                  select p).FirstOrDefault<DM_LenhSanXuat>();
                    if (query2 == null)
                    {
                        db.DM_LenhSanXuat.Add(new DM_LenhSanXuat
                        {
                            PostingDate = Convert.ToDateTime(_PostingDate),
                            BatchNo = _BatchNo
                        });
                        db.SaveChanges();
                    }
                    
                    var lc = db.DM_Location.Where(c => c.LocationName == _LocationName).ToList();
                    if (lc.Count > 0)
                    {
                        _LocationCode = lc[0].Code;
                    }
                    //Lưu chi tiết lệnh sản xuất
                    var query = (from s in db.Chitiet_LenhSanXuat
                                 where s.BatchNo == _BatchNo && s.LineNo == _LineNo
                                 select s).FirstOrDefault<Chitiet_LenhSanXuat>();
                    if (query == null)
                    {
                        db.Chitiet_LenhSanXuat.Add(new Chitiet_LenhSanXuat
                        {
                            PostingDate = Convert.ToDateTime(_PostingDate),
                            BatchNo = _BatchNo,
                            ItemNo = _ItemNo,
                            LocationCode = _LocationCode,
                            BinCode = _BinCode,
                            PalletQty = cnn.sNull2Int(_PalletQty),
                            PackingUnitCode = _PackingUnitCode,
                            Quantity = Convert.ToDecimal(_Quantity),
                            LineNo = _LineNo,
                            UpdateDate = cnn.GetDateServer(),
                            UserName = Properties.Settings.Default.FULL_NAME
                        });
                        db.SaveChanges();
                    }
                }
                Search();
            }
            this.Cursor = Cursors.Default;
            XtraMessageBox.Show("Cập nhật danh sách thành công");
        }

        private void frmLenhSanXuat_Load(object sender, EventArgs e)
        {
            dtpTuNgay.uValue = cnn.GetDateServer().AddDays(-7);
            dtpDenNgay.uValue = cnn.GetDateServer();
            dtpNgay.uValue = cnn.GetDateServer();                 
            Load_cboLocationCode();
            using (DBACOMEntities db = new DBACOMEntities())
            {
                DM_Location lc = db.DM_Location.Where(c => c.Status == true).FirstOrDefault();                
                cboLocationCode.uEditValue = lc.Code;                
            }
            Search();
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
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\LenhSanXuat.repx", dt);

                frm.Show();
                dt.Columns.Remove("Tungay");
                dt.Columns.Remove("Denngay");
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {      
            dtpNgay.uValue = cnn.GetDateServer();
            using (DBACOMEntities db = new DBACOMEntities())
            {
                DM_Location lc = db.DM_Location.Where(c => c.Status == true).FirstOrDefault();
                _LocationCode = lc.Code;
                _LocationName = lc.LocationName;
            }
            cboLocationCode.uEditValue = _LocationCode;
            cnn.clearControl(cboItemCode);
            cnn.clearControl(cboVitri);
            cnn.clearControl(cboQuiCach);
            spnQTy.uValue = 0;
            groupBox1.Enabled = true;
        }

        string _BatchNo = "";
        string _ItemNo = "";
        string _BinCode = "RECEIVING";
        string _PackingUnitCode = "";
        int _Quantity = 0;
        int _LineNo = 0;
        string _Lot = "";

        private bool Check_Cond()
        {
            if (txtLSX.Text.Trim().Length == 0)
            {
                txtLSX.Focus();
                XtraMessageBox.Show("Lệnh sản xuất không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (DELFITextProcess.Xoadau(txtLSX.Text.Trim()).ToString() != txtLSX.Text.Trim().ToString())
            {
                txtLSX.Focus();
                XtraMessageBox.Show("Lệnh sản xuất không được nhập có dấu", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpNgay.uValue.ToString().Length == 0)
            {
                XtraMessageBox.Show("Ngày không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cnn.bComboIsNull(cboItemCode))
            {
                XtraMessageBox.Show("Sản phẩm không được bỏ trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (txtLSX.uText != "")
            {
                _BatchNo = txtLSX.uText;
            }
            if (!cnn.bComboIsNull(cboItemCode))
            {
                _ItemNo = cboItemCode.uEditValue.ToString();
            }
            if (!cnn.bComboIsNull(cboLot))
            {
                _Lot = cboLot.uEditValue.ToString();
            }
            else
            {
                _Lot = "";
            }
            if (!cnn.bComboIsNull(cboLocationCode))
            {
                _LocationCode = cboLocationCode.uEditValue.ToString();
            }
            else
            {
                _LocationCode = "";
            }
            if (!cnn.bComboIsNull(cboVitri))
            {
                _BinCode = cboVitri.uEditValue.ToString();
            }
            else
            {
                _BinCode = "";
            }
            if (!cnn.bComboIsNull(cboQuiCach))
            {
                _PackingUnitCode = cboQuiCach.uEditValue.ToString();
            }
            else
            {
                _PackingUnitCode = "";
            }
            _Quantity = Convert.ToInt32(spnQTy.uValue);

            DataTable dt = new DataTable();
            dt = cnn.DT_DataTable("SELECT MAX([LineNo]) as [LineNo] FROM Chitiet_LenhSanXuat WHERE BatchNo = '" + _BatchNo + "' GROUP BY BatchNo");
            if (dt.Rows.Count > 0)
            {
                _LineNo = Convert.ToInt32(dt.Rows[0]["LineNo"]) + 1;
            }
            else
            {
                _LineNo = 1;
            }

            using (DBACOMEntities db = new DBACOMEntities())
            {
                //Lưu danh mục lệnh sản xuất
                var query2 = (from p in db.DM_LenhSanXuat
                              where p.BatchNo == _BatchNo && p.PostingDate == _PostingDate
                              select p).FirstOrDefault<DM_LenhSanXuat>();
                if (query2 == null)
                {
                    db.DM_LenhSanXuat.Add(new DM_LenhSanXuat
                    {
                        PostingDate = Convert.ToDateTime(_PostingDate),
                        BatchNo = _BatchNo
                    });
                    db.SaveChanges();
                }

                //Lưu chi tiết lệnh sản xuất

                db.Chitiet_LenhSanXuat.Add(new Chitiet_LenhSanXuat
                {
                    PostingDate = Convert.ToDateTime(_PostingDate),
                    BatchNo = _BatchNo,
                    Lot = _Lot,
                    ItemNo = _ItemNo,
                    LocationCode = _LocationCode,
                    BinCode = _BinCode,
                    PalletQty = Convert.ToInt32(spnPallet.uValue),
                    PackingUnitCode = _PackingUnitCode,
                    Quantity = Convert.ToDecimal(_Quantity),
                    LineNo = _LineNo,
                    Note = txtNote.uText,
                    UpdateDate = cnn.GetDateServer(),
                    UserName = Properties.Settings.Default.FULL_NAME
                });
                if (db.SaveChanges() > 0)
                {
                    XtraMessageBox.Show("Cập nhật danh sách thành công");
                    txtLSX.uText = _BatchNo;
                }                
                Search();
            }
            this.Cursor = Cursors.Default;
        }

        private void Load_cboLocationCode()
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

        private void cboLocationCode_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboLocationCode();
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

        private void gridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView1.OptionsSelection.MultiSelect = true;
                gridView1.SelectAll();
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
                _Lot = cboLot.uEditValue.ToString();
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
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa Lệnh sản xuất này?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string _LenhSX = gridView1.GetFocusedRowCellValue("BatchNo").ToString();
                string _LineNo = gridView1.GetFocusedRowCellValue("ID").ToString();
                var Thamso = new Dictionary<String, String>() { { "LenhSX", _LenhSX }, { "LineNo", _LineNo } };
                if (cnn.SQL_GetStoredProcedure("SP_LenhSanXuat_Del", Thamso).Rows.Count > 0)
                {
                    XtraMessageBox.Show("Không thể xóa\nĐã có phát sinh cho Lệnh sản xuất này", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cnn.ExecuteNonQuery("DELETE FROM Chitiet_LenhSanXuat WHERE ID = '" + _LineNo + "'");
                    if (cnn.DT_DataTable("SELECT BatchNo FROM Chitiet_LenhSanXuat WHERE BatchNo = '" + _LenhSX + "'").Rows.Count == 0)
                    {
                        cnn.ExecuteNonQuery("DELETE FROM DM_LenhSanXuat WHERE BatchNo = '" + _LenhSX + "'");
                    }
                    Search();
                    XtraMessageBox.Show("Đã xóa", "Thông báo");
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Import.FrmImport_LenhSanXuat frm = new Import.FrmImport_LenhSanXuat();
            frm.Show();
        }
    }
}
