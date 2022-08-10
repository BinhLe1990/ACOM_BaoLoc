namespace BSC_HRM.NET.FrHT.FrND
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
            this.btnTroLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaoNguoiDung = new DevExpress.XtraEditors.SimpleButton();
            this.txtXacNhan = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.txtMatKhau = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.txtHoTen = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.txtTaiKhoan = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.chkQuyenPhanQuyen = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chkQuyenPhanQuyen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(225, 138);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(108, 30);
            this.btnTroLai.TabIndex = 2;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnTaoNguoiDung
            // 
            this.btnTaoNguoiDung.Location = new System.Drawing.Point(111, 138);
            this.btnTaoNguoiDung.Name = "btnTaoNguoiDung";
            this.btnTaoNguoiDung.Size = new System.Drawing.Size(108, 30);
            this.btnTaoNguoiDung.TabIndex = 0;
            this.btnTaoNguoiDung.Text = "Tạo người dùng";
            this.btnTaoNguoiDung.Click += new System.EventHandler(this.btnTaoNguoiDung_Click);
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
            this.txtXacNhan.Size = new System.Drawing.Size(322, 20);
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
            this.txtMatKhau.Size = new System.Drawing.Size(322, 20);
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
            this.txtHoTen.Size = new System.Drawing.Size(322, 20);
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
            this.txtTaiKhoan.Size = new System.Drawing.Size(322, 20);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // chkQuyenPhanQuyen
            // 
            this.chkQuyenPhanQuyen.Location = new System.Drawing.Point(9, 119);
            this.chkQuyenPhanQuyen.Name = "chkQuyenPhanQuyen";
            this.chkQuyenPhanQuyen.Properties.Caption = "Quyền phân quyền";
            this.chkQuyenPhanQuyen.Size = new System.Drawing.Size(127, 19);
            this.chkQuyenPhanQuyen.TabIndex = 4;
            // 
            // frmTaoNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 176);
            this.Controls.Add(this.chkQuyenPhanQuyen);
            this.Controls.Add(this.txtXacNhan);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.btnTaoNguoiDung);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaoNguoiDung";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo người dùng";
            this.Load += new System.EventHandler(this.frmTaoNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkQuyenPhanQuyen.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTroLai;
        private DevExpress.XtraEditors.SimpleButton btnTaoNguoiDung;
        private BSC_HRM.NET.BSC_User_Control.uTextBox txtXacNhan;
        private BSC_HRM.NET.BSC_User_Control.uTextBox txtMatKhau;
        private BSC_HRM.NET.BSC_User_Control.uTextBox txtHoTen;
        private BSC_HRM.NET.BSC_User_Control.uTextBox txtTaiKhoan;
        private DevExpress.XtraEditors.CheckEdit chkQuyenPhanQuyen;
    }
}