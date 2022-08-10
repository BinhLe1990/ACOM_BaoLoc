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
using DevExpress.XtraExport;
using System.Xml;
using System.IO;

namespace DELFI_WHM.NET.FrSYS
{
    public partial class frmThamSoSQL : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_Class.DELFIConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        public frmThamSoSQL()
        {
            InitializeComponent();
            CreateItemView();
        }
        public frmThamSoSQL(string ThamSo)
        {
            InitializeComponent();
            CreateItemView();
            txtKey.EditValue = ThamSo;
            DataTable dtItem = cnn.SelectRows("SELECT MaCauLenh, MoTa, SqlDoc FROM HT_SQL_CAU_LENH WHERE MaCauLenh = N'" + txtKey.EditValue.ToString() + "'");
            if (dtItem.Rows.Count == 0)
                return;
            txtSQLQurey.RtfText = dtItem.Rows[0]["SqlDoc"].ToString();
            txtMoTa.EditValue = dtItem.Rows[0]["MoTa"];

            navBarMain.SelectedLink = navBarMain.Items["I"+dtItem.Rows[0]["MaCauLenh"].ToString()].Links[0];
        }
        private void CreateItemView()
        {
            navBarMain.Items.Clear();
            navBarMain.Groups.Clear();
            DataTable dtGroup = cnn.SelectRows("SELECT MaNhom, NhomCauLenh FROM HT_SQL_NHOM_CAU_LENH");
            DataTable dtItem = cnn.SelectRows("SELECT MaNhom, MaCauLenh, MoTa, SqlDoc FROM HT_SQL_CAU_LENH WHERE MaNhom IN (SELECT MaNhom FROM HT_SQL_NHOM_CAU_LENH) ORDER BY MaNhom, MaCauLenh");
            string sPermit = Properties.Settings.Default.PER_DANH_MUC;
            string sPTmp = "";
            foreach (DataRow drGroup in dtGroup.Rows)
            {
                sPTmp = "|" + "G" + drGroup["MaNhom"].ToString() + "|";
                //if (sPermit.IndexOf(sPTmp) >= 0)
                {
                    DevExpress.XtraNavBar.NavBarGroup nvGroup = new DevExpress.XtraNavBar.NavBarGroup(drGroup["NhomCauLenh"].ToString());
                    nvGroup.Name = "G" + drGroup["MaNhom"].ToString();
                    nvGroup.Tag = drGroup["MaNhom"].ToString();
                    navBarMain.Groups.Add(nvGroup);
                    foreach (DataRow drItem in dtItem.Rows)
                    {
                        sPTmp = "|" + "I" + drItem["MaCauLenh"].ToString() + "|";
                        //if (sPermit.IndexOf(sPTmp) >= 0)
                        {
                            if (drItem["MaNhom"].ToString().Equals(drGroup["MaNhom"].ToString()))
                            {
                                DevExpress.XtraNavBar.NavBarItem nvItem = new DevExpress.XtraNavBar.NavBarItem(drItem["MoTa"].ToString());
                                nvItem.Name = "I" + drItem["MaCauLenh"].ToString();
                                try
                                {
                                    nvItem.Tag = drItem["SqlDoc"].ToString();
                                }
                                catch { nvItem.Tag = string.Empty; }
                                nvItem.CanDrag = false;
                                nvGroup.ItemLinks.Add(nvItem);
                            }
                        }
                    }
                }
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
            DataTable dt = new DataTable();
            try
            {
                dt = cnn.SelectRows(txtSQLQurey.Text,  DELFI_WHM.NET.DELFI_Class.DELFIConnection.BSCLoadType.UseLoadProcess);
                gridView1.Columns.Clear();
                gridControl1.DataSource = dt;
                mmoRes.Text = dt.Rows.Count.ToString("N0") + " dòng dữ liệu.";
                gridView1.BestFitColumns();
                xtraTabControl1.SelectedTabPageIndex = 0;
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
            if ((txtKey.EditValue == null) || (txtKey.EditValue.ToString().Trim().Length <= 0))
            {
                XtraMessageBox.Show(this, "Bạn chưa nhập thông tin Key của câu lệnh", "Lưu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((txtMoTa.EditValue == null) || (txtMoTa.EditValue.ToString().Trim().Length <= 0))
            {
                XtraMessageBox.Show(this, "Bạn chưa nhập thông tin mô tả của câu lệnh", "Lưu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Hashtable Val = new Hashtable();
            Val.Add("MaCauLenh", txtKey.EditValue.ToString());
           
            try
            {
                if (cnn.SelectRows(Val, "HT_SQL_CAU_LENH").Rows.Count > 0)
                {
                    if (XtraMessageBox.Show(this, "Thông tin câu lệnh mà bạn nhập đã tồn tại rồi. Bạn có muốn cập nhật lại không? ", "Lưu thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    else
                    {
                        Hashtable Valu2 = new Hashtable();
                        foreach (DevExpress.XtraNavBar.NavBarGroup gTmp in navBarMain.Groups)
                        {
                            if (gTmp.Expanded)
                                Valu2.Add("MaNhom", gTmp.Name.Substring(1));
                        }
                        Valu2.Add("MoTa", txtMoTa.EditValue.ToString());
                        Valu2.Add("SqlRun", txtSQLQurey.Text);
                        Valu2.Add("SqlDoc", txtSQLQurey.RtfText);
                        if (cnn.UpdateRows(Valu2, Val, "HT_SQL_CAU_LENH"))
                        {
                            XtraMessageBox.Show(this, "Thông tin đã được cập nhật thành công", "Lưu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //CreateItemView();
                            return;
                        }
                        XtraMessageBox.Show(this, "Không thể lưu thông tin mà bạn đã nhập được", "Lưu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch { }
            foreach (DevExpress.XtraNavBar.NavBarGroup gTmp in navBarMain.Groups)
            {
                if(gTmp.Expanded)
                    Val.Add("MaNhom", gTmp.Name.Substring(1));
            }
            Val.Add("MoTa", txtMoTa.EditValue.ToString());
            Val.Add("SqlRun", txtSQLQurey.Text);
            Val.Add("SqlDoc", txtSQLQurey.RtfText);
            if (cnn.InsertNewRow(Val, "HT_SQL_CAU_LENH"))
            {
                XtraMessageBox.Show(this, "Thông tin đã được cập nhật thành công", "Lưu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //CreateItemView();
                return;
            }
            XtraMessageBox.Show(this, "Không thể lưu thông tin mà bạn đã nhập được", "Lưu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void navBarMain_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                txtSQLQurey.RtfText = e.Link.Item.Tag.ToString();
                txtKey.EditValue = e.Link.Item.Name.Substring(1);
                txtMoTa.EditValue = e.Link.Item.Caption;
            }
            catch { }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ribbonControl1.Minimized = !ribbonControl1.Minimized;
        }

        private string ShowSaveFileDialog(string title, string filter)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Export To " + title;
            dlg.FileName = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");
            dlg.Filter = filter;
            if (dlg.ShowDialog() == DialogResult.OK)
                return dlg.FileName;
            return "";
        }
        private System.Data.DataSet DS_DataSet()
        {
            System.Data.DataSet ds = new System.Data.DataSet("BAOCAO");
            System.Data.DataTable DTT = DT_DataTable_Filter_Dtg();
            try
            {
                ds.Tables.Add(DTT);
            }
            catch
            {
            }
            finally
            {
                //ds.Tables.Remove(DTT);
            }
            return (ds);
        }
        private System.Data.DataTable DT_DataTable_Filter_Dtg()
        {
            System.Data.DataTable DTT = new System.Data.DataTable();
            try
            {
                DataView dv = null;
                if (gridView1.DataSource is DataView)
                {
                    dv = (DataView)gridView1.DataSource;
                }
                else if (gridView1.DataSource is DataTable)
                {
                    dv = ((System.Data.DataTable)(gridView1.DataSource)).DefaultView;
                }
                if (dv != null)
                {
                    DTT = dv.Table.Clone();
                    for (int ii = 0; ii < dv.Count; ii++)
                    {
                        DTT.ImportRow(dv[ii].Row);
                    }
                    DTT.DefaultView.AllowNew = false;
                }
                else
                {
                    DTT = null;
                }
            }
            catch
            {
            }
            return (DTT);
        }

        private System.Data.DataTable DT_DataTable()
        {
            System.Data.DataTable DTT = new System.Data.DataTable();
            try
            {
                DataView dv = null;
                if (gridView1.DataSource is DataView)
                {
                    dv = (DataView)gridView1.DataSource;
                    if (dv != null)
                    {
                        DTT = dv.Table;
                    }
                }
                else if (gridView1.DataSource is DataTable)
                {
                    DTT = (System.Data.DataTable)(gridView1.DataSource);
                }

            }
            catch
            {
            }
            return (DTT);
        }
        private void btnExportXml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string XMLfileName = ShowSaveFileDialog("XML Document", "XML Files|*.XML");
            if (XMLfileName == "")
                return;
            //    (new frmExport(new ExportXmlProvider(XMLfileName), gridView1, XMLfileName)).ShowDialog();

            #region Tạo file XML để đưa vào CrystalReport (cách của .NET 2003)
            if (gridView1.DataSource == null)
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
                (new DELFI_Class.frmExport(new ExportHtmlProvider(HTMLfileName), gridView1, HTMLfileName)).ShowDialog();
        }
        private void btnExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string XLSfileName = ShowSaveFileDialog("Microsoft Excel Document", "Excel Files|*.XLS");
            if (XLSfileName != "")
                (new DELFI_Class.frmExport(new ExportXlsProvider(XLSfileName), gridView1, XLSfileName)).ShowDialog();
        }
        private void btnExportTxt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string TXTfileName = ShowSaveFileDialog("Text Document", "Text Files|*.TXT");
            if (TXTfileName != "")
                (new DELFI_Class.frmExport(new ExportTxtProvider(TXTfileName), gridView1, TXTfileName)).ShowDialog();
        }

        private void txtKey_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dtItem = cnn.SelectRows("SELECT MaCauLenh, MoTa, SqlDoc FROM HT_SQL_CAU_LENH WHERE MaCauLenh = N'"+txtKey.EditValue.ToString()+"'");
            if(dtItem.Rows.Count == 0)
                return;
            txtSQLQurey.RtfText = dtItem.Rows[0]["SqlDoc"].ToString();
            txtMoTa.EditValue = dtItem.Rows[0]["MoTa"];
        }

        private void navBarMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void navBarMain_DragDrop(object sender, DragEventArgs e)
        {
        }

        private string ShowSaveFileDialog()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "XML";
            dlg.OverwritePrompt = true;
            dlg.Filter = "XML|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
                return dlg.FileName;
            return "";
        }

        private string ShowOpenFileDialog()
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Title = "XML";
            openFD.Filter = "XML|*.xml";
            if (openFD.ShowDialog() == DialogResult.OK)
                return openFD.FileName;
            return "";
        }
        
        private void btnXuatXML_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string Path = ShowSaveFileDialog();
                DataSet ds = cnn.CreateDataset("Select * from HT_SQL_CAU_LENH");
                StreamWriter xmlDoc = new StreamWriter(Path, false);
                ds.WriteXml(xmlDoc);
                xmlDoc.Close();
                XtraMessageBox.Show("Export thành công :\n" + Path, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                XtraMessageBox.Show("Export thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDocXML_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Hashtable Val = new Hashtable();
                Hashtable Cond = new Hashtable();
                string Path = ShowOpenFileDialog();
                DataSet ds = new DataSet();
                StreamReader xmlDoc;
                try
                {
                    xmlDoc = new StreamReader(Path, false);
                }
                catch
                {
                    XtraMessageBox.Show("Không tìm thấy file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ds.ReadXml(xmlDoc);
                DataTable DT = new DataTable();
                DT = ds.Tables[0];
                if (DT != null && DT.Rows.Count > 0)
                {
                    foreach (DataRow r in DT.Rows)
                    {
                        Cond.Clear();
                        Val.Clear();
                        Cond.Add("MaCauLenh", r["MaCauLenh"]);
                        if (cnn.SelectRows(Cond, "HT_SQL_CAU_LENH").Rows.Count > 0)
                        {
                            Val.Add("SqlRun", r["SqlRun"]);
                            cnn.UpdateRows(Val, Cond, "HT_SQL_CAU_LENH");
                        }
                        else
                        {
                            Val.Add("MaNhom", r["MaNhom"]);
                            Val.Add("MaCauLenh", r["MaCauLenh"]);
                            Val.Add("MoTa", r["MoTa"]);
                            Val.Add("SqlRun", r["SqlRun"]);
                            Val.Add("SqlDoc", r["SqlDoc"]);
                            cnn.InsertNewRow(Val, "HT_SQL_CAU_LENH");
                        }
                    }
                    XtraMessageBox.Show("Import thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                XtraMessageBox.Show("Import thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDocThamSo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string sPath = "", NhomDanhMuc = "";
            DELFI_WHM.NET.ThamSoSQL.frmPopupNhapThamSo frm = new DELFI_WHM.NET.ThamSoSQL.frmPopupNhapThamSo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                sPath = frm.txtDuongDan.uText.ToString();
                NhomDanhMuc = frm.cbxNhomDanhMuc.uEditValue.ToString();
            }
            if (sPath != "" && NhomDanhMuc != "")
            {
                string[] PathFiles = Directory.GetFiles(sPath);
                string[] NameFile = new string[PathFiles.Length];
                for (int i = 0; i < PathFiles.Length; i++)
                {
                    string[] a = PathFiles[i].Split(new string[] { "\\" }, StringSplitOptions.None);
                    NameFile[i] = a[a.Length - 1].Replace(".rtf", "");
                }

                System.Windows.Forms.RichTextBox rtBox = new System.Windows.Forms.RichTextBox();
                String rtfText = "";
                Hashtable Val = new Hashtable();
                Hashtable Cond = new Hashtable();
                try
                {
                    for (int i = 0; i < PathFiles.Length; i++)
                    {
                        string s = System.IO.File.ReadAllText(PathFiles[i]);
                        rtBox.Rtf = s;
                        rtfText = rtBox.Text;
                        Cond.Clear();
                        Cond.Add("MaCauLenh", NameFile[i]);
                        if (cnn.SelectRows(Cond, "HT_SQL_CAU_LENH").Rows.Count > 0)
                        {
                            Val.Clear();
                            Val.Add("SqlRun", rtfText);
                            Val.Add("SqlDoc", s);
                            cnn.UpdateRows(Val, Cond, "HT_SQL_CAU_LENH");
                        }
                        else
                        {
                            Val.Clear();
                            Val.Add("MaNhom", NhomDanhMuc);
                            Val.Add("MaCauLenh", NameFile[i]);
                            Val.Add("MoTa", NameFile[i]);
                            Val.Add("SqlRun", rtfText);
                            Val.Add("SqlDoc", s);
                            cnn.InsertNewRow(Val, "HT_SQL_CAU_LENH");
                        }
                    }
                    XtraMessageBox.Show("Cập nhật thành công");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Cập nhật thất bại\n" + ex.Message);
                }
            }
        }
    }
}