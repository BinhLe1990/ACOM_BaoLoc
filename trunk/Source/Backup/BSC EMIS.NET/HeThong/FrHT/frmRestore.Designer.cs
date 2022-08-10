namespace BSC_HRM.NET.HeThong.FrHT
{
    partial class frmRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestore));
            this.txtFileDir = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.txtPass = new BSC_HRM.NET.BSC_User_Control.uTextBox();
            this.ckbPass = new DevExpress.XtraEditors.CheckEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.OpenFileBackup = new System.Windows.Forms.OpenFileDialog();
            this.MainErr = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ckbPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainErr)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFileDir
            // 
            this.txtFileDir.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtFileDir.bIsReadOnly = true;
            this.txtFileDir.iWidth = 135;
            this.txtFileDir.Location = new System.Drawing.Point(5, 32);
            this.txtFileDir.Name = "txtFileDir";
            this.txtFileDir.sCaption = "Tập tin sao lưu";
            this.txtFileDir.SelectionStart = 0;
            this.txtFileDir.Size = new System.Drawing.Size(393, 21);
            this.txtFileDir.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(404, 32);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(31, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPass
            // 
            this.txtPass.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtPass.bIsPassword = true;
            this.txtPass.Enabled = false;
            this.txtPass.iWidth = 0;
            this.txtPass.Location = new System.Drawing.Point(140, 59);
            this.txtPass.Name = "txtPass";
            this.txtPass.SelectionStart = 0;
            this.txtPass.Size = new System.Drawing.Size(295, 21);
            this.txtPass.TabIndex = 2;
            // 
            // ckbPass
            // 
            this.ckbPass.Location = new System.Drawing.Point(3, 61);
            this.ckbPass.Name = "ckbPass";
            this.ckbPass.Properties.Caption = "Tập tin chứa mật khẩu";
            this.ckbPass.Size = new System.Drawing.Size(132, 19);
            this.ckbPass.TabIndex = 3;
            this.ckbPass.CheckedChanged += new System.EventHandler(this.ckbPass_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(229, 86);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 25);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Phục hồi dữ liệu";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(335, 86);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // OpenFileBackup
            // 
            this.OpenFileBackup.Filter = "BSC Backup Files (*.bscbk)|*.bscbk|Microsoft SQL Backup Files (*.bak)|*.bak|All F" +
                "iles (*.*)|*.*";
            this.OpenFileBackup.Title = "Open File";
            // 
            // MainErr
            // 
            this.MainErr.ContainerControl = this;
            // 
            // frmRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 129);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ckbPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFileDir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phục hồi dữ liệu";
            ((System.ComponentModel.ISupportInitialize)(this.ckbPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainErr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BSC_HRM.NET.BSC_User_Control.uTextBox txtFileDir;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private BSC_HRM.NET.BSC_User_Control.uTextBox txtPass;
        private DevExpress.XtraEditors.CheckEdit ckbPass;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.OpenFileDialog OpenFileBackup;
        private System.Windows.Forms.ErrorProvider MainErr;
    }
}