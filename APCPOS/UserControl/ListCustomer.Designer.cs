using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace APCPOS.UserControl
{
    partial class ListCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton9 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblfullname = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblid = new System.Windows.Forms.Label();
            this.popup = new Tulpep.NotificationWindow.PopupNotifier();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.bunifuImageButton9);
            this.panel1.Controls.Add(this.lblfullname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 31);
            this.panel1.TabIndex = 34;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            this.panel1.MouseEnter += new System.EventHandler(this.ListCustomer_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.ListCustomer_MouseLeave);
            // 
            // bunifuImageButton9
            // 
            this.bunifuImageButton9.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton9.Image")));
            this.bunifuImageButton9.ImageActive = null;
            this.bunifuImageButton9.Location = new System.Drawing.Point(230, 0);
            this.bunifuImageButton9.Name = "bunifuImageButton9";
            this.bunifuImageButton9.Size = new System.Drawing.Size(36, 31);
            this.bunifuImageButton9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton9.TabIndex = 44;
            this.bunifuImageButton9.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton9, "Load this consumer");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton9, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton9, "");
            this.bunifuImageButton9.Zoom = 10;
            this.bunifuImageButton9.Click += new System.EventHandler(this.bunifuImageButton9_Click);
            // 
            // lblfullname
            // 
            this.lblfullname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblfullname.AutoSize = true;
            this.lblfullname.BackColor = System.Drawing.Color.Transparent;
            this.lblfullname.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.lblfullname.Location = new System.Drawing.Point(2, 7);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(108, 15);
            this.lblfullname.TabIndex = 19;
            this.lblfullname.Text = "No Data Available";
            this.lblfullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.lblfullname, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblfullname, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblfullname, "");
            this.lblfullname.MouseEnter += new System.EventHandler(this.ListCustomer_MouseEnter);
            this.lblfullname.MouseLeave += new System.EventHandler(this.ListCustomer_MouseLeave);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 36;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(8, 43);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(72, 72);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 35;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuPictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuPictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuPictureBox1, "");
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox1.MouseEnter += new System.EventHandler(this.ListCustomer_MouseEnter);
            this.bunifuPictureBox1.MouseLeave += new System.EventHandler(this.ListCustomer_MouseLeave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 44);
            this.label2.TabIndex = 36;
            this.label2.Text = "Prk. Caimito Brgy. Datu abdul dadia panabo city 8105";
            this.bunifuToolTip1.SetToolTip(this.label2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label2, "");
            this.label2.MouseEnter += new System.EventHandler(this.ListCustomer_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.ListCustomer_MouseLeave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(86, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "(339)-9484-44";
            this.bunifuToolTip1.SetToolTip(this.label3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label3, "");
            this.label3.MouseEnter += new System.EventHandler(this.ListCustomer_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.ListCustomer_MouseLeave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "loveyourenemy@outlook.com";
            this.bunifuToolTip1.SetToolTip(this.label5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label5, "");
            this.label5.MouseEnter += new System.EventHandler(this.ListCustomer_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.ListCustomer_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox1, "");
            this.pictureBox1.MouseEnter += new System.EventHandler(this.ListCustomer_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.ListCustomer_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox2, "");
            this.pictureBox2.MouseEnter += new System.EventHandler(this.ListCustomer_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.ListCustomer_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(86, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox3, "");
            this.pictureBox3.MouseEnter += new System.EventHandler(this.ListCustomer_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.ListCustomer_MouseLeave);
            // 
            // lblid
            // 
            this.lblid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.lblid.Location = new System.Drawing.Point(173, 129);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(108, 15);
            this.lblid.TabIndex = 45;
            this.lblid.Text = "No Data Available";
            this.lblid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.lblid, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblid, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblid, "");
            this.lblid.Visible = false;
            // 
            // popup
            // 
            this.popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            this.popup.ContentHoverColor = System.Drawing.SystemColors.ControlText;
            this.popup.ContentText = null;
            this.popup.Image = ((System.Drawing.Image)(resources.GetObject("popup.Image")));
            this.popup.IsRightToLeft = false;
            this.popup.OptionsMenu = null;
            this.popup.Size = new System.Drawing.Size(400, 100);
            this.popup.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.popup.TitleText = null;
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
            // ListCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "ListCustomer";
            this.Size = new System.Drawing.Size(266, 168);
            this.bunifuToolTip1.SetToolTip(this, "");
            this.bunifuToolTip1.SetToolTipIcon(this, null);
            this.bunifuToolTip1.SetToolTipTitle(this, "");
            this.Load += new System.EventHandler(this.ListCustomer_Load);
            this.MouseEnter += new System.EventHandler(this.ListCustomer_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListCustomer_MouseLeave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        public Label lblfullname;
        public Label label2;
        public Label label3;
        public Label label5;
        public BunifuPictureBox bunifuPictureBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton9;
        public Label lblid;
        private Tulpep.NotificationWindow.PopupNotifier popup;
        private BunifuToolTip bunifuToolTip1;
    }
}
