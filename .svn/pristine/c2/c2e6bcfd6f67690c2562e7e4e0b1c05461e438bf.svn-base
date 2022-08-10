using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using System.Data.OleDb;

namespace BSC_HRM.NET.Luong
{
    public partial class frmThuLaoGiangDay : DevExpress.XtraEditors.XtraForm
    {
        public frmThuLaoGiangDay()
        {
            InitializeComponent();
            clsrun.SetValueToControl(this);
            dtg.sKEY = sKEY;
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsrun = new clsRun();
        string sKEY = "THULAOGIANGDAY_TONGHOP";

        private void cbxPhanHe_Load(object sender, EventArgs e)
        {
            cbxPhanHe.uDataSource = cnn.SelectRows_NonSortOrder("SELECT * FROM dbo.DM_PHANHE WHERE MAPHANHE != 03");
        }

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            string sDKNgay = "";
            if (cnn.sNull2String(dateTuNgay.uValue) != "" && cnn.sNull2String(dateDenNgay.uValue) == "")
                sDKNgay = " Ngay >= '" + dateTuNgay.uDateTime.ToString("MM/dd/yyyy") + "'";
            if (cnn.sNull2String(dateTuNgay.uValue) == "" && cnn.sNull2String(dateDenNgay.uValue) != "")
                sDKNgay = " Ngay <= '" + dateDenNgay.uDateTime.ToString("MM/dd/yyyy") + "'";
            if (cnn.sNull2String(dateTuNgay.uValue) != "" && cnn.sNull2String(dateDenNgay.uValue) != "")
                sDKNgay = " Ngay >= '" + dateTuNgay.uDateTime.ToString("MM/dd/yyyy") + "' AND Ngay <= '" + dateDenNgay.uDateTime.ToString("MM/dd/yyyy") + "'";

            string sSQL = cnn.GetSQLString(sKEY);
            sSQL = sSQL.Replace("1 = 1", sDKNgay);

            string sReplace2 = "";
            if (!cnn.bComboIsNull(cbxCoSo))
                sReplace2 += " CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxPhanHe))
                sReplace2 += " PhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxNoiDungChi))
                sReplace2 += " NoiDungChi LIKE N'%" + cbxNoiDungChi.uText + "%' AND ";
            if (cnn.sNull2String(txtDonViNhan.uText) != "")
                sReplace2 += " DonViNhan LIKE N'%" + cnn.sNull2String(txtDonViNhan.uText) + "%' AND ";
            if (!cnn.bComboIsNull(cbxNganHang))
            {
                string sListNH = cnn.sNull2String(cnn.SQL_ExecuteScalar("SELECT DanhSachMaNganHang FROM  dbo.DM_NhomNganHang WHERE MaNhomNganHang=N'"+cnn.sNull2String(cbxNganHang.uEditValue)+"'"));
                sReplace2 += " NGANHANG IN (" + sListNH + ") AND ";
            }
            if (sReplace2.Length > 0)
            {
                sReplace2 = sReplace2.Substring(0, sReplace2.Length - 4);
                sSQL = sSQL.Replace("2 = 2", sReplace2);
            }
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = DT;
        }

