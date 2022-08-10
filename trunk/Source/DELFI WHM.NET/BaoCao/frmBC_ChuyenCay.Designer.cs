namespace DELFI_WHM.NET.BaoCao
{
    partial class frmBC_ChuyenCay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBC_ChuyenCay));
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cboShift = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn_Tonghop = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimkiem_Tonghop = new DevExpress.XtraEditors.SimpleButton();
            this.dtpNgay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.grid_Tonghop = new DevExpress.XtraGrid.GridControl();
            this.gridView_Tonghop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Tonghop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Tonghop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.cboShift);
            this.groupControl1.Controls.Add(this.btnExport);
            this.groupControl1.Controls.Add(this.btnIn_Tonghop);
            this.groupControl1.Controls.Add(this.btnTimkiem_Tonghop);
            this.groupControl1.Controls.Add(this.dtpNgay);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1069, 58);
            this.groupControl1.TabIndex = 86;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // cboShift
            // 
            this.cboShift.iWidth = 80;
            this.cboShift.Location = new System.Drawing.Point(232, 25);
            this.cboShift.Margin = new System.Windows.Forms.Padding(4);
            this.cboShift.Name = "cboShift";
            this.cboShift.sCaption = "Ca:";
            this.cboShift.sColumnCaption = "Ca";
            this.cboShift.sField = "Ca";
            this.cboShift.Size = new System.Drawing.Size(212, 21);
            this.cboShift.sNullText = "<Chọn>";
            this.cboShift.TabIndex = 89;
            this.cboShift.uDisplayMember = "Ca";
            this.cboShift.uEditValue = null;
            this.cboShift.uValueMember = "Ca";
            this.cboShift.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboShift_uQueryPopUp);
            // 
            // btnExport
            // 
            this.btnExport.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Appearance.Options.UseForeColor = true;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageIndex = 0;
            this.btnExport.ImageList = this.IML;
            this.btnExport.Location = new System.Drawing.Point(659, 26);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(98, 26);
            this.btnExport.TabIndex = 88;
            this.btnExport.Tag = "ADD";
            this.btnExport.Text = "Export NAV";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnIn_Tonghop
            // 
            this.btnIn_Tonghop.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnIn_Tonghop.Appearance.Options.UseForeColor = true;
            this.btnIn_Tonghop.Image = ((System.Drawing.Image)(resources.GetObject("btnIn_Tonghop.Image")));
            this.btnIn_Tonghop.ImageIndex = 0;
            this.btnIn_Tonghop.ImageList = this.IML;
            this.btnIn_Tonghop.Location = new System.Drawing.Point(555, 25);
            this.btnIn_Tonghop.Name = "btnIn_Tonghop";
            this.btnIn_Tonghop.Size = new System.Drawing.Size(98, 26);
            this.btnIn_Tonghop.TabIndex = 87;
            this.btnIn_Tonghop.Text = "In";
            this.btnIn_Tonghop.Click += new System.EventHandler(this.btnIn_Tonghop_Click);
            // 
            // btnTimkiem_Tonghop
            // 
            this.btnTimkiem_Tonghop.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnTimkiem_Tonghop.Appearance.Options.UseForeColor = true;
            this.btnTimkiem_Tonghop.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem_Tonghop.Image")));
            this.btnTimkiem_Tonghop.ImageIndex = 0;
            this.btnTimkiem_Tonghop.ImageList = this.IML;
            this.btnTimkiem_Tonghop.Location = new System.Drawing.Point(451, 25);
            this.btnTimkiem_Tonghop.Name = "btnTimkiem_Tonghop";
            this.btnTimkiem_Tonghop.Size = new System.Drawing.Size(98, 26);
            this.btnTimkiem_Tonghop.TabIndex = 86;
            this.btnTimkiem_Tonghop.Text = "Tìm kiếm";
            this.btnTimkiem_Tonghop.Click += new System.EventHandler(this.btnTimkiem_Tonghop_Click);
            // 
            // dtpNgay
            // 
            this.dtpNgay.iWidth = 80;
            this.dtpNgay.Location = new System.Drawing.Point(12, 25);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.sCaption = "Ngày:";
            this.dtpNgay.sFormat = "dd/MM/yyyy";
            this.dtpNgay.Size = new System.Drawing.Size(212, 21);
            this.dtpNgay.TabIndex = 52;
            this.dtpNgay.uValue = new System.DateTime(2020, 4, 15, 9, 40, 0, 0);
            // 
            // grid_Tonghop
            // 
            this.grid_Tonghop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Tonghop.Location = new System.Drawing.Point(0, 58);
            this.grid_Tonghop.MainView = this.gridView_Tonghop;
            this.grid_Tonghop.Name = "grid_Tonghop";
            this.grid_Tonghop.Size = new System.Drawing.Size(1069, 371);
            this.grid_Tonghop.TabIndex = 103;
            this.grid_Tonghop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Tonghop,
            this.gridView2});
            // 
            // gridView_Tonghop
            // 
            this.gridView_Tonghop.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView_Tonghop.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView_Tonghop.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView_Tonghop.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView_Tonghop.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView_Tonghop.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView_Tonghop.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView_Tonghop.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView_Tonghop.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView_Tonghop.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView_Tonghop.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView_Tonghop.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView_Tonghop.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView_Tonghop.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_Tonghop.Appearance.GroupRow.Options.UseFont = true;
            this.gridView_Tonghop.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView_Tonghop.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView_Tonghop.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView_Tonghop.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_Tonghop.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_Tonghop.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView_Tonghop.Appearance.Row.Options.UseForeColor = true;
            this.gridView_Tonghop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView_Tonghop.GridControl = this.grid_Tonghop;
            this.gridView_Tonghop.IndicatorWidth = 50;
            this.gridView_Tonghop.Name = "gridView_Tonghop";
            this.gridView_Tonghop.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView_Tonghop.OptionsBehavior.Editable = false;
            this.gridView_Tonghop.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView_Tonghop.OptionsView.ShowFooter = true;
            this.gridView_Tonghop.OptionsView.ShowGroupPanel = false;
            this.gridView_Tonghop.ViewCaption = "Chưa hoàn thành";
            this.gridView_Tonghop.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_Tonghop_CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Sản phẩm";
            this.gridColumn1.FieldName = "ItemNo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Lot";
            this.gridColumn2.FieldName = "Lot";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cây hàng đi";
            this.gridColumn3.FieldName = "NoiXuat";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Cây hàng đến";
            this.gridColumn4.FieldName = "NoiNhan";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số bao";
            this.gridColumn5.DisplayFormat.FormatString = "N0";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "SoBao";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoBao", "{0:N0}")});
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Loại bao bì";
            this.gridColumn6.FieldName = "PackageCode";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Trọng lượng";
            this.gridColumn7.DisplayFormat.FormatString = "N0";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "TrongLuong";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TrongLuong", "{0:N0}")});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grid_Tonghop;
            this.gridView2.Name = "gridView2";
            // 
            // frmBC_ChuyenCay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 429);
            this.Controls.Add(this.grid_Tonghop);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmBC_ChuyenCay";
            this.Tag = "|frmBC_ChuyenCay|";
            this.Text = "BÁO CÁO CHUYỂN CÂY HÀNG";
            this.Load += new System.EventHandler(this.frmBC_ChuyenCay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Tonghop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Tonghop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnIn_Tonghop;
        private DevExpress.XtraEditors.SimpleButton btnTimkiem_Tonghop;
        private DELFI_User_Control.uDateTimePicker2 dtpNgay;
        private DevExpress.XtraGrid.GridControl grid_Tonghop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Tonghop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DELFI_User_Control.uComboBox cboShift;
    }
}