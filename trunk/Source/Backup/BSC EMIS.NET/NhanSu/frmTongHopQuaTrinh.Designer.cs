namespace BSC_HRM.NET.NhanSu
{
    partial class frmTongHopQuaTrinh
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
            this.uFind1 = new BSC_HRM.NET.BSC_User_Control.uFind();
            this.btnInDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.cboQuaTrinh = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.dtg = new BSC_HRM.NET.BSC_User_Control.uDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.uFind1);
            this.panelControl1.Controls.Add(this.btnInDanhSach);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.cboQuaTrinh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(260, 509);
            this.panelControl1.TabIndex = 0;
            // 
            // uFind1
            // 
            this.uFind1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uFind1.Location = new System.Drawing.Point(2, 23);
            this.uFind1.Name = "uFind1";
            this.uFind1.Size = new System.Drawing.Size(256, 430);
            this.uFind1.sKEY = "";
            this.uFind1.TabIndex = 1;
            this.uFind1.uClick += new BSC_HRM.NET.BSC_User_Control.uFind.EventHandler(this.uFind1_uClick);
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInDanhSach.Location = new System.Drawing.Point(2, 453);
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.Size = new System.Drawing.Size(256, 27);
            this.btnInDanhSach.TabIndex = 2;
            this.btnInDanhSach.Text = "In danh sách";
            this.btnInDanhSach.Click += new System.EventHandler(this.btnInDanhSach_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.Location = new System.Drawing.Point(2, 480);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(256, 27);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboQuaTrinh
            // 
            this.cboQuaTrinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboQuaTrinh.iWidth = 80;
            this.cboQuaTrinh.Location = new System.Drawing.Point(2, 2);
            this.cboQuaTrinh.Name = "cboQuaTrinh";
            this.cboQuaTrinh.sCaption = "Chọn quá trình";
            this.cboQuaTrinh.sField = "";
            this.cboQuaTrinh.Size = new System.Drawing.Size(256, 21);
            this.cboQuaTrinh.TabIndex = 0;
            this.cboQuaTrinh.uDisplayMember = null;
            this.cboQuaTrinh.uEditValue = "";
            this.cboQuaTrinh.uValueMember = null;
            this.cboQuaTrinh.uEditValueChanged += new System.EventHandler(this.cboQuaTrinh_uEditValueChanged);
            // 
            // dtg
            // 
            this.dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(260, 0);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(659, 509);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 1;
            this.dtg.uDataSource = null;
            // 
            // frmTongHopQuaTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 509);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmTongHopQuaTrinh";
            this.Tag = "|HS|";
            this.Text = "Tổng hợp quá trình";
            this.Load += new System.EventHandler(this.frmTongHopQuaTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BSC_HRM.NET.BSC_User_Control.uFind uFind1;
        private DevExpress.XtraEditors.SimpleButton btnInDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private BSC_HRM.NET.BSC_User_Control.uComboBox cboQuaTrinh;
        private BSC_HRM.NET.BSC_User_Control.uDataGrid dtg;
    }
}