        private void btnTinhThuLao_Click(object sender, EventArgs e)
        {
            string sDKNgay = "";
            if (cnn.sNull2String(dateTuNgay.uValue) != "" && cnn.sNull2String(dateDenNgay.uValue) == "")
                sDKNgay = " Ngay >= '" + dateTuNgay.uDateTime.ToString("MM/dd/yyyy") + "'";
            if (cnn.sNull2String(dateTuNgay.uValue) == "" && cnn.sNull2String(dateDenNgay.uValue) != "")
                sDKNgay = " Ngay <= '" + dateDenNgay.uDateTime.ToString("MM/dd/yyyy") + "'";
            if (cnn.sNull2String(dateTuNgay.uValue) != "" && cnn.sNull2String(dateDenNgay.uValue) != "")
                sDKNgay = " Ngay >= '" + dateTuNgay.uDateTime.ToString("MM/dd/yyyy") + "' AND Ngay <= '" + dateDenNgay.uDateTime.ToString("MM/dd/yyyy") + "'";

            string sSQL = cnn.GetSQLString("THULAOGIANGDAY_TINHTHULAO");
            sSQL = sSQL.Replace("1 = 1", sDKNgay);

            string sReplace2 = "";
            if (!cnn.bComboIsNull(cbxCoSo))
                sReplace2 += " CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxPhanHe))
                sReplace2 += " PhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxNoiDungChi))
                sReplace2 += " NoiDungChi LIKE N'%" + cbxNoiDungChi.uText + "%' AND ";
            if (cnn.sNull2String(txtDonViNhan.uText) != "")
                sReplace2 += " DonViNhan LIKE N'%" + cnn.sNull2String(txtDonViNhan.uText) + "%' AND ";
            if (!cnn.bComboIsNull(cbxNganHang))
            {
                string sListNH = cnn.sNull2String(cnn.SQL_ExecuteScalar("SELECT DanhSachMaNganHang FROM  dbo.DM_NhomNganHang WHERE MaNhomNganHang=N'" + cnn.sNull2String(cbxNganHang.uEditValue) + "'"));
                sReplace2 += " NGANHANG IN (" + sListNH + ") AND ";
            }
            if (sReplace2.Length > 0)
            {
                sReplace2 = sReplace2.Substring(0, sReplace2.Length - 4);
                sSQL = sSQL.Replace("2 = 2", sReplace2);
            }
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = DT;
        }
        
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Hashtable Val = new Hashtable();
            Hashtable Cond = new Hashtable();
            foreach (DataRow row in dtg.GetDataSource().Rows)
            {
                Cond.Clear();
                Val.Clear();
                Cond.Add("Ngay", Convert.ToDateTime(row["Ngay"]).ToString("MM/dd/yyyy"));
                Cond.Add("Thang", cnn.sNull2Int(Convert.ToDateTime(row["Ngay"]).Month));
                Cond.Add("Nam", cnn.sNull2Int(Convert.ToDateTime(row["Ngay"]).Year));
                Cond.Add("NhanSu", row["NhanSu"].ToString());

                Val.Add("MA", row["MA"]);
                Val.Add("CMND", row["SOCMND"]);
                Val.Add("NoiDungChi", row["NoiDungChi"]);
                Val.Add("DonViNhan", row["DonViNhan"]);
                Val.Add("TongTien", cnn.sNull2Number(row["TongTien"]));
                Val.Add("PTThueTNCN", cnn.sNull2Number(row["PTThueTNCN"]));
                Val.Add("TienThueTNCN", cnn.sNull2Number(row["TienThueTNCN"]));
                Val.Add("ThucLanh", cnn.sNull2Number(row["ThucLanh"]));
                Val.Add("PhiChuyenKhoan", cnn.sNull2Number(row["PhiChuyenKhoan"]));
                Val.Add("GhiChu", row["GhiChu"].ToString());
                Val.Add("SoChungTu", row["SoChungTu"].ToString());
                string sNgayChungTu = string.Empty;
                try
                {
                    sNgayChungTu = Convert.ToDateTime(row["NgayChungTu"]).ToString("MM/dd/yyyy");
                }
                catch
                {
                    sNgayChungTu = string.Empty;
                }
                Val.Add("NgayChungTu", sNgayChungTu);

                if (cnn.SelectRows(Cond, "NS_ThuLaoGiangDay").Rows.Count > 0)
                {
                    cnn.UpdateRows(Val, Cond, "NS_ThuLaoGiangDay");
                }
                else
                {
                    Val.Add("Ngay", Convert.ToDateTime(row["Ngay"]).ToString("MM/dd/yyyy"));
                    Val.Add("Thang", cnn.sNull2Int(Convert.ToDateTime(row["Ngay"]).Month));
                    Val.Add("Nam", cnn.sNull2Int(Convert.ToDateTime(row["Ngay"]).Year));
                    Val.Add("NhanSu", row["NhanSu"].ToString());
                    cnn.InsertNewRow(Val, "NS_ThuLaoGiangDay");
                }
            }
            XtraMessageBox.Show("Cập nhật thành công", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLocDanhSach_Click(sender, e);
        }
        
        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            popupMenu1.ShowPopup(MousePosition);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuMau1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            decimal TongThucLanh = 0;
            foreach (DataRow r in DT.Rows)
            {
                TongThucLanh += cnn.sNull2Number(r["ThucLanh"]);
            }
            BSC_Class.Doctien doctien = new BSC_HRM.NET.BSC_Class.Doctien();
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BangThuLaoGiangDay.repx", DT);
            frm.sSoTienBangChu = doctien.Convert_NumtoText(TongThucLanh.ToString());
            frm.sTime_FromTo = clsrun.sTime(dateTuNgay.uValue, dateDenNgay.uValue);
            frm.Show();
        }

