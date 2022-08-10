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
    public partial class frmBC_HaoHutKho : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string LSX, TuNgay, DenNgay, Ca, Ngay;
        clsRun clRun = new clsRun();

        public frmBC_HaoHutKho()
        {
            clRun.SetPermit(this);
            InitializeComponent();
            clRun.SetValueToControl(this);
        }

        private void btnIn_QRCode_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)grid_QRCode.DataSource;            
            if (dt != null)
            {
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_HaoHutKho_QRCode.repx", dt);
                frm.Show();
            }
        }

        private void btnTimkiem_Tonghop_Click(object sender, EventArgs e)
        {
            var Thamso = new Dictionary<String, String>() { { "Tungay", Convert.ToDateTime(dtpTungay_TH.uValue).ToString("yyyy-MM-dd")},
                                                            { "Denngay", Convert.ToDateTime(dtpDenngay_TH.uValue).ToString("yyyy-MM-dd")}};
            grid_TongHop.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_HaoHut_Lot", Thamso);
        }

        private void btnIn_Tonghop_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)grid_TongHop.DataSource;
            if (dt != null)
            {
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_HaoHutKho_Lot.repx", dt);
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

        private void frmBC_HaoHutKho_Load(object sender, EventArgs e)
        {           
            dtpNgay.uValue = cnn.GetDateServer();
            dtpTungay_CT.uValue = cnn.GetDateServer();
            dtpDenngay_CT.uValue = cnn.GetDateServer();
            dtpTungay_TH.uValue = cnn.GetDateServer();
            dtpDenngay_TH.uValue = cnn.GetDateServer();
            dtpTungay_TheoLot.uValue = cnn.GetDateServer();
            dtpDenngay_TheoLot.uValue = cnn.GetDateServer();
            dtpTungay_TheoNgay.uValue = cnn.GetDateServer();
            dtpDenngay_TheoNgay.uValue = cnn.GetDateServer();

            for (int i = 0; i < gridView_TheoLot.Columns.Count; i++)
            {
                gridView_TheoLot.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
            for (int i = 0; i < gridView_QRCode.Columns.Count; i++)
            {
                gridView_QRCode.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
            for (int i = 0; i < gridView_TheoNgay.Columns.Count; i++)
            {
                gridView_TheoNgay.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
            for (int i = 0; i < gridView_TongHop.Columns.Count; i++)
            {
                gridView_TongHop.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
        }

        private void btnIn_Export_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)grid_Export.DataSource;
            if (dt != null)
            {
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_HaoHutKho_Export.repx", dt);
                frm.Show();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn Export NAV?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Ca = cboShift.uEditValue.ToString();
                DataTable dt = new DataTable();
                dt.Columns.Add("Chuoi");
                SaveFileDialog filename = new SaveFileDialog();
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    var f = db.tblConfigLinkSync.Where(c => c.Value == "EX_DieuChinhKho").Select(p => p.Description).First();
                    if (f == null)
                    {
                        XtraMessageBox.Show("Không tìm thấy đường dẫn export", "Thông báo");
                    }
                    if (cnn.DT_DataTable("SELECT * FROM His_Export_NhapXuatSX WHERE " +
                                        " Ngay = '" + Convert.ToDateTime(dtpNgay.uValue).ToString("yyyy-MM-dd") + "' " +
                                        " AND Type = 'DieuChinhKho' AND Ca = '" + Ca + "'").Rows.Count > 0)
                    {
                        XtraMessageBox.Show("Dữ liệu đã Export, không thể Export lại", "Thông báo");
                    }
                    else
                    {
                        filename.FileName = f;

                        var Thamso = new Dictionary<String, String>() { { "Ngay", Convert.ToDateTime(dtpNgay.uValue).ToString("yyyy-MM-dd") }, { "UserName", Properties.Settings.Default.USER_NAME }, { "Ca", Ca } };
                        dt = cnn.SQL_GetStoredProcedure("SP_EX_HaoHut", Thamso);
                        if (dt.Rows.Count == 0)
                        {
                            XtraMessageBox.Show("Không có dữ liệu Export", "Thông báo");
                        }
                        else
                        {
                            cnn.Export_NAV(f, dt);
                            XtraMessageBox.Show("Export thành công", "Thông báo");
                        }
                    }
                }
            }
        }

        private void cboShift_uQueryPopUp(object sender, CancelEventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Ca");
            dt.Rows.Add("1");
            dt.Rows.Add("2");
            dt.Rows.Add("3");
            cboShift.uDataSource = dt;
        }

        private void gridView_TongHop_CustomDrawRowIndicator_1(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void btn_TimKiem_TheoLot_Click(object sender, EventArgs e)
        {
            var Thamso = new Dictionary<String, String>() { { "Tungay", Convert.ToDateTime(dtpTungay_TheoLot.uValue).ToString("yyyy-MM-dd")},
                                                            { "Denngay", Convert.ToDateTime(dtpDenngay_TheoLot.uValue).ToString("yyyy-MM-dd")}};
            grid_TheoLot.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_HaoHut_TongHop", Thamso);
        }

        private void gridView_TheoLot_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void btnIn_TheoLot_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)grid_TheoLot.DataSource;
            if (dt != null)
            {
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_HaoHutKho_TheoLot.repx", dt);
                frm.Show();
            }
        }

        private void btnTimKiem_TheoNgay_Click(object sender, EventArgs e)
        {
            var Thamso = new Dictionary<String, String>() { { "Tungay", Convert.ToDateTime(dtpTungay_TheoNgay.uValue).ToString("yyyy-MM-dd")},
                                                            { "Denngay", Convert.ToDateTime(dtpDenngay_TheoNgay.uValue).ToString("yyyy-MM-dd")}};
            grid_TheoNgay.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_HaoHut_TheoNgay", Thamso);
        }

        private void btnIn_TheoNgay_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)grid_TheoNgay.DataSource;
            if (dt != null)
            {
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_HaoHutKho_TheoNgay.repx", dt);
                frm.Show();
            }
        }

        private void gridView_TheoNgay_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView_Export_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void btnTimkiem_Export_Click(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboShift))
            {
                Ngay = Convert.ToDateTime(dtpNgay.uValue).ToString("yyyy-MM-dd");
                Ca = cboShift.uEditValue.ToString();
                var Thamso = new Dictionary<String, String>() { { "Ngay", Ngay }, { "Ca", Ca }};
                grid_Export.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_HaoHut_Ex", Thamso);
            }
        }

        private void gridView_QRCode_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void btnTimKiem_QRCode_Click(object sender, EventArgs e)
        {
            var Thamso = new Dictionary<String, String>() { { "Tungay", Convert.ToDateTime(dtpTungay_CT.uValue).ToString("yyyy-MM-dd")},
                                                            { "Denngay", Convert.ToDateTime(dtpDenngay_CT.uValue).ToString("yyyy-MM-dd")}};
            grid_QRCode.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_HaoHut_QRCode", Thamso);
        }
    }
}
