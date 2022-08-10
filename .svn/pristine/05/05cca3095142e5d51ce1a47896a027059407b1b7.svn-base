using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace DELFI_WHM.NET.Luong
{
    public partial class frmNhanSu_BaoHiem : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanSu_BaoHiem()
        {
            InitializeComponent();
            clsrun.SetValueToControl(this);
            dtg.sKEY = sKEY;
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clsrun = new clsRun();
        string sKEY = "NHANSU_BAOHIEM";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhanSu_BaoHiem_Load(object sender, EventArgs e)
        {
            txtNam.uValue = DateTime.Now.Year;
            txtThang.uValue = DateTime.Now.Month;
        }

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            string sSQL = cnn.GetSQLString("LOC_NHANSU_BAOHIEM");
            if (cnn.bComboIsNull(cbxDot))
            {
                XtraMessageBox.Show("Bạn chưa chọn đợt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sCond = "Thang=" + cnn.sNull2Int(txtThang.uValue) + " And Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND MaDotXetBaoHiem=N'"+cnn.sNull2String(cbxDot.uEditValue)+"' AND ";
            if (!cnn.bComboIsNull(cbxCoSo))
            {
                sCond += "CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxPhanHe))
            {
                sCond += "PhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxPhongBan))
            {
                sCond += "PhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
            }
            sCond = sCond.Substring(0, sCond.Length - 4);
            sSQL = sSQL.Replace("1 = 0", sCond);
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = DT;
            EditColumn();
        }

        private void btnXet_Click(object sender, EventArgs e)
        {
            string str = "SELECT * FROM  dbo.DM_DotXetBaoHiem WHERE MaDotXetBaoHiem NOT IN (SELECT MaDotXetBaoHiem FROM  dbo.NS_NhanSu_BaoHiem WHERE Thang="+cnn.sNull2Int(txtThang.uValue)+" And Nam="+cnn.sNull2Int(txtNam.uValue)+")";
            DataTable dtStr = cnn.DT_DataTable(str);            
            if (dtStr != null && dtStr.Rows.Count > 0)
            {
                cbxDot.uEditValue = cnn.sNull2String(dtStr.Rows[0][0]);
            }
            if (cnn.bComboIsNull(cbxDot))
            {
                XtraMessageBox.Show("Bạn chưa chọn đợt xét", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sSQL = "";
            if (cnn.bComboIsNull(cbxPhanHe))
            {
                XtraMessageBox.Show("Bạn chưa chọn phân hệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cnn.sNull2String(cbxPhanHe.uEditValue) == "05")
            {
                sSQL = cnn.GetSQLString("NHANSU_BAOHIEM_HOPDONG68");
            }
            else
            {
                sSQL = cnn.GetSQLString(sKEY);
            }
            int iThangNay=cnn.sNull2Int(txtThang.uValue);
            int iNamNay=cnn.sNull2Int(txtNam.uValue);
            int iThangTruoc=iThangNay-1;
            int iNamTruoc=iNamNay;
            if(iThangNay==1)
            {
                iThangTruoc=12;
                iNamTruoc=iNamNay-1;
            }
            string sReplace10 = "Thang=" + iThangTruoc + " AND Nam=" + iNamTruoc;
            string sReplace20 = "Thang=" + iThangNay + " And Nam=" + iNamNay;
            sSQL = sSQL.Replace("1 = 0", sReplace10).Replace("2 = 0", sReplace20);
            string sWhere = "";
            if (!cnn.bComboIsNull(cbxCoSo))
            {
                sWhere += "CoSo=N'"+cnn.sNull2String(cbxCoSo.uEditValue)+"' AND ";
            }
            if (!cnn.bComboIsNull(cbxPhanHe))
            {
                sWhere += "PhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxPhongBan))
            {
                sWhere += "PhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
            }
            if (sWhere != "")
            {
                sWhere = sWhere.Substring(0, sWhere.Length - 4);
                sSQL = "Select * from (" + sSQL + ")AAAA where " + sWhere;
            }
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = DT;
            EditColumn();
        }
        private void EditColumn()
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
            {
                if (col.FieldName != "Chon" && col.FieldName != "TuThangNam" && col.FieldName != "DenThangNam" && col.FieldName != "TyLeDong" && col.FieldName != "GhuChu")
                    col.OptionsColumn.AllowEdit = false;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cbxDot))
            {
                XtraMessageBox.Show("Bạn chưa chọn đợt xét", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable DT = dtg.GetDataSource();
            if (DT != null && DT.Rows.Count > 0)
            {
                DataRow[] RowChon = DT.Select("Chon=1");
                DataRow[] RowKhongChon = DT.Select("Chon=0");
                Hashtable Cond = new Hashtable();
                Hashtable Val = new Hashtable();
                cnn.BeginTransaction();
                this.Cursor = Cursors.WaitCursor;
                try
                {
                    if (RowChon != null && RowChon.Length > 0)
                    {
                        foreach (DataRow r in RowChon)
                        {
                            Cond.Clear();
                            Val.Clear();
                            Cond.Add("NhanSu", r["NhanSu"]);
                            Cond.Add("Thang", cnn.sNull2Int(txtThang.uValue));
                            Cond.Add("Nam", cnn.sNull2Int(txtNam.uValue));

                            Val.Add("MaDotXetBaoHiem", cnn.sNull2String(cbxDot.uEditValue));
                            Val.Add("Nhom", r["Nhom"]);
                            Val.Add("TenNhom", r["TenNhom"]);
                            Val.Add("Loai", r["Loai"]);
                            Val.Add("TenLoai", r["TenLoai"]);
                            Val.Add("HeSoLuong_Cu", r["HeSoLuong_Cu"]);
                            Val.Add("HeSoChucVu_Cu", r["HeSoChucVu_Cu"]);
                            Val.Add("PTThamNienVuotKhung_Cu", r["PTThamNienVuotKhung_Cu"]);
                            Val.Add("PTThamNienNghe_Cu", r["PTThamNienNghe_Cu"]);
                            Val.Add("Khac_Cu", r["Khac_Cu"]);
                            Val.Add("HeSoLuong_Moi", r["HeSoLuong_Moi"]);
                            Val.Add("HeSoChucVu_Moi", r["HeSoChucVu_Moi"]);
                            Val.Add("PTThamNienVuotKhung_Moi", r["PTThamNienVuotKhung_Moi"]);
                            Val.Add("PTThamNienNghe_Moi", r["PTThamNienNghe_Moi"]);
                            Val.Add("Khac_Moi", r["Khac_Moi"]);
                            Val.Add("TuThangNam", r["TuThangNam"]);
                            Val.Add("DenThangNam", r["DenThangNam"]);
                            Val.Add("TyLeDong", r["TyLeDong"]);
                            Val.Add("GhiChu", r["GhiChu"]);
                            if (cnn.SelectRows(Cond, "NS_NhanSu_BaoHiem").Rows.Count > 0)
                            {
                                cnn.UpdateRows(Val, Cond, "NS_NhanSu_BaoHiem");
                            }
                            else
                            {
                                Val.Add("NhanSu", r["NhanSu"]);
                                Val.Add("Thang", cnn.sNull2Int(txtThang.uValue));
                                Val.Add("Nam", cnn.sNull2Int(txtNam.uValue));
                                cnn.InsertNewRow(Val, "NS_NhanSu_BaoHiem");
                            }
                        }
                    }
                    if (RowKhongChon != null && RowKhongChon.Length > 0)
                    {
                        foreach (DataRow r in RowKhongChon)
                        {
                            Cond.Clear();
                            if (cnn.sNull2String(r["MaDotXetBaoHiem"]) != "")
                            {
                                Cond.Add("NhanSu", r["NhanSu"]);
                                Cond.Add("Thang", cnn.sNull2Int(txtThang.uValue));
                                Cond.Add("Nam", cnn.sNull2Int(txtNam.uValue));
                                cnn.DeleteRows(Cond, "NS_NhanSu_BaoHiem");
                            }
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
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            if (DT != null && DT.Rows.Count > 0)
            {
                foreach (DataRow r in DT.Rows)
                {
                    r["TuThangNam"] = cnn.sNull2String(txtTuThangNam.uText);
                    r["DenThangNam"] = cnn.sNull2String(txtDenThangNam.uText);
                    r["TyLeDong"] = cnn.sNull2Number(txtTyLeDong.uText);
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            if (DT != null && DT.Rows.Count > 0)
            {
                DataRow[] row = DT.Select("Chon=1");
                if (row != null && row.Length > 0)
                {
                    DataTable DTT = DT.Copy().Clone();
                    foreach (DataRow r in row)
                    {
                        DTT.ImportRow(r);
                    }
                    BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\DS_LaoDongThamGiaBHXH_BHYT.repx", DTT);
                    frm.sDot = cnn.sNull2String(cbxDot.uText) + " tháng " + cnn.sNull2Int(txtThang.uValue) + " năm " + cnn.sNull2Int(txtNam.uValue);
                    frm.Show();
                }
            }


        }
    }
}