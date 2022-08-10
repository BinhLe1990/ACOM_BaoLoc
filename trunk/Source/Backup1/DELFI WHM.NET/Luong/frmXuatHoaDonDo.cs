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
    public partial class frmXuatHoaDonDo : DevExpress.XtraEditors.XtraForm
    {
        public frmXuatHoaDonDo()
        {
            InitializeComponent();
            clsrun.SetValueToControl(this);
            dtg.sKEY = "NS_LUONG_THULAOGIANGDAY";
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clsrun = new clsRun();        
        private int iHoaDon = 0;

        private int iNhanSu = 0;
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Control ctr in panelControl1.Controls)
            {
                ctr.Width = panelControl1.Width / panelControl1.Controls.Count;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            iHoaDon = 0;
            cnn.clearControl(this);
            iNhanSu = 0;
            LoadThuLaoGiangDay(iNhanSu);
            dtpNgayXuat.uDateTime = DateTime.Now;
            chkLuuVaIn.Checked = true;
        }

        
        private void InHoaDon()
        {
            string sSQL = cnn.GetSQLString("INHOADONDON");
            sSQL = sSQL.Replace("1 = 0", "HoaDon=" + iHoaDon);
            DataTable DT = cnn.DT_DataTable(sSQL);
            BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\HoaDonDo.repx", DT);
            frm.Show();
        }

        private void frmXuatHoaDonDo_Load(object sender, EventArgs e)
        {
            string sSQL = "Select KyHieu from DM_QuyenHoaDon where OK=1";
            DataTable DT = cnn.DT_DataTable(sSQL);
            cbxKyHieu.uDataSource = DT;
        }

        private void btnFindNS_Click(object sender, EventArgs e)
        {
            TimKiem.frmTimKiemNhanSu frm = new DELFI_WHM.NET.TimKiem.frmTimKiemNhanSu();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                iNhanSu = frm.iNhanSu;
                LoadNhanSu(iNhanSu);
                ListCMND.Visible = false;
            }
        }
        
        private void LoadNhanSu(int iNS)
        { 
            string sSQL="SELECT 	NHANSU,	MA,	HODEM+' '+TEN HOTEN,	SOCMND,	CASE WHEN GIOITINH=1 THEN N'Nam' ELSE N'Nữ' END GIOITINH,	MST,	DCLL,	DIENTHOAI,	DIDONG,	PHANHE,"+
	                    " CASE 		WHEN ISNULL(MST,' ')=' ' AND ISNULL(PHANHE,'')='04' THEN 20 		WHEN ISNULL(MST,' ')<>' ' AND ISNULL(PHANHE,'')='04' THEN 10 ELSE 0 END PTThue "+
                        " FROM  dbo.NS_NHANSU WHERE Del=0 AND NhanSu="+iNS;
            DataTable DT = cnn.DT_DataTable(sSQL);
            if (DT != null && DT.Rows.Count > 0)
            {
                txtMaSo.uText = cnn.sNull2String(DT.Rows[0]["MA"]);

                txtSoCMND.uText = cnn.sNull2String(DT.Rows[0]["SOCMND"]);
                txtHoTen.uText = cnn.sNull2String(DT.Rows[0]["HOTEN"]);
                txtGioiTinh.uText = cnn.sNull2String(DT.Rows[0]["GIOITINH"]);
                txtMaSoThue.uText = cnn.sNull2String(DT.Rows[0]["MST"]);
                txtDCLL.uText = cnn.sNull2String(DT.Rows[0]["DCLL"]);
                txtDiDong.uText = cnn.sNull2String(DT.Rows[0]["DIDONG"]);
                txtDienThoai.uText = cnn.sNull2String(DT.Rows[0]["DIENTHOAI"]);
                txtPTThue.uText = cnn.sNull2String(DT.Rows[0]["PTThue"]);
            }
        }

        private void txtMaSo_uValidated(object sender, EventArgs e)
        {
            if (txtMaSo.uText.Trim().Length > 0)
            {
                iNhanSu = cnn.sNull2Int(cnn.SQL_ExecuteScalar("Select NhanSu from NS_NhanSu where MA=N'"+txtMaSo.uText+"'"));
                if (iNhanSu > 0)
                {
                    LoadNhanSu(iNhanSu);
                    LoadThuLaoGiangDay(iNhanSu);
                }
                ListCMND.Visible = false;
            }
        }
        
        private void LoadThuLaoGiangDay(int iNhanS)
        {
            try
            {
                string sql = cnn.GetSQLString("NS_LUONG_THULAOGIANGDAY");
                sql = sql.Replace("000000000", iNhanS.ToString());
                DataTable dtb = cnn.SelectRows(sql);
                if (dtb != null)
                {
                    dtg.uDataSource  = dtb;
                }
                foreach (DataRow r in dtg.GetDataSource().Rows)
                {
                    r["OK"] = 1;
                }
                dtg_uCellValueChanged(dtg, new DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs(0, dtg.Columns["OK"], null));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 

        private void txtSoCMND_uTextChanged(object sender, EventArgs e)
        {
            if (txtSoCMND.uText.Trim().Length == 0)
            {
                ListCMND.Visible = false;
            }
            else
            {
                string sSQL = "SELECT NhanSu,SOCMND FROM  dbo.NS_NhanSu WHERE Del=0 AND SOCMND LIKE N'%" + txtSoCMND.uText + "%'";
                DataTable DT = cnn.DT_DataTable(sSQL);
                if (DT != null && DT.Rows.Count > 0)
                {
                    ListCMND.DisplayMember = "SOCMND";
                    ListCMND.ValueMember = "NhanSu";
                    ListCMND.DataSource = DT;
                    ListCMND.Visible = true;
                }
                else
                    ListCMND.Visible = false;
            }
        }

        private void ListCMND_DoubleClick(object sender, EventArgs e)
        {
            iNhanSu = cnn.sNull2Int(ListCMND.SelectedValue);
            LoadNhanSu(iNhanSu);
            LoadThuLaoGiangDay(iNhanSu);
            ListCMND.Visible = false;
        }

        private void cbxKyHieu_uEditValueChanged(object sender, EventArgs e)
        {
            string sSQL = "SELECT 	dbo.DM_QuyenHoaDon.KyHieu,	SoBatDau,	CASE WHEN SoHoaDon IS NULL THEN SoBatDau ELSE RIGHT('0000000000'+CONVERT(NVARCHAR,(CONVERT(INT,SoHoaDon)+1)),LEN(SoBatDau)) END SoHoaDon " +
                        " FROM  dbo.DM_QuyenHoaDon " +
                        " LEFT JOIN (	SELECT 		KyHieu,		MAX(SoHoaDon) SoHoaDon	FROM  dbo.NS_HoaDonDo	GROUP BY KyHieu	)NS_HoaDonDo ON dbo.DM_QuyenHoaDon.KyHieu = NS_HoaDonDo.KyHieu Where DM_QuyenHoaDon.KyHieu=N'" + cnn.sNull2String(cbxKyHieu.uEditValue) + "'";
            DataTable DT = cnn.DT_DataTable(sSQL);
            if (DT != null && DT.Rows.Count > 0)
            {
                txtSoBatDau.uText = cnn.sNull2String(DT.Rows[0]["SoBatDau"]);
                txtSoHoaDon.uText = cnn.sNull2String(DT.Rows[0]["SoHoaDon"]);
            }
        }

        private void txtTongThuNhap_uValidated(object sender, EventArgs e)
        {
            //txtTienThue.uText = cnn.sNull2Number(cnn.sNull2Number(txtPTThue.uText) * cnn.sNull2Number(txtTongThuNhap.uText) / 100).ToString("N00");
           
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Hashtable Val = new Hashtable();
            string sKyHieu = cnn.sNull2String(cbxKyHieu.uEditValue);
            if (iNhanSu == 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn nhân sự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.bComboIsNull(cbxKyHieu))
            {
                XtraMessageBox.Show("Bạn chưa chọn ký hiệu hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtg.RowCount  <1)
            {
                XtraMessageBox.Show("Cán bộ này không có khoản thù lao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool In = chkLuuVaIn.Checked;
            cnn.BeginTransaction();
            try
            {

                bool bExist = false;
                TextBox txt = new TextBox();
                txt.Text = iNhanSu.ToString();
                txt.Tag = "..NhanSu";
                grpThongTinHoaDon.Controls.Add(txt);
                string sSQL = cnn.UpdateDataSQLComm(grpThongTinHoaDon, "NS_HoaDonDo", "HoaDon=" + iHoaDon, ref bExist, true);
                grpThongTinHoaDon.Controls.Remove(txt);
                cnn.SQL_ExecuteNonQuery(sSQL);
                if (!bExist)
                {
                    iHoaDon = cnn.sNull2Int(cnn.SQL_ExecuteScalar("SELECT @@IDENTITY"));
                }
                if (bExist)
                {
                    sSQL = "DELETE NS_ChiTietHoaDon WHERE NhanSu =" + iNhanSu + " AND SoHoaDon = N'" + txtSoHoaDon.Text + "' And KyHieu=N'" + cnn.sNull2String(cbxKyHieu.uEditValue) + "'";
                    cnn.ExecuteNonQuery(sSQL);
                }

                DataRow[] rows = ((DataTable)dtg.uDataSource).Select("OK = 1");
                foreach (DataRow row in rows)
                {
                    Val.Clear();
                    Val.Add("NhanSu", iNhanSu);
                    Val.Add("SoHoaDon", txtSoHoaDon.uText);
                    Val.Add("Thang", row["Thang"]);
                    Val.Add("Nam", row["Nam"]);
                    Val.Add("SoTien", row["TongTien"]);
                    Val.Add("TienThueTNCN", row["TienThueTNCN"]);
                    Val.Add("PTThue", row["PTThueTNCN"]);
                    Val.Add("NoiDung", row["NoiDungChi"]);
                    Val.Add("PhiChuyenKhoan", row["PhiChuyenKhoan"]);
                    Val.Add("ThucLanh", row["ThucLanh"]);
                    Val.Add("KyHieu", cnn.sNull2String(cbxKyHieu.uEditValue));
                    Val.Add("NgayThuLao", row["Ngay"]);
                    Val.Add("SoChungTu", row["SoChungTu"]);
                    Val.Add("NgayChungTu", row["NgayChungTu"]);
                    cnn.InsertNewRow(Val, "NS_ChiTietHoaDon");

                    sSQL = " Update NS_ThuLaoGiangDay set ISDaXuatHD=1 where NhanSu=" + iNhanSu + " And Thang=" + cnn.sNull2Number(row["Thang"]) + " And Nam=" + cnn.sNull2Number(row["Nam"]) + " And Ngay='" + Convert.ToDateTime(row["Ngay"]).ToString("MM/dd/yyyy") + "'";
                    cnn.SQL_ExecuteNonQuery(sSQL);
                }
                cnn.EndTransaction();
                //iHoaDon = cnn.sNull2Int(cnn.SQL_ExecuteScalar("Select HoaDon from NS_HOADONDO where SoHoaDon=N'" + txtSoHoaDon.uText + "' And KyHieu=N'" + cbxKyHieu.uEditValue.ToString() + "'"));
                if (chkLuuVaIn.Checked)
                {
                    InHoaDon();
                    cnn.SQL_ExecuteNonQuery("UPDATE NS_HOADONDO Set IsDaIn=1 Where HOADON="+iHoaDon);
                }
                btnThemMoi_Click(null, null);
                cbxKyHieu.uEditValue = sKyHieu;
                cbxKyHieu_uEditValueChanged(null, null);
                chkLuuVaIn.Checked = In;

            }
            catch (Exception ex)
            {
                cnn.RollbackTransaction();
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtg_uDataSourceChanged(object sender, EventArgs e)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn gc in dtg.Columns)
            {
                if (gc.FieldName != "OK")
                    gc.OptionsColumn.AllowEdit = false;
            }
        }

        private void dtg_uCellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string strNoiDung = "";
                decimal TongTien = 0;
                decimal fPhanTramThue = 0;
                for (int i = 0; i < dtg.RowCount; i++)
                {
                    if ((bool)dtg.GetDaTaRow(i)["OK"] == true)
                    {
                        TongTien += cnn.sNull2Number(dtg.GetDaTaRow(i)["TienThueTNCN"].ToString());
                        fPhanTramThue = cnn.sNull2Number(dtg.GetDaTaRow(0)["PTThueTNCN"].ToString());
                        strNoiDung += dtg.GetDaTaRow(i)["NoiDungChi"].ToString() + "; ";
                    }
                }
                if (strNoiDung.Trim().Length > 0)
                    strNoiDung = strNoiDung.Substring(0, strNoiDung.Length - 2);
                txtTienThue.uText = TongTien.ToString();
                txtTienThue.Text = TongTien.ToString("###,###");
                txtPTThue.uText = fPhanTramThue.ToString();
                txtNoiDung.uText = strNoiDung;
            
            
        }
    }
}