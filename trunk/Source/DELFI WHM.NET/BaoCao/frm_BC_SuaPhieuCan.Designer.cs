namespace DELFI_WHM.NET.BaoCao
{
    partial class frm_BC_SuaPhieuCan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BC_SuaPhieuCan));
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.txtWeightNote = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.dtpDenNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.dtpTuNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.griDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemDateEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemDateEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.xtraTabControl3.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit5.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit6.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // IML
            // 
            this.IML.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IML.ImageStream")));
            this.IML.TransparentColor = System.Drawing.Color.Transparent;
            this.IML.Images.SetKeyName(0, "Search.png");
            this.IML.Images.SetKeyName(1, "Exit.png");
            this.IML.Images.SetKeyName(2, "Save as.png");
            this.IML.Images.SetKeyName(3, "Open file.png");
            this.IML.Images.SetKeyName(4, "Redo.png");
            this.IML.Images.SetKeyName(5, "Cancel.png");
            this.IML.Images.SetKeyName(6, "btnSave.LargeGlyph.png");
            this.IML.Images.SetKeyName(7, "postscript.png");
            this.IML.Images.SetKeyName(8, "Print.png");
            this.IML.Images.SetKeyName(9, "replaceItem1.LargeGlyph.png");
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Appearance.Options.UseForeColor = true;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageList = this.IML;
            this.btnSearch.Location = new System.Drawing.Point(9, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 26);
            this.btnSearch.TabIndex = 84;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // xtraTabControl3
            // 
            this.xtraTabControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl3.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl3.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl3.Name = "xtraTabControl3";
            this.xtraTabControl3.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl3.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl3.Size = new System.Drawing.Size(1069, 154);
            this.xtraTabControl3.TabIndex = 83;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.AutoScroll = true;
            this.xtraTabPage3.Controls.Add(this.txtWeightNote);
            this.xtraTabPage3.Controls.Add(this.btnPrint);
            this.xtraTabPage3.Controls.Add(this.dtpDenNgay);
            this.xtraTabPage3.Controls.Add(this.btnSearch);
            this.xtraTabPage3.Controls.Add(this.dtpTuNgay);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1063, 148);
            // 
            // txtWeightNote
            // 
            this.txtWeightNote.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtWeightNote.Location = new System.Drawing.Point(12, 80);
            this.txtWeightNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeightNote.Name = "txtWeightNote";
            this.txtWeightNote.sCaption = "WeightNote:";
            this.txtWeightNote.SelectionStart = 0;
            this.txtWeightNote.Size = new System.Drawing.Size(258, 21);
            this.txtWeightNote.TabIndex = 86;
            this.txtWeightNote.Tag = "..MaNhaCungCap";
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Appearance.Options.UseForeColor = true;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageIndex = 0;
            this.btnPrint.ImageList = this.IML;
            this.btnPrint.Location = new System.Drawing.Point(116, 108);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 26);
            this.btnPrint.TabIndex = 85;
            this.btnPrint.Text = "In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(12, 50);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.sCaption = "Đến ngày:";
            this.dtpDenNgay.sFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Size = new System.Drawing.Size(258, 21);
            this.dtpDenNgay.TabIndex = 50;
            this.dtpDenNgay.uValue = new System.DateTime(2020, 4, 15, 9, 40, 0, 0);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(12, 21);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.sCaption = "Từ ngày:";
            this.dtpTuNgay.sFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Size = new System.Drawing.Size(258, 21);
            this.dtpTuNgay.TabIndex = 50;
            this.dtpTuNgay.uValue = new System.DateTime(2020, 4, 15, 9, 40, 0, 0);
            // 
            // griDanhSach
            // 
            this.griDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.griDanhSach.Location = new System.Drawing.Point(0, 154);
            this.griDanhSach.MainView = this.gridView2;
            this.griDanhSach.Name = "griDanhSach";
            this.griDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit4,
            this.repositoryItemDateEdit5,
            this.repositoryItemDateEdit6,
            this.repositoryItemMemoEdit1});
            this.griDanhSach.Size = new System.Drawing.Size(1069, 449);
            this.griDanhSach.TabIndex = 113;
            this.griDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.Row.Options.UseForeColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView2.GridControl = this.griDanhSach;
            this.gridView2.IndicatorWidth = 50;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.RowAutoHeight = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView2_CustomDrawRowIndicator);
            this.gridView2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView2_KeyUp);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Người sửa";
            this.gridColumn1.FieldName = "UserName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số phiếu cân";
            this.gridColumn2.FieldName = "WeightNote";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Thời gian sửa";
            this.gridColumn3.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn3.FieldName = "ThoiGian";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Hình thức sửa";
            this.gridColumn9.FieldName = "Loai";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Loại phiếu cân";
            this.gridColumn10.FieldName = "WeightType";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Lần cân";
            this.gridColumn4.DisplayFormat.FormatString = "N0";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "LanCan";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số ban đầu";
            this.gridColumn5.DisplayFormat.FormatString = "N0";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "SoCanBanDau";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Số sau khi sửa";
            this.gridColumn6.DisplayFormat.FormatString = "N0";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "SoSauKhiSua";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Chênh lệch";
            this.gridColumn7.DisplayFormat.FormatString = "N0";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "ChenhLech";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 8;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Ghi chú";
            this.gridColumn8.FieldName = "Ghichu";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 9;
            // 
            // repositoryItemDateEdit4
            // 
            this.repositoryItemDateEdit4.AutoHeight = false;
            this.repositoryItemDateEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit4.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit4.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit4.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit4.Name = "repositoryItemDateEdit4";
            // 
            // repositoryItemDateEdit5
            // 
            this.repositoryItemDateEdit5.AutoHeight = false;
            this.repositoryItemDateEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit5.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit5.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit5.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit5.Name = "repositoryItemDateEdit5";
            // 
            // repositoryItemDateEdit6
            // 
            this.repositoryItemDateEdit6.AutoHeight = false;
            this.repositoryItemDateEdit6.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit6.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit6.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.repositoryItemDateEdit6.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit6.Name = "repositoryItemDateEdit6";
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // frm_BC_SuaPhieuCan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 603);
            this.Controls.Add(this.griDanhSach);
            this.Controls.Add(this.xtraTabControl3);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frm_BC_SuaPhieuCan";
            this.Text = "BÁO CÁO SỬA PHIẾU CÂN";
            this.Load += new System.EventHandler(this.frm_BC_SuaPhieuCan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.xtraTabControl3.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit5.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit6.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DELFI_User_Control.uDateTimePicker2 dtpDenNgay;
        private DELFI_User_Control.uDateTimePicker2 dtpTuNgay;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.GridControl griDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit5;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DELFI_User_Control.uTextBox txtWeightNote;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
    }
}