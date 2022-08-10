namespace DELFI_WHM.NET.DELFI_User_Control
{
    partial class frmDefineCondition
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
            this.cbxPhepSoSanh = new DELFI_WHM.NET.DELFI_User_Control.BSCComboBox();
            this.txtKetQua = new DELFI_WHM.NET.DELFI_User_Control.uMemoEdit();
            this.btnAnd = new DevExpress.XtraEditors.SimpleButton();
            this.btnOR = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.txtDate = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker();
            this.cbxGiaTri = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.SuspendLayout();
            // 
            // cbxPhepSoSanh
            // 
            this.cbxPhepSoSanh.bSelectedIndex = -1;
            this.cbxPhepSoSanh.bSort = false;
            this.cbxPhepSoSanh.iWidth = 0;
            this.cbxPhepSoSanh.Location = new System.Drawing.Point(0, 2);
            this.cbxPhepSoSanh.Name = "cbxPhepSoSanh";
            this.cbxPhepSoSanh.Size = new System.Drawing.Size(80, 20);
            this.cbxPhepSoSanh.TabIndex = 0;
            this.cbxPhepSoSanh.uText = "";
            // 
            // txtKetQua
            // 
            this.txtKetQua.bHAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtKetQua.iWidth = 0;
            this.txtKetQua.Location = new System.Drawing.Point(0, 49);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(280, 84);
            this.txtKetQua.TabIndex = 2;
            this.txtKetQua.uCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtKetQua.uMaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtKetQua.uEditValueChanged += new System.EventHandler(this.txtKetQua_uEditValueChanged);
            this.txtKetQua.uTextChanged += new System.EventHandler(this.txtKetQua_uTextChanged);
            // 
            // btnAnd
            // 
            this.btnAnd.Location = new System.Drawing.Point(0, 25);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(98, 23);
            this.btnAnd.TabIndex = 3;
            this.btnAnd.Text = "ADD";
            this.btnAnd.Click += new System.EventHandler(this.btnAnd_Click);
            // 
            // btnOR
            // 
            this.btnOR.Enabled = false;
            this.btnOR.Location = new System.Drawing.Point(50, 25);
            this.btnOR.Name = "btnOR";
            this.btnOR.Size = new System.Drawing.Size(48, 23);
            this.btnOR.TabIndex = 3;
            this.btnOR.Text = "OR";
            this.btnOR.Click += new System.EventHandler(this.btnOR_Click);
            // 
            // btnOK
            // 
            this.btnOK.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnOK.Location = new System.Drawing.Point(170, 25);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(55, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(225, 25);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClear.Location = new System.Drawing.Point(114, 25);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(55, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDate
            // 
            this.txtDate.iWidth = 50;
            this.txtDate.Location = new System.Drawing.Point(83, 2);
            this.txtDate.Name = "txtDate";
            this.txtDate.sCaption = "Giá trị";
            this.txtDate.Size = new System.Drawing.Size(197, 21);
            this.txtDate.TabIndex = 7;
            this.txtDate.uDateTime = new System.DateTime(2011, 7, 29, 15, 50, 7, 943);
            this.txtDate.uValue = new System.DateTime(2011, 7, 29, 15, 50, 7, 943);
            this.txtDate.Visible = false;
            // 
            // cbxGiaTri
            // 
            this.cbxGiaTri.iWidth = 50;
            this.cbxGiaTri.Location = new System.Drawing.Point(83, 2);
            this.cbxGiaTri.Name = "cbxGiaTri";
            this.cbxGiaTri.sCaption = "Giá trị";
            this.cbxGiaTri.sField = null;
            this.cbxGiaTri.Size = new System.Drawing.Size(197, 21);
            this.cbxGiaTri.TabIndex = 8;
            this.cbxGiaTri.uDisplayMember = null;
            this.cbxGiaTri.uEditValue = "";
            this.cbxGiaTri.uValueMember = null;
            // 
            // frmDefineCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(283, 135);
            this.ControlBox = false;
            this.Controls.Add(this.cbxGiaTri);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAnd);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.cbxPhepSoSanh);
            this.Controls.Add(this.btnOR);
            this.Controls.Add(this.txtDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDefineCondition";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmDefineCondition";
            this.Load += new System.EventHandler(this.frmDefineCondition_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private BSCComboBox cbxPhepSoSanh;
        private uMemoEdit txtKetQua;
        private DevExpress.XtraEditors.SimpleButton btnAnd;
        private DevExpress.XtraEditors.SimpleButton btnOR;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private uDateTimePicker txtDate;
        private uComboBox cbxGiaTri;
    }
}