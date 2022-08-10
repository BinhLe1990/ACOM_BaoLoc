namespace DELFI_WHM.NET.HeThong.FrND
{
    partial class frmKhoaNguoiDung
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtXacNhan = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbxNGUOIDUNG = new DevExpress.XtraEditors.LookUpEdit();
            this.btnTroLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.chkKhoa = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNGUOIDUNG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkKhoa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chkKhoa);
            this.panelControl1.Controls.Add(this.txtXacNhan);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cbxNGUOIDUNG);
            this.panelControl1.Location = new System.Drawing.Point(12, 11);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(298, 99);
            this.panelControl1.TabIndex = 3;
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtXacNhan.bIsPassword = true;
            this.txtXacNhan.iWidth = 70;
            this.txtXacNhan.Location = new System.Drawing.Point(14, 39);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.sCaption = "Lý do:";
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
            this.btnTroLai.Location = new System.Drawing.Point(210, 124);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(100, 27);
            this.btnTroLai.TabIndex = 5;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Location = new System.Drawing.Point(78, 124);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(126, 27);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Khóa người dùng";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // chkKhoa
            // 
            this.chkKhoa.Location = new System.Drawing.Point(84, 65);
            this.chkKhoa.Name = "chkKhoa";
            this.chkKhoa.Properties.Caption = "Xác nhận khóa người dùng";
            this.chkKhoa.Size = new System.Drawing.Size(199, 19);
            this.chkKhoa.TabIndex = 11;
            // 
            // frmKhoaNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 162);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnLuu);
            this.Name = "frmKhoaNguoiDung";
            this.Text = "frmKhoaNguoiDung";
            this.Load += new System.EventHandler(this.frmKhoaNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNGUOIDUNG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkKhoa.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DELFI_User_Control.uTextBox txtXacNhan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cbxNGUOIDUNG;
        private DevExpress.XtraEditors.SimpleButton btnTroLai;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.CheckEdit chkKhoa;
    }
}