using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace DELFI_WHM.NET.BaoCao
{
    public partial class frmBC_LenhSanXuat : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string LSX, TuNgay, DenNgay;

        public frmBC_LenhSanXuat()
        {
            InitializeComponent();
        }

        private void cboLSX_uQueryPopUp(object sender, CancelEventArgs e)
        {
            cboLSX.uDataSource = cnn.DT_DataTable("SELECT DISTINCT BatchNo FROM DM_LenhSanXuat");
        }

        private void btnIn_Chitiet_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)grid_Chitiet.DataSource;            
            if (dt != null)
            {
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_LenhSanXuat_Chitiet.repx", dt);
                frm.Show();
            }
        }

        private void btnTimkiem_Tonghop_Click(object sender, EventArgs e)
        {
            TuNgay = Convert.ToDateTime(dtpTuNgay.uValue).ToString("yyyy-MM-dd");
            DenNgay = Convert.ToDateTime(dtpDenNgay.uValue).ToString("yyyy-MM-dd");
            var Thamso = new Dictionary<String, String>() { { "Tungay", TuNgay }, { "DenNgay", DenNgay } };
            grid_Tonghop.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_Batch_Tonghop", Thamso);
        }

        private void btnIn_Tonghop_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)grid_Tonghop.DataSource;
            if (dt != null)
            {
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_LenhSanXuat_TongHop.repx", dt);
                frm.Show();
            }
        }

        private void gridView_Tonghop_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void frmBC_LenhSanXuat_Load(object sender, EventArgs e)
        {
            dtpTuNgay.uValue = cnn.GetDateServer();
            dtpDenNgay.uValue = cnn.GetDateServer();
        }

        private void gridView_Chitiet_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void btnTimKiem_Chitiet_Click(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboLSX))
            {
                LSX = cboLSX.uEditValue.ToString();
                var Thamso = new Dictionary<String, String>() { { "LenhSanXuat", LSX } };
                grid_Chitiet.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_Batch_Chitiet", Thamso);
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn Lệnh sản xuất", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLSX.Focus();
            }
        }
    }
}
