namespace DELFI_WHM.NET.HeThong.FrND
{
    partial class frmNhatKyNguoiDung
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
            this.txtTuNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker();
            this.txtDenNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker();
            this.cbxNguoiDung = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.btnLocDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.dtg = new DELFI_WHM.NET.DELFI_User_Control.uDataGrid();
            this.SuspendLayout();
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.iWidth = 80;
            this.txtTuNgay.Location = new System.Drawing.Point(3, 3);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.sCaption = "Từ ngày";
            this.txtTuNgay.Size = new System.Drawing.Size(228, 21);
            this.txtTuNgay.TabIndex = 0;
            this.txtTuNgay.uValue = new System.DateTime(2010, 7, 22, 9, 22, 49, 453);
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.iWidth = 80;
            this.txtDenNgay.Location = new System.Drawing.Point(3, 30);
            this.txtDenNgay.Name = "txtDenNgay";
            this.txtDenNgay.sCaption = "Đến ngày";
            this.txtDenNgay.Size = new System.Drawing.Size(228, 21);
            this.txtDenNgay.TabIndex = 1;
            this.txtDenNgay.uValue = new System.DateTime(2010, 7, 22, 9, 22, 51, 640);
            // 
            // cbxNguoiDung
            // 
            this.cbxNguoiDung.iWidth = 80;
            this.cbxNguoiDung.Location = new System.Drawing.Point(3, 57);
            this.cbxNguoiDung.Name = "cbxNguoiDung";
            this.cbxNguoiDung.sCaption = "Người dùng";
            this.cbxNguoiDung.sColumnCaption = "ID, Tài khoản, Họ tên";
            this.cbxNguoiDung.sField = "NGUOIDUNG, TAIKHOAN, HOTEN";
            this.cbxNguoiDung.Size = new System.Drawing.Size(228, 20);
            this.cbxNguoiDung.TabIndex = 3;
            this.cbxNguoiDung.Tag = "";
            this.cbxNguoiDung.uDisplayMember = "HOTEN";
            this.cbxNguoiDung.uEditValue = null;
            this.cbxNguoiDung.uTableName = "HT_NGUOIDUNG";
            this.cbxNguoiDung.uValueMember = "NGUOIDUNG";
            // 
            // btnLocDanhSach
            // 
            this.btnLocDanhSach.Location = new System.Drawing.Point(3, 83);
            this.btnLocDanhSach.Name = "btnLocDanhSach";
            this.btnLocDanhSach.Size = new System.Drawing.Size(111, 25);
            this.btnLocDanhSach.TabIndex = 4;
            this.btnLocDanhSach.Text = "Lọc danh sách";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(120, 83);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Trở về";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtg
            // 
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(238, 3);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(471, 482);
            this.dtg.TabIndex = 6;
            this.dtg.uDataSource = null;
            // 
            // frmNhatKyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 490);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.btnLocDanhSach);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbxNguoiDung);
            this.Controls.Add(this.txtDenNgay);
            this.Controls.Add(this.txtTuNgay);
            this.Name = "frmNhatKyNguoiDung";
            this.Text = "Nhật ký người dùng";
            this.ResumeLayout(false);

        }

        #endregion

        private DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker txtTuNgay;
        private DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker txtDenNgay;
        private DELFI_WHM.NET.DELFI_User_Control.uComboBox cbxNguoiDung;
        private DevExpress.XtraEditors.SimpleButton btnLocDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DELFI_WHM.NET.DELFI_User_Control.uDataGrid dtg;
    }
}