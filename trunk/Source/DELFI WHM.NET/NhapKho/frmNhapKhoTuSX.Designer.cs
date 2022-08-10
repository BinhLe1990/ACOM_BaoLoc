namespace DELFI_WHM.NET.NhapKho
{
    partial class frmNhapKhoTuSX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapKhoTuSX));
            this.btnThemmoi = new DevExpress.XtraEditors.SimpleButton();
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnInTem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.spnTLTrubi = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.txtQRCode = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtWeightNote = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.cboVitri = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboQuicach = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboLot = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.spnSoBao = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.cboCer = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.txtCropYear = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.spnTrongluong = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.cboLSX = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.chbHangmau = new System.Windows.Forms.CheckBox();
            this.dtpNgayTao = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.txtGhichu = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.cboMaSanPham = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboLoai = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.griDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.QRCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NetWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnThemmoi.Appearance.Options.UseForeColor = true;
            this.btnThemmoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemmoi.Image")));
            this.btnThemmoi.ImageIndex = 8;
            this.btnThemmoi.ImageList = this.IML;
            this.btnThemmoi.Location = new System.Drawing.Point(306, 5);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(103, 26);
            this.btnThemmoi.TabIndex = 108;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.Visible = false;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnInTem.Location = new System.Drawing.Point(18, 5);
            this.btnInTem.Name = "btnInTem";
            this.btnInTem.Size = new System.Drawing.Size(90, 26);
            this.btnInTem.TabIndex = 95;
            this.btnInTem.TabStop = false;
            this.btnInTem.Text = "In tem";
            this.btnInTem.Click += new System.EventHandler(this.btnInTem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageIndex = 6;
            this.btnLuu.ImageList = this.IML;
            this.btnLuu.Location = new System.Drawing.Point(114, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 26);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Tag = "ADD";
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Appearance.Options.UseForeColor = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageIndex = 5;
            this.btnHuy.ImageList = this.IML;
            this.btnHuy.Location = new System.Drawing.Point(210, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 26);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.TabStop = false;
            this.btnHuy.Tag = "ADD";
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // spnTLTrubi
            // 
            this.spnTLTrubi.iWidth = 105;
            this.spnTLTrubi.Location = new System.Drawing.Point(741, 81);
            this.spnTLTrubi.Name = "spnTLTrubi";
            this.spnTLTrubi.sCaption = "Tổng TL trừ bì:";
            this.spnTLTrubi.Size = new System.Drawing.Size(298, 21);
            this.spnTLTrubi.TabIndex = 116;
            this.spnTLTrubi.TabStop = false;
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
            this.spnTLTrubi.uValueChanged += new System.EventHandler(this.spnTLTrubi_uValueChanged);
            // 
            // txtQRCode
            // 
            this.txtQRCode.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtQRCode.bIsReadOnly = true;
            this.txtQRCode.Location = new System.Drawing.Point(1123, 83);
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.sCaption = "QRCode:";
            this.txtQRCode.SelectionStart = 0;
            this.txtQRCode.Size = new System.Drawing.Size(320, 20);
            this.txtQRCode.TabIndex = 115;
            this.txtQRCode.TabStop = false;
            this.txtQRCode.Visible = false;
            // 
            // txtWeightNote
            // 
            this.txtWeightNote.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtWeightNote.Location = new System.Drawing.Point(1123, 55);
            this.txtWeightNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeightNote.Name = "txtWeightNote";
            this.txtWeightNote.sCaption = "WeightNote";
            this.txtWeightNote.SelectionStart = 0;
            this.txtWeightNote.Size = new System.Drawing.Size(320, 21);
            this.txtWeightNote.TabIndex = 112;
            this.txtWeightNote.Tag = "..MaNhaCungCap";
            this.txtWeightNote.Visible = false;
            // 
            // cboVitri
            // 
            this.cboVitri.Location = new System.Drawing.Point(370, 52);
            this.cboVitri.Margin = new System.Windows.Forms.Padding(4);
            this.cboVitri.Name = "cboVitri";
            this.cboVitri.sCaption = "Cây hàng:";
            this.cboVitri.sColumnCaption = "Cây hàng";
            this.cboVitri.sField = "BinCode";
            this.cboVitri.Size = new System.Drawing.Size(343, 21);
            this.cboVitri.sNullText = "<Chọn>";
            this.cboVitri.TabIndex = 6;
            this.cboVitri.uDisplayMember = "BinCode";
            this.cboVitri.uEditValue = null;
            this.cboVitri.uValueMember = "BinCode";
            this.cboVitri.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboVitri_uQueryPopUp);
            // 
            // cboQuicach
            // 
            this.cboQuicach.Location = new System.Drawing.Point(370, 25);
            this.cboQuicach.Margin = new System.Windows.Forms.Padding(4);
            this.cboQuicach.Name = "cboQuicach";
            this.cboQuicach.sCaption = "Loại bao bì (*):";
            this.cboQuicach.sColumnCaption = "Loại bao bì";
            this.cboQuicach.sField = "PackageCode";
            this.cboQuicach.Size = new System.Drawing.Size(343, 21);
            this.cboQuicach.sNullText = "<Chọn>";
            this.cboQuicach.TabIndex = 4;
            this.cboQuicach.uDisplayMember = "PackageCode";
            this.cboQuicach.uEditValue = null;
            this.cboQuicach.uValueMember = "PackageCode";
            this.cboQuicach.uEditValueChanged += new System.EventHandler(this.cboQuicach_uEditValueChanged);
            this.cboQuicach.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboQuicach_uQueryPopUp);
            // 
            // cboLot
            // 
            this.cboLot.Location = new System.Drawing.Point(18, 25);
            this.cboLot.Margin = new System.Windows.Forms.Padding(4);
            this.cboLot.Name = "cboLot";
            this.cboLot.sCaption = "Số Lot (*):";
            this.cboLot.sColumnCaption = "Lot, Item";
            this.cboLot.sField = "Lot, ItemCode";
            this.cboLot.Size = new System.Drawing.Size(343, 21);
            this.cboLot.sNullText = "<Chọn>";
            this.cboLot.TabIndex = 5;
            this.cboLot.uDisplayMember = "Lot";
            this.cboLot.uEditValue = null;
            this.cboLot.uValueMember = "Lot";
            this.cboLot.uEditValueChanged += new System.EventHandler(this.cboLot_uEditValueChanged);
            this.cboLot.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboLot_uQueryPopUp);
            // 
            // spnSoBao
            // 
            this.spnSoBao.iWidth = 105;
            this.spnSoBao.Location = new System.Drawing.Point(741, 110);
            this.spnSoBao.Name = "spnSoBao";
            this.spnSoBao.sCaption = "Số bao của QRCode:";
            this.spnSoBao.Size = new System.Drawing.Size(298, 21);
            this.spnSoBao.TabIndex = 108;
            this.spnSoBao.TabStop = false;
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
            this.spnSoBao.uValueChanged += new System.EventHandler(this.spnSoBao_uValueChanged);
            // 
            // cboCer
            // 
            this.cboCer.Location = new System.Drawing.Point(370, 81);
            this.cboCer.Margin = new System.Windows.Forms.Padding(4);
            this.cboCer.Name = "cboCer";
            this.cboCer.sCaption = "Certificate:";
            this.cboCer.sColumnCaption = "Certificate";
            this.cboCer.sField = "Ten";
            this.cboCer.Size = new System.Drawing.Size(343, 21);
            this.cboCer.sNullText = "<Chọn>";
            this.cboCer.TabIndex = 3;
            this.cboCer.uDisplayMember = "Ten";
            this.cboCer.uEditValue = null;
            this.cboCer.uValueMember = "Ten";
            this.cboCer.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboCer_uQueryPopUp);
            // 
            // txtCropYear
            // 
            this.txtCropYear.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtCropYear.bIsReadOnly = true;
            this.txtCropYear.Location = new System.Drawing.Point(1123, 24);
            this.txtCropYear.Name = "txtCropYear";
            this.txtCropYear.sCaption = "Crop Year:";
            this.txtCropYear.SelectionStart = 0;
            this.txtCropYear.Size = new System.Drawing.Size(320, 20);
            this.txtCropYear.TabIndex = 109;
            this.txtCropYear.TabStop = false;
            this.txtCropYear.Visible = false;
            // 
            // spnTrongluong
            // 
            this.spnTrongluong.bIsReadOnly = true;
            this.spnTrongluong.iWidth = 105;
            this.spnTrongluong.Location = new System.Drawing.Point(741, 52);
            this.spnTrongluong.Name = "spnTrongluong";
            this.spnTrongluong.sCaption = "Trọng lượng cân:";
            this.spnTrongluong.Size = new System.Drawing.Size(298, 21);
            this.spnTrongluong.TabIndex = 106;
            this.spnTrongluong.TabStop = false;
            this.spnTrongluong.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTrongluong.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnTrongluong.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTrongluong.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTrongluong.uText = "0";
            this.spnTrongluong.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // cboLSX
            // 
            this.cboLSX.Location = new System.Drawing.Point(18, 52);
            this.cboLSX.Name = "cboLSX";
            this.cboLSX.sCaption = "Lệnh sản xuất (*):";
            this.cboLSX.sColumnCaption = "Ngày, Lệnh sản xuất, Ghi chú";
            this.cboLSX.sField = "PostingDate, BatchNo, Note";
            this.cboLSX.Size = new System.Drawing.Size(343, 21);
            this.cboLSX.TabIndex = 0;
            this.cboLSX.uDisplayMember = "BatchNo";
            this.cboLSX.uEditValue = "";
            this.cboLSX.uValueMember = "BatchNo";
            this.cboLSX.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboLSX_uQueryPopUp);
            // 
            // chbHangmau
            // 
            this.chbHangmau.AutoSize = true;
            this.chbHangmau.Location = new System.Drawing.Point(1044, 25);
            this.chbHangmau.Margin = new System.Windows.Forms.Padding(2);
            this.chbHangmau.Name = "chbHangmau";
            this.chbHangmau.Size = new System.Drawing.Size(74, 17);
            this.chbHangmau.TabIndex = 104;
            this.chbHangmau.TabStop = false;
            this.chbHangmau.Text = "Hàng mẫu";
            this.chbHangmau.UseVisualStyleBackColor = true;
            this.chbHangmau.Visible = false;
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.bIsReadOnly = true;
            this.dtpNgayTao.iWidth = 105;
            this.dtpNgayTao.Location = new System.Drawing.Point(741, 25);
            this.dtpNgayTao.MaskDateTime = "dd/MM/yyyy";
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.sCaption = "Ngày tạo:";
            this.dtpNgayTao.sFormat = "dd/MM/yyyy";
            this.dtpNgayTao.Size = new System.Drawing.Size(298, 21);
            this.dtpNgayTao.TabIndex = 103;
            this.dtpNgayTao.TabStop = false;
            this.dtpNgayTao.uDateTime = new System.DateTime(2020, 4, 20, 17, 7, 0, 0);
            this.dtpNgayTao.uValue = new System.DateTime(2020, 4, 20, 17, 7, 0, 0);
            // 
            // txtGhichu
            // 
            this.txtGhichu.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtGhichu.iMaxLength = 500;
            this.txtGhichu.Location = new System.Drawing.Point(18, 110);
            this.txtGhichu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.sCaption = "Ghi chú";
            this.txtGhichu.SelectionStart = 0;
            this.txtGhichu.Size = new System.Drawing.Size(695, 21);
            this.txtGhichu.TabIndex = 7;
            this.txtGhichu.Tag = "..MaNhaCungCap";
            // 
            // cboMaSanPham
            // 
            this.cboMaSanPham.Location = new System.Drawing.Point(18, 80);
            this.cboMaSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaSanPham.Name = "cboMaSanPham";
            this.cboMaSanPham.sCaption = "Sản phẩm (*):";
            this.cboMaSanPham.sColumnCaption = "Mã sản phẩm, Tên sản phẩm";
            this.cboMaSanPham.sField = "ItemNo, ItemName";
            this.cboMaSanPham.Size = new System.Drawing.Size(343, 21);
            this.cboMaSanPham.sNullText = "<Chọn sản phẩm>";
            this.cboMaSanPham.TabIndex = 1;
            this.cboMaSanPham.uDisplayMember = "ItemNo";
            this.cboMaSanPham.uEditValue = null;
            this.cboMaSanPham.uValueMember = "ItemNo";
            this.cboMaSanPham.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboMaSanPham_uQueryPopUp);
            // 
            // cboLoai
            // 
            this.cboLoai.Location = new System.Drawing.Point(1123, 110);
            this.cboLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.sCaption = "Loại:";
            this.cboLoai.sColumnCaption = "Loại";
            this.cboLoai.sField = "Loai";
            this.cboLoai.Size = new System.Drawing.Size(320, 21);
            this.cboLoai.sNullText = "<Chọn>";
            this.cboLoai.TabIndex = 2;
            this.cboLoai.TabStop = false;
            this.cboLoai.uDisplayMember = "Loai";
            this.cboLoai.uEditValue = null;
            this.cboLoai.uTextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboLoai.uValueMember = "Loai";
            this.cboLoai.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // groupControl
            // 
            this.groupControl.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.groupControl.AppearanceCaption.Options.UseFont = true;
            this.groupControl.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl.Controls.Add(this.spnTLTrubi);
            this.groupControl.Controls.Add(this.cboLot);
            this.groupControl.Controls.Add(this.txtQRCode);
            this.groupControl.Controls.Add(this.cboLoai);
            this.groupControl.Controls.Add(this.txtWeightNote);
            this.groupControl.Controls.Add(this.cboMaSanPham);
            this.groupControl.Controls.Add(this.cboVitri);
            this.groupControl.Controls.Add(this.txtGhichu);
            this.groupControl.Controls.Add(this.cboQuicach);
            this.groupControl.Controls.Add(this.dtpNgayTao);
            this.groupControl.Controls.Add(this.chbHangmau);
            this.groupControl.Controls.Add(this.spnSoBao);
            this.groupControl.Controls.Add(this.cboLSX);
            this.groupControl.Controls.Add(this.cboCer);
            this.groupControl.Controls.Add(this.spnTrongluong);
            this.groupControl.Controls.Add(this.txtCropYear);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl.Location = new System.Drawing.Point(0, 0);
            this.groupControl.LookAndFeel.SkinName = "Office 2013";
            this.groupControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(1455, 138);
            this.groupControl.TabIndex = 101;
            this.groupControl.TabStop = true;
            this.groupControl.Text = "Thông tin";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThemmoi);
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.btnInTem);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 138);
            this.panelControl1.LookAndFeel.SkinName = "Office 2013";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1455, 39);
            this.panelControl1.TabIndex = 102;
            this.panelControl1.TabStop = true;
            // 
            // griDanhSach
            // 
            this.griDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.griDanhSach.Location = new System.Drawing.Point(0, 177);
            this.griDanhSach.MainView = this.gridView1;
            this.griDanhSach.Name = "griDanhSach";
            this.griDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.griDanhSach.Size = new System.Drawing.Size(1455, 434);
            this.griDanhSach.TabIndex = 103;
            this.griDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn6,
            this.gridColumn7,
            this.QRCode,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn10,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn9,
            this.gridColumn14,
            this.NetWeight,
            this.gridColumn15,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13});
            this.gridView1.GridControl = this.griDanhSach;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Chọn";
            this.gridColumn8.FieldName = "Chon";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Lệnh sản xuất";
            this.gridColumn6.FieldName = "Document";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Ngày nhập";
            this.gridColumn7.ColumnEdit = this.repositoryItemDateEdit1;
            this.gridColumn7.FieldName = "Date";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
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
            // QRCode
            // 
            this.QRCode.Caption = "QRCode";
            this.QRCode.FieldName = "QRCode";
            this.QRCode.Name = "QRCode";
            this.QRCode.Visible = true;
            this.QRCode.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Sản phẩm";
            this.gridColumn1.FieldName = "ItemNo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Lot";
            this.gridColumn2.FieldName = "Lot";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Lot", "Đã hoàn thành: {0}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Cây hàng";
            this.gridColumn10.FieldName = "BinCode";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 6;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Chứng nhận";
            this.gridColumn3.FieldName = "Certificate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 7;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "PackageType";
            this.gridColumn4.FieldName = "PackageType";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Loại bao bì";
            this.gridColumn5.FieldName = "PackageCode";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 8;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "TL cân";
            this.gridColumn9.DisplayFormat.FormatString = "N0";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn9.FieldName = "GrossWeight";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 9;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "TL Trừ bì";
            this.gridColumn14.FieldName = "TotalPackageQty";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 10;
            // 
            // NetWeight
            // 
            this.NetWeight.Caption = "NetWeight";
            this.NetWeight.DisplayFormat.FormatString = "N0";
            this.NetWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NetWeight.FieldName = "NetWeight";
            this.NetWeight.Name = "NetWeight";
            this.NetWeight.Visible = true;
            this.NetWeight.VisibleIndex = 11;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Ca";
            this.gridColumn15.FieldName = "Ca";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 12;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Ghi chú";
            this.gridColumn11.FieldName = "Note";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 13;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Sample";
            this.gridColumn12.FieldName = "Sample";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Type";
            this.gridColumn13.FieldName = "Type";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // frmNhapKhoTuSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 611);
            this.Controls.Add(this.griDanhSach);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmNhapKhoTuSX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập kho từ bộ phận sản xuất";
            this.Load += new System.EventHandler(this.frmNhapKhoTuSX_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmNhapKhoTuSX_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            this.groupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DELFI_User_Control.uComboBox cboLoai;
        private DELFI_User_Control.uComboBox cboMaSanPham;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnInTem;
        private DELFI_User_Control.uDateTimePicker2 dtpNgayTao;
        private System.Windows.Forms.CheckBox chbHangmau;
        private DELFI_User_Control.uComboBox cboLot;
        private DELFI_User_Control.uSpinEdit spnTrongluong;
        private DELFI_User_Control.uComboBox cboLSX;
        private DELFI_User_Control.uComboBox cboQuicach;
        private DELFI_User_Control.uComboBox cboCer;
        private DELFI_User_Control.uTextBox txtCropYear;
        private DELFI_User_Control.uSpinEdit spnSoBao;
        private DELFI_User_Control.uComboBox cboVitri;
        private DELFI_User_Control.uTextBox txtQRCode;
        private DELFI_User_Control.uTextBox txtWeightNote;
        private DELFI_User_Control.uTextBox txtGhichu;
        private DevExpress.XtraEditors.SimpleButton btnThemmoi;
        private System.Windows.Forms.Timer timer1;
        private DELFI_User_Control.uSpinEdit spnTLTrubi;
        private DevExpress.XtraEditors.GroupControl groupControl;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl griDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn QRCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn NetWeight;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
    }
}