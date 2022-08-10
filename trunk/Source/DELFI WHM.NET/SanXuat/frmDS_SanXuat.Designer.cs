namespace DELFI_WHM.NET.SanXuat
{
    partial class frmDS_SanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDS_SanXuat));
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.btnTimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.dtpDenngay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.dtpTungay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.btnThemmoi = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridHoanThanh = new DevExpress.XtraGrid.GridControl();
            this.gridViewHoanThanh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.xtraTabControl3.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHoanThanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHoanThanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl3
            // 
            this.xtraTabControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl3.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right;
            this.xtraTabControl3.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl3.Name = "xtraTabControl3";
            this.xtraTabControl3.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl3.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl3.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl3.Size = new System.Drawing.Size(1178, 109);
            this.xtraTabControl3.TabIndex = 94;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.AutoScroll = true;
            this.xtraTabPage3.Controls.Add(this.btnTimkiem);
            this.xtraTabPage3.Controls.Add(this.dtpDenngay);
            this.xtraTabPage3.Controls.Add(this.dtpTungay);
            this.xtraTabPage3.Controls.Add(this.btnThemmoi);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1172, 103);
            this.xtraTabPage3.Text = "Danh sách Lệnh sản xuất";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnTimkiem.Appearance.Options.UseForeColor = true;
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageIndex = 8;
            this.btnTimkiem.ImageList = this.IML;
            this.btnTimkiem.Location = new System.Drawing.Point(119, 74);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(103, 26);
            this.btnTimkiem.TabIndex = 106;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
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
            // dtpDenngay
            // 
            this.dtpDenngay.Location = new System.Drawing.Point(10, 41);
            this.dtpDenngay.Name = "dtpDenngay";
            this.dtpDenngay.sCaption = "Đến ngày:";
            this.dtpDenngay.sFormat = "dd/MM/yyyy";
            this.dtpDenngay.Size = new System.Drawing.Size(268, 21);
            this.dtpDenngay.TabIndex = 105;
            this.dtpDenngay.uValue = new System.DateTime(2020, 4, 15, 9, 57, 0, 0);
            // 
            // dtpTungay
            // 
            this.dtpTungay.Location = new System.Drawing.Point(10, 15);
            this.dtpTungay.Name = "dtpTungay";
            this.dtpTungay.sCaption = "Từ ngày:";
            this.dtpTungay.sFormat = "dd/MM/yyyy";
            this.dtpTungay.Size = new System.Drawing.Size(268, 21);
            this.dtpTungay.TabIndex = 104;
            this.dtpTungay.uValue = new System.DateTime(2020, 4, 15, 9, 57, 0, 0);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnThemmoi.Appearance.Options.UseForeColor = true;
            this.btnThemmoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemmoi.Image")));
            this.btnThemmoi.ImageIndex = 8;
            this.btnThemmoi.ImageList = this.IML;
            this.btnThemmoi.Location = new System.Drawing.Point(10, 74);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(103, 26);
            this.btnThemmoi.TabIndex = 95;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Size = new System.Drawing.Size(1184, 611);
            this.xtraTabControl1.TabIndex = 100;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(this.gridHoanThanh);
            this.xtraTabPage1.Controls.Add(this.xtraTabControl3);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1178, 583);
            this.xtraTabPage1.Text = "Danh sách Lệnh sản xuất";
            // 
            // gridHoanThanh
            // 
            this.gridHoanThanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHoanThanh.Location = new System.Drawing.Point(0, 109);
            this.gridHoanThanh.MainView = this.gridViewHoanThanh;
            this.gridHoanThanh.Name = "gridHoanThanh";
            this.gridHoanThanh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit2});
            this.gridHoanThanh.Size = new System.Drawing.Size(1178, 474);
            this.gridHoanThanh.TabIndex = 101;
            this.gridHoanThanh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHoanThanh});
            // 
            // gridViewHoanThanh
            // 
            this.gridViewHoanThanh.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewHoanThanh.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewHoanThanh.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewHoanThanh.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewHoanThanh.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewHoanThanh.Appearance.Row.Options.UseForeColor = true;
            this.gridViewHoanThanh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn22});
            this.gridViewHoanThanh.GridControl = this.gridHoanThanh;
            this.gridViewHoanThanh.IndicatorWidth = 50;
            this.gridViewHoanThanh.Name = "gridViewHoanThanh";
            this.gridViewHoanThanh.OptionsBehavior.Editable = false;
            this.gridViewHoanThanh.OptionsView.ShowGroupPanel = false;
            this.gridViewHoanThanh.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn14, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewHoanThanh.ViewCaption = "Lệnh sản xuất đã hoàn thành";
            this.gridViewHoanThanh.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewHoanThanh_CustomDrawRowIndicator);
            this.gridViewHoanThanh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridViewHoanThanh_KeyUp);
            this.gridViewHoanThanh.DoubleClick += new System.EventHandler(this.gridViewHoanThanh_DoubleClick);
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Lệnh sản xuất";
            this.gridColumn12.FieldName = "ContractNo";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Số phiếu cân";
            this.gridColumn13.FieldName = "WeightNote";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Ngày";
            this.gridColumn14.ColumnEdit = this.repositoryItemDateEdit2;
            this.gridColumn14.FieldName = "PostingDate";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 1;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Lot";
            this.gridColumn17.FieldName = "Lot";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 3;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Cây hàng";
            this.gridColumn18.FieldName = "BinCode";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 4;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "ID";
            this.gridColumn22.FieldName = "ID";
            this.gridColumn22.Name = "gridColumn22";
            // 
            // frmDS_SanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.xtraTabControl1);
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmDS_SanXuat";
            this.Text = "Xuất nguyên liệu cho sản xuất";
            this.Load += new System.EventHandler(this.frmDS_SanXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.xtraTabControl3.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHoanThanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHoanThanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraEditors.SimpleButton btnThemmoi;
        private DELFI_User_Control.uDateTimePicker2 dtpDenngay;
        private DELFI_User_Control.uDateTimePicker2 dtpTungay;
        private DevExpress.XtraEditors.SimpleButton btnTimkiem;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridHoanThanh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHoanThanh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
    }
}