namespace BSC_HRM.NET.FrHT.FrND
{
    partial class frmNDDoiMatKhau
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
            this.btnLuuQuyen = new DevExpress.XtraEditors.SimpleButton();
            this.btnTroLai = new DevExpress.XtraEditors.SimpleButton();
            this.txtXacNhan = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.txtMKCu = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.txtMatKhau = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.SuspendLayout();
            // 
            // btnLuuQuyen
            // 
            this.btnLuuQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuQuyen.Location = new System.Drawing.Point(72, 104);
            this.btnLuuQuyen.Name = "btnLuuQuyen";
            this.btnLuuQuyen.Size = new System.Drawing.Size(117, 26);
            this.btnLuuQuyen.TabIndex = 3;
            this.btnLuuQuyen.Text = "Đổi mật khẩu";
            this.btnLuuQuyen.Click += new System.EventHandler(this.btnLuuQuyen_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTroLai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTroLai.Location = new System.Drawing.Point(195, 104);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(88, 26);
            this.btnTroLai.TabIndex = 4;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.sCaption = "Xác nhận lại";
            this.txtXacNhan.sEditMask = "";
            this.txtXacNhan.bHAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtXacNhan.bIsPassword = true;
            this.txtXacNhan.bIsReadOnly = false;
            this.txtXacNhan.iMaxLength = 0;
            this.txtXacNhan.sNullText = "";
            this.txtXacNhan.bUseMask = false;
            this.txtXacNhan.uText = "";
            this.txtXacNhan.iWidth = 70;
            this.txtXacNhan.Location = new System.Drawing.Point(12, 64);
            this.txtXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.Size = new System.Drawing.Size(271, 20);
            this.txtXacNhan.TabIndex = 2;
            // 
            // txtMKCu
            // 
            this.txtMKCu.sCaption = "Mật khẩu cũ";
            this.txtMKCu.sEditMask = "";
            this.txtMKCu.bHAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtMKCu.bIsPassword = true;
            this.txtMKCu.bIsReadOnly = false;
            this.txtMKCu.iMaxLength = 0;
            this.txtMKCu.sNullText = "";
            this.txtMKCu.bUseMask = false;
            this.txtMKCu.uText = "";
            this.txtMKCu.iWidth = 70;
            this.txtMKCu.Location = new System.Drawing.Point(12, 12);
            this.txtMKCu.Margin = new System.Windows.Forms.Padding(2);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(271, 20);
            this.txtMKCu.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.sCaption = "Mật khẩu mới";
            this.txtMatKhau.sEditMask = "";
            this.txtMatKhau.bHAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtMatKhau.bIsPassword = true;
            this.txtMatKhau.bIsReadOnly = false;
            this.txtMatKhau.iMaxLength = 0;
            this.txtMatKhau.sNullText = "";
            this.txtMatKhau.bUseMask = false;
            this.txtMatKhau.uText = "";
            this.txtMatKhau.iWidth = 70;
            this.txtMatKhau.Location = new System.Drawing.Point(12, 38);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(271, 20);
            this.txtMatKhau.TabIndex = 1;
            // 
            // frmNDDoiMatKhau
            // 
            this.AcceptButton = this.btnLuuQuyen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTroLai;
            this.ClientSize = new System.Drawing.Size(295, 142);
            this.Controls.Add(this.btnLuuQuyen);
            this.Controls.Add(this.txtXacNhan);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.btnTroLai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNDDoiMatKhau";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mặt khẩu";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLuuQuyen;
        private BSC_HRM.NET.BSC_User_Control.uTextBox txtXacNhan;
        private BSC_HRM.NET.BSC_User_Control.uTextBox txtMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnTroLai;
        private BSC_HRM.NET.BSC_User_Control.uTextBox txtMKCu;
    }
}