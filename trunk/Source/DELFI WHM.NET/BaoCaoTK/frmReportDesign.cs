using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.UserDesigner;

namespace DELFI_WHM.NET.FrReport
{
    public partial class frmReportDesign : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmReportDesign()
        {
            InitializeComponent();
        }

        public frmReportDesign(string sReportPath, DataTable dtValue)
        {
            InitializeComponent();
            this.Text = sReportPath;
            ribbonControl1.ApplicationCaption = "";
            ribbonControl1.ApplicationDocumentCaption = sReportPath;

            xrDesignRibbonController1.XRDesignPanel.OpenReport(sReportPath);
            xrDesignRibbonController1.XRDesignPanel.Report.DataSource = dtValue;
            xrDesignRibbonController1.XRDesignPanel.Report.ShowDesignerHints = false;
            xrDesignRibbonController1.XRDesignPanel.Report.ShowExportWarnings = false;
            xrDesignRibbonController1.XRDesignPanel.Report.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.HundredthsOfAnInch;           
        }
    }
}