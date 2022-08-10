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
    public partial class frmTongHop : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string Tungay, Denngay, Ca, SanPham;
        
        public frmTongHop()
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
            Tungay = Convert.ToDateTime(dtpTuNgay.uValue).ToString("yyyy-MM-dd");
            Denngay = Convert.ToDateTime(dtpDenngay.uValue).ToString("yyyy-MM-dd");

            if (!cnn.bComboIsNull(cboShift))
            {
                Ca = cboShift.uEditValue.ToString();
            }
            else
            {
                Ca = "";
            }
            
            if (!cnn.bComboIsNull(cboSanPham))
            {
                SanPham = cboSanPham.uEditValue.ToString();
            }
            else
            {
                SanPham = "";
            }
            var Thamso = new Dictionary<String, String>() { { "Tungay", Tungay }, { "Denngay", Denngay }, { "Shift", Ca }, { "ItemNo", SanPham } };
            pivotGridControl1.DataSource = cnn.SQL_GetStoredProcedure("SP_BC_TongHop", Thamso);
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

        private void cboShift_uQueryPopUp(object sender, CancelEventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var q = (from p in db.DM_Lot
                         group p by p.Shift into g
                         select new { Shift = g.Key }).ToList();
                if (q.Count > 0)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Shift");
                    dt = ConvertToDataTable(q);
                    cboShift.uDataSource = dt;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();            
            dt = (DataTable)pivotGridControl1.DataSource;           
           
            if (dt != null)
            {
                BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\BC_TongHop.repx", dt);
                frm.Show();
               
            }
        }

        private void frmTongHop_Load(object sender, EventArgs e)
        {
            dtpTuNgay.uValue = cnn.GetDateServer();
            dtpDenngay.uValue = cnn.GetDateServer();            
            Search();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

    }
}
