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
    public partial class frm_BC_SuaPhieuCan : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string Tungay, Denngay;
        
        public frm_BC_SuaPhieuCan()
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
            Tungay = Convert.ToDateTime(dtpTuNgay.uValue).ToString("yyyy-MM-dd");
            Denngay = Convert.ToDateTime(dtpDenNgay.uValue).AddDays(1).ToString("yyyy-MM-dd");

            var Thamso = new Dictionary<String, String>() { { "Tungay", Tungay }, { "Denngay", Denngay }, { "WeightNote", txtWeightNote.uText }, { "Loai", "PhieuCanCau" } };
            griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_SuaPhieuCan", Thamso);
            gridView2.BestFitColumns();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();            
            dt = (DataTable)griDanhSach.DataSource;
            if (dt != null)
            {
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_SuaPhieuCan.repx", dt);                
                frm.Show();
            }
        }

        private void frm_BC_SuaPhieuCan_Load(object sender, EventArgs e)
        {
            dtpTuNgay.uValue = cnn.GetDateServer();
            dtpDenNgay.uValue = cnn.GetDateServer();
        }

        private void gridView2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView2.OptionsSelection.MultiSelect = true;
                gridView2.SelectAll();
            }            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

    }
}
