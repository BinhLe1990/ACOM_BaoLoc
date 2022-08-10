namespace BSC_HRM.NET.Luong
{
    partial class frmBangPhuCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangPhuCap));
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.cboPhuCap = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.btnNhapDongLoat = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoTien = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.raPhuCap = new DevExpress.XtraEditors.RadioGroup();
            this.cbxPhongBan = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.btnLocDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnXetPhuCap = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnInDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.cbxPhanHe = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxCoSo = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.txtNam = new BSC_HRM.NET.BSC_User_Control.uSpinEdit();
            this.txtThang = new BSC_HRM.NET.BSC_User_Control.uSpinEdit();
            this.dtg = new BSC_HRM.NET.BSC_User_Control.uDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raPhuCap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboPhuCap);
            this.panel1.Controls.Add(this.btnNhapDongLoat);
            this.panel1.Controls.Add(this.txtSoTien);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.raPhuCap);
            this.panel1.Controls.Add(this.cbxPhongBan);
            this.panel1.Controls.Add(this.btnLocDanhSach);
            this.panel1.Controls.Add(this.btnXetPhuCap);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnInDanhSach);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.cbxPhanHe);
            this.panel1.Controls.Add(this.cbxCoSo);
            this.panel1.Controls.Add(this.txtNam);
            this.panel1.Controls.Add(this.txtThang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 523);
            this.panel1.TabIndex = 0;
            // 
            // cboPhuCap
            // 
            this.cboPhuCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboPhuCap.iWidth = 60;
            this.cboPhuCap.Location = new System.Drawing.Point(2, 107);
            this.cboPhuCap.Name = "cboPhuCap";
            this.cboPhuCap.sCaption = "Phụ cấp";
            this.cboPhuCap.sColumnCaption = "Mã phụ cấp khác,Tên phụ cấp khác, Tính thuế";
            this.cboPhuCap.sField = "MAPHUCAPKHAC,TENPHUCAPKHAC, IsTNCN";
            this.cboPhuCap.Size = new System.Drawing.Size(228, 21);
            this.cboPhuCap.sNullText = "";
            this.cboPhuCap.TabIndex = 17;
            this.cboPhuCap.uDisplayMember = "TENPHUCAPKHAC";
            this.cboPhuCap.uEditValue = null;
            this.cboPhuCap.uTableName = "DM_PHUCAPKHAC";
            this.cboPhuCap.uValueMember = "MAPHUCAPKHAC";
            // 
            // btnNhapDongLoat
            // 
            this.btnNhapDongLoat.Location = new System.Drawing.Point(132, 161);
            this.btnNhapDongLoat.Name = "btnNhapDongLoat";
            this.btnNhapDongLoat.Size = new System.Drawing.Size(95, 23);
            this.btnNhapDongLoat.TabIndex = 16;
            this.btnNhapDongLoat.Text = "Nhập đồng loạt";
            this.btnNhapDongLoat.Click += new System.EventHandler(this.btnNhapDongLoat_Click);
            // 
            // txtSoTien
            // 
            this.txtSoTien.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtSoTien.iWidth = 60;
            this.txtSoTien.Location = new System.Drawing.Point(2, 135);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.sCaption = "Số tiền";
            this.txtSoTien.sEditMask = "N00";
            this.txtSoTien.SelectionStart = 0;
            this.txtSoTien.Size = new System.Drawing.Size(228, 20);
            this.txtSoTien.TabIndex = 15;
            this.txtSoTien.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSoTien.uKeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoTien_uKeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl2.Location = new System.Drawing.Point(5, 325);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(221, 26);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "2. Xét phụ cấp : Xét bảng phụ cấp cho tháng hiện tại ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(5, 291);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(221, 26);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "1. Lọc phụ cấp : Lọc lại bảng phụ cấp đã xét";
            // 
            // raPhuCap
            // 
            this.raPhuCap.EditValue = 0;
            this.raPhuCap.Location = new System.Drawing.Point(2, 218);
            this.raPhuCap.Name = "raPhuCap";
            this.raPhuCap.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Phụ cấp trường"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Phụ cấp khoa")});
            this.raPhuCap.Size = new System.Drawing.Size(225, 67);
            this.raPhuCap.TabIndex = 12;
            this.raPhuCap.Visible = false;
            // 
            // cbxPhongBan
            // 
            this.cbxPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxPhongBan.iWidth = 60;
            this.cbxPhongBan.Location = new System.Drawing.Point(2, 86);
            this.cbxPhongBan.Name = "cbxPhongBan";
            this.cbxPhongBan.sCaption = "Phòng ban";
            this.cbxPhongBan.sColumnCaption = "Mã phòng ban,Tên phòng ban";
            this.cbxPhongBan.sField = "MAPHONGBAN,TENPHONGBAN";
            this.cbxPhongBan.Size = new System.Drawing.Size(228, 21);
            this.cbxPhongBan.TabIndex = 11;
            this.cbxPhongBan.uDisplayMember = "TENPHONGBAN";
            this.cbxPhongBan.uEditValue = "";
            this.cbxPhongBan.uTableName = "DM_PHONGBAN";
            this.cbxPhongBan.uValueMember = "MAPHONGBAN";
            // 
            // btnLocDanhSach
            // 
            this.btnLocDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLocDanhSach.ImageIndex = 0;
            this.btnLocDanhSach.ImageList = this.IML;
            this.btnLocDanhSach.Location = new System.Drawing.Point(2, 381);
            this.btnLocDanhSach.Name = "btnLocDanhSach";
            this.btnLocDanhSach.Size = new System.Drawing.Size(228, 28);
            this.btnLocDanhSach.TabIndex = 5;
            this.btnLocDanhSach.Text = "Lọc phụ cấp";
            this.btnLocDanhSach.Click += new System.EventHandler(this.btnLocDanhSach_Click);
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
            this.IML.Images.SetKeyName(7, "Print.png");
            this.IML.Images.SetKeyName(8, "Rotation.png");
            this.IML.Images.SetKeyName(9, "changeFontBackColorItem1.LargeGlyph.png");
            this.IML.Images.SetKeyName(10, "Add.png");
            this.IML.Images.SetKeyName(11, "Yes.png");
            this.IML.Images.SetKeyName(12, "pqsd.png");
            this.IML.Images.SetKeyName(13, "32px-Crystal_Clear_Password.png");
            // 
            // btnXetPhuCap
            // 
            this.btnXetPhuCap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnXetPhuCap.ImageIndex = 8;
            this.btnXetPhuCap.ImageList = this.IML;
            this.btnXetPhuCap.Location = new System.Drawing.Point(2, 409);
            this.btnXetPhuCap.Name = "btnXetPhuCap";
            this.btnXetPhuCap.Size = new System.Drawing.Size(228, 28);
            this.btnXetPhuCap.TabIndex = 6;
            this.btnXetPhuCap.Tag = "ADD";
            this.btnXetPhuCap.Text = "Xét phụ cấp";
            this.btnXetPhuCap.Click += new System.EventHandler(this.btnXetPhuCap_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCapNhat.ImageIndex = 2;
            this.btnCapNhat.ImageList = this.IML;
            this.btnCapNhat.Location = new System.Drawing.Point(2, 437);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(228, 28);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Tag = "EDIT";
            this.btnCapNhat.Text = "Lưu phụ cấp";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInDanhSach.ImageIndex = 7;
            this.btnInDanhSach.ImageList = this.IML;
            this.btnInDanhSach.Location = new System.Drawing.Point(2, 465);
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.Size = new System.Drawing.Size(228, 28);
            this.btnInDanhSach.TabIndex = 5;
            this.btnInDanhSach.Text = "In phụ cấp";
            this.btnInDanhSach.Click += new System.EventHandler(this.btnInDanhSach_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.ImageIndex = 1;
            this.btnThoat.ImageList = this.IML;
            this.btnThoat.Location = new System.Drawing.Point(2, 493);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(228, 28);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbxPhanHe
            // 
            this.cbxPhanHe.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxPhanHe.iWidth = 60;
            this.cbxPhanHe.Location = new System.Drawing.Point(2, 65);
            this.cbxPhanHe.Name = "cbxPhanHe";
            this.cbxPhanHe.sCaption = "Phân hệ";
            this.cbxPhanHe.sField = "";
            this.cbxPhanHe.Size = new System.Drawing.Size(228, 21);
            this.cbxPhanHe.TabIndex = 18;
            this.cbxPhanHe.uDisplayMember = "TENPHANHE";
            this.cbxPhanHe.uEditValue = "";
            this.cbxPhanHe.uTableName = "DM_PHANHE";
            this.cbxPhanHe.uValueMember = "MAPHANHE";
            // 
            // cbxCoSo
            // 
            this.cbxCoSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxCoSo.iWidth = 60;
            this.cbxCoSo.Location = new System.Drawing.Point(2, 44);
            this.cbxCoSo.Name = "cbxCoSo";
            this.cbxCoSo.sCaption = "Cơ sở";
            this.cbxCoSo.sColumnCaption = "Mã cơ sở,Tên cơ sở";
            this.cbxCoSo.sField = "MaCoSo,TenCoSo";
            this.cbxCoSo.Size = new System.Drawing.Size(228, 21);
            this.cbxCoSo.TabIndex = 9;
            this.cbxCoSo.uDisplayMember = "TenCoSo";
            this.cbxCoSo.uEditValue = "";
            this.cbxCoSo.uTableName = "DM_COSO";
            this.cbxCoSo.uValueMember = "MaCoSo";
            // 
            // txtNam
            // 
            this.txtNam.bHAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtNam.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNam.iWidth = 60;
            this.txtNam.Location = new System.Drawing.Point(2, 23);
            this.txtNam.Name = "txtNam";
            this.txtNam.sCaption = "Năm";
            this.txtNam.Size = new System.Drawing.Size(228, 21);
            this.txtNam.TabIndex = 8;
            this.txtNam.uEditValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txtNam.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNam.uMaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtNam.uMinValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txtNam.uText = "2000";
            this.txtNam.uValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // txtThang
            // 
            this.txtThang.bHAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtThang.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtThang.iWidth = 60;
            this.txtThang.Location = new System.Drawing.Point(2, 2);
            this.txtThang.Name = "txtThang";
            this.txtThang.sCaption = "Tháng";
            this.txtThang.Size = new System.Drawing.Size(228, 21);
            this.txtThang.TabIndex = 7;
            this.txtThang.uEditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtThang.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtThang.uMaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtThang.uMinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtThang.uText = "1";
            this.txtThang.uValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtg
            // 
            this.dtg.bAllowEdit = true;
            this.dtg.bMultiSelect = true;
            this.dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(232, 0);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(796, 523);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 1;
            this.dtg.uDataSource = null;
            this.dtg.uCellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.dtg_uCellValueChanged);
            // 
            // frmBangPhuCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 523);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.panel1);
            this.Name = "frmBangPhuCap";
            this.Tag = "|LUONG|";
            this.Text = "Bảng phụ cấp";
            this.Load += new System.EventHandler(this.frmBangPhuCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raPhuCap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraEditors.SimpleButton btnLocDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnInDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraEditors.SimpleButton btnXetPhuCap;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxPhongBan;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxCoSo;
        private BSC_HRM.NET.BSC_User_Control.uSpinEdit txtNam;
        private BSC_HRM.NET.BSC_User_Control.uSpinEdit txtThang;
        private DevExpress.XtraEditors.RadioGroup raPhuCap;
        private BSC_HRM.NET.BSC_User_Control.uDataGrid dtg;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnNhapDongLoat;
        private BSC_HRM.NET.BSC_User_Control.uTextBox txtSoTien;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cboPhuCap;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxPhanHe;
    }
}