namespace DELFI_WHM.NET.QuanLy
{
    partial class fmPhieuCan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPhieuCan));
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.dtpDenNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.dtpTuNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.cboTrangThai = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboWeightType = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.txtSoHopDong = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.griDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ExportNav = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnSearch.Location = new System.Drawing.Point(11, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 26);
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
            this.xtraTabControl3.Size = new System.Drawing.Size(1069, 152);
            this.xtraTabControl3.TabIndex = 83;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.AutoScroll = true;
            this.xtraTabPage3.Controls.Add(this.btnPrint);
            this.xtraTabPage3.Controls.Add(this.dtpDenNgay);
            this.xtraTabPage3.Controls.Add(this.btnSearch);
            this.xtraTabPage3.Controls.Add(this.dtpTuNgay);
            this.xtraTabPage3.Controls.Add(this.cboTrangThai);
            this.xtraTabPage3.Controls.Add(this.cboWeightType);
            this.xtraTabPage3.Controls.Add(this.txtSoHopDong);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1063, 146);
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Appearance.Options.UseForeColor = true;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageIndex = 0;
            this.btnPrint.ImageList = this.IML;
            this.btnPrint.Location = new System.Drawing.Point(114, 109);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 26);
            this.btnPrint.TabIndex = 85;
            this.btnPrint.Text = "In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.iWidth = 65;
            this.dtpDenNgay.Location = new System.Drawing.Point(243, 12);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDenNgay.MaskDateTime = "dd/MM/yyyy";
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.sCaption = "Đến ngày:";
            this.dtpDenNgay.sFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Size = new System.Drawing.Size(195, 21);
            this.dtpDenNgay.TabIndex = 50;
            this.dtpDenNgay.uDateTime = new System.DateTime(2020, 4, 7, 9, 22, 46, 31);
            this.dtpDenNgay.uValue = new System.DateTime(2020, 4, 7, 9, 22, 46, 31);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.iWidth = 80;
            this.dtpTuNgay.Location = new System.Drawing.Point(12, 12);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTuNgay.MaskDateTime = "dd/MM/yyyy";
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.sCaption = "Từ ngày:";
            this.dtpTuNgay.sFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Size = new System.Drawing.Size(212, 21);
            this.dtpTuNgay.TabIndex = 50;
            this.dtpTuNgay.uDateTime = new System.DateTime(2020, 4, 7, 9, 22, 46, 31);
            this.dtpTuNgay.uValue = new System.DateTime(2020, 4, 7, 9, 22, 46, 31);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.iWidth = 65;
            this.cboTrangThai.Location = new System.Drawing.Point(243, 39);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.sCaption = "Trạng thái:";
            this.cboTrangThai.sColumnCaption = "Trạng thái";
            this.cboTrangThai.sField = "Noidung";
            this.cboTrangThai.Size = new System.Drawing.Size(195, 21);
            this.cboTrangThai.sNullText = "<Chọn trạng thái>";
            this.cboTrangThai.TabIndex = 51;
            this.cboTrangThai.uDisplayMember = "Noidung";
            this.cboTrangThai.uEditValue = null;
            this.cboTrangThai.uValueMember = "Noidung";
            // 
            // cboWeightType
            // 
            this.cboWeightType.iWidth = 80;
            this.cboWeightType.Location = new System.Drawing.Point(12, 39);
            this.cboWeightType.Margin = new System.Windows.Forms.Padding(4);
            this.cboWeightType.Name = "cboWeightType";
            this.cboWeightType.sCaption = "Weight type:";
            this.cboWeightType.sColumnCaption = "Trạng thái";
            this.cboWeightType.sField = "WeightType";
            this.cboWeightType.Size = new System.Drawing.Size(212, 21);
            this.cboWeightType.sNullText = "<Chọn>";
            this.cboWeightType.TabIndex = 51;
            this.cboWeightType.uDisplayMember = "WeightType";
            this.cboWeightType.uEditValue = null;
            this.cboWeightType.uValueMember = "WeightType";
            // 
            // txtSoHopDong
            // 
            this.txtSoHopDong.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtSoHopDong.iWidth = 130;
            this.txtSoHopDong.Location = new System.Drawing.Point(12, 66);
            this.txtSoHopDong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoHopDong.Name = "txtSoHopDong";
            this.txtSoHopDong.sCaption = "Weight note/Vehicle No.:";
            this.txtSoHopDong.SelectionStart = 0;
            this.txtSoHopDong.Size = new System.Drawing.Size(426, 21);
            this.txtSoHopDong.TabIndex = 0;
            this.txtSoHopDong.Tag = "..MaNhaCungCap";
            // 
            // griDanhSach
            // 
            this.griDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.griDanhSach.Location = new System.Drawing.Point(0, 152);
            this.griDanhSach.MainView = this.gridView2;
            this.griDanhSach.Name = "griDanhSach";
            this.griDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit4,
            this.repositoryItemDateEdit5,
            this.repositoryItemDateEdit6});
            this.griDanhSach.Size = new System.Drawing.Size(1069, 451);
            this.griDanhSach.TabIndex = 112;
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
            this.ExportNav,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gridView2.GridControl = this.griDanhSach;
            this.gridView2.IndicatorWidth = 50;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView2_CustomDrawRowIndicator);
            this.gridView2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView2_KeyUp);
            // 
            // ExportNav
            // 
            this.ExportNav.Caption = "ExportNav";
            this.ExportNav.FieldName = "ExportNav";
            this.ExportNav.Name = "ExportNav";
            this.ExportNav.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.ExportNav.Visible = true;
            this.ExportNav.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số phiếu";
            this.gridColumn2.FieldName = "WeightNote";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày tạo";
            this.gridColumn3.ColumnEdit = this.repositoryItemDateEdit4;
            this.gridColumn3.FieldName = "CreateDate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
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
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số xe";
            this.gridColumn4.FieldName = "VehicleNo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Khách hàng";
            this.gridColumn5.FieldName = "VendorCode";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Sản phẩm";
            this.gridColumn6.FieldName = "ItemCode";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Ngày vào";
            this.gridColumn7.ColumnEdit = this.repositoryItemDateEdit5;
            this.gridColumn7.FieldName = "DateIn";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
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
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Ngày ra";
            this.gridColumn8.ColumnEdit = this.repositoryItemDateEdit6;
            this.gridColumn8.FieldName = "DateOut";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
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
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Cân lần 1";
            this.gridColumn9.FieldName = "FirstWeight";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Cân lần 2";
            this.gridColumn10.FieldName = "SecondWeight";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Số bao";
            this.gridColumn11.FieldName = "TruckQty";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 10;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "TL hàng xuất/nhập";
            this.gridColumn12.FieldName = "TotalPackageQty";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 11;
            // 
            // fmPhieuCan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 603);
            this.Controls.Add(this.griDanhSach);
            this.Controls.Add(this.xtraTabControl3);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "fmPhieuCan";
            this.Text = "DANH SÁCH PHIẾU CÂN";
            this.Load += new System.EventHandler(this.fmPhieuCan_Load);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DELFI_User_Control.uDateTimePicker2 dtpDenNgay;
        private DELFI_User_Control.uDateTimePicker2 dtpTuNgay;
        private DELFI_User_Control.uComboBox cboWeightType;
        private DELFI_User_Control.uTextBox txtSoHopDong;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private DELFI_User_Control.uComboBox cboTrangThai;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.GridControl griDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn ExportNav;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
    }
}