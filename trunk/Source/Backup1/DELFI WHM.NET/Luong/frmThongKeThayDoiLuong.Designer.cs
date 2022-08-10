namespace DELFI_WHM.NET.Luong
{
    partial class frmThongKeThayDoiLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeThayDoiLuong));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnLocDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.raTangGiam = new DevExpress.XtraEditors.RadioGroup();
            this.dtg = new DELFI_WHM.NET.DELFI_User_Control.uDataGrid();
            this.cbxPhongBan = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cbxPhanHe = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cbxCoSo = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.txtNam = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.txtThang = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raTangGiam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.raTangGiam);
            this.panelControl1.Controls.Add(this.btnLocDanhSach);
            this.panelControl1.Controls.Add(this.btnIn);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.cbxPhongBan);
            this.panelControl1.Controls.Add(this.cbxPhanHe);
            this.panelControl1.Controls.Add(this.cbxCoSo);
            this.panelControl1.Controls.Add(this.txtNam);
            this.panelControl1.Controls.Add(this.txtThang);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(220, 544);
            this.panelControl1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "btnSave.LargeGlyph.png");
            this.imageList1.Images.SetKeyName(1, "Exit.png");
            this.imageList1.Images.SetKeyName(2, "Ok.png");
            this.imageList1.Images.SetKeyName(3, "Print.png");
            this.imageList1.Images.SetKeyName(4, "Search.png");
            // 
            // btnLocDanhSach
            // 
            this.btnLocDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLocDanhSach.ImageIndex = 4;
            this.btnLocDanhSach.ImageList = this.imageList1;
            this.btnLocDanhSach.Location = new System.Drawing.Point(2, 443);
            this.btnLocDanhSach.Name = "btnLocDanhSach";
            this.btnLocDanhSach.Size = new System.Drawing.Size(216, 33);
            this.btnLocDanhSach.TabIndex = 13;
            this.btnLocDanhSach.Text = "Lọc dữ liệu";
            this.btnLocDanhSach.Click += new System.EventHandler(this.btnLocDanhSach_Click);
            // 
            // btnIn
            // 
            this.btnIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIn.ImageIndex = 3;
            this.btnIn.ImageList = this.imageList1;
            this.btnIn.Location = new System.Drawing.Point(2, 476);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(216, 33);
            this.btnIn.TabIndex = 12;
            this.btnIn.Text = "In danh sách";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.ImageIndex = 1;
            this.btnThoat.ImageList = this.imageList1;
            this.btnThoat.Location = new System.Drawing.Point(2, 509);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(216, 33);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // raTangGiam
            // 
            this.raTangGiam.Dock = System.Windows.Forms.DockStyle.Top;
            this.raTangGiam.EditValue = 1;
            this.raTangGiam.Location = new System.Drawing.Point(2, 107);
            this.raTangGiam.Name = "raTangGiam";
            this.raTangGiam.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Tất cả"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Tăng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Giảm")});
            this.raTangGiam.Size = new System.Drawing.Size(216, 33);
            this.raTangGiam.TabIndex = 14;
            // 
            // dtg
            // 
            this.dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(220, 0);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(780, 544);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 1;
            this.dtg.uDataSource = null;
            // 
            // cbxPhongBan
            // 
            this.cbxPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxPhongBan.iWidth = 60;
            this.cbxPhongBan.Location = new System.Drawing.Point(2, 86);
            this.cbxPhongBan.Name = "cbxPhongBan";
            this.cbxPhongBan.sCaption = "Phòng ban";
            this.cbxPhongBan.sField = "";
            this.cbxPhongBan.Size = new System.Drawing.Size(216, 21);
            this.cbxPhongBan.TabIndex = 10;
            this.cbxPhongBan.uDisplayMember = "TENPHONGBAN";
            this.cbxPhongBan.uEditValue = null;
            this.cbxPhongBan.uTableName = "DM_PhongBan";
            this.cbxPhongBan.uValueMember = "MAPHONGBAN";
            // 
            // cbxPhanHe
            // 
            this.cbxPhanHe.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxPhanHe.iWidth = 60;
            this.cbxPhanHe.Location = new System.Drawing.Point(2, 65);
            this.cbxPhanHe.Name = "cbxPhanHe";
            this.cbxPhanHe.sCaption = "Phân hệ";
            this.cbxPhanHe.sField = "";
            this.cbxPhanHe.Size = new System.Drawing.Size(216, 21);
            this.cbxPhanHe.TabIndex = 9;
            this.cbxPhanHe.uDisplayMember = "TENPHANHE";
            this.cbxPhanHe.uEditValue = null;
            this.cbxPhanHe.uTableName = "DM_PhanHe";
            this.cbxPhanHe.uValueMember = "MAPHANHE";
            // 
            // cbxCoSo
            // 
            this.cbxCoSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxCoSo.iWidth = 60;
            this.cbxCoSo.Location = new System.Drawing.Point(2, 44);
            this.cbxCoSo.Name = "cbxCoSo";
            this.cbxCoSo.sCaption = "Cơ sở";
            this.cbxCoSo.sField = "";
            this.cbxCoSo.Size = new System.Drawing.Size(216, 21);
            this.cbxCoSo.TabIndex = 8;
            this.cbxCoSo.uDisplayMember = "TENCOSO";
            this.cbxCoSo.uEditValue = null;
            this.cbxCoSo.uTableName = "DM_COSO";
            this.cbxCoSo.uValueMember = "MACOSO";
            // 
            // txtNam
            // 
            this.txtNam.bHAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtNam.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNam.iWidth = 60;
            this.txtNam.Location = new System.Drawing.Point(2, 23);
            this.txtNam.Name = "txtNam";
            this.txtNam.sCaption = "Năm";
            this.txtNam.Size = new System.Drawing.Size(216, 21);
            this.txtNam.TabIndex = 6;
            this.txtNam.uEditValue = new decimal(new int[] {
            9990,
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
            this.txtNam.uText = "9990";
            this.txtNam.uValue = new decimal(new int[] {
            9990,
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
            this.txtThang.Size = new System.Drawing.Size(216, 21);
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
            // frmThongKeThayDoiLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 544);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmThongKeThayDoiLuong";
            this.Text = "Thống kê thay đổi lương";
            this.Load += new System.EventHandler(this.frmThongKeThayDoiLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raTangGiam.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DELFI_WHM.NET.DELFI_User_Control.uDataGrid dtg;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cbxPhongBan;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cbxPhanHe;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cbxCoSo;
        private DELFI_WHM.NET.DELFI_User_Control.uSpinEdit txtNam;
        private DELFI_WHM.NET.DELFI_User_Control.uSpinEdit txtThang;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton btnLocDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.RadioGroup raTangGiam;
    }
}