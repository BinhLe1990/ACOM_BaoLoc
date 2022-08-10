namespace BSC_EMIS.NET.FrHT
{
    partial class frmHT_PHAN_QUYEN
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
            this.PERMIT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treePermit = new DevExpress.XtraTreeList.TreeList();
            this.TAGMENU = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnLUUQUYEN = new DevExpress.XtraEditors.SimpleButton();
            this.cbxNGUOIDUNG = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.treePermit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNGUOIDUNG.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PERMIT
            // 
            this.PERMIT.Caption = "Quyền sử dụng";
            this.PERMIT.FieldName = "PERMIT";
            this.PERMIT.Name = "PERMIT";
            this.PERMIT.OptionsColumn.AllowEdit = false;
            this.PERMIT.OptionsColumn.AllowMove = false;
            this.PERMIT.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.PERMIT.OptionsColumn.AllowSort = false;
            this.PERMIT.Visible = true;
            this.PERMIT.VisibleIndex = 0;
            this.PERMIT.Width = 88;
            // 
            // treePermit
            // 
            this.treePermit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treePermit.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.PERMIT,
            this.TAGMENU});
            this.treePermit.Location = new System.Drawing.Point(12, 41);
            this.treePermit.Name = "treePermit";
            this.treePermit.OptionsBehavior.AllowIndeterminateCheckState = true;
            this.treePermit.OptionsView.EnableAppearanceEvenRow = true;
            this.treePermit.OptionsView.EnableAppearanceOddRow = true;
            this.treePermit.OptionsView.ShowCheckBoxes = true;
            this.treePermit.Size = new System.Drawing.Size(587, 336);
            this.treePermit.TabIndex = 6;
            this.treePermit.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.treeList1_BeforeCheckNode);
            this.treePermit.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeList1_AfterCheckNode);
            // 
            // TAGMENU
            // 
            this.TAGMENU.Caption = "TAGMENU";
            this.TAGMENU.FieldName = "TAGMENU";
            this.TAGMENU.Name = "TAGMENU";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(505, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Trở về";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLUUQUYEN
            // 
            this.btnLUUQUYEN.Location = new System.Drawing.Point(328, 12);
            this.btnLUUQUYEN.Name = "btnLUUQUYEN";
            this.btnLUUQUYEN.Size = new System.Drawing.Size(171, 23);
            this.btnLUUQUYEN.TabIndex = 1;
            this.btnLUUQUYEN.Text = "Lưu quyền người dùng";
            this.btnLUUQUYEN.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxNGUOIDUNG
            // 
            this.cbxNGUOIDUNG.Location = new System.Drawing.Point(73, 13);
            this.cbxNGUOIDUNG.Name = "cbxNGUOIDUNG";
            this.cbxNGUOIDUNG.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbxNGUOIDUNG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxNGUOIDUNG.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NGUOIDUNG", "NGUOIDUNG", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TAIKHOAN", 80, "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HOTEN", 160, "Họ tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NHOM", "Nhóm", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KIEUGIAODIEN", "Kiểu giao diện", 90, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.cbxNGUOIDUNG.Properties.DisplayMember = "HOTEN";
            this.cbxNGUOIDUNG.Properties.NullText = "Bạn hãy chọn người dùng";
            this.cbxNGUOIDUNG.Properties.ValueMember = "NGUOIDUNG";
            this.cbxNGUOIDUNG.Size = new System.Drawing.Size(249, 20);
            this.cbxNGUOIDUNG.TabIndex = 7;
            this.cbxNGUOIDUNG.EditValueChanged += new System.EventHandler(this.cbxNGUOIDUNG_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Người dùng";
            // 
            // frmHT_PHAN_QUYEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 389);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbxNGUOIDUNG);
            this.Controls.Add(this.btnLUUQUYEN);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.treePermit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmHT_PHAN_QUYEN";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân quyền";
            ((System.ComponentModel.ISupportInitialize)(this.treePermit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNGUOIDUNG.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treePermit;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnLUUQUYEN;
        private DevExpress.XtraTreeList.Columns.TreeListColumn PERMIT;
        private DevExpress.XtraEditors.LookUpEdit cbxNGUOIDUNG;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn TAGMENU;

    }
}