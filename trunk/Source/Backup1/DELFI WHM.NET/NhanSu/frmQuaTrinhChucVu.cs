using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace DELFI_WHM.NET.NhanSu
{
    public partial class frmQuaTrinhChucVu : DevExpress.XtraEditors.XtraForm
    {
        public frmQuaTrinhChucVu()
        {
            InitializeComponent();
            clRun.SetValueToControl(this);
            dtg.sKEY = sKEY;
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clRun = new clsRun();
        string sKEY = "QUATRINHCHUCVU";
        public int iQuaTrinhCV = 0;
        public int NhanSuID = 0;
        private void btnLamLai_Click(object sender, EventArgs e)
        {
            cnn.clearControl(panelThongTin);
            iQuaTrinhCV = 0;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmQuaTrinhChucVu_Load(object sender, EventArgs e)
        {
            uNhanSu1.LoadHS(NhanSuID);
            LoadQuaTrinhChucVu();            
        }

        private void LoadQuaTrinhChucVu()
        {
            string sSQL = cnn.GetSQLString("QUATRINHCHUCVU");
            sSQL = "Select * from (" + sSQL + ")A where NhanSu=" + NhanSuID + " Order by QuaTrinhChucVu DESC";
            dtg.uDataSource = cnn.DT_DataTable(sSQL);
        }

        private void btnLuuHoSo_Click(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cboChucVu))
            {
                XtraMessageBox.Show("Bạn chưa chọn chức vụ ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSoQuyetDinh.uText.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập số quyết định", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoQuyetDinh.Focus();
                return;
            }
            if (cnn.sNull2Number(txtHSCV.uText) == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập HSCV", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHSCV.Focus();
                return;
            }
            bool bExist=false;
            TextBox txt = new TextBox();
            txt.Text = NhanSuID.ToString();
            txt.Tag = "..NhanSu";
            panelThongTin.Controls.Add(txt);
            string sSQL = cnn.UpdateDataSQLComm(panelThongTin, "NS_QuaTrinhChucVu", "QuaTrinhChucVu=" + iQuaTrinhCV, ref bExist, true);
            panelThongTin.Controls.Remove(txt);
            int i=cnn.SQL_ExecuteNonQuery(sSQL);
            if (i > 0)
            {
                if (!bExist)
                {
                    iQuaTrinhCV = cnn.sNull2Int(cnn.SQL_ExecuteScalar("Select MAX(QuaTrinhChucVu) From NS_QuaTrinhChucVu"));
                }
                else
                { }
                XtraMessageBox.Show("Cập nhật thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadQuaTrinhChucVu();
            }
            else
            {
                XtraMessageBox.Show("Cập nhật thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtg_uDoubleClick(object sender, EventArgs e)
        {
            try
            {
                iQuaTrinhCV = cnn.sNull2Int(dtg.CurRow["QuaTrinhChucVu"]);
            }
            catch
            {
                iQuaTrinhCV = 0;
            }
            if (iQuaTrinhCV == 0)
                return;
            string sSQL = "Select * from NS_QuaTrinhChucVu where QuaTrinhChucVu=" + iQuaTrinhCV;
            DataRow r = cnn.DT_DataTable(sSQL).Rows[0];
            cnn.DR_DataReader(panelThongTin,r);
            radioChucVuChinh.EditValue=cnn.sNull2Int(r["ChucVuChinh"]);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (iQuaTrinhCV == 0) return;
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa bỏ chức vụ này ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               int i= cnn.SQL_ExecuteNonQuery("Delete NS_QuaTrinhChucVu where QuaTrinhChucVu=" + iQuaTrinhCV);
               if (i > 0)
               {
                   XtraMessageBox.Show("Đã xóa thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   cnn.clearControl(panelThongTin);
                   LoadQuaTrinhChucVu();
               }
               else
               {
                   XtraMessageBox.Show("Xóa thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return;
               }
            }
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }         
    }
}