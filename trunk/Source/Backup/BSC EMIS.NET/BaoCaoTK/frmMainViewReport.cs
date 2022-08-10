using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using DevExpress.XtraReports.UI;

namespace BSC_HRM.NET.FrReport
{
    public partial class frmMainViewReport : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BSC_Class.BSCConnection cnn = new BSC_Class.BSCConnection(Program.sConnection);
        clsRun clRun = new clsRun();

        XtraReport fReport;
        string fileName = "";
        DataTable dt = new DataTable();
        public frmMainViewReport()
        {
            InitializeComponent();
            clRun.SetValueToControl(this);
            //BaoCaoTK.XReportTemp xNew = new BaoCaoTK.XReportTemp();
            ////xNew.LoadLayout(@"e:\dssv3.repx"); 
            //DataTable dtTmp = cnn.SelectRows(cnn.SelectRows("select SqlRun from HT_SQL_CAU_LENH where MaCauLenh = N'TK_KHEN_THUONG_KY_LUAT_KT'").Rows[0][0].ToString());
            ////DataTable dtTmp = cnn.SelectRows("Select top 100 ROW_NUMBER() OVER (ORDER BY SinhVien) AS STT, HoDem,Ten,MaSinhVien As MaSo,dbo.GioiTinh(GioiTinh) as GioiTinh,dbo.NgaySinh(NgaySinh,ThangSinh,NamSinh) as NamSinh from EM_HS_SinhVien");
            //xNew.DataSource = dtTmp;
            //ReportMain.PrintingSystem = xNew.PrintingSystem;
            //xNew.CreateDocument();
        }


        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (System.IO.File.Exists(fileName))
            {
                frmReportDesign frm = new frmReportDesign(fileName, dt);
                frm.Show();
            }
            else
            {
                frmReportDesign frm = new frmReportDesign();
                frm.Show();
            }
        }

        private void LoadNodeRoot()
        {
            DataTable dt = cnn.SelectRows("SELECT * FROM HT_NHOMBAOCAO WHERE SHOW = 1");
            if (dt == null || dt.Rows.Count <= 0) return;
            navBarControl1.Groups.Clear();
            navBarControl1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                DevExpress.XtraNavBar.NavBarGroup grp = new DevExpress.XtraNavBar.NavBarGroup(cnn.sNull2String(row["TENNHOMBAOCAO"]));
                grp.Tag = cnn.sNull2String(row["NHOMBAOCAO"]);
                LoadDSBaoCao(grp);
                navBarControl1.Groups.Add(grp);
                //GetChildNode(node);
            }
        }
        private void LoadDSBaoCao(DevExpress.XtraNavBar.NavBarGroup grp)
        {
            DataTable DTT1 = cnn.SelectRows("SELECT * FROM HT_BAOCAO WHERE SHOW =1 AND NHOMBAOCAO ='" + (string)grp.Tag + "'");
            if (DTT1 == null || DTT1.Rows.Count <= 0) return;
            foreach (DataRow row in DTT1.Rows)
            {
                DevExpress.XtraNavBar.NavBarItem item = new DevExpress.XtraNavBar.NavBarItem(cnn.sNull2String(row["TENBAOCAO"]));
                item.Tag = row["BAOCAO"];
                grp.ItemLinks.Add(item);
            }
        }
        private void frmMainViewReport_Load(object sender, EventArgs e)
        {
            LoadNodeRoot();
        }

        private void LoadBaoCao(string Tag_BC)
        {
            string sSQL = "select THAMSO, tenfile from ht_baocao where baocao = '" + Tag_BC + "' and show = 1";
            DataTable ddt = cnn.SelectRows(sSQL);
            if(ddt == null)
                return;
            DataRow r = ddt.Rows[0];
            string sql = cnn.GetSQLString(r["THAMSO"].ToString());
            if(sql == "" || sql == null)
                return;
            if(uLop1.Value.sLop != "" && uLop1.Value.sLop != null)
            {
                sql = "select * from (" + sql + ")A where MaLopHoc = N'" + uLop1.Value.sLop.ToString() + "'";
            }
            dt = cnn.SelectRows(sql);
            if(dt == null)
                return;
            if (dt.Rows.Count < 1)
                return;
            fileName = Path.Combine(Application.StartupPath + @"\Report\" , r["tenfile"].ToString() + ".repx");
            XtraReport xrep = new XtraReport();
            PrintReport(fileName, dt);
        }

        private void navBarControl1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            barButtonItem1.Caption = e.Link.Group.Caption + " / " + e.Link.Item.Caption;
            LoadBaoCao(e.Link.Item.Tag.ToString());
        }

        public static string GetReportPath(DevExpress.XtraReports.UI.XtraReport fReport, string ext)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string repName = fReport.Name;
            if (repName.Length == 0) repName = fReport.GetType().Name;
            string dirName = Path.GetDirectoryName(asm.Location);
            return Path.Combine(dirName, repName + "." + ext);
        }
       
        /*
        public XtraReport Report
        {
            get { return fReport; }
            set
            {
                if (fReport != value)
                {
                    if (fReport != null)
                        fReport.Dispose();
                    fReport = value;
                    if (fReport == null)
                        return;
                    printingSystem.ClearContent();
                    Invalidate();
                    Update();
                    fileName = GetReportPath(fReport, "repx");
                    fReport.PrintingSystem = printingSystem;
                    fReport.CreateDocument(true);
                }
            }
        }
        */

        private void PrintReport(string filename_rep, DataTable dtDataSource)
        {
            XtraReport fReport = new XtraReport();
            fReport.LoadLayout(filename_rep);
            fReport.DataSource = dtDataSource;
            fReport.RequestParameters = false;
            this.Text = filename_rep;
            DataTable dtInf = cnn.SelectRows("select * from ht_hethong");
            if (dtInf.Rows.Count != 0)
            {
                try
                {
                    fReport.Parameters["par_COQUANCHUQUAN"].Value = dtInf.Rows[0]["COQUANCHUQUAN"].ToString().ToUpper();
                }
                catch { }
                try
                {
                    fReport.Parameters["par_TENCOQUAN"].Value = dtInf.Rows[0]["TENCOQUAN"].ToString().ToUpper();
                }
                catch { }
                try
                {
                    fReport.Parameters["par_DIENTHOAI"].Value = dtInf.Rows[0]["DIENTHOAI"];
                }
                catch { }
                try
                {
                    fReport.Parameters["par_DIACHI"].Value = dtInf.Rows[0]["DIACHI"];
                }
                catch { }
                try
                {
                    fReport.Parameters["par_DIADIEM"].Value = dtInf.Rows[0]["DIADIEM"];
                }
                catch { }
                try
                {
                    fReport.Parameters["par_NGAYKY"].Value = dtInf.Rows[0]["DIADIEM"] + ", ngày ... tháng ... năm 20...";
                }
                catch { }
                try
                {
                    fReport.Parameters["par_NOW"].Value = dtInf.Rows[0]["DIADIEM"] + ", ngày " + DateTime.Now.Day.ToString("00") + " tháng " + DateTime.Now.Month.ToString("00") + " năm " + DateTime.Now.Year;
                }
                catch { }
                try
                {
                    fReport.Parameters["par_HIEUTRUONG"].Value = dtInf.Rows[0]["HIEUTRUONG"];
                }
                catch { }
                try
                {
                    fReport.Parameters["par_TPTAIVU"].Value = dtInf.Rows[0]["TPTAIVU"];
                }
                catch { }
                try
                {
                    fReport.Parameters["par_TPDAOTAO"].Value = dtInf.Rows[0]["TPDAOTAO"];
                }
                catch { }
                try
                {
                    fReport.Parameters["par_TPQLSV"].Value = dtInf.Rows[0]["TPQLSV"];
                }
                catch { }
            }
            //fReport.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Parameters);
            ReportMain.PrintingSystem = fReport.PrintingSystem;
            //fReport.AfterPrint += new EventHandler(fReport_AfterPrint);
            fReport.BeforePrint += new System.Drawing.Printing.PrintEventHandler(fReport_BeforePrint);
            fReport.CreateDocument(true);
        }

        void fReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        void fReport_AfterPrint(object sender, EventArgs e)
        {
            
        }
    }
}