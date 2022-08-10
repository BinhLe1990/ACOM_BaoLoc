using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DELFI_WHM.NET.Models;

namespace DELFI_WHM.NET.BaoCao
{
    public partial class frmTonKho : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string Ngay;
        string Vitri = "";
        string SanPham = "";
        string Lot = "";
        
        public frmTonKho()
        {
            InitializeComponent();
        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

        private void Search()
        {
            Ngay = Convert.ToDateTime(dtpTuNgay.uValue).ToString("yyyy-MM-dd");          
            
            if (!cnn.bComboIsNull(cboVitri))
            {
                Vitri = cboVitri.uEditValue.ToString();
            }  
            else
            {
                Vitri = "";
            }
            if (!cnn.bComboIsNull(cboSanPham))
            {
                SanPham = cboSanPham.uEditValue.ToString();
            }
            else
            {
                SanPham = "";
            }
            if (!cnn.bComboIsNull(cboLot))
            {
                Lot = cboLot.uEditValue.ToString();
            }
            else
            {
                Lot = "";
            }

            var Thamso_1 = new Dictionary<String, String>() { { "Ngay", Ngay }, { "BinCode", Vitri }, { "ItemNo", SanPham }, { "Lot", Lot } , {"Type", "1" } };
            pivotGridControl1.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_TonKho", Thamso_1);

            var Thamso_2 = new Dictionary<String, String>() { { "Ngay", Ngay }, { "BinCode", Vitri }, { "ItemNo", SanPham }, { "Lot", Lot }, { "Type", "2" } };
            pivotGridControl2.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_TonKho", Thamso_2);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (Tab.SelectedTabPage == Tab_all)
            {
                dt = (DataTable)pivotGridControl1.DataSource;
                if (dt != null)
                {
                    BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_TonKho.repx", dt);
                    frm.Show();
                }
            }
            if (Tab.SelectedTabPage == Tab_BinCode)
            {
                dt = (DataTable)pivotGridControl2.DataSource;
                if (dt != null)
                {
                    BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_TonKho_BinCode.repx", dt);
                    frm.Show();
                }
            }
        }

        private void cboVitri_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var q = db.DM_Pile.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("BinCode");
                dt = ConvertToDataTable(q);
                cboVitri.uDataSource = dt;
            }
            
        }

        private void cboSanPham_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var data = db.tblItems.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ItemNo");
                dt.Columns.Add("ItemName");
                dt = ConvertToDataTable(data);
                cboSanPham.uDataSource = dt;
            }

        }

        private void cboLot_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var Lot = db.DM_Lot.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Lot");
                dt = ConvertToDataTable(Lot);
                cboLot.uDataSource = dt;
            }
        }

        private void frmTonKho_Load(object sender, EventArgs e)
        {
            dtpTuNgay.uValue = cnn.GetDateServer();            
            Search();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

    }
}
