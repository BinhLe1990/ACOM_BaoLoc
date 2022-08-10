namespace BSC_HRM.NET.Luong
{
    partial class frmTongHopTienLuong_Thuong
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLocDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.btnInDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.dtg = new BSC_HRM.NET.BSC_User_Control.uDataGrid();
            this.txtNam = new BSC_HRM.NET.BSC_User_Control.uSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnInDanhSach);
            this.panelControl1.Controls.Add(this.btnLocDanhSach);
            this.panelControl1.Controls.Add(this.txtNam);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(977, 28);
            this.panelControl1.TabIndex = 0;
            // 
            // btnLocDanhSach
            // 
            this.btnLocDanhSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLocDanhSach.Location = new System.Drawing.Point(120, 2);
            this.btnLocDanhSach.Name = "btnLocDanhSach";
            this.btnLocDanhSach.Size = new System.Drawing.Size(135, 24);
            this.btnLocDanhSach.TabIndex = 1;
            this.btnLocDanhSach.Text = "Lọc danh sách";
            this.btnLocDanhSach.Click += new System.EventHandler(this.btnLocDanhSach_Click);
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInDanhSach.Location = new System.Drawing.Point(255, 2);
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.Size = new System.Drawing.Size(118, 24);
            this.btnInDanhSach.TabIndex = 1;
            this.btnInDanhSach.Text = "In báo cáo";
            this.btnInDanhSach.Click += new System.EventHandler(this.btnInDanhSach_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThoat.Location = new System.Drawing.Point(373, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 24);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtg
            // 
            this.dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(0, 28);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(977, 447);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 1;
            this.dtg.uDataSource = null;
            // 
            // txtNam
            // 
            this.txtNam.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtNam.iWidth = 30;
            this.txtNam.Location = new System.Drawing.Point(2, 2);
            this.txtNam.Name = "txtNam";
            this.txtNam.sCaption = "Năm";
            this.txtNam.Size = new System.Drawing.Size(118, 24);
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
            // frmTongHopTienLuong_Thuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 475);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmTongHopTienLuong_Thuong";
            this.Text = "Tổng hợp tiền lương - thưởng";
            this.Load += new System.EventHandler(this.frmTongHopTienLuong_Thuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BSC_HRM.NET.BSC_User_Control.uDataGrid dtg;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnInDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnLocDanhSach;
        private BSC_HRM.NET.BSC_User_Control.uSpinEdit txtNam;
    }
}