        private void menuMau2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            decimal TongThucLanh = 0;
            foreach (DataRow r in DT.Rows)
            {
                TongThucLanh += cnn.sNull2Number(r["TongTien"]);
            }
            BSC_Class.Doctien doctien = new BSC_HRM.NET.BSC_Class.Doctien();
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BangThuLaoGiangDay_Mau2.repx", DT);
            frm.sSoTienBangChu = doctien.Convert_NumtoText(TongThucLanh.ToString());
            frm.sTime_FromTo = clsrun.sTime(dateTuNgay.uValue, dateDenNgay.uValue);
            frm.Show();
        }

        private void dtg_uCellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "PhiChuyenKhoan")
                {
                    dtg.CurRow["ThucLanh"] = cnn.sNull2Number(dtg.CurRow["TongTien"]) -cnn.sNull2Number(dtg.CurRow["TienThueTNCN"])- cnn.sNull2Number(dtg.CurRow["PhiChuyenKhoan"]);
                }
            }
            catch
            { }
        }
        
        private void dtg_uDataSourceChanged(object sender, EventArgs e)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
            {
                if (col.FieldName != "PhiChuyenKhoan" && col.FieldName != "GhiChu" && col.FieldName != "SoChungTu" && col.FieldName != "NgayChungTu")
                    col.OptionsColumn.AllowEdit = false;
            }
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa dòng chọn không?", "Xóa dòng chọn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cnn.DeleteRows("DELETE FROM NS_ThuLaoGiangDay WHERE Ngay = '" + Convert.ToDateTime(dtg.CurRow["Ngay"]).ToString("MM/dd/yyyy") + "' AND NhanSu = '" + dtg.CurRow["NhanSu"].ToString() + "'");
                XtraMessageBox.Show("Xóa thành công", "Xóa dòng chọn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLocDanhSach_Click(sender, e);
            }
        }

        private void frmThuLaoGiangDay_Load(object sender, EventArgs e)
        {
            LoadNoiDungChi();
        }
        private void LoadNoiDungChi()
        {
            string sSQL = "SELECT DISTINCT NoiDungChi FROM  dbo.NS_ThuLaoGiangDayChiTiet WHERE Ngay>='"+dateTuNgay.uDateTime.ToString("MM/dd/yyyy")+"' AND Ngay<='"+dateDenNgay.uDateTime.ToString("MM/dd/yyyy")+"'";
            DataTable DT = cnn.DT_DataTable(sSQL);
            cbxNoiDungChi.uDisplayMember = "NoiDungChi";
            cbxNoiDungChi.uValueMember = "NoiDungChi";
            cbxNoiDungChi.uDataSource = DT;

        }

        private void dateTuNgay_uEditValueChanged(object sender, EventArgs e)
        {
            LoadNoiDungChi();
        }

        private void dateDenNgay_uEditValueChanged(object sender, EventArgs e)
        {
            LoadNoiDungChi();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable DT = dtg.GetDataSource();
                if (DT != null && DT.Rows.Count > 0)
                {
                    foreach (DataRow r in DT.Rows)
                    {
                        r["SoChungTu"] = txtSoChungTu.uText;
                        r["NgayChungTu"] = dtpNgayChungTu.uDateTime;
                    }
                    dtg.uDataSource = DT;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}