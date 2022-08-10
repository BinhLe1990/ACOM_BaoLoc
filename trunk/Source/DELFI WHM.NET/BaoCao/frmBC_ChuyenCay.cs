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
    public partial class frmBC_ChuyenCay : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string LSX, TuNgay, Ca;
        clsRun clRun = new clsRun();

        public frmBC_ChuyenCay()
        {
            clRun.SetPermit(this);
            InitializeComponent();
            clRun.SetValueToControl(this);
        }


        private void btnTimkiem_Tonghop_Click(object sender, EventArgs e)
        {
            if (!cnn.bComboIsNull(cboShift))
            {
                TuNgay = Convert.ToDateTime(dtpNgay.uValue).ToString("yyyy-MM-dd");
                Ca = cboShift.uEditValue.ToString();
                var Thamso = new Dictionary<String, String>() { { "Ngay", TuNgay }, { "Ca", Ca } };
                grid_Tonghop.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_ChuyenCay", Thamso);
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn Ca", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIn_Tonghop_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)grid_Tonghop.DataSource;
            if (dt != null)
            {
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_ChuyenCay.repx", dt);
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

        private void cboShift_uQueryPopUp(object sender, CancelEventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Ca");
            dt.Rows.Add("1");
            dt.Rows.Add("2");
            dt.Rows.Add("3");
            cboShift.uDataSource = dt;
        }

        private void frmBC_ChuyenCay_Load(object sender, EventArgs e)
        {
            dtpNgay.uValue = DateTime.Now;
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
                    var f = db.tblConfigLinkSync.Where(c => c.Value == "EX_ChuyenCay").Select(p => p.Description).First();
                    if (f == null)
                    {
                        XtraMessageBox.Show("Không tìm thấy đường dẫn export", "Thông báo");
                    }
                    if (cnn.DT_DataTable("SELECT * FROM His_Export_NhapXuatSX WHERE " +
                                        " Ngay = '" + Convert.ToDateTime(dtpNgay.uValue).ToString("yyyy-MM-dd") + "' " +
                                        " AND Type = 'ChuyenCay' AND Ca = '" + Ca + "'").Rows.Count > 0)
                    {
                        XtraMessageBox.Show("Dữ liệu đã Export, không thể Export lại", "Thông báo");
                    }
                    else
                    {
                        filename.FileName = f;

                        var Thamso = new Dictionary<String, String>() { { "Ngay", Convert.ToDateTime(dtpNgay.uValue).ToString("yyyy-MM-dd") }, { "UserName", Properties.Settings.Default.USER_NAME }, { "Ca", Ca } };
                        dt = cnn.SQL_GetStoredProcedure("SP_EX_ChuyenCay", Thamso);
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
    }
}
