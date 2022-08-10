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
    public partial class frmBC_TKToChucCanBo : DevExpress.XtraEditors.XtraForm
    {
        public frmBC_TKToChucCanBo()
        {
            InitializeComponent();
            clRun.SetValueToControl(this);
        }

        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clRun = new clsRun();
        string sSearchInf = "";

        private void cbxMauBaoCao_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Filter");
            dt.Rows.Add(new object[] { "1", "Thống kê cán bộ" });
            dt.Rows.Add(new object[] { "2", "Thống kê cán bộ viên chức cơ hữu, biên chế" });
            dt.Rows.Add(new object[] { "3", "Thống kê cán bộ viên chức thỉnh giảng, ngắn hạn" });
            dt.Rows.Add(new object[] { "4", "Báo cáo trình độ chuyên môn, chính trị, ngoại ngữ, tin học" });
            dt.Rows.Add(new object[] { "5", "Báo cáo theo ngạch" });
            dt.Rows.Add(new object[] { "6", "Báo cáo về độ tuổi" });

            cbxMauBaoCao.uDataSource = dt;
            cbxMauBaoCao.uDisplayMember = "Filter";
            cbxMauBaoCao.uValueMember = "ID";

        }

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            string sSearch = "";
            if (cnn.bComboIsNull(cbxMauBaoCao))
                return;
            DataTable dt = new DataTable();
            switch (cbxMauBaoCao.uEditValue.ToString())
            {
                case "1":
                    sSearchInf = "TK_GIAOVIEN";
                    dtg.sKEY = sSearchInf;
                    sSearch = cnn.GetSQLString(sSearchInf);
                    break;
                case "2":
                    sSearchInf = "TK_GIAOVIEN_COHUU";
                    dtg.sKEY = sSearchInf;
                    sSearch = cnn.GetSQLString(sSearchInf);
                    break;
                case "3":
                    sSearchInf = "TK_GIAOVIEN_THINHGIANG";
                    dtg.sKEY = sSearchInf;
                    sSearch = cnn.GetSQLString(sSearchInf);
                    break;
                case "4":
                    sSearchInf = "BC_CHUYENMON_CHINHTRI_NGOAINGU_TINHOC";
                    dtg.sKEY = sSearchInf;
                    sSearch = cnn.GetSQLString(sSearchInf);
                    break;
                case "5":
                    sSearchInf = "BC_NGACH";
                    dtg.sKEY = sSearchInf;
                    sSearch = cnn.GetSQLString(sSearchInf);
                    break;
                case "6":
                    sSearchInf = "BC_DOTUOI";
                    dtg.sKEY = sSearchInf;
                    sSearch = cnn.GetSQLString(sSearchInf);
                    break;
            }
            dt = cnn.SelectRows(sSearch,BSC_HRM.NET.BSC_Class.BSCConnection.BSCLoadType.UseLoadProcess);
            dtg.uDataSource = dt;
        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            if (cnn.sNull2String(cbxMauBaoCao.uEditValue) == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn mẫu cần in");
                return;
            }
            DataTable dt = dtg.GetDataSource();
            if (dt.Rows.Count == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để in!");
                return;
            }
            string FileIn = "";
            switch (cbxMauBaoCao.uEditValue.ToString())
            {

                case "1":
                    FileIn = "GV_TK_GiaoVien";
                    break;
                case "2":
                    FileIn = "GV_TK_GiaoVien_CoHuu";
                    break;
                case "3":
                    FileIn = "GV_TK_GiaoVien_ThinhGiang";
                    break;
                case "4":
                    FileIn = "GV_BC_ChuyenMon_ChinhTri_NgoaiNgu_TinHoc";
                    break;
                case "5":
                    FileIn = "GV_BC_Ngach";
                    break;
                case "6":
                    FileIn = "GV_BC_DoTuoi";
                    break;
                default:
                    FileIn = "";
                    break;
            }

            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\" + FileIn + ".repx", dt);
            frm.Show();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}