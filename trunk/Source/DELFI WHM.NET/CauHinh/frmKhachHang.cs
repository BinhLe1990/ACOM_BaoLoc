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

namespace DELFI_WHM.NET.CauHinh
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void Search()
        {
            this.Cursor = Cursors.WaitCursor;
            griDanhSach.DataSource = cnn.DT_DataTable("SELECT * FROM DM_KhachHang");
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
                var link = db.tblConfigLinkSync.Where(c => c.Value.Equals("DM_KHACHHANG")).Select(p => p.Description).ToArray();
                string[] lines = cnn.Import_NAV(link[0]);
                foreach (string line in lines)
                {
                    string[] MKH = line.Split(';');
                    string _MaKhachHang = MKH[0].Replace("\"", "");
                    string _TenKhachHang = MKH[1].Replace("\"", "");
                    
                    var query = (from s in db.DM_KhachHang
                                 where s.MaKhachHang == _MaKhachHang
                                 select s).FirstOrDefault<DM_KhachHang>();
                    if (query == null)
                    {
                        db.DM_KhachHang.Add(new DM_KhachHang
                        {
                            MaKhachHang = _MaKhachHang,
                            TenKhachHang = _TenKhachHang
                        });
                        db.SaveChanges();
                    }
                }
                Search();
            }
            this.Cursor = Cursors.Default;
            XtraMessageBox.Show("Cập nhật danh sách thành công");
        }
        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            Search();
        }

        private void gridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView1.OptionsSelection.MultiSelect = true;
                gridView1.SelectAll();
            }
        }
    }
}
