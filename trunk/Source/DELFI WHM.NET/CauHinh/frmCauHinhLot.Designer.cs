namespace DELFI_WHM.NET.CauHinh
{
    partial class frmCauHinhLot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCauHinhLot));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.pnMain = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnThemmoi = new DevExpress.XtraEditors.SimpleButton();
            this.group = new DevExpress.XtraEditors.GroupControl();
            this.dtpNgayTao = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.txtGhiChu = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.spnID = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.txtLot = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.cboCer = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboCropYear = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.lbGioihanLot = new DevExpress.XtraEditors.LabelControl();
            this.cboVatTu = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboQuicach = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.spnBag = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.cboLSX = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.spnShift = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.griDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Lot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.Bag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CropYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.xtraTabControl3.SuspendLayout();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group)).BeginInit();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
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
            this.btnLuu.Location = new System.Drawing.Point(120, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 26);
            this.btnLuu.TabIndex = 60;
            this.btnLuu.Tag = "ADD";
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // xtraTabControl3
            // 
            this.xtraTabControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl3.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl3.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl3.Name = "xtraTabControl3";
            this.xtraTabControl3.SelectedTabPage = this.pnMain;
            this.xtraTabControl3.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl3.Size = new System.Drawing.Size(1433, 188);
            this.xtraTabControl3.TabIndex = 58;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pnMain});
            // 
            // pnMain
            // 
            this.pnMain.AutoScroll = true;
            this.pnMain.Controls.Add(this.panelControl1);
            this.pnMain.Controls.Add(this.group);
            this.pnMain.Image = ((System.Drawing.Image)(resources.GetObject("pnMain.Image")));
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1427, 182);
            this.pnMain.TabPageWidth = 150;
            this.pnMain.Text = "Quản lý số lot";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThemmoi);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 146);
            this.panelControl1.LookAndFeel.SkinName = "Office 2013";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1427, 36);
            this.panelControl1.TabIndex = 105;
            this.panelControl1.TabStop = true;
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnThemmoi.Appearance.Options.UseForeColor = true;
            this.btnThemmoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemmoi.Image")));
            this.btnThemmoi.ImageIndex = 8;
            this.btnThemmoi.ImageList = this.IML;
            this.btnThemmoi.Location = new System.Drawing.Point(11, 5);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(103, 26);
            this.btnThemmoi.TabIndex = 108;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // group
            // 
            this.group.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.group.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.group.AppearanceCaption.Options.UseFont = true;
            this.group.AppearanceCaption.Options.UseForeColor = true;
            this.group.Controls.Add(this.dtpNgayTao);
            this.group.Controls.Add(this.txtGhiChu);
            this.group.Controls.Add(this.spnID);
            this.group.Controls.Add(this.txtLot);
            this.group.Controls.Add(this.cboCer);
            this.group.Controls.Add(this.cboCropYear);
            this.group.Controls.Add(this.lbGioihanLot);
            this.group.Controls.Add(this.cboVatTu);
            this.group.Controls.Add(this.cboQuicach);
            this.group.Controls.Add(this.spnBag);
            this.group.Controls.Add(this.cboLSX);
            this.group.Controls.Add(this.spnShift);
            this.group.Dock = System.Windows.Forms.DockStyle.Top;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.LookAndFeel.SkinName = "Office 2013";
            this.group.LookAndFeel.UseDefaultLookAndFeel = false;
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(1427, 146);
            this.group.TabIndex = 105;
            this.group.Text = "Thông tin";
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Location = new System.Drawing.Point(6, 25);
            this.dtpNgayTao.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.sCaption = "Ngày (*):";
            this.dtpNgayTao.sFormat = "d";
            this.dtpNgayTao.Size = new System.Drawing.Size(340, 21);
            this.dtpNgayTao.TabIndex = 50;
            this.dtpNgayTao.Tag = "..Date";
            this.dtpNgayTao.uDateTime = new System.DateTime(2020, 4, 7, 9, 22, 46, 31);
            this.dtpNgayTao.uValue = new System.DateTime(2020, 4, 7, 9, 22, 46, 31);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtGhiChu.Location = new System.Drawing.Point(6, 112);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.sCaption = "Ghi chú:";
            this.txtGhiChu.SelectionStart = 0;
            this.txtGhiChu.Size = new System.Drawing.Size(1066, 21);
            this.txtGhiChu.TabIndex = 0;
            this.txtGhiChu.Tag = "..Note";
            // 
            // spnID
            // 
            this.spnID.Location = new System.Drawing.Point(1078, 82);
            this.spnID.Name = "spnID";
            this.spnID.sCaption = "ID:";
            this.spnID.Size = new System.Drawing.Size(254, 21);
            this.spnID.TabIndex = 68;
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
            // txtLot
            // 
            this.txtLot.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtLot.iMaxLength = 20;
            this.txtLot.Location = new System.Drawing.Point(6, 54);
            this.txtLot.Margin = new System.Windows.Forms.Padding(4);
            this.txtLot.Name = "txtLot";
            this.txtLot.sCaption = "Số lot (*):";
            this.txtLot.SelectionStart = 0;
            this.txtLot.Size = new System.Drawing.Size(340, 21);
            this.txtLot.TabIndex = 0;
            this.txtLot.Tag = "..Lot";
            this.txtLot.uTextChanged += new System.EventHandler(this.txtLot_uTextChanged);
            // 
            // cboCer
            // 
            this.cboCer.Location = new System.Drawing.Point(412, 82);
            this.cboCer.Margin = new System.Windows.Forms.Padding(4);
            this.cboCer.Name = "cboCer";
            this.cboCer.sCaption = "Chứng nhận:";
            this.cboCer.sColumnCaption = "Chứng nhận";
            this.cboCer.sField = "Ten";
            this.cboCer.Size = new System.Drawing.Size(362, 21);
            this.cboCer.sNullText = "<Chọn>";
            this.cboCer.TabIndex = 67;
            this.cboCer.Tag = "..Cer";
            this.cboCer.uDisplayMember = "Ten";
            this.cboCer.uEditValue = null;
            this.cboCer.uValueMember = "Ten";
            this.cboCer.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboCer_uQueryPopUp);
            // 
            // cboCropYear
            // 
            this.cboCropYear.Location = new System.Drawing.Point(818, 25);
            this.cboCropYear.Margin = new System.Windows.Forms.Padding(4);
            this.cboCropYear.Name = "cboCropYear";
            this.cboCropYear.sCaption = "Crop year (*):";
            this.cboCropYear.sColumnCaption = "Crop year";
            this.cboCropYear.sField = "Ten";
            this.cboCropYear.Size = new System.Drawing.Size(254, 21);
            this.cboCropYear.sNullText = "<Chọn Crop year>";
            this.cboCropYear.TabIndex = 51;
            this.cboCropYear.Tag = "..CropYear";
            this.cboCropYear.uDisplayMember = "Ten";
            this.cboCropYear.uEditValue = null;
            this.cboCropYear.uValueMember = "Ten";
            this.cboCropYear.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboCropYear_uQueryPopUp);
            // 
            // lbGioihanLot
            // 
            this.lbGioihanLot.Location = new System.Drawing.Point(353, 61);
            this.lbGioihanLot.Name = "lbGioihanLot";
            this.lbGioihanLot.Size = new System.Drawing.Size(22, 13);
            this.lbGioihanLot.TabIndex = 66;
            this.lbGioihanLot.Text = "0/20";
            // 
            // cboVatTu
            // 
            this.cboVatTu.Location = new System.Drawing.Point(412, 25);
            this.cboVatTu.Margin = new System.Windows.Forms.Padding(4);
            this.cboVatTu.Name = "cboVatTu";
            this.cboVatTu.sCaption = "Sản phẩm (*):";
            this.cboVatTu.sColumnCaption = "Mã sản phẩm, Tên sản phẩm";
            this.cboVatTu.sField = "ItemNo, ItemName";
            this.cboVatTu.Size = new System.Drawing.Size(362, 21);
            this.cboVatTu.sNullText = "<Chọn sản phẩm>";
            this.cboVatTu.TabIndex = 60;
            this.cboVatTu.Tag = "..ItemCode";
            this.cboVatTu.uDisplayMember = "ItemName";
            this.cboVatTu.uEditValue = null;
            this.cboVatTu.uValueMember = "ItemNo";
            this.cboVatTu.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboVatTu_uQueryPopUp);
            // 
            // cboQuicach
            // 
            this.cboQuicach.Location = new System.Drawing.Point(412, 54);
            this.cboQuicach.Margin = new System.Windows.Forms.Padding(4);
            this.cboQuicach.Name = "cboQuicach";
            this.cboQuicach.sCaption = "Loại bao bì:";
            this.cboQuicach.sColumnCaption = "Loại bao bì";
            this.cboQuicach.sField = "PackageCode";
            this.cboQuicach.Size = new System.Drawing.Size(362, 21);
            this.cboQuicach.sNullText = "<Chọn>";
            this.cboQuicach.TabIndex = 65;
            this.cboQuicach.Tag = "..PackingUnitCode";
            this.cboQuicach.uDisplayMember = "PackageCode";
            this.cboQuicach.uEditValue = null;
            this.cboQuicach.uValueMember = "PackageCode";
            this.cboQuicach.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboQuicach_uQueryPopUp);
            // 
            // spnBag
            // 
            this.spnBag.Location = new System.Drawing.Point(818, 53);
            this.spnBag.Name = "spnBag";
            this.spnBag.sCaption = "Bag:";
            this.spnBag.Size = new System.Drawing.Size(254, 21);
            this.spnBag.TabIndex = 61;
            this.spnBag.Tag = "..Bag";
            this.spnBag.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnBag.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnBag.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnBag.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnBag.uText = "0";
            this.spnBag.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnBag.uValueChanged += new System.EventHandler(this.spnBag_uValueChanged);
            // 
            // cboLSX
            // 
            this.cboLSX.Location = new System.Drawing.Point(6, 82);
            this.cboLSX.Name = "cboLSX";
            this.cboLSX.sCaption = "Lệnh sản xuất:";
            this.cboLSX.sColumnCaption = "Lệnh sản xuất";
            this.cboLSX.sField = "BatchNo";
            this.cboLSX.Size = new System.Drawing.Size(340, 21);
            this.cboLSX.TabIndex = 63;
            this.cboLSX.Tag = "..BatchNo";
            this.cboLSX.uDisplayMember = "BatchNo";
            this.cboLSX.uEditValue = "";
            this.cboLSX.uValueMember = "BatchNo";
            this.cboLSX.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboLSX_uQueryPopUp);
            // 
            // spnShift
            // 
            this.spnShift.Location = new System.Drawing.Point(818, 83);
            this.spnShift.Name = "spnShift";
            this.spnShift.sCaption = "Shift:";
            this.spnShift.Size = new System.Drawing.Size(254, 21);
            this.spnShift.TabIndex = 62;
            this.spnShift.Tag = "..Shift";
            this.spnShift.uEditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnShift.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnShift.uMaxValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.spnShift.uMinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnShift.uText = "1";
            this.spnShift.uValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnShift.Visible = false;
            // 
            // griDanhSach
            // 
            this.griDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.griDanhSach.Location = new System.Drawing.Point(0, 188);
            this.griDanhSach.MainView = this.gridView;
            this.griDanhSach.Name = "griDanhSach";
            this.griDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.rptDel});
            this.griDanhSach.Size = new System.Drawing.Size(1433, 415);
            this.griDanhSach.TabIndex = 59;
            this.griDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.griDanhSach.Click += new System.EventHandler(this.griDanhSach_Click);
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.Row.Options.UseForeColor = true;
            this.gridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.Lot,
            this.gridColumn1,
            this.Date,
            this.Bag,
            this.CropYear,
            this.SanPham,
            this.gridColumn2,
            this.gridColumn3,
            this.Note,
            this.gridColumn4});
            this.gridView.GridControl = this.griDanhSach;
            this.gridView.IndicatorWidth = 50;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyUp);
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Xóa";
            this.gridColumn5.ColumnEdit = this.rptDel;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 38;
            // 
            // rptDel
            // 
            this.rptDel.AutoHeight = false;
            this.rptDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rptDel.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.rptDel.Name = "rptDel";
            this.rptDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.rptDel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.rptDel_ButtonClick);
            // 
            // Lot
            // 
            this.Lot.Caption = "Số lot";
            this.Lot.FieldName = "Lot";
            this.Lot.Name = "Lot";
            this.Lot.OptionsColumn.AllowEdit = false;
            this.Lot.Visible = true;
            this.Lot.VisibleIndex = 1;
            this.Lot.Width = 149;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Lệnh sản xuất";
            this.gridColumn1.FieldName = "BatchNo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 149;
            // 
            // Date
            // 
            this.Date.Caption = "Ngày";
            this.Date.ColumnEdit = this.repositoryItemDateEdit1;
            this.Date.FieldName = "Date";
            this.Date.Name = "Date";
            this.Date.OptionsColumn.AllowEdit = false;
            this.Date.Visible = true;
            this.Date.VisibleIndex = 3;
            this.Date.Width = 149;
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
            // Bag
            // 
            this.Bag.Caption = "Số bao";
            this.Bag.FieldName = "Bag";
            this.Bag.Name = "Bag";
            this.Bag.OptionsColumn.AllowEdit = false;
            this.Bag.Visible = true;
            this.Bag.VisibleIndex = 4;
            this.Bag.Width = 149;
            // 
            // CropYear
            // 
            this.CropYear.Caption = "Crop year";
            this.CropYear.FieldName = "CropYear";
            this.CropYear.Name = "CropYear";
            this.CropYear.OptionsColumn.AllowEdit = false;
            this.CropYear.Visible = true;
            this.CropYear.VisibleIndex = 5;
            this.CropYear.Width = 149;
            // 
            // SanPham
            // 
            this.SanPham.Caption = "Sản phẩm";
            this.SanPham.FieldName = "ItemCode";
            this.SanPham.Name = "SanPham";
            this.SanPham.OptionsColumn.AllowEdit = false;
            this.SanPham.Visible = true;
            this.SanPham.VisibleIndex = 6;
            this.SanPham.Width = 149;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Loại bao bì";
            this.gridColumn2.FieldName = "PackingUnitCode";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            this.gridColumn2.Width = 149;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Chứng nhận";
            this.gridColumn3.FieldName = "Cer";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 8;
            this.gridColumn3.Width = 149;
            // 
            // Note
            // 
            this.Note.Caption = "Ghi chú";
            this.Note.FieldName = "Note";
            this.Note.Name = "Note";
            this.Note.OptionsColumn.AllowEdit = false;
            this.Note.Visible = true;
            this.Note.VisibleIndex = 9;
            this.Note.Width = 151;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ID";
            this.gridColumn4.FieldName = "ID";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // frmCauHinhLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 603);
            this.Controls.Add(this.griDanhSach);
            this.Controls.Add(this.xtraTabControl3);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmCauHinhLot";
            this.Text = "CẤU HÌNH SỐ LOT";
            this.Load += new System.EventHandler(this.frmCauHinhLot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.xtraTabControl3.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.group)).EndInit();
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DELFI_User_Control.uDateTimePicker2 dtpNgayTao;
        private DevExpress.XtraTab.XtraTabPage pnMain;
        private DELFI_User_Control.uComboBox cboCropYear;
        private DELFI_User_Control.uTextBox txtGhiChu;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private DELFI_User_Control.uTextBox txtLot;
        private DELFI_User_Control.uComboBox cboVatTu;
        private DevExpress.XtraGrid.GridControl griDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn Lot;
        private DevExpress.XtraGrid.Columns.GridColumn CropYear;
        private DevExpress.XtraGrid.Columns.GridColumn SanPham;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn Note;
        private DELFI_User_Control.uSpinEdit spnBag;
        private DevExpress.XtraGrid.Columns.GridColumn Bag;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DELFI_User_Control.uComboBox cboLSX;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DELFI_User_Control.uComboBox cboQuicach;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DELFI_User_Control.uSpinEdit spnShift;
        private DevExpress.XtraEditors.LabelControl lbGioihanLot;
        private DELFI_User_Control.uComboBox cboCer;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DELFI_User_Control.uSpinEdit spnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rptDel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThemmoi;
        private DevExpress.XtraEditors.GroupControl group;
    }
}