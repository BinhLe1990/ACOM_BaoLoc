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
    public partial class frmQuaTrinhKhenThuong : DevExpress.XtraEditors.XtraForm
    {
        public frmQuaTrinhKhenThuong()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            dtg.sKEY = sKey;
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKey = "QUATRINHKHENTHUONG";
        private int iQuaTrinhKhenThuong = 0;
        public int iNhanSu = 0;
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cnn.clearControl(grpThongTin);
            iQuaTrinhKhenThuong = 0;
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
            if (iQuaTrinhKhenThuong == 0)
            {

                if (cnn.DT_DataTable("Select 1 from NS_QuaTrinhKhenThuong where SoQuyetDinh=N'" + txtSoQuyetDinh.uText + "' And NhanSu=" + iNhanSu).Rows.Count > 0)
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
                string sSQL = cnn.UpdateDataSQLComm(grpThongTin, "NS_QuaTrinhKhenThuong", "QuaTrinhKhenThuong=" + iQuaTrinhKhenThuong, ref bExist, true);
                grpThongTin.Controls.Remove(txt);
                int i = cnn.ExecuteNonQuery(sSQL);
                if (i > 0)
                {
                    if (!bExist)
                    {
                        iQuaTrinhKhenThuong = cnn.sNull2Int(cnn.SQL_ExecuteScalar("Select @@IDENTITY"));
                    }
                    cnn.EndTransaction();
                    XtraMessageBox.Show("Cập nhật dữ liệu thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadQuaTrinhKhenThuong();
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

        private void frmQuaTrinhKhenThuong_Load(object sender, EventArgs e)
        {
            uNhanSu1.LoadHS(iNhanSu);
            LoadQuaTrinhKhenThuong();
        }
        private void LoadQuaTrinhKhenThuong()
        {
            string sSQL = cnn.GetSQLString(sKey);
            sSQL = "Select * from (" + sSQL + ")A where Nhansu=" + iNhanSu;
            dtg.uDataSource = cnn.DT_DataTable(sSQL);
        }
        private void dtg_uDoubleClick(object sender, EventArgs e)
        {
            try
            {
                iQuaTrinhKhenThuong = cnn.sNull2Int(dtg.CurRow["QuaTrinhKhenThuong"]);
            }
            catch
            {
                iQuaTrinhKhenThuong = 0;
            }
            if (iQuaTrinhKhenThuong == 0) return;
            cnn.DR_DataReader(grpThongTin, cnn.DT_DataTable("Select * from NS_QuaTrinhKhenThuong where QuaTrinhKhenThuong=" + iQuaTrinhKhenThuong).Rows[0]);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (iQuaTrinhKhenThuong == 0) return;
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa quá trình khen thưởng này ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = cnn.SQL_ExecuteNonQuery("Delete NS_QuaTrinhKhenThuong where QuaTrinhKhenThuong=" + iQuaTrinhKhenThuong);
                if (i > 0)
                {
                    XtraMessageBox.Show("Đã xóa dữ liệu thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cnn.clearControl(grpThongTin);
                    iQuaTrinhKhenThuong = 0;
                    LoadQuaTrinhKhenThuong();

                }
                else
                    XtraMessageBox.Show("Xóa dữ liệu thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}