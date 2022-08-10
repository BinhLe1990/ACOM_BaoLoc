namespace DELFI_WHM.NET.DELFI_User_Control
{
    partial class uTextBox
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
            this.txtValue = new DevExpress.XtraEditors.TextEdit();
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
            this.popupContainerControl1 = new DevExpress.XtraEditors.PopupContainerControl();
            this.uNumPad1 = new DELFI_WHM.NET.DELFI_User_Control.uNumPad();
            this.popupContainerEdit1 = new DevExpress.XtraEditors.PopupContainerEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).BeginInit();
            this.popupContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValue.Location = new System.Drawing.Point(100, 0);
            this.txtValue.Margin = new System.Windows.Forms.Padding(0);
            this.txtValue.Name = "txtValue";
            this.txtValue.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtValue.Properties.Appearance.Options.UseForeColor = true;
            this.txtValue.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValue.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.txtValue.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtValue.Size = new System.Drawing.Size(200, 20);
            this.txtValue.TabIndex = 0;
            this.txtValue.EditValueChanged += new System.EventHandler(this.txtValue_EditValueChanged);
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            this.txtValue.DoubleClick += new System.EventHandler(this.txtValue_DoubleClick);
            this.txtValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValue_KeyDown);
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            this.txtValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValue_KeyUp);
            this.txtValue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtValue_MouseDown);
            this.txtValue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtValue_MouseUp);
            this.txtValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtValue_Validating);
            this.txtValue.Validated += new System.EventHandler(this.txtValue_Validated);
            // 
            // lblCaption
            // 
            this.lblCaption.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblCaption.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.LookAndFeel.SkinName = "Office 2010 Blue";
            this.lblCaption.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lblCaption.Margin = new System.Windows.Forms.Padding(0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(100, 20);
            this.lblCaption.TabIndex = 5;
            this.lblCaption.Text = "Caption";
            // 
            // popupContainerControl1
            // 
            this.popupContainerControl1.Controls.Add(this.uNumPad1);
            this.popupContainerControl1.Location = new System.Drawing.Point(0, 22);
            this.popupContainerControl1.Name = "popupContainerControl1";
            this.popupContainerControl1.Size = new System.Drawing.Size(300, 150);
            this.popupContainerControl1.TabIndex = 7;
            // 
            // uNumPad1
            // 
            this.uNumPad1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uNumPad1.Location = new System.Drawing.Point(0, 0);
            this.uNumPad1.Margin = new System.Windows.Forms.Padding(4);
            this.uNumPad1.Name = "uNumPad1";
            this.uNumPad1.Size = new System.Drawing.Size(300, 150);
            this.uNumPad1.TabIndex = 0;
            // 
            // popupContainerEdit1
            // 
            this.popupContainerEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.popupContainerEdit1.Location = new System.Drawing.Point(-3, -1);
            this.popupContainerEdit1.Name = "popupContainerEdit1";
            this.popupContainerEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.popupContainerEdit1.Properties.PopupControl = this.popupContainerControl1;
            this.popupContainerEdit1.Properties.PopupSizeable = false;
            this.popupContainerEdit1.Properties.ShowPopupCloseButton = false;
            this.popupContainerEdit1.Size = new System.Drawing.Size(100, 20);
            this.popupContainerEdit1.TabIndex = 8;
            this.popupContainerEdit1.Visible = false;
            this.popupContainerEdit1.Click += new System.EventHandler(this.popupContainerEdit1_Click);
            // 
            // uTextBox
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.popupContainerControl1);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.popupContainerEdit1);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "uTextBox";
            this.Size = new System.Drawing.Size(300, 20);
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).EndInit();
            this.popupContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtValue;
        private DevExpress.XtraEditors.LabelControl lblCaption;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl1;
        private uNumPad uNumPad1;
        private DevExpress.XtraEditors.PopupContainerEdit popupContainerEdit1;
    }
}
