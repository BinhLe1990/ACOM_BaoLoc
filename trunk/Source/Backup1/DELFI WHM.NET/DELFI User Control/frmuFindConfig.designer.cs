namespace DELFI_WHM.NET.DELFI_User_Control
{
    partial class frmUFINDConfig
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
            this.btnDown = new DevExpress.XtraEditors.SimpleButton();
            this.btnUp = new DevExpress.XtraEditors.SimpleButton();
            this.txtTIEU_DE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.cbxCANH = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ckVISIBLE = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAPPING_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HEADER_TEXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WIDTH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ALIGNMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VISIBLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FORMAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VALUE_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.btnXoaDinhDang = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTIEU_DE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCANH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckVISIBLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Location = new System.Drawing.Point(128, 462);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(120, 25);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "↓ Chọn xuống dưới";
            this.btnDown.ToolTip = "Xuống dưới";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Location = new System.Drawing.Point(22, 462);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(100, 25);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "↑ Chọn lên trên";
            this.btnUp.ToolTip = "Lên trên";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // txtTIEU_DE
            // 
            this.txtTIEU_DE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTIEU_DE.Location = new System.Drawing.Point(99, 12);
            this.txtTIEU_DE.Name = "txtTIEU_DE";
            this.txtTIEU_DE.Size = new System.Drawing.Size(640, 20);
            this.txtTIEU_DE.TabIndex = 0;
            this.txtTIEU_DE.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Thông tin tiêu đề";
            this.labelControl1.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(537, 462);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 25);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(652, 462);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 25);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Trở lại";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbxCANH
            // 
            this.cbxCANH.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxCANH.AutoHeight = false;
            this.cbxCANH.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCANH.Items.AddRange(new object[] {
            "Trái",
            "Giữa",
            "Phải"});
            this.cbxCANH.Name = "cbxCANH";
            // 
            // ckVISIBLE
            // 
            this.ckVISIBLE.AutoHeight = false;
            this.ckVISIBLE.Name = "ckVISIBLE";
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.MAPPING_NAME,
            this.HEADER_TEXT,
            this.WIDTH,
            this.ALIGNMENT,
            this.VISIBLE,
            this.FORMAT,
            this.VALUE_TYPE});
            this.gridViewMain.FixedLineWidth = 1;
            this.gridViewMain.GridControl = this.gridMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewMain.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.STT.Name = "STT";
            this.STT.OptionsColumn.AllowEdit = false;
            this.STT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.STT.OptionsColumn.AllowMove = false;
            this.STT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 40;
            // 
            // MAPPING_NAME
            // 
            this.MAPPING_NAME.Caption = "Tên cột";
            this.MAPPING_NAME.FieldName = "MAPPING_NAME";
            this.MAPPING_NAME.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MAPPING_NAME.Name = "MAPPING_NAME";
            this.MAPPING_NAME.OptionsColumn.AllowEdit = false;
            this.MAPPING_NAME.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.MAPPING_NAME.OptionsColumn.AllowMove = false;
            this.MAPPING_NAME.Visible = true;
            this.MAPPING_NAME.VisibleIndex = 1;
            this.MAPPING_NAME.Width = 150;
            // 
            // HEADER_TEXT
            // 
            this.HEADER_TEXT.Caption = "Tiêu đề cột";
            this.HEADER_TEXT.FieldName = "HEADER_TEXT";
            this.HEADER_TEXT.Name = "HEADER_TEXT";
            this.HEADER_TEXT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.HEADER_TEXT.OptionsColumn.AllowMove = false;
            this.HEADER_TEXT.Visible = true;
            this.HEADER_TEXT.VisibleIndex = 2;
            this.HEADER_TEXT.Width = 170;
            // 
            // WIDTH
            // 
            this.WIDTH.Caption = "Độ rộng";
            this.WIDTH.FieldName = "WIDTH";
            this.WIDTH.Name = "WIDTH";
            this.WIDTH.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.WIDTH.OptionsColumn.AllowMove = false;
            this.WIDTH.Visible = true;
            this.WIDTH.VisibleIndex = 3;
            this.WIDTH.Width = 60;
            // 
            // ALIGNMENT
            // 
            this.ALIGNMENT.AppearanceCell.Options.UseTextOptions = true;
            this.ALIGNMENT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ALIGNMENT.Caption = "Canh";
            this.ALIGNMENT.ColumnEdit = this.cbxCANH;
            this.ALIGNMENT.FieldName = "ALIGNMENT";
            this.ALIGNMENT.Name = "ALIGNMENT";
            this.ALIGNMENT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ALIGNMENT.OptionsColumn.AllowMove = false;
            this.ALIGNMENT.Visible = true;
            this.ALIGNMENT.VisibleIndex = 4;
            this.ALIGNMENT.Width = 70;
            // 
            // VISIBLE
            // 
            this.VISIBLE.Caption = "Hiện/Ẩn";
            this.VISIBLE.ColumnEdit = this.ckVISIBLE;
            this.VISIBLE.FieldName = "VISIBLE";
            this.VISIBLE.Name = "VISIBLE";
            this.VISIBLE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.VISIBLE.OptionsColumn.AllowMove = false;
            this.VISIBLE.Visible = true;
            this.VISIBLE.VisibleIndex = 5;
            this.VISIBLE.Width = 60;
            // 
            // FORMAT
            // 
            this.FORMAT.Caption = "Định dạng";
            this.FORMAT.FieldName = "FORMAT";
            this.FORMAT.Name = "FORMAT";
            this.FORMAT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.FORMAT.OptionsColumn.AllowMove = false;
            this.FORMAT.Visible = true;
            this.FORMAT.VisibleIndex = 6;
            // 
            // VALUE_TYPE
            // 
            this.VALUE_TYPE.Caption = "Kiểu dữ liệu";
            this.VALUE_TYPE.FieldName = "VALUE_TYPE";
            this.VALUE_TYPE.Name = "VALUE_TYPE";
            this.VALUE_TYPE.OptionsColumn.AllowEdit = false;
            this.VALUE_TYPE.OptionsColumn.AllowMove = false;
            this.VALUE_TYPE.Visible = true;
            this.VALUE_TYPE.VisibleIndex = 7;
            this.VALUE_TYPE.Width = 80;
            // 
            // gridMain
            // 
            this.gridMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMain.Location = new System.Drawing.Point(8, 12);
            this.gridMain.MainView = this.gridViewMain;
            this.gridMain.Name = "gridMain";
            this.gridMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbxCANH,
            this.ckVISIBLE});
            this.gridMain.Size = new System.Drawing.Size(731, 444);
            this.gridMain.TabIndex = 5;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // btnXoaDinhDang
            // 
            this.btnXoaDinhDang.Location = new System.Drawing.Point(254, 462);
            this.btnXoaDinhDang.Name = "btnXoaDinhDang";
            this.btnXoaDinhDang.Size = new System.Drawing.Size(159, 25);
            this.btnXoaDinhDang.TabIndex = 18;
            this.btnXoaDinhDang.Text = "Xóa định dạng đã lưu";
            this.btnXoaDinhDang.Click += new System.EventHandler(this.btnXoaDinhDang_Click);
            // 
            // frmUFINDConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 499);
            this.Controls.Add(this.btnXoaDinhDang);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtTIEU_DE);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "frmUFINDConfig";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định dạng tìm kiếm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDGridDMConfig_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtTIEU_DE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCANH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckVISIBLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDown;
        private DevExpress.XtraEditors.SimpleButton btnUp;
        private DevExpress.XtraEditors.TextEdit txtTIEU_DE;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbxCANH;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ckVISIBLE;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn MAPPING_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn HEADER_TEXT;
        private DevExpress.XtraGrid.Columns.GridColumn WIDTH;
        private DevExpress.XtraGrid.Columns.GridColumn ALIGNMENT;
        private DevExpress.XtraGrid.Columns.GridColumn VISIBLE;
        private DevExpress.XtraGrid.Columns.GridColumn FORMAT;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Columns.GridColumn VALUE_TYPE;
        private DevExpress.XtraEditors.SimpleButton btnXoaDinhDang;
    }
}