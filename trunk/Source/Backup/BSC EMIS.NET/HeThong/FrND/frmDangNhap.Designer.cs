namespace BSC_HRM.NET.FrHT.FrND
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnTroLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuQuyen = new DevExpress.XtraEditors.SimpleButton();
            this.chkNhoMK = new DevExpress.XtraEditors.CheckEdit();
            this.bscMatKhau = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.bscTaiKhoan = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNhoMK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(8, 10);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Size = new System.Drawing.Size(68, 63);
            this.pictureEdit1.TabIndex = 5;
            this.pictureEdit1.DoubleClick += new System.EventHandler(this.pictureEdit1_DoubleClick);
            // 
            // btnTroLai
            // 
            this.btnTroLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTroLai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTroLai.Location = new System.Drawing.Point(249, 87);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(89, 26);
            this.btnTroLai.TabIndex = 4;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnLuuQuyen
            // 
            this.btnLuuQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuQuyen.Location = new System.Drawing.Point(132, 87);
            this.btnLuuQuyen.Name = "btnLuuQuyen";
            this.btnLuuQuyen.Size = new System.Drawing.Size(111, 26);
            this.btnLuuQuyen.TabIndex = 3;
            this.btnLuuQuyen.Text = "Đăng nhập";
            this.btnLuuQuyen.Click += new System.EventHandler(this.btnLuuQuyen_Click);
            // 
            // chkNhoMK
            // 
            this.chkNhoMK.Location = new System.Drawing.Point(132, 63);
            this.chkNhoMK.Name = "chkNhoMK";
            this.chkNhoMK.Properties.Caption = "Nhớ mật khẩu";
            this.chkNhoMK.Size = new System.Drawing.Size(170, 19);
            this.chkNhoMK.TabIndex = 2;
            // 
            // bscMatKhau
            // 
            this.bscMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bscMatKhau.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.bscMatKhau.bIsPassword = true;
            this.bscMatKhau.iWidth = 60;
            this.bscMatKhau.Location = new System.Drawing.Point(73, 38);
            this.bscMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.bscMatKhau.Name = "bscMatKhau";
            this.bscMatKhau.sCaption = "Mật khẩu";
            this.bscMatKhau.SelectionStart = 0;
            this.bscMatKhau.Size = new System.Drawing.Size(265, 20);
            this.bscMatKhau.TabIndex = 1;
            // 
            // bscTaiKhoan
            // 
            this.bscTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bscTaiKhoan.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.bscTaiKhoan.iWidth = 60;
            this.bscTaiKhoan.Location = new System.Drawing.Point(73, 12);
            this.bscTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.bscTaiKhoan.Name = "bscTaiKhoan";
            this.bscTaiKhoan.sCaption = "Tài khoản";
            this.bscTaiKhoan.SelectionStart = 0;
            this.bscTaiKhoan.Size = new System.Drawing.Size(265, 20);
            this.bscTaiKhoan.TabIndex = 0;
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnLuuQuyen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTroLai;
            this.ClientSize = new System.Drawing.Size(350, 124);
            this.Controls.Add(this.chkNhoMK);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnLuuQuyen);
            this.Controls.Add(this.bscMatKhau);
            this.Controls.Add(this.bscTaiKhoan);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập chương trình";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNhoMK.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BSC_HRM.NET.BSC_User_Control.uTextBox bscTaiKhoan;
        private BSC_HRM.NET.BSC_User_Control.uTextBox bscMatKhau;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnTroLai;
        private DevExpress.XtraEditors.SimpleButton btnLuuQuyen;
        private DevExpress.XtraEditors.CheckEdit chkNhoMK;
    }
}