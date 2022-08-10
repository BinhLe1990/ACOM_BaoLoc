using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using BSC_EMIS.NET.BSC_Class;
using System.Drawing.Drawing2D;
using DevExpress.XtraExport;
using System.Data.SqlClient;

namespace BSC_EMIS.NET.BSC_User_Control
{
    public partial class uGridMenu : DevExpress.XtraGrid.GridControl
    {

        public uGridMenu()
        {
            InitializeComponent();
        }
        #region Object
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnDesignGrid;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarSubItem btnExport;
        private DevExpress.XtraBars.BarButtonItem btnExportExcel;
        private DevExpress.XtraBars.BarButtonItem btnExportTxt;
        private DevExpress.XtraBars.BarButtonItem btnExportXml;
        private DevExpress.XtraBars.BarButtonItem btnExportHtml;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.PopupMenu popupMnu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        #endregion

        private DevExpress.XtraGrid.GridControl GridMain;

        private string ShowSaveFileDialog(string title, string filter)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Export To " + title;
            dlg.FileName = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");
            dlg.Filter = filter;
            if (dlg.ShowDialog() == DialogResult.OK) return dlg.FileName;
            return "";
        }


        private void btnExportXml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string XMLfileName = ShowSaveFileDialog("XML Document", "XML Files|*.XML");
            if (XMLfileName == "")
                return;
            //    (new frmExport(new ExportXmlProvider(XMLfileName), gridViewMain, XMLfileName)).ShowDialog();

            #region Tạo file XML để đưa vào CrystalReport (cách của .NET 2003) - không sử dụng
            if (this.DataSource == null)
                return;
            DataTable dt = DT_DataTable_Filter_Dtg();
            if (dt == null) return;
            DataSet DS = new DataSet();
            if (dt.DataSet == null)
            {
                DS = DS_DataSet();
            }
            else
            {
                DS = dt.DataSet;
                DS.Tables[0].TableName = "BAOCAO";
            }
            if (DS == null)
            {
                return;
            }
            DS.WriteXml(XMLfileName);
            DS.WriteXmlSchema(XMLfileName + ".xsd");
            #endregion

        }
        private void btnExportHtml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string HTMLfileName = ShowSaveFileDialog("HTML Document", "HTML Files|*.HTML");
            if (HTMLfileName != "")
                (new frmExport(new ExportHtmlProvider(HTMLfileName), gridViewMain, HTMLfileName)).ShowDialog();
        }
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }
        
    }
}
