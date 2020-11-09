using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;

namespace APCPOS.UserControl
{
    partial class ListStock
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListStock));
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblprodname = new System.Windows.Forms.Label();
            this.lblstock = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.bunifuImageButton9 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 35;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(49, 18);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(70, 70);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuPictureBox1.TabIndex = 1;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuPictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuPictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuPictureBox1, "");
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox1.MouseEnter += new System.EventHandler(this.ListStock_MouseEnter);
            this.bunifuPictureBox1.MouseLeave += new System.EventHandler(this.ListStock_MouseLeave);
            // 
            // lblprodname
            // 
            this.lblprodname.BackColor = System.Drawing.Color.Transparent;
            this.lblprodname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblprodname.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprodname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.lblprodname.Location = new System.Drawing.Point(0, 99);
            this.lblprodname.Name = "lblprodname";
            this.lblprodname.Size = new System.Drawing.Size(173, 18);
            this.lblprodname.TabIndex = 36;
            this.lblprodname.Text = "No Data Available";
            this.lblprodname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.lblprodname, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblprodname, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblprodname, "");
            this.lblprodname.MouseEnter += new System.EventHandler(this.ListStock_MouseEnter);
            this.lblprodname.MouseLeave += new System.EventHandler(this.ListStock_MouseLeave);
            // 
            // lblstock
            // 
            this.lblstock.BackColor = System.Drawing.Color.Transparent;
            this.lblstock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblstock.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstock.ForeColor = System.Drawing.Color.Snow;
            this.lblstock.Location = new System.Drawing.Point(0, 117);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(173, 35);
            this.lblstock.TabIndex = 39;
            this.lblstock.Text = "ID #:";
            this.lblstock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.lblstock, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblstock, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblstock, "");
            this.lblstock.MouseEnter += new System.EventHandler(this.ListStock_MouseEnter);
            this.lblstock.MouseLeave += new System.EventHandler(this.ListStock_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(224)))), ((int)(((byte)(221)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "0";
            this.bunifuToolTip1.SetToolTip(this.label6, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label6, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label6, "");
            this.label6.MouseEnter += new System.EventHandler(this.ListStock_MouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.ListStock_MouseLeave);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(149)))));
            this.lblID.Location = new System.Drawing.Point(3, 70);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(39, 18);
            this.lblID.TabIndex = 41;
            this.lblID.Text = "ID #:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.lblID, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblID, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblID, "");
            this.lblID.Visible = false;
            this.lblID.MouseEnter += new System.EventHandler(this.ListStock_MouseEnter);
            this.lblID.MouseLeave += new System.EventHandler(this.ListStock_MouseLeave);
            // 
            // bunifuImageButton9
            // 
            this.bunifuImageButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton9.Image")));
            this.bunifuImageButton9.ImageActive = null;
            this.bunifuImageButton9.Location = new System.Drawing.Point(134, -1);
            this.bunifuImageButton9.Name = "bunifuImageButton9";
            this.bunifuImageButton9.Size = new System.Drawing.Size(40, 32);
            this.bunifuImageButton9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton9.TabIndex = 42;
            this.bunifuImageButton9.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton9, "Adjust stock");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton9, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton9, "");
            this.bunifuImageButton9.Zoom = 10;
            this.bunifuImageButton9.Click += new System.EventHandler(this.bunifuImageButton9_Click);
            this.bunifuImageButton9.MouseEnter += new System.EventHandler(this.ListStock_MouseEnter);
            this.bunifuImageButton9.MouseLeave += new System.EventHandler(this.ListStock_MouseLeave);
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
            // ListStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.bunifuImageButton9);
            this.Controls.Add(this.lblprodname);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblstock);
            this.Controls.Add(this.bunifuPictureBox1);
            this.DoubleBuffered = true;
            this.Name = "ListStock";
            this.Size = new System.Drawing.Size(173, 152);
            this.bunifuToolTip1.SetToolTip(this, "");
            this.bunifuToolTip1.SetToolTipIcon(this, null);
            this.bunifuToolTip1.SetToolTipTitle(this, "");
            this.Load += new System.EventHandler(this.ListStock_Load);
            this.MouseEnter += new System.EventHandler(this.ListStock_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListStock_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public BunifuPictureBox bunifuPictureBox1;
        public Label lblprodname;
        public Label lblstock;
        public Label lblID;
        public Label label6;
        private BunifuImageButton bunifuImageButton9;
        private BunifuToolTip bunifuToolTip1;
    }
}
