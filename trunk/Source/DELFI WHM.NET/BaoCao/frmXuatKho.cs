using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DELFI_WHM.NET.Models;

namespace DELFI_WHM.NET.BaoCao
{
    public partial class frmXuatKho : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string Tungay, Denngay, Khachhang, Sanpham, LenhGH;
        
        public frmXuatKho()
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

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void cboKhachhang_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var q = db.DM_KhachHang.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaKhachHang");
                dt.Columns.Add("TenKhachHang");
                dt = ConvertToDataTable(q);
                cboKhachhang.uDataSource = dt;
            }
        }

        private void cboLenhGH_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var p = db.DM_LenhGiaoHang.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("SaleOrderCalNo");
                dt.Columns.Add("PostingDate");
                dt.Columns.Add("SaleContractNo");
                dt = ConvertToDataTable(p);
                cboLenhGH.uDataSource = dt;
            }
        }

        private void cboSanPham_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var data = db.tblItems.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ItemNo");
                dt.Columns.Add("ItemName");
                dt = ConvertToDataTable(data);
                cboSanPham.uDataSource = dt;
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

        private void Search()
        {
            Tungay = Convert.ToDateTime(dtpTuNgay.uValue).ToString("yyyy-MM-dd");
            Denngay = Convert.ToDateTime(dtpDenNgay.uValue).AddDays(1).ToString("yyyy-MM-dd");
            
            if (!cnn.bComboIsNull(cboLenhGH))
            {
                LenhGH = cboLenhGH.uEditValue.ToString();
            }
            else
            {
                LenhGH = "";
            }
            if(!cnn.bComboIsNull(cboKhachhang))
            {
                Khachhang = cboKhachhang.uEditValue.ToString();
            }
            else
            {
                Khachhang = "";
            }
            if (!cnn.bComboIsNull(cboSanPham))
            {
                Sanpham = cboSanPham.uEditValue.ToString();
            }
            else
            {
                Sanpham = "";
            }
            var Thamso = new Dictionary<String, String>() { { "Tungay", Tungay }, { "Denngay", Denngay }, { "DocumentNo", LenhGH }, 
                                                            { "VendorCode", Khachhang }, { "ItemNo", Sanpham }};
            griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_XuatKho", Thamso);
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                if (gridView1.Columns[i].FieldName == "Tieude")
                {
                    gridView1.Columns[i].Visible = false;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();            
            dt = (DataTable)griDanhSach.DataSource;           
            if (dt != null)
            {
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_PhieuXuat.repx", dt);                
                frm.Show();
               
            }
        }

        private void frmXuatKho_Load(object sender, EventArgs e)
        {
            dtpTuNgay.uValue = cnn.GetDateServer();
            dtpDenNgay.uValue = cnn.GetDateServer();            
            Search();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

    }
}
