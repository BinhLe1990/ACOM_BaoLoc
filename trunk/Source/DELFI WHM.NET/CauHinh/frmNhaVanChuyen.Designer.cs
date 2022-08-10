namespace DELFI_WHM.NET.CauHinh
{
    partial class frmNhaVanChuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaVanChuyen));
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.txtTenNhaVanChuyen = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnDongBo = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaNhaVanChuyen = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.griDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNhaVanChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhaVanChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.xtraTabControl3.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.xtraTabControl3.Size = new System.Drawing.Size(1008, 52);
            this.xtraTabControl3.TabIndex = 66;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.AutoScroll = true;
            this.xtraTabPage3.Controls.Add(this.txtTenNhaVanChuyen);
            this.xtraTabPage3.Controls.Add(this.btnSearch);
            this.xtraTabPage3.Controls.Add(this.btnDongBo);
            this.xtraTabPage3.Controls.Add(this.txtMaNhaVanChuyen);
            this.xtraTabPage3.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage3.Image")));
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1002, 46);
            this.xtraTabPage3.TabPageWidth = 150;
            this.xtraTabPage3.Text = "Danh sách nhà vận chuyển";
            // 
            // txtTenNhaVanChuyen
            // 
            this.txtTenNhaVanChuyen.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtTenNhaVanChuyen.iWidth = 120;
            this.txtTenNhaVanChuyen.Location = new System.Drawing.Point(570, 4);
            this.txtTenNhaVanChuyen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNhaVanChuyen.Name = "txtTenNhaVanChuyen";
            this.txtTenNhaVanChuyen.sCaption = "Tên nhà vận chuyển:";
            this.txtTenNhaVanChuyen.SelectionStart = 0;
            this.txtTenNhaVanChuyen.Size = new System.Drawing.Size(218, 21);
            this.txtTenNhaVanChuyen.TabIndex = 0;
            this.txtTenNhaVanChuyen.Tag = "..MaNhaCungCap";
            this.txtTenNhaVanChuyen.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Appearance.Options.UseForeColor = true;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageList = this.IML;
            this.btnSearch.Location = new System.Drawing.Point(186, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 26);
            this.btnSearch.TabIndex = 67;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Visible = false;
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
            this.btnDongBo.Location = new System.Drawing.Point(11, 11);
            this.btnDongBo.Name = "btnDongBo";
            this.btnDongBo.Size = new System.Drawing.Size(169, 26);
            this.btnDongBo.TabIndex = 68;
            this.btnDongBo.Tag = "ADD";
            this.btnDongBo.Text = "Đồng bộ từ Navision về";
            this.btnDongBo.Click += new System.EventHandler(this.btnDongBo_Click);
            // 
            // txtMaNhaVanChuyen
            // 
            this.txtMaNhaVanChuyen.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtMaNhaVanChuyen.iWidth = 120;
            this.txtMaNhaVanChuyen.Location = new System.Drawing.Point(796, 4);
            this.txtMaNhaVanChuyen.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNhaVanChuyen.Name = "txtMaNhaVanChuyen";
            this.txtMaNhaVanChuyen.sCaption = "Mã nhà vận chuyển:";
            this.txtMaNhaVanChuyen.SelectionStart = 0;
            this.txtMaNhaVanChuyen.Size = new System.Drawing.Size(198, 21);
            this.txtMaNhaVanChuyen.TabIndex = 0;
            this.txtMaNhaVanChuyen.Tag = "..MaNhaCungCap";
            this.txtMaNhaVanChuyen.Visible = false;
            // 
            // griDanhSach
            // 
            this.griDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.griDanhSach.Location = new System.Drawing.Point(0, 52);
            this.griDanhSach.MainView = this.gridView1;
            this.griDanhSach.Name = "griDanhSach";
            this.griDanhSach.Size = new System.Drawing.Size(1008, 551);
            this.griDanhSach.TabIndex = 67;
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
            this.MaNhaVanChuyen,
            this.TenNhaVanChuyen});
            this.gridView1.GridControl = this.griDanhSach;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // MaNhaVanChuyen
            // 
            this.MaNhaVanChuyen.Caption = "Mã nhà vận chuyển";
            this.MaNhaVanChuyen.FieldName = "MaNhaVanChuyen";
            this.MaNhaVanChuyen.Name = "MaNhaVanChuyen";
            this.MaNhaVanChuyen.Visible = true;
            this.MaNhaVanChuyen.VisibleIndex = 0;
            // 
            // TenNhaVanChuyen
            // 
            this.TenNhaVanChuyen.Caption = "Tên nhà vận chuyển";
            this.TenNhaVanChuyen.FieldName = "TenNhaVanChuyen";
            this.TenNhaVanChuyen.Name = "TenNhaVanChuyen";
            this.TenNhaVanChuyen.Visible = true;
            this.TenNhaVanChuyen.VisibleIndex = 1;
            // 
            // frmNhaVanChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 603);
            this.Controls.Add(this.griDanhSach);
            this.Controls.Add(this.xtraTabControl3);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmNhaVanChuyen";
            this.Text = "NHÀ VẬN CHUYỂN";
            this.Load += new System.EventHandler(this.frmNhaVanChuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.xtraTabControl3.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DELFI_User_Control.uTextBox txtTenNhaVanChuyen;
        private DELFI_User_Control.uTextBox txtMaNhaVanChuyen;
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnDongBo;
        private DevExpress.XtraGrid.GridControl griDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhaVanChuyen;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhaVanChuyen;
    }
}