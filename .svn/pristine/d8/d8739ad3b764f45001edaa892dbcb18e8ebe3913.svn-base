using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BSC_EMIS.NET.BSC_User_Control
{
    public partial class uSearchDT : UserControl
    {
        BSC_Class.BSCConnection cnn = new BSC_Class.BSCConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        public uSearchDT()
        {
            InitializeComponent();
            DataTable dtVal = new DataTable();
            dtVal = cnn.SelectRows("Select * from DM_HeAB");
            cbxHeAB.DataBindings.Add("EditValue", dtVal, "MaHeAB");
            dtVal.Rows.InsertAt(dtVal.NewRow(), 0);
            cbxHeAB.Properties.DataSource = dtVal.Copy();
            dtVal = cnn.SelectRows("Select * from DM_LopHoc");
            cbxLopHoc.DataBindings.Add("EditValue", dtVal, "MaLopHoc");
            dtVal.Rows.InsertAt(dtVal.NewRow(), 0);
            cbxLopHoc.Properties.DataSource = dtVal.Copy();
            dtVal = cnn.SelectRows("Select * from DM_KhoaHoc");
            cbxKhoaHoc.DataBindings.Add("EditValue", dtVal, "Makhoahoc");
            dtVal.Rows.InsertAt(dtVal.NewRow(), 0);
            cbxKhoaHoc.Properties.DataSource = dtVal.Copy();
            dtVal = cnn.SelectRows("Select * from DM_BacDaoTao");
            cbxHeDaoTao.DataBindings.Add("EditValue", dtVal, "MaBacDaoTao");
            dtVal.Rows.InsertAt(dtVal.NewRow(), 0);
            cbxHeDaoTao.Properties.DataSource = dtVal.Copy();
            dtVal = cnn.SelectRows("Select * from DM_Nganh");
            cbxNganhDaoTao.DataBindings.Add("EditValue", dtVal, "MaNganh");
            dtVal.Rows.InsertAt(dtVal.NewRow(), 0);
            cbxNganhDaoTao.Properties.DataSource = dtVal.Copy();
            dtVal = cnn.SelectRows("Select * from DM_LoaiDaoTao");
            cbxLoaiDaiTao.DataBindings.Add("EditValue", dtVal, "MaLoaiDaoTao");
            dtVal.Rows.InsertAt(dtVal.NewRow(), 0);
            cbxLoaiDaiTao.Properties.DataSource = dtVal.Copy();
            dtVal = cnn.SelectRows("Select * from DM_QuocTich");
            cbxQuocTich.DataBindings.Add("EditValue", dtVal, "MaQuocTich");
            dtVal.Rows.InsertAt(dtVal.NewRow(), 0);
            cbxQuocTich.Properties.DataSource = dtVal.Copy();
            dtVal = cnn.SelectRows("Select * from DM_DanToc");
            cbxDanToc.DataBindings.Add("EditValue", dtVal, "MaDanToc");
            dtVal.Rows.InsertAt(dtVal.NewRow(), 0);
            cbxDanToc.Properties.DataSource = dtVal.Copy();
            dtVal = cnn.SelectRows("Select * from DM_TonGiao");
            cbxTonGiao.DataBindings.Add("EditValue", dtVal, "MaTonGiao");
            dtVal.Rows.InsertAt(dtVal.NewRow(), 0);
            cbxTonGiao.Properties.DataSource = dtVal.Copy();
            dtVal = cnn.SelectRows("Select * from DM_ChinhTri");
            cbxMaChinhTri.DataBindings.Add("EditValue", dtVal, "MaChinhTri");
            dtVal.Rows.InsertAt(dtVal.NewRow(), 0);
            cbxMaChinhTri.Properties.DataSource = dtVal.Copy();
            dtVal = cnn.SelectRows("Select * from DM_TinhThanhPho");
            cbxMaTinhThanhPho.DataBindings.Add("EditValue", dtVal, "MaTinhThanhPho");
            dtVal.Rows.InsertAt(dtVal.NewRow(), 0);
            cbxMaTinhThanhPho.Properties.DataSource = dtVal.Copy();
        }

        private void cbxMaTinhThanhPho_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dtVal = cnn.SelectRows("Select * from DM_QuanHuyen where MaTinhThanhPho ='" + cbxMaTinhThanhPho.EditValue.ToString() + "'");
            try
            {
                cbxMaQuanHuyen.DataBindings.Clear();
                dtVal.Rows.InsertAt(dtVal.NewRow(), 0);
                cbxMaQuanHuyen.DataBindings.Add("EditValue", dtVal, "MaQuanHuyen");
            }
            catch { }
            cbxMaQuanHuyen.Properties.DataSource = dtVal.Copy();
        }
        public string GetSearch()
        {
            string sSearch = "";
            foreach (Control ctrTmp in this.tableLayoutPanel1.Controls)
            {
                if (ctrTmp.GetType().Name.Equals("LookUpEdit"))
                {
                    try
                    {
                        LookUpEdit lTmp = ctrTmp as LookUpEdit;
                        if (lTmp.EditValue.ToString().Length > 0)
                            sSearch += " AND " + lTmp.Properties.ValueMember + " = '" + lTmp.EditValue + "'";
                    }
                    catch { }
                }
            }
            if (sSearch.Length > 2)
                return sSearch.Substring(4);
            return "";
        }

        private void cbxKhoaHoc_EditValueChanged(object sender, EventArgs e)
        {
            //LookUpEdit lTmp = ctrTmp as LookUpEdit;
            //if (lTmp.EditValue.ToString().Length > 0)
            //    sSearch += " AND " + lTmp.Properties.ValueMember + " = '" + lTmp.EditValue + "'";
        }
    }
}