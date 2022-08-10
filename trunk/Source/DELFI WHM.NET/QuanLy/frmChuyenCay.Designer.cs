namespace DELFI_WHM.NET.QuanLy
{
    partial class frmChuyenCay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuyenCay));
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.cboVitri = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboLot = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.chk_All = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grid_Chitiet = new DevExpress.XtraGrid.GridControl();
            this.gridView_Chitiet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tab = new DevExpress.XtraTab.XtraTabControl();
            this.Tab_Chitiet = new DevExpress.XtraTab.XtraTabPage();
            this.Tab_TongHop = new DevExpress.XtraTab.XtraTabPage();
            this.grid_TongHop = new DevExpress.XtraGrid.GridControl();
            this.gridView_TongHop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_All.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Chitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Chitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab)).BeginInit();
            this.Tab.SuspendLayout();
            this.Tab_Chitiet.SuspendLayout();
            this.Tab_TongHop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TongHop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_TongHop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // IML
            // 
            this.IML.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IML.ImageStream")));
            this.IML.TransparentColor = System.Drawing.Color.Transparent;
            this.IML.Images.SetKeyName(0, "Search.png");
            this.IML.Images.SetKeyName(1, "Exit.png");
            this.IML.Images.SetKeyName(2, "Save as.png");
            this.IML.Images.SetKeyName(3, "Open file.png");
            this.IML.Images.SetKeyName(4, "Redo.png");
            this.IML.Images.SetKeyName(5, "Cancel.png");
            this.IML.Images.SetKeyName(6, "btnSave.LargeGlyph.png");
            this.IML.Images.SetKeyName(7, "postscript.png");
            this.IML.Images.SetKeyName(8, "Print.png");
            this.IML.Images.SetKeyName(9, "replaceItem1.LargeGlyph.png");
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageIndex = 6;
            this.btnLuu.ImageList = this.IML;
            this.btnLuu.Location = new System.Drawing.Point(352, 25);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(184, 50);
            this.btnLuu.TabIndex = 124;
            this.btnLuu.Tag = "ADD";
            this.btnLuu.Text = "Xác nhận chuyển cây hàng";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cboVitri
            // 
            this.cboVitri.iWidth = 120;
            this.cboVitri.Location = new System.Drawing.Point(13, 54);
            this.cboVitri.Margin = new System.Windows.Forms.Padding(4);
            this.cboVitri.Name = "cboVitri";
            this.cboVitri.sCaption = "Chọn cây hàng đến:";
            this.cboVitri.sColumnCaption = "Cây hàng";
            this.cboVitri.sField = "BinCode";
            this.cboVitri.Size = new System.Drawing.Size(332, 21);
            this.cboVitri.sNullText = "<Chọn>";
            this.cboVitri.TabIndex = 121;
            this.cboVitri.uDisplayMember = "BinCode";
            this.cboVitri.uEditValue = null;
            this.cboVitri.uValueMember = "BinCode";
            this.cboVitri.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboVitri_uQueryPopUp);
            // 
            // cboLot
            // 
            this.cboLot.iWidth = 120;
            this.cboLot.Location = new System.Drawing.Point(13, 25);
            this.cboLot.Margin = new System.Windows.Forms.Padding(4);
            this.cboLot.Name = "cboLot";
            this.cboLot.sCaption = "Chọn LOT cần chuyển:";
            this.cboLot.sColumnCaption = "Lot, CropYear, Sản phẩm";
            this.cboLot.sField = "Lot, CropYear, ItemNo";
            this.cboLot.Size = new System.Drawing.Size(332, 21);
            this.cboLot.sNullText = "<Chọn>";
            this.cboLot.TabIndex = 117;
            this.cboLot.uDisplayMember = "Lot";
            this.cboLot.uEditValue = null;
            this.cboLot.uValueMember = "Lot";
            this.cboLot.uEditValueChanged += new System.EventHandler(this.cboLot_uEditValueChanged);
            this.cboLot.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboLot_uQueryPopUp);
            // 
            // chk_All
            // 
            this.chk_All.Location = new System.Drawing.Point(13, 82);
            this.chk_All.Name = "chk_All";
            this.chk_All.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chk_All.Properties.Appearance.Options.UseForeColor = true;
            this.chk_All.Properties.Caption = "Chọn tất cả theo cây hàng";
            this.chk_All.Size = new System.Drawing.Size(213, 19);
            this.chk_All.TabIndex = 114;
            this.chk_All.EditValueChanged += new System.EventHandler(this.chk_All_EditValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.groupControl1.Appearance.Options.UseForeColor = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.cboLot);
            this.groupControl1.Controls.Add(this.chk_All);
            this.groupControl1.Controls.Add(this.cboVitri);
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1069, 118);
            this.groupControl1.TabIndex = 129;
            this.groupControl1.Text = "Tìm kiếm theo LOT";
            // 
            // grid_Chitiet
            // 
            this.grid_Chitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Chitiet.Location = new System.Drawing.Point(0, 0);
            this.grid_Chitiet.MainView = this.gridView_Chitiet;
            this.grid_Chitiet.Name = "grid_Chitiet";
            this.grid_Chitiet.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.grid_Chitiet.Size = new System.Drawing.Size(1063, 457);
            this.grid_Chitiet.TabIndex = 130;
            this.grid_Chitiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Chitiet});
            // 
            // gridView_Chitiet
            // 
            this.gridView_Chitiet.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView_Chitiet.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView_Chitiet.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_Chitiet.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_Chitiet.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView_Chitiet.Appearance.Row.Options.UseForeColor = true;
            this.gridView_Chitiet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn7,
            this.gridColumn3,
            this.gridColumn2,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn8,
            this.gridColumn12});
            this.gridView_Chitiet.GridControl = this.grid_Chitiet;
            this.gridView_Chitiet.GroupPanelText = " ";
            this.gridView_Chitiet.IndicatorWidth = 50;
            this.gridView_Chitiet.LevelIndent = 0;
            this.gridView_Chitiet.Name = "gridView_Chitiet";
            this.gridView_Chitiet.OptionsView.ColumnAutoWidth = false;
            this.gridView_Chitiet.OptionsView.ShowGroupPanel = false;
            this.gridView_Chitiet.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView2_CustomDrawRowIndicator);
            this.gridView_Chitiet.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView2_KeyUp);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Chọn";
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn1.FieldName = "Chon";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 49;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Lot";
            this.gridColumn4.FieldName = "Lot";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 187;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Cây hàng";
            this.gridColumn7.FieldName = "BinCode";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 90;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Sản phẩm";
            this.gridColumn3.FieldName = "ItemNo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 125;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "QRCode";
            this.gridColumn2.FieldName = "QRCode";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 171;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Loại bao bì";
            this.gridColumn5.FieldName = "PackageCode";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 82;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Trọng lượng";
            this.gridColumn6.DisplayFormat.FormatString = "N0";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "QRCodeQty";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            this.gridColumn6.Width = 100;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Chứng nhận";
            this.gridColumn8.FieldName = "Certificate";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            this.gridColumn8.Width = 99;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "ID";
            this.gridColumn12.FieldName = "ID";
            this.gridColumn12.Name = "gridColumn12";
            // 
            // Tab
            // 
            this.Tab.AppearancePage.Header.ForeColor = System.Drawing.Color.Black;
            this.Tab.AppearancePage.Header.Options.UseForeColor = true;
            this.Tab.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Tab.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.Black;
            this.Tab.AppearancePage.HeaderActive.Options.UseFont = true;
            this.Tab.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 118);
            this.Tab.Name = "Tab";
            this.Tab.SelectedTabPage = this.Tab_Chitiet;
            this.Tab.Size = new System.Drawing.Size(1069, 485);
            this.Tab.TabIndex = 131;
            this.Tab.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.Tab_Chitiet,
            this.Tab_TongHop});
            // 
            // Tab_Chitiet
            // 
            this.Tab_Chitiet.Controls.Add(this.grid_Chitiet);
            this.Tab_Chitiet.Name = "Tab_Chitiet";
            this.Tab_Chitiet.Size = new System.Drawing.Size(1063, 457);
            this.Tab_Chitiet.Text = "Theo QRCode";
            // 
            // Tab_TongHop
            // 
            this.Tab_TongHop.Controls.Add(this.grid_TongHop);
            this.Tab_TongHop.Name = "Tab_TongHop";
            this.Tab_TongHop.Size = new System.Drawing.Size(1063, 457);
            this.Tab_TongHop.Text = "Theo toàn bộ Lot còn Tồn kho";
            // 
            // grid_TongHop
            // 
            this.grid_TongHop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_TongHop.Location = new System.Drawing.Point(0, 0);
            this.grid_TongHop.MainView = this.gridView_TongHop;
            this.grid_TongHop.Name = "grid_TongHop";
            this.grid_TongHop.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.grid_TongHop.Size = new System.Drawing.Size(1063, 457);
            this.grid_TongHop.TabIndex = 131;
            this.grid_TongHop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_TongHop});
            // 
            // gridView_TongHop
            // 
            this.gridView_TongHop.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView_TongHop.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView_TongHop.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_TongHop.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_TongHop.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView_TongHop.Appearance.Row.Options.UseForeColor = true;
            this.gridView_TongHop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn14,
            this.gridColumn13,
            this.gridColumn15,
            this.gridColumn17,
            this.gridColumn9,
            this.gridColumn20,
            this.gridColumn19,
            this.gridColumn16,
            this.gridColumn18});
            this.gridView_TongHop.GridControl = this.grid_TongHop;
            this.gridView_TongHop.GroupPanelText = " ";
            this.gridView_TongHop.IndicatorWidth = 50;
            this.gridView_TongHop.LevelIndent = 0;
            this.gridView_TongHop.Name = "gridView_TongHop";
            this.gridView_TongHop.OptionsBehavior.Editable = false;
            this.gridView_TongHop.OptionsView.ColumnAutoWidth = false;
            this.gridView_TongHop.OptionsView.ShowGroupPanel = false;
            this.gridView_TongHop.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_TongHop_CustomDrawRowIndicator);
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Lot";
            this.gridColumn10.FieldName = "Lot";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            this.gridColumn10.Width = 164;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Cây hàng";
            this.gridColumn11.FieldName = "BinCode";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "QRCode";
            this.gridColumn14.FieldName = "QRCode";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 2;
            this.gridColumn14.Width = 139;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Sản phẩm";
            this.gridColumn13.FieldName = "ItemNo";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 3;
            this.gridColumn13.Width = 153;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Loại bao bì";
            this.gridColumn15.FieldName = "PackageCode";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 4;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Chứng nhận";
            this.gridColumn17.FieldName = "Cer";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 5;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Số bao tồn kho";
            this.gridColumn9.DisplayFormat.FormatString = "N0";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn9.FieldName = "TruckQty_Ton";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "TL Tồn kho";
            this.gridColumn20.DisplayFormat.FormatString = "N0";
            this.gridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn20.FieldName = "QRCodeQty_Ton";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 7;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Số bao";
            this.gridColumn19.DisplayFormat.FormatString = "N0";
            this.gridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn19.FieldName = "TruckQty";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 8;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Trọng lượng";
            this.gridColumn16.DisplayFormat.FormatString = "N0";
            this.gridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn16.FieldName = "QRCodeQty";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 9;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "ID";
            this.gridColumn18.FieldName = "ID";
            this.gridColumn18.Name = "gridColumn18";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // frmChuyenCay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 603);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmChuyenCay";
            this.Text = "Cập nhật cây hàng theo LOT";
            this.Load += new System.EventHandler(this.frmChuyenCay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chk_All.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Chitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Chitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab)).EndInit();
            this.Tab.ResumeLayout(false);
            this.Tab_Chitiet.ResumeLayout(false);
            this.Tab_TongHop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_TongHop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_TongHop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DELFI_User_Control.uComboBox cboVitri;
        private DELFI_User_Control.uComboBox cboLot;
        private DevExpress.XtraEditors.CheckEdit chk_All;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grid_Chitiet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Chitiet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraTab.XtraTabControl Tab;
        private DevExpress.XtraTab.XtraTabPage Tab_Chitiet;
        private DevExpress.XtraTab.XtraTabPage Tab_TongHop;
        private DevExpress.XtraGrid.GridControl grid_TongHop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_TongHop;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
    }
}