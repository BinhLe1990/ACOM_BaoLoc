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
    public partial class frmQuanHeGiaDinh : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanHeGiaDinh()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            dtg.sKEY = sKey;
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKey = "QUANHEGIADINH";
        private int iQuanHeGiaDinh = 0;
        public int iNhanSu = 0;
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cnn.clearControl(grpThongTin);
            iQuanHeGiaDinh = 0;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (iNhanSu == 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn nhân sự ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.bComboIsNull(cboQuanHe))
            {
                XtraMessageBox.Show("Bạn chưa chọn mối quan hệ ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtHoTen.uText.Trim().Length == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập họ tên", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
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
                string sSQL = cnn.UpdateDataSQLComm(grpThongTin, "NS_QuanHeGiaDinh", "NS_QuanHeGiaDinh=" + iQuanHeGiaDinh, ref bExist, true);
                grpThongTin.Controls.Remove(txt);
                int i = cnn.ExecuteNonQuery(sSQL);
                if (i > 0)
                {
                    if (!bExist)
                    {
                        iQuanHeGiaDinh = cnn.sNull2Int(cnn.SQL_ExecuteScalar("Select @@IDENTITY"));
                    }
                    cnn.EndTransaction();
                    XtraMessageBox.Show("Cập nhật dữ liệu thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadQuanHeGD();
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
        private void LoadQuanHeGD()
        {
            string sSQL = cnn.GetSQLString(sKey);
            sSQL = "Select * from ("+sSQL + ")A where Nhansu=" + iNhanSu;
            dtg.uDataSource = cnn.DT_DataTable(sSQL);
        }
        private void dtg_uDoubleClick(object sender, EventArgs e)
        {
            try
            {
                iQuanHeGiaDinh = cnn.sNull2Int(dtg.CurRow["NS_QuanHeGiaDinh"]);
            }
            catch
            {
                iQuanHeGiaDinh = 0;
            }
            if (iQuanHeGiaDinh == 0) return;
            cnn.DR_DataReader(grpThongTin, cnn.DT_DataTable("Select * from NS_QuanHeGiaDinh where NS_QuanHeGiaDinh=" + iQuanHeGiaDinh).Rows[0]);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (iQuanHeGiaDinh == 0) return;
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa mối quan hệ này không ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = cnn.SQL_ExecuteNonQuery("Delete NS_QuanHeGiaDinh where NS_QuanHeGiaDinh=" + iQuanHeGiaDinh);
                if (i > 0)
                {
                    XtraMessageBox.Show("Đã xóa dữ liệu thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cnn.clearControl(grpThongTin);
                    iQuanHeGiaDinh = 0;
                    LoadQuanHeGD();

                }
                else
                    XtraMessageBox.Show("Xóa dữ liệu thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uNhanSu1_uClick(object sender, EventArgs e)
        {
            iNhanSu = uNhanSu1.iNhanSuID;
            LoadQuanHeGD();
        }

        private void frmQuanHeGiaDinh_Load(object sender, EventArgs e)
        {

        }
    }
}