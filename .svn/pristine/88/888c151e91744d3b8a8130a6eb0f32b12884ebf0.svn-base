using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BSC_HRM.NET.NhanSu
{
    public partial class frmChuyenPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmChuyenPhong()
        {
            InitializeComponent();
            clsRun.SetValueToControl(this);
            dtg.sKEY = sKey;
            dtgTu.sKEY = "HOSONHANSU";
            dtgDen.sKEY = "HOSONHANSU";
        }
        BSC_Class.BSCConnection cnn = new BSC_HRM.NET.BSC_Class.BSCConnection(Program.sConnection);
        clsRun clsRun = new clsRun();
        string sKey = "DSCHUYENPHONG";

        private void frmChuyenPhong_Load(object sender, EventArgs e)
        {
            LoadDanhSachChuyenPhong();
        }
        private void LoadDanhSachChuyenPhong()
        {
            dtg.uDataSource = cnn.DT_DataTable("Select * from ("+cnn.GetSQLString(sKey)+") A Order by NgayChuyen");
        }

        private void cboTuPhong_uEditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string sMaPhong = cnn.sNull2String(cboTuPhong.uEditValue);
                dtgTu.uDataSource = cnn.DT_DataTable("Select * from (" + cnn.GetSQLString("HOSONHANSU") + ")A where PHONGBAN=N'" + sMaPhong + "'");
                foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtgTu.Columns)
                {
                    if (col.Name != dtgTu.Columns["CHON"].Name)
                        col.OptionsColumn.AllowEdit = false;
                }
            }
            catch
            { }
        }

        private void cboDenPhong_uEditValueChanged(object sender, EventArgs e)
        {           
            try
            {
                string sMaPhong = cnn.sNull2String(cboDenPhong.uEditValue);
                dtgDen.uDataSource = cnn.DT_DataTable("Select * from (" + cnn.GetSQLString("HOSONHANSU") + ")A where PHONGBAN=N'" + sMaPhong + "'");
                foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtgDen.Columns)
                {
                    if (col.Name != dtgDen.Columns["CHON"].Name)
                        col.OptionsColumn.AllowEdit = false;
                }

            }
            catch
            { }        
        }

        private void btnChuyenQua_Click(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cboTuPhong))
            {
                XtraMessageBox.Show("Bạn chưa chọn phòng chuyển đi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.bComboIsNull(cboDenPhong))
            {
                XtraMessageBox.Show("Bạn chưa chọn phòng chuyển đến", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cboTuPhong.uEditValue.Equals(cboDenPhong.uEditValue))
            {
                XtraMessageBox.Show("Không thể chuyển do 2 phòng giống nhau",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            DataTable dtTu = dtgTu.GetDataSource();            
            DataRow[] dr = dtTu.Select("CHON=1");
            if (dr.Length == 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn nhân viên nào", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (XtraMessageBox.Show("Bạn có thật sự muốn chuyển ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cboTuPhong.Tag = "..TuPhong";
                        cboDenPhong.Tag = "..DenPhong";
                        cnn.BeginTransaction();
                        bool bExist = false;
                        foreach (DataRow r in dr)
                        {
                            txtNhanSu.uText = cnn.sNull2String(r["NhanSu"]);
                            string sSQL = cnn.UpdateDataSQLComm(this, "NS_ChuyenPhong", "", ref bExist, true);
                            int i = cnn.SQL_ExecuteNonQuery(sSQL);
                            if (i <= 0)
                            {
                                cnn.RollbackTransaction();
                                XtraMessageBox.Show("Chuyển phòng thất bại ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cboTuPhong.Tag = "";
                                cboDenPhong.Tag = "";
                                cboTuPhong_uEditValueChanged(null, null);
                            }
                            string sSQL2 = "Update NS_NhanSu set PHONGBAN=N'" + cnn.sNull2String(cboDenPhong.uEditValue) + "' where NhanSu=" + cnn.sNull2Int(r["NhanSu"]);
                            i = cnn.SQL_ExecuteNonQuery(sSQL2);
                            if (i <= 0)
                            {
                                cnn.RollbackTransaction();
                                XtraMessageBox.Show("Chuyển phòng thất bại ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cboTuPhong.Tag = "";
                                cboDenPhong.Tag = "";
                                cboTuPhong_uEditValueChanged(null, null);
                            }
                        }
                        cnn.EndTransaction();
                        cboTuPhong_uEditValueChanged(null, null);
                        cboDenPhong_uEditValueChanged(null, null);
                        cboTuPhong.Tag = "";
                        cboDenPhong.Tag = "";
                        LoadDanhSachChuyenPhong();
                    }
                    catch
                    {
                        cnn.RollbackTransaction();
                        XtraMessageBox.Show("Chuyển phòng thất bại ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboTuPhong.Tag = "";
                        cboDenPhong.Tag = "";
                        cboTuPhong_uEditValueChanged(null, null);
                    }
                }
            }
        }

        private void dtgTu_uDataSourceChanged(object sender, EventArgs e)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtgTu.Columns)
            {
                if (col.Name != dtgTu.Columns["CHON"].Name)
                    col.OptionsColumn.AllowEdit = false;
            }
        }

        private void dtgDen_uDataSourceChanged(object sender, EventArgs e)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtgDen.Columns)
            {
                if (col.Name != dtgDen.Columns["CHON"].Name)
                    col.OptionsColumn.AllowEdit = false;
            }
        }

        private void btnChuyenLai_Click(object sender, EventArgs e)
        {
            if (cnn.bComboIsNull(cboTuPhong))
            {
                XtraMessageBox.Show("Bạn chưa chọn phòng chuyển đi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cnn.bComboIsNull(cboDenPhong))
            {
                XtraMessageBox.Show("Bạn chưa chọn phòng chuyển đến", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboTuPhong.uEditValue.Equals(cboDenPhong.uEditValue))
            {
                XtraMessageBox.Show("Không thể chuyển do 2 phòng giống nhau", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }            
            DataTable dtDen = dtgDen.GetDataSource();
            DataRow[] dr = dtDen.Select("CHON=1");
            if (dr.Length == 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn nhân viên nào", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (XtraMessageBox.Show("Bạn có thật sự muốn chuyển ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cboTuPhong.Tag = "..DenPhong";
                        cboDenPhong.Tag = "..TuPhong";
                        cnn.BeginTransaction();
                        bool bExist = false;
                        foreach (DataRow r in dr)
                        {
                            txtNhanSu.uText = cnn.sNull2String(r["NhanSu"]);
                            string sSQL = cnn.UpdateDataSQLComm(this, "NS_ChuyenPhong", "", ref bExist, true);
                            int i = cnn.SQL_ExecuteNonQuery(sSQL);
                            if (i <= 0)
                            {
                                cnn.RollbackTransaction();
                                XtraMessageBox.Show("Chuyển phòng thất bại ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cboTuPhong.Tag = "";
                                cboDenPhong.Tag = "";
                                cboTuPhong_uEditValueChanged(null, null);
                            }
                            string sSQL2 = "Update NS_NhanSu set PHONGBAN=N'" + cnn.sNull2String(cboTuPhong.uEditValue) + "' where NhanSu=" + cnn.sNull2Int(r["NhanSu"]);
                            i = cnn.SQL_ExecuteNonQuery(sSQL2);
                            if (i <= 0)
                            {
                                cnn.RollbackTransaction();
                                XtraMessageBox.Show("Chuyển phòng thất bại ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cboTuPhong.Tag = "";
                                cboDenPhong.Tag = "";
                                cboTuPhong_uEditValueChanged(null, null);
                            }
                        }
                        cnn.EndTransaction();
                        cboTuPhong_uEditValueChanged(null, null);
                        cboDenPhong_uEditValueChanged(null, null);
                        cboTuPhong.Tag = "";
                        cboDenPhong.Tag = "";
                        LoadDanhSachChuyenPhong();
                    }
                    catch
                    {
                        cnn.RollbackTransaction();
                        XtraMessageBox.Show("Chuyển phòng thất bại ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboTuPhong.Tag = "";
                        cboDenPhong.Tag = "";
                        cboDenPhong_uEditValueChanged(null, null);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int iChuyenPhong;
            try
            {
                iChuyenPhong = cnn.sNull2Int(dtg.CurRow["ChuyenPhong"]);
            }
            catch             
            {

                iChuyenPhong = 0;
            }
            if (iChuyenPhong == 0) return;
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa dữ liệu này không ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = cnn.SQL_ExecuteNonQuery("Delete NS_ChuyenPhong where ChuyenPhong=" + iChuyenPhong);
                if (i <= 0)
                {
                    XtraMessageBox.Show("Xóa dữ liệu thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                     XtraMessageBox.Show("Xóa dữ liệu thành công",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
                     LoadDanhSachChuyenPhong();
                }
            }
        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            DataTable dt = dtg.GetDataSource();
            BaoCaoTK.frmViewReport frm = new BSC_HRM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\DS_ChuyenPhong.repx", dt);
            frm.Show();
        }
    }
}