namespace APCPOS.UserControl
{
    partial class ListProdTopSelling
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListProdTopSelling));
            this.prodpic = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblprodname = new System.Windows.Forms.Label();
            this.lbltotalsales = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prodpic)).BeginInit();
            this.SuspendLayout();
            // 
            // prodpic
            // 
            this.prodpic.AllowFocused = false;
            this.prodpic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prodpic.BorderRadius = 16;
            this.prodpic.Image = ((System.Drawing.Image)(resources.GetObject("prodpic.Image")));
            this.prodpic.IsCircle = true;
            this.prodpic.Location = new System.Drawing.Point(3, 2);
            this.prodpic.Name = "prodpic";
            this.prodpic.Size = new System.Drawing.Size(33, 33);
            this.prodpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prodpic.TabIndex = 48;
            this.prodpic.TabStop = false;
            this.prodpic.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.prodpic.MouseEnter += new System.EventHandler(this.ListProdTopSelling_MouseEnter);
            this.prodpic.MouseLeave += new System.EventHandler(this.ListProdTopSelling_MouseLeave);
            // 
            // lblprodname
            // 
            this.lblprodname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblprodname.AutoSize = true;
            this.lblprodname.BackColor = System.Drawing.Color.Transparent;
            this.lblprodname.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprodname.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblprodname.Location = new System.Drawing.Point(42, 12);
            this.lblprodname.Name = "lblprodname";
            this.lblprodname.Size = new System.Drawing.Size(178, 15);
            this.lblprodname.TabIndex = 51;
            this.lblprodname.Text = "loveyourenemy@outlook.com";
            this.lblprodname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblprodname.MouseEnter += new System.EventHandler(this.ListProdTopSelling_MouseEnter);
            this.lblprodname.MouseLeave += new System.EventHandler(this.ListProdTopSelling_MouseLeave);
            // 
            // lbltotalsales
            // 
            this.lbltotalsales.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalsales.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbltotalsales.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalsales.ForeColor = System.Drawing.Color.White;
            this.lbltotalsales.Location = new System.Drawing.Point(532, 0);
            this.lbltotalsales.Name = "lbltotalsales";
            this.lbltotalsales.Size = new System.Drawing.Size(261, 38);
            this.lbltotalsales.TabIndex = 52;
            this.lbltotalsales.Text = "loveyourenemy@outlook.com";
            this.lbltotalsales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbltotalsales.MouseEnter += new System.EventHandler(this.ListProdTopSelling_MouseEnter);
            this.lbltotalsales.MouseLeave += new System.EventHandler(this.ListProdTopSelling_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(1, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 43);
            this.panel1.TabIndex = 53;
            this.panel1.MouseEnter += new System.EventHandler(this.ListProdTopSelling_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.ListProdTopSelling_MouseLeave);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ListProdTopSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltotalsales);
            this.Controls.Add(this.lblprodname);
            this.Controls.Add(this.prodpic);
            this.Name = "ListProdTopSelling";
            this.Size = new System.Drawing.Size(793, 38);
            this.MouseEnter += new System.EventHandler(this.ListProdTopSelling_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListProdTopSelling_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.prodpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuPictureBox prodpic;
        public System.Windows.Forms.Label lblprodname;
        public System.Windows.Forms.Label lbltotalsales;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
