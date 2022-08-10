namespace DELFI_WHM.NET.BaoCao
{
    partial class frm_BC_GiaoNhanSX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BC_GiaoNhanSX));
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.dtpDenNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.dtpTuNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptTLTrubi = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptThoigian = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.griDanhSach = new DevExpress.XtraGrid.GridControl();
            this.rptTLCan = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.rptSobao = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.rptTLNet = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.rptNgayTao = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.xtraTabControl3.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptTLTrubi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptThoigian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptThoigian.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptTLCan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptSobao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptTLNet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptNgayTao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptNgayTao.CalendarTimeProperties)).BeginInit();
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
            this.btnSearch.Location = new System.Drawing.Point(12, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 26);
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
            this.xtraTabControl3.Size = new System.Drawing.Size(969, 126);
            this.xtraTabControl3.TabIndex = 83;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.AutoScroll = true;
            this.xtraTabPage3.Controls.Add(this.btnPrint);
            this.xtraTabPage3.Controls.Add(this.dtpDenNgay);
            this.xtraTabPage3.Controls.Add(this.btnSearch);
            this.xtraTabPage3.Controls.Add(this.dtpTuNgay);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(963, 120);
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Appearance.Options.UseForeColor = true;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageIndex = 0;
            this.btnPrint.ImageList = this.IML;
            this.btnPrint.Location = new System.Drawing.Point(118, 78);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 26);
            this.btnPrint.TabIndex = 85;
            this.btnPrint.Text = "In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(12, 50);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDenNgay.MaskDateTime = "dd/MM/yyyy";
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.sCaption = "Đến ngày:";
            this.dtpDenNgay.sFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Size = new System.Drawing.Size(212, 21);
            this.dtpDenNgay.TabIndex = 50;
            this.dtpDenNgay.uDateTime = new System.DateTime(2020, 4, 15, 9, 40, 0, 0);
            this.dtpDenNgay.uValue = new System.DateTime(2020, 4, 15, 9, 40, 0, 0);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(12, 21);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTuNgay.MaskDateTime = "dd/MM/yyyy";
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.sCaption = "Từ ngày:";
            this.dtpTuNgay.sFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Size = new System.Drawing.Size(212, 21);
            this.dtpTuNgay.TabIndex = 50;
            this.dtpTuNgay.uDateTime = new System.DateTime(2020, 4, 15, 9, 40, 0, 0);
            this.dtpTuNgay.uValue = new System.DateTime(2020, 4, 15, 9, 40, 0, 0);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView2.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.Row.Options.UseForeColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20});
            this.gridView2.GridControl = this.griDanhSach;
            this.gridView2.IndicatorWidth = 50;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView2_CustomDrawRowIndicator);
            this.gridView2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView2_KeyUp);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Lệnh sản xuất";
            this.gridColumn1.FieldName = "Document";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Lot";
            this.gridColumn2.FieldName = "Lot";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số bao Y/C";
            this.gridColumn3.FieldName = "Bag";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Sản phẩm";
            this.gridColumn4.FieldName = "ItemNo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Chứng nhận";
            this.gridColumn5.FieldName = "Certificate";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "CropYear";
            this.gridColumn6.FieldName = "CropYear";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Loại cân";
            this.gridColumn7.FieldName = "LoaiCan";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Cây hàng";
            this.gridColumn8.FieldName = "BinCode";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "QRCode";
            this.gridColumn9.FieldName = "QRCode";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "TL Cân";
            this.gridColumn10.DisplayFormat.FormatString = "N0";
            this.gridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn10.FieldName = "GrossWeight";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GrossWeight", "{0:N0}")});
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Loại bao bì";
            this.gridColumn11.FieldName = "PackageCode";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 10;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Số bao";
            this.gridColumn12.DisplayFormat.FormatString = "N0";
            this.gridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn12.FieldName = "TruckQty";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TruckQty", "{0:N0}")});
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 11;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "TL Trừ bì";
            this.gridColumn13.ColumnEdit = this.rptTLTrubi;
            this.gridColumn13.FieldName = "TotalPackageQty";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPackageQty", "{0:N2}")});
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 12;
            // 
            // rptTLTrubi
            // 
            this.rptTLTrubi.AutoHeight = false;
            this.rptTLTrubi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptTLTrubi.Mask.EditMask = "N2";
            this.rptTLTrubi.Mask.UseMaskAsDisplayFormat = true;
            this.rptTLTrubi.Name = "rptTLTrubi";
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Trọng lượng Net";
            this.gridColumn14.DisplayFormat.FormatString = "N0";
            this.gridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn14.FieldName = "NetWeight";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetWeight", "{0:N0}")});
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 13;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Ngày cân";
            this.gridColumn21.FieldName = "NgayTao";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 14;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Giờ cân";
            this.gridColumn22.FieldName = "GioTao";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 15;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Ngày chuyển kho";
            this.gridColumn15.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn15.FieldName = "Date";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 16;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Giờ chuyển kho";
            this.gridColumn16.ColumnEdit = this.rptThoigian;
            this.gridColumn16.FieldName = "Thoigian";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 17;
            // 
            // rptThoigian
            // 
            this.rptThoigian.AutoHeight = false;
            this.rptThoigian.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptThoigian.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptThoigian.Mask.EditMask = "HH:mm:ss";
            this.rptThoigian.Mask.UseMaskAsDisplayFormat = true;
            this.rptThoigian.Name = "rptThoigian";
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Người cân";
            this.gridColumn17.FieldName = "UserName";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 18;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Sample";
            this.gridColumn18.FieldName = "Sample";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 19;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Ghi chú";
            this.gridColumn19.FieldName = "Note";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 20;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Tieude";
            this.gridColumn20.FieldName = "Tieude";
            this.gridColumn20.Name = "gridColumn20";
            // 
            // griDanhSach
            // 
            this.griDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.griDanhSach.Location = new System.Drawing.Point(0, 126);
            this.griDanhSach.MainView = this.gridView2;
            this.griDanhSach.Name = "griDanhSach";
            this.griDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rptThoigian,
            this.rptTLCan,
            this.rptSobao,
            this.rptTLTrubi,
            this.rptTLNet,
            this.rptNgayTao});
            this.griDanhSach.Size = new System.Drawing.Size(969, 477);
            this.griDanhSach.TabIndex = 113;
            this.griDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // rptTLCan
            // 
            this.rptTLCan.AutoHeight = false;
            this.rptTLCan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptTLCan.Mask.EditMask = "N";
            this.rptTLCan.Mask.UseMaskAsDisplayFormat = true;
            this.rptTLCan.Name = "rptTLCan";
            this.rptTLCan.NullText = "0";
            // 
            // rptSobao
            // 
            this.rptSobao.AutoHeight = false;
            this.rptSobao.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptSobao.Mask.EditMask = "#";
            this.rptSobao.Mask.UseMaskAsDisplayFormat = true;
            this.rptSobao.Name = "rptSobao";
            this.rptSobao.NullText = "0";
            // 
            // rptTLNet
            // 
            this.rptTLNet.AutoHeight = false;
            this.rptTLNet.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptTLNet.Mask.EditMask = "#";
            this.rptTLNet.Mask.UseMaskAsDisplayFormat = true;
            this.rptTLNet.Name = "rptTLNet";
            // 
            // rptNgayTao
            // 
            this.rptNgayTao.AutoHeight = false;
            this.rptNgayTao.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptNgayTao.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptNgayTao.Mask.UseMaskAsDisplayFormat = true;
            this.rptNgayTao.Name = "rptNgayTao";
            // 
            // frm_BC_GiaoNhanSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 603);
            this.Controls.Add(this.griDanhSach);
            this.Controls.Add(this.xtraTabControl3);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frm_BC_GiaoNhanSX";
            this.Text = "BÁO CÁO TỔNG HỢP GIAO - NHẬN SẢN XUẤT";
            this.Load += new System.EventHandler(this.frm_BC_GiaoNhanSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.xtraTabControl3.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptTLTrubi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptThoigian.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptThoigian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptTLCan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptSobao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptTLNet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptNgayTao.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptNgayTao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DELFI_User_Control.uDateTimePicker2 dtpDenNgay;
        private DELFI_User_Control.uDateTimePicker2 dtpTuNgay;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.GridControl griDanhSach;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rptThoigian;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit rptTLCan;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit rptSobao;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit rptTLTrubi;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit rptTLNet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rptNgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
    }
}