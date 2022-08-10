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
using DevExpress.XtraGrid.Views.Grid;

namespace DELFI_WHM.NET.CauHinh
{
    public partial class frmLocations : DevExpress.XtraEditors.XtraForm
    {
        public frmLocations()
        {
            InitializeComponent();
        }

        private void Search()
        {
            this.Cursor = Cursors.WaitCursor;
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var data = db.DM_Location.Where(c => c.Code.Contains(txtCode.Text) && c.LocationName.Contains(txtName.Text)).ToList();
                if (data != null)
                {
                    griDanhSach.DataSource = data;
                }
            }
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

        private bool Check_Cond()
        {
            if (txtCode.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập Mã Location", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.SelectAll();
                return false;
            }
            if (txtName.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập Tên Location", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.SelectAll();
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Check_Cond())
                return;
            this.Cursor = Cursors.WaitCursor;
            using (DBACOMEntities db = new DBACOMEntities())
            { 
                var query = (from s in db.DM_Location
                              where s.Code == txtCode.uText
                              select s).FirstOrDefault<DM_Location>();
               if (query == null)
                {
                    db.DM_Location.Add(new DM_Location
                    {
                        Code = txtCode.Text,
                        LocationName = txtName.Text
                    });
                    db.SaveChanges();
                    XtraMessageBox.Show("Cập nhật danh sách thành công");
                }     
               else if (query != null)
                {
                    DM_Location q = db.DM_Location.Where(c => c.Code == txtCode.uText).FirstOrDefault();
                    q.Code = txtCode.uText;
                    q.LocationName = txtName.uText;
                    if (db.SaveChanges() > 0)
                    {
                        XtraMessageBox.Show("Cập nhật danh sách thành công");
                    }
                }
                Search();
            }
            this.Cursor = Cursors.Default;
            
        }

        private void frmLocations_Load(object sender, EventArgs e)
        {
            Search();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if(gridView1.FocusedRowHandle >= 0)
            {
                txtCode.Text = gridView1.GetFocusedRowCellValue(("Code")).ToString();
                txtName.Text = gridView1.GetFocusedRowCellValue("LocationName").ToString();
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
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
    }
}
