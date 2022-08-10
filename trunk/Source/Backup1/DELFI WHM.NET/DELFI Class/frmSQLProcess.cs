using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.DELFI_Class
{
    public partial class frmSQLProcess : DevExpress.XtraEditors.XtraForm
    {
        public DataTable reValue = new DataTable();
        DELFIConnection cnn = new DELFIConnection();
        public frmSQLProcess(string ConnectionString, string SelectQueryString)
        {
            InitializeComponent();
            cnn = new DELFIConnection(ConnectionString);
            backgroundWorker1.RunWorkerAsync(SelectQueryString);
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = cnn.SelectRows(e.Argument.ToString());
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            reValue = e.Result as DataTable;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}