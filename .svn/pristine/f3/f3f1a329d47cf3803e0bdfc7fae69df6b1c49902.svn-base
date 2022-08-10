using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BSC_HRM.NET.Luong
{
    public partial class frmSoLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmSoLuong()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            dtg.sKEY = sKey;

        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKey = "SOLUONG";
        int iSoLuong = 0;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSoLuong_Load(object sender, EventArgs e)
        {
            txtNam.uText = DateTime.Now.Year.ToString();
            txtThang.uText = DateTime.Now.Month.ToString();
        }

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            string sSQL = cnn.GetSQLString(sKey);
            sSQL = "Select * from (" + sSQL + ")A where Nam=" + txtNam.uText;
            dtg.uDataSource = cnn.DT_DataTable(sSQL);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            iSoLuong = 0;
            cnn.clearControl(panelControl1);
            txtNam.uText = DateTime.Now.Year.ToString();
            txtLuongCoBan.uText = "1150000";
            txtBHXH.uText = "7";
            txtKinhPhiCongDoan.uText = "1";
            txtBaoHiemYTe.Text = "1.5";
            txtBaoHiemThatNghiep.uText = "1";
            txtGiamTruChoBanThan.uText = "4000000";
            txtGiamTruChoPhuThuoc.uText = "1600000";
            txtThang.uText = cnn.sNull2String(cnn.sNull2Int(cnn.SQL_ExecuteScalar("Select Top 1 Thang from NS_SoLuong where Nam="+txtNam.uText+" order by Thang DESC"))+1);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {            
            if (cnn.sNull2Int(txtThang.uText) <= 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn tháng", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cnn.sNull2Int(txtNam.uText) <= 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn năm", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }            
            if (cnn.sNull2Number(txtLuongCoBan.uText) <= 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập lương cơ bản", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.sNull2Number(txtPhuCapUuDai.uText) <= 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập phụ cấp ưu đãi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            if (cnn.sNull2Number(txtPhuCapThemGio.uText) <= 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập mức phụ cấp thêm giờ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.sNull2Number(txtPhuCapChiTieuNoiBo.uText) <= 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập mức phụ cấp chi tiêu nội bộ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.sNull2Number(txtGiamTruChoBanThan.uText) <= 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập mức giảm trừ cho bản thân ( thuế TNCN )", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.sNull2Number(txtGiamTruChoPhuThuoc.uText) <= 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập mức giảm trừ cho người phụ thuộc ( thuế TNCN )", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.DT_DataTable("Select 1 from NS_SoLuong where Nam="+txtNam.uText+" And Thang="+txtThang.uText).Rows.Count > 0 &&iSoLuong==0)
            {
                XtraMessageBox.Show("Sổ lương này đã tồn tại, vui lòng kiểm tra lại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cnn.BeginTransaction();
            bool bExist=false;
            try
            {
                string sSQL = cnn.UpdateDataSQLComm(panelControl1, "NS_SoLuong", "SoLuong=" + iSoLuong, ref bExist, true);
                cnn.SQL_ExecuteNonQuery(sSQL);
                if (!bExist)
                {
                    iSoLuong = cnn.sNull2Int(cnn.SQL_ExecuteScalar("SELECT @@IDENTITY"));
                }
                cnn.EndTransaction();
                btnLocDanhSach_Click(null, null);
            }
            catch (Exception ex)
            {
                cnn.RollbackTransaction();
                XtraMessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dtg_uDoubleClick(object sender, EventArgs e)
        {
            try
            {
                iSoLuong = cnn.sNull2Int(dtg.CurRow["SoLuong"]);
            }
            catch
            {
                iSoLuong = 0;
            }
            if (iSoLuong == 0) return;
            DataRow r = cnn.DT_DataTable("Select * from NS_SoLuong where SoLuong=" + iSoLuong).Rows[0];
            cnn.DR_DataReader(panelControl1, r);           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (iSoLuong <= 0) return;
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa sổ lương này ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool ok = cnn.DeleteRows("Delete NS_SoLuong where SoLuong=" + iSoLuong);
                    if (!ok)
                    {
                        XtraMessageBox.Show("Xóa thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    btnLocDanhSach_Click(null, null);
                }
                catch 
                {
                    XtraMessageBox.Show("Xóa thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        
    }
}