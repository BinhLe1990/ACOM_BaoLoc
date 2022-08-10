using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace DELFI_WHM.NET.KhoHang
{
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCungCap ()
        {
            InitializeComponent();
            clRun.SetValueToControl(this);
            dtg.sKEY = sKEY;
        }

        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clRun = new clsRun();
        string sKEY = "NHACUNGCAP";
        string NhaCungCap = "";
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dtg.RowCount == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để xóa!");
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa thông tin nhà cung cấp này khỏi cơ sở dữ liệu?\nCHÚ Ý: Dữ liệu đã xóa sẽ không thể khôi phục lại được", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            String ID = cnn.sNull2String(dtg.CurRow["NhaCungCap"]);
            cnn.ExecuteNonQuery("UPDATE DM_NhaCungCap Set Active = 0 where NhaCungCap = '" + ID + "'");
            XtraMessageBox.Show("Đã xóa thành công!");
            Hashtable Val = new Hashtable();
            cnn.GetValue(pnMain, ref Val);
            DataTable dt = cnn.SearchRows(Val, cnn.GetSQLString(sKEY));
            dtg.uDataSource = dt;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            cnn.clearControl(pnMain);
            NhaCungCap = "";
            clRun.SetPermit(this);
        }
        private void btnSuaHoSo_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCap = cnn.sNull2String(dtg.CurRow["NhaCungCap"]);
            }
            catch
            {
                NhaCungCap = "";
            }
            if (NhaCungCap == "")
                return;
            string sql = "select * from DM_NhaCungCap where NhaCungCap = '" + NhaCungCap + "'";
            DataRow r = cnn.SelectRows(sql).Rows[0];
            cnn.DR_DataReader(this, r);
        }

        private bool Check_Cond()
        {
            if (txtMaSo.uText.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập mã số nhà cung cấp", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSo.Focus();
                return false;
            }
            if (txtTenNCC.uText.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập tên nhà cung cấp", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNCC.Focus();
                return false;
            }
            return true;
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {

            if (!Check_Cond())
                return;
            if (NhaCungCap == "")
            {
                if (cnn.DT_DataTable("Select 1 from DM_NhaCungCap where MaNhaCungCap=N'" + txtMaSo.uText + "' And Active = 1").Rows.Count > 0)
                {
                    XtraMessageBox.Show("Mã nhà cung cấp này đã được sử dụng", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSo.uText = "";
                    return;
                }
            }
            bool bExits = false;
            cnn.BeginTransaction();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string sSQL = cnn.UpdateDataSQLComm(pnMain, "DM_NhaCungCap", "NhaCungCap = '" + NhaCungCap + "'", ref bExits, true);
                cnn.ExecuteNonQuery(sSQL);
                if (!bExits)
                {
                    NhaCungCap = cnn.sNull2String(cnn.SQL_ExecuteScalar("SELECT @@IDENTITY"));
                }
                cnn.EndTransaction();
                this.Cursor = Cursors.Default;
                XtraMessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NhaCungCap = "";
                clRun.SetPermit(this);
            }
            catch (Exception ex)
            {
                cnn.RollbackTransaction();
                this.Cursor = Cursors.Default;
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NhaCungCap = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtg_uDataSourceChanged(object sender, EventArgs e)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
            {
                if (col.Name != dtg.Columns["Chon"].Name)
                    col.OptionsColumn.AllowEdit = false;
            }
        }

        private void frmHoSoGiaoVien_Load(object sender, EventArgs e)
        {
            cnn.clearControl(this);
            NhaCungCap = "";
        }
        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            DataTable dt = dtg.GetDataSource();
            if (dt.Rows.Count == 0)
                return;
            BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\DM_NhaCungCap.repx", dt);
            frm.Show();
        }

        private void cboTinh_uEditValueChanged(object sender, EventArgs e)
        {
            string sSQL = "SELECT * FROM dbo.DM_QuanHuyen WHERE MaTinhThanhPho='" + cnn.sNull2String(cboTinh.uEditValue) + "'";
            DataTable DT = cnn.DT_DataTable(sSQL);
            cboQuanHuyen.uDataSource = DT;
            cboQuanHuyen.sField = "MaQuanHuyen,TenQuanHuyen";
            cboQuanHuyen.sColumnCaption = "Mã quận huyện,Tên quận huyện";
        }

        private void btnQuaTrinh_Click(object sender, EventArgs e)
        {
            popupMenu1.ShowPopup(MousePosition);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Hashtable Val = new Hashtable();
            cnn.GetValue(pnMain, ref Val);
            DataTable dt = cnn.SearchRows(Val, cnn.GetSQLString(sKEY), DELFI_WHM.NET.DELFI_Class.DELFIConnection.BSCLoadType.UseLoadProcess);
            dtg.uDataSource = dt;
        }
        
    }
}