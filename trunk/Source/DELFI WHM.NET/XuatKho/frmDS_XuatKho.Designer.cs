namespace DELFI_WHM.NET.XuatKho
{
    partial class frmDS_XuatKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDS_XuatKho));
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.btnTimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.dtpDenngay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.dtpTungay = new DELFI_WHM.NET.DELFI_User_Control.uDateTimePicker2();
            this.btnThemmoi = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.griDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.xtraTabControl3.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl3
            // 
            this.xtraTabControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl3.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl3.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl3.Name = "xtraTabControl3";
            this.xtraTabControl3.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl3.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl3.Size = new System.Drawing.Size(1178, 106);
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
            this.xtraTabPage3.Size = new System.Drawing.Size(1172, 100);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnTimkiem.Appearance.Options.UseForeColor = true;
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageIndex = 8;
            this.btnTimkiem.ImageList = this.IML;
            this.btnTimkiem.Location = new System.Drawing.Point(118, 61);
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
            this.dtpDenngay.iWidth = 150;
            this.dtpDenngay.Location = new System.Drawing.Point(10, 29);
            this.dtpDenngay.Name = "dtpDenngay";
            this.dtpDenngay.sCaption = "Đến ngày:";
            this.dtpDenngay.sFormat = "dd/MM/yyyy";
            this.dtpDenngay.Size = new System.Drawing.Size(268, 21);
            this.dtpDenngay.TabIndex = 105;
            this.dtpDenngay.uValue = new System.DateTime(2020, 4, 7, 9, 22, 46, 31);
            // 
            // dtpTungay
            // 
            this.dtpTungay.iWidth = 150;
            this.dtpTungay.Location = new System.Drawing.Point(10, 3);
            this.dtpTungay.Name = "dtpTungay";
            this.dtpTungay.sCaption = "Từ ngày:";
            this.dtpTungay.sFormat = "dd/MM/yyyy";
            this.dtpTungay.Size = new System.Drawing.Size(268, 21);
            this.dtpTungay.TabIndex = 104;
            this.dtpTungay.uValue = new System.DateTime(2020, 4, 7, 9, 22, 46, 31);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnThemmoi.Appearance.Options.UseForeColor = true;
            this.btnThemmoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemmoi.Image")));
            this.btnThemmoi.ImageIndex = 8;
            this.btnThemmoi.ImageList = this.IML;
            this.btnThemmoi.Location = new System.Drawing.Point(10, 61);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(103, 26);
            this.btnThemmoi.TabIndex = 95;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.AppearancePage.Header.ForeColor = System.Drawing.Color.Black;
            this.xtraTabControl1.AppearancePage.Header.Options.UseForeColor = true;
            this.xtraTabControl1.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.Black;
            this.xtraTabControl1.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1184, 611);
            this.xtraTabControl1.TabIndex = 100;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(this.griDanhSach);
            this.xtraTabPage1.Controls.Add(this.xtraTabControl3);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1178, 583);
            this.xtraTabPage1.Text = "Danh sách soạn hàng";
            // 
            // griDanhSach
            // 
            this.griDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.griDanhSach.Location = new System.Drawing.Point(0, 106);
            this.griDanhSach.MainView = this.gridView1;
            this.griDanhSach.Name = "griDanhSach";
            this.griDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.griDanhSach.Size = new System.Drawing.Size(1178, 477);
            this.griDanhSach.TabIndex = 100;
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
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.griDanhSach;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyUp);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "DocumentNo";
            this.gridColumn1.FieldName = "DocumentNo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Date";
            this.gridColumn2.ColumnEdit = this.repositoryItemDateEdit1;
            this.gridColumn2.FieldName = "Datetime";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
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
            // frmDS_XuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.xtraTabControl1);
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmDS_XuatKho";
            this.Text = "Danh sách soạn hàng";
            this.Load += new System.EventHandler(this.frmDS_XuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.xtraTabControl3.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
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
        private DevExpress.XtraGrid.GridControl griDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    }
}