namespace DELFI_WHM.NET.XuatKho
{
    partial class frmTachPhieuXuatKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTachPhieuXuatKho));
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnInTem = new DevExpress.XtraEditors.SimpleButton();
            this.dtpNgaytao = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.cboSanPham = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboCer = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.txtCrop = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.spnTruckQty = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.cboLot = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboVitri = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboLoai = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.spnTLTrubi = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.txtGhichu = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtMaPallet = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.spnTLCan = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.cboQuicach = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTachSX = new DevExpress.XtraEditors.SimpleButton();
            this.griDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QRCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            // btnInTem
            // 
            this.btnInTem.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnInTem.Appearance.Options.UseForeColor = true;
            this.btnInTem.Image = ((System.Drawing.Image)(resources.GetObject("btnInTem.Image")));
            this.btnInTem.ImageIndex = 8;
            this.btnInTem.ImageList = this.IML;
            this.btnInTem.Location = new System.Drawing.Point(271, 162);
            this.btnInTem.Name = "btnInTem";
            this.btnInTem.Size = new System.Drawing.Size(100, 26);
            this.btnInTem.TabIndex = 84;
            this.btnInTem.Text = "In tem";
            this.btnInTem.Click += new System.EventHandler(this.btnInTem_Click);
            // 
            // dtpNgaytao
            // 
            this.dtpNgaytao.bIsReadOnly = true;
            this.dtpNgaytao.iWidth = 150;
            this.dtpNgaytao.Location = new System.Drawing.Point(707, 79);
            this.dtpNgaytao.MaskDateTime = "dd/MM/yyyy";
            this.dtpNgaytao.Name = "dtpNgaytao";
            this.dtpNgaytao.sCaption = "Ngày tách:";
            this.dtpNgaytao.sFormat = "dd/MM/yyyy";
            this.dtpNgaytao.Size = new System.Drawing.Size(298, 21);
            this.dtpNgaytao.TabIndex = 100;
            this.dtpNgaytao.TabStop = false;
            this.dtpNgaytao.uDateTime = new System.DateTime(2020, 4, 20, 17, 7, 0, 0);
            this.dtpNgaytao.uValue = new System.DateTime(2020, 4, 20, 17, 7, 0, 0);
            this.dtpNgaytao.Visible = false;
            // 
            // cboSanPham
            // 
            this.cboSanPham.Location = new System.Drawing.Point(5, 52);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.sCaption = "Sản phẩm:";
            this.cboSanPham.sField = "ItemNo, ItemName";
            this.cboSanPham.Size = new System.Drawing.Size(332, 21);
            this.cboSanPham.TabIndex = 90;
            this.cboSanPham.TabStop = false;
            this.cboSanPham.uDisplayMember = "ItemNo";
            this.cboSanPham.uEditValue = null;
            this.cboSanPham.uValueMember = "ItemNo";
            this.cboSanPham.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboSanPham_uQueryPopUp);
            // 
            // cboCer
            // 
            this.cboCer.Location = new System.Drawing.Point(369, 106);
            this.cboCer.Name = "cboCer";
            this.cboCer.sCaption = "Certificate:";
            this.cboCer.sColumnCaption = "Certificate";
            this.cboCer.sField = "Ten";
            this.cboCer.Size = new System.Drawing.Size(332, 21);
            this.cboCer.TabIndex = 97;
            this.cboCer.TabStop = false;
            this.cboCer.uDisplayMember = "Ten";
            this.cboCer.uEditValue = null;
            this.cboCer.uValueMember = "Ten";
            this.cboCer.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboCer_uQueryPopUp);
            // 
            // txtCrop
            // 
            this.txtCrop.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtCrop.bIsReadOnly = true;
            this.txtCrop.iWidth = 150;
            this.txtCrop.Location = new System.Drawing.Point(707, 25);
            this.txtCrop.Name = "txtCrop";
            this.txtCrop.sCaption = "Crop Year:";
            this.txtCrop.SelectionStart = 0;
            this.txtCrop.Size = new System.Drawing.Size(298, 21);
            this.txtCrop.TabIndex = 96;
            this.txtCrop.TabStop = false;
            this.txtCrop.Visible = false;
            // 
            // spnTruckQty
            // 
            this.spnTruckQty.Location = new System.Drawing.Point(5, 135);
            this.spnTruckQty.Name = "spnTruckQty";
            this.spnTruckQty.sCaption = "Số lượng bao:";
            this.spnTruckQty.Size = new System.Drawing.Size(332, 21);
            this.spnTruckQty.TabIndex = 4;
            this.spnTruckQty.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTruckQty.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnTruckQty.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTruckQty.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTruckQty.uText = "0";
            this.spnTruckQty.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTruckQty.uValueChanged += new System.EventHandler(this.spnTruckQty_uValueChanged);
            // 
            // cboLot
            // 
            this.cboLot.Location = new System.Drawing.Point(369, 79);
            this.cboLot.Name = "cboLot";
            this.cboLot.sCaption = "Lot:";
            this.cboLot.sColumnCaption = "Lot, Bag, CropYear";
            this.cboLot.sField = "Lot, Bag, CropYear";
            this.cboLot.Size = new System.Drawing.Size(332, 21);
            this.cboLot.TabIndex = 94;
            this.cboLot.TabStop = false;
            this.cboLot.uDisplayMember = "Lot";
            this.cboLot.uEditValue = null;
            this.cboLot.uValueMember = "Lot";
            this.cboLot.uEditValueChanged += new System.EventHandler(this.cboLot_uEditValueChanged);
            this.cboLot.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboLot_uQueryPopUp);
            // 
            // cboVitri
            // 
            this.cboVitri.Location = new System.Drawing.Point(369, 52);
            this.cboVitri.Name = "cboVitri";
            this.cboVitri.sCaption = "Cây hàng:";
            this.cboVitri.sColumnCaption = "Cây hàng";
            this.cboVitri.sField = "BinCode";
            this.cboVitri.Size = new System.Drawing.Size(332, 21);
            this.cboVitri.TabIndex = 2;
            this.cboVitri.uDisplayMember = "BinCode";
            this.cboVitri.uEditValue = null;
            this.cboVitri.uValueMember = "BinCode";
            this.cboVitri.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboVitri_uQueryPopUp);
            // 
            // cboLoai
            // 
            this.cboLoai.iWidth = 150;
            this.cboLoai.Location = new System.Drawing.Point(707, 52);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.sCaption = "Loại:";
            this.cboLoai.sColumnCaption = "Loại";
            this.cboLoai.sField = "Loai";
            this.cboLoai.Size = new System.Drawing.Size(298, 21);
            this.cboLoai.TabIndex = 92;
            this.cboLoai.TabStop = false;
            this.cboLoai.uDisplayMember = "Loai";
            this.cboLoai.uEditValue = null;
            this.cboLoai.uValueMember = "Loai";
            this.cboLoai.Visible = false;
            // 
            // spnTLTrubi
            // 
            this.spnTLTrubi.Location = new System.Drawing.Point(5, 106);
            this.spnTLTrubi.Name = "spnTLTrubi";
            this.spnTLTrubi.sCaption = "Tổng TL trừ bì:";
            this.spnTLTrubi.Size = new System.Drawing.Size(332, 21);
            this.spnTLTrubi.TabIndex = 6;
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
            this.spnTLTrubi.uText = "0";
            this.spnTLTrubi.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTLTrubi.uEditValueChanged += new System.EventHandler(this.spnTLTrubi_uEditValueChanged);
            // 
            // txtGhichu
            // 
            this.txtGhichu.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtGhichu.Location = new System.Drawing.Point(369, 135);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.sCaption = "Ghi chú:";
            this.txtGhichu.SelectionStart = 0;
            this.txtGhichu.Size = new System.Drawing.Size(332, 23);
            this.txtGhichu.TabIndex = 7;
            // 
            // txtMaPallet
            // 
            this.txtMaPallet.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtMaPallet.Location = new System.Drawing.Point(5, 25);
            this.txtMaPallet.Name = "txtMaPallet";
            this.txtMaPallet.sCaption = "Quét mã pallet:";
            this.txtMaPallet.SelectionStart = 0;
            this.txtMaPallet.Size = new System.Drawing.Size(332, 21);
            this.txtMaPallet.TabIndex = 0;
            this.txtMaPallet.uKeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaPallet_uKeyUp);
            // 
            // spnTLCan
            // 
            this.spnTLCan.bIsReadOnly = true;
            this.spnTLCan.Location = new System.Drawing.Point(5, 79);
            this.spnTLCan.Name = "spnTLCan";
            this.spnTLCan.sCaption = "Trọng lượng dư:";
            this.spnTLCan.Size = new System.Drawing.Size(332, 21);
            this.spnTLCan.TabIndex = 89;
            this.spnTLCan.TabStop = false;
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
            // cboQuicach
            // 
            this.cboQuicach.Location = new System.Drawing.Point(369, 25);
            this.cboQuicach.Name = "cboQuicach";
            this.cboQuicach.sCaption = "Loại bao bì:";
            this.cboQuicach.sColumnCaption = "Loại bao bì";
            this.cboQuicach.sField = "PackageCode";
            this.cboQuicach.Size = new System.Drawing.Size(332, 21);
            this.cboQuicach.TabIndex = 1;
            this.cboQuicach.uDisplayMember = "PackageCode";
            this.cboQuicach.uEditValue = null;
            this.cboQuicach.uValueMember = "PackageCode";
            this.cboQuicach.uEditValueChanged += new System.EventHandler(this.cboQuicach_uEditValueChanged);
            this.cboQuicach.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboQuicach_uQueryPopUp);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Appearance.Options.UseForeColor = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageIndex = 5;
            this.btnHuy.ImageList = this.IML;
            this.btnHuy.Location = new System.Drawing.Point(377, 162);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 26);
            this.btnHuy.TabIndex = 85;
            this.btnHuy.Tag = "ADD";
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageIndex = 3;
            this.btnLuu.ImageList = this.IML;
            this.btnLuu.Location = new System.Drawing.Point(5, 162);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(127, 26);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Tag = "ADD";
            this.btnLuu.Text = "Tách xuất Cân cầu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.btnTachSX);
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.dtpNgaytao);
            this.groupControl1.Controls.Add(this.btnInTem);
            this.groupControl1.Controls.Add(this.txtMaPallet);
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Controls.Add(this.txtCrop);
            this.groupControl1.Controls.Add(this.cboLoai);
            this.groupControl1.Controls.Add(this.cboQuicach);
            this.groupControl1.Controls.Add(this.cboSanPham);
            this.groupControl1.Controls.Add(this.spnTLCan);
            this.groupControl1.Controls.Add(this.cboCer);
            this.groupControl1.Controls.Add(this.txtGhichu);
            this.groupControl1.Controls.Add(this.spnTLTrubi);
            this.groupControl1.Controls.Add(this.spnTruckQty);
            this.groupControl1.Controls.Add(this.cboVitri);
            this.groupControl1.Controls.Add(this.cboLot);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1398, 205);
            this.groupControl1.TabIndex = 101;
            this.groupControl1.Text = "Khai báo thông tin";
            // 
            // btnTachSX
            // 
            this.btnTachSX.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnTachSX.Appearance.Options.UseForeColor = true;
            this.btnTachSX.Image = ((System.Drawing.Image)(resources.GetObject("btnTachSX.Image")));
            this.btnTachSX.ImageIndex = 3;
            this.btnTachSX.ImageList = this.IML;
            this.btnTachSX.Location = new System.Drawing.Point(138, 162);
            this.btnTachSX.Name = "btnTachSX";
            this.btnTachSX.Size = new System.Drawing.Size(127, 26);
            this.btnTachSX.TabIndex = 101;
            this.btnTachSX.Tag = "ADD";
            this.btnTachSX.Text = "Tách xuất Sản xuất";
            this.btnTachSX.Click += new System.EventHandler(this.btnTachSX_Click);
            // 
            // griDanhSach
            // 
            this.griDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.griDanhSach.Location = new System.Drawing.Point(0, 205);
            this.griDanhSach.MainView = this.gridView1;
            this.griDanhSach.Name = "griDanhSach";
            this.griDanhSach.Size = new System.Drawing.Size(1398, 398);
            this.griDanhSach.TabIndex = 102;
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
            this.gridColumn15,
            this.gridColumn14,
            this.QRCode,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn10,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn4,
            this.gridColumn7,
            this.gridColumn11});
            this.gridView1.GridControl = this.griDanhSach;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyUp);
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Chọn";
            this.gridColumn15.FieldName = "Chon";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 0;
            this.gridColumn15.Width = 50;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Mã QRCode cũ";
            this.gridColumn14.FieldName = "Document";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 1;
            this.gridColumn14.Width = 140;
            // 
            // QRCode
            // 
            this.QRCode.Caption = "Mã QRCode mới";
            this.QRCode.FieldName = "QRCode";
            this.QRCode.Name = "QRCode";
            this.QRCode.Visible = true;
            this.QRCode.VisibleIndex = 2;
            this.QRCode.Width = 140;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Sản phẩm";
            this.gridColumn1.FieldName = "ItemNo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 91;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Lot";
            this.gridColumn2.FieldName = "Lot";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 91;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Cây hàng";
            this.gridColumn10.FieldName = "BinCode";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            this.gridColumn10.Width = 91;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Chứng nhận";
            this.gridColumn3.FieldName = "Certificate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            this.gridColumn3.Width = 91;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Loại bao bì";
            this.gridColumn5.FieldName = "PackageCode";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 7;
            this.gridColumn5.Width = 91;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Trọng lượng";
            this.gridColumn4.DisplayFormat.FormatString = "N0";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "QRCodeQty";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 8;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Số bao";
            this.gridColumn7.DisplayFormat.FormatString = "N0";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "TruckQty";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 9;
            this.gridColumn7.Width = 91;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Ghi chú";
            this.gridColumn11.FieldName = "Note";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 10;
            this.gridColumn11.Width = 106;
            // 
            // frmTachPhieuXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 603);
            this.Controls.Add(this.griDanhSach);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmTachPhieuXuatKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÁCH PHIẾU CÂN DƯ";
            this.Load += new System.EventHandler(this.frmTachPhieuXuatKho_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmTachPhieuXuatKho_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraEditors.SimpleButton btnInTem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DELFI_User_Control.uTextBox txtGhichu;
        private DELFI_User_Control.uComboBox cboSanPham;
        private DELFI_User_Control.uSpinEdit spnTLCan;
        private DELFI_User_Control.uTextBox txtMaPallet;
        private DELFI_User_Control.uSpinEdit spnTruckQty;
        private DELFI_User_Control.uComboBox cboCer;
        private DELFI_User_Control.uTextBox txtCrop;
        private DELFI_User_Control.uComboBox cboLot;
        private DELFI_User_Control.uComboBox cboQuicach;
        private DELFI_User_Control.uComboBox cboLoai;
        private DELFI_User_Control.uDateTimePicker2 dtpNgaytao;
        private DELFI_User_Control.uComboBox cboVitri;
        private DELFI_User_Control.uSpinEdit spnTLTrubi;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl griDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn QRCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.SimpleButton btnTachSX;
    }
}