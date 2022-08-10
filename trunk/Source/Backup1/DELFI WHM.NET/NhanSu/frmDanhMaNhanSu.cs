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
    public partial class frmDanhMaNhanSu : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhMaNhanSu()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            dtg.sKEY = sKey;
            uFind1.sKEY = sKey;
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKey = "HOSONHANSU";

        private void uFind1_uClick(object sender, EventArgs e, DataTable dt)
        {
            dtg.uDataSource = dt;
        }

        private void btnDanhMa_Click(object sender, EventArgs e)
        {

            if (txtKyHieu.uText.Trim().Length == 0)
            {
                XtraMessageBox.Show("Bạn phải nhập mã khởi đầu", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSoBD.uText.Trim().Length == 0)
            {
                XtraMessageBox.Show("Bạn phải nhập số khởi đầu", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable DTT = dtg.GetDataSource();
            int iStart = 0;
            try
            {
                iStart = cnn.sNull2Int(txtSoBD.uText);

            }
            catch
            {
                XtraMessageBox.Show("Số bắt đầu phải là số ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int iMax = (DTT.Rows.Count + iStart);
            foreach (DataRow Row in DTT.Rows)
            {
                string MaNhanSu = iStart.ToString();
                MaNhanSu = "000000000000000000" + MaNhanSu;
                MaNhanSu = MaNhanSu.Substring(MaNhanSu.Length - txtSoBD.uText.Length, txtSoBD.uText.Length);
                Row["MA"] = string.Format("{0}{1}", txtKyHieu.Text, MaNhanSu);
                iStart++;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataTable dt = dtg.GetDataSource();
            if (XtraMessageBox.Show("Bạn có chắc muốn cập nhật lại mã nhân sự ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cnn.BeginTransaction();
                foreach (DataRow r in dt.Rows)
                {
                    int i = cnn.SQL_ExecuteNonQuery("Update NS_NhanSu set MA=N'" + cnn.sNull2String(r["MA"]) + "' where NhanSu=" + cnn.sNull2Int(r["NhanSu"]));
                    if (i <= 0)
                    {
                        cnn.RollbackTransaction();
                        XtraMessageBox.Show("Cập nhật thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                cnn.EndTransaction();
                XtraMessageBox.Show("Cập nhật thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}