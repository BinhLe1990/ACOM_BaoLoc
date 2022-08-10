using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Export;
using DevExpress.XtraExport;

namespace DELFI_WHM.NET.DELFI_Class
{
    public partial class frmExport : DevExpress.XtraEditors.XtraForm
    {
        string _sDir = string.Empty;
        IExportProvider _provider;
        DevExpress.XtraGrid.Views.Grid.GridView _gridViewExport;
        public frmExport(IExportProvider provider, DevExpress.XtraGrid.Views.Grid.GridView gridViewExport, string sDir)
        {
            InitializeComponent();
            _sDir = sDir;
            _provider = provider;
            _gridViewExport = gridViewExport;
            Export();
        }
        private void Export_Progress(object sender, DevExpress.XtraGrid.Export.ProgressEventArgs e)
        {
            if (e.Phase == DevExpress.XtraGrid.Export.ExportPhase.Link)
            {
                progressBarControl1.Position = e.Position;
                this.Update();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void OpenFile()
        {
                try
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = _sDir;
                    process.StartInfo.Verb = "Open";
                    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                    process.Start();
                }
                catch
                {
                    XtraMessageBox.Show(this, "Không tìm thấy file mà bạn đã lưu để mở", "Mở file đã lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void Export()
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            this.FindForm().Refresh();
            BaseExportLink link = _gridViewExport.CreateExportLink(_provider);
            (link as GridViewExportLink).ExpandAll = false;
            link.Progress += new DevExpress.XtraGrid.Export.ProgressEventHandler(Export_Progress);
            link.ExportTo(true);
            _provider.Dispose();
            link.Progress -= new DevExpress.XtraGrid.Export.ProgressEventHandler(Export_Progress);
            Cursor.Current = currentCursor;
            btnClose.Enabled = true;
            btnOpen.Enabled = true;
            btnOpen.Focus();
        }
    }
}