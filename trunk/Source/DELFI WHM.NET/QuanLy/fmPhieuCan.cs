using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DELFI_WHM.NET.Models;

namespace DELFI_WHM.NET.QuanLy
{
    public partial class fmPhieuCan : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        DateTime Tungay, Denngay;
        string Trangthai, Sophieucan;
        Boolean Export;
        public fmPhieuCan()
        {
            InitializeComponent();
        }

        private void Search()
        {
            Tungay = Convert.ToDateTime(dtpTuNgay.uValue).Date;
            Denngay = Convert.ToDateTime(dtpDenNgay.uValue).AddDays(1).Date;
            Trangthai = "";
            if (!cnn.bComboIsNull(cboWeightType)) { Trangthai = cboWeightType.uEditValue.ToString(); }
            if (!cnn.bComboIsNull(cboTrangThai))
            {
                if (cboTrangThai.uEditValue.ToString() == "Đã export NAV")
                {
                    Export = true;
                }
                else
                {
                    Export = false;
                }
            }       
            Sophieucan = txtSoHopDong.uText;

            using (DBACOMEntities db = new DBACOMEntities())
            {
                if (cnn.bComboIsNull(cboTrangThai))
                {
                   var q  = db.DM_PhieuCanCau
                        .Where(c => c.CreateDate >= Tungay && c.CreateDate <= Denngay && c.WeightType.Contains(Trangthai) &&
                        c.WeightNote.Contains(Sophieucan)
                        ).ToList();
                    if (q != null)
                    {
                        griDanhSach.DataSource = q;
                    }
                }
                else
                {
                    var q = db.DM_PhieuCanCau
                           .Where(c => c.CreateDate >= Tungay && c.CreateDate <= Denngay && c.WeightType.Contains(Trangthai) &&
                           c.WeightNote.Contains(Sophieucan) && c.ExportNav == Export
                           ).ToList();
                    if (q != null)
                    {
                        griDanhSach.DataSource = q;
                    }
                }                
            }
            for (int i = 0; i < gridView2.Columns.Count; i++)
            {
                gridView2.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
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
            }
        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
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

        private void fmPhieuCan_Load(object sender, EventArgs e)
        {
            dtpTuNgay.uValue = cnn.GetDateServer();
            dtpDenNgay.uValue = cnn.GetDateServer();
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
                dt.Columns.Add("Noidung");
                dt.Rows.Add("Đã export NAV");
                dt.Rows.Add("Chưa export NAV");
                cboTrangThai.uDataSource = dt;
            }
            Search();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

    }
}
