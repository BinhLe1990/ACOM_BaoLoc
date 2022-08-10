namespace DELFI_WHM.NET.NhanSu
{
    partial class frmQuaTrinhCongTac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuaTrinhCongTac));
            this.uNhanSu1 = new DELFI_WHM.NET.DELFI_User_Control.uNhanSu();
            this.grpThongTin = new DevExpress.XtraEditors.GroupControl();
            this.pnThongTin = new DevExpress.XtraEditors.PanelControl();
            this.txtGhiChu = new DELFI_WHM.NET.DELFI_User_Control.uMemoEdit();
            this.txtNoiLamViec = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.cboChucVu = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.dtpDenNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker();
            this.dtpTuNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker();
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
            this.uNhanSu1.Location = new System.Drawing.Point(42, 12);
            this.uNhanSu1.Name = "uNhanSu1";
            this.uNhanSu1.Size = new System.Drawing.Size(550, 50);
            this.uNhanSu1.sMaNhanSu = null;
            this.uNhanSu1.TabIndex = 0;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.pnThongTin);
            this.grpThongTin.Controls.Add(this.pnButton);
            this.grpThongTin.Controls.Add(this.dtg);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpThongTin.Location = new System.Drawing.Point(0, 59);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(651, 420);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.Text = "Thông tin chi tiết";
            // 
            // pnThongTin
            // 
            this.pnThongTin.Controls.Add(this.txtGhiChu);
            this.pnThongTin.Controls.Add(this.txtNoiLamViec);
            this.pnThongTin.Controls.Add(this.cboChucVu);
            this.pnThongTin.Controls.Add(this.dtpDenNgay);
            this.pnThongTin.Controls.Add(this.dtpTuNgay);
            this.pnThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThongTin.Location = new System.Drawing.Point(2, 22);
            this.pnThongTin.Name = "pnThongTin";
            this.pnThongTin.Size = new System.Drawing.Size(647, 121);
            this.pnThongTin.TabIndex = 2;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.bHAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtGhiChu.iWidth = 70;
            this.txtGhiChu.Location = new System.Drawing.Point(3, 52);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.sCaption = "Ghi chú";
            this.txtGhiChu.Size = new System.Drawing.Size(642, 64);
            this.txtGhiChu.TabIndex = 3;
            this.txtGhiChu.Tag = "..GhiChu";
            this.txtGhiChu.uCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtGhiChu.uMaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            // 
            // txtNoiLamViec
            // 
            this.txtNoiLamViec.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtNoiLamViec.iWidth = 80;
            this.txtNoiLamViec.Location = new System.Drawing.Point(219, 28);
            this.txtNoiLamViec.Name = "txtNoiLamViec";
            this.txtNoiLamViec.sCaption = "Nơi làm việc";
            this.txtNoiLamViec.SelectionStart = 0;
            this.txtNoiLamViec.Size = new System.Drawing.Size(425, 20);
            this.txtNoiLamViec.TabIndex = 2;
            this.txtNoiLamViec.Tag = "..NoiLamViec";
            // 
            // cboChucVu
            // 
            this.cboChucVu.iWidth = 80;
            this.cboChucVu.Location = new System.Drawing.Point(219, 6);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.sCaption = "Chức vụ";
            this.cboChucVu.sColumnCaption = "Mã chức vụ,Tên chức vụ";
            this.cboChucVu.sField = "MaChucVu,TenChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(317, 21);
            this.cboChucVu.TabIndex = 1;
            this.cboChucVu.Tag = "..MaChucVu";
            this.cboChucVu.uDisplayMember = "TenChucVu";
            this.cboChucVu.uEditValue = "";
            this.cboChucVu.uTableName = "DM_ChucVu";
            this.cboChucVu.uValueMember = "MaChucVu";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.iWidth = 70;
            this.dtpDenNgay.Location = new System.Drawing.Point(3, 28);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.sCaption = "Đến ngày";
            this.dtpDenNgay.Size = new System.Drawing.Size(210, 21);
            this.dtpDenNgay.TabIndex = 0;
            this.dtpDenNgay.Tag = "..DenNgay";
            this.dtpDenNgay.uDateTime = new System.DateTime(2013, 3, 13, 11, 1, 8, 498);
            this.dtpDenNgay.uValue = new System.DateTime(2013, 3, 13, 11, 1, 8, 498);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.iWidth = 70;
            this.dtpTuNgay.Location = new System.Drawing.Point(3, 6);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.sCaption = "Từ ngày";
            this.dtpTuNgay.Size = new System.Drawing.Size(210, 21);
            this.dtpTuNgay.TabIndex = 0;
            this.dtpTuNgay.Tag = "..TuNgay";
            this.dtpTuNgay.uDateTime = new System.DateTime(2013, 3, 13, 11, 1, 8, 500);
            this.dtpTuNgay.uValue = new System.DateTime(2013, 3, 13, 11, 1, 8, 500);
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.btnThemMoi);
            this.pnButton.Controls.Add(this.btnCapNhat);
            this.pnButton.Controls.Add(this.btnXoa);
            this.pnButton.Controls.Add(this.btnTroVe);
            this.pnButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnButton.Location = new System.Drawing.Point(2, 143);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(647, 30);
            this.pnButton.TabIndex = 0;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThemMoi.ImageIndex = 10;
            this.btnThemMoi.ImageList = this.IML;
            this.btnThemMoi.Location = new System.Drawing.Point(318, 2);
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
            this.btnCapNhat.Location = new System.Drawing.Point(399, 2);
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
            this.btnXoa.Location = new System.Drawing.Point(485, 2);
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
            this.btnTroVe.Location = new System.Drawing.Point(565, 2);
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
            this.dtg.Location = new System.Drawing.Point(2, 173);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(647, 245);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 1;
            this.dtg.uDataSource = null;
            this.dtg.uDoubleClick += new System.EventHandler(this.dtg_uDoubleClick);
            // 
            // frmQuaTrinhCongTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 479);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.uNhanSu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmQuaTrinhCongTac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "|HS|";
            this.Text = "Quá trình công tác";
            this.Load += new System.EventHandler(this.frmQuaTrinhCongTac_Load);
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
        private DELFI_WHM.NET.DELFI_User_Control.uMemoEdit txtGhiChu;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtNoiLamViec;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cboChucVu;
        private DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker dtpDenNgay;
        private DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker dtpTuNgay;
        private System.Windows.Forms.ImageList IML;
    }
}