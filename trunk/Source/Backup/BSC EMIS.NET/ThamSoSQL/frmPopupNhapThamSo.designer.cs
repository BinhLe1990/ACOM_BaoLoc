namespace BSC_HRM.NET.ThamSoSQL
{
    partial class frmPopupNhapThamSo
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
            this.txtDuongDan = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.cbxNhomDanhMuc = new BSC_HRM.NET.BSC_User_Control.uComboBox();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtDuongDan.Location = new System.Drawing.Point(9, 10);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.sCaption = "Đường dẫn";
            this.txtDuongDan.SelectionStart = 0;
            this.txtDuongDan.Size = new System.Drawing.Size(347, 21);
            this.txtDuongDan.TabIndex = 0;
            // 
            // cbxNhomDanhMuc
            // 
            this.cbxNhomDanhMuc.Location = new System.Drawing.Point(9, 36);
            this.cbxNhomDanhMuc.Name = "cbxNhomDanhMuc";
            this.cbxNhomDanhMuc.sCaption = "Nhóm danh mục";
            this.cbxNhomDanhMuc.sField = null;
            this.cbxNhomDanhMuc.Size = new System.Drawing.Size(347, 21);
            this.cbxNhomDanhMuc.TabIndex = 2;
            this.cbxNhomDanhMuc.uDisplayMember = "NhomCauLenh";
            this.cbxNhomDanhMuc.uEditValue = "";
            this.cbxNhomDanhMuc.uTableName = "HT_SQL_NHOM_CAU_LENH";
            this.cbxNhomDanhMuc.uValueMember = "MaNhom";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(273, 63);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(82, 25);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // frmPopupNhapThamSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 96);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.cbxNhomDanhMuc);
            this.Controls.Add(this.txtDuongDan);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPopupNhapThamSo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật tham số";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        public BSC_HRM.NET.BSC_User_Control.uTextBox txtDuongDan;
        public BSC_HRM.NET.BSC_User_Control.uComboBox cbxNhomDanhMuc;
    }
}