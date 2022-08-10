namespace DELFI_WHM.NET.QuanLy
{
    partial class frmHopDongMuaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDongMuaHang));
            this.dtpDenNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.dtpTuNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.txtSoHopDong = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnDongBo = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.griDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SoHopDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.NhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LocationCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Certification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cropyear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contractnetwt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitOfMeasure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WeightNotNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.xtraTabControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.iWidth = 65;
            this.dtpDenNgay.Location = new System.Drawing.Point(271, 27);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDenNgay.MaskDateTime = "dd/MM/yyyy";
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.sCaption = "Đến ngày:";
            this.dtpDenNgay.sFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Size = new System.Drawing.Size(184, 21);
            this.dtpDenNgay.TabIndex = 50;
            this.dtpDenNgay.uDateTime = new System.DateTime(2020, 4, 7, 9, 22, 46, 31);
            this.dtpDenNgay.uValue = new System.DateTime(2020, 4, 7, 9, 22, 46, 31);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.iWidth = 90;
            this.dtpTuNgay.Location = new System.Drawing.Point(40, 27);
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
            // txtSoHopDong
            // 
            this.txtSoHopDong.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtSoHopDong.iWidth = 90;
            this.txtSoHopDong.Location = new System.Drawing.Point(40, 56);
            this.txtSoHopDong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoHopDong.Name = "txtSoHopDong";
            this.txtSoHopDong.sCaption = "Số hợp đồng:";
            this.txtSoHopDong.SelectionStart = 0;
            this.txtSoHopDong.Size = new System.Drawing.Size(415, 21);
            this.txtSoHopDong.TabIndex = 0;
            this.txtSoHopDong.Tag = "..MaNhaCungCap";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.AutoScroll = true;
            this.xtraTabPage3.Controls.Add(this.dtpDenNgay);
            this.xtraTabPage3.Controls.Add(this.btnSearch);
            this.xtraTabPage3.Controls.Add(this.dtpTuNgay);
            this.xtraTabPage3.Controls.Add(this.btnDongBo);
            this.xtraTabPage3.Controls.Add(this.txtSoHopDong);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1063, 94);
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Appearance.Options.UseForeColor = true;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageList = this.IML;
            this.btnSearch.Location = new System.Drawing.Point(462, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 26);
            this.btnSearch.TabIndex = 80;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // btnDongBo
            // 
            this.btnDongBo.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnDongBo.Appearance.Options.UseForeColor = true;
            this.btnDongBo.Image = ((System.Drawing.Image)(resources.GetObject("btnDongBo.Image")));
            this.btnDongBo.ImageIndex = 9;
            this.btnDongBo.ImageList = this.IML;
            this.btnDongBo.Location = new System.Drawing.Point(566, 51);
            this.btnDongBo.Name = "btnDongBo";
            this.btnDongBo.Size = new System.Drawing.Size(169, 26);
            this.btnDongBo.TabIndex = 81;
            this.btnDongBo.Tag = "ADD";
            this.btnDongBo.Text = "Đồng bộ từ Navision về";
            this.btnDongBo.Click += new System.EventHandler(this.btnDongBo_Click);
            // 
            // xtraTabControl3
            // 
            this.xtraTabControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl3.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl3.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl3.Name = "xtraTabControl3";
            this.xtraTabControl3.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl3.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl3.Size = new System.Drawing.Size(1069, 100);
            this.xtraTabControl3.TabIndex = 79;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // griDanhSach
            // 
            this.griDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.griDanhSach.Location = new System.Drawing.Point(0, 100);
            this.griDanhSach.MainView = this.gridView1;
            this.griDanhSach.Name = "griDanhSach";
            this.griDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.griDanhSach.Size = new System.Drawing.Size(1069, 503);
            this.griDanhSach.TabIndex = 83;
            this.griDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SoHopDong,
            this.NgayHD,
            this.NhaCC,
            this.LocationCode,
            this.SanPham,
            this.Certification,
            this.cropyear,
            this.contractnetwt,
            this.UnitOfMeasure,
            this.WeightNotNo});
            this.gridView1.GridControl = this.griDanhSach;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyUp);
            // 
            // SoHopDong
            // 
            this.SoHopDong.Caption = "Số hợp đồng";
            this.SoHopDong.FieldName = "ContractNo";
            this.SoHopDong.Name = "SoHopDong";
            this.SoHopDong.Visible = true;
            this.SoHopDong.VisibleIndex = 0;
            // 
            // NgayHD
            // 
            this.NgayHD.Caption = "Ngày hợp đồng";
            this.NgayHD.ColumnEdit = this.repositoryItemDateEdit1;
            this.NgayHD.FieldName = "ContractDate";
            this.NgayHD.Name = "NgayHD";
            this.NgayHD.Visible = true;
            this.NgayHD.VisibleIndex = 1;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // NhaCC
            // 
            this.NhaCC.Caption = "Nhà cung cấp";
            this.NhaCC.FieldName = "VendorName";
            this.NhaCC.Name = "NhaCC";
            this.NhaCC.Visible = true;
            this.NhaCC.VisibleIndex = 2;
            // 
            // LocationCode
            // 
            this.LocationCode.Caption = "Location code";
            this.LocationCode.FieldName = "LocationCode";
            this.LocationCode.Name = "LocationCode";
            this.LocationCode.Visible = true;
            this.LocationCode.VisibleIndex = 3;
            // 
            // SanPham
            // 
            this.SanPham.Caption = "Sản phẩm";
            this.SanPham.FieldName = "ItemNo";
            this.SanPham.Name = "SanPham";
            this.SanPham.Visible = true;
            this.SanPham.VisibleIndex = 4;
            // 
            // Certification
            // 
            this.Certification.Caption = "Chứng nhận";
            this.Certification.FieldName = "Cert";
            this.Certification.Name = "Certification";
            this.Certification.Visible = true;
            this.Certification.VisibleIndex = 5;
            // 
            // cropyear
            // 
            this.cropyear.Caption = "Crop year";
            this.cropyear.FieldName = "CropYear";
            this.cropyear.Name = "cropyear";
            this.cropyear.Visible = true;
            this.cropyear.VisibleIndex = 6;
            // 
            // contractnetwt
            // 
            this.contractnetwt.Caption = "Contract net Wt. (Kg)";
            this.contractnetwt.DisplayFormat.FormatString = "N0";
            this.contractnetwt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.contractnetwt.FieldName = "ContractNetWeight";
            this.contractnetwt.Name = "contractnetwt";
            this.contractnetwt.Visible = true;
            this.contractnetwt.VisibleIndex = 7;
            // 
            // UnitOfMeasure
            // 
            this.UnitOfMeasure.Caption = "Unit of Measure";
            this.UnitOfMeasure.FieldName = "UnitOfMeasure";
            this.UnitOfMeasure.Name = "UnitOfMeasure";
            this.UnitOfMeasure.Visible = true;
            this.UnitOfMeasure.VisibleIndex = 8;
            // 
            // WeightNotNo
            // 
            this.WeightNotNo.Caption = "Weight Note No.";
            this.WeightNotNo.FieldName = "WeightNoteNo";
            this.WeightNotNo.Name = "WeightNotNo";
            this.WeightNotNo.Visible = true;
            this.WeightNotNo.VisibleIndex = 9;
            // 
            // frmHopDongMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 603);
            this.Controls.Add(this.griDanhSach);
            this.Controls.Add(this.xtraTabControl3);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmHopDongMuaHang";
            this.Text = "HỢP ĐỒNG MUA HÀNG";
            this.Load += new System.EventHandler(this.frmHopDongMuaHang_Load);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.xtraTabControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DELFI_User_Control.uDateTimePicker2 dtpDenNgay;
        private DELFI_User_Control.uDateTimePicker2 dtpTuNgay;
        private DELFI_User_Control.uTextBox txtSoHopDong;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private DevExpress.XtraEditors.SimpleButton btnDongBo;
        private DevExpress.XtraGrid.GridControl griDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn SoHopDong;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHD;
        private DevExpress.XtraGrid.Columns.GridColumn NhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn SanPham;
        private DevExpress.XtraGrid.Columns.GridColumn LocationCode;
        private DevExpress.XtraGrid.Columns.GridColumn Certification;
        private DevExpress.XtraGrid.Columns.GridColumn cropyear;
        private DevExpress.XtraGrid.Columns.GridColumn contractnetwt;
        private DevExpress.XtraGrid.Columns.GridColumn UnitOfMeasure;
        private DevExpress.XtraGrid.Columns.GridColumn WeightNotNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    }
}