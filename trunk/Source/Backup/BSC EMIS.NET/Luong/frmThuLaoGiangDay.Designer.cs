namespace BSC_HRM.NET.Luong
{
    partial class frmThuLaoGiangDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuLaoGiangDay));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.dtpNgayChungTu = new BSC_HRM.NET.BSC_User_Control.uDateTimePicker();
            this.txtSoChungTu = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnXoaDong = new DevExpress.XtraEditors.SimpleButton();
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnInDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.btnTinhThuLao = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLocDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtDonViNhan = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.cbxNoiDungChi = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxNganHang = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.dateDenNgay = new BSC_HRM.NET.BSC_User_Control.uDateTimePicker();
            this.dateTuNgay = new BSC_HRM.NET.BSC_User_Control.uDateTimePicker();
            this.cbxPhanHe = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxCoSo = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.dtg = new BSC_HRM.NET.BSC_User_Control.uDataGrid();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.menuMau1 = new DevExpress.XtraBars.BarButtonItem();
            this.menuMau2 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl3);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(242, 604);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnOK);
            this.groupControl3.Controls.Add(this.dtpNgayChungTu);
            this.groupControl3.Controls.Add(this.txtSoChungTu);
            this.groupControl3.Location = new System.Drawing.Point(2, 186);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(236, 100);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Nhập đồng loạt";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(156, 69);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dtpNgayChungTu
            // 
            this.dtpNgayChungTu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpNgayChungTu.iWidth = 80;
            this.dtpNgayChungTu.Location = new System.Drawing.Point(2, 42);
            this.dtpNgayChungTu.Name = "dtpNgayChungTu";
            this.dtpNgayChungTu.sCaption = "Ngày chứng từ";
            this.dtpNgayChungTu.Size = new System.Drawing.Size(232, 21);
            this.dtpNgayChungTu.TabIndex = 1;
            this.dtpNgayChungTu.uDateTime = new System.DateTime(2013, 6, 19, 14, 14, 26, 951);
            this.dtpNgayChungTu.uValue = new System.DateTime(2013, 6, 19, 14, 14, 26, 951);
            // 
            // txtSoChungTu
            // 
            this.txtSoChungTu.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtSoChungTu.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSoChungTu.iWidth = 80;
            this.txtSoChungTu.Location = new System.Drawing.Point(2, 22);
            this.txtSoChungTu.Name = "txtSoChungTu";
            this.txtSoChungTu.sCaption = "Số chứng từ";
            this.txtSoChungTu.SelectionStart = 0;
            this.txtSoChungTu.Size = new System.Drawing.Size(232, 20);
            this.txtSoChungTu.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnXoaDong);
            this.groupControl2.Controls.Add(this.btnThoat);
            this.groupControl2.Controls.Add(this.btnInDanhSach);
            this.groupControl2.Controls.Add(this.btnTinhThuLao);
            this.groupControl2.Controls.Add(this.btnCapNhat);
            this.groupControl2.Controls.Add(this.btnLocDanhSach);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(2, 446);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(238, 156);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "THAO TÁC THỰC HIỆN";
            // 
            // btnXoaDong
            // 
            this.btnXoaDong.ImageIndex = 5;
            this.btnXoaDong.ImageList = this.IML;
            this.btnXoaDong.Location = new System.Drawing.Point(5, 89);
            this.btnXoaDong.Name = "btnXoaDong";
            this.btnXoaDong.Size = new System.Drawing.Size(114, 32);
            this.btnXoaDong.TabIndex = 5;
            this.btnXoaDong.Tag = "DEL";
            this.btnXoaDong.Text = "Xóa dòng";
            this.btnXoaDong.Click += new System.EventHandler(this.btnXoaDong_Click);
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
            this.IML.Images.SetKeyName(7, "Print.png");
            this.IML.Images.SetKeyName(8, "Rotation.png");
            this.IML.Images.SetKeyName(9, "changeFontBackColorItem1.LargeGlyph.png");
            this.IML.Images.SetKeyName(10, "Add.png");
            this.IML.Images.SetKeyName(11, "Yes.png");
            this.IML.Images.SetKeyName(12, "pqsd.png");
            this.IML.Images.SetKeyName(13, "32px-Crystal_Clear_Password.png");
            this.IML.Images.SetKeyName(14, "excel (Custom).png");
            // 
            // btnThoat
            // 
            this.btnThoat.ImageIndex = 1;
            this.btnThoat.ImageList = this.IML;
            this.btnThoat.Location = new System.Drawing.Point(5, 121);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(229, 32);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.ImageIndex = 7;
            this.btnInDanhSach.ImageList = this.IML;
            this.btnInDanhSach.Location = new System.Drawing.Point(119, 89);
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.Size = new System.Drawing.Size(113, 32);
            this.btnInDanhSach.TabIndex = 3;
            this.btnInDanhSach.Text = "In danh sách";
            this.btnInDanhSach.Click += new System.EventHandler(this.btnInDanhSach_Click);
            // 
            // btnTinhThuLao
            // 
            this.btnTinhThuLao.ImageIndex = 9;
            this.btnTinhThuLao.ImageList = this.IML;
            this.btnTinhThuLao.Location = new System.Drawing.Point(5, 57);
            this.btnTinhThuLao.Name = "btnTinhThuLao";
            this.btnTinhThuLao.Size = new System.Drawing.Size(114, 32);
            this.btnTinhThuLao.TabIndex = 1;
            this.btnTinhThuLao.Tag = "ADD";
            this.btnTinhThuLao.Text = "Tính thù lao";
            this.btnTinhThuLao.Click += new System.EventHandler(this.btnTinhThuLao_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ImageIndex = 2;
            this.btnCapNhat.ImageList = this.IML;
            this.btnCapNhat.Location = new System.Drawing.Point(119, 57);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(114, 32);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Tag = "ADD";
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLocDanhSach
            // 
            this.btnLocDanhSach.ImageIndex = 0;
            this.btnLocDanhSach.ImageList = this.IML;
            this.btnLocDanhSach.Location = new System.Drawing.Point(5, 25);
            this.btnLocDanhSach.Name = "btnLocDanhSach";
            this.btnLocDanhSach.Size = new System.Drawing.Size(229, 32);
            this.btnLocDanhSach.TabIndex = 0;
            this.btnLocDanhSach.Text = "Lọc dữ liệu";
            this.btnLocDanhSach.Click += new System.EventHandler(this.btnLocDanhSach_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtDonViNhan);
            this.groupControl1.Controls.Add(this.cbxNoiDungChi);
            this.groupControl1.Controls.Add(this.cbxNganHang);
            this.groupControl1.Controls.Add(this.dateDenNgay);
            this.groupControl1.Controls.Add(this.dateTuNgay);
            this.groupControl1.Controls.Add(this.cbxPhanHe);
            this.groupControl1.Controls.Add(this.cbxCoSo);
            this.groupControl1.Location = new System.Drawing.Point(0, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(238, 179);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Điều kiện lọc";
            // 
            // txtDonViNhan
            // 
            this.txtDonViNhan.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtDonViNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDonViNhan.iWidth = 60;
            this.txtDonViNhan.Location = new System.Drawing.Point(2, 154);
            this.txtDonViNhan.Name = "txtDonViNhan";
            this.txtDonViNhan.sCaption = "Đơn vị nhận";
            this.txtDonViNhan.SelectionStart = 0;
            this.txtDonViNhan.Size = new System.Drawing.Size(234, 23);
            this.txtDonViNhan.TabIndex = 5;
            // 
            // cbxNoiDungChi
            // 
            this.cbxNoiDungChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxNoiDungChi.iWidth = 60;
            this.cbxNoiDungChi.Location = new System.Drawing.Point(2, 133);
            this.cbxNoiDungChi.Name = "cbxNoiDungChi";
            this.cbxNoiDungChi.sCaption = "Nội dung chi";
            this.cbxNoiDungChi.sField = "";
            this.cbxNoiDungChi.Size = new System.Drawing.Size(234, 21);
            this.cbxNoiDungChi.TabIndex = 7;
            this.cbxNoiDungChi.uDisplayMember = null;
            this.cbxNoiDungChi.uEditValue = "";
            this.cbxNoiDungChi.uTextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxNoiDungChi.uValueMember = null;
            // 
            // cbxNganHang
            // 
            this.cbxNganHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxNganHang.iWidth = 60;
            this.cbxNganHang.Location = new System.Drawing.Point(2, 112);
            this.cbxNganHang.Name = "cbxNganHang";
            this.cbxNganHang.sCaption = "Ngân hàng";
            this.cbxNganHang.sField = "MaNhomNganHang,TenNhomNganHang";
            this.cbxNganHang.Size = new System.Drawing.Size(234, 21);
            this.cbxNganHang.TabIndex = 6;
            this.cbxNganHang.uDisplayMember = "TenNhomNganHang";
            this.cbxNganHang.uEditValue = "";
            this.cbxNganHang.uTableName = "DM_NhomNganHang";
            this.cbxNganHang.uTextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxNganHang.uValueMember = "MaNhomNganHang";
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateDenNgay.iWidth = 60;
            this.dateDenNgay.Location = new System.Drawing.Point(2, 89);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.sCaption = "Đến ngày";
            this.dateDenNgay.Size = new System.Drawing.Size(234, 23);
            this.dateDenNgay.TabIndex = 3;
            this.dateDenNgay.uDateTime = new System.DateTime(2013, 6, 19, 14, 14, 26, 933);
            this.dateDenNgay.uValue = new System.DateTime(2013, 6, 19, 14, 14, 26, 933);
            this.dateDenNgay.uEditValueChanged += new System.EventHandler(this.dateDenNgay_uEditValueChanged);
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTuNgay.iWidth = 60;
            this.dateTuNgay.Location = new System.Drawing.Point(2, 66);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.sCaption = "Từ ngày";
            this.dateTuNgay.Size = new System.Drawing.Size(234, 23);
            this.dateTuNgay.TabIndex = 2;
            this.dateTuNgay.uDateTime = new System.DateTime(2013, 6, 19, 14, 14, 26, 937);
            this.dateTuNgay.uValue = new System.DateTime(2013, 6, 19, 14, 14, 26, 937);
            this.dateTuNgay.uEditValueChanged += new System.EventHandler(this.dateTuNgay_uEditValueChanged);
            // 
            // cbxPhanHe
            // 
            this.cbxPhanHe.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxPhanHe.iWidth = 60;
            this.cbxPhanHe.Location = new System.Drawing.Point(2, 44);
            this.cbxPhanHe.Name = "cbxPhanHe";
            this.cbxPhanHe.sCaption = "Phân hệ";
            this.cbxPhanHe.sColumnCaption = "Mã phân hệ,Tên phân hệ";
            this.cbxPhanHe.sField = "MAPHANHE,TENPHANHE";
            this.cbxPhanHe.Size = new System.Drawing.Size(234, 22);
            this.cbxPhanHe.TabIndex = 1;
            this.cbxPhanHe.uDisplayMember = "TENPHANHE";
            this.cbxPhanHe.uEditValue = null;
            this.cbxPhanHe.uValueMember = "MAPHANHE";
            this.cbxPhanHe.Load += new System.EventHandler(this.cbxPhanHe_Load);
            // 
            // cbxCoSo
            // 
            this.cbxCoSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxCoSo.iWidth = 60;
            this.cbxCoSo.Location = new System.Drawing.Point(2, 22);
            this.cbxCoSo.Name = "cbxCoSo";
            this.cbxCoSo.sCaption = "Cơ sở";
            this.cbxCoSo.sColumnCaption = "Mã cơ sở,Tên cơ sở";
            this.cbxCoSo.sField = "MaCoSo,TenCoSo";
            this.cbxCoSo.Size = new System.Drawing.Size(234, 22);
            this.cbxCoSo.TabIndex = 0;
            this.cbxCoSo.uDisplayMember = "TenCoSo";
            this.cbxCoSo.uEditValue = "";
            this.cbxCoSo.uTableName = "DM_COSO";
            this.cbxCoSo.uValueMember = "MaCoSo";
            // 
            // dtg
            // 
            this.dtg.bAllowEdit = true;
            this.dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(242, 0);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(796, 604);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 1;
            this.dtg.uDataSource = null;
            this.dtg.uDataSourceChanged += new System.EventHandler(this.dtg_uDataSourceChanged);
            this.dtg.uCellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.dtg_uCellValueChanged);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.menuMau1,
            this.menuMau2});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1038, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 604);
            this.barDockControlBottom.Size = new System.Drawing.Size(1038, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 604);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1038, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 604);
            // 
            // menuMau1
            // 
            this.menuMau1.Caption = "Mẫu 1";
            this.menuMau1.Id = 0;
            this.menuMau1.Name = "menuMau1";
            this.menuMau1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuMau1_ItemClick);
            // 
            // menuMau2
            // 
            this.menuMau2.Caption = "Mẫu 2";
            this.menuMau2.Id = 1;
            this.menuMau2.Name = "menuMau2";
            this.menuMau2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuMau2_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.menuMau1),
            new DevExpress.XtraBars.LinkPersistInfo(this.menuMau2)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // frmThuLaoGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 604);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmThuLaoGiangDay";
            this.Tag = "|THULAO|";
            this.Text = "Tổng hợp thù lao giảng dạy";
            this.Load += new System.EventHandler(this.frmThuLaoGiangDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BSC_HRM.NET.BSC_User_Control.uDataGrid dtg;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxCoSo;
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraEditors.SimpleButton btnLocDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnInDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxPhanHe;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private BSC_HRM.NET.BSC_User_Control.uDateTimePicker dateDenNgay;
        private BSC_HRM.NET.BSC_User_Control.uDateTimePicker dateTuNgay;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private BSC_HRM.NET.BSC_User_Control.uTextBox txtDonViNhan;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem menuMau1;
        private DevExpress.XtraBars.BarButtonItem menuMau2;
        private DevExpress.XtraEditors.SimpleButton btnTinhThuLao;
        private DevExpress.XtraEditors.SimpleButton btnXoaDong;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxNganHang;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxNoiDungChi;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private BSC_HRM.NET.BSC_User_Control.uDateTimePicker dtpNgayChungTu;
        private BSC_HRM.NET.BSC_User_Control.uTextBox txtSoChungTu;
    }
}