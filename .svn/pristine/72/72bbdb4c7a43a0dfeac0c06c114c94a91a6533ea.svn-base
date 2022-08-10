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

namespace BSC_HRM.NET.FrHT.FrND
{
    public partial class frmPhanQuyenSuDung : DevExpress.XtraEditors.XtraForm
    {
        BSC_Class.BSCConnection cnn = new BSC_Class.BSCConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        
        public frmPhanQuyenSuDung(DevExpress.XtraBars.Ribbon.RibbonControl ribControl, DevExpress.XtraBars.Ribbon.ApplicationMenu ApMenu)
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
            //#region Phạm Vi
            //DataTable dtPhamVi = cnn.SelectRows("SELECT MaKhoa, TenKhoa FROM DM_Khoa");
            //foreach (DataRow drGroupPV in dtPhamVi.Rows)
            //{
            //    treePhamVi.FocusedNode = treePhamVi.AppendNode(drGroupPV["TenKhoa"].ToString(), null);
            //    TreeListNode t1 = treePhamVi.FocusedNode;
            //    t1.Tag = "PV" + drGroupPV["MaKhoa"].ToString();
            //    t1.SetValue("TenKhoa", drGroupPV["TenKhoa"].ToString().ToUpper());
            //    //foreach (DataRow drItem in dtItem.Rows)
            //    //{
            //    //    if (drItem["MaNhom"].ToString().Equals(drGroup["MaNhom"].ToString()))
            //    //    {
            //    //        treePhamVi.FocusedNode = treePhamVi.AppendNode(drItem["DanhMuc"].ToString(), t1);
            //    //        treePhamVi.FocusedNode.Tag = "I" + drItem["MaDanhMuc"].ToString();
            //    //        treePhamVi.FocusedNode.SetValue("DANH_MUC", drItem["DanhMuc"].ToString());
            //    //    }
            //    //}
            //}
            //treePhamVi.MoveFirst();
            //  #endregion
            //DevExpress.XtraBars.Ribbon.ApplicationMenu ApMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu();
            #region Menu Dọc
            foreach (object objItem in ApMenu.ItemLinks)
            {
                if (objItem.GetType().FullName.Equals("DevExpress.XtraBars.BarButtonItemLink"))
                {
                    DevExpress.XtraBars.BarButtonItemLink btnItem = (DevExpress.XtraBars.BarButtonItemLink)objItem;
                    treeMENU_DOC.FocusedNode = treeMENU_DOC.AppendNode(btnItem.Caption.ToUpper(), null);
                    treeMENU_DOC.FocusedNode.Tag = btnItem.Item.Name;
                    treeMENU_DOC.FocusedNode.SetValue("MENU_DOC", btnItem.Caption.ToUpper());
                }
                else
                {
                    if (objItem.GetType().FullName.Equals("DevExpress.XtraBars.BarSubItemLink"))
                    {
                        DevExpress.XtraBars.BarSubItemLink btnItemLink = (DevExpress.XtraBars.BarSubItemLink)objItem;
                        treeMENU_DOC.FocusedNode = treeMENU_DOC.AppendNode(btnItemLink.Caption.ToUpper(), null);
                        treeMENU_DOC.FocusedNode.SetValue("MENU_DOC", btnItemLink.Caption.ToUpper());
                        TreeListNode t1 = treeMENU_DOC.FocusedNode;
                        t1.Tag = btnItemLink.Item.Name;
                        foreach (DevExpress.XtraBars.BarButtonItemLink btnItemAdd in btnItemLink.Item.ItemLinks)
                        {
                            treeMENU_DOC.FocusedNode = treeMENU_DOC.AppendNode(btnItemAdd.Caption, t1);
                            treeMENU_DOC.FocusedNode.SetValue("MENU_DOC", btnItemAdd.Caption);
                            treeMENU_DOC.FocusedNode.Tag = btnItemAdd.Item.Name;
                        }
                    }
                }
            }
            treeMENU_DOC.MoveFirst();
            #endregion
            #region TenQuyen
            DataTable dtTenQuyen = cnn.SelectRows("SELECT MaQuyen, TenQuyen FROM HT_QuyenHeThong");
            foreach (DataRow drGroupPV in dtTenQuyen.Rows)
            {
                treeQuyenSD.FocusedNode = treeQuyenSD.AppendNode(drGroupPV["TenQuyen"].ToString(), null);
                TreeListNode t1 = treeQuyenSD.FocusedNode;
                t1.Tag = drGroupPV["MaQuyen"].ToString();
                t1.SetValue("TenQuyen", drGroupPV["TenQuyen"].ToString().ToUpper());
            }
            treeQuyenSD.MoveFirst();
               #endregion
            treeDANH_MUC.CollapseAll();
            treeMENU_NGANG.CollapseAll();
            treeMENU_DOC.CollapseAll();
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


