using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BSC_HRM.NET.BSC_Class;
using System.Collections;

namespace BSC_HRM.NET.NhanSu
{
    public partial class frmThongKeThiDua : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKeThiDua()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
        }
        BSC_Class.BSCConnection cnn = new BSCConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKeyCaNhan = "THONGKETHIDUACANHAN";
        string sKeyTapThe = "THONGKETHIDUATAPTHE";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            if (raLoai.EditValue.ToString() == "0")
            {
                string sSQL = cnn.GetSQLString(sKeyCaNhan);
                int NamBatDau = (int)txtTuNam.uValue;
                sSQL = sSQL.Replace("1111", NamBatDau.ToString());
                sSQL = sSQL.Replace("1112", (NamBatDau + 1).ToString());
                sSQL = sSQL.Replace("1113", (NamBatDau + 2).ToString());
                sSQL = sSQL.Replace("1114", (NamBatDau + 3).ToString());
                sSQL = sSQL.Replace("1115", (NamBatDau + 4).ToString());
                sSQL = sSQL.Replace("1116", (NamBatDau + 5).ToString());
                dtg.sKEY = sKeyCaNhan;
                string sWhere = "";
                if (!cnn.bComboIsNull(cbxCoSo))
                    sWhere += "COSO=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
                if (!cnn.bComboIsNull(cbxPhanHe))
                    sWhere += "PhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
                if (!cnn.bComboIsNull(cbxPhongBan))
                    sWhere += "PhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
                if (sWhere != "")
                {
                    sWhere = sWhere.Substring(0, sWhere.Length - 4);
                    sSQL = sSQL.Replace("1 = 1", sWhere);
                }
                DataTable DT = cnn.DT_DataTable(sSQL);
                dtg.uDataSource = DT;
            }
            else
            {
                string sSQL = cnn.GetSQLString(sKeyTapThe);
                int NamBatDau = (int)txtTuNam.uValue;
                sSQL = sSQL.Replace("1111", NamBatDau.ToString());
                sSQL = sSQL.Replace("1112", (NamBatDau + 1).ToString());
                sSQL = sSQL.Replace("1113", (NamBatDau + 2).ToString());
                sSQL = sSQL.Replace("1114", (NamBatDau + 3).ToString());
                sSQL = sSQL.Replace("1115", (NamBatDau + 4).ToString());
                sSQL = sSQL.Replace("1116", (NamBatDau + 5).ToString());
                dtg.sKEY = sKeyTapThe;
                string sWhere = "";
                if (!cnn.bComboIsNull(cbxPhongBan))
                    sWhere += "dbo.DM_PHONGBAN.MAPHONGBAN=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
                if (sWhere != "")
                {
                    sWhere = sWhere.Substring(0, sWhere.Length - 4);
                    sSQL = sSQL.Replace("1 = 1", sWhere);
                }
                DataTable DT = cnn.DT_DataTable(sSQL);
                dtg.uDataSource = DT;
            }
        }

        private void frmXetThiDua_Load(object sender, EventArgs e)
        {
            txtTuNam.uValue = cnn.GetDateServer().Year;
        }

        private void raLoai_EditValueChanged(object sender, EventArgs e)
        {
            btnLocDanhSach_Click(null, null);
        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            if (raLoai.EditValue.ToString() == "0")
            {
                DataTable DT = dtg.GetDataSource();
                BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\ThongKeThiDuaCaNhan.repx", DT);
                int tunam=(int)txtTuNam.uValue;
                frm.NamXet[0] = tunam.ToString();
                frm.NamXet[1] = (tunam+1).ToString();
                frm.NamXet[2] = (tunam +2).ToString();
                frm.NamXet[3] = (tunam + 3).ToString();
                frm.NamXet[4] = (tunam + 4).ToString();
                frm.NamXet[5] = (tunam + 5).ToString();
                frm.Show();
            }
            else
            {
                DataTable DT = dtg.GetDataSource();
                BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\ThongKeThiDuaTapThe.repx", DT);
                int tunam = (int)txtTuNam.uValue;
                frm.NamXet[0] = tunam.ToString();
                frm.NamXet[1] = (tunam + 1).ToString();
                frm.NamXet[2] = (tunam + 2).ToString();
                frm.NamXet[3] = (tunam + 3).ToString();
                frm.NamXet[4] = (tunam + 4).ToString();
                frm.NamXet[5] = (tunam + 5).ToString();
                frm.Show();
            }
        }      
        
    }
}