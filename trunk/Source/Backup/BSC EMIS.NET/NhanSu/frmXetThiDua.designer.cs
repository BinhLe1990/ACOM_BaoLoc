namespace BSC_HRM.NET.NhanSu
{
    partial class frmXetThiDua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXetThiDua));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupLoc = new DevExpress.XtraEditors.GroupControl();
            this.txtNam = new BSC_HRM.NET.BSC_User_Control.uSpinEdit();
            this.cbxCoSo = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxPhongBan = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxPhanHe = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.raLoai = new DevExpress.XtraEditors.RadioGroup();
            this.grpThaoTac = new DevExpress.XtraEditors.GroupControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnInDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXetDongLoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLocDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.dtg = new BSC_HRM.NET.BSC_User_Control.uDataGrid();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar_LaoDongTienTien = new DevExpress.XtraBars.BarButtonItem();
            this.bar_ChienSiThiDua = new DevExpress.XtraBars.BarButtonItem();
            this.bar_Tatca = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupLoc)).BeginInit();
            this.groupLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpThaoTac)).BeginInit();
            this.grpThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupLoc);
            this.panelControl1.Controls.Add(this.grpThaoTac);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(251, 456);
            this.panelControl1.TabIndex = 0;
            // 
            // groupLoc
            // 
            this.groupLoc.Controls.Add(this.txtNam);
            this.groupLoc.Controls.Add(this.cbxCoSo);
            this.groupLoc.Controls.Add(this.cbxPhongBan);
            this.groupLoc.Controls.Add(this.cbxPhanHe);
            this.groupLoc.Controls.Add(this.raLoai);
            this.groupLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupLoc.Location = new System.Drawing.Point(2, 2);
            this.groupLoc.Name = "groupLoc";
            this.groupLoc.Size = new System.Drawing.Size(247, 141);
            this.groupLoc.TabIndex = 9;
            this.groupLoc.Text = "ĐIỀU KIỆN LỌC";
            // 
            // txtNam
            // 
            this.txtNam.bHAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtNam.iWidth = 60;
            this.txtNam.Location = new System.Drawing.Point(6, 88);
            this.txtNam.Name = "txtNam";
            this.txtNam.sCaption = "Năm";
            this.txtNam.Size = new System.Drawing.Size(237, 22);
            this.txtNam.TabIndex = 10;
            this.txtNam.uEditValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txtNam.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNam.uMaxValue = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.txtNam.uMinValue = new decimal(new int[] {
            1000,
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
            this.cbxCoSo.Location = new System.Drawing.Point(6, 23);
            this.cbxCoSo.Name = "cbxCoSo";
            this.cbxCoSo.sCaption = "Cơ sở";
            this.cbxCoSo.sColumnCaption = "Mã cơ sở,Tên cơ sở";
            this.cbxCoSo.sField = "MACOSO,TENCOSO";
            this.cbxCoSo.Size = new System.Drawing.Size(237, 22);
            this.cbxCoSo.TabIndex = 11;
            this.cbxCoSo.uDisplayMember = "TENCOSO";
            this.cbxCoSo.uEditValue = "";
            this.cbxCoSo.uTableName = "DM_COSO";
            this.cbxCoSo.uValueMember = "MACOSO";
            // 
            // cbxPhongBan
            // 
            this.cbxPhongBan.iWidth = 60;
            this.cbxPhongBan.Location = new System.Drawing.Point(6, 67);
            this.cbxPhongBan.Name = "cbxPhongBan";
            this.cbxPhongBan.sCaption = "Phòng ban";
            this.cbxPhongBan.sColumnCaption = "Mã phòng ban,Tên phòng ban";
            this.cbxPhongBan.sField = "MAPHONGBAN,TENPHONGBAN";
            this.cbxPhongBan.Size = new System.Drawing.Size(237, 22);
            this.cbxPhongBan.TabIndex = 13;
            this.cbxPhongBan.uDisplayMember = "TENPHONGBAN";
            this.cbxPhongBan.uEditValue = "";
            this.cbxPhongBan.uTableName = "DM_PHONGBAN";
            this.cbxPhongBan.uValueMember = "MAPHONGBAN";
            // 
            // cbxPhanHe
            // 
            this.cbxPhanHe.iWidth = 60;
            this.cbxPhanHe.Location = new System.Drawing.Point(6, 45);
            this.cbxPhanHe.Name = "cbxPhanHe";
            this.cbxPhanHe.sCaption = "Phân hệ";
            this.cbxPhanHe.sColumnCaption = "Mã phân hệ,Tên phân hệ";
            this.cbxPhanHe.sField = "MAPHANHE,TENPHANHE";
            this.cbxPhanHe.Size = new System.Drawing.Size(237, 22);
            this.cbxPhanHe.TabIndex = 12;
            this.cbxPhanHe.uDisplayMember = "TENPHANHE";
            this.cbxPhanHe.uEditValue = "";
            this.cbxPhanHe.uTableName = "DM_PHANHE";
            this.cbxPhanHe.uValueMember = "MAPHANHE";
            // 
            // raLoai
            // 
            this.raLoai.EditValue = 0;
            this.raLoai.Location = new System.Drawing.Point(67, 110);
            this.raLoai.Name = "raLoai";
            this.raLoai.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Cá nhân"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Tập thể")});
            this.raLoai.Size = new System.Drawing.Size(176, 23);
            this.raLoai.TabIndex = 9;
            // 
            // grpThaoTac
            // 
            this.grpThaoTac.Controls.Add(this.btnThoat);
            this.grpThaoTac.Controls.Add(this.btnInDanhSach);
            this.grpThaoTac.Controls.Add(this.btnCapNhat);
            this.grpThaoTac.Controls.Add(this.btnXetDongLoat);
            this.grpThaoTac.Controls.Add(this.btnLocDanhSach);
            this.grpThaoTac.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpThaoTac.Location = new System.Drawing.Point(2, 303);
            this.grpThaoTac.Name = "grpThaoTac";
            this.grpThaoTac.Size = new System.Drawing.Size(247, 151);
            this.grpThaoTac.TabIndex = 1;
            this.grpThaoTac.Text = "THAO TÁC THỰC HIỆN";
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThoat.ImageIndex = 1;
            this.btnThoat.ImageList = this.IML;
            this.btnThoat.Location = new System.Drawing.Point(2, 126);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(243, 26);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
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
            this.IML.Images.SetKeyName(7, "Print.png");
            this.IML.Images.SetKeyName(8, "Rotation.png");
            this.IML.Images.SetKeyName(9, "changeFontBackColorItem1.LargeGlyph.png");
            this.IML.Images.SetKeyName(10, "Add.png");
            this.IML.Images.SetKeyName(11, "Yes.png");
            this.IML.Images.SetKeyName(12, "pqsd.png");
            this.IML.Images.SetKeyName(13, "32px-Crystal_Clear_Password.png");
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInDanhSach.ImageIndex = 7;
            this.btnInDanhSach.ImageList = this.IML;
            this.btnInDanhSach.Location = new System.Drawing.Point(2, 100);
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.Size = new System.Drawing.Size(243, 26);
            this.btnInDanhSach.TabIndex = 2;
            this.btnInDanhSach.Text = "In danh sách";
            this.btnInDanhSach.Click += new System.EventHandler(this.btnInDanhSach_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCapNhat.ImageIndex = 2;
            this.btnCapNhat.ImageList = this.IML;
            this.btnCapNhat.Location = new System.Drawing.Point(2, 74);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(243, 26);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Tag = "ADD";
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXetDongLoat
            // 
            this.btnXetDongLoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXetDongLoat.ImageIndex = 4;
            this.btnXetDongLoat.ImageList = this.IML;
            this.btnXetDongLoat.Location = new System.Drawing.Point(2, 48);
            this.btnXetDongLoat.Name = "btnXetDongLoat";
            this.btnXetDongLoat.Size = new System.Drawing.Size(243, 26);
            this.btnXetDongLoat.TabIndex = 4;
            this.btnXetDongLoat.Text = "Xét đồng loạt";
            this.btnXetDongLoat.Click += new System.EventHandler(this.btnXetDongLoat_Click);
            // 
            // btnLocDanhSach
            // 
            this.btnLocDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocDanhSach.ImageIndex = 0;
            this.btnLocDanhSach.ImageList = this.IML;
            this.btnLocDanhSach.Location = new System.Drawing.Point(2, 22);
            this.btnLocDanhSach.Name = "btnLocDanhSach";
            this.btnLocDanhSach.Size = new System.Drawing.Size(243, 26);
            this.btnLocDanhSach.TabIndex = 0;
            this.btnLocDanhSach.Text = "Lọc danh sách";
            this.btnLocDanhSach.Click += new System.EventHandler(this.btnLocDanhSach_Click);
            // 
            // dtg
            // 
            this.dtg.bAllowEdit = true;
            this.dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(251, 0);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(701, 456);
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
            this.bar_LaoDongTienTien,
            this.bar_ChienSiThiDua,
            this.bar_Tatca});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(952, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 456);
            this.barDockControlBottom.Size = new System.Drawing.Size(952, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 456);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(952, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 456);
            // 
            // bar_LaoDongTienTien
            // 
            this.bar_LaoDongTienTien.Caption = "Lao động tiên tiến";
            this.bar_LaoDongTienTien.Id = 0;
            this.bar_LaoDongTienTien.Name = "bar_LaoDongTienTien";
            this.bar_LaoDongTienTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_LaoDongTienTien_ItemClick);
            // 
            // bar_ChienSiThiDua
            // 
            this.bar_ChienSiThiDua.Caption = "Chiến sĩ thi đua";
            this.bar_ChienSiThiDua.Id = 1;
            this.bar_ChienSiThiDua.Name = "bar_ChienSiThiDua";
            this.bar_ChienSiThiDua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ChienSiThiDua_ItemClick);
            // 
            // bar_Tatca
            // 
            this.bar_Tatca.Caption = "Tất cả";
            this.bar_Tatca.Id = 2;
            this.bar_Tatca.Name = "bar_Tatca";
            this.bar_Tatca.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bar_Tatca.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_Tatca_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_LaoDongTienTien),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_ChienSiThiDua),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_Tatca)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // frmXetThiDua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 456);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmXetThiDua";
            this.Tag = "|HS|";
            this.Text = "Xét thi đua";
            this.Load += new System.EventHandler(this.frmXetThiDua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupLoc)).EndInit();
            this.groupLoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpThaoTac)).EndInit();
            this.grpThaoTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl grpThaoTac;
        private BSC_HRM.NET.BSC_User_Control.uDataGrid dtg;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnInDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnLocDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnXetDongLoat;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bar_LaoDongTienTien;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem bar_ChienSiThiDua;
        private DevExpress.XtraBars.BarButtonItem bar_Tatca;
        private DevExpress.XtraEditors.GroupControl groupLoc;
        private BSC_HRM.NET.BSC_User_Control.uSpinEdit txtNam;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxCoSo;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxPhongBan;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxPhanHe;
        private DevExpress.XtraEditors.RadioGroup raLoai;
        private System.Windows.Forms.ImageList IML;
    }
}