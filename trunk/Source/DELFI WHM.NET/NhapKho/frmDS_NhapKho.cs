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
    public partial class frmDS_NhapKho : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        DateTime Tungay, Denngay;
        string CT;
        DateTime Ngay;
        XtraTabPage Tabpage;
        public frmDS_NhapKho()
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
            Tungay =Convert.ToDateTime(dtpTungay.uValue).Date;           
            Denngay = Convert.ToDateTime(dtpDenngay.uValue).Date;
            using (DBACOMEntities db = new DBACOMEntities())
            {                
                var list = db.DM_PhieuNhap.Where(c=>c.PostingDate >= Tungay && c.PostingDate <= Denngay && c.Type == "Purchase").ToList();
                if (list != null)
                {
                    griDanhSach.DataSource = list;
                }               
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            Ngay = cnn.GetDateServer();            
            CT = "";
            Chitiet_Load();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Form_Load();
        }

        private void frmDS_NhapKho_Load(object sender, EventArgs e)
        {
            Ngay = cnn.GetDateServer();
            dtpTungay.uValue = cnn.GetDateServer().AddDays(-7);
            dtpDenngay.uValue = cnn.GetDateServer();
            Form_Load();            
            CT = "";
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
            if (gridView1.GetFocusedRowCellValue("WeightNote") != null)
            {
                CT = gridView1.GetFocusedRowCellValue("WeightNote").ToString();
                Ngay = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("PostingDate"));
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

            //frmNhapKhoThanhPham nk = new frmNhapKhoThanhPham(this);
            //nk.TopLevel = false;
            //Tabpage.Controls.Add(nk);
            //nk.Dock = DockStyle.Fill;
            //nk.NgayTao = Ngay;
            //nk.Chungtu = CT;
            //nk.Show();
        }
    }
}
