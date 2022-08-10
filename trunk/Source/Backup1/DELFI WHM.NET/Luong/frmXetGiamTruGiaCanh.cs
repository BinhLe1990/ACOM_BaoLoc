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
    public partial class frmXetGiamTruGiaCanh : DevExpress.XtraEditors.XtraForm
    {
        public frmXetGiamTruGiaCanh()
        {
            InitializeComponent();
            clsrun.SetValueToControl(this);
            dtg.sKEY = sKEY;
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clsrun = new clsRun();
        string sKEY = "GIAMTRUGIACANH";
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
        private void EditColum()
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
                if (col.FieldName != "SoNguoiPhuThuoc")
                    col.OptionsColumn.AllowEdit = false;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            string sSQL = cnn.GetSQLString(sKEY);
            string sReplace = " Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue) + " AND ";
            if(!cnn.bComboIsNull(cbxCoSo))
                sReplace += "NS_NhanSu.CoSo=N'"+cnn.sNull2String(cbxCoSo.uEditValue)+"' AND ";
            if (!cnn.bComboIsNull(cbxPhongBan))
                sReplace += "NS_NhanSu.PhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxDonVi))
                sReplace += "NS_NhanSu.DonVi=N'" + cnn.sNull2String(cbxDonVi.uEditValue) + "' AND ";
            sReplace = sReplace.Substring(0, sReplace.Length - 4);
            sSQL = sSQL.Replace("1 = 0", sReplace);
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = DT;
            EditColum();
        }

        private void btnXetGiamTru_Click(object sender, EventArgs e)
        {
            string sSQL = cnn.GetSQLString("XETGIAMTRUGIACANH");
            string sReplace10 = " Thang=" + cnn.sNull2Int(txtThang.uValue) + " AND Nam=" + cnn.sNull2Int(txtNam.uValue);
            string sReplace = "";
            if (!cnn.bComboIsNull(cbxCoSo))
                sReplace += "NS_NhanSu.CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxPhongBan))
                sReplace += "NS_NhanSu.PhongBan=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxDonVi))
                sReplace += "NS_NhanSu.DonVi=N'" + cnn.sNull2String(cbxDonVi.uEditValue) + "' AND ";
            if (sReplace != "")
            {
                sReplace = sReplace.Substring(0, sReplace.Length - 4);
                sSQL = sSQL.Replace("1 = 1", sReplace);
            }
            sSQL = sSQL.Replace("1 = 0", sReplace10);
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = DT;
            EditColum();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Hashtable Val = new Hashtable();
            Hashtable Cond = new Hashtable();
            DataTable DT = dtg.GetDataSource();
            if (DT != null && DT.Rows.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;
                cnn.BeginTransaction();
                try
                {
                    foreach (DataRow r in DT.Rows)
                    {
                        Cond.Clear();
                        Val.Clear();
                        Cond.Add("NhanSu", r["NhanSu"]);
                        Cond.Add("Thang", cnn.sNull2Int(txtThang.uValue));
                        Cond.Add("Nam", cnn.sNull2Int(txtNam.uValue));
                        if (cnn.SelectRows(Cond, "NS_GiamTruGiaCanh").Rows.Count > 0)
                        {
                            Val.Add("SoNguoiPhuThuoc", r["SoNguoiPhuThuoc"]);
                            cnn.UpdateRows(Val, Cond, "NS_GiamTruGiaCanh");
                        }
                        else
                        {
                            Cond.Add("SoNguoiPhuThuoc", r["SoNguoiPhuThuoc"]);
                            cnn.InsertNewRow(Cond, "NS_GiamTruGiaCanh");
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

        private void frmXetGiamTruGiaCanh_Load(object sender, EventArgs e)
        {
            txtNam.uValue = DateTime.Now.Year;
            txtThang.uValue = DateTime.Now.Month;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            int iThang = cnn.sNull2Int(txtThang.uValue) - 1;
            int iNam = cnn.sNull2Int(txtNam.uValue);
            if (cnn.sNull2Int(txtThang.uValue) == 1)
            {
                iThang = 12;
                iNam = iNam - 1;
            }
            string sSQL = "SELECT * FROM  dbo.NS_GiamTruGiaCanh WHERE Thang="+iThang+"  AND Nam="+iNam;
            DataTable DT_old = cnn.DT_DataTable(sSQL);
            if (DT_old != null && DT_old.Rows.Count > 0)
            {
                DataTable DT_New = dtg.GetDataSource();
                if (DT_New != null && DT_New.Rows.Count > 0)
                {
                    foreach (DataRow r in DT_New.Rows)
                    {
                        foreach (DataRow rr in DT_old.Rows)
                        {
                            if (cnn.sNull2Int(r["NhanSu"]) == cnn.sNull2Int(rr["NhanSu"]))
                                r["SoNguoiPhuThuoc"] = rr["SoNguoiPhuThuoc"];
                        }
                    }
                    dtg.uDataSource = DT_New;
                    XtraMessageBox.Show("Copy dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để copy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}