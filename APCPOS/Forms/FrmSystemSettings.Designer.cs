namespace APCPOS.Forms
{
    partial class FrmSystemSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSystemSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnpostransac = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btndashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.indicator = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 525);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 501);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.panel3.Controls.Add(this.bunifuImageButton2);
            this.panel3.Controls.Add(this.lbltitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 24);
            this.panel3.TabIndex = 94;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(724, 2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(24, 19);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 11;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lbltitle.Location = new System.Drawing.Point(4, 2);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(122, 19);
            this.lbltitle.TabIndex = 8;
            this.lbltitle.Text = "System settings";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnpostransac);
            this.panel9.Controls.Add(this.btndashboard);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(171, 501);
            this.panel9.TabIndex = 7;
            // 
            // btnpostransac
            // 
            this.btnpostransac.Active = false;
            this.btnpostransac.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnpostransac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnpostransac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpostransac.BorderRadius = 0;
            this.btnpostransac.ButtonText = "              Transaction";
            this.btnpostransac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpostransac.DisabledColor = System.Drawing.Color.Gray;
            this.btnpostransac.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpostransac.Iconcolor = System.Drawing.Color.Transparent;
            this.btnpostransac.Iconimage = null;
            this.btnpostransac.Iconimage_right = null;
            this.btnpostransac.Iconimage_right_Selected = null;
            this.btnpostransac.Iconimage_Selected = null;
            this.btnpostransac.IconMarginLeft = 0;
            this.btnpostransac.IconMarginRight = 0;
            this.btnpostransac.IconRightVisible = true;
            this.btnpostransac.IconRightZoom = 0D;
            this.btnpostransac.IconVisible = true;
            this.btnpostransac.IconZoom = 80D;
            this.btnpostransac.IsTab = false;
            this.btnpostransac.Location = new System.Drawing.Point(7, 53);
            this.btnpostransac.Name = "btnpostransac";
            this.btnpostransac.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnpostransac.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btnpostransac.OnHoverTextColor = System.Drawing.Color.White;
            this.btnpostransac.selected = false;
            this.btnpostransac.Size = new System.Drawing.Size(164, 53);
            this.btnpostransac.TabIndex = 25;
            this.btnpostransac.Text = "              Transaction";
            this.btnpostransac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpostransac.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnpostransac.TextFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btndashboard
            // 
            this.btndashboard.Active = true;
            this.btndashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btndashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btndashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndashboard.BorderRadius = 0;
            this.btndashboard.ButtonText = "              General";
            this.btndashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btndashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btndashboard.Iconimage = null;
            this.btndashboard.Iconimage_right = null;
            this.btndashboard.Iconimage_right_Selected = null;
            this.btndashboard.Iconimage_Selected = null;
            this.btndashboard.IconMarginLeft = 0;
            this.btndashboard.IconMarginRight = 0;
            this.btndashboard.IconRightVisible = true;
            this.btndashboard.IconRightZoom = 0D;
            this.btndashboard.IconVisible = true;
            this.btndashboard.IconZoom = 80D;
            this.btndashboard.IsTab = true;
            this.btndashboard.Location = new System.Drawing.Point(7, 0);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btndashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btndashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btndashboard.selected = true;
            this.btndashboard.Size = new System.Drawing.Size(164, 53);
            this.btndashboard.TabIndex = 20;
            this.btndashboard.Text = "              General";
            this.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btndashboard.TextFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.indicator);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(7, 501);
            this.panel10.TabIndex = 26;
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.indicator.Location = new System.Drawing.Point(2, 0);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(4, 53);
            this.indicator.TabIndex = 21;
            // 
            // FrmSystemSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(753, 527);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSystemSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSystemSettings";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        public System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel9;
        private Bunifu.Framework.UI.BunifuFlatButton btnpostransac;
        private Bunifu.Framework.UI.BunifuFlatButton btndashboard;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel indicator;
    }
}