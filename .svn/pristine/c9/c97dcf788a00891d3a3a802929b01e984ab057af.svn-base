using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace DELFI_WHM.NET.Luong
{
    public partial class frmChamCongNgay : DevExpress.XtraEditors.XtraForm
    {
        public frmChamCongNgay()
        {
            InitializeComponent();
            clRun.SetValueToControl(this);
            dtg.sKEY = sKEY;

        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clRun = new clsRun();
        string sKEY = "CHAMCONGNGAY";

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            if (dtpNgayCham.uValue.ToString() == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn ngày chấm công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sSQL = cnn.GetSQLString("CHAMCONGNGAY");
            sSQL = sSQL.Replace("'1'='0'","NGAY='"+Convert.ToDateTime(dtpNgayCham.uValue).ToString("MM/dd/yyyy")+"'");
            if (!cnn.bComboIsNull(cboPhongBan))
            {
                sSQL = "Select * from (" + sSQL + ")A where A.PHONGBAN='" + cnn.sNull2String(cboPhongBan.uEditValue) + "'";
            }
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = DT;
            DataTable dt = cnn.SelectRows("SELECT * FROM dbo.DM_LOAINGHI");
            dtg.Columns["LOAINGHI"].ColumnEdit = clRun.AddReference(dt, "TENLOAINGHI", "MALOAINGHI");            
            dtg.bAllowEdit = true;
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
            {
                if (col.Name != dtg.Columns["LOAINGHI"].Name)
                    col.OptionsColumn.AllowEdit = false;
            }
        }

        private void btnChamDongLoat_Click(object sender, EventArgs e)
        {
            
            DataTable dt = dtg.GetDataSource();
            foreach (DataRow r in dt.Rows)
            {
                r["LOAINGHI"] = "1";
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dtg.RowCount == 0)
                return;

            this.Cursor = Cursors.WaitCursor;
            if (cnn.sNull2String(dtpNgayCham.uValue) == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn ngày chấm công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;
                return;
            }
            Hashtable Val = new Hashtable();
            Hashtable Cond = new Hashtable();
            DataTable DT = dtg.GetDataSource();
            cnn.BeginTransaction();
            foreach (DataRow r in DT.Rows)
            {
                Val.Clear();
                Val.Add("Ngay", Convert.ToDateTime(dtpNgayCham.uValue).ToString("MM/dd/yyyy"));
                Val.Add("NhanSu", r["NhanSu"]);
                if (cnn.SelectRows(Val, "NS_CHAMCONGNGAY").Rows.Count > 0)
                {
                    Cond.Clear();
                    if (cnn.sNull2String(r["LOAINGHI"]) != "")
                    {
                        Cond.Add("LOAINGHI", r["LOAINGHI"]);
                    }
                    else
                    {
                        Cond.Add("LOAINGHI", "0");
                    }

                    if(!cnn.UpdateRows(Cond, Val, "NS_CHAMCONGNGAY"))
                    {
                        cnn.RollbackTransaction();
                        XtraMessageBox.Show("Cập nhật thất bại",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
                        this.Cursor = Cursors.Default;
                    }

                }
                else
                {
                    if (cnn.sNull2String(r["LOAINGHI"]) != "")
                    {
                        Val.Add("LOAINGHI", r["LOAINGHI"]);
                    }
                    else
                    {
                        Val.Add("LOAINGHI", "0");
                    }
                    if (!cnn.InsertNewRow(Val, "NS_CHAMCONGNGAY"))
                    {
                        cnn.RollbackTransaction();
                        XtraMessageBox.Show("Cập nhật thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Cursor = Cursors.Default;
                    }
                }                
            }
            cnn.EndTransaction();
            XtraMessageBox.Show("Cập nhật thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Cursor = Cursors.Default;            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DataTable dt = dtg.GetDataSource();
            if (dt.Rows.Count == 0)
                return;
            BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BangChamCongNgay.repx", dt);
            string [] Ngay=new string[]{Convert.ToDateTime(dtpNgayCham.uValue).ToString("dd/MM/yyyy")};
            frm.bXoayDiem = true;
            frm.MonHoc = Ngay;
            frm.Show();
        }
    }
}