using DELFI_WHM.NET.DELFI_Class;
using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DELFI_WHM.NET.SanXuat
{
    public partial class frmDS_SanXuat : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        DateTime Tungay, Denngay;
        XtraTabPage Tabpage;
        string CT = "";
        int ID;
        DateTime Ngay;
        string _LenhSanXuat = "";
        string _LocationCode = "";
        string _LocationName = "";
        string _Vitri = "";
        string _Lot = "";

        public frmDS_SanXuat()
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

        private void Form_Load()
        {
            Tungay = Convert.ToDateTime(dtpTungay.uValue).Date;
            Denngay = Convert.ToDateTime(dtpDenngay.uValue).Date;

            using (DBACOMEntities db = new DBACOMEntities())
            { 
                var HoanThanh = db.DM_PhieuXuat.Where(c => c.PostingDate >= Tungay && c.PostingDate <= Denngay && c.Type == "Processing").ToList();
                if (HoanThanh.Count > 0)
                {
                    gridHoanThanh.DataSource = HoanThanh;
                }
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            ID = 0;
            CT = "";
            Chitiet_Load();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Form_Load();
        }

        private void frmDS_SanXuat_Load(object sender, EventArgs e)
        {
            dtpTungay.uValue = cnn.GetDateServer().AddDays(-7);
            dtpDenngay.uValue = cnn.GetDateServer();
            Form_Load();
            ID = 0;
            CT = "";
            Ngay = cnn.GetDateServer();
            Chitiet_Load();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }
        

        private void gridViewHoanThanh_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewHoanThanh.GetFocusedRowCellValue("ContractNo") != null)
            {
                CT = gridViewHoanThanh.GetFocusedRowCellValue("ContractNo").ToString();
                Ngay = Convert.ToDateTime(gridViewHoanThanh.GetFocusedRowCellValue("PostingDate"));
                ID = Convert.ToInt32(gridViewHoanThanh.GetFocusedRowCellValue("ID"));
                Chitiet_Load();
            }
        }

        private void gridViewHoanThanh_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridViewHoanThanh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridViewHoanThanh.OptionsSelection.MultiSelect = true;
                gridViewHoanThanh.SelectAll();
            }
        }

        //private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        //{
        //    if (gridViewChuaHoanThanh.RowCount> 0)
        //    {
        //        DataTable dt = new DataTable();
        //        using (DBACOMEntities db = new DBACOMEntities())
        //        {
        //            try
        //            {
        //                var f = db.tblConfigLinkSyncs.Where(c => c.Value == "EX_PHIEUCANCAU").Select(p => p.Description).First();
        //                if (f == null)
        //                {
        //                    XtraMessageBox.Show("Không tìm thấy đường dẫn export", "Thông báo");
        //                }
        //                else
        //                {
        //                    Ngay = Convert.ToDateTime(gridViewChuaHoanThanh.GetFocusedRowCellValue("PostingDate"));
        //                    _LenhSanXuat = gridViewChuaHoanThanh.GetFocusedRowCellValue("ContractNo").ToString();

        //                    //Khởi tạo WeightNote
        //                    DM_Location lc = db.DM_Location.Where(c => c.Status == true).FirstOrDefault();
        //                    _LocationCode = lc.Code;
        //                    _LocationName = lc.LocationName;

        //                    Random RAN = new Random();
        //                    int abc = RAN.Next(10000, 99999);
        //                    int bcd = RAN.Next(100000, 999999);
        //                    string result = "";

        //                    //Load ID Phiếu xuất
        //                    var y = db.DM_PhieuXuat.Where(id => id.PostingDate == Ngay.Date && id.ContractNo == _LenhSanXuat).First();
        //                    int _ID = Convert.ToInt32(y.ID);

        //                    //Update lại WeightNote cho DM_PhieuXuat                        
        //                    var x = db.DM_PhieuXuat.Where(id => id.PostingDate == Ngay.Date && id.ContractNo == _LenhSanXuat && id.WeightNote != "").ToList();
        //                    if (x.Count == 0)
        //                    {
        //                        result = _LocationCode + "-" + abc.ToString() + "-" + bcd.ToString();
        //                        DM_PhieuXuat px = db.DM_PhieuXuat.Where(c => c.ID == _ID).First();
        //                        px.WeightNote = result;
        //                        db.SaveChanges();
        //                    }
        //                    else
        //                    {
        //                        result = x[0].WeightNote;
        //                    }

        //                    var list = db.WH_ChiTietXuatKho.Where(c => c.IDPhieuXuat == _ID).ToList();

        //                    for (int i = 0; i < list.Count; i++)
        //                    {
        //                        string QR = list[i].QRCode;                                    

        //                            //Update lại WeightNote cho Chi tiết xuất kho
        //                            {
        //                                WH_ChiTietXuatKho ctx = db.WH_ChiTietXuatKho.Where(p => p.QRCode == QR && p.IDPhieuXuat == _ID).First();
        //                                ctx.WeightNote = result;
        //                                db.SaveChanges();
        //                            }

        //                            //Update tồn kho
        //                            {
        //                                WH_TonKho tk = db.WH_TonKho.Where(c => c.QRCode == QR).FirstOrDefault();
        //                                tk.Exported = true;
        //                                db.SaveChanges();
        //                                decimal TLCan = Convert.ToDecimal(list[i].GrossWeight);
        //                                decimal TLTruBi = Convert.ToDecimal(list[i].TotalPackageQty);
        //                                decimal QRQty = Math.Round((decimal)TLCan - TLTruBi, 2);
        //                                _Vitri = list[i].BinCode;
        //                                _Lot = list[i].Lot;
        //                                var Thamso = new Dictionary<String, String>() { { "Lot", _Lot }, { "BinCode", _Vitri }, { "Nhap", "0" }, { "Xuat", QRQty.ToString() } };
        //                                cnn.SQL_ExecuteStoredProcedure("SP_TonKhoTucThoi", Thamso);
        //                            }
        //                    }

        //                    //Export Nav
        //                    {
        //                        SaveFileDialog filename = new SaveFileDialog();
        //                        filename.FileName = f;
        //                        var Thamso = new Dictionary<String, String>() { { "ID", _ID.ToString() } };
        //                        dt = cnn.SQL_GetStoredProcedure("SP_ExportNAV_SX", Thamso);
        //                        dt.Columns.Add("Chuoi");
        //                        foreach (DataRow dr in dt.Rows)
        //                        {
        //                            dr["Chuoi"] =
        //                            "\"" + dr["WeightNote"] + "\";" +
        //                            "\"" + Convert.ToDateTime(dr["Date"]).ToString("dd/MM/yyyy") + "\";" +
        //                            "\"" + dr["VendorNo"] + "\";" +
        //                            "\"" + dr["ItemNo"] + "\";" +
        //                            "\"" + dr["Code"] + "\";" +
        //                            "\"" + dr["LocationName"] + "\";" +
        //                            "\"" + dr["Vehicle"] + "\";" +
        //                            "\"" + Convert.ToInt32(dr["GrossWeight"]) + "\";" +
        //                            "\"" + Convert.ToInt32(dr["TruckTare"]) + "\";" +
        //                            "\"" + Convert.ToInt32(dr["NetWeight"]) + "\";" +
        //                            "\"" + Convert.ToInt32(dr["TruckQty"]) + "\";" +
        //                            "\"" + dr["TotalBagWeight"] + "\";" +
        //                            "\"" + Convert.ToInt32(dr["QRCodeQty"]) + "\";" +
        //                            "\"" + dr["WeightType"] + "\";" +
        //                            "\"" + dr["TransportCode"] + "\"";
        //                        }
        //                        for (int i = dt.Columns.Count - 1; i >= 0; i--)
        //                        {
        //                            if (dt.Columns[i].ColumnName != "Chuoi")
        //                                dt.Columns.RemoveAt(i);
        //                        }
        //                    }                            
        //                    new frmExport(dt, f);
        //                    Form_Load();
        //                    XtraMessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
        //                }
        //            }
        //            catch { }
        //        }
        //    }
        //}

        public void Chitiet_Load()
        {
            Tabpage = new XtraTabPage();
            Tabpage.Text = "Chi tiết Lệnh sản xuất";
            Tabpage.Name = "TabChitiet";

            for (int i = 0; i < xtraTabControl1.TabPages.Count; i++)
            {
                if (xtraTabControl1.TabPages[i].Name == "TabChitiet")
                {
                    xtraTabControl1.TabPages.RemoveAt(i);
                }
            }

            xtraTabControl1.TabPages.Add(Tabpage);

            xtraTabControl1.SelectedTabPage = Tabpage;

            frmSanXuat SX = new frmSanXuat(this);
            SX.TopLevel = false;
            Tabpage.Controls.Add(SX);
            SX.Dock = DockStyle.Fill;
            SX.Chungtu = CT;
            SX.__ID = ID;
            SX.NgayTao = Ngay;
            SX.Show();
        }
    }
}
