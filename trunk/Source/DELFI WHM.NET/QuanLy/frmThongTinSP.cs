using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DELFI_WHM.NET.DELFI_Class;
using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.QuanLy
{
    public partial class frmThongTinSP : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        public static string Access_Connection = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Database.mdb";
        string _ItemCode = "";
        string _Lot = "";
        string _Cer = "NONE";
        string _Quicach = "";
        string _Vitri = "";
        decimal QrCodeQty = 0;
        decimal GrossWeight = 0;
        decimal TotalPackageQty = 0;
        Boolean Sample = false;

        public frmThongTinSP()
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
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.WH_TonKho.Where(c => c.Exported == false && c.QRCodeQty != 0 && c.TruckQty != 0).ToList();
                if (list.Count > 0)
                {
                    griDanhSach.DataSource = list;
                }
            }
            for (int i = 0; i < gridView2.Columns.Count; i++)
            {
                gridView2.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
        }

        private bool Check_Cond()
        {
            _ItemCode = txtMaPallet.uText;
            using (DBACOMEntities db = new DBACOMEntities())
            {
                    var list = db.WH_TonKho.Where(c => c.QRCode == _ItemCode && c.QRCodeQty != 0 && c.TruckQty != 0 && c.Exported == false).ToList();
                    if (list.Count == 0)
                    {
                        XtraMessageBox.Show("Mã QRCode không hợp lệ, chỉ chuyển được QRCode đã có Trọng lượng và Số bao", "Thông báo");
                        return false;
                    }
            }
            if (cnn.bComboIsNull(cboQuicach))
            {
                XtraMessageBox.Show("Loại bao bì không được bỏ trống", "Thông báo");
                return false;
            }
            if (txtMaPallet.uText.Length == 0)
            {
                XtraMessageBox.Show("Mã QRCode không được bỏ trống", "Thông báo");
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

        private void Check()
        {
            string QRCode = txtMaPallet.uText;
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.WH_TonKho.Where(c => c.QRCode == QRCode).ToList();
                _Lot = list[0].Lot;
                if (!cnn.bComboIsNull(cboCer))
                {
                    _Cer = cboCer.uEditValue.ToString();
                }
                else
                {
                    _Cer = "NONE";
                }
                if (!cnn.bComboIsNull(cboQuicach))
                {
                    _Quicach = cboQuicach.uEditValue.ToString();
                }
                else
                {
                    _Quicach = "";
                }                
                if (!cnn.bComboIsNull(cboVitri))
                {
                    _Vitri = cboVitri.uEditValue.ToString();
                }
                else
                {
                    _Vitri = "RECEIVING";
                }
            }                   
        }

        private void History()
        {
            string chuoi = "";
            string QRCode = txtMaPallet.uText;
            Check();
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var pc = db.WH_TonKho.Where(c => c.QRCode == QRCode).ToArray().FirstOrDefault();
                if (pc != null)
                {
                    if (pc.Lot != cboLot.uEditValue.ToString())
                    {
                        chuoi += "Sửa Lot " + pc.Lot + " thành " + cboLot.uEditValue.ToString() + "\n";
                    }
                    if (pc.Certificate != cboCer.uEditValue.ToString())
                    {
                        chuoi += " Sửa Certificate " + pc.Certificate + " thành " + cboCer.uEditValue.ToString() + "\n";
                    }
                    if (pc.PackageCode != cboQuicach.uEditValue.ToString())
                    {
                        chuoi += " Sửa loại bao bì " + pc.PackageCode + " thành " + cboQuicach.uEditValue.ToString() + "\n";
                    }
                    if (pc.BinCode != cboVitri.uEditValue.ToString())
                    {
                        chuoi += " Sửa cây hàng " + pc.BinCode + " thành " + cboVitri.uEditValue.ToString() + "\n";
                    }                    
                }
                if (chuoi != "")
                {
                    db.HIS_Phieucancau.Add(new HIS_Phieucancau
                    {
                        ID_WeightNote = Convert.ToInt32(spnID.uValue),
                        Dateupdate = cnn.GetDateServer(),
                        UserName = Properties.Settings.Default.USER_NAME,
                        Desc = chuoi,
                        Loai = "UpdateSP"
                    });
                    db.SaveChanges();
                }
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Check_Cond())
                return;
            History();
            Check();
            var Up = new Dictionary<String, String>() { { "QRCode", txtMaPallet.uText },
                                                        { "Lot", _Lot},
                                                        { "Cer", _Cer},
                                                        { "PackageCode", _Quicach},
                                                        { "BinCode", _Vitri},
                                                        { "Sample", Sample.ToString()},
                                                        { "GrossWeight", GrossWeight.ToString()},
                                                        { "TotalPackageQty", TotalPackageQty.ToString()},
                                                        { "QRCodeQty", QrCodeQty.ToString() },
                                                        { "UserName", Properties.Settings.Default.USER_NAME}};
            cnn.SQL_ExecuteStoredProcedure("SP_UPDATE_ThongTinSP", Up);

            Search();

            cnn.clearControl(groupBox1);
            XtraMessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
        }

        private void cboQuicach_uEditValueChanged(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboQuicach))
            {
                string Quicach = cboQuicach.uEditValue.ToString();
                using (DBACOMEntities DB = new DBACOMEntities())
                {
                    var qc = DB.DM_Packing.Where(c => c.PackageCode == Quicach).First();
                    if (qc != null)
                    {
                        cboLoai.uEditValue = qc.PackageType;
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Load_cboCer();
            Load_cboMaSanPham();
            Load_cboQuicach();
            Load_cboVitri();

            for (int i = 0; i < gridView2.RowCount; i++)
            {
                if (gridView2.GetRowCellValue(i, "Exported").ToString() == "True")
                {
                    txtMaPallet.uText = gridView2.GetRowCellValue(i, "QRCode").ToString();
                    cboMaSanPham.uEditValue = gridView2.GetRowCellValue(i, "ItemNo").ToString();
                    cboLot.uEditValue = gridView2.GetRowCellValue(i, "Lot").ToString();
                    cboCer.uEditValue = gridView2.GetRowCellValue(i, "Certificate").ToString();
                    cboQuicach.uEditValue = gridView2.GetRowCellValue(i, "PackageCode").ToString();
                    cboVitri.uEditValue = gridView2.GetRowCellValue(i, "BinCode").ToString();
                    spnID.uValue = Convert.ToInt32(gridView2.GetRowCellValue(i, "ID").ToString());
                }
            }
        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void frmThongTinSP_Load(object sender, EventArgs e)
        {
            Search();
        }

        private void cboMaSanPham_uEditValueChanged(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboMaSanPham))
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    _ItemCode = cboMaSanPham.uEditValue.ToString();
                    {
                        var Lot = db.DM_Lot.Where(c => c.ItemCode == _ItemCode).ToList();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Lot");
                        dt.Columns.Add("CropYear");
                        dt = ConvertToDataTable(Lot);
                        cboLot.uDataSource = dt;
                    }
                }
        }

        private void txtMaPallet_uKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Load_cboCer();
                Load_cboMaSanPham();
                Load_cboQuicach();
                Load_cboVitri();
                _ItemCode = txtMaPallet.uText;
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    var list = db.WH_TonKho.Where(c => c.QRCode == _ItemCode).ToList();
                    if (list.Count > 0)
                    {
                        cboMaSanPham.uEditValue = list[0].ItemNo;
                        cboLot.uEditValue = list[0].Lot;
                        cboCer.uEditValue = list[0].Certificate;
                        cboQuicach.uEditValue = list[0].PackageCode;
                        cboVitri.uEditValue = list[0].BinCode;
                        spnID.uValue = Convert.ToInt32(list[0].ID);
                    }
                    else
                    {
                        XtraMessageBox.Show("Mã QRCode không hợp lệ", "Thông báo");
                    }
                }
            }
        }

        int TrongLuongCan = 0;

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

        private void Load_cboQuicach()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                {
                    var Quicach = db.DM_Packing.ToList();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("PackageCode");
                    dt = ConvertToDataTable(Quicach);
                    cboQuicach.uDataSource = dt;
                }
                {
                    var Loai = db.DM_LoaiBao.ToList();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Loai");
                    dt = ConvertToDataTable(Loai);
                    cboLoai.uDataSource = dt;
                }
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

        private void cboMaSanPham_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboMaSanPham();
        }

        private void cboCer_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboCer();
        }

        private void cboQuicach_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboQuicach();
        }

        private void cboVitri_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboVitri();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            Load_cboCer();
            Load_cboMaSanPham();
            Load_cboQuicach();
            Load_cboVitri();

            txtMaPallet.uText       = gridView2.GetFocusedRowCellValue("QRCode").ToString();
            cboMaSanPham.uEditValue = gridView2.GetFocusedRowCellValue("ItemNo").ToString();
            cboLot.uEditValue       = gridView2.GetFocusedRowCellValue("Lot").ToString();
            cboCer.uEditValue       = gridView2.GetFocusedRowCellValue("Certificate").ToString();
            cboQuicach.uEditValue   = gridView2.GetFocusedRowCellValue("PackageCode").ToString();
            cboVitri.uEditValue     = gridView2.GetFocusedRowCellValue("BinCode").ToString();
            spnID.uValue            = Convert.ToInt32(gridView2.GetFocusedRowCellValue("ID").ToString());
        }

        private void gridView2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView2.OptionsSelection.MultiSelect = true;
                gridView2.SelectAll();
            }
        }
    }
}

