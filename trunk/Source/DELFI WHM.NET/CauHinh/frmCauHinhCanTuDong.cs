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

namespace DELFI_WHM.NET.CauHinh
{
    public partial class frmCauHinhCanTuDong : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);

        int _IDScales = 0;
        int _UuTien = 0;
        int ID = 0;
        string _Lot = "";
        string _LSX = "";
        public frmCauHinhCanTuDong()
        {
            InitializeComponent();
        }

        DateTime Tungay, Denngay, Ngay;

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

        private bool Check_Cond()
        {
            if (cnn.bComboIsNull(cboLot))
            {
                XtraMessageBox.Show("Bạn chưa nhập Lot", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLot.Focus();
                return false;
            }
            if (dtpDate.uValue.ToString().Length == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập Ngày", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDate.Focus();
                return false;
            }
            if (cnn.bComboIsNull(cboItem))
            {
                XtraMessageBox.Show("Bạn chưa chọn Sản phẩm", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboItem.Focus();
                return false;
            }
            if (cnn.bComboIsNull(cboPackageCode))
            {
                XtraMessageBox.Show("Bạn chưa chọn Qui cách", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPackageCode.Focus();
                return false;
            }
            if (cnn.bComboIsNull(cboScales))
            {
                XtraMessageBox.Show("Bạn chưa chọn Cân", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboScales.Focus();
                return false;
            }
            if (cnn.bComboIsNull(cboLSX))
            {
                XtraMessageBox.Show("Bạn chưa chọn Lệnh sản xuất", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLSX.Focus();
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
                Tungay = Convert.ToDateTime(dtpFromDate.uValue);
                Denngay = Convert.ToDateTime(dtpToDate.uValue);
                int ID_Can = Convert.ToInt32(cboScales.uEditValue);
                var Can = db.tblBigBagConfig.Where(c => c.IDScales == ID_Can &&
                                                   (c.FromDate <= Tungay && Tungay <= c.ToDate ||
                                                    c.FromDate <= Denngay && Denngay <= c.ToDate)).ToList();
                if (Can.Count > 0)
                {
                    XtraMessageBox.Show("Khoảng thời gian của Cân không được trùng nhau", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboScales.Focus();
                    return false;
                }
            }
            return true;
        }

        private void Search()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var can = db.tblConfigScale.Where(c => c.PortServer == "502" && c.ID >= 3 && c.ID <= 5).ToList();
                if (can.Count > 0)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Note");
                    dt = ConvertToDataTable(can);

                    repositoryItemLookUpEdit1.DataSource = dt;
                    repositoryItemLookUpEdit1.DisplayMember = "Note";
                    repositoryItemLookUpEdit1.ValueMember = "ID";

                    repositoryItemLookUpEdit2.DataSource = dt;
                    repositoryItemLookUpEdit2.DisplayMember = "Note";
                    repositoryItemLookUpEdit2.ValueMember = "ID";
                }

                var ht = db.tblBigBagConfig.Where(c => c.HoanThanh == false).OrderBy(c => c.UuTien).ToList();
                if (ht.Count > 0)
                {
                    griDangdung.DataSource = ht;
                }
                var list = db.tblBigBagConfig.Where(c => c.HoanThanh == true).OrderBy(c => c.UuTien).ToList();
                if (list.Count > 0)
                {
                    gridHoanThanh.DataSource = list;
                }
            }
            Load_cboLSX();
            Load_cboItem();
            Load_cboLot();
            Load_cboPackageCode();
            Load_cboScales();           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int ID = 0;
            ID = Convert.ToInt32(spnID.uValue);

            using (DBACOMEntities db = new DBACOMEntities())
            {
                if (ID == 0)
                {
                    if (!Check_Cond())
                        return;
                    _IDScales = Convert.ToInt32(cboScales.uEditValue);
                    int ut = 1;
                    try
                    {
                        ut = Convert.ToInt32(db.tblBigBagConfig.Where(c => c.IDScales == _IDScales).Max(p => p.UuTien)) + 1;
                    }
                    catch
                    {
                        ut = 1;
                    }
                    Ngay = DateTime.Now;
                    db.tblBigBagConfig.Add(new tblBigBagConfig
                    {
                        LOT = cboLot.uEditValue.ToString(),
                        Date = Convert.ToDateTime(dtpDate.uValue),
                        Bag = Convert.ToInt32(spnBag.uValue),
                        CropYear = txtCropYear.uText,
                        ItemCode = cboItem.uEditValue.ToString(),
                        Note = txtNote.uText,
                        CreateDate = Ngay,
                        UserCreate = Properties.Settings.Default.USER_NAME,
                        FromDate = Convert.ToDateTime(dtpFromDate.uValue),
                        ToDate = Convert.ToDateTime(dtpToDate.uValue),
                        IDScales = Convert.ToInt32(cboScales.uEditValue),
                        PackageType = cboPackageCode.uEditValue.ToString(),
                        BatchNo = cboLSX.uEditValue.ToString(),
                        IsActive = chkActive.Checked,
                        UuTien = ut,
                        TamNgung = false,
                        HoanThanh = false
                    });
                    if (db.SaveChanges() > 0)
                    {
                        Search();
                        var Thamso = new Dictionary<String, String>() { { "IDScales", _IDScales.ToString() }, { "Ngay", Ngay.ToString("yyyy-MM-dd HH:mm:ss") } };
                        lbID.Text = "ID Cấu hình cân hiện tại là: " + cnn.SQL_GetStoredProcedure("SP_GET_IDBigbagConfig", Thamso).Rows[0][0].ToString();
                        lbID.Visible = true;
                        XtraMessageBox.Show("Cập nhật danh sách thành công", "Thông báo");
                    }
                }
                else
                {
                    var sl = db.tblBigBagConfig.Where(c => c.ID == ID).ToList();
                    if (spnBag.uValue < sl[0].SoBaoDaSanXuat)
                    {
                        XtraMessageBox.Show("Số bao không được nhỏ hơn Số bao đã hoàn thành", "Thông báo");
                    }
                    else
                    {
                        tblBigBagConfig lc = db.tblBigBagConfig.Where(c => c.ID == ID).FirstOrDefault();
                        lc.Note = txtNote.uText;
                        lc.Bag = Convert.ToInt32(spnBag.uValue);
                        lc.PackageType = cboPackageCode.uEditValue.ToString();
                        lc.IsActive = chkActive.Checked;
                        lc.Date = Convert.ToDateTime(dtpDate.uValue);
                        if (db.SaveChanges() > 0)
                        {
                            Search();                            
                            var Thamso = new Dictionary<String, String>() { { "IDScales", _IDScales.ToString() }, { "Ngay", Ngay.ToString("yyyy-MM-dd HH:mm:ss") } };                            
                            XtraMessageBox.Show("Cập nhật trạng thái thành công", "Thông báo");
                        }
                    }
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


        private void cboLot_uEditValueChanged(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboLot))
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    string _Lot = "";
                    _Lot = cboLot.uEditValue.ToString();
                    var list = db.DM_Lot.Where(c => c.Lot == _Lot).ToList();
                    if (list.Count > 0)
                    {
                        spnBag.uValue = Convert.ToInt32(list[0].Bag);
                        txtCropYear.uText = list[0].CropYear;
                        dtpDate.uValue = Convert.ToDateTime(list[0].Date);
                        cboItem.uEditValue = list[0].ItemCode;
                        cboPackageCode.uEditValue = list[0].PackingUnitCode;
                    }
                    else
                    {
                        spnBag.uValue = 0;
                        txtCropYear.uText = "";
                        cnn.clearControl(cboItem);
                        cnn.clearControl(cboPackageCode);
                    }
                }            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int ID = 0;
            ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            lbID.Visible = true;
            lbID.Text = "ID Cấu hình cân hiện tại là: " + ID.ToString();
            spnID.uValue = ID;
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.tblBigBagConfig.Where(c => c.ID == ID).ToList();
                cboLot.uEditValue = list[0].LOT;
                dtpDate.uValue = Convert.ToDateTime(list[0].Date);
                cboItem.uEditValue = list[0].ItemCode;
                cboPackageCode.uEditValue = list[0].PackageType;
                cboScales.uEditValue = list[0].IDScales;
                cboLSX.uEditValue = list[0].BatchNo;
                dtpFromDate.uValue = Convert.ToDateTime(list[0].FromDate);
                dtpToDate.uValue = Convert.ToDateTime(list[0].ToDate);
                chkActive.Checked = list[0].IsActive;
                spnBag.uValue = Convert.ToInt32(list[0].Bag);
                txtNote.uText = list[0].Note;
            }
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            _IDScales = Convert.ToInt32(gridView1.GetFocusedRowCellValue("IDScales"));
            _UuTien = Convert.ToInt32(gridView1.GetFocusedRowCellValue("UuTien"));
            int ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));

            var Thamso = new Dictionary<String, String>() { { "IDScale", _IDScales.ToString() }, { "UuTien", _UuTien.ToString() } };
            cnn.SQL_ExecuteStoredProcedure("Update_UuTien_Can_Truoc", Thamso);

            Search();
            //Chọn lại dòng vừa chuyển
            int r = gridView1.LocateByValue("ID", ID);
            gridView1.FocusedRowHandle = r;
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            _IDScales = Convert.ToInt32(gridView1.GetFocusedRowCellValue("IDScales"));
            _UuTien = Convert.ToInt32(gridView1.GetFocusedRowCellValue("UuTien"));
            int ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));

            var Thamso = new Dictionary<String, String>() { { "IDScale", _IDScales.ToString() }, { "UuTien", _UuTien.ToString() } };
            cnn.SQL_ExecuteStoredProcedure("Update_UuTien_Can_Sau", Thamso);

            Search();

            //Chọn lại dòng vừa chuyển
            int r = gridView1.LocateByValue("ID", ID);
            gridView1.FocusedRowHandle = r;
        }


        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            cnn.clearControl(group);
            dtpDate.uValue = DateTime.Now;
            dtpFromDate.uValue = DateTime.Now;
            dtpToDate.uValue = DateTime.Now;
            lbID.Visible = false;
        }

        private void btnHoanthanh_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn hoàn thành?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.tblBigBagConfig.Where(c => c.ID == ID && c.HoanThanh == false).ToList();
                if (list.Count > 0)
                {
                    tblBigBagConfig lc = db.tblBigBagConfig.Where(c => c.ID == ID).FirstOrDefault();
                    lc.HoanThanh = true;
                    db.SaveChanges();
                    XtraMessageBox.Show("Đã hoàn thành", "Thông báo");
                    Search();
                }
                else
                {
                    XtraMessageBox.Show("Lệnh đã hoàn thành, không thể tiếp tục", "Thông báo");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void chkTamNgung_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.PostEditor();
            ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.tblBigBagConfig.Where(c => c.ID == ID && c.HoanThanh == false).ToList();
                if (list.Count > 0)
                {
                    tblBigBagConfig lc = db.tblBigBagConfig.Where(c => c.ID == ID).FirstOrDefault();
                    lc.TamNgung = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("TamNgung"));
                    db.SaveChanges();
                }
                else
                {
                    XtraMessageBox.Show("Lệnh đã hoàn thành, không thể tạm dừng", "Thông báo");
                }
            }
        }

        private void Load_cboLot()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                _LSX = cboLSX.uEditValue.ToString();
                var lt = db.DM_Lot.Where(c => c.BatchNo == _LSX).ToList();
                if (lt.Count > 0)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Lot");
                    dt = ConvertToDataTable(lt);
                    cboLot.uDataSource = dt;
                } 
                else
                {
                    var Lot = db.DM_Lot.ToList();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Lot");
                    dt = ConvertToDataTable(Lot);
                    cboLot.uDataSource = dt;
                }
            }
        }

        private void Load_cboItem()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var it = db.tblItems.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ItemNo");
                dt.Columns.Add("ItemName");
                dt = ConvertToDataTable(it);
                cboItem.uDataSource = dt;
            }
        }

        private void Load_cboPackageCode()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Quicach = db.DM_Packing.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("PackageCode");
                dt.Columns.Add("PackageDesc");
                dt = ConvertToDataTable(Quicach);
                cboPackageCode.uDataSource = dt;
            }
        }

        private void Load_cboScales()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var can = db.tblConfigScale.Where(c => c.PortServer == "502" && c.ID >= 3 && c.ID <= 5).ToList();
                if (can.Count > 0)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Note");
                    dt = ConvertToDataTable(can);
                    cboScales.uDataSource = dt;
                }
            }
        }

        private void Load_cboLSX()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var LSX = db.Chitiet_LenhSanXuat.OrderByDescending(c => c.PostingDate).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("PostingDate");
                dt.Columns.Add("BatchNo");
                dt.Columns.Add("Note");
                dt = ConvertToDataTable(LSX);
                cboLSX.uDataSource = dt;
            }
        } 

        private void cboLot_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboLot();
        }

        private void cboItem_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboItem();
        }

        private void cboPackageCode_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboPackageCode();
        }

        private void cboScales_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboScales();
        }

        private void spnBag_uValueChanged(object sender, EventArgs e)
        {
            if (spnBag.uValue < 0)
            {
                XtraMessageBox.Show("Số bao không được âm", "Thông báo");
                spnBag.uValue = 0;
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

        private void gridView2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView2.OptionsSelection.MultiSelect = true;
                gridView2.SelectAll();
            }
        }

        private void cboLSX_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboLSX();
        }

        private void frmCauHinhCanTuDong_Load(object sender, EventArgs e)
        {
            dtpDate.uValue = DateTime.Now;
            dtpFromDate.uValue = DateTime.Now;
            dtpToDate.uValue = DateTime.Now;
            lbID.Visible = false;
            Search();
        }
    }
}
