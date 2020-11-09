namespace APCPOS.Forms
{
    partial class FrmServerSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServerSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.txtusername = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtpassword = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label25 = new System.Windows.Forms.Label();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtipaddress = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.metroTabControl1);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.bunifuFlatButton2);
            this.panel1.Controls.Add(this.txtipaddress);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 389);
            this.panel1.TabIndex = 61;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(436, 108);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(25, 29);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 49;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton3, "Contact Server");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton3, "");
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(11, 169);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(482, 150);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 48;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bunifuToolTip1.SetToolTip(this.metroTabControl1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroTabControl1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroTabControl1, "");
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.metroTabPage1.Controls.Add(this.txtusername);
            this.metroTabPage1.Controls.Add(this.txtpassword);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(474, 108);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Database configuration";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bunifuToolTip1.SetToolTip(this.metroTabPage1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroTabPage1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroTabPage1, "");
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // txtusername
            // 
            this.txtusername.AcceptsReturn = false;
            this.txtusername.AcceptsTab = false;
            this.txtusername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.txtusername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtusername.BackgroundImage")));
            this.txtusername.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.txtusername.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtusername.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(120)))));
            this.txtusername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(106)))), ((int)(((byte)(110)))));
            this.txtusername.BorderRadius = 1;
            this.txtusername.BorderThickness = 6;
            this.txtusername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtusername.DefaultFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.DefaultText = "";
            this.txtusername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.txtusername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtusername.HideSelection = true;
            this.txtusername.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtusername.IconLeft")));
            this.txtusername.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtusername.IconPadding = 10;
            this.txtusername.IconRight = null;
            this.txtusername.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtusername.Location = new System.Drawing.Point(15, 13);
            this.txtusername.MaxLength = 32767;
            this.txtusername.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtusername.Modified = false;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '●';
            this.txtusername.ReadOnly = false;
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.ShortcutsEnabled = false;
            this.txtusername.Size = new System.Drawing.Size(443, 35);
            this.txtusername.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtusername.TabIndex = 1;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtusername.TextMarginLeft = 5;
            this.txtusername.TextPlaceholder = "User name";
            this.bunifuToolTip1.SetToolTip(this.txtusername, "Database user id");
            this.bunifuToolTip1.SetToolTipIcon(this.txtusername, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtusername, "");
            this.txtusername.UseSystemPasswordChar = true;
            // 
            // txtpassword
            // 
            this.txtpassword.AcceptsReturn = false;
            this.txtpassword.AcceptsTab = false;
            this.txtpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.txtpassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtpassword.BackgroundImage")));
            this.txtpassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.txtpassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtpassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(120)))));
            this.txtpassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(106)))), ((int)(((byte)(110)))));
            this.txtpassword.BorderRadius = 1;
            this.txtpassword.BorderThickness = 6;
            this.txtpassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtpassword.DefaultFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.DefaultText = "";
            this.txtpassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.txtpassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtpassword.HideSelection = true;
            this.txtpassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtpassword.IconLeft")));
            this.txtpassword.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtpassword.IconPadding = 10;
            this.txtpassword.IconRight = null;
            this.txtpassword.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtpassword.Location = new System.Drawing.Point(15, 54);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtpassword.Modified = false;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '●';
            this.txtpassword.ReadOnly = false;
            this.txtpassword.SelectedText = "";
            this.txtpassword.SelectionLength = 0;
            this.txtpassword.SelectionStart = 0;
            this.txtpassword.ShortcutsEnabled = false;
            this.txtpassword.Size = new System.Drawing.Size(443, 35);
            this.txtpassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtpassword.TabIndex = 2;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpassword.TextMarginLeft = 5;
            this.txtpassword.TextPlaceholder = "Password";
            this.bunifuToolTip1.SetToolTip(this.txtpassword, "Database password");
            this.bunifuToolTip1.SetToolTipIcon(this.txtpassword, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtpassword, "");
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(8, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(33, 31);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 47;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton1, "");
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(480, 3);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(21, 19);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 21;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton2, "Close");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton2, "");
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.DimGray;
            this.label25.Location = new System.Drawing.Point(47, 37);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(383, 34);
            this.label25.TabIndex = 20;
            this.label25.Text = "Please ensure that IP Address and all specified configuration has been\r\nset-up su" +
    "ccessfully.";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label25, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label25, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label25, "");
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 3;
            this.bunifuFlatButton2.ButtonText = "Close";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(304, 325);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(189, 43);
            this.bunifuFlatButton2.TabIndex = 16;
            this.bunifuFlatButton2.Text = "Close";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.bunifuFlatButton2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuFlatButton2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuFlatButton2, "");
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // txtipaddress
            // 
            this.txtipaddress.AcceptsReturn = false;
            this.txtipaddress.AcceptsTab = false;
            this.txtipaddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtipaddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtipaddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.txtipaddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtipaddress.BackgroundImage")));
            this.txtipaddress.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.txtipaddress.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtipaddress.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(120)))));
            this.txtipaddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(106)))), ((int)(((byte)(110)))));
            this.txtipaddress.BorderRadius = 1;
            this.txtipaddress.BorderThickness = 6;
            this.txtipaddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtipaddress.DefaultFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtipaddress.DefaultText = "";
            this.txtipaddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.txtipaddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtipaddress.HideSelection = true;
            this.txtipaddress.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtipaddress.IconLeft")));
            this.txtipaddress.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtipaddress.IconPadding = 10;
            this.txtipaddress.IconRight = null;
            this.txtipaddress.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtipaddress.Location = new System.Drawing.Point(50, 105);
            this.txtipaddress.MaxLength = 32767;
            this.txtipaddress.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtipaddress.Modified = false;
            this.txtipaddress.Name = "txtipaddress";
            this.txtipaddress.PasswordChar = '\0';
            this.txtipaddress.ReadOnly = false;
            this.txtipaddress.SelectedText = "";
            this.txtipaddress.SelectionLength = 0;
            this.txtipaddress.SelectionStart = 0;
            this.txtipaddress.ShortcutsEnabled = true;
            this.txtipaddress.Size = new System.Drawing.Size(380, 35);
            this.txtipaddress.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtipaddress.TabIndex = 0;
            this.txtipaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtipaddress.TextMarginLeft = 5;
            this.txtipaddress.TextPlaceholder = "IP Address";
            this.bunifuToolTip1.SetToolTip(this.txtipaddress, "Server address");
            this.bunifuToolTip1.SetToolTipIcon(this.txtipaddress, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtipaddress, "");
            this.txtipaddress.UseSystemPasswordChar = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 3;
            this.bunifuFlatButton1.ButtonText = "Test and Save";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(109, 325);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(189, 43);
            this.bunifuFlatButton1.TabIndex = 14;
            this.bunifuFlatButton1.Text = "Test and Save";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.bunifuFlatButton1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuFlatButton1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuFlatButton1, "");
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(45, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Settings";
            this.bunifuToolTip1.SetToolTip(this.label1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label1, "");
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
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FrmServerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(506, 391);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmServerSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmServerSettings";
            this.Load += new System.EventHandler(this.FrmServerSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtipaddress;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtpassword;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtusername;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Label label25;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
    }
}