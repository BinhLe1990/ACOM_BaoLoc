using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DELFI_WHM.NET.DELFI_Class;
using System.Collections;

namespace DELFI_WHM.NET.NhanSu
{
    public partial class frmXetThiDua : DevExpress.XtraEditors.XtraForm
    {
        public frmXetThiDua()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            dtg.sKEY = sKeyCaNhan;
        }
        DELFI_Class.DELFIConnection cnn = new DELFIConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKeyCaNhan = "XetThiDuaCaNhan";
        string sKeyTapThe = "XetThiDuaTapThe";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            if (raLoai.EditValue.ToString() == "0")
            {
                dtg.sKEY = sKeyCaNhan;
                string sSQL = cnn.GetSQLString(sKeyCaNhan);
                sSQL = sSQL.Replace("1=1", "Nam=" + txtNam.uValue);
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
                    sSQL = "Select * from (" + sSQL + ")A where " + sWhere + " Order by Ten";
                }
                else
                {
                    sSQL = "Select * from (" + sSQL + ")A Order by Ten";
                }
                DataTable DT = cnn.DT_DataTable(sSQL);
                dtg.uDataSource = DT;
                DataTable dt = cnn.SelectRows("SELECT MaDanhHieuThiDua,TenDanhHieuThiDua FROM  dbo.DM_DanhHieuThiDua WHERE IsTapThe=0");
                dtg.Columns["MaDanhHieuThiDua"].ColumnEdit = clsRun.AddReference(dt, "TenDanhHieuThiDua", "MaDanhHieuThiDua");

                DataTable dt2 = cnn.SelectRows("SELECT * FROM  dbo.DM_CapKhenThuong");
                dtg.Columns["MaCapKhenThuong"].ColumnEdit = clsRun.AddReference(dt2, "TenCapKhenThuong", "MaCapKhenThuong");

                foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
                {
                    if (col.FieldName != "MaDanhHieuThiDua" && col.FieldName != "MaCapKhenThuong" && col.FieldName != "GhiChu" && col.FieldName != "SoQuyetDinh" && col.FieldName != "NgayQD")
                        col.OptionsColumn.AllowEdit = false;
                }
            }
            else
            {
                dtg.sKEY = sKeyTapThe;
                string sSQL = cnn.GetSQLString(sKeyTapThe);
                sSQL = sSQL.Replace("1=1", "Nam=" + txtNam.uValue);
                string sWhere = "";
                if (!cnn.bComboIsNull(cbxPhongBan))
                    sWhere += "PhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
                if (sWhere != "")
                {
                    sWhere = sWhere.Substring(0, sWhere.Length - 4);
                    sSQL = "Select * from (" + sSQL + ")A where " + sWhere;
                }
                DataTable DT = cnn.DT_DataTable(sSQL);
                dtg.uDataSource = DT;
                DataTable dt = cnn.SelectRows("SELECT MaDanhHieuThiDua,TenDanhHieuThiDua FROM  dbo.DM_DanhHieuThiDua WHERE IsTapThe=1");
                dtg.Columns["MaDanhHieuThiDua"].ColumnEdit = clsRun.AddReference(dt, "TenDanhHieuThiDua", "MaDanhHieuThiDua");

                DataTable dt2 = cnn.SelectRows("SELECT * FROM  dbo.DM_CapKhenThuong");
                dtg.Columns["MaCapKhenThuong"].ColumnEdit = clsRun.AddReference(dt2, "TenCapKhenThuong", "MaCapKhenThuong");

                foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
                {
                    if (col.Name != dtg.Columns["MaDanhHieuThiDua"].Name && col.Name != dtg.Columns["MaCapKhenThuong"].Name && col.Name != dtg.Columns["GhiChu"].Name && col.Name!="SoQuyetDinh" && col.Name!="NgayQD")
                        col.OptionsColumn.AllowEdit = false;
                }
            }
        }

        private void frmXetThiDua_Load(object sender, EventArgs e)
        {
            txtNam.uValue = cnn.GetDateServer().Year;
        }

        private void btnXetDongLoat_Click(object sender, EventArgs e)
        {
            if (raLoai.EditValue.ToString() == "0")
            {
                DataTable dt = dtg.GetDataSource();
                foreach (DataRow r in dt.Rows)
                {
                    r["MaDanhHieuThiDua"] = "1";
                }
            }
            else
            {
                DataTable dt = dtg.GetDataSource();
                foreach (DataRow r in dt.Rows)
                {
                    r["MaDanhHieuThiDua"] = "3";
                }
            }
        }

        private void raLoai_EditValueChanged(object sender, EventArgs e)
        {
            btnLocDanhSach_Click(null, null);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Hashtable Val = new Hashtable();
            Hashtable Cond = new Hashtable();
            DataTable DT = dtg.GetDataSource();
            if (DT == null) return;
            if (DT.Rows.Count == 0) return;
            cnn.BeginTransaction();
            try
            {
                if (raLoai.EditValue.ToString() == "0")
                {
                    foreach (DataRow r in DT.Rows)
                    {
                        Cond.Clear();
                        Cond.Add("Nam", txtNam.uValue);
                        Cond.Add("NhanSu", r["NHANSU"]);
                        cnn.DeleteRows(Cond, "NS_XetThiDuaCaNhan");
                        Val.Clear();
                        Val.Add("Nam", txtNam.uValue);
                        Val.Add("NHANSU", r["NHANSU"]);
                        Val.Add("MaDanhHieuThiDua", r["MaDanhHieuThiDua"]);
                        Val.Add("MaCapKhenThuong", r["MaCapKhenThuong"]);
                        Val.Add("SoQuyetDinh", r["SoQuyetDinh"]);
                        Val.Add("NgayQD", r["NgayQD"]);
                        Val.Add("GhiChu", r["GhiChu"]);
                        cnn.InsertNewRow(Val, "NS_XetThiDuaCaNhan");
                    }
                }
                else
                {
                    foreach (DataRow r in DT.Rows)
                    {
                        Cond.Clear();
                        Cond.Add("Nam", txtNam.uValue);
                        Cond.Add("PHONGBAN", r["PHONGBAN"]);
                        cnn.DeleteRows(Cond, "NS_XetThiDuaTapThe");
                        Val.Clear();
                        Val.Add("Nam", txtNam.uValue);
                        Val.Add("PHONGBAN", r["PHONGBAN"]);
                        Val.Add("MaDanhHieuThiDua", r["MaDanhHieuThiDua"]);
                        Val.Add("MaCapKhenThuong", r["MaCapKhenThuong"]);
                        Val.Add("SoQuyetDinh", r["SoQuyetDinh"]);
                        Val.Add("NgayQD", r["NgayQD"]);
                        Val.Add("GhiChu", r["GhiChu"]);
                        cnn.InsertNewRow(Val, "NS_XetThiDuaTapThe");
                    }
                }
                cnn.EndTransaction();
                XtraMessageBox.Show("Cập nhật thành công", "Xét thi đua", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                cnn.RollbackTransaction();
                XtraMessageBox.Show("Cập nhật thất bại :\n"+ex.Message, "Xét thi đua", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            if (raLoai.EditValue.ToString() == "0")
            {
                bar_ChienSiThiDua.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                bar_LaoDongTienTien.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                bar_Tatca.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else
            {
                bar_ChienSiThiDua.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                bar_LaoDongTienTien.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                bar_Tatca.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            popupMenu1.ShowPopup(MousePosition);
        }
        private void bar_LaoDongTienTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (raLoai.EditValue.ToString() == "0")
            {
                string sSQL = cnn.GetSQLString(sKeyCaNhan);
                sSQL = sSQL.Replace("1=1", "Nam=" + txtNam.uValue);
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
                    sSQL = "Select * from (" + sSQL + ")A where " + sWhere + " AND MaDanhHieuThiDua='1'";
                }
                else
                {
                    sSQL = "Select * from (" + sSQL + ")A WHERE MaDanhHieuThiDua='1'";
                }
                DataTable DT = cnn.DT_DataTable(sSQL);
                int iCapTruong = 0;
                int iCapTinh = 0;
                foreach(DataRow r in DT.Rows)
                {
                    if (cnn.sNull2Int(r["MaCapKhenThuong"]) == 1)
                        iCapTruong++;
                    else
                        if (cnn.sNull2Int(r["MaCapKhenThuong"]) == 2)
                         iCapTinh++;
                }
                string[] CapKhen = new string[] {iCapTruong.ToString(),iCapTinh.ToString() };
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\GV_DSCaNhanDuocCongNhanDanhHieu_LDTT.repx", DT);
                frm.iNamHoc = (int)txtNam.uValue;
                frm.bXoayDiem = true;
                frm.MonHoc = CapKhen;
                frm.Show();
            }
            else
            {
                string sSQL = cnn.GetSQLString(sKeyTapThe);
                sSQL = sSQL.Replace("1=1", "Nam=" + txtNam.uValue);
                string sWhere = "";
                if (!cnn.bComboIsNull(cbxPhongBan))
                    sWhere += "PhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
                if (sWhere != "")
                {
                    sWhere = sWhere.Substring(0, sWhere.Length - 4);
                    sSQL = "Select * from (" + sSQL + ")A where " + sWhere + " AND MaDanhHieuThiDua='3'";
                }
                else
                {
                    sSQL = "Select * from (" + sSQL + ")A WHERE MaDanhHieuThiDua='3'";
                }
                DataTable DT = cnn.DT_DataTable(sSQL);
                int iCapTruong = 0;
                int iCapTinh = 0;
                foreach (DataRow r in DT.Rows)
                {
                    if (cnn.sNull2Int(r["MaCapKhenThuong"]) == 1)
                        iCapTruong++;
                    else
                        if (cnn.sNull2Int(r["MaCapKhenThuong"]) == 2)
                            iCapTinh++;
                }
                string[] CapKhen = new string[] { iCapTruong.ToString(), iCapTinh.ToString() };
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\GV_DSTapTheCongNhanDanhHieu_TD.repx", DT);
                frm.iNamHoc = (int)txtNam.uValue;
                frm.bXoayDiem = true;
                frm.MonHoc = CapKhen;
                frm.Show();
            }
        }

        private void bar_ChienSiThiDua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (raLoai.EditValue.ToString() == "0")
            {
                string sSQL = cnn.GetSQLString(sKeyCaNhan);
                sSQL = sSQL.Replace("1=1", "Nam=" + txtNam.uValue);
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
                    sSQL = "Select * from (" + sSQL + ")A where " + sWhere + " AND MaDanhHieuThiDua='2'";
                }
                else
                {
                    sSQL = "Select * from (" + sSQL + ")A WHERE MaDanhHieuThiDua='2'";
                }
                DataTable DT = cnn.DT_DataTable(sSQL);
                int iCapTruong = 0;
                int iCapTinh = 0;
                foreach (DataRow r in DT.Rows)
                {
                    if (cnn.sNull2Int(r["MaCapKhenThuong"]) == 1)
                        iCapTruong++;
                    else
                        if (cnn.sNull2Int(r["MaCapKhenThuong"]) == 2)
                            iCapTinh++;
                }
                string[] CapKhen = new string[] { iCapTruong.ToString(), iCapTinh.ToString() };
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\GV_DSCaNhanDuocCongNhanDanhHieu_CSTD.repx", DT);
                frm.iNamHoc = (int)txtNam.uValue;
                frm.bXoayDiem = true;
                frm.MonHoc = CapKhen;
                frm.Show();
            }
            else
            {
                //string sSQL = cnn.GetSQLString(sKeyTapThe);
                //sSQL = sSQL.Replace("1=1", "NamHoc=" + uLop1.txtNamHoc.iYear);
                //if (!cnn.bComboIsNull(uLop1.cbxKhoa))
                //{
                //    sSQL = "Select * from (" + sSQL + ")A where MaKhoa=N'" + cnn.sNull2String(uLop1.cbxKhoa.uEditValue) + "' AND MaDanhHieuThiDua IS NOT NULL ";
                //}
                //else
                //{
                //    sSQL = "Select * from (" + sSQL + ")A where MaDanhHieuThiDua=3 ";
                //}
                //DataTable DT = cnn.DT_DataTable(sSQL);
                //BaoCaoTK.frmViewReport frm = new BSC_EMIS.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\.repx", DT);
                //frm.iNamHoc = uLop1.txtNamHoc.iYear;
                //frm.Show();
            }
        }

        private void bar_Tatca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }       
        
    }
}