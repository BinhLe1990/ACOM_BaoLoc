namespace DELFI_WHM.NET.BaoCao
{
    partial class frmSuaPhieuCan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaPhieuCan));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTenKhachHang = new DevExpress.XtraEditors.ButtonEdit();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.spnID = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.txtLyDoSua = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.cboLot = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.txtGhichu = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.dtpCreateDate = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker();
            this.txtWeightNote = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.spnTLSauTruBi = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.spnTongTLBao = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.cboWeightType = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.spnPackageQty = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.cboTransporterCode = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.spnTruckQty = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.cboItemCode = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.spnTLHang = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.cboVendorCode = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.spnTruckTare = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.txtVehicleNo = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.spnGrossWeight = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.txtTenSanPham = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtLocationName = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.cboLocationCode = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.spnSoCan2 = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.spnSoCan1 = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.cboContractNo = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageIndex = 6;
            this.btnSave.Location = new System.Drawing.Point(12, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 26);
            this.btnSave.TabIndex = 113;
            this.btnSave.Tag = "ADD";
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.groupBox1.Appearance.BorderColor = System.Drawing.Color.White;
            this.groupBox1.Appearance.Options.UseBorderColor = true;
            this.groupBox1.Controls.Add(this.cboContractNo);
            this.groupBox1.Controls.Add(this.txtLyDoSua);
            this.groupBox1.Controls.Add(this.cboLot);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.txtGhichu);
            this.groupBox1.Controls.Add(this.dtpCreateDate);
            this.groupBox1.Controls.Add(this.txtWeightNote);
            this.groupBox1.Controls.Add(this.spnTLSauTruBi);
            this.groupBox1.Controls.Add(this.spnTongTLBao);
            this.groupBox1.Controls.Add(this.cboWeightType);
            this.groupBox1.Controls.Add(this.spnPackageQty);
            this.groupBox1.Controls.Add(this.cboTransporterCode);
            this.groupBox1.Controls.Add(this.spnTruckQty);
            this.groupBox1.Controls.Add(this.cboItemCode);
            this.groupBox1.Controls.Add(this.spnTLHang);
            this.groupBox1.Controls.Add(this.cboVendorCode);
            this.groupBox1.Controls.Add(this.spnTruckTare);
            this.groupBox1.Controls.Add(this.txtVehicleNo);
            this.groupBox1.Controls.Add(this.spnGrossWeight);
            this.groupBox1.Controls.Add(this.txtTenSanPham);
            this.groupBox1.Controls.Add(this.txtLocationName);
            this.groupBox1.Controls.Add(this.cboLocationCode);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 314);
            this.groupBox1.TabIndex = 129;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(257, 198);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtTenKhachHang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtTenKhachHang.Size = new System.Drawing.Size(227, 20);
            this.txtTenKhachHang.TabIndex = 106;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageIndex = 6;
            this.btnXoa.Location = new System.Drawing.Point(108, 360);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 26);
            this.btnXoa.TabIndex = 131;
            this.btnXoa.Tag = "ADD";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // spnID
            // 
            this.spnID.bUseMask = true;
            this.spnID.iWidth = 117;
            this.spnID.Location = new System.Drawing.Point(546, 12);
            this.spnID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spnID.Name = "spnID";
            this.spnID.sCaption = "spnID";
            this.spnID.sEditMask = "N0";
            this.spnID.Size = new System.Drawing.Size(182, 22);
            this.spnID.TabIndex = 130;
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
            // txtLyDoSua
            // 
            this.txtLyDoSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLyDoSua.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtLyDoSua.iMaxLength = 500;
            this.txtLyDoSua.iWidth = 117;
            this.txtLyDoSua.Location = new System.Drawing.Point(7, 281);
            this.txtLyDoSua.Margin = new System.Windows.Forms.Padding(4);
            this.txtLyDoSua.Name = "txtLyDoSua";
            this.txtLyDoSua.sCaption = "Lý do sửa (*):";
            this.txtLyDoSua.SelectionStart = 0;
            this.txtLyDoSua.Size = new System.Drawing.Size(703, 21);
            this.txtLyDoSua.TabIndex = 133;
            this.txtLyDoSua.Tag = "";
            // 
            // cboLot
            // 
            this.cboLot.bIsReadOnly = true;
            this.cboLot.iWidth = 117;
            this.cboLot.Location = new System.Drawing.Point(7, 168);
            this.cboLot.Margin = new System.Windows.Forms.Padding(4);
            this.cboLot.Name = "cboLot";
            this.cboLot.sCaption = "Số Lot:";
            this.cboLot.sColumnCaption = "Lot";
            this.cboLot.sField = "Lot";
            this.cboLot.Size = new System.Drawing.Size(477, 21);
            this.cboLot.sNullText = "<Chọn>";
            this.cboLot.TabIndex = 132;
            this.cboLot.uDisplayMember = "Lot";
            this.cboLot.uEditValue = null;
            this.cboLot.uValueMember = "Lot";
            this.cboLot.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboLot_uQueryPopUp);
            // 
            // txtGhichu
            // 
            this.txtGhichu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhichu.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtGhichu.bIsReadOnly = true;
            this.txtGhichu.iMaxLength = 500;
            this.txtGhichu.iWidth = 117;
            this.txtGhichu.Location = new System.Drawing.Point(6, 252);
            this.txtGhichu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.sCaption = "Ghi chú:";
            this.txtGhichu.SelectionStart = 0;
            this.txtGhichu.Size = new System.Drawing.Size(703, 21);
            this.txtGhichu.TabIndex = 7;
            this.txtGhichu.Tag = "..MaNhaCungCap";
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Appearance.ForeColor = System.Drawing.Color.Black;
            this.dtpCreateDate.Appearance.Options.UseForeColor = true;
            this.dtpCreateDate.bIsReadOnly = true;
            this.dtpCreateDate.iWidth = 117;
            this.dtpCreateDate.Location = new System.Drawing.Point(257, 24);
            this.dtpCreateDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.sCaption = "Ngày tạo:";
            this.dtpCreateDate.sFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpCreateDate.Size = new System.Drawing.Size(227, 22);
            this.dtpCreateDate.TabIndex = 131;
            this.dtpCreateDate.uValue = new System.DateTime(2021, 10, 22, 16, 44, 6, 323);
            // 
            // txtWeightNote
            // 
            this.txtWeightNote.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtWeightNote.Appearance.Options.UseForeColor = true;
            this.txtWeightNote.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtWeightNote.bIsReadOnly = true;
            this.txtWeightNote.iWidth = 117;
            this.txtWeightNote.Location = new System.Drawing.Point(7, 24);
            this.txtWeightNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeightNote.Name = "txtWeightNote";
            this.txtWeightNote.sCaption = "Số phiếu:";
            this.txtWeightNote.SelectionStart = 0;
            this.txtWeightNote.Size = new System.Drawing.Size(242, 21);
            this.txtWeightNote.TabIndex = 108;
            this.txtWeightNote.Tag = "..MaNhaCungCap";
            // 
            // spnTLSauTruBi
            // 
            this.spnTLSauTruBi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spnTLSauTruBi.bIsReadOnly = true;
            this.spnTLSauTruBi.bUseMask = true;
            this.spnTLSauTruBi.iWidth = 117;
            this.spnTLSauTruBi.Location = new System.Drawing.Point(499, 190);
            this.spnTLSauTruBi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spnTLSauTruBi.Name = "spnTLSauTruBi";
            this.spnTLSauTruBi.sCaption = "TL sau trừ bì:";
            this.spnTLSauTruBi.sEditMask = "N0";
            this.spnTLSauTruBi.Size = new System.Drawing.Size(211, 21);
            this.spnTLSauTruBi.TabIndex = 130;
            this.spnTLSauTruBi.TabStop = false;
            this.spnTLSauTruBi.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTLSauTruBi.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnTLSauTruBi.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTLSauTruBi.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTLSauTruBi.uText = "0";
            this.spnTLSauTruBi.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // spnTongTLBao
            // 
            this.spnTongTLBao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spnTongTLBao.bIsReadOnly = true;
            this.spnTongTLBao.iWidth = 117;
            this.spnTongTLBao.Location = new System.Drawing.Point(499, 163);
            this.spnTongTLBao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spnTongTLBao.Name = "spnTongTLBao";
            this.spnTongTLBao.sCaption = "Tổng TL bao:";
            this.spnTongTLBao.sEditMask = "N2";
            this.spnTongTLBao.Size = new System.Drawing.Size(211, 21);
            this.spnTongTLBao.TabIndex = 129;
            this.spnTongTLBao.TabStop = false;
            this.spnTongTLBao.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTongTLBao.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnTongTLBao.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTongTLBao.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTongTLBao.uText = "0";
            this.spnTongTLBao.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTongTLBao.uValueChanged += new System.EventHandler(this.spnTongTLBao_uValueChanged);
            // 
            // cboWeightType
            // 
            this.cboWeightType.bIsReadOnly = true;
            this.cboWeightType.iWidth = 117;
            this.cboWeightType.Location = new System.Drawing.Point(257, 50);
            this.cboWeightType.Margin = new System.Windows.Forms.Padding(4);
            this.cboWeightType.Name = "cboWeightType";
            this.cboWeightType.sCaption = "Trạng thái (*):";
            this.cboWeightType.sColumnCaption = "Trạng thái";
            this.cboWeightType.sField = "WeightType";
            this.cboWeightType.Size = new System.Drawing.Size(227, 22);
            this.cboWeightType.sNullText = "<Chọn>";
            this.cboWeightType.TabIndex = 1;
            this.cboWeightType.uDisplayMember = "WeightType";
            this.cboWeightType.uEditValue = null;
            this.cboWeightType.uValueMember = "WeightType";
            this.cboWeightType.uEditValueChanged += new System.EventHandler(this.cboWeightType_uEditValueChanged);
            // 
            // spnPackageQty
            // 
            this.spnPackageQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spnPackageQty.iWidth = 117;
            this.spnPackageQty.Location = new System.Drawing.Point(499, 136);
            this.spnPackageQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spnPackageQty.Name = "spnPackageQty";
            this.spnPackageQty.sCaption = "TL 1 bao:";
            this.spnPackageQty.Size = new System.Drawing.Size(211, 22);
            this.spnPackageQty.TabIndex = 9;
            this.spnPackageQty.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPackageQty.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnPackageQty.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPackageQty.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPackageQty.uText = "0";
            this.spnPackageQty.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPackageQty.uValueChanged += new System.EventHandler(this.spnTLBao_uValueChanged);
            // 
            // cboTransporterCode
            // 
            this.cboTransporterCode.bIsReadOnly = true;
            this.cboTransporterCode.iWidth = 117;
            this.cboTransporterCode.Location = new System.Drawing.Point(7, 110);
            this.cboTransporterCode.Margin = new System.Windows.Forms.Padding(4);
            this.cboTransporterCode.Name = "cboTransporterCode";
            this.cboTransporterCode.sCaption = "Nhà vận chuyển:";
            this.cboTransporterCode.sColumnCaption = "Mã nhà vận chuyển, Tên nhà vận chuyển";
            this.cboTransporterCode.sField = "MaNhaVanChuyen,TenNhaVanChuyen";
            this.cboTransporterCode.Size = new System.Drawing.Size(477, 22);
            this.cboTransporterCode.sNullText = "<Chọn nhà vận chuyển>";
            this.cboTransporterCode.TabIndex = 3;
            this.cboTransporterCode.uDisplayMember = "TenNhaVanChuyen";
            this.cboTransporterCode.uEditValue = null;
            this.cboTransporterCode.uValueMember = "MaNhaVanChuyen";
            this.cboTransporterCode.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboTransporterCode_uQueryPopUp);
            // 
            // spnTruckQty
            // 
            this.spnTruckQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spnTruckQty.bUseMask = true;
            this.spnTruckQty.iWidth = 117;
            this.spnTruckQty.Location = new System.Drawing.Point(500, 108);
            this.spnTruckQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spnTruckQty.Name = "spnTruckQty";
            this.spnTruckQty.sCaption = "Số bao tải:";
            this.spnTruckQty.sEditMask = "N0";
            this.spnTruckQty.Size = new System.Drawing.Size(211, 22);
            this.spnTruckQty.TabIndex = 8;
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
            this.spnTruckQty.uValueChanged += new System.EventHandler(this.spnSobao_uValueChanged);
            // 
            // cboItemCode
            // 
            this.cboItemCode.bIsReadOnly = true;
            this.cboItemCode.iWidth = 117;
            this.cboItemCode.Location = new System.Drawing.Point(7, 139);
            this.cboItemCode.Margin = new System.Windows.Forms.Padding(4);
            this.cboItemCode.Name = "cboItemCode";
            this.cboItemCode.sCaption = "Sản phẩm (*):";
            this.cboItemCode.sColumnCaption = "Mã sản phẩm, Tên sản phẩm";
            this.cboItemCode.sField = "ItemNo, ItemName";
            this.cboItemCode.Size = new System.Drawing.Size(242, 21);
            this.cboItemCode.sNullText = "<Chọn sản phẩm>";
            this.cboItemCode.TabIndex = 4;
            this.cboItemCode.uDisplayMember = "ItemNo";
            this.cboItemCode.uEditValue = null;
            this.cboItemCode.uValueMember = "ItemNo";
            this.cboItemCode.uEditValueChanged += new System.EventHandler(this.cboItemCode_uEditValueChanged);
            // 
            // spnTLHang
            // 
            this.spnTLHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spnTLHang.bIsReadOnly = true;
            this.spnTLHang.bUseMask = true;
            this.spnTLHang.iWidth = 117;
            this.spnTLHang.Location = new System.Drawing.Point(500, 80);
            this.spnTLHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spnTLHang.Name = "spnTLHang";
            this.spnTLHang.sCaption = "TL Hàng:";
            this.spnTLHang.sEditMask = "N0";
            this.spnTLHang.Size = new System.Drawing.Size(211, 26);
            this.spnTLHang.TabIndex = 126;
            this.spnTLHang.TabStop = false;
            this.spnTLHang.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTLHang.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnTLHang.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTLHang.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTLHang.uText = "0";
            this.spnTLHang.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTLHang.uValueChanged += new System.EventHandler(this.spnTLHang_uValueChanged);
            // 
            // cboVendorCode
            // 
            this.cboVendorCode.bIsReadOnly = true;
            this.cboVendorCode.iWidth = 117;
            this.cboVendorCode.Location = new System.Drawing.Point(7, 197);
            this.cboVendorCode.Margin = new System.Windows.Forms.Padding(4);
            this.cboVendorCode.Name = "cboVendorCode";
            this.cboVendorCode.sCaption = "Khách hàng:";
            this.cboVendorCode.sColumnCaption = "Mã khách hàng, Tên khách hàng";
            this.cboVendorCode.sField = "MaKhachHang,TenKhachHang";
            this.cboVendorCode.Size = new System.Drawing.Size(242, 21);
            this.cboVendorCode.sNullText = "<Chọn khách hàng>";
            this.cboVendorCode.TabIndex = 5;
            this.cboVendorCode.uDisplayMember = "MaKhachHang";
            this.cboVendorCode.uEditValue = null;
            this.cboVendorCode.uValueMember = "MaKhachHang";
            this.cboVendorCode.uEditValueChanged += new System.EventHandler(this.cboVendorCode_uEditValueChanged);
            this.cboVendorCode.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboVendorCode_uQueryPopUp);
            // 
            // spnTruckTare
            // 
            this.spnTruckTare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spnTruckTare.bIsReadOnly = true;
            this.spnTruckTare.bUseMask = true;
            this.spnTruckTare.iWidth = 117;
            this.spnTruckTare.Location = new System.Drawing.Point(500, 50);
            this.spnTruckTare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spnTruckTare.Name = "spnTruckTare";
            this.spnTruckTare.sCaption = "TL xe:";
            this.spnTruckTare.sEditMask = "N0";
            this.spnTruckTare.Size = new System.Drawing.Size(211, 24);
            this.spnTruckTare.TabIndex = 125;
            this.spnTruckTare.TabStop = false;
            this.spnTruckTare.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTruckTare.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnTruckTare.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTruckTare.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTruckTare.uText = "0";
            this.spnTruckTare.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTruckTare.uValueChanged += new System.EventHandler(this.spnTLXe_uValueChanged);
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtVehicleNo.bIsReadOnly = true;
            this.txtVehicleNo.iMaxLength = 40;
            this.txtVehicleNo.iWidth = 117;
            this.txtVehicleNo.Location = new System.Drawing.Point(7, 50);
            this.txtVehicleNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.sCaption = "Số xe (*):";
            this.txtVehicleNo.SelectionStart = 0;
            this.txtVehicleNo.Size = new System.Drawing.Size(242, 21);
            this.txtVehicleNo.TabIndex = 0;
            this.txtVehicleNo.Tag = "..MaNhaCungCap";
            // 
            // spnGrossWeight
            // 
            this.spnGrossWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spnGrossWeight.bHAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.spnGrossWeight.bIsReadOnly = true;
            this.spnGrossWeight.bLabelAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.spnGrossWeight.bUseMask = true;
            this.spnGrossWeight.iWidth = 117;
            this.spnGrossWeight.Location = new System.Drawing.Point(500, 24);
            this.spnGrossWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spnGrossWeight.Name = "spnGrossWeight";
            this.spnGrossWeight.sCaption = "TL xe + hàng:";
            this.spnGrossWeight.sEditMask = "N0";
            this.spnGrossWeight.Size = new System.Drawing.Size(211, 24);
            this.spnGrossWeight.TabIndex = 124;
            this.spnGrossWeight.TabStop = false;
            this.spnGrossWeight.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnGrossWeight.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnGrossWeight.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnGrossWeight.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnGrossWeight.uText = "0";
            this.spnGrossWeight.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnGrossWeight.uValueChanged += new System.EventHandler(this.spnTLHangXe_uValueChanged);
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtTenSanPham.bIsReadOnly = true;
            this.txtTenSanPham.iWidth = 1;
            this.txtTenSanPham.Location = new System.Drawing.Point(257, 139);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.sCaption = "";
            this.txtTenSanPham.SelectionStart = 0;
            this.txtTenSanPham.Size = new System.Drawing.Size(227, 21);
            this.txtTenSanPham.TabIndex = 112;
            this.txtTenSanPham.TabStop = false;
            this.txtTenSanPham.Tag = "..MaNhaCungCap";
            // 
            // txtLocationName
            // 
            this.txtLocationName.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtLocationName.bIsReadOnly = true;
            this.txtLocationName.iWidth = 1;
            this.txtLocationName.Location = new System.Drawing.Point(257, 222);
            this.txtLocationName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.sCaption = "";
            this.txtLocationName.SelectionStart = 0;
            this.txtLocationName.Size = new System.Drawing.Size(227, 21);
            this.txtLocationName.TabIndex = 122;
            this.txtLocationName.TabStop = false;
            this.txtLocationName.Tag = "..MaNhaCungCap";
            // 
            // cboLocationCode
            // 
            this.cboLocationCode.bIsReadOnly = true;
            this.cboLocationCode.iWidth = 117;
            this.cboLocationCode.Location = new System.Drawing.Point(7, 222);
            this.cboLocationCode.Margin = new System.Windows.Forms.Padding(4);
            this.cboLocationCode.Name = "cboLocationCode";
            this.cboLocationCode.sCaption = "Khu vực (*):";
            this.cboLocationCode.sColumnCaption = "Mã khu vực, Tên khu vực";
            this.cboLocationCode.sField = "Code, LocationName";
            this.cboLocationCode.Size = new System.Drawing.Size(242, 21);
            this.cboLocationCode.sNullText = "<Chọn khu vực>";
            this.cboLocationCode.TabIndex = 6;
            this.cboLocationCode.uDisplayMember = "Code";
            this.cboLocationCode.uEditValue = null;
            this.cboLocationCode.uValueMember = "Code";
            this.cboLocationCode.uEditValueChanged += new System.EventHandler(this.cboLocationCode_uEditValueChanged);
            this.cboLocationCode.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboLocationCode_uQueryPopUp);
            // 
            // spnSoCan2
            // 
            this.spnSoCan2.bUseMask = true;
            this.spnSoCan2.iWidth = 117;
            this.spnSoCan2.Location = new System.Drawing.Point(280, 12);
            this.spnSoCan2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spnSoCan2.Name = "spnSoCan2";
            this.spnSoCan2.sCaption = "Số cân lần 2:";
            this.spnSoCan2.sEditMask = "N0";
            this.spnSoCan2.Size = new System.Drawing.Size(260, 22);
            this.spnSoCan2.TabIndex = 111;
            this.spnSoCan2.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnSoCan2.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnSoCan2.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnSoCan2.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnSoCan2.uText = "0";
            this.spnSoCan2.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnSoCan2.uValueChanged += new System.EventHandler(this.spnSoCan2_uValueChanged);
            // 
            // spnSoCan1
            // 
            this.spnSoCan1.bUseMask = true;
            this.spnSoCan1.iWidth = 117;
            this.spnSoCan1.Location = new System.Drawing.Point(12, 12);
            this.spnSoCan1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spnSoCan1.Name = "spnSoCan1";
            this.spnSoCan1.sCaption = "Số cân lần 1:";
            this.spnSoCan1.sEditMask = "N0";
            this.spnSoCan1.Size = new System.Drawing.Size(260, 22);
            this.spnSoCan1.TabIndex = 110;
            this.spnSoCan1.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnSoCan1.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnSoCan1.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnSoCan1.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnSoCan1.uText = "0";
            this.spnSoCan1.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnSoCan1.uValueChanged += new System.EventHandler(this.spnSoCan1_uValueChanged);
            // 
            // cboContractNo
            // 
            this.cboContractNo.bIsReadOnly = true;
            this.cboContractNo.iWidth = 117;
            this.cboContractNo.Location = new System.Drawing.Point(7, 79);
            this.cboContractNo.Margin = new System.Windows.Forms.Padding(4);
            this.cboContractNo.Name = "cboContractNo";
            this.cboContractNo.sCaption = "Số hợp đồng/SO:";
            this.cboContractNo.sColumnCaption = "Mã, Diễn giải";
            this.cboContractNo.sField = "Ma, Ten";
            this.cboContractNo.Size = new System.Drawing.Size(477, 22);
            this.cboContractNo.sNullText = "<Chọn hợp đồng/chỉ thị>";
            this.cboContractNo.TabIndex = 134;
            this.cboContractNo.uDisplayMember = "Ma";
            this.cboContractNo.uEditValue = null;
            this.cboContractNo.uValueMember = "Ma";
            // 
            // frmSuaPhieuCan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 399);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.spnID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.spnSoCan2);
            this.Controls.Add(this.spnSoCan1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "frmSuaPhieuCan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SỬA PHIẾU CÂN";
            this.Load += new System.EventHandler(this.frmSuaPhieuCan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DELFI_User_Control.uSpinEdit spnSoCan1;
        private DELFI_User_Control.uSpinEdit spnSoCan2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupBox1;
        private DELFI_User_Control.uComboBox cboLot;
        private DevExpress.XtraEditors.ButtonEdit txtTenKhachHang;
        private DELFI_User_Control.uTextBox txtGhichu;
        private DELFI_User_Control.uDateTimePicker dtpCreateDate;
        private DELFI_User_Control.uTextBox txtWeightNote;
        private DELFI_User_Control.uSpinEdit spnTLSauTruBi;
        private DELFI_User_Control.uSpinEdit spnTongTLBao;
        private DELFI_User_Control.uComboBox cboWeightType;
        private DELFI_User_Control.uSpinEdit spnPackageQty;
        private DELFI_User_Control.uComboBox cboTransporterCode;
        private DELFI_User_Control.uSpinEdit spnTruckQty;
        private DELFI_User_Control.uComboBox cboItemCode;
        private DELFI_User_Control.uSpinEdit spnTLHang;
        private DELFI_User_Control.uComboBox cboVendorCode;
        private DELFI_User_Control.uSpinEdit spnTruckTare;
        private DELFI_User_Control.uTextBox txtVehicleNo;
        private DELFI_User_Control.uSpinEdit spnGrossWeight;
        private DELFI_User_Control.uTextBox txtTenSanPham;
        private DELFI_User_Control.uTextBox txtLocationName;
        private DELFI_User_Control.uComboBox cboLocationCode;
        private DELFI_User_Control.uSpinEdit spnID;
        private DELFI_User_Control.uTextBox txtLyDoSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DELFI_User_Control.uComboBox cboContractNo;
    }
}