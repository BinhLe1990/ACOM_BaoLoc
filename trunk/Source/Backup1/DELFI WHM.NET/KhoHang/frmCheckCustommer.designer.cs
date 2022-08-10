namespace DELFI_WHM.NET.KhoHang
{
    partial class frmCheckCustommer
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
            this.grThaoTac = new DevExpress.XtraEditors.GroupControl();
            this.radChon = new DevExpress.XtraEditors.RadioGroup();
            this.txtDiaDiem = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtLoaiNganhNghe = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtNganhNghe = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtNamKinhNghiem = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtLoaiSuKien = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtDiaChi = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtChucVu = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtEmail = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.cboSuKien = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.chkSound = new System.Windows.Forms.CheckBox();
            this.txtDienThoai = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtTen = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtHoDem = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtIDCus = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.btnInDS = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.dtg = new DELFI_WHM.NET.DELFI_User_Control.uDataGrid();
            this.txtSoLanQuet = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grThaoTac)).BeginInit();
            this.grThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grThaoTac
            // 
            this.grThaoTac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grThaoTac.Controls.Add(this.txtSoLanQuet);
            this.grThaoTac.Controls.Add(this.radChon);
            this.grThaoTac.Controls.Add(this.txtDiaDiem);
            this.grThaoTac.Controls.Add(this.txtLoaiNganhNghe);
            this.grThaoTac.Controls.Add(this.txtNganhNghe);
            this.grThaoTac.Controls.Add(this.txtNamKinhNghiem);
            this.grThaoTac.Controls.Add(this.txtLoaiSuKien);
            this.grThaoTac.Controls.Add(this.txtDiaChi);
            this.grThaoTac.Controls.Add(this.txtChucVu);
            this.grThaoTac.Controls.Add(this.txtEmail);
            this.grThaoTac.Controls.Add(this.cboSuKien);
            this.grThaoTac.Controls.Add(this.chkSound);
            this.grThaoTac.Controls.Add(this.txtDienThoai);
            this.grThaoTac.Controls.Add(this.txtTen);
            this.grThaoTac.Controls.Add(this.txtHoDem);
            this.grThaoTac.Controls.Add(this.txtIDCus);
            this.grThaoTac.Controls.Add(this.btnInDS);
            this.grThaoTac.Controls.Add(this.btnTimKiem);
            this.grThaoTac.Location = new System.Drawing.Point(12, 1);
            this.grThaoTac.Name = "grThaoTac";
            this.grThaoTac.Size = new System.Drawing.Size(876, 203);
            this.grThaoTac.TabIndex = 5;
            this.grThaoTac.Text = "THAO TÁC THỰC HIỆN";
            // 
            // radChon
            // 
            this.radChon.EditValue = 1;
            this.radChon.Location = new System.Drawing.Point(212, 179);
            this.radChon.Name = "radChon";
            this.radChon.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radChon.Properties.Appearance.Options.UseBackColor = true;
            this.radChon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radChon.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Điện thoại"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Email")});
            this.radChon.Size = new System.Drawing.Size(323, 19);
            this.radChon.TabIndex = 23;
            this.radChon.Tag = "..GIOITINH";
            this.radChon.SelectedIndexChanged += new System.EventHandler(this.radChon_SelectedIndexChanged);
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaDiem.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtDiaDiem.bIsReadOnly = true;
            this.txtDiaDiem.Location = new System.Drawing.Point(440, 140);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.sCaption = "Địa điểm";
            this.txtDiaDiem.SelectionStart = 0;
            this.txtDiaDiem.Size = new System.Drawing.Size(431, 20);
            this.txtDiaDiem.TabIndex = 22;
            // 
            // txtLoaiNganhNghe
            // 
            this.txtLoaiNganhNghe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoaiNganhNghe.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtLoaiNganhNghe.bIsReadOnly = true;
            this.txtLoaiNganhNghe.Location = new System.Drawing.Point(440, 118);
            this.txtLoaiNganhNghe.Name = "txtLoaiNganhNghe";
            this.txtLoaiNganhNghe.sCaption = "Loại ngành nghề";
            this.txtLoaiNganhNghe.SelectionStart = 0;
            this.txtLoaiNganhNghe.Size = new System.Drawing.Size(431, 20);
            this.txtLoaiNganhNghe.TabIndex = 21;
            // 
            // txtNganhNghe
            // 
            this.txtNganhNghe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNganhNghe.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtNganhNghe.bIsReadOnly = true;
            this.txtNganhNghe.Location = new System.Drawing.Point(440, 96);
            this.txtNganhNghe.Name = "txtNganhNghe";
            this.txtNganhNghe.sCaption = "Ngành nghề";
            this.txtNganhNghe.SelectionStart = 0;
            this.txtNganhNghe.Size = new System.Drawing.Size(431, 20);
            this.txtNganhNghe.TabIndex = 20;
            // 
            // txtNamKinhNghiem
            // 
            this.txtNamKinhNghiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamKinhNghiem.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtNamKinhNghiem.bIsReadOnly = true;
            this.txtNamKinhNghiem.Location = new System.Drawing.Point(440, 74);
            this.txtNamKinhNghiem.Name = "txtNamKinhNghiem";
            this.txtNamKinhNghiem.sCaption = "Năm kinh nghiệm";
            this.txtNamKinhNghiem.SelectionStart = 0;
            this.txtNamKinhNghiem.Size = new System.Drawing.Size(431, 20);
            this.txtNamKinhNghiem.TabIndex = 19;
            // 
            // txtLoaiSuKien
            // 
            this.txtLoaiSuKien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoaiSuKien.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtLoaiSuKien.bIsReadOnly = true;
            this.txtLoaiSuKien.Location = new System.Drawing.Point(440, 52);
            this.txtLoaiSuKien.Name = "txtLoaiSuKien";
            this.txtLoaiSuKien.sCaption = "Loại sự kiện";
            this.txtLoaiSuKien.SelectionStart = 0;
            this.txtLoaiSuKien.Size = new System.Drawing.Size(431, 20);
            this.txtLoaiSuKien.TabIndex = 18;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtDiaChi.bIsReadOnly = true;
            this.txtDiaChi.Location = new System.Drawing.Point(440, 30);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.sCaption = "Địa chỉ";
            this.txtDiaChi.SelectionStart = 0;
            this.txtDiaChi.Size = new System.Drawing.Size(431, 20);
            this.txtDiaChi.TabIndex = 17;
            // 
            // txtChucVu
            // 
            this.txtChucVu.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtChucVu.bIsReadOnly = true;
            this.txtChucVu.Location = new System.Drawing.Point(17, 140);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.sCaption = "Chức vụ";
            this.txtChucVu.SelectionStart = 0;
            this.txtChucVu.Size = new System.Drawing.Size(403, 20);
            this.txtChucVu.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtEmail.bIsReadOnly = true;
            this.txtEmail.Location = new System.Drawing.Point(17, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.sCaption = "Email";
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(403, 20);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.uKeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmail_uKeyUp);
            // 
            // cboSuKien
            // 
            this.cboSuKien.Location = new System.Drawing.Point(17, 30);
            this.cboSuKien.Name = "cboSuKien";
            this.cboSuKien.sCaption = "Sự kiện";
            this.cboSuKien.sField = "MaSuKien,TenSuKien";
            this.cboSuKien.Size = new System.Drawing.Size(403, 21);
            this.cboSuKien.TabIndex = 14;
            this.cboSuKien.Tag = "..MaSuKien";
            this.cboSuKien.uDisplayMember = "TenSuKien";
            this.cboSuKien.uEditValue = null;
            this.cboSuKien.uTableName = "DM_SuKien";
            this.cboSuKien.uValueMember = "MaSuKien";
            // 
            // chkSound
            // 
            this.chkSound.AutoSize = true;
            this.chkSound.Location = new System.Drawing.Point(115, 181);
            this.chkSound.Name = "chkSound";
            this.chkSound.Size = new System.Drawing.Size(72, 17);
            this.chkSound.TabIndex = 12;
            this.chkSound.Text = "Âm thanh";
            this.chkSound.UseVisualStyleBackColor = true;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtDienThoai.bIsReadOnly = true;
            this.txtDienThoai.Location = new System.Drawing.Point(17, 96);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.sCaption = "Số ĐT";
            this.txtDienThoai.SelectionStart = 0;
            this.txtDienThoai.Size = new System.Drawing.Size(403, 20);
            this.txtDienThoai.TabIndex = 8;
            this.txtDienThoai.uKeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDienThoai_uKeyUp);
            // 
            // txtTen
            // 
            this.txtTen.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtTen.bIsReadOnly = true;
            this.txtTen.iWidth = 0;
            this.txtTen.Location = new System.Drawing.Point(322, 74);
            this.txtTen.Name = "txtTen";
            this.txtTen.sCaption = "Tên";
            this.txtTen.SelectionStart = 0;
            this.txtTen.Size = new System.Drawing.Size(98, 20);
            this.txtTen.TabIndex = 7;
            // 
            // txtHoDem
            // 
            this.txtHoDem.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtHoDem.bIsReadOnly = true;
            this.txtHoDem.Location = new System.Drawing.Point(17, 74);
            this.txtHoDem.Name = "txtHoDem";
            this.txtHoDem.sCaption = "Họ tên";
            this.txtHoDem.SelectionStart = 0;
            this.txtHoDem.Size = new System.Drawing.Size(299, 20);
            this.txtHoDem.TabIndex = 6;
            // 
            // txtIDCus
            // 
            this.txtIDCus.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtIDCus.Location = new System.Drawing.Point(17, 52);
            this.txtIDCus.Name = "txtIDCus";
            this.txtIDCus.sCaption = "Mã khách hàng";
            this.txtIDCus.SelectionStart = 0;
            this.txtIDCus.Size = new System.Drawing.Size(271, 20);
            this.txtIDCus.TabIndex = 5;
            this.txtIDCus.uKeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIDCus_uKeyUp);
            // 
            // btnInDS
            // 
            this.btnInDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInDS.Location = new System.Drawing.Point(759, 173);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(99, 25);
            this.btnInDS.TabIndex = 2;
            this.btnInDS.Text = "In danh sách";
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(654, 173);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(99, 25);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Lọc DS";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtg
            // 
            this.dtg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(12, 205);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(876, 304);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 39;
            this.dtg.uDataSource = null;
            // 
            // txtSoLanQuet
            // 
            this.txtSoLanQuet.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtSoLanQuet.bIsReadOnly = true;
            this.txtSoLanQuet.iWidth = 60;
            this.txtSoLanQuet.Location = new System.Drawing.Point(294, 52);
            this.txtSoLanQuet.Name = "txtSoLanQuet";
            this.txtSoLanQuet.sCaption = "Lần quét";
            this.txtSoLanQuet.SelectionStart = 0;
            this.txtSoLanQuet.Size = new System.Drawing.Size(126, 20);
            this.txtSoLanQuet.TabIndex = 24;
            // 
            // frmCheckCustommer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 521);
            this.Controls.Add(this.grThaoTac);
            this.Controls.Add(this.dtg);
            this.Name = "frmCheckCustommer";
            this.Tag = "|HP|";
            this.Text = "Kiểm tra khách hàng";
            this.Load += new System.EventHandler(this.frmCheckCustommer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grThaoTac)).EndInit();
            this.grThaoTac.ResumeLayout(false);
            this.grThaoTac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChon.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grThaoTac;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnInDS;
        private DELFI_WHM.NET.DELFI_User_Control.uDataGrid dtg;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtIDCus;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtDienThoai;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtTen;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtHoDem;
        private System.Windows.Forms.CheckBox chkSound;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtChucVu;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtEmail;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cboSuKien;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtDiaDiem;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtLoaiNganhNghe;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtNganhNghe;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtNamKinhNghiem;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtLoaiSuKien;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtDiaChi;
        private DevExpress.XtraEditors.RadioGroup radChon;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtSoLanQuet;
    }
}