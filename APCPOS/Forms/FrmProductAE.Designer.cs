using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using MetroFramework.Controls;

namespace APCPOS.Forms
{
    partial class FrmProductAe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductAe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbltitle = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.cmbounit = new MetroFramework.Controls.MetroComboBox();
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.category = new MetroFramework.Controls.MetroComboBox();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdesciption = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.psdstartdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuTextBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuTextBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuTextBox3 = new System.Windows.Forms.NumericUpDown();
            this.bunifuTextBox4 = new System.Windows.Forms.NumericUpDown();
            this.cost = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.bunifuCheckBox2 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.dateTimePicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label12 = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuCheckBox1 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuTextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuTextBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.lbltitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 31);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(756, 6);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(21, 19);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 11;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lbltitle.Location = new System.Drawing.Point(7, 3);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(128, 25);
            this.lbltitle.TabIndex = 8;
            this.lbltitle.Text = "Product Add";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 166);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(361, 10);
            this.bunifuSeparator1.TabIndex = 10;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(9, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(9, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Unit";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(415, 145);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(213, 8);
            this.bunifuSeparator2.TabIndex = 17;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 3;
            this.bunifuFlatButton1.ButtonText = "Close";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(594, 423);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(162, 38);
            this.bunifuFlatButton1.TabIndex = 9;
            this.bunifuFlatButton1.Text = "Close";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(12, 413);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(744, 8);
            this.bunifuSeparator3.TabIndex = 19;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = true;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 3;
            this.bunifuFlatButton2.ButtonText = "Save";
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(324, 423);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = true;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(264, 38);
            this.bunifuFlatButton2.TabIndex = 8;
            this.bunifuFlatButton2.Text = "Save";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Active = false;
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 3;
            this.bunifuFlatButton3.ButtonText = "...";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.bunifuFlatButton3.Location = new System.Drawing.Point(637, 178);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(119, 35);
            this.bunifuFlatButton3.TabIndex = 7;
            this.bunifuFlatButton3.Text = "...";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // cmbounit
            // 
            this.cmbounit.FormattingEnabled = true;
            this.cmbounit.ItemHeight = 23;
            this.cmbounit.Location = new System.Drawing.Point(12, 354);
            this.cmbounit.Name = "cmbounit";
            this.cmbounit.Size = new System.Drawing.Size(360, 29);
            this.cmbounit.Style = MetroFramework.MetroColorStyle.Orange;
            this.cmbounit.TabIndex = 4;
            this.cmbounit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbounit.UseSelectable = true;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Production start date";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.ItemHeight = 23;
            this.category.Location = new System.Drawing.Point(12, 300);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(361, 29);
            this.category.Style = MetroFramework.MetroColorStyle.Orange;
            this.category.TabIndex = 4;
            this.category.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.category.UseSelectable = true;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(12, 263);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(361, 10);
            this.bunifuSeparator4.TabIndex = 26;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(6, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Category";
            // 
            // txtdesciption
            // 
            this.txtdesciption.BackColor = System.Drawing.Color.White;
            this.txtdesciption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdesciption.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesciption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdesciption.Location = new System.Drawing.Point(418, 235);
            this.txtdesciption.MaxLength = 1999;
            this.txtdesciption.Multiline = true;
            this.txtdesciption.Name = "txtdesciption";
            this.txtdesciption.Size = new System.Drawing.Size(334, 106);
            this.txtdesciption.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(415, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Product Description";
            // 
            // psdstartdate
            // 
            this.psdstartdate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.psdstartdate.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psdstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.psdstartdate.Location = new System.Drawing.Point(12, 67);
            this.psdstartdate.Name = "psdstartdate";
            this.psdstartdate.Size = new System.Drawing.Size(360, 26);
            this.psdstartdate.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(9, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Available for sale?";
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTextBox1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox1.ForeColor = System.Drawing.Color.White;
            this.bunifuTextBox1.Location = new System.Drawing.Point(143, 190);
            this.bunifuTextBox1.MaxLength = 500;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            this.bunifuTextBox1.Size = new System.Drawing.Size(229, 19);
            this.bunifuTextBox1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(9, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Product name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(9, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "Barcode Number:";
            // 
            // bunifuTextBox2
            // 
            this.bunifuTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTextBox2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox2.ForeColor = System.Drawing.Color.White;
            this.bunifuTextBox2.Location = new System.Drawing.Point(143, 215);
            this.bunifuTextBox2.MaxLength = 1000;
            this.bunifuTextBox2.Name = "bunifuTextBox2";
            this.bunifuTextBox2.Size = new System.Drawing.Size(229, 19);
            this.bunifuTextBox2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(9, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 18);
            this.label9.TabIndex = 37;
            this.label9.Tag = "";
            this.label9.Text = "Available stock:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(412, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 18);
            this.label10.TabIndex = 39;
            this.label10.Tag = "";
            this.label10.Text = "Unit price:";
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator5.LineThickness = 1;
            this.bunifuSeparator5.Location = new System.Drawing.Point(415, 205);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(213, 8);
            this.bunifuSeparator5.TabIndex = 40;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = false;
            // 
            // bunifuTextBox3
            // 
            this.bunifuTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTextBox3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox3.ForeColor = System.Drawing.Color.White;
            this.bunifuTextBox3.Location = new System.Drawing.Point(143, 240);
            this.bunifuTextBox3.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.bunifuTextBox3.Name = "bunifuTextBox3";
            this.bunifuTextBox3.Size = new System.Drawing.Size(229, 19);
            this.bunifuTextBox3.TabIndex = 41;
            this.bunifuTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuTextBox4
            // 
            this.bunifuTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTextBox4.DecimalPlaces = 2;
            this.bunifuTextBox4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox4.ForeColor = System.Drawing.Color.White;
            this.bunifuTextBox4.Location = new System.Drawing.Point(496, 185);
            this.bunifuTextBox4.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.bunifuTextBox4.Name = "bunifuTextBox4";
            this.bunifuTextBox4.Size = new System.Drawing.Size(132, 19);
            this.bunifuTextBox4.TabIndex = 42;
            this.bunifuTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuTextBox4.ThousandsSeparator = true;
            // 
            // cost
            // 
            this.cost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.cost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cost.DecimalPlaces = 2;
            this.cost.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost.ForeColor = System.Drawing.Color.White;
            this.cost.Location = new System.Drawing.Point(496, 159);
            this.cost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(132, 19);
            this.cost.TabIndex = 44;
            this.cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cost.ThousandsSeparator = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(412, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 18);
            this.label11.TabIndex = 43;
            this.label11.Tag = "";
            this.label11.Text = "Cost:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.bunifuCheckBox2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.cost);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.bunifuTextBox4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bunifuTextBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bunifuSeparator5);
            this.panel2.Controls.Add(this.bunifuSeparator2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.bunifuSeparator3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.bunifuFlatButton2);
            this.panel2.Controls.Add(this.bunifuTextBox2);
            this.panel2.Controls.Add(this.bunifuPictureBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.bunifuFlatButton3);
            this.panel2.Controls.Add(this.bunifuTextBox1);
            this.panel2.Controls.Add(this.cmbounit);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.bunifuCheckBox1);
            this.panel2.Controls.Add(this.bunifuSeparator4);
            this.panel2.Controls.Add(this.psdstartdate);
            this.panel2.Controls.Add(this.category);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtdesciption);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 472);
            this.panel2.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(9, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 18);
            this.label13.TabIndex = 48;
            this.label13.Text = "Has Expi. date?";
            // 
            // bunifuCheckBox2
            // 
            this.bunifuCheckBox2.AllowBindingControlAnimation = true;
            this.bunifuCheckBox2.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox2.AllowBindingControlLocation = true;
            this.bunifuCheckBox2.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox2.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox2.AllowOnHoverStates = true;
            this.bunifuCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox2.BackgroundImage")));
            this.bunifuCheckBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox2.BindingControl = null;
            this.bunifuCheckBox2.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox2.Checked = true;
            this.bunifuCheckBox2.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCheckBox2.CustomCheckmarkImage = null;
            this.bunifuCheckBox2.Location = new System.Drawing.Point(142, 124);
            this.bunifuCheckBox2.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox2.Name = "bunifuCheckBox2";
            this.bunifuCheckBox2.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuCheckBox2.OnCheck.BorderRadius = 2;
            this.bunifuCheckBox2.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox2.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuCheckBox2.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox2.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox2.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox2.OnDisable.BorderRadius = 2;
            this.bunifuCheckBox2.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox2.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox2.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox2.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox2.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuCheckBox2.OnHoverChecked.BorderRadius = 2;
            this.bunifuCheckBox2.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox2.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuCheckBox2.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox2.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox2.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuCheckBox2.OnHoverUnchecked.BorderRadius = 2;
            this.bunifuCheckBox2.OnHoverUnchecked.BorderThickness = 2;
            this.bunifuCheckBox2.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox2.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuCheckBox2.OnUncheck.BorderRadius = 2;
            this.bunifuCheckBox2.OnUncheck.BorderThickness = 2;
            this.bunifuCheckBox2.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox2.Size = new System.Drawing.Size(21, 21);
            this.bunifuCheckBox2.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox2.TabIndex = 47;
            this.bunifuCheckBox2.ThreeState = false;
            this.bunifuCheckBox2.ToolTipText = null;
            this.bunifuCheckBox2.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.bunifuCheckBox2_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.dateTimePicker1.BorderRadius = 0;
            this.dateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker1.FormatCustom = null;
            this.dateTimePicker1.Location = new System.Drawing.Point(418, 379);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(333, 28);
            this.dateTimePicker1.TabIndex = 46;
            this.dateTimePicker1.Value = new System.DateTime(2020, 6, 3, 14, 57, 44, 550);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(415, 354);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 18);
            this.label12.TabIndex = 45;
            this.label12.Text = "Expiration date:";
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 59;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(637, 53);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(119, 119);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 21;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // bunifuCheckBox1
            // 
            this.bunifuCheckBox1.AllowBindingControlAnimation = true;
            this.bunifuCheckBox1.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox1.AllowBindingControlLocation = true;
            this.bunifuCheckBox1.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox1.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox1.AllowOnHoverStates = true;
            this.bunifuCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox1.BackgroundImage")));
            this.bunifuCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox1.BindingControl = null;
            this.bunifuCheckBox1.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox1.Checked = true;
            this.bunifuCheckBox1.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCheckBox1.CustomCheckmarkImage = null;
            this.bunifuCheckBox1.Location = new System.Drawing.Point(143, 97);
            this.bunifuCheckBox1.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox1.Name = "bunifuCheckBox1";
            this.bunifuCheckBox1.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuCheckBox1.OnCheck.BorderRadius = 2;
            this.bunifuCheckBox1.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuCheckBox1.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.BorderRadius = 2;
            this.bunifuCheckBox1.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuCheckBox1.OnHoverChecked.BorderRadius = 2;
            this.bunifuCheckBox1.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuCheckBox1.OnHoverUnchecked.BorderRadius = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.bunifuCheckBox1.OnUncheck.BorderRadius = 2;
            this.bunifuCheckBox1.OnUncheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.Size = new System.Drawing.Size(21, 21);
            this.bunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox1.TabIndex = 30;
            this.bunifuCheckBox1.ThreeState = false;
            this.bunifuCheckBox1.ToolTipText = null;
            this.bunifuCheckBox1.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.bunifuCheckBox1_CheckedChanged);
            // 
            // FrmProductAe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(782, 474);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductAe";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmProductAE";
            this.Load += new System.EventHandler(this.FrmProductAe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuTextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuTextBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private BunifuSeparator bunifuSeparator1;
        private BunifuSeparator bunifuSeparator2;
        private Label label3;
        private BunifuFlatButton bunifuFlatButton2;
        private BunifuSeparator bunifuSeparator3;
        private BunifuFlatButton bunifuFlatButton1;
        private BunifuFlatButton bunifuFlatButton3;
        private BunifuPictureBox bunifuPictureBox1;
        private BunifuImageButton bunifuImageButton2;
        private BunifuDragControl bunifuDragControl1;
        public Label lbltitle;
        private MetroComboBox cmbounit;
        private BunifuFormFadeTransition bunifuFormFadeTransition1;
        private Label label1;
        private MetroComboBox category;
        private BunifuSeparator bunifuSeparator4;
        private Label label4;
        private Label label5;
        private TextBox txtdesciption;
        private DateTimePicker psdstartdate;
        private BunifuCheckBox bunifuCheckBox1;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox bunifuTextBox2;
        private Label label7;
        private TextBox bunifuTextBox1;
        private BunifuSeparator bunifuSeparator5;
        private NumericUpDown bunifuTextBox3;
        private NumericUpDown bunifuTextBox4;
        private NumericUpDown cost;
        private Label label11;
        private Panel panel2;
        private Label label12;
        private BunifuDatepicker dateTimePicker1;
        private Label label13;
        private BunifuCheckBox bunifuCheckBox2;
    }
}