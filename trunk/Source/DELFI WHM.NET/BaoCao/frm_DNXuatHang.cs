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
    public partial class frm_DNXuatHang : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string Ngay;
        
        public frm_DNXuatHang()
        {
            InitializeComponent();
        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void Search()
        {
            Ngay = Convert.ToDateTime(dtpNgay.uValue).ToString("yyyy-MM-dd");

            var Thamso = new Dictionary<String, String>() {{ "Ngay", Ngay}};
            griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_DNXuatHang", Thamso);            
            gridView2.BestFitColumns();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gridView2.PostEditor();
            DataTable dt = new DataTable();
            dt.Columns.Add("BatchNo");
            dt.Columns.Add("ItemNo");
            dt.Columns.Add("Lot");
            dt.Columns.Add("PalletQty", typeof(int));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("BinCode");
            dt.Columns.Add("Note");
            dt.Columns.Add("PostingDate", typeof(DateTime));
            dt.Columns.Add("NguoiDeNghi");
            for (int i = 0; i< gridView2.RowCount; i ++)
            {
                if (gridView2.GetRowCellValue(i, "Chon").ToString() == "True")
                    dt.Rows.Add(gridView2.GetRowCellValue(i, "BatchNo").ToString(),
                                gridView2.GetRowCellValue(i, "ItemNo").ToString(),
                                gridView2.GetRowCellValue(i, "Lot").ToString(),
                                gridView2.GetRowCellValue(i, "PalletQty"),
                                gridView2.GetRowCellValue(i, "Quantity"),
                                gridView2.GetRowCellValue(i, "BinCode").ToString(),
                                gridView2.GetRowCellValue(i, "Note").ToString(),
                                gridView2.GetRowCellValue(i, "PostingDate"),
                                Properties.Settings.Default.FULL_NAME);
            }
            if (dt != null)
            {
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_DNXuatHang.repx", dt);                
                frm.Show();
            }
        }

        private void frm_DNXuatHang_Load(object sender, EventArgs e)
        {
            dtpNgay.uValue = cnn.GetDateServer();           
            Search();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
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
