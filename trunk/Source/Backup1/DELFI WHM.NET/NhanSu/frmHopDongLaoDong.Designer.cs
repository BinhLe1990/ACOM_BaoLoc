namespace DELFI_WHM.NET.NhanSu
{
    partial class frmHopDongLaoDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDongLaoDong));
            this.panelButton = new DevExpress.XtraEditors.PanelControl();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            this.grpHopDong = new DevExpress.XtraEditors.GroupControl();
            this.txtPhuCap = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtCheDoDaoTao = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtTienThuong = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtHinhThucTraLuong = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtPhuongTienDiLai = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.cboLoaiHD = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.txtBoiThuong = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtThoaThuanKhac = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtTrangbi = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtCheDoNghiNgoi = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtCheDoNangLuong = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtNgayTraLuong = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtMucLuongChinh = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtDungCuLamViec = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtCongViecPhaiLam = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtNgheNghiep = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtDiaDiemLamViec = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtThoiGianLamViec = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.dtpDenNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker();
            this.dtpTuNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker();
            this.txtNoiKy = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.dtpNgayHieuLuc = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker();
            this.dtpNgayKy = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker();
            this.txtSoHD = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.uNhanSu1 = new DELFI_WHM.NET.DELFI_User_Control.uNhanSu();
            ((System.ComponentModel.ISupportInitialize)(this.panelButton)).BeginInit();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpHopDong)).BeginInit();
            this.grpHopDong.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnThemMoi);
            this.panelButton.Controls.Add(this.btnCapNhat);
            this.panelButton.Controls.Add(this.btnIn);
            this.panelButton.Controls.Add(this.btnXoa);
            this.panelButton.Controls.Add(this.btnThoat);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 372);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(594, 27);
            this.panelButton.TabIndex = 0;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThemMoi.ImageIndex = 4;
            this.btnThemMoi.ImageList = this.IML;
            this.btnThemMoi.Location = new System.Drawing.Point(164, 2);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 0;
            this.btnThemMoi.Tag = "ADD";
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
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
            // btnCapNhat
            // 
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCapNhat.ImageIndex = 6;
            this.btnCapNhat.ImageList = this.IML;
            this.btnCapNhat.Location = new System.Drawing.Point(239, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(88, 23);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Tag = "EDIT";
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIn.ImageIndex = 8;
            this.btnIn.ImageList = this.IML;
            this.btnIn.Location = new System.Drawing.Point(327, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(107, 23);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In hợp đồng";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXoa.ImageIndex = 5;
            this.btnXoa.ImageList = this.IML;
            this.btnXoa.Location = new System.Drawing.Point(434, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Tag = "DEL";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThoat.ImageIndex = 1;
            this.btnThoat.ImageList = this.IML;
            this.btnThoat.Location = new System.Drawing.Point(509, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.grpHopDong);
            this.panelMain.Controls.Add(this.uNhanSu1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(594, 372);
            this.panelMain.TabIndex = 1;
            // 
            // grpHopDong
            // 
            this.grpHopDong.Controls.Add(this.txtPhuCap);
            this.grpHopDong.Controls.Add(this.txtCheDoDaoTao);
            this.grpHopDong.Controls.Add(this.txtTienThuong);
            this.grpHopDong.Controls.Add(this.txtHinhThucTraLuong);
            this.grpHopDong.Controls.Add(this.txtPhuongTienDiLai);
            this.grpHopDong.Controls.Add(this.cboLoaiHD);
            this.grpHopDong.Controls.Add(this.txtBoiThuong);
            this.grpHopDong.Controls.Add(this.txtThoaThuanKhac);
            this.grpHopDong.Controls.Add(this.txtTrangbi);
            this.grpHopDong.Controls.Add(this.txtCheDoNghiNgoi);
            this.grpHopDong.Controls.Add(this.txtCheDoNangLuong);
            this.grpHopDong.Controls.Add(this.txtNgayTraLuong);
            this.grpHopDong.Controls.Add(this.txtMucLuongChinh);
            this.grpHopDong.Controls.Add(this.txtDungCuLamViec);
            this.grpHopDong.Controls.Add(this.txtCongViecPhaiLam);
            this.grpHopDong.Controls.Add(this.txtNgheNghiep);
            this.grpHopDong.Controls.Add(this.txtDiaDiemLamViec);
            this.grpHopDong.Controls.Add(this.txtThoiGianLamViec);
            this.grpHopDong.Controls.Add(this.dtpDenNgay);
            this.grpHopDong.Controls.Add(this.dtpTuNgay);
            this.grpHopDong.Controls.Add(this.txtNoiKy);
            this.grpHopDong.Controls.Add(this.dtpNgayHieuLuc);
            this.grpHopDong.Controls.Add(this.dtpNgayKy);
            this.grpHopDong.Controls.Add(this.txtSoHD);
            this.grpHopDong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpHopDong.Location = new System.Drawing.Point(2, 50);
            this.grpHopDong.Name = "grpHopDong";
            this.grpHopDong.Size = new System.Drawing.Size(590, 320);
            this.grpHopDong.TabIndex = 2;
            this.grpHopDong.Text = "THÔNG TIN HỢP ĐỒNG";
            // 
            // txtPhuCap
            // 
            this.txtPhuCap.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtPhuCap.iWidth = 108;
            this.txtPhuCap.Location = new System.Drawing.Point(303, 172);
            this.txtPhuCap.Name = "txtPhuCap";
            this.txtPhuCap.sCaption = "Phụ cấp";
            this.txtPhuCap.SelectionStart = 0;
            this.txtPhuCap.Size = new System.Drawing.Size(282, 20);
            this.txtPhuCap.TabIndex = 9;
            this.txtPhuCap.Tag = "..PhuCap";
            // 
            // txtCheDoDaoTao
            // 
            this.txtCheDoDaoTao.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtCheDoDaoTao.iWidth = 108;
            this.txtCheDoDaoTao.Location = new System.Drawing.Point(303, 235);
            this.txtCheDoDaoTao.Name = "txtCheDoDaoTao";
            this.txtCheDoDaoTao.sCaption = "Chế độ đào tạo";
            this.txtCheDoDaoTao.SelectionStart = 0;
            this.txtCheDoDaoTao.Size = new System.Drawing.Size(282, 20);
            this.txtCheDoDaoTao.TabIndex = 9;
            this.txtCheDoDaoTao.Tag = "..CheDoDaoTao";
            // 
            // txtTienThuong
            // 
            this.txtTienThuong.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtTienThuong.iWidth = 108;
            this.txtTienThuong.Location = new System.Drawing.Point(303, 214);
            this.txtTienThuong.Name = "txtTienThuong";
            this.txtTienThuong.sCaption = "Tiền thưởng";
            this.txtTienThuong.SelectionStart = 0;
            this.txtTienThuong.Size = new System.Drawing.Size(282, 20);
            this.txtTienThuong.TabIndex = 9;
            this.txtTienThuong.Tag = "..TienThuong";
            // 
            // txtHinhThucTraLuong
            // 
            this.txtHinhThucTraLuong.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtHinhThucTraLuong.iWidth = 108;
            this.txtHinhThucTraLuong.Location = new System.Drawing.Point(303, 193);
            this.txtHinhThucTraLuong.Name = "txtHinhThucTraLuong";
            this.txtHinhThucTraLuong.sCaption = "Hình thức trả lương";
            this.txtHinhThucTraLuong.SelectionStart = 0;
            this.txtHinhThucTraLuong.Size = new System.Drawing.Size(282, 20);
            this.txtHinhThucTraLuong.TabIndex = 9;
            this.txtHinhThucTraLuong.Tag = "..HinhThucTraLuong";
            // 
            // txtPhuongTienDiLai
            // 
            this.txtPhuongTienDiLai.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtPhuongTienDiLai.iWidth = 108;
            this.txtPhuongTienDiLai.Location = new System.Drawing.Point(303, 130);
            this.txtPhuongTienDiLai.Name = "txtPhuongTienDiLai";
            this.txtPhuongTienDiLai.sCaption = "Phương tiện đi lại";
            this.txtPhuongTienDiLai.SelectionStart = 0;
            this.txtPhuongTienDiLai.Size = new System.Drawing.Size(282, 20);
            this.txtPhuongTienDiLai.TabIndex = 9;
            this.txtPhuongTienDiLai.Tag = "..PhuongTienDiLai";
            // 
            // cboLoaiHD
            // 
            this.cboLoaiHD.iWidth = 95;
            this.cboLoaiHD.Location = new System.Drawing.Point(6, 130);
            this.cboLoaiHD.Name = "cboLoaiHD";
            this.cboLoaiHD.sCaption = "Loại hợp đồng";
            this.cboLoaiHD.sColumnCaption = "Mã loại,Tên";
            this.cboLoaiHD.sField = "MAHD_LAODONG,TENHD_LAODONG";
            this.cboLoaiHD.Size = new System.Drawing.Size(294, 21);
            this.cboLoaiHD.TabIndex = 8;
            this.cboLoaiHD.Tag = "..HD_LaoDong";
            this.cboLoaiHD.uDisplayMember = "TENHD_LAODONG";
            this.cboLoaiHD.uEditValue = null;
            this.cboLoaiHD.uTableName = "DM_HD_LAODONG";
            this.cboLoaiHD.uValueMember = "MAHD_LAODONG";
            // 
            // txtBoiThuong
            // 
            this.txtBoiThuong.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtBoiThuong.iWidth = 95;
            this.txtBoiThuong.Location = new System.Drawing.Point(6, 298);
            this.txtBoiThuong.Name = "txtBoiThuong";
            this.txtBoiThuong.sCaption = "Bồi thường vi phạm";
            this.txtBoiThuong.SelectionStart = 0;
            this.txtBoiThuong.Size = new System.Drawing.Size(579, 20);
            this.txtBoiThuong.TabIndex = 7;
            this.txtBoiThuong.Tag = "..BoiThuongViPham";
            // 
            // txtThoaThuanKhac
            // 
            this.txtThoaThuanKhac.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtThoaThuanKhac.iWidth = 95;
            this.txtThoaThuanKhac.Location = new System.Drawing.Point(6, 277);
            this.txtThoaThuanKhac.Name = "txtThoaThuanKhac";
            this.txtThoaThuanKhac.sCaption = "Thỏa thuận khác";
            this.txtThoaThuanKhac.SelectionStart = 0;
            this.txtThoaThuanKhac.Size = new System.Drawing.Size(579, 20);
            this.txtThoaThuanKhac.TabIndex = 7;
            this.txtThoaThuanKhac.Tag = "..ThaoThuanKhac";
            // 
            // txtTrangbi
            // 
            this.txtTrangbi.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtTrangbi.iWidth = 95;
            this.txtTrangbi.Location = new System.Drawing.Point(6, 256);
            this.txtTrangbi.Name = "txtTrangbi";
            this.txtTrangbi.sCaption = "Trang bị bảo hộ LĐ";
            this.txtTrangbi.SelectionStart = 0;
            this.txtTrangbi.Size = new System.Drawing.Size(579, 20);
            this.txtTrangbi.TabIndex = 7;
            this.txtTrangbi.Tag = "..TrangBiBaoHo";
            // 
            // txtCheDoNghiNgoi
            // 
            this.txtCheDoNghiNgoi.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtCheDoNghiNgoi.iWidth = 95;
            this.txtCheDoNghiNgoi.Location = new System.Drawing.Point(6, 235);
            this.txtCheDoNghiNgoi.Name = "txtCheDoNghiNgoi";
            this.txtCheDoNghiNgoi.sCaption = "Chế độ nghỉ ngơi";
            this.txtCheDoNghiNgoi.SelectionStart = 0;
            this.txtCheDoNghiNgoi.Size = new System.Drawing.Size(294, 20);
            this.txtCheDoNghiNgoi.TabIndex = 7;
            this.txtCheDoNghiNgoi.Tag = "..CheDoNghiNgoi";
            // 
            // txtCheDoNangLuong
            // 
            this.txtCheDoNangLuong.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtCheDoNangLuong.iWidth = 95;
            this.txtCheDoNangLuong.Location = new System.Drawing.Point(6, 214);
            this.txtCheDoNangLuong.Name = "txtCheDoNangLuong";
            this.txtCheDoNangLuong.sCaption = "Chế độ nâng lương";
            this.txtCheDoNangLuong.SelectionStart = 0;
            this.txtCheDoNangLuong.Size = new System.Drawing.Size(294, 20);
            this.txtCheDoNangLuong.TabIndex = 7;
            this.txtCheDoNangLuong.Tag = "..CheDoNangLuong";
            // 
            // txtNgayTraLuong
            // 
            this.txtNgayTraLuong.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtNgayTraLuong.iWidth = 95;
            this.txtNgayTraLuong.Location = new System.Drawing.Point(6, 193);
            this.txtNgayTraLuong.Name = "txtNgayTraLuong";
            this.txtNgayTraLuong.sCaption = "Ngày trả lương";
            this.txtNgayTraLuong.SelectionStart = 0;
            this.txtNgayTraLuong.Size = new System.Drawing.Size(294, 20);
            this.txtNgayTraLuong.TabIndex = 7;
            this.txtNgayTraLuong.Tag = "..NgayTraLuong";
            // 
            // txtMucLuongChinh
            // 
            this.txtMucLuongChinh.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtMucLuongChinh.iWidth = 95;
            this.txtMucLuongChinh.Location = new System.Drawing.Point(6, 172);
            this.txtMucLuongChinh.Name = "txtMucLuongChinh";
            this.txtMucLuongChinh.sCaption = "Mức lương chính";
            this.txtMucLuongChinh.SelectionStart = 0;
            this.txtMucLuongChinh.Size = new System.Drawing.Size(294, 20);
            this.txtMucLuongChinh.TabIndex = 7;
            this.txtMucLuongChinh.Tag = "..MucLuongChinh";
            // 
            // txtDungCuLamViec
            // 
            this.txtDungCuLamViec.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtDungCuLamViec.iWidth = 95;
            this.txtDungCuLamViec.Location = new System.Drawing.Point(6, 151);
            this.txtDungCuLamViec.Name = "txtDungCuLamViec";
            this.txtDungCuLamViec.sCaption = "Dụng cụ làm việc";
            this.txtDungCuLamViec.SelectionStart = 0;
            this.txtDungCuLamViec.Size = new System.Drawing.Size(579, 20);
            this.txtDungCuLamViec.TabIndex = 7;
            this.txtDungCuLamViec.Tag = "..DungCuLamViec";
            // 
            // txtCongViecPhaiLam
            // 
            this.txtCongViecPhaiLam.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtCongViecPhaiLam.iWidth = 95;
            this.txtCongViecPhaiLam.Location = new System.Drawing.Point(6, 109);
            this.txtCongViecPhaiLam.Name = "txtCongViecPhaiLam";
            this.txtCongViecPhaiLam.sCaption = "Công việc phải làm";
            this.txtCongViecPhaiLam.SelectionStart = 0;
            this.txtCongViecPhaiLam.Size = new System.Drawing.Size(579, 20);
            this.txtCongViecPhaiLam.TabIndex = 7;
            this.txtCongViecPhaiLam.Tag = "..CongViecPhaiLam";
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtNgheNghiep.iWidth = 85;
            this.txtNgheNghiep.Location = new System.Drawing.Point(413, 88);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.sCaption = "Nghề nghiệp";
            this.txtNgheNghiep.SelectionStart = 0;
            this.txtNgheNghiep.Size = new System.Drawing.Size(172, 20);
            this.txtNgheNghiep.TabIndex = 6;
            this.txtNgheNghiep.Tag = "..NgheNghiep";
            // 
            // txtDiaDiemLamViec
            // 
            this.txtDiaDiemLamViec.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtDiaDiemLamViec.iWidth = 95;
            this.txtDiaDiemLamViec.Location = new System.Drawing.Point(6, 88);
            this.txtDiaDiemLamViec.Name = "txtDiaDiemLamViec";
            this.txtDiaDiemLamViec.sCaption = "Địa điểm làm việc";
            this.txtDiaDiemLamViec.SelectionStart = 0;
            this.txtDiaDiemLamViec.Size = new System.Drawing.Size(405, 20);
            this.txtDiaDiemLamViec.TabIndex = 6;
            this.txtDiaDiemLamViec.Tag = "..DiaDiemLamViec";
            // 
            // txtThoiGianLamViec
            // 
            this.txtThoiGianLamViec.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtThoiGianLamViec.iWidth = 85;
            this.txtThoiGianLamViec.Location = new System.Drawing.Point(413, 67);
            this.txtThoiGianLamViec.Name = "txtThoiGianLamViec";
            this.txtThoiGianLamViec.sCaption = "Thời gian làm việc";
            this.txtThoiGianLamViec.SelectionStart = 0;
            this.txtThoiGianLamViec.Size = new System.Drawing.Size(172, 20);
            this.txtThoiGianLamViec.TabIndex = 5;
            this.txtThoiGianLamViec.Tag = "..ThoiGianLamViec";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.iWidth = 60;
            this.dtpDenNgay.Location = new System.Drawing.Point(237, 67);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.sCaption = "Đến ngày";
            this.dtpDenNgay.Size = new System.Drawing.Size(174, 21);
            this.dtpDenNgay.TabIndex = 4;
            this.dtpDenNgay.Tag = "..DenNgay";
            this.dtpDenNgay.uDateTime = new System.DateTime(2013, 3, 13, 10, 59, 2, 941);
            this.dtpDenNgay.uValue = new System.DateTime(2013, 3, 13, 10, 59, 2, 941);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.iWidth = 95;
            this.dtpTuNgay.Location = new System.Drawing.Point(6, 67);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.sCaption = "Từ ngày";
            this.dtpTuNgay.Size = new System.Drawing.Size(227, 21);
            this.dtpTuNgay.TabIndex = 4;
            this.dtpTuNgay.Tag = "..TuNgay";
            this.dtpTuNgay.uDateTime = new System.DateTime(2013, 3, 13, 10, 59, 2, 944);
            this.dtpTuNgay.uValue = new System.DateTime(2013, 3, 13, 10, 59, 2, 944);
            // 
            // txtNoiKy
            // 
            this.txtNoiKy.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtNoiKy.iWidth = 95;
            this.txtNoiKy.Location = new System.Drawing.Point(6, 46);
            this.txtNoiKy.Name = "txtNoiKy";
            this.txtNoiKy.sCaption = "Nơi ký";
            this.txtNoiKy.SelectionStart = 0;
            this.txtNoiKy.Size = new System.Drawing.Size(579, 20);
            this.txtNoiKy.TabIndex = 3;
            this.txtNoiKy.Tag = "..NoiKy";
            // 
            // dtpNgayHieuLuc
            // 
            this.dtpNgayHieuLuc.iWidth = 70;
            this.dtpNgayHieuLuc.Location = new System.Drawing.Point(413, 25);
            this.dtpNgayHieuLuc.Name = "dtpNgayHieuLuc";
            this.dtpNgayHieuLuc.sCaption = "Ngày hiệu lực";
            this.dtpNgayHieuLuc.Size = new System.Drawing.Size(172, 21);
            this.dtpNgayHieuLuc.TabIndex = 2;
            this.dtpNgayHieuLuc.Tag = "..NgayHieuLuc";
            this.dtpNgayHieuLuc.uDateTime = new System.DateTime(2013, 3, 13, 10, 59, 2, 949);
            this.dtpNgayHieuLuc.uValue = new System.DateTime(2013, 3, 13, 10, 59, 2, 949);
            // 
            // dtpNgayKy
            // 
            this.dtpNgayKy.iWidth = 60;
            this.dtpNgayKy.Location = new System.Drawing.Point(237, 25);
            this.dtpNgayKy.Name = "dtpNgayKy";
            this.dtpNgayKy.sCaption = "Ngày ký";
            this.dtpNgayKy.Size = new System.Drawing.Size(174, 21);
            this.dtpNgayKy.TabIndex = 2;
            this.dtpNgayKy.Tag = "..NgayKy";
            this.dtpNgayKy.uDateTime = new System.DateTime(2013, 3, 13, 10, 59, 2, 952);
            this.dtpNgayKy.uValue = new System.DateTime(2013, 3, 13, 10, 59, 2, 952);
            // 
            // txtSoHD
            // 
            this.txtSoHD.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtSoHD.iWidth = 95;
            this.txtSoHD.Location = new System.Drawing.Point(6, 25);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.sCaption = "Số hợp đồng";
            this.txtSoHD.SelectionStart = 0;
            this.txtSoHD.Size = new System.Drawing.Size(227, 20);
            this.txtSoHD.TabIndex = 1;
            this.txtSoHD.Tag = "..SoHopDong";
            this.txtSoHD.uKeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoHD_uKeyDown);
            this.txtSoHD.uValidated += new System.EventHandler(this.txtSoHD_uValidated);
            // 
            // uNhanSu1
            // 
            this.uNhanSu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uNhanSu1.iNhanSuID = 0;
            this.uNhanSu1.Location = new System.Drawing.Point(2, 2);
            this.uNhanSu1.Name = "uNhanSu1";
            this.uNhanSu1.Size = new System.Drawing.Size(590, 50);
            this.uNhanSu1.sMaNhanSu = null;
            this.uNhanSu1.TabIndex = 0;
            this.uNhanSu1.Load += new System.EventHandler(this.uNhanSu1_Load);
            this.uNhanSu1.uClick += new System.EventHandler(this.uNhanSu1_uClick);
            // 
            // frmHopDongLaoDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 399);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHopDongLaoDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "|HS|";
            this.Text = "Hợp đồng lao động";
            ((System.ComponentModel.ISupportInitialize)(this.panelButton)).EndInit();
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpHopDong)).EndInit();
            this.grpHopDong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelButton;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.PanelControl panelMain;
        private DELFI_WHM.NET.DELFI_User_Control.uNhanSu uNhanSu1;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtSoHD;
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.GroupControl grpHopDong;
        private DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker dtpTuNgay;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtNoiKy;
        private DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker dtpNgayHieuLuc;
        private DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker dtpNgayKy;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtCongViecPhaiLam;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtNgheNghiep;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtDiaDiemLamViec;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtThoiGianLamViec;
        private DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker dtpDenNgay;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtPhuongTienDiLai;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cboLoaiHD;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtPhuCap;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtMucLuongChinh;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtDungCuLamViec;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtHinhThucTraLuong;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtCheDoDaoTao;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtTienThuong;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtTrangbi;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtCheDoNghiNgoi;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtCheDoNangLuong;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtBoiThuong;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtThoaThuanKhac;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtNgayTraLuong;

    }
}