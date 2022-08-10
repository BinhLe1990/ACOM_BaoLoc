namespace BSC_HRM.NET.BSC_User_Control
{
    partial class uLop
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpMain = new DevExpress.XtraEditors.GroupControl();
            this.cbxHocKy = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.txtNamHoc = new BSC_HRM.NET.BSC_User_Control.BSCEmisNamHoc();
            this.cbxLop = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxChuyenNganh = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxNganh = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxKhoaHoc = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxBac = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxKhoa = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxLoaiDaoTao = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.ErrPrvd = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnReset = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).BeginInit();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPrvd)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMain.AppearanceCaption.Options.UseBackColor = true;
            this.grpMain.AppearanceCaption.Options.UseFont = true;
            this.grpMain.AppearanceCaption.Options.UseTextOptions = true;
            this.grpMain.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grpMain.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.grpMain.Controls.Add(this.cbxHocKy);
            this.grpMain.Controls.Add(this.txtNamHoc);
            this.grpMain.Controls.Add(this.cbxLop);
            this.grpMain.Controls.Add(this.cbxChuyenNganh);
            this.grpMain.Controls.Add(this.cbxNganh);
            this.grpMain.Controls.Add(this.cbxKhoaHoc);
            this.grpMain.Controls.Add(this.cbxBac);
            this.grpMain.Controls.Add(this.cbxKhoa);
            this.grpMain.Controls.Add(this.cbxLoaiDaoTao);
            this.grpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMain.FireScrollEventOnMouseWheel = true;
            this.grpMain.Location = new System.Drawing.Point(0, 0);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(215, 404);
            this.grpMain.TabIndex = 0;
            this.grpMain.Text = "ĐIỀU KIỆN TÌM KIẾM";
            this.grpMain.Click += new System.EventHandler(this.grpMain_Click);
            this.grpMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uLop_MouseDown);
            // 
            // cbxHocKy
            // 
            this.cbxHocKy.bLabelTopDock = true;
            this.cbxHocKy.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxHocKy.iWidth = 211;
            this.cbxHocKy.Location = new System.Drawing.Point(2, 350);
            this.cbxHocKy.Name = "cbxHocKy";
            this.cbxHocKy.sCaption = "Học kỳ";
            this.cbxHocKy.sColumnCaption = "Mã học kỳ, Tên học kỳ";
            this.cbxHocKy.sField = "HocKy, TenHocKy";
            this.cbxHocKy.Size = new System.Drawing.Size(211, 41);
            this.cbxHocKy.TabIndex = 8;
            this.cbxHocKy.uDisplayMember = "TenHocKy";
            this.cbxHocKy.uEditValue = "";
            this.cbxHocKy.uTableName = "DM_HocKy";
            this.cbxHocKy.uValueMember = "HocKy";
            this.cbxHocKy.Visible = false;
            this.cbxHocKy.uEditValueChanged += new System.EventHandler(this.cbxHocKy_uEditValueChanged);
            this.cbxHocKy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uLop_MouseDown);
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.bHAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtNamHoc.bLabelTopDock = true;
            this.txtNamHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNamHoc.iWidth = 211;
            this.txtNamHoc.iYear = 2009;
            this.txtNamHoc.Location = new System.Drawing.Point(2, 309);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.sCaption = "Năm học";
            this.txtNamHoc.Size = new System.Drawing.Size(211, 41);
            this.txtNamHoc.TabIndex = 7;
            this.txtNamHoc.Visible = false;
            this.txtNamHoc.uEditValueChanged += new System.EventHandler(this.txtNamHoc_uEditValueChanged);
            this.txtNamHoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uLop_MouseDown);
            // 
            // cbxLop
            // 
            this.cbxLop.bLabelTopDock = true;
            this.cbxLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxLop.iWidth = 211;
            this.cbxLop.Location = new System.Drawing.Point(2, 268);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.sCaption = "Lớp";
            this.cbxLop.sColumnCaption = "Mã lớp học, Tên lớp học, Quy chế";
            this.cbxLop.sField = "MaLopHoc, TenLopHoc, MaQuyChe";
            this.cbxLop.Size = new System.Drawing.Size(211, 41);
            this.cbxLop.TabIndex = 6;
            this.cbxLop.uDisplayMember = null;
            this.cbxLop.uEditValue = "";
            this.cbxLop.uValueMember = null;
            this.cbxLop.uLeave += new System.EventHandler(this.cbxLop_uLeave);
            this.cbxLop.uValidated += new System.EventHandler(this.cbxLop_uValidated);
            this.cbxLop.uEditValueChanged += new System.EventHandler(this.cbxLop_uEditValueChanged);
            this.cbxLop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uLop_MouseDown);
            this.cbxLop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxLop_KeyDown);
            // 
            // cbxChuyenNganh
            // 
            this.cbxChuyenNganh.bLabelTopDock = true;
            this.cbxChuyenNganh.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxChuyenNganh.iWidth = 211;
            this.cbxChuyenNganh.Location = new System.Drawing.Point(2, 227);
            this.cbxChuyenNganh.Name = "cbxChuyenNganh";
            this.cbxChuyenNganh.sCaption = "Chuyên ngành";
            this.cbxChuyenNganh.sColumnCaption = "Mã chuyên ngành, Tên chuyên ngành";
            this.cbxChuyenNganh.sField = "MaChuyenNganh, TenChuyenNganh";
            this.cbxChuyenNganh.Size = new System.Drawing.Size(211, 41);
            this.cbxChuyenNganh.TabIndex = 5;
            this.cbxChuyenNganh.uDisplayMember = "TenChuyenNganh";
            this.cbxChuyenNganh.uEditValue = "";
            this.cbxChuyenNganh.uValueMember = "MaChuyenNganh";
            this.cbxChuyenNganh.Visible = false;
            this.cbxChuyenNganh.uEditValueChanged += new System.EventHandler(this.cbx_uEditValueChanged);
            this.cbxChuyenNganh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uLop_MouseDown);
            // 
            // cbxNganh
            // 
            this.cbxNganh.bLabelTopDock = true;
            this.cbxNganh.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxNganh.iWidth = 211;
            this.cbxNganh.Location = new System.Drawing.Point(2, 186);
            this.cbxNganh.Name = "cbxNganh";
            this.cbxNganh.sCaption = "Ngành đào tạo";
            this.cbxNganh.sColumnCaption = "Mã ngành, Tên ngành";
            this.cbxNganh.sField = "MaNganh, TenNganh";
            this.cbxNganh.Size = new System.Drawing.Size(211, 41);
            this.cbxNganh.TabIndex = 4;
            this.cbxNganh.uDisplayMember = "TenNganh";
            this.cbxNganh.uEditValue = "";
            this.cbxNganh.uTableName = "DM_Nganh";
            this.cbxNganh.uValueMember = "MaNganh";
            this.cbxNganh.uEditValueChanged += new System.EventHandler(this.cbx_uEditValueChanged);
            this.cbxNganh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uLop_MouseDown);
            // 
            // cbxKhoaHoc
            // 
            this.cbxKhoaHoc.bLabelTopDock = true;
            this.cbxKhoaHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxKhoaHoc.iWidth = 211;
            this.cbxKhoaHoc.Location = new System.Drawing.Point(2, 145);
            this.cbxKhoaHoc.Name = "cbxKhoaHoc";
            this.cbxKhoaHoc.sCaption = "Khóa học";
            this.cbxKhoaHoc.sColumnCaption = "Mã khóa học, Tên khóa học, Năm bắt đầu";
            this.cbxKhoaHoc.sField = "MaKhoaHoc, TenKhoaHoc, NamBatDau";
            this.cbxKhoaHoc.Size = new System.Drawing.Size(211, 41);
            this.cbxKhoaHoc.TabIndex = 3;
            this.cbxKhoaHoc.uDisplayMember = "TenKhoaHoc";
            this.cbxKhoaHoc.uEditValue = "";
            this.cbxKhoaHoc.uTableName = "DM_KhoaHoc";
            this.cbxKhoaHoc.uValueMember = "MaKhoaHoc";
            this.cbxKhoaHoc.uEditValueChanged += new System.EventHandler(this.cbx_uEditValueChanged);
            this.cbxKhoaHoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uLop_MouseDown);
            // 
            // cbxBac
            // 
            this.cbxBac.bLabelTopDock = true;
            this.cbxBac.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxBac.iWidth = 211;
            this.cbxBac.Location = new System.Drawing.Point(2, 104);
            this.cbxBac.Name = "cbxBac";
            this.cbxBac.sCaption = "Bậc đào tạo";
            this.cbxBac.sColumnCaption = "Mã bậc đào tạo, Tên bậc đào tạo, Quy chế";
            this.cbxBac.sField = "MaBacDaoTao, TenBacDaoTao, MaQuyChe";
            this.cbxBac.Size = new System.Drawing.Size(211, 41);
            this.cbxBac.TabIndex = 2;
            this.cbxBac.uDisplayMember = "TenBacDaoTao";
            this.cbxBac.uEditValue = "";
            this.cbxBac.uTableName = "DM_BacDaoTao";
            this.cbxBac.uValueMember = "MaBacDaoTao";
            this.cbxBac.uEditValueChanged += new System.EventHandler(this.cbx_uEditValueChanged);
            this.cbxBac.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uLop_MouseDown);
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.bLabelTopDock = true;
            this.cbxKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxKhoa.iWidth = 211;
            this.cbxKhoa.Location = new System.Drawing.Point(2, 63);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.sCaption = "Khoa";
            this.cbxKhoa.sColumnCaption = "Mã Khoa, Tên Khoa, Trưởng Khoa";
            this.cbxKhoa.sField = "MaKhoa, TenKhoa, TruongKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(211, 41);
            this.cbxKhoa.TabIndex = 1;
            this.cbxKhoa.uDisplayMember = "TenKhoa";
            this.cbxKhoa.uEditValue = "";
            this.cbxKhoa.uValueMember = "MaKhoa";
            this.cbxKhoa.uEditValueChanged += new System.EventHandler(this.cbx_uEditValueChanged);
            this.cbxKhoa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uLop_MouseDown);
            // 
            // cbxLoaiDaoTao
            // 
            this.cbxLoaiDaoTao.bLabelTopDock = true;
            this.cbxLoaiDaoTao.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxLoaiDaoTao.iWidth = 211;
            this.cbxLoaiDaoTao.Location = new System.Drawing.Point(2, 22);
            this.cbxLoaiDaoTao.Name = "cbxLoaiDaoTao";
            this.cbxLoaiDaoTao.sCaption = "Loại đào tạo";
            this.cbxLoaiDaoTao.sColumnCaption = "Mã loại đào tạo, Tên loại đào tạo";
            this.cbxLoaiDaoTao.sField = "MaLoaiDaoTao, TenLoaiDaoTao";
            this.cbxLoaiDaoTao.Size = new System.Drawing.Size(211, 41);
            this.cbxLoaiDaoTao.TabIndex = 0;
            this.cbxLoaiDaoTao.uDisplayMember = "TenLoaiDaoTao";
            this.cbxLoaiDaoTao.uEditValue = "";
            this.cbxLoaiDaoTao.uTableName = "DM_LoaiDaoTao";
            this.cbxLoaiDaoTao.uValueMember = "MaLoaiDaoTao";
            this.cbxLoaiDaoTao.uEditValueChanged += new System.EventHandler(this.cbx_uEditValueChanged);
            this.cbxLoaiDaoTao.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uLop_MouseDown);
            // 
            // ErrPrvd
            // 
            this.ErrPrvd.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReset});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(196, 26);
            // 
            // btnReset
            // 
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(195, 22);
            this.btnReset.Text = "Xóa điều kiện tìm kiếm";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // uLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.Controls.Add(this.grpMain);
            this.Name = "uLop";
            this.Size = new System.Drawing.Size(215, 404);
            this.Load += new System.EventHandler(this.uLop_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uLop_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).EndInit();
            this.grpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrPrvd)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpMain;
        public uComboBox cbxBac;
        public uComboBox cbxKhoa;
        public uComboBox cbxLoaiDaoTao;
        public uComboBox cbxKhoaHoc;
        public uComboBox cbxHocKy;
        public BSCEmisNamHoc txtNamHoc;
        public uComboBox cbxLop;
        public uComboBox cbxChuyenNganh;
        public uComboBox cbxNganh;
        private System.Windows.Forms.ErrorProvider ErrPrvd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnReset;

    }
}
