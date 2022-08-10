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
    public partial class fmCapNhat_PhieuCan_Nhap : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string Tungay, Denngay;       

        clsRun clRun = new clsRun();
        public fmCapNhat_PhieuCan_Nhap()
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
            
        }
        
        private void fmCapNhat_PhieuCan_Nhap_Load(object sender, EventArgs e)
        {   
            for (int i = 0; i < gridView_Chitiet.Columns.Count; i++)
            {
                gridView_Chitiet.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
                if (gridView_Chitiet.Columns[i].FieldName != "Active")
                {
                    gridView_Chitiet.Columns[i].OptionsColumn.AllowEdit = false;
                }
            }            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ID_PhieuCan = Convert.ToInt32(spnID.uValue);
            int SoCan_Lan1 = Convert.ToInt32(spnSoCan1.uValue);
            int SoCan_Lan2 = Convert.ToInt32(spnSoCan2.uValue);
            string SoPhieuCan = txtWeightNote.uText;
            string SoXe = cnn.sNull2String(txtVehicleNo.uText);
            string LoaiPhieuCan = cnn.sNull2String(cboWeightType.uEditValue);
            string LenhGiaoHang = cnn.sNull2String(cboContractNo.uEditValue);
            string NhaVanChuyen = cnn.sNull2String(cboTransporterCode.uEditValue);
            string Item = cnn.sNull2String(cboItemCode.uEditValue);
            string Lot = cnn.sNull2String(cboLot.uEditValue);
            string KhachHang = cnn.sNull2String(cboVendorCode.uEditValue);
            int SoBao = Convert.ToInt32(spnTruckQty.uValue);
            decimal TLTruBi = spnPackageQty.uValue;
            string GhiChu = cnn.sNull2String(txtNote.uText);
            string LyDo = cnn.sNull2String(txtLyDoSua.uText);


        }

        private void spnSoCan1_uValueChanged(object sender, EventArgs e)
        {

        }

        private void spnSoCan2_uValueChanged(object sender, EventArgs e)
        {

        }

        private void spnTruckQty_uValueChanged(object sender, EventArgs e)
        {

        }

        private void spnPackageQty_uValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

    }
}
