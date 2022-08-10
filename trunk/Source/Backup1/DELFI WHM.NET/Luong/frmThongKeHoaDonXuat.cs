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
    public partial class frmThongKeHoaDonXuat : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKeHoaDonXuat()
        {
            InitializeComponent();
            clsrun.SetValueToControl(this);
            dtg.sKEY = sKEY;
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clsrun = new clsRun();
        string sKEY = "THONGKEHOADON";
        private void cbxPhanHe_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            string sSQL = cnn.GetSQLString(sKEY);
            string sCond = "NgayXuat>='" + dtpTuNgay.uDateTime.ToString("MM/dd/yyyy") + "' AND NgayXuat<='" + dtpDenNgay.uDateTime.ToString("MM/dd/yyyy") + "' AND ";
            if(!cnn.bComboIsNull(cbxCoSo))
                sCond += "NS_NhanSu.COSO=N'"+cnn.sNull2String(cbxCoSo.uEditValue)+"' AND ";
            if (!cnn.bComboIsNull(cbxPhanHe))
                sCond += "NS_NhanSu.PHANHE=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxPhongBan))
                sCond += "NS_NhanSu.PHONGBAN=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
            if (cnn.sNull2Int(raDangDung.EditValue) == 0)
            {
                sCond += "NS_HoaDonDo.Del=0 AND ";
            }
            else if (cnn.sNull2Int(raDangDung.EditValue) == 1)
            {
                sCond += "NS_HoaDonDo.Del=1 AND ";
            }
            else
            {
                sCond += "NS_HoaDonDo.Del>= 0 AND ";
            }
            if (chkChungTu.Checked) 
            {
                sCond = "";
                sCond += " NgayChungTu>='" + dtpChungTuTuNgay.uDateTime.ToString("MM/dd/yyyy") + "' AND NgayChungTu<='" + dtpChungTuDenNgay.uDateTime.ToString("MM/dd/yyyy") + "' AND ";
            }
            if (txtTuSoHoaDon.Text != "")
            {
                sCond += " NS_HoaDonDo.SoHoaDon >=" + Convert.ToInt32(txtTuSoHoaDon.Text) + " AND ";
            }
            if (txtSoHoDonDen.Text != "")
            {
                sCond += " NS_HoaDonDo.SoHoaDon <=" + Convert.ToInt32(txtSoHoDonDen.Text) + " AND ";
            }

            sCond = sCond.Substring(0, sCond.Length - 4);
            sSQL = sSQL.Replace("1 = 0", sCond);
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = DT;
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
            {
                if (col.FieldName != "Chon"&&col.FieldName!="SoChungTu"&&col.FieldName!="NgayChungTu")
                    col.OptionsColumn.AllowEdit = false;
            }
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int iHoaDon = cnn.sNull2Int(dtg.CurRow["HoaDon"]);
                if (iHoaDon > 0)
                {
                    frmViewHoaDon frm = new frmViewHoaDon();
                    frm.iHoaDon = iHoaDon;
                    frm.ShowDialog();
                }
            }
            catch
            { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            if (DT != null && DT.Rows.Count > 0)
            {
                DataRow[] Row = DT.Select("Chon=1");
                if (Row.Length > 0)
                {
                    if (XtraMessageBox.Show("Bạn có chắc muốn xóa " + Row.Length + " hóa đơn không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (cnn.sNull2Int(raDangDung.EditValue) == 0)
                        {
                            cnn.BeginTransaction();
                            try
                            {
                                foreach(DataRow r in Row)
                                {
                                    cnn.SQL_ExecuteNonQuery("UPDATE NS_HOADONDO SET DEL=1 WHERE HOADON=" + cnn.sNull2Int(r["HoaDon"]));
                                }
                                cnn.EndTransaction();
                                btnLocDanhSach_Click(null, null);
                            }
                            catch(Exception ex)
                            {
                                cnn.RollbackTransaction();
                                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (cnn.sNull2Int(raDangDung.EditValue) == 1)
                        {
                            cnn.BeginTransaction();
                            try
                            {
                                foreach (DataRow r in Row)
                                {
                                    cnn.SQL_ExecuteNonQuery("DELETE NS_HOADONDO WHERE HOADON=" + cnn.sNull2Int(r["HoaDon"]));
                                    cnn.SQL_ExecuteNonQuery("DELETE NS_ChiTietHoaDon WHERE NhanSu=" + cnn.sNull2Int(r["NhanSu"]) + " And Thang=" + cnn.sNull2Int(r["Thang"]) + " AND Nam=" + cnn.sNull2Int(r["Nam"]));
                                    cnn.SQL_ExecuteNonQuery("UPDATE NS_ThuLaoGiangDay set IsDaXuatHD=0  WHERE NhanSu=" + cnn.sNull2Int(r["NhanSu"]) + " And Thang=" + cnn.sNull2Int(r["Thang"]) + " AND Nam=" + cnn.sNull2Int(r["Nam"]));
                                }
                                cnn.EndTransaction();
                                btnLocDanhSach_Click(null, null);
                            }
                            catch (Exception ex)
                            {
                                cnn.RollbackTransaction();
                                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bạn chưa chọn hóa đơn để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInNhanh_Click(object sender, EventArgs e)
        {
            popupMenu1.ShowPopup(MousePosition);
            
        }       

        private void InHoaDon(int iHD)
        {
            string sSQL = cnn.GetSQLString("INHOADONDON");
            sSQL = sSQL.Replace("1 = 0", "HoaDon=" + iHD);
            DataTable DT = cnn.DT_DataTable(sSQL);
            BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\HoaDonDo.repx", DT);
            frm.InNhanh(true);
        }

        private void btnInDanhSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cnn.sNull2Int(raDangDung.EditValue) == 2)
            {
                DataTable DT = dtg.GetDataSource();
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\DanhSachHoaDon_Mau2.repx", DT);
                frm.sTime_FromTo = clsrun.sTime(dtpTuNgay.uValue, dtpDenNgay.uValue);
                frm.Show();
            }
            else
            {
                DataTable DT = dtg.GetDataSource();
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\DanhSachHoaDon.repx", DT);
                frm.sTime_FromTo = clsrun.sTime(dtpTuNgay.uValue, dtpDenNgay.uValue);
                frm.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn in nhanh thông qua máy in hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;
                DataTable DT = dtg.GetDataSource();
                if (DT != null && DT.Rows.Count > 0)
                {
                    DataRow[] Row = DT.Select("Chon=1");
                    if (Row.Length > 0)
                    {
                        foreach (DataRow r in Row)
                        {
                            InHoaDon(cnn.sNull2Int(r["HoaDon"]));
                        }
                        this.Cursor = Cursors.Default;
                    }
                    else
                    {
                        this.Cursor = Cursors.Default;
                        XtraMessageBox.Show("Bạn chưa chọn hóa đơn để in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.Cursor = Cursors.Default;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            if (DT != null && DT.Rows.Count > 0)
            {
                cnn.BeginTransaction();
                try
                {
                    Hashtable Val = new Hashtable();
                    Hashtable Cond = new Hashtable();
                    foreach (DataRow r in DT.Rows)
                    {
                        Val.Clear();
                        Cond.Clear();
                        Cond.Add("HoaDon", r["HoaDon"]);
                        Val.Add("SoChungTu", r["SoChungTu"]);
                        Val.Add("NgayChungTu", r["NgayChungTu"]);
                        cnn.UpdateRows(Val, Cond, "NS_HoaDonDo");
                    }
                    cnn.EndTransaction();
                    XtraMessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    cnn.RollbackTransaction();
                    XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chkChungTu_CheckedChanged(object sender, EventArgs e)
        {
            groupControl1.Visible = chkChungTu.Checked;
        }

        private void dtg_uDataSourceChanged(object sender, EventArgs e)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
            {
                if (col.FieldName != "Chon")
                {
                    col.OptionsColumn.AllowEdit = false;
                }
            }
        }
    }
}