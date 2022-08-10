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

namespace DELFI_WHM.NET.XuatKho
{
    public partial class frmDS_XuatKho : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        DateTime Tungay, Denngay;
        DateTime Ngay;
        string CT;
        XtraTabPage Tabpage;

        public frmDS_XuatKho()
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
                var list = db.ChiTietSoanHang.Where(c => c.Datetime >= Tungay.Date && c.Datetime <= Denngay.Date).GroupBy(c=>new { c.DocumentNo, c.Datetime }).Select(p=> new { p.Key.DocumentNo, p.Key.Datetime }).ToList();
                if (list.Count >0)
                {
                    griDanhSach.DataSource = list;
                }               
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            CT = "";
            Ngay = DateTime.Now;
            Chitiet_Load();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Form_Load();
        }

        private void frmDS_XuatKho_Load(object sender, EventArgs e)
        {
            dtpTungay.uValue = DateTime.Now.AddDays(-7);
            dtpDenngay.uValue = DateTime.Now;
            Form_Load();
            CT = "";
            Ngay = DateTime.Now;
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
            if (gridView1.GetFocusedRowCellValue("DocumentNo") != null)
            {
                CT = gridView1.GetFocusedRowCellValue("DocumentNo").ToString();
                Ngay = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("Datetime"));
                Chitiet_Load();
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

        public void Chitiet_Load()
        {
            Tabpage = new XtraTabPage();
            Tabpage.Text = "Chi tiết xuất kho";
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

            frmXuatKho XK = new frmXuatKho(this);
            XK.TopLevel = false;
            Tabpage.Controls.Add(XK);
            XK.Dock = DockStyle.Fill;
            XK.NgayTao = Ngay;
            XK.Chungtu = CT;
            XK.Show();
        }
    }
}
