namespace BSC_HRM.NET.BSC_User_Control
{
    partial class BSCEmisKhoaHoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lookUpEditValue = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEditValue
            // 
            this.lookUpEditValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpEditValue.Location = new System.Drawing.Point(100, 0);
            this.lookUpEditValue.Name = "lookUpEditValue";
            this.lookUpEditValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditValue.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKhoaHoc", "Mã", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKhoaHoc", 150, "Khóa học"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NamBatDau", "Năm BĐ", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CachViet", "Cách viết", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.lookUpEditValue.Properties.DisplayMember = "TenKhoaHoc";
            this.lookUpEditValue.Properties.NullText = "Khóa học";
            this.lookUpEditValue.Properties.PopupSizeable = false;
            this.lookUpEditValue.Properties.PopupWidth = 340;
            this.lookUpEditValue.Properties.ValueMember = "MaKhoaHoc";
            this.lookUpEditValue.Size = new System.Drawing.Size(140, 20);
            this.lookUpEditValue.TabIndex = 12;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(100, 20);
            this.lblCaption.TabIndex = 11;
            this.lblCaption.Text = "Khóa học";
            // 
            // BSCComboKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lookUpEditValue);
            this.Controls.Add(this.lblCaption);
            this.Name = "BSCComboKhoaHoc";
            this.Size = new System.Drawing.Size(240, 20);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditValue.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEditValue;
        private DevExpress.XtraEditors.LabelControl lblCaption;

    }
}
