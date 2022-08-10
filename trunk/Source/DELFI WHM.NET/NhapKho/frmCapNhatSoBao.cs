using DELFI_WHM.NET.DELFI_Class;
using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DELFI_WHM.NET.NhapKho
{
    public partial class frmCapNhatSoBao : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string Tungay, Denngay;
        public frmCapNhatSoBao()
        {
            InitializeComponent();
        }

        private void gridView_Danhsach_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView_Chitiet_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void Search()
        {
            Tungay = Convert.ToDateTime(dtpTungay.uValue).ToString("yyyy-MM-dd");
            Denngay = Convert.ToDateTime(dtpDenngay.uValue).ToString("yyyy-MM-dd");
            var Thamso = new Dictionary<String, String>() { { "Tungay", Tungay }, { "Denngay", Denngay } };
            griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_CapNhatSoBao_PCC_DanhSach", Thamso);
        }

        private void frmCapNhatSoBao_Load(object sender, EventArgs e)
        {
            dtpTungay.uValue = cnn.GetDateServer();
            dtpDenngay.uValue = cnn.GetDateServer();
            Search();
        }

        private void gridView_Danhsach_DoubleClick(object sender, EventArgs e)
        {
            int _ID = Convert.ToInt32(gridView_Danhsach.GetFocusedRowCellValue("ID"));
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.DM_PhieuCanCau.Where(c => c.ID == _ID).ToList();
                txtWeightNote.uText = list[0].WeightNote;
                txtLoaiPhieu.uText = list[0].WeightType;
                txtLenhGiaoHang.uText = list[0].ContractNo;
                txtKhachHang.uText = list[0].VendorName;
                txtGhichu.uText = list[0].Note;
                spnSoBao_PhieuCan.uValue = Convert.ToInt32(list[0].TruckQty);
            }
            var Thamso = new Dictionary<String, String>() { { "ID", _ID.ToString() } };
            grid_Chitiet.DataSource = cnn.SQL_GetStoredProcedure("SP_CapNhatSoBao_PCC_Chitiet", Thamso);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn Lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            for (int i = 0; i < gridView_Chitiet.DataRowCount; i++)
            {
                string WeightNote = txtWeightNote.uText;
                int SoBao = Convert.ToInt32(gridView_Chitiet.GetRowCellValue(i, "TruckQty"));
                int Trongluong = Convert.ToInt32(gridView_Chitiet.GetRowCellValue(i, "QRCodeQty"));
                string Lot = gridView_Chitiet.GetRowCellValue(i, "Lot").ToString();
                string BinCode = gridView_Chitiet.GetRowCellValue(i, "BinCode").ToString();
                var Thamso = new Dictionary<String, String>() { { "WeightNote",  WeightNote} ,
                                                                { "SoBao",  SoBao.ToString()} ,
                                                                { "Trongluong", Trongluong.ToString() } ,
                                                                { "Lot",  Lot },
                                                                { "BinCode",  BinCode },};
                cnn.SQL_ExecuteStoredProcedure("SP_CapNhatSoBao_UpDate", Thamso);
            }
            Search();
            XtraMessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
