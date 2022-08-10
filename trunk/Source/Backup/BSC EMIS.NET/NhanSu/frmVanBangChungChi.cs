using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BSC_HRM.NET.NhanSu
{
    public partial class frmVanBangChungChi : DevExpress.XtraEditors.XtraForm
    {
        public frmVanBangChungChi()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            dtg.sKEY = sKey;
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKey = "VANBANGCHUNGCHI";
        private int iVanBangChungChi = 0;
        public int iNhanSu = 0;
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cnn.clearControl(grpThongTin);
            iVanBangChungChi = 0;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (iNhanSu == 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn nhân sự ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.bComboIsNull(cboVanBang))
            {
                XtraMessageBox.Show("Bạn chưa chọn Văn bằng-Chứng chỉ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSoBang.uText.Trim().Length == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập số bằng", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoBang.Focus();
                return;
            }            
            try
            {
                bool bExist = false;
                cnn.BeginTransaction();
                TextBox txt = new TextBox();
                txt.Text = iNhanSu.ToString();
                txt.Tag = "..NhanSu";
                grpThongTin.Controls.Add(txt);
                string sSQL = cnn.UpdateDataSQLComm(grpThongTin, "NS_VanBangChungChi", "VanBangChungChi=" + iVanBangChungChi, ref bExist, true);
                grpThongTin.Controls.Remove(txt);
                int i = cnn.ExecuteNonQuery(sSQL);
                if (i > 0)
                {
                    if (!bExist)
                    {
                        iVanBangChungChi = cnn.sNull2Int(cnn.SQL_ExecuteScalar("Select @@IDENTITY"));
                    }
                    cnn.EndTransaction();
                    XtraMessageBox.Show("Cập nhật dữ liệu thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVanBang();
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

        private void frmVanBangChungChi_Load(object sender, EventArgs e)
        {
            uNhanSu1.LoadHS(iNhanSu);
            LoadVanBang();
        }
        private void LoadVanBang()
        {
            string sSQL = cnn.GetSQLString(sKey);
            sSQL = "Select * from (" + sSQL + ")A where Nhansu=" + iNhanSu;
            dtg.uDataSource = cnn.DT_DataTable(sSQL);
        }
        private void dtg_uDoubleClick(object sender, EventArgs e)
        {
            try
            {
                iVanBangChungChi = cnn.sNull2Int(dtg.CurRow["VanBangChungChi"]);
            }
            catch
            {
                iVanBangChungChi = 0;
            }
            if (iVanBangChungChi == 0) return;
            cnn.DR_DataReader(grpThongTin, cnn.DT_DataTable("Select * from NS_VanBangChungChi where VanBangChungChi=" + iVanBangChungChi).Rows[0]);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (iVanBangChungChi == 0) return;
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa văn bằng-chứng chỉ này ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = cnn.SQL_ExecuteNonQuery("Delete NS_VanBangChungChi where VanBangChungChi=" + iVanBangChungChi);
                if (i > 0)
                {
                    XtraMessageBox.Show("Đã xóa dữ liệu thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cnn.clearControl(grpThongTin);
                    iVanBangChungChi = 0;
                    LoadVanBang();

                }
                else
                    XtraMessageBox.Show("Xóa dữ liệu thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}