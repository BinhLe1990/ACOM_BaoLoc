namespace DELFI_WHM.NET.Luong
{
    partial class frmThongKeHoaDonXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeHoaDonXuat));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.raDangDung = new DevExpress.XtraEditors.RadioGroup();
            this.txtSoHoDonDen = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtTuSoHoaDon = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtpChungTuDenNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker();
            this.dtpChungTuTuNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker();
            this.chkChungTu = new DevExpress.XtraEditors.CheckEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnInDanhSach = new DevExpress.XtraBars.BarButtonItem();
            this.barInNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLocDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnXemHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnInNhanh = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.dtpDenNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker();
            this.dtpTuNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker();
            this.cbxPhongBan = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cbxPhanHe = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cbxCoSo = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.dtg = new DELFI_WHM.NET.DELFI_User_Control.uDataGrid();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raDangDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkChungTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.raDangDung);
            this.panelControl1.Controls.Add(this.txtSoHoDonDen);
            this.panelControl1.Controls.Add(this.txtTuSoHoaDon);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.chkChungTu);
            this.panelControl1.Controls.Add(this.btnLocDanhSach);
            this.panelControl1.Controls.Add(this.btnXemHoaDon);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnInNhanh);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.dtpDenNgay);
            this.panelControl1.Controls.Add(this.dtpTuNgay);
            this.panelControl1.Controls.Add(this.cbxPhongBan);
            this.panelControl1.Controls.Add(this.cbxPhanHe);
            this.panelControl1.Controls.Add(this.cbxCoSo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(288, 493);
            this.panelControl1.TabIndex = 0;
            // 
            // raDangDung
            // 
            this.raDangDung.EditValue = 0;
            this.raDangDung.Location = new System.Drawing.Point(5, 141);
            this.raDangDung.Name = "raDangDung";
            this.raDangDung.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.raDangDung.Properties.Appearance.Options.UseForeColor = true;
            this.raDangDung.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Sử dụng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Đã xóa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Tất cả")});
            this.raDangDung.Size = new System.Drawing.Size(277, 23);
            this.raDangDung.TabIndex = 38;
            // 
            // txtSoHoDonDen
            // 
            this.txtSoHoDonDen.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtSoHoDonDen.Location = new System.Drawing.Point(3, 88);
            this.txtSoHoDonDen.Name = "txtSoHoDonDen";
            this.txtSoHoDonDen.sCaption = "Đến số:";
            this.txtSoHoDonDen.SelectionStart = 0;
            this.txtSoHoDonDen.Size = new System.Drawing.Size(283, 20);
            this.txtSoHoDonDen.TabIndex = 13;
            // 
            // txtTuSoHoaDon
            // 
            this.txtTuSoHoaDon.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtTuSoHoaDon.Location = new System.Drawing.Point(3, 66);
            this.txtTuSoHoaDon.Name = "txtTuSoHoaDon";
            this.txtTuSoHoaDon.sCaption = "Hóa đơn từ số:";
            this.txtTuSoHoaDon.SelectionStart = 0;
            this.txtTuSoHoaDon.Size = new System.Drawing.Size(283, 20);
            this.txtTuSoHoaDon.TabIndex = 12;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dtpChungTuDenNgay);
            this.groupControl1.Controls.Add(this.dtpChungTuTuNgay);
            this.groupControl1.Location = new System.Drawing.Point(4, 190);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(278, 51);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Chừng từ";
            this.groupControl1.Visible = false;
            // 
            // dtpChungTuDenNgay
            // 
            this.dtpChungTuDenNgay.bHAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dtpChungTuDenNgay.iWidth = 35;
            this.dtpChungTuDenNgay.Location = new System.Drawing.Point(147, 25);
            this.dtpChungTuDenNgay.Name = "dtpChungTuDenNgay";
            this.dtpChungTuDenNgay.sCaption = "Đến N";
            this.dtpChungTuDenNgay.Size = new System.Drawing.Size(121, 21);
            this.dtpChungTuDenNgay.TabIndex = 6;
            this.dtpChungTuDenNgay.uDateTime = new System.DateTime(2013, 4, 17, 10, 16, 2, 714);
            this.dtpChungTuDenNgay.uValue = new System.DateTime(2013, 4, 17, 10, 16, 2, 714);
            // 
            // dtpChungTuTuNgay
            // 
            this.dtpChungTuTuNgay.bHAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dtpChungTuTuNgay.iWidth = 45;
            this.dtpChungTuTuNgay.Location = new System.Drawing.Point(9, 25);
            this.dtpChungTuTuNgay.Name = "dtpChungTuTuNgay";
            this.dtpChungTuTuNgay.sCaption = "Từ ngày";
            this.dtpChungTuTuNgay.Size = new System.Drawing.Size(124, 21);
            this.dtpChungTuTuNgay.TabIndex = 5;
            this.dtpChungTuTuNgay.uDateTime = new System.DateTime(2013, 4, 17, 10, 16, 2, 732);
            this.dtpChungTuTuNgay.uValue = new System.DateTime(2013, 4, 17, 10, 16, 2, 732);
            // 
            // chkChungTu
            // 
            this.chkChungTu.Location = new System.Drawing.Point(2, 168);
            this.chkChungTu.MenuManager = this.barManager1;
            this.chkChungTu.Name = "chkChungTu";
            this.chkChungTu.Properties.Caption = "Tìm theo chứng từ";
            this.chkChungTu.Size = new System.Drawing.Size(246, 19);
            this.chkChungTu.TabIndex = 11;
            this.chkChungTu.CheckedChanged += new System.EventHandler(this.chkChungTu_CheckedChanged);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnInDanhSach,
            this.barInNhanh,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(887, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 493);
            this.barDockControlBottom.Size = new System.Drawing.Size(887, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 493);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(887, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 493);
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.Caption = "In danh sách";
            this.btnInDanhSach.Id = 0;
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInDanhSach_ItemClick);
            // 
            // barInNhanh
            // 
            this.barInNhanh.Caption = "In nhanh";
            this.barInNhanh.Id = 1;
            this.barInNhanh.Name = "barInNhanh";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "In nhanh hóa đơn";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnLocDanhSach
            // 
            this.btnLocDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLocDanhSach.ImageIndex = 2;
            this.btnLocDanhSach.ImageList = this.imageList1;
            this.btnLocDanhSach.Location = new System.Drawing.Point(2, 380);
            this.btnLocDanhSach.Name = "btnLocDanhSach";
            this.btnLocDanhSach.Size = new System.Drawing.Size(279, 31);
            this.btnLocDanhSach.TabIndex = 5;
            this.btnLocDanhSach.Text = "Lọc danh sách";
            this.btnLocDanhSach.Click += new System.EventHandler(this.btnLocDanhSach_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "copyItem1.LargeGlyph.png");
            this.imageList1.Images.SetKeyName(1, "Exit.png");
            this.imageList1.Images.SetKeyName(2, "Search.png");
            this.imageList1.Images.SetKeyName(3, "Cancel.png");
            this.imageList1.Images.SetKeyName(4, "Print.png");
            this.imageList1.Images.SetKeyName(5, "Ok.png");
            // 
            // btnXemHoaDon
            // 
            this.btnXemHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXemHoaDon.ImageIndex = 0;
            this.btnXemHoaDon.ImageList = this.imageList1;
            this.btnXemHoaDon.Location = new System.Drawing.Point(2, 417);
            this.btnXemHoaDon.Name = "btnXemHoaDon";
            this.btnXemHoaDon.Size = new System.Drawing.Size(130, 31);
            this.btnXemHoaDon.TabIndex = 5;
            this.btnXemHoaDon.Tag = "EDIT";
            this.btnXemHoaDon.Text = "Xem hóa đơn";
            this.btnXemHoaDon.Click += new System.EventHandler(this.btnXemHoaDon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.ImageIndex = 3;
            this.btnXoa.ImageList = this.imageList1;
            this.btnXoa.Location = new System.Drawing.Point(138, 417);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(143, 31);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Tag = "DEL";
            this.btnXoa.Text = "Xóa hóa đơn";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnInNhanh
            // 
            this.btnInNhanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInNhanh.ImageIndex = 4;
            this.btnInNhanh.ImageList = this.imageList1;
            this.btnInNhanh.Location = new System.Drawing.Point(2, 454);
            this.btnInNhanh.Name = "btnInNhanh";
            this.btnInNhanh.Size = new System.Drawing.Size(130, 31);
            this.btnInNhanh.TabIndex = 8;
            this.btnInNhanh.Text = "In dữ liệu";
            this.btnInNhanh.Click += new System.EventHandler(this.btnInNhanh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThoat.ImageIndex = 1;
            this.btnThoat.ImageList = this.imageList1;
            this.btnThoat.Location = new System.Drawing.Point(138, 454);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(143, 31);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.bHAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dtpDenNgay.iWidth = 50;
            this.dtpDenNgay.Location = new System.Drawing.Point(141, 114);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.sCaption = "Đến N";
            this.dtpDenNgay.Size = new System.Drawing.Size(145, 21);
            this.dtpDenNgay.TabIndex = 4;
            this.dtpDenNgay.uDateTime = new System.DateTime(2013, 4, 17, 10, 16, 2, 762);
            this.dtpDenNgay.uValue = new System.DateTime(2013, 4, 17, 10, 16, 2, 762);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.bHAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dtpTuNgay.iWidth = 55;
            this.dtpTuNgay.Location = new System.Drawing.Point(2, 114);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.sCaption = "Từ ngày";
            this.dtpTuNgay.Size = new System.Drawing.Size(133, 21);
            this.dtpTuNgay.TabIndex = 0;
            this.dtpTuNgay.uDateTime = new System.DateTime(2013, 4, 17, 10, 16, 2, 777);
            this.dtpTuNgay.uValue = new System.DateTime(2013, 4, 17, 10, 16, 2, 777);
            // 
            // cbxPhongBan
            // 
            this.cbxPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxPhongBan.Location = new System.Drawing.Point(2, 44);
            this.cbxPhongBan.Name = "cbxPhongBan";
            this.cbxPhongBan.sCaption = "Phòng ban";
            this.cbxPhongBan.sColumnCaption = "Mã phòng ban,Tên phòng ban";
            this.cbxPhongBan.sField = "MAPHONGBAN,TENPHONGBAN";
            this.cbxPhongBan.Size = new System.Drawing.Size(284, 21);
            this.cbxPhongBan.TabIndex = 3;
            this.cbxPhongBan.uDisplayMember = "TENPHONGBAN";
            this.cbxPhongBan.uEditValue = "";
            this.cbxPhongBan.uTableName = "DM_PHONGBAN";
            this.cbxPhongBan.uValueMember = "MAPHONGBAN";
            // 
            // cbxPhanHe
            // 
            this.cbxPhanHe.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxPhanHe.Location = new System.Drawing.Point(2, 23);
            this.cbxPhanHe.Name = "cbxPhanHe";
            this.cbxPhanHe.sCaption = "Phân hệ";
            this.cbxPhanHe.sColumnCaption = "Mã phân hệ,Tên phân hệ";
            this.cbxPhanHe.sField = "MAPHANHE,TENPHANHE";
            this.cbxPhanHe.Size = new System.Drawing.Size(284, 21);
            this.cbxPhanHe.TabIndex = 2;
            this.cbxPhanHe.uDisplayMember = "TENPHANHE";
            this.cbxPhanHe.uEditValue = "";
            this.cbxPhanHe.uTableName = "DM_PHANHE";
            this.cbxPhanHe.uValueMember = "MAPHANHE";
            this.cbxPhanHe.Load += new System.EventHandler(this.cbxPhanHe_Load);
            // 
            // cbxCoSo
            // 
            this.cbxCoSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxCoSo.Location = new System.Drawing.Point(2, 2);
            this.cbxCoSo.Name = "cbxCoSo";
            this.cbxCoSo.sCaption = "Cơ sở";
            this.cbxCoSo.sColumnCaption = "Mã cơ sở,Tên cơ sở";
            this.cbxCoSo.sField = "MACOSO,TENCOSO";
            this.cbxCoSo.Size = new System.Drawing.Size(284, 21);
            this.cbxCoSo.TabIndex = 1;
            this.cbxCoSo.uDisplayMember = "TENCOSO";
            this.cbxCoSo.uEditValue = "";
            this.cbxCoSo.uTableName = "DM_COSO";
            this.cbxCoSo.uValueMember = "MACOSO";
            // 
            // dtg
            // 
            this.dtg.bAllowEdit = true;
            this.dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(288, 0);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(599, 493);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 1;
            this.dtg.uDataSource = null;
            this.dtg.uDataSourceChanged += new System.EventHandler(this.dtg_uDataSourceChanged);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnInDanhSach),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // frmThongKeHoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 493);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmThongKeHoaDonXuat";
            this.Tag = "|HOADON|";
            this.Text = "Thống kê hóa đơn xuất";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raDangDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkChungTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DELFI_WHM.NET.DELFI_User_Control.uDataGrid dtg;
        private DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker dtpTuNgay;
        private DevExpress.XtraEditors.SimpleButton btnLocDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnXemHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker dtpDenNgay;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cbxPhongBan;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cbxPhanHe;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cbxCoSo;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnInNhanh;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnInDanhSach;
        private DevExpress.XtraBars.BarButtonItem barInNhanh;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker dtpChungTuDenNgay;
        private DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker dtpChungTuTuNgay;
        private DevExpress.XtraEditors.CheckEdit chkChungTu;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtSoHoDonDen;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtTuSoHoaDon;
        private DevExpress.XtraEditors.RadioGroup raDangDung;
    }
}