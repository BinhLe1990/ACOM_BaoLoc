using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DELFI_WHM.NET;
using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;
using DELFI_WHM.NET.DELFI_Class;

namespace DELFI_WHM.NET.CauHinh
{
    public partial class frmCauHinh_LoaiBao : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        bool bExits = false;

        public frmCauHinh_LoaiBao()
        {
            InitializeComponent();
        }

        private void Search()
        {
            griDanhSach.DataSource = cnn.dt_PackageType();
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
        }

        private bool Check_Cond()
        {
            if (txtLoaiBao.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập Loại bao", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoaiBao.SelectAll();
                return false;
            }
            if (cnn.DT_DataTable("SELECT Loai FROM DM_LoaiBao WHERE Loai = '" + txtLoaiBao.uText +"'").Rows.Count > 0)
            {
                XtraMessageBox.Show("Loại bao đã tồn tại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoaiBao.SelectAll();
                return false;
            }
            return true;
        }

        private void frmCauHinh_LoaiBao_Load(object sender, EventArgs e)
        {
            Search();            
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView.OptionsSelection.MultiSelect = true;
                gridView.SelectAll();
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            cnn.clearControl(groupControl);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Check_Cond())
                return;
            cnn.BeginTransaction();
            try
            {
                string sSQL = cnn.UpdateDataSQLComm(groupControl, "DM_LoaiBao", "Loai = '" + txtLoaiBao.uText + "'", ref bExits, true);
                cnn.ExecuteNonQuery(sSQL);
                cnn.EndTransaction();
                Search();
                cnn.clearControl(groupControl);
                XtraMessageBox.Show("Lưu thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
