namespace APCPOS.Forms
{
    partial class FrmNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotification));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton9 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblnotcount = new System.Windows.Forms.Label();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(257, 549);
            this.flowLayoutPanel1.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.flowLayoutPanel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.flowLayoutPanel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.flowLayoutPanel1, "");
            this.flowLayoutPanel1.Leave += new System.EventHandler(this.flowLayoutPanel1_Leave);
            this.flowLayoutPanel1.MouseLeave += new System.EventHandler(this.flowLayoutPanel1_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.bunifuImageButton9);
            this.panel1.Controls.Add(this.lblnotcount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 21);
            this.panel1.TabIndex = 35;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            // 
            // bunifuImageButton9
            // 
            this.bunifuImageButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton9.Image")));
            this.bunifuImageButton9.ImageActive = null;
            this.bunifuImageButton9.Location = new System.Drawing.Point(235, 1);
            this.bunifuImageButton9.Name = "bunifuImageButton9";
            this.bunifuImageButton9.Size = new System.Drawing.Size(19, 20);
            this.bunifuImageButton9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton9.TabIndex = 20;
            this.bunifuImageButton9.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton9, "Dismiss all");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton9, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton9, "");
            this.bunifuImageButton9.Zoom = 10;
            this.bunifuImageButton9.Click += new System.EventHandler(this.bunifuImageButton9_Click);
            // 
            // lblnotcount
            // 
            this.lblnotcount.AutoSize = true;
            this.lblnotcount.BackColor = System.Drawing.Color.Transparent;
            this.lblnotcount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblnotcount.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotcount.ForeColor = System.Drawing.Color.White;
            this.lblnotcount.Location = new System.Drawing.Point(0, 0);
            this.lblnotcount.Name = "lblnotcount";
            this.lblnotcount.Size = new System.Drawing.Size(97, 15);
            this.lblnotcount.TabIndex = 19;
            this.lblnotcount.Text = "No Data Available";
            this.lblnotcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.lblnotcount, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblnotcount, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblnotcount, "");
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // FrmNotification
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(257, 570);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmNotification";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmNotification";
            this.Deactivate += new System.EventHandler(this.FrmNotification_Deactivate);
            this.Load += new System.EventHandler(this.FrmNotification_Load);
            this.Leave += new System.EventHandler(this.FrmNotification_Leave);
            this.MouseEnter += new System.EventHandler(this.FrmNotification_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FrmNotification_MouseLeave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblnotcount;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton9;
    }
}