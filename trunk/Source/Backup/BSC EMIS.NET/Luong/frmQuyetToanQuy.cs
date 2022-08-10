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
    public partial class frmQuyetToanQuy : DevExpress.XtraEditors.XtraForm
    {
        public frmQuyetToanQuy()
        {
            InitializeComponent();
            clsrun.SetValueToControl(this);
            dtg.sKEY = sKEY;
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsrun = new clsRun();
        string sKEY = "QUYETTOANTHUE_QUY";
        private void frmQuyetToanQuy_Load(object sender, EventArgs e)
        {
            txtNam.uValue = DateTime.Now.Year;
        }
        private void cbxPhongBan_uEditValueChanged(object sender, EventArgs e)
        {
            string sSQL = "Select MaDonVi,TenDonVi from DM_DonVi where MaPhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "'";
            DataTable DT = cnn.DT_DataTable(sSQL);
            cbxDonVi.uDataSource = DT;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            string sSQL = cnn.GetSQLString(sKEY);
            string sReplace = "";
            if (cnn.sNull2Int(raQuy.EditValue) == 1)
            {
                sReplace = "Thang=4 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND ";
            }
            else if (cnn.sNull2Int(raQuy.EditValue) == 2)
                {
                    sReplace = "Thang=7 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND ";
                }
                else if (cnn.sNull2Int(raQuy.EditValue) == 3)
                {
                    sReplace = "Thang=10 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND ";
                }
                else if (cnn.sNull2Int(raQuy.EditValue) == 4)
                {
                    sReplace = "Thang=1 AND Nam=" + (cnn.sNull2Int(txtNam.uValue) + 1) + " AND ";
                }  
            if (!cnn.bComboIsNull(cbxCoSo))
                sReplace += "NS_NhanSu.CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxPhanHe))
                sReplace += "NS_NhanSu.PhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxPhongBan))
                sReplace += "NS_NhanSu.PhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxDonVi))
                sReplace += "NS_NhanSu.DonVi=N'" + cnn.sNull2String(cbxDonVi.uEditValue) + "' AND ";
            sReplace = sReplace.Substring(0, sReplace.Length - 4);
            sSQL = sSQL.Replace("1 = 0", sReplace);
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = DT;
        }

        private void btnTinhThue_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string sSQL = cnn.GetSQLString("XETQUYETTOANTHUE_QUY");
            string sReplace20 = "";
            string sReplace10 = "";
            string sReplace22 = "";
            if (cnn.sNull2Int(raQuy.EditValue) == 1)
            {
                sReplace20 = "(Thang=1 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + ") OR (Thang=2 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + ") OR (Thang=3 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + ")";
                sReplace10 = "(NS_BangLuongHopDongBienChe.Thang=1 AND NS_BangLuongHopDongBienChe.Nam=" + cnn.sNull2Int(txtNam.uValue) + ") OR (NS_BangLuongHopDongBienChe.Thang=2 AND NS_BangLuongHopDongBienChe.Nam=" + cnn.sNull2Int(txtNam.uValue) + ") OR (NS_BangLuongHopDongBienChe.Thang=3 AND NS_BangLuongHopDongBienChe.Nam=" + cnn.sNull2Int(txtNam.uValue) + ")";
            }
            else if (cnn.sNull2Int(raQuy.EditValue) == 2)
            {
                sReplace20 = "(Thang=4 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + ") OR (Thang=5 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + ") OR (Thang=6 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + ")";
                sReplace10 = "(NS_BangLuongHopDongBienChe.Thang=4 AND NS_BangLuongHopDongBienChe.Nam=" + cnn.sNull2Int(txtNam.uValue) + ") OR (NS_BangLuongHopDongBienChe.Thang=5 AND NS_BangLuongHopDongBienChe.Nam=" + cnn.sNull2Int(txtNam.uValue) + ") OR (NS_BangLuongHopDongBienChe.Thang=6 AND NS_BangLuongHopDongBienChe.Nam=" + cnn.sNull2Int(txtNam.uValue) + ")";
            }
            else if (cnn.sNull2Int(raQuy.EditValue) == 3)
            {
                sReplace20 = "(Thang=7 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + ") OR (Thang=8 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + ") OR (Thang=9 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + ")";
                sReplace10 = "(NS_BangLuongHopDongBienChe.Thang=7 AND NS_BangLuongHopDongBienChe.Nam=" + cnn.sNull2Int(txtNam.uValue) + ") OR (NS_BangLuongHopDongBienChe.Thang=8 AND NS_BangLuongHopDongBienChe.Nam=" + cnn.sNull2Int(txtNam.uValue) + ") OR (NS_BangLuongHopDongBienChe.Thang=9 AND NS_BangLuongHopDongBienChe.Nam=" + cnn.sNull2Int(txtNam.uValue) + ")";
            }
            else if (cnn.sNull2Int(raQuy.EditValue) == 4)
            {
                sReplace20 = "(Thang=10 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + ") OR (Thang=11 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + ") OR (Thang=12 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + ")";
                sReplace10 = "(NS_BangLuongHopDongBienChe.Thang=10 AND NS_BangLuongHopDongBienChe.Nam=" + cnn.sNull2Int(txtNam.uValue) + ") OR (NS_BangLuongHopDongBienChe.Thang=11 AND NS_BangLuongHopDongBienChe.Nam=" + cnn.sNull2Int(txtNam.uValue) + ") OR (NS_BangLuongHopDongBienChe.Thang=12 AND NS_BangLuongHopDongBienChe.Nam=" + cnn.sNull2Int(txtNam.uValue) + ")";
            }  
            if (!cnn.bComboIsNull(cbxCoSo))
                sReplace22 += "NS_NhanSu.CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxPhanHe))
                sReplace22 += "NS_NhanSu.Phanhe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxPhongBan))
                sReplace22 += "NS_NhanSu.PhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxDonVi))
                sReplace22 += "NS_NhanSu.DonVi=N'" + cnn.sNull2String(cbxDonVi.uEditValue) + "' AND ";
            sSQL = sSQL.Replace("1 = 0", sReplace10).Replace("2 = 0", sReplace20);
            if (sReplace22 != "")
            {
                sReplace22 = sReplace22.Substring(0, sReplace22.Length - 4);
                sSQL = sSQL.Replace("2 = 2", sReplace22);
            }
            DataTable DT = cnn.DT_DataTable(sSQL);
            foreach (DataRow r in DT.Rows)
            {
                r["ThueTNCN"] = TinhThue(cnn.sNull2Number(r["ThuNhapTinhThueTrungBinh"]));
                r["TongTienThue"] = cnn.sNull2Number(r["ThueTNCN"]) * 3;
            }
            dtg.uDataSource = DT;
            this.Cursor = Cursors.Default;
        }
        private decimal TinhThue(decimal dTienChiuThue)
        {
            decimal dTongTienThue=0;
            string sBacThue = "SELECT * FROM  dbo.DM_BieuThueLuyTien WHERE TinhThueThangTu<"+dTienChiuThue+" AND TinhThueThangDen>="+dTienChiuThue;
            DataTable DTBacThue = cnn.DT_DataTable(sBacThue);
            int iBacThue=0;
            if (DTBacThue != null && DTBacThue.Rows.Count > 0)
            {
                iBacThue = cnn.sNull2Int(DTBacThue.Rows[0]["BacThue"]);
                string sBangTinh = "SELECT * FROM  dbo.DM_BieuThueLuyTien WHERE BacThue<" + iBacThue + " ORDER BY BacThue";
                DataTable DTBangTinh = cnn.DT_DataTable(sBangTinh);
                foreach (DataRow r in DTBangTinh.Rows)
                {
                    dTongTienThue += (cnn.sNull2Number(r["TinhThueThangDen"]) - cnn.sNull2Number(r["TinhThueThangTu"])) * cnn.sNull2Number(r["PTThueSuat"]) / 100;
                }
                dTongTienThue += (dTienChiuThue - cnn.sNull2Number(DTBacThue.Rows[0]["TinhThueThangTu"])) * cnn.sNull2Number(DTBacThue.Rows[0]["PTThueSuat"]) / 100;                
            }
            return dTongTienThue;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            if (DT != null && DT.Rows.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;
                cnn.BeginTransaction();
                try
                {
                    Hashtable Val = new Hashtable();
                    Hashtable Cond = new Hashtable();
                    foreach (DataRow r in DT.Rows)
                    {
                        Val.Clear();
                        Cond.Clear();
                        if (cnn.sNull2Int(raQuy.EditValue) == 1)
                        {
                            Cond.Add("Thang", 4);
                            Cond.Add("Nam", cnn.sNull2Int(txtNam.uValue));
                        }
                        else if (cnn.sNull2Int(raQuy.EditValue) == 2)
                        {
                            Cond.Add("Thang", 7);
                            Cond.Add("Nam", cnn.sNull2Int(txtNam.uValue));
                        }
                        else if (cnn.sNull2Int(raQuy.EditValue) == 3)
                        {
                            Cond.Add("Thang", 10);
                            Cond.Add("Nam", cnn.sNull2Int(txtNam.uValue));
                        }
                        else if (cnn.sNull2Int(raQuy.EditValue) == 4)
                        {
                            Cond.Add("Thang", 1);
                            Cond.Add("Nam", (cnn.sNull2Int(txtNam.uValue) + 1));
                        }
                        
                        Cond.Add("NhanSu", r["NhanSu"]);
                        Val.Add("TongThuNhap", r["TongThuNhap"]);
                        Val.Add("GiamTruGiaCanh", r["GiamTruGiaCanh"]);
                        Val.Add("BaoHiem", r["BaoHiem"]);
                        Val.Add("ThuNhapTinhThue", r["ThuNhapTinhThue"]);
                        Val.Add("ThuNhapTinhThueTrungBinh", r["ThuNhapTinhThueTrungBinh"]);
                        Val.Add("ThueTNCN", r["ThueTNCN"]);
                        Val.Add("TongTienThue", r["TongTienThue"]);
                        if (cnn.SelectRows(Cond, "NS_ThueTNCN_Quy").Rows.Count > 0)
                        {
                            cnn.UpdateRows(Val, Cond, "NS_ThueTNCN_Quy");
                        }
                        else
                        {
                            Cond.Add("TongThuNhap", r["TongThuNhap"]);
                            Cond.Add("GiamTruGiaCanh", r["GiamTruGiaCanh"]);
                            Cond.Add("BaoHiem", r["BaoHiem"]);
                            Cond.Add("ThuNhapTinhThue", r["ThuNhapTinhThue"]);
                            Cond.Add("ThuNhapTinhThueTrungBinh", r["ThuNhapTinhThueTrungBinh"]);
                            Cond.Add("ThueTNCN", r["ThueTNCN"]);
                            Cond.Add("TongTienThue", r["TongTienThue"]);
                            cnn.InsertNewRow(Cond, "NS_ThueTNCN_Quy");
                        }                            
                    }
                    cnn.EndTransaction();
                    this.Cursor = Cursors.Default;
                    XtraMessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    cnn.RollbackTransaction();
                    this.Cursor = Cursors.Default;
                    XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            decimal TongTienThue = 0;
            foreach (DataRow r in DT.Rows)
            { 
                TongTienThue+= cnn.sNull2Number(r["TongTienThue"]);
            }
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BangTinhThueTNCN_Quy.repx", DT);
            BSC_Class.Doctien DocTien = new BSC_HRM.NET.BSC_Class.Doctien();
            frm.sSoTienBangChu = DocTien.Convert_NumtoText(TongTienThue.ToString());
            frm.iNam = cnn.sNull2Int(txtNam.uValue);
            frm.iQuy = cnn.sNull2Int(raQuy.EditValue);
            frm.Show();

        }

        private void cbxPhanHe_Load(object sender, EventArgs e)
        {
            cbxPhanHe.uDataSource = cnn.SelectRows_NonSortOrder("SELECT MaPhanHe,TenPhanHe FROM dbo.DM_PHANHE WHERE MAPHANHE NOT IN ('03','04')");
        }
    }
}