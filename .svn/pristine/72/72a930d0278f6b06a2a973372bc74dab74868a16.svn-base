using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BSC_HRM.NET.BSC_Class;

namespace BSC_HRM.NET.BSC_User_Control
{
    public partial class uSearch : DevExpress.XtraEditors.XtraUserControl
    {
        public uSearch()
        {
            InitializeComponent();
        }

        private BSCConnection cnn;
        public BSCConnection BSCConn
        {
            set
            {
                if (value != null)
                {
                    cnn = value;
                }
            }
        }
        public DataTable dt = new DataTable();
        public string sColumnName = "";
        public string sValueType = "";
        [Category("UserDefine"), DefaultValue(75)]
        public int iWidth
        {
            set { txt.iWidth = value; }
            get { return txt.iWidth; }
        }

        [Category("UserDefine")]
        public string uText
        {
            get
            {
                if (txt.uText.Contains(sColumnName))
                    return txt.uText;
                else if (txt.uText.Trim().Length == 0)
                    return "";
                else
                    return sColumnName + sLike(txt.uText);
            }
        }

        public string sLike(string s)
        {
            s = s.Replace("'", "''");
            if (sValueType == "System.String")
                return (" LIKE N'%" + s + "%'");
            else
                return (" LIKE '%" + s + "%'");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            frmDefineCondition ff = new frmDefineCondition(dt, sColumnName);
            int iWith = this.Width;
            if (iWith > ff.Width)
                ff.Width = iWith;
            Point pt = txt.PointToScreen(new Point(0 + txt.iWidth, 0));
            Screen screen = Screen.FromControl(this.FindForm());
            if (pt.X + ff.Width > screen.WorkingArea.Right)
            {
                pt.X = screen.WorkingArea.Right - ff.Width;
            }
            if (pt.Y + ff.Height > screen.WorkingArea.Bottom)
            {
                pt.Y = screen.WorkingArea.Bottom - ff.Height;
            }
            ff.Location = pt;
            ff.sValueType = sValueType;
            if (ff.ShowDialog() == DialogResult.OK)
            {
                txt.uText = ff.sCondition;
            }

        }
    }
}