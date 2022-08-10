namespace DELFI_WHM.NET.QuanLy
{
    partial class frmCanLai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCanLai));
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.spnTLTrubi = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.spnTLCan = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.spnID = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.txtMaPallet = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtLot = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtCayHang = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtItem = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.group = new DevExpress.XtraEditors.GroupControl();
            this.chkNhanDuLieu = new DevExpress.XtraEditors.CheckEdit();
            this.spnSoBao = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.txtLoaiBaoBi = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.griDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptSobao = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.group)).BeginInit();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkNhanDuLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptSobao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
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
            // spnTLTrubi
            // 
            this.spnTLTrubi.bUseMask = true;
            this.spnTLTrubi.Location = new System.Drawing.Point(12, 78);
            this.spnTLTrubi.Name = "spnTLTrubi";
            this.spnTLTrubi.sCaption = "Tổng TL trừ bì:";
            this.spnTLTrubi.sEditMask = "N2";
            this.spnTLTrubi.Size = new System.Drawing.Size(332, 21);
            this.spnTLTrubi.TabIndex = 130;
            this.spnTLTrubi.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTLTrubi.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnTLTrubi.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTLTrubi.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTLTrubi.uText = "0.00";
            this.spnTLTrubi.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTLTrubi.uValueChanged += new System.EventHandler(this.spnTLTrubi_uValueChanged);
            // 
            // spnTLCan
            // 
            this.spnTLCan.Appearance.ForeColor = System.Drawing.Color.Black;
            this.spnTLCan.Appearance.Options.UseForeColor = true;
            this.spnTLCan.bIsReadOnly = true;
            this.spnTLCan.bUseMask = true;
            this.spnTLCan.Location = new System.Drawing.Point(12, 51);
            this.spnTLCan.Name = "spnTLCan";
            this.spnTLCan.sCaption = "Trọng lượng cân:";
            this.spnTLCan.sEditMask = "N0";
            this.spnTLCan.Size = new System.Drawing.Size(221, 21);
            this.spnTLCan.TabIndex = 129;
            this.spnTLCan.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTLCan.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnTLCan.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTLCan.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTLCan.uText = "0";
            this.spnTLCan.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // spnID
            // 
            this.spnID.Location = new System.Drawing.Point(709, 24);
            this.spnID.Name = "spnID";
            this.spnID.sCaption = "ID QRCode";
            this.spnID.Size = new System.Drawing.Size(174, 21);
            this.spnID.TabIndex = 128;
            this.spnID.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnID.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnID.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnID.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnID.uText = "0";
            this.spnID.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnID.Visible = false;
            // 
            // txtMaPallet
            // 
            this.txtMaPallet.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtMaPallet.Location = new System.Drawing.Point(12, 24);
            this.txtMaPallet.Name = "txtMaPallet";
            this.txtMaPallet.sCaption = "Quét mã pallet:";
            this.txtMaPallet.SelectionStart = 0;
            this.txtMaPallet.Size = new System.Drawing.Size(332, 21);
            this.txtMaPallet.TabIndex = 86;
            this.txtMaPallet.uKeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaPallet_uKeyUp);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageIndex = 6;
            this.btnLuu.ImageList = this.IML;
            this.btnLuu.Location = new System.Drawing.Point(12, 132);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(101, 26);
            this.btnLuu.TabIndex = 124;
            this.btnLuu.Tag = "ADD";
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtLot
            // 
            this.txtLot.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtLot.Appearance.Options.UseForeColor = true;
            this.txtLot.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtLot.bIsReadOnly = true;
            this.txtLot.Location = new System.Drawing.Point(371, 51);
            this.txtLot.LookAndFeel.SkinName = "Office 2010 Blue";
            this.txtLot.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtLot.Name = "txtLot";
            this.txtLot.sCaption = "Lot:";
            this.txtLot.SelectionStart = 0;
            this.txtLot.Size = new System.Drawing.Size(332, 20);
            this.txtLot.TabIndex = 131;
            // 
            // txtCayHang
            // 
            this.txtCayHang.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtCayHang.Appearance.Options.UseForeColor = true;
            this.txtCayHang.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtCayHang.bIsReadOnly = true;
            this.txtCayHang.Location = new System.Drawing.Point(371, 77);
            this.txtCayHang.LookAndFeel.SkinName = "Office 2010 Blue";
            this.txtCayHang.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtCayHang.Name = "txtCayHang";
            this.txtCayHang.sCaption = "Cây hàng:";
            this.txtCayHang.SelectionStart = 0;
            this.txtCayHang.Size = new System.Drawing.Size(332, 20);
            this.txtCayHang.TabIndex = 132;
            // 
            // txtItem
            // 
            this.txtItem.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtItem.Appearance.Options.UseForeColor = true;
            this.txtItem.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtItem.bIsReadOnly = true;
            this.txtItem.Location = new System.Drawing.Point(371, 25);
            this.txtItem.LookAndFeel.SkinName = "Office 2010 Blue";
            this.txtItem.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtItem.Name = "txtItem";
            this.txtItem.sCaption = "Sản phẩm:";
            this.txtItem.SelectionStart = 0;
            this.txtItem.Size = new System.Drawing.Size(332, 20);
            this.txtItem.TabIndex = 133;
            // 
            // group
            // 
            this.group.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.group.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.group.AppearanceCaption.Options.UseFont = true;
            this.group.AppearanceCaption.Options.UseForeColor = true;
            this.group.Controls.Add(this.chkNhanDuLieu);
            this.group.Controls.Add(this.spnSoBao);
            this.group.Controls.Add(this.txtLoaiBaoBi);
            this.group.Controls.Add(this.btnLuu);
            this.group.Controls.Add(this.spnID);
            this.group.Controls.Add(this.spnTLTrubi);
            this.group.Controls.Add(this.txtCayHang);
            this.group.Controls.Add(this.spnTLCan);
            this.group.Controls.Add(this.txtItem);
            this.group.Controls.Add(this.txtLot);
            this.group.Controls.Add(this.txtMaPallet);
            this.group.Dock = System.Windows.Forms.DockStyle.Top;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(1069, 172);
            this.group.TabIndex = 129;
            this.group.Text = "Thông tin sản phẩm";
            // 
            // chkNhanDuLieu
            // 
            this.chkNhanDuLieu.Location = new System.Drawing.Point(239, 53);
            this.chkNhanDuLieu.Name = "chkNhanDuLieu";
            this.chkNhanDuLieu.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkNhanDuLieu.Properties.Appearance.Options.UseForeColor = true;
            this.chkNhanDuLieu.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.chkNhanDuLieu.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.chkNhanDuLieu.Properties.Caption = "Nhận dữ liệu cân";
            this.chkNhanDuLieu.Size = new System.Drawing.Size(105, 19);
            this.chkNhanDuLieu.TabIndex = 136;
            this.chkNhanDuLieu.TabStop = false;
            this.chkNhanDuLieu.Tag = "..GIAOVIEN";
            this.chkNhanDuLieu.CheckedChanged += new System.EventHandler(this.chkNhanDuLieu_CheckedChanged);
            // 
            // spnSoBao
            // 
            this.spnSoBao.Appearance.ForeColor = System.Drawing.Color.Black;
            this.spnSoBao.Appearance.Options.UseForeColor = true;
            this.spnSoBao.bUseMask = true;
            this.spnSoBao.Location = new System.Drawing.Point(12, 105);
            this.spnSoBao.Name = "spnSoBao";
            this.spnSoBao.sCaption = "Số bao:";
            this.spnSoBao.sEditMask = "N0";
            this.spnSoBao.Size = new System.Drawing.Size(332, 21);
            this.spnSoBao.TabIndex = 135;
            this.spnSoBao.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnSoBao.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnSoBao.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnSoBao.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnSoBao.uText = "0";
            this.spnSoBao.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // txtLoaiBaoBi
            // 
            this.txtLoaiBaoBi.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtLoaiBaoBi.Appearance.Options.UseForeColor = true;
            this.txtLoaiBaoBi.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtLoaiBaoBi.bIsReadOnly = true;
            this.txtLoaiBaoBi.Location = new System.Drawing.Point(371, 103);
            this.txtLoaiBaoBi.LookAndFeel.SkinName = "Office 2010 Blue";
            this.txtLoaiBaoBi.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtLoaiBaoBi.Name = "txtLoaiBaoBi";
            this.txtLoaiBaoBi.sCaption = "Loại bao bì:";
            this.txtLoaiBaoBi.SelectionStart = 0;
            this.txtLoaiBaoBi.Size = new System.Drawing.Size(332, 20);
            this.txtLoaiBaoBi.TabIndex = 134;
            // 
            // griDanhSach
            // 
            this.griDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.griDanhSach.Location = new System.Drawing.Point(0, 172);
            this.griDanhSach.MainView = this.gridView2;
            this.griDanhSach.Name = "griDanhSach";
            this.griDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.rptSobao});
            this.griDanhSach.Size = new System.Drawing.Size(1069, 431);
            this.griDanhSach.TabIndex = 130;
            this.griDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.Row.Options.UseForeColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn1,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gridView2.GridControl = this.griDanhSach;
            this.gridView2.IndicatorWidth = 50;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView2_CustomDrawRowIndicator);
            this.gridView2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView2_KeyUp);
            this.gridView2.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "QRCode";
            this.gridColumn2.FieldName = "QRCode";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Sản phẩm";
            this.gridColumn3.FieldName = "ItemNo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Lot";
            this.gridColumn4.FieldName = "Lot";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Loại bao bì";
            this.gridColumn5.FieldName = "PackageCode";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Số bao";
            this.gridColumn1.ColumnEdit = this.rptSobao;
            this.gridColumn1.FieldName = "TruckQty";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // rptSobao
            // 
            this.rptSobao.AutoHeight = false;
            this.rptSobao.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptSobao.Mask.EditMask = "N0";
            this.rptSobao.Mask.UseMaskAsDisplayFormat = true;
            this.rptSobao.Name = "rptSobao";
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
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Cây hàng";
            this.gridColumn7.FieldName = "BinCode";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Chứng nhận";
            this.gridColumn8.FieldName = "Certificate";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Sample";
            this.gridColumn9.FieldName = "Sample";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "ID";
            this.gridColumn10.FieldName = "ID";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmCanLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 603);
            this.Controls.Add(this.griDanhSach);
            this.Controls.Add(this.group);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmCanLai";
            this.Text = "CÂN LẠI HÀNG";
            this.Load += new System.EventHandler(this.frmCanLai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.group)).EndInit();
            this.group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkNhanDuLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptSobao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DELFI_User_Control.uTextBox txtMaPallet;
        private DELFI_User_Control.uSpinEdit spnID;
        private DELFI_User_Control.uSpinEdit spnTLTrubi;
        private DELFI_User_Control.uSpinEdit spnTLCan;
        private DELFI_User_Control.uTextBox txtItem;
        private DELFI_User_Control.uTextBox txtCayHang;
        private DELFI_User_Control.uTextBox txtLot;
        private DevExpress.XtraEditors.GroupControl group;
        private DELFI_User_Control.uTextBox txtLoaiBaoBi;
        private DevExpress.XtraGrid.GridControl griDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit rptSobao;
        private DELFI_User_Control.uSpinEdit spnSoBao;
        private DevExpress.XtraEditors.CheckEdit chkNhanDuLieu;
        private System.Windows.Forms.Timer timer1;
    }
}