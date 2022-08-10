﻿namespace BSC_HRM.NET.BSC_User_Control
{
    partial class frmDataGridConfig
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
            this.ckC2 = new DevExpress.XtraEditors.CheckEdit();
            this.ckC1 = new DevExpress.XtraEditors.CheckEdit();
            this.btnDown = new DevExpress.XtraEditors.SimpleButton();
            this.btnUp = new DevExpress.XtraEditors.SimpleButton();
            this.color2 = new DevExpress.XtraEditors.ColorEdit();
            this.color1 = new DevExpress.XtraEditors.ColorEdit();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnShowAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHideAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ckC2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckC1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTIEU_DE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCANH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckVISIBLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckC2
            // 
            this.ckC2.Location = new System.Drawing.Point(246, 37);
            this.ckC2.Name = "ckC2";
            this.ckC2.Properties.Caption = "Màu dòng 2";
            this.ckC2.Size = new System.Drawing.Size(86, 19);
            this.ckC2.TabIndex = 24;
            this.ckC2.CheckedChanged += new System.EventHandler(this.ckC2_CheckedChanged);
            // 
            // ckC1
            // 
            this.ckC1.Location = new System.Drawing.Point(10, 37);
            this.ckC1.Name = "ckC1";
            this.ckC1.Properties.Caption = "Màu dòng 1";
            this.ckC1.Size = new System.Drawing.Size(83, 19);
            this.ckC1.TabIndex = 25;
            this.ckC1.CheckedChanged += new System.EventHandler(this.ckC1_CheckedChanged);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(118, 73);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(120, 25);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "↓ Chọn xuống dưới";
            this.btnDown.ToolTip = "Xuống dưới";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(12, 73);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(100, 25);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "↑ Chọn lên trên";
            this.btnUp.ToolTip = "Lên trên";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // color2
            // 
            this.color2.EditValue = System.Drawing.Color.AliceBlue;
            this.color2.Location = new System.Drawing.Point(340, 36);
            this.color2.Name = "color2";
            this.color2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.color2.Size = new System.Drawing.Size(139, 20);
            this.color2.TabIndex = 2;
            this.color2.EditValueChanged += new System.EventHandler(this.color2_EditValueChanged);
            // 
            // color1
            // 
            this.color1.EditValue = System.Drawing.Color.White;
            this.color1.Location = new System.Drawing.Point(99, 36);
            this.color1.Name = "color1";
            this.color1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.color1.Size = new System.Drawing.Size(139, 20);
            this.color1.TabIndex = 1;
            this.color1.EditValueChanged += new System.EventHandler(this.color1_EditValueChanged);
            // 
            // txtTIEU_DE
            // 
            this.txtTIEU_DE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTIEU_DE.Location = new System.Drawing.Point(99, 12);
            this.txtTIEU_DE.Name = "txtTIEU_DE";
            this.txtTIEU_DE.Size = new System.Drawing.Size(757, 20);
            this.txtTIEU_DE.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Thông tin tiêu đề";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(654, 73);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 25);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(769, 73);
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
            this.gridMain.Location = new System.Drawing.Point(12, 104);
            this.gridMain.MainView = this.gridViewMain;
            this.gridMain.Name = "gridMain";
            this.gridMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbxCANH,
            this.ckVISIBLE});
            this.gridMain.Size = new System.Drawing.Size(844, 336);
            this.gridMain.TabIndex = 5;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            this.gridMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridMain_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowAll,
            this.btnHideAll});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 48);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(189, 22);
            this.btnShowAll.Text = "Hiển thị tất cả các cột";
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnHideAll
            // 
            this.btnHideAll.Name = "btnHideAll";
            this.btnHideAll.Size = new System.Drawing.Size(189, 22);
            this.btnHideAll.Text = "Ẩn tất cả các cột";
            this.btnHideAll.Click += new System.EventHandler(this.btnHideAll_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Location = new System.Drawing.Point(539, 73);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(109, 25);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Xóa định dạng cũ";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // frmDataGridConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 452);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.ckC2);
            this.Controls.Add(this.ckC1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.txtTIEU_DE);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDel);
            this.Name = "frmDataGridConfig";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định dạng lưới";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDGridDMConfig_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ckC2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckC1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTIEU_DE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCANH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckVISIBLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit ckC2;
        private DevExpress.XtraEditors.CheckEdit ckC1;
        private DevExpress.XtraEditors.SimpleButton btnDown;
        private DevExpress.XtraEditors.SimpleButton btnUp;
        private DevExpress.XtraEditors.ColorEdit color2;
        private DevExpress.XtraEditors.ColorEdit color1;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnShowAll;
        private System.Windows.Forms.ToolStripMenuItem btnHideAll;
        private DevExpress.XtraEditors.SimpleButton btnDel;
    }
}