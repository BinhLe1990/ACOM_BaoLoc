using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.HeThong
{
    public partial class frmThongTinNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinNguoiDung()
        {
            InitializeComponent();
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        public string sTag = "";
        public DataRow row;

        private void frmThongTinNguoiDung_Load(object sender, EventArgs e)
        {
            string sql = "";
            DataTable dt = new DataTable();
            if (sTag == "frmCapNhatDiemThi")
            {
                sql = "select ND1.HoTen HoTen1, ND1.TaiKhoan TaiKhoan1, Ngay1, ND2.HoTen HoTen2, ND2.TaiKhoan TaiKhoan2, Ngay2 " +
                    " from EM_DT_SODIEM LEFT JOIN " +
                    " HT_NGUOIDUNG ND1 ON ND1.NguoiDung = EM_DT_SoDIEM.NguoiDung1 LEFT JOIN " +
                    " HT_NGUOIDUNG ND2 ON ND2.NguoiDung = EM_DT_SoDIEM.NguoiDung2 " +
                    " where SinhVien = N'" + row["SinhVien"] + "' AND MaLopHocPhan = N'" + row["MaLopHocPhan"] + "'";
                dt = cnn.SelectRows(sql);
            }
            if (dt.Rows.Count == 0)
                return;
            if (cnn.sNull2String(dt.Rows[0]["TaiKhoan1"].ToString()) != "")
            {
                txtNguoiDung1.uText = dt.Rows[0]["HoTen1"].ToString() + " (" + dt.Rows[0]["TaiKhoan1"].ToString() + ")";
                txtNgay1.uText = dt.Rows[0]["Ngay1"].ToString();
            }
            if (cnn.sNull2String(dt.Rows[0]["TaiKhoan2"].ToString()) != "")
            {
                txtNguoiDung2.uText = dt.Rows[0]["HoTen2"].ToString() + " (" + dt.Rows[0]["TaiKhoan2"].ToString() + ")";
                txtNgay2.uText = dt.Rows[0]["Ngay2"].ToString();
            }
        }
    }
}