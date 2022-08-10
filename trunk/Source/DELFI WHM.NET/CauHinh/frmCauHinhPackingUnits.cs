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
    public partial class frmCauHinhPackingUnits : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        bool bExits = false;

        public frmCauHinhPackingUnits()
        {
            InitializeComponent();
        }

        private void Search()
        {
            griDanhSach.DataSource = cnn.dt_PackageCode();
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private bool Check_Cond()
        {
            if (cnn.bComboIsNull(cboLoai))
            {
                XtraMessageBox.Show("Bạn chưa chọn Loại bao", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoai.Focus();
                return false;
            }
            if (txtCode.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập Loại bao bì", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus();
                return false;
            }
            if (cnn.DT_DataTable("SELECT PackageCode FROM DM_Packing WHERE PackageCode = '" + txtCode.uText + "'").Rows.Count > 0 && spnID.uValue == 0)
            {
                XtraMessageBox.Show("Loại bao bì đã tồn tại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus();
                return false;
            }
            return true;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Check_Cond())
                return;
            cnn.BeginTransaction();
            try
            {
                string sSQL = cnn.UpdateDataSQLComm(groupControl, "DM_Packing", "ID = '" + spnID.uValue + "'", ref bExits, true);
                cnn.ExecuteNonQuery(sSQL);
                cnn.EndTransaction();
                Search();
                cnn.clearControl(groupControl);
                txtCode.Enabled = true;
                XtraMessageBox.Show("Lưu thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                cnn.RollbackTransaction();
                this.Cursor = Cursors.Default;
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCauHinhPackingUnits_Load(object sender, EventArgs e)
        {
            cboLoai.uDataSource = cnn.dt_PackageType();
            cboLoai.uValueMember = "Loai";
            cboLoai.uDisplayMember = "Loai";
            Search();
        }

        private void cboLoai_uQueryPopUp(object sender, CancelEventArgs e)
        {
            cboLoai.uDataSource = cnn.dt_PackageType();
            cboLoai.uValueMember = "Loai";
            cboLoai.uDisplayMember = "Loai";
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

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from DM_Packing where ID = '" + gridView.GetFocusedRowCellValue("ID") + "'";
                DataRow r = cnn.SelectRows(sql).Rows[0];
                cnn.DR_DataReader(this, r);
                spnID.uValue = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID"));
                txtCode.Enabled = false;
            }
            catch { }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            cnn.clearControl(groupControl);
            txtCode.Enabled = true;
        }
    }
}
