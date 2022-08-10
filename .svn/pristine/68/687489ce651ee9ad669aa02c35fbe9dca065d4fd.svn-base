using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace BSC_HRM.NET.NhanSu
{
    public partial class frmHopDongLaoDong : DevExpress.XtraEditors.XtraForm
    {
        public frmHopDongLaoDong()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        private int iNhanSu = 0;
        private int iHopDongLaoDong = 0;
        public int uHopDongLaoDong
        {
            get { return iHopDongLaoDong; }
            set { iHopDongLaoDong = value; }
        }
        private void uNhanSu1_uClick(object sender, EventArgs e)
        {
            iNhanSu = uNhanSu1.iNhanSuID;
            iHopDongLaoDong = 0;
            cnn.clearControl(grpHopDong);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cnn.clearControl(grpHopDong);
            iHopDongLaoDong = 0;
        }

        private void uNhanSu1_Load(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (iNhanSu == 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn nhân sự ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSoHD.uText.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập số HĐ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.bComboIsNull(cboLoaiHD))
            {
                XtraMessageBox.Show("Bạn chưa chọn loại HĐ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (iHopDongLaoDong == 0)
            {
                if (cnn.DT_DataTable("Select 1 from NS_HopDongLaoDong where SoHopDong=N'"+txtSoHD.uText+"'").Rows.Count > 0)
                {
                    XtraMessageBox.Show("Số hợp đồng đã tồn tại, vui lòng nhập số khác !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            try
            {
                bool bExist=false;
                cnn.BeginTransaction();
                TextBox txt = new TextBox();
                txt.Text = iNhanSu.ToString() ;
                txt.Tag = "..NhanSu";
                grpHopDong.Controls.Add(txt);
                string sSQL = cnn.UpdateDataSQLComm(grpHopDong, "NS_HOPDONGLAODONG", "HopDongLaoDong=" + iHopDongLaoDong, ref bExist, true);
                grpHopDong.Controls.Remove(txt);
                int i = cnn.SQL_ExecuteNonQuery(sSQL);
                if (i > 0)
                {
                    if (!bExist)
                    {
                        iHopDongLaoDong = cnn.sNull2Int(cnn.SQL_ExecuteScalar("Select @@IDENTITY"));
                    }
                    cnn.EndTransaction();
                    XtraMessageBox.Show("Cập nhật dự liệu thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                return;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (iHopDongLaoDong == 0) return;
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa hợp đồng này không ?", "Xóa hợp đồng lao động", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int i = cnn.SQL_ExecuteNonQuery("DELETE NS_HopDongLaoDong where HopDongLaoDong=" + iHopDongLaoDong);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa hợp đồng thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Xóa hợp đồng thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    XtraMessageBox.Show("Xóa hợp đồng thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (iHopDongLaoDong == 0)
                return;
            string sSQL = cnn.GetSQLString("HOPDONGLAODONG");
            sSQL = sSQL + " Where HopDongLaoDong=" + iHopDongLaoDong;
            DataTable dt = cnn.DT_DataTable(sSQL);
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\NS_HopDongLaoDong.repx", dt);
            frm.Show();
        }
        private void LoadHD(string sSoHopDong)
        {
            DataTable DT = cnn.DT_DataTable("Select * from ns_hopdonglaodong where sohopdong=N'" + sSoHopDong + "'");
            if (DT != null && DT.Rows.Count > 0)
            {
                cnn.DR_DataReader(grpHopDong, DT.Rows[0]);
                iHopDongLaoDong = cnn.sNull2Int(DT.Rows[0]["hopdonglaodong"]);
                iNhanSu = cnn.sNull2Int(DT.Rows[0]["NhanSu"]);
                uNhanSu1.LoadHS(iNhanSu);
            }
            else
                return;
        }

        private void txtSoHD_uValidated(object sender, EventArgs e)
        {
            LoadHD(txtSoHD.uText);
        }

        private void txtSoHD_uKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadHD(txtSoHD.uText);
            }
        }
    }
}