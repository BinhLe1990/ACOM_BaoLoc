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

namespace DELFI_WHM.NET.CauHinh
{
    public partial class frmCropYear : DevExpress.XtraEditors.XtraForm
    {
        public frmCropYear()
        {
            InitializeComponent();
        }

        private void Search()
        {
            this.Cursor = Cursors.WaitCursor;
            using (DBACOMEntities db = new DBACOMEntities())
            {
                {
                    var data = db.DM_CropYear.ToList();
                    if (data != null)
                    {
                        gridCropyear.DataSource = data;
                    }
                }
                {
                    var data = db.DM_Certificate.ToList();
                    if (data != null)
                    {
                        gridCertification.DataSource = data;
                    }
                }
                {
                    var data = db.DM_Pile.ToList();
                    if (data != null)
                    {
                        gridPile.DataSource = data;
                    }
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void frmCropYear_Load(object sender, EventArgs e)
        {
            Search();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView3_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void btnLuuCropyear_Click(object sender, EventArgs e)
        {
            if (txtCropyear.Text.Trim() != "")
            {
                this.Cursor = Cursors.WaitCursor;
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    DM_CropYear lc = new DM_CropYear();

                    db.DM_CropYear.Add(new DM_CropYear
                    {
                        Ten = txtCropyear.Text
                    });
                    var query = (from s in db.DM_CropYear
                                 where s.Ten == txtCropyear.Text
                                 select s).FirstOrDefault<DM_CropYear>();
                    if (query == null)
                    {
                        db.SaveChanges();
                    }
                    Search();
                }
                this.Cursor = Cursors.Default;
                XtraMessageBox.Show("Cập nhật danh sách thành công");
            }
        }

        private void btnLuuCertification_Click(object sender, EventArgs e)
        {
            if (txtCertification.Text.Trim() != "")
            {
                this.Cursor = Cursors.WaitCursor;
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    DM_Certificate lc = new DM_Certificate();

                    db.DM_Certificate.Add(new DM_Certificate
                    {
                        Ten = txtCertification.Text
                    });
                    var query = (from s in db.DM_Certificate
                                 where s.Ten == txtCertification.Text
                                 select s).FirstOrDefault<DM_Certificate>();
                    if (query == null)
                    {
                        db.SaveChanges();
                    }
                    Search();
                }
                this.Cursor = Cursors.Default;
                XtraMessageBox.Show("Cập nhật danh sách thành công");
            }
        }

        private void btnLuuPile_Click(object sender, EventArgs e)
        {
            if (txtPile.Text.Trim() != "")
            {
                this.Cursor = Cursors.WaitCursor;
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    DM_Pile lc = new DM_Pile();

                    db.DM_Pile.Add(new DM_Pile
                    {
                        BinCode = txtPile.Text.ToUpper()
                    });
                    string _BinCode = txtPile.Text.ToUpper();
                    var query = (from s in db.DM_Pile
                                 where s.BinCode == _BinCode
                                 select s).FirstOrDefault<DM_Pile>();
                    if (query == null)
                    {
                        db.SaveChanges();
                    }
                    Search();
                }
                this.Cursor = Cursors.Default;
                XtraMessageBox.Show("Cập nhật danh sách thành công");
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

        private void gridView3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView3.OptionsSelection.MultiSelect = true;
                gridView3.SelectAll();
            }
        }
    }
}
