namespace APCPOS.UserControl
{
    partial class ListUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListUsers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblid = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblfullname = new System.Windows.Forms.Label();
            this.lblstat = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblmobile = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userpic = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.popup = new Tulpep.NotificationWindow.PopupNotifier();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.approvedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temporaryBlockedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.lblid);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.lblfullname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 31);
            this.panel1.TabIndex = 46;
            // 
            // lblid
            // 
            this.lblid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.Aqua;
            this.lblid.Location = new System.Drawing.Point(157, 9);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(108, 15);
            this.lblid.TabIndex = 56;
            this.lblid.Text = "No Data Available";
            this.lblid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblid.Visible = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(260, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 31);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 33;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // lblfullname
            // 
            this.lblfullname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblfullname.AutoSize = true;
            this.lblfullname.BackColor = System.Drawing.Color.Transparent;
            this.lblfullname.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.lblfullname.Location = new System.Drawing.Point(3, 9);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(108, 15);
            this.lblfullname.TabIndex = 19;
            this.lblfullname.Text = "No Data Available";
            this.lblfullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblstat
            // 
            this.lblstat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblstat.AutoSize = true;
            this.lblstat.BackColor = System.Drawing.Color.Transparent;
            this.lblstat.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.lblstat.Location = new System.Drawing.Point(104, 130);
            this.lblstat.Name = "lblstat";
            this.lblstat.Size = new System.Drawing.Size(108, 15);
            this.lblstat.TabIndex = 54;
            this.lblstat.Text = "No Data Available";
            this.lblstat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblemail
            // 
            this.lblemail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.White;
            this.lblemail.Location = new System.Drawing.Point(101, 107);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(178, 15);
            this.lblemail.TabIndex = 50;
            this.lblemail.Text = "loveyourenemy@outlook.com";
            // 
            // lblmobile
            // 
            this.lblmobile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblmobile.AutoSize = true;
            this.lblmobile.BackColor = System.Drawing.Color.Transparent;
            this.lblmobile.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmobile.ForeColor = System.Drawing.Color.White;
            this.lblmobile.Location = new System.Drawing.Point(101, 85);
            this.lblmobile.Name = "lblmobile";
            this.lblmobile.Size = new System.Drawing.Size(90, 15);
            this.lblmobile.TabIndex = 49;
            this.lblmobile.Text = "(339)-9484-44";
            // 
            // lbladd
            // 
            this.lbladd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbladd.BackColor = System.Drawing.Color.Transparent;
            this.lbladd.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladd.ForeColor = System.Drawing.Color.White;
            this.lbladd.Location = new System.Drawing.Point(104, 37);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(178, 44);
            this.lbladd.TabIndex = 48;
            this.lbladd.Text = "Prk. Caimito Brgy. Datu abdul dadia panabo city 8105";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(81, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(81, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // userpic
            // 
            this.userpic.AllowFocused = false;
            this.userpic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userpic.BorderRadius = 36;
            this.userpic.Image = ((System.Drawing.Image)(resources.GetObject("userpic.Image")));
            this.userpic.IsCircle = true;
            this.userpic.Location = new System.Drawing.Point(3, 37);
            this.userpic.Name = "userpic";
            this.userpic.Size = new System.Drawing.Size(72, 72);
            this.userpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userpic.TabIndex = 47;
            this.userpic.TabStop = false;
            this.userpic.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
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
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(81, 129);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 55;
            this.pictureBox4.TabStop = false;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.actionsToolStripMenuItem1});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(137, 48);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.actionsToolStripMenuItem.Text = "View Profile";
            // 
            // actionsToolStripMenuItem1
            // 
            this.actionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.approvedToolStripMenuItem,
            this.blockedToolStripMenuItem,
            this.temporaryBlockedToolStripMenuItem});
            this.actionsToolStripMenuItem1.Name = "actionsToolStripMenuItem1";
            this.actionsToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.actionsToolStripMenuItem1.Text = "Actions";
            // 
            // approvedToolStripMenuItem
            // 
            this.approvedToolStripMenuItem.CheckOnClick = true;
            this.approvedToolStripMenuItem.Name = "approvedToolStripMenuItem";
            this.approvedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.approvedToolStripMenuItem.Text = "Approved";
            this.approvedToolStripMenuItem.Click += new System.EventHandler(this.approvedToolStripMenuItem_Click);
            // 
            // blockedToolStripMenuItem
            // 
            this.blockedToolStripMenuItem.CheckOnClick = true;
            this.blockedToolStripMenuItem.Name = "blockedToolStripMenuItem";
            this.blockedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blockedToolStripMenuItem.Text = "Blocked";
            this.blockedToolStripMenuItem.Click += new System.EventHandler(this.blockedToolStripMenuItem_Click);
            // 
            // temporaryBlockedToolStripMenuItem
            // 
            this.temporaryBlockedToolStripMenuItem.CheckOnClick = true;
            this.temporaryBlockedToolStripMenuItem.Name = "temporaryBlockedToolStripMenuItem";
            this.temporaryBlockedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.temporaryBlockedToolStripMenuItem.Text = "Temporary Blocked";
            this.temporaryBlockedToolStripMenuItem.Click += new System.EventHandler(this.temporaryBlockedToolStripMenuItem_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblstat);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblmobile);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.userpic);
            this.Name = "ListUsers";
            this.Size = new System.Drawing.Size(288, 154);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblfullname;
        public System.Windows.Forms.Label lblstat;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblemail;
        public System.Windows.Forms.Label lblmobile;
        public System.Windows.Forms.Label lbladd;
        public Bunifu.UI.WinForms.BunifuPictureBox userpic;
        private Tulpep.NotificationWindow.PopupNotifier popup;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem1;
        public System.Windows.Forms.Label lblid;
        public System.Windows.Forms.ToolStripMenuItem approvedToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem blockedToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem temporaryBlockedToolStripMenuItem;
    }
}
