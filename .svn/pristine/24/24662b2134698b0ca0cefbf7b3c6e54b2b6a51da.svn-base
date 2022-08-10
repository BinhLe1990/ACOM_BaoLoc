using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.NhanSu
{
    public partial class frmThongKeTheoLoaiHD : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKeTheoLoaiHD()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            dtg.sKEY = sKEY;
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKEY = "THONGKELOAIHD";

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable dt;
        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            string sSQL = cnn.GetSQLString(sKEY);
            if (!cnn.bComboIsNull(cboLoaiHD))
            {
                sSQL = sSQL.Replace("1=1", " DM_HD_LAODONG.MAHD_LAODONG=N'" + cnn.sNull2String(cboLoaiHD.uEditValue) + "'");
            }
            dt = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = dt;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dt==null || dt.Rows.Count == 0)
                return;
            BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\TK_LoaiHopDong.repx", dt);
            frm.Show();
        }
    }
}