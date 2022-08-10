using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.NhanSu
{
    public partial class frmQuaTrinhKyLuat : DevExpress.XtraEditors.XtraForm
    {
        public frmQuaTrinhKyLuat()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            dtg.sKEY = sKey;
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKey = "QUATRINHKYLUAT";
        private int iQuaTrinhKyLuat = 0;
        public int iNhanSu = 0;
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cnn.clearControl(grpThongTin);
            iQuaTrinhKyLuat = 0;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (iNhanSu == 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn nhân sự ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.bComboIsNull(cboChucVu))
            {
                XtraMessageBox.Show("Bạn chưa chọn chức vụ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSoQuyetDinh.uText.Trim().Length == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập số quyết định", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (iQuaTrinhKyLuat == 0)
            {

                if (cnn.DT_DataTable("Select 1 from NS_QuaTrinhKyLuat where SoQuyetDinh=N'" + txtSoQuyetDinh.uText + "' And NhanSu=" + iNhanSu).Rows.Count > 0)
                {
                    XtraMessageBox.Show("Số quyết định này đã tồn tại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            try
            {
                bool bExist = false;
                cnn.BeginTransaction();
                TextBox txt = new TextBox();
                txt.Text = iNhanSu.ToString();
                txt.Tag = "..NhanSu";
                grpThongTin.Controls.Add(txt);
                string sSQL = cnn.UpdateDataSQLComm(grpThongTin, "NS_QuaTrinhKyLuat", "QuaTrinhKyLuat=" + iQuaTrinhKyLuat, ref bExist, true);
                grpThongTin.Controls.Remove(txt);
                int i = cnn.ExecuteNonQuery(sSQL);
                if (i > 0)
                {
                    if (!bExist)
                    {
                        iQuaTrinhKyLuat = cnn.sNull2Int(cnn.SQL_ExecuteScalar("Select @@IDENTITY"));
                    }
                    cnn.EndTransaction();
                    XtraMessageBox.Show("Cập nhật dữ liệu thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadQuaTrinhKyLuat();
                }
                else
                {
                    cnn.RollbackTransaction();
                    XtraMessageBox.Show("Cập nhật thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                cnn.RollbackTransaction();
                XtraMessageBox.Show("Cập nhật thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmQuaTrinhKyLuat_Load(object sender, EventArgs e)
        {
            uNhanSu1.LoadHS(iNhanSu);
            LoadQuaTrinhKyLuat();
        }
        private void LoadQuaTrinhKyLuat()
        {
            string sSQL = cnn.GetSQLString(sKey);
            sSQL = "Select * from (" + sSQL + ")A where Nhansu=" + iNhanSu;
            dtg.uDataSource = cnn.DT_DataTable(sSQL);
        }
        private void dtg_uDoubleClick(object sender, EventArgs e)
        {
            try
            {
                iQuaTrinhKyLuat = cnn.sNull2Int(dtg.CurRow["QuaTrinhKyLuat"]);
            }
            catch
            {
                iQuaTrinhKyLuat = 0;
            }
            if (iQuaTrinhKyLuat == 0) return;
            cnn.DR_DataReader(grpThongTin, cnn.DT_DataTable("Select * from NS_QuaTrinhKyLuat where QuaTrinhKyLuat=" + iQuaTrinhKyLuat).Rows[0]);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (iQuaTrinhKyLuat == 0) return;
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa quá trình kỷ luật này ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = cnn.SQL_ExecuteNonQuery("Delete NS_QuaTrinhKyLuat where QuaTrinhKyLuat=" + iQuaTrinhKyLuat);
                if (i > 0)
                {
                    XtraMessageBox.Show("Đã xóa dữ liệu thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cnn.clearControl(grpThongTin);
                    iQuaTrinhKyLuat = 0;
                    LoadQuaTrinhKyLuat();

                }
                else
                    XtraMessageBox.Show("Xóa dữ liệu thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboHinhThuc_uEditValueChanged(object sender, EventArgs e)
        {
            string sSQL = "Select * from DM_KYLUAT where MAKYLUAT=N'" + cnn.sNull2String(cboHinhThuc.uEditValue) + "'";
            DataTable dt = cnn.DT_DataTable(sSQL);
            if (dt != null && dt.Rows.Count > 0)
            {
                chkDinhChi.Checked = (bool)cnn.DT_DataTable(sSQL).Rows[0]["DinhChi"];
            }
            else
                chkDinhChi.Checked = false;
        }
    }
}