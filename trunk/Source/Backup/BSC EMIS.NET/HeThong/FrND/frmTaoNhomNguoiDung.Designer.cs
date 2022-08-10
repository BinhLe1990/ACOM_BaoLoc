namespace BSC_HRM.NET.FrHT.FrND
{
    partial class frmTaoNhomNguoiDung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoNhomNguoiDung));
            this.btnTroLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuQuyen = new DevExpress.XtraEditors.SimpleButton();
            this.grTaiKhoan = new DevExpress.XtraEditors.GroupControl();
            this.txtTaiKhoan = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.tabQuyen = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.treeList4 = new DevExpress.XtraTreeList.TreeList();
            this.QUYEN_SU_DUNG = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.QUYEN_SU_DUNG_TAG = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.treeMENU_NGANG = new DevExpress.XtraTreeList.TreeList();
            this.MENU_NGANG = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.MENU_NGANG_TAG = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.MENU_DOC = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.MENU_DOC_TAG = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.treeDANH_MUC = new DevExpress.XtraTreeList.TreeList();
            this.DANH_MUC = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.DANH_MUC_TAG = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.treeList3 = new DevExpress.XtraTreeList.TreeList();
            this.PHAM_VI = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.PHAM_VI_TAG = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grTaiKhoan)).BeginInit();
            this.grTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabQuyen)).BeginInit();
            this.tabQuyen.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList4)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeMENU_NGANG)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeDANH_MUC)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(413, 48);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(105, 30);
            this.btnTroLai.TabIndex = 2;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnLuuQuyen
            // 
            this.btnLuuQuyen.Location = new System.Drawing.Point(413, 12);
            this.btnLuuQuyen.Name = "btnLuuQuyen";
            this.btnLuuQuyen.Size = new System.Drawing.Size(105, 30);
            this.btnLuuQuyen.TabIndex = 1;
            this.btnLuuQuyen.Text = "Lưu quyền";
            this.btnLuuQuyen.Click += new System.EventHandler(this.btnLuuQuyen_Click);
            // 
            // grTaiKhoan
            // 
            this.grTaiKhoan.Controls.Add(this.txtTaiKhoan);
            this.grTaiKhoan.Location = new System.Drawing.Point(12, 12);
            this.grTaiKhoan.Name = "grTaiKhoan";
            this.grTaiKhoan.Size = new System.Drawing.Size(395, 66);
            this.grTaiKhoan.TabIndex = 0;
            this.grTaiKhoan.Text = "Thông tin nhóm người dùng";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.sCaption = "Tên nhóm";
            this.txtTaiKhoan.sEditMask = "";
            this.txtTaiKhoan.bHAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtTaiKhoan.bIsPassword = false;
            this.txtTaiKhoan.bIsReadOnly = false;
            this.txtTaiKhoan.iMaxLength = 0;
            this.txtTaiKhoan.sNullText = "";
            this.txtTaiKhoan.bUseMask = false;
            this.txtTaiKhoan.uText = "";
            this.txtTaiKhoan.iWidth = 70;
            this.txtTaiKhoan.Location = new System.Drawing.Point(16, 32);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(363, 20);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // tabQuyen
            // 
            this.tabQuyen.Location = new System.Drawing.Point(12, 84);
            this.tabQuyen.Name = "tabQuyen";
            this.tabQuyen.SelectedTabPage = this.xtraTabPage1;
            this.tabQuyen.Size = new System.Drawing.Size(506, 329);
            this.tabQuyen.TabIndex = 2;
            this.tabQuyen.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.treeList4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(497, 298);
            this.xtraTabPage1.Text = "Quyền sử dụng";
            // 
            // treeList4
            // 
            this.treeList4.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.QUYEN_SU_DUNG,
            this.QUYEN_SU_DUNG_TAG});
            this.treeList4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList4.Location = new System.Drawing.Point(0, 0);
            this.treeList4.Name = "treeList4";
            this.treeList4.OptionsBehavior.AllowIndeterminateCheckState = true;
            this.treeList4.OptionsView.EnableAppearanceEvenRow = true;
            this.treeList4.OptionsView.EnableAppearanceOddRow = true;
            this.treeList4.OptionsView.ShowCheckBoxes = true;
            this.treeList4.Size = new System.Drawing.Size(497, 298);
            this.treeList4.TabIndex = 8;
            // 
            // QUYEN_SU_DUNG
            // 
            this.QUYEN_SU_DUNG.Caption = "Quyền sử dụng";
            this.QUYEN_SU_DUNG.FieldName = "QUYEN_SU_DUNG";
            this.QUYEN_SU_DUNG.Name = "QUYEN_SU_DUNG";
            this.QUYEN_SU_DUNG.OptionsColumn.AllowEdit = false;
            this.QUYEN_SU_DUNG.OptionsColumn.AllowMove = false;
            this.QUYEN_SU_DUNG.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.QUYEN_SU_DUNG.OptionsColumn.AllowSort = false;
            this.QUYEN_SU_DUNG.Visible = true;
            this.QUYEN_SU_DUNG.VisibleIndex = 0;
            this.QUYEN_SU_DUNG.Width = 88;
            // 
            // QUYEN_SU_DUNG_TAG
            // 
            this.QUYEN_SU_DUNG_TAG.Caption = "QUYEN_SU_DUNG_TAG";
            this.QUYEN_SU_DUNG_TAG.FieldName = "QUYEN_SU_DUNG_TAG";
            this.QUYEN_SU_DUNG_TAG.Name = "QUYEN_SU_DUNG_TAG";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.treeMENU_NGANG);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(497, 298);
            this.xtraTabPage2.Text = "Menu ngang";
            // 
            // treeMENU_NGANG
            // 
            this.treeMENU_NGANG.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.MENU_NGANG,
            this.MENU_NGANG_TAG});
            this.treeMENU_NGANG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMENU_NGANG.Location = new System.Drawing.Point(0, 0);
            this.treeMENU_NGANG.Name = "treeMENU_NGANG";
            this.treeMENU_NGANG.OptionsBehavior.AllowIndeterminateCheckState = true;
            this.treeMENU_NGANG.OptionsView.EnableAppearanceEvenRow = true;
            this.treeMENU_NGANG.OptionsView.EnableAppearanceOddRow = true;
            this.treeMENU_NGANG.OptionsView.ShowCheckBoxes = true;
            this.treeMENU_NGANG.Size = new System.Drawing.Size(497, 298);
            this.treeMENU_NGANG.TabIndex = 7;
            this.treeMENU_NGANG.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.treeList1_BeforeCheckNode);
            this.treeMENU_NGANG.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeList1_AfterCheckNode);
            // 
            // MENU_NGANG
            // 
            this.MENU_NGANG.Caption = "Quyền trên menu ngang";
            this.MENU_NGANG.FieldName = "MENU_NGANG";
            this.MENU_NGANG.Name = "MENU_NGANG";
            this.MENU_NGANG.OptionsColumn.AllowEdit = false;
            this.MENU_NGANG.OptionsColumn.AllowMove = false;
            this.MENU_NGANG.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.MENU_NGANG.OptionsColumn.AllowSort = false;
            this.MENU_NGANG.Visible = true;
            this.MENU_NGANG.VisibleIndex = 0;
            this.MENU_NGANG.Width = 88;
            // 
            // MENU_NGANG_TAG
            // 
            this.MENU_NGANG_TAG.Caption = "MENU_NGANG_TAG";
            this.MENU_NGANG_TAG.FieldName = "MENU_NGANG_TAG";
            this.MENU_NGANG_TAG.Name = "MENU_NGANG_TAG";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.treeList1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(497, 298);
            this.xtraTabPage3.Text = "Menu dọc";
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.MENU_DOC,
            this.MENU_DOC_TAG});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.AllowIndeterminateCheckState = true;
            this.treeList1.OptionsView.EnableAppearanceEvenRow = true;
            this.treeList1.OptionsView.EnableAppearanceOddRow = true;
            this.treeList1.OptionsView.ShowCheckBoxes = true;
            this.treeList1.Size = new System.Drawing.Size(497, 298);
            this.treeList1.TabIndex = 8;
            // 
            // MENU_DOC
            // 
            this.MENU_DOC.Caption = "Quyền trên menu dọc";
            this.MENU_DOC.FieldName = "MENU_DOC";
            this.MENU_DOC.Name = "MENU_DOC";
            this.MENU_DOC.OptionsColumn.AllowEdit = false;
            this.MENU_DOC.OptionsColumn.AllowMove = false;
            this.MENU_DOC.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.MENU_DOC.OptionsColumn.AllowSort = false;
            this.MENU_DOC.Visible = true;
            this.MENU_DOC.VisibleIndex = 0;
            this.MENU_DOC.Width = 88;
            // 
            // MENU_DOC_TAG
            // 
            this.MENU_DOC_TAG.Caption = "MENU_DOC_TAG";
            this.MENU_DOC_TAG.FieldName = "MENU_DOC_TAG";
            this.MENU_DOC_TAG.Name = "MENU_DOC_TAG";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.treeDANH_MUC);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(497, 298);
            this.xtraTabPage4.Text = "Danh mục";
            // 
            // treeDANH_MUC
            // 
            this.treeDANH_MUC.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.DANH_MUC,
            this.DANH_MUC_TAG});
            this.treeDANH_MUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDANH_MUC.Location = new System.Drawing.Point(0, 0);
            this.treeDANH_MUC.Name = "treeDANH_MUC";
            this.treeDANH_MUC.OptionsBehavior.AllowIndeterminateCheckState = true;
            this.treeDANH_MUC.OptionsView.EnableAppearanceEvenRow = true;
            this.treeDANH_MUC.OptionsView.EnableAppearanceOddRow = true;
            this.treeDANH_MUC.OptionsView.ShowCheckBoxes = true;
            this.treeDANH_MUC.Size = new System.Drawing.Size(497, 298);
            this.treeDANH_MUC.TabIndex = 8;
            this.treeDANH_MUC.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.treeList1_BeforeCheckNode);
            this.treeDANH_MUC.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeList1_AfterCheckNode);
            // 
            // DANH_MUC
            // 
            this.DANH_MUC.Caption = "Quyền trên danh mục";
            this.DANH_MUC.FieldName = "DANH_MUC";
            this.DANH_MUC.Name = "DANH_MUC";
            this.DANH_MUC.OptionsColumn.AllowEdit = false;
            this.DANH_MUC.OptionsColumn.AllowMove = false;
            this.DANH_MUC.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.DANH_MUC.OptionsColumn.AllowSort = false;
            this.DANH_MUC.Visible = true;
            this.DANH_MUC.VisibleIndex = 0;
            this.DANH_MUC.Width = 88;
            // 
            // DANH_MUC_TAG
            // 
            this.DANH_MUC_TAG.Caption = "DANH_MUC_TAG";
            this.DANH_MUC_TAG.FieldName = "DANH_MUC_TAG";
            this.DANH_MUC_TAG.Name = "DANH_MUC_TAG";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.treeList3);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(497, 298);
            this.xtraTabPage5.Text = "Phạm vi";
            // 
            // treeList3
            // 
            this.treeList3.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.PHAM_VI,
            this.PHAM_VI_TAG});
            this.treeList3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList3.Location = new System.Drawing.Point(0, 0);
            this.treeList3.Name = "treeList3";
            this.treeList3.OptionsBehavior.AllowIndeterminateCheckState = true;
            this.treeList3.OptionsView.EnableAppearanceEvenRow = true;
            this.treeList3.OptionsView.EnableAppearanceOddRow = true;
            this.treeList3.OptionsView.ShowCheckBoxes = true;
            this.treeList3.Size = new System.Drawing.Size(497, 298);
            this.treeList3.TabIndex = 8;
            // 
            // PHAM_VI
            // 
            this.PHAM_VI.Caption = "Quyền trên phạm vi";
            this.PHAM_VI.FieldName = "PHAM_VI";
            this.PHAM_VI.Name = "PHAM_VI";
            this.PHAM_VI.OptionsColumn.AllowEdit = false;
            this.PHAM_VI.OptionsColumn.AllowMove = false;
            this.PHAM_VI.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.PHAM_VI.OptionsColumn.AllowSort = false;
            this.PHAM_VI.Visible = true;
            this.PHAM_VI.VisibleIndex = 0;
            this.PHAM_VI.Width = 88;
            // 
            // PHAM_VI_TAG
            // 
            this.PHAM_VI_TAG.Caption = "PHAM_VI_TAG";
            this.PHAM_VI_TAG.FieldName = "PHAM_VI_TAG";
            this.PHAM_VI_TAG.Name = "PHAM_VI_TAG";
            // 
            // frmTaoNhomNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 425);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnLuuQuyen);
            this.Controls.Add(this.tabQuyen);
            this.Controls.Add(this.grTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaoNhomNguoiDung";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo nhóm người dùng";
            ((System.ComponentModel.ISupportInitialize)(this.grTaiKhoan)).EndInit();
            this.grTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabQuyen)).EndInit();
            this.tabQuyen.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList4)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeMENU_NGANG)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeDANH_MUC)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTroLai;
        private DevExpress.XtraEditors.SimpleButton btnLuuQuyen;
        private DevExpress.XtraEditors.GroupControl grTaiKhoan;
        private BSC_HRM.NET.BSC_User_Control.uTextBox txtTaiKhoan;
        private DevExpress.XtraTab.XtraTabControl tabQuyen;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraTreeList.TreeList treeMENU_NGANG;
        private DevExpress.XtraTreeList.Columns.TreeListColumn MENU_NGANG;
        private DevExpress.XtraTreeList.Columns.TreeListColumn MENU_NGANG_TAG;
        private DevExpress.XtraTreeList.TreeList treeList4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn QUYEN_SU_DUNG;
        private DevExpress.XtraTreeList.Columns.TreeListColumn QUYEN_SU_DUNG_TAG;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn MENU_DOC;
        private DevExpress.XtraTreeList.Columns.TreeListColumn MENU_DOC_TAG;
        private DevExpress.XtraTreeList.TreeList treeDANH_MUC;
        private DevExpress.XtraTreeList.Columns.TreeListColumn DANH_MUC;
        private DevExpress.XtraTreeList.Columns.TreeListColumn DANH_MUC_TAG;
        private DevExpress.XtraTreeList.TreeList treeList3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn PHAM_VI;
        private DevExpress.XtraTreeList.Columns.TreeListColumn PHAM_VI_TAG;
    }
}