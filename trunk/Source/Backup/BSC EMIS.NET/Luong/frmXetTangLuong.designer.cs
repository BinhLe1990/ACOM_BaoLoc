namespace BSC_HRM.NET.Luong
{
    partial class frmXetTangLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXetTangLuong));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTroVe = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnInDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpDateHoSo = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXetTangLuong = new DevExpress.XtraEditors.SimpleButton();
            this.btnLocDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.dateDenNgay = new BSC_HRM.NET.BSC_User_Control.uDateTimePicker();
            this.dtg = new BSC_HRM.NET.BSC_User_Control.uDataGrid();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar_NangBacLuongThuongXuyen = new DevExpress.XtraBars.BarButtonItem();
            this.bar_PhuCapVuotKhung = new DevExpress.XtraBars.BarButtonItem();
            this.bar_KhongDuocNangBac = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachTangLuong = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbxPhongBan = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.txtSoQuyetDinh = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.txtNguoiKy = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.grpQuyetDinh = new DevExpress.XtraEditors.GroupControl();
            this.dtpNgayKy = new BSC_HRM.NET.BSC_User_Control.uDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpQuyetDinh)).BeginInit();
            this.grpQuyetDinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.btnTroVe);
            this.groupControl1.Controls.Add(this.btnInDanhSach);
            this.groupControl1.Controls.Add(this.btnUpDateHoSo);
            this.groupControl1.Controls.Add(this.btnCapNhat);
            this.groupControl1.Controls.Add(this.btnXetTangLuong);
            this.groupControl1.Controls.Add(this.btnLocDanhSach);
            this.groupControl1.Location = new System.Drawing.Point(1, 370);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(215, 125);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "THAO TÁC THỰC HIỆN";
            // 
            // btnTroVe
            // 
            this.btnTroVe.ImageIndex = 0;
            this.btnTroVe.ImageList = this.imageList1;
            this.btnTroVe.Location = new System.Drawing.Point(4, 98);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(211, 25);
            this.btnTroVe.TabIndex = 3;
            this.btnTroVe.Text = "Thoát";
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Exit.png");
            this.imageList1.Images.SetKeyName(1, "loai 1.png");
            this.imageList1.Images.SetKeyName(2, "Print.png");
            this.imageList1.Images.SetKeyName(3, "Rotation.png");
            this.imageList1.Images.SetKeyName(4, "Save.png");
            this.imageList1.Images.SetKeyName(5, "Search.png");
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.ImageIndex = 2;
            this.btnInDanhSach.ImageList = this.imageList1;
            this.btnInDanhSach.Location = new System.Drawing.Point(3, 73);
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.Size = new System.Drawing.Size(211, 25);
            this.btnInDanhSach.TabIndex = 2;
            this.btnInDanhSach.Text = "In danh sách";
            this.btnInDanhSach.Click += new System.EventHandler(this.btnInDanhSach_Click);
            // 
            // btnUpDateHoSo
            // 
            this.btnUpDateHoSo.ImageIndex = 1;
            this.btnUpDateHoSo.ImageList = this.imageList1;
            this.btnUpDateHoSo.Location = new System.Drawing.Point(107, 48);
            this.btnUpDateHoSo.Name = "btnUpDateHoSo";
            this.btnUpDateHoSo.Size = new System.Drawing.Size(106, 25);
            this.btnUpDateHoSo.TabIndex = 5;
            this.btnUpDateHoSo.Tag = "EDIT";
            this.btnUpDateHoSo.Text = "Update hồ sơ";
            this.btnUpDateHoSo.Click += new System.EventHandler(this.btnUpDateHoSo_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ImageIndex = 4;
            this.btnCapNhat.ImageList = this.imageList1;
            this.btnCapNhat.Location = new System.Drawing.Point(3, 48);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(104, 25);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Tag = "EDIT";
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXetTangLuong
            // 
            this.btnXetTangLuong.ImageIndex = 3;
            this.btnXetTangLuong.ImageList = this.imageList1;
            this.btnXetTangLuong.Location = new System.Drawing.Point(107, 22);
            this.btnXetTangLuong.Name = "btnXetTangLuong";
            this.btnXetTangLuong.Size = new System.Drawing.Size(107, 25);
            this.btnXetTangLuong.TabIndex = 6;
            this.btnXetTangLuong.Tag = "EDIT";
            this.btnXetTangLuong.Text = "Xét tăng lương";
            this.btnXetTangLuong.Click += new System.EventHandler(this.btnXetTangLuong_Click);
            // 
            // btnLocDanhSach
            // 
            this.btnLocDanhSach.ImageIndex = 5;
            this.btnLocDanhSach.ImageList = this.imageList1;
            this.btnLocDanhSach.Location = new System.Drawing.Point(3, 22);
            this.btnLocDanhSach.Name = "btnLocDanhSach";
            this.btnLocDanhSach.Size = new System.Drawing.Size(104, 25);
            this.btnLocDanhSach.TabIndex = 0;
            this.btnLocDanhSach.Text = "Lọc danh sách";
            this.btnLocDanhSach.Click += new System.EventHandler(this.btnLocDanhSach_Click);
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.iWidth = 80;
            this.dateDenNgay.Location = new System.Drawing.Point(5, 24);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.sCaption = "Tính đến ngày";
            this.dateDenNgay.Size = new System.Drawing.Size(212, 21);
            this.dateDenNgay.TabIndex = 1;
            this.dateDenNgay.uDateTime = new System.DateTime(2014, 10, 3, 11, 34, 35, 61);
            this.dateDenNgay.uValue = new System.DateTime(2014, 10, 3, 11, 34, 35, 61);
            this.dateDenNgay.uEditValueChanged += new System.EventHandler(this.dateDenNgay_uEditValueChanged);
            // 
            // dtg
            // 
            this.dtg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg.bAllowEdit = true;
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(222, 3);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(858, 492);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 3;
            this.dtg.uDataSource = null;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bar_NangBacLuongThuongXuyen,
            this.bar_PhuCapVuotKhung,
            this.bar_KhongDuocNangBac,
            this.btnDanhSachTangLuong});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1082, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 498);
            this.barDockControlBottom.Size = new System.Drawing.Size(1082, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 498);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1082, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 498);
            // 
            // bar_NangBacLuongThuongXuyen
            // 
            this.bar_NangBacLuongThuongXuyen.Caption = "Đề nghị nâng bậc lương thường xuyên";
            this.bar_NangBacLuongThuongXuyen.Id = 0;
            this.bar_NangBacLuongThuongXuyen.Name = "bar_NangBacLuongThuongXuyen";
            this.bar_NangBacLuongThuongXuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_NangBacLuongThuongXuyen_ItemClick);
            // 
            // bar_PhuCapVuotKhung
            // 
            this.bar_PhuCapVuotKhung.Caption = "Phụ cấp thâm niên vượt khung";
            this.bar_PhuCapVuotKhung.Id = 1;
            this.bar_PhuCapVuotKhung.Name = "bar_PhuCapVuotKhung";
            this.bar_PhuCapVuotKhung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_PhuCapVuotKhung_ItemClick);
            // 
            // bar_KhongDuocNangBac
            // 
            this.bar_KhongDuocNangBac.Caption = "Danh sách không được nâng bậc lương";
            this.bar_KhongDuocNangBac.Id = 2;
            this.bar_KhongDuocNangBac.Name = "bar_KhongDuocNangBac";
            this.bar_KhongDuocNangBac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_KhongDuocNangBac_ItemClick);
            // 
            // btnDanhSachTangLuong
            // 
            this.btnDanhSachTangLuong.Caption = "Danh sách tăng lương";
            this.btnDanhSachTangLuong.Id = 3;
            this.btnDanhSachTangLuong.Name = "btnDanhSachTangLuong";
            this.btnDanhSachTangLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachTangLuong_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_NangBacLuongThuongXuyen),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_PhuCapVuotKhung),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_KhongDuocNangBac),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDanhSachTangLuong)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.LineColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(1, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(213, 26);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "1.\"Lọc danh sách\" dùng để lọc lại các đợt xét trước theo ngày";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl2.LineColor = System.Drawing.Color.White;
            this.labelControl2.Location = new System.Drawing.Point(0, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(213, 26);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "2.\"Xét tăng lương\" dùng để làm mới lại dữ liệu theo ngày";
            // 
            // cbxPhongBan
            // 
            this.cbxPhongBan.iWidth = 80;
            this.cbxPhongBan.Location = new System.Drawing.Point(5, 3);
            this.cbxPhongBan.Name = "cbxPhongBan";
            this.cbxPhongBan.sCaption = "Phòng ban";
            this.cbxPhongBan.sField = "";
            this.cbxPhongBan.Size = new System.Drawing.Size(212, 21);
            this.cbxPhongBan.TabIndex = 10;
            this.cbxPhongBan.uDisplayMember = "TENPHONGBAN";
            this.cbxPhongBan.uEditValue = "";
            this.cbxPhongBan.uTableName = "DM_PHONGBAN";
            this.cbxPhongBan.uValueMember = "MAPHONGBAN";
            // 
            // txtSoQuyetDinh
            // 
            this.txtSoQuyetDinh.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtSoQuyetDinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSoQuyetDinh.iWidth = 80;
            this.txtSoQuyetDinh.Location = new System.Drawing.Point(2, 22);
            this.txtSoQuyetDinh.Name = "txtSoQuyetDinh";
            this.txtSoQuyetDinh.sCaption = "Số quyết định";
            this.txtSoQuyetDinh.SelectionStart = 0;
            this.txtSoQuyetDinh.Size = new System.Drawing.Size(212, 20);
            this.txtSoQuyetDinh.TabIndex = 15;
            // 
            // txtNguoiKy
            // 
            this.txtNguoiKy.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtNguoiKy.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNguoiKy.iWidth = 80;
            this.txtNguoiKy.Location = new System.Drawing.Point(2, 42);
            this.txtNguoiKy.Name = "txtNguoiKy";
            this.txtNguoiKy.sCaption = "Người ký";
            this.txtNguoiKy.SelectionStart = 0;
            this.txtNguoiKy.Size = new System.Drawing.Size(212, 20);
            this.txtNguoiKy.TabIndex = 16;
            // 
            // grpQuyetDinh
            // 
            this.grpQuyetDinh.Controls.Add(this.dtpNgayKy);
            this.grpQuyetDinh.Controls.Add(this.txtNguoiKy);
            this.grpQuyetDinh.Controls.Add(this.txtSoQuyetDinh);
            this.grpQuyetDinh.Location = new System.Drawing.Point(1, 124);
            this.grpQuyetDinh.Name = "grpQuyetDinh";
            this.grpQuyetDinh.Size = new System.Drawing.Size(216, 87);
            this.grpQuyetDinh.TabIndex = 18;
            this.grpQuyetDinh.Text = "Thông tin quyết định";
            // 
            // dtpNgayKy
            // 
            this.dtpNgayKy.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpNgayKy.iWidth = 80;
            this.dtpNgayKy.Location = new System.Drawing.Point(2, 62);
            this.dtpNgayKy.Name = "dtpNgayKy";
            this.dtpNgayKy.sCaption = "Ngày ký";
            this.dtpNgayKy.Size = new System.Drawing.Size(212, 21);
            this.dtpNgayKy.TabIndex = 17;
            this.dtpNgayKy.uDateTime = new System.DateTime(2014, 10, 3, 11, 34, 35, 51);
            this.dtpNgayKy.uValue = new System.DateTime(2014, 10, 3, 11, 34, 35, 51);
            // 
            // frmXetTangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 498);
            this.Controls.Add(this.grpQuyetDinh);
            this.Controls.Add(this.cbxPhongBan);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dateDenNgay);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmXetTangLuong";
            this.Tag = "|LUONG|";
            this.Text = "Xét tăng lương";
            this.Load += new System.EventHandler(this.frmXetTangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpQuyetDinh)).EndInit();
            this.grpQuyetDinh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BSC_HRM.NET.BSC_User_Control.uDataGrid dtg;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnLocDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnInDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnTroVe;
        private BSC_HRM.NET.BSC_User_Control.uDateTimePicker dateDenNgay;
        private DevExpress.XtraEditors.SimpleButton btnUpDateHoSo;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bar_NangBacLuongThuongXuyen;
        private DevExpress.XtraBars.BarButtonItem bar_PhuCapVuotKhung;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem bar_KhongDuocNangBac;
        private DevExpress.XtraEditors.SimpleButton btnXetTangLuong;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxPhongBan;
        private DevExpress.XtraEditors.GroupControl grpQuyetDinh;
        private BSC_HRM.NET.BSC_User_Control.uTextBox txtSoQuyetDinh;
        private BSC_HRM.NET.BSC_User_Control.uTextBox txtNguoiKy;
        private BSC_HRM.NET.BSC_User_Control.uDateTimePicker dtpNgayKy;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachTangLuong;
    }
}