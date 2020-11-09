using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;

namespace APCPOS.Messageboxes
{
    partial class Frm_Question
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Question));
            this.bunifuDragControl5 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.msgtxt = new System.Windows.Forms.Label();
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.question = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.titletxt = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuDragControl4 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.anim = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.question)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl5
            // 
            this.bunifuDragControl5.Fixed = true;
            this.bunifuDragControl5.Horizontal = true;
            this.bunifuDragControl5.TargetControl = this.msgtxt;
            this.bunifuDragControl5.Vertical = true;
            // 
            // msgtxt
            // 
            this.anim.SetDecoration(this.msgtxt, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.msgtxt.Font = new System.Drawing.Font("Roboto Lt", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgtxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.msgtxt.Location = new System.Drawing.Point(121, 20);
            this.msgtxt.Name = "msgtxt";
            this.msgtxt.Size = new System.Drawing.Size(357, 103);
            this.msgtxt.TabIndex = 10;
            this.msgtxt.Text = "label2";
            this.msgtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.panel1;
            this.bunifuDragControl3.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(185)))), ((int)(((byte)(236)))));
            this.panel1.Controls.Add(this.question);
            this.anim.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 193);
            this.panel1.TabIndex = 8;
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.Transparent;
            this.anim.SetDecoration(this.question, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.question.Image = ((System.Drawing.Image)(resources.GetObject("question.Image")));
            this.question.Location = new System.Drawing.Point(25, 60);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(66, 63);
            this.question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.question.TabIndex = 10;
            this.question.TabStop = false;
            this.question.Visible = false;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.titletxt;
            this.bunifuDragControl2.Vertical = true;
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
            this.titletxt.TabIndex = 11;
            this.titletxt.Text = "Alert Title";
            this.titletxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(185)))), ((int)(((byte)(236)))));
            this.anim.SetDecoration(this.button1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(189, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "YES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.anim.SetDecoration(this.bunifuSeparator1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(124, 124);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(354, 8);
            this.bunifuSeparator1.TabIndex = 12;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuDragControl4
            // 
            this.bunifuDragControl4.Fixed = true;
            this.bunifuDragControl4.Horizontal = true;
            this.bunifuDragControl4.TargetControl = this.panel2;
            this.bunifuDragControl4.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(185)))), ((int)(((byte)(236)))));
            this.anim.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(487, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 193);
            this.panel2.TabIndex = 13;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(185)))), ((int)(((byte)(236)))));
            this.anim.SetDecoration(this.button2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button2.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(338, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 41);
            this.button2.TabIndex = 14;
            this.button2.Text = "NO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 3;
            this.bunifuElipse1.TargetControl = this.button1;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 3;
            this.bunifuElipse2.TargetControl = this.button2;
            // 
            // Frm_Question
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(493, 193);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.titletxt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.msgtxt);
            this.Controls.Add(this.panel1);
            this.anim.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Question";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Question";
            this.Load += new System.EventHandler(this.Frm_Question_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.question)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuDragControl bunifuDragControl5;
        public Label msgtxt;
        private BunifuTransition anim;
        private BunifuDragControl bunifuDragControl3;
        private Panel panel1;
        private PictureBox question;
        private BunifuDragControl bunifuDragControl2;
        public Label titletxt;
        private BunifuDragControl bunifuDragControl1;
        private Button button1;
        private BunifuSeparator bunifuSeparator1;
        private BunifuDragControl bunifuDragControl4;
        private Panel panel2;
        private Timer timer1;
        private Button button2;
        private BunifuElipse bunifuElipse1;
        private BunifuElipse bunifuElipse2;
    }
}