namespace DELFI_WHM.NET.NhanSu
{
    partial class frmQuanHeGiaDinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanHeGiaDinh));
            this.uNhanSu1 = new DELFI_WHM.NET.DELFI_User_Control.uNhanSu();
            this.grpThongTin = new DevExpress.XtraEditors.GroupControl();
            this.pnThongTin = new DevExpress.XtraEditors.PanelControl();
            this.txtGhiChu = new DELFI_WHM.NET.DELFI_User_Control.uMemoEdit();
            this.cboQuanHe = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.txtDiaChi = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtNgheNghiep = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtHoTen = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.dtpNgaySinh = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker();
            this.pnButton = new DevExpress.XtraEditors.PanelControl();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnTroVe = new DevExpress.XtraEditors.SimpleButton();
            this.dtg = new DELFI_WHM.NET.DELFI_User_Control.uDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTin)).BeginInit();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnThongTin)).BeginInit();
            this.pnThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnButton)).BeginInit();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // uNhanSu1
            // 
            this.uNhanSu1.iNhanSuID = 0;
            this.uNhanSu1.Location = new System.Drawing.Point(5, 7);
            this.uNhanSu1.Name = "uNhanSu1";
            this.uNhanSu1.Size = new System.Drawing.Size(550, 50);
            this.uNhanSu1.sMaNhanSu = null;
            this.uNhanSu1.TabIndex = 0;
            this.uNhanSu1.uClick += new System.EventHandler(this.uNhanSu1_uClick);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.pnThongTin);
            this.grpThongTin.Controls.Add(this.pnButton);
            this.grpThongTin.Controls.Add(this.dtg);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpThongTin.Location = new System.Drawing.Point(0, 63);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(568, 478);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.Text = "Thông tin chi tiết";
            // 
            // pnThongTin
            // 
            this.pnThongTin.Controls.Add(this.txtGhiChu);
            this.pnThongTin.Controls.Add(this.cboQuanHe);
            this.pnThongTin.Controls.Add(this.txtDiaChi);
            this.pnThongTin.Controls.Add(this.txtNgheNghiep);
            this.pnThongTin.Controls.Add(this.txtHoTen);
            this.pnThongTin.Controls.Add(this.dtpNgaySinh);
            this.pnThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThongTin.Location = new System.Drawing.Point(2, 22);
            this.pnThongTin.Name = "pnThongTin";
            this.pnThongTin.Size = new System.Drawing.Size(564, 137);
            this.pnThongTin.TabIndex = 2;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.bHAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtGhiChu.iWidth = 70;
            this.txtGhiChu.Location = new System.Drawing.Point(3, 71);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.sCaption = "Ghi chú";
            this.txtGhiChu.Size = new System.Drawing.Size(559, 64);
            this.txtGhiChu.TabIndex = 4;
            this.txtGhiChu.Tag = "..GhiChu";
            this.txtGhiChu.uCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtGhiChu.uMaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            // 
            // cboQuanHe
            // 
            this.cboQuanHe.iWidth = 70;
            this.cboQuanHe.Location = new System.Drawing.Point(289, 27);
            this.cboQuanHe.Name = "cboQuanHe";
            this.cboQuanHe.sCaption = "Quan hệ";
            this.cboQuanHe.sField = null;
            this.cboQuanHe.Size = new System.Drawing.Size(273, 21);
            this.cboQuanHe.TabIndex = 3;
            this.cboQuanHe.Tag = "..QuanHeGiaDinh";
            this.cboQuanHe.uDisplayMember = "TenQuanHeGiaDinh";
            this.cboQuanHe.uEditValue = null;
            this.cboQuanHe.uTableName = "DM_QuanHeGiaDinh";
            this.cboQuanHe.uValueMember = "MaQuanHeGiaDinh";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtDiaChi.iWidth = 70;
            this.txtDiaChi.Location = new System.Drawing.Point(3, 48);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.sCaption = "Địa chỉ";
            this.txtDiaChi.SelectionStart = 0;
            this.txtDiaChi.Size = new System.Drawing.Size(559, 20);
            this.txtDiaChi.TabIndex = 1;
            this.txtDiaChi.Tag = "..DiaChi";
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtNgheNghiep.iWidth = 70;
            this.txtNgheNghiep.Location = new System.Drawing.Point(3, 27);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.sCaption = "Nghề nghiệp";
            this.txtNgheNghiep.SelectionStart = 0;
            this.txtNgheNghiep.Size = new System.Drawing.Size(280, 20);
            this.txtNgheNghiep.TabIndex = 1;
            this.txtNgheNghiep.Tag = "..NgheNghiep";
            // 
            // txtHoTen
            // 
            this.txtHoTen.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtHoTen.iWidth = 70;
            this.txtHoTen.Location = new System.Drawing.Point(3, 6);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.sCaption = "Họ tên";
            this.txtHoTen.SelectionStart = 0;
            this.txtHoTen.Size = new System.Drawing.Size(280, 20);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.Tag = "..HoTen";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.iWidth = 70;
            this.dtpNgaySinh.Location = new System.Drawing.Point(289, 6);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.sCaption = "Ngày sinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(219, 21);
            this.dtpNgaySinh.TabIndex = 0;
            this.dtpNgaySinh.Tag = "..NgaySinh";
            this.dtpNgaySinh.uDateTime = new System.DateTime(2013, 3, 13, 11, 0, 2, 20);
            this.dtpNgaySinh.uValue = new System.DateTime(2013, 3, 13, 11, 0, 2, 20);
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.btnThemMoi);
            this.pnButton.Controls.Add(this.btnCapNhat);
            this.pnButton.Controls.Add(this.btnXoa);
            this.pnButton.Controls.Add(this.btnTroVe);
            this.pnButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnButton.Location = new System.Drawing.Point(2, 159);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(564, 30);
            this.pnButton.TabIndex = 0;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThemMoi.ImageIndex = 10;
            this.btnThemMoi.ImageList = this.IML;
            this.btnThemMoi.Location = new System.Drawing.Point(235, 2);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(81, 26);
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
            this.IML.Images.SetKeyName(10, "Create.ico");
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCapNhat.ImageIndex = 6;
            this.btnCapNhat.ImageList = this.IML;
            this.btnCapNhat.Location = new System.Drawing.Point(316, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(86, 26);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Tag = "EDIT";
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXoa.ImageIndex = 5;
            this.btnXoa.ImageList = this.IML;
            this.btnXoa.Location = new System.Drawing.Point(402, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 26);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Tag = "DEL";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTroVe.ImageIndex = 1;
            this.btnTroVe.ImageList = this.IML;
            this.btnTroVe.Location = new System.Drawing.Point(482, 2);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(80, 26);
            this.btnTroVe.TabIndex = 3;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // dtg
            // 
            this.dtg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(2, 189);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(564, 287);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 1;
            this.dtg.uDataSource = null;
            this.dtg.uDoubleClick += new System.EventHandler(this.dtg_uDoubleClick);
            // 
            // frmQuanHeGiaDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 541);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.uNhanSu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmQuanHeGiaDinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "|HS|";
            this.Text = "Quan hệ gia đình";
            this.Load += new System.EventHandler(this.frmQuanHeGiaDinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTin)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnThongTin)).EndInit();
            this.pnThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnButton)).EndInit();
            this.pnButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DELFI_WHM.NET.DELFI_User_Control.uNhanSu uNhanSu1;
        private DevExpress.XtraEditors.GroupControl grpThongTin;
        private DevExpress.XtraEditors.PanelControl pnThongTin;
        private DevExpress.XtraEditors.PanelControl pnButton;
        private DevExpress.XtraEditors.SimpleButton btnTroVe;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DELFI_WHM.NET.DELFI_User_Control.uDataGrid dtg;
        private DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ImageList IML;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtHoTen;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cboQuanHe;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtNgheNghiep;
        private DELFI_WHM.NET.DELFI_User_Control.uMemoEdit txtGhiChu;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtDiaChi;
    }
}