namespace DELFI_WHM.NET.Luong
{
    partial class frmThanhToanLuongQuaATM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhToanLuongQuaATM));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupThaoTac = new DevExpress.XtraEditors.GroupControl();
            this.btnLocDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.groupLoc = new DevExpress.XtraEditors.GroupControl();
            this.txtThang = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.txtNam = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.cbxCoSo = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cbxPhongBan = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cbxPhanHe = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.dtg = new DELFI_WHM.NET.DELFI_User_Control.uDataGrid();
            this.raLuong = new DevExpress.XtraEditors.RadioGroup();
            this.raThang = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupThaoTac)).BeginInit();
            this.groupThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupLoc)).BeginInit();
            this.groupLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raThang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupThaoTac);
            this.panelControl1.Controls.Add(this.groupLoc);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(256, 572);
            this.panelControl1.TabIndex = 1;
            // 
            // groupThaoTac
            // 
            this.groupThaoTac.Controls.Add(this.btnLocDuLieu);
            this.groupThaoTac.Controls.Add(this.btnThoat);
            this.groupThaoTac.Controls.Add(this.btnIn);
            this.groupThaoTac.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupThaoTac.Location = new System.Drawing.Point(2, 475);
            this.groupThaoTac.Name = "groupThaoTac";
            this.groupThaoTac.Size = new System.Drawing.Size(252, 95);
            this.groupThaoTac.TabIndex = 2;
            this.groupThaoTac.Text = "THAO TÁC THỰC HIỆN";
            // 
            // btnLocDuLieu
            // 
            this.btnLocDuLieu.ImageIndex = 0;
            this.btnLocDuLieu.ImageList = this.IML;
            this.btnLocDuLieu.Location = new System.Drawing.Point(7, 24);
            this.btnLocDuLieu.Name = "btnLocDuLieu";
            this.btnLocDuLieu.Size = new System.Drawing.Size(114, 32);
            this.btnLocDuLieu.TabIndex = 7;
            this.btnLocDuLieu.Text = "Lọc dữ liệu";
            this.btnLocDuLieu.Click += new System.EventHandler(this.btnLocDuLieu_Click);
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
            // btnThoat
            // 
            this.btnThoat.ImageIndex = 1;
            this.btnThoat.ImageList = this.IML;
            this.btnThoat.Location = new System.Drawing.Point(7, 59);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(240, 32);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            // 
            // btnIn
            // 
            this.btnIn.ImageIndex = 4;
            this.btnIn.ImageList = this.IML;
            this.btnIn.Location = new System.Drawing.Point(127, 24);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(120, 32);
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "In danh sách";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // groupLoc
            // 
            this.groupLoc.Controls.Add(this.raThang);
            this.groupLoc.Controls.Add(this.raLuong);
            this.groupLoc.Controls.Add(this.txtThang);
            this.groupLoc.Controls.Add(this.txtNam);
            this.groupLoc.Controls.Add(this.cbxCoSo);
            this.groupLoc.Controls.Add(this.cbxPhongBan);
            this.groupLoc.Controls.Add(this.cbxPhanHe);
            this.groupLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupLoc.Location = new System.Drawing.Point(2, 2);
            this.groupLoc.Name = "groupLoc";
            this.groupLoc.Size = new System.Drawing.Size(252, 171);
            this.groupLoc.TabIndex = 2;
            this.groupLoc.Text = "ĐIỀU KIỆN LỌC";
            // 
            // txtThang
            // 
            this.txtThang.bHAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtThang.iWidth = 60;
            this.txtThang.Location = new System.Drawing.Point(4, 25);
            this.txtThang.Name = "txtThang";
            this.txtThang.sCaption = "Tháng";
            this.txtThang.Size = new System.Drawing.Size(130, 22);
            this.txtThang.TabIndex = 0;
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
            // txtNam
            // 
            this.txtNam.bHAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtNam.iWidth = 40;
            this.txtNam.Location = new System.Drawing.Point(139, 25);
            this.txtNam.Name = "txtNam";
            this.txtNam.sCaption = "Năm";
            this.txtNam.Size = new System.Drawing.Size(109, 20);
            this.txtNam.TabIndex = 1;
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
            // cbxCoSo
            // 
            this.cbxCoSo.iWidth = 60;
            this.cbxCoSo.Location = new System.Drawing.Point(4, 47);
            this.cbxCoSo.Name = "cbxCoSo";
            this.cbxCoSo.sCaption = "Cơ sở";
            this.cbxCoSo.sColumnCaption = "Mã cơ sở,Tên cơ sở";
            this.cbxCoSo.sField = "MACOSO,TENCOSO";
            this.cbxCoSo.Size = new System.Drawing.Size(244, 22);
            this.cbxCoSo.TabIndex = 2;
            this.cbxCoSo.uDisplayMember = "TENCOSO";
            this.cbxCoSo.uEditValue = "";
            this.cbxCoSo.uTableName = "DM_COSO";
            this.cbxCoSo.uValueMember = "MACOSO";
            // 
            // cbxPhongBan
            // 
            this.cbxPhongBan.iWidth = 60;
            this.cbxPhongBan.Location = new System.Drawing.Point(4, 91);
            this.cbxPhongBan.Name = "cbxPhongBan";
            this.cbxPhongBan.sCaption = "Phòng ban";
            this.cbxPhongBan.sColumnCaption = "Mã phòng ban,Tên phòng ban";
            this.cbxPhongBan.sField = "MAPHONGBAN,TENPHONGBAN";
            this.cbxPhongBan.Size = new System.Drawing.Size(244, 22);
            this.cbxPhongBan.TabIndex = 4;
            this.cbxPhongBan.uDisplayMember = "TENPHONGBAN";
            this.cbxPhongBan.uEditValue = "";
            this.cbxPhongBan.uTableName = "DM_PHONGBAN";
            this.cbxPhongBan.uValueMember = "MAPHONGBAN";
            // 
            // cbxPhanHe
            // 
            this.cbxPhanHe.iWidth = 60;
            this.cbxPhanHe.Location = new System.Drawing.Point(4, 69);
            this.cbxPhanHe.Name = "cbxPhanHe";
            this.cbxPhanHe.sCaption = "Phân hệ";
            this.cbxPhanHe.sColumnCaption = "Mã phân hệ,Tên phân hệ";
            this.cbxPhanHe.sField = "MAPHANHE,TENPHANHE";
            this.cbxPhanHe.Size = new System.Drawing.Size(244, 22);
            this.cbxPhanHe.TabIndex = 3;
            this.cbxPhanHe.uDisplayMember = "TENPHANHE";
            this.cbxPhanHe.uEditValue = "";
            this.cbxPhanHe.uTableName = "DM_PHANHE";
            this.cbxPhanHe.uValueMember = "MAPHANHE";
            // 
            // dtg
            // 
            this.dtg.bAllowEdit = true;
            this.dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(256, 0);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(727, 572);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 2;
            this.dtg.uDataSource = null;
            // 
            // raLuong
            // 
            this.raLuong.EditValue = ((short)(0));
            this.raLuong.Location = new System.Drawing.Point(63, 113);
            this.raLuong.Name = "raLuong";
            this.raLuong.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Bảng lương"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Phụ cấp ABC")});
            this.raLuong.Size = new System.Drawing.Size(185, 25);
            this.raLuong.TabIndex = 14;
            this.raLuong.SelectedIndexChanged += new System.EventHandler(this.raLuong_SelectedIndexChanged);
            // 
            // raThang
            // 
            this.raThang.EditValue = ((short)(0));
            this.raThang.Location = new System.Drawing.Point(3, 140);
            this.raThang.Name = "raThang";
            this.raThang.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "6 tháng đầu năm"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "6 tháng cuối năm")});
            this.raThang.Size = new System.Drawing.Size(245, 25);
            this.raThang.TabIndex = 15;
            this.raThang.Visible = false;
            // 
            // frmThanhToanLuongQuaATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 572);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmThanhToanLuongQuaATM";
            this.Text = "Thanh toán lương qua ATM";
            this.Load += new System.EventHandler(this.frmThanhToanLuongQuaATM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupThaoTac)).EndInit();
            this.groupThaoTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupLoc)).EndInit();
            this.groupLoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raThang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupThaoTac;
        private DevExpress.XtraEditors.SimpleButton btnLocDuLieu;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.GroupControl groupLoc;
        private DELFI_WHM.NET.DELFI_User_Control.uSpinEdit txtThang;
        private DELFI_WHM.NET.DELFI_User_Control.uSpinEdit txtNam;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cbxCoSo;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cbxPhongBan;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cbxPhanHe;
        private DELFI_WHM.NET.DELFI_User_Control.uDataGrid dtg;
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraEditors.RadioGroup raLuong;
        private DevExpress.XtraEditors.RadioGroup raThang;
    }
}