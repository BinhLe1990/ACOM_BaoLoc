namespace BSC_HRM.NET.NhanSu
{
    partial class frmDanhSachDenHanNghiHuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachDenHanNghiHuu));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dtpDenNgay = new BSC_HRM.NET.BSC_User_Control.uDateTimePicker();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnInDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.btnLocDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.dtg = new BSC_HRM.NET.BSC_User_Control.uDataGrid();
            this.cbxCoSo = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxPhongBan = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.cbxPhanHe = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dtpDenNgay);
            this.panelControl1.Controls.Add(this.cbxPhanHe);
            this.panelControl1.Controls.Add(this.cbxPhongBan);
            this.panelControl1.Controls.Add(this.cbxCoSo);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(214, 521);
            this.panelControl1.TabIndex = 0;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.bHAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dtpDenNgay.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpDenNgay.iWidth = 80;
            this.dtpDenNgay.Location = new System.Drawing.Point(2, 65);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.sCaption = "Tính đến ngày";
            this.dtpDenNgay.Size = new System.Drawing.Size(210, 21);
            this.dtpDenNgay.TabIndex = 2;
            this.dtpDenNgay.uDateTime = new System.DateTime(2013, 4, 8, 8, 57, 46, 985);
            this.dtpDenNgay.uValue = new System.DateTime(2013, 4, 8, 8, 57, 46, 985);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.btnInDanhSach);
            this.groupControl1.Controls.Add(this.btnLocDanhSach);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(2, 404);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(210, 115);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "THAO TÁC THỰC HIỆN";
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThoat.ImageIndex = 0;
            this.btnThoat.ImageList = this.imageList1;
            this.btnThoat.Location = new System.Drawing.Point(2, 84);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(206, 31);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInDanhSach.ImageIndex = 3;
            this.btnInDanhSach.ImageList = this.imageList1;
            this.btnInDanhSach.Location = new System.Drawing.Point(2, 53);
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.Size = new System.Drawing.Size(206, 31);
            this.btnInDanhSach.TabIndex = 1;
            this.btnInDanhSach.Text = "In danh sách";
            this.btnInDanhSach.Click += new System.EventHandler(this.btnInDanhSach_Click);
            // 
            // btnLocDanhSach
            // 
            this.btnLocDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocDanhSach.ImageIndex = 4;
            this.btnLocDanhSach.ImageList = this.imageList1;
            this.btnLocDanhSach.Location = new System.Drawing.Point(2, 22);
            this.btnLocDanhSach.Name = "btnLocDanhSach";
            this.btnLocDanhSach.Size = new System.Drawing.Size(206, 31);
            this.btnLocDanhSach.TabIndex = 0;
            this.btnLocDanhSach.Text = "Lọc danh sách";
            this.btnLocDanhSach.Click += new System.EventHandler(this.btnLocDanhSach_Click);
            // 
            // dtg
            // 
            this.dtg.bAllowEdit = true;
            this.dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(214, 0);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(739, 521);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 1;
            this.dtg.uDataSource = null;
            // 
            // cbxCoSo
            // 
            this.cbxCoSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxCoSo.iWidth = 80;
            this.cbxCoSo.Location = new System.Drawing.Point(2, 2);
            this.cbxCoSo.Name = "cbxCoSo";
            this.cbxCoSo.sCaption = "Cơ sở";
            this.cbxCoSo.sField = "";
            this.cbxCoSo.Size = new System.Drawing.Size(210, 21);
            this.cbxCoSo.TabIndex = 3;
            this.cbxCoSo.uDisplayMember = "TENCOSO";
            this.cbxCoSo.uEditValue = "";
            this.cbxCoSo.uTableName = "DM_COSO";
            this.cbxCoSo.uValueMember = "MACOSO";
            // 
            // cbxPhongBan
            // 
            this.cbxPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxPhongBan.iWidth = 80;
            this.cbxPhongBan.Location = new System.Drawing.Point(2, 23);
            this.cbxPhongBan.Name = "cbxPhongBan";
            this.cbxPhongBan.sCaption = "Phòng ban";
            this.cbxPhongBan.sField = "";
            this.cbxPhongBan.Size = new System.Drawing.Size(210, 21);
            this.cbxPhongBan.TabIndex = 4;
            this.cbxPhongBan.uDisplayMember = "TENPHONGBAN";
            this.cbxPhongBan.uEditValue = "";
            this.cbxPhongBan.uTableName = "DM_PHONGBAN";
            this.cbxPhongBan.uValueMember = "MAPHONGBAN";
            // 
            // cbxPhanHe
            // 
            this.cbxPhanHe.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxPhanHe.iWidth = 80;
            this.cbxPhanHe.Location = new System.Drawing.Point(2, 44);
            this.cbxPhanHe.Name = "cbxPhanHe";
            this.cbxPhanHe.sCaption = "Phân hệ";
            this.cbxPhanHe.sField = "";
            this.cbxPhanHe.Size = new System.Drawing.Size(210, 21);
            this.cbxPhanHe.TabIndex = 5;
            this.cbxPhanHe.uDisplayMember = "TENPHANHE";
            this.cbxPhanHe.uEditValue = "";
            this.cbxPhanHe.uTableName = "DM_PHANHE";
            this.cbxPhanHe.uValueMember = "MAPHANHE";
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
            // frmDanhSachDenHanNghiHuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 521);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDanhSachDenHanNghiHuu";
            this.Tag = "|HS|";
            this.Text = "Danh sách cán bộ đến hạn nghỉ hưu";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BSC_HRM.NET.BSC_User_Control.uDateTimePicker dtpDenNgay;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private BSC_HRM.NET.BSC_User_Control.uDataGrid dtg;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnInDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnLocDanhSach;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxPhanHe;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxPhongBan;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxCoSo;
        private System.Windows.Forms.ImageList imageList1;        
    }
}