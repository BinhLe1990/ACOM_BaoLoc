using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using System.Collections;

namespace BSC_EMIS.NET.FrHT
{
    public partial class frmHT_PHAN_QUYEN : DevExpress.XtraEditors.XtraForm
    {
        BSC_Class.BSCConnection cnn = new BSC_Class.BSCConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        public frmHT_PHAN_QUYEN(DevExpress.XtraBars.Ribbon.RibbonControl ribControl)
        {
            InitializeComponent();
            DataTable dtVal = cnn.SelectRows("SELECT * FROM HT_NGUOIDUNG");
            cbxNGUOIDUNG.DataBindings.Add("EditValue", dtVal, "NGUOIDUNG");
            cbxNGUOIDUNG.Properties.DataSource = dtVal;
            foreach (DevExpress.XtraBars.Ribbon.RibbonPage ribPage in ribControl.Pages)
            {
                treePermit.FocusedNode = treePermit.AppendNode(ribPage.Text, null);
                TreeListNode t1 = treePermit.FocusedNode;
                t1.Tag = ribPage.Name;
                t1.SetValue("PERMIT", ribPage.Text.ToUpper());
                foreach (DevExpress.XtraBars.Ribbon.RibbonPageGroup ribGroup in ribPage.Groups)
                {
                    treePermit.FocusedNode = treePermit.AppendNode(ribGroup.Text, t1);
                    TreeListNode t2 = treePermit.FocusedNode;
                    t2.Tag = ribGroup.Name;
                    t2.SetValue("PERMIT", ribGroup.Text);
                    foreach (object objItem in ribGroup.ItemLinks)
                    {
                        if (objItem.GetType().FullName.Equals("DevExpress.XtraBars.BarButtonItemLink"))
                        {
                            DevExpress.XtraBars.BarButtonItemLink btnItem = (DevExpress.XtraBars.BarButtonItemLink)objItem;
                            treePermit.FocusedNode = treePermit.AppendNode(btnItem.Caption, t2);
                            treePermit.FocusedNode.SetValue("PERMIT", btnItem.Caption);
                            treePermit.FocusedNode.Tag = btnItem.Item.Name;
                        }
                        else
                        {
                            if (objItem.GetType().FullName.Equals("DevExpress.XtraBars.BarSubItemLink"))
                            {
                                DevExpress.XtraBars.BarSubItemLink btnItemLink = (DevExpress.XtraBars.BarSubItemLink)objItem;
                                treePermit.FocusedNode = treePermit.AppendNode(btnItemLink.Caption, t2);
                                treePermit.FocusedNode.SetValue("PERMIT", btnItemLink.Caption);
                                TreeListNode t3 = treePermit.FocusedNode;
                                t3.Tag = btnItemLink.Item.Name;
                                foreach (DevExpress.XtraBars.BarButtonItemLink btnItemAdd in btnItemLink.Item.ItemLinks)
                                {
                                    treePermit.FocusedNode = treePermit.AppendNode(btnItemAdd.Caption, t3);
                                    treePermit.FocusedNode.SetValue("PERMIT", btnItemAdd.Caption);
                                    treePermit.FocusedNode.Tag = btnItemAdd.Item.Name;
                                }
                            }
                        }
                    }
                }
            }
        }
        private void treeList1_AfterCheckNode(object sender, NodeEventArgs e)
        {
            SetCheckedChildNodes(e.Node, e.Node.CheckState);
            SetCheckedParentNodes(e.Node, e.Node.CheckState);
        }
        private void treeList1_BeforeCheckNode(object sender, CheckNodeEventArgs e)
        {
            e.State = (e.PrevState == CheckState.Checked ? CheckState.Unchecked : CheckState.Checked);
        }
        private void SetCheckedChildNodes(TreeListNode node, CheckState check)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i].CheckState = check;
                SetCheckedChildNodes(node.Nodes[i], check);
            }
        }
        private void SetCheckedParentNodes(TreeListNode node, CheckState check)
        {
            if (node.ParentNode != null)
            {
                bool b = false;
                CheckState state;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    state = (CheckState)node.ParentNode.Nodes[i].CheckState;
                    if (!check.Equals(state))
                    {
                        b = !b;
                        break;
                    }
                }
                node.ParentNode.CheckState = b ? CheckState.Indeterminate : check;
                SetCheckedParentNodes(node.ParentNode, check);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string CheckPermit(TreeListNodes tlnNode)
        {
            string sCHECK = "";
            foreach (TreeListNode trTmp in tlnNode)
            {
                if (trTmp.CheckState != CheckState.Unchecked)
                {
                    string aa = trTmp.GetDisplayText("PERMIT");
                    sCHECK += "|" + trTmp.Tag.ToString() + "|=" + (trTmp.CheckState == CheckState.Checked ? "1" : "2") + "|;";
                    if (trTmp.Nodes.Count > 0)
                        sCHECK += CheckPermit(trTmp.Nodes);
                }
            }
            return sCHECK;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string strQUYEN = CheckPermit(treePermit.Nodes);
            Hashtable Val = new Hashtable();
            Val.Add("QUYEN", strQUYEN);
            Hashtable Con = new Hashtable();

            Con.Add("NGUOIDUNG", cbxNGUOIDUNG.EditValue);
            if (cnn.UpdateRows(Val, Con, "HT_NGUOIDUNG"))
                XtraMessageBox.Show("Thông tin đã được lưu lại");
            else
                XtraMessageBox.Show("Không thể cập nhật được thông tin mà bạn đã chọn");
        }
        private void ClearCheck(TreeListNodes tlnNode)
        {
            foreach (TreeListNode trTmp in tlnNode)
            {
                trTmp.CheckState = CheckState.Unchecked;
                if (trTmp.Nodes.Count > 0)
                    ClearCheck(trTmp.Nodes);
            }
        }
        private void SetPermit(TreeListNodes tlnNode, string sPermit)
        {
            foreach (TreeListNode trTmp in tlnNode)
            {
                string sPTmp = "|" + trTmp.Tag.ToString() + "|";
                if (sPermit.IndexOf(sPTmp) >= 0)
                    if (sPermit.Substring(sPermit.IndexOf(sPTmp) + sPTmp.Length + 1, 1) == "1")
                        trTmp.CheckState = CheckState.Checked;
                    else
                        trTmp.CheckState = CheckState.Indeterminate;
                if (trTmp.Nodes.Count > 0)
                    SetPermit(trTmp.Nodes, sPermit);
            }
        }
        private void cbxNGUOIDUNG_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Hashtable Con = new Hashtable();
                Con.Add("NGUOIDUNG", cbxNGUOIDUNG.EditValue.ToString());
                string strPermit = cnn.SelectRows(Con, "HT_NGUOIDUNG").Rows[0]["QUYEN"].ToString();
                ClearCheck(treePermit.Nodes);
                SetPermit(treePermit.Nodes, strPermit);
            }
            catch { }
        }
    }
}