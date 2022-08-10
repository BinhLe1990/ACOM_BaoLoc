namespace DELFI_WHM.NET.QuanLy
{
    partial class frmThongTinSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinSP));
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spnID = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.txtMaPallet = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.cboQuicach = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboMaSanPham = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboLoai = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboVitri = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboCer = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboLot = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.griDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptSoBao = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.xtraTabControl3.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptSoBao)).BeginInit();
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
            // xtraTabControl3
            // 
            this.xtraTabControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl3.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl3.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl3.Name = "xtraTabControl3";
            this.xtraTabControl3.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl3.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl3.Size = new System.Drawing.Size(1069, 262);
            this.xtraTabControl3.TabIndex = 83;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.AutoScroll = true;
            this.xtraTabPage3.Controls.Add(this.groupBox1);
            this.xtraTabPage3.Controls.Add(this.btnLuu);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1063, 256);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.spnID);
            this.groupBox1.Controls.Add(this.txtMaPallet);
            this.groupBox1.Controls.Add(this.cboQuicach);
            this.groupBox1.Controls.Add(this.cboMaSanPham);
            this.groupBox1.Controls.Add(this.cboLoai);
            this.groupBox1.Controls.Add(this.cboVitri);
            this.groupBox1.Controls.Add(this.cboCer);
            this.groupBox1.Controls.Add(this.cboLot);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 195);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // spnID
            // 
            this.spnID.Location = new System.Drawing.Point(346, 48);
            this.spnID.Name = "spnID";
            this.spnID.sCaption = "ID";
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
            this.txtMaPallet.Location = new System.Drawing.Point(6, 20);
            this.txtMaPallet.Name = "txtMaPallet";
            this.txtMaPallet.sCaption = "Quét mã pallet:";
            this.txtMaPallet.SelectionStart = 0;
            this.txtMaPallet.Size = new System.Drawing.Size(332, 21);
            this.txtMaPallet.TabIndex = 86;
            this.txtMaPallet.uKeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaPallet_uKeyUp);
            // 
            // cboQuicach
            // 
            this.cboQuicach.Location = new System.Drawing.Point(7, 132);
            this.cboQuicach.Name = "cboQuicach";
            this.cboQuicach.sCaption = "Loại bao bì (*):";
            this.cboQuicach.sColumnCaption = "Loại bao bì";
            this.cboQuicach.sField = "PackageCode";
            this.cboQuicach.Size = new System.Drawing.Size(332, 21);
            this.cboQuicach.TabIndex = 120;
            this.cboQuicach.uDisplayMember = "PackageCode";
            this.cboQuicach.uEditValue = null;
            this.cboQuicach.uValueMember = "PackageCode";
            this.cboQuicach.uEditValueChanged += new System.EventHandler(this.cboQuicach_uEditValueChanged);
            this.cboQuicach.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboQuicach_uQueryPopUp);
            // 
            // cboMaSanPham
            // 
            this.cboMaSanPham.bIsReadOnly = true;
            this.cboMaSanPham.Location = new System.Drawing.Point(7, 48);
            this.cboMaSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaSanPham.Name = "cboMaSanPham";
            this.cboMaSanPham.sCaption = "Sản phẩm:";
            this.cboMaSanPham.sColumnCaption = "Mã sản phẩm, Tên sản phẩm";
            this.cboMaSanPham.sField = "ItemNo, ItemName";
            this.cboMaSanPham.Size = new System.Drawing.Size(332, 21);
            this.cboMaSanPham.sNullText = "<Chọn sản phẩm>";
            this.cboMaSanPham.TabIndex = 116;
            this.cboMaSanPham.TabStop = false;
            this.cboMaSanPham.uDisplayMember = "ItemNo";
            this.cboMaSanPham.uEditValue = null;
            this.cboMaSanPham.uTextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboMaSanPham.uValueMember = "ItemNo";
            this.cboMaSanPham.uEditValueChanged += new System.EventHandler(this.cboMaSanPham_uEditValueChanged);
            this.cboMaSanPham.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboMaSanPham_uQueryPopUp);
            // 
            // cboLoai
            // 
            this.cboLoai.Location = new System.Drawing.Point(345, 21);
            this.cboLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.sCaption = "Loại:";
            this.cboLoai.sColumnCaption = "Loại";
            this.cboLoai.sField = "Loai";
            this.cboLoai.Size = new System.Drawing.Size(175, 21);
            this.cboLoai.sNullText = "<Chọn>";
            this.cboLoai.TabIndex = 126;
            this.cboLoai.TabStop = false;
            this.cboLoai.uDisplayMember = "Loai";
            this.cboLoai.uEditValue = null;
            this.cboLoai.uTextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboLoai.uValueMember = "Loai";
            this.cboLoai.Visible = false;
            // 
            // cboVitri
            // 
            this.cboVitri.Location = new System.Drawing.Point(7, 160);
            this.cboVitri.Margin = new System.Windows.Forms.Padding(4);
            this.cboVitri.Name = "cboVitri";
            this.cboVitri.sCaption = "Cây hàng:";
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
            // cboCer
            // 
            this.cboCer.Location = new System.Drawing.Point(7, 105);
            this.cboCer.Name = "cboCer";
            this.cboCer.sCaption = "Certificate:";
            this.cboCer.sColumnCaption = "Certificate";
            this.cboCer.sField = "Ten";
            this.cboCer.Size = new System.Drawing.Size(332, 21);
            this.cboCer.TabIndex = 119;
            this.cboCer.uDisplayMember = "Ten";
            this.cboCer.uEditValue = "";
            this.cboCer.uValueMember = "Ten";
            this.cboCer.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboCer_uQueryPopUp);
            // 
            // cboLot
            // 
            this.cboLot.bIsReadOnly = true;
            this.cboLot.Location = new System.Drawing.Point(7, 77);
            this.cboLot.Margin = new System.Windows.Forms.Padding(4);
            this.cboLot.Name = "cboLot";
            this.cboLot.sCaption = "Số Lot:";
            this.cboLot.sColumnCaption = "Lot, CropYear";
            this.cboLot.sField = "Lot, CropYear";
            this.cboLot.Size = new System.Drawing.Size(332, 21);
            this.cboLot.sNullText = "<Chọn>";
            this.cboLot.TabIndex = 117;
            this.cboLot.uDisplayMember = "Lot";
            this.cboLot.uEditValue = null;
            this.cboLot.uValueMember = "Lot";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageIndex = 6;
            this.btnLuu.ImageList = this.IML;
            this.btnLuu.Location = new System.Drawing.Point(11, 212);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 26);
            this.btnLuu.TabIndex = 124;
            this.btnLuu.Tag = "ADD";
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // griDanhSach
            // 
            this.griDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.griDanhSach.Location = new System.Drawing.Point(0, 262);
            this.griDanhSach.MainView = this.gridView2;
            this.griDanhSach.Name = "griDanhSach";
            this.griDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.rptSoBao});
            this.griDanhSach.Size = new System.Drawing.Size(1069, 341);
            this.griDanhSach.TabIndex = 112;
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
            this.gridView2.OptionsSelection.MultiSelect = true;
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
            this.gridColumn1.ColumnEdit = this.rptSoBao;
            this.gridColumn1.DisplayFormat.FormatString = "N0";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "TruckQty";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // rptSoBao
            // 
            this.rptSoBao.AutoHeight = false;
            this.rptSoBao.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptSoBao.Mask.EditMask = "N0";
            this.rptSoBao.Mask.UseMaskAsDisplayFormat = true;
            this.rptSoBao.Name = "rptSoBao";
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
            // frmThongTinSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 603);
            this.Controls.Add(this.griDanhSach);
            this.Controls.Add(this.xtraTabControl3);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmThongTinSP";
            this.Text = "THÔNG TIN SẢN PHẨM";
            this.Load += new System.EventHandler(this.frmThongTinSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.xtraTabControl3.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptSoBao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private DevExpress.XtraGrid.GridControl griDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DELFI_User_Control.uTextBox txtMaPallet;
        private DELFI_User_Control.uComboBox cboQuicach;
        private DELFI_User_Control.uComboBox cboMaSanPham;
        private DELFI_User_Control.uComboBox cboLoai;
        private DELFI_User_Control.uComboBox cboVitri;
        private DELFI_User_Control.uComboBox cboCer;
        private DELFI_User_Control.uComboBox cboLot;
        private DELFI_User_Control.uSpinEdit spnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit rptSoBao;
    }
}