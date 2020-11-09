using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;

namespace APCPOS.Messageboxes
{
    partial class Frm_OK
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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_OK));
            this.panel1 = new System.Windows.Forms.Panel();
            this.warn = new System.Windows.Forms.PictureBox();
            this.success = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.anim = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.msgtxt = new System.Windows.Forms.Label();
            this.titletxt = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl4 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl5 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.success)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(76)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.warn);
            this.panel1.Controls.Add(this.success);
            this.panel1.Controls.Add(this.error);
            this.panel1.Controls.Add(this.info);
            this.anim.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 193);
            this.panel1.TabIndex = 0;
            // 
            // warn
            // 
            this.warn.BackColor = System.Drawing.Color.Transparent;
            this.anim.SetDecoration(this.warn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.warn.Image = ((System.Drawing.Image)(resources.GetObject("warn.Image")));
            this.warn.Location = new System.Drawing.Point(25, 60);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(66, 63);
            this.warn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.warn.TabIndex = 12;
            this.warn.TabStop = false;
            this.warn.Visible = false;
            // 
            // success
            // 
            this.success.BackColor = System.Drawing.Color.Transparent;
            this.anim.SetDecoration(this.success, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.success.Image = ((System.Drawing.Image)(resources.GetObject("success.Image")));
            this.success.Location = new System.Drawing.Point(25, 60);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(66, 63);
            this.success.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.success.TabIndex = 11;
            this.success.TabStop = false;
            this.success.Visible = false;
            // 
            // error
            // 
            this.error.BackColor = System.Drawing.Color.Transparent;
            this.anim.SetDecoration(this.error, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.error.Image = ((System.Drawing.Image)(resources.GetObject("error.Image")));
            this.error.Location = new System.Drawing.Point(25, 60);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(66, 63);
            this.error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error.TabIndex = 9;
            this.error.TabStop = false;
            this.error.Visible = false;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.anim.SetDecoration(this.info, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.Location = new System.Drawing.Point(25, 60);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(66, 63);
            this.info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info.TabIndex = 10;
            this.info.TabStop = false;
            this.info.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // anim
            // 
            this.anim.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Rotate;
            this.anim.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 1F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.anim.DefaultAnimation = animation1;
            // 
            // msgtxt
            // 
            this.anim.SetDecoration(this.msgtxt, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.msgtxt.Font = new System.Drawing.Font("Roboto Lt", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgtxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.msgtxt.Location = new System.Drawing.Point(121, 22);
            this.msgtxt.Name = "msgtxt";
            this.msgtxt.Size = new System.Drawing.Size(357, 103);
            this.msgtxt.TabIndex = 4;
            this.msgtxt.Text = "label2";
            this.msgtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titletxt
            // 
            this.anim.SetDecoration(this.titletxt, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.titletxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.titletxt.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titletxt.ForeColor = System.Drawing.Color.Snow;
            this.titletxt.Location = new System.Drawing.Point(115, 0);
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(372, 22);
            this.titletxt.TabIndex = 5;
            this.titletxt.Text = "Alert Title";
            this.titletxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.anim.SetDecoration(this.bunifuSeparator1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(124, 126);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(354, 8);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // button1
            // 
            this.anim.SetDecoration(this.button1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(267, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(76)))), ((int)(((byte)(61)))));
            this.anim.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(487, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 193);
            this.panel2.TabIndex = 7;
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
            this.bunifuDragControl2.TargetControl = this.titletxt;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.panel1;
            this.bunifuDragControl3.Vertical = true;
            // 
            // bunifuDragControl4
            // 
            this.bunifuDragControl4.Fixed = true;
            this.bunifuDragControl4.Horizontal = true;
            this.bunifuDragControl4.TargetControl = this.panel2;
            this.bunifuDragControl4.Vertical = true;
            // 
            // bunifuDragControl5
            // 
            this.bunifuDragControl5.Fixed = true;
            this.bunifuDragControl5.Horizontal = true;
            this.bunifuDragControl5.TargetControl = this.msgtxt;
            this.bunifuDragControl5.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 3;
            this.bunifuElipse1.TargetControl = this.button1;
            // 
            // Frm_OK
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(493, 193);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.titletxt);
            this.Controls.Add(this.msgtxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.anim.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_OK";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_OK";
            this.Load += new System.EventHandler(this.Frm_OK_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.success)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox warn;
        private PictureBox success;
        private PictureBox info;
        private PictureBox error;
        private Timer timer1;
        private BunifuTransition anim;
        public Label msgtxt;
        public Label titletxt;
        private BunifuSeparator bunifuSeparator1;
        private Button button1;
        private Panel panel2;
        private BunifuDragControl bunifuDragControl1;
        private BunifuDragControl bunifuDragControl2;
        private BunifuDragControl bunifuDragControl3;
        private BunifuDragControl bunifuDragControl4;
        private BunifuDragControl bunifuDragControl5;
        private BunifuElipse bunifuElipse1;
    }
}