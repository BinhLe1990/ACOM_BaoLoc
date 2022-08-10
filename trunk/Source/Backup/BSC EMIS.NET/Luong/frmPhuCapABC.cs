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
    public partial class frmPhuCapABC : DevExpress.XtraEditors.XtraForm
    {
        public frmPhuCapABC()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            string sPermit = Properties.Settings.Default.PER_SYSTEM;
            string sTag = cnn.sNull2String(this.Tag);
            if (sTag == "")
                bBanDau = false;
            if (sPermit.Contains(sTag))
                bBanDau = true;
            btnXetPhuCap.Enabled = false;
            btnCapNhat.Enabled = false;
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        bool bLock = false;
        bool bBanDau = false;
        string sKEY_DAUNAM = "XETBANGPHUCAPABC_DAUNAM";
        string sKEY_CUOINAM = "XETBANGPHUCAPABC_CUOINAM";

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            txtNam.uValue = DateTime.Now.Year;
        }      

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cbxPhanHe))
            {
                XtraMessageBox.Show("Bạn chưa chọn phân hệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sSQL = "";
            if (raThang.SelectedIndex == 0)
            {
                dtg.sKEY = "INBANGPHUCAPABC_DAUNAM";
                sSQL = cnn.GetSQLString("INBANGPHUCAPABC_DAUNAM");
            }
            else
            {
                dtg.sKEY = "INBANGPHUCAPABC_CUOINAM";
                sSQL = cnn.GetSQLString("INBANGPHUCAPABC_CUOINAM");
            }
            string sFieldSum = "ThucLanh,TongHeSo6Thang";
            int Thang = 7;
            if (raThang.SelectedIndex == 1)
                Thang = 12;
            string sCond = " Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND Thang =" + Thang + " AND ";
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
                sCond += " NS_NhanSu.CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxPhanHe))
            {
                sCond += " NS_NhanSu.PHANHE=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            }
            sCond = sCond.Substring(0, sCond.Length - 4);
            sSQL = sSQL.Replace("1 = 0", sCond);
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.sFieldSummary = sFieldSum;
            dtg.uDataSource = DT;
            btnXetPhuCap.Enabled = true;
            btnCapNhat.Enabled = true;
            dtg.bAllowEdit = false;
        }
        private void EditColumn()
        {
            dtg.bAllowEdit = true;
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
            {
                if (col.FieldName != "XepLoai")
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
                    cnn.BeginTransaction();
                    int Thang = 7;
                    if (raThang.SelectedIndex == 1)
                        Thang = 12;
                    string sDelete = "DELETE NS_PhuCapABC FROM  dbo.NS_PhuCapABC INNER JOIN dbo.NS_NHANSU ON dbo.NS_PhuCapABC.NhanSu = dbo.NS_NHANSU.NHANSU WHERE Thang=" + Thang + " And Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND NS_NHANSU.COSO=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND NS_NHANSU.PHANHE=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "'";
                    string sCond = "";
                    if (!cnn.bComboIsNull(cboPhongBan))
                    {
                        sCond += " NS_NHANSU.PHONGBAN=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "' AND ";
                    }
                    if (!cnn.bComboIsNull(cbxDonVi))
                    {
                        sCond += "NS_NHANSU.DONVI=N'" + cnn.sNull2String(cbxDonVi.uEditValue) + "' AND ";
                    }
                    if (sCond != "")
                    {
                        sCond = sCond.Substring(0, sCond.Length - 4);
                        sDelete = sDelete + " AND " + sCond;
                    }
                    cnn.SQL_ExecuteNonQuery(sDelete);
                    try
                    {
                        if (Thang == 7)
                        {
                            foreach (DataRow r in DT.Rows)
                            {
                                Val.Clear();
                                Val.Add("Nam", txtNam.uValue);
                                Val.Add("NhanSu", cnn.sNull2Int(r["NHANSU"]));
                                Val.Add("Thang", 7);
                                Val.Add("TongHeSoT1", cnn.sNull2Number(r["TongHeSoT1"]));
                                Val.Add("TongHeSoT2", cnn.sNull2Number(r["TongHeSoT2"]));
                                Val.Add("TongHeSoT3", cnn.sNull2Number(r["TongHeSoT3"]));
                                Val.Add("TongHeSoT4", cnn.sNull2Number(r["TongHeSoT4"]));
                                Val.Add("TongHeSoT5", cnn.sNull2Number(r["TongHeSoT5"]));
                                Val.Add("TongHeSoT6", cnn.sNull2Number(r["TongHeSoT6"]));
                                Val.Add("TongHeSo6Thang", cnn.sNull2Number(r["TongHeSo6Thang"]));
                                Val.Add("TienPhuCap", cnn.sNull2Number(r["TienPhuCap"]));
                                Val.Add("XepLoai", cnn.sNull2String(r["XepLoai"]));
                                Val.Add("ThucLanh", cnn.sNull2Number(r["ThucLanh"]));
                                cnn.InsertNewRow(Val, "NS_PhuCapABC");
                            }
                        }
                        else
                        {
                            foreach (DataRow r in DT.Rows)
                            {
                                Val.Clear();
                                Val.Add("Nam", txtNam.uValue);
                                Val.Add("NhanSu", cnn.sNull2Int(r["NHANSU"]));
                                Val.Add("Thang", 12);
                                Val.Add("TongHeSoT1", cnn.sNull2Number(r["TongHeSoT7"]));
                                Val.Add("TongHeSoT2", cnn.sNull2Number(r["TongHeSoT8"]));
                                Val.Add("TongHeSoT3", cnn.sNull2Number(r["TongHeSoT9"]));
                                Val.Add("TongHeSoT4", cnn.sNull2Number(r["TongHeSoT10"]));
                                Val.Add("TongHeSoT5", cnn.sNull2Number(r["TongHeSoT11"]));
                                Val.Add("TongHeSoT6", cnn.sNull2Number(r["TongHeSoT12"]));
                                Val.Add("TongHeSo6Thang", cnn.sNull2Number(r["TongHeSo6Thang"]));
                                Val.Add("TienPhuCap", cnn.sNull2Number(r["TienPhuCap"]));
                                Val.Add("XepLoai", cnn.sNull2String(r["XepLoai"]));
                                Val.Add("ThucLanh", cnn.sNull2Number(r["ThucLanh"]));
                                cnn.InsertNewRow(Val, "NS_PhuCapABC");
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
        }
        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            decimal TongThucLanh = 0;
            foreach (DataRow r in DT.Rows)
            {
                TongThucLanh += cnn.sNull2Number(r["ThucLanh"]);
            }
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BangPhuCapABC.repx", DT);
            BSC_Class.Doctien doctien = new BSC_HRM.NET.BSC_Class.Doctien();
            frm.sSoTienBangChu = doctien.Convert_NumtoText(TongThucLanh.ToString());
            frm.iNam = cnn.sNull2Int(txtNam.uValue);
            frm.sCoSo = cbxCoSo.uText;
            frm.sPhanHe = cbxPhanHe.uText;
            if (!cnn.bComboIsNull(cboPhongBan))
                frm.sPhongBan = cboPhongBan.uText;
            frm.Show();

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
            if (XtraMessageBox.Show("Bạn có muốn xét bảng phụ cấp ABC hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;
                string sFieldSum = "ThucLanh,TongHeSo6Thang";
                string sReplace20 = "LUONG.Nam=" + txtNam.uValue + " AND ";

                if (!cnn.bComboIsNull(cbxCoSo))
                {
                    sReplace20 += " NS_NhanSu.CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
                }
                if (!cnn.bComboIsNull(cbxPhanHe))
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
                string sSQL = "";
                if (raThang.SelectedIndex == 0)
                {
                    dtg.sKEY = sKEY_DAUNAM;
                    sSQL = cnn.GetSQLString(sKEY_DAUNAM);
                }
                else
                {
                    dtg.sKEY = sKEY_CUOINAM;
                    sSQL = cnn.GetSQLString(sKEY_CUOINAM);
                }
                sSQL = sSQL.Replace("1 = 0", sReplace20);
                DataTable dt = cnn.DT_DataTable(sSQL);
                dtg.sFieldSummary = sFieldSum;
                dtg.uDataSource = dt;
                EditColumn();
                this.Cursor = Cursors.Default;
            }
        }

        private void cboPhongBan_uEditValueChanged(object sender, EventArgs e)
        {
            string sSQL = "Select MaDonVi,TenDonVi From DM_DonVi where MaPhongBan=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "'";
            DataTable DT = cnn.DT_DataTable(sSQL);
            cbxDonVi.uDataSource = DT;
            btnXetPhuCap.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private int PhanTramXepLoai(string XepLoai)
        {
            switch (XepLoai)
            {
                case "A":
                    return 100;
                case "B":
                    return 50;
                case "C":
                    return 30;
                default:
                    return 0;
            }
        }

        private void dtg_uCellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "XepLoai")
            {
                DataRow r = dtg.CurRow;
                string XepLoai = cnn.sNull2String(e.Value).Trim().ToUpper();
                if (XepLoai != "A" && XepLoai != "B" && XepLoai != "C")
                {
                    r["XepLoai"] = "";
                }
                else
                {
                    r["XepLoai"] = XepLoai;
                    int iNhanSu = cnn.sNull2Int(r["NhanSu"]);
                    decimal TyLeHuongLuong = cnn.sNull2Number(cnn.SQL_ExecuteScalar("SELECT  TYLEHUONGLUONG " +
                                                                                    "FROM    dbo.NS_NHANSU " +
                                                                                            "LEFT JOIN dbo.DM_TINHTRANG ON dbo.NS_NHANSU.TINHTRANG = dbo.DM_TINHTRANG.MATINHTRANG " +
                                                                                    "WHERE NHANSU=" + iNhanSu));
                    decimal TongHeSo = cnn.sNull2Number(r["TongHeSo6Thang"]);
                    r["ThucLanh"] = (cnn.sNull2Number(r["TienPhuCap"]) * TongHeSo) * TyLeHuongLuong / 100 * PhanTramXepLoai(XepLoai) / 100;
                }
            }
        }

        private void cbx_uEditValueChanged(object sender, EventArgs e)
        {
            btnXetPhuCap.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string XepLoai = txtXepLoai.uText.Trim().ToUpper();
            if (XepLoai != "A" && XepLoai != "B" && XepLoai != "C")
            {
                XtraMessageBox.Show("Chỉ chấp nhận loại A,B,C", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtXepLoai.uText = "";
                txtXepLoai.Focus();
            }
            else
            {
                try
                {
                    int[] iRow = dtg.uGetSelectRows();
                    if (iRow.Length > 0)
                    {
                        DevExpress.XtraGrid.Columns.GridColumn col = new DevExpress.XtraGrid.Columns.GridColumn();
                        col.FieldName = "XepLoai";
                        for (int i = 0; i < iRow.Length; i++)
                        {
                            dtg.uSetRowCellValue(iRow[i], col, XepLoai);
                            DataRow r = dtg.GetDaTaRow(iRow[i]);
                            int iNhanSu = cnn.sNull2Int(r["NhanSu"]);
                            decimal TyLeHuongLuong = cnn.sNull2Number(cnn.SQL_ExecuteScalar("SELECT  TYLEHUONGLUONG " +
                                                                                            "FROM    dbo.NS_NHANSU " +
                                                                                                    "LEFT JOIN dbo.DM_TINHTRANG ON dbo.NS_NHANSU.TINHTRANG = dbo.DM_TINHTRANG.MATINHTRANG " +
                                                                                            "WHERE NHANSU=" + iNhanSu));
                            decimal TongHeSo = cnn.sNull2Number(r["TongHeSo6Thang"]);
                            r["ThucLanh"] = (cnn.sNull2Number(r["TienPhuCap"]) * TongHeSo) * TyLeHuongLuong / 100 * PhanTramXepLoai(XepLoai) / 100;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < dtg.RowCount; i++)
                        {
                            DataRow r = dtg.GetDaTaRow(i);
                            r["XepLoai"] = XepLoai;
                            int iNhanSu = cnn.sNull2Int(r["NhanSu"]);
                            decimal TyLeHuongLuong = cnn.sNull2Number(cnn.SQL_ExecuteScalar("SELECT  TYLEHUONGLUONG " +
                                                                                            "FROM    dbo.NS_NHANSU " +
                                                                                                    "LEFT JOIN dbo.DM_TINHTRANG ON dbo.NS_NHANSU.TINHTRANG = dbo.DM_TINHTRANG.MATINHTRANG " +
                                                                                            "WHERE NHANSU=" + iNhanSu));
                            decimal TongHeSo = cnn.sNull2Number(r["TongHeSo6Thang"]);
                            r["ThucLanh"] = (cnn.sNull2Number(r["TienPhuCap"]) * TongHeSo) * TyLeHuongLuong / 100 * PhanTramXepLoai(XepLoai) / 100;
                        }
                    }
                }
                catch { }
            }
        }
    }
}