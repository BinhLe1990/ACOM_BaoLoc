namespace BSC_HRM.NET.NhanSu
{
    partial class frmBC_TKToChucCanBo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBC_TKToChucCanBo));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTroVe = new DevExpress.XtraEditors.SimpleButton();
            this.btnInDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.btnLocDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cbxMauBaoCao = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.dtg = new BSC_HRM.NET.BSC_User_Control.uDataGrid();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.btnTroVe);
            this.groupControl1.Controls.Add(this.btnInDanhSach);
            this.groupControl1.Controls.Add(this.btnLocDanhSach);
            this.groupControl1.Location = new System.Drawing.Point(5, 376);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(228, 115);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "THAO TÁC THỰC HIỆN";
            // 
            // btnTroVe
            // 
            this.btnTroVe.ImageIndex = 0;
            this.btnTroVe.ImageList = this.imageList1;
            this.btnTroVe.Location = new System.Drawing.Point(14, 81);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(198, 29);
            this.btnTroVe.TabIndex = 3;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.ImageIndex = 1;
            this.btnInDanhSach.ImageList = this.imageList1;
            this.btnInDanhSach.Location = new System.Drawing.Point(14, 52);
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.Size = new System.Drawing.Size(198, 29);
            this.btnInDanhSach.TabIndex = 3;
            this.btnInDanhSach.Text = "In danh sách";
            this.btnInDanhSach.Click += new System.EventHandler(this.btnInDanhSach_Click);
            // 
            // btnLocDanhSach
            // 
            this.btnLocDanhSach.ImageIndex = 2;
            this.btnLocDanhSach.ImageList = this.imageList1;
            this.btnLocDanhSach.Location = new System.Drawing.Point(14, 23);
            this.btnLocDanhSach.Name = "btnLocDanhSach";
            this.btnLocDanhSach.Size = new System.Drawing.Size(198, 29);
            this.btnLocDanhSach.TabIndex = 3;
            this.btnLocDanhSach.Text = "Lọc danh sách";
            this.btnLocDanhSach.Click += new System.EventHandler(this.btnLocDanhSach_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cbxMauBaoCao);
            this.groupControl2.Location = new System.Drawing.Point(5, 7);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(229, 49);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "ĐIỀU KIỆN LỌC";
            // 
            // cbxMauBaoCao
            // 
            this.cbxMauBaoCao.iWidth = 80;
            this.cbxMauBaoCao.Location = new System.Drawing.Point(2, 23);
            this.cbxMauBaoCao.Name = "cbxMauBaoCao";
            this.cbxMauBaoCao.sCaption = "Mẫu báo cáo";
            this.cbxMauBaoCao.sField = null;
            this.cbxMauBaoCao.Size = new System.Drawing.Size(225, 21);
            this.cbxMauBaoCao.TabIndex = 0;
            this.cbxMauBaoCao.uDisplayMember = null;
            this.cbxMauBaoCao.uEditValue = "";
            this.cbxMauBaoCao.uValueMember = null;
            this.cbxMauBaoCao.Load += new System.EventHandler(this.cbxMauBaoCao_Load);
            // 
            // dtg
            // 
            this.dtg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(237, 5);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(703, 487);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 2;
            this.dtg.uDataSource = null;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Exit.png");
            this.imageList1.Images.SetKeyName(1, "Print.png");
            this.imageList1.Images.SetKeyName(2, "Search.png");
            // 
            // frmBC_TKToChucCanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 495);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmBC_TKToChucCanBo";
            this.Text = "Báo cáo thống kê tổ chức cán bộ";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BSC_HRM.NET.BSC_User_Control.uComboBox cbxMauBaoCao;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private BSC_HRM.NET.BSC_User_Control.uDataGrid dtg;
        private DevExpress.XtraEditors.SimpleButton btnTroVe;
        private DevExpress.XtraEditors.SimpleButton btnInDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnLocDanhSach;
        private System.Windows.Forms.ImageList imageList1;
    }
}