using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using System.Data.OleDb;

namespace DELFI_WHM.NET.Luong
{
    public partial class frmThuLaoGiangDay_ChiTiet : DevExpress.XtraEditors.XtraForm
    {
        public frmThuLaoGiangDay_ChiTiet()
        {
            InitializeComponent();
            clsrun.SetValueToControl(this);
            dtg.sKEY = sKEY;
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clsrun = new clsRun();
        string sKEY = "THULAOGIANGDAY";
        private void frmThuLaoGiangDay_ChiTiet_Load(object sender, EventArgs e)
        {
            dateNgay.uDateTime = DateTime.Now;
        }

        private void cbxPhanHe_Load(object sender, EventArgs e)
        {
            cbxPhanHe.uDataSource = cnn.SelectRows_NonSortOrder("SELECT * FROM dbo.DM_PHANHE WHERE MAPHANHE != 03");
        }

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            string sDKNgay = "";
            if (cnn.sNull2String(dateTuNgay.uValue) != "" && cnn.sNull2String(dateDenNgay.uValue) == "")
                sDKNgay = " Ngay >= '" + dateTuNgay.uDateTime.ToString("MM/dd/yyyy") + "'";
            if (cnn.sNull2String(dateTuNgay.uValue) == "" && cnn.sNull2String(dateDenNgay.uValue) != "")
                sDKNgay = " Ngay <= '" + dateDenNgay.uDateTime.ToString("MM/dd/yyyy") + "'";
            if (cnn.sNull2String(dateTuNgay.uValue) != "" && cnn.sNull2String(dateDenNgay.uValue) != "")
                sDKNgay = " Ngay >= '" + dateTuNgay.uDateTime.ToString("MM/dd/yyyy") + "' AND Ngay <= '" + dateDenNgay.uDateTime.ToString("MM/dd/yyyy") + "'";

            string sSQL = cnn.GetSQLString(sKEY);
            sSQL = sSQL.Replace("1 = 1", sDKNgay);

            string sReplace2 = "";
            if (!cnn.bComboIsNull(cbxCoSo))
                sReplace2 += " CoSo=N'" + cnn.sNull2String(cbxCoSo.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxPhanHe))
                sReplace2 += " PhanHe=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            if (cnn.sNull2String(txtNoiDungChi.uText) != "")
                sReplace2 += " NoiDungChi LIKE N'%" + cnn.sNull2String(txtNoiDungChi.uText) + "%' AND ";
            if (cnn.sNull2String(txtDonViNhan.uText) != "")
                sReplace2 += " DonViNhan LIKE N'%" + cnn.sNull2String(txtDonViNhan.uText) + "%' AND ";
            if (sReplace2.Length > 0)
            {
                sReplace2 = sReplace2.Substring(0, sReplace2.Length - 4);
                sSQL = sSQL.Replace("2 = 2", sReplace2);
            }
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = DT;
            tabMain.SelectedTabPage = tabThuLao;
        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            DataTable DT = dtg.GetDataSource();
            BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BangThuLaoGiangDay_ChiTiet.repx", DT);
            frm.sTime_FromTo = clsrun.sTime(dateTuNgay.uValue, dateDenNgay.uValue);
            frm.Show();
        }

