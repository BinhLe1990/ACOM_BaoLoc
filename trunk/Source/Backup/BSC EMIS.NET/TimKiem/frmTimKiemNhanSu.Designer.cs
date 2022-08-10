namespace BSC_HRM.NET.TimKiem
{
    partial class frmTimKiemNhanSu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemNhanSu));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLocDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.cbxDonVi = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxPhongBan = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxPhanHe = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxCoSo = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.dtg = new BSC_HRM.NET.BSC_User_Control.uDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLocDanhSach);
            this.panelControl1.Controls.Add(this.btnChon);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.cbxDonVi);
            this.panelControl1.Controls.Add(this.cbxPhongBan);
            this.panelControl1.Controls.Add(this.cbxPhanHe);
            this.panelControl1.Controls.Add(this.cbxCoSo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(211, 545);
            this.panelControl1.TabIndex = 0;
            // 
            // btnLocDanhSach
            // 
            this.btnLocDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLocDanhSach.ImageIndex = 2;
            this.btnLocDanhSach.ImageList = this.imageList1;
            this.btnLocDanhSach.Location = new System.Drawing.Point(2, 447);
            this.btnLocDanhSach.Name = "btnLocDanhSach";
            this.btnLocDanhSach.Size = new System.Drawing.Size(207, 32);
            this.btnLocDanhSach.TabIndex = 6;
            this.btnLocDanhSach.Text = "Lọc danh sách";
            this.btnLocDanhSach.Click += new System.EventHandler(this.btnLocDanhSach_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Exit.png");
            this.imageList1.Images.SetKeyName(1, "Ok.png");
            this.imageList1.Images.SetKeyName(2, "Search.png");
            // 
            // btnChon
            // 
            this.btnChon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChon.ImageIndex = 1;
            this.btnChon.ImageList = this.imageList1;
            this.btnChon.Location = new System.Drawing.Point(2, 479);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(207, 32);
            this.btnChon.TabIndex = 5;
            this.btnChon.Text = "Chọn danh sách";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.ImageIndex = 0;
            this.btnThoat.ImageList = this.imageList1;
            this.btnThoat.Location = new System.Drawing.Point(2, 511);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(207, 32);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbxDonVi
            // 
            this.cbxDonVi.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxDonVi.iWidth = 60;
            this.cbxDonVi.Location = new System.Drawing.Point(2, 65);
            this.cbxDonVi.Name = "cbxDonVi";
            this.cbxDonVi.sCaption = "Đơn vị";
            this.cbxDonVi.sColumnCaption = "Mã đơn vị,Tên đơn vị";
            this.cbxDonVi.sField = "MADONVI,TENDONVI";
            this.cbxDonVi.Size = new System.Drawing.Size(207, 21);
            this.cbxDonVi.TabIndex = 3;
            this.cbxDonVi.uDisplayMember = "TENDONVI";
            this.cbxDonVi.uEditValue = null;
            this.cbxDonVi.uValueMember = "MADONVI";
            // 
            // cbxPhongBan
            // 
            this.cbxPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxPhongBan.iWidth = 60;
            this.cbxPhongBan.Location = new System.Drawing.Point(2, 44);
            this.cbxPhongBan.Name = "cbxPhongBan";
            this.cbxPhongBan.sCaption = "Phòng ban";
            this.cbxPhongBan.sColumnCaption = "Mã phòng ban,Tên phòng ban";
            this.cbxPhongBan.sField = "MAPHONGBAN,TENPHONGBAN";
            this.cbxPhongBan.Size = new System.Drawing.Size(207, 21);
            this.cbxPhongBan.TabIndex = 2;
            this.cbxPhongBan.uDisplayMember = "TENPHONGBAN";
            this.cbxPhongBan.uEditValue = "";
            this.cbxPhongBan.uTableName = "DM_PHONGBAN";
            this.cbxPhongBan.uValueMember = "MAPHONGBAN";
            this.cbxPhongBan.uEditValueChanged += new System.EventHandler(this.cbxPhongBan_uEditValueChanged);
            // 
            // cbxPhanHe
            // 
            this.cbxPhanHe.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxPhanHe.iWidth = 60;
            this.cbxPhanHe.Location = new System.Drawing.Point(2, 23);
            this.cbxPhanHe.Name = "cbxPhanHe";
            this.cbxPhanHe.sCaption = "Phân hệ";
            this.cbxPhanHe.sColumnCaption = "Mã phân hệ,Tên phân hệ";
            this.cbxPhanHe.sField = "MAPHANHE,TENPHANHE";
            this.cbxPhanHe.Size = new System.Drawing.Size(207, 21);
            this.cbxPhanHe.TabIndex = 1;
            this.cbxPhanHe.uDisplayMember = "TENPHANHE";
            this.cbxPhanHe.uEditValue = "";
            this.cbxPhanHe.uTableName = "DM_PHANHE";
            this.cbxPhanHe.uValueMember = "MAPHANHE";
            // 
            // cbxCoSo
            // 
            this.cbxCoSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxCoSo.iWidth = 60;
            this.cbxCoSo.Location = new System.Drawing.Point(2, 2);
            this.cbxCoSo.Name = "cbxCoSo";
            this.cbxCoSo.sCaption = "Cơ sở";
            this.cbxCoSo.sColumnCaption = "Mã cơ sở,Tên cơ sở";
            this.cbxCoSo.sField = "MACOSO,TENCOSO";
            this.cbxCoSo.Size = new System.Drawing.Size(207, 21);
            this.cbxCoSo.TabIndex = 0;
            this.cbxCoSo.uDisplayMember = "TENCOSO";
            this.cbxCoSo.uEditValue = "";
            this.cbxCoSo.uTableName = "DM_COSO";
            this.cbxCoSo.uValueMember = "MACOSO";
            // 
            // dtg
            // 
            this.dtg.bAllowEdit = true;
            this.dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(211, 0);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(735, 545);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 1;
            this.dtg.uDataSource = null;
            this.dtg.uDoubleClick += new System.EventHandler(this.dtg_uDoubleClick);
            // 
            // frmTimKiemNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 545);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTimKiemNhanSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm nhân sự";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BSC_HRM.NET.BSC_User_Control.uDataGrid dtg;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxDonVi;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxPhongBan;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxPhanHe;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxCoSo;
        private DevExpress.XtraEditors.SimpleButton btnLocDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnChon;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.ImageList imageList1;
    }
}