using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace DELFI_WHM.NET.FrHT.FrND
{
    public partial class frmTaoNhomNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_Class.DELFIConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        public frmTaoNhomNguoiDung(DevExpress.XtraBars.Ribbon.RibbonControl ribControl)
        {
            InitializeComponent();
            #region Menu Ngang
            foreach (DevExpress.XtraBars.Ribbon.RibbonPage ribPage in ribControl.Pages)
            {
                treeMENU_NGANG.FocusedNode = treeMENU_NGANG.AppendNode(ribPage.Text, null);
                TreeListNode t1 = treeMENU_NGANG.FocusedNode;
                t1.Tag = ribPage.Name;
                t1.SetValue("MENU_NGANG", ribPage.Text.ToUpper());
                foreach (DevExpress.XtraBars.Ribbon.RibbonPageGroup ribGroup in ribPage.Groups)
                {
                    treeMENU_NGANG.FocusedNode = treeMENU_NGANG.AppendNode(ribGroup.Text, t1);
                    TreeListNode t2 = treeMENU_NGANG.FocusedNode;
                    t2.Tag = ribGroup.Name;
                    t2.SetValue("MENU_NGANG", ribGroup.Text);
                    foreach (object objItem in ribGroup.ItemLinks)
                    {
                        if (objItem.GetType().FullName.Equals("DevExpress.XtraBars.BarButtonItemLink"))
                        {
                            DevExpress.XtraBars.BarButtonItemLink btnItem = (DevExpress.XtraBars.BarButtonItemLink)objItem;
                            treeMENU_NGANG.FocusedNode = treeMENU_NGANG.AppendNode(btnItem.Caption, t2);
                            treeMENU_NGANG.FocusedNode.SetValue("MENU_NGANG", btnItem.Caption);
                            treeMENU_NGANG.FocusedNode.Tag = btnItem.Item.Name;
                        }
                        else
                        {
                            if (objItem.GetType().FullName.Equals("DevExpress.XtraBars.BarSubItemLink"))
                            {
                                DevExpress.XtraBars.BarSubItemLink btnItemLink = (DevExpress.XtraBars.BarSubItemLink)objItem;
                                treeMENU_NGANG.FocusedNode = treeMENU_NGANG.AppendNode(btnItemLink.Caption, t2);
                                treeMENU_NGANG.FocusedNode.SetValue("MENU_NGANG", btnItemLink.Caption);
                                TreeListNode t3 = treeMENU_NGANG.FocusedNode;
                                t3.Tag = btnItemLink.Item.Name;
                                foreach (DevExpress.XtraBars.BarButtonItemLink btnItemAdd in btnItemLink.Item.ItemLinks)
                                {
                                    treeMENU_NGANG.FocusedNode = treeMENU_NGANG.AppendNode(btnItemAdd.Caption, t3);
                                    treeMENU_NGANG.FocusedNode.SetValue("MENU_NGANG", btnItemAdd.Caption);
                                    treeMENU_NGANG.FocusedNode.Tag = btnItemAdd.Item.Name;
                                }
                            }
                        }
                    }
                }
            }
            treeMENU_NGANG.MoveFirst();
            #endregion
            #region Danh mục
            DataTable dtGroup = cnn.SelectRows("SELECT MaNhom, NhomDanhMuc FROM HT_NhomDanhMuc WHERE MaNhom IN (SELECT MaNhom FROM HT_DanhSachDanhMuc) ORDER BY MaNhom");
            DataTable dtItem = cnn.SelectRows("SELECT MaNhom, MaDanhMuc, DanhMuc, TableLink FROM HT_DanhSachDanhMuc WHERE MaNhom IN (SELECT MaNhom FROM HT_NhomDanhMuc) ORDER BY MaNhom, MaDanhMuc");
            foreach (DataRow drGroup in dtGroup.Rows)
            {
                treeDANH_MUC.FocusedNode = treeDANH_MUC.AppendNode(drGroup["NhomDanhMuc"].ToString(), null);
                TreeListNode t1 = treeDANH_MUC.FocusedNode;
                t1.Tag = "G" + drGroup["MaNhom"].ToString();
                t1.SetValue("DANH_MUC", drGroup["NhomDanhMuc"].ToString().ToUpper());
                foreach (DataRow drItem in dtItem.Rows)
                {
                    if (drItem["MaNhom"].ToString().Equals(drGroup["MaNhom"].ToString()))
                    {
                        treeDANH_MUC.FocusedNode = treeDANH_MUC.AppendNode(drItem["DanhMuc"].ToString(), t1);
                        treeDANH_MUC.FocusedNode.Tag = "I" + drItem["MaDanhMuc"].ToString();
                        treeDANH_MUC.FocusedNode.SetValue("DANH_MUC", drItem["DanhMuc"].ToString());
                    }
                }
            }
            treeDANH_MUC.MoveFirst();
            #endregion
            treeDANH_MUC.CollapseAll();
            treeMENU_NGANG.CollapseAll();
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
        private void btnTroLai_Click(object sender, EventArgs e)
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
            string strQUYEN = CheckPermit(treeMENU_NGANG.Nodes);
            Hashtable Val = new Hashtable();
            Val.Add("QUYEN", strQUYEN);
            Hashtable Con = new Hashtable();
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
        private void btnLuuQuyen_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.uText.Trim().Length <= 0)
                return;
            Hashtable Val = new Hashtable();
            Val.Add("MENU_NGANG", CheckPermit(treeMENU_NGANG.Nodes));
            Val.Add("DANH_MUC", CheckPermit(treeDANH_MUC.Nodes));
            Hashtable Con = new Hashtable();
            Con.Add("TENNHOM", txtTaiKhoan.uText);
            if (cnn.UpdateRows(Val, Con, "HT_NHOMNGUOIDUNG"))
                XtraMessageBox.Show(this, "Quyền cho nhóm người dùng đã được lưu lại thành công", "Lưu quyền nhóm người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(this, "Không thể lưu quyền cho nhóm người dùng mà bạn đã chọn được", "Lưu quyền nhóm người dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}