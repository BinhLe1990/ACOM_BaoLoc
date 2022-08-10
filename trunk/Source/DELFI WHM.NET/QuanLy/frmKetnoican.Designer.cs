namespace DELFI_WHM.NET.QuanLy
{
    partial class frmKetnoican
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetnoican));
            this.IML = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResultCom1 = new System.Windows.Forms.TextBox();
            this.btnBatdau = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtTrongLuongCOM = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.TextBox();
            this.txtdatabits = new System.Windows.Forms.TextBox();
            this.txtmaxspeed = new System.Windows.Forms.TextBox();
            this.txtstopbits = new System.Windows.Forms.TextBox();
            this.txtparity = new System.Windows.Forms.TextBox();
            this.txtcom1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResultCom1);
            this.groupBox2.Controls.Add(this.btnBatdau);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.txtTrongLuongCOM);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.txtdatabits);
            this.groupBox2.Controls.Add(this.txtmaxspeed);
            this.groupBox2.Controls.Add(this.txtstopbits);
            this.groupBox2.Controls.Add(this.txtparity);
            this.groupBox2.Controls.Add(this.txtcom1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1069, 603);
            this.groupBox2.TabIndex = 105;
            this.groupBox2.TabStop = false;
            // 
            // txtResultCom1
            // 
            this.txtResultCom1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultCom1.Enabled = false;
            this.txtResultCom1.Location = new System.Drawing.Point(142, 14);
            this.txtResultCom1.Multiline = true;
            this.txtResultCom1.Name = "txtResultCom1";
            this.txtResultCom1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultCom1.Size = new System.Drawing.Size(915, 583);
            this.txtResultCom1.TabIndex = 49;
            this.txtResultCom1.TextChanged += new System.EventHandler(this.txtResultCom1_TextChanged);
            // 
            // btnBatdau
            // 
            this.btnBatdau.Image = ((System.Drawing.Image)(resources.GetObject("btnBatdau.Image")));
            this.btnBatdau.ImageIndex = 1;
            this.btnBatdau.ImageList = this.IML;
            this.btnBatdau.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnBatdau.Location = new System.Drawing.Point(12, 20);
            this.btnBatdau.Name = "btnBatdau";
            this.btnBatdau.Size = new System.Drawing.Size(124, 26);
            this.btnBatdau.TabIndex = 206;
            this.btnBatdau.Tag = "ADD";
            this.btnBatdau.Text = "Bắt đầu";
            this.btnBatdau.Click += new System.EventHandler(this.btnstartcom_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 255);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 54);
            this.textBox1.TabIndex = 62;
            this.textBox1.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 228);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(130, 21);
            this.numericUpDown1.TabIndex = 61;
            this.numericUpDown1.Visible = false;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtTrongLuongCOM
            // 
            this.txtTrongLuongCOM.Location = new System.Drawing.Point(6, 315);
            this.txtTrongLuongCOM.Multiline = true;
            this.txtTrongLuongCOM.Name = "txtTrongLuongCOM";
            this.txtTrongLuongCOM.ReadOnly = true;
            this.txtTrongLuongCOM.Size = new System.Drawing.Size(130, 30);
            this.txtTrongLuongCOM.TabIndex = 60;
            this.txtTrongLuongCOM.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(6, 192);
            this.lblStatus.Multiline = true;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.ReadOnly = true;
            this.lblStatus.Size = new System.Drawing.Size(130, 30);
            this.lblStatus.TabIndex = 57;
            this.lblStatus.Visible = false;
            // 
            // txtdatabits
            // 
            this.txtdatabits.Location = new System.Drawing.Point(86, 138);
            this.txtdatabits.Name = "txtdatabits";
            this.txtdatabits.Size = new System.Drawing.Size(50, 21);
            this.txtdatabits.TabIndex = 50;
            this.txtdatabits.Text = "8";
            this.txtdatabits.Visible = false;
            // 
            // txtmaxspeed
            // 
            this.txtmaxspeed.Location = new System.Drawing.Point(86, 84);
            this.txtmaxspeed.Name = "txtmaxspeed";
            this.txtmaxspeed.Size = new System.Drawing.Size(50, 21);
            this.txtmaxspeed.TabIndex = 51;
            this.txtmaxspeed.Text = "9600";
            this.txtmaxspeed.Visible = false;
            // 
            // txtstopbits
            // 
            this.txtstopbits.Location = new System.Drawing.Point(86, 165);
            this.txtstopbits.Name = "txtstopbits";
            this.txtstopbits.Size = new System.Drawing.Size(50, 21);
            this.txtstopbits.TabIndex = 52;
            this.txtstopbits.Text = "1";
            this.txtstopbits.Visible = false;
            // 
            // txtparity
            // 
            this.txtparity.Location = new System.Drawing.Point(86, 111);
            this.txtparity.Name = "txtparity";
            this.txtparity.Size = new System.Drawing.Size(50, 21);
            this.txtparity.TabIndex = 53;
            this.txtparity.Text = "None";
            this.txtparity.Visible = false;
            // 
            // txtcom1
            // 
            this.txtcom1.Location = new System.Drawing.Point(86, 55);
            this.txtcom1.Name = "txtcom1";
            this.txtcom1.Size = new System.Drawing.Size(50, 21);
            this.txtcom1.TabIndex = 54;
            this.txtcom1.Text = "COM3";
            this.txtcom1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Stop Bits";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Parity";
            this.label3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Port";
            this.label1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Speed";
            this.label5.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Data Bits";
            this.label2.Visible = false;
            // 
            // frmKetnoican
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 603);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmKetnoican";
            this.Text = "Kết nối cân";
            this.Load += new System.EventHandler(this.frmKetnoican_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IML;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtTrongLuongCOM;
        private System.Windows.Forms.TextBox lblStatus;
        private System.Windows.Forms.TextBox txtdatabits;
        private System.Windows.Forms.TextBox txtmaxspeed;
        private System.Windows.Forms.TextBox txtstopbits;
        private System.Windows.Forms.TextBox txtparity;
        private System.Windows.Forms.TextBox txtcom1;
        private System.Windows.Forms.TextBox txtResultCom1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnBatdau;
    }
}