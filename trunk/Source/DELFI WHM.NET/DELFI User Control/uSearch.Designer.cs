namespace DELFI_WHM.NET.DELFI_User_Control
{
    partial class uSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn = new DevExpress.XtraEditors.SimpleButton();
            this.txt = new DELFI_WHM.NET.DELFI_User_Control.uTextBox();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn.Location = new System.Drawing.Point(250, 0);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(30, 21);
            this.btn.TabIndex = 2;
            this.btn.Text = "...";
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txt
            // 
            this.txt.bAllowNull = DevExpress.Utils.DefaultBoolean.Default;
            this.txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt.Location = new System.Drawing.Point(0, 0);
            this.txt.Name = "txt";
            this.txt.SelectionStart = 0;
            this.txt.Size = new System.Drawing.Size(250, 21);
            this.txt.TabIndex = 3;
            // 
            // uSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btn);
            this.Name = "uSearch";
            this.Size = new System.Drawing.Size(280, 21);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btn;
        public uTextBox txt;
    }
}
