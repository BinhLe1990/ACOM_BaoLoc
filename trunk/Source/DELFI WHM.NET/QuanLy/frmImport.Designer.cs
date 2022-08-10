namespace DELFI_WHM.NET.QuanLy
{
    partial class frmImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImport));
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnFilemau = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu_Import = new DevExpress.XtraEditors.SimpleButton();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.Tab = new DevExpress.XtraTab.XtraTabControl();
            this.Tab_NhapKho = new DevExpress.XtraTab.XtraTabPage();
            this.grid_Nhapkho = new DevExpress.XtraGrid.GridControl();
            this.gridView_Nhapkho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ItemNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Lot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BinCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Certificate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PackageCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptLoai = new DELFI_WHM.NET.DELFI_User_Control.uComboBox.RepositoryItemCustomGridLookUpEdit();
            this.repositoryItemCustomGridLookUpEdit1View = new DELFI_WHM.NET.DELFI_User_Control.uComboBox.CustomGridView();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CropYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrossWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TruckQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPackageQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NetWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sample = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Thoigian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tab_DMLot = new DevExpress.XtraTab.XtraTabPage();
            this.grid_DMLOT = new DevExpress.XtraGrid.GridControl();
            this.gridView_DMLOT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Lot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_BatchNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.col_Bag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_CropYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_PackingUnitCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Shift = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_CreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab)).BeginInit();
            this.Tab.SuspendLayout();
            this.Tab_NhapKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Nhapkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Nhapkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCustomGridLookUpEdit1View)).BeginInit();
            this.Tab_DMLot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DMLOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DMLOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
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
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnFilemau);
            this.panelControl2.Controls.Add(this.btnLuu_Import);
            this.panelControl2.Controls.Add(this.btnImport);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1378, 50);
            this.panelControl2.TabIndex = 61;
            // 
            // btnFilemau
            // 
            this.btnFilemau.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnFilemau.Appearance.Options.UseForeColor = true;
            this.btnFilemau.Image = ((System.Drawing.Image)(resources.GetObject("btnFilemau.Image")));
            this.btnFilemau.ImageIndex = 0;
            this.btnFilemau.ImageList = this.IML;
            this.btnFilemau.Location = new System.Drawing.Point(224, 12);
            this.btnFilemau.Name = "btnFilemau";
            this.btnFilemau.Size = new System.Drawing.Size(100, 26);
            this.btnFilemau.TabIndex = 62;
            this.btnFilemau.Text = "Xuất fle mẫu";
            this.btnFilemau.Click += new System.EventHandler(this.btnFilemau_Click);
            // 
            // btnLuu_Import
            // 
            this.btnLuu_Import.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnLuu_Import.Appearance.Options.UseForeColor = true;
            this.btnLuu_Import.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_Import.Image")));
            this.btnLuu_Import.ImageIndex = 6;
            this.btnLuu_Import.ImageList = this.IML;
            this.btnLuu_Import.Location = new System.Drawing.Point(118, 12);
            this.btnLuu_Import.Name = "btnLuu_Import";
            this.btnLuu_Import.Size = new System.Drawing.Size(100, 26);
            this.btnLuu_Import.TabIndex = 61;
            this.btnLuu_Import.Tag = "ADD";
            this.btnLuu_Import.Text = "Lưu";
            this.btnLuu_Import.Click += new System.EventHandler(this.btnLuu_Import_Click);
            // 
            // btnImport
            // 
            this.btnImport.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Appearance.Options.UseForeColor = true;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageIndex = 0;
            this.btnImport.ImageList = this.IML;
            this.btnImport.Location = new System.Drawing.Point(12, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 26);
            this.btnImport.TabIndex = 60;
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // Tab
            // 
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 50);
            this.Tab.Name = "Tab";
            this.Tab.SelectedTabPage = this.Tab_NhapKho;
            this.Tab.Size = new System.Drawing.Size(1378, 553);
            this.Tab.TabIndex = 62;
            this.Tab.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.Tab_NhapKho,
            this.Tab_DMLot});
            // 
            // Tab_NhapKho
            // 
            this.Tab_NhapKho.Controls.Add(this.grid_Nhapkho);
            this.Tab_NhapKho.Name = "Tab_NhapKho";
            this.Tab_NhapKho.Size = new System.Drawing.Size(1372, 525);
            this.Tab_NhapKho.Text = "Nhập kho";
            // 
            // grid_Nhapkho
            // 
            this.grid_Nhapkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Nhapkho.Location = new System.Drawing.Point(0, 0);
            this.grid_Nhapkho.MainView = this.gridView_Nhapkho;
            this.grid_Nhapkho.Name = "grid_Nhapkho";
            this.grid_Nhapkho.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.rptLoai});
            this.grid_Nhapkho.Size = new System.Drawing.Size(1372, 525);
            this.grid_Nhapkho.TabIndex = 106;
            this.grid_Nhapkho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Nhapkho});
            // 
            // gridView_Nhapkho
            // 
            this.gridView_Nhapkho.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView_Nhapkho.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView_Nhapkho.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_Nhapkho.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_Nhapkho.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView_Nhapkho.Appearance.Row.Options.UseForeColor = true;
            this.gridView_Nhapkho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Date,
            this.ItemNo,
            this.Lot,
            this.BinCode,
            this.Certificate,
            this.PackageCode,
            this.CropYear,
            this.GrossWeight,
            this.TruckQty,
            this.TotalPackageQty,
            this.NetWeight,
            this.Note,
            this.Sample,
            this.Ca,
            this.Thoigian});
            this.gridView_Nhapkho.GridControl = this.grid_Nhapkho;
            this.gridView_Nhapkho.IndicatorWidth = 50;
            this.gridView_Nhapkho.Name = "gridView_Nhapkho";
            this.gridView_Nhapkho.OptionsBehavior.Editable = false;
            this.gridView_Nhapkho.OptionsView.ShowGroupPanel = false;
            this.gridView_Nhapkho.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_Nhapkho_CustomDrawRowIndicator);
            this.gridView_Nhapkho.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_Nhapkho_RowCellStyle);
            // 
            // Date
            // 
            this.Date.Caption = "Ngày nhập";
            this.Date.ColumnEdit = this.repositoryItemDateEdit1;
            this.Date.FieldName = "Date";
            this.Date.Name = "Date";
            this.Date.OptionsColumn.AllowEdit = false;
            this.Date.Visible = true;
            this.Date.VisibleIndex = 0;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // ItemNo
            // 
            this.ItemNo.Caption = "Sản phẩm";
            this.ItemNo.FieldName = "ItemNo";
            this.ItemNo.Name = "ItemNo";
            this.ItemNo.OptionsColumn.AllowEdit = false;
            this.ItemNo.Visible = true;
            this.ItemNo.VisibleIndex = 1;
            // 
            // Lot
            // 
            this.Lot.Caption = "Lot";
            this.Lot.FieldName = "Lot";
            this.Lot.Name = "Lot";
            this.Lot.OptionsColumn.AllowEdit = false;
            this.Lot.Visible = true;
            this.Lot.VisibleIndex = 2;
            // 
            // BinCode
            // 
            this.BinCode.Caption = "Cây hàng";
            this.BinCode.FieldName = "BinCode";
            this.BinCode.Name = "BinCode";
            this.BinCode.OptionsColumn.AllowEdit = false;
            this.BinCode.Visible = true;
            this.BinCode.VisibleIndex = 3;
            // 
            // Certificate
            // 
            this.Certificate.Caption = "Certificate";
            this.Certificate.FieldName = "Certificate";
            this.Certificate.Name = "Certificate";
            this.Certificate.OptionsColumn.AllowEdit = false;
            this.Certificate.Visible = true;
            this.Certificate.VisibleIndex = 4;
            // 
            // PackageCode
            // 
            this.PackageCode.Caption = "Loại bao bì";
            this.PackageCode.ColumnEdit = this.rptLoai;
            this.PackageCode.FieldName = "PackageCode";
            this.PackageCode.Name = "PackageCode";
            this.PackageCode.OptionsColumn.AllowEdit = false;
            this.PackageCode.Visible = true;
            this.PackageCode.VisibleIndex = 5;
            // 
            // rptLoai
            // 
            this.rptLoai.AutoComplete = false;
            this.rptLoai.AutoHeight = false;
            this.rptLoai.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptLoai.Name = "rptLoai";
            this.rptLoai.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rptLoai.View = this.repositoryItemCustomGridLookUpEdit1View;
            // 
            // repositoryItemCustomGridLookUpEdit1View
            // 
            this.repositoryItemCustomGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn16,
            this.gridColumn17});
            this.repositoryItemCustomGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemCustomGridLookUpEdit1View.Name = "repositoryItemCustomGridLookUpEdit1View";
            this.repositoryItemCustomGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemCustomGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "PackageCode";
            this.gridColumn16.FieldName = "PackageCode";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 0;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "PackageType";
            this.gridColumn17.FieldName = "PackageType";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 1;
            // 
            // CropYear
            // 
            this.CropYear.Caption = "CropYear";
            this.CropYear.FieldName = "CropYear";
            this.CropYear.Name = "CropYear";
            this.CropYear.Visible = true;
            this.CropYear.VisibleIndex = 6;
            // 
            // GrossWeight
            // 
            this.GrossWeight.Caption = "TL cân";
            this.GrossWeight.DisplayFormat.FormatString = "N0";
            this.GrossWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GrossWeight.FieldName = "GrossWeight";
            this.GrossWeight.Name = "GrossWeight";
            this.GrossWeight.OptionsColumn.AllowEdit = false;
            this.GrossWeight.Visible = true;
            this.GrossWeight.VisibleIndex = 7;
            // 
            // TruckQty
            // 
            this.TruckQty.Caption = "Số bao";
            this.TruckQty.FieldName = "TruckQty";
            this.TruckQty.Name = "TruckQty";
            this.TruckQty.Visible = true;
            this.TruckQty.VisibleIndex = 8;
            // 
            // TotalPackageQty
            // 
            this.TotalPackageQty.Caption = "TL Trừ bì";
            this.TotalPackageQty.FieldName = "TotalPackageQty";
            this.TotalPackageQty.Name = "TotalPackageQty";
            this.TotalPackageQty.OptionsColumn.AllowEdit = false;
            this.TotalPackageQty.Visible = true;
            this.TotalPackageQty.VisibleIndex = 9;
            // 
            // NetWeight
            // 
            this.NetWeight.Caption = "NetWeight";
            this.NetWeight.DisplayFormat.FormatString = "N0";
            this.NetWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NetWeight.FieldName = "NetWeight";
            this.NetWeight.Name = "NetWeight";
            this.NetWeight.OptionsColumn.AllowEdit = false;
            this.NetWeight.Visible = true;
            this.NetWeight.VisibleIndex = 10;
            // 
            // Note
            // 
            this.Note.Caption = "Ghi chú";
            this.Note.FieldName = "Note";
            this.Note.Name = "Note";
            this.Note.OptionsColumn.AllowEdit = false;
            this.Note.Visible = true;
            this.Note.VisibleIndex = 11;
            // 
            // Sample
            // 
            this.Sample.Caption = "Sample";
            this.Sample.FieldName = "Sample";
            this.Sample.Name = "Sample";
            this.Sample.OptionsColumn.AllowEdit = false;
            this.Sample.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.Sample.Visible = true;
            this.Sample.VisibleIndex = 12;
            // 
            // Ca
            // 
            this.Ca.Caption = "Ca";
            this.Ca.FieldName = "Ca";
            this.Ca.Name = "Ca";
            this.Ca.OptionsColumn.AllowEdit = false;
            this.Ca.Visible = true;
            this.Ca.VisibleIndex = 13;
            // 
            // Thoigian
            // 
            this.Thoigian.Caption = "Thời gian";
            this.Thoigian.FieldName = "Thoigian";
            this.Thoigian.Name = "Thoigian";
            this.Thoigian.Visible = true;
            this.Thoigian.VisibleIndex = 14;
            // 
            // Tab_DMLot
            // 
            this.Tab_DMLot.Controls.Add(this.grid_DMLOT);
            this.Tab_DMLot.Name = "Tab_DMLot";
            this.Tab_DMLot.Size = new System.Drawing.Size(1372, 525);
            this.Tab_DMLot.Text = "DM_Lot";
            // 
            // grid_DMLOT
            // 
            this.grid_DMLOT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_DMLOT.Location = new System.Drawing.Point(0, 0);
            this.grid_DMLOT.MainView = this.gridView_DMLOT;
            this.grid_DMLOT.Name = "grid_DMLOT";
            this.grid_DMLOT.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit2});
            this.grid_DMLOT.Size = new System.Drawing.Size(1372, 525);
            this.grid_DMLOT.TabIndex = 60;
            this.grid_DMLOT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DMLOT});
            // 
            // gridView_DMLOT
            // 
            this.gridView_DMLOT.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView_DMLOT.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView_DMLOT.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_DMLOT.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_DMLOT.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView_DMLOT.Appearance.Row.Options.UseForeColor = true;
            this.gridView_DMLOT.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView_DMLOT.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Black;
            this.gridView_DMLOT.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView_DMLOT.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridView_DMLOT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Lot,
            this.col_BatchNo,
            this.col_Date,
            this.col_Bag,
            this.col_CropYear,
            this.col_ItemCode,
            this.col_PackingUnitCode,
            this.col_Note,
            this.col_Shift,
            this.col_CreateDate});
            this.gridView_DMLOT.GridControl = this.grid_DMLOT;
            this.gridView_DMLOT.IndicatorWidth = 50;
            this.gridView_DMLOT.Name = "gridView_DMLOT";
            this.gridView_DMLOT.OptionsBehavior.Editable = false;
            this.gridView_DMLOT.OptionsView.ShowGroupPanel = false;
            this.gridView_DMLOT.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView2_CustomDrawRowIndicator);
            this.gridView_DMLOT.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_DMLOT_RowCellStyle);
            // 
            // col_Lot
            // 
            this.col_Lot.Caption = "Số lot (*)";
            this.col_Lot.FieldName = "Lot";
            this.col_Lot.Name = "col_Lot";
            this.col_Lot.Visible = true;
            this.col_Lot.VisibleIndex = 0;
            // 
            // col_BatchNo
            // 
            this.col_BatchNo.Caption = "Lệnh sản xuất";
            this.col_BatchNo.FieldName = "BatchNo";
            this.col_BatchNo.Name = "col_BatchNo";
            this.col_BatchNo.Visible = true;
            this.col_BatchNo.VisibleIndex = 1;
            // 
            // col_Date
            // 
            this.col_Date.Caption = "Ngày (*)";
            this.col_Date.ColumnEdit = this.repositoryItemDateEdit2;
            this.col_Date.FieldName = "Date";
            this.col_Date.Name = "col_Date";
            this.col_Date.Visible = true;
            this.col_Date.VisibleIndex = 2;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // col_Bag
            // 
            this.col_Bag.Caption = "Số bao (*)";
            this.col_Bag.FieldName = "Bag";
            this.col_Bag.Name = "col_Bag";
            this.col_Bag.Visible = true;
            this.col_Bag.VisibleIndex = 3;
            // 
            // col_CropYear
            // 
            this.col_CropYear.Caption = "Crop year (*)";
            this.col_CropYear.FieldName = "CropYear";
            this.col_CropYear.Name = "col_CropYear";
            this.col_CropYear.Visible = true;
            this.col_CropYear.VisibleIndex = 4;
            // 
            // col_ItemCode
            // 
            this.col_ItemCode.Caption = "Sản phẩm (*)";
            this.col_ItemCode.FieldName = "ItemCode";
            this.col_ItemCode.Name = "col_ItemCode";
            this.col_ItemCode.Visible = true;
            this.col_ItemCode.VisibleIndex = 5;
            // 
            // col_PackingUnitCode
            // 
            this.col_PackingUnitCode.Caption = "Loại bao bì (*)";
            this.col_PackingUnitCode.FieldName = "PackingUnitCode";
            this.col_PackingUnitCode.Name = "col_PackingUnitCode";
            this.col_PackingUnitCode.Visible = true;
            this.col_PackingUnitCode.VisibleIndex = 6;
            // 
            // col_Note
            // 
            this.col_Note.Caption = "Ghi chú";
            this.col_Note.FieldName = "Note";
            this.col_Note.Name = "col_Note";
            this.col_Note.Visible = true;
            this.col_Note.VisibleIndex = 7;
            // 
            // col_Shift
            // 
            this.col_Shift.Caption = "Ca";
            this.col_Shift.FieldName = "Shift";
            this.col_Shift.Name = "col_Shift";
            this.col_Shift.Visible = true;
            this.col_Shift.VisibleIndex = 8;
            // 
            // col_CreateDate
            // 
            this.col_CreateDate.Caption = "Ngày tạo (*)";
            this.col_CreateDate.FieldName = "CreateDate";
            this.col_CreateDate.Name = "col_CreateDate";
            this.col_CreateDate.Visible = true;
            this.col_CreateDate.VisibleIndex = 9;
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 603);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.panelControl2);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmImport";
            this.Text = "IMPORT DATA";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tab)).EndInit();
            this.Tab.ResumeLayout(false);
            this.Tab_NhapKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Nhapkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Nhapkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCustomGridLookUpEdit1View)).EndInit();
            this.Tab_DMLot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_DMLOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DMLOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnLuu_Import;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraTab.XtraTabControl Tab;
        private DevExpress.XtraTab.XtraTabPage Tab_NhapKho;
        private DevExpress.XtraTab.XtraTabPage Tab_DMLot;
        private DevExpress.XtraGrid.GridControl grid_DMLOT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DMLOT;
        private DevExpress.XtraGrid.Columns.GridColumn col_Lot;
        private DevExpress.XtraGrid.Columns.GridColumn col_BatchNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_Date;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn col_Bag;
        private DevExpress.XtraGrid.Columns.GridColumn col_CropYear;
        private DevExpress.XtraGrid.Columns.GridColumn col_ItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn col_PackingUnitCode;
        private DevExpress.XtraGrid.Columns.GridColumn col_Note;
        private DevExpress.XtraGrid.Columns.GridColumn col_Shift;
        private DevExpress.XtraGrid.Columns.GridColumn col_CreateDate;
        private DevExpress.XtraEditors.SimpleButton btnFilemau;
        private DevExpress.XtraGrid.GridControl grid_Nhapkho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Nhapkho;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn ItemNo;
        private DevExpress.XtraGrid.Columns.GridColumn Lot;
        private DevExpress.XtraGrid.Columns.GridColumn BinCode;
        private DevExpress.XtraGrid.Columns.GridColumn Certificate;
        private DELFI_User_Control.uComboBox.RepositoryItemCustomGridLookUpEdit rptLoai;
        private DELFI_User_Control.uComboBox.CustomGridView repositoryItemCustomGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn PackageCode;
        private DevExpress.XtraGrid.Columns.GridColumn GrossWeight;
        private DevExpress.XtraGrid.Columns.GridColumn TruckQty;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPackageQty;
        private DevExpress.XtraGrid.Columns.GridColumn NetWeight;
        private DevExpress.XtraGrid.Columns.GridColumn Note;
        private DevExpress.XtraGrid.Columns.GridColumn Sample;
        private DevExpress.XtraGrid.Columns.GridColumn Ca;
        private DevExpress.XtraGrid.Columns.GridColumn Thoigian;
        private DevExpress.XtraGrid.Columns.GridColumn CropYear;
    }
}