using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DELFI_WHM.NET;
using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;
using DELFI_WHM.NET.DELFI_Class;
using System.Data.OleDb;

namespace DELFI_WHM.NET.CauHinh
{
    public partial class frmCauHinhLot : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);

        string _LSX = "";
        string _Loaibaobi = "";
        string _Cer = "NONE";

        public frmCauHinhLot()
        {
            InitializeComponent();
        }

        private void Search()
        {
            this.Cursor = Cursors.WaitCursor;
            //string MaSanPham = cnn.sNull2String(cboVatTu);
            //string CropYear = cnn.sNull2String(cboCropYear);
            //using (DBACOMEntities db = new DBACOMEntities())
            //{
            //    var data = db.DM_Lot.Where(c => c.Lot.Contains(txtLot.Text) &&
            //                              c.ItemCode.Contains(MaSanPham) &&
            //                              c.CropYear.Contains(CropYear) &&
            //                              c.Note.Contains(txtGhiChu.Text)).OrderByDescending(c => c.Date).ToList();
            //    if (data != null)
            //    {
            //        griDanhSach.DataSource = data;
            //    }
            //}
            griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_Get_DMLot");
            this.Cursor = Cursors.Default;
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
        }

        public void Load_Data()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                {
                    var data = db.DM_LenhSanXuat.OrderByDescending(c => c.PostingDate).ToList();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("BatchNo");
                    dt = ConvertToDataTable(data);
                    cboLSX.uDataSource = dt;
                }
                {
                    var data = db.tblItems.ToList();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ItemNo");
                    dt.Columns.Add("ItemName");
                    dt = ConvertToDataTable(data);
                    cboVatTu.uDataSource = dt;
                }
                {
                    var Quicach = db.DM_Packing.ToList();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("PackageCode");
                    dt = ConvertToDataTable(Quicach);
                    cboQuicach.uDataSource = dt;
                }
                {
                    cboCer.uDataSource = cnn.DT_DataTable("SELECT Ten FROM DM_Certificate");
                }
                {
                    var data = db.DM_CropYear.OrderByDescending(c => c.Ten).ToList();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Ten");
                    dt = ConvertToDataTable(data);
                    cboCropYear.uDataSource = dt;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private bool Check_Cond()
        {
            if (txtLot.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập Số lot", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLot.SelectAll();
                return false;
            }

            if (DELFITextProcess.Xoadau(txtLot.Text.Trim()).ToString() != txtLot.Text.Trim().ToString())
            {
                XtraMessageBox.Show("Lot không được nhập có dấu", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLot.SelectAll();
                return false;
            }

            if (dtpNgayTao.uValue.ToString().Length == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập Ngày", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayTao.Focus();
                return false;
            }
            if (cboVatTu.uEditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn Sản phẩm", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboVatTu.Focus();
                return false;
            }
            if (cboCropYear.uEditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn Crop Year", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCropYear.Focus();
                return false;
            }
            if (txtLot.Text.Length > 20)
            {
                XtraMessageBox.Show("Lot chỉ tối đa 20 ký tự", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLot.SelectAll();
                return false;
            }
            if (cnn.DT_DataTable("SELECT Lot FROM DM_Lot WHERE Lot = '" + txtLot.uText + "'").Rows.Count > 0 && spnID.uValue == 0)
            {
                XtraMessageBox.Show("Lot đã tồn tại, không thể thêm mới", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLot.SelectAll();
                return false;
            }

            if (cnn.bComboIsNull(cboCer))
            {
                cboCer.uEditValue = "NONE";
            }
            return true;
        }

        public bool Check_Lot(string Lot)
        {
            var thamso = new Dictionary<String, String>() { { "Lot", Lot } };
            DataTable dt = cnn.SQL_GetStoredProcedure("SP_Lot_Del", thamso);
            if (dt.Rows.Count > 0)
            {
                XtraMessageBox.Show("Mã Lot đã phát sinh dữ liệu không thể sửa, xóa", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLot.Focus();
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int ID = 0;
            bool bExits = false;
            if (!Check_Cond())
                return;
            if (!Check_Lot(txtLot.uText))
                return;
            this.Cursor = Cursors.WaitCursor;
            spnShift.uValue = cnn.Shift();

            cnn.BeginTransaction();
            try
            {
                ID = Convert.ToInt32(spnID.uValue);
                this.Cursor = Cursors.WaitCursor;
                string sSQL = cnn.UpdateDataSQLComm(pnMain, "DM_Lot", "ID = '" + ID + "'", ref bExits, true);
                cnn.ExecuteNonQuery(sSQL);
                cnn.EndTransaction();
                this.Cursor = Cursors.Default;
                Search();
                cnn.clearControl(group);
                XtraMessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            catch (Exception ex)
            {
                cnn.RollbackTransaction();
                this.Cursor = Cursors.Default;
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnn.clearControl(this);
            }
            this.Cursor = Cursors.Default;
        }

        private void frmCauHinhLot_Load(object sender, EventArgs e)
        {
            dtpNgayTao.uValue = cnn.GetDateServer();
            Load_Data();
            if (cnn.GetDateServer().Month >= 10 && cnn.GetDateServer().Month <= 12)
            {
                cboCropYear.uEditValue = cnn.GetDateServer().Year +1;
            }
            else
            {
                cboCropYear.uEditValue = cnn.GetDateServer().Year;
            }
            Search();
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

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void cboVatTu_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var data = db.tblItems.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ItemNo");
                dt.Columns.Add("ItemName");
                dt = ConvertToDataTable(data);
                cboVatTu.uDataSource = dt;
            }
        }

        private void Load_cboCropYear()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var data = db.DM_CropYear.OrderByDescending(c=>c.Ten).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Ten");
                dt = ConvertToDataTable(data);
                cboCropYear.uDataSource = dt;
            }
        }

        private void cboCropYear_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboCropYear();
        }

        private void cboLSX_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var data = db.DM_LenhSanXuat.OrderByDescending(c=>c.PostingDate).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("BatchNo");
                dt = ConvertToDataTable(data);
                cboLSX.uDataSource = dt;
            }
        }

        private void cboQuicach_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Quicach = db.DM_Packing.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("PackageCode");
                dt = ConvertToDataTable(Quicach);
                cboQuicach.uDataSource = dt;
            }
        }

        private void spnBag_uValueChanged(object sender, EventArgs e)
        {
            if (spnBag.uValue < 0)
            {
                XtraMessageBox.Show("Số bao không được nhỏ hơn 0", "Thông báo");
                spnBag.uValue = 0;
            }
        }

        private void txtLot_uTextChanged(object sender, EventArgs e)
        {
            lbGioihanLot.Text = txtLot.Text.Length.ToString() + "/20";
        }

        private void gridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView.OptionsSelection.MultiSelect = true;
                gridView.SelectAll();
            }
        }

        private void cboCer_uQueryPopUp(object sender, CancelEventArgs e)
        {
            cboCer.uDataSource = cnn.DT_DataTable("SELECT Ten FROM DM_Certificate");
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            int ID = cnn.sNull2Int(gridView.GetFocusedRowCellValue("ID"));
            if (ID > 0)
            {
                string sql = "select * from DM_Lot where ID = '" + ID + "'";
                DataRow r = cnn.SelectRows(sql).Rows[0];
                cnn.DR_DataReader(pnMain, r);
                spnID.uValue = ID;
            }
        }

        private void griDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void rptDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa Lot này?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string Lot = gridView.GetFocusedRowCellValue("Lot").ToString();
                if (!Check_Lot(Lot))
                    return;
                else
                {
                    cnn.ExecuteNonQuery("DELETE FROM DM_Lot WHERE Lot = '" + Lot + "'");
                    Search();
                    XtraMessageBox.Show("Đã xóa", "Thông báo");
                }
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            cnn.clearControl(group);
            dtpNgayTao.uValue = cnn.GetDateServer();
            if (cnn.GetDateServer().Month >= 10 && cnn.GetDateServer().Month <= 12)
            {
                cboCropYear.uEditValue = cnn.GetDateServer().Year + 1;
            }
            else
            {
                cboCropYear.uEditValue = cnn.GetDateServer().Year;
            }
        }
    }
}
