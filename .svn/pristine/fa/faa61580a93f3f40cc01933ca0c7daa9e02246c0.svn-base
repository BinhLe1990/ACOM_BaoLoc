using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.TimKiem
{
    public partial class frmTimKiemNhanSu : DevExpress.XtraEditors.XtraForm
    {
        public frmTimKiemNhanSu()
        {
            InitializeComponent();
            clsrun.SetValueToControl(this);
            dtg.sKEY = sKEY;
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clsrun = new clsRun();
        string sKEY = "HOSONHANSU";
        public DataRow[] Rows;
        public int iNhanSu = 0;
        private void cbxPhongBan_uEditValueChanged(object sender, EventArgs e)
        {
            string sSQL = "Select MADONVI,TENDONVI from DM_DONVI where MAPHONGBAN=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "'";
            DataTable DT = cnn.DT_DataTable(sSQL);
            cbxDonVi.uDataSource = DT;
        }
        public string sListNotIn = "";
        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            string sSQL = cnn.GetSQLString(sKEY);
            string sCond = "";
            if(!cnn.bComboIsNull(cbxCoSo))
                sCond += " COSO=N'"+cnn.sNull2String(cbxCoSo.uEditValue)+"' AND ";
            if (!cnn.bComboIsNull(cbxPhanHe))
                sCond += " PHANHE=N'" + cnn.sNull2String(cbxPhanHe.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxPhongBan))
                sCond += " PHONGBAN=N'" + cnn.sNull2String(cbxPhongBan.uEditValue) + "' AND ";
            if (!cnn.bComboIsNull(cbxDonVi))
                sCond += " DONVI=N'" + cnn.sNull2String(cbxDonVi.uEditValue) + "' AND ";
            if (sCond != "")
            {
                sCond = sCond.Substring(0, sCond.Length - 4);
                sSQL = "Select * from (" + sSQL + ")BBBB Where " + sCond;
                if (sListNotIn != "")
                    sSQL += " AND NHANSU Not in (" + sListNotIn + ")";
            }
            else
            {                
                if (sListNotIn != "")
                    sSQL = "Select * from (" + sSQL + ")BBBB Where  NHANSU Not in (" + sListNotIn + ")";
            }            
            DataTable DT = cnn.DT_DataTable(sSQL);
            dtg.uDataSource = DT;
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in dtg.Columns)
            {
                if (col.FieldName != "Chon")
                    col.OptionsColumn.AllowEdit = false;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                Rows = dtg.GetDataSource().Select("Chon=1");
                this.DialogResult = DialogResult.OK;
            }
            catch { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtg_uDoubleClick(object sender, EventArgs e)
        {
            try
            {
                iNhanSu = cnn.sNull2Int(dtg.CurRow["NhanSu"]);
                if (iNhanSu > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch { }
        }
    }
}