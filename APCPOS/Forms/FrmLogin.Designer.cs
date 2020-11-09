using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuTextbox;
using MetroFramework.Controls;

namespace APCPOS.Forms
{
    partial class FrmLogin
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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation2 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton9 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtpassword = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtusername = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbodesig = new MetroFramework.Controls.MetroComboBox();
            this.bunifuTextBox7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuTextBox6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuTextBox5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTextBox3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuTextBox4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.popup = new Tulpep.NotificationWindow.PopupNotifier();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.bunifuImageButton9);
            this.panel1.Controls.Add(this.bunifuPictureBox1);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 387);
            this.panel1.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            // 
            // bunifuImageButton9
            // 
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton9.Image")));
            this.bunifuImageButton9.ImageActive = null;
            this.bunifuImageButton9.Location = new System.Drawing.Point(296, 338);
            this.bunifuImageButton9.Name = "bunifuImageButton9";
            this.bunifuImageButton9.Size = new System.Drawing.Size(56, 46);
            this.bunifuImageButton9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton9.TabIndex = 45;
            this.bunifuImageButton9.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton9, "Scan QR code for quick login");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton9, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton9, "");
            this.bunifuImageButton9.Zoom = 10;
            this.bunifuImageButton9.Click += new System.EventHandler(this.bunifuImageButton9_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 42;
            this.bunifuTransition1.SetDecoration(this.bunifuPictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(142, 73);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(84, 84);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 15;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuPictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuPictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuPictureBox1, "");
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 3;
            this.bunifuFlatButton1.ButtonText = "Sign In";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(56, 237);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(242, 43);
            this.bunifuFlatButton1.TabIndex = 14;
            this.bunifuFlatButton1.Text = "Sign In";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.bunifuFlatButton1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuFlatButton1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuFlatButton1, "");
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.AcceptsReturn = false;
            this.txtpassword.AcceptsTab = false;
            this.txtpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.txtpassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtpassword.BackgroundImage")));
            this.txtpassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.txtpassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtpassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.txtpassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.txtpassword.BorderRadius = 1;
            this.txtpassword.BorderThickness = 6;
            this.txtpassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTransition1.SetDecoration(this.txtpassword, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txtpassword.DefaultFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.DefaultText = "";
            this.txtpassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.txtpassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtpassword.HideSelection = true;
            this.txtpassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtpassword.IconLeft")));
            this.txtpassword.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtpassword.IconPadding = 10;
            this.txtpassword.IconRight = null;
            this.txtpassword.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtpassword.Location = new System.Drawing.Point(56, 196);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtpassword.Modified = false;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '●';
            this.txtpassword.ReadOnly = false;
            this.txtpassword.SelectedText = "";
            this.txtpassword.SelectionLength = 0;
            this.txtpassword.SelectionStart = 0;
            this.txtpassword.ShortcutsEnabled = true;
            this.txtpassword.Size = new System.Drawing.Size(242, 35);
            this.txtpassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtpassword.TabIndex = 2;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassword.TextMarginLeft = 5;
            this.txtpassword.TextPlaceholder = "Password";
            this.bunifuToolTip1.SetToolTip(this.txtpassword, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtpassword, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtpassword, "");
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyDown);
            // 
            // txtusername
            // 
            this.txtusername.AcceptsReturn = false;
            this.txtusername.AcceptsTab = false;
            this.txtusername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.txtusername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtusername.BackgroundImage")));
            this.txtusername.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.txtusername.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtusername.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.txtusername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.txtusername.BorderRadius = 1;
            this.txtusername.BorderThickness = 6;
            this.txtusername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTransition1.SetDecoration(this.txtusername, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txtusername.DefaultFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.DefaultText = "";
            this.txtusername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.txtusername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtusername.HideSelection = true;
            this.txtusername.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtusername.IconLeft")));
            this.txtusername.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtusername.IconPadding = 10;
            this.txtusername.IconRight = null;
            this.txtusername.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtusername.Location = new System.Drawing.Point(56, 155);
            this.txtusername.MaxLength = 32767;
            this.txtusername.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtusername.Modified = false;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.ReadOnly = false;
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.ShortcutsEnabled = true;
            this.txtusername.Size = new System.Drawing.Size(242, 35);
            this.txtusername.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtusername.TabIndex = 1;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusername.TextMarginLeft = 5;
            this.txtusername.TextPlaceholder = "User name";
            this.bunifuToolTip1.SetToolTip(this.txtusername, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtusername, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtusername, "");
            this.txtusername.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(145, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            this.bunifuToolTip1.SetToolTip(this.label1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label1, "");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.bunifuFlatButton4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.bunifuTransition1.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(357, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 389);
            this.panel2.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.panel2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel2, "");
            // 
            // bunifuImageButton1
            // 
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(264, 339);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(56, 46);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 46;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton1, "Server settings");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton1, "");
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(128, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Not Registered yet?";
            this.bunifuToolTip1.SetToolTip(this.label6, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label6, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label6, "");
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Active = false;
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 3;
            this.bunifuFlatButton4.ButtonText = "Sign Up";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(127, 294);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(225, 43);
            this.bunifuFlatButton4.TabIndex = 15;
            this.bunifuFlatButton4.Text = "Sign Up";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.bunifuFlatButton4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuFlatButton4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuFlatButton4, "");
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(53, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Point of Sale System";
            this.bunifuToolTip1.SetToolTip(this.label4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label4, "");
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox1, "");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(45, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tadeco Rd. Brgy. San  Francisco, Panabo City";
            this.bunifuToolTip1.SetToolTip(this.label3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label3, "");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(72, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "APC Green Market";
            this.bunifuToolTip1.SetToolTip(this.label2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label2, "");
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel2;
            this.bunifuDragControl2.Vertical = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.bunifuFlatButton3);
            this.panel3.Controls.Add(this.cmbodesig);
            this.panel3.Controls.Add(this.bunifuTextBox7);
            this.panel3.Controls.Add(this.bunifuTextBox6);
            this.panel3.Controls.Add(this.bunifuTextBox5);
            this.panel3.Controls.Add(this.bunifuPictureBox2);
            this.panel3.Controls.Add(this.bunifuFlatButton2);
            this.panel3.Controls.Add(this.bunifuTextBox3);
            this.panel3.Controls.Add(this.bunifuTextBox4);
            this.panel3.Controls.Add(this.label5);
            this.bunifuTransition1.SetDecoration(this.panel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 387);
            this.panel3.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.panel3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel3, "");
            this.panel3.Visible = false;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Active = false;
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 3;
            this.bunifuFlatButton3.ButtonText = "....";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(279, 108);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(63, 30);
            this.bunifuFlatButton3.TabIndex = 16;
            this.bunifuFlatButton3.Text = "....";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.bunifuFlatButton3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuFlatButton3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuFlatButton3, "");
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // cmbodesig
            // 
            this.bunifuTransition1.SetDecoration(this.cmbodesig, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.cmbodesig.FormattingEnabled = true;
            this.cmbodesig.ItemHeight = 23;
            this.cmbodesig.Items.AddRange(new object[] {
            "Sample",
            "Sample"});
            this.cmbodesig.Location = new System.Drawing.Point(13, 193);
            this.cmbodesig.Name = "cmbodesig";
            this.cmbodesig.Size = new System.Drawing.Size(253, 29);
            this.cmbodesig.Style = MetroFramework.MetroColorStyle.Green;
            this.cmbodesig.TabIndex = 6;
            this.cmbodesig.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bunifuToolTip1.SetToolTip(this.cmbodesig, "");
            this.bunifuToolTip1.SetToolTipIcon(this.cmbodesig, null);
            this.bunifuToolTip1.SetToolTipTitle(this.cmbodesig, "");
            this.cmbodesig.UseSelectable = true;
            // 
            // bunifuTextBox7
            // 
            this.bunifuTextBox7.AcceptsReturn = false;
            this.bunifuTextBox7.AcceptsTab = false;
            this.bunifuTextBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTextBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox7.BackgroundImage")));
            this.bunifuTextBox7.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuTextBox7.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBox7.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox7.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox7.BorderRadius = 1;
            this.bunifuTextBox7.BorderThickness = 6;
            this.bunifuTextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTransition1.SetDecoration(this.bunifuTextBox7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTextBox7.DefaultFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox7.DefaultText = "";
            this.bunifuTextBox7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTextBox7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuTextBox7.HideSelection = true;
            this.bunifuTextBox7.IconLeft = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox7.IconLeft")));
            this.bunifuTextBox7.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox7.IconPadding = 10;
            this.bunifuTextBox7.IconRight = null;
            this.bunifuTextBox7.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox7.Location = new System.Drawing.Point(13, 143);
            this.bunifuTextBox7.MaxLength = 20;
            this.bunifuTextBox7.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox7.Modified = false;
            this.bunifuTextBox7.Name = "bunifuTextBox7";
            this.bunifuTextBox7.PasswordChar = '\0';
            this.bunifuTextBox7.ReadOnly = false;
            this.bunifuTextBox7.SelectedText = "";
            this.bunifuTextBox7.SelectionLength = 0;
            this.bunifuTextBox7.SelectionStart = 0;
            this.bunifuTextBox7.ShortcutsEnabled = true;
            this.bunifuTextBox7.Size = new System.Drawing.Size(253, 35);
            this.bunifuTextBox7.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.bunifuTextBox7.TabIndex = 5;
            this.bunifuTextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox7.TextMarginLeft = 5;
            this.bunifuTextBox7.TextPlaceholder = "Contact number";
            this.bunifuToolTip1.SetToolTip(this.bunifuTextBox7, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuTextBox7, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuTextBox7, "");
            this.bunifuTextBox7.UseSystemPasswordChar = false;
            // 
            // bunifuTextBox6
            // 
            this.bunifuTextBox6.AcceptsReturn = false;
            this.bunifuTextBox6.AcceptsTab = false;
            this.bunifuTextBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTextBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox6.BackgroundImage")));
            this.bunifuTextBox6.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuTextBox6.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBox6.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox6.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox6.BorderRadius = 1;
            this.bunifuTextBox6.BorderThickness = 6;
            this.bunifuTextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTransition1.SetDecoration(this.bunifuTextBox6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTextBox6.DefaultFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox6.DefaultText = "";
            this.bunifuTextBox6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTextBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuTextBox6.HideSelection = true;
            this.bunifuTextBox6.IconLeft = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox6.IconLeft")));
            this.bunifuTextBox6.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox6.IconPadding = 10;
            this.bunifuTextBox6.IconRight = null;
            this.bunifuTextBox6.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox6.Location = new System.Drawing.Point(13, 102);
            this.bunifuTextBox6.MaxLength = 300;
            this.bunifuTextBox6.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox6.Modified = false;
            this.bunifuTextBox6.Name = "bunifuTextBox6";
            this.bunifuTextBox6.PasswordChar = '\0';
            this.bunifuTextBox6.ReadOnly = false;
            this.bunifuTextBox6.SelectedText = "";
            this.bunifuTextBox6.SelectionLength = 0;
            this.bunifuTextBox6.SelectionStart = 0;
            this.bunifuTextBox6.ShortcutsEnabled = true;
            this.bunifuTextBox6.Size = new System.Drawing.Size(253, 35);
            this.bunifuTextBox6.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.bunifuTextBox6.TabIndex = 4;
            this.bunifuTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox6.TextMarginLeft = 5;
            this.bunifuTextBox6.TextPlaceholder = "Address";
            this.bunifuToolTip1.SetToolTip(this.bunifuTextBox6, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuTextBox6, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuTextBox6, "");
            this.bunifuTextBox6.UseSystemPasswordChar = false;
            // 
            // bunifuTextBox5
            // 
            this.bunifuTextBox5.AcceptsReturn = false;
            this.bunifuTextBox5.AcceptsTab = false;
            this.bunifuTextBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTextBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox5.BackgroundImage")));
            this.bunifuTextBox5.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuTextBox5.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBox5.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox5.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox5.BorderRadius = 1;
            this.bunifuTextBox5.BorderThickness = 6;
            this.bunifuTextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTransition1.SetDecoration(this.bunifuTextBox5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTextBox5.DefaultFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox5.DefaultText = "";
            this.bunifuTextBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTextBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuTextBox5.HideSelection = true;
            this.bunifuTextBox5.IconLeft = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox5.IconLeft")));
            this.bunifuTextBox5.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox5.IconPadding = 10;
            this.bunifuTextBox5.IconRight = null;
            this.bunifuTextBox5.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox5.Location = new System.Drawing.Point(13, 61);
            this.bunifuTextBox5.MaxLength = 100;
            this.bunifuTextBox5.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox5.Modified = false;
            this.bunifuTextBox5.Name = "bunifuTextBox5";
            this.bunifuTextBox5.PasswordChar = '\0';
            this.bunifuTextBox5.ReadOnly = false;
            this.bunifuTextBox5.SelectedText = "";
            this.bunifuTextBox5.SelectionLength = 0;
            this.bunifuTextBox5.SelectionStart = 0;
            this.bunifuTextBox5.ShortcutsEnabled = true;
            this.bunifuTextBox5.Size = new System.Drawing.Size(253, 35);
            this.bunifuTextBox5.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.bunifuTextBox5.TabIndex = 3;
            this.bunifuTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox5.TextMarginLeft = 5;
            this.bunifuTextBox5.TextPlaceholder = "Full name";
            this.bunifuToolTip1.SetToolTip(this.bunifuTextBox5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuTextBox5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuTextBox5, "");
            this.bunifuTextBox5.UseSystemPasswordChar = false;
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.BorderRadius = 40;
            this.bunifuTransition1.SetDecoration(this.bunifuPictureBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox2.Image")));
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(272, 25);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(80, 80);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 15;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuPictureBox2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuPictureBox2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuPictureBox2, "");
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 3;
            this.bunifuFlatButton2.ButtonText = "Sign Up";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(13, 310);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(253, 41);
            this.bunifuFlatButton2.TabIndex = 14;
            this.bunifuFlatButton2.Text = "Sign Up";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.bunifuFlatButton2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuFlatButton2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuFlatButton2, "");
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuTextBox3
            // 
            this.bunifuTextBox3.AcceptsReturn = false;
            this.bunifuTextBox3.AcceptsTab = false;
            this.bunifuTextBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTextBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox3.BackgroundImage")));
            this.bunifuTextBox3.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuTextBox3.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBox3.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox3.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox3.BorderRadius = 1;
            this.bunifuTextBox3.BorderThickness = 6;
            this.bunifuTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTransition1.SetDecoration(this.bunifuTextBox3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTextBox3.DefaultFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox3.DefaultText = "";
            this.bunifuTextBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTextBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuTextBox3.HideSelection = true;
            this.bunifuTextBox3.IconLeft = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox3.IconLeft")));
            this.bunifuTextBox3.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox3.IconPadding = 10;
            this.bunifuTextBox3.IconRight = null;
            this.bunifuTextBox3.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox3.Location = new System.Drawing.Point(13, 269);
            this.bunifuTextBox3.MaxLength = 8;
            this.bunifuTextBox3.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox3.Modified = false;
            this.bunifuTextBox3.Name = "bunifuTextBox3";
            this.bunifuTextBox3.PasswordChar = '●';
            this.bunifuTextBox3.ReadOnly = false;
            this.bunifuTextBox3.SelectedText = "";
            this.bunifuTextBox3.SelectionLength = 0;
            this.bunifuTextBox3.SelectionStart = 0;
            this.bunifuTextBox3.ShortcutsEnabled = true;
            this.bunifuTextBox3.Size = new System.Drawing.Size(253, 35);
            this.bunifuTextBox3.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.bunifuTextBox3.TabIndex = 8;
            this.bunifuTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox3.TextMarginLeft = 5;
            this.bunifuTextBox3.TextPlaceholder = "Password";
            this.bunifuToolTip1.SetToolTip(this.bunifuTextBox3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuTextBox3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuTextBox3, "");
            this.bunifuTextBox3.UseSystemPasswordChar = false;
            // 
            // bunifuTextBox4
            // 
            this.bunifuTextBox4.AcceptsReturn = false;
            this.bunifuTextBox4.AcceptsTab = false;
            this.bunifuTextBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTextBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox4.BackgroundImage")));
            this.bunifuTextBox4.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuTextBox4.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBox4.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox4.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox4.BorderRadius = 1;
            this.bunifuTextBox4.BorderThickness = 6;
            this.bunifuTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTransition1.SetDecoration(this.bunifuTextBox4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTextBox4.DefaultFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox4.DefaultText = "";
            this.bunifuTextBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTextBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuTextBox4.HideSelection = true;
            this.bunifuTextBox4.IconLeft = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox4.IconLeft")));
            this.bunifuTextBox4.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox4.IconPadding = 10;
            this.bunifuTextBox4.IconRight = null;
            this.bunifuTextBox4.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox4.Location = new System.Drawing.Point(13, 228);
            this.bunifuTextBox4.MaxLength = 50;
            this.bunifuTextBox4.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox4.Modified = false;
            this.bunifuTextBox4.Name = "bunifuTextBox4";
            this.bunifuTextBox4.PasswordChar = '\0';
            this.bunifuTextBox4.ReadOnly = false;
            this.bunifuTextBox4.SelectedText = "";
            this.bunifuTextBox4.SelectionLength = 0;
            this.bunifuTextBox4.SelectionStart = 0;
            this.bunifuTextBox4.ShortcutsEnabled = true;
            this.bunifuTextBox4.Size = new System.Drawing.Size(253, 35);
            this.bunifuTextBox4.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.bunifuTextBox4.TabIndex = 7;
            this.bunifuTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox4.TextMarginLeft = 5;
            this.bunifuTextBox4.TextPlaceholder = "User name";
            this.bunifuToolTip1.SetToolTip(this.bunifuTextBox4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuTextBox4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuTextBox4, "");
            this.bunifuTextBox4.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(113, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sign Up";
            this.bunifuToolTip1.SetToolTip(this.label5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label5, "");
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Scale;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            this.bunifuTransition1.MaxAnimationTime = 1200;
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
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(680, 389);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private BunifuDragControl bunifuDragControl1;
        private BunifuDragControl bunifuDragControl2;
        private BunifuTextBox txtusername;
        private BunifuTextBox txtpassword;
        private BunifuFlatButton bunifuFlatButton1;
        private BunifuPictureBox bunifuPictureBox1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Panel panel3;
        private BunifuPictureBox bunifuPictureBox2;
        private BunifuFlatButton bunifuFlatButton2;
        private BunifuTextBox bunifuTextBox3;
        private BunifuTextBox bunifuTextBox4;
        private Label label5;
        private BunifuTextBox bunifuTextBox5;
        private BunifuTextBox bunifuTextBox7;
        private BunifuTextBox bunifuTextBox6;
        private MetroComboBox cmbodesig;
        private BunifuFlatButton bunifuFlatButton3;
        private BunifuFlatButton bunifuFlatButton4;
        private BunifuTransition bunifuTransition1;
        private Label label6;
        private Tulpep.NotificationWindow.PopupNotifier popup;
        private BunifuImageButton bunifuImageButton9;
        private BunifuToolTip bunifuToolTip1;
        private BunifuImageButton bunifuImageButton1;
    }
}