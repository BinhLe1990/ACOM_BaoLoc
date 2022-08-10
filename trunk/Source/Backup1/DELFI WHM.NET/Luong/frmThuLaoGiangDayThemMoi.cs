using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.Luong
{
    public partial class frmThuLaoGiangDayThemMoi : DevExpress.XtraEditors.XtraForm
    {
        public frmThuLaoGiangDayThemMoi()
        {
            InitializeComponent();
            clsrun.SetValueToControl(this);
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clsrun = new clsRun();
        private int iNhanSu = 0;

        private void txtMaSo_uValidated(object sender, EventArgs e)
        {
            if (txtMaSo.uText.Trim().Length > 0)
            {
                iNhanSu = cnn.sNull2Int(cnn.SQL_ExecuteScalar("Select NhanSu from NS_NhanSu where MA=N'" + txtMaSo.uText + "'"));
                if (iNhanSu > 0)
                    LoadNhanSu(iNhanSu);
                ListCMND.Visible = false;
            }
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

        private void ListCMND_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            iNhanSu = cnn.sNull2Int(ListCMND.SelectedValue);
            LoadNhanSu(iNhanSu);
            ListCMND.Visible = false;
        }

        private void LoadNhanSu(int iNS)
        {
            string sSQL = "SELECT 	NHANSU,	MA,	HODEM+' '+TEN HOTEN,	SOCMND,	CASE WHEN GIOITINH=1 THEN N'Nam' ELSE N'Nữ' END GIOITINH,	MST,	DCLL,	DIENTHOAI,	DIDONG,	PHANHE," +
                        " CASE 		WHEN ISNULL(MST,' ')=' ' AND ISNULL(PHANHE,'')='04' THEN 20 		WHEN ISNULL(MST,' ')<>' ' AND ISNULL(PHANHE,'')='04' THEN 10 ELSE 0 END PTThue " +
                        " FROM  dbo.NS_NHANSU WHERE Del=0 AND NhanSu=" + iNS;
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
            }
        }
        
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (iNhanSu == 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn nhân sự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.sNull2Number(txtTongThuNhap.uText) == 0)
            {
                XtraMessageBox.Show("Số tiền phải khác 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cnn.BeginTransaction();
            try
            {

                bool bExist = false;
                TextBox txt = new TextBox();
                txt.Text = iNhanSu.ToString();
                txt.Tag = "..NhanSu";
                TextBox txtMa = new TextBox();
                txtMa.Text = txtMaSo.uText;
                txtMa.Tag = "..MA";
                TextBox txtCMND = new TextBox();
                txtCMND.Text = txtSoCMND.uText;
                txtCMND.Tag = "..CMND";

                grpThongTin.Controls.Add(txt);
                grpThongTin.Controls.Add(txtMa);
                grpThongTin.Controls.Add(txtCMND);
                string sSQL = cnn.UpdateDataSQLComm(grpThongTin, "NS_ThuLaoGiangDayChiTiet", "NhanSu=" + iNhanSu + " AND Ngay = '" + dtpNgay.uDateTime.ToString("MM/dd/yyyy"), ref bExist, false);
                grpThongTin.Controls.Remove(txt);
                grpThongTin.Controls.Remove(txtMa);
                grpThongTin.Controls.Remove(txtCMND);
                cnn.SQL_ExecuteNonQuery(sSQL);                
                cnn.EndTransaction();
                XtraMessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string sNoiDung = txtNoiDungChi.uText;
                string sDonViNhan = txtDonViNhan.uText;
                btnThemMoi_Click(null, null);
                txtNoiDungChi.uText = sNoiDung;
                txtDonViNhan.uText = sDonViNhan;


            }
            catch (Exception ex)
            {
                cnn.RollbackTransaction();
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cnn.clearControl(this);
            iNhanSu = 0;
            dtpNgay.uDateTime = DateTime.Now;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmThuLaoGiangDayThemMoi_Load(object sender, EventArgs e)
        {

        }

    }
}