        private string CheckDanhMuc(TreeListNodes tlnNode)
        {
            string sCHECK = "";
            foreach (TreeListNode trTmp in tlnNode)
            {
                if (trTmp.CheckState != CheckState.Unchecked)
                {
                    string aa = trTmp.GetDisplayText("PERMIT");
                    sCHECK += "|" + trTmp.Tag.ToString() + "|=" + (trTmp.CheckState == CheckState.Checked ? "1" : "2") + "-" +
                        (cnn.sNull2String(trTmp.GetValue(DANH_MUC_UPDATE)) == "True" ? "1" : "0") + "|;";
                    if (trTmp.Nodes.Count > 0)
                        sCHECK += CheckDanhMuc(trTmp.Nodes);
                }
            }
            return sCHECK;
        }

        private string CheckQuyenSD(TreeListNodes tlnNode)
        {
            string sCHECK = "";
            foreach (TreeListNode trTmp in tlnNode)
            {
                if (trTmp.CheckState == CheckState.Checked)
                {
                    string aa = trTmp.GetDisplayText("PERMIT");
                    sCHECK += "|" + cnn.sNull2String(trTmp.Tag) + "|=";
                    sCHECK += (trTmp.CheckState == CheckState.Checked ? "1" : "2") + "-" + 
                        (cnn.sNull2String(trTmp.GetValue(QUYEN_THEM)) == "True" ? "1" : "0") + "-" +
                        (cnn.sNull2String(trTmp.GetValue(QUYEN_SUA)) == "True" ? "1" : "0") + "-" + 
                        (cnn.sNull2String(trTmp.GetValue(QUYEN_XOA)) == "True" ? "1" : "0") + "|;";
                    if (trTmp.Nodes.Count > 0)
                        sCHECK += CheckQuyenSD(trTmp.Nodes);
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
        
        private void AllCheck(TreeListNodes tlnNode)
        {
            foreach (TreeListNode trTmp in tlnNode)
            {
                trTmp.CheckState = CheckState.Checked;
                if (trTmp.Nodes.Count > 0)
                    AllCheck(trTmp.Nodes);
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

        private void SetDanhMuc(TreeListNodes tlnNode, string sPermit)
        {
            foreach (TreeListNode trTmp in tlnNode)
            {
                string sPTmp = "|" + trTmp.Tag.ToString() + "|";
                int a = sPermit.IndexOf(sPTmp);
                if (a >= 0)
                {
                    string Quyen = sPermit.Substring(sPermit.IndexOf(sPTmp) + sPTmp.Length + 1, 3);
                    string DM_Show = Quyen.Substring(0, 1);
                    string DM_Update = Quyen.Substring(2, 1);
                    if (DM_Show == "1")
                    {
                        trTmp.CheckState = CheckState.Checked;
                        trTmp.SetValue(DANH_MUC_UPDATE, (DM_Update == "1" ? true : false));
                    }
                    else
                    {
                        trTmp.CheckState = CheckState.Indeterminate;
                    }
                }
                if (trTmp.Nodes.Count > 0)
                    SetDanhMuc(trTmp.Nodes, sPermit);
            }
        }

        private void SetQuyenSD(TreeListNodes tlnNode, string sPermit)
        {
            foreach (TreeListNode trTmp in tlnNode)
            {
                string sPTmp = "|" + trTmp.Tag.ToString() + "|";
                int a = sPermit.IndexOf(sPTmp);
                if (a >= 0)
                {
                    string Quyen = sPermit.Substring(sPermit.IndexOf(sPTmp) + sPTmp.Length + 1, 7);
                    string Q_Show = Quyen.Substring(0, 1);
                    string Q_Them = Quyen.Substring(2, 1);
                    string Q_Sua = Quyen.Substring(4, 1);
                    string Q_Xoa = Quyen.Substring(6, 1);
                    if (Q_Show == "1")
                    {
                        trTmp.CheckState = CheckState.Checked;
                        trTmp.SetValue(QUYEN_THEM, (Q_Them == "1" ? true : false));
                        trTmp.SetValue(QUYEN_SUA, (Q_Sua == "1" ? true : false));
                        trTmp.SetValue(QUYEN_XOA, (Q_Xoa == "1" ? true : false));
                    }
                    else
                    {
                        trTmp.CheckState = CheckState.Indeterminate;
                    }
                }
                if (trTmp.Nodes.Count > 0)
                    SetQuyenSD(trTmp.Nodes, sPermit);
            }
        }

        private void frmTaoNguoiDung_Load(object sender, EventArgs e)
        {
            DataTable dtVal = cnn.SelectRows("SELECT * FROM HT_NGUOIDUNG");
            cbxNGUOIDUNG.DataBindings.Add("EditValue", dtVal, "NGUOIDUNG");
            cbxNGUOIDUNG.Properties.DataSource = dtVal;
        }

        private void btnLuuQuyen_Click(object sender, EventArgs e)
        {
            if (cbxNGUOIDUNG.EditValue.ToString().Trim().Length <= 0)
                return;
            if (Properties.Settings.Default.USER_ID == cbxNGUOIDUNG.EditValue.ToString() && cbxNGUOIDUNG.EditValue.ToString() == "3") //nếu người dùng = 3 là tài khoản Quản trị thì ta không cho lưu phân quyền.
            {
                XtraMessageBox.Show(this, "Bạn không thể phân quyền cho chính bạn", "Lưu quyền người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Hashtable Val = new Hashtable();
            Val.Add("MENU_NGANG", CheckPermit(treeMENU_NGANG.Nodes));
            Val.Add("DANH_MUC", CheckDanhMuc(treeDANH_MUC.Nodes));
            Val.Add("MENU_DOC", CheckPermit(treeMENU_DOC.Nodes));
            Val.Add("QUYEN", CheckQuyenSD(treeQuyenSD.Nodes));
           // Val.Add("LINH_VUC", CheckPermit(treePhamVi.Nodes));
            Val.Add("QUYENPHANQUYEN", chkQuyenPhanQuyen.Checked);
            Hashtable Con = new Hashtable();
            Con.Add("NGUOIDUNG", cbxNGUOIDUNG.EditValue.ToString());
            if (cnn.UpdateRows(Val, Con, "HT_NGUOIDUNG"))
                XtraMessageBox.Show(this, "Quyền cho người dùng đã được lưu lại thành công", "Lưu quyền người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(this, "Không thể lưu quyền cho người dùng mà bạn đã chọn được", "Lưu quyền người dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbxNGUOIDUNG_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ClearCheck(treeDANH_MUC.Nodes);
                ClearCheck(treeMENU_NGANG.Nodes);
                ClearCheck(treeMENU_DOC.Nodes);
                ClearCheck(treeQuyenSD.Nodes);
               // ClearCheck(treePhamVi.Nodes); 
                Hashtable Con = new Hashtable();
                Con.Add("NGUOIDUNG", cbxNGUOIDUNG.EditValue.ToString());
                DataRow dtTmp = cnn.SelectRows(Con, "HT_NGUOIDUNG").Rows[0];
                chkQuyenPhanQuyen.Checked = (bool)dtTmp["QUYENPHANQUYEN"];
                string strPermit = dtTmp["DANH_MUC"].ToString();
                SetDanhMuc(treeDANH_MUC.Nodes, strPermit);
                strPermit = dtTmp["MENU_NGANG"].ToString();
                SetPermit(treeMENU_NGANG.Nodes, strPermit);
                strPermit = dtTmp["MENU_DOC"].ToString();
                SetPermit(treeMENU_DOC.Nodes, strPermit);
                strPermit = dtTmp["QUYEN"].ToString();
                SetQuyenSD(treeQuyenSD.Nodes, strPermit);
                strPermit = dtTmp["LINH_VUC"].ToString();
                //SetPermit(treePhamVi.Nodes, strPermit);
            }
            catch { }
        }

        private void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnQTD_Click(object sender, EventArgs e)
        {
            BSC_HRM.NET.HeThong.FrND.frmPopupQuyenTuongTuong frm = new BSC_HRM.NET.HeThong.FrND.frmPopupQuyenTuongTuong();
            frm.NguoiDung = cbxNGUOIDUNG.EditValue.ToString();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cbxNGUOIDUNG_EditValueChanged(sender, e);
            }

        }

        private void ckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAll.Checked)
            {
                switch (tabQuyen.SelectedTabPage.Name)
                {
                    case "xtraTabPage1":
                        AllCheck(treeQuyenSD.Nodes);
                        break;
                    case "xtraTabPage2":
                        AllCheck(treeMENU_NGANG.Nodes);
                        break;
                    case "xtraTabPage3":
                        AllCheck(treeMENU_DOC.Nodes);
                        break;
                    case "xtraTabPage4":
                        AllCheck(treeDANH_MUC.Nodes);
                        break;
                    //case "xtraTabPage5":
                    //    AllCheck(treePhamVi.Nodes);
                    //    break;
                    default:
                        AllCheck(treeDANH_MUC.Nodes);
                        AllCheck(treeMENU_NGANG.Nodes);
                        AllCheck(treeMENU_DOC.Nodes);
                        AllCheck(treeQuyenSD.Nodes);
                        //AllCheck(treePhamVi.Nodes);
                        break;
                }

            }
            else
            {
                switch (tabQuyen.SelectedTabPage.Name)
                {
                    case "xtraTabPage1":
                        ClearCheck(treeQuyenSD.Nodes);
                        break;
                    case "xtraTabPage2":
                        ClearCheck(treeMENU_NGANG.Nodes);
                        break;
                    case "xtraTabPage3":
                        ClearCheck(treeMENU_DOC.Nodes);
                        break;
                    case "xtraTabPage4":
                        ClearCheck(treeDANH_MUC.Nodes);
                        break;
                    //case "xtraTabPage5":
                    //    ClearCheck(treePhamVi.Nodes);
                    //    break;
                    default:
                        ClearCheck(treeDANH_MUC.Nodes);
                        ClearCheck(treeMENU_NGANG.Nodes);
                        ClearCheck(treeMENU_DOC.Nodes);
                        ClearCheck(treeQuyenSD.Nodes);
                       // ClearCheck(treePhamVi.Nodes);
                        break;
                }
            }
        }
    }
}