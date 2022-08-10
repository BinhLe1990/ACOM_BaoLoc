namespace DELFI_WHM.NET.SuKien
{
    partial class frmNhapDSSuKien 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapDSSuKien));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.pnMain = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabThongTinChinh = new DevExpress.XtraTab.XtraTabPage();
            this.dtDenNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker();
            this.dtTuNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker();
            this.txtDiaDiem = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtTenSuKien = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuThongTin = new DevExpress.XtraEditors.SimpleButton();
            this.dtg = new DELFI_WHM.NET.DELFI_User_Control.uDataGrid();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnQuaTrinhLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuaTrinhChucVu = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuaTrinhKhenThuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuaTrinhKyLuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuaTrinhDaoTao = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenCongTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiNanLaoDong = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.btnVanBang = new DevExpress.XtraBars.BarButtonItem();
            this.btnTangThamNienGD = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabThongTinChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.pnMain);
            this.splitContainerControl1.Panel2.Controls.Add(this.dtg);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1024, 550);
            this.splitContainerControl1.SplitterPosition = 176;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.xtraTabControl1);
            this.pnMain.Controls.Add(this.btnThoat);
            this.pnMain.Controls.Add(this.btnDel);
            this.pnMain.Controls.Add(this.btnLamLai);
            this.pnMain.Controls.Add(this.btnSua);
            this.pnMain.Controls.Add(this.btnSearch);
            this.pnMain.Controls.Add(this.btnLuuThongTin);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.FireScrollEventOnMouseWheel = true;
            this.pnMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1024, 176);
            this.pnMain.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 3);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabThongTinChinh;
            this.xtraTabControl1.Size = new System.Drawing.Size(1017, 142);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabThongTinChinh});
            // 
            // xtraTabThongTinChinh
            // 
            this.xtraTabThongTinChinh.AutoScroll = true;
            this.xtraTabThongTinChinh.Controls.Add(this.dtDenNgay);
            this.xtraTabThongTinChinh.Controls.Add(this.dtTuNgay);
            this.xtraTabThongTinChinh.Controls.Add(this.txtDiaDiem);
            this.xtraTabThongTinChinh.Controls.Add(this.txtTenSuKien);
            this.xtraTabThongTinChinh.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabThongTinChinh.Image")));
            this.xtraTabThongTinChinh.Name = "xtraTabThongTinChinh";
            this.xtraTabThongTinChinh.Size = new System.Drawing.Size(988, 136);
            this.xtraTabThongTinChinh.TabPageWidth = 100;
            this.xtraTabThongTinChinh.Text = "Thông tin SK";
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.Location = new System.Drawing.Point(510, 57);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.sCaption = "Đến ngày";
            this.dtDenNgay.Size = new System.Drawing.Size(260, 21);
            this.dtDenNgay.TabIndex = 17;
            this.dtDenNgay.Tag = "..NgayKetThuc";
            this.dtDenNgay.uDateTime = new System.DateTime(2015, 8, 12, 22, 47, 9, 551);
            this.dtDenNgay.uValue = new System.DateTime(2015, 8, 12, 22, 47, 9, 551);
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.Location = new System.Drawing.Point(511, 26);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.sCaption = "Từ ngày";
            this.dtTuNgay.Size = new System.Drawing.Size(260, 21);
            this.dtTuNgay.TabIndex = 16;
            this.dtTuNgay.Tag = "..NgayBatDau";
            this.dtTuNgay.uDateTime = new System.DateTime(2015, 8, 12, 22, 47, 9, 521);
            this.dtTuNgay.uValue = new System.DateTime(2015, 8, 12, 22, 47, 9, 521);
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtDiaDiem.Location = new System.Drawing.Point(35, 57);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.sCaption = "Địa điểm";
            this.txtDiaDiem.SelectionStart = 0;
            this.txtDiaDiem.Size = new System.Drawing.Size(451, 21);
            this.txtDiaDiem.TabIndex = 3;
            this.txtDiaDiem.Tag = "..DiaDiem";
            // 
            // txtTenSuKien
            // 
            this.txtTenSuKien.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtTenSuKien.Location = new System.Drawing.Point(35, 26);
            this.txtTenSuKien.Name = "txtTenSuKien";
            this.txtTenSuKien.sCaption = "Tên sự kiện";
            this.txtTenSuKien.SelectionStart = 0;
            this.txtTenSuKien.Size = new System.Drawing.Size(451, 21);
            this.txtTenSuKien.TabIndex = 2;
            this.txtTenSuKien.Tag = "..TenSuKien";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.ImageIndex = 1;
            this.btnThoat.ImageList = this.IML;
            this.btnThoat.Location = new System.Drawing.Point(904, 145);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 26);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Trở về";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.ImageIndex = 5;
            this.btnDel.ImageList = this.IML;
            this.btnDel.Location = new System.Drawing.Point(788, 145);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(110, 26);
            this.btnDel.TabIndex = 5;
            this.btnDel.Tag = "DEL";
            this.btnDel.Text = "Xóa sự kiện";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamLai.ImageIndex = 4;
            this.btnLamLai.ImageList = this.IML;
            this.btnLamLai.Location = new System.Drawing.Point(703, 145);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(79, 26);
            this.btnLamLai.TabIndex = 4;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.ImageIndex = 3;
            this.btnSua.ImageList = this.IML;
            this.btnSua.Location = new System.Drawing.Point(589, 145);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 26);
            this.btnSua.TabIndex = 3;
            this.btnSua.Tag = "EDIT";
            this.btnSua.Text = "Xem thông tin";
            this.btnSua.Click += new System.EventHandler(this.btnSuaHangHoa_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageList = this.IML;
            this.btnSearch.Location = new System.Drawing.Point(374, 145);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 26);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tra cứu thông tin";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLuuThongTin
            // 
            this.btnLuuThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuThongTin.ImageIndex = 6;
            this.btnLuuThongTin.ImageList = this.IML;
            this.btnLuuThongTin.Location = new System.Drawing.Point(493, 145);
            this.btnLuuThongTin.Name = "btnLuuThongTin";
            this.btnLuuThongTin.Size = new System.Drawing.Size(90, 26);
            this.btnLuuThongTin.TabIndex = 2;
            this.btnLuuThongTin.Tag = "ADD";
            this.btnLuuThongTin.Text = "Lưu";
            this.btnLuuThongTin.Click += new System.EventHandler(this.btnLuuThongTin_Click);
            // 
            // dtg
            // 
            this.dtg.bAllowEdit = true;
            this.dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(0, 0);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(1024, 369);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 0;
            this.dtg.uDataSource = null;
            this.dtg.uDataSourceChanged += new System.EventHandler(this.dtg_uDataSourceChanged);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnQuaTrinhLuong,
            this.btnQuaTrinhChucVu,
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnQuaTrinhKhenThuong,
            this.btnQuaTrinhKyLuat,
            this.btnQuaTrinhDaoTao,
            this.btnChuyenCongTac,
            this.btnTaiNanLaoDong,
            this.barButtonItem8,
            this.btnVanBang,
            this.btnTangThamNienGD});
            this.barManager1.MaxItemId = 12;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1024, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 550);
            this.barDockControlBottom.Size = new System.Drawing.Size(1024, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 550);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1024, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 550);
            // 
            // btnQuaTrinhLuong
            // 
            this.btnQuaTrinhLuong.Caption = "Quá trình lương";
            this.btnQuaTrinhLuong.Id = 0;
            this.btnQuaTrinhLuong.Name = "btnQuaTrinhLuong";
            // 
            // btnQuaTrinhChucVu
            // 
            this.btnQuaTrinhChucVu.Caption = "Quá trình chức vụ";
            this.btnQuaTrinhChucVu.Id = 1;
            this.btnQuaTrinhChucVu.Name = "btnQuaTrinhChucVu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Lịch sử bản thân";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Quá trình công tác";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnQuaTrinhKhenThuong
            // 
            this.btnQuaTrinhKhenThuong.Caption = "Quá trình khen thưởng";
            this.btnQuaTrinhKhenThuong.Id = 4;
            this.btnQuaTrinhKhenThuong.Name = "btnQuaTrinhKhenThuong";
            // 
            // btnQuaTrinhKyLuat
            // 
            this.btnQuaTrinhKyLuat.Caption = "Quá trình kỷ luật";
            this.btnQuaTrinhKyLuat.Id = 5;
            this.btnQuaTrinhKyLuat.Name = "btnQuaTrinhKyLuat";
            // 
            // btnQuaTrinhDaoTao
            // 
            this.btnQuaTrinhDaoTao.Caption = "Quá trình đào tạo";
            this.btnQuaTrinhDaoTao.Id = 6;
            this.btnQuaTrinhDaoTao.Name = "btnQuaTrinhDaoTao";
            // 
            // btnChuyenCongTac
            // 
            this.btnChuyenCongTac.Caption = "Quá trình chuyển công tác";
            this.btnChuyenCongTac.Id = 7;
            this.btnChuyenCongTac.Name = "btnChuyenCongTac";
            // 
            // btnTaiNanLaoDong
            // 
            this.btnTaiNanLaoDong.Caption = "Tai nạn lao động";
            this.btnTaiNanLaoDong.Id = 8;
            this.btnTaiNanLaoDong.Name = "btnTaiNanLaoDong";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Văn bằng - Chứng chì";
            this.barButtonItem8.Id = 9;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // btnVanBang
            // 
            this.btnVanBang.Caption = "Văn bằng - Chứng chỉ";
            this.btnVanBang.Id = 10;
            this.btnVanBang.Name = "btnVanBang";
            // 
            // btnTangThamNienGD
            // 
            this.btnTangThamNienGD.Caption = "Quá trình tăng thâm niên GD";
            this.btnTangThamNienGD.Id = 11;
            this.btnTangThamNienGD.Name = "btnTangThamNienGD";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnQuaTrinhLuong),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnQuaTrinhChucVu),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnQuaTrinhKhenThuong),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnQuaTrinhKyLuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnQuaTrinhDaoTao),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChuyenCongTac),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTangThamNienGD),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTaiNanLaoDong),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnVanBang)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // frmNhapDSSuKien
            // 
            this.AccessibleName = "Thông tin sự kiện";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 550);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhapDSSuKien";
            this.Tag = "|HS|";
            this.Text = "Thông tin sự kiện";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabThongTinChinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DELFI_WHM.NET.DELFI_User_Control.uDataGrid dtg;
        private DevExpress.XtraEditors.PanelControl pnMain;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabThongTinChinh;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnLamLai;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnLuuThongTin;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtTenSuKien;
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnQuaTrinhLuong;
        private DevExpress.XtraBars.BarButtonItem btnQuaTrinhChucVu;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnQuaTrinhKhenThuong;
        private DevExpress.XtraBars.BarButtonItem btnQuaTrinhKyLuat;
        private DevExpress.XtraBars.BarButtonItem btnQuaTrinhDaoTao;
        private DevExpress.XtraBars.BarButtonItem btnChuyenCongTac;
        private DevExpress.XtraBars.BarButtonItem btnTaiNanLaoDong;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem btnVanBang;
        private DevExpress.XtraBars.BarButtonItem btnTangThamNienGD;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtDiaDiem;
        private DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker dtDenNgay;
        private DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker dtTuNgay;
    }
}