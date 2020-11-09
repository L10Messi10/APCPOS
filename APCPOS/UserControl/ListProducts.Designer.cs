using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;

namespace APCPOS.UserControl
{
    partial class ListProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListProducts));
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblprodname = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblstock = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblbrcode = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblunit = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 33;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(9, 44);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(67, 67);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox1.MouseEnter += new System.EventHandler(this.ListProducts_MouseEnter);
            this.bunifuPictureBox1.MouseLeave += new System.EventHandler(this.ListProducts_MouseLeave);
            // 
            // lblprice
            // 
            this.lblprice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblprice.AutoEllipsis = true;
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.IndianRed;
            this.lblprice.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.White;
            this.lblprice.Location = new System.Drawing.Point(138, 104);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(14, 14);
            this.lblprice.TabIndex = 20;
            this.lblprice.Text = "0";
            this.lblprice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblprice.MouseEnter += new System.EventHandler(this.ListProducts_MouseEnter);
            this.lblprice.MouseLeave += new System.EventHandler(this.ListProducts_MouseLeave);
            // 
            // lblprodname
            // 
            this.lblprodname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblprodname.AutoSize = true;
            this.lblprodname.BackColor = System.Drawing.Color.Transparent;
            this.lblprodname.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprodname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            this.lblprodname.Location = new System.Drawing.Point(2, 8);
            this.lblprodname.Name = "lblprodname";
            this.lblprodname.Size = new System.Drawing.Size(109, 15);
            this.lblprodname.TabIndex = 19;
            this.lblprodname.Text = "No Data Available";
            this.lblprodname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblprodname.MouseEnter += new System.EventHandler(this.ListProducts_MouseEnter);
            this.lblprodname.MouseLeave += new System.EventHandler(this.ListProducts_MouseLeave);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(190, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 32;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.MouseEnter += new System.EventHandler(this.ListProducts_MouseEnter);
            this.bunifuImageButton1.MouseLeave += new System.EventHandler(this.ListProducts_MouseLeave);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblprodname);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 33);
            this.panel1.TabIndex = 33;
            this.panel1.MouseEnter += new System.EventHandler(this.ListProducts_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.ListProducts_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(178, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 33);
            this.panel3.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(96, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "ID #:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseEnter += new System.EventHandler(this.ListProducts_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.ListProducts_MouseLeave);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Roboto Lt", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(149)))));
            this.lblID.Location = new System.Drawing.Point(136, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(34, 15);
            this.lblID.TabIndex = 36;
            this.lblID.Text = "ID #:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblID.MouseEnter += new System.EventHandler(this.ListProducts_MouseEnter);
            this.lblID.MouseLeave += new System.EventHandler(this.ListProducts_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(87, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Stock:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.MouseEnter += new System.EventHandler(this.ListProducts_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.ListProducts_MouseLeave);
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.BackColor = System.Drawing.Color.Transparent;
            this.lblstock.Font = new System.Drawing.Font("Roboto Lt", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstock.ForeColor = System.Drawing.Color.Snow;
            this.lblstock.Location = new System.Drawing.Point(136, 51);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(34, 15);
            this.lblstock.TabIndex = 38;
            this.lblstock.Text = "ID #:";
            this.lblstock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblstock.MouseEnter += new System.EventHandler(this.ListProducts_MouseEnter);
            this.lblstock.MouseLeave += new System.EventHandler(this.ListProducts_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(82, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "Brcd #:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.MouseEnter += new System.EventHandler(this.ListProducts_MouseEnter);
            this.label8.MouseLeave += new System.EventHandler(this.ListProducts_MouseLeave);
            // 
            // lblbrcode
            // 
            this.lblbrcode.AutoSize = true;
            this.lblbrcode.BackColor = System.Drawing.Color.Transparent;
            this.lblbrcode.Font = new System.Drawing.Font("Roboto Lt", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrcode.ForeColor = System.Drawing.Color.Snow;
            this.lblbrcode.Location = new System.Drawing.Point(136, 65);
            this.lblbrcode.Name = "lblbrcode";
            this.lblbrcode.Size = new System.Drawing.Size(68, 15);
            this.lblbrcode.TabIndex = 41;
            this.lblbrcode.Text = "Barcode #:";
            this.lblbrcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblbrcode.MouseEnter += new System.EventHandler(this.ListProducts_MouseEnter);
            this.lblbrcode.MouseLeave += new System.EventHandler(this.ListProducts_MouseLeave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(97, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 42;
            this.label10.Text = "Unit:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.MouseEnter += new System.EventHandler(this.ListProducts_MouseEnter);
            this.label10.MouseLeave += new System.EventHandler(this.ListProducts_MouseLeave);
            // 
            // lblunit
            // 
            this.lblunit.AutoSize = true;
            this.lblunit.BackColor = System.Drawing.Color.Transparent;
            this.lblunit.Font = new System.Drawing.Font("Roboto Lt", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblunit.ForeColor = System.Drawing.Color.Snow;
            this.lblunit.Location = new System.Drawing.Point(135, 83);
            this.lblunit.Name = "lblunit";
            this.lblunit.Size = new System.Drawing.Size(33, 15);
            this.lblunit.TabIndex = 43;
            this.lblunit.Text = "Unit:";
            this.lblunit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblunit.MouseEnter += new System.EventHandler(this.ListProducts_MouseEnter);
            this.lblunit.MouseLeave += new System.EventHandler(this.ListProducts_MouseLeave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Snow;
            this.label12.Location = new System.Drawing.Point(91, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 44;
            this.label12.Text = "Price:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.MouseEnter += new System.EventHandler(this.ListProducts_MouseEnter);
            this.label12.MouseLeave += new System.EventHandler(this.ListProducts_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Location = new System.Drawing.Point(-9, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 31);
            this.panel2.TabIndex = 46;
            // 
            // ListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblunit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblbrcode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblstock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.bunifuPictureBox1);
            this.DoubleBuffered = true;
            this.Name = "ListProducts";
            this.Size = new System.Drawing.Size(218, 126);
            this.Load += new System.EventHandler(this.ListProducts_Load);
            this.MouseEnter += new System.EventHandler(this.ListProducts_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListProducts_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BunifuImageButton bunifuImageButton1;
        private BunifuElipse bunifuElipse1;
        private Panel panel1;
        public BunifuPictureBox bunifuPictureBox1;
        public Label lblprice;
        public Label lblprodname;
        public Label label1;
        public Label lblID;
        public Label lblstock;
        public Label label5;
        public Label lblunit;
        public Label label10;
        public Label lblbrcode;
        public Label label8;
        public Label label12;
        private Panel panel2;
        private Panel panel3;
    }
}
