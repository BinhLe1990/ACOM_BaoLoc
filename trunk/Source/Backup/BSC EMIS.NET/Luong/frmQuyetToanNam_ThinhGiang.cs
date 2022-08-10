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
    public partial class frmQuyetToanNam_ThinhGiang : DevExpress.XtraEditors.XtraForm
    {
        public frmQuyetToanNam_ThinhGiang()
        {
            InitializeComponent();
            clsrun.SetValueToControl(this);
            dtg.sKEY = sKEY;
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsrun = new clsRun();
        string sKEY = "QUYETTOANTHUE_NAM_THINHGIANG";
        private void cbxPhongBan_uEditValueChanged(object sender, EventArgs e)
        {
            string sSQL = "Select MaDonVi,TenDonVi from DM_DonVi where MaPhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "'";
            DataTable DT = cnn.DT_DataTable(sSQL);
            cbxDonVi.uDataSource = DT;
        }
        private decimal TinhThue(decimal dTienChiuThue)
        {
            decimal dTongTienThue = 0;
            string sBacThue = "SELECT * FROM  dbo.DM_BieuThueLuyTien WHERE TinhThueNamTu<" + dTienChiuThue + " AND TinhThueNamDen>=" + dTienChiuThue;
            DataTable DTBacThue = cnn.DT_DataTable(sBacThue);
            int iBacThue = 0;
            if (DTBacThue != null && DTBacThue.Rows.Count > 0)
            {
                iBacThue = cnn.sNull2Int(DTBacThue.Rows[0]["BacThue"]);
                string sBangTinh = "SELECT * FROM  dbo.DM_BieuThueLuyTien WHERE BacThue<" + iBacThue + " ORDER BY BacThue";
                DataTable DTBangTinh = cnn.DT_DataTable(sBangTinh);
                foreach (DataRow r in DTBangTinh.Rows)
                {
                    dTongTienThue += (cnn.sNull2Number(r["TinhThueNamDen"]) - cnn.sNull2Number(r["TinhThueNamTu"])) * cnn.sNull2Number(r["PTThueSuat"]) / 100;
                }
                dTongTienThue += (dTienChiuThue - cnn.sNull2Number(DTBacThue.Rows[0]["TinhThueNamTu"])) * cnn.sNull2Number(DTBacThue.Rows[0]["PTThueSuat"]) / 100;
            }
            return dTongTienThue;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInBanThue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BangTinhThueTNCN_Nam.repx", DT);
            frm.iNam = cnn.sNull2Int(txtNam.uValue);
            frm.Show();
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private string ShowSaveFileDialog()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Export To Microsoft Excel Document";
            dlg.OverwritePrompt = true;
            dlg.FileName = cnn.sNull2String(cbxPhanHe.uEditValue)+".Bang_Ke_05AK_"+cnn.sNull2Int(txtNam.uValue);
            dlg.Filter = "Excel Files|*.xls";
            if (dlg.ShowDialog() == DialogResult.OK) return dlg.FileName + ".xls";
            return "";
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            string XLSfileName = ShowSaveFileDialog();
            if (XLSfileName != "")
            {
                Export(XLSfileName, DT);
            }
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cbxPhanHe))
            {
                XtraMessageBox.Show("Bạn chưa chọn phân hệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "04")
            {
                string sKEY = "QUYETTOANTHUE_NAM_THINHGIANG";
                dtg.sKEY = sKEY;
                string sSQL = cnn.GetSQLString(sKEY);
                string sReplace = sReplace = "Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND ";
                if (!cnn.bComboIsNull(cbxCoSo))
                    sReplace += "NS_NhanSu.CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";                
                if (!cnn.bComboIsNull(cbxPhongBan))
                    sReplace += "NS_NhanSu.PhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
                if (!cnn.bComboIsNull(cbxDonVi))
                    sReplace += "NS_NhanSu.DonVi=N'" + cnn.sNull2String(cbxDonVi.uEditValue) + "' AND ";
                sReplace = sReplace.Substring(0, sReplace.Length - 4);
                sSQL = sSQL.Replace("1 = 0", sReplace);
                DataTable DT = cnn.DT_DataTable(sSQL);
                dtg.uDataSource = DT;
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
                string sKEY = "XETQUYETTOANTHUE_NAM";
                dtg.sKEY = sKEY;
                string sSQL = cnn.GetSQLString(sKEY);
                string sReplace20 = "";
                string sReplace10 = "";
                string sReplace22 = "";
                string sReplace30 = "(Thang=5 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + ")OR (Thang=8 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + ") OR (Thang=11 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + ") OR (Thang=2 AND Nam=" + (cnn.sNull2Int(txtNam.uValue) + 1) + ")";
                sReplace20 = "Nam=" + cnn.sNull2Int(txtNam.uValue);
                sReplace10 = "NS_BangLuongHopDongBienChe.Nam=" + cnn.sNull2Int(txtNam.uValue);
                if (!cnn.bComboIsNull(cbxCoSo))
                    sReplace22 += "NS_NhanSu.CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
                if (!cnn.bComboIsNull(cbxPhanHe))
                    sReplace22 += "NS_NhanSu.Phanhe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
                if (!cnn.bComboIsNull(cbxPhongBan))
                    sReplace22 += "NS_NhanSu.PhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
                if (!cnn.bComboIsNull(cbxDonVi))
                    sReplace22 += "NS_NhanSu.DonVi=N'" + cnn.sNull2String(cbxDonVi.uEditValue) + "' AND ";
                sSQL = sSQL.Replace("1 = 0", sReplace10).Replace("2 = 0", sReplace20).Replace("3 = 0", sReplace30).Replace("IsTuQuyetToanThueNam = 0", "IsTuQuyetToanThueNam = 1");
                if (sReplace22 != "")
                {
                    sReplace22 = sReplace22.Substring(0, sReplace22.Length - 4);
                    sSQL = sSQL.Replace("2 = 2", sReplace22);
                }
                DataTable DT = cnn.DT_DataTable(sSQL);
                foreach (DataRow r in DT.Rows)
                {
                    r["TienThueTNCNPhaiNop"] = TinhThue(cnn.sNull2Number(r["ThuNhapTinhThue"]));
                    r["TienThueTNCNPhaiKhauTru"] = cnn.sNull2Number(r["TienThueTNCNPhaiNop"]) - cnn.sNull2Number(r["TienThueTNCNDaKhauTru"]);
                }
                dtg.uDataSource = DT;
                this.Cursor = Cursors.Default;
            }
        }
        private void frmQuyetToanNam_ThinhGiang_Load(object sender, EventArgs e)
        {
            txtNam.uValue = DateTime.Now.Year;
        }
        
        private void Export(string _sDir,DataTable DT)
        {

            string sourceFileName = Application.StartupPath + @"\FileMau\BangKe_ThinhGiang.xls";
            if (!Directory.Exists(Application.StartupPath + @"\FileMau\"))
                Directory.CreateDirectory(Application.StartupPath + @"\FileMau\");
            string sServerPath = Program.sPathServer + @"FileMau\BangKe_ThinhGiang.xls";
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
                        xlSheet.Cells[iStart, 1] = iSTT.ToString();
                        xlSheet.Cells[iStart, 2] = cnn.sNull2String(cnn.sNull2String(DT.Rows[i]["HODEM"]) + " " + cnn.sNull2String(DT.Rows[i]["TEN"]));
                        xlSheet.Cells[iStart, 3] = cnn.sNull2String(DT.Rows[i]["MST"]);
                        xlSheet.Cells[iStart, 4] = cnn.sNull2String(DT.Rows[i]["SOCMND"]);
                        xlSheet.Cells[iStart, 6] = cnn.sNull2String(DT.Rows[i]["TongThuNhap"]);
                        xlSheet.Cells[iStart, 8] = cnn.sNull2String(DT.Rows[i]["TienThueTNCNDaKhauTru"]);
                        xlSheet.Cells[iStart, 9] = cnn.sNull2String(DT.Rows[i]["TienThueTNCNPhaiKhauTru"]);                                                            
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
                XtraMessageBox.Show("Bạn phải đóng file Excel", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                xlApp.Workbooks.Close();
                xlApp.Quit();               
            }
        }

        private void cbxPhanHe_Load(object sender, EventArgs e)
        {
            cbxPhanHe.uDataSource = cnn.SelectRows_NonSortOrder("SELECT MaPhanHe,TenPhanHe FROM dbo.DM_PHANHE WHERE MAPHANHE NOT IN ('03')");
        }

        
    }
}