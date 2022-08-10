namespace DELFI_WHM.NET
{
    partial class frmThongTinCoQuan
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
            this.txtReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenCoQuan = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.uTextBox1 = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtTPKinhDoanh = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtTPKeToan = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtTPKyThuat = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtGiamDoc = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtDiaDiem = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtEmail = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtWebsite = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtFax = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtDienThoai = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtDiaChi = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.uTextBox2 = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtCoQuanChuQuan = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtID = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.SuspendLayout();
            // 
            // txtReset
            // 
            this.txtReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReset.Location = new System.Drawing.Point(105, 364);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(100, 25);
            this.txtReset.TabIndex = 14;
            this.txtReset.Text = "Nhập lại";
            this.txtReset.Click += new System.EventHandler(this.txtReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(211, 364);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 25);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(317, 364);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 25);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTenCoQuan
            // 
            this.txtTenCoQuan.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtTenCoQuan.Location = new System.Drawing.Point(5, 4);
            this.txtTenCoQuan.Name = "txtTenCoQuan";
            this.txtTenCoQuan.sCaption = "Tên cơ quan";
            this.txtTenCoQuan.SelectionStart = 0;
            this.txtTenCoQuan.Size = new System.Drawing.Size(412, 21);
            this.txtTenCoQuan.TabIndex = 0;
            this.txtTenCoQuan.Tag = "..TENCOQUAN";
            this.txtTenCoQuan.uKeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenCoQuan_KeyDown);
            // 
            // uTextBox1
            // 
            this.uTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uTextBox1.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.uTextBox1.Location = new System.Drawing.Point(5, 337);
            this.uTextBox1.Name = "uTextBox1";
            this.uTextBox1.sCaption = "Đường dẫn máy chủ";
            this.uTextBox1.SelectionStart = 0;
            this.uTextBox1.Size = new System.Drawing.Size(412, 20);
            this.uTextBox1.TabIndex = 13;
            this.uTextBox1.Tag = "..PATHSERVER";
            // 
            // txtTPKinhDoanh
            // 
            this.txtTPKinhDoanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTPKinhDoanh.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtTPKinhDoanh.Location = new System.Drawing.Point(5, 311);
            this.txtTPKinhDoanh.Name = "txtTPKinhDoanh";
            this.txtTPKinhDoanh.sCaption = "TP. Kinh Doanh";
            this.txtTPKinhDoanh.SelectionStart = 0;
            this.txtTPKinhDoanh.Size = new System.Drawing.Size(412, 20);
            this.txtTPKinhDoanh.TabIndex = 12;
            this.txtTPKinhDoanh.Tag = "..TPQLSV";
            // 
            // txtTPKeToan
            // 
            this.txtTPKeToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTPKeToan.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtTPKeToan.Location = new System.Drawing.Point(5, 285);
            this.txtTPKeToan.Name = "txtTPKeToan";
            this.txtTPKeToan.sCaption = "TP. Kế toán";
            this.txtTPKeToan.SelectionStart = 0;
            this.txtTPKeToan.Size = new System.Drawing.Size(412, 20);
            this.txtTPKeToan.TabIndex = 11;
            this.txtTPKeToan.Tag = "..TPTAIVU";
            // 
            // txtTPKyThuat
            // 
            this.txtTPKyThuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTPKyThuat.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtTPKyThuat.Location = new System.Drawing.Point(5, 259);
            this.txtTPKyThuat.Name = "txtTPKyThuat";
            this.txtTPKyThuat.sCaption = "TP. Kỹ Thuật";
            this.txtTPKyThuat.SelectionStart = 0;
            this.txtTPKyThuat.Size = new System.Drawing.Size(412, 20);
            this.txtTPKyThuat.TabIndex = 10;
            this.txtTPKyThuat.Tag = "..TPDAOTAO";
            // 
            // txtGiamDoc
            // 
            this.txtGiamDoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiamDoc.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtGiamDoc.Location = new System.Drawing.Point(5, 233);
            this.txtGiamDoc.Name = "txtGiamDoc";
            this.txtGiamDoc.sCaption = "Giám Đốc";
            this.txtGiamDoc.SelectionStart = 0;
            this.txtGiamDoc.Size = new System.Drawing.Size(412, 20);
            this.txtGiamDoc.TabIndex = 9;
            this.txtGiamDoc.Tag = "..HIEUTRUONG";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaDiem.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtDiaDiem.Location = new System.Drawing.Point(5, 207);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.sCaption = "Địa điểm";
            this.txtDiaDiem.SelectionStart = 0;
            this.txtDiaDiem.Size = new System.Drawing.Size(412, 20);
            this.txtDiaDiem.TabIndex = 8;
            this.txtDiaDiem.Tag = "..DIADIEM";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtEmail.Location = new System.Drawing.Point(5, 181);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.sCaption = "Email";
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(412, 20);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Tag = "..MAIL";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWebsite.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtWebsite.Location = new System.Drawing.Point(5, 155);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.sCaption = "Website";
            this.txtWebsite.SelectionStart = 0;
            this.txtWebsite.Size = new System.Drawing.Size(412, 20);
            this.txtWebsite.TabIndex = 6;
            this.txtWebsite.Tag = "..WEBSITE";
            // 
            // txtFax
            // 
            this.txtFax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFax.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtFax.Location = new System.Drawing.Point(5, 129);
            this.txtFax.Name = "txtFax";
            this.txtFax.sCaption = "Số Fax";
            this.txtFax.SelectionStart = 0;
            this.txtFax.Size = new System.Drawing.Size(412, 20);
            this.txtFax.TabIndex = 5;
            this.txtFax.Tag = "..FAX";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDienThoai.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtDienThoai.Location = new System.Drawing.Point(5, 104);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.sCaption = "Điện thoại";
            this.txtDienThoai.SelectionStart = 0;
            this.txtDienThoai.Size = new System.Drawing.Size(412, 20);
            this.txtDienThoai.TabIndex = 4;
            this.txtDienThoai.Tag = "..DIENTHOAI";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtDiaChi.Location = new System.Drawing.Point(5, 78);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.sCaption = "Địa chỉ";
            this.txtDiaChi.SelectionStart = 0;
            this.txtDiaChi.Size = new System.Drawing.Size(412, 20);
            this.txtDiaChi.TabIndex = 3;
            this.txtDiaChi.Tag = "..DIACHI";
            // 
            // uTextBox2
            // 
            this.uTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uTextBox2.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.uTextBox2.iWidth = 0;
            this.uTextBox2.Location = new System.Drawing.Point(105, 26);
            this.uTextBox2.Name = "uTextBox2";
            this.uTextBox2.sCaption = "Cơ quan chủ quản";
            this.uTextBox2.SelectionStart = 0;
            this.uTextBox2.Size = new System.Drawing.Size(312, 20);
            this.uTextBox2.TabIndex = 1;
            this.uTextBox2.Tag = "..TENCOQUAN2";
            // 
            // txtCoQuanChuQuan
            // 
            this.txtCoQuanChuQuan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoQuanChuQuan.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtCoQuanChuQuan.Location = new System.Drawing.Point(5, 52);
            this.txtCoQuanChuQuan.Name = "txtCoQuanChuQuan";
            this.txtCoQuanChuQuan.sCaption = "Cơ quan chủ quản";
            this.txtCoQuanChuQuan.SelectionStart = 0;
            this.txtCoQuanChuQuan.Size = new System.Drawing.Size(412, 20);
            this.txtCoQuanChuQuan.TabIndex = 2;
            this.txtCoQuanChuQuan.Tag = "..COQUANCHUQUAN";
            // 
            // txtID
            // 
            this.txtID.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtID.iWidth = 30;
            this.txtID.Location = new System.Drawing.Point(252, 93);
            this.txtID.Name = "txtID";
            this.txtID.sCaption = "ID";
            this.txtID.SelectionStart = 0;
            this.txtID.Size = new System.Drawing.Size(70, 20);
            this.txtID.TabIndex = 15;
            this.txtID.Tag = "..ID";
            this.txtID.Visible = false;
            // 
            // frmThongTinCoQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(425, 397);
            this.Controls.Add(this.txtTenCoQuan);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtReset);
            this.Controls.Add(this.uTextBox1);
            this.Controls.Add(this.txtTPKinhDoanh);
            this.Controls.Add(this.txtTPKeToan);
            this.Controls.Add(this.txtTPKyThuat);
            this.Controls.Add(this.txtGiamDoc);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.uTextBox2);
            this.Controls.Add(this.txtCoQuanChuQuan);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmThongTinCoQuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cơ quan";
            this.Load += new System.EventHandler(this.frmThongTinCoQuan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtCoQuanChuQuan;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtDiaChi;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtDienThoai;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtFax;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtWebsite;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtEmail;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtDiaDiem;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtGiamDoc;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtTPKyThuat;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtTPKeToan;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtTPKinhDoanh;
        private DevExpress.XtraEditors.SimpleButton txtReset;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtID;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox uTextBox1;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox uTextBox2;
        private DELFI_WHM.NET.DELFI_User_Control.uTextBox txtTenCoQuan;
    }
}