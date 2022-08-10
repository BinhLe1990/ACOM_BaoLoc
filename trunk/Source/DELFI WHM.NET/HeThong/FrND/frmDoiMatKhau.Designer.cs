namespace DELFI_WHM.NET.FrHT.FrND
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtXacNhan = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMatKhau = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.cbxNGUOIDUNG = new DevExpress.XtraEditors.LookUpEdit();
            this.btnTroLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuQuyen = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNGUOIDUNG.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtXacNhan);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtMatKhau);
            this.panelControl1.Controls.Add(this.cbxNGUOIDUNG);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(298, 99);
            this.panelControl1.TabIndex = 0;
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtXacNhan.bIsPassword = true;
            this.txtXacNhan.iWidth = 70;
            this.txtXacNhan.Location = new System.Drawing.Point(14, 64);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.sCaption = "Xác nhận lại";
            this.txtXacNhan.SelectionStart = 0;
            this.txtXacNhan.Size = new System.Drawing.Size(269, 20);
            this.txtXacNhan.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Người dùng";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtMatKhau.bIsPassword = true;
            this.txtMatKhau.iWidth = 70;
            this.txtMatKhau.Location = new System.Drawing.Point(14, 38);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.sCaption = "Mật khẩu";
            this.txtMatKhau.SelectionStart = 0;
            this.txtMatKhau.Size = new System.Drawing.Size(269, 20);
            this.txtMatKhau.TabIndex = 1;
            // 
            // cbxNGUOIDUNG
            // 
            this.cbxNGUOIDUNG.Location = new System.Drawing.Point(84, 13);
            this.cbxNGUOIDUNG.Name = "cbxNGUOIDUNG";
            this.cbxNGUOIDUNG.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbxNGUOIDUNG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxNGUOIDUNG.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NGUOIDUNG", "NGUOIDUNG", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TAIKHOAN", 80, "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HOTEN", 160, "Họ tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KIEUGIAODIEN", "Kiểu giao diện", 90, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.cbxNGUOIDUNG.Properties.DisplayMember = "HOTEN";
            this.cbxNGUOIDUNG.Properties.NullText = "Bạn hãy chọn người dùng";
            this.cbxNGUOIDUNG.Properties.ValueMember = "NGUOIDUNG";
            this.cbxNGUOIDUNG.Size = new System.Drawing.Size(199, 20);
            this.cbxNGUOIDUNG.TabIndex = 0;
            // 
            // btnTroLai
            // 
            this.btnTroLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTroLai.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnTroLai.Appearance.Options.UseForeColor = true;
            this.btnTroLai.Location = new System.Drawing.Point(210, 125);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(100, 27);
            this.btnTroLai.TabIndex = 2;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnLuuQuyen
            // 
            this.btnLuuQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuQuyen.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnLuuQuyen.Appearance.Options.UseForeColor = true;
            this.btnLuuQuyen.Location = new System.Drawing.Point(78, 125);
            this.btnLuuQuyen.Name = "btnLuuQuyen";
            this.btnLuuQuyen.Size = new System.Drawing.Size(126, 27);
            this.btnLuuQuyen.TabIndex = 1;
            this.btnLuuQuyen.Text = "Đổi mật khẩu";
            this.btnLuuQuyen.Click += new System.EventHandler(this.btnLuuQuyen_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 162);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnLuuQuyen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu người dùng";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNGUOIDUNG.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cbxNGUOIDUNG;
        private DevExpress.XtraEditors.SimpleButton btnTroLai;
        private DevExpress.XtraEditors.SimpleButton btnLuuQuyen;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtXacNhan;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtMatKhau;
    }
}