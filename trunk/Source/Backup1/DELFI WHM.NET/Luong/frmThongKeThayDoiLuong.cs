using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.Luong
{
    public partial class frmThongKeThayDoiLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKeThayDoiLuong()
        {
            InitializeComponent();
            clsrun.SetValueToControl(this);
            dtg.sKEY = sKEY;
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clsrun = new clsRun();
        string sKEY = "THONGKETHAYDOILUONG";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            string sSQL = cnn.GetSQLString(sKEY);
            int iThangNay = cnn.sNull2Int(txtThang.uValue);
            int iNamNay = cnn.sNull2Int(txtNam.uValue);
            int iThangTruoc = iThangNay - 1;
            int iNamTruoc = iNamNay;
            if (iThangNay == 1)
            {
                iThangTruoc = 12;
                iNamTruoc = iNamNay - 1;
            }
            string sReplace10 = "Thang=" + iThangTruoc + " AND Nam=" + iNamTruoc;
            string sReplace20 = "Thang=" + iThangNay + " And Nam=" + iNamNay;
            sSQL = sSQL.Replace("1 = 0", sReplace10).Replace("2 = 0", sReplace20);
            string sWhere = "";
            if (!cnn.bComboIsNull(cbxCoSo))
            {
                sWhere += "CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxPhanHe))
            {
                sWhere += "PhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxPhongBan))
            {
                sWhere += "PhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
            }
            if (cnn.sNull2Int(raTangGiam.EditValue) == 2)
            {
                sWhere += "Loai = 1 AND ";
            }
            else if (cnn.sNull2Int(raTangGiam.EditValue) == 3)
            {
                sWhere += "Loai = 2 AND ";
            }            
            if (sWhere != "")
            {
                sWhere = sWhere.Substring(0, sWhere.Length - 4);
                sSQL = "Select * from (" + sSQL + ")AAAA where " + sWhere;
            }
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = DT;
        }

        private void frmThongKeThayDoiLuong_Load(object sender, EventArgs e)
        {
            txtThang.uValue = DateTime.Now.Month;
            txtNam.uValue = DateTime.Now.Year;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\TK_ThayDoiLuong.repx", DT);
            frm.Show();
        }
    }
}