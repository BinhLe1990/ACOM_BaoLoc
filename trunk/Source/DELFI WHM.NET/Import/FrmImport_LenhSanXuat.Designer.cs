namespace DELFI_WHM.NET.Import
{
    partial class FrmImport_LenhSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImport_LenhSanXuat));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnFileMau = new DevExpress.XtraEditors.SimpleButton();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PostingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptNgay = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.BatchNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Lot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BinCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PalletQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptSoLuong = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PackingUnitCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LineNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LocationCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptNgay.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptDel)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnImport);
            this.panelControl1.Controls.Add(this.btnFileMau);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1198, 45);
            this.panelControl1.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Appearance.Options.UseForeColor = true;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageIndex = 0;
            this.btnImport.Location = new System.Drawing.Point(128, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(110, 26);
            this.btnImport.TabIndex = 78;
            this.btnImport.Text = "Import từ Excel";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnFileMau
            // 
            this.btnFileMau.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnFileMau.Appearance.Options.UseForeColor = true;
            this.btnFileMau.Image = ((System.Drawing.Image)(resources.GetObject("btnFileMau.Image")));
            this.btnFileMau.ImageIndex = 0;
            this.btnFileMau.Location = new System.Drawing.Point(12, 12);
            this.btnFileMau.Name = "btnFileMau";
            this.btnFileMau.Size = new System.Drawing.Size(110, 26);
            this.btnFileMau.TabIndex = 77;
            this.btnFileMau.Text = "File excel mẫu";
            this.btnFileMau.Click += new System.EventHandler(this.btnFileMau_Click);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 45);
            this.grid.MainView = this.gridView;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rptNgay,
            this.rptDel,
            this.rptSoLuong});
            this.grid.Size = new System.Drawing.Size(1198, 405);
            this.grid.TabIndex = 83;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.Row.Options.UseForeColor = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PostingDate,
            this.BatchNo,
            this.ItemNo,
            this.Lot,
            this.BinCode,
            this.PalletQty,
            this.Quantity,
            this.PackingUnitCode,
            this.LineNo,
            this.Note,
            this.UserName,
            this.LocationCode});
            this.gridView.GridControl = this.grid;
            this.gridView.IndicatorWidth = 50;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_CustomDrawRowIndicator);
            // 
            // PostingDate
            // 
            this.PostingDate.Caption = "Ngày";
            this.PostingDate.ColumnEdit = this.rptNgay;
            this.PostingDate.FieldName = "PostingDate";
            this.PostingDate.Name = "PostingDate";
            this.PostingDate.Visible = true;
            this.PostingDate.VisibleIndex = 0;
            this.PostingDate.Width = 87;
            // 
            // rptNgay
            // 
            this.rptNgay.AutoHeight = false;
            this.rptNgay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptNgay.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptNgay.Mask.EditMask = "dd/MM/yyyy";
            this.rptNgay.Mask.UseMaskAsDisplayFormat = true;
            this.rptNgay.Name = "rptNgay";
            // 
            // BatchNo
            // 
            this.BatchNo.Caption = "Lệnh sản xuất";
            this.BatchNo.FieldName = "BatchNo";
            this.BatchNo.Name = "BatchNo";
            this.BatchNo.Visible = true;
            this.BatchNo.VisibleIndex = 1;
            this.BatchNo.Width = 87;
            // 
            // ItemNo
            // 
            this.ItemNo.Caption = "Sản phẩm";
            this.ItemNo.FieldName = "ItemNo";
            this.ItemNo.Name = "ItemNo";
            this.ItemNo.Visible = true;
            this.ItemNo.VisibleIndex = 2;
            this.ItemNo.Width = 87;
            // 
            // Lot
            // 
            this.Lot.Caption = "Lot";
            this.Lot.FieldName = "Lot";
            this.Lot.Name = "Lot";
            this.Lot.Visible = true;
            this.Lot.VisibleIndex = 3;
            this.Lot.Width = 87;
            // 
            // BinCode
            // 
            this.BinCode.Caption = "Cây hàng";
            this.BinCode.FieldName = "BinCode";
            this.BinCode.Name = "BinCode";
            this.BinCode.Visible = true;
            this.BinCode.VisibleIndex = 4;
            this.BinCode.Width = 87;
            // 
            // PalletQty
            // 
            this.PalletQty.Caption = "Số lượng Pallet";
            this.PalletQty.ColumnEdit = this.rptSoLuong;
            this.PalletQty.DisplayFormat.FormatString = "N0";
            this.PalletQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PalletQty.FieldName = "PalletQty";
            this.PalletQty.Name = "PalletQty";
            this.PalletQty.Visible = true;
            this.PalletQty.VisibleIndex = 5;
            this.PalletQty.Width = 87;
            // 
            // rptSoLuong
            // 
            this.rptSoLuong.AutoHeight = false;
            this.rptSoLuong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptSoLuong.Mask.EditMask = "N0";
            this.rptSoLuong.Mask.UseMaskAsDisplayFormat = true;
            this.rptSoLuong.Name = "rptSoLuong";
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Trọng lượng";
            this.Quantity.ColumnEdit = this.rptSoLuong;
            this.Quantity.DisplayFormat.FormatString = "N0";
            this.Quantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Quantity.FieldName = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 6;
            this.Quantity.Width = 87;
            // 
            // PackingUnitCode
            // 
            this.PackingUnitCode.Caption = "Loại bao bì";
            this.PackingUnitCode.FieldName = "PackingUnitCode";
            this.PackingUnitCode.Name = "PackingUnitCode";
            this.PackingUnitCode.Visible = true;
            this.PackingUnitCode.VisibleIndex = 7;
            this.PackingUnitCode.Width = 87;
            // 
            // LineNo
            // 
            this.LineNo.Caption = "LineNo";
            this.LineNo.ColumnEdit = this.rptSoLuong;
            this.LineNo.FieldName = "LineNo";
            this.LineNo.Name = "LineNo";
            this.LineNo.Visible = true;
            this.LineNo.VisibleIndex = 8;
            // 
            // Note
            // 
            this.Note.Caption = "Ghi chú";
            this.Note.FieldName = "Note";
            this.Note.Name = "Note";
            this.Note.Visible = true;
            this.Note.VisibleIndex = 9;
            this.Note.Width = 103;
            // 
            // UserName
            // 
            this.UserName.Caption = "UserName";
            this.UserName.FieldName = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.Visible = true;
            this.UserName.VisibleIndex = 10;
            // 
            // LocationCode
            // 
            this.LocationCode.Caption = "LocationCode";
            this.LocationCode.FieldName = "LocationCode";
            this.LocationCode.Name = "LocationCode";
            this.LocationCode.Visible = true;
            this.LocationCode.VisibleIndex = 11;
            // 
            // rptDel
            // 
            this.rptDel.AutoHeight = false;
            this.rptDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rptDel.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.rptDel.Name = "rptDel";
            this.rptDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // FrmImport_LenhSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 450);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmImport_LenhSanXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Lệnh Sản Xuất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptNgay.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.SimpleButton btnFileMau;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn PostingDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rptNgay;
        private DevExpress.XtraGrid.Columns.GridColumn BatchNo;
        private DevExpress.XtraGrid.Columns.GridColumn ItemNo;
        private DevExpress.XtraGrid.Columns.GridColumn Lot;
        private DevExpress.XtraGrid.Columns.GridColumn BinCode;
        private DevExpress.XtraGrid.Columns.GridColumn PalletQty;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn PackingUnitCode;
        private DevExpress.XtraGrid.Columns.GridColumn Note;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rptDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit rptSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn UserName;
        private DevExpress.XtraGrid.Columns.GridColumn LocationCode;
        private DevExpress.XtraGrid.Columns.GridColumn LineNo;
    }
}