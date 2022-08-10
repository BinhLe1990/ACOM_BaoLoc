using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BSC_HRM.NET.NhanSu
{
    public partial class frmDanhSachDenHanNghiHuu : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachDenHanNghiHuu()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            dtg.sKEY = sKEY;

        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKEY = "DSNghiHuu";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            string sSQL = cnn.GetSQLString(sKEY);
            sSQL = sSQL.Replace("01/01/2012", dtpDenNgay.uDateTime.ToString("MM/dd/yyyy"));
            if (!cnn.bComboIsNull(cbxCoSo))
            {
                sSQL += " AND COSO=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "'";
            }
            if (!cnn.bComboIsNull(cbxPhongBan))
            {
                sSQL += " AND PHONGBAN=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "'";
            }
            if (!cnn.bComboIsNull(cbxPhanHe))
            {
                sSQL += " AND PHANHE=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "'";
            }
            sSQL += " Order By ThoiGianNghi";
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = DT;
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
            {
                if (col.Name != "Chon")
                {
                    col.OptionsColumn.AllowEdit = false;
                }
            } 
        }
        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            DataTable DTT = DT.Clone();
            foreach (DataRow r in DT.Rows)
            {
                if ((bool)(r["Chon"]) == true)
                {
                    DTT.ImportRow(r);
                }
            }
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\DS_DenHanNghiHuu.repx", DTT);
            frm.iNamThu = Convert.ToDateTime(dtpDenNgay.uValue).Year;
            frm.Show();
        }
    }
}