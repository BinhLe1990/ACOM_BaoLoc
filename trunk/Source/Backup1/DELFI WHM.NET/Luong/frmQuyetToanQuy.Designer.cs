namespace DELFI_WHM.NET.Luong
{
    partial class frmQuyetToanQuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuyetToanQuy));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLocDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnTinhThue = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.cbxDonVi = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cbxPhongBan = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cbxPhanHe = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cbxCoSo = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.raQuy = new DevExpress.XtraEditors.RadioGroup();
            this.txtNam = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.dtg = new DELFI_WHM.NET.DELFI_User_Control.uDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raQuy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLocDuLieu);
            this.panelControl1.Controls.Add(this.btnTinhThue);
            this.panelControl1.Controls.Add(this.btnCapNhat);
            this.panelControl1.Controls.Add(this.btnIn);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.cbxDonVi);
            this.panelControl1.Controls.Add(this.cbxPhongBan);
            this.panelControl1.Controls.Add(this.cbxPhanHe);
            this.panelControl1.Controls.Add(this.cbxCoSo);
            this.panelControl1.Controls.Add(this.raQuy);
            this.panelControl1.Controls.Add(this.txtNam);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(267, 555);
            this.panelControl1.TabIndex = 0;
            // 
            // btnLocDuLieu
            // 
            this.btnLocDuLieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLocDuLieu.ImageIndex = 4;
            this.btnLocDuLieu.ImageList = this.imageList1;
            this.btnLocDuLieu.Location = new System.Drawing.Point(2, 383);
            this.btnLocDuLieu.Name = "btnLocDuLieu";
            this.btnLocDuLieu.Size = new System.Drawing.Size(263, 34);
            this.btnLocDuLieu.TabIndex = 6;
            this.btnLocDuLieu.Text = "Lọc dữ liệu";
            this.btnLocDuLieu.Click += new System.EventHandler(this.btnLocDuLieu_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Exit.png");
            this.imageList1.Images.SetKeyName(1, "fileSaveAsItem1.LargeGlyph.png");
            this.imageList1.Images.SetKeyName(2, "history.png");
            this.imageList1.Images.SetKeyName(3, "Print.png");
            this.imageList1.Images.SetKeyName(4, "Search.png");
            // 
            // btnTinhThue
            // 
            this.btnTinhThue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTinhThue.ImageIndex = 2;
            this.btnTinhThue.ImageList = this.imageList1;
            this.btnTinhThue.Location = new System.Drawing.Point(2, 417);
            this.btnTinhThue.Name = "btnTinhThue";
            this.btnTinhThue.Size = new System.Drawing.Size(263, 34);
            this.btnTinhThue.TabIndex = 6;
            this.btnTinhThue.Text = "Tính thuế TNCN";
            this.btnTinhThue.Click += new System.EventHandler(this.btnTinhThue_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCapNhat.ImageIndex = 1;
            this.btnCapNhat.ImageList = this.imageList1;
            this.btnCapNhat.Location = new System.Drawing.Point(2, 451);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(263, 34);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIn.ImageIndex = 3;
            this.btnIn.ImageList = this.imageList1;
            this.btnIn.Location = new System.Drawing.Point(2, 485);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(263, 34);
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "In bản thuế";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.ImageIndex = 0;
            this.btnThoat.ImageList = this.imageList1;
            this.btnThoat.Location = new System.Drawing.Point(2, 519);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(263, 34);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbxDonVi
            // 
            this.cbxDonVi.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxDonVi.iWidth = 80;
            this.cbxDonVi.Location = new System.Drawing.Point(2, 119);
            this.cbxDonVi.Name = "cbxDonVi";
            this.cbxDonVi.sCaption = "Đơn vị";
            this.cbxDonVi.sColumnCaption = "Mã đơn vị,Tên đơn vị";
            this.cbxDonVi.sField = "MaDonVi,TenDonVi";
            this.cbxDonVi.Size = new System.Drawing.Size(263, 21);
            this.cbxDonVi.TabIndex = 5;
            this.cbxDonVi.uDisplayMember = "TenDonVi";
            this.cbxDonVi.uEditValue = "";
            this.cbxDonVi.uValueMember = "MaDonVi";
            // 
            // cbxPhongBan
            // 
            this.cbxPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxPhongBan.iWidth = 80;
            this.cbxPhongBan.Location = new System.Drawing.Point(2, 98);
            this.cbxPhongBan.Name = "cbxPhongBan";
            this.cbxPhongBan.sCaption = "Phòng ban";
            this.cbxPhongBan.sColumnCaption = "Mã phòng ban,Tên phòng ban";
            this.cbxPhongBan.sField = "MaPhongBan,TenPhongBan";
            this.cbxPhongBan.Size = new System.Drawing.Size(263, 21);
            this.cbxPhongBan.TabIndex = 4;
            this.cbxPhongBan.uDisplayMember = "TenPhongBan";
            this.cbxPhongBan.uEditValue = "";
            this.cbxPhongBan.uTableName = "DM_PhongBan";
            this.cbxPhongBan.uValueMember = "MaPhongBan";
            this.cbxPhongBan.uEditValueChanged += new System.EventHandler(this.cbxPhongBan_uEditValueChanged);
            // 
            // cbxPhanHe
            // 
            this.cbxPhanHe.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxPhanHe.iWidth = 80;
            this.cbxPhanHe.Location = new System.Drawing.Point(2, 77);
            this.cbxPhanHe.Name = "cbxPhanHe";
            this.cbxPhanHe.sCaption = "Phân hệ";
            this.cbxPhanHe.sColumnCaption = "Mã phân hệ,Tên phân hệ";
            this.cbxPhanHe.sField = "MaPhanHe,TenPhanHe";
            this.cbxPhanHe.Size = new System.Drawing.Size(263, 21);
            this.cbxPhanHe.TabIndex = 3;
            this.cbxPhanHe.uDisplayMember = "TenPhanHe";
            this.cbxPhanHe.uEditValue = "";
            this.cbxPhanHe.uTableName = "DM_PhanHe";
            this.cbxPhanHe.uValueMember = "MaPhanHe";
            this.cbxPhanHe.Load += new System.EventHandler(this.cbxPhanHe_Load);
            // 
            // cbxCoSo
            // 
            this.cbxCoSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxCoSo.iWidth = 80;
            this.cbxCoSo.Location = new System.Drawing.Point(2, 56);
            this.cbxCoSo.Name = "cbxCoSo";
            this.cbxCoSo.sCaption = "Cơ sở";
            this.cbxCoSo.sColumnCaption = "Mã cơ sở,Tên cơ sở";
            this.cbxCoSo.sField = "MaCoSo,TenCoSo";
            this.cbxCoSo.Size = new System.Drawing.Size(263, 21);
            this.cbxCoSo.TabIndex = 2;
            this.cbxCoSo.uDisplayMember = "TenCoSo";
            this.cbxCoSo.uEditValue = null;
            this.cbxCoSo.uTableName = "DM_COSO";
            this.cbxCoSo.uValueMember = "MaCoSo";
            // 
            // raQuy
            // 
            this.raQuy.Dock = System.Windows.Forms.DockStyle.Top;
            this.raQuy.EditValue = 1;
            this.raQuy.Location = new System.Drawing.Point(2, 23);
            this.raQuy.Name = "raQuy";
            this.raQuy.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Quý 1"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Quý 2"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Quý 3"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Quý 4")});
            this.raQuy.Size = new System.Drawing.Size(263, 33);
            this.raQuy.TabIndex = 1;
            // 
            // txtNam
            // 
            this.txtNam.bHAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtNam.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNam.iWidth = 80;
            this.txtNam.Location = new System.Drawing.Point(2, 2);
            this.txtNam.Name = "txtNam";
            this.txtNam.sCaption = "Năm";
            this.txtNam.Size = new System.Drawing.Size(263, 21);
            this.txtNam.TabIndex = 0;
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
            // dtg
            // 
            this.dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(267, 0);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(683, 555);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 1;
            this.dtg.uDataSource = null;
            // 
            // frmQuyetToanQuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 555);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmQuyetToanQuy";
            this.Text = "Quyết toán quý";
            this.Load += new System.EventHandler(this.frmQuyetToanQuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raQuy.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DELFI_WHM.NET.DELFI_User_Control.uDataGrid dtg;
        private DevExpress.XtraEditors.RadioGroup raQuy;
        private DELFI_WHM.NET.DELFI_User_Control.uSpinEdit txtNam;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cbxDonVi;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cbxPhongBan;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cbxPhanHe;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cbxCoSo;
        private DevExpress.XtraEditors.SimpleButton btnLocDuLieu;
        private DevExpress.XtraEditors.SimpleButton btnTinhThue;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.ImageList imageList1;
    }
}