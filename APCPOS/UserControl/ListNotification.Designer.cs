namespace APCPOS.UserControl
{
    partial class ListNotification
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblnottitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblnotdesc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.lblnottitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 16);
            this.panel1.TabIndex = 34;
            this.panel1.MouseEnter += new System.EventHandler(this.ListNotification_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.ListNotification_MouseLeave);
            // 
            // lblnottitle
            // 
            this.lblnottitle.AutoSize = true;
            this.lblnottitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.lblnottitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblnottitle.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnottitle.ForeColor = System.Drawing.Color.Aqua;
            this.lblnottitle.Location = new System.Drawing.Point(0, 0);
            this.lblnottitle.Name = "lblnottitle";
            this.lblnottitle.Size = new System.Drawing.Size(97, 15);
            this.lblnottitle.TabIndex = 19;
            this.lblnottitle.Text = "No Data Available";
            this.lblnottitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblnottitle.MouseEnter += new System.EventHandler(this.ListNotification_MouseEnter);
            this.lblnottitle.MouseLeave += new System.EventHandler(this.ListNotification_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(-4, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 8);
            this.panel2.TabIndex = 35;
            this.panel2.MouseEnter += new System.EventHandler(this.ListNotification_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.ListNotification_MouseLeave);
            // 
            // lblnotdesc
            // 
            this.lblnotdesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.lblnotdesc.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotdesc.ForeColor = System.Drawing.Color.White;
            this.lblnotdesc.Location = new System.Drawing.Point(0, 19);
            this.lblnotdesc.Name = "lblnotdesc";
            this.lblnotdesc.Size = new System.Drawing.Size(233, 36);
            this.lblnotdesc.TabIndex = 36;
            this.lblnotdesc.Text = "No Data Available";
            this.lblnotdesc.MouseEnter += new System.EventHandler(this.ListNotification_MouseEnter);
            this.lblnotdesc.MouseLeave += new System.EventHandler(this.ListNotification_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "1h";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuImageButton2.Image = global::APCPOS.Properties.Resources.error;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(3, 54);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(18, 16);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 37;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // ListNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblnotdesc);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "ListNotification";
            this.Size = new System.Drawing.Size(233, 73);
            this.Load += new System.EventHandler(this.ListNotification_Load);
            this.MouseEnter += new System.EventHandler(this.ListNotification_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListNotification_MouseLeave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblnottitle;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblnotdesc;
        public System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}
