using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;

namespace BSC_HRM.NET.Luong
{
    public partial class frmThanhToanLuongQuaNganHang : DevExpress.XtraEditors.XtraForm
    {
        public frmThanhToanLuongQuaNganHang()
        {
            InitializeComponent();
            clsrun.SetValueToControl(this);
            dtg.sKEY = sKEY;
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsrun = new clsRun();
        string sKEY = "TONGHOPTHUNHAP";

        private void frmThanhToanLuongQuaNganHangp_Load(object sender, EventArgs e)
        {
            txtThang.uValue = DateTime.Now.Month;
            txtNam.uValue = DateTime.Now.Year;
            cbxNganHang.uEditValue = "01";
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string sSQL = cnn.GetSQLString(sKEY);
            string sReplace10 = "";
            string sReplace11 = "";
            if (!cnn.bComboIsNull(cbxCoSo))
                sReplace11 += "COSO=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxPhanHe))
                sReplace11 += "PhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxPhongBan))
                sReplace11 += "PhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxNganHang))
            {
                string sListNH = cnn.sNull2String(cnn.SQL_ExecuteScalar("SELECT DanhSachMaNganHang FROM  dbo.DM_NhomNganHang WHERE MaNhomNganHang=N'" + cnn.sNull2String(cbxNganHang.uEditValue) + "'"));
                sReplace11 += " NGANHANG IN (" + sListNH + ") AND ";                
            }
            if (sReplace11 != "")
            {
                sReplace11 = sReplace11.Substring(0, sReplace11.Length - 4);
                sSQL = sSQL.Replace("1 = 1", sReplace11);
            }
            
            sReplace10 = " Thang=" + txtThang.uValue + " AND Nam=" + txtNam.uValue;
            sSQL = sSQL.Replace("1 = 0", sReplace10);

            string sDKNgay = "", sDKNgay2 = "";
            if (cnn.sNull2String(dateTuNgay.uValue) != "" && cnn.sNull2String(dateDenNgay.uValue) == "")
            {
                sDKNgay = " Ngay >= '" + dateTuNgay.uDateTime.ToString("MM/dd/yyyy") + "'";
                sDKNgay2 = " NGAY1 >= '" + dateTuNgay.uDateTime.ToString("MM/dd/yyyy") + "'";
            }
            if (cnn.sNull2String(dateTuNgay.uValue) == "" && cnn.sNull2String(dateDenNgay.uValue) != "")
            {
                sDKNgay = " Ngay <= '" + dateDenNgay.uDateTime.ToString("MM/dd/yyyy") + "'";
                sDKNgay2 = " NGAY1 <= '" + dateDenNgay.uDateTime.ToString("MM/dd/yyyy") + "'";
            }
            if (cnn.sNull2String(dateTuNgay.uValue) != "" && cnn.sNull2String(dateDenNgay.uValue) != "")
            {
                sDKNgay = " Ngay >= '" + dateTuNgay.uDateTime.ToString("MM/dd/yyyy") + "' AND Ngay <= '" + dateDenNgay.uDateTime.ToString("MM/dd/yyyy") + "'";
                sDKNgay2 = " NGAY1 >= '" + dateTuNgay.uDateTime.ToString("MM/dd/yyyy") + "' AND NGAY1 <= '" + dateDenNgay.uDateTime.ToString("MM/dd/yyyy") + "'";
            }
            if (!cnn.bComboIsNull(cbxNoiDungChi))
            {
                sDKNgay += " AND NoiDungChi Like N'%"+cbxNoiDungChi.uText+"%'";
                sDKNgay2 += " AND NoiDung Like N'%" + cbxNoiDungChi.uText + "%'";
            }
            sSQL = sSQL.Replace("2 = 2", sDKNgay);
            sSQL = sSQL.Replace("3 = 3", sDKNgay2);

            string sReplace33 = "";
            if (ckListThuNhapChuyen.Items[0].CheckState == CheckState.Checked)//Tiền lương biên chế, hơp đồng
                sReplace33 += "Sort = 0 OR ";
            if (ckListThuNhapChuyen.Items[1].CheckState == CheckState.Checked)//Lương hợp đồng khoán
                sReplace33 += "Sort = 1 OR ";
            if (ckListThuNhapChuyen.Items[2].CheckState == CheckState.Checked)//Phúc lợi hàng tháng
                sReplace33 += "Sort = 2 OR ";
            if (ckListThuNhapChuyen.Items[3].CheckState == CheckState.Checked)//Phụ cấp trường - PTNK
                sReplace33 += "Sort = 5 OR ";
            if (ckListThuNhapChuyen.Items[4].CheckState == CheckState.Checked)//Thu nhập khác
                sReplace33 += "Sort = 6 OR ";
            if (ckListThuNhapChuyen.Items[5].CheckState == CheckState.Checked)//Thù lao giảng dạy
                sReplace33 += "Sort = 7 OR ";
            if (ckListThuNhapChuyen.Items[6].CheckState == CheckState.Checked)//Phụ cấp điện thoai
                sReplace33 += "Sort = 8 OR ";
            if (ckListThuNhapChuyen.Items[7].CheckState == CheckState.Checked)//Phụ cấp giỗ tổ Hùng Vương
                sReplace33 += "Sort = 9 OR ";
            if (ckListThuNhapChuyen.Items[8].CheckState == CheckState.Checked)//Phụ cấp 30/04-01/05
                sReplace33 += "Sort = 10 OR ";
            if (ckListThuNhapChuyen.Items[9].CheckState == CheckState.Checked)//Phụ cấp độc hại
                sReplace33 += "Sort = 11 OR ";
            if (ckListThuNhapChuyen.Items[10].CheckState == CheckState.Checked)//Phụ cấp khác
                sReplace33 += "Sort = 12 OR ";

            if (sReplace33 != "")
            {
                sReplace33 = sReplace33.Substring(0, sReplace33.Length - 4);
                sSQL = sSQL.Replace("3 = 3", sReplace33);
            }
            else
            {
                this.Cursor = Cursors.Default;
                XtraMessageBox.Show("Bạn phải chọn nội dung chuyển khoản ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = DT;
            this.Cursor = Cursors.Default;
        }

        private void ckListThuNhapChuyen_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (ckListThuNhapChuyen.Items[7].CheckState == CheckState.Checked)
            {
                cbxNoiDungChi.Visible = true;
                dateDenNgay.Visible = true;
                dateTuNgay.Visible = true;
                LoadNoiDungChi();
            }
            else
            {
                cbxNoiDungChi.Visible = false;
                dateDenNgay.Visible = false;
                dateTuNgay.Visible = false;
            }
        }
        private void LoadNoiDungChi()
        {
            string sSQL = "SELECT DISTINCT NoiDungChi FROM  dbo.NS_ThuLaoGiangDay WHERE Ngay>='" + dateTuNgay.uDateTime.ToString("MM/dd/yyyy") + "' AND Ngay<='" + dateDenNgay.uDateTime.ToString("MM/dd/yyyy") + "'";
            DataTable DT = cnn.DT_DataTable(sSQL);
            cbxNoiDungChi.uDisplayMember = "NoiDungChi";
            cbxNoiDungChi.uValueMember = "NoiDungChi";
            cbxNoiDungChi.uDataSource = DT;
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            popupMenu1.ShowPopup(MousePosition);   
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInDanhSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\ThanhToanLuongQuaNganHang.repx", DT);
            if (!cnn.bComboIsNull(cbxCoSo))
                frm.sCoSo = cbxCoSo.uText;
            if (!cnn.bComboIsNull(cbxPhanHe))
                frm.sPhanHe = cbxPhanHe.uText;
            if (!cnn.bComboIsNull(cbxPhongBan))
                frm.sPhongBan = cbxPhongBan.uText;
            if (!cnn.bComboIsNull(cbxTaiKhoan))
                frm.sNganHang = cbxTaiKhoan.uText;
            frm.iThang = cnn.sNull2Int(txtThang.uValue);
            frm.iNam = cnn.sNull2Int(txtNam.uValue);
            string sNoiDungChuyenKhoan = "";
            if (ckListThuNhapChuyen.Items[0].CheckState == CheckState.Checked)//Tiền lương biên chế, hơp đồng
                sNoiDungChuyenKhoan = "TIỀN LƯƠNG BIÊN CHẾ, HỢP ĐỒNG";
            if (ckListThuNhapChuyen.Items[1].CheckState == CheckState.Checked)//Lương hợp đồng khoán
                sNoiDungChuyenKhoan = "LƯƠNG HỢP ĐỒNG KHOÁN";
            if (ckListThuNhapChuyen.Items[2].CheckState == CheckState.Checked)//Phúc lợi hàng tháng
                sNoiDungChuyenKhoan = "PHÚC LỢI HÀNG THÁNG";
            if (ckListThuNhapChuyen.Items[3].CheckState == CheckState.Checked)//Phụ cấp khoa
                sNoiDungChuyenKhoan = "PHỤ CẤP KHOA";
            if (ckListThuNhapChuyen.Items[4].CheckState == CheckState.Checked)//Phụ cấp trường
                sNoiDungChuyenKhoan = "PHỤ CẤP TRƯỜNG";
            if (ckListThuNhapChuyen.Items[5].CheckState == CheckState.Checked)//Phụ cấp trường - PTNK
                sNoiDungChuyenKhoan = "PHỤ CẤP TRƯỜNG - PTNK";
            if (ckListThuNhapChuyen.Items[6].CheckState == CheckState.Checked)//Thu nhập khác
                sNoiDungChuyenKhoan = "THU NHẬP KHÁC";
            if (ckListThuNhapChuyen.Items[7].CheckState == CheckState.Checked)//Thù lao giảng dạy
                sNoiDungChuyenKhoan = "THÙ LAO GIẢNG DẠY";
            if (ckListThuNhapChuyen.Items[8].CheckState == CheckState.Checked)//Phụ cấp điện thoai
                sNoiDungChuyenKhoan = "PHỤ CẤP ĐIỆN THOẠI";
            if (ckListThuNhapChuyen.Items[9].CheckState == CheckState.Checked)//Phụ cấp giỗ tổ Hùng Vương
                sNoiDungChuyenKhoan = "PHỤ CẤP GIỖ TỔ HÙNG VƯƠNG 10/03 ÂM LỊCH";
            if (ckListThuNhapChuyen.Items[10].CheckState == CheckState.Checked)//Phụ cấp 30/04-01/05
                sNoiDungChuyenKhoan = "PHỤ CẤP 30/04 - 01/05";
            if (ckListThuNhapChuyen.Items[11].CheckState == CheckState.Checked)//Phụ cấp độc hại
                sNoiDungChuyenKhoan = "PHỤ CẤP ĐỘC HẠI";
            if (ckListThuNhapChuyen.Items[12].CheckState == CheckState.Checked)//Phụ cấp khác
                sNoiDungChuyenKhoan = "PHỤ CẤP KHÁC";
            frm.sNoiDungChuyenKhoan = sNoiDungChuyenKhoan;
            frm.Show();
        }

        private void btnExportToExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cnn.bComboIsNull(cbxTaiKhoan))
            {
                XtraMessageBox.Show("Bạn chưa chọn tài khoản ngân hàng của trường ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable DT = dtg.GetDataSource();
            string XLSfileName = ShowSaveFileDialog();
            if (XLSfileName != "")
            {
                Export(XLSfileName, DT);
            }
        }
        private string ShowSaveFileDialog()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Export To Microsoft Excel Document";
            dlg.OverwritePrompt = true;
            dlg.FileName = "ChuyenKhoanThuNhap_" + cnn.sNull2String(txtThang.uValue) + "_" + cnn.sNull2String(txtNam.uValue);
            dlg.Filter = "Excel Files|*.xls";
            if (dlg.ShowDialog() == DialogResult.OK) return dlg.FileName;// +".xls";
            return "";
        }
        private void Export(string _sDir, DataTable DT)
        {

            string sourceFileName = Application.StartupPath + @"\FileMau\ChuyenKhoanThuNhap.xls";
            if (!Directory.Exists(Application.StartupPath + @"\FileMau\"))
                Directory.CreateDirectory(Application.StartupPath + @"\FileMau\");
            string sServerPath = Program.sPathServer + @"FileMau\ChuyenKhoanThuNhap.xls";
            clsrun.CheckVersionReports(sServerPath, sourceFileName);

            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Excel.ApplicationClass xlApp = new Excel.ApplicationClass();
            Excel.Workbook xlBook;
            Excel.Worksheet xlSheet;
            try
            {
                File.Copy(sourceFileName, _sDir, true);
                xlBook = xlApp.Workbooks.Open(_sDir, 0, false, 5, null, null, false, Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                xlSheet = (Excel.Worksheet)xlBook.Worksheets.get_Item(1);
                xlSheet.Activate();
                xlApp.Visible = false;

                if (DT.Rows.Count > 0)
                {

                    int iStart = 4, iSTT = 1;
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                        xlSheet.Cells[iStart, 1] = "KO";
                        xlSheet.Cells[iStart, 2] = cnn.sNull2String(cbxTaiKhoan.GetColumnValue("SoTaiKhoanNganHangTruong"));
                        xlSheet.Cells[iStart, 3] = cnn.sNull2String(cbxTaiKhoan.GetColumnValue("TenTaiKhoanNganHangTruong"));
                        xlSheet.Cells[iStart, 4] = cnn.sNull2String(DT.Rows[i]["SoTaiKhoan"]);
                        xlSheet.Cells[iStart, 5] = cnn.sNull2String(DT.Rows[i]["HODEM"]) + " " + cnn.sNull2String(DT.Rows[i]["TEN"]);
                        xlSheet.Cells[iStart, 6] = cnn.sNull2String(DT.Rows[i]["VND"]);
                        xlSheet.Cells[iStart, 7] = cnn.sNull2String(DT.Rows[i]["ThucLanh"]);
                        xlSheet.Cells[iStart, 8] = dtpNgayChuyen.uDateTime.ToString("yyyyMMdd");
                        xlSheet.Cells[iStart, 9] = cnn.sNull2String(DT.Rows[i]["TenNganHang"]);
                        xlSheet.Cells[iStart, 10] = cnn.sNull2String(DT.Rows[i]["NganHangChiNhanh"]);
                        xlSheet.Cells[iStart, 11] = cnn.sNull2String(DT.Rows[i]["NoiDung"]);

                        iStart++;
                        iSTT++;
                    }
                    iStart--;
                    
                    xlBook.Save();
                }                
                xlApp.Visible = true;
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                Cursor.Current = currentCursor;
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("Bạn phải đóng file Excel","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                xlApp.Workbooks.Close();
                xlApp.Quit();
            }
        }

        private void dateTuNgay_uEditValueChanged(object sender, EventArgs e)
        {
            LoadNoiDungChi();
        }

        private void dateDenNgay_uEditValueChanged(object sender, EventArgs e)
        {
            LoadNoiDungChi();
        }

        private void menuMau2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\ThanhToanLuongQuaNganHang_Mau2.repx", DT);
            if (!cnn.bComboIsNull(cbxCoSo))
                frm.sCoSo = cbxCoSo.uText;
            if (!cnn.bComboIsNull(cbxPhanHe))
                frm.sPhanHe = cbxPhanHe.uText;
            if (!cnn.bComboIsNull(cbxPhongBan))
                frm.sPhongBan = cbxPhongBan.uText;
            if (!cnn.bComboIsNull(cbxTaiKhoan))
                frm.sNganHang = cbxTaiKhoan.uText;
            frm.iThang = cnn.sNull2Int(txtThang.uValue);
            frm.iNam = cnn.sNull2Int(txtNam.uValue);
            string sNoiDungChuyenKhoan = "";
            if (ckListThuNhapChuyen.Items[0].CheckState == CheckState.Checked)//Tiền lương biên chế, hơp đồng
                sNoiDungChuyenKhoan = "TIỀN LƯƠNG BIÊN CHẾ, HỢP ĐỒNG";
            if (ckListThuNhapChuyen.Items[1].CheckState == CheckState.Checked)//Lương hợp đồng khoán
                sNoiDungChuyenKhoan = "LƯƠNG HỢP ĐỒNG KHOÁN";
            if (ckListThuNhapChuyen.Items[2].CheckState == CheckState.Checked)//Phúc lợi hàng tháng
                sNoiDungChuyenKhoan = "PHÚC LỢI HÀNG THÁNG";
            if (ckListThuNhapChuyen.Items[3].CheckState == CheckState.Checked)//Phụ cấp khoa
                sNoiDungChuyenKhoan = "PHỤ CẤP KHOA";
            if (ckListThuNhapChuyen.Items[4].CheckState == CheckState.Checked)//Phụ cấp trường
                sNoiDungChuyenKhoan = "PHỤ CẤP TRƯỜNG";
            if (ckListThuNhapChuyen.Items[5].CheckState == CheckState.Checked)//Phụ cấp trường - PTNK
                sNoiDungChuyenKhoan = "PHỤ CẤP TRƯỜNG - PTNK";
            if (ckListThuNhapChuyen.Items[6].CheckState == CheckState.Checked)//Thu nhập khác
                sNoiDungChuyenKhoan = "THU NHẬP KHÁC";
            if (ckListThuNhapChuyen.Items[7].CheckState == CheckState.Checked)//Thù lao giảng dạy
                sNoiDungChuyenKhoan = "THÙ LAO GIẢNG DẠY";
            if (ckListThuNhapChuyen.Items[8].CheckState == CheckState.Checked)//Phụ cấp điện thoai
                sNoiDungChuyenKhoan = "PHỤ CẤP ĐIỆN THOẠI";
            if (ckListThuNhapChuyen.Items[9].CheckState == CheckState.Checked)//Phụ cấp giỗ tổ Hùng Vương
                sNoiDungChuyenKhoan = "PHỤ CẤP GIỖ TỔ HÙNG VƯƠNG 10/03 ÂM LỊCH";
            if (ckListThuNhapChuyen.Items[10].CheckState == CheckState.Checked)//Phụ cấp 30/04-01/05
                sNoiDungChuyenKhoan = "PHỤ CẤP 30/04 - 01/05";
            if (ckListThuNhapChuyen.Items[11].CheckState == CheckState.Checked)//Phụ cấp độc hại
                sNoiDungChuyenKhoan = "PHỤ CẤP ĐỘC HẠI";
            if (ckListThuNhapChuyen.Items[12].CheckState == CheckState.Checked)//Phụ cấp khác
                sNoiDungChuyenKhoan = "PHỤ CẤP KHÁC";
            frm.sNoiDungChuyenKhoan = sNoiDungChuyenKhoan;
            frm.Show();
        }
    }
}