namespace BSC_EMIS.NET.FrHT
{
    partial class frmHT_DM_PopupGridAdd
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
            this.txtTEXT_HEADER = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbxTABLE_REF = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbxTAB_REF = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbxTAB_DISPLAY = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbxCANH = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtWith = new DevExpress.XtraEditors.SpinEdit();
            this.txtFORMAT = new DevExpress.XtraEditors.TextEdit();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnRef = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTAB_REF = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEXT_HEADER.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTABLE_REF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTAB_REF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTAB_DISPLAY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCANH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWith.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFORMAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTAB_REF.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTEXT_HEADER
            // 
            this.txtTEXT_HEADER.Location = new System.Drawing.Point(96, 108);
            this.txtTEXT_HEADER.Name = "txtTEXT_HEADER";
            this.txtTEXT_HEADER.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTEXT_HEADER.Properties.Appearance.Options.UseBackColor = true;
            this.txtTEXT_HEADER.Size = new System.Drawing.Size(238, 20);
            this.txtTEXT_HEADER.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Bảng liên kết";
            // 
            // cbxTABLE_REF
            // 
            this.cbxTABLE_REF.Location = new System.Drawing.Point(96, 36);
            this.cbxTABLE_REF.Name = "cbxTABLE_REF";
            this.cbxTABLE_REF.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxTABLE_REF.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxTABLE_REF.Size = new System.Drawing.Size(238, 20);
            this.cbxTABLE_REF.TabIndex = 0;
            this.cbxTABLE_REF.SelectedIndexChanged += new System.EventHandler(this.cbxTABLE_NAME_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Cột liên kết";
            // 
            // cbxTAB_REF
            // 
            this.cbxTAB_REF.Location = new System.Drawing.Point(96, 60);
            this.cbxTAB_REF.Name = "cbxTAB_REF";
            this.cbxTAB_REF.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxTAB_REF.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxTAB_REF.Size = new System.Drawing.Size(238, 20);
            this.cbxTAB_REF.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Cột hiển thị";
            // 
            // cbxTAB_DISPLAY
            // 
            this.cbxTAB_DISPLAY.Location = new System.Drawing.Point(96, 84);
            this.cbxTAB_DISPLAY.Name = "cbxTAB_DISPLAY";
            this.cbxTAB_DISPLAY.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxTAB_DISPLAY.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxTAB_DISPLAY.Size = new System.Drawing.Size(238, 20);
            this.cbxTAB_DISPLAY.TabIndex = 2;
            this.cbxTAB_DISPLAY.SelectedIndexChanged += new System.EventHandler(this.cbxTAB_DISPLAY_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(18, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Tiêu đề cột";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(18, 135);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "Độ rộng";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(18, 159);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(25, 13);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Canh";
            // 
            // cbxCANH
            // 
            this.cbxCANH.Location = new System.Drawing.Point(96, 156);
            this.cbxCANH.Name = "cbxCANH";
            this.cbxCANH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCANH.Properties.Items.AddRange(new object[] {
            "Canh trái",
            "Canh giữa",
            "Canh phải"});
            this.cbxCANH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxCANH.Size = new System.Drawing.Size(238, 20);
            this.cbxCANH.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(18, 185);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(49, 13);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "Định dạng";
            // 
            // txtWith
            // 
            this.txtWith.EditValue = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.txtWith.Location = new System.Drawing.Point(96, 132);
            this.txtWith.Name = "txtWith";
            this.txtWith.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtWith.Properties.DisplayFormat.FormatString = "N0";
            this.txtWith.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtWith.Properties.EditFormat.FormatString = "N0";
            this.txtWith.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtWith.Properties.Mask.EditMask = "N0";
            this.txtWith.Size = new System.Drawing.Size(238, 20);
            this.txtWith.TabIndex = 4;
            // 
            // txtFORMAT
            // 
            this.txtFORMAT.Location = new System.Drawing.Point(96, 180);
            this.txtFORMAT.Name = "txtFORMAT";
            this.txtFORMAT.Size = new System.Drawing.Size(238, 20);
            this.txtFORMAT.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(254, 222);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 25);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Trở lại";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(140, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 25);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(18, 222);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(116, 25);
            this.btnRef.TabIndex = 10;
            this.btnRef.Text = "Lấy lại thông tin";
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(18, 15);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(70, 13);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "Dữ liệu liên kết";
            // 
            // txtTAB_REF
            // 
            this.txtTAB_REF.Location = new System.Drawing.Point(96, 12);
            this.txtTAB_REF.Name = "txtTAB_REF";
            this.txtTAB_REF.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTAB_REF.Properties.Appearance.Options.UseBackColor = true;
            this.txtTAB_REF.Properties.ReadOnly = true;
            this.txtTAB_REF.Size = new System.Drawing.Size(238, 20);
            this.txtTAB_REF.TabIndex = 20;
            // 
            // frmHT_DM_PopupGridAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 257);
            this.Controls.Add(this.txtTAB_REF);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtWith);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.cbxCANH);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cbxTAB_DISPLAY);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbxTAB_REF);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.cbxTABLE_REF);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtFORMAT);
            this.Controls.Add(this.txtTEXT_HEADER);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHT_DM_PopupGridAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm liên kết hiển thị";
            ((System.ComponentModel.ISupportInitialize)(this.txtTEXT_HEADER.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTABLE_REF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTAB_REF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTAB_DISPLAY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCANH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWith.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFORMAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTAB_REF.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnRef;
        public DevExpress.XtraEditors.TextEdit txtTEXT_HEADER;
        public DevExpress.XtraEditors.ComboBoxEdit cbxTABLE_REF;
        public DevExpress.XtraEditors.ComboBoxEdit cbxTAB_REF;
        public DevExpress.XtraEditors.ComboBoxEdit cbxTAB_DISPLAY;
        public DevExpress.XtraEditors.ComboBoxEdit cbxCANH;
        public DevExpress.XtraEditors.SpinEdit txtWith;
        public DevExpress.XtraEditors.TextEdit txtFORMAT;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        public DevExpress.XtraEditors.TextEdit txtTAB_REF;
    }
}