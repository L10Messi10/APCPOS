using System.ComponentModel;
using System.Windows.Forms;

namespace APCPOS.UserControl
{
    partial class ListProdCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListProdCategory));
            this.lbltitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderopen = new System.Windows.Forms.PictureBox();
            this.folderclose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.folderopen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderclose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbltitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(0, 93);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(175, 24);
            this.lbltitle.TabIndex = 9;
            this.lbltitle.Text = "POS Transaction";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbltitle.Click += new System.EventHandler(this.ListProdCategory_Click);
            this.lbltitle.Leave += new System.EventHandler(this.ListProdCategory_Leave);
            this.lbltitle.MouseEnter += new System.EventHandler(this.ListProdCategory_MouseEnter);
            this.lbltitle.MouseLeave += new System.EventHandler(this.ListProdCategory_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "22";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.ListProdCategory_Click);
            this.label1.Leave += new System.EventHandler(this.ListProdCategory_Leave);
            this.label1.MouseEnter += new System.EventHandler(this.ListProdCategory_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.ListProdCategory_MouseEnter);
            // 
            // folderopen
            // 
            this.folderopen.Image = ((System.Drawing.Image)(resources.GetObject("folderopen.Image")));
            this.folderopen.Location = new System.Drawing.Point(102, 3);
            this.folderopen.Name = "folderopen";
            this.folderopen.Size = new System.Drawing.Size(71, 60);
            this.folderopen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.folderopen.TabIndex = 11;
            this.folderopen.TabStop = false;
            this.folderopen.Visible = false;
            this.folderopen.MouseEnter += new System.EventHandler(this.ListProdCategory_MouseEnter);
            this.folderopen.MouseLeave += new System.EventHandler(this.ListProdCategory_MouseEnter);
            // 
            // folderclose
            // 
            this.folderclose.Image = ((System.Drawing.Image)(resources.GetObject("folderclose.Image")));
            this.folderclose.Location = new System.Drawing.Point(101, 3);
            this.folderclose.Name = "folderclose";
            this.folderclose.Size = new System.Drawing.Size(71, 60);
            this.folderclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.folderclose.TabIndex = 12;
            this.folderclose.TabStop = false;
            // 
            // ListProdCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.folderclose);
            this.Controls.Add(this.folderopen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltitle);
            this.Name = "ListProdCategory";
            this.Size = new System.Drawing.Size(175, 117);
            this.Load += new System.EventHandler(this.ListProdCategory_Load);
            this.Click += new System.EventHandler(this.ListProdCategory_Click);
            this.Leave += new System.EventHandler(this.ListProdCategory_Leave);
            this.MouseEnter += new System.EventHandler(this.ListProdCategory_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListProdCategory_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.folderopen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox folderopen;
        public Label label1;
        public Label lbltitle;
        private PictureBox folderclose;
    }
}