        private void dtg_uCellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "TongTien")
                {
                    dtg.CurRow["TienThueTNCN"] = cnn.sNull2Number(dtg.CurRow["TongTien"]) * cnn.sNull2Number(dtg.CurRow["PTThueTNCN"]) / 100;
                    dtg.CurRow["ThucLanh"] = cnn.sNull2Number(dtg.CurRow["TongTien"]) - cnn.sNull2Number(dtg.CurRow["TienThueTNCN"]);
                }
            }
            catch
            { }
        }

        private void btnChonExcel_Click(object sender, EventArgs e)
        {
            string sFileName = "";
            OpenFileDialog diag = new OpenFileDialog();
            diag.Filter = "Microsoft Excel 2003 (*.xls)|*.xls";
            if (diag.ShowDialog() == DialogResult.OK)
                sFileName = diag.FileName;
            if (sFileName == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn file Excel", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sExcel = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + sFileName + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\"";
            System.Data.OleDb.OleDbConnection cnnExcel = new System.Data.OleDb.OleDbConnection(sExcel);
            cnnExcel.Open();
            try
            {
                DataTable dtTABLE_NAME = cnnExcel.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                string sTable = dtTABLE_NAME.Rows[0]["TABLE_NAME"].ToString().Trim();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [" + sTable + "]", sExcel);

                DataSet ds = new DataSet();
                da.Fill(ds);

                DataTable dtValex = new DataTable();
                dtValex.Columns.Add("COL2");
                dtValex.Columns.Add("DTYPE2");
                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                    dtValex.Rows.Add(new object[] { ds.Tables[0].Columns[i].Caption, "Text" });
                dtValex.Rows.Add();
                rpxCol.DataSource = dtValex;
                rpxCol.NullText = "";

                gridExcel.DataSource = ds.Tables[0].DefaultView;
                DataTable dtDGConfig = new DataTable();
                dtDGConfig.Columns.Add("CHON", Type.GetType("System.Boolean"));
                dtDGConfig.Columns.Add("COL1", Type.GetType("System.String"));
                dtDGConfig.Columns.Add("DTYPE1", Type.GetType("System.String"));
                dtDGConfig.Columns.Add("COL2", Type.GetType("System.String"));
                DataTable dtDataTable = cnn.SelectRows("SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.Columns WHERE TABLE_NAME = 'NS_ThuLaoGiangDayChiTiet' AND ( COLUMN_NAME = 'MA' OR COLUMN_NAME = 'CMND' OR COLUMN_NAME = 'NoiDungChi' OR COLUMN_NAME = 'DonViNhan' OR COLUMN_NAME = 'TongTien' OR COLUMN_NAME = 'GhiChu' )");
                for (int i = 0; i < dtDataTable.Rows.Count; i++)
                {
                    dtDGConfig.Rows.Add(new object[] { false, dtDataTable.Rows[i]["COLUMN_NAME"].ToString(), dtDataTable.Rows[i]["DATA_TYPE"].ToString(), dtDataTable.Rows[i]["COLUMN_NAME"].ToString() });
                }
                gridMain.DataSource = dtDGConfig;
                gridViewSource.OptionsView.ShowViewCaption = false;
                gridViewSource.Columns.Clear();
                gridSource.DataSource = cnn.SelectRows("Select * from NS_ThuLaoGiangDayChiTiet");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Chương trình không thể kết nối đến Database mà bạn chọn được.\n" + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tabMain.SelectedTabPage = tabImport;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Hashtable Val = new Hashtable();
            Hashtable Cond = new Hashtable();
            int iNotSucceed = 0;
            cnn.BeginTransaction();
            int i = 0;
            try
            {
                for (i = 0; i < gridViewExcel.RowCount; i++) // i = RowsIndex duyet qua cac dong muon Import
                {
                    Val.Clear();
                    Cond.Clear();
                    foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridViewExcel.Columns)//Duyet qua tung cot cua lưới chứa dữ liệu import
                    {
                        foreach (DataRow drTmp in ((DataTable)gridMain.DataSource).Rows)//Duyet qua tung dong cua luoi so sanh su lieu giua field trong database với các field của dữ liệu import
                        {
                            if (drTmp["CHON"].ToString().ToLower().Equals("true"))
                            {
                                if (col.FieldName == drTmp["COL2"].ToString())
                                {
                                    if (gridViewExcel.GetDataRow(i)[col.FieldName].ToString() != "") //  neu du lieu trong o trong (=null)
                                        Val.Add(drTmp["COL1"].ToString(), gridViewExcel.GetDataRow(i)[col.FieldName]);// Lay du lieu
                                }
                            }
                        }
                    }
                    if (Val.Count > 0)
                    {
                        Val.Add("Ngay", dateNgay.uDateTime.ToString("MM/dd/yyyy"));
                        string sNhanSu = "";
                        try
                        {
                            if (Val.ContainsKey("MA") == true)
                                sNhanSu = cnn.SQL_ExecuteScalar("SELECT NHANSU FROM NS_NHANSU WHERE MA = N'" + Val["MA"].ToString() + "'").ToString();
                            else if (Val.ContainsKey("CMND") == true)
                                sNhanSu = cnn.SQL_ExecuteScalar("SELECT NHANSU FROM NS_NHANSU WHERE SOCMND = '" + Val["CMND"].ToString() + "'").ToString();
                             
                        }
                        catch (System.Exception ex)
                        {
                            sNhanSu = "";
                        }
                        if (sNhanSu == "")
                        {
                            continue;
                        }
                        Val.Add("NhanSu", sNhanSu);
                        cnn.InsertNewRow(Val, "NS_ThuLaoGiangDayChiTiet");
                        iNotSucceed++;

                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Cập nhật không thành công. Lỗi phát sinh ở dòng thứ " + (i + 1) + ". Bạn vui lòng kiểm tra lại!\n" + ex.Message);

                cnn.RollbackTransaction();
                return;
            }
            if (iNotSucceed > 0)
            {
                XtraMessageBox.Show("Có" + iNotSucceed.ToString() + " dòng đã Import vào được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnn.EndTransaction();
            }
            else
            {
                cnn.EndTransaction();
                XtraMessageBox.Show("Đã cập nhật thành công");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtg_uDataSourceChanged(object sender, EventArgs e)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
            {
                if (col.FieldName != "TongTien" && col.FieldName != "GhiChu")
                    col.OptionsColumn.AllowEdit = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThuLaoGiangDayThemMoi frm = new frmThuLaoGiangDayThemMoi();
            frm.ShowDialog();
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa dòng chọn không?", "Xóa dòng chọn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cnn.DeleteRows("DELETE FROM NS_ThuLaoGiangDayChiTiet WHERE Ngay = '" + Convert.ToDateTime(dtg.CurRow["Ngay"]).ToString("MM/dd/yyyy") + "' AND NhanSu = '" + dtg.CurRow["NhanSu"].ToString() + "'");
                XtraMessageBox.Show("Xóa thành công?", "Xóa dòng chọn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLocDanhSach_Click(sender, e);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Hashtable Val = new Hashtable();
            Hashtable Cond = new Hashtable();
            foreach (DataRow row in dtg.GetDataSource().Rows)
            {
                Cond.Clear();
                Val.Clear();
                Cond.Add("Ngay", Convert.ToDateTime(row["Ngay"]).ToString("MM/dd/yyyy"));
                Cond.Add("NhanSu", row["NhanSu"].ToString());

                Val.Add("TongTien", cnn.sNull2Number(row["TongTien"]));
                Val.Add("GhiChu", row["GhiChu"].ToString());

                if (cnn.SelectRows(Cond, "NS_ThuLaoGiangDayChiTiet").Rows.Count > 0)
                {
                    cnn.UpdateRows(Val, Cond, "NS_ThuLaoGiangDayChiTiet");
                }
            }
            XtraMessageBox.Show("Cập nhật thành công?", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLocDanhSach_Click(sender, e);
        }
    }
}