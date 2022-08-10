namespace DELFI_WHM.NET.DELFI_User_Control
{
    partial class BSCComboBox
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
            this.cbxValue = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(100, 21);
            this.lblCaption.TabIndex = 7;
            this.lblCaption.Text = "Caption";
            // 
            // cbxValue
            // 
            this.cbxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxValue.Location = new System.Drawing.Point(100, 0);
            this.cbxValue.Name = "cbxValue";
            this.cbxValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxValue.Properties.DropDownRows = 8;
            this.cbxValue.Properties.ImmediatePopup = true;
            this.cbxValue.Properties.Sorted = true;
            this.cbxValue.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxValue.Size = new System.Drawing.Size(140, 20);
            this.cbxValue.TabIndex = 8;
            this.cbxValue.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cbxValue_EditValueChanging);
            // 
            // BSCComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxValue);
            this.Controls.Add(this.lblCaption);
            this.Name = "BSCComboBox";
            this.Size = new System.Drawing.Size(240, 21);
            ((System.ComponentModel.ISupportInitialize)(this.cbxValue.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCaption;
        private DevExpress.XtraEditors.ComboBoxEdit cbxValue;
    }
}
