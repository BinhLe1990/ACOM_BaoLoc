namespace DELFI_WHM.NET.BaoCao
{
    partial class frmBC_LenhSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBC_LenhSanXuat));
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.Tab = new DevExpress.XtraTab.XtraTabControl();
            this.Tab_all = new DevExpress.XtraTab.XtraTabPage();
            this.grid_Tonghop = new DevExpress.XtraGrid.GridControl();
            this.gridView_Tonghop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnIn_Tonghop = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimkiem_Tonghop = new DevExpress.XtraEditors.SimpleButton();
            this.dtpDenNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.dtpTuNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.Tab_BinCode = new DevExpress.XtraTab.XtraTabPage();
            this.grid_Chitiet = new DevExpress.XtraGrid.GridControl();
            this.gridView_Chitiet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DocumentNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cboLSX = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.btnIn_Chitiet = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiem_Chitiet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Tab)).BeginInit();
            this.Tab.SuspendLayout();
            this.Tab_all.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Tonghop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Tonghop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.Tab_BinCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Chitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Chitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
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
            // Tab
            // 
            this.Tab.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Tab.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.Black;
            this.Tab.AppearancePage.HeaderActive.Options.UseFont = true;
            this.Tab.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedTabPage = this.Tab_all;
            this.Tab.Size = new System.Drawing.Size(1069, 429);
            this.Tab.TabIndex = 85;
            this.Tab.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.Tab_all,
            this.Tab_BinCode});
            // 
            // Tab_all
            // 
            this.Tab_all.Controls.Add(this.grid_Tonghop);
            this.Tab_all.Controls.Add(this.groupControl1);
            this.Tab_all.Name = "Tab_all";
            this.Tab_all.Size = new System.Drawing.Size(1063, 401);
            this.Tab_all.Text = "Tổng hợp";
            // 
            // grid_Tonghop
            // 
            this.grid_Tonghop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Tonghop.Location = new System.Drawing.Point(0, 58);
            this.grid_Tonghop.MainView = this.gridView_Tonghop;
            this.grid_Tonghop.Name = "grid_Tonghop";
            this.grid_Tonghop.Size = new System.Drawing.Size(1063, 343);
            this.grid_Tonghop.TabIndex = 102;
            this.grid_Tonghop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Tonghop,
            this.gridView2});
            // 
            // gridView_Tonghop
            // 
            this.gridView_Tonghop.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView_Tonghop.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView_Tonghop.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView_Tonghop.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView_Tonghop.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView_Tonghop.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView_Tonghop.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView_Tonghop.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView_Tonghop.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView_Tonghop.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_Tonghop.Appearance.GroupRow.Options.UseFont = true;
            this.gridView_Tonghop.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView_Tonghop.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView_Tonghop.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView_Tonghop.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_Tonghop.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_Tonghop.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView_Tonghop.Appearance.Row.Options.UseForeColor = true;
            this.gridView_Tonghop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15});
            this.gridView_Tonghop.GridControl = this.grid_Tonghop;
            this.gridView_Tonghop.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TruckQty", this.gridColumn14, "{0:N0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QRCodeQty", this.gridColumn15, "{0:N0}")});
            this.gridView_Tonghop.IndicatorWidth = 50;
            this.gridView_Tonghop.Name = "gridView_Tonghop";
            this.gridView_Tonghop.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView_Tonghop.OptionsBehavior.Editable = false;
            this.gridView_Tonghop.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView_Tonghop.OptionsView.ShowGroupPanel = false;
            this.gridView_Tonghop.ViewCaption = "Chưa hoàn thành";
            this.gridView_Tonghop.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_Tonghop_CustomDrawRowIndicator);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Lệnh sản xuất";
            this.gridColumn5.FieldName = "Document";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Tháng";
            this.gridColumn9.FieldName = "Thang";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Đầu vào";
            this.gridColumn10.FieldName = "Vao";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Đầu ra";
            this.gridColumn11.FieldName = "Ra";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 3;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Hao hụt";
            this.gridColumn12.FieldName = "HaoHut";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 4;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "% Hao hụt";
            this.gridColumn13.FieldName = "PhanTram";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 5;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Open Date";
            this.gridColumn14.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn14.FieldName = "OpenDate";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 6;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Close Date";
            this.gridColumn15.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn15.FieldName = "CloseDate";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 7;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grid_Tonghop;
            this.gridView2.Name = "gridView2";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.btnIn_Tonghop);
            this.groupControl1.Controls.Add(this.btnTimkiem_Tonghop);
            this.groupControl1.Controls.Add(this.dtpDenNgay);
            this.groupControl1.Controls.Add(this.dtpTuNgay);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1063, 58);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // btnIn_Tonghop
            // 
            this.btnIn_Tonghop.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnIn_Tonghop.Appearance.Options.UseForeColor = true;
            this.btnIn_Tonghop.Image = ((System.Drawing.Image)(resources.GetObject("btnIn_Tonghop.Image")));
            this.btnIn_Tonghop.ImageIndex = 0;
            this.btnIn_Tonghop.ImageList = this.IML;
            this.btnIn_Tonghop.Location = new System.Drawing.Point(538, 24);
            this.btnIn_Tonghop.Name = "btnIn_Tonghop";
            this.btnIn_Tonghop.Size = new System.Drawing.Size(98, 26);
            this.btnIn_Tonghop.TabIndex = 87;
            this.btnIn_Tonghop.Text = "In";
            this.btnIn_Tonghop.Click += new System.EventHandler(this.btnIn_Tonghop_Click);
            // 
            // btnTimkiem_Tonghop
            // 
            this.btnTimkiem_Tonghop.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnTimkiem_Tonghop.Appearance.Options.UseForeColor = true;
            this.btnTimkiem_Tonghop.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem_Tonghop.Image")));
            this.btnTimkiem_Tonghop.ImageIndex = 0;
            this.btnTimkiem_Tonghop.ImageList = this.IML;
            this.btnTimkiem_Tonghop.Location = new System.Drawing.Point(434, 24);
            this.btnTimkiem_Tonghop.Name = "btnTimkiem_Tonghop";
            this.btnTimkiem_Tonghop.Size = new System.Drawing.Size(98, 26);
            this.btnTimkiem_Tonghop.TabIndex = 86;
            this.btnTimkiem_Tonghop.Text = "Tìm kiếm";
            this.btnTimkiem_Tonghop.Click += new System.EventHandler(this.btnTimkiem_Tonghop_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.iWidth = 65;
            this.dtpDenNgay.Location = new System.Drawing.Point(232, 25);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.sCaption = "Đến ngày:";
            this.dtpDenNgay.sFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Size = new System.Drawing.Size(195, 21);
            this.dtpDenNgay.TabIndex = 51;
            this.dtpDenNgay.uValue = new System.DateTime(2020, 4, 15, 9, 40, 0, 0);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.iWidth = 80;
            this.dtpTuNgay.Location = new System.Drawing.Point(12, 25);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.sCaption = "Từ ngày:";
            this.dtpTuNgay.sFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Size = new System.Drawing.Size(212, 21);
            this.dtpTuNgay.TabIndex = 52;
            this.dtpTuNgay.uValue = new System.DateTime(2020, 4, 15, 9, 40, 0, 0);
            // 
            // Tab_BinCode
            // 
            this.Tab_BinCode.Controls.Add(this.grid_Chitiet);
            this.Tab_BinCode.Controls.Add(this.groupControl2);
            this.Tab_BinCode.Name = "Tab_BinCode";
            this.Tab_BinCode.Size = new System.Drawing.Size(1063, 401);
            this.Tab_BinCode.Text = "Chi tiết";
            // 
            // grid_Chitiet
            // 
            this.grid_Chitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Chitiet.Location = new System.Drawing.Point(0, 58);
            this.grid_Chitiet.MainView = this.gridView_Chitiet;
            this.grid_Chitiet.Name = "grid_Chitiet";
            this.grid_Chitiet.Size = new System.Drawing.Size(1063, 343);
            this.grid_Chitiet.TabIndex = 101;
            this.grid_Chitiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Chitiet,
            this.gridView4});
            // 
            // gridView_Chitiet
            // 
            this.gridView_Chitiet.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView_Chitiet.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView_Chitiet.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView_Chitiet.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView_Chitiet.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView_Chitiet.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView_Chitiet.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView_Chitiet.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView_Chitiet.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView_Chitiet.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_Chitiet.Appearance.GroupRow.Options.UseFont = true;
            this.gridView_Chitiet.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView_Chitiet.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView_Chitiet.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView_Chitiet.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_Chitiet.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_Chitiet.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView_Chitiet.Appearance.Row.Options.UseForeColor = true;
            this.gridView_Chitiet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DocumentNo,
            this.gridColumn1,
            this.gridColumn2,
            this.ItemNo,
            this.gridColumn6,
            this.gridColumn8,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn7});
            this.gridView_Chitiet.GridControl = this.grid_Chitiet;
            this.gridView_Chitiet.GroupCount = 1;
            this.gridView_Chitiet.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TruckQty", this.gridColumn3, "{0:N0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QRCodeQty", this.gridColumn4, "{0:N0}")});
            this.gridView_Chitiet.IndicatorWidth = 50;
            this.gridView_Chitiet.Name = "gridView_Chitiet";
            this.gridView_Chitiet.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView_Chitiet.OptionsBehavior.Editable = false;
            this.gridView_Chitiet.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView_Chitiet.OptionsView.ShowGroupPanel = false;
            this.gridView_Chitiet.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn7, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView_Chitiet.ViewCaption = "Chưa hoàn thành";
            this.gridView_Chitiet.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_Chitiet_CustomDrawRowIndicator);
            // 
            // DocumentNo
            // 
            this.DocumentNo.Caption = "Lệnh sản xuất";
            this.DocumentNo.FieldName = "Document";
            this.DocumentNo.Name = "DocumentNo";
            this.DocumentNo.OptionsColumn.AllowEdit = false;
            this.DocumentNo.Visible = true;
            this.DocumentNo.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ngày";
            this.gridColumn1.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn1.FieldName = "Date";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ca";
            this.gridColumn2.FieldName = "Ca";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // ItemNo
            // 
            this.ItemNo.Caption = "Sản phẩm";
            this.ItemNo.FieldName = "ItemNo";
            this.ItemNo.Name = "ItemNo";
            this.ItemNo.OptionsColumn.AllowEdit = false;
            this.ItemNo.Visible = true;
            this.ItemNo.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Lot";
            this.gridColumn6.FieldName = "Lot";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Loại bao bì";
            this.gridColumn8.FieldName = "PackageCode";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số bao";
            this.gridColumn3.DisplayFormat.FormatString = "N0";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "TruckQty";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Trọng lượng";
            this.gridColumn4.DisplayFormat.FormatString = "N0";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "QRCodeQty";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Nghiệp vụ";
            this.gridColumn7.FieldName = "Note";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Note", "SUM={0:N0}")});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 9;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.grid_Chitiet;
            this.gridView4.Name = "gridView4";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.cboLSX);
            this.groupControl2.Controls.Add(this.btnIn_Chitiet);
            this.groupControl2.Controls.Add(this.btnTimKiem_Chitiet);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1063, 58);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Tìm kiếm";
            // 
            // cboLSX
            // 
            this.cboLSX.iWidth = 130;
            this.cboLSX.Location = new System.Drawing.Point(11, 29);
            this.cboLSX.Name = "cboLSX";
            this.cboLSX.sCaption = "Nhập/Quét lệnh sản xuất:";
            this.cboLSX.sColumnCaption = "Lệnh sản xuất";
            this.cboLSX.sField = "BatchNo";
            this.cboLSX.Size = new System.Drawing.Size(319, 21);
            this.cboLSX.TabIndex = 128;
            this.cboLSX.uDisplayMember = "BatchNo";
            this.cboLSX.uEditValue = "";
            this.cboLSX.uValueMember = "BatchNo";
            this.cboLSX.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboLSX_uQueryPopUp);
            // 
            // btnIn_Chitiet
            // 
            this.btnIn_Chitiet.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnIn_Chitiet.Appearance.Options.UseForeColor = true;
            this.btnIn_Chitiet.Image = ((System.Drawing.Image)(resources.GetObject("btnIn_Chitiet.Image")));
            this.btnIn_Chitiet.ImageIndex = 0;
            this.btnIn_Chitiet.ImageList = this.IML;
            this.btnIn_Chitiet.Location = new System.Drawing.Point(440, 24);
            this.btnIn_Chitiet.Name = "btnIn_Chitiet";
            this.btnIn_Chitiet.Size = new System.Drawing.Size(98, 26);
            this.btnIn_Chitiet.TabIndex = 87;
            this.btnIn_Chitiet.Text = "In";
            this.btnIn_Chitiet.Click += new System.EventHandler(this.btnIn_Chitiet_Click);
            // 
            // btnTimKiem_Chitiet
            // 
            this.btnTimKiem_Chitiet.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem_Chitiet.Appearance.Options.UseForeColor = true;
            this.btnTimKiem_Chitiet.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem_Chitiet.Image")));
            this.btnTimKiem_Chitiet.ImageIndex = 0;
            this.btnTimKiem_Chitiet.ImageList = this.IML;
            this.btnTimKiem_Chitiet.Location = new System.Drawing.Point(336, 24);
            this.btnTimKiem_Chitiet.Name = "btnTimKiem_Chitiet";
            this.btnTimKiem_Chitiet.Size = new System.Drawing.Size(98, 26);
            this.btnTimKiem_Chitiet.TabIndex = 86;
            this.btnTimKiem_Chitiet.Text = "Tìm kiếm";
            this.btnTimKiem_Chitiet.Click += new System.EventHandler(this.btnTimKiem_Chitiet_Click);
            // 
            // frmBC_LenhSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 429);
            this.Controls.Add(this.Tab);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmBC_LenhSanXuat";
            this.Text = "BÁO CÁO THEO LỆNH SẢN XUẤT";
            this.Load += new System.EventHandler(this.frmBC_LenhSanXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tab)).EndInit();
            this.Tab.ResumeLayout(false);
            this.Tab_all.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Tonghop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Tonghop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.Tab_BinCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Chitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Chitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraTab.XtraTabControl Tab;
        private DevExpress.XtraTab.XtraTabPage Tab_all;
        private DevExpress.XtraTab.XtraTabPage Tab_BinCode;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DELFI_User_Control.uDateTimePicker2 dtpDenNgay;
        private DELFI_User_Control.uDateTimePicker2 dtpTuNgay;
        private DevExpress.XtraEditors.SimpleButton btnIn_Tonghop;
        private DevExpress.XtraEditors.SimpleButton btnTimkiem_Tonghop;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnIn_Chitiet;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem_Chitiet;
        private DELFI_User_Control.uComboBox cboLSX;
        private DevExpress.XtraGrid.GridControl grid_Chitiet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Chitiet;
        private DevExpress.XtraGrid.Columns.GridColumn DocumentNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn ItemNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.GridControl grid_Tonghop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Tonghop;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}