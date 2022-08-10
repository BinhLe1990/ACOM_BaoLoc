namespace DELFI_WHM.NET.HeThong
{
    partial class frmKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKey));
            this.btnCheck = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheckAll = new DevExpress.XtraBars.BarButtonItem();
            this.btnUnCheckAll = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtRequestKey = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtProductKey = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Caption = "Check chọn";
            this.btnCheck.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCheck.Glyph")));
            this.btnCheck.Id = 11;
            this.btnCheck.Name = "btnCheck";
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Caption = "Chọn tắt cả";
            this.btnCheckAll.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCheckAll.Glyph")));
            this.btnCheckAll.Id = 9;
            this.btnCheckAll.Name = "btnCheckAll";
            // 
            // btnUnCheckAll
            // 
            this.btnUnCheckAll.Caption = "Bỏ chọn tắt cả";
            this.btnUnCheckAll.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUnCheckAll.Glyph")));
            this.btnUnCheckAll.Id = 10;
            this.btnUnCheckAll.Name = "btnUnCheckAll";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnCheckAll,
            this.btnUnCheckAll,
            this.btnCheck});
            this.barManager1.MaxItemId = 14;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(506, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 99);
            this.barDockControlBottom.Size = new System.Drawing.Size(506, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 99);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(506, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 99);
            // 
            // txtRequestKey
            // 
            this.txtRequestKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequestKey.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtRequestKey.bIsReadOnly = true;
            this.txtRequestKey.Location = new System.Drawing.Point(12, 12);
            this.txtRequestKey.Name = "txtRequestKey";
            this.txtRequestKey.sCaption = "Request Key";
            this.txtRequestKey.SelectionStart = 0;
            this.txtRequestKey.Size = new System.Drawing.Size(482, 20);
            this.txtRequestKey.TabIndex = 4;
            // 
            // txtProductKey
            // 
            this.txtProductKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductKey.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtProductKey.Location = new System.Drawing.Point(12, 38);
            this.txtProductKey.Name = "txtProductKey";
            this.txtProductKey.sCaption = "Product Key";
            this.txtProductKey.SelectionStart = 0;
            this.txtProductKey.Size = new System.Drawing.Size(482, 20);
            this.txtProductKey.TabIndex = 5;
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(409, 64);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 26);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 99);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtProductKey);
            this.Controls.Add(this.txtRequestKey);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKey";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Add or Remove Content";
            this.Text = "Keys";
            this.Load += new System.EventHandler(this.frmKey_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem btnCheck;
        private DevExpress.XtraBars.BarButtonItem btnCheckAll;
        private DevExpress.XtraBars.BarButtonItem btnUnCheckAll;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DELFI_User_Control.uTextBox txtProductKey;
        private DELFI_User_Control.uTextBox txtRequestKey;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
    }
}