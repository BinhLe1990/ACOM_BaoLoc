namespace DELFI_WHM.NET.CauHinh
{
    partial class frmCauHinhPackingUnits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCauHinhPackingUnits));
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.spnTrongLuongBao = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.cboLoai = new DELFI_WHM.NET.DELFI_User_Control.uComboBox();
            this.txtDienGiai = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.txtCode = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.spnTrongLuongBi = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.spnID = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.spnSoBao = new DELFI_WHM.NET.DELFI_User_Control.uSpinEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.griDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Loai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrongLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThemmoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
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
            // btnLuu
            // 
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageIndex = 6;
            this.btnLuu.ImageList = this.IML;
            this.btnLuu.Location = new System.Drawing.Point(108, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 26);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Tag = "ADD";
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // spnTrongLuongBao
            // 
            this.spnTrongLuongBao.bUseMask = true;
            this.spnTrongLuongBao.Location = new System.Drawing.Point(351, 50);
            this.spnTrongLuongBao.Name = "spnTrongLuongBao";
            this.spnTrongLuongBao.sCaption = "Trọng lượng bao:";
            this.spnTrongLuongBao.sEditMask = "N0";
            this.spnTrongLuongBao.Size = new System.Drawing.Size(254, 21);
            this.spnTrongLuongBao.TabIndex = 5;
            this.spnTrongLuongBao.Tag = "..Format";
            this.spnTrongLuongBao.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTrongLuongBao.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnTrongLuongBao.uMaxValue = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spnTrongLuongBao.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTrongLuongBao.uText = "0";
            this.spnTrongLuongBao.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // cboLoai
            // 
            this.cboLoai.Location = new System.Drawing.Point(12, 24);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.sCaption = "Loại bao (*):";
            this.cboLoai.sColumnCaption = "Loại bao";
            this.cboLoai.sField = "Loai";
            this.cboLoai.Size = new System.Drawing.Size(333, 21);
            this.cboLoai.TabIndex = 1;
            this.cboLoai.Tag = "..PackageType";
            this.cboLoai.uDisplayMember = "Loai";
            this.cboLoai.uEditValue = "";
            this.cboLoai.uTableName = "DM_LoaiBao";
            this.cboLoai.uValueMember = "Loai";
            this.cboLoai.uQueryPopUp += new System.ComponentModel.CancelEventHandler(this.cboLoai_uQueryPopUp);
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtDienGiai.Location = new System.Drawing.Point(12, 76);
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.sCaption = "Diễn giải:";
            this.txtDienGiai.SelectionStart = 0;
            this.txtDienGiai.Size = new System.Drawing.Size(333, 20);
            this.txtDienGiai.TabIndex = 3;
            this.txtDienGiai.Tag = "..PackageDesc";
            // 
            // txtCode
            // 
            this.txtCode.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txtCode.Location = new System.Drawing.Point(12, 51);
            this.txtCode.Name = "txtCode";
            this.txtCode.sCaption = "Code (*):";
            this.txtCode.SelectionStart = 0;
            this.txtCode.Size = new System.Drawing.Size(333, 20);
            this.txtCode.TabIndex = 2;
            this.txtCode.Tag = "..PackageCode";
            // 
            // spnTrongLuongBi
            // 
            this.spnTrongLuongBi.Location = new System.Drawing.Point(351, 24);
            this.spnTrongLuongBi.Name = "spnTrongLuongBi";
            this.spnTrongLuongBi.sCaption = "Trọng lượng bì:";
            this.spnTrongLuongBi.Size = new System.Drawing.Size(254, 21);
            this.spnTrongLuongBi.TabIndex = 4;
            this.spnTrongLuongBi.Tag = "..PackageQty";
            this.spnTrongLuongBi.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTrongLuongBi.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnTrongLuongBi.uMaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spnTrongLuongBi.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTrongLuongBi.uText = "0";
            this.spnTrongLuongBi.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // groupControl
            // 
            this.groupControl.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.groupControl.AppearanceCaption.Options.UseFont = true;
            this.groupControl.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl.Controls.Add(this.spnID);
            this.groupControl.Controls.Add(this.cboLoai);
            this.groupControl.Controls.Add(this.spnSoBao);
            this.groupControl.Controls.Add(this.txtCode);
            this.groupControl.Controls.Add(this.txtDienGiai);
            this.groupControl.Controls.Add(this.spnTrongLuongBi);
            this.groupControl.Controls.Add(this.spnTrongLuongBao);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl.Location = new System.Drawing.Point(0, 0);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(1069, 106);
            this.groupControl.TabIndex = 60;
            this.groupControl.TabStop = true;
            this.groupControl.Text = "Thông tin";
            // 
            // spnID
            // 
            this.spnID.Appearance.ForeColor = System.Drawing.Color.Black;
            this.spnID.Appearance.Options.UseForeColor = true;
            this.spnID.Location = new System.Drawing.Point(611, 51);
            this.spnID.LookAndFeel.SkinName = "Office 2010 Blue";
            this.spnID.LookAndFeel.UseDefaultLookAndFeel = false;
            this.spnID.Name = "spnID";
            this.spnID.sCaption = "ID";
            this.spnID.Size = new System.Drawing.Size(263, 21);
            this.spnID.TabIndex = 7;
            this.spnID.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnID.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnID.uMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnID.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnID.uText = "0";
            this.spnID.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnID.Visible = false;
            // 
            // spnSoBao
            // 
            this.spnSoBao.Location = new System.Drawing.Point(351, 77);
            this.spnSoBao.Name = "spnSoBao";
            this.spnSoBao.sCaption = "Số bao mặc định:";
            this.spnSoBao.Size = new System.Drawing.Size(254, 21);
            this.spnSoBao.TabIndex = 6;
            this.spnSoBao.Tag = "..SoBao";
            this.spnSoBao.uEditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnSoBao.uMaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spnSoBao.uMaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spnSoBao.uMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnSoBao.uText = "0";
            this.spnSoBao.uValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThemmoi);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 106);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1069, 39);
            this.panelControl1.TabIndex = 68;
            this.panelControl1.TabStop = true;
            // 
            // griDanhSach
            // 
            this.griDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.griDanhSach.Location = new System.Drawing.Point(0, 145);
            this.griDanhSach.MainView = this.gridView;
            this.griDanhSach.Name = "griDanhSach";
            this.griDanhSach.Size = new System.Drawing.Size(1069, 497);
            this.griDanhSach.TabIndex = 69;
            this.griDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.Row.Options.UseForeColor = true;
            this.gridView.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Loai,
            this.Code,
            this.DienGiai,
            this.TrongLuong,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView.GridControl = this.griDanhSach;
            this.gridView.IndicatorWidth = 50;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_CustomDrawRowIndicator);
            this.gridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView_KeyUp);
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // Loai
            // 
            this.Loai.Caption = "Loại";
            this.Loai.FieldName = "PackageType";
            this.Loai.Name = "Loai";
            this.Loai.Visible = true;
            this.Loai.VisibleIndex = 0;
            this.Loai.Width = 141;
            // 
            // Code
            // 
            this.Code.Caption = "Code";
            this.Code.FieldName = "PackageCode";
            this.Code.Name = "Code";
            this.Code.Visible = true;
            this.Code.VisibleIndex = 1;
            this.Code.Width = 113;
            // 
            // DienGiai
            // 
            this.DienGiai.Caption = "Diễn giải";
            this.DienGiai.FieldName = "PackageDesc";
            this.DienGiai.Name = "DienGiai";
            this.DienGiai.Visible = true;
            this.DienGiai.VisibleIndex = 2;
            this.DienGiai.Width = 198;
            // 
            // TrongLuong
            // 
            this.TrongLuong.Caption = "Trọng lượng bì";
            this.TrongLuong.FieldName = "TLTruBi";
            this.TrongLuong.Name = "TrongLuong";
            this.TrongLuong.Visible = true;
            this.TrongLuong.VisibleIndex = 3;
            this.TrongLuong.Width = 108;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Trọng lượng bao";
            this.gridColumn1.DisplayFormat.FormatString = "N0";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "TLBao";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 106;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số bao";
            this.gridColumn2.FieldName = "SoBao";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 77;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ID";
            this.gridColumn3.FieldName = "ID";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnThemmoi.Appearance.Options.UseForeColor = true;
            this.btnThemmoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemmoi.Image")));
            this.btnThemmoi.ImageIndex = 6;
            this.btnThemmoi.ImageList = this.IML;
            this.btnThemmoi.Location = new System.Drawing.Point(12, 6);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(90, 26);
            this.btnThemmoi.TabIndex = 8;
            this.btnThemmoi.Tag = "ADD";
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // frmCauHinhPackingUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 642);
            this.Controls.Add(this.griDanhSach);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmCauHinhPackingUnits";
            this.Text = "CẤU HÌNH PACKING UNITS";
            this.Load += new System.EventHandler(this.frmCauHinhPackingUnits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.griDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IML;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DELFI_User_Control.uTextBox txtDienGiai;
        private DELFI_User_Control.uTextBox txtCode;
        private DELFI_User_Control.uSpinEdit spnTrongLuongBi;
        private DELFI_User_Control.uComboBox cboLoai;
        private DELFI_User_Control.uSpinEdit spnTrongLuongBao;
        private DevExpress.XtraEditors.GroupControl groupControl;
        private DELFI_User_Control.uSpinEdit spnSoBao;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl griDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn Loai;
        private DevExpress.XtraGrid.Columns.GridColumn Code;
        private DevExpress.XtraGrid.Columns.GridColumn DienGiai;
        private DevExpress.XtraGrid.Columns.GridColumn TrongLuong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DELFI_User_Control.uSpinEdit spnID;
        private DevExpress.XtraEditors.SimpleButton btnThemmoi;
    }
}