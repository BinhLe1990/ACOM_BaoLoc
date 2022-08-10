namespace DELFI_WHM.NET.DELFI_User_Control
{
    partial class BSCEmisNamHoc
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
            this.udNamHoc = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.udNamHoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(100, 20);
            this.lblCaption.TabIndex = 8;
            this.lblCaption.Text = "Caption";
            // 
            // udNamHoc
            // 
            this.udNamHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.udNamHoc.EditValue = "";
            this.udNamHoc.Location = new System.Drawing.Point(100, 0);
            this.udNamHoc.Name = "udNamHoc";
            this.udNamHoc.Properties.Appearance.Options.UseTextOptions = true;
            this.udNamHoc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.udNamHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Left, "Về trước", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "", "Về trước"),
            new DevExpress.XtraEditors.Controls.EditorButton("Về sau", DevExpress.XtraEditors.Controls.ButtonPredefines.Right)});
            this.udNamHoc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.udNamHoc.Properties.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.udNamHoc_Properties_MouseWheel);
            this.udNamHoc.Size = new System.Drawing.Size(173, 20);
            this.udNamHoc.TabIndex = 9;
            this.udNamHoc.EditValueChanged += new System.EventHandler(this.udNamHoc_EditValueChanged);
            this.udNamHoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.udNamHoc_MouseDown);
            this.udNamHoc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.udNamHoc_KeyUp);
            this.udNamHoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.udNamHoc_KeyDown);
            this.udNamHoc.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.udNamHoc_ButtonPressed);
            // 
            // BSCEmisNamHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.udNamHoc);
            this.Controls.Add(this.lblCaption);
            this.Name = "BSCEmisNamHoc";
            this.Size = new System.Drawing.Size(273, 20);
            ((System.ComponentModel.ISupportInitialize)(this.udNamHoc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCaption;
        private DevExpress.XtraEditors.ButtonEdit udNamHoc;
    }
}
