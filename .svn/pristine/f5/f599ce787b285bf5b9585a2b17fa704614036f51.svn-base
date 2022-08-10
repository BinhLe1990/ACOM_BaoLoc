using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DELFI_WHM.NET.DELFI_Class;
using System.Collections;

namespace DELFI_WHM.NET.DELFI_User_Control
{
    public partial class uFind : DevExpress.XtraEditors.XtraUserControl
    {
        public uFind()
        {
            InitializeComponent();
        }

        private DELFIConnection cnn;
        public DELFIConnection BSCConn
        {
            set
            {
                if (value != null)
                {
                    cnn = value;
                }
            }
        }

        private string uKEY = "";
        /// <summary>
        /// Điều kiện lọc tìm kiếm
        /// </summary>
        public string sCondition = "";
        public string sKEY
        {
            set
            {
                uKEY = value;
                Load_ThongTin();
            }
            get
            { return uKEY; }
        }

        [Browsable(false), Category("UserDefine"), Description("Form cha chứa DataGrid")]
        public string sFormName
        {
            get { return this.FindForm().Name; }
        }

        DataTable dt = new DataTable();
        DataTable dtValue = new DataTable();
        private void Load_ThongTin()
        {
            try
            {
                grpMain.Controls.Clear();
                Hashtable Val = new Hashtable();
                Val.Add("uFind_name", this.Name);
                Val.Add("Form_name", this.FindForm().Name);
                Val.Add("Parameter", uKEY);
                int uFind_ID = 0;
                DataTable dt = new DataTable();
                dt = cnn.SelectRows(Val, "HT_UFIND_TITLE");
                if (dt.Rows.Count != 0)
                    uFind_ID = cnn.sNull2Int(dt.Rows[0]["uFind_TITLE"].ToString());
                string sWhere = sCondition;
                string sSQL = "";
                if (sWhere.Trim().Length > 0)
                    sSQL = "select * from (" + cnn.GetSQLString(uKEY) + ")A where " + sWhere;
                else
                    sSQL = "select * from (" + cnn.GetSQLString(uKEY) + ")A ";
                //dt = cnn.SelectRows("select * from (" + cnn.GetSQLString(uKEY) + ")A");
                dt = cnn.SelectRows(sSQL);
                DataTable dtt = new DataTable();

                for (int i = dt.Columns.Count - 1; i >= 0; i--)
                {
                    Val.Clear();
                    Val.Add("uFind_TITLE", uFind_ID);
                    Val.Add("Mapping_Name", dt.Columns[i].ColumnName);
                    dtt = cnn.SelectRows(Val, "HT_UFIND");
                    if (dtt.Rows.Count == 0)
                    {
                        uSearch uS = new uSearch();
                        uS.BSCConn = cnn;
                        uS.txt.sCaption = dt.Columns[i].ColumnName;
                        uS.txt.Name = dt.Columns[i].ColumnName;
                        uS.Tag = ".." + dt.Columns[i].ColumnName;
                        uS.Dock = DockStyle.Top;
                        uS.sValueType = dt.Columns[i].DataType.ToString();
                        uS.sColumnName = dt.Columns[i].ColumnName;
                        uS.dt = dt;
                        uS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grpMain_MouseDown);
                        grpMain.Controls.Add(uS);
                    }
                    else
                    {
                        uSearch uS = new uSearch();
                        uS.BSCConn = cnn;
                        uS.txt.sCaption = dtt.Rows[0]["Header_Text"].ToString();
                        uS.txt.Name = dt.Columns[i].ColumnName;
                        uS.Tag = ".." + dt.Columns[i].ColumnName;
                        uS.Dock = DockStyle.Top;
                        uS.Visible = (bool)dtt.Rows[0]["Visible"];
                        uS.iWidth = cnn.sNull2Int(dtt.Rows[0]["Width"].ToString());
                        uS.sColumnName = dt.Columns[i].ColumnName;
                        uS.sValueType = dtt.Rows[0]["Value_Type"].ToString();
                        uS.dt = dt;
                        uS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grpMain_MouseDown);
                        grpMain.Controls.Add(uS);
                    }
                }
            }
            catch { }
        }

        private void uFind_Load(object sender, EventArgs e)
        {
            //Load_ThongTin();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FindForm().Close();
        }

        private void btnClear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cnn.clearControl(grpMain);
        }

        public DataTable dtRefresh()
        {
            try
            {
                return cnn.SelectRows(sSQL, DELFIConnection.BSCLoadType.UseLoadProcess);
            }
            catch { return null; }
        }
        
        private void btnConfig_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUFINDConfig frm = new frmUFINDConfig(this.FindForm().Name, this.uKEY, this.Name);
            frm.ShowDialog();
            Load_ThongTin();
        }

        private void btnTimKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        string sSQL = "";
        public delegate void EventHandler(object sender, System.EventArgs e, DataTable dt);
        public event EventHandler uClick;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (uKEY == "") return;
            try
            {
                sSQL = "";
                string sWhere = sCondition;
                foreach (Control ctrl in grpMain.Controls)
                {
                    if (ctrl is uSearch)
                    {
                        uSearch lbl = (uSearch)ctrl;
                        if (lbl.uText.Trim().Length > 0)
                        {
                            if (sWhere.Trim().Length > 0)
                            {
                                sWhere += " And ";
                            }
                            sWhere += lbl.uText;
                        }
                    }
                }
                //if (cnn.ExistField(cnn.GetSQLString(uKEY), "TaiSan"))
                //{
                //    if (sWhere.Trim().Length > 0)
                //    {
                //        sSQL = "select * from (" + cnn.GetSQLString(uKEY) + ")A where taisan in (select taisan from v_TS where MaChungLoai IN (" + LoadChungLoai() + ") AND (ISNULL(MaPhongBan, '' ) = '' OR MaPhongBan IN (" + LoadPhongBan() + "))) AND " + sWhere;
                //    }
                //    else
                //    {
                //        sSQL = "select * from (" + cnn.GetSQLString(uKEY) + ")A where taisan in (select taisan from v_TS where MaChungLoai IN (" + LoadChungLoai() + ") AND (ISNULL(MaPhongBan, '' ) = '' OR MaPhongBan IN (" + LoadPhongBan() + ")))";
                //    }
                //}
                //else
                //{
                    if (sWhere.Trim().Length > 0)
                    {
                        sSQL = "select * from (" + cnn.GetSQLString(uKEY) + ")A where " + sWhere;
                    }
                    else
                    {
                        sSQL = "select * from (" + cnn.GetSQLString(uKEY) + ")A ";
                    }
                //}
                dtValue = cnn.SelectRows(sSQL, DELFIConnection.BSCLoadType.UseLoadProcess);
                uClick(sender, e, dtValue);
            }
            catch
            {
                throw;
            }
        }

        private void grpMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(MousePosition);
        }
    }
}