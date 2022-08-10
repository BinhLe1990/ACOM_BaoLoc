using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DELFI_WHM.NET.NhapKho
{
    public partial class frmDS_CapNhatSoBao : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string Tungay, Denngay, QRCode;
        int _IDPhieuCan;

        public frmDS_CapNhatSoBao()
        {
            InitializeComponent();
        }

        private void Form_Load()
        {
            Tungay = Convert.ToDateTime(dtpTungay.uValue).ToString("yyyy-MM-dd");           
            Denngay = Convert.ToDateTime(dtpDenngay.uValue).ToString("yyyy-MM-dd");

            var Thamso = new Dictionary<String, String>() { { "Tungay", Tungay }, { "Denngay", Denngay } };
            griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_CapNhatSoBao_PCC_DanhSach", Thamso);
        }

        private void frmDS_CapNhatSoBao_Load(object sender, EventArgs e)
        {
            dtpTungay.uValue = cnn.GetDateServer();
            dtpDenngay.uValue = cnn.GetDateServer();
            Form_Load(); 
        }

        private void gridView_Danhsach_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Form_Load();
        }

        private void gridView_Chitiet_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (XtraMessageBox.Show("Bạn có chắc chắn muốn Lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            for (int i = 0; i < gridView_Chitiet.DataRowCount; i++)
            {
                int SoBao = Convert.ToInt32(gridView_Chitiet.GetRowCellValue(i, "TruckQty"));
                string _WeightNote = txtWeightNote.uText;
                QRCode = gridView_Chitiet.GetRowCellValue(i, "QRCode").ToString();
                var Thamso = new Dictionary<String, String>() { { "WeightNote",  _WeightNote} ,
                                                                { "SoBao",  SoBao.ToString()},
                                                                { "QRCode",  QRCode} };
                cnn.SQL_ExecuteStoredProcedure("SP_CapNhatSoBao_PCC_UpDate", Thamso);
            }
            Form_Load();
            XtraMessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
        }

        private void gridView_Danhsach_DoubleClick(object sender, EventArgs e)
        {
            if (gridView_Danhsach.GetFocusedRowCellValue("ID") != null)
            {
                //if (gridView_Danhsach.GetFocusedRowCellValue("TrangThai").ToString() == "Đã cập nhật")
                //{
                //    gridView_Chitiet.Columns["TruckQty"].OptionsColumn.AllowEdit = false;
                //}
                //else
                //{
                //    gridView_Chitiet.Columns["TruckQty"].OptionsColumn.AllowEdit = true;
                //}
                _IDPhieuCan = Convert.ToInt32(gridView_Danhsach.GetFocusedRowCellValue("ID"));
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    var list = db.DM_PhieuCanCau.Where(c => c.ID == _IDPhieuCan).ToList();
                    if (list.Count> 0)
                    {
                        txtWeightNote.uText = list[0].WeightNote;
                        txtLoaiPhieu.uText = list[0].WeightType;
                        txtHopDong.uText = list[0].ContractNo;
                        txtKhachHang.uText = list[0].VendorName;
                        spnSoBao_PhieuCan.uValue = Convert.ToDecimal(list[0].TruckQty);
                        spnTL_PhieuCan.uValue = Convert.ToDecimal(list[0].NetWeight);
                    }
                    var Thamso = new Dictionary<String, String>() { { "ID", _IDPhieuCan.ToString() } };
                    grid_Chitiet.DataSource = cnn.SQL_GetStoredProcedure("SP_CapNhatSoBao_PCC_Chitiet", Thamso);
                }
                Tab.SelectedTabPage = Tab_Chitiet;
            }
        }

    }
}
