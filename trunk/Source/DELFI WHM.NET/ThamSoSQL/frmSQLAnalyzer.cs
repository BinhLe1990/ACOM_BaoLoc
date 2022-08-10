using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils;
using DevExpress.Tutorials.Controls;

namespace DELFI_WHM.NET.FrSYS
{
    public partial class frmSQLAnalyzer : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_Class.DELFIConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        public frmSQLAnalyzer()
        {
            InitializeComponent();
            DataTable dtTABLE_NAME = cnn.SelectRows("SELECT [NAME] FROM sys.Tables ORDER BY [NAME]");
            foreach (DataRow drGroup in dtTABLE_NAME.Rows)
            {
                if (navBarMain.Groups.Count <= 0)
                {
                    DevExpress.XtraNavBar.NavBarGroup nvGroup = new DevExpress.XtraNavBar.NavBarGroup(drGroup["NAME"].ToString().Substring(0, 2));
                    nvGroup.Name = "G" + drGroup["NAME"].ToString().Substring(0, 2);
                    nvGroup.Tag = drGroup["NAME"].ToString().Substring(0, 2);
                    nvGroup.Caption = "BẢNG DỮ LIỆU " + nvGroup.Name.Replace("GDM", "[DANH MỤC]").Replace("GHT", "[HỆ THỐNG]").Replace("GNS", "[NHÂN SỰ]");
                    navBarMain.Groups.Add(nvGroup);
                }
                else
                {
                    if (!drGroup["NAME"].ToString().Substring(0, 2).Equals(navBarMain.Groups[navBarMain.Groups.Count - 1].Name.Substring(1, 2)))
                    {
                        DevExpress.XtraNavBar.NavBarGroup nvGroup = new DevExpress.XtraNavBar.NavBarGroup(drGroup["NAME"].ToString().Substring(0, 2));
                        nvGroup.Name = "G" + drGroup["NAME"].ToString().Substring(0, 2);
                        nvGroup.Tag = drGroup["NAME"].ToString().Substring(0, 2);
                        nvGroup.Caption = "BẢNG DỮ LIỆU " + nvGroup.Name.Replace("GDM", "[DANH MỤC]").Replace("GHT", "[HỆ THỐNG]").Replace("GNS", "[NHÂN SỰ]");
                        navBarMain.Groups.Add(nvGroup);
                    }
                }
                DevExpress.XtraNavBar.NavBarItem nvItem = new DevExpress.XtraNavBar.NavBarItem(drGroup["NAME"].ToString());
                nvItem.Name = "I" + drGroup["NAME"].ToString();
                navBarMain.Groups[navBarMain.Groups.Count - 1].ItemLinks.Add(nvItem);
            }
        }
        private void btnKiemTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int i = cnn.ExecuteNonQuery(txtSQLQurey.Text);
            if (i >= 0)
            {
                mmoRes.Text = i.ToString() + " dữ liệu.";
            }
            else
            {
                if (null != cnn.LastError)
                    mmoRes.Text = cnn.LastError.ToString();
                else
                    mmoRes.Text = "Câu lệnh phù hợp.";
            }
        }

        private void btnExcute_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mmoRes.Text = "";
            try
            {
                gridView1.Columns.Clear();
                int iEx = cnn.ExecuteNonQuery(txtSQLQurey.Text);
                if (txtSQLQurey.Text.Trim().Substring(0, 14).ToUpper() == "TRUNCATE TABLE")
                {
                    mmoRes.Text = "Command(s) completed successfully.";
                }
                else
                {
                    if (iEx < 0)
                        mmoRes.Text = "Câu lệnh sai hoặc câu lệnh không phải là câu lệnh dùng để thực thi";
                    else
                        mmoRes.Text = iEx.ToString("N0") + " dòng dữ liệu.";
                }
                xtraTabControl1.SelectedTabPageIndex = 1;
            }
            catch
            {
                mmoRes.Text = cnn.LastError.Message;
                xtraTabControl1.SelectedTabPageIndex = 1;
            }
        }

        private void btnToMau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show(txtSQLQurey.RtfText);
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mmoRes.Text = "";
            DataTable dt = new DataTable();
            try
            {
                dt = cnn.SelectRows(txtSQLQurey.Text, DELFI_WHM.NET.DELFI_Class.DELFIConnection.BSCLoadType.UseLoadProcess);
                gridView1.Columns.Clear();
                gridControl1.DataSource = dt;
                mmoRes.Text = dt.Rows.Count.ToString("N0") + " dòng dữ liệu.";
                xtraTabControl1.SelectedTabPageIndex = 0;
            }
            catch
            {
                mmoRes.Text = cnn.LastError.Message;
                xtraTabControl1.SelectedTabPageIndex = 1;
            }
        }

        private void navBarMain_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                txtKey.EditValue = e.Link.Item.Caption;
                txtMoTa.EditValue = e.Link.Item.Caption;
                DataTable dt = new DataTable();
                try
                {
                    DataTable dtDataTable = cnn.SelectRows("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.Columns WHERE TABLE_NAME = '" + e.Link.Item.Caption + "'");
                    string sCol = "";
                    foreach (DataRow drTmp in dtDataTable.Rows)
                    {
                        sCol += @"\f1\fs20\par\pard\plain\ql{\f1\fs20\cf0 \tab }{\f1\fs20\cf0 " + drTmp["COLUMN_NAME"].ToString() + ", " + "}";
                    }
                    sCol = sCol.Substring(0, sCol.Length - 3) + "}";
                    txtSQLQurey.RtfText = @"{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}{\f1 Courier New;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}}{\sectd\pard\plain\ql{\f1\fs20\cf1 S}{\f1\fs20\cf1 ELECT}{\f1\fs20\cf0  }" + sCol + @"\f1\fs20\par\pard\plain\ql{\f1\fs20\cf1 F}{\f1\fs20\cf1 ROM}{\f1\fs20\cf0  }\f1\fs20\par\pard\plain\ql{\f1\fs20\cf0 \tab }{\f1\fs20\cf0 " + e.Link.Item.Caption.ToUpper() + @"}\par}}";
                    dt = cnn.SelectRows("select * from " + e.Link.Item.Caption, DELFI_WHM.NET.DELFI_Class.DELFIConnection.BSCLoadType.UseLoadProcess);
                    gridView1.Columns.Clear();
                    gridControl1.DataSource = dt;
                    mmoRes.Text = dt.Rows.Count.ToString("N0") + " dòng dữ liệu.";
                    xtraTabControl1.SelectedTabPageIndex = 0;
                }
                catch
                {
                    mmoRes.Text = cnn.LastError.Message;
                    xtraTabControl1.SelectedTabPageIndex = 1;
                }
            }
            catch { }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ribbonControl1.Minimized = !ribbonControl1.Minimized;
        }

        private void frmSQLAnalyzer_Load(object sender, EventArgs e)
        {

        }
    }
}
