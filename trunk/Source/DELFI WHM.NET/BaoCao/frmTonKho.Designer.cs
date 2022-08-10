namespace DELFI_WHM.NET.BaoCao
{
    partial class frmTonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTonKho));
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.cboLot = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboSanPham = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboVitri = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.dtpTuNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.Tab = new DevExpress.XtraTab.XtraTabControl();
            this.Tab_all = new DevExpress.XtraTab.XtraTabPage();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField6 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Tab_BinCode = new DevExpress.XtraTab.XtraTabPage();
            this.pivotGridControl2 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridField8 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField7 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField10 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField11 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField12 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.xtraTabControl3.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab)).BeginInit();
            this.Tab.SuspendLayout();
            this.Tab_all.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.Tab_BinCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl2)).BeginInit();
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
            // btnSearch
            // 
            this.btnSearch.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Appearance.Options.UseForeColor = true;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageList = this.IML;
            this.btnSearch.Location = new System.Drawing.Point(12, 137);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 26);
            this.btnSearch.TabIndex = 84;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // xtraTabControl3
            // 
            this.xtraTabControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl3.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl3.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl3.Name = "xtraTabControl3";
            this.xtraTabControl3.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl3.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl3.Size = new System.Drawing.Size(1069, 181);
            this.xtraTabControl3.TabIndex = 83;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.AutoScroll = true;
            this.xtraTabPage3.Controls.Add(this.cboLot);
            this.xtraTabPage3.Controls.Add(this.cboSanPham);
            this.xtraTabPage3.Controls.Add(this.cboVitri);
            this.xtraTabPage3.Controls.Add(this.btnPrint);
            this.xtraTabPage3.Controls.Add(this.btnSearch);
            this.xtraTabPage3.Controls.Add(this.dtpTuNgay);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1063, 175);
            // 
            // cboLot
            // 
            this.cboLot.iWidth = 80;
            this.cboLot.Location = new System.Drawing.Point(12, 99);
            this.cboLot.Margin = new System.Windows.Forms.Padding(4);
            this.cboLot.Name = "cboLot";
            this.cboLot.sCaption = "Số Lot:";
            this.cboLot.sColumnCaption = "Lot";
            this.cboLot.sField = "Lot";
            this.cboLot.Size = new System.Drawing.Size(219, 21);
            this.cboLot.sNullText = "<Chọn>";
            this.cboLot.TabIndex = 88;
            this.cboLot.uDisplayMember = "Lot";
            this.cboLot.uEditValue = null;
            this.cboLot.uValueMember = "Lot";
            this.cboLot.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboLot_uQueryPopUp);
            // 
            // cboSanPham
            // 
            this.cboSanPham.iWidth = 80;
            this.cboSanPham.Location = new System.Drawing.Point(12, 41);
            this.cboSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.sCaption = "Sản phẩm:";
            this.cboSanPham.sColumnCaption = "Mã sản phẩm, Tên sản phẩm";
            this.cboSanPham.sField = "ItemNo, ItemName";
            this.cboSanPham.Size = new System.Drawing.Size(219, 21);
            this.cboSanPham.sNullText = "<Chọn>";
            this.cboSanPham.TabIndex = 87;
            this.cboSanPham.uDisplayMember = "ItemName";
            this.cboSanPham.uEditValue = null;
            this.cboSanPham.uValueMember = "ItemNo";
            this.cboSanPham.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboSanPham_uQueryPopUp);
            // 
            // cboVitri
            // 
            this.cboVitri.iWidth = 80;
            this.cboVitri.Location = new System.Drawing.Point(12, 70);
            this.cboVitri.Margin = new System.Windows.Forms.Padding(4);
            this.cboVitri.Name = "cboVitri";
            this.cboVitri.sCaption = "Vị trí:";
            this.cboVitri.sColumnCaption = "Vị trí";
            this.cboVitri.sField = "BinCode";
            this.cboVitri.Size = new System.Drawing.Size(219, 21);
            this.cboVitri.sNullText = "<Chọn>";
            this.cboVitri.TabIndex = 86;
            this.cboVitri.uDisplayMember = "BinCode";
            this.cboVitri.uEditValue = null;
            this.cboVitri.uValueMember = "BinCode";
            this.cboVitri.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboVitri_uQueryPopUp);
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Appearance.Options.UseForeColor = true;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageIndex = 0;
            this.btnPrint.ImageList = this.IML;
            this.btnPrint.Location = new System.Drawing.Point(115, 137);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 26);
            this.btnPrint.TabIndex = 85;
            this.btnPrint.Text = "In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.iWidth = 80;
            this.dtpTuNgay.Location = new System.Drawing.Point(12, 12);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTuNgay.MaskDateTime = "dd/MM/yyyy";
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.sCaption = "Từ ngày:";
            this.dtpTuNgay.sFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Size = new System.Drawing.Size(219, 21);
            this.dtpTuNgay.TabIndex = 50;
            this.dtpTuNgay.uDateTime = new System.DateTime(2020, 4, 15, 9, 44, 0, 0);
            this.dtpTuNgay.uValue = new System.DateTime(2020, 4, 15, 9, 44, 0, 0);
            // 
            // Tab
            // 
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 181);
            this.Tab.Name = "Tab";
            this.Tab.SelectedTabPage = this.Tab_all;
            this.Tab.Size = new System.Drawing.Size(1069, 349);
            this.Tab.TabIndex = 85;
            this.Tab.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.Tab_all,
            this.Tab_BinCode});
            // 
            // Tab_all
            // 
            this.Tab_all.Controls.Add(this.pivotGridControl1);
            this.Tab_all.Name = "Tab_all";
            this.Tab_all.Size = new System.Drawing.Size(1063, 321);
            this.Tab_all.Text = "Tất cả";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Appearance.ColumnHeaderArea.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pivotGridControl1.Appearance.ColumnHeaderArea.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.ColumnHeaderArea.Options.UseFont = true;
            this.pivotGridControl1.Appearance.ColumnHeaderArea.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.DataHeaderArea.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pivotGridControl1.Appearance.DataHeaderArea.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.DataHeaderArea.Options.UseFont = true;
            this.pivotGridControl1.Appearance.DataHeaderArea.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.FieldHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pivotGridControl1.Appearance.FieldHeader.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.FieldHeader.Options.UseFont = true;
            this.pivotGridControl1.Appearance.FieldHeader.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.FieldValue.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.HeaderArea.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pivotGridControl1.Appearance.HeaderArea.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.HeaderArea.Options.UseFont = true;
            this.pivotGridControl1.Appearance.HeaderArea.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.RowHeaderArea.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.RowHeaderArea.Options.UseForeColor = true;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField2,
            this.pivotGridField1,
            this.pivotGridField6,
            this.pivotGridField3,
            this.pivotGridField4,
            this.pivotGridField5});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsBehavior.BestFitMode = DevExpress.XtraPivotGrid.PivotGridBestFitMode.None;
            this.pivotGridControl1.OptionsBehavior.CopyToClipboardWithFieldValues = true;
            this.pivotGridControl1.OptionsFilterPopup.ToolbarButtons = DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.None;
            this.pivotGridControl1.OptionsOLAP.DefaultMemberFields = DevExpress.XtraPivotGrid.PivotDefaultMemberFields.AllFilterFields;
            this.pivotGridControl1.OptionsPrint.MergeRowFieldValues = false;
            this.pivotGridControl1.OptionsPrint.PrintUnusedFilterFields = false;
            this.pivotGridControl1.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotalHeader = false;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowColumnHeaders = false;
            this.pivotGridControl1.OptionsView.ShowColumnTotals = false;
            this.pivotGridControl1.OptionsView.ShowDataHeaders = false;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.OptionsView.ShowRowGrandTotalHeader = false;
            this.pivotGridControl1.OptionsView.ShowRowGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowRowTotals = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(1063, 321);
            this.pivotGridControl1.TabIndex = 85;
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField2.AreaIndex = 0;
            this.pivotGridField2.Caption = "Sản phẩm";
            this.pivotGridField2.FieldName = "ItemNo";
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.Options.AllowEdit = false;
            this.pivotGridField2.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 1;
            this.pivotGridField1.Caption = "Cây hàng";
            this.pivotGridField1.FieldName = "BinCode";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.Options.AllowEdit = false;
            this.pivotGridField1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // pivotGridField6
            // 
            this.pivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField6.AreaIndex = 2;
            this.pivotGridField6.Caption = "Lot";
            this.pivotGridField6.FieldName = "Lot";
            this.pivotGridField6.Name = "pivotGridField6";
            this.pivotGridField6.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField3.AreaIndex = 0;
            this.pivotGridField3.Caption = "PackageType";
            this.pivotGridField3.FieldName = "PackageCode";
            this.pivotGridField3.Name = "pivotGridField3";
            this.pivotGridField3.Options.AllowEdit = false;
            this.pivotGridField3.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.Appearance.Cell.Options.UseTextOptions = true;
            this.pivotGridField4.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.pivotGridField4.Appearance.Value.Options.UseTextOptions = true;
            this.pivotGridField4.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField4.AreaIndex = 3;
            this.pivotGridField4.Caption = "NetWeight";
            this.pivotGridField4.CellFormat.FormatString = "N0";
            this.pivotGridField4.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField4.FieldName = "NetWeight";
            this.pivotGridField4.MinWidth = 1;
            this.pivotGridField4.Name = "pivotGridField4";
            this.pivotGridField4.Options.AllowEdit = false;
            this.pivotGridField4.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridField4.Options.AllowHide = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGridField4.ValueFormat.FormatString = "N0";
            this.pivotGridField4.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField5.AreaIndex = 0;
            this.pivotGridField5.Caption = "Qty";
            this.pivotGridField5.CellFormat.FormatString = "N0";
            this.pivotGridField5.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField5.FieldName = "Qty";
            this.pivotGridField5.Name = "pivotGridField5";
            this.pivotGridField5.ValueFormat.FormatString = "N0";
            this.pivotGridField5.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField5.Width = 50;
            // 
            // Tab_BinCode
            // 
            this.Tab_BinCode.Controls.Add(this.pivotGridControl2);
            this.Tab_BinCode.Name = "Tab_BinCode";
            this.Tab_BinCode.Size = new System.Drawing.Size(1063, 321);
            this.Tab_BinCode.Text = "Theo Cây hàng";
            // 
            // pivotGridControl2
            // 
            this.pivotGridControl2.Appearance.ColumnHeaderArea.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pivotGridControl2.Appearance.ColumnHeaderArea.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl2.Appearance.ColumnHeaderArea.Options.UseFont = true;
            this.pivotGridControl2.Appearance.ColumnHeaderArea.Options.UseForeColor = true;
            this.pivotGridControl2.Appearance.DataHeaderArea.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pivotGridControl2.Appearance.DataHeaderArea.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl2.Appearance.DataHeaderArea.Options.UseFont = true;
            this.pivotGridControl2.Appearance.DataHeaderArea.Options.UseForeColor = true;
            this.pivotGridControl2.Appearance.FieldHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pivotGridControl2.Appearance.FieldHeader.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl2.Appearance.FieldHeader.Options.UseFont = true;
            this.pivotGridControl2.Appearance.FieldHeader.Options.UseForeColor = true;
            this.pivotGridControl2.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl2.Appearance.FieldValue.Options.UseForeColor = true;
            this.pivotGridControl2.Appearance.HeaderArea.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pivotGridControl2.Appearance.HeaderArea.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl2.Appearance.HeaderArea.Options.UseFont = true;
            this.pivotGridControl2.Appearance.HeaderArea.Options.UseForeColor = true;
            this.pivotGridControl2.Appearance.RowHeaderArea.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl2.Appearance.RowHeaderArea.Options.UseForeColor = true;
            this.pivotGridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl2.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField8,
            this.pivotGridField7,
            this.pivotGridField10,
            this.pivotGridField11,
            this.pivotGridField12});
            this.pivotGridControl2.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl2.LookAndFeel.SkinName = "Office 2010 Blue";
            this.pivotGridControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pivotGridControl2.Margin = new System.Windows.Forms.Padding(2);
            this.pivotGridControl2.Name = "pivotGridControl2";
            this.pivotGridControl2.OptionsBehavior.BestFitMode = DevExpress.XtraPivotGrid.PivotGridBestFitMode.None;
            this.pivotGridControl2.OptionsBehavior.CopyToClipboardWithFieldValues = true;
            this.pivotGridControl2.OptionsFilterPopup.ToolbarButtons = DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.None;
            this.pivotGridControl2.OptionsOLAP.DefaultMemberFields = DevExpress.XtraPivotGrid.PivotDefaultMemberFields.AllFilterFields;
            this.pivotGridControl2.OptionsPrint.MergeRowFieldValues = false;
            this.pivotGridControl2.OptionsPrint.PrintUnusedFilterFields = false;
            this.pivotGridControl2.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near;
            this.pivotGridControl2.OptionsView.ShowColumnGrandTotalHeader = false;
            this.pivotGridControl2.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl2.OptionsView.ShowColumnHeaders = false;
            this.pivotGridControl2.OptionsView.ShowColumnTotals = false;
            this.pivotGridControl2.OptionsView.ShowDataHeaders = false;
            this.pivotGridControl2.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl2.OptionsView.ShowRowGrandTotalHeader = false;
            this.pivotGridControl2.OptionsView.ShowRowGrandTotals = false;
            this.pivotGridControl2.OptionsView.ShowRowTotals = false;
            this.pivotGridControl2.Size = new System.Drawing.Size(1063, 321);
            this.pivotGridControl2.TabIndex = 86;
            // 
            // pivotGridField8
            // 
            this.pivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField8.AreaIndex = 0;
            this.pivotGridField8.Caption = "Cây hàng";
            this.pivotGridField8.FieldName = "BinCode";
            this.pivotGridField8.Name = "pivotGridField8";
            this.pivotGridField8.Options.AllowEdit = false;
            this.pivotGridField8.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // pivotGridField7
            // 
            this.pivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField7.AreaIndex = 1;
            this.pivotGridField7.Caption = "Sản phẩm";
            this.pivotGridField7.FieldName = "ItemNo";
            this.pivotGridField7.Name = "pivotGridField7";
            this.pivotGridField7.Options.AllowEdit = false;
            this.pivotGridField7.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // pivotGridField10
            // 
            this.pivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField10.AreaIndex = 0;
            this.pivotGridField10.Caption = "PackageType";
            this.pivotGridField10.FieldName = "PackageCode";
            this.pivotGridField10.Name = "pivotGridField10";
            this.pivotGridField10.Options.AllowEdit = false;
            this.pivotGridField10.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // pivotGridField11
            // 
            this.pivotGridField11.Appearance.Cell.Options.UseTextOptions = true;
            this.pivotGridField11.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.pivotGridField11.Appearance.Value.Options.UseTextOptions = true;
            this.pivotGridField11.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.pivotGridField11.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField11.AreaIndex = 2;
            this.pivotGridField11.Caption = "NetWeight";
            this.pivotGridField11.CellFormat.FormatString = "N0";
            this.pivotGridField11.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField11.FieldName = "NetWeight";
            this.pivotGridField11.MinWidth = 1;
            this.pivotGridField11.Name = "pivotGridField11";
            this.pivotGridField11.Options.AllowEdit = false;
            this.pivotGridField11.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridField11.Options.AllowHide = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGridField11.ValueFormat.FormatString = "N0";
            this.pivotGridField11.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // pivotGridField12
            // 
            this.pivotGridField12.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField12.AreaIndex = 0;
            this.pivotGridField12.Caption = "Qty";
            this.pivotGridField12.CellFormat.FormatString = "N0";
            this.pivotGridField12.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField12.FieldName = "Qty";
            this.pivotGridField12.Name = "pivotGridField12";
            this.pivotGridField12.ValueFormat.FormatString = "N0";
            this.pivotGridField12.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField12.Width = 50;
            // 
            // frmTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 530);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.xtraTabControl3);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmTonKho";
            this.Text = "BÁO CÁO TỒN KHO";
            this.Load += new System.EventHandler(this.frmTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.xtraTabControl3.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tab)).EndInit();
            this.Tab.ResumeLayout(false);
            this.Tab_all.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.Tab_BinCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DELFI_User_Control.uDateTimePicker2 dtpTuNgay;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DELFI_User_Control.uComboBox cboSanPham;
        private DELFI_User_Control.uComboBox cboVitri;
        private DELFI_User_Control.uComboBox cboLot;
        private DevExpress.XtraTab.XtraTabControl Tab;
        private DevExpress.XtraTab.XtraTabPage Tab_all;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField6;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
        private DevExpress.XtraTab.XtraTabPage Tab_BinCode;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField8;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField7;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField10;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField11;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField12;
    }
}