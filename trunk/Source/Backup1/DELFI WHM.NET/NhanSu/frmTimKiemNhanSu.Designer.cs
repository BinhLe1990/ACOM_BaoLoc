namespace DELFI_WHM.NET.NhanSu
{
    partial class frmTimKiemNhanSu
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
            this.dtg = new DELFI_WHM.NET.DELFI_User_Control.uDataGrid();
            this.uFind1 = new DELFI_WHM.NET.DELFI_User_Control.uFind();
            this.SuspendLayout();
            // 
            // dtg
            // 
            this.dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg.FocusedRowHandle = -2147483648;
            this.dtg.Location = new System.Drawing.Point(222, 0);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(695, 514);
            this.dtg.sKEY = null;
            this.dtg.TabIndex = 3;
            this.dtg.uDataSource = null;
            this.dtg.uDoubleClick += new System.EventHandler(this.dtg_uDoubleClick);
            // 
            // uFind1
            // 
            this.uFind1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uFind1.Location = new System.Drawing.Point(0, 0);
            this.uFind1.Name = "uFind1";
            this.uFind1.Size = new System.Drawing.Size(222, 514);
            this.uFind1.sKEY = "";
            this.uFind1.TabIndex = 2;
            this.uFind1.uClick += new DELFI_WHM.NET.DELFI_User_Control.uFind.EventHandler(this.uFind1_uClick);
            // 
            // frmTimKiemNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 514);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.uFind1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTimKiemNhanSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm nhân sự";
            this.ResumeLayout(false);

        }

        #endregion

        private DELFI_WHM.NET.DELFI_User_Control.uFind uFind1;
        private DELFI_WHM.NET.DELFI_User_Control.uDataGrid dtg;


    }
}