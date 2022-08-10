namespace DELFI_WHM.NET.FrHT.FrND
{
    partial class frmTaoNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoNguoiDung));
            this.btnTaoNguoiDung = new DevExpress.XtraEditors.SimpleButton();
            this.chkQuyenPhanQuyen = new DevExpress.XtraEditors.CheckEdit();
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.spnID = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.txtGhichu = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtXacNhan = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtMatKhau = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtHoTen = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtTaiKhoan = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chkQuyenPhanQuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaoNguoiDung
            // 
            this.btnTaoNguoiDung.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnTaoNguoiDung.Appearance.Options.UseForeColor = true;
            this.btnTaoNguoiDung.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoNguoiDung.Image")));
            this.btnTaoNguoiDung.Location = new System.Drawing.Point(11, 193);
            this.btnTaoNguoiDung.Name = "btnTaoNguoiDung";
            this.btnTaoNguoiDung.Size = new System.Drawing.Size(108, 30);
            this.btnTaoNguoiDung.TabIndex = 0;
            this.btnTaoNguoiDung.Text = "Lưu";
            this.btnTaoNguoiDung.Click += new System.EventHandler(this.btnTaoNguoiDung_Click);
            // 
            // chkQuyenPhanQuyen
            // 
            this.chkQuyenPhanQuyen.Location = new System.Drawing.Point(11, 143);
            this.chkQuyenPhanQuyen.Name = "chkQuyenPhanQuyen";
            this.chkQuyenPhanQuyen.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkQuyenPhanQuyen.Properties.Appearance.Options.UseForeColor = true;
            this.chkQuyenPhanQuyen.Properties.Caption = "Quyền phân quyền";
            this.chkQuyenPhanQuyen.Size = new System.Drawing.Size(127, 19);
            this.chkQuyenPhanQuyen.TabIndex = 4;
            // 
            // chkActive
            // 
            this.chkActive.Location = new System.Drawing.Point(12, 168);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkActive.Properties.Appearance.Options.UseForeColor = true;
            this.chkActive.Properties.Caption = "Active";
            this.chkActive.Size = new System.Drawing.Size(127, 19);
            this.chkActive.TabIndex = 7;
            // 
            // spnID
            // 
            this.spnID.iWidth = 50;
            this.spnID.Location = new System.Drawing.Point(236, 146);
            this.spnID.Name = "spnID";
            this.spnID.sCaption = "ID";
            this.spnID.Size = new System.Drawing.Size(129, 25);
            this.spnID.TabIndex = 8;
            this.spnID.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnID.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnID.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnID.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnID.uText = "0";
            this.spnID.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnID.Visible = false;
            // 
            // txtGhichu
            // 
            this.txtGhichu.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtGhichu.iWidth = 70;
            this.txtGhichu.Location = new System.Drawing.Point(11, 118);
            this.txtGhichu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.sCaption = "Ghi chú";
            this.txtGhichu.SelectionStart = 0;
            this.txtGhichu.Size = new System.Drawing.Size(354, 20);
            this.txtGhichu.TabIndex = 6;
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtXacNhan.bIsPassword = true;
            this.txtXacNhan.iWidth = 70;
            this.txtXacNhan.Location = new System.Drawing.Point(11, 94);
            this.txtXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.sCaption = "Xác nhận lại";
            this.txtXacNhan.SelectionStart = 0;
            this.txtXacNhan.Size = new System.Drawing.Size(354, 20);
            this.txtXacNhan.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtMatKhau.bIsPassword = true;
            this.txtMatKhau.iWidth = 70;
            this.txtMatKhau.Location = new System.Drawing.Point(11, 68);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.sCaption = "Mật khẩu";
            this.txtMatKhau.SelectionStart = 0;
            this.txtMatKhau.Size = new System.Drawing.Size(354, 20);
            this.txtMatKhau.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtHoTen.iWidth = 70;
            this.txtHoTen.Location = new System.Drawing.Point(11, 42);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.sCaption = "Họ tên";
            this.txtHoTen.SelectionStart = 0;
            this.txtHoTen.Size = new System.Drawing.Size(354, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtTaiKhoan.iWidth = 70;
            this.txtTaiKhoan.Location = new System.Drawing.Point(11, 16);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.sCaption = "Tài khoản";
            this.txtTaiKhoan.SelectionStart = 0;
            this.txtTaiKhoan.Size = new System.Drawing.Size(354, 20);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // frmTaoNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 239);
            this.Controls.Add(this.spnID);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.chkQuyenPhanQuyen);
            this.Controls.Add(this.txtXacNhan);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.btnTaoNguoiDung);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaoNguoiDung";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin người dùng";
            this.Load += new System.EventHandler(this.frmTaoNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkQuyenPhanQuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnTaoNguoiDung;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtXacNhan;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtMatKhau;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtHoTen;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtTaiKhoan;
        private DevExpress.XtraEditors.CheckEdit chkQuyenPhanQuyen;
        private DELFI_User_Control.uTextBox txtGhichu;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private DELFI_User_Control.uSpinEdit spnID;
    }
}