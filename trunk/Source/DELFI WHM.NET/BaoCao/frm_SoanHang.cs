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

namespace DELFI_WHM.NET.BaoCao
{
    public partial class frm_SoanHang : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string Ngay;
        string Ca = "";
        clsRun clRun = new clsRun();
        public frm_SoanHang()
        {
            clRun.SetPermit(this);
            InitializeComponent();
            clRun.SetValueToControl(this);
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
            if (!cnn.bComboIsNull(cboShift))
            {
                Ca = cboShift.uEditValue.ToString();
            }
            else
            {
                Ca = "";
            }
            var Thamso = new Dictionary<String, String>() {{ "Ngay", Ngay}, {"Ca", Ca } };
            griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_PhieuXuatHang", Thamso);            
            gridView2.BestFitColumns();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           DataTable dt = new DataTable();
            dt = (DataTable)griDanhSach.DataSource;
            if (dt != null)
            {
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_PhieuXuatHang.repx", dt);
                frm.Show();
            }
        }

        private void frm_SoanHang_Load(object sender, EventArgs e)
        {
            dtpNgay.uValue = cnn.GetDateServer();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
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

        private void btnExport_Click(object sender, EventArgs e)
        {
           
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn Export NAV?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Chuoi");
                SaveFileDialog filename = new SaveFileDialog();
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    var f = db.tblConfigLinkSync.Where(c => c.Value == "EX_XuatSX").Select(p => p.Description).First();
                    if (f == null)
                    {
                        XtraMessageBox.Show("Không tìm thấy đường dẫn export", "Thông báo");
                    }
                    if (cnn.DT_DataTable("SELECT * FROM His_Export_NhapXuatSX WHERE " +
                                        "Ngay = '" + Convert.ToDateTime(dtpNgay.uValue).ToString("yyyy-MM-dd") + "' " + 
                                        " AND Ca = '" + cboShift.uEditValue + "' AND Type = 'XuatSX'").Rows.Count > 0)
                    {
                        XtraMessageBox.Show("Dữ liệu đã Export, không thể Export lại", "Thông báo");
                    }
                    else
                    {
                        filename.FileName = f;                        
                        var Thamso = new Dictionary<String, String>() { { "Ngay", Convert.ToDateTime(dtpNgay.uValue).ToString("yyyy-MM-dd") }, { "Ca", cboShift.uEditValue.ToString() }, { "UserName", Properties.Settings.Default.USER_NAME } };
                        dt = cnn.SQL_GetStoredProcedure("SP_EX_XuatSX", Thamso);
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
