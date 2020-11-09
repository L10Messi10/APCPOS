using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework.Controls;

namespace APCPOS.Forms
{
    partial class FrmPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPayments));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton9 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroTile12 = new MetroFramework.Controls.MetroTile();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblchange = new System.Windows.Forms.Label();
            this.lblpayment = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label28 = new System.Windows.Forms.Label();
            this.lblinvoice = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblamntdue = new System.Windows.Forms.Label();
            this.lbltotaltax = new System.Windows.Forms.Label();
            this.lbltax = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton13 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton11 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton12 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton9 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popup = new Tulpep.NotificationWindow.PopupNotifier();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel14.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1369, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(317, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1052, 49);
            this.label1.TabIndex = 10;
            this.label1.Text = "Payments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuImageButton9);
            this.panel2.Controls.Add(this.lbltitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 49);
            this.panel2.TabIndex = 1;
            // 
            // bunifuImageButton9
            // 
            this.bunifuImageButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton9.Image")));
            this.bunifuImageButton9.ImageActive = null;
            this.bunifuImageButton9.Location = new System.Drawing.Point(3, 3);
            this.bunifuImageButton9.Name = "bunifuImageButton9";
            this.bunifuImageButton9.Size = new System.Drawing.Size(44, 42);
            this.bunifuImageButton9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton9.TabIndex = 13;
            this.bunifuImageButton9.TabStop = false;
            this.bunifuImageButton9.Zoom = 10;
            this.bunifuImageButton9.Click += new System.EventHandler(this.bunifuImageButton9_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lbltitle.Location = new System.Drawing.Point(50, 12);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(57, 25);
            this.lbltitle.TabIndex = 9;
            this.lbltitle.Text = "Back";
            this.lbltitle.Click += new System.EventHandler(this.lbltitle_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.metroTile12);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 743);
            this.panel3.TabIndex = 1;
            // 
            // metroTile12
            // 
            this.metroTile12.ActiveControl = null;
            this.metroTile12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.metroTile12.Location = new System.Drawing.Point(12, 548);
            this.metroTile12.Name = "metroTile12";
            this.metroTile12.Size = new System.Drawing.Size(380, 89);
            this.metroTile12.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile12.TabIndex = 38;
            this.metroTile12.Text = "Ctrl+S";
            this.metroTile12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile12.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile12.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile12.TileImage")));
            this.metroTile12.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile12.UseCustomBackColor = true;
            this.metroTile12.UseSelectable = true;
            this.metroTile12.UseTileImage = true;
            this.metroTile12.Click += new System.EventHandler(this.printReceiptToolStripMenuItem_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.label22);
            this.panel7.Controls.Add(this.label24);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 453);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(403, 89);
            this.panel7.TabIndex = 37;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblchange);
            this.panel8.Controls.Add(this.lblpayment);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(124, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(279, 89);
            this.panel8.TabIndex = 37;
            // 
            // lblchange
            // 
            this.lblchange.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblchange.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblchange.Location = new System.Drawing.Point(0, 29);
            this.lblchange.Name = "lblchange";
            this.lblchange.Size = new System.Drawing.Size(279, 29);
            this.lblchange.TabIndex = 33;
            this.lblchange.Text = "0";
            this.lblchange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblpayment
            // 
            this.lblpayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblpayment.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblpayment.Location = new System.Drawing.Point(0, 0);
            this.lblpayment.Name = "lblpayment";
            this.lblpayment.Size = new System.Drawing.Size(279, 29);
            this.lblpayment.TabIndex = 32;
            this.lblpayment.Text = "0";
            this.lblpayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label22.Location = new System.Drawing.Point(15, 5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 18);
            this.label22.TabIndex = 35;
            this.label22.Text = "PAYMENTS";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label24.Location = new System.Drawing.Point(13, 34);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(66, 18);
            this.label24.TabIndex = 36;
            this.label24.Text = "CHANGE";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bunifuSeparator2);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.lblinvoice);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.bunifuSeparator1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(403, 453);
            this.panel4.TabIndex = 2;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(12, 37);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(366, 8);
            this.bunifuSeparator2.TabIndex = 22;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(149)))));
            this.label28.Location = new System.Drawing.Point(12, 13);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(49, 18);
            this.label28.TabIndex = 21;
            this.label28.Text = "INV. #";
            // 
            // lblinvoice
            // 
            this.lblinvoice.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(149)))));
            this.lblinvoice.Location = new System.Drawing.Point(124, 10);
            this.lblinvoice.Name = "lblinvoice";
            this.lblinvoice.Size = new System.Drawing.Size(254, 24);
            this.lblinvoice.TabIndex = 20;
            this.lblinvoice.Text = "###";
            this.lblinvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 184);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(403, 269);
            this.panel5.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label12.Location = new System.Drawing.Point(13, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 18);
            this.label12.TabIndex = 33;
            this.label12.Text = "Total VAT";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label15.Location = new System.Drawing.Point(12, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 18);
            this.label15.TabIndex = 20;
            this.label15.Text = "AMOUNT DUE";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label21.Location = new System.Drawing.Point(13, 29);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 18);
            this.label21.TabIndex = 30;
            this.label21.Text = "TAX";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label17.Location = new System.Drawing.Point(13, 1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 18);
            this.label17.TabIndex = 29;
            this.label17.Text = "SUBTOTAL";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblamntdue);
            this.panel6.Controls.Add(this.lbltotaltax);
            this.panel6.Controls.Add(this.lbltax);
            this.panel6.Controls.Add(this.lblsubtotal);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(124, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(279, 269);
            this.panel6.TabIndex = 17;
            // 
            // lblamntdue
            // 
            this.lblamntdue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblamntdue.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamntdue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.lblamntdue.Location = new System.Drawing.Point(0, 233);
            this.lblamntdue.Name = "lblamntdue";
            this.lblamntdue.Size = new System.Drawing.Size(279, 36);
            this.lblamntdue.TabIndex = 21;
            this.lblamntdue.Text = " $ 234.56";
            this.lblamntdue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltotaltax
            // 
            this.lbltotaltax.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltotaltax.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaltax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lbltotaltax.Location = new System.Drawing.Point(0, 58);
            this.lbltotaltax.Name = "lbltotaltax";
            this.lbltotaltax.Size = new System.Drawing.Size(279, 29);
            this.lbltotaltax.TabIndex = 32;
            this.lbltotaltax.Text = "SUBTOTAL";
            this.lbltotaltax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltax
            // 
            this.lbltax.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltax.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lbltax.Location = new System.Drawing.Point(0, 29);
            this.lbltax.Name = "lbltax";
            this.lbltax.Size = new System.Drawing.Size(279, 29);
            this.lbltax.TabIndex = 31;
            this.lbltax.Text = "SUBTOTAL";
            this.lbltax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblsubtotal.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblsubtotal.Location = new System.Drawing.Point(0, 0);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(279, 29);
            this.lblsubtotal.TabIndex = 30;
            this.lblsubtotal.Text = "SUBTOTAL";
            this.lblsubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 149);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(366, 8);
            this.bunifuSeparator1.TabIndex = 15;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Transacted by:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Loyal name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Transaction date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.label3.Location = new System.Drawing.Point(11, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Loyal name";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.numericUpDown1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(403, 49);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(966, 122);
            this.panel9.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(0, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(966, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Insufficient  amount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDown1.Font = new System.Drawing.Font("Bookman Old Style", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.Snow;
            this.numericUpDown1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(966, 76);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Text = "0";
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.TextChanged += new System.EventHandler(this.numericUpDown1_TextChanged);
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(403, 171);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(966, 621);
            this.panel10.TabIndex = 3;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel14.Controls.Add(this.bunifuFlatButton13);
            this.panel14.Controls.Add(this.bunifuFlatButton11);
            this.panel14.Controls.Add(this.bunifuFlatButton12);
            this.panel14.Controls.Add(this.bunifuFlatButton7);
            this.panel14.Controls.Add(this.bunifuFlatButton8);
            this.panel14.Controls.Add(this.bunifuFlatButton9);
            this.panel14.Controls.Add(this.bunifuFlatButton4);
            this.panel14.Controls.Add(this.bunifuFlatButton5);
            this.panel14.Controls.Add(this.bunifuFlatButton6);
            this.panel14.Controls.Add(this.bunifuFlatButton3);
            this.panel14.Controls.Add(this.bunifuFlatButton1);
            this.panel14.Controls.Add(this.bunifuFlatButton2);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(273, 36);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(578, 585);
            this.panel14.TabIndex = 7;
            // 
            // bunifuFlatButton13
            // 
            this.bunifuFlatButton13.Active = true;
            this.bunifuFlatButton13.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton13.BackgroundImage")));
            this.bunifuFlatButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton13.BorderRadius = 0;
            this.bunifuFlatButton13.ButtonText = "";
            this.bunifuFlatButton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton13.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton13.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton13.Iconimage = null;
            this.bunifuFlatButton13.Iconimage_right = null;
            this.bunifuFlatButton13.Iconimage_right_Selected = null;
            this.bunifuFlatButton13.Iconimage_Selected = null;
            this.bunifuFlatButton13.IconMarginLeft = 0;
            this.bunifuFlatButton13.IconMarginRight = 0;
            this.bunifuFlatButton13.IconRightVisible = true;
            this.bunifuFlatButton13.IconRightZoom = 0D;
            this.bunifuFlatButton13.IconVisible = true;
            this.bunifuFlatButton13.IconZoom = 90D;
            this.bunifuFlatButton13.IsTab = false;
            this.bunifuFlatButton13.Location = new System.Drawing.Point(384, 354);
            this.bunifuFlatButton13.Name = "bunifuFlatButton13";
            this.bunifuFlatButton13.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton13.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton13.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton13.selected = true;
            this.bunifuFlatButton13.Size = new System.Drawing.Size(183, 109);
            this.bunifuFlatButton13.TabIndex = 14;
            this.bunifuFlatButton13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton13.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton13.TextFont = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton13.Click += new System.EventHandler(this.bunifuFlatButton13_Click);
            // 
            // bunifuFlatButton11
            // 
            this.bunifuFlatButton11.Active = true;
            this.bunifuFlatButton11.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton11.BorderRadius = 0;
            this.bunifuFlatButton11.ButtonText = "00";
            this.bunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton11.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.Iconimage = null;
            this.bunifuFlatButton11.Iconimage_right = null;
            this.bunifuFlatButton11.Iconimage_right_Selected = null;
            this.bunifuFlatButton11.Iconimage_Selected = null;
            this.bunifuFlatButton11.IconMarginLeft = 0;
            this.bunifuFlatButton11.IconMarginRight = 0;
            this.bunifuFlatButton11.IconRightVisible = true;
            this.bunifuFlatButton11.IconRightZoom = 0D;
            this.bunifuFlatButton11.IconVisible = true;
            this.bunifuFlatButton11.IconZoom = 90D;
            this.bunifuFlatButton11.IsTab = false;
            this.bunifuFlatButton11.Location = new System.Drawing.Point(195, 354);
            this.bunifuFlatButton11.Name = "bunifuFlatButton11";
            this.bunifuFlatButton11.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton11.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton11.selected = true;
            this.bunifuFlatButton11.Size = new System.Drawing.Size(183, 109);
            this.bunifuFlatButton11.TabIndex = 12;
            this.bunifuFlatButton11.Text = "00";
            this.bunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton11.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton11.TextFont = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton11.Click += new System.EventHandler(this.button_click);
            // 
            // bunifuFlatButton12
            // 
            this.bunifuFlatButton12.Active = true;
            this.bunifuFlatButton12.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton12.BorderRadius = 0;
            this.bunifuFlatButton12.ButtonText = "0";
            this.bunifuFlatButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton12.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton12.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton12.Iconimage = null;
            this.bunifuFlatButton12.Iconimage_right = null;
            this.bunifuFlatButton12.Iconimage_right_Selected = null;
            this.bunifuFlatButton12.Iconimage_Selected = null;
            this.bunifuFlatButton12.IconMarginLeft = 0;
            this.bunifuFlatButton12.IconMarginRight = 0;
            this.bunifuFlatButton12.IconRightVisible = true;
            this.bunifuFlatButton12.IconRightZoom = 0D;
            this.bunifuFlatButton12.IconVisible = true;
            this.bunifuFlatButton12.IconZoom = 90D;
            this.bunifuFlatButton12.IsTab = false;
            this.bunifuFlatButton12.Location = new System.Drawing.Point(6, 354);
            this.bunifuFlatButton12.Name = "bunifuFlatButton12";
            this.bunifuFlatButton12.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton12.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton12.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton12.selected = true;
            this.bunifuFlatButton12.Size = new System.Drawing.Size(183, 109);
            this.bunifuFlatButton12.TabIndex = 11;
            this.bunifuFlatButton12.Text = "0";
            this.bunifuFlatButton12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton12.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton12.TextFont = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton12.Click += new System.EventHandler(this.button_click);
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Active = true;
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "9";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = null;
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 90D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(384, 239);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = true;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(183, 109);
            this.bunifuFlatButton7.TabIndex = 10;
            this.bunifuFlatButton7.Text = "9";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton7.Click += new System.EventHandler(this.button_click);
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Active = true;
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "8";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = null;
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 90D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(195, 239);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = true;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(183, 109);
            this.bunifuFlatButton8.TabIndex = 9;
            this.bunifuFlatButton8.Text = "8";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.Click += new System.EventHandler(this.button_click);
            // 
            // bunifuFlatButton9
            // 
            this.bunifuFlatButton9.Active = true;
            this.bunifuFlatButton9.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton9.BorderRadius = 0;
            this.bunifuFlatButton9.ButtonText = "7";
            this.bunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.Iconimage = null;
            this.bunifuFlatButton9.Iconimage_right = null;
            this.bunifuFlatButton9.Iconimage_right_Selected = null;
            this.bunifuFlatButton9.Iconimage_Selected = null;
            this.bunifuFlatButton9.IconMarginLeft = 0;
            this.bunifuFlatButton9.IconMarginRight = 0;
            this.bunifuFlatButton9.IconRightVisible = true;
            this.bunifuFlatButton9.IconRightZoom = 0D;
            this.bunifuFlatButton9.IconVisible = true;
            this.bunifuFlatButton9.IconZoom = 90D;
            this.bunifuFlatButton9.IsTab = false;
            this.bunifuFlatButton9.Location = new System.Drawing.Point(6, 239);
            this.bunifuFlatButton9.Name = "bunifuFlatButton9";
            this.bunifuFlatButton9.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton9.selected = true;
            this.bunifuFlatButton9.Size = new System.Drawing.Size(183, 109);
            this.bunifuFlatButton9.TabIndex = 8;
            this.bunifuFlatButton9.Text = "7";
            this.bunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton9.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton9.TextFont = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton9.Click += new System.EventHandler(this.button_click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Active = true;
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "6";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.bunifuFlatButton4.Location = new System.Drawing.Point(384, 124);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = true;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(183, 109);
            this.bunifuFlatButton4.TabIndex = 7;
            this.bunifuFlatButton4.Text = "6";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.button_click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Active = true;
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "5";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = null;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(195, 124);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = true;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(183, 109);
            this.bunifuFlatButton5.TabIndex = 6;
            this.bunifuFlatButton5.Text = "5";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.button_click);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Active = true;
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "4";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = null;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(6, 124);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = true;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(183, 109);
            this.bunifuFlatButton6.TabIndex = 5;
            this.bunifuFlatButton6.Text = "4";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.button_click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Active = true;
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "3";
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
            this.bunifuFlatButton3.Location = new System.Drawing.Point(384, 9);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = true;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(183, 109);
            this.bunifuFlatButton3.TabIndex = 4;
            this.bunifuFlatButton3.Text = "3";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.button_click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = true;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "2";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(195, 9);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = true;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(183, 109);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.Text = "2";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.button_click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = true;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "1";
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(6, 9);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = true;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(183, 109);
            this.bunifuFlatButton2.TabIndex = 2;
            this.bunifuFlatButton2.Text = "1";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.button_click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(273, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(578, 36);
            this.panel13.TabIndex = 6;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(851, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(115, 621);
            this.panel12.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(273, 621);
            this.panel11.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1369, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printReceiptToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printReceiptToolStripMenuItem
            // 
            this.printReceiptToolStripMenuItem.Name = "printReceiptToolStripMenuItem";
            this.printReceiptToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.printReceiptToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.printReceiptToolStripMenuItem.Text = "Print Receipt";
            this.printReceiptToolStripMenuItem.Click += new System.EventHandler(this.printReceiptToolStripMenuItem_Click);
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
            // FrmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1369, 792);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPayments";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPayments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPayments_Load);
            this.Resize += new System.EventHandler(this.FrmPayments_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lbltitle;
        private BunifuImageButton bunifuImageButton9;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label label3;
        private Timer timer1;
        private Label label4;
        private Label label5;
        private BunifuSeparator bunifuSeparator1;
        private Panel panel5;
        private Panel panel6;
        private Label label12;
        private Label label21;
        private Label label17;
        private Label label22;
        private Label label24;
        private Label label15;
        private Panel panel7;
        private Panel panel8;
        private Label lblchange;
        private Label lblpayment;
        private Panel panel9;
        private Panel panel10;
        private Panel panel14;
        private Panel panel13;
        private Panel panel12;
        private Panel panel11;
        private BunifuFlatButton bunifuFlatButton11;
        private BunifuFlatButton bunifuFlatButton12;
        private BunifuFlatButton bunifuFlatButton7;
        private BunifuFlatButton bunifuFlatButton8;
        private BunifuFlatButton bunifuFlatButton9;
        private BunifuFlatButton bunifuFlatButton4;
        private BunifuFlatButton bunifuFlatButton5;
        private BunifuFlatButton bunifuFlatButton6;
        private BunifuFlatButton bunifuFlatButton3;
        private BunifuFlatButton bunifuFlatButton1;
        private BunifuFlatButton bunifuFlatButton2;
        private BunifuSeparator bunifuSeparator2;
        private Label label28;
        public Label lblinvoice;
        public Label lbltotaltax;
        public Label lbltax;
        public Label lblsubtotal;
        public Label lblamntdue;
        private Label label6;
        private BunifuFlatButton bunifuFlatButton13;
        private TextBox numericUpDown1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem printReceiptToolStripMenuItem;
        private MetroTile metroTile12;
        private Tulpep.NotificationWindow.PopupNotifier popup;
    }
}