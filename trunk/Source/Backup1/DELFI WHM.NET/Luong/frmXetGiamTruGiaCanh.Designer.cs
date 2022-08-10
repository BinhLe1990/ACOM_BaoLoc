namespace DELFI_WHM.NET.Luong
{
    partial class frmXetGiamTruGiaCanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXetGiamTruGiaCanh));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLocDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnXetGiamTru = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.cbxDonVi = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cbxPhongBan = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cbxCoSo = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.txtNam = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.txtThang = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.dtg = new DELFI_WHM.NET.DELFI_User_Control.uDataGrid();
            this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLocDuLieu);
            this.panelControl1.Controls.Add(this.btnXetGiamTru);
            this.panelControl1.Controls.Add(this.btnCopy);
            this.panelControl1.Controls.Add(this.btnCapNhat);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.cbxDonVi);
            this.panelControl1.Controls.Add(this.cbxPhongBan);
            this.panelControl1.Controls.Add(this.cbxCoSo);
            this.panelControl1.Controls.Add(this.txtNam);
            this.panelControl1.Controls.Add(this.txtThang);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(254, 564);
            this.panelControl1.TabIndex = 0;
            // 
            // btnLocDuLieu
            // 
            this.btnLocDuLieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLocDuLieu.ImageIndex = 3;
            this.btnLocDuLieu.ImageList = this.imageList1;
            this.btnLocDuLieu.Location = new System.Drawing.Point(2, 392);
            this.btnLocDuLieu.Name = "btnLocDuLieu";
            this.btnLocDuLieu.Size = new System.Drawing.Size(250, 34);
            this.btnLocDuLieu.TabIndex = 5;
            this.btnLocDuLieu.Text = "Lọc dữ liệu";
            this.btnLocDuLieu.Click += new System.EventHandler(this.btnLocDuLieu_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Exit.png");
            this.imageList1.Images.SetKeyName(1, "Import.png");
            this.imageList1.Images.SetKeyName(2, "Save.png");
            this.imageList1.Images.SetKeyName(3, "Search.png");
            this.imageList1.Images.SetKeyName(4, "Close folder.png");
            // 
            // btnXetGiamTru
            // 
            this.btnXetGiamTru.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnXetGiamTru.ImageIndex = 1;
            this.btnXetGiamTru.ImageList = this.imageList1;
            this.btnXetGiamTru.Location = new System.Drawing.Point(2, 426);
            this.btnXetGiamTru.Name = "btnXetGiamTru";
            this.btnXetGiamTru.Size = new System.Drawing.Size(250, 34);
            this.btnXetGiamTru.TabIndex = 5;
            this.btnXetGiamTru.Text = "Xét giảm trừ";
            this.btnXetGiamTru.Click += new System.EventHandler(this.btnXetGiamTru_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCapNhat.ImageIndex = 2;
            this.btnCapNhat.ImageList = this.imageList1;
            this.btnCapNhat.Location = new System.Drawing.Point(2, 494);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(250, 34);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.ImageIndex = 0;
            this.btnThoat.ImageList = this.imageList1;
            this.btnThoat.Location = new System.Drawing.Point(2, 528);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(250, 34);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbxDonVi
            // 
            this.cbxDonVi.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxDonVi.iWidth = 70;
            this.cbxDonVi.Location = new System.Drawing.Point(2, 86);
            this.cbxDonVi.Name = "cbxDonVi";
            this.cbxDonVi.sCaption = "Đơn vị";
            this.cbxDonVi.sColumnCaption = "Mã đơn vị,Tên đơn vị";
            this.cbxDonVi.sField = "MaDonVi,TenDonVi";
            this.cbxDonVi.Size = new System.Drawing.Size(250, 21);
            this.cbxDonVi.TabIndex = 4;
            this.cbxDonVi.uDisplayMember = "TenDonVi";
            this.cbxDonVi.uEditValue = "";
            this.cbxDonVi.uValueMember = "MaDonVi";
            // 
            // cbxPhongBan
            // 
            this.cbxPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxPhongBan.iWidth = 70;
            this.cbxPhongBan.Location = new System.Drawing.Point(2, 65);
            this.cbxPhongBan.Name = "cbxPhongBan";
            this.cbxPhongBan.sCaption = "Phòng ban";
            this.cbxPhongBan.sColumnCaption = "Mã phòng ban,Tên phòng ban";
            this.cbxPhongBan.sField = "MaPhongBan,TenPhongBan";
            this.cbxPhongBan.Size = new System.Drawing.Size(250, 21);
            this.cbxPhongBan.TabIndex = 3;
            this.cbxPhongBan.uDisplayMember = "TenPhongBan";
            this.cbxPhongBan.uEditValue = "";
            this.cbxPhongBan.uTableName = "DM_PhongBan";
            this.cbxPhongBan.uValueMember = "MaPhongBan";
            this.cbxPhongBan.uEditValueChanged += new System.EventHandler(this.cbxPhongBan_uEditValueChanged);
            // 
            // cbxCoSo
            // 
            this.cbxCoSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxCoSo.iWidth = 70;
            this.cbxCoSo.Location = new System.Drawing.Point(2, 44);
            this.cbxCoSo.Name = "cbxCoSo";
            this.cbxCoSo.sCaption = "Cơ sở";
            this.cbxCoSo.sColumnCaption = "Mã cơ sở,Tên cơ sở";
            this.cbxCoSo.sField = "MaCoSo,TenCoSo";
            this.cbxCoSo.Size = new System.Drawing.Size(250, 21);
            this.cbxCoSo.TabIndex = 2;
            this.cbxCoSo.uDisplayMember = "TenCoSo";
            this.cbxCoSo.uEditValue = "";
            this.cbxCoSo.uTableName = "DM_CoSo";
            this.cbxCoSo.uValueMember = "MaCoSo";
            // 
            // txtNam
            // 
            this.txtNam.bHAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtNam.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNam.iWidth = 70;
            this.txtNam.Location = new System.Drawing.Point(2, 23);
            this.txtNam.Name = "txtNam";
            this.txtNam.sCaption = "Năm";
            this.txtNam.Size = new System.Drawing.Size(250, 21);
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
            // txtThang
            // 
            this.txtThang.bHAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtThang.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtThang.iWidth = 70;
            this.txtThang.Location = new System.Drawing.Point(2, 2);
            this.txtThang.Name = "txtThang";
            this.txtThang.sCaption = "Tháng";
            this.txtThang.Size = new System.Drawing.Size(250, 21);
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
            // dtg
            // 
            this.dtg.bAllowEdit = true;
            this.dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(254, 0);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(612, 564);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 1;
            this.dtg.uDataSource = null;
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCopy.ImageIndex = 4;
            this.btnCopy.ImageList = this.imageList1;
            this.btnCopy.Location = new System.Drawing.Point(2, 460);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(250, 34);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Copy từ tháng trước";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // frmXetGiamTruGiaCanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 564);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmXetGiamTruGiaCanh";
            this.Text = "Xét giảm trừ gia cảnh";
            this.Load += new System.EventHandler(this.frmXetGiamTruGiaCanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cbxPhongBan;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cbxCoSo;
        private DELFI_WHM.NET.DELFI_User_Control.uSpinEdit txtNam;
        private DELFI_WHM.NET.DELFI_User_Control.uSpinEdit txtThang;
        private DELFI_WHM.NET.DELFI_User_Control.uDataGrid dtg;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cbxDonVi;
        private DevExpress.XtraEditors.SimpleButton btnLocDuLieu;
        private DevExpress.XtraEditors.SimpleButton btnXetGiamTru;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton btnCopy;
    }
}