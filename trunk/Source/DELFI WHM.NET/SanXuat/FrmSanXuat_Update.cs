using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DELFI_WHM.NET.SanXuat
{
    public partial class FrmSanXuat_Update : DevExpress.XtraEditors.XtraForm
    {
        public FrmSanXuat_Update()
        {
            InitializeComponent();
        }

        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboLenhSanXuat_Cu))
            {
                try
                {
                    SplashScreenManager.ShowDefaultWaitForm();
                    string LSX = "";
                    LSX = cnn.sNull2String(cboLenhSanXuat_Cu.uEditValue);

                    var Thamso = new Dictionary<String, String>() { { "LenhSanXuat", LSX } };
                    DataTable dt_Nhap = new DataTable();
                    dt_Nhap = cnn.SQL_GetStoredProcedure("SP_NhapKho_LSX", Thamso);
                    grid_Nhap.DataSource = dt_Nhap;

                    DataTable dt_Xuat = new DataTable();
                    dt_Xuat = cnn.SQL_GetStoredProcedure("SP_XuatKho_LSX", Thamso);
                    grid_Xuat.DataSource = dt_Xuat;

                    gridView_Nhap.BestFitColumns();
                    gridView_Xuat.BestFitColumns();
                    if (gridView_Xuat.DataRowCount > 0)
                    {
                        Tab.SelectedTabPage = Tab_Xuat;
                    }
                    SplashScreenManager.CloseDefaultWaitForm();
                }
                catch
                { SplashScreenManager.CloseDefaultWaitForm(); }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn Lệnh sản xuất trước", "Thông báo");
                cboLenhSanXuat_Cu.Focus();
            }
        }

        private void gridView_Nhap_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView_Xuat_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void cboLenhSanXuat_Cu_uQueryPopUp(object sender, CancelEventArgs e)
        {
            string Ngay = Convert.ToDateTime(dtpNgay.uValue).ToString("yyyy-MM-dd");
            var Thamso = new Dictionary<String, String>() { {"Ngay", Ngay }, { "Loai", "1" } };
            cboLenhSanXuat_Cu.uDataSource = cnn.SQL_GetStoredProcedure("SP_ListLSX_Update", Thamso);
        }

        private void cboLenhSanXuat_Moi_uQueryPopUp(object sender, CancelEventArgs e)
        {
            string Ngay = Convert.ToDateTime(dtpNgayNhap.uValue).ToString("yyyy-MM-dd");
            var Thamso = new Dictionary<String, String>() { { "Ngay", Ngay }, { "Loai", "1" } };
            cboLenhSanXuat_NhapMoi.uDataSource = cnn.SQL_GetStoredProcedure("SP_ListLSX_Update", Thamso);
        }

        private void cboLenhSanXuat_XuatMoi_uQueryPopUp(object sender, CancelEventArgs e)
        {
            string Ngay = Convert.ToDateTime(dtpNgayXuat.uValue).ToString("yyyy-MM-dd");
            var Thamso = new Dictionary<String, String>() { { "Ngay", Ngay }, { "Loai", "2" } };
            cboLenhSanXuat_XuatMoi.uDataSource = cnn.SQL_GetStoredProcedure("SP_ListLSX_Update", Thamso);
            cboLenhSanXuat_XuatMoi.Columns["ID"].Visible = false;
        }

        private void btn_LuuNhap_Click(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboLenhSanXuat_NhapMoi))
            {
                if (gridView_Nhap.DataRowCount > 0)
                {
                    SplashScreenManager.ShowDefaultWaitForm();
                    DataTable dt = new DataTable();
                    dt = (DataTable)grid_Nhap.DataSource;
                    DataView dv = new DataView(dt).ToTable().DefaultView;
                    dv.RowFilter = "Chon = True";
                    if (dv.Count > 0)
                    {
                        for (int i = 0; i < dv.Count; i++)
                        {
                            var Thamso = new Dictionary<String, String>() { { "ID", cnn.sNull2String(dv[i]["ID"]) },
                                                                            { "UserName", Properties.Settings.Default.USER_NAME },
                                                                            { "LenhSanXuat", cnn.sNull2String(cboLenhSanXuat_NhapMoi.uEditValue) }};
                            cnn.SQL_ExecuteStoredProcedure("SP_Update_NhapKho_LSX", Thamso);
                        }
                        string LSX = "";
                        LSX = cnn.sNull2String(cboLenhSanXuat_NhapMoi.uEditValue);
                        var Thamso2 = new Dictionary<String, String>() { { "LenhSanXuat", LSX } };
                        DataTable dt_Nhap = new DataTable();
                        dt_Nhap = cnn.SQL_GetStoredProcedure("SP_NhapKho_LSX", Thamso2);
                        grid_Nhap.DataSource = dt_Nhap;
                        gridView_Nhap.BestFitColumns();
                        SplashScreenManager.CloseDefaultWaitForm();
                        XtraMessageBox.Show("Đã cập nhật lại Lệnh sản xuất", "Thông báo");
                    }
                    else
                    {
                        SplashScreenManager.CloseDefaultWaitForm();
                        XtraMessageBox.Show("Vui lòng chọn dòng cần Update lại Lệnh sản xuất", "Thông báo");
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn Lệnh sản xuất trước", "Thông báo");
                cboLenhSanXuat_NhapMoi.Focus();
            }
        }

        private void btn_LuuXuat_Click(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboLenhSanXuat_XuatMoi))
            {
                if (gridView_Xuat.DataRowCount > 0)
                {
                    SplashScreenManager.ShowDefaultWaitForm();
                    DataTable dt = new DataTable();
                    dt = (DataTable)grid_Xuat.DataSource;
                    DataView dv = new DataView(dt).ToTable().DefaultView;
                    dv.RowFilter = "Chon = True";
                    if (dv.Count > 0)
                    {
                        for (int i = 0; i < dv.Count; i++)
                        {
                            var Thamso = new Dictionary<String, String>() { { "ID", cnn.sNull2String(dv[i]["ID"]) },
                                                                            { "UserName", Properties.Settings.Default.USER_NAME },
                                                                            { "ID_LenhSanXuat", cnn.sNull2String(cboLenhSanXuat_XuatMoi.uEditValue) }};
                            cnn.SQL_ExecuteStoredProcedure("SP_Update_XuatKho_LSX", Thamso);
                        }
                        string LSX = "";
                        LSX = cnn.sNull2String(cboLenhSanXuat_XuatMoi.uText);
                        var Thamso2 = new Dictionary<String, String>() { { "LenhSanXuat", LSX } };
                        DataTable dt_Xuat = new DataTable();
                        dt_Xuat = cnn.SQL_GetStoredProcedure("SP_XuatKho_LSX", Thamso2);
                        grid_Xuat.DataSource = dt_Xuat;
                        gridView_Xuat.BestFitColumns();
                        SplashScreenManager.CloseDefaultWaitForm();
                        XtraMessageBox.Show("Đã cập nhật lại Lệnh sản xuất", "Thông báo");
                    }
                    else
                    {
                        SplashScreenManager.CloseDefaultWaitForm();
                        XtraMessageBox.Show("Vui lòng chọn dòng cần Update lại Lệnh sản xuất", "Thông báo");
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn Lệnh sản xuất trước", "Thông báo");
                cboLenhSanXuat_XuatMoi.Focus();
            }
        }

        private void FrmSanXuat_Update_Load(object sender, EventArgs e)
        {
            dtpNgay.uValue = cnn.GetDateServer();
            dtpNgayNhap.uValue = cnn.GetDateServer();
            dtpNgayXuat.uValue = cnn.GetDateServer();
        }
    }
}
