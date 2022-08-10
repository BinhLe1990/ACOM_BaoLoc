using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace BSC_HRM.NET.Luong
{
    public partial class frmKhauTruTrongThang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhauTruTrongThang()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            dtg.sKEY = sKey;
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKey = "KHAUTRUTRONGTHANG";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKhauTruTrongThang_Load(object sender, EventArgs e)
        {
            txtNam.uText = DateTime.Now.Year.ToString();
            txtThang.uText = DateTime.Now.Month.ToString();
        }

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            string sSQL = cnn.GetSQLString(sKey);
            sSQL = sSQL.Replace("1=1", "NAM="+txtNam.uText+" AND THANG="+txtThang.uText+" AND NS_KHAUTRU.MALOAIKHAUTRU=N'"+cnn.sNull2String(cboKhauTru.uEditValue)+"'");
            if (!cnn.bComboIsNull(cboPhongBan))
            {
                sSQL = "Select * from (" + sSQL + ")A where PHONGBAN=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "'";
            }
            sSQL = sSQL + " Order by TEN";
            dtg.uDataSource = cnn.DT_DataTable(sSQL);
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
            {
                if (col.Name != dtg.Columns["SOTIEN"].Name && col.Name != dtg.Columns["GHICHU"].Name)
                    col.OptionsColumn.AllowEdit = false;
            }
        }

        private void btnNhapDongLoat_Click(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cboKhauTru))
            {
                XtraMessageBox.Show("Bạn chưa chọn loại khấu trừ", "Khấu trừ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable DT=dtg.GetDataSource();
            if (DT != null && DT.Rows.Count > 0)
            {
                foreach (DataRow r in DT.Rows)
                {
                    r["NAM"] = txtNam.uText;
                    r["THANG"] = txtThang.uText;
                    r["Sotien"] = cnn.sNull2Number(txtSotien.uText);
                    r["MALOAIKHAUTRU"] = cboKhauTru.uEditValue;
                    r["TENLOAIKHAUTRU"] = cboKhauTru.uText;
                }
            }


        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            if (DT != null && DT.Rows.Count > 0)
            {
                Hashtable Val = new Hashtable();
                Hashtable Cond = new Hashtable();
                cnn.BeginTransaction();
                try
                {
                    foreach (DataRow r in DT.Rows)
                    {
                        Val.Clear();
                        Cond.Clear();
                        Cond.Add("NHANSU", r["NhanSu"]);
                        Cond.Add("NAM", r["NAM"]);
                        Cond.Add("THANG", r["THANG"]);
                        Cond.Add("MALOAIKHAUTRU", r["MALOAIKHAUTRU"]);
                        if (cnn.SelectRows(Cond, "NS_KHAUTRU").Rows.Count > 0)
                        {
                            Val.Add("SOTIEN", r["SOTIEN"]);
                            Val.Add("GHICHU", r["GHICHU"]);
                            bool i = cnn.UpdateRows(Val, Cond, "NS_KHAUTRU");
                            if (!i)
                            {
                                cnn.RollbackTransaction();
                                XtraMessageBox.Show("Cập nhật thất bại", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            Cond.Add("SOTIEN", r["SOTIEN"]);
                            Cond.Add("GHICHU", r["GHICHU"]);
                            bool i = cnn.InsertNewRow(Cond, "NS_KHAUTRU");
                            if (!i)
                            {
                                cnn.RollbackTransaction();
                                XtraMessageBox.Show("Cập nhật thất bại", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }


                    }
                    cnn.EndTransaction();
                    XtraMessageBox.Show("Cập nhật dữ liệu thành công", "cập nhật", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch
                {
                    cnn.RollbackTransaction();
                    XtraMessageBox.Show("Cập nhật thất bại", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            if (DT != null && DT.Rows.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;
                BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\NS_KhauTruTrongThang.repx", DT);
                frm.Show();
                this.Cursor = Cursors.Default;
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu dể in ", "In danh sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}