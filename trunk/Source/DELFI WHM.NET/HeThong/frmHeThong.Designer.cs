namespace DELFI_WHM.NET.HeThong
{
    partial class frmHeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHeThong));
            this.btnLuuTT = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtServerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDatabase = new DevExpress.XtraEditors.TextEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnKiemTra = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserMysql = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDatabaseMysql = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnCheckMysql = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveMysql = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtServerMySQL = new DevExpress.XtraEditors.TextEdit();
            this.txtPortMysql = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtPasswordMysql = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserMysql.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabaseMysql.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerMySQL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortMysql.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordMysql.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuuTT
            // 
            this.btnLuuTT.Location = new System.Drawing.Point(138, 133);
            this.btnLuuTT.Name = "btnLuuTT";
            this.btnLuuTT.Size = new System.Drawing.Size(101, 26);
            this.btnLuuTT.TabIndex = 5;
            this.btnLuuTT.Text = "Lưu thông tin";
            this.btnLuuTT.Click += new System.EventHandler(this.btnLuuTT_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Server";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(83, 32);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(237, 20);
            this.txtServerName.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Người dùng";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(83, 82);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(237, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(83, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(237, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 60);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Tên CSDL";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(83, 57);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(237, 20);
            this.txtDatabase.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(245, 336);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Đóng lại";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(47, 133);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(85, 26);
            this.btnKiemTra.TabIndex = 4;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 303);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Mật khẩu";
            // 
            // txtUserMysql
            // 
            this.txtUserMysql.Location = new System.Drawing.Point(82, 275);
            this.txtUserMysql.Name = "txtUserMysql";
            this.txtUserMysql.Size = new System.Drawing.Size(237, 20);
            this.txtUserMysql.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 278);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Người dùng";
            // 
            // txtDatabaseMysql
            // 
            this.txtDatabaseMysql.Location = new System.Drawing.Point(82, 250);
            this.txtDatabaseMysql.Name = "txtDatabaseMysql";
            this.txtDatabaseMysql.Size = new System.Drawing.Size(237, 20);
            this.txtDatabaseMysql.TabIndex = 8;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(13, 253);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(46, 13);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Tên CSDL";
            // 
            // btnCheckMysql
            // 
            this.btnCheckMysql.Location = new System.Drawing.Point(47, 336);
            this.btnCheckMysql.Name = "btnCheckMysql";
            this.btnCheckMysql.Size = new System.Drawing.Size(85, 26);
            this.btnCheckMysql.TabIndex = 15;
            this.btnCheckMysql.Text = "Kiểm tra";
            this.btnCheckMysql.Click += new System.EventHandler(this.btnCheckMysql_Click);
            // 
            // btnSaveMysql
            // 
            this.btnSaveMysql.Location = new System.Drawing.Point(138, 336);
            this.btnSaveMysql.Name = "btnSaveMysql";
            this.btnSaveMysql.Size = new System.Drawing.Size(101, 26);
            this.btnSaveMysql.TabIndex = 16;
            this.btnSaveMysql.Text = "Lưu thông tin";
            this.btnSaveMysql.Click += new System.EventHandler(this.btnSaveMysql_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(14, 201);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(32, 13);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Server";
            // 
            // txtServerMySQL
            // 
            this.txtServerMySQL.Location = new System.Drawing.Point(83, 198);
            this.txtServerMySQL.Name = "txtServerMySQL";
            this.txtServerMySQL.Size = new System.Drawing.Size(237, 20);
            this.txtServerMySQL.TabIndex = 7;
            // 
            // txtPortMysql
            // 
            this.txtPortMysql.EditValue = "1";
            this.txtPortMysql.Location = new System.Drawing.Point(82, 224);
            this.txtPortMysql.Name = "txtPortMysql";
            this.txtPortMysql.Size = new System.Drawing.Size(237, 20);
            this.txtPortMysql.TabIndex = 17;
            this.txtPortMysql.Visible = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(13, 227);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(20, 13);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Port";
            this.labelControl9.Visible = false;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(122, 12);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(147, 13);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "Thông tin kết nối dữ liệu nội bộ";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(122, 179);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(144, 13);
            this.labelControl11.TabIndex = 20;
            this.labelControl11.Text = "Thông tin kết nối dữ liệu mạng";
            // 
            // txtPasswordMysql
            // 
            this.txtPasswordMysql.Location = new System.Drawing.Point(82, 301);
            this.txtPasswordMysql.Name = "txtPasswordMysql";
            this.txtPasswordMysql.Size = new System.Drawing.Size(237, 20);
            this.txtPasswordMysql.TabIndex = 21;
            // 
            // frmHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 383);
            this.Controls.Add(this.txtPasswordMysql);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtPortMysql);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.btnSaveMysql);
            this.Controls.Add(this.btnCheckMysql);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtUserMysql);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtServerMySQL);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtDatabaseMysql);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.btnLuuTT);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.labelControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông số đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHeThong_FormClosing);
            this.Load += new System.EventHandler(this.frmHeThong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserMysql.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabaseMysql.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerMySQL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortMysql.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordMysql.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLuuTT;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtServerName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDatabase;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnKiemTra;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtUserMysql;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtDatabaseMysql;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnCheckMysql;
        private DevExpress.XtraEditors.SimpleButton btnSaveMysql;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtServerMySQL;
        private DevExpress.XtraEditors.TextEdit txtPortMysql;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtPasswordMysql;
    }
}