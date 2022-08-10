using DELFI_WHM.NET.DELFI_Class;
using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DELFI_WHM.NET.QuanLy
{
    public partial class frmQRCode : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string _Lot = "";
        string _SanPham = "";

        public frmQRCode()
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

        public void Form_Load()
        {
            if (!cnn.bComboIsNull(cboLot))
            {
                _Lot = cboLot.uEditValue.ToString();
            }
            else
            {
                _Lot = "";
            }
            if (!cnn.bComboIsNull(cboMaSanPham))
            {
                _SanPham = cboMaSanPham.uEditValue.ToString();
            }
            else
            {
                _SanPham = "";
            }
            var Thamso = new Dictionary<String, String>() { { "Lot", _Lot }, { "Item", _SanPham } };
            griDanhSach.DataSource = cnn.SQL_GetStoredProcedure("SP_List_QRCode", Thamso);
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                gridView1.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
        }

        public void Intem()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("QRCode");
            dt.Columns.Add("ItemNo");
            dt.Columns.Add("Lot");
            dt.Columns.Add("BinCode");
            dt.Columns.Add("Certificate");
            dt.Columns.Add("PackageCode");
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, "Chon").ToString() == "True")
                {
                    dt.Rows.Add(gridView1.GetRowCellValue(i, "QRCode"),
                                gridView1.GetRowCellValue(i, "ItemNo"),
                                gridView1.GetRowCellValue(i, "Lot"),
                                gridView1.GetRowCellValue(i, "BinCode"),
                                gridView1.GetRowCellValue(i, "Certificate"),
                                gridView1.GetRowCellValue(i, "PackageCode"));
                }
            }
            BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\List_QRCode.repx", dt);
            frm.Show();
        }

        private void btnInTem_Click(object sender, EventArgs e)
        {
            Intem();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void frmQRCode_Load(object sender, EventArgs e)
        {
            Form_Load();
        }


        private void Load_cboMaSanPham()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var it = db.tblItems.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ItemNo");
                dt.Columns.Add("ItemName");
                dt = ConvertToDataTable(it);
                cboMaSanPham.uDataSource = dt;
            }
        }
        private void Load_Lot()
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

        private void cboMaSanPham_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_cboMaSanPham();
        }


        private void cboLot_uQueryPopUp(object sender, CancelEventArgs e)
        {
            Load_Lot();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Form_Load();
        }

        private void chk_All_EditValueChanged(object sender, EventArgs e)
        {
            if (chk_All.Checked == true)
            {
                for (int i = 0; i < gridView1.DataRowCount; i ++)
                {
                    gridView1.SetRowCellValue(i, "Chon", true);
                }
            }
            else
            {
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    gridView1.SetRowCellValue(i, "Chon", false);
                }
            }            
        }

        private void gridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView1.OptionsSelection.MultiSelect = true;
                gridView1.SelectAll();
            }
        }
    }
}
