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
    public partial class frmChamCongThang : DevExpress.XtraEditors.XtraForm
    {
        public frmChamCongThang()
        {
            InitializeComponent();
            clRun.SetValueToControl(this);
            dtg.sKEY = sKEY;

        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clRun = new clsRun();
        string sKEY = "CHAMCONGTHANG";

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {            
            string sSQL = cnn.GetSQLString("CHAMCONGTHANG");
            sSQL = sSQL.Replace("1=0", "Thang=" + spinThang.uText + " And Nam=" + spinNam.uText);
            if (!cnn.bComboIsNull(cboPhongBan))
            {
                sSQL = "Select * from (" + sSQL + ")A where A.PhongBan=N'" + cnn.sNull2String(cboPhongBan.uEditValue) + "'";
            }
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = DT;
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
            {
                if (col.Name != dtg.Columns["DiLam"].Name && col.Name != dtg.Columns["Vang"].Name && col.Name != dtg.Columns["VangCoPhep"].Name && col.Name != dtg.Columns["BaoHiemXaHoi"].Name
                    && col.Name != dtg.Columns["Vang1Buoi"].Name && col.Name != dtg.Columns["DiTre"].Name && col.Name != dtg.Columns["NGOAIGIO"].Name && col.Name != dtg.Columns["TONGQUYDOINGOAIGIO"].Name && col.Name != dtg.Columns["SONGAYCHAMCONG"].Name && col.Name != dtg.Columns["SONGAYTINHLUONG"].Name  )
                    col.OptionsColumn.AllowEdit = false;
            }
        }

        private void btnChamDongLoat_Click(object sender, EventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            foreach (DataRow r in DT.Rows)
            {
                r["DiLam"] = txtSoNgay.uText;
                r["Vang"] = 0;
                r["VangCoPhep"] = 0;
                r["BaoHiemXaHoi"] = 0;
                r["NGOAIGIO"] = 0;
                r["TONGQUYDOINGOAIGIO"] = 0;
                r["Vang1Buoi"] = 0;
                r["DiTre"] = 0;
                r["SONGAYCHAMCONG"] = txtSoNgay.uText;
                r["SONGAYTINHLUONG"] = txtSoNgay.uText; 
            }            
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Hashtable Cond = new Hashtable();
                Hashtable Val = new Hashtable();
                DataTable DT = dtg.GetDataSource();
                cnn.BeginTransaction();
                foreach (DataRow r in DT.Rows)
                {
                    Cond.Clear();
                    Val.Clear();
                    Cond.Add("NhanSu", r["NhanSu"]);
                    Cond.Add("Thang", spinThang.uText);
                    Cond.Add("Nam", spinNam.uText);
                    if (cnn.SelectRows(Cond, "NS_CHAMCONGTHANG").Rows.Count > 0)
                    {
                        Val.Add("DiLam", r["DiLam"]);
                        Val.Add("Vang", r["Vang"]);
                        Val.Add("VangCoPhep", r["VangCoPhep"]);
                        Val.Add("BaoHiemXaHoi", r["BaoHiemXaHoi"]);
                        Val.Add("DiTre", r["DiTre"]);
                        Val.Add("Vang1Buoi", r["Vang1Buoi"]);
                        Val.Add("NgoaiGio", r["NGOAIGIO"]);
                        Val.Add("TONGQUYDOINGOAIGIO", r["TONGQUYDOINGOAIGIO"]);
                        Val.Add("SONGAYCHAMCONG", r["SONGAYCHAMCONG"]);
                        Val.Add("SONGAYTINHLUONG", r["SONGAYTINHLUONG"]);
                        if (!cnn.UpdateRows(Val, Cond, "NS_CHAMCONGTHANG"))
                        {
                            cnn.RollbackTransaction();
                            XtraMessageBox.Show("Cập nhật thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Cursor = Cursors.Default;
                        }
                    }
                    else
                    {
                        Val.Add("NhanSu", r["NhanSu"]);
                        Val.Add("Thang", spinThang.uText);
                        Val.Add("Nam", spinNam.uText);
                        Val.Add("DiLam", r["DiLam"]);
                        Val.Add("Vang", r["Vang"]);
                        Val.Add("VangCoPhep", r["VangCoPhep"]);
                        Val.Add("BaoHiemXaHoi", r["BaoHiemXaHoi"]);
                        Val.Add("DiTre", r["DiTre"]);
                        Val.Add("Vang1Buoi", r["Vang1Buoi"]);
                        Val.Add("NgoaiGio", r["NGOAIGIO"]);
                        Val.Add("TONGQUYDOINGOAIGIO", r["TONGQUYDOINGOAIGIO"]);
                        Val.Add("SONGAYCHAMCONG", r["SONGAYCHAMCONG"]);
                        Val.Add("SONGAYTINHLUONG", r["SONGAYTINHLUONG"]);
                        if (!cnn.InsertNewRow(Val,"NS_CHAMCONGTHANG"))
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
            catch
            {
                cnn.RollbackTransaction();
                XtraMessageBox.Show("Cập nhật thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
        }

        private void frmChamCongThang_Load(object sender, EventArgs e)
        {
            spinThang.uText = DateTime.Now.Month.ToString();
            spinNam.uText = DateTime.Now.Year.ToString();
        }

        private void dtpDenNgay_uEditValueChanged(object sender, EventArgs e)
        {
            spinThang.uText = Convert.ToDateTime(dtpDenNgay.uValue).Month.ToString();
            spinNam.uText = Convert.ToDateTime(dtpDenNgay.uValue).Year.ToString();
        }

        private void btnTuChamCongNgay_Click(object sender, EventArgs e)
        {
            string str = cnn.GetSQLString("TONGHOPCHAMCONGNGAY");
            str = str.Replace("1=1", "NGAY BETWEEN '" + Convert.ToDateTime(dtpTuNgay.uValue).ToString("MM/dd/yyyy") + "' AND '" + Convert.ToDateTime(dtpDenNgay.uValue).ToString("MM/dd/yyyy") + "'").Replace("2=2", " MONTH(NGAY)<=" + spinThang.uText + " AND YEAR(NGAY)=" + spinNam.uText); 
            DataTable DT = cnn.DT_DataTable(str);
            if (DT != null && DT.Rows.Count > 0)
            {
                foreach (DataRow r in dtg.GetDataSource().Rows)
                {
                    foreach (DataRow rr in DT.Rows)
                    {
                        if (cnn.sNull2Int(r["NhanSu"]) == cnn.sNull2Int(rr["NhanSu"]))
                        {
                            r["DiLam"] = rr["DiLam"];
                            r["Vang"] = rr["Vang"];
                            r["VangCoPhep"] = rr["VangCoPhep"];
                            r["BaoHiemXaHoi"] = rr["BaoHiemXaHoi"];
                            r["Vang1Buoi"] = rr["Vang1Buoi"];
                            r["DiTre"] = rr["DiTre"];
                            r["NGOAIGIO"] = rr["NGOAIGIO"];
                            r["TONGQUYDOINGOAIGIO"] = cnn.sNull2Number(r["NGOAIGIO"])*cnn.sNull2Number(1.5);
                            if (cnn.sNull2Int(r["DiTre"]) <= 4)
                            {
                                r["SONGAYCHAMCONG"] = cnn.sNull2Number(r["DiLam"]) + (cnn.sNull2Number(r["Vang1Buoi"]) * cnn.sNull2Number(0.5)) + cnn.sNull2Number(r["DiTre"]);
                            }
                            else
                            {
                                r["SONGAYCHAMCONG"] = cnn.sNull2Number(r["DiLam"]) + (cnn.sNull2Number(r["Vang1Buoi"]) * cnn.sNull2Number(0.5)) + (cnn.sNull2Number(r["DiTre"]) - ((cnn.sNull2Number(r["DiTre"]) - 4) * cnn.sNull2Number(0.5)));
                            }
                            if (cnn.sNull2Int(rr["SONGAYNGHICONLAI"]) >= 0)
                            {
                                r["SONGAYTINHLUONG"] = cnn.sNull2Number(r["SONGAYCHAMCONG"]) + cnn.sNull2Number(rr["VangCoPhep"]) ; 
                            }
                            else
                            {
                                r["SONGAYTINHLUONG"] = cnn.sNull2Number(r["SONGAYCHAMCONG"]) ;
                            }
                        }
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            popupMenu1.ShowPopup(MousePosition);
        }

        private void btnInBangChamCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable dt = dtg.GetDataSource();
            if (dt.Rows.Count == 0)
                return;
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BangChamCongThang.repx", dt);
            string[] ThangNam = new string[] { spinThang.uText, spinNam.uText };
            frm.bXoayDiem = true;
            frm.MonHoc = ThangNam;
            frm.Show();
        }

        private void btnBangdiemDanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string sSQL = cnn.GetSQLString("BANGDIEMDANH");
            sSQL = sSQL.Replace("1=1", " MONTH(NGAY)=" + spinThang.uText + " AND YEAR(NGAY)=" + spinNam.uText).Replace("2=2", " MONTH(NGAY)<=" + spinThang.uText + " AND YEAR(NGAY)=" + spinNam.uText);
            sSQL = sSQL + " Order By TEN";
            DataTable DT = cnn.DT_DataTable(sSQL);
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BangDiemDanhThang.repx", DT);
            string[] ThangNam = new string[] { spinThang.uText, spinNam.uText };
            frm.bXoayDiem = true;
            frm.MonHoc = ThangNam;
            frm.Show();
        }
    }
}