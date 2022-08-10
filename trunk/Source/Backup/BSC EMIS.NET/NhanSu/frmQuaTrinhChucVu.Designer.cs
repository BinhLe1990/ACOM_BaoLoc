namespace BSC_HRM.NET.NhanSu
{
    partial class frmQuaTrinhChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuaTrinhChucVu));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.pnMain = new DevExpress.XtraEditors.PanelControl();
            this.uNhanSu1 = new BSC_HRM.NET.BSC_User_Control.uNhanSu();
            this.panelThongTin = new DevExpress.XtraEditors.PanelControl();
            this.radioChucVuChinh = new DevExpress.XtraEditors.RadioGroup();
            this.cboChucVu = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.uDateTimePicker2 = new BSC_HRM.NET.BSC_User_Control.uDateTimePicker();
            this.dtpNgayNhanChuc = new BSC_HRM.NET.BSC_User_Control.uDateTimePicker();
            this.txtHSCV = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.txtSoQuyetDinh = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.txtGhiChu = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.txtNguoiKy = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuHoSo = new DevExpress.XtraEditors.SimpleButton();
            this.dtg = new BSC_HRM.NET.BSC_User_Control.uDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelThongTin)).BeginInit();
            this.panelThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioChucVuChinh.Properties)).BeginInit();
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
            this.splitContainerControl1.Size = new System.Drawing.Size(561, 484);
            this.splitContainerControl1.SplitterPosition = 198;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.uNhanSu1);
            this.pnMain.Controls.Add(this.panelThongTin);
            this.pnMain.Controls.Add(this.btnThoat);
            this.pnMain.Controls.Add(this.btnDel);
            this.pnMain.Controls.Add(this.btnThemMoi);
            this.pnMain.Controls.Add(this.btnLuuHoSo);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.FireScrollEventOnMouseWheel = true;
            this.pnMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(561, 198);
            this.pnMain.TabIndex = 0;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMain_Paint);
            // 
            // uNhanSu1
            // 
            this.uNhanSu1.iNhanSuID = 0;
            this.uNhanSu1.Location = new System.Drawing.Point(5, 9);
            this.uNhanSu1.Name = "uNhanSu1";
            this.uNhanSu1.Size = new System.Drawing.Size(553, 50);
            this.uNhanSu1.sMaNhanSu = null;
            this.uNhanSu1.TabIndex = 76;
            // 
            // panelThongTin
            // 
            this.panelThongTin.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelThongTin.Controls.Add(this.radioChucVuChinh);
            this.panelThongTin.Controls.Add(this.cboChucVu);
            this.panelThongTin.Controls.Add(this.uDateTimePicker2);
            this.panelThongTin.Controls.Add(this.dtpNgayNhanChuc);
            this.panelThongTin.Controls.Add(this.txtHSCV);
            this.panelThongTin.Controls.Add(this.txtSoQuyetDinh);
            this.panelThongTin.Controls.Add(this.txtGhiChu);
            this.panelThongTin.Controls.Add(this.txtNguoiKy);
            this.panelThongTin.Location = new System.Drawing.Point(5, 61);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(553, 104);
            this.panelThongTin.TabIndex = 75;
            // 
            // radioChucVuChinh
            // 
            this.radioChucVuChinh.EditValue = 1;
            this.radioChucVuChinh.Location = new System.Drawing.Point(215, 51);
            this.radioChucVuChinh.Name = "radioChucVuChinh";
            this.radioChucVuChinh.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioChucVuChinh.Properties.Appearance.Options.UseBackColor = true;
            this.radioChucVuChinh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioChucVuChinh.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Kiêm nhiệm"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Chức vụ chính")});
            this.radioChucVuChinh.Size = new System.Drawing.Size(336, 23);
            this.radioChucVuChinh.TabIndex = 3;
            this.radioChucVuChinh.Tag = "..ChucVuChinh";
            // 
            // cboChucVu
            // 
            this.cboChucVu.iWidth = 70;
            this.cboChucVu.Location = new System.Drawing.Point(5, 4);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.sCaption = "Chức vụ";
            this.cboChucVu.sField = null;
            this.cboChucVu.Size = new System.Drawing.Size(204, 21);
            this.cboChucVu.TabIndex = 2;
            this.cboChucVu.Tag = "..MaChucVu";
            this.cboChucVu.uDisplayMember = "TenChucVu";
            this.cboChucVu.uEditValue = "";
            this.cboChucVu.uTableName = "DM_ChucVu";
            this.cboChucVu.uValueMember = "MaChucVu";
            // 
            // uDateTimePicker2
            // 
            this.uDateTimePicker2.Location = new System.Drawing.Point(215, 27);
            this.uDateTimePicker2.Name = "uDateTimePicker2";
            this.uDateTimePicker2.sCaption = "Ngày quyết định";
            this.uDateTimePicker2.Size = new System.Drawing.Size(235, 21);
            this.uDateTimePicker2.TabIndex = 1;
            this.uDateTimePicker2.Tag = "..NgayQuyetDinh";
            this.uDateTimePicker2.uDateTime = new System.DateTime(2013, 3, 13, 11, 0, 23, 636);
            this.uDateTimePicker2.uValue = new System.DateTime(2013, 3, 13, 11, 0, 23, 636);
            // 
            // dtpNgayNhanChuc
            // 
            this.dtpNgayNhanChuc.Location = new System.Drawing.Point(215, 4);
            this.dtpNgayNhanChuc.Name = "dtpNgayNhanChuc";
            this.dtpNgayNhanChuc.sCaption = "Ngày nhận chức";
            this.dtpNgayNhanChuc.Size = new System.Drawing.Size(235, 21);
            this.dtpNgayNhanChuc.TabIndex = 1;
            this.dtpNgayNhanChuc.Tag = "..NgayNhanChuc";
            this.dtpNgayNhanChuc.uDateTime = new System.DateTime(2013, 3, 13, 11, 0, 23, 639);
            this.dtpNgayNhanChuc.uValue = new System.DateTime(2013, 3, 13, 11, 0, 23, 639);
            // 
            // txtHSCV
            // 
            this.txtHSCV.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtHSCV.iWidth = 30;
            this.txtHSCV.Location = new System.Drawing.Point(456, 27);
            this.txtHSCV.Name = "txtHSCV";
            this.txtHSCV.sCaption = "HSCV";
            this.txtHSCV.sEditMask = "N2";
            this.txtHSCV.SelectionStart = 0;
            this.txtHSCV.Size = new System.Drawing.Size(95, 20);
            this.txtHSCV.TabIndex = 0;
            this.txtHSCV.Tag = "..HSCV";
            this.txtHSCV.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            // 
            // txtSoQuyetDinh
            // 
            this.txtSoQuyetDinh.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtSoQuyetDinh.iWidth = 70;
            this.txtSoQuyetDinh.Location = new System.Drawing.Point(6, 28);
            this.txtSoQuyetDinh.Name = "txtSoQuyetDinh";
            this.txtSoQuyetDinh.sCaption = "Số quyết định";
            this.txtSoQuyetDinh.SelectionStart = 0;
            this.txtSoQuyetDinh.Size = new System.Drawing.Size(203, 20);
            this.txtSoQuyetDinh.TabIndex = 0;
            this.txtSoQuyetDinh.Tag = "..SoQuyetDinh";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtGhiChu.iWidth = 70;
            this.txtGhiChu.Location = new System.Drawing.Point(5, 76);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.sCaption = "Ghi chú";
            this.txtGhiChu.SelectionStart = 0;
            this.txtGhiChu.Size = new System.Drawing.Size(546, 20);
            this.txtGhiChu.TabIndex = 0;
            this.txtGhiChu.Tag = "..GhiChu";
            // 
            // txtNguoiKy
            // 
            this.txtNguoiKy.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtNguoiKy.iWidth = 70;
            this.txtNguoiKy.Location = new System.Drawing.Point(6, 52);
            this.txtNguoiKy.Name = "txtNguoiKy";
            this.txtNguoiKy.sCaption = "Người ký";
            this.txtNguoiKy.SelectionStart = 0;
            this.txtNguoiKy.Size = new System.Drawing.Size(203, 20);
            this.txtNguoiKy.TabIndex = 0;
            this.txtNguoiKy.Tag = "..NguoiKy";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.ImageIndex = 1;
            this.btnThoat.ImageList = this.IML;
            this.btnThoat.Location = new System.Drawing.Point(448, 168);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 26);
            this.btnThoat.TabIndex = 73;
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
            this.btnDel.Location = new System.Drawing.Point(352, 168);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(90, 26);
            this.btnDel.TabIndex = 70;
            this.btnDel.Tag = "DEL";
            this.btnDel.Text = "Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoi.ImageIndex = 4;
            this.btnThemMoi.ImageList = this.IML;
            this.btnThemMoi.Location = new System.Drawing.Point(171, 168);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(79, 26);
            this.btnThemMoi.TabIndex = 69;
            this.btnThemMoi.Tag = "ADD";
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnLuuHoSo
            // 
            this.btnLuuHoSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuHoSo.ImageIndex = 6;
            this.btnLuuHoSo.ImageList = this.IML;
            this.btnLuuHoSo.Location = new System.Drawing.Point(256, 168);
            this.btnLuuHoSo.Name = "btnLuuHoSo";
            this.btnLuuHoSo.Size = new System.Drawing.Size(90, 26);
            this.btnLuuHoSo.TabIndex = 67;
            this.btnLuuHoSo.Tag = "EDIT";
            this.btnLuuHoSo.Text = "Lưu";
            this.btnLuuHoSo.Click += new System.EventHandler(this.btnLuuHoSo_Click);
            // 
            // dtg
            // 
            this.dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(0, 0);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(561, 281);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 0;
            this.dtg.uDataSource = null;
            this.dtg.uDoubleClick += new System.EventHandler(this.dtg_uDoubleClick);
            // 
            // frmQuaTrinhChucVu
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 484);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuaTrinhChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "|HS|";
            this.Text = "Quá trình chức vụ";
            this.Load += new System.EventHandler(this.frmQuaTrinhChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelThongTin)).EndInit();
            this.panelThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioChucVuChinh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private BSC_HRM.NET.BSC_User_Control.uDataGrid dtg;
        private DevExpress.XtraEditors.PanelControl pnMain;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.SimpleButton btnLuuHoSo;
        private System.Windows.Forms.ImageList IML;       
        private DevExpress.XtraEditors.PanelControl panelThongTin;
        private DevExpress.XtraEditors.RadioGroup radioChucVuChinh;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cboChucVu;
        private BSC_HRM.NET.BSC_User_Control.uDateTimePicker uDateTimePicker2;
        private BSC_HRM.NET.BSC_User_Control.uDateTimePicker dtpNgayNhanChuc;
        private BSC_HRM.NET.BSC_User_Control.uTextBox txtSoQuyetDinh;
        private BSC_HRM.NET.BSC_User_Control.uTextBox txtGhiChu;
        private BSC_HRM.NET.BSC_User_Control.uTextBox txtNguoiKy;
        private BSC_HRM.NET.BSC_User_Control.uTextBox txtHSCV;
        private BSC_HRM.NET.BSC_User_Control.uNhanSu uNhanSu1;
    }
}