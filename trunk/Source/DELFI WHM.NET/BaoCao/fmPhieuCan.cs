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
    public partial class fmPhieuCan : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string Tungay, Denngay, Trangthai, Sophieucan, Export;
        string _LocationCode = "";
        string _LocationName = "";
        string TenCty = "";
        string Diachi = "";
        string SDT = "";

        clsRun clRun = new clsRun();
        public fmPhieuCan()
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

        private void btnSuaSoCan_Click(object sender, EventArgs e)
        {
            if (gridView_Chitiet.RowCount > 0)
            {
                BaoCao.frmSuaPhieuCan frm = new BaoCao.frmSuaPhieuCan(this);
                frm.ID = gridView_Chitiet.GetFocusedRowCellValue("ID").ToString();
                frm.ShowDialog();
            }
        }

        private void gridView2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView_Chitiet.OptionsSelection.MultiSelect = true;
                gridView_Chitiet.SelectAll();
            }
        }

        private void gridView_Chitiet_DoubleClick(object sender, EventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                DM_Location lc = db.DM_Location.Where(d => d.Status == true).FirstOrDefault();
                _LocationCode = lc.Code;
                _LocationName = lc.LocationName;

                var c = db.HT_HETHONG.Where(p => p.LOCATIONCODE == _LocationCode).ToList();
                if (c != null)
                {
                    TenCty = c[0].TENCOQUAN;
                    Diachi = c[0].DIACHI;
                    SDT = c[0].DIENTHOAI;
                }

                DataTable dt = new DataTable();
                var Thamso = new Dictionary<String, String>() { { "WeightNote", gridView_Chitiet.GetFocusedRowCellValue("WeightNote").ToString() }, { "ID", "" } };
                dt = cnn.SQL_GetStoredProcedure("SP_GetHinhAnhPCC", Thamso);
                dt.Columns.Add("Nguoidung");
                dt.Columns.Add("TenCty");
                dt.Columns.Add("Diachi");
                dt.Columns.Add("SDT");
                dt.Columns.Add("NgayTao");
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        dr["Nguoidung"] = Properties.Settings.Default.USER_NAME;
                        dr["TenCty"] = TenCty;
                        dr["Diachi"] = Diachi;
                        dr["SDT"] = SDT;
                        dr["NgayTao"] = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
                        dr["TransporterCode"] = dr["TransporterCode"].ToString().Replace(" ChuaXacDinh", "");
                        dr["ItemCode"] = dr["ItemCode"].ToString().Replace(" Chuaxacdinh", "");
                        dr["VendorCode"] = dr["VendorCode"].ToString().Replace(" ChuaXacDinh", "");
                        dr["VendorName"] = dr["VendorName"].ToString().Replace("Chưa xác định", "");
                        dr["Lot"] = dr["Lot"].ToString();
                    }
                    BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\PhieuCan.repx", dt);
                    frm.Show();
                }
            }
        }

        private void Search()
        {
            Tungay = Convert.ToDateTime(dtpTuNgay.uValue).ToString("yyyy-MM-dd");
            Denngay = Convert.ToDateTime(dtpDenNgay.uValue).AddDays(1).ToString("yyyy-MM-dd");

            if (!cnn.bComboIsNull(cboWeightType))
            {
                Trangthai = cboWeightType.uEditValue.ToString();
            }
            else
            {
                Trangthai = "";
            }
            if (!cnn.bComboIsNull(cboTrangThai))
            {
                Export = cboTrangThai.uEditValue.ToString();
            }
            else
            {
                Export = "";
            }

            Sophieucan = txtSoHopDong.uText;

            var Thamso = new Dictionary<String, String>() { { "Tungay", Tungay }, { "Denngay", Denngay }, { "WeightType", Trangthai },
                                                            { "ExportNav", Export }, { "WeightNote", Sophieucan }};
            griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_PhieuCan", Thamso);
            gridView_Chitiet.BestFitColumns();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = (DataTable)griDanhSach.DataSource;
                dt.Columns.Add("Tungay");
                dt.Columns.Add("Denngay");
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        dr["Tungay"] = Convert.ToDateTime(dtpTuNgay.uValue).ToString("dd/MM/yyyy");
                        dr["Denngay"] = Convert.ToDateTime(dtpDenNgay.uValue).ToString("dd/MM/yyyy");
                    }
                    BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_PhieuCan.repx", dt);

                    frm.Show();
                    dt.Columns.Remove("Tungay");
                    dt.Columns.Remove("Denngay");
                }
            }
            catch { }
        }

        private void fmPhieuCan_Load(object sender, EventArgs e)
        {
            clRun.SetValueToControl(this);
            dtpTuNgay.uValue = DateTime.Now;
            dtpDenNgay.uValue = DateTime.Now;
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("WeightType");
                dt.Rows.Add("Purchase"); //Nhập mua theo hợp đồng
                dt.Rows.Add("Receive"); //Nhập chuyển kho nội bộ
                dt.Rows.Add("Ship"); //Xuất chuyển kho nội bộ
                dt.Rows.Add("Sale"); //Xuất bán hàng          
                cboWeightType.uDataSource = dt;
            }
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Trangthai");
                dt.Rows.Add("Đã Export");
                dt.Rows.Add("Đã xóa");
                dt.Rows.Add("Đang cân");
                cboTrangThai.uDataSource = dt;
            }
            for (int i = 0; i < gridView_Chitiet.Columns.Count; i++)
            {
                gridView_Chitiet.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
            //Search();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

    }
}
