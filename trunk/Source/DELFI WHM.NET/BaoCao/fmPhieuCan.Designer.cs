namespace DELFI_WHM.NET.BaoCao
{
    partial class fmPhieuCan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPhieuCan));
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.btnSuaSoCan = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.dtpDenNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.dtpTuNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.cboTrangThai = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboWeightType = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.txtSoHopDong = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.griDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView_Chitiet = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemDateEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemDateEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.xtraTabControl3.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Chitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit5.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit6.CalendarTimeProperties)).BeginInit();
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
            this.btnSearch.Location = new System.Drawing.Point(12, 103);
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
            this.xtraTabControl3.Size = new System.Drawing.Size(1069, 152);
            this.xtraTabControl3.TabIndex = 83;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.AutoScroll = true;
            this.xtraTabPage3.Controls.Add(this.btnSuaSoCan);
            this.xtraTabPage3.Controls.Add(this.btnPrint);
            this.xtraTabPage3.Controls.Add(this.dtpDenNgay);
            this.xtraTabPage3.Controls.Add(this.btnSearch);
            this.xtraTabPage3.Controls.Add(this.dtpTuNgay);
            this.xtraTabPage3.Controls.Add(this.cboTrangThai);
            this.xtraTabPage3.Controls.Add(this.cboWeightType);
            this.xtraTabPage3.Controls.Add(this.txtSoHopDong);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1063, 146);
            // 
            // btnSuaSoCan
            // 
            this.btnSuaSoCan.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnSuaSoCan.Appearance.Options.UseForeColor = true;
            this.btnSuaSoCan.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaSoCan.Image")));
            this.btnSuaSoCan.ImageIndex = 0;
            this.btnSuaSoCan.ImageList = this.IML;
            this.btnSuaSoCan.Location = new System.Drawing.Point(219, 103);
            this.btnSuaSoCan.Name = "btnSuaSoCan";
            this.btnSuaSoCan.Size = new System.Drawing.Size(98, 26);
            this.btnSuaSoCan.TabIndex = 86;
            this.btnSuaSoCan.Tag = "EDIT";
            this.btnSuaSoCan.Text = "Sửa số cân";
            this.btnSuaSoCan.Click += new System.EventHandler(this.btnSuaSoCan_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Appearance.Options.UseForeColor = true;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageIndex = 0;
            this.btnPrint.ImageList = this.IML;
            this.btnPrint.Location = new System.Drawing.Point(115, 103);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 26);
            this.btnPrint.TabIndex = 85;
            this.btnPrint.Text = "In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.iWidth = 65;
            this.dtpDenNgay.Location = new System.Drawing.Point(243, 21);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDenNgay.MaskDateTime = "dd/MM/yyyy";
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.sCaption = "Đến ngày:";
            this.dtpDenNgay.sFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Size = new System.Drawing.Size(195, 21);
            this.dtpDenNgay.TabIndex = 50;
            this.dtpDenNgay.uDateTime = new System.DateTime(2020, 4, 15, 9, 40, 0, 0);
            this.dtpDenNgay.uValue = new System.DateTime(2020, 4, 15, 9, 40, 0, 0);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.iWidth = 80;
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
            // cboTrangThai
            // 
            this.cboTrangThai.iWidth = 65;
            this.cboTrangThai.Location = new System.Drawing.Point(243, 48);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.sCaption = "Trạng thái:";
            this.cboTrangThai.sColumnCaption = "Trạng thái";
            this.cboTrangThai.sField = "Trangthai";
            this.cboTrangThai.Size = new System.Drawing.Size(195, 21);
            this.cboTrangThai.sNullText = "<Chọn trạng thái>";
            this.cboTrangThai.TabIndex = 51;
            this.cboTrangThai.uDisplayMember = "Trangthai";
            this.cboTrangThai.uEditValue = null;
            this.cboTrangThai.uValueMember = "Trangthai";
            // 
            // cboWeightType
            // 
            this.cboWeightType.iWidth = 80;
            this.cboWeightType.Location = new System.Drawing.Point(12, 48);
            this.cboWeightType.Margin = new System.Windows.Forms.Padding(4);
            this.cboWeightType.Name = "cboWeightType";
            this.cboWeightType.sCaption = "Weight type:";
            this.cboWeightType.sColumnCaption = "Trạng thái";
            this.cboWeightType.sField = "WeightType";
            this.cboWeightType.Size = new System.Drawing.Size(212, 21);
            this.cboWeightType.sNullText = "<Chọn>";
            this.cboWeightType.TabIndex = 51;
            this.cboWeightType.uDisplayMember = "WeightType";
            this.cboWeightType.uEditValue = null;
            this.cboWeightType.uValueMember = "WeightType";
            // 
            // txtSoHopDong
            // 
            this.txtSoHopDong.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtSoHopDong.iWidth = 130;
            this.txtSoHopDong.Location = new System.Drawing.Point(12, 75);
            this.txtSoHopDong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoHopDong.Name = "txtSoHopDong";
            this.txtSoHopDong.sCaption = "Weight note/Vehicle No.:";
            this.txtSoHopDong.SelectionStart = 0;
            this.txtSoHopDong.Size = new System.Drawing.Size(426, 21);
            this.txtSoHopDong.TabIndex = 0;
            this.txtSoHopDong.Tag = "..MaNhaCungCap";
            // 
            // griDanhSach
            // 
            this.griDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.griDanhSach.Location = new System.Drawing.Point(0, 152);
            this.griDanhSach.MainView = this.gridView_Chitiet;
            this.griDanhSach.Name = "griDanhSach";
            this.griDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit4,
            this.repositoryItemDateEdit5,
            this.repositoryItemDateEdit6});
            this.griDanhSach.Size = new System.Drawing.Size(1069, 451);
            this.griDanhSach.TabIndex = 113;
            this.griDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18});
            this.gridView_Chitiet.GridControl = this.griDanhSach;
            this.gridView_Chitiet.IndicatorWidth = 50;
            this.gridView_Chitiet.Name = "gridView_Chitiet";
            this.gridView_Chitiet.OptionsBehavior.Editable = false;
            this.gridView_Chitiet.OptionsSelection.MultiSelect = true;
            this.gridView_Chitiet.OptionsView.ColumnAutoWidth = false;
            this.gridView_Chitiet.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Chitiet.OptionsView.ShowGroupPanel = false;
            this.gridView_Chitiet.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView2_CustomDrawRowIndicator);
            this.gridView_Chitiet.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView2_KeyUp);
            this.gridView_Chitiet.DoubleClick += new System.EventHandler(this.gridView_Chitiet_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Số phiếu";
            this.gridColumn1.FieldName = "WeightNote";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ngày tạo";
            this.gridColumn2.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn2.FieldName = "CreateDate";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số xe";
            this.gridColumn3.FieldName = "VehicleNo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Khách hàng";
            this.gridColumn4.FieldName = "VendorName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Sản phẩm";
            this.gridColumn5.FieldName = "ItemCode";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ngày vào";
            this.gridColumn6.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn6.FieldName = "DateIn";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Ngày ra";
            this.gridColumn7.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn7.FieldName = "DateOut";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Cân lần 1";
            this.gridColumn8.DisplayFormat.FormatString = "N0";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn8.FieldName = "FirstWeight";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Cân lần 2";
            this.gridColumn9.DisplayFormat.FormatString = "N0";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn9.FieldName = "SecondWeight";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Số bao";
            this.gridColumn10.DisplayFormat.FormatString = "N0";
            this.gridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn10.FieldName = "TruckQty";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "TL 1 bao";
            this.gridColumn11.FieldName = "PackageQty";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 10;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Tổng TL bao";
            this.gridColumn12.FieldName = "TotalPackageQty";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 11;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "TL Nhập/xuất";
            this.gridColumn13.DisplayFormat.FormatString = "N0";
            this.gridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn13.FieldName = "NetWeight";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 12;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Kiểu cân";
            this.gridColumn14.FieldName = "WeightType";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 13;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Trạng thái";
            this.gridColumn15.FieldName = "Trangthai";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 14;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Người tạo";
            this.gridColumn16.FieldName = "UserName";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 15;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "ID";
            this.gridColumn17.FieldName = "ID";
            this.gridColumn17.Name = "gridColumn17";
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Ghi chú";
            this.gridColumn18.FieldName = "Note";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 16;
            // 
            // repositoryItemDateEdit4
            // 
            this.repositoryItemDateEdit4.AutoHeight = false;
            this.repositoryItemDateEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit4.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit4.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit4.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit4.Name = "repositoryItemDateEdit4";
            // 
            // repositoryItemDateEdit5
            // 
            this.repositoryItemDateEdit5.AutoHeight = false;
            this.repositoryItemDateEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit5.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit5.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit5.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit5.Name = "repositoryItemDateEdit5";
            // 
            // repositoryItemDateEdit6
            // 
            this.repositoryItemDateEdit6.AutoHeight = false;
            this.repositoryItemDateEdit6.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit6.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit6.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit6.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit6.Name = "repositoryItemDateEdit6";
            // 
            // fmPhieuCan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 603);
            this.Controls.Add(this.griDanhSach);
            this.Controls.Add(this.xtraTabControl3);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "fmPhieuCan";
            this.Tag = "|frmDanhSachPhieuCan|";
            this.Text = "DANH SÁCH PHIẾU CÂN";
            this.Load += new System.EventHandler(this.fmPhieuCan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.xtraTabControl3.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Chitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit5.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit6.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DELFI_User_Control.uDateTimePicker2 dtpDenNgay;
        private DELFI_User_Control.uDateTimePicker2 dtpTuNgay;
        private DELFI_User_Control.uComboBox cboWeightType;
        private DELFI_User_Control.uTextBox txtSoHopDong;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private DELFI_User_Control.uComboBox cboTrangThai;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.GridControl griDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Chitiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit5;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit6;
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
        private DevExpress.XtraEditors.SimpleButton btnSuaSoCan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
    }
}