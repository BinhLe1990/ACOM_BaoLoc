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
    public partial class frmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmHangHoa ()
        {
            InitializeComponent();
            clRun.SetValueToControl(this);
            dtg.sKEY = sKEY;
        }

        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clRun = new clsRun();
        string sKEY = "HangHoa";
        string HangHoa = "";
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dtg.RowCount == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để xóa!");
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa thông tin hàng hóa này khỏi cơ sở dữ liệu?\nCHÚ Ý: Dữ liệu đã xóa sẽ không thể khôi phục lại được", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            String ID = cnn.sNull2String(dtg.CurRow["HangHoa"]);
            cnn.ExecuteNonQuery("UPDATE DM_HangHoa Set Active = 0 where HangHoa = '" + ID + "'");
            XtraMessageBox.Show("Đã xóa thành công!");
            Hashtable Val = new Hashtable();
            cnn.GetValue(pnMain, ref Val);
            DataTable dt = cnn.SearchRows(Val, cnn.GetSQLString(sKEY));
            dtg.uDataSource = dt;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            cnn.clearControl(pnMain);
            HangHoa = "";
            clRun.SetPermit(this);
        }
        private void btnSuaHangHoa_Click(object sender, EventArgs e)
        {
            try
            {
                HangHoa = cnn.sNull2String(dtg.CurRow["HangHoa"]);
            }
            catch
            {
                HangHoa = "";
            }
            if (HangHoa == "")
                return;
            string sql = "select * from DM_HangHoa where HangHoa = '" + HangHoa + "'";
            DataRow r = cnn.SelectRows(sql).Rows[0];
            cnn.DR_DataReader(this, r);
        }

        private bool Check_Cond()
        {
            if (txtMaSo.uText.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập mã số hàng hóa", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSo.Focus();
                return false;
            }
            if (txtTenHHVN.uText.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập tên hàng hóa", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHHVN.SelectAll();
                return false;
            }
            return true;
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {

            if (!Check_Cond())
                return;
            if (HangHoa == "")
            {
                if (cnn.DT_DataTable("Select 1 from DM_HangHoa where MaHangHoa=N'" + txtMaSo.uText + "'").Rows.Count > 0)
                {
                    XtraMessageBox.Show("Mã hàng hóa này đã được sử dụng", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSo.Focus();
                    return;
                }
            }
            bool bExits = false;
            cnn.BeginTransaction();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string sSQL = cnn.UpdateDataSQLComm(pnMain, "DM_HangHoa", "HangHoa = '" + HangHoa + "'", ref bExits, true);
                cnn.ExecuteNonQuery(sSQL);
                if (!bExits)
                {
                    HangHoa = cnn.sNull2String(cnn.SQL_ExecuteScalar("SELECT @@IDENTITY"));
                }
                cnn.EndTransaction();
                this.Cursor = Cursors.Default;
                XtraMessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HangHoa = "";
                clRun.SetPermit(this);
                Hashtable Val = new Hashtable();
                cnn.GetValue(pnMain, ref Val);
                DataTable dt = cnn.SearchRows(Val, cnn.GetSQLString(sKEY));
                dtg.uDataSource = dt;
            }
            catch (Exception ex)
            {
                cnn.RollbackTransaction();
                this.Cursor = Cursors.Default;
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HangHoa = "";
                cnn.clearControl(this);
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

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            cnn.clearControl(this);
            HangHoa = "";
        }
        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            DataTable dt = dtg.GetDataSource();
            if (dt.Rows.Count == 0)
                return;
            BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\DM_NhaCungCap.repx", dt);
            frm.Show();
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