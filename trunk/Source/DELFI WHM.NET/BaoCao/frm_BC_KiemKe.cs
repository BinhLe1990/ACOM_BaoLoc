using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DELFI_WHM.NET.Models;
using DevExpress.Data;
using DevExpress.XtraGrid;

namespace DELFI_WHM.NET.BaoCao
{
    public partial class frm_BC_KiemKe : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string Tungay, Denngay, PhanTram_CT, PhanTram_TH, SoPhieuKK;
        decimal ChenhLech_CT, ChenhLech_TH, TrongLuong_CT, TrongLuong_TH;

        clsRun clRun = new clsRun();

        private void gridView_Tonghop_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        public void Footer_TongHop()
        {
            if (gridView_Tonghop.RowCount > 0)
            {
                ChenhLech_TH = Convert.ToDecimal(gridView_Tonghop.Columns["ChenhLech"].SummaryText);
                TrongLuong_TH = Convert.ToDecimal(gridView_Tonghop.Columns["QRCodeQty"].SummaryText);
                if (TrongLuong_TH == 0)
                {
                    TrongLuong_TH = ChenhLech_TH;
                }
                else
                {
                    TrongLuong_TH = TrongLuong_TH;
                }
                try
                {
                    PhanTram_TH = (Math.Round((decimal)ChenhLech_TH * 100 / TrongLuong_TH, 2)).ToString() + "%";
                    gridView_Tonghop.Columns["PhanTramChenhLech"].SummaryItem.DisplayFormat = PhanTram_TH;
                }
                catch
                {
                    gridView_Tonghop.Columns["PhanTramChenhLech"].SummaryItem.DisplayFormat = "0%";
                }
            }
        }

        public void Footer_ChiTiet()
        {
            if (gridView_Chitiet.RowCount > 0)
            {
                ChenhLech_CT = Convert.ToDecimal(gridView_Chitiet.Columns["ChenhLech"].SummaryText);
                TrongLuong_CT = Convert.ToDecimal(gridView_Chitiet.Columns["QRCodeQty"].SummaryText);
                if (TrongLuong_CT == 0)
                {
                    TrongLuong_CT = ChenhLech_CT;
                }
                else
                {
                    TrongLuong_CT = TrongLuong_CT;
                }
                try
                {
                    PhanTram_CT = (Math.Round((decimal)ChenhLech_CT * 100 / TrongLuong_CT, 2)).ToString() + "%";
                    gridView_Chitiet.Columns["PhanTramChenhLech"].SummaryItem.DisplayFormat = PhanTram_CT;
                }
                catch
                {
                    gridView_Chitiet.Columns["PhanTramChenhLech"].SummaryItem.DisplayFormat = "0%";
                }
            }
        }

        public void Load_Chitiet(string _TuNgay, string _DenNgay, string _SoPhieuKK)
        {
            var Thamso = new Dictionary<String, String>() { { "Tungay", _TuNgay }, { "Denngay", _DenNgay }, { "Type", "1" } , { "SoPhieuKK", _SoPhieuKK } };
            grid_Chitiet.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_KiemKe", Thamso);
            gridView_Chitiet.BestFitColumns();
            Footer_ChiTiet();
        }

        private void gridView_Tonghop_ColumnFilterChanged(object sender, EventArgs e)
        {
            Footer_TongHop();
        }

        private void gridView_Chitiet_ColumnFilterChanged(object sender, EventArgs e)
        {
            Footer_ChiTiet();
        }

        private void gridView_Tonghop_DoubleClick(object sender, EventArgs e)
        {
            Tungay = Convert.ToDateTime(gridView_Tonghop.GetFocusedRowCellValue("NgayKK")).ToString("yyyy-MM-dd");
            SoPhieuKK = gridView_Tonghop.GetFocusedRowCellValue("SoPhieuKK").ToString();
            Load_Chitiet(Tungay, Tungay, SoPhieuKK);
            Tab.SelectedTabPage = Tab_Chitiet;
        }

        public frm_BC_KiemKe()
        {
            InitializeComponent();
            clRun.SetValueToControl(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Tungay = Convert.ToDateTime(dtpTuNgay.uValue).ToString("yyyy-MM-dd");
            Denngay = Convert.ToDateTime(dtpDenngay.uValue).ToString("yyyy-MM-dd");

            Load_Chitiet(Tungay, Denngay, "");

            var Thamso2 = new Dictionary<String, String>() { { "Tungay", Tungay }, { "Denngay", Denngay }, { "Type", "2" },  { "SoPhieuKK", "" } };
            grid_Tonghop.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_KiemKe", Thamso2);
            gridView_Tonghop.BestFitColumns();
            Footer_TongHop();
        }

        private void gridView_Chitiet_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView_Chitiet_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView_Chitiet.OptionsSelection.MultiSelect = true;
                gridView_Chitiet.SelectAll();
            }
        }

        private void frm_BC_KiemKe_Load(object sender, EventArgs e)
        {
            dtpTuNgay.uValue = cnn.GetDateServer();
            dtpDenngay.uValue = cnn.GetDateServer();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (Tab.SelectedTabPage == Tab_Chitiet)
            {
                DataTable dt = new DataTable();
                dt = (DataTable)grid_Chitiet.DataSource;
                if (dt != null)
                {
                    BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_KiemKe.repx", dt);
                    frm.Show();
                }
            }
            else if (Tab.SelectedTabPage == Tab_Tonghop)
            {
                DataTable dt = new DataTable();
                dt = (DataTable)grid_Tonghop.DataSource;
                if (dt != null)
                {
                    BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_KiemKe_TH.repx", dt);
                    frm.Show();
                }
            }
        }
    }
}
