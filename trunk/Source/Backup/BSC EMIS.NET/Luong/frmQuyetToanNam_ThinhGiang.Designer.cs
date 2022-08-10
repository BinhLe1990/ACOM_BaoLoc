namespace BSC_HRM.NET.Luong
{
    partial class frmQuyetToanNam_ThinhGiang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuyetToanNam_ThinhGiang));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLocDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.cbxDonVi = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxPhongBan = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxPhanHe = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxCoSo = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.txtNam = new BSC_HRM.NET.BSC_User_Control.uSpinEdit();
            this.dtg = new BSC_HRM.NET.BSC_User_Control.uDataGrid();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnInBanThue = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatExcel = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLocDuLieu);
            this.panelControl1.Controls.Add(this.btnIn);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.cbxDonVi);
            this.panelControl1.Controls.Add(this.cbxPhongBan);
            this.panelControl1.Controls.Add(this.cbxPhanHe);
            this.panelControl1.Controls.Add(this.cbxCoSo);
            this.panelControl1.Controls.Add(this.txtNam);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(278, 565);
            this.panelControl1.TabIndex = 0;
            // 
            // btnLocDuLieu
            // 
            this.btnLocDuLieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLocDuLieu.ImageIndex = 4;
            this.btnLocDuLieu.ImageList = this.imageList1;
            this.btnLocDuLieu.Location = new System.Drawing.Point(2, 461);
            this.btnLocDuLieu.Name = "btnLocDuLieu";
            this.btnLocDuLieu.Size = new System.Drawing.Size(274, 34);
            this.btnLocDuLieu.TabIndex = 13;
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
            // btnIn
            // 
            this.btnIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIn.ImageIndex = 3;
            this.btnIn.ImageList = this.imageList1;
            this.btnIn.Location = new System.Drawing.Point(2, 495);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(274, 34);
            this.btnIn.TabIndex = 10;
            this.btnIn.Text = "In bản thuế";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.ImageIndex = 0;
            this.btnThoat.ImageList = this.imageList1;
            this.btnThoat.Location = new System.Drawing.Point(2, 529);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(274, 34);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbxDonVi
            // 
            this.cbxDonVi.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxDonVi.iWidth = 80;
            this.cbxDonVi.Location = new System.Drawing.Point(2, 86);
            this.cbxDonVi.Name = "cbxDonVi";
            this.cbxDonVi.sCaption = "Đơn vị";
            this.cbxDonVi.sColumnCaption = "Mã đơn vị,Tên đơn vị";
            this.cbxDonVi.sField = "MaDonVi,TenDonVi";
            this.cbxDonVi.Size = new System.Drawing.Size(274, 21);
            this.cbxDonVi.TabIndex = 9;
            this.cbxDonVi.uDisplayMember = "TenDonVi";
            this.cbxDonVi.uEditValue = "";
            this.cbxDonVi.uValueMember = "MaDonVi";
            // 
            // cbxPhongBan
            // 
            this.cbxPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxPhongBan.iWidth = 80;
            this.cbxPhongBan.Location = new System.Drawing.Point(2, 65);
            this.cbxPhongBan.Name = "cbxPhongBan";
            this.cbxPhongBan.sCaption = "Phòng ban";
            this.cbxPhongBan.sColumnCaption = "Mã phòng ban,Tên phòng ban";
            this.cbxPhongBan.sField = "MaPhongBan,TenPhongBan";
            this.cbxPhongBan.Size = new System.Drawing.Size(274, 21);
            this.cbxPhongBan.TabIndex = 8;
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
            this.cbxPhanHe.Location = new System.Drawing.Point(2, 44);
            this.cbxPhanHe.Name = "cbxPhanHe";
            this.cbxPhanHe.sCaption = "Phân hệ";
            this.cbxPhanHe.sColumnCaption = "Mã phân hệ,Tên phân hệ";
            this.cbxPhanHe.sField = "MaPhanHe,TenPhanHe";
            this.cbxPhanHe.Size = new System.Drawing.Size(274, 21);
            this.cbxPhanHe.TabIndex = 7;
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
            this.cbxCoSo.Location = new System.Drawing.Point(2, 23);
            this.cbxCoSo.Name = "cbxCoSo";
            this.cbxCoSo.sCaption = "Cơ sở";
            this.cbxCoSo.sColumnCaption = "Mã cơ sở,Tên cơ sở";
            this.cbxCoSo.sField = "MaCoSo,TenCoSo";
            this.cbxCoSo.Size = new System.Drawing.Size(274, 21);
            this.cbxCoSo.TabIndex = 6;
            this.cbxCoSo.uDisplayMember = "TenCoSo";
            this.cbxCoSo.uEditValue = null;
            this.cbxCoSo.uTableName = "DM_COSO";
            this.cbxCoSo.uValueMember = "MaCoSo";
            // 
            // txtNam
            // 
            this.txtNam.bHAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtNam.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNam.iWidth = 80;
            this.txtNam.Location = new System.Drawing.Point(2, 2);
            this.txtNam.Name = "txtNam";
            this.txtNam.sCaption = "Năm";
            this.txtNam.Size = new System.Drawing.Size(274, 21);
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
            this.dtg.Location = new System.Drawing.Point(278, 0);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(694, 565);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 1;
            this.dtg.uDataSource = null;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnInBanThue,
            this.btnXuatExcel});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(972, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 565);
            this.barDockControlBottom.Size = new System.Drawing.Size(972, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 565);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(972, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 565);
            // 
            // btnInBanThue
            // 
            this.btnInBanThue.Caption = "In bản thuế";
            this.btnInBanThue.Id = 0;
            this.btnInBanThue.Name = "btnInBanThue";
            this.btnInBanThue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInBanThue_ItemClick);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Caption = "Xuất bảng tính Excel";
            this.btnXuatExcel.Id = 1;
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatExcel_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnInBanThue),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXuatExcel)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // frmQuyetToanNam_ThinhGiang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 565);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmQuyetToanNam_ThinhGiang";
            this.Text = "Quyết toán thuế TNCN năm (Thỉnh giảng, cơ hữu tự quyết toán)";
            this.Load += new System.EventHandler(this.frmQuyetToanNam_ThinhGiang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BSC_HRM.NET.BSC_User_Control.uDataGrid dtg;
        private BSC_HRM.NET.BSC_User_Control.uSpinEdit txtNam;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxDonVi;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxPhongBan;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxPhanHe;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxCoSo;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton btnLocDuLieu;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnInBanThue;
        private DevExpress.XtraBars.BarButtonItem btnXuatExcel;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
    }
}