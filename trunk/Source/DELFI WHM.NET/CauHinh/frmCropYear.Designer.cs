namespace DELFI_WHM.NET.CauHinh
{
    partial class frmCropYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCropYear));
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cropyear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCropyear = new DevExpress.XtraGrid.GridControl();
            this.btnLuuCropyear = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.txtCropyear = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtCertification = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.btnLuuCertification = new DevExpress.XtraEditors.SimpleButton();
            this.gridCertification = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtPile = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.btnLuuPile = new DevExpress.XtraEditors.SimpleButton();
            this.gridPile = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCropyear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.xtraTabControl3.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCertification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
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
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cropyear});
            this.gridView1.GridControl = this.gridCropyear;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyUp);
            // 
            // cropyear
            // 
            this.cropyear.Caption = "Crop year";
            this.cropyear.FieldName = "Ten";
            this.cropyear.Name = "cropyear";
            this.cropyear.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.cropyear.Visible = true;
            this.cropyear.VisibleIndex = 0;
            // 
            // gridCropyear
            // 
            this.gridCropyear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridCropyear.Location = new System.Drawing.Point(3, 46);
            this.gridCropyear.MainView = this.gridView1;
            this.gridCropyear.Name = "gridCropyear";
            this.gridCropyear.Size = new System.Drawing.Size(301, 526);
            this.gridCropyear.TabIndex = 61;
            this.gridCropyear.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btnLuuCropyear
            // 
            this.btnLuuCropyear.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnLuuCropyear.Appearance.Options.UseForeColor = true;
            this.btnLuuCropyear.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuCropyear.Image")));
            this.btnLuuCropyear.ImageIndex = 6;
            this.btnLuuCropyear.ImageList = this.IML;
            this.btnLuuCropyear.Location = new System.Drawing.Point(205, 13);
            this.btnLuuCropyear.Name = "btnLuuCropyear";
            this.btnLuuCropyear.Size = new System.Drawing.Size(90, 26);
            this.btnLuuCropyear.TabIndex = 64;
            this.btnLuuCropyear.Tag = "ADD";
            this.btnLuuCropyear.Text = "Lưu";
            this.btnLuuCropyear.Click += new System.EventHandler(this.btnLuuCropyear_Click);
            // 
            // xtraTabControl3
            // 
            this.xtraTabControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.xtraTabControl3.Appearance.Options.UseForeColor = true;
            this.xtraTabControl3.AppearancePage.Header.ForeColor = System.Drawing.Color.Black;
            this.xtraTabControl3.AppearancePage.Header.Options.UseForeColor = true;
            this.xtraTabControl3.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.Black;
            this.xtraTabControl3.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.xtraTabControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.xtraTabControl3.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl3.Name = "xtraTabControl3";
            this.xtraTabControl3.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl3.Size = new System.Drawing.Size(313, 603);
            this.xtraTabControl3.TabIndex = 62;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.AutoScroll = true;
            this.xtraTabPage3.Controls.Add(this.txtCropyear);
            this.xtraTabPage3.Controls.Add(this.btnLuuCropyear);
            this.xtraTabPage3.Controls.Add(this.gridCropyear);
            this.xtraTabPage3.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage3.Image")));
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(307, 572);
            this.xtraTabPage3.TabPageWidth = 150;
            this.xtraTabPage3.Text = "CROP YEAR";
            // 
            // txtCropyear
            // 
            this.txtCropyear.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtCropyear.iWidth = 80;
            this.txtCropyear.Location = new System.Drawing.Point(13, 18);
            this.txtCropyear.Margin = new System.Windows.Forms.Padding(4);
            this.txtCropyear.Name = "txtCropyear";
            this.txtCropyear.sCaption = "Crop year (*):";
            this.txtCropyear.SelectionStart = 0;
            this.txtCropyear.Size = new System.Drawing.Size(186, 21);
            this.txtCropyear.TabIndex = 0;
            this.txtCropyear.Tag = "..MaNhaCungCap";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.AppearancePage.Header.ForeColor = System.Drawing.Color.Black;
            this.xtraTabControl1.AppearancePage.Header.Options.UseForeColor = true;
            this.xtraTabControl1.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.Black;
            this.xtraTabControl1.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xtraTabControl1.Location = new System.Drawing.Point(313, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(349, 603);
            this.xtraTabControl1.TabIndex = 62;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(this.txtCertification);
            this.xtraTabPage1.Controls.Add(this.btnLuuCertification);
            this.xtraTabPage1.Controls.Add(this.gridCertification);
            this.xtraTabPage1.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(343, 572);
            this.xtraTabPage1.TabPageWidth = 150;
            this.xtraTabPage1.Text = "CERTIFICATIONS";
            // 
            // txtCertification
            // 
            this.txtCertification.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtCertification.iWidth = 80;
            this.txtCertification.Location = new System.Drawing.Point(14, 18);
            this.txtCertification.Margin = new System.Windows.Forms.Padding(4);
            this.txtCertification.Name = "txtCertification";
            this.txtCertification.sCaption = "Certification (*):";
            this.txtCertification.SelectionStart = 0;
            this.txtCertification.Size = new System.Drawing.Size(205, 21);
            this.txtCertification.TabIndex = 0;
            this.txtCertification.Tag = "..MaNhaCungCap";
            // 
            // btnLuuCertification
            // 
            this.btnLuuCertification.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnLuuCertification.Appearance.Options.UseForeColor = true;
            this.btnLuuCertification.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuCertification.Image")));
            this.btnLuuCertification.ImageIndex = 6;
            this.btnLuuCertification.Location = new System.Drawing.Point(225, 13);
            this.btnLuuCertification.Name = "btnLuuCertification";
            this.btnLuuCertification.Size = new System.Drawing.Size(90, 26);
            this.btnLuuCertification.TabIndex = 64;
            this.btnLuuCertification.Tag = "ADD";
            this.btnLuuCertification.Text = "Lưu";
            this.btnLuuCertification.Click += new System.EventHandler(this.btnLuuCertification_Click);
            // 
            // gridCertification
            // 
            this.gridCertification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCertification.Location = new System.Drawing.Point(3, 46);
            this.gridCertification.MainView = this.gridView2;
            this.gridCertification.Name = "gridCertification";
            this.gridCertification.Size = new System.Drawing.Size(337, 526);
            this.gridCertification.TabIndex = 61;
            this.gridCertification.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridColumn2});
            this.gridView2.GridControl = this.gridCertification;
            this.gridView2.IndicatorWidth = 50;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView2_CustomDrawRowIndicator);
            this.gridView2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView2_KeyUp);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Certification";
            this.gridColumn2.FieldName = "Ten";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.AppearancePage.Header.ForeColor = System.Drawing.Color.Black;
            this.xtraTabControl2.AppearancePage.Header.Options.UseForeColor = true;
            this.xtraTabControl2.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.Black;
            this.xtraTabControl2.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.xtraTabControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.xtraTabControl2.Location = new System.Drawing.Point(662, 0);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl2.Size = new System.Drawing.Size(319, 603);
            this.xtraTabControl2.TabIndex = 62;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.AutoScroll = true;
            this.xtraTabPage2.Controls.Add(this.txtPile);
            this.xtraTabPage2.Controls.Add(this.btnLuuPile);
            this.xtraTabPage2.Controls.Add(this.gridPile);
            this.xtraTabPage2.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(313, 572);
            this.xtraTabPage2.TabPageWidth = 150;
            this.xtraTabPage2.Text = "PILES";
            // 
            // txtPile
            // 
            this.txtPile.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtPile.iWidth = 65;
            this.txtPile.Location = new System.Drawing.Point(14, 18);
            this.txtPile.Margin = new System.Windows.Forms.Padding(4);
            this.txtPile.Name = "txtPile";
            this.txtPile.sCaption = "Pile (*):";
            this.txtPile.SelectionStart = 0;
            this.txtPile.Size = new System.Drawing.Size(188, 21);
            this.txtPile.TabIndex = 0;
            this.txtPile.Tag = "..MaNhaCungCap";
            // 
            // btnLuuPile
            // 
            this.btnLuuPile.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnLuuPile.Appearance.Options.UseForeColor = true;
            this.btnLuuPile.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuPile.Image")));
            this.btnLuuPile.ImageIndex = 6;
            this.btnLuuPile.Location = new System.Drawing.Point(209, 13);
            this.btnLuuPile.Name = "btnLuuPile";
            this.btnLuuPile.Size = new System.Drawing.Size(90, 26);
            this.btnLuuPile.TabIndex = 64;
            this.btnLuuPile.Tag = "ADD";
            this.btnLuuPile.Text = "Lưu";
            this.btnLuuPile.Click += new System.EventHandler(this.btnLuuPile_Click);
            // 
            // gridPile
            // 
            this.gridPile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridPile.Location = new System.Drawing.Point(8, 46);
            this.gridPile.MainView = this.gridView3;
            this.gridPile.Name = "gridPile";
            this.gridPile.Size = new System.Drawing.Size(301, 526);
            this.gridPile.TabIndex = 61;
            this.gridPile.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView3.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.Row.Options.UseForeColor = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4});
            this.gridView3.GridControl = this.gridPile;
            this.gridView3.IndicatorWidth = 50;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView3_CustomDrawRowIndicator);
            this.gridView3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView3_KeyUp);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Pile";
            this.gridColumn4.FieldName = "BinCode";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // frmCropYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 603);
            this.Controls.Add(this.xtraTabControl2);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.xtraTabControl3);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmCropYear";
            this.Text = "Danh sách Crop year/Certifications/Piles";
            this.Load += new System.EventHandler(this.frmCropYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCropyear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.xtraTabControl3.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCertification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DELFI_User_Control.uTextBox txtCropyear;
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn cropyear;
        private DevExpress.XtraGrid.GridControl gridCropyear;
        private DevExpress.XtraEditors.SimpleButton btnLuuCropyear;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DELFI_User_Control.uTextBox txtCertification;
        private DevExpress.XtraEditors.SimpleButton btnLuuCertification;
        private DevExpress.XtraGrid.GridControl gridCertification;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DELFI_User_Control.uTextBox txtPile;
        private DevExpress.XtraEditors.SimpleButton btnLuuPile;
        private DevExpress.XtraGrid.GridControl gridPile;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}