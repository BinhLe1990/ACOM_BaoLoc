namespace DELFI_WHM.NET.QuanLy
{
    partial class frmLenhSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLenhSanXuat));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnDongBo = new DevExpress.XtraEditors.SimpleButton();
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dtpDenNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.dtpTuNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.txtBatch = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNote = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.cboLot = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.dtpNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.spnPallet = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.txtLSX = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.cboLocationCode = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.spnQTy = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.cboItemCode = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboVitri = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboQuiCach = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.griDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Del = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.postingdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.batchno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LocationCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BinCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PackingUnitCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LineNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDongBo
            // 
            this.btnDongBo.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnDongBo.Appearance.Options.UseForeColor = true;
            this.btnDongBo.Image = ((System.Drawing.Image)(resources.GetObject("btnDongBo.Image")));
            this.btnDongBo.ImageIndex = 9;
            this.btnDongBo.ImageList = this.IML;
            this.btnDongBo.Location = new System.Drawing.Point(643, 48);
            this.btnDongBo.Name = "btnDongBo";
            this.btnDongBo.Size = new System.Drawing.Size(169, 26);
            this.btnDongBo.TabIndex = 77;
            this.btnDongBo.Tag = "ADD";
            this.btnDongBo.Text = "Đồng bộ từ Navision về";
            this.btnDongBo.Click += new System.EventHandler(this.btnDongBo_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(435, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 26);
            this.btnSearch.TabIndex = 76;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageIndex = 0;
            this.simpleButton1.ImageList = this.IML;
            this.simpleButton1.Location = new System.Drawing.Point(539, 48);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(98, 26);
            this.simpleButton1.TabIndex = 78;
            this.simpleButton1.Text = "In danh sách";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.iWidth = 65;
            this.dtpDenNgay.Location = new System.Drawing.Point(244, 24);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDenNgay.MaskDateTime = "dd/MM/yyyy";
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.sCaption = "Đến ngày:";
            this.dtpDenNgay.sFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Size = new System.Drawing.Size(184, 21);
            this.dtpDenNgay.TabIndex = 50;
            this.dtpDenNgay.uDateTime = new System.DateTime(2020, 4, 7, 9, 22, 46, 31);
            this.dtpDenNgay.uValue = new System.DateTime(2020, 4, 7, 9, 22, 46, 31);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.iWidth = 90;
            this.dtpTuNgay.Location = new System.Drawing.Point(13, 24);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTuNgay.MaskDateTime = "dd/MM/yyyy";
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.sCaption = "Từ ngày:";
            this.dtpTuNgay.sFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Size = new System.Drawing.Size(212, 21);
            this.dtpTuNgay.TabIndex = 50;
            this.dtpTuNgay.uDateTime = new System.DateTime(2020, 4, 7, 9, 22, 46, 31);
            this.dtpTuNgay.uValue = new System.DateTime(2020, 4, 7, 9, 22, 46, 31);
            // 
            // txtBatch
            // 
            this.txtBatch.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtBatch.iWidth = 90;
            this.txtBatch.Location = new System.Drawing.Point(13, 53);
            this.txtBatch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.sCaption = "Batch No.:";
            this.txtBatch.SelectionStart = 0;
            this.txtBatch.Size = new System.Drawing.Size(415, 21);
            this.txtBatch.TabIndex = 0;
            this.txtBatch.Tag = "..MaNhaCungCap";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(1069, 184);
            this.xtraTabControl1.TabIndex = 80;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(this.panelControl1);
            this.xtraTabPage1.Controls.Add(this.groupBox1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1063, 178);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnImport);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 138);
            this.panelControl1.LookAndFeel.SkinName = "Office 2013";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1063, 40);
            this.panelControl1.TabIndex = 99;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageIndex = 9;
            this.btnLuu.ImageList = this.IML;
            this.btnLuu.Location = new System.Drawing.Point(11, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 26);
            this.btnLuu.TabIndex = 77;
            this.btnLuu.Tag = "ADD";
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.cboLot);
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(this.spnPallet);
            this.groupBox1.Controls.Add(this.txtLSX);
            this.groupBox1.Controls.Add(this.cboLocationCode);
            this.groupBox1.Controls.Add(this.spnQTy);
            this.groupBox1.Controls.Add(this.cboItemCode);
            this.groupBox1.Controls.Add(this.cboVitri);
            this.groupBox1.Controls.Add(this.cboQuiCach);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1063, 138);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết Lệnh sản xuất";
            // 
            // txtNote
            // 
            this.txtNote.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtNote.iMaxLength = 390;
            this.txtNote.Location = new System.Drawing.Point(7, 105);
            this.txtNote.Name = "txtNote";
            this.txtNote.sCaption = "Ghi chú:";
            this.txtNote.SelectionStart = 0;
            this.txtNote.Size = new System.Drawing.Size(853, 20);
            this.txtNote.TabIndex = 99;
            // 
            // cboLot
            // 
            this.cboLot.Location = new System.Drawing.Point(293, 21);
            this.cboLot.Margin = new System.Windows.Forms.Padding(4);
            this.cboLot.Name = "cboLot";
            this.cboLot.sCaption = "Số Lot:";
            this.cboLot.sColumnCaption = "Lot, Item";
            this.cboLot.sField = "Lot, ItemCode";
            this.cboLot.Size = new System.Drawing.Size(268, 21);
            this.cboLot.sNullText = "<Chọn>";
            this.cboLot.TabIndex = 98;
            this.cboLot.uDisplayMember = "Lot";
            this.cboLot.uEditValue = null;
            this.cboLot.uValueMember = "Lot";
            this.cboLot.uEditValueChanged += new System.EventHandler(this.cboLot_uEditValueChanged);
            this.cboLot.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboLot_uQueryPopUp);
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(7, 21);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgay.MaskDateTime = "dd/MM/yyyy";
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.sCaption = "Ngày:";
            this.dtpNgay.sFormat = "dd/MM/yyyy";
            this.dtpNgay.Size = new System.Drawing.Size(262, 21);
            this.dtpNgay.TabIndex = 50;
            this.dtpNgay.uDateTime = new System.DateTime(2020, 4, 7, 9, 22, 46, 31);
            this.dtpNgay.uValue = new System.DateTime(2020, 4, 7, 9, 22, 46, 31);
            // 
            // spnPallet
            // 
            this.spnPallet.Location = new System.Drawing.Point(592, 77);
            this.spnPallet.Name = "spnPallet";
            this.spnPallet.sCaption = "Số lượng Pallet:";
            this.spnPallet.Size = new System.Drawing.Size(268, 21);
            this.spnPallet.TabIndex = 97;
            this.spnPallet.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPallet.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnPallet.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPallet.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPallet.uText = "0";
            this.spnPallet.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // txtLSX
            // 
            this.txtLSX.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtLSX.Location = new System.Drawing.Point(7, 48);
            this.txtLSX.Name = "txtLSX";
            this.txtLSX.sCaption = "Lệnh sản xuất (*):";
            this.txtLSX.SelectionStart = 0;
            this.txtLSX.Size = new System.Drawing.Size(262, 20);
            this.txtLSX.TabIndex = 78;
            // 
            // cboLocationCode
            // 
            this.cboLocationCode.Location = new System.Drawing.Point(7, 77);
            this.cboLocationCode.Margin = new System.Windows.Forms.Padding(4);
            this.cboLocationCode.Name = "cboLocationCode";
            this.cboLocationCode.sCaption = "Khu vực:";
            this.cboLocationCode.sColumnCaption = "Mã khu vực, Tên khu vực";
            this.cboLocationCode.sField = "Code, LocationName";
            this.cboLocationCode.Size = new System.Drawing.Size(262, 21);
            this.cboLocationCode.sNullText = "<Chọn khu vực>";
            this.cboLocationCode.TabIndex = 80;
            this.cboLocationCode.uDisplayMember = "Code";
            this.cboLocationCode.uEditValue = null;
            this.cboLocationCode.uValueMember = "Code";
            this.cboLocationCode.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboLocationCode_uQueryPopUp);
            // 
            // spnQTy
            // 
            this.spnQTy.Location = new System.Drawing.Point(592, 48);
            this.spnQTy.Name = "spnQTy";
            this.spnQTy.sCaption = "TL Yêu cầu:";
            this.spnQTy.Size = new System.Drawing.Size(268, 21);
            this.spnQTy.TabIndex = 83;
            this.spnQTy.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnQTy.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnQTy.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnQTy.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnQTy.uText = "0";
            this.spnQTy.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // cboItemCode
            // 
            this.cboItemCode.Location = new System.Drawing.Point(293, 48);
            this.cboItemCode.Margin = new System.Windows.Forms.Padding(4);
            this.cboItemCode.Name = "cboItemCode";
            this.cboItemCode.sCaption = "Sản phẩm (*)";
            this.cboItemCode.sColumnCaption = "Mã sản phẩm, Tên sản phẩm";
            this.cboItemCode.sField = "ItemNo, ItemName";
            this.cboItemCode.Size = new System.Drawing.Size(268, 21);
            this.cboItemCode.sNullText = "<Chọn sản phẩm>";
            this.cboItemCode.TabIndex = 79;
            this.cboItemCode.uDisplayMember = "ItemNo";
            this.cboItemCode.uEditValue = null;
            this.cboItemCode.uValueMember = "ItemNo";
            this.cboItemCode.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboItemCode_uQueryPopUp);
            // 
            // cboVitri
            // 
            this.cboVitri.Location = new System.Drawing.Point(592, 21);
            this.cboVitri.Margin = new System.Windows.Forms.Padding(4);
            this.cboVitri.Name = "cboVitri";
            this.cboVitri.sCaption = "Cây hàng:";
            this.cboVitri.sColumnCaption = "Cây hàng";
            this.cboVitri.sField = "BinCode";
            this.cboVitri.Size = new System.Drawing.Size(268, 21);
            this.cboVitri.sNullText = "<Chọn>";
            this.cboVitri.TabIndex = 81;
            this.cboVitri.uDisplayMember = "BinCode";
            this.cboVitri.uEditValue = null;
            this.cboVitri.uValueMember = "BinCode";
            this.cboVitri.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboVitri_uQueryPopUp);
            // 
            // cboQuiCach
            // 
            this.cboQuiCach.Location = new System.Drawing.Point(293, 77);
            this.cboQuiCach.Margin = new System.Windows.Forms.Padding(4);
            this.cboQuiCach.Name = "cboQuiCach";
            this.cboQuiCach.sCaption = "Loại bao bì:";
            this.cboQuiCach.sColumnCaption = "Loại bao bì";
            this.cboQuiCach.sField = "PackageCode";
            this.cboQuiCach.Size = new System.Drawing.Size(268, 21);
            this.cboQuiCach.sNullText = "<Chọn>";
            this.cboQuiCach.TabIndex = 82;
            this.cboQuiCach.uDisplayMember = "PackageCode";
            this.cboQuiCach.uEditValue = null;
            this.cboQuiCach.uValueMember = "PackageCode";
            this.cboQuiCach.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboQuiCach_uQueryPopUp);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.groupControl1.Appearance.Options.UseForeColor = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.dtpTuNgay);
            this.groupControl1.Controls.Add(this.dtpDenNgay);
            this.groupControl1.Controls.Add(this.txtBatch);
            this.groupControl1.Controls.Add(this.btnDongBo);
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 184);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1069, 88);
            this.groupControl1.TabIndex = 81;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // griDanhSach
            // 
            this.griDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.griDanhSach.Location = new System.Drawing.Point(0, 272);
            this.griDanhSach.MainView = this.gridView1;
            this.griDanhSach.Name = "griDanhSach";
            this.griDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.rptDel});
            this.griDanhSach.Size = new System.Drawing.Size(1069, 331);
            this.griDanhSach.TabIndex = 82;
            this.griDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Del,
            this.postingdate,
            this.batchno,
            this.SanPham,
            this.LocationCode,
            this.gridColumn2,
            this.BinCode,
            this.gridColumn1,
            this.Quantity,
            this.PackingUnitCode,
            this.LineNo,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.griDanhSach;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyUp);
            // 
            // col_Del
            // 
            this.col_Del.Caption = "Xóa";
            this.col_Del.ColumnEdit = this.rptDel;
            this.col_Del.FieldName = "Del";
            this.col_Del.Name = "col_Del";
            this.col_Del.Visible = true;
            this.col_Del.VisibleIndex = 0;
            this.col_Del.Width = 44;
            // 
            // rptDel
            // 
            this.rptDel.AutoHeight = false;
            this.rptDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rptDel.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.rptDel.Name = "rptDel";
            this.rptDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.rptDel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.rptDel_ButtonClick);
            // 
            // postingdate
            // 
            this.postingdate.Caption = "Ngày";
            this.postingdate.ColumnEdit = this.repositoryItemDateEdit1;
            this.postingdate.FieldName = "PostingDate";
            this.postingdate.Name = "postingdate";
            this.postingdate.Visible = true;
            this.postingdate.VisibleIndex = 1;
            this.postingdate.Width = 87;
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
            // batchno
            // 
            this.batchno.Caption = "Lệnh sản xuất";
            this.batchno.FieldName = "BatchNo";
            this.batchno.Name = "batchno";
            this.batchno.Visible = true;
            this.batchno.VisibleIndex = 2;
            this.batchno.Width = 87;
            // 
            // SanPham
            // 
            this.SanPham.Caption = "Sản phẩm";
            this.SanPham.FieldName = "ItemNo";
            this.SanPham.Name = "SanPham";
            this.SanPham.Visible = true;
            this.SanPham.VisibleIndex = 3;
            this.SanPham.Width = 87;
            // 
            // LocationCode
            // 
            this.LocationCode.Caption = "Location code";
            this.LocationCode.FieldName = "LocationCode";
            this.LocationCode.Name = "LocationCode";
            this.LocationCode.Visible = true;
            this.LocationCode.VisibleIndex = 4;
            this.LocationCode.Width = 87;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Lot";
            this.gridColumn2.FieldName = "Lot";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 87;
            // 
            // BinCode
            // 
            this.BinCode.Caption = "Cây hàng";
            this.BinCode.FieldName = "BinCode";
            this.BinCode.Name = "BinCode";
            this.BinCode.Visible = true;
            this.BinCode.VisibleIndex = 6;
            this.BinCode.Width = 87;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Số lượng Pallet";
            this.gridColumn1.DisplayFormat.FormatString = "N0";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "PalletQty";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 87;
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Trọng lượng";
            this.Quantity.DisplayFormat.FormatString = "N0";
            this.Quantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Quantity.FieldName = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 8;
            this.Quantity.Width = 87;
            // 
            // PackingUnitCode
            // 
            this.PackingUnitCode.Caption = "Loại bao bì";
            this.PackingUnitCode.FieldName = "PackingUnitCode";
            this.PackingUnitCode.Name = "PackingUnitCode";
            this.PackingUnitCode.Visible = true;
            this.PackingUnitCode.VisibleIndex = 9;
            this.PackingUnitCode.Width = 87;
            // 
            // LineNo
            // 
            this.LineNo.Caption = "LineNo";
            this.LineNo.FieldName = "LineNo";
            this.LineNo.Name = "LineNo";
            this.LineNo.Visible = true;
            this.LineNo.VisibleIndex = 10;
            this.LineNo.Width = 87;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ghi chú";
            this.gridColumn3.FieldName = "Note";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 11;
            this.gridColumn3.Width = 103;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ID";
            this.gridColumn4.FieldName = "ID";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // btnImport
            // 
            this.btnImport.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Appearance.Options.UseForeColor = true;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageIndex = 9;
            this.btnImport.ImageList = this.IML;
            this.btnImport.Location = new System.Drawing.Point(117, 6);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 26);
            this.btnImport.TabIndex = 78;
            this.btnImport.Tag = "";
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // frmLenhSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 603);
            this.Controls.Add(this.griDanhSach);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.xtraTabControl1);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmLenhSanXuat";
            this.Text = "LỆNH SẢN XUẤT";
            this.Load += new System.EventHandler(this.frmLenhSanXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnDongBo;
        private System.Windows.Forms.ImageList IML;
        private DELFI_User_Control.uDateTimePicker2 dtpDenNgay;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DELFI_User_Control.uDateTimePicker2 dtpTuNgay;
        private DELFI_User_Control.uTextBox txtBatch;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DELFI_User_Control.uDateTimePicker2 dtpNgay;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl griDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn postingdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn batchno;
        private DevExpress.XtraGrid.Columns.GridColumn SanPham;
        private DevExpress.XtraGrid.Columns.GridColumn LocationCode;
        private DevExpress.XtraGrid.Columns.GridColumn BinCode;
        private DevExpress.XtraGrid.Columns.GridColumn PackingUnitCode;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn LineNo;
        private DELFI_User_Control.uTextBox txtLSX;
        private DELFI_User_Control.uComboBox cboItemCode;
        private DELFI_User_Control.uComboBox cboLocationCode;
        private DELFI_User_Control.uComboBox cboVitri;
        private DELFI_User_Control.uComboBox cboQuiCach;
        private DELFI_User_Control.uSpinEdit spnQTy;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DELFI_User_Control.uSpinEdit spnPallet;
        private System.Windows.Forms.GroupBox groupBox1;
        private DELFI_User_Control.uComboBox cboLot;
        private DELFI_User_Control.uTextBox txtNote;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn col_Del;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rptDel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnImport;
    }
}