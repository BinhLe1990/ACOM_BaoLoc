namespace BSC_HRM.NET.BSC_User_Control
{
    partial class uMemoEdit
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
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
            this.txtValue = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.Appearance.Options.UseTextOptions = true;
            this.lblCaption.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(100, 100);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Caption";
            // 
            // txtValue
            // 
            this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValue.Location = new System.Drawing.Point(100, 0);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(200, 100);
            this.txtValue.TabIndex = 1;
            this.txtValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtValue_Validating);
            this.txtValue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtValue_MouseUp);
            this.txtValue.DoubleClick += new System.EventHandler(this.txtValue_DoubleClick);
            this.txtValue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtValue_MouseDown);
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            this.txtValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValue_KeyUp);
            this.txtValue.Validated += new System.EventHandler(this.txtValue_Validated);
            this.txtValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValue_KeyDown);
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // uMemoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblCaption);
            this.Name = "uMemoEdit";
            this.Size = new System.Drawing.Size(300, 100);
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCaption;
        private DevExpress.XtraEditors.MemoEdit txtValue;
    }
}
