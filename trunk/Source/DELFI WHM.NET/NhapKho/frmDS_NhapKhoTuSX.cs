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

namespace DELFI_WHM.NET.NhapKho
{
    public partial class frmDS_NhapKhoTuSX : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string Tungay, Denngay;
        string CT, CT_LSX;
        DateTime Ngay;
        string QRCode;
        XtraTabPage Tabpage;
        public frmDS_NhapKhoTuSX()
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
            Tungay = Convert.ToDateTime(dtpTungay.uValue).ToString("yyyy-MM-dd");
            Denngay = Convert.ToDateTime(dtpDenngay.uValue).ToString("yyyy-MM-dd");
            var Thamso = new Dictionary<String, String>() { { "Tungay", Tungay }, { "Denngay", Denngay } };
            griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_NhapTuSX", Thamso);
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                gridView1.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            CT = "";
            Ngay = cnn.GetDateServer();
            QRCode = cnn.GetDateServer().ToString("yyyyMMddHHmmss") + "001";            
            Chitiet_Load();           
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Form_Load();
        }

        private void frmDS_NhapKhoTuSX_Load(object sender, EventArgs e)
        {            
            CT = "";
            Ngay = cnn.GetDateServer();
            dtpTungay.uValue = cnn.GetDateServer().AddDays(-7);
            dtpDenngay.uValue = cnn.GetDateServer();
            QRCode = Convert.ToDateTime(cnn.GetDateServer()).ToString("yyyyMMddHHmmss") + "001";
            Form_Load();
            Chitiet_Load();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("Lot") != null)
            {
                CT = gridView1.GetFocusedRowCellValue("Lot").ToString();                
                QRCode = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("PostingDate")).ToString("yyyyMMddHHmmss") + "001";
                Chitiet_Load();
            }
        }

        public void Chitiet_Load()
        {
            Tabpage = new XtraTabPage();
            Tabpage.Text = "Chi tiết nhập kho";
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
            frmNhapKhoTuSX nk = new frmNhapKhoTuSX(this);
            nk.TopLevel = false;
            Tabpage.Controls.Add(nk);
            nk.Dock = DockStyle.Fill;
            nk.Chungtu = CT;
            nk.Chungtu_LSX = cnn.sNull2String(gridView1.GetFocusedRowCellValue("ContractNo"));
            nk.QR = QRCode;
            nk.Show();
        }        
    }
}
