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

namespace DELFI_WHM.NET.QuanLy
{

    public partial class frmHopDongMuaHang : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        public frmHopDongMuaHang()
        {
            InitializeComponent();
        }
      
        private void Search()
        {
            this.Cursor = Cursors.WaitCursor;
            DateTime Tungay = Convert.ToDateTime(dtpTuNgay.uValue).Date;
            DateTime Denngay = Convert.ToDateTime(dtpDenNgay.uValue).Date;
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var data = db.DM_PurchaseContract
                    .Where(c => c.ContractNo.Contains(txtSoHopDong.Text)  &&
                                          c.ContractDate >= Tungay && c.ContractDate <= Denngay).OrderByDescending(c => c.ContractDate).ToList();
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

        private void btnDongBo_Click(object sender, EventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                this.Cursor = Cursors.WaitCursor;
                OpenFileDialog openFD = new OpenFileDialog();
                var link = db.tblConfigLinkSync.Where(c => c.Value.Equals("DM_PurchaseContract")).Select(p => p.Description).ToArray();
                string[] lines = cnn.Import_NAV(link[0]);
                foreach (string line in lines)
                {
                    string[] PO = line.ToString().Replace("\",", "\";").Split(';');
                    string _ContractNo          = PO[0].Replace("\"", "");
                    string _VendorNo            = PO[1].Replace("\"", "");
                    string _VendorName          = PO[2].Replace("\"", "");
                    string _ContractDate        = PO[3].Replace("\"", "");
                    string _LocationName        = PO[4].Replace("\"", "");
                    string _LocationCode        = PO[5].Replace("\"", "");
                    string _ItemNo              = PO[6].Replace("\"", "");
                    string _Cert                = PO[7].Replace("\"", "");
                    string _CropYear            = PO[8].Replace("\"", "");
                    string _ContractNetWeight   = PO[9].Replace("\"", "");
                    string _UnitOfMeasure       = PO[10].Replace("\"", "");
                    string _WeightNoteNo        = PO[11].Replace("\"", "");


                    db.DM_PurchaseContract.Add(new DM_PurchaseContract
                    {
                        ContractNo          = _ContractNo,
                        VendorNo            = _VendorNo,
                        VendorName          = _VendorName,
                        ContractDate        = Convert.ToDateTime(_ContractDate),
                        LocationCode        = _LocationCode,
                        LocationName        = _LocationName,
                        ItemNo              = _ItemNo,
                        Cert                = _Cert,     
                        CropYear            = _CropYear,
                        ContractNetWeight   = Convert.ToDecimal(_ContractNetWeight),
                        UnitOfMeasure       = _UnitOfMeasure,
                        WeightNoteNo        = _WeightNoteNo 
                    });
                    var query = (from s in db.DM_PurchaseContract
                                 where s.ContractNo == _ContractNo && s.WeightNoteNo == _WeightNoteNo
                                 select s).FirstOrDefault<DM_PurchaseContract>();
                    if (query == null)
                    {
                        db.SaveChanges();
                    }
                }
                Search();
            }
            this.Cursor = Cursors.Default;
            XtraMessageBox.Show("Cập nhật danh sách thành công");
        }

        private void frmHopDongMuaHang_Load(object sender, EventArgs e)
        {
            dtpTuNgay.uValue = cnn.GetDateServer().AddDays(-7);
            dtpDenNgay.uValue = cnn.GetDateServer();
            Search();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
