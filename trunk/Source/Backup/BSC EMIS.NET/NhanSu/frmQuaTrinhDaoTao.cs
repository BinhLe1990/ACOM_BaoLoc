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
    public partial class frmQuaTrinhDaoTao : DevExpress.XtraEditors.XtraForm
    {
        public frmQuaTrinhDaoTao()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            dtg.sKEY = sKey;
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKey = "QUATRINHDAOTAO";
        private int iQuaTrinhDaoTao = 0;
        public int iNhanSu = 0;
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cnn.clearControl(grpThongTin);
            iQuaTrinhDaoTao = 0;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (iNhanSu == 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn nhân sự ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNoiDung.uText.Trim().Length == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập nội dung ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoiDung.Focus();
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
                string sSQL = cnn.UpdateDataSQLComm(grpThongTin, "NS_QuaTrinhDaoTao", "QuaTrinhDaoTao=" + iQuaTrinhDaoTao, ref bExist, true);
                grpThongTin.Controls.Remove(txt);
                int i = cnn.ExecuteNonQuery(sSQL);
                if (i > 0)
                {
                    if (!bExist)
                    {
                        iQuaTrinhDaoTao = cnn.sNull2Int(cnn.SQL_ExecuteScalar("Select @@IDENTITY"));
                    }
                    cnn.EndTransaction();
                    XtraMessageBox.Show("Cập nhật dữ liệu thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadQuaTrinhDaoTao();
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

        private void frmQuaTrinhDaoTao_Load(object sender, EventArgs e)
        {
            uNhanSu1.LoadHS(iNhanSu);
            LoadQuaTrinhDaoTao();
        }
        private void LoadQuaTrinhDaoTao()
        {
            string sSQL = cnn.GetSQLString(sKey);
            sSQL = "Select * from ("+sSQL + ")A where Nhansu=" + iNhanSu;
            dtg.uDataSource = cnn.DT_DataTable(sSQL);
        }
        private void dtg_uDoubleClick(object sender, EventArgs e)
        {
            try
            {
                iQuaTrinhDaoTao = cnn.sNull2Int(dtg.CurRow["QuaTrinhDaoTao"]);
            }
            catch
            {
                iQuaTrinhDaoTao = 0;
            }
            if (iQuaTrinhDaoTao == 0) return;
            cnn.DR_DataReader(grpThongTin, cnn.DT_DataTable("Select * from NS_QuaTrinhDaoTao where QuaTrinhDaoTao=" + iQuaTrinhDaoTao).Rows[0]);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (iQuaTrinhDaoTao == 0) return;
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa quá trình đào tạo này ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = cnn.SQL_ExecuteNonQuery("Delete NS_QuaTrinhDaoTao where QuaTrinhDaoTao=" + iQuaTrinhDaoTao);
                if (i > 0)
                {
                    XtraMessageBox.Show("Đã xóa dữ liệu thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cnn.clearControl(grpThongTin);
                    iQuaTrinhDaoTao = 0;
                    LoadQuaTrinhDaoTao();

                }
                else
                    XtraMessageBox.Show("Xóa dữ liệu thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}