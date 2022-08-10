namespace BSC_HRM.NET
{
    partial class frmThayDoiHinhNem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThayDoiHinhNem));
            this.btnTroVe = new DevExpress.XtraEditors.SimpleButton();
            this.btnChonHinh = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuThongTin = new DevExpress.XtraEditors.SimpleButton();
            this.picHinhAnh = new DevExpress.XtraEditors.PictureEdit();
            this.txtPathHinhAnh = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(519, 475);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(101, 32);
            this.btnTroVe.TabIndex = 1;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Location = new System.Drawing.Point(588, 9);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(38, 23);
            this.btnChonHinh.TabIndex = 2;
            this.btnChonHinh.Text = "...";
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // btnLuuThongTin
            // 
            this.btnLuuThongTin.Enabled = false;
            this.btnLuuThongTin.Location = new System.Drawing.Point(412, 475);
            this.btnLuuThongTin.Name = "btnLuuThongTin";
            this.btnLuuThongTin.Size = new System.Drawing.Size(101, 32);
            this.btnLuuThongTin.TabIndex = 1;
            this.btnLuuThongTin.Text = "Lưu thông tin";
            this.btnLuuThongTin.Click += new System.EventHandler(this.btnLuuThongTin_Click);
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.Location = new System.Drawing.Point(12, 39);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(604, 427);
            this.picHinhAnh.TabIndex = 3;
            // 
            // txtPathHinhAnh
            // 
            this.txtPathHinhAnh.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtPathHinhAnh.bIsReadOnly = true;
            this.txtPathHinhAnh.Location = new System.Drawing.Point(12, 11);
            this.txtPathHinhAnh.Name = "txtPathHinhAnh";
            this.txtPathHinhAnh.sCaption = "Hình ảnh";
            this.txtPathHinhAnh.SelectionStart = 0;
            this.txtPathHinhAnh.Size = new System.Drawing.Size(572, 20);
            this.txtPathHinhAnh.TabIndex = 0;
            // 
            // frmThayDoiHinhNem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 513);
            this.Controls.Add(this.picHinhAnh);
            this.Controls.Add(this.btnChonHinh);
            this.Controls.Add(this.btnLuuThongTin);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.txtPathHinhAnh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThayDoiHinhNem";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi hình nền";
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BSC_HRM.NET.BSC_User_Control.uTextBox txtPathHinhAnh;
        private DevExpress.XtraEditors.SimpleButton btnTroVe;
        private DevExpress.XtraEditors.SimpleButton btnChonHinh;
        private DevExpress.XtraEditors.SimpleButton btnLuuThongTin;
        private DevExpress.XtraEditors.PictureEdit picHinhAnh;
    }
}