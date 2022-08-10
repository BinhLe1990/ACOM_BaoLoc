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
    public partial class frmBangPhuCap : DevExpress.XtraEditors.XtraForm
    {
        public frmBangPhuCap()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKEYTRUONG = "BANGPHUCAPTRUONG";
        string sKEYPTNK = "BANGPHUCAPPTNK";
        string sKEYKHOA = "BANGPHUCAPKHOA";
        string sKEYKHAC = "BANGPHUCAPKHAC";
        string sKEYKHAC_DT = "BANGPHUCAPKHAC_DIENTHOAI";
        string sKEYDOCHAI = "BANGPHUCAPDOCHAI";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBangPhuCap_Load(object sender, EventArgs e)
        {
            txtNam.uValue = DateTime.Now.Year;
            txtThang.uValue = DateTime.Now.Month;
        }

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cboPhuCap))
            {
                XtraMessageBox.Show("Bạn chưa chọn loại phụ cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sSQL = "";
            string sCond = "Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND ";
            if (!cnn.bComboIsNull(cbxCoSo))
            {
                sCond += "NS_NhanSu.CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxPhanHe))
            {
                sCond += "NS_NhanSu.PHANHE=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            } 
            if (!cnn.bComboIsNull(cbxPhongBan))
            {
                sCond += "NS_NhanSu.PhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
            }
            sCond = sCond.Substring(0, sCond.Length - 4);
            DataTable DT = new DataTable();
            switch (cnn.sNull2Int(cboPhuCap.uEditValue))
            {
                case 0:
                    dtg.sKEY = sKEYTRUONG;
                    sSQL = cnn.GetSQLString("INBANGPHUCAPTRUONG");
                    sSQL = sSQL.Replace("1 = 0", sCond);
                    DT = cnn.DT_DataTable(sSQL);
                    dtg.uDataSource = DT;
                    EditColumn(0);
                    break;
                case 1:
                    dtg.sKEY = sKEYKHOA;
                    sSQL = cnn.GetSQLString("INBANGPHUCAPKHOA");
                    sSQL = sSQL.Replace("1 = 0", sCond);
                    DT = cnn.DT_DataTable(sSQL);
                    dtg.uDataSource = DT;
                    EditColumn(1);
                    break;
                case 2:
                    if (!cnn.bComboIsNull(cboPhuCap))
                    {
                        sCond += "AND NS_BangPhuCapKhac.MaPhuCap=N'" + cnn.sNull2String(cboPhuCap.uEditValue) + "' AND ";
                    }
                    sCond = sCond.Substring(0, sCond.Length - 4);
                    dtg.sKEY = sKEYKHAC_DT;
                    sSQL = cnn.GetSQLString("INBANGPHUCAPKHAC");
                    sSQL = sSQL.Replace("1 = 0", sCond);
                    DT = cnn.DT_DataTable(sSQL);
                    dtg.uDataSource = DT;
                    EditColumn(2);
                    break;
                case 5:
                    dtg.sKEY = sKEYPTNK;
                    sSQL = cnn.GetSQLString("INBANGPHUCAPPTNK");
                    sSQL = sSQL.Replace("1 = 0", sCond);
                    DT = cnn.DT_DataTable(sSQL);
                    dtg.uDataSource = DT;
                    EditColumn(0);
                    break;
                case 6:
                    dtg.sKEY = sKEYDOCHAI;
                    sSQL = cnn.GetSQLString("INBANGPHUCAPDOCHAI");
                    sSQL = sSQL.Replace("1 = 0", sCond);
                    DT = cnn.DT_DataTable(sSQL);
                    dtg.uDataSource = DT;
                    EditColumn(0);
                    break;
                default:
                    if (!cnn.bComboIsNull(cboPhuCap))
                    {
                        sCond += "AND NS_BangPhuCapKhac.MaPhuCap=N'" + cnn.sNull2String(cboPhuCap.uEditValue) + "' AND ";
                    }
                    sCond = sCond.Substring(0, sCond.Length - 4);
                    dtg.sKEY = sKEYKHAC;
                    sSQL = cnn.GetSQLString("INBANGPHUCAPKHAC");
                    sSQL = sSQL.Replace("1 = 0", sCond);
                    DT = cnn.DT_DataTable(sSQL);
                    dtg.uDataSource = DT;
                    EditColumn(2);
                    break;
            }
        }
        private void EditColumn(int iKieu)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
            {
                if (iKieu == 0)//Truong
                {
                    if (col.FieldName != "BoSung" && col.FieldName != "GhiChu")
                        col.OptionsColumn.AllowEdit = false;
                }
                else//Khoa
                {
                    if (iKieu == 1)
                    {
                        if (col.FieldName != "PhanMem" && col.FieldName != "GhiChu")
                            col.OptionsColumn.AllowEdit = false;
                    }
                    else
                    {
                        if (col.FieldName != "ThucLanh" && col.FieldName != "GhiChu")
                            col.OptionsColumn.AllowEdit = false;
                    }
                }
            }
        }

        private void btnXetPhuCap_Click(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cboPhuCap))
            {
                XtraMessageBox.Show("Bạn chưa chọn loại phụ cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc muốn xét phụ cấp hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sSQL = "";
                string sReplace10 = "Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND Thang=" + cnn.sNull2Int(txtThang.uValue);
                string sReplace20 = " 1 = 1 AND ";
                if (!cnn.bComboIsNull(cbxCoSo))
                {
                    sReplace20 += "NS_NhanSu.CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
                }
                if (!cnn.bComboIsNull(cbxPhanHe))
                {
                    sReplace20 += "NS_NhanSu.PHANHE=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
                } 
                if (!cnn.bComboIsNull(cbxPhongBan))
                {
                    sReplace20 += "NS_NhanSu.PhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
                }
                sReplace20 = sReplace20.Substring(0, sReplace20.Length - 4);
                DataTable DT = new DataTable();
                switch (cnn.sNull2Int(cboPhuCap.uEditValue))
                {
                    case 0:
                        dtg.sKEY = sKEYTRUONG;
                        sSQL = cnn.GetSQLString(sKEYTRUONG);
                        sSQL = sSQL.Replace("1 = 0", sReplace10).Replace("2 = 0", sReplace20);
                        DT = cnn.DT_DataTable(sSQL);
                        dtg.uDataSource = DT;
                        EditColumn(0);
                        break;
                    case 1:
                        dtg.sKEY = sKEYKHOA;
                        sSQL = cnn.GetSQLString(sKEYKHOA);
                        sSQL = sSQL.Replace("1 = 0", sReplace10).Replace("2 = 0", sReplace20);
                        DT = cnn.DT_DataTable(sSQL);
                        foreach (DataRow r in DT.Rows)
                        {
                            r["TongCong"] = cnn.sNull2Number(r["PhanMem"]) + cnn.sNull2Number(r["ThanhTien"]);
                            r["TienThueTNCN"] = TinhThue(cnn.sNull2Number(r["TongCong"]), cnn.sNull2Number(r["PTThueTNCN"]));
                            r["ThucLanh"] = cnn.sNull2Number(r["TongCong"]) - cnn.sNull2Number(r["TienThueTNCN"]);
                        }
                        dtg.uDataSource = DT;
                        EditColumn(1);
                        break;
                    case 2:
                        dtg.sKEY = sKEYKHAC_DT;
                        sSQL = cnn.GetSQLString(sKEYKHAC_DT);
                        sSQL = sSQL.Replace("1 = 0", sReplace10).Replace("2 = 0", sReplace20);
                        DT = cnn.DT_DataTable(sSQL);
                        dtg.uDataSource = DT;
                        EditColumn(2);
                        break;
                    case 5:
                        dtg.sKEY = sKEYPTNK;
                        sSQL = cnn.GetSQLString(sKEYPTNK);
                        sSQL = sSQL.Replace("1 = 0", sReplace10).Replace("2 = 0", sReplace20);
                        DT = cnn.DT_DataTable(sSQL);
                        dtg.uDataSource = DT;
                        EditColumn(0);
                        break;
                    case 6:
                        dtg.sKEY = sKEYDOCHAI;
                        sSQL = cnn.GetSQLString(sKEYDOCHAI);
                        sSQL = sSQL.Replace("1 = 0", sReplace10).Replace("2 = 0", sReplace20);
                        DT = cnn.DT_DataTable(sSQL);
                        dtg.uDataSource = DT;
                        EditColumn(0);
                        break;
                    default:
                        dtg.sKEY = sKEYKHAC;
                        sSQL = cnn.GetSQLString(sKEYKHAC);
                        sSQL = sSQL.Replace("1 = 0", sReplace10).Replace("2 = 0", sReplace20);
                        DT = cnn.DT_DataTable(sSQL);
                        dtg.uDataSource = DT;
                        EditColumn(2);
                        break;
                }
            }
        }

        private decimal TinhThue(decimal dTienChiuThue, decimal dPhanTram)
        {
            decimal dTongTienThue = 0;
            if (dTienChiuThue > 1000000)
            {
                dTongTienThue = dTienChiuThue * (dPhanTram / 100);
            }
            return dTongTienThue;
        }
        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cboPhuCap))
            {
                XtraMessageBox.Show("Bạn chưa chọn loại phụ cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sSQL = "";
            string sCond = "ISNULL(ThucLanh,0)>0 AND Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND ";
            if (!cnn.bComboIsNull(cbxCoSo))
            {
                sCond += "NS_NhanSu.CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxPhanHe))
            {
                sCond += "NS_NhanSu.PHANHE=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            }
            if (!cnn.bComboIsNull(cbxPhongBan))
            {
                sCond += "NS_NhanSu.PhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
            }
            sCond = sCond.Substring(0, sCond.Length - 4);

            DataTable DT = new DataTable();
            BaoCaoTK.frmViewReport frm;
            switch (cnn.sNull2Int(cboPhuCap.uEditValue))
            {
                case 0:
                    //dtg.sKEY = sKEYTRUONG;
                    sSQL = cnn.GetSQLString("INBANGPHUCAPTRUONG");
                    sSQL = sSQL.Replace("1 = 0", sCond);
                    DT = cnn.DT_DataTable(sSQL);
                    frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BangPhuCapTruong.repx", DT);
                    frm.iNam = cnn.sNull2Int(txtNam.uValue);
                    frm.iThang = cnn.sNull2Int(txtThang.uValue);
                    if (!cnn.bComboIsNull(cbxCoSo))
                        frm.sCoSo = cbxCoSo.uText;
                    if (!cnn.bComboIsNull(cbxPhongBan))
                        frm.sPhongBan = cbxPhongBan.uText;
                    frm.Show();
                    break;
                case 1:
                    //dtg.sKEY = sKEYKHOA;
                    sSQL = cnn.GetSQLString("INBANGPHUCAPKHOA");
                    sSQL = sSQL.Replace("1 = 0", sCond);
                    DT = cnn.DT_DataTable(sSQL);
                    frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BangPhuCapKhoa.repx", DT);
                    frm.iNam = cnn.sNull2Int(txtNam.uValue);
                    frm.iThang = cnn.sNull2Int(txtThang.uValue);
                    if (!cnn.bComboIsNull(cbxCoSo))
                        frm.sCoSo = cbxCoSo.uText;
                    if (!cnn.bComboIsNull(cbxPhongBan))
                        frm.sPhongBan = cbxPhongBan.uText;
                    frm.Show();
                    break;
                case 5:
                    sSQL = cnn.GetSQLString("INBANGPHUCAPPTNK");
                    sSQL = sSQL.Replace("1 = 0", sCond);
                    DT = cnn.DT_DataTable(sSQL);
                    frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BangPhuCapTruongPTNK.repx", DT);
                    frm.iNam = cnn.sNull2Int(txtNam.uValue);
                    frm.iThang = cnn.sNull2Int(txtThang.uValue);
                    if (!cnn.bComboIsNull(cbxCoSo))
                        frm.sCoSo = cbxCoSo.uText;
                    if (!cnn.bComboIsNull(cbxPhongBan))
                        frm.sPhongBan = cbxPhongBan.uText;
                    frm.Show();
                    break;
                case 6:
                    sSQL = cnn.GetSQLString("INBANGPHUCAPDOCHAI");
                    sSQL = sSQL.Replace("1 = 0", sCond);
                    DT = cnn.DT_DataTable(sSQL);
                    frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BangPhuCapDocHai.repx", DT);
                    frm.iNam = cnn.sNull2Int(txtNam.uValue);
                    frm.iThang = cnn.sNull2Int(txtThang.uValue);
                    if (!cnn.bComboIsNull(cbxCoSo))
                        frm.sCoSo = cbxCoSo.uText;
                    if (!cnn.bComboIsNull(cbxPhongBan))
                        frm.sPhongBan = cbxPhongBan.uText;
                    frm.Show();
                    break;
                default:
                    if (!cnn.bComboIsNull(cboPhuCap))
                    {
                        sCond += "AND NS_BangPhuCapKhac.MaPhuCap =N'" + cnn.sNull2String(cboPhuCap.uEditValue) + "' AND ";
                    }
                    sCond = sCond.Substring(0, sCond.Length - 4);
                    //dtg.sKEY = sKEYKHAC;
                    DataTable dt = dtg.GetDataSource();
                    Decimal TongThucLanh = 0;
                    foreach(DataRow r in dt.Rows)
                    {
                            TongThucLanh += cnn.sNull2Number(r["ThucLanh"]); 
                    }
                    sSQL = cnn.GetSQLString("INBANGPHUCAPKHAC");
                    sSQL = sSQL.Replace("1 = 0", sCond);
                    DT = cnn.DT_DataTable(sSQL);
                    frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BangPhuCapKhac.repx", DT);
                    frm.iNam = cnn.sNull2Int(txtNam.uText);
                    frm.iThang = cnn.sNull2Int(txtThang.uText);
                    BSC_Class.Doctien doctien = new BSC_HRM.NET.BSC_Class.Doctien();
                    frm.sSoTienBangChu = doctien.Convert_NumtoText(TongThucLanh.ToString());
                    if (!cnn.bComboIsNull(cbxCoSo))
                        frm.sCoSo = cbxCoSo.uText;
                    if (!cnn.bComboIsNull(cbxPhongBan))
                        frm.sPhongBan = cbxPhongBan.uText;
                    if (!cnn.bComboIsNull(cboPhuCap))
                        frm.sPhuCap = cboPhuCap.uText;
                    frm.Show();
                    break;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cboPhuCap))
            {
                XtraMessageBox.Show("Bạn chưa chọn loại phụ cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable DT = dtg.GetDataSource();
            if (DT != null && DT.Rows.Count > 0)
            {
                if (XtraMessageBox.Show("Bạn có chắc muốn lưu bảng phụ cấp hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Cursor = Cursors.Default;
                    Hashtable Val = new Hashtable();
                    Hashtable Cond = new Hashtable();
                    cnn.BeginTransaction();
                    try
                    {
                        foreach (DataRow r in DT.Rows)
                        {
                            Cond.Clear();
                            Val.Clear();
                            Cond.Add("Thang", cnn.sNull2Int(txtThang.uValue));
                            Cond.Add("Nam", cnn.sNull2Int(txtNam.uValue));
                            Cond.Add("NhanSu", cnn.sNull2Int(r["NhanSu"]));

                            switch (cnn.sNull2Int(cboPhuCap.uEditValue))
                            {
                                case 0:
                                    Val.Add("HeSo", r["HeSo"]);
                                    Val.Add("ThanhTien", r["ThanhTien"]);
                                    Val.Add("TongCong", r["TongCong"]);
                                    Val.Add("ThucLanh", r["ThucLanh"]);
                                    Val.Add("GhiChu", r["GhiChu"]);
                                    Val.Add("BoSung", r["BoSung"]);
                                    if (cnn.SelectRows(Cond, "NS_BangPhuCapTruong").Rows.Count > 0)
                                    {
                                        cnn.UpdateRows(Val, Cond, "NS_BangPhuCapTruong");
                                    }
                                    else
                                    {
                                        Val.Add("Thang", cnn.sNull2Int(txtThang.uValue));
                                        Val.Add("Nam", cnn.sNull2Int(txtNam.uValue));
                                        Val.Add("NhanSu", cnn.sNull2Int(r["NhanSu"]));
                                        cnn.InsertNewRow(Val, "NS_BangPhuCapTruong");
                                    }
                                    break;
                                case 1:
                                    Val.Add("HeSo", r["HeSo"]);
                                    Val.Add("ThanhTien", r["ThanhTien"]);
                                    Val.Add("TongCong", r["TongCong"]);
                                    Val.Add("ThucLanh", r["ThucLanh"]);
                                    Val.Add("GhiChu", r["GhiChu"]);
                                    Val.Add("PhanMem", r["PhanMem"]);
                                    Val.Add("PTThueTNCN", r["PTThueTNCN"]);
                                    Val.Add("TienThueTNCN", r["TienThueTNCN"]);
                                    if (cnn.SelectRows(Cond, "NS_BangPhuCapKhoa").Rows.Count > 0)
                                    {
                                        cnn.UpdateRows(Val, Cond, "NS_BangPhuCapKhoa");
                                    }
                                    else
                                    {
                                        Val.Add("Thang", cnn.sNull2Int(txtThang.uValue));
                                        Val.Add("Nam", cnn.sNull2Int(txtNam.uValue));
                                        Val.Add("NhanSu", cnn.sNull2Int(r["NhanSu"]));
                                        cnn.InsertNewRow(Val, "NS_BangPhuCapKhoa");
                                    }
                                    break;
                                case 5:
                                    Val.Add("HeSo", r["HeSo"]);
                                    Val.Add("ThanhTien", r["ThanhTien"]);
                                    Val.Add("TongCong", r["TongCong"]);
                                    Val.Add("ThucLanh", r["ThucLanh"]);
                                    Val.Add("GhiChu", r["GhiChu"]);
                                    Val.Add("BoSung", r["BoSung"]);
                                    if (cnn.SelectRows(Cond, "NS_BangPhuCapPTNK").Rows.Count > 0)
                                    {
                                        cnn.UpdateRows(Val, Cond, "NS_BangPhuCapPTNK");
                                    }
                                    else
                                    {
                                        Val.Add("Thang", cnn.sNull2Int(txtThang.uValue));
                                        Val.Add("Nam", cnn.sNull2Int(txtNam.uValue));
                                        Val.Add("NhanSu", cnn.sNull2Int(r["NhanSu"]));
                                        cnn.InsertNewRow(Val, "NS_BangPhuCapPTNK");
                                    }
                                    break;
                                case 6:
                                    Val.Add("ThucLanh", r["ThucLanh"]);
                                    Val.Add("GhiChu", r["GhiChu"]);
                                    Val.Add("HeSo", r["HeSo"]);
                                    Val.Add("ThanhTien", r["ThanhTien"]);
                                    Cond.Add("MaPhuCap", cnn.sNull2String(cboPhuCap.uEditValue));
                                    if (cnn.SelectRows(Cond, "NS_BangPhuCapKhac").Rows.Count > 0)
                                        cnn.UpdateRows(Val, Cond, "NS_BangPhuCapKhac");
                                    else
                                    {
                                        Val.Add("MaPhuCap", cnn.sNull2String(cboPhuCap.uEditValue));
                                        Val.Add("Thang", cnn.sNull2Int(txtThang.uValue));
                                        Val.Add("Nam", cnn.sNull2Int(txtNam.uValue));
                                        Val.Add("NhanSu", cnn.sNull2Int(r["NhanSu"]));
                                        cnn.InsertNewRow(Val, "NS_BangPhuCapKhac");
                                    }
                                    break;
                                default:
                                    Val.Add("ThucLanh", r["ThucLanh"]);
                                    Val.Add("GhiChu", r["GhiChu"]);
                                    Cond.Add("MaPhuCap", cnn.sNull2String(cboPhuCap.uEditValue));
                                    if (cnn.SelectRows(Cond, "NS_BangPhuCapKhac").Rows.Count > 0)
                                        cnn.UpdateRows(Val, Cond, "NS_BangPhuCapKhac");
                                    else
                                    {
                                        Val.Add("MaPhuCap", cnn.sNull2String(cboPhuCap.uEditValue));
                                        Val.Add("Thang", cnn.sNull2Int(txtThang.uValue));
                                        Val.Add("Nam", cnn.sNull2Int(txtNam.uValue));
                                        Val.Add("NhanSu", cnn.sNull2Int(r["NhanSu"]));
                                        cnn.InsertNewRow(Val, "NS_BangPhuCapKhac");
                                    }
                                    break;
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

        private void dtg_uCellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (cnn.sNull2Int(cboPhuCap.uEditValue) == 0)
            {
                if (e.Column.FieldName == "BoSung")
                {
                    dtg.CurRow["TongCong"] = dtg.CurRow["ThucLanh"] = cnn.sNull2Number(dtg.CurRow["BoSung"]) + cnn.sNull2Number(dtg.CurRow["ThanhTien"]);
                }
            }
            else
            {
                if (cnn.sNull2Int(cboPhuCap.uEditValue) == 1)
                {
                    if (e.Column.FieldName == "PhanMem")
                    {
                        dtg.CurRow["TongCong"] = cnn.sNull2Number(dtg.CurRow["PhanMem"]) + cnn.sNull2Number(dtg.CurRow["ThanhTien"]);
                        dtg.CurRow["TienThueTNCN"] = TinhThue(cnn.sNull2Number(dtg.CurRow["TongCong"]), cnn.sNull2Number(dtg.CurRow["PTThueTNCN"]));
                        dtg.CurRow["ThucLanh"] = cnn.sNull2Number(dtg.CurRow["TongCong"]) - cnn.sNull2Number(dtg.CurRow["TienThueTNCN"]);
                        //dtg.CurRow["TongCong"] = dtg.CurRow["ThucLanh"] = cnn.sNull2Number(dtg.CurRow["PhanMem"]) + cnn.sNull2Number(dtg.CurRow["ThanhTien"]);
                    }
                }
                else
                {
                    if (e.Column.FieldName == "ThucLanh")
                    {
                        dtg.CurRow["ThucLanh"] = cnn.sNull2Number(dtg.CurRow["ThucLanh"]);
                    }
                }
            }

        }

        private void btnNhapDongLoat_Click(object sender, EventArgs e)
        {
            try
            {
                int[] iRow = dtg.uGetSelectRows();
                if (iRow.Length > 0)
                {
                    DevExpress.XtraGrid.Columns.GridColumn col = new DevExpress.XtraGrid.Columns.GridColumn();
                    if (cnn.sNull2Int(cboPhuCap.uEditValue) == 0)
                        col.FieldName = "BoSung";
                    else
                    {
                        if (cnn.sNull2Int(cboPhuCap.uEditValue) == 1)
                        {
                            col.FieldName = "PhanMem";
                        }
                        else
                        {
                            col.FieldName = "ThucLanh";
                        }
                    }
                    for (int i = 0; i < iRow.Length; i++)
                    {
                        dtg.uSetRowCellValue(iRow[i], col, cnn.sNull2Number(txtSoTien.uText));
                    }
                    RefeshGrid();
                }
                else
                {
                    DataTable DT = dtg.GetDataSource();
                    if (DT != null && DT.Rows.Count > 0)
                    {
                        foreach (DataRow r in DT.Rows)
                        {
                            if (cnn.sNull2Int(cboPhuCap.uEditValue) == 0)
                            {
                                r["BoSung"] = cnn.sNull2Number(txtSoTien.uText);
                                r["TongCong"] = r["ThucLanh"] = cnn.sNull2Number(r["BoSung"]) + cnn.sNull2Number(r["ThanhTien"]);
                            }
                            else
                            {
                                if (cnn.sNull2Int(cboPhuCap.uEditValue) == 1)
                                {
                                    r["PhanMem"] = cnn.sNull2Number(txtSoTien.uText);
                                    r["TongCong"] = r["ThucLanh"] = cnn.sNull2Number(r["PhanMem"]) + cnn.sNull2Number(r["ThanhTien"]);
                                }
                                else
                                {
                                    r["ThucLanh"] = cnn.sNull2Number(txtSoTien.uText);
                                    r["ThucLanh"] = cnn.sNull2Number(r["ThucLanh"]);

                                }
                            }
                        }
                    }
                    dtg.uDataSource = DT;
                    EditColumn(cnn.sNull2Int(cboPhuCap.uEditValue));
                }
            }
            catch { }
        }
        private void RefeshGrid()
        {
            DataTable DT = dtg.GetDataSource();
            if (DT != null && DT.Rows.Count > 0)
            {
                foreach (DataRow r in DT.Rows)
                {
                    if (cnn.sNull2Int(cboPhuCap.uEditValue) == 0)
                    {
                        r["TongCong"] = r["ThucLanh"] = cnn.sNull2Number(r["BoSung"]) + cnn.sNull2Number(r["ThanhTien"]);
                    }
                    else
                    {
                        if (cnn.sNull2Int(cboPhuCap.uEditValue) == 1)
                        {
                            r["TongCong"] = r["ThucLanh"] = cnn.sNull2Number(r["PhanMem"]) + cnn.sNull2Number(r["ThanhTien"]);
                        }
                        else
                        {
                            r["ThucLanh"] = cnn.sNull2Number(r["ThucLanh"]);
                        }
                    }
                }
                dtg.uDataSource = DT;
                EditColumn(cnn.sNull2Int(cboPhuCap.uEditValue));
            }
        }

        private void txtSoTien_uKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnNhapDongLoat_Click(null, null);
        }
    }
}