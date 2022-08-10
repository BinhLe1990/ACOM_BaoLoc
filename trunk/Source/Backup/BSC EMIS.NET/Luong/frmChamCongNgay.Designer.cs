﻿namespace BSC_HRM.NET.Luong
{
    partial class frmChamCongNgay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamCongNgay));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cboPhongBan = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnChamDongLoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLocDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.dtpNgayCham = new BSC_HRM.NET.BSC_User_Control.uDateTimePicker();
            this.dtg = new BSC_HRM.NET.BSC_User_Control.uDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.cboPhongBan);
            this.groupControl1.Location = new System.Drawing.Point(2, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 332);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "ĐIỀU KIỆN TÌM KIẾM";
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.iWidth = 65;
            this.cboPhongBan.Location = new System.Drawing.Point(3, 25);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.sCaption = "Phòng ban";
            this.cboPhongBan.sColumnCaption = "Phòng ban,Tên phòng ban";
            this.cboPhongBan.sField = "MAPHONGBAN,TENPHONGBAN";
            this.cboPhongBan.Size = new System.Drawing.Size(195, 21);
            this.cboPhongBan.TabIndex = 0;
            this.cboPhongBan.uDisplayMember = "TENPHONGBAN";
            this.cboPhongBan.uEditValue = null;
            this.cboPhongBan.uTableName = "DM_PHONGBAN";
            this.cboPhongBan.uTextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboPhongBan.uValueMember = "MAPHONGBAN";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl2.Controls.Add(this.btnThoat);
            this.groupControl2.Controls.Add(this.btnIn);
            this.groupControl2.Controls.Add(this.btnCapNhat);
            this.groupControl2.Controls.Add(this.btnChamDongLoat);
            this.groupControl2.Controls.Add(this.btnLocDanhSach);
            this.groupControl2.Location = new System.Drawing.Point(2, 341);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(200, 139);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "THAO TÁC THỰC HIỆN";
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThoat.ImageIndex = 1;
            this.btnThoat.ImageList = this.IML;
            this.btnThoat.Location = new System.Drawing.Point(2, 114);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(196, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Trở về";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // IML
            // 
            this.IML.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IML.ImageStream")));
            this.IML.TransparentColor = System.Drawing.Color.Transparent;
            this.IML.Images.SetKeyName(0, "Search.png");
            this.IML.Images.SetKeyName(1, "Exit.png");
            this.IML.Images.SetKeyName(2, "Save as.png");
            this.IML.Images.SetKeyName(3, "Open file.png");
            this.IML.Images.SetKeyName(4, "Redo.png");
            this.IML.Images.SetKeyName(5, "Cancel.png");
            this.IML.Images.SetKeyName(6, "btnSave.LargeGlyph.png");
            this.IML.Images.SetKeyName(7, "postscript.png");
            this.IML.Images.SetKeyName(8, "Print.png");
            this.IML.Images.SetKeyName(9, "Rotation.png");
            // 
            // btnIn
            // 
            this.btnIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIn.ImageIndex = 7;
            this.btnIn.ImageList = this.IML;
            this.btnIn.Location = new System.Drawing.Point(2, 91);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(196, 23);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In bảng chấm công ngày";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCapNhat.ImageIndex = 2;
            this.btnCapNhat.ImageList = this.IML;
            this.btnCapNhat.Location = new System.Drawing.Point(2, 68);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(196, 23);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnChamDongLoat
            // 
            this.btnChamDongLoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChamDongLoat.ImageIndex = 9;
            this.btnChamDongLoat.ImageList = this.IML;
            this.btnChamDongLoat.Location = new System.Drawing.Point(2, 45);
            this.btnChamDongLoat.Name = "btnChamDongLoat";
            this.btnChamDongLoat.Size = new System.Drawing.Size(196, 23);
            this.btnChamDongLoat.TabIndex = 2;
            this.btnChamDongLoat.Text = "Chấm đồng loạt";
            this.btnChamDongLoat.Click += new System.EventHandler(this.btnChamDongLoat_Click);
            // 
            // btnLocDanhSach
            // 
            this.btnLocDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocDanhSach.ImageIndex = 0;
            this.btnLocDanhSach.ImageList = this.IML;
            this.btnLocDanhSach.Location = new System.Drawing.Point(2, 22);
            this.btnLocDanhSach.Name = "btnLocDanhSach";
            this.btnLocDanhSach.Size = new System.Drawing.Size(196, 23);
            this.btnLocDanhSach.TabIndex = 0;
            this.btnLocDanhSach.Text = "Lọc danh sách";
            this.btnLocDanhSach.Click += new System.EventHandler(this.btnLocDanhSach_Click);
            // 
            // dtpNgayCham
            // 
            this.dtpNgayCham.iWidth = 65;
            this.dtpNgayCham.Location = new System.Drawing.Point(5, 51);
            this.dtpNgayCham.Name = "dtpNgayCham";
            this.dtpNgayCham.sCaption = "Ngày chấm";
            this.dtpNgayCham.Size = new System.Drawing.Size(195, 21);
            this.dtpNgayCham.TabIndex = 1;
            this.dtpNgayCham.uDateTime = new System.DateTime(2012, 2, 23, 9, 52, 53, 832);
            this.dtpNgayCham.uValue = new System.DateTime(2012, 2, 23, 9, 52, 53, 832);
            // 
            // dtg
            // 
            this.dtg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(208, 3);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(771, 475);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 0;
            this.dtg.uDataSource = null;
            // 
            // frmChamCongNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 482);
            this.Controls.Add(this.dtpNgayCham);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dtg);
            this.Name = "frmChamCongNgay";
            this.Text = "Chấm công ngày";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BSC_HRM.NET.BSC_User_Control.uDataGrid dtg;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnChamDongLoat;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnLocDanhSach;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cboPhongBan;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private BSC_HRM.NET.BSC_User_Control.uDateTimePicker dtpNgayCham;
        private System.Windows.Forms.ImageList IML;
    }
}