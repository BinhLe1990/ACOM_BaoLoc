namespace DELFI_WHM.NET.BaoCao
{
    partial class frmTongHop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTongHop));
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.pivotGridField6 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.dtpDenngay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.cboSanPham = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.cboShift = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.dtpTuNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField7 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField8 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.xtraTabControl3.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridField6
            // 
            this.pivotGridField6.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pivotGridField6.Appearance.Header.ForeColor = System.Drawing.Color.Black;
            this.pivotGridField6.Appearance.Header.Options.UseFont = true;
            this.pivotGridField6.Appearance.Header.Options.UseForeColor = true;
            this.pivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField6.AreaIndex = 0;
            this.pivotGridField6.Caption = "Type";
            this.pivotGridField6.FieldName = "Type";
            this.pivotGridField6.Name = "pivotGridField6";
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
            this.btnSearch.Location = new System.Drawing.Point(12, 79);
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
            this.xtraTabControl3.Size = new System.Drawing.Size(1069, 132);
            this.xtraTabControl3.TabIndex = 83;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.AutoScroll = true;
            this.xtraTabPage3.Controls.Add(this.dtpDenngay);
            this.xtraTabPage3.Controls.Add(this.cboSanPham);
            this.xtraTabPage3.Controls.Add(this.cboShift);
            this.xtraTabPage3.Controls.Add(this.btnPrint);
            this.xtraTabPage3.Controls.Add(this.btnSearch);
            this.xtraTabPage3.Controls.Add(this.dtpTuNgay);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1063, 126);
            // 
            // dtpDenngay
            // 
            this.dtpDenngay.iWidth = 80;
            this.dtpDenngay.Location = new System.Drawing.Point(239, 22);
            this.dtpDenngay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDenngay.Name = "dtpDenngay";
            this.dtpDenngay.sCaption = "Đến ngày:";
            this.dtpDenngay.sFormat = "dd/MM/yyyy";
            this.dtpDenngay.Size = new System.Drawing.Size(219, 21);
            this.dtpDenngay.TabIndex = 88;
            this.dtpDenngay.uValue = new System.DateTime(2020, 4, 15, 9, 44, 0, 0);
            // 
            // cboSanPham
            // 
            this.cboSanPham.iWidth = 80;
            this.cboSanPham.Location = new System.Drawing.Point(239, 51);
            this.cboSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.sCaption = "Sản phẩm:";
            this.cboSanPham.sColumnCaption = "Mã sản phẩm, Tên sản phẩm";
            this.cboSanPham.sField = "ItemNo, ItemName";
            this.cboSanPham.Size = new System.Drawing.Size(219, 21);
            this.cboSanPham.sNullText = "<Chọn>";
            this.cboSanPham.TabIndex = 87;
            this.cboSanPham.uDisplayMember = "ItemName";
            this.cboSanPham.uEditValue = null;
            this.cboSanPham.uValueMember = "ItemNo";
            this.cboSanPham.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboSanPham_uQueryPopUp);
            // 
            // cboShift
            // 
            this.cboShift.iWidth = 80;
            this.cboShift.Location = new System.Drawing.Point(12, 51);
            this.cboShift.Margin = new System.Windows.Forms.Padding(4);
            this.cboShift.Name = "cboShift";
            this.cboShift.sCaption = "Ca:";
            this.cboShift.sColumnCaption = "Ca";
            this.cboShift.sField = "Shift";
            this.cboShift.Size = new System.Drawing.Size(219, 21);
            this.cboShift.sNullText = "<Chọn>";
            this.cboShift.TabIndex = 86;
            this.cboShift.uDisplayMember = "Shift";
            this.cboShift.uEditValue = null;
            this.cboShift.uValueMember = "Shift";
            this.cboShift.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboShift_uQueryPopUp);
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Appearance.Options.UseForeColor = true;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageIndex = 0;
            this.btnPrint.ImageList = this.IML;
            this.btnPrint.Location = new System.Drawing.Point(115, 79);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 26);
            this.btnPrint.TabIndex = 85;
            this.btnPrint.Text = "In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.iWidth = 80;
            this.dtpTuNgay.Location = new System.Drawing.Point(12, 22);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.sCaption = "Từ ngày:";
            this.dtpTuNgay.sFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Size = new System.Drawing.Size(219, 21);
            this.dtpTuNgay.TabIndex = 50;
            this.dtpTuNgay.uValue = new System.DateTime(2020, 4, 15, 9, 44, 0, 0);
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Appearance.ColumnHeaderArea.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pivotGridControl1.Appearance.ColumnHeaderArea.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.ColumnHeaderArea.Options.UseFont = true;
            this.pivotGridControl1.Appearance.ColumnHeaderArea.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.DataHeaderArea.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pivotGridControl1.Appearance.DataHeaderArea.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.DataHeaderArea.Options.UseFont = true;
            this.pivotGridControl1.Appearance.DataHeaderArea.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.FieldHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pivotGridControl1.Appearance.FieldHeader.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.FieldHeader.Options.UseFont = true;
            this.pivotGridControl1.Appearance.FieldHeader.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.FieldValue.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.FilterHeaderArea.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pivotGridControl1.Appearance.FilterHeaderArea.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.FilterHeaderArea.Options.UseFont = true;
            this.pivotGridControl1.Appearance.FilterHeaderArea.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.HeaderArea.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pivotGridControl1.Appearance.HeaderArea.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.HeaderArea.Options.UseFont = true;
            this.pivotGridControl1.Appearance.HeaderArea.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.RowHeaderArea.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pivotGridControl1.Appearance.RowHeaderArea.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.RowHeaderArea.Options.UseFont = true;
            this.pivotGridControl1.Appearance.RowHeaderArea.Options.UseForeColor = true;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.pivotGridField5,
            this.pivotGridField2,
            this.pivotGridField3,
            this.pivotGridField4,
            this.pivotGridField6,
            this.pivotGridField7,
            this.pivotGridField8});
            this.pivotGridControl1.ForeColor = System.Drawing.Color.Black;
            pivotGridGroup1.Fields.Add(this.pivotGridField6);
            pivotGridGroup1.Hierarchy = null;
            pivotGridGroup1.ShowNewValues = true;
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 132);
            this.pivotGridControl1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.pivotGridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pivotGridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsCustomization.AllowEdit = false;
            this.pivotGridControl1.OptionsCustomization.AllowExpand = false;
            this.pivotGridControl1.OptionsFilterPopup.GroupFilterMode = DevExpress.XtraPivotGrid.PivotGroupFilterMode.List;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotalHeader = false;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowColumnHeaders = false;
            this.pivotGridControl1.OptionsView.ShowColumnTotals = false;
            this.pivotGridControl1.OptionsView.ShowDataHeaders = false;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.OptionsView.ShowRowGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowRowTotals = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(1069, 315);
            this.pivotGridControl1.TabIndex = 84;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "Ngày";
            this.pivotGridField1.CellFormat.FormatString = "d";
            this.pivotGridField1.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pivotGridField1.FieldName = "Ngay";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.ValueFormat.FormatString = "d";
            this.pivotGridField1.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField5.AreaIndex = 1;
            this.pivotGridField5.Caption = "Ca";
            this.pivotGridField5.FieldName = "Ca";
            this.pivotGridField5.Name = "pivotGridField5";
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField2.AreaIndex = 2;
            this.pivotGridField2.Caption = "Cây hàng";
            this.pivotGridField2.FieldName = "BinCode";
            this.pivotGridField2.Name = "pivotGridField2";
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField3.AreaIndex = 3;
            this.pivotGridField3.Caption = "Sản phẩm";
            this.pivotGridField3.FieldName = "ItemNo";
            this.pivotGridField3.Name = "pivotGridField3";
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField4.AreaIndex = 4;
            this.pivotGridField4.Caption = "Lot";
            this.pivotGridField4.FieldName = "Lot";
            this.pivotGridField4.Name = "pivotGridField4";
            // 
            // pivotGridField7
            // 
            this.pivotGridField7.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pivotGridField7.Appearance.Header.ForeColor = System.Drawing.Color.Black;
            this.pivotGridField7.Appearance.Header.Options.UseFont = true;
            this.pivotGridField7.Appearance.Header.Options.UseForeColor = true;
            this.pivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField7.AreaIndex = 1;
            this.pivotGridField7.Caption = "PackageType";
            this.pivotGridField7.FieldName = "PackageCode";
            this.pivotGridField7.Name = "pivotGridField7";
            // 
            // pivotGridField8
            // 
            this.pivotGridField8.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pivotGridField8.Appearance.Header.ForeColor = System.Drawing.Color.Black;
            this.pivotGridField8.Appearance.Header.Options.UseFont = true;
            this.pivotGridField8.Appearance.Header.Options.UseForeColor = true;
            this.pivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField8.AreaIndex = 0;
            this.pivotGridField8.Caption = "Qty";
            this.pivotGridField8.CellFormat.FormatString = "N0";
            this.pivotGridField8.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField8.FieldName = "TruckQty";
            this.pivotGridField8.Name = "pivotGridField8";
            this.pivotGridField8.ValueFormat.FormatString = "N0";
            this.pivotGridField8.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // frmTongHop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 447);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.xtraTabControl3);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmTongHop";
            this.Text = "BÁO CÁO TỔNG HỢP";
            this.Load += new System.EventHandler(this.frmTongHop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.xtraTabControl3.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DELFI_User_Control.uDateTimePicker2 dtpTuNgay;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DELFI_User_Control.uComboBox cboSanPham;
        private DELFI_User_Control.uComboBox cboShift;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DELFI_User_Control.uDateTimePicker2 dtpDenngay;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField6;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField7;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField8;
    }
}