namespace DELFI_WHM.NET.CauHinh
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.txtTenKhachHang = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.txtMaKhachHang = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.btnDongBo = new DevExpress.XtraEditors.SimpleButton();
            this.griDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.xtraTabControl3.Size = new System.Drawing.Size(1069, 51);
            this.xtraTabControl3.TabIndex = 70;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.AutoScroll = true;
            this.xtraTabPage3.Controls.Add(this.txtTenKhachHang);
            this.xtraTabPage3.Controls.Add(this.btnSearch);
            this.xtraTabPage3.Controls.Add(this.txtMaKhachHang);
            this.xtraTabPage3.Controls.Add(this.btnDongBo);
            this.xtraTabPage3.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage3.Image")));
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1063, 45);
            this.xtraTabPage3.TabPageWidth = 150;
            this.xtraTabPage3.Text = "Danh sách khách hàng";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtTenKhachHang.iWidth = 110;
            this.txtTenKhachHang.Location = new System.Drawing.Point(850, 12);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.sCaption = "Tên khách hàng:";
            this.txtTenKhachHang.SelectionStart = 0;
            this.txtTenKhachHang.Size = new System.Drawing.Size(205, 21);
            this.txtTenKhachHang.TabIndex = 0;
            this.txtTenKhachHang.Tag = "..MaNhaCungCap";
            this.txtTenKhachHang.Visible = false;
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
            this.btnSearch.TabIndex = 71;
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
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtMaKhachHang.iWidth = 110;
            this.txtMaKhachHang.Location = new System.Drawing.Point(647, 12);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.sCaption = "Mã khách hàng:";
            this.txtMaKhachHang.SelectionStart = 0;
            this.txtMaKhachHang.Size = new System.Drawing.Size(195, 21);
            this.txtMaKhachHang.TabIndex = 0;
            this.txtMaKhachHang.Tag = "..MaNhaCungCap";
            this.txtMaKhachHang.Visible = false;
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
            this.btnDongBo.TabIndex = 72;
            this.btnDongBo.Tag = "ADD";
            this.btnDongBo.Text = "Đồng bộ từ Navision về";
            this.btnDongBo.Click += new System.EventHandler(this.btnDongBo_Click);
            // 
            // griDanhSach
            // 
            this.griDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.griDanhSach.Location = new System.Drawing.Point(0, 51);
            this.griDanhSach.MainView = this.gridView1;
            this.griDanhSach.Name = "griDanhSach";
            this.griDanhSach.Size = new System.Drawing.Size(1069, 552);
            this.griDanhSach.TabIndex = 71;
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
            this.MaKhachHang,
            this.TenKhachHang});
            this.gridView1.GridControl = this.griDanhSach;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyUp);
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.Caption = "Mã khách hàng";
            this.MaKhachHang.FieldName = "MaKhachHang";
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Visible = true;
            this.MaKhachHang.VisibleIndex = 0;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.Caption = "Tên khách hàng";
            this.TenKhachHang.FieldName = "TenKhachHang";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Visible = true;
            this.TenKhachHang.VisibleIndex = 1;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 603);
            this.Controls.Add(this.griDanhSach);
            this.Controls.Add(this.xtraTabControl3);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmKhachHang";
            this.Text = "DANH SÁCH KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
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
        private DELFI_User_Control.uTextBox txtTenKhachHang;
        private DELFI_User_Control.uTextBox txtMaKhachHang;
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnDongBo;
        private DevExpress.XtraGrid.GridControl griDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn TenKhachHang;
    }
}