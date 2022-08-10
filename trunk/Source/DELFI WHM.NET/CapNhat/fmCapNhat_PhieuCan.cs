using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DELFI_WHM.NET.Models;

namespace DELFI_WHM.NET.CapNhat
{
    public partial class fmCapNhat_PhieuCan : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string Tungay, Denngay;       

        clsRun clRun = new clsRun();
        public fmCapNhat_PhieuCan()
        {
            clRun.SetPermit(this);
            InitializeComponent();
            clRun.SetValueToControl(this);
        }

        private void gridView_Chitiet_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView_Chitiet_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void Search()
        {
            Tungay = Convert.ToDateTime(dtpTuNgay.uValue).ToString("yyyy-MM-dd");
            Denngay = Convert.ToDateTime(dtpDenNgay.uValue).AddDays(1).ToString("yyyy-MM-dd");

            var Thamso = new Dictionary<String, String>() { { "Tungay", Tungay }, { "Denngay", Denngay }};
            griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_DanhSach_Edit_PhieuCan", Thamso);
            gridView_Chitiet.BestFitColumns();
        }
        
        private void fmCapNhat_PhieuCan_Load(object sender, EventArgs e)
        {            
            dtpTuNgay.uValue = cnn.GetDateServer();
            dtpDenNgay.uValue = cnn.GetDateServer();            
            for (int i = 0; i < gridView_Chitiet.Columns.Count; i++)
            {
                gridView_Chitiet.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

    }
}
