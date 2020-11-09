using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuTextbox;
using MetroFramework.Controls;

namespace APCPOS.Forms
{
    partial class FrmPOSTransaction
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPOSTransaction));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuImageButton9 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
            this.networkimg = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel24 = new System.Windows.Forms.Panel();
            this.bunifuImageButton10 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.userpic = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lbldesignation = new System.Windows.Forms.Label();
            this.lblfullname = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panelaction = new System.Windows.Forms.Panel();
            this.metroTile10 = new MetroFramework.Controls.MetroTile();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.panelorder = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.panelvatsettings = new System.Windows.Forms.Panel();
            this.bunifuDropdown2 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label26 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuiOSSwitch5 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label24 = new System.Windows.Forms.Label();
            this.bunifuiOSSwitch4 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label23 = new System.Windows.Forms.Label();
            this.bunifuiOSSwitch3 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label22 = new System.Windows.Forms.Label();
            this.bunifuiOSSwitch2 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label19 = new System.Windows.Forms.Label();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panelcustomer = new System.Windows.Forms.Panel();
            this.metroTile18 = new MetroFramework.Controls.MetroTile();
            this.metroTile17 = new MetroFramework.Controls.MetroTile();
            this.metroTile15 = new MetroFramework.Controls.MetroTile();
            this.metroTile14 = new MetroFramework.Controls.MetroTile();
            this.metroTile16 = new MetroFramework.Controls.MetroTile();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btncustomers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btndiscounts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnorder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnaction = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.indicator = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.metroTile13 = new MetroFramework.Controls.MetroTile();
            this.metroTile12 = new MetroFramework.Controls.MetroTile();
            this.metroTile11 = new MetroFramework.Controls.MetroTile();
            this.metroTile9 = new MetroFramework.Controls.MetroTile();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.linediscounts = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.lblline = new System.Windows.Forms.Label();
            this.lblinvoice = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.total_vat = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.VAT = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.subtotal = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.amntdue = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.flowpaneldebt = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowpanelcart = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.flowpanelcustomer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowpanelproducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.flowpanelproductsearch = new System.Windows.Forms.FlowLayoutPanel();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.popup = new Tulpep.NotificationWindow.PopupNotifier();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::APCPOS.Forms.WaitForm1), false, true);
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkimg)).BeginInit();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panelaction.SuspendLayout();
            this.panelorder.SuspendLayout();
            this.panelvatsettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panelcustomer.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flowpaneldebt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowpanelcart)).BeginInit();
            this.panel2.SuspendLayout();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.panel23);
            this.panel1.Controls.Add(this.bunifuImageButton9);
            this.panel1.Controls.Add(this.lbltitle);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.bunifuTransition1.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1705, 60);
            this.panel1.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.bunifuImageButton1);
            this.panel23.Controls.Add(this.bunifuTextBox1);
            this.bunifuTransition1.SetDecoration(this.panel23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel23.Location = new System.Drawing.Point(531, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(526, 60);
            this.panel23.TabIndex = 14;
            this.bunifuToolTip1.SetToolTip(this.panel23, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel23, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel23, "");
            // 
            // bunifuImageButton1
            // 
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(471, 10);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(49, 42);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 13;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton1, "Refresh [F5]");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton1, "");
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuTextBox1_OnIconRightClick);
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox1.BorderRadius = 5;
            this.bunifuTextBox1.BorderThickness = 6;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTransition1.SetDecoration(this.bunifuTextBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuTextBox1.ForeColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = global::APCPOS.Properties.Resources.search;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTextBox1.Location = new System.Drawing.Point(1, 12);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(465, 42);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.bunifuTextBox1.TabIndex = 0;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginLeft = 5;
            this.bunifuTextBox1.TextPlaceholder = "Type your query here and press \"Enter\"";
            this.bunifuToolTip1.SetToolTip(this.bunifuTextBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuTextBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuTextBox1, "");
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.TextChange += new System.EventHandler(this.bunifuTextBox1_TextChange);
            this.bunifuTextBox1.OnIconRightClick += new System.EventHandler(this.bunifuTextBox1_OnIconRightClick);
            this.bunifuTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuTextBox1_KeyDown);
            this.bunifuTextBox1.Enter += new System.EventHandler(this.bunifuTextBox1_Enter);
            this.bunifuTextBox1.Leave += new System.EventHandler(this.bunifuTextBox1_Leave);
            // 
            // bunifuImageButton9
            // 
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton9.Image")));
            this.bunifuImageButton9.ImageActive = null;
            this.bunifuImageButton9.Location = new System.Drawing.Point(12, 10);
            this.bunifuImageButton9.Name = "bunifuImageButton9";
            this.bunifuImageButton9.Size = new System.Drawing.Size(44, 42);
            this.bunifuImageButton9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton9.TabIndex = 12;
            this.bunifuImageButton9.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton9, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton9, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton9, "");
            this.bunifuImageButton9.Zoom = 10;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbltitle, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbltitle.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lbltitle.Location = new System.Drawing.Point(62, 20);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(268, 25);
            this.lbltitle.TabIndex = 8;
            this.lbltitle.Text = "POS Transaction(Products)";
            this.bunifuToolTip1.SetToolTip(this.lbltitle, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbltitle, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbltitle, "");
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.bunifuSeparator5);
            this.panel6.Controls.Add(this.lbltime);
            this.panel6.Controls.Add(this.lbldate);
            this.bunifuTransition1.SetDecoration(this.panel6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1057, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(221, 60);
            this.panel6.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.panel6, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel6, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel6, "");
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator5.LineThickness = 1;
            this.bunifuSeparator5.Location = new System.Drawing.Point(-1, 7);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(8, 46);
            this.bunifuSeparator5.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator5, "");
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = true;
            // 
            // lbltime
            // 
            this.bunifuTransition1.SetDecoration(this.lbltime, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbltime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltime.Font = new System.Drawing.Font("Roboto Bk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.Snow;
            this.lbltime.Location = new System.Drawing.Point(0, 26);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(221, 19);
            this.lbltime.TabIndex = 14;
            this.lbltime.Text = "Administrator";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.lbltime, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbltime, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbltime, "");
            // 
            // lbldate
            // 
            this.bunifuTransition1.SetDecoration(this.lbldate, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbldate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbldate.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.DimGray;
            this.lbldate.Location = new System.Drawing.Point(0, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(221, 26);
            this.lbldate.TabIndex = 13;
            this.lbldate.Text = "Administrator";
            this.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.lbldate, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbldate, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbldate, "");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bunifuSeparator6);
            this.panel4.Controls.Add(this.networkimg);
            this.panel4.Controls.Add(this.panel24);
            this.panel4.Controls.Add(this.bunifuSeparator4);
            this.panel4.Controls.Add(this.userpic);
            this.panel4.Controls.Add(this.lbldesignation);
            this.panel4.Controls.Add(this.lblfullname);
            this.bunifuTransition1.SetDecoration(this.panel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1278, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(427, 60);
            this.panel4.TabIndex = 13;
            this.bunifuToolTip1.SetToolTip(this.panel4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel4, "");
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator6.LineThickness = 1;
            this.bunifuSeparator6.Location = new System.Drawing.Point(3, 8);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Size = new System.Drawing.Size(8, 46);
            this.bunifuSeparator6.TabIndex = 22;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator6, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator6, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator6, "");
            this.bunifuSeparator6.Transparency = 255;
            this.bunifuSeparator6.Vertical = true;
            // 
            // networkimg
            // 
            this.bunifuTransition1.SetDecoration(this.networkimg, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.networkimg.Image = ((System.Drawing.Image)(resources.GetObject("networkimg.Image")));
            this.networkimg.ImageActive = null;
            this.networkimg.Location = new System.Drawing.Point(16, 8);
            this.networkimg.Name = "networkimg";
            this.networkimg.Size = new System.Drawing.Size(49, 47);
            this.networkimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.networkimg.TabIndex = 21;
            this.networkimg.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.networkimg, "Server status");
            this.bunifuToolTip1.SetToolTipIcon(this.networkimg, null);
            this.bunifuToolTip1.SetToolTipTitle(this.networkimg, "");
            this.networkimg.Zoom = 10;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.bunifuImageButton10);
            this.bunifuTransition1.SetDecoration(this.panel24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel24.Location = new System.Drawing.Point(400, 0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(27, 60);
            this.panel24.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.panel24, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel24, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel24, "");
            // 
            // bunifuImageButton10
            // 
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton10.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton10.Image")));
            this.bunifuImageButton10.ImageActive = null;
            this.bunifuImageButton10.Location = new System.Drawing.Point(3, 16);
            this.bunifuImageButton10.Name = "bunifuImageButton10";
            this.bunifuImageButton10.Size = new System.Drawing.Size(20, 23);
            this.bunifuImageButton10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton10.TabIndex = 13;
            this.bunifuImageButton10.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton10, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton10, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton10, "");
            this.bunifuImageButton10.Zoom = 10;
            this.bunifuImageButton10.Click += new System.EventHandler(this.bunifuImageButton10_Click);
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(71, 8);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(8, 46);
            this.bunifuSeparator4.TabIndex = 14;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator4, "");
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = true;
            // 
            // userpic
            // 
            this.userpic.AllowFocused = false;
            this.userpic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userpic.BorderRadius = 27;
            this.bunifuTransition1.SetDecoration(this.userpic, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.userpic.Image = ((System.Drawing.Image)(resources.GetObject("userpic.Image")));
            this.userpic.IsCircle = true;
            this.userpic.Location = new System.Drawing.Point(339, 5);
            this.userpic.Name = "userpic";
            this.userpic.Size = new System.Drawing.Size(55, 55);
            this.userpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userpic.TabIndex = 10;
            this.userpic.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.userpic, "");
            this.bunifuToolTip1.SetToolTipIcon(this.userpic, null);
            this.bunifuToolTip1.SetToolTipTitle(this.userpic, "");
            this.userpic.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.userpic.Click += new System.EventHandler(this.userpic_Click);
            // 
            // lbldesignation
            // 
            this.lbldesignation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuTransition1.SetDecoration(this.lbldesignation, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbldesignation.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesignation.ForeColor = System.Drawing.Color.DimGray;
            this.lbldesignation.Location = new System.Drawing.Point(85, 33);
            this.lbldesignation.Name = "lbldesignation";
            this.lbldesignation.Size = new System.Drawing.Size(248, 15);
            this.lbldesignation.TabIndex = 11;
            this.lbldesignation.Text = "Administrator";
            this.lbldesignation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.lbldesignation, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbldesignation, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbldesignation, "");
            this.lbldesignation.Click += new System.EventHandler(this.lbldesignation_Click);
            // 
            // lblfullname
            // 
            this.lblfullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuTransition1.SetDecoration(this.lblfullname, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblfullname.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullname.ForeColor = System.Drawing.Color.Snow;
            this.lblfullname.Location = new System.Drawing.Point(85, 17);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(248, 18);
            this.lblfullname.TabIndex = 12;
            this.lblfullname.Text = "Administrator";
            this.lblfullname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.lblfullname, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblfullname, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblfullname, "");
            this.lblfullname.Click += new System.EventHandler(this.lblfullname_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel9
            // 
            this.bunifuTransition1.SetDecoration(this.panel9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 60);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1705, 6);
            this.panel9.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.panel9, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel9, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel9, "");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel5);
            this.bunifuTransition1.SetDecoration(this.panel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1365, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 802);
            this.panel3.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panel3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel3, "");
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panelaction);
            this.panel12.Controls.Add(this.panelorder);
            this.panel12.Controls.Add(this.panelvatsettings);
            this.panel12.Controls.Add(this.panelcustomer);
            this.bunifuTransition1.SetDecoration(this.panel12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(246, 597);
            this.panel12.TabIndex = 17;
            this.bunifuToolTip1.SetToolTip(this.panel12, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel12, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel12, "");
            // 
            // panelaction
            // 
            this.panelaction.Controls.Add(this.metroTile10);
            this.panelaction.Controls.Add(this.metroTile8);
            this.panelaction.Controls.Add(this.metroTile7);
            this.panelaction.Controls.Add(this.metroTile3);
            this.panelaction.Controls.Add(this.metroTile2);
            this.panelaction.Controls.Add(this.metroTile1);
            this.bunifuTransition1.SetDecoration(this.panelaction, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelaction.Location = new System.Drawing.Point(0, 0);
            this.panelaction.Name = "panelaction";
            this.panelaction.Size = new System.Drawing.Size(246, 597);
            this.panelaction.TabIndex = 18;
            this.bunifuToolTip1.SetToolTip(this.panelaction, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelaction, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelaction, "");
            this.panelaction.Visible = false;
            // 
            // metroTile10
            // 
            this.metroTile10.ActiveControl = null;
            this.metroTile10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.bunifuTransition1.SetDecoration(this.metroTile10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.metroTile10.Location = new System.Drawing.Point(8, 285);
            this.metroTile10.Name = "metroTile10";
            this.metroTile10.Size = new System.Drawing.Size(230, 87);
            this.metroTile10.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile10.TabIndex = 6;
            this.metroTile10.Text = "Override tax";
            this.metroTile10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile10.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile10.TileImage")));
            this.metroTile10.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile10.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile10.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bunifuToolTip1.SetToolTip(this.metroTile10, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroTile10, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroTile10, "");
            this.metroTile10.UseCustomBackColor = true;
            this.metroTile10.UseSelectable = true;
            this.metroTile10.UseTileImage = true;
            // 
            // metroTile8
            // 
            this.metroTile8.ActiveControl = null;
            this.metroTile8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.bunifuTransition1.SetDecoration(this.metroTile8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.metroTile8.Location = new System.Drawing.Point(8, 192);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(230, 87);
            this.metroTile8.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile8.TabIndex = 4;
            this.metroTile8.Text = "Return line";
            this.metroTile8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile8.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile8.TileImage")));
            this.metroTile8.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile8.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile8.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bunifuToolTip1.SetToolTip(this.metroTile8, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroTile8, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroTile8, "");
            this.metroTile8.UseCustomBackColor = true;
            this.metroTile8.UseSelectable = true;
            this.metroTile8.UseTileImage = true;
            this.metroTile8.Click += new System.EventHandler(this.metroTile8_Click);
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.bunifuTransition1.SetDecoration(this.metroTile7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.metroTile7.Location = new System.Drawing.Point(8, 99);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(110, 87);
            this.metroTile7.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile7.TabIndex = 3;
            this.metroTile7.Text = "Set line discount";
            this.metroTile7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile7.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile7.TileImage")));
            this.metroTile7.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile7.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile7.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bunifuToolTip1.SetToolTip(this.metroTile7, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroTile7, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroTile7, "");
            this.metroTile7.UseCustomBackColor = true;
            this.metroTile7.UseSelectable = true;
            this.metroTile7.UseTileImage = true;
            this.metroTile7.Click += new System.EventHandler(this.metroTile7_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(110)))), ((int)(((byte)(201)))));
            this.bunifuTransition1.SetDecoration(this.metroTile3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.metroTile3.Enabled = false;
            this.metroTile3.Location = new System.Drawing.Point(128, 99);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(110, 87);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Issue loyalty card";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bunifuToolTip1.SetToolTip(this.metroTile3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroTile3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroTile3, "");
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(110)))), ((int)(((byte)(201)))));
            this.bunifuTransition1.SetDecoration(this.metroTile2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.metroTile2.Enabled = false;
            this.metroTile2.Location = new System.Drawing.Point(128, 6);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(110, 87);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Scan loyalty card";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bunifuToolTip1.SetToolTip(this.metroTile2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroTile2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroTile2, "");
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.bunifuTransition1.SetDecoration(this.metroTile1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.metroTile1.Location = new System.Drawing.Point(8, 6);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(110, 87);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Set line quantity";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bunifuToolTip1.SetToolTip(this.metroTile1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroTile1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroTile1, "");
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // panelorder
            // 
            this.panelorder.Controls.Add(this.label25);
            this.bunifuTransition1.SetDecoration(this.panelorder, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelorder.Location = new System.Drawing.Point(0, 0);
            this.panelorder.Name = "panelorder";
            this.panelorder.Size = new System.Drawing.Size(246, 597);
            this.panelorder.TabIndex = 19;
            this.bunifuToolTip1.SetToolTip(this.panelorder, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelorder, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelorder, "");
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTransition1.SetDecoration(this.label25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label25.Dock = System.Windows.Forms.DockStyle.Top;
            this.label25.Font = new System.Drawing.Font("Roboto Lt", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.DarkGray;
            this.label25.Location = new System.Drawing.Point(0, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(246, 62);
            this.label25.TabIndex = 88;
            this.label25.Text = "Order";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuToolTip1.SetToolTip(this.label25, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label25, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label25, "");
            // 
            // panelvatsettings
            // 
            this.panelvatsettings.Controls.Add(this.bunifuDropdown2);
            this.panelvatsettings.Controls.Add(this.bunifuImageButton3);
            this.panelvatsettings.Controls.Add(this.label26);
            this.panelvatsettings.Controls.Add(this.bunifuImageButton2);
            this.panelvatsettings.Controls.Add(this.bunifuiOSSwitch5);
            this.panelvatsettings.Controls.Add(this.label24);
            this.panelvatsettings.Controls.Add(this.bunifuiOSSwitch4);
            this.panelvatsettings.Controls.Add(this.label23);
            this.panelvatsettings.Controls.Add(this.bunifuiOSSwitch3);
            this.panelvatsettings.Controls.Add(this.label22);
            this.panelvatsettings.Controls.Add(this.bunifuiOSSwitch2);
            this.panelvatsettings.Controls.Add(this.label19);
            this.panelvatsettings.Controls.Add(this.bunifuSeparator3);
            this.panelvatsettings.Controls.Add(this.bunifuiOSSwitch1);
            this.panelvatsettings.Controls.Add(this.label18);
            this.panelvatsettings.Controls.Add(this.label16);
            this.bunifuTransition1.SetDecoration(this.panelvatsettings, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelvatsettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelvatsettings.Location = new System.Drawing.Point(0, 0);
            this.panelvatsettings.Name = "panelvatsettings";
            this.panelvatsettings.Size = new System.Drawing.Size(246, 597);
            this.panelvatsettings.TabIndex = 21;
            this.bunifuToolTip1.SetToolTip(this.panelvatsettings, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelvatsettings, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelvatsettings, "");
            this.panelvatsettings.Visible = false;
            // 
            // bunifuDropdown2
            // 
            this.bunifuDropdown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuDropdown2.BorderRadius = 5;
            this.bunifuDropdown2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.bunifuTransition1.SetDecoration(this.bunifuDropdown2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuDropdown2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdown2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown2.FillDropDown = false;
            this.bunifuDropdown2.FillIndicator = false;
            this.bunifuDropdown2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuDropdown2.FormattingEnabled = true;
            this.bunifuDropdown2.Icon = null;
            this.bunifuDropdown2.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.bunifuDropdown2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown2.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuDropdown2.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuDropdown2.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuDropdown2.ItemHeight = 20;
            this.bunifuDropdown2.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuDropdown2.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25"});
            this.bunifuDropdown2.Location = new System.Drawing.Point(117, 264);
            this.bunifuDropdown2.Name = "bunifuDropdown2";
            this.bunifuDropdown2.Size = new System.Drawing.Size(119, 26);
            this.bunifuDropdown2.TabIndex = 101;
            this.bunifuDropdown2.Text = null;
            this.bunifuToolTip1.SetToolTip(this.bunifuDropdown2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuDropdown2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuDropdown2, "");
            this.bunifuDropdown2.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown2_SelectedIndexChanged);
            // 
            // bunifuImageButton3
            // 
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(82, 256);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(19, 25);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 100;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton3, "The amount of data to be loaded in the view. Remember, the lower\r\nthe number, the" +
        " faster the data will be loaded.");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton3, "");
            this.bunifuImageButton3.Zoom = 10;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label26.Font = new System.Drawing.Font("Roboto", 9F);
            this.label26.ForeColor = System.Drawing.Color.Gainsboro;
            this.label26.Location = new System.Drawing.Point(5, 272);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(76, 14);
            this.label26.TabIndex = 99;
            this.label26.Text = "Data Display";
            this.bunifuToolTip1.SetToolTip(this.label26, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label26, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label26, "");
            // 
            // bunifuImageButton2
            // 
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(78, 221);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(19, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 98;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton2, "Opens cart directly when there is only one result on the query given.");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton2, "");
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuiOSSwitch5
            // 
            this.bunifuiOSSwitch5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch5.BackgroundImage")));
            this.bunifuiOSSwitch5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuiOSSwitch5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuiOSSwitch5.Location = new System.Drawing.Point(198, 226);
            this.bunifuiOSSwitch5.Name = "bunifuiOSSwitch5";
            this.bunifuiOSSwitch5.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch5.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuiOSSwitch5.Size = new System.Drawing.Size(35, 20);
            this.bunifuiOSSwitch5.TabIndex = 97;
            this.bunifuToolTip1.SetToolTip(this.bunifuiOSSwitch5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuiOSSwitch5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuiOSSwitch5, "");
            this.bunifuiOSSwitch5.Value = true;
            this.bunifuiOSSwitch5.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch5_OnValueChange);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label24.Font = new System.Drawing.Font("Roboto", 9F);
            this.label24.ForeColor = System.Drawing.Color.Gainsboro;
            this.label24.Location = new System.Drawing.Point(5, 232);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 14);
            this.label24.TabIndex = 96;
            this.label24.Text = "Direct search";
            this.bunifuToolTip1.SetToolTip(this.label24, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label24, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label24, "");
            // 
            // bunifuiOSSwitch4
            // 
            this.bunifuiOSSwitch4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch4.BackgroundImage")));
            this.bunifuiOSSwitch4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuiOSSwitch4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuiOSSwitch4.Location = new System.Drawing.Point(198, 182);
            this.bunifuiOSSwitch4.Name = "bunifuiOSSwitch4";
            this.bunifuiOSSwitch4.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch4.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuiOSSwitch4.Size = new System.Drawing.Size(35, 20);
            this.bunifuiOSSwitch4.TabIndex = 95;
            this.bunifuToolTip1.SetToolTip(this.bunifuiOSSwitch4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuiOSSwitch4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuiOSSwitch4, "");
            this.bunifuiOSSwitch4.Value = true;
            this.bunifuiOSSwitch4.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch4_OnValueChange);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label23.Font = new System.Drawing.Font("Roboto", 9F);
            this.label23.ForeColor = System.Drawing.Color.Gainsboro;
            this.label23.Location = new System.Drawing.Point(3, 188);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 14);
            this.label23.TabIndex = 94;
            this.label23.Text = "Horizontal Info flow";
            this.bunifuToolTip1.SetToolTip(this.label23, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label23, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label23, "");
            // 
            // bunifuiOSSwitch3
            // 
            this.bunifuiOSSwitch3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch3.BackgroundImage")));
            this.bunifuiOSSwitch3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuiOSSwitch3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuiOSSwitch3.Location = new System.Drawing.Point(199, 140);
            this.bunifuiOSSwitch3.Name = "bunifuiOSSwitch3";
            this.bunifuiOSSwitch3.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch3.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuiOSSwitch3.Size = new System.Drawing.Size(35, 20);
            this.bunifuiOSSwitch3.TabIndex = 93;
            this.bunifuToolTip1.SetToolTip(this.bunifuiOSSwitch3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuiOSSwitch3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuiOSSwitch3, "");
            this.bunifuiOSSwitch3.Value = true;
            this.bunifuiOSSwitch3.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch3_OnValueChange);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label22.Font = new System.Drawing.Font("Roboto", 9F);
            this.label22.ForeColor = System.Drawing.Color.Gainsboro;
            this.label22.Location = new System.Drawing.Point(3, 144);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 14);
            this.label22.TabIndex = 92;
            this.label22.Text = "Direct Print";
            this.bunifuToolTip1.SetToolTip(this.label22, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label22, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label22, "");
            // 
            // bunifuiOSSwitch2
            // 
            this.bunifuiOSSwitch2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch2.BackgroundImage")));
            this.bunifuiOSSwitch2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuiOSSwitch2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuiOSSwitch2.Location = new System.Drawing.Point(198, 99);
            this.bunifuiOSSwitch2.Name = "bunifuiOSSwitch2";
            this.bunifuiOSSwitch2.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch2.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuiOSSwitch2.Size = new System.Drawing.Size(35, 20);
            this.bunifuiOSSwitch2.TabIndex = 91;
            this.bunifuToolTip1.SetToolTip(this.bunifuiOSSwitch2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuiOSSwitch2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuiOSSwitch2, "");
            this.bunifuiOSSwitch2.Value = true;
            this.bunifuiOSSwitch2.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch2_OnValueChange);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label19.Font = new System.Drawing.Font("Roboto", 9F);
            this.label19.ForeColor = System.Drawing.Color.Gainsboro;
            this.label19.Location = new System.Drawing.Point(2, 103);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 14);
            this.label19.TabIndex = 90;
            this.label19.Text = "Enable DEBT";
            this.bunifuToolTip1.SetToolTip(this.label19, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label19, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label19, "");
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(6, 28);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(227, 12);
            this.bunifuSeparator3.TabIndex = 89;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator3, "");
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuiOSSwitch1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(199, 61);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(35, 20);
            this.bunifuiOSSwitch1.TabIndex = 88;
            this.bunifuToolTip1.SetToolTip(this.bunifuiOSSwitch1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuiOSSwitch1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuiOSSwitch1, "");
            this.bunifuiOSSwitch1.Value = true;
            this.bunifuiOSSwitch1.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch1_OnValueChange);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label18.Font = new System.Drawing.Font("Roboto", 9F);
            this.label18.ForeColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(3, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 14);
            this.label18.TabIndex = 87;
            this.label18.Text = "Enable VAT";
            this.bunifuToolTip1.SetToolTip(this.label18, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label18, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label18, "");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label16.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(2, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 19);
            this.label16.TabIndex = 86;
            this.label16.Text = "Settings";
            this.bunifuToolTip1.SetToolTip(this.label16, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label16, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label16, "");
            // 
            // panelcustomer
            // 
            this.panelcustomer.Controls.Add(this.metroTile18);
            this.panelcustomer.Controls.Add(this.metroTile17);
            this.panelcustomer.Controls.Add(this.metroTile15);
            this.panelcustomer.Controls.Add(this.metroTile14);
            this.panelcustomer.Controls.Add(this.metroTile16);
            this.bunifuTransition1.SetDecoration(this.panelcustomer, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelcustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcustomer.Location = new System.Drawing.Point(0, 0);
            this.panelcustomer.Name = "panelcustomer";
            this.panelcustomer.Size = new System.Drawing.Size(246, 597);
            this.panelcustomer.TabIndex = 20;
            this.bunifuToolTip1.SetToolTip(this.panelcustomer, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelcustomer, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelcustomer, "");
            this.panelcustomer.Visible = false;
            // 
            // metroTile18
            // 
            this.metroTile18.ActiveControl = null;
            this.metroTile18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.bunifuTransition1.SetDecoration(this.metroTile18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.metroTile18.Location = new System.Drawing.Point(6, 195);
            this.metroTile18.Name = "metroTile18";
            this.metroTile18.Size = new System.Drawing.Size(230, 87);
            this.metroTile18.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile18.TabIndex = 4;
            this.metroTile18.Text = "View debt history";
            this.metroTile18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile18.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile18.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile18.TileImage")));
            this.metroTile18.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile18.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile18.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bunifuToolTip1.SetToolTip(this.metroTile18, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroTile18, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroTile18, "");
            this.metroTile18.UseCustomBackColor = true;
            this.metroTile18.UseSelectable = true;
            this.metroTile18.UseTileImage = true;
            this.metroTile18.Click += new System.EventHandler(this.metroTile18_Click);
            // 
            // metroTile17
            // 
            this.metroTile17.ActiveControl = null;
            this.metroTile17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.bunifuTransition1.SetDecoration(this.metroTile17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.metroTile17.Location = new System.Drawing.Point(6, 288);
            this.metroTile17.Name = "metroTile17";
            this.metroTile17.Size = new System.Drawing.Size(230, 87);
            this.metroTile17.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile17.TabIndex = 3;
            this.metroTile17.Text = "Refresh";
            this.metroTile17.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile17.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile17.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile17.TileImage")));
            this.metroTile17.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile17.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile17.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bunifuToolTip1.SetToolTip(this.metroTile17, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroTile17, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroTile17, "");
            this.metroTile17.UseCustomBackColor = true;
            this.metroTile17.UseSelectable = true;
            this.metroTile17.UseTileImage = true;
            this.metroTile17.Click += new System.EventHandler(this.metroTile17_Click);
            // 
            // metroTile15
            // 
            this.metroTile15.ActiveControl = null;
            this.metroTile15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.bunifuTransition1.SetDecoration(this.metroTile15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.metroTile15.Location = new System.Drawing.Point(126, 102);
            this.metroTile15.Name = "metroTile15";
            this.metroTile15.Size = new System.Drawing.Size(110, 87);
            this.metroTile15.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile15.TabIndex = 2;
            this.metroTile15.Text = "Cancel Cus order";
            this.metroTile15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile15.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile15.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile15.TileImage")));
            this.metroTile15.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile15.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile15.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bunifuToolTip1.SetToolTip(this.metroTile15, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroTile15, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroTile15, "");
            this.metroTile15.UseCustomBackColor = true;
            this.metroTile15.UseSelectable = true;
            this.metroTile15.UseTileImage = true;
            this.metroTile15.Click += new System.EventHandler(this.metroTile15_Click);
            // 
            // metroTile14
            // 
            this.metroTile14.ActiveControl = null;
            this.metroTile14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.bunifuTransition1.SetDecoration(this.metroTile14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.metroTile14.Location = new System.Drawing.Point(6, 101);
            this.metroTile14.Name = "metroTile14";
            this.metroTile14.Size = new System.Drawing.Size(110, 87);
            this.metroTile14.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile14.TabIndex = 1;
            this.metroTile14.Text = "Add to debt";
            this.metroTile14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile14.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile14.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile14.TileImage")));
            this.metroTile14.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile14.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile14.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bunifuToolTip1.SetToolTip(this.metroTile14, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroTile14, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroTile14, "");
            this.metroTile14.UseCustomBackColor = true;
            this.metroTile14.UseSelectable = true;
            this.metroTile14.UseTileImage = true;
            this.metroTile14.Click += new System.EventHandler(this.metroTile14_Click);
            // 
            // metroTile16
            // 
            this.metroTile16.ActiveControl = null;
            this.metroTile16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.bunifuTransition1.SetDecoration(this.metroTile16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.metroTile16.Location = new System.Drawing.Point(6, 9);
            this.metroTile16.Name = "metroTile16";
            this.metroTile16.Size = new System.Drawing.Size(230, 87);
            this.metroTile16.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile16.TabIndex = 0;
            this.metroTile16.Text = "Add customer";
            this.metroTile16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile16.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile16.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile16.TileImage")));
            this.metroTile16.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile16.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile16.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bunifuToolTip1.SetToolTip(this.metroTile16, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroTile16, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroTile16, "");
            this.metroTile16.UseCustomBackColor = true;
            this.metroTile16.UseSelectable = true;
            this.metroTile16.UseTileImage = true;
            this.metroTile16.Click += new System.EventHandler(this.metroTile16_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btncustomers);
            this.panel7.Controls.Add(this.btndiscounts);
            this.panel7.Controls.Add(this.btnorder);
            this.panel7.Controls.Add(this.btnaction);
            this.bunifuTransition1.SetDecoration(this.panel7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(246, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(84, 597);
            this.panel7.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.panel7, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel7, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel7, "");
            // 
            // btncustomers
            // 
            this.btncustomers.Active = false;
            this.btncustomers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btncustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btncustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncustomers.BorderRadius = 0;
            this.btncustomers.ButtonText = "";
            this.btncustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btncustomers, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btncustomers.DisabledColor = System.Drawing.Color.Gray;
            this.btncustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncustomers.Iconcolor = System.Drawing.Color.Transparent;
            this.btncustomers.Iconimage = ((System.Drawing.Image)(resources.GetObject("btncustomers.Iconimage")));
            this.btncustomers.Iconimage_right = null;
            this.btncustomers.Iconimage_right_Selected = null;
            this.btncustomers.Iconimage_Selected = null;
            this.btncustomers.IconMarginLeft = 0;
            this.btncustomers.IconMarginRight = 0;
            this.btncustomers.IconRightVisible = true;
            this.btncustomers.IconRightZoom = 0D;
            this.btncustomers.IconVisible = true;
            this.btncustomers.IconZoom = 80D;
            this.btncustomers.IsTab = false;
            this.btncustomers.Location = new System.Drawing.Point(0, 237);
            this.btncustomers.Name = "btncustomers";
            this.btncustomers.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btncustomers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btncustomers.OnHoverTextColor = System.Drawing.Color.White;
            this.btncustomers.selected = false;
            this.btncustomers.Size = new System.Drawing.Size(84, 79);
            this.btncustomers.TabIndex = 29;
            this.btncustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncustomers.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btncustomers.TextFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btncustomers, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btncustomers, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btncustomers, "");
            this.btncustomers.Click += new System.EventHandler(this.btncustomers_Click);
            // 
            // btndiscounts
            // 
            this.btndiscounts.Active = false;
            this.btndiscounts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btndiscounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btndiscounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndiscounts.BorderRadius = 0;
            this.btndiscounts.ButtonText = "";
            this.btndiscounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btndiscounts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btndiscounts.DisabledColor = System.Drawing.Color.Gray;
            this.btndiscounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndiscounts.Iconcolor = System.Drawing.Color.Transparent;
            this.btndiscounts.Iconimage = ((System.Drawing.Image)(resources.GetObject("btndiscounts.Iconimage")));
            this.btndiscounts.Iconimage_right = null;
            this.btndiscounts.Iconimage_right_Selected = null;
            this.btndiscounts.Iconimage_Selected = null;
            this.btndiscounts.IconMarginLeft = 0;
            this.btndiscounts.IconMarginRight = 0;
            this.btndiscounts.IconRightVisible = true;
            this.btndiscounts.IconRightZoom = 0D;
            this.btndiscounts.IconVisible = true;
            this.btndiscounts.IconZoom = 80D;
            this.btndiscounts.IsTab = false;
            this.btndiscounts.Location = new System.Drawing.Point(0, 158);
            this.btndiscounts.Name = "btndiscounts";
            this.btndiscounts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btndiscounts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btndiscounts.OnHoverTextColor = System.Drawing.Color.White;
            this.btndiscounts.selected = false;
            this.btndiscounts.Size = new System.Drawing.Size(84, 79);
            this.btndiscounts.TabIndex = 28;
            this.btndiscounts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndiscounts.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btndiscounts.TextFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btndiscounts, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btndiscounts, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btndiscounts, "");
            this.btndiscounts.Click += new System.EventHandler(this.btndiscounts_Click);
            // 
            // btnorder
            // 
            this.btnorder.Active = false;
            this.btnorder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnorder.BorderRadius = 0;
            this.btnorder.ButtonText = "";
            this.btnorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnorder, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnorder.DisabledColor = System.Drawing.Color.Gray;
            this.btnorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnorder.Iconcolor = System.Drawing.Color.Transparent;
            this.btnorder.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnorder.Iconimage")));
            this.btnorder.Iconimage_right = null;
            this.btnorder.Iconimage_right_Selected = null;
            this.btnorder.Iconimage_Selected = null;
            this.btnorder.IconMarginLeft = 0;
            this.btnorder.IconMarginRight = 0;
            this.btnorder.IconRightVisible = true;
            this.btnorder.IconRightZoom = 0D;
            this.btnorder.IconVisible = true;
            this.btnorder.IconZoom = 80D;
            this.btnorder.IsTab = false;
            this.btnorder.Location = new System.Drawing.Point(0, 79);
            this.btnorder.Name = "btnorder";
            this.btnorder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnorder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btnorder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnorder.selected = false;
            this.btnorder.Size = new System.Drawing.Size(84, 79);
            this.btnorder.TabIndex = 27;
            this.btnorder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnorder.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnorder.TextFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnorder, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnorder, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnorder, "");
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btnaction
            // 
            this.btnaction.Active = false;
            this.btnaction.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaction.BorderRadius = 0;
            this.btnaction.ButtonText = "";
            this.btnaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnaction, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnaction.DisabledColor = System.Drawing.Color.Gray;
            this.btnaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnaction.Iconcolor = System.Drawing.Color.Transparent;
            this.btnaction.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnaction.Iconimage")));
            this.btnaction.Iconimage_right = null;
            this.btnaction.Iconimage_right_Selected = null;
            this.btnaction.Iconimage_Selected = null;
            this.btnaction.IconMarginLeft = 0;
            this.btnaction.IconMarginRight = 0;
            this.btnaction.IconRightVisible = true;
            this.btnaction.IconRightZoom = 0D;
            this.btnaction.IconVisible = true;
            this.btnaction.IconZoom = 80D;
            this.btnaction.IsTab = false;
            this.btnaction.Location = new System.Drawing.Point(0, 0);
            this.btnaction.Name = "btnaction";
            this.btnaction.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnaction.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btnaction.OnHoverTextColor = System.Drawing.Color.White;
            this.btnaction.selected = false;
            this.btnaction.Size = new System.Drawing.Size(84, 79);
            this.btnaction.TabIndex = 26;
            this.btnaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaction.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnaction.TextFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnaction, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnaction, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnaction, "");
            this.btnaction.Click += new System.EventHandler(this.btnaction_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.indicator);
            this.bunifuTransition1.SetDecoration(this.panel8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(330, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 597);
            this.panel8.TabIndex = 16;
            this.bunifuToolTip1.SetToolTip(this.panel8, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel8, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel8, "");
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuTransition1.SetDecoration(this.indicator, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.indicator.Location = new System.Drawing.Point(0, 78);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(9, 80);
            this.indicator.TabIndex = 22;
            this.bunifuToolTip1.SetToolTip(this.indicator, "");
            this.bunifuToolTip1.SetToolTipIcon(this.indicator, null);
            this.bunifuToolTip1.SetToolTipTitle(this.indicator, "");
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.metroTile13);
            this.panel5.Controls.Add(this.metroTile12);
            this.panel5.Controls.Add(this.metroTile11);
            this.panel5.Controls.Add(this.metroTile9);
            this.bunifuTransition1.SetDecoration(this.panel5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 597);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(340, 205);
            this.panel5.TabIndex = 14;
            this.bunifuToolTip1.SetToolTip(this.panel5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel5, "");
            // 
            // metroTile13
            // 
            this.metroTile13.ActiveControl = null;
            this.metroTile13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.bunifuTransition1.SetDecoration(this.metroTile13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.metroTile13.Location = new System.Drawing.Point(168, 101);
            this.metroTile13.Name = "metroTile13";
            this.metroTile13.Size = new System.Drawing.Size(164, 93);
            this.metroTile13.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile13.TabIndex = 19;
            this.metroTile13.Text = "Transaction List";
            this.metroTile13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile13.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile13.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile13.TileImage")));
            this.metroTile13.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile13.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile13.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bunifuToolTip1.SetToolTip(this.metroTile13, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroTile13, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroTile13, "");
            this.metroTile13.UseCustomBackColor = true;
            this.metroTile13.UseSelectable = true;
            this.metroTile13.UseTileImage = true;
            // 
            // metroTile12
            // 
            this.metroTile12.ActiveControl = null;
            this.metroTile12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.bunifuTransition1.SetDecoration(this.metroTile12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.metroTile12.Location = new System.Drawing.Point(8, 101);
            this.metroTile12.Name = "metroTile12";
            this.metroTile12.Size = new System.Drawing.Size(154, 93);
            this.metroTile12.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile12.TabIndex = 18;
            this.metroTile12.Text = "Ctrl+T";
            this.metroTile12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile12.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile12.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile12.TileImage")));
            this.metroTile12.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile12.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile12.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bunifuToolTip1.SetToolTip(this.metroTile12, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroTile12, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroTile12, "");
            this.metroTile12.UseCustomBackColor = true;
            this.metroTile12.UseSelectable = true;
            this.metroTile12.UseTileImage = true;
            // 
            // metroTile11
            // 
            this.metroTile11.ActiveControl = null;
            this.metroTile11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuTransition1.SetDecoration(this.metroTile11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.metroTile11.Enabled = false;
            this.metroTile11.Location = new System.Drawing.Point(168, 6);
            this.metroTile11.Name = "metroTile11";
            this.metroTile11.Size = new System.Drawing.Size(164, 91);
            this.metroTile11.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile11.TabIndex = 17;
            this.metroTile11.Text = "Void Transac";
            this.metroTile11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile11.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile11.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile11.TileImage")));
            this.metroTile11.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile11.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile11.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bunifuToolTip1.SetToolTip(this.metroTile11, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroTile11, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroTile11, "");
            this.metroTile11.UseCustomBackColor = true;
            this.metroTile11.UseSelectable = true;
            this.metroTile11.UseTileImage = true;
            this.metroTile11.Click += new System.EventHandler(this.metroTile11_Click);
            // 
            // metroTile9
            // 
            this.metroTile9.ActiveControl = null;
            this.metroTile9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuTransition1.SetDecoration(this.metroTile9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.metroTile9.Enabled = false;
            this.metroTile9.Location = new System.Drawing.Point(8, 3);
            this.metroTile9.Name = "metroTile9";
            this.metroTile9.Size = new System.Drawing.Size(154, 94);
            this.metroTile9.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile9.TabIndex = 16;
            this.metroTile9.Text = "Checkout";
            this.metroTile9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile9.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile9.TileImage")));
            this.metroTile9.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile9.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile9.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bunifuToolTip1.SetToolTip(this.metroTile9, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroTile9, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroTile9, "");
            this.metroTile9.UseCustomBackColor = true;
            this.metroTile9.UseSelectable = true;
            this.metroTile9.UseTileImage = true;
            this.metroTile9.Click += new System.EventHandler(this.metroTile9_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel19);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Controls.Add(this.panel17);
            this.panel10.Controls.Add(this.panel15);
            this.bunifuTransition1.SetDecoration(this.panel10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 594);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1365, 208);
            this.panel10.TabIndex = 16;
            this.bunifuToolTip1.SetToolTip(this.panel10, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel10, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel10, "");
            // 
            // panel19
            // 
            this.bunifuTransition1.SetDecoration(this.panel19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(310, 10);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(282, 188);
            this.panel19.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.panel19, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel19, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel19, "");
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel13.Controls.Add(this.label10);
            this.panel13.Controls.Add(this.label9);
            this.panel13.Controls.Add(this.label8);
            this.panel13.Controls.Add(this.label7);
            this.panel13.Controls.Add(this.label6);
            this.panel13.Controls.Add(this.label5);
            this.panel13.Controls.Add(this.bunifuSeparator1);
            this.panel13.Controls.Add(this.label4);
            this.panel13.Controls.Add(this.label3);
            this.panel13.Controls.Add(this.pictureBox2);
            this.panel13.Controls.Add(this.pictureBox1);
            this.panel13.Controls.Add(this.label2);
            this.panel13.Controls.Add(this.label1);
            this.panel13.Controls.Add(this.bunifuPictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 10);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(310, 188);
            this.panel13.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panel13, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel13, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel13, "");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label10.Location = new System.Drawing.Point(204, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Loyalty card #:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.label10, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label10, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label10, "");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label9.Location = new System.Drawing.Point(204, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Loyalty card #:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.label9, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label9, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label9, "");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label8.Location = new System.Drawing.Point(12, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Card points:";
            this.bunifuToolTip1.SetToolTip(this.label8, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label8, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label8, "");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label7.Location = new System.Drawing.Point(12, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Balance:";
            this.bunifuToolTip1.SetToolTip(this.label7, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label7, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label7, "");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label6.Location = new System.Drawing.Point(204, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Loyalty card #:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.label6, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label6, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label6, "");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Loyalty card #:";
            this.bunifuToolTip1.SetToolTip(this.label5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label5, "");
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(11, 95);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(285, 10);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator1, "");
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label4.Location = new System.Drawing.Point(122, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Loyal name";
            this.bunifuToolTip1.SetToolTip(this.label4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label4, "");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(122, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Loyal name";
            this.bunifuToolTip1.SetToolTip(this.label3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label3, "");
            // 
            // pictureBox2
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(94, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox2, "");
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox1, "");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(92, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Loyal name";
            this.bunifuToolTip1.SetToolTip(this.label2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label2, "");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(91, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Loyal name";
            this.bunifuToolTip1.SetToolTip(this.label1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label1, "");
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 36;
            this.bunifuTransition1.SetDecoration(this.bunifuPictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(12, 6);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(73, 73);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuPictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuPictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuPictureBox1, "");
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel14.Controls.Add(this.label21);
            this.panel14.Controls.Add(this.label17);
            this.panel14.Controls.Add(this.label12);
            this.panel14.Controls.Add(this.panel25);
            this.panel14.Controls.Add(this.panel18);
            this.panel14.Controls.Add(this.panel16);
            this.panel14.Controls.Add(this.bunifuSeparator2);
            this.bunifuTransition1.SetDecoration(this.panel14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(592, 10);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(773, 188);
            this.panel14.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.panel14, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel14, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel14, "");
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label21.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label21.Location = new System.Drawing.Point(331, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 15);
            this.label21.TabIndex = 24;
            this.label21.Text = "TAX";
            this.bunifuToolTip1.SetToolTip(this.label21, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label21, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label21, "");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label17.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label17.Location = new System.Drawing.Point(331, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 15);
            this.label17.TabIndex = 21;
            this.label17.Text = "SUBTOTAL";
            this.bunifuToolTip1.SetToolTip(this.label17, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label17, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label17, "");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label12.Location = new System.Drawing.Point(331, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Total VAT";
            this.bunifuToolTip1.SetToolTip(this.label12, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label12, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label12, "");
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.label11);
            this.panel25.Controls.Add(this.label13);
            this.panel25.Controls.Add(this.label14);
            this.panel25.Controls.Add(this.label28);
            this.panel25.Controls.Add(this.panel26);
            this.bunifuTransition1.SetDecoration(this.panel25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel25.Location = new System.Drawing.Point(0, 0);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(314, 129);
            this.panel25.TabIndex = 27;
            this.bunifuToolTip1.SetToolTip(this.panel25, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel25, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel25, "");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label11.Location = new System.Drawing.Point(3, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "LINES";
            this.bunifuToolTip1.SetToolTip(this.label11, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label11, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label11, "");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label13.Location = new System.Drawing.Point(3, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "Tot. Qty";
            this.bunifuToolTip1.SetToolTip(this.label13, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label13, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label13, "");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label14.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label14.Location = new System.Drawing.Point(3, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 15);
            this.label14.TabIndex = 20;
            this.label14.Text = "DISCOUNTS";
            this.bunifuToolTip1.SetToolTip(this.label14, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label14, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label14, "");
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label28, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label28.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(149)))));
            this.label28.Location = new System.Drawing.Point(3, 7);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(42, 15);
            this.label28.TabIndex = 19;
            this.label28.Text = "INV. #";
            this.bunifuToolTip1.SetToolTip(this.label28, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label28, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label28, "");
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.linediscounts);
            this.panel26.Controls.Add(this.quantity);
            this.panel26.Controls.Add(this.lblline);
            this.panel26.Controls.Add(this.lblinvoice);
            this.bunifuTransition1.SetDecoration(this.panel26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel26.Location = new System.Drawing.Point(88, 0);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(226, 129);
            this.panel26.TabIndex = 18;
            this.bunifuToolTip1.SetToolTip(this.panel26, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel26, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel26, "");
            // 
            // linediscounts
            // 
            this.bunifuTransition1.SetDecoration(this.linediscounts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.linediscounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.linediscounts.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linediscounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.linediscounts.Location = new System.Drawing.Point(0, 72);
            this.linediscounts.Name = "linediscounts";
            this.linediscounts.Size = new System.Drawing.Size(226, 24);
            this.linediscounts.TabIndex = 19;
            this.linediscounts.Text = "0.00";
            this.linediscounts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.linediscounts, "");
            this.bunifuToolTip1.SetToolTipIcon(this.linediscounts, null);
            this.bunifuToolTip1.SetToolTipTitle(this.linediscounts, "");
            // 
            // quantity
            // 
            this.bunifuTransition1.SetDecoration(this.quantity, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.quantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.quantity.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.quantity.Location = new System.Drawing.Point(0, 48);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(226, 24);
            this.quantity.TabIndex = 18;
            this.quantity.Text = "0.00";
            this.quantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.quantity, "");
            this.bunifuToolTip1.SetToolTipIcon(this.quantity, null);
            this.bunifuToolTip1.SetToolTipTitle(this.quantity, "");
            // 
            // lblline
            // 
            this.bunifuTransition1.SetDecoration(this.lblline, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblline.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblline.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblline.Location = new System.Drawing.Point(0, 24);
            this.lblline.Name = "lblline";
            this.lblline.Size = new System.Drawing.Size(226, 24);
            this.lblline.TabIndex = 14;
            this.lblline.Text = "0.00";
            this.lblline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.lblline, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblline, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblline, "");
            // 
            // lblinvoice
            // 
            this.bunifuTransition1.SetDecoration(this.lblinvoice, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblinvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblinvoice.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(149)))));
            this.lblinvoice.Location = new System.Drawing.Point(0, 0);
            this.lblinvoice.Name = "lblinvoice";
            this.lblinvoice.Size = new System.Drawing.Size(226, 24);
            this.lblinvoice.TabIndex = 17;
            this.lblinvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.lblinvoice, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblinvoice, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblinvoice, "");
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.panel22);
            this.panel18.Controls.Add(this.panel21);
            this.panel18.Controls.Add(this.panel20);
            this.bunifuTransition1.SetDecoration(this.panel18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel18.Location = new System.Drawing.Point(569, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(204, 129);
            this.panel18.TabIndex = 23;
            this.bunifuToolTip1.SetToolTip(this.panel18, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel18, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel18, "");
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.total_vat);
            this.bunifuTransition1.SetDecoration(this.panel22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel22.Location = new System.Drawing.Point(0, 58);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(204, 29);
            this.panel22.TabIndex = 25;
            this.bunifuToolTip1.SetToolTip(this.panel22, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel22, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel22, "");
            // 
            // total_vat
            // 
            this.bunifuTransition1.SetDecoration(this.total_vat, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.total_vat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.total_vat.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_vat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.total_vat.Location = new System.Drawing.Point(0, 0);
            this.total_vat.Name = "total_vat";
            this.total_vat.Size = new System.Drawing.Size(204, 29);
            this.total_vat.TabIndex = 22;
            this.total_vat.Text = "0.00";
            this.total_vat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.total_vat, "");
            this.bunifuToolTip1.SetToolTipIcon(this.total_vat, null);
            this.bunifuToolTip1.SetToolTipTitle(this.total_vat, "");
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.VAT);
            this.bunifuTransition1.SetDecoration(this.panel21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(0, 29);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(204, 29);
            this.panel21.TabIndex = 24;
            this.bunifuToolTip1.SetToolTip(this.panel21, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel21, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel21, "");
            // 
            // VAT
            // 
            this.bunifuTransition1.SetDecoration(this.VAT, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.VAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VAT.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.VAT.Location = new System.Drawing.Point(0, 0);
            this.VAT.Name = "VAT";
            this.VAT.Size = new System.Drawing.Size(204, 29);
            this.VAT.TabIndex = 22;
            this.VAT.Text = "0.00";
            this.VAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.VAT, "");
            this.bunifuToolTip1.SetToolTipIcon(this.VAT, null);
            this.bunifuToolTip1.SetToolTipTitle(this.VAT, "");
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.subtotal);
            this.bunifuTransition1.SetDecoration(this.panel20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(204, 29);
            this.panel20.TabIndex = 23;
            this.bunifuToolTip1.SetToolTip(this.panel20, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel20, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel20, "");
            // 
            // subtotal
            // 
            this.bunifuTransition1.SetDecoration(this.subtotal, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.subtotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtotal.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.subtotal.Location = new System.Drawing.Point(0, 0);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(204, 29);
            this.subtotal.TabIndex = 22;
            this.subtotal.Text = "0.00";
            this.subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.subtotal, "");
            this.bunifuToolTip1.SetToolTipIcon(this.subtotal, null);
            this.bunifuToolTip1.SetToolTipTitle(this.subtotal, "");
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.label15);
            this.panel16.Controls.Add(this.amntdue);
            this.bunifuTransition1.SetDecoration(this.panel16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(0, 129);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(773, 59);
            this.panel16.TabIndex = 20;
            this.bunifuToolTip1.SetToolTip(this.panel16, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel16, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel16, "");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label15.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label15.Location = new System.Drawing.Point(6, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "AMOUNT DUE";
            this.bunifuToolTip1.SetToolTip(this.label15, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label15, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label15, "");
            // 
            // amntdue
            // 
            this.bunifuTransition1.SetDecoration(this.amntdue, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.amntdue.Dock = System.Windows.Forms.DockStyle.Right;
            this.amntdue.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amntdue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.amntdue.Location = new System.Drawing.Point(371, 0);
            this.amntdue.Name = "amntdue";
            this.amntdue.Size = new System.Drawing.Size(402, 59);
            this.amntdue.TabIndex = 19;
            this.amntdue.Text = "Php. 0.00";
            this.amntdue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.amntdue, "");
            this.bunifuToolTip1.SetToolTipIcon(this.amntdue, null);
            this.bunifuToolTip1.SetToolTipTitle(this.amntdue, "");
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(310, 8);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(15, 115);
            this.bunifuSeparator2.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator2, "");
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // panel17
            // 
            this.bunifuTransition1.SetDecoration(this.panel17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel17.Location = new System.Drawing.Point(0, 198);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1365, 10);
            this.panel17.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.panel17, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel17, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel17, "");
            // 
            // panel15
            // 
            this.bunifuTransition1.SetDecoration(this.panel15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1365, 10);
            this.panel15.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.panel15, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel15, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel15, "");
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.flowpaneldebt);
            this.panel11.Controls.Add(this.flowpanelcart);
            this.panel11.Controls.Add(this.label20);
            this.panel11.Controls.Add(this.flowpanelcustomer);
            this.panel11.Controls.Add(this.flowpanelproducts);
            this.bunifuTransition1.SetDecoration(this.panel11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1365, 594);
            this.panel11.TabIndex = 17;
            this.bunifuToolTip1.SetToolTip(this.panel11, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel11, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel11, "");
            // 
            // flowpaneldebt
            // 
            this.flowpaneldebt.AllowUserToAddRows = false;
            this.flowpaneldebt.AllowUserToDeleteRows = false;
            this.flowpaneldebt.AllowUserToOrderColumns = true;
            this.flowpaneldebt.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.flowpaneldebt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.flowpaneldebt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.flowpaneldebt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flowpaneldebt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.flowpaneldebt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flowpaneldebt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.flowpaneldebt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flowpaneldebt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.bunifuTransition1.SetDecoration(this.flowpaneldebt, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.flowpaneldebt.DefaultCellStyle = dataGridViewCellStyle3;
            this.flowpaneldebt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpaneldebt.DoubleBuffered = true;
            this.flowpaneldebt.EnableHeadersVisualStyles = false;
            this.flowpaneldebt.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.flowpaneldebt.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
            this.flowpaneldebt.Location = new System.Drawing.Point(0, 62);
            this.flowpaneldebt.MultiSelect = false;
            this.flowpaneldebt.Name = "flowpaneldebt";
            this.flowpaneldebt.ReadOnly = true;
            this.flowpaneldebt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.flowpaneldebt.RowHeadersVisible = false;
            this.flowpaneldebt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.flowpaneldebt.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.flowpaneldebt.RowTemplate.Height = 39;
            this.flowpaneldebt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.flowpaneldebt.Size = new System.Drawing.Size(1365, 532);
            this.flowpaneldebt.TabIndex = 89;
            this.bunifuToolTip1.SetToolTip(this.flowpaneldebt, "Double click on an item to view it\'s details");
            this.bunifuToolTip1.SetToolTipIcon(this.flowpaneldebt, null);
            this.bunifuToolTip1.SetToolTipTitle(this.flowpaneldebt, "");
            this.flowpaneldebt.Visible = false;
            this.flowpaneldebt.Leave += new System.EventHandler(this.flowpaneldebt_Leave);
            this.flowpaneldebt.MouseLeave += new System.EventHandler(this.flowpaneldebt_MouseLeave);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.HeaderText = "Inv No.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount Due";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 140;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "No. of Itms";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // flowpanelcart
            // 
            this.flowpanelcart.AllowUserToAddRows = false;
            this.flowpanelcart.AllowUserToDeleteRows = false;
            this.flowpanelcart.AllowUserToOrderColumns = true;
            this.flowpanelcart.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.flowpanelcart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.flowpanelcart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.flowpanelcart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flowpanelcart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.flowpanelcart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flowpanelcart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.flowpanelcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flowpanelcart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.bunifuTransition1.SetDecoration(this.flowpanelcart, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.flowpanelcart.DefaultCellStyle = dataGridViewCellStyle7;
            this.flowpanelcart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpanelcart.DoubleBuffered = true;
            this.flowpanelcart.EnableHeadersVisualStyles = false;
            this.flowpanelcart.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.flowpanelcart.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
            this.flowpanelcart.Location = new System.Drawing.Point(0, 62);
            this.flowpanelcart.MultiSelect = false;
            this.flowpanelcart.Name = "flowpanelcart";
            this.flowpanelcart.ReadOnly = true;
            this.flowpanelcart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.flowpanelcart.RowHeadersVisible = false;
            this.flowpanelcart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.flowpanelcart.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.flowpanelcart.RowTemplate.Height = 39;
            this.flowpanelcart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.flowpanelcart.Size = new System.Drawing.Size(1365, 532);
            this.flowpanelcart.TabIndex = 88;
            this.bunifuToolTip1.SetToolTip(this.flowpanelcart, "");
            this.bunifuToolTip1.SetToolTipIcon(this.flowpanelcart, null);
            this.bunifuToolTip1.SetToolTipTitle(this.flowpanelcart, "");
            this.flowpanelcart.Visible = false;
            this.flowpanelcart.Click += new System.EventHandler(this.flowpanelcart_Click_1);
            this.flowpanelcart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.flowpanelcart_KeyDown);
            this.flowpanelcart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.flowpanelcart_KeyUp);
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column6.HeaderText = "Prod ID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Items";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 350;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantity";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Line Discount (%)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sell Price (Php)";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sub-total (Php)";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTransition1.SetDecoration(this.label20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label20.Dock = System.Windows.Forms.DockStyle.Top;
            this.label20.Font = new System.Drawing.Font("Roboto Lt", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkGray;
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(1365, 62);
            this.label20.TabIndex = 87;
            this.label20.Text = "Settings";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuToolTip1.SetToolTip(this.label20, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label20, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label20, "");
            this.label20.Visible = false;
            // 
            // flowpanelcustomer
            // 
            this.flowpanelcustomer.AutoScroll = true;
            this.flowpanelcustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTransition1.SetDecoration(this.flowpanelcustomer, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.flowpanelcustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpanelcustomer.Location = new System.Drawing.Point(0, 0);
            this.flowpanelcustomer.Name = "flowpanelcustomer";
            this.flowpanelcustomer.Size = new System.Drawing.Size(1365, 594);
            this.flowpanelcustomer.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.flowpanelcustomer, "");
            this.bunifuToolTip1.SetToolTipIcon(this.flowpanelcustomer, null);
            this.bunifuToolTip1.SetToolTipTitle(this.flowpanelcustomer, "");
            this.flowpanelcustomer.Visible = false;
            // 
            // flowpanelproducts
            // 
            this.flowpanelproducts.AutoScroll = true;
            this.flowpanelproducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTransition1.SetDecoration(this.flowpanelproducts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.flowpanelproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpanelproducts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowpanelproducts.Location = new System.Drawing.Point(0, 0);
            this.flowpanelproducts.Name = "flowpanelproducts";
            this.flowpanelproducts.Size = new System.Drawing.Size(1365, 594);
            this.flowpanelproducts.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.flowpanelproducts, "");
            this.bunifuToolTip1.SetToolTipIcon(this.flowpanelproducts, null);
            this.bunifuToolTip1.SetToolTipTitle(this.flowpanelproducts, "");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel3);
            this.bunifuTransition1.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1705, 802);
            this.panel2.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.panel2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel2, "");
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // flowpanelproductsearch
            // 
            this.flowpanelproductsearch.AutoScroll = true;
            this.flowpanelproductsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTransition1.SetDecoration(this.flowpanelproductsearch, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.flowpanelproductsearch.Location = new System.Drawing.Point(532, 54);
            this.flowpanelproductsearch.Name = "flowpanelproductsearch";
            this.flowpanelproductsearch.Size = new System.Drawing.Size(461, 472);
            this.flowpanelproductsearch.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.flowpanelproductsearch, "");
            this.bunifuToolTip1.SetToolTipIcon(this.flowpanelproductsearch, null);
            this.bunifuToolTip1.SetToolTipTitle(this.flowpanelproductsearch, "");
            this.flowpanelproductsearch.Visible = false;
            // 
            // metroContextMenu1
            // 
            this.bunifuTransition1.SetDecoration(this.metroContextMenu1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(120, 48);
            this.metroContextMenu1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroContextMenu1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bunifuToolTip1.SetToolTip(this.metroContextMenu1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroContextMenu1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroContextMenu1, "");
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.profileToolStripMenuItem.Text = "Account";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 1500;
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPOSTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1705, 868);
            this.Controls.Add(this.flowpanelproductsearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1347, 827);
            this.Name = "FrmPOSTransaction";
            this.Text = " POS Transaction";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmPOSTransaction_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPOSTransaction_FormClosing);
            this.Load += new System.EventHandler(this.FrmPOSTransaction_Load);
            this.Resize += new System.EventHandler(this.FrmPOSTransaction_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.networkimg)).EndInit();
            this.panel24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panelaction.ResumeLayout(false);
            this.panelorder.ResumeLayout(false);
            this.panelvatsettings.ResumeLayout(false);
            this.panelvatsettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panelcustomer.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flowpaneldebt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowpanelcart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lbltitle;
        private BunifuImageButton bunifuImageButton9;
        private BunifuDragControl bunifuDragControl1;
        private Panel panel4;
        private Panel panel9;
        private Panel panel23;
        private BunifuImageButton bunifuImageButton1;
        private BunifuTransition bunifuTransition1;
        private Panel panel3;
        private Panel panel12;
        private Panel panelcustomer;
        private MetroTile metroTile15;
        private MetroTile metroTile14;
        private MetroTile metroTile16;
        private Panel panelaction;
        private MetroTile metroTile10;
        private MetroTile metroTile8;
        private MetroTile metroTile7;
        private MetroTile metroTile3;
        private MetroTile metroTile2;
        private MetroTile metroTile1;
        private Panel panelorder;
        private Panel panel7;
        private BunifuFlatButton btncustomers;
        private BunifuFlatButton btndiscounts;
        private BunifuFlatButton btnorder;
        private BunifuFlatButton btnaction;
        private Panel panel8;
        private Panel indicator;
        private Panel panel5;
        private MetroTile metroTile13;
        private MetroTile metroTile12;
        private MetroTile metroTile11;
        private MetroTile metroTile9;
        private Panel panel10;
        private Panel panel19;
        private Panel panel13;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private BunifuSeparator bunifuSeparator1;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private BunifuPictureBox bunifuPictureBox1;
        private Panel panel14;
        private Label label21;
        private Label label17;
        private Label label12;
        private Panel panel25;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label label28;
        private Panel panel26;
        private Label linediscounts;
        private Label quantity;
        private Label lblline;
        public Label lblinvoice;
        private Panel panel18;
        private Panel panel22;
        private Label total_vat;
        private Panel panel21;
        private Label VAT;
        private Panel panel20;
        private Label subtotal;
        private Panel panel16;
        private Label label15;
        private Label amntdue;
        private BunifuSeparator bunifuSeparator2;
        private Panel panel17;
        private Panel panel15;
        private Panel panel11;
        private FlowLayoutPanel flowpanelcustomer;
        private FlowLayoutPanel flowpanelproducts;
        private Panel panel2;
        private MetroTile metroTile17;
        private FlowLayoutPanel flowpanelproductsearch;
        private Tulpep.NotificationWindow.PopupNotifier popup;
        private BunifuPictureBox userpic;
        public Label lbldesignation;
        private Label lblfullname;
        private BunifuImageButton bunifuImageButton10;
        private MetroTile metroTile18;
        private MetroContextMenu metroContextMenu1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private Panel panelvatsettings;
        private Label label16;
        private BunifuiOSSwitch bunifuiOSSwitch1;
        private Label label18;
        private BunifuSeparator bunifuSeparator3;
        private BunifuiOSSwitch bunifuiOSSwitch2;
        private Label label19;
        private Label label20;
        private BunifuiOSSwitch bunifuiOSSwitch3;
        private Label label22;
        private BunifuSeparator bunifuSeparator4;
        private BunifuiOSSwitch bunifuiOSSwitch4;
        private Label label23;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private BunifuCustomDataGrid flowpanelcart;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private BunifuToolTip bunifuToolTip1;
        private BunifuImageButton bunifuImageButton2;
        private BunifuiOSSwitch bunifuiOSSwitch5;
        private Label label24;
        private Label label25;
        private Panel panel6;
        private Label lbltime;
        private Label lbldate;
        private Timer timer1;
        private Panel panel24;
        private BunifuSeparator bunifuSeparator5;
        private BunifuImageButton bunifuImageButton3;
        private Label label26;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown2;
        private BunifuTextBox bunifuTextBox1;
        private BunifuImageButton networkimg;
        private BunifuSeparator bunifuSeparator6;
        private BunifuCustomDataGrid flowpaneldebt;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}