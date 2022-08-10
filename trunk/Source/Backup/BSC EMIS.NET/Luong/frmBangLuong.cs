using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace BSC_HRM.NET.Luong
{
    public partial class frmBangLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmBangLuong()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            string sPermit = Properties.Settings.Default.PER_SYSTEM;
            string sTag = cnn.sNull2String(this.Tag);
            if (sTag == "")
                bBanDau = false;
            if (sPermit.Contains(sTag))
                bBanDau = true;
            btnXetBangLuong.Enabled = false;
            btnCapNhat.Enabled = false;
            btnMoKhoa.Enabled = false;
            btnKhoa.Enabled = false;
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKEYHOPDONG_BIENCHE = "BANGLUONG_HOPDONG_BIENCHE";
        string sKEYKHOAN = "BANLUONG_KHOAN";
        string sKEYHOPDONG68 = "BANGLUONGHOPDONG68";
        bool bLock = false;
        bool bBanDau = false;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            txtNam.uValue = DateTime.Now.Year;
            txtThang.uValue = DateTime.Now.Month;
        }      

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            //if (cnn.bComboIsNull(cbxCoSo))
            //{
            //    XtraMessageBox.Show("Bạn chưa chọn cơ sở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            if (cnn.bComboIsNull(cbxPhanHe))
            {
                XtraMessageBox.Show("Bạn chưa chọn phân hệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sSQL = "";
            string sFieldSum = "";
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "01" || cnn.sNull2String(cbxPhanHe.uEditValue) == "02")
            {                
                sSQL = cnn.GetSQLString("INBANGLUONGBIENCHE");
                dtg.sKEY = sKEYHOPDONG_BIENCHE;
                sFieldSum = "TongTienHeSo,TienUuDai,TienPhuCapTrachNhiem,TienThemGio,TienChiTieuNoiBo,TienPhuCapHCCB,TienBHXH_YT,TienKinhPhiCongDoan,TienBHTN,TienBHXH_YT_Truong,TienKinhPhiCongDoan_Truong,TienBHTN_Truong,ThucLanh,ThueTNCN,CongNo,ThueTNCN_Nop,ThueTNCN_ConLai";
            }
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")
            {
                sSQL = cnn.GetSQLString("INBANGLUONGHOPDONG68");
                dtg.sKEY = sKEYHOPDONG68;
                sFieldSum = "TongTienHeSo,TienPhuCapTrachNhiem,TienThemGio_DocHai,TienHanhChinh,TienPhuCapHCCB,TienBHXH_YT,TienKinhPhiCongDoan,TienBHTN,TienBHXH_YT_Truong,TienKinhPhiCongDoan_Truong,TienBHTN_Truong,ThucLanh,ThueTNCN,CongNo,ThueTNCN_Nop,ThueTNCN_ConLai";
            }
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "03")
            {                
                sSQL = cnn.GetSQLString("INBANGLUONGKHOAN");
                dtg.sKEY = sKEYKHOAN;
                sFieldSum = "ThucLanh";
            }
            string sCond = " Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND ";
            if (!cnn.bComboIsNull(cboPhongBan))
            {
                sCond += " NS_NhanSu.PHONGBAN=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxDonVi))
            {
                sCond += " NS_NhanSu.DONVI=N'" + cnn.sNull2String(cbxDonVi.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxCoSo))
            {
                if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")
                {
                    sCond += " NS_BangLuongHopDong68.MaCoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
                }
                else if (cnn.sNull2String(cbxPhanHe.uEditValue) != "03")
                {
                    sCond += " NS_BangLuongHopDongBienChe.MaCoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
                }
                else
                {
                    sCond += " NS_NhanSu.CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
                }
            }
            if (!cnn.bComboIsNull(cbxPhanHe) && cnn.sNull2String(cbxPhanHe.uEditValue) == "05")
            {
                sCond += " NS_BangLuongHopDong68.MaPhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            }
            else if (!cnn.bComboIsNull(cbxPhanHe) && cnn.sNull2String(cbxPhanHe.uEditValue) != "03")
            {
                sCond += " NS_BangLuongHopDongBienChe.MaPhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            }
            sCond = sCond.Substring(0, sCond.Length - 4);
            sSQL = sSQL.Replace("1 = 0", sCond);
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.sFieldSummary = sFieldSum;
            dtg.uDataSource = DT;            
            EditColumn();

        }
        private void EditColumn()
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
            {
                if (col.FieldName != "TienThemGio" && col.FieldName != "SoChungTu" && col.FieldName != "NgayChungTu" && col.FieldName != "CongNo" && col.FieldName != "ThueTNCN_Nop" && col.FieldName != "GhiChu")
                    col.OptionsColumn.AllowEdit = false;
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cbxCoSo))
            {
                XtraMessageBox.Show("Bạn chưa chọn cơ sở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.bComboIsNull(cbxPhanHe))
            {
                XtraMessageBox.Show("Bạn chưa chọn phân hệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc muốn cập nhật bảng lương hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable DT = dtg.GetDataSource();
                if (DT != null && DT.Rows.Count > 0)
                {
                    this.Cursor = Cursors.WaitCursor;
                    Hashtable Val = new Hashtable();
                    Hashtable Cond = new Hashtable();
                    if (cnn.sNull2String(cbxPhanHe.uEditValue) == "01" || cnn.sNull2String(cbxPhanHe.uEditValue) == "02") //Lương biên chế, hợp đồng dài hạn
                    {
                        cnn.BeginTransaction();
                        string sDelete = "DELETE NS_BangLuongHopDongBienChe FROM  dbo.NS_BangLuongHopDongBienChe INNER JOIN dbo.NS_NHANSU ON dbo.NS_BangLuongHopDongBienChe.NhanSu = dbo.NS_NHANSU.NHANSU WHERE Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND NS_BangLuongHopDongBienChe.MaCOSO=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND NS_BangLuongHopDongBienChe.MaPHANHE=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "'";
                        string sCond = "";
                        if (!cnn.bComboIsNull(cboPhongBan))
                        {
                            sCond += " PHONGBAN=N'"+cnn.sNull2String(cboPhongBan.uEditValue)+"' AND ";
                        }
                        if (!cnn.bComboIsNull(cbxDonVi))
                        {
                            sCond += "DONVI=N'"+cnn.sNull2String(cbxDonVi.uEditValue)+"' AND ";
                        }
                        if (sCond != "")
                        {
                            sCond = sCond.Substring(0, sCond.Length - 4);
                            sDelete = sDelete + " AND " + sCond;
                        }
                        cnn.SQL_ExecuteNonQuery(sDelete);
                        try
                        {
                            foreach (DataRow r in DT.Rows)
                            {
                                Val.Clear();
                                Val.Add("Thang", txtThang.uValue);
                                Val.Add("Nam", txtNam.uValue);
                                Val.Add("NhanSu", cnn.sNull2Int(r["NHANSU"]));
                                Val.Add("TenChucVu", cnn.sNull2String(r["TenChucVu"]));
                                Val.Add("Ngach_CongChuc", r["Ngach_CongChuc"]);
                                Val.Add("MaCoSo", cnn.sNull2String(r["COSO"]));
                                Val.Add("MaPhongBan", cnn.sNull2String(r["PHONGBAN"]));
                                Val.Add("HeSoLuong", cnn.sNull2String(r["HeSoLuong"]));
                                Val.Add("TienLuongCoBan", cnn.sNull2String(r["TienLuongCoBan"]));
                                Val.Add("PhanTramVuotKhung", cnn.sNull2String(r["PhanTramVuotKhung"]));
                                Val.Add("HeSoVuotKhung", cnn.sNull2String(r["HeSoVuotKhung"]));
                                Val.Add("TienVuotKhung", cnn.sNull2String(r["TienVuotKhung"]));
                                Val.Add("HeSoChucVu", cnn.sNull2String(r["HeSoChucVu"]));
                                Val.Add("TienChucVu", cnn.sNull2String(r["TienChucVu"]));
                                Val.Add("PhanTramThamNienGD", cnn.sNull2String(r["PhanTramThamNienGD"]));
                                Val.Add("HeSoThamNienGD", cnn.sNull2String(r["HeSoThamNienGD"]));
                                Val.Add("TienThamNienGD", cnn.sNull2String(r["TienThamNienGD"]));
                                Val.Add("TongHeSo", cnn.sNull2String(r["TongHeSo"]));
                                Val.Add("TongTienHeSo", cnn.sNull2String(r["TongTienHeSo"]));
                                Val.Add("TienUuDai", cnn.sNull2String(r["TienUuDai"]));
                                Val.Add("HeSoPhuCapTrachNhiem", cnn.sNull2String(r["HeSoPhuCapTrachNhiem"]));
                                Val.Add("TienPhuCapTrachNhiem", cnn.sNull2String(r["TienPhuCapTrachNhiem"]));
                                Val.Add("TienThemGio", cnn.sNull2String(r["TienThemGio"]));
                                Val.Add("TienChiTieuNoiBo", cnn.sNull2String(r["TienChiTieuNoiBo"]));
                                Val.Add("HeSoPhuCapHCCB", cnn.sNull2String(r["HeSoPhuCapHCCB"]));
                                Val.Add("TienPhuCapHCCB", cnn.sNull2String(r["TienPhuCapHCCB"]));
                                Val.Add("HeSoPhuCapDQTV", cnn.sNull2String(r["HeSoPhuCapDQTV"]));
                                Val.Add("TienPhuCapDQTV", cnn.sNull2String(r["TienPhuCapDQTV"]));
                                Val.Add("TienBHXH_YT", cnn.sNull2String(r["TienBHXH_YT"]));
                                Val.Add("TienKinhPhiCongDoan", cnn.sNull2String(r["TienKinhPhiCongDoan"]));
                                Val.Add("TienBHTN", cnn.sNull2String(r["TienBHTN"]));
                                Val.Add("TienBHXH_YT_Truong", cnn.sNull2String(r["TienBHXH_YT_Truong"]));
                                Val.Add("TienKinhPhiCongDoan_Truong", cnn.sNull2String(r["TienKinhPhiCongDoan_Truong"]));
                                Val.Add("TienBHTN_Truong", cnn.sNull2String(r["TienBHTN_Truong"]));
                                Val.Add("ThucLanh", cnn.sNull2Number(r["ThucLanh"]));
                                Val.Add("ThueTNCN", r["ThueTNCN"]);
                                Val.Add("SoChungTu", r["SoChungTu"]);
                                Val.Add("ThueTNCN_Nop", cnn.sNull2Number(r["ThueTNCN_Nop"]));
                                Val.Add("ThueTNCN_ConLai", cnn.sNull2Number(r["ThueTNCN_ConLai"]));
                                Val.Add("GhiChu", r["GhiChu"]);
                                Val.Add("MaPhanHe", cnn.sNull2String(cbxPhanHe.uEditValue));
                                Val.Add("bLock", cnn.sNull2String(r["bLock"]));
                                Val.Add("TYLEHUONGLUONG", cnn.sNull2Number(r["TYLEHUONGLUONG"]));
                                string sNgayChungTu = string.Empty;
                                try
                                {
                                    sNgayChungTu = Convert.ToDateTime(r["NgayChungTu"]).ToString("MM/dd/yyyy");
                                }
                                catch
                                {
                                    sNgayChungTu = string.Empty;
                                }
                                Val.Add("NgayChungTu", sNgayChungTu);
                                Val.Add("CongNo", r["CongNo"]);
                                cnn.InsertNewRow(Val, "NS_BangLuongHopDongBienChe");
                               
                            }
                            cnn.EndTransaction();
                            this.Cursor = Cursors.Default;
                            XtraMessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            cnn.RollbackTransaction();
                            this.Cursor = Cursors.Default;
                            XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (cnn.sNull2String(cbxPhanHe.uEditValue) == "03")//Lương khoán
                    {
                        cnn.BeginTransaction();
                        try
                        {
                            foreach (DataRow r in DT.Rows)
                            {
                                Val.Clear();
                                Cond.Clear();
                                Cond.Add("Thang", txtThang.uValue);
                                Cond.Add("Nam", txtNam.uValue);
                                Cond.Add("NhanSu", cnn.sNull2Int(r["NhanSu"]));

                                Val.Add("LuongHDKhoan", r["LuongHDKhoan"]);
                                Val.Add("LuongKhoanCB", r["LuongKhoanCB"]);
                                Val.Add("PhiCongDoan", r["PhiCongDoan"]);
                                Val.Add("PhiCongDoan_Truong", r["PhiCongDoan_Truong"]);
                                Val.Add("KhoanTuNgay", r["KhoanTuNgay"]);
                                Val.Add("KhoanDenNgay", r["KhoanDenNgay"]);
                                Val.Add("ThucLanh", r["ThucLanh"]);
                                Val.Add("CongNo", r["CongNo"]);

                                if (cnn.SelectRows(Cond, "NS_BangLuongKhoan").Rows.Count > 0)
                                {
                                    cnn.UpdateRows(Val, Cond, "NS_BangLuongKhoan");
                                }
                                else
                                {
                                    Val.Add("Thang", txtThang.uValue);
                                    Val.Add("Nam", txtNam.uValue);
                                    Val.Add("NhanSu", cnn.sNull2Int(r["NhanSu"]));
                                    cnn.InsertNewRow(Val, "NS_BangLuongKhoan");
                                }
                            }
                            cnn.EndTransaction();
                            this.Cursor = Cursors.Default;
                            XtraMessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            cnn.RollbackTransaction();
                            this.Cursor = Cursors.Default;
                            XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")//Lương hợp đồng 68
                    {
                        cnn.BeginTransaction();
                        string sDelete = "DELETE NS_BangLuongHopDong68 FROM  dbo.NS_BangLuongHopDong68 INNER JOIN dbo.NS_NHANSU ON dbo.NS_BangLuongHopDong68.NhanSu = dbo.NS_NHANSU.NHANSU WHERE Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND NS_BangLuongHopDong68.MaCOSO=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND NS_BangLuongHopDong68.MaPHANHE=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "'";
                        string sCond = "";
                        if (!cnn.bComboIsNull(cboPhongBan))
                        {
                            sCond += " PHONGBAN=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "' AND ";
                        }
                        if (!cnn.bComboIsNull(cbxDonVi))
                        {
                            sCond += "DONVI=N'" + cnn.sNull2String(cbxDonVi.uEditValue) + "' AND ";
                        }
                        if (sCond != "")
                        {
                            sCond = sCond.Substring(0, sCond.Length - 4);
                            sDelete = sDelete + " AND " + sCond;
                        }
                        cnn.SQL_ExecuteNonQuery(sDelete);
                        try
                        {
                            foreach (DataRow r in DT.Rows)
                            {
                                Val.Clear();
                                Val.Add("Thang", txtThang.uValue);
                                Val.Add("Nam", txtNam.uValue);
                                Val.Add("NhanSu", cnn.sNull2Int(r["NHANSU"]));
                                Val.Add("MaChucVu", cnn.sNull2String(r["ChucVu"]));
                                Val.Add("Ngach_CongChuc", r["Ngach_CongChuc"]);
                                Val.Add("MaCoSo", cnn.sNull2String(r["COSO"]));
                                Val.Add("MaPhongBan", cnn.sNull2String(r["PHONGBAN"]));
                                Val.Add("HeSoLuong", cnn.sNull2String(r["HeSoLuong"]));
                                Val.Add("TienLuongCoBan", cnn.sNull2String(r["TienLuongCoBan"]));
                                Val.Add("PhanTramVuotKhung", cnn.sNull2String(r["PhanTramVuotKhung"]));
                                Val.Add("HeSoVuotKhung", cnn.sNull2String(r["HeSoVuotKhung"]));
                                Val.Add("TienVuotKhung", cnn.sNull2String(r["TienVuotKhung"]));
                                Val.Add("HeSoChucVu", cnn.sNull2String(r["HeSoChucVu"]));
                                Val.Add("TienChucVu", cnn.sNull2String(r["TienChucVu"]));
                                Val.Add("TongHeSo", cnn.sNull2String(r["TongHeSo"]));
                                Val.Add("TongTienHeSo", cnn.sNull2String(r["TongTienHeSo"]));
                                Val.Add("HeSoPhuCapTrachNhiem", cnn.sNull2String(r["HeSoPhuCapTrachNhiem"]));
                                Val.Add("TienTrachNhiem", cnn.sNull2String(r["TienPhuCapTrachNhiem"]));
                                Val.Add("TienThemGio", cnn.sNull2String(r["TienThemGio"]));
                                Val.Add("PhuCapHanhChinh", cnn.sNull2String(r["TienHanhChinh"]));
                                Val.Add("HeSoPhuCapHCCB", cnn.sNull2String(r["HeSoPhuCapHCCB"]));
                                Val.Add("TienPhuCapHCCB", cnn.sNull2String(r["TienPhuCapHCCB"]));
                                Val.Add("HeSoPhuCapDQTV", cnn.sNull2String(r["HeSoPhuCapDQTV"]));
                                Val.Add("TienPhuCapDQTV", cnn.sNull2String(r["TienPhuCapDQTV"]));
                                Val.Add("TienBHXH_YT", cnn.sNull2String(r["TienBHXH_YT"]));
                                Val.Add("TienKinhPhiCongDoan", cnn.sNull2String(r["TienKinhPhiCongDoan"]));
                                Val.Add("TienBHTN", cnn.sNull2String(r["TienBHTN"]));
                                Val.Add("TienBHXH_YT_Truong", cnn.sNull2String(r["TienBHXH_YT_Truong"]));
                                Val.Add("TienKinhPhiCongDoan_Truong", cnn.sNull2String(r["TienKinhPhiCongDoan_Truong"]));
                                Val.Add("TienBHTN_Truong", cnn.sNull2String(r["TienBHTN_Truong"]));
                                Val.Add("ThucLanh", cnn.sNull2Number(r["ThucLanh"]));
                                Val.Add("ThueTNCN", r["ThueTNCN"]);
                                Val.Add("SoChungTu", r["SoChungTu"]);
                                Val.Add("ThueTNCN_Nop", cnn.sNull2Number(r["ThueTNCN_Nop"]));
                                Val.Add("ThueTNCN_ConLai", cnn.sNull2Number(r["ThueTNCN_ConLai"]));
                                Val.Add("GhiChu", r["GhiChu"]);
                                Val.Add("MaPhanHe", cnn.sNull2String(cbxPhanHe.uEditValue));
                                Val.Add("bLock", cnn.sNull2String(r["bLock"]));
                                string sNgayChungTu = string.Empty;
                                try
                                {
                                    sNgayChungTu = Convert.ToDateTime(r["NgayChungTu"]).ToString("MM/dd/yyyy");
                                }
                                catch
                                {
                                    sNgayChungTu = string.Empty;
                                }
                                Val.Add("NgayChungTu", sNgayChungTu);
                                Val.Add("CongNo", r["CongNo"]);
                                cnn.InsertNewRow(Val, "NS_BangLuongHopDong68");

                            }
                            cnn.EndTransaction();
                            this.Cursor = Cursors.Default;
                            XtraMessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            cnn.RollbackTransaction();
                            this.Cursor = Cursors.Default;
                            XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            string sReportName = "";
            string sSQL = "";
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "01")                
            {
                popupMenu1.ShowPopup(MousePosition);
                return;
            }
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "02") 
            {
                popupMenu1.ShowPopup(MousePosition);
                return;
                
            }
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")
            {
                popupMenu1.ShowPopup(MousePosition);
                return;

            }
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "03")
            {
                if (!cnn.bComboIsNull(cbxCoSo))
                {
                    sReportName = "BangLuongKhoan.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGKHOAN");
                }
                else
                {
                    sReportName = "BangLuongKhoan_Truong.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGKHOAN");
                }
            }
            string sCond = " Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue) +" AND ";
            if (!cnn.bComboIsNull(cboPhongBan))
            {
                sCond += " NS_NhanSu.PHONGBAN=N'"+cnn.sNull2String(cboPhongBan.uEditValue)+"' AND ";
            }
            if (!cnn.bComboIsNull(cbxCoSo))
            {
                sCond += " NS_NhanSu.CoSo=N'"+cnn.sNull2String(cbxCoSo.uEditValue)+"' AND ";
            }
            if (!cnn.bComboIsNull(cbxPhanHe) && cnn.sNull2String(cbxPhanHe.uEditValue) != "03")
            {
                sCond += " NS_NhanSu.PhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            }
            sCond = sCond.Substring(0, sCond.Length - 4);
            sSQL = sSQL.Replace("1 = 0", sCond);
            DataTable DT = cnn.DT_DataTable(sSQL);
            decimal TongThucLanh = 0;
            foreach (DataRow r in DT.Rows)
            {
                TongThucLanh += cnn.sNull2Number(r["ThucLanh"]);
            }
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\" + sReportName, DT);
            frm.iNam = cnn.sNull2Int(txtNam.uValue);
            BSC_Class.Doctien doctien = new BSC_HRM.NET.BSC_Class.Doctien();
            frm.sSoTienBangChu = doctien.Convert_NumtoText(TongThucLanh.ToString());
            frm.iThang = cnn.sNull2Int(txtThang.uValue);
            frm.sCoSo = cbxCoSo.uText;
            frm.sPhanHe = cbxPhanHe.uText;
            if (!cnn.bComboIsNull(cboPhongBan))
                frm.sPhongBan = cboPhongBan.uText;
            frm.Show();

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            
        }
        public string ReplaceMucLuong(int Thang,int Nam)
        {
            string KetQua;
            DataTable dt_MucLuong = cnn.SelectRows("select LuongCoBan,SONGAYCHUAN from NS_SoLuong where Thang=" + Thang + " And Nam=" + Nam);

            if (dt_MucLuong.Rows.Count == 0)
                return "0 as MUCLUONG, 0 as SONGAYCHUAN,";
            else return cnn.sNull2String(dt_MucLuong.Rows[0]["LuongCoBan"]) + " as MUCLUONG,"+ cnn.sNull2String(dt_MucLuong.Rows[0]["SONGAYCHUAN"])+" as SONGAYCHUAN,";             
            return KetQua;
        }

        private void btnXetBangLuong_Click(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cbxCoSo))
            {
                XtraMessageBox.Show("Bạn chưa chọn cơ sở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.bComboIsNull(cbxPhanHe))
            {
                XtraMessageBox.Show("Bạn chưa chọn phân hệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (XtraMessageBox.Show("Bạn có muốn xét bảng lương hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;
                string sReplace20 = "1 = 1 AND ";
                int iThangTruoc = cnn.sNull2Int(txtThang.uValue) - 1;
                int iNamTruoc = cnn.sNull2Int(txtNam.uValue);
                if (cnn.sNull2Int(txtThang.uValue) == 1)
                {
                    iThangTruoc = 12;
                    iNamTruoc = cnn.sNull2Int(txtNam.uValue) - 1;
                }                
                if (!cnn.bComboIsNull(cbxCoSo))
                {
                    sReplace20 += " NS_NhanSu.CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
                }
                if (cnn.sNull2String(cbxPhanHe.uEditValue) != "03")
                {
                    sReplace20 += " dbo.NS_NHANSU.PHANHE=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
                }
                if (!cnn.bComboIsNull(cboPhongBan))
                {
                    sReplace20 += "dbo.NS_NHANSU.PHONGBAN=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "' AND ";
                }
                if (!cnn.bComboIsNull(cbxDonVi))
                {
                    sReplace20 += "dbo.NS_NHANSU.DONVI=N'" + cnn.sNull2String(cbxDonVi.uEditValue) + "' AND ";
                }
                sReplace20 = sReplace20.Substring(0, sReplace20.Length - 4);
                string sReplace10 = " Nam=" + txtNam.uValue + " AND Thang=" + txtThang.uValue;
                if (cnn.sNull2String(cbxPhanHe.uEditValue) == "01" || cnn.sNull2String(cbxPhanHe.uEditValue) == "02") // Co huu bien che - hop dong dai han
                {
                    dtg.sKEY = sKEYHOPDONG_BIENCHE;
                    string sSQL = cnn.GetSQLString(sKEYHOPDONG_BIENCHE);
                    sSQL = sSQL.Replace("444", iNamTruoc.ToString()).Replace("1 = 0", sReplace10).Replace("2 = 0", sReplace20).Replace("333", iThangTruoc.ToString());
                    DataTable DT = cnn.DT_DataTable(sSQL);

                    string sThue = "";
                    if (cnn.sNull2Int(txtThang.uValue) == 3)
                    {
                        sThue = "SELECT NhanSu,TienThueTNCNPhaiKhauTru TongTienThue FROM dbo.NS_ThueTNCN_Nam where Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue);
                    }
                    if (cnn.sNull2Int(txtThang.uValue) == 4 || cnn.sNull2Int(txtThang.uValue) == 7 || cnn.sNull2Int(txtThang.uValue) == 10 || cnn.sNull2Int(txtThang.uValue) == 1)
                    {
                        sThue = "SELECT NhanSu,TongTienThue FROM dbo.NS_ThueTNCN_Quy Where Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue);
                    }
                    if (sThue != "")
                    {
                        DataTable DTThue = cnn.DT_DataTable(sThue);
                        if (DTThue != null && DTThue.Rows.Count > 0)
                        {
                            foreach (DataRow r in DT.Rows)
                            {
                                foreach (DataRow rr in DTThue.Rows)
                                {
                                    if (cnn.sNull2Int(r["NhanSu"]) == cnn.sNull2Int(rr["NhanSu"]))
                                    {
                                        r["ThueTNCN"] = cnn.sNull2Number(r["ThueTNCN"]) + cnn.sNull2Number(rr["TongTienThue"]);
                                        //decimal TongMucLuong = cnn.sNull2Number(cnn.sNull2String(r["TongTienHeSo"])) + cnn.sNull2Number(cnn.sNull2String(r["TienUuDai"])) + cnn.sNull2Number(cnn.sNull2String(r["TienPhuCapTrachNhiem"])) + cnn.sNull2Number(cnn.sNull2String(r["TienThemGio"])) + cnn.sNull2Number(cnn.sNull2String(r["TienChiTieuNoiBo"])) + cnn.sNull2Number(cnn.sNull2String(r["TienPhuCapHCCB"]));
                                        //decimal CongCacKhoanTru = cnn.sNull2Number(cnn.sNull2String(r["TienBHXH_YT"])) + cnn.sNull2Number(cnn.sNull2String(r["TienKinhPhiCongDoan"]));
                                        decimal dThucLanh = cnn.sNull2Number(r["ThucLanh"]);
                                        if (cnn.sNull2Number(r["ThueTNCN"]) > Math.Round((dThucLanh / 2), 0))
                                        {
                                            r["ThueTNCN_Nop"] = Math.Round((dThucLanh / 2));
                                        }
                                        else
                                        {
                                            r["ThueTNCN_Nop"] = r["ThueTNCN"];
                                        }
                                        r["ThueTNCN_ConLai"] = cnn.sNull2Number(r["ThueTNCN"]) - cnn.sNull2Number(r["ThueTNCN_Nop"]);
                                        r["ThucLanh"] = dThucLanh - cnn.sNull2Number(r["ThueTNCN_Nop"]);
                                    }
                                }
                            }
                        }
                    }
                    try
                    {
                        foreach (DataRow r in DT.Rows)
                        {
                            if (cnn.sNull2Number(r["ThueTNCN_Nop"]) == 0 && cnn.sNull2Number(r["ThueTNCN"]) > 0)
                            {
                                decimal dThucLanh = cnn.sNull2Number(r["ThucLanh"]);
                                decimal ddd = Math.Round(dThucLanh / 2, 0);
                                if (cnn.sNull2Number(r["ThueTNCN"]) > ddd)
                                {
                                    r["ThueTNCN_Nop"] = ddd;
                                    r["ThueTNCN_ConLai"] = cnn.sNull2Number(r["ThueTNCN"]) - cnn.sNull2Number(r["ThueTNCN_Nop"]);
                                    r["ThucLanh"] = cnn.sNull2Number(r["ThucLanh"]) - cnn.sNull2Number(r["ThueTNCN_Nop"]);
                                }
                                else
                                {
                                    r["ThueTNCN_Nop"] = r["ThueTNCN"];
                                    r["ThueTNCN_ConLai"] = 0;
                                    r["ThucLanh"] = cnn.sNull2Number(r["ThucLanh"]) - cnn.sNull2Number(r["ThueTNCN_Nop"]);
                                }
                            }
                        }
                    }
                    catch
                    {
                    }
                    dtg.sFieldSummary = "TongTienHeSo,TienUuDai,TienPhuCapTrachNhiem,TienThemGio,TienChiTieuNoiBo,TienPhuCapHCCB,TienBHXH_YT,TienKinhPhiCongDoan,TienBHTN,TienBHXH_YT_Truong,TienKinhPhiCongDoan_Truong,TienBHTN_Truong,ThucLanh,ThueTNCN,CongNo,ThueTNCN_Nop,ThueTNCN_ConLai";
                    dtg.uDataSource = DT;                                 
                    EditColumn();
                }
                else if (cnn.sNull2String(cbxPhanHe.uEditValue) == "03")// hop dong khoan
                {
                    string sReplace = " KhoanTuNgay<='" + cnn.sNull2Int(txtThang.uValue) + "/01/" + cnn.sNull2Int(txtNam.uValue) + "' AND KhoanDenNgay>='" + cnn.sNull2Int(txtThang.uValue) + "/01/" + cnn.sNull2Int(txtNam.uValue) + "' ";
                    dtg.sKEY = sKEYKHOAN;
                    string sSQL = cnn.GetSQLString(sKEYKHOAN);
                    sSQL = sSQL.Replace("1 = 0", sReplace + " AND " + sReplace20);
                    DataTable DT = cnn.DT_DataTable(sSQL);
                    dtg.sFieldSummary = "ThucLanh";
                    dtg.uDataSource = DT;                    
                    EditColumn();
                }
                else if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05") // hop dong 68
                {
                    dtg.sKEY = sKEYHOPDONG68;
                    string sSQL = cnn.GetSQLString(sKEYHOPDONG68);
                    sSQL = sSQL.Replace("2013", iNamTruoc.ToString()).Replace("1 = 0", sReplace10).Replace("2 = 0", sReplace20).Replace("333", iThangTruoc.ToString());
                    DataTable DT = cnn.DT_DataTable(sSQL);

                    string sThue = "";
                    if (cnn.sNull2Int(txtThang.uValue) == 3)
                    {
                        sThue = "SELECT NhanSu,TienThueTNCNPhaiKhauTru TongTienThue FROM dbo.NS_ThueTNCN_Nam where Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue);
                    }
                    if (cnn.sNull2Int(txtThang.uValue) == 5 || cnn.sNull2Int(txtThang.uValue) == 8 || cnn.sNull2Int(txtThang.uValue) == 11 || cnn.sNull2Int(txtThang.uValue) == 2)
                    {
                        sThue = "SELECT NhanSu,TongTienThue FROM dbo.NS_ThueTNCN_Quy Where Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue);
                    }
                    if (sThue != "")
                    {
                        DataTable DTThue = cnn.DT_DataTable(sThue);
                        if (DTThue != null && DTThue.Rows.Count > 0)
                        {
                            foreach (DataRow r in DT.Rows)
                            {
                                foreach (DataRow rr in DTThue.Rows)
                                {
                                    if (cnn.sNull2Int(r["NhanSu"]) == cnn.sNull2Int(rr["NhanSu"]))
                                    {
                                        r["ThueTNCN"] = cnn.sNull2Number(r["ThueTNCN"]) + cnn.sNull2Number(rr["TongTienThue"]);
                                        //decimal TongMucLuong = cnn.sNull2Number(cnn.sNull2String(r["TongTienHeSo"])) + cnn.sNull2Number(cnn.sNull2String(r["TienTrachNhiem"])) + cnn.sNull2Number(cnn.sNull2String(r["TienThemGio"])) + cnn.sNull2Number(cnn.sNull2String(r["TienHanhChinh"])) + cnn.sNull2Number(cnn.sNull2String(r["TienPhuCapHCCB"]));
                                        //decimal CongCacKhoanTru = cnn.sNull2Number(cnn.sNull2String(r["TienBHXH_YT"])) + cnn.sNull2Number(cnn.sNull2String(r["TienKinhPhiCongDoan"]));
                                        decimal dThucLanh = cnn.sNull2Number(r["ThucLanh"]);
                                        if (cnn.sNull2Number(r["ThueTNCN"]) > Math.Round((dThucLanh / 2), 0))
                                        {
                                            r["ThueTNCN_Nop"] = Math.Round((dThucLanh / 2));
                                        }
                                        else
                                        {
                                            r["ThueTNCN_Nop"] = r["ThueTNCN"];
                                        }
                                        r["ThueTNCN_ConLai"] = cnn.sNull2Number(r["ThueTNCN"]) - cnn.sNull2Number(r["ThueTNCN_Nop"]);
                                        r["ThucLanh"] = dThucLanh - cnn.sNull2Number(r["ThueTNCN_Nop"]);
                                    }
                                }
                            }
                        }
                    }
                    try
                    {
                        foreach (DataRow r in DT.Rows)
                        {
                            if (cnn.sNull2Number(r["ThueTNCN_Nop"]) == 0 && cnn.sNull2Number(r["ThueTNCN"]) > 0)
                            {
                                decimal dThucLanh = cnn.sNull2Number(r["ThucLanh"]);
                                decimal ddd = Math.Round(dThucLanh / 2, 0);
                                if (cnn.sNull2Number(r["ThueTNCN"]) > ddd)
                                {
                                    r["ThueTNCN_Nop"] = ddd;
                                    r["ThueTNCN_ConLai"] = cnn.sNull2Number(r["ThueTNCN"]) - cnn.sNull2Number(r["ThueTNCN_Nop"]);
                                    r["ThucLanh"] = cnn.sNull2Number(r["ThucLanh"]) - cnn.sNull2Number(r["ThueTNCN_Nop"]);
                                }
                                else
                                {
                                    r["ThueTNCN_Nop"] = r["ThueTNCN"];
                                    r["ThueTNCN_ConLai"] = 0;
                                    r["ThucLanh"] = cnn.sNull2Number(r["ThucLanh"]) - cnn.sNull2Number(r["ThueTNCN_Nop"]);
                                }
                            }
                        }
                    }
                    catch
                    {
                    }
                    dtg.sFieldSummary = "TongTienHeSo,TienPhuCapTrachNhiem,TienThemGio_DocHai,TienHanhChinh,TienPhuCapHCCB,TienBHXH_YT,TienKinhPhiCongDoan,TienBHTN,TienBHXH_YT_Truong,TienKinhPhiCongDoan_Truong,TienBHTN_Truong,ThucLanh,ThueTNCN,CongNo,ThueTNCN_Nop,ThueTNCN_ConLai";
                    dtg.uDataSource = DT;
                    EditColumn();
                }
                else
                    dtg.uDataSource = null;
                this.Cursor = Cursors.Default;
            }
        }

        private void cboPhongBan_uEditValueChanged(object sender, EventArgs e)
        {
            string sSQL = "Select MaDonVi,TenDonVi From DM_DonVi where MaPhongBan=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "'";
            DataTable DT = cnn.DT_DataTable(sSQL);
            cbxDonVi.uDataSource = DT;
            btnXetBangLuong.Enabled = false;
            btnCapNhat.Enabled = false;
            btnMoKhoa.Enabled = false;
            btnKhoa.Enabled = false;
        }

        private void btnInBangLuongBienChe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string sReportName = "";
            string sSQL = "";
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "01")
            {
                if (!cnn.bComboIsNull(cbxCoSo))
                {
                    sReportName = "BangLuongBienChe_Mau2_Phan1.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGBIENCHE");
                }
                else
                {
                    sReportName = "BangLuongBienChe_Truong_Mau2_Phan1.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGBIENCHE");
                }
            }
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "02")
            {
                if (!cnn.bComboIsNull(cbxCoSo))
                {
                    sReportName = "BangLuongHopDong_Mau2_Phan1.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGBIENCHE");
                }
                else
                {
                    sReportName = "BangLuongHopDong_Truong_Mau2_Phan1.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGBIENCHE");
                }
            }
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")
            {
                if (!cnn.bComboIsNull(cbxCoSo))
                {
                    sReportName = "BangLuongHopDong68_Mau2_Phan1.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGHOPDONG68");
                }
                else
                {
                    sReportName = "BangLuongHopDong68_Truong_Mau2_Phan1.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGHOPDONG68");
                }
            }
            
            string sCond = " Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND ";
            if (!cnn.bComboIsNull(cboPhongBan))
            {
                sCond += " NS_NhanSu.PHONGBAN=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxCoSo))
            {
                if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")
                {
                    sCond += " NS_BangLuongHopDong68.MaCoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
                }
                else
                    sCond += " NS_BangLuongHopDongBienChe.MaCoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxPhanHe) && cnn.sNull2String(cbxPhanHe.uEditValue) != "03")
            {
                if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")
                    sCond += " NS_BangLuongHopDong68.MaPhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
                else
                    sCond += " NS_BangLuongHopDongBienChe.MaPhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            }
            sCond = sCond.Substring(0, sCond.Length - 4);
            sSQL = sSQL.Replace("1 = 0", sCond);
            DataTable DT = cnn.DT_DataTable(sSQL);
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\" + sReportName, DT);
            frm.iNam = cnn.sNull2Int(txtNam.uValue);
            frm.iThang = cnn.sNull2Int(txtThang.uValue);
            frm.sCoSo = cbxCoSo.uText;
            frm.sPhanHe = cbxPhanHe.uText;
            if (!cnn.bComboIsNull(cboPhongBan))
                frm.sPhongBan = cboPhongBan.uText;
            frm.Show();
        }

        private void btnBangLuongThuNhapTangThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string sReportName = "";
            string sSQL = "";
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "01")
            {
                if (!cnn.bComboIsNull(cbxCoSo))
                {
                    sReportName = "BangLuongBienChe_Mau2_Phan2.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGBIENCHE");
                }
                else
                {
                    sReportName = "BangLuongBienChe_Truong_Mau2_Phan2.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGBIENCHE");
                }
            }
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "02")
            {
                if (!cnn.bComboIsNull(cbxCoSo))
                {
                    sReportName = "BangLuongHopDong_Mau2_Phan2.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGBIENCHE");
                }
                else
                {
                    sReportName = "BangLuongHopDong_Truong_Mau2_Phan2.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGBIENCHE");
                }
            }
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")
            {
                if (!cnn.bComboIsNull(cbxCoSo))
                {
                    sReportName = "BangLuongHopDong68_Mau2_Phan2.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGHOPDONG68");
                }
                else
                {
                    sReportName = "BangLuongHopDong68_Truong_Mau2_Phan2.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGHOPDONG68");
                }
            }

            string sCond = " Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND ";
            if (!cnn.bComboIsNull(cboPhongBan))
            {
                sCond += " NS_NhanSu.PHONGBAN=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxCoSo))
            {
                if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")
                {
                    sCond += " NS_BangLuongHopDong68.MaCoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
                }
                else
                    sCond += " NS_BangLuongHopDongBienChe.MaCoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxPhanHe) && cnn.sNull2String(cbxPhanHe.uEditValue) != "03")
            {
                if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")
                    sCond += " NS_BangLuongHopDong68.MaPhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
                else
                    sCond += " NS_BangLuongHopDongBienChe.MaPhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            }
            sCond = sCond.Substring(0, sCond.Length - 4);
            sSQL = sSQL.Replace("1 = 0", sCond);
            DataTable DT = cnn.DT_DataTable(sSQL);
            decimal TongThucLanh = 0;
            foreach (DataRow r in DT.Rows)
            {
                TongThucLanh += cnn.sNull2Number(r["ThucLanh"]);
            }
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\" + sReportName, DT);
            BSC_Class.Doctien doctien = new BSC_HRM.NET.BSC_Class.Doctien();
            frm.sSoTienBangChu = doctien.Convert_NumtoText(TongThucLanh.ToString());
            frm.iNam = cnn.sNull2Int(txtNam.uValue);
            frm.iThang = cnn.sNull2Int(txtThang.uValue);
            frm.sCoSo = cbxCoSo.uText;
            frm.sPhanHe = cbxPhanHe.uText;
            if (!cnn.bComboIsNull(cboPhongBan))
                frm.sPhongBan = cboPhongBan.uText;
            frm.Show();
        }

        private void dtg_uCellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "CongNo")
            {
                if (cnn.sNull2String(cbxPhanHe.uEditValue) == "01" || cnn.sNull2String(cbxPhanHe.uEditValue) == "02") //Lương biên chế, hợp đồng dài hạn
                    dtg.CurRow["ThucLanh"] = Math.Round((cnn.sNull2Number(dtg.CurRow["TongTienHeSo"]) + cnn.sNull2Number(dtg.CurRow["TienUuDai"]) + cnn.sNull2Number(dtg.CurRow["TienPhuCapTrachNhiem"]) + cnn.sNull2Number(dtg.CurRow["TienThemGio"]) + cnn.sNull2Number(dtg.CurRow["TienChiTieuNoiBo"]) + cnn.sNull2Number(dtg.CurRow["TienPhuCapHCCB"]) + cnn.sNull2Number(dtg.CurRow["TienPhuCapDQTV"])) - (cnn.sNull2Number(dtg.CurRow["TienBHXH_YT"]) + cnn.sNull2Number(dtg.CurRow["TienKinhPhiCongDoan"]) + cnn.sNull2Number(dtg.CurRow["TienBHTN"]) + cnn.sNull2Number(dtg.CurRow["CongNo"]) + cnn.sNull2Number(dtg.CurRow["ThueTNCN_Nop"])), 0);
                else if (cnn.sNull2String(cbxPhanHe.uEditValue) == "03")//Lương khoán
                    dtg.CurRow["ThucLanh"] = Math.Round(cnn.sNull2Number(dtg.CurRow["LuongHDKhoan"]) - cnn.sNull2Number(dtg.CurRow["CongNo"]), 0);
                else if(cnn.sNull2String(cbxPhanHe.uEditValue) == "05")//Lương hd 68
                    dtg.CurRow["ThucLanh"] = Math.Round((cnn.sNull2Number(dtg.CurRow["TongTienHeSo"]) + cnn.sNull2Number(dtg.CurRow["TienPhuCapTrachNhiem"]) + cnn.sNull2Number(dtg.CurRow["TienThemGio"]) + cnn.sNull2Number(dtg.CurRow["TienHanhChinh"]) + cnn.sNull2Number(dtg.CurRow["TienPhuCapHCCB"]) + cnn.sNull2Number(dtg.CurRow["TienPhuCapDQTV"])) - (cnn.sNull2Number(dtg.CurRow["TienBHXH_YT"]) + cnn.sNull2Number(dtg.CurRow["TienKinhPhiCongDoan"]) + cnn.sNull2Number(dtg.CurRow["TienBHTN"]) + cnn.sNull2Number(dtg.CurRow["CongNo"]) + cnn.sNull2Number(dtg.CurRow["ThueTNCN_Nop"])), 0);
            }
            if (e.Column.FieldName == "ThueTNCN_Nop")
            {
                if (cnn.sNull2String(cbxPhanHe.uEditValue) == "01" || cnn.sNull2String(cbxPhanHe.uEditValue) == "02") //Lương biên chế, hợp đồng dài hạn
                {
                    dtg.CurRow["ThueTNCN_ConLai"] = cnn.sNull2Number(dtg.CurRow["ThueTNCN"]) - cnn.sNull2Number(dtg.CurRow["ThueTNCN_Nop"]);
                    dtg.CurRow["ThucLanh"] = Math.Round((cnn.sNull2Number(dtg.CurRow["TongTienHeSo"]) + cnn.sNull2Number(dtg.CurRow["TienUuDai"]) + cnn.sNull2Number(dtg.CurRow["TienPhuCapTrachNhiem"]) + cnn.sNull2Number(dtg.CurRow["TienThemGio"]) + cnn.sNull2Number(dtg.CurRow["TienChiTieuNoiBo"]) + cnn.sNull2Number(dtg.CurRow["TienPhuCapHCCB"]) + cnn.sNull2Number(dtg.CurRow["TienPhuCapDQTV"])) - (cnn.sNull2Number(dtg.CurRow["TienBHXH_YT"]) + cnn.sNull2Number(dtg.CurRow["TienKinhPhiCongDoan"]) + cnn.sNull2Number(dtg.CurRow["TienBHTN"]) + cnn.sNull2Number(dtg.CurRow["CongNo"]) + cnn.sNull2Number(dtg.CurRow["ThueTNCN_Nop"])), 0);
                }
                else if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")//Lương hd 68
                {
                    dtg.CurRow["ThueTNCN_ConLai"] = cnn.sNull2Number(dtg.CurRow["ThueTNCN"]) - cnn.sNull2Number(dtg.CurRow["ThueTNCN_Nop"]);
                    dtg.CurRow["ThucLanh"] = Math.Round((cnn.sNull2Number(dtg.CurRow["TongTienHeSo"]) + cnn.sNull2Number(dtg.CurRow["TienPhuCapTrachNhiem"]) + cnn.sNull2Number(dtg.CurRow["TienThemGio"]) + cnn.sNull2Number(dtg.CurRow["TienHanhChinh"]) + cnn.sNull2Number(dtg.CurRow["TienPhuCapHCCB"]) + cnn.sNull2Number(dtg.CurRow["TienPhuCapDQTV"])) - (cnn.sNull2Number(dtg.CurRow["TienBHXH_YT"]) + cnn.sNull2Number(dtg.CurRow["TienKinhPhiCongDoan"]) + cnn.sNull2Number(dtg.CurRow["TienBHTN"]) + cnn.sNull2Number(dtg.CurRow["CongNo"]) + cnn.sNull2Number(dtg.CurRow["ThueTNCN_Nop"])), 0);
                }
            }
            if (e.Column.FieldName == "TienThemGio")
            {
                if (cnn.sNull2String(cbxPhanHe.uEditValue) == "01" || cnn.sNull2String(cbxPhanHe.uEditValue) == "02") //Lương biên chế, hợp đồng dài hạn
                {
                    dtg.CurRow["ThucLanh"] = Math.Round((cnn.sNull2Number(dtg.CurRow["TongTienHeSo"]) + cnn.sNull2Number(dtg.CurRow["TienPhuCapTrachNhiem"]) + cnn.sNull2Number(dtg.CurRow["TienThemGio"]) + cnn.sNull2Number(dtg.CurRow["TienChiTieuNoiBo"]) + cnn.sNull2Number(dtg.CurRow["TienPhuCapHCCB"]) + cnn.sNull2Number(dtg.CurRow["TienPhuCapDQTV"])) - (cnn.sNull2Number(dtg.CurRow["TienBHXH_YT"]) + cnn.sNull2Number(dtg.CurRow["TienKinhPhiCongDoan"]) + cnn.sNull2Number(dtg.CurRow["TienBHTN"]) + cnn.sNull2Number(dtg.CurRow["CongNo"]) + cnn.sNull2Number(dtg.CurRow["ThueTNCN_Nop"])), 0);
                }
                else if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")//Lương hd 68
                {
                    dtg.CurRow["ThucLanh"] = Math.Round((cnn.sNull2Number(dtg.CurRow["TongTienHeSo"]) + cnn.sNull2Number(dtg.CurRow["TienPhuCapTrachNhiem"]) + cnn.sNull2Number(dtg.CurRow["TienThemGio"]) + cnn.sNull2Number(dtg.CurRow["TienHanhChinh"]) + cnn.sNull2Number(dtg.CurRow["TienPhuCapHCCB"]) + cnn.sNull2Number(dtg.CurRow["TienPhuCapDQTV"])) - (cnn.sNull2Number(dtg.CurRow["TienBHXH_YT"]) + cnn.sNull2Number(dtg.CurRow["TienKinhPhiCongDoan"]) + cnn.sNull2Number(dtg.CurRow["TienBHTN"]) + cnn.sNull2Number(dtg.CurRow["CongNo"]) + cnn.sNull2Number(dtg.CurRow["ThueTNCN_Nop"])), 0);
                }
            }
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

        private void barInKhoBac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string sReportName = "";
            string sSQL = "";
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "01")
            {
                if (!cnn.bComboIsNull(cbxCoSo))
                {
                    sReportName = "BangLuongBienChe.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGBIENCHE");
                }
                else
                {
                    sReportName = "BangLuongBienChe_Truong.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGBIENCHE");
                }
            }
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "02")
            {
                if (!cnn.bComboIsNull(cbxCoSo))
                {
                    sReportName = "BangLuongHopDong.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGBIENCHE");
                }
                else
                {
                    sReportName = "BangLuongHopDong_Truong.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGBIENCHE");
                }
            }
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")
            {
                if (!cnn.bComboIsNull(cbxCoSo))
                {
                    sReportName = "BangLuongHopDong68.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGHOPDONG68");
                }
                else
                {
                    sReportName = "BangLuongHopDong68_Truong.repx";
                    sSQL = cnn.GetSQLString("INBANGLUONGHOPDONG68");
                }
            }

            string sCond = " Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND ";
            if (!cnn.bComboIsNull(cboPhongBan))
            {
                sCond += " NS_NhanSu.PHONGBAN=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxCoSo))
            {
                if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")
                {
                    sCond += " NS_BangLuongHopDong68.MaCoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
                }
                else
                    sCond += " NS_BangLuongHopDongBienChe.MaCoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxPhanHe) && cnn.sNull2String(cbxPhanHe.uEditValue) != "03")
            {
                if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")
                    sCond += " NS_BangLuongHopDong68.MaPhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
                else
                    sCond += " NS_BangLuongHopDongBienChe.MaPhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            }
            sCond = sCond.Substring(0, sCond.Length - 4);
            sSQL = sSQL.Replace("1 = 0", sCond);
            DataTable DT = cnn.DT_DataTable(sSQL);
            decimal TongThucLanh = 0;
            foreach (DataRow r in DT.Rows)
            {
                TongThucLanh += cnn.sNull2Number(r["ThucLanh"]);
            }
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\" + sReportName, DT);
            BSC_Class.Doctien doctien = new BSC_HRM.NET.BSC_Class.Doctien();
            frm.sSoTienBangChu = doctien.Convert_NumtoText(TongThucLanh.ToString());
            frm.iNam = cnn.sNull2Int(txtNam.uValue);
            frm.iThang = cnn.sNull2Int(txtThang.uValue);
            frm.sCoSo = cbxCoSo.uText;
            frm.sPhanHe = cbxPhanHe.uText;
            if (!cnn.bComboIsNull(cboPhongBan))
                frm.sPhongBan = cboPhongBan.uText;
            frm.Show();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cbxCoSo))
            {
                XtraMessageBox.Show("Bạn chưa chọn cơ sở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.bComboIsNull(cbxPhanHe))
            {
                XtraMessageBox.Show("Bạn chưa chọn phân hệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc muốn khóa bảng lương hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;
                Hashtable Val = new Hashtable();
                Hashtable Cond = new Hashtable();
                if (cnn.sNull2String(cbxPhanHe.uEditValue) == "01" || cnn.sNull2String(cbxPhanHe.uEditValue) == "02") //Lương biên chế, hợp đồng dài hạn
                {
                    string sSelect = "SELECT * FROM NS_BangLuongHopDongBienChe INNER JOIN dbo.NS_NHANSU ON dbo.NS_BangLuongHopDongBienChe.NhanSu = dbo.NS_NHANSU.NHANSU WHERE Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND COSO=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND PHANHE=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "'";
                    string sCond = "";
                    if (!cnn.bComboIsNull(cboPhongBan))
                    {
                        sCond += " PHONGBAN=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "' AND ";
                    }
                    if (!cnn.bComboIsNull(cbxDonVi))
                    {
                        sCond += "DONVI=N'" + cnn.sNull2String(cbxDonVi.uEditValue) + "' AND ";
                    }
                    if (sCond != "")
                    {
                        sCond = sCond.Substring(0, sCond.Length - 4);
                        sSelect = sSelect + " AND " + sCond;
                    }
                    DataTable dt = cnn.DT_DataTable(sSelect);
                    cnn.BeginTransaction();
                    try
                    {
                        foreach (DataRow r in dt.Rows)
                        {
                            Val.Clear();
                            Cond.Clear();
                            Cond.Add("Thang", txtThang.uValue);
                            Cond.Add("Nam", txtNam.uValue);
                            Cond.Add("NhanSu", cnn.sNull2Int(r["NhanSu"]));

                            Val.Add("bLock", 1);
                            if (cnn.SelectRows(Cond, "NS_BangLuongHopDongBienChe").Rows.Count > 0)
                                cnn.UpdateRows(Val, Cond, "NS_BangLuongHopDongBienChe");
                        }
                        cnn.EndTransaction();
                        this.Cursor = Cursors.Default;
                        XtraMessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        cnn.RollbackTransaction();
                        this.Cursor = Cursors.Default;
                        XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (cnn.sNull2String(cbxPhanHe.uEditValue) == "03")//Lương khoán
                {
                    string sSelect = "SELECT * FROM NS_BangLuongKhoan INNER JOIN dbo.NS_NHANSU ON NS_BangLuongKhoan.NhanSu = dbo.NS_NHANSU.NHANSU WHERE Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND COSO=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND PHANHE=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "'";
                    string sCond = "";
                    if (!cnn.bComboIsNull(cboPhongBan))
                    {
                        sCond += " PHONGBAN=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "' AND ";
                    }
                    if (!cnn.bComboIsNull(cbxDonVi))
                    {
                        sCond += "DONVI=N'" + cnn.sNull2String(cbxDonVi.uEditValue) + "' AND ";
                    }
                    if (sCond != "")
                    {
                        sCond = sCond.Substring(0, sCond.Length - 4);
                        sSelect = sSelect + " AND " + sCond;
                    }
                    DataTable dt = cnn.DT_DataTable(sSelect);
                    cnn.BeginTransaction();
                    try
                    {
                        foreach (DataRow r in dt.Rows)
                        {
                            Val.Clear();
                            Cond.Clear();
                            Cond.Add("Thang", txtThang.uValue);
                            Cond.Add("Nam", txtNam.uValue);
                            Cond.Add("NhanSu", cnn.sNull2Int(r["NhanSu"]));

                            Val.Add("bLock", 1);

                            if (cnn.SelectRows(Cond, "NS_BangLuongKhoan").Rows.Count > 0)
                                cnn.UpdateRows(Val, Cond, "NS_BangLuongKhoan");
                        }
                        cnn.EndTransaction();
                        this.Cursor = Cursors.Default;
                        XtraMessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        cnn.RollbackTransaction();
                        this.Cursor = Cursors.Default;
                        XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")//Lương hợp đồng 68
                {
                    string sSelect = "SELECT * FROM NS_BangLuongHopDong68 INNER JOIN dbo.NS_NHANSU ON NS_BangLuongHopDong68.NhanSu = dbo.NS_NHANSU.NHANSU WHERE Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND COSO=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND PHANHE=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "'";
                    string sCond = "";
                    if (!cnn.bComboIsNull(cboPhongBan))
                    {
                        sCond += " PHONGBAN=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "' AND ";
                    }
                    if (!cnn.bComboIsNull(cbxDonVi))
                    {
                        sCond += "DONVI=N'" + cnn.sNull2String(cbxDonVi.uEditValue) + "' AND ";
                    }
                    if (sCond != "")
                    {
                        sCond = sCond.Substring(0, sCond.Length - 4);
                        sSelect = sSelect + " AND " + sCond;
                    }
                    DataTable dt = cnn.DT_DataTable(sSelect);
                    cnn.BeginTransaction();
                    try
                    {
                        foreach (DataRow r in dt.Rows)
                        {
                            Val.Clear();
                            Cond.Clear();
                            Cond.Add("Thang", txtThang.uValue);
                            Cond.Add("Nam", txtNam.uValue);
                            Cond.Add("NhanSu", cnn.sNull2Int(r["NhanSu"]));

                            Val.Add("bLock", 1);

                            if (cnn.SelectRows(Cond, "NS_BangLuongHopDong68").Rows.Count > 0)
                                cnn.UpdateRows(Val, Cond, "NS_BangLuongHopDong68");
                        }
                        cnn.EndTransaction();
                        this.Cursor = Cursors.Default;
                        XtraMessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        cnn.RollbackTransaction();
                        this.Cursor = Cursors.Default;
                        XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            btnLocDanhSach_Click(sender, e);
        }

        private void btnMoKhoa_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.USER_NAME.ToLower() == "supervisor" || Properties.Settings.Default.USER_NAME.ToLower() == "administrator")
            {
                if (cnn.bComboIsNull(cbxCoSo))
                {
                    XtraMessageBox.Show("Bạn chưa chọn cơ sở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cnn.bComboIsNull(cbxPhanHe))
                {
                    XtraMessageBox.Show("Bạn chưa chọn phân hệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (XtraMessageBox.Show("Bạn có chắc muốn mở khóa bảng lương hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    Hashtable Val = new Hashtable();
                    Hashtable Cond = new Hashtable();
                    if (cnn.sNull2String(cbxPhanHe.uEditValue) == "01" || cnn.sNull2String(cbxPhanHe.uEditValue) == "02") //Lương biên chế, hợp đồng dài hạn
                    {
                        string sSelect = "SELECT * FROM NS_BangLuongHopDongBienChe INNER JOIN dbo.NS_NHANSU ON dbo.NS_BangLuongHopDongBienChe.NhanSu = dbo.NS_NHANSU.NHANSU WHERE Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND COSO=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND PHANHE=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "'";
                        string sCond = "";
                        if (!cnn.bComboIsNull(cboPhongBan))
                        {
                            sCond += " PHONGBAN=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "' AND ";
                        }
                        if (!cnn.bComboIsNull(cbxDonVi))
                        {
                            sCond += "DONVI=N'" + cnn.sNull2String(cbxDonVi.uEditValue) + "' AND ";
                        }
                        if (sCond != "")
                        {
                            sCond = sCond.Substring(0, sCond.Length - 4);
                            sSelect = sSelect + " AND " + sCond;
                        }
                        DataTable dt = cnn.DT_DataTable(sSelect);
                        cnn.BeginTransaction();
                        try
                        {
                            foreach (DataRow r in dt.Rows)
                            {
                                Val.Clear();
                                Cond.Clear();
                                Cond.Add("Thang", txtThang.uValue);
                                Cond.Add("Nam", txtNam.uValue);
                                Cond.Add("NhanSu", cnn.sNull2Int(r["NhanSu"]));

                                Val.Add("bLock", 0);
                                if (cnn.SelectRows(Cond, "NS_BangLuongHopDongBienChe").Rows.Count > 0)
                                    cnn.UpdateRows(Val, Cond, "NS_BangLuongHopDongBienChe");
                            }
                            cnn.EndTransaction();
                            this.Cursor = Cursors.Default;
                            XtraMessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            cnn.RollbackTransaction();
                            this.Cursor = Cursors.Default;
                            XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05") //Lương hợp đồng 68
                    {
                        string sSelect = "SELECT * FROM NS_BangLuongHopDong68 INNER JOIN dbo.NS_NHANSU ON dbo.NS_BangLuongHopDong68.NhanSu = dbo.NS_NHANSU.NHANSU WHERE Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND COSO=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND PHANHE=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "'";
                        string sCond = "";
                        if (!cnn.bComboIsNull(cboPhongBan))
                        {
                            sCond += " PHONGBAN=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "' AND ";
                        }
                        if (!cnn.bComboIsNull(cbxDonVi))
                        {
                            sCond += "DONVI=N'" + cnn.sNull2String(cbxDonVi.uEditValue) + "' AND ";
                        }
                        if (sCond != "")
                        {
                            sCond = sCond.Substring(0, sCond.Length - 4);
                            sSelect = sSelect + " AND " + sCond;
                        }
                        DataTable dt = cnn.DT_DataTable(sSelect);
                        cnn.BeginTransaction();
                        try
                        {
                            foreach (DataRow r in dt.Rows)
                            {
                                Val.Clear();
                                Cond.Clear();
                                Cond.Add("Thang", txtThang.uValue);
                                Cond.Add("Nam", txtNam.uValue);
                                Cond.Add("NhanSu", cnn.sNull2Int(r["NhanSu"]));

                                Val.Add("bLock", 0);
                                if (cnn.SelectRows(Cond, "NS_BangLuongHopDong68").Rows.Count > 0)
                                    cnn.UpdateRows(Val, Cond, "NS_BangLuongHopDong68");
                            }
                            cnn.EndTransaction();
                            this.Cursor = Cursors.Default;
                            XtraMessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            cnn.RollbackTransaction();
                            this.Cursor = Cursors.Default;
                            XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (cnn.sNull2String(cbxPhanHe.uEditValue) == "03")//Lương khoán
                    {
                        string sSelect = "SELECT * FROM NS_BangLuongKhoan INNER JOIN dbo.NS_NHANSU ON NS_BangLuongKhoan.NhanSu = dbo.NS_NHANSU.NHANSU WHERE Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND COSO=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND PHANHE=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "'";
                        string sCond = "";
                        if (!cnn.bComboIsNull(cboPhongBan))
                        {
                            sCond += " PHONGBAN=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "' AND ";
                        }
                        if (!cnn.bComboIsNull(cbxDonVi))
                        {
                            sCond += "DONVI=N'" + cnn.sNull2String(cbxDonVi.uEditValue) + "' AND ";
                        }
                        if (sCond != "")
                        {
                            sCond = sCond.Substring(0, sCond.Length - 4);
                            sSelect = sSelect + " AND " + sCond;
                        }
                        DataTable dt = cnn.DT_DataTable(sSelect);
                        cnn.BeginTransaction();
                        try
                        {
                            foreach (DataRow r in dt.Rows)
                            {
                                Val.Clear();
                                Cond.Clear();
                                Cond.Add("Thang", txtThang.uValue);
                                Cond.Add("Nam", txtNam.uValue);
                                Cond.Add("NhanSu", cnn.sNull2Int(r["NhanSu"]));

                                Val.Add("bLock", 0);

                                if (cnn.SelectRows(Cond, "NS_BangLuongKhoan").Rows.Count > 0)
                                    cnn.UpdateRows(Val, Cond, "NS_BangLuongKhoan");
                            }
                            cnn.EndTransaction();
                            this.Cursor = Cursors.Default;
                            XtraMessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            cnn.RollbackTransaction();
                            this.Cursor = Cursors.Default;
                            XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                btnLocDanhSach_Click(sender, e);
            }
            else
                XtraMessageBox.Show("Bạn không có quyển mở khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dtg_uDataSourceChanged(object sender, EventArgs e)
        {
            bLock = bBanDau;
            foreach (DevExpress.XtraGrid.Columns.GridColumn gc in dtg.Columns)
            {
                if (gc.FieldName == "bLock")
                    foreach (DataRow r in dtg.GetDataSource().Rows)
                    {
                        if (Convert.ToBoolean(r[gc.FieldName]) == true)
                        {
                            bLock = false;
                            break;
                        }
                    }
                if (bLock == false)
                    break;
            }

            btnXetBangLuong.Enabled = bLock;
            btnCapNhat.Enabled = bLock;
            btnMoKhoa.Enabled = !bLock;
            btnKhoa.Enabled = bLock;
            //clsRun.SetValueToControl(this);
        }

        private void cbx_uEditValueChanged(object sender, EventArgs e)
        {
            btnXetBangLuong.Enabled = false;
            btnCapNhat.Enabled = false;
            btnMoKhoa.Enabled = false;
            btnKhoa.Enabled = false;
        }

        private void btnBangNopThueTNCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable tb = dtg.GetDataSource();
            DataTable DT = tb.Copy().Clone();
            foreach (DataRow r in tb.Rows)
            {
                decimal TienThue = cnn.sNull2Number(r["ThueTNCN"]);
                if (TienThue != null && TienThue > 0)
                {
                    DT.ImportRow(r);
                }
            }
            decimal TongThucLanh = 0;
            foreach (DataRow r in DT.Rows)
            {
                TongThucLanh += cnn.sNull2Number(r["ThueTNCN"]);
            }
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BangNopThueTNCN.repx", DT);
            BSC_Class.Doctien doctien = new BSC_HRM.NET.BSC_Class.Doctien();
            frm.sSoTienBangChu = doctien.Convert_NumtoText(TongThucLanh.ToString());
            frm.iNam = cnn.sNull2Int(txtNam.uValue);
            frm.iThang = cnn.sNull2Int(txtThang.uValue);
            frm.sCoSo = cbxCoSo.uText;
            frm.sPhanHe = cbxPhanHe.uText;
            if (!cnn.bComboIsNull(cboPhongBan))
                frm.sPhongBan = cboPhongBan.uText;
            frm.Show();
        }
    }
}