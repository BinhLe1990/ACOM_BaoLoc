namespace DELFI_WHM.NET.DELFI_User_Control
{
    partial class uComboBox
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
            this.cbxValue = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbxValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxValue
            // 
            this.cbxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxValue.EditValue = "";
            this.cbxValue.Location = new System.Drawing.Point(100, 0);
            this.cbxValue.Name = "cbxValue";
            this.cbxValue.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbxValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxValue.Properties.NullText = "<Chọn giá trị>";
            this.cbxValue.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxValue.Size = new System.Drawing.Size(200, 20);
            this.cbxValue.TabIndex = 1;
            this.cbxValue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cbxValue_MouseUp);
            this.cbxValue.EditValueChanged += new System.EventHandler(this.cbxValue_EditValueChanged);
            this.cbxValue.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cbxValue_EditValueChanging);
            this.cbxValue.Leave += new System.EventHandler(this.cbxValue_Leave);
            this.cbxValue.DoubleClick += new System.EventHandler(this.cbxValue_DoubleClick);
            this.cbxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxValue_KeyPress);
            this.cbxValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxValue_KeyUp);
            this.cbxValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxValue_KeyDown);
            this.cbxValue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbxValue_MouseDown);
            this.cbxValue.Click += new System.EventHandler(this.cbxValue_Click);
            // 
            // lblCaption
            // 
            this.lblCaption.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(100, 21);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Caption";
            // 
            // uComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxValue);
            this.Controls.Add(this.lblCaption);
            this.Name = "uComboBox";
            this.Size = new System.Drawing.Size(300, 21);
            ((System.ComponentModel.ISupportInitialize)(this.cbxValue.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cbxValue;
        private DevExpress.XtraEditors.LabelControl lblCaption;
    }
}
