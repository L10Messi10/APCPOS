﻿using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForm.BunifuShadowPanel;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuTextbox;

namespace APCPOS
{
    partial class Form1
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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation3 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation2 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation4 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation5 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel68 = new System.Windows.Forms.Panel();
            this.bunifuSeparator21 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panelaccnt = new System.Windows.Forms.Panel();
            this.lblnotifcount = new System.Windows.Forms.Label();
            this.bunifuSeparator22 = new Bunifu.Framework.UI.BunifuSeparator();
            this.networkimg = new Bunifu.Framework.UI.BunifuImageButton();
            this.userpic = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuImageButton10 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton9 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbldesignation = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblfullname = new System.Windows.Forms.Label();
            this.panelproducts = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flowLayoutPanelprodcategory = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblsales = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblinventory = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sidepanel = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnreports = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_stock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_product = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnpostransac = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnusers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnuserlog = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btndashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.indicator = new System.Windows.Forms.Panel();
            this.panel65 = new System.Windows.Forms.Panel();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.panelstock = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bunifuTextBox2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelmain = new System.Windows.Forms.Panel();
            this.panelreports = new System.Windows.Forms.Panel();
            this.panel64 = new System.Windows.Forms.Panel();
            this.panelreportcharts = new System.Windows.Forms.Panel();
            this.bunifuImageButton39 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton38 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator23 = new Bunifu.Framework.UI.BunifuSeparator();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label47 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuSeparator20 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuImageButton37 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label43 = new System.Windows.Forms.Label();
            this.bunifuSeparator19 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuImageButton36 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton35 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDataViz5 = new Bunifu.DataViz.WinForms.BunifuDataViz();
            this.panel67 = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.bunifuImageButton34 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label42 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuSeparator18 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuDataViz4 = new Bunifu.DataViz.WinForms.BunifuDataViz();
            this.bunifuDropdown4 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuSeparator17 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label28 = new System.Windows.Forms.Label();
            this.panel66 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.bunifuImageButton33 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label29 = new System.Windows.Forms.Label();
            this.bunifuSeparator16 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuDataViz3 = new Bunifu.DataViz.WinForms.BunifuDataViz();
            this.panelexpiredproducts = new System.Windows.Forms.Panel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel63 = new System.Windows.Forms.Panel();
            this.bunifuImageButton32 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton31 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTextBox5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.paneldebts = new System.Windows.Forms.Panel();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panel48 = new System.Windows.Forms.Panel();
            this.bunifuDataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuVScrollBar3 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.panel50 = new System.Windows.Forms.Panel();
            this.label37 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.bunifuSeparator12 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator11 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel49 = new System.Windows.Forms.Panel();
            this.bunifuImageButton23 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton22 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTextBox4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.panel40 = new System.Windows.Forms.Panel();
            this.bunifuDataGridView2 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuSeparator10 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel44 = new System.Windows.Forms.Panel();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.bunifuSeparator13 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel41 = new System.Windows.Forms.Panel();
            this.panel43 = new System.Windows.Forms.Panel();
            this.panel51 = new System.Windows.Forms.Panel();
            this.bunifuImageButton21 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton24 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbldebtfullname = new System.Windows.Forms.Label();
            this.panel42 = new System.Windows.Forms.Panel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel39 = new System.Windows.Forms.Panel();
            this.panel47 = new System.Windows.Forms.Panel();
            this.panel38 = new System.Windows.Forms.Panel();
            this.panel61 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton10 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton9 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel62 = new System.Windows.Forms.Panel();
            this.indicator2 = new System.Windows.Forms.Panel();
            this.paneldashboard = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.bunifuDataViz2 = new Bunifu.DataViz.WinForms.BunifuDataViz();
            this.panel37 = new System.Windows.Forms.Panel();
            this.panel53 = new System.Windows.Forms.Panel();
            this.bunifuDropdown1 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuImageButton25 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.panel45 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbllog5 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar5 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbllog4 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar4 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbllog3 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar3 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbllog2 = new System.Windows.Forms.Label();
            this.lbllog1 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel46 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.bunifuSeparator15 = new Bunifu.Framework.UI.BunifuSeparator();
            this.splitterControl2 = new DevExpress.XtraEditors.SplitterControl();
            this.panel27 = new System.Windows.Forms.Panel();
            this.bunifuDataViz1 = new Bunifu.DataViz.WinForms.BunifuDataViz();
            this.panel36 = new System.Windows.Forms.Panel();
            this.panel52 = new System.Windows.Forms.Panel();
            this.bunifuDropdown2 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuImageButton19 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.flowpanelcriticalproducts = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel35 = new System.Windows.Forms.Panel();
            this.bunifuImageButton30 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton27 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.panel54 = new System.Windows.Forms.Panel();
            this.flowpanelnearexpire = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel55 = new System.Windows.Forms.Panel();
            this.bunifuImageButton29 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton28 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.splitterControl3 = new DevExpress.XtraEditors.SplitterControl();
            this.panel30 = new System.Windows.Forms.Panel();
            this.flowpaneltopselling = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel31 = new System.Windows.Forms.Panel();
            this.bunifuImageButton26 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label27 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.bunifuSeparator7 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel18 = new System.Windows.Forms.Panel();
            this.bunifuDropdown5 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.panel24 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.panel60 = new System.Windows.Forms.Panel();
            this.bunifuSeparator9 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.bunifuImageButton17 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel21 = new System.Windows.Forms.Panel();
            this.bunifuImageButton20 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label19 = new System.Windows.Forms.Label();
            this.bunifuImageButton15 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator8 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblcollectables = new System.Windows.Forms.Label();
            this.panel56 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.bunifuImageButton16 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblneworders = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel32 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuImageButton7 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblrevenue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bunifuImageButton8 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel34 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.bunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel59 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.bunifuImageButton13 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.bunifuImageButton11 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label13 = new System.Windows.Forms.Label();
            this.panel57 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.bunifuImageButton12 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblcustomercount = new System.Windows.Forms.Label();
            this.panel58 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.bunifuImageButton14 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator14 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelusers = new System.Windows.Forms.Panel();
            this.flowLayoutPaneluser = new System.Windows.Forms.FlowLayoutPanel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.bunifuDropdown3 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuImageButton18 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTextBox3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.refreshDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bunifuTransition2 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.fade = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.popup = new Tulpep.NotificationWindow.PopupNotifier();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition3 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransition4 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::APCPOS.Forms.WaitForm1), true, true);
            this.panel1.SuspendLayout();
            this.panel68.SuspendLayout();
            this.panelaccnt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).BeginInit();
            this.panelproducts.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.sidepanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel65.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            this.panelstock.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.panelmain.SuspendLayout();
            this.panelreports.SuspendLayout();
            this.panel64.SuspendLayout();
            this.panelreportcharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton35)).BeginInit();
            this.panel67.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton34)).BeginInit();
            this.panel66.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton33)).BeginInit();
            this.panelexpiredproducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.panel63.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton31)).BeginInit();
            this.paneldebts.SuspendLayout();
            this.panel48.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.panel50.SuspendLayout();
            this.panel49.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton22)).BeginInit();
            this.panel40.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView2)).BeginInit();
            this.panel44.SuspendLayout();
            this.panel41.SuspendLayout();
            this.panel43.SuspendLayout();
            this.panel51.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton24)).BeginInit();
            this.panel42.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.panel38.SuspendLayout();
            this.panel61.SuspendLayout();
            this.panel62.SuspendLayout();
            this.paneldashboard.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel37.SuspendLayout();
            this.panel53.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton25)).BeginInit();
            this.panel45.SuspendLayout();
            this.panel46.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel36.SuspendLayout();
            this.panel52.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton19)).BeginInit();
            this.panel28.SuspendLayout();
            this.panel33.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flowpanelcriticalproducts)).BeginInit();
            this.panel35.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton27)).BeginInit();
            this.panel54.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flowpanelnearexpire)).BeginInit();
            this.panel55.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton28)).BeginInit();
            this.panel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flowpaneltopselling)).BeginInit();
            this.panel31.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton26)).BeginInit();
            this.panel19.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton17)).BeginInit();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton16)).BeginInit();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).BeginInit();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton13)).BeginInit();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton12)).BeginInit();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton14)).BeginInit();
            this.panelusers.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton18)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.panel68);
            this.panel1.Controls.Add(this.lbltitle);
            this.panel1.Controls.Add(this.panelaccnt);
            this.fade.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 36);
            this.panel1.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel68
            // 
            this.panel68.Controls.Add(this.bunifuSeparator21);
            this.panel68.Controls.Add(this.lbltime);
            this.panel68.Controls.Add(this.lbldate);
            this.fade.SetDecoration(this.panel68, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel68, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel68, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel68, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel68, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel68.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel68.Location = new System.Drawing.Point(1226, 0);
            this.panel68.Name = "panel68";
            this.panel68.Size = new System.Drawing.Size(221, 36);
            this.panel68.TabIndex = 21;
            this.bunifuToolTip1.SetToolTip(this.panel68, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel68, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel68, "");
            // 
            // bunifuSeparator21
            // 
            this.bunifuSeparator21.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator21.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator21.LineThickness = 1;
            this.bunifuSeparator21.Location = new System.Drawing.Point(3, 5);
            this.bunifuSeparator21.Name = "bunifuSeparator21";
            this.bunifuSeparator21.Size = new System.Drawing.Size(8, 24);
            this.bunifuSeparator21.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator21, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator21, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator21, "");
            this.bunifuSeparator21.Transparency = 255;
            this.bunifuSeparator21.Vertical = true;
            // 
            // lbltime
            // 
            this.fade.SetDecoration(this.lbltime, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbltime, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lbltime, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lbltime, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lbltime, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbltime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltime.Font = new System.Drawing.Font("Roboto Bk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.Snow;
            this.lbltime.Location = new System.Drawing.Point(0, 16);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(221, 15);
            this.lbltime.TabIndex = 14;
            this.lbltime.Text = "Administrator";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.lbltime, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbltime, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbltime, "");
            // 
            // lbldate
            // 
            this.fade.SetDecoration(this.lbldate, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbldate, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lbldate, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lbldate, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lbldate, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbldate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbldate.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.DimGray;
            this.lbldate.Location = new System.Drawing.Point(0, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(221, 16);
            this.lbldate.TabIndex = 13;
            this.lbldate.Text = "Administrator";
            this.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.lbldate, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbldate, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbldate, "");
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.fade.SetDecoration(this.lbltitle, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbltitle, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lbltitle, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lbltitle, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lbltitle, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbltitle.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lbltitle.Location = new System.Drawing.Point(4, 6);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(114, 25);
            this.lbltitle.TabIndex = 7;
            this.lbltitle.Text = "Dashboard";
            this.bunifuToolTip1.SetToolTip(this.lbltitle, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbltitle, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbltitle, "");
            // 
            // panelaccnt
            // 
            this.panelaccnt.Controls.Add(this.lblnotifcount);
            this.panelaccnt.Controls.Add(this.bunifuSeparator22);
            this.panelaccnt.Controls.Add(this.networkimg);
            this.panelaccnt.Controls.Add(this.userpic);
            this.panelaccnt.Controls.Add(this.bunifuImageButton10);
            this.panelaccnt.Controls.Add(this.bunifuImageButton2);
            this.panelaccnt.Controls.Add(this.bunifuImageButton9);
            this.panelaccnt.Controls.Add(this.lbldesignation);
            this.panelaccnt.Controls.Add(this.bunifuSeparator1);
            this.panelaccnt.Controls.Add(this.lblfullname);
            this.fade.SetDecoration(this.panelaccnt, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panelaccnt, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelaccnt, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panelaccnt, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panelaccnt, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelaccnt.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelaccnt.Location = new System.Drawing.Point(1447, 0);
            this.panelaccnt.Name = "panelaccnt";
            this.panelaccnt.Size = new System.Drawing.Size(473, 36);
            this.panelaccnt.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.panelaccnt, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelaccnt, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelaccnt, "");
            // 
            // lblnotifcount
            // 
            this.lblnotifcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(0)))));
            this.fade.SetDecoration(this.lblnotifcount, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblnotifcount, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lblnotifcount, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lblnotifcount, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lblnotifcount, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblnotifcount.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotifcount.ForeColor = System.Drawing.Color.Black;
            this.lblnotifcount.Location = new System.Drawing.Point(8, 1);
            this.lblnotifcount.Name = "lblnotifcount";
            this.lblnotifcount.Size = new System.Drawing.Size(24, 15);
            this.lblnotifcount.TabIndex = 19;
            this.lblnotifcount.Text = "0";
            this.lblnotifcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.lblnotifcount, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblnotifcount, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblnotifcount, "");
            // 
            // bunifuSeparator22
            // 
            this.bunifuSeparator22.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator22.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator22.LineThickness = 1;
            this.bunifuSeparator22.Location = new System.Drawing.Point(0, 6);
            this.bunifuSeparator22.Name = "bunifuSeparator22";
            this.bunifuSeparator22.Size = new System.Drawing.Size(10, 25);
            this.bunifuSeparator22.TabIndex = 21;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator22, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator22, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator22, "");
            this.bunifuSeparator22.Transparency = 255;
            this.bunifuSeparator22.Vertical = true;
            // 
            // networkimg
            // 
            this.fade.SetDecoration(this.networkimg, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.networkimg, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.networkimg, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.networkimg, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.networkimg, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.networkimg.Image = ((System.Drawing.Image)(resources.GetObject("networkimg.Image")));
            this.networkimg.ImageActive = null;
            this.networkimg.Location = new System.Drawing.Point(91, 5);
            this.networkimg.Name = "networkimg";
            this.networkimg.Size = new System.Drawing.Size(25, 28);
            this.networkimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.networkimg.TabIndex = 20;
            this.networkimg.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.networkimg, "Server status");
            this.bunifuToolTip1.SetToolTipIcon(this.networkimg, null);
            this.bunifuToolTip1.SetToolTipTitle(this.networkimg, "");
            this.networkimg.Zoom = 10;
            this.networkimg.Click += new System.EventHandler(this.networkimg_Click);
            // 
            // userpic
            // 
            this.userpic.AllowFocused = false;
            this.userpic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userpic.BorderRadius = 15;
            this.fade.SetDecoration(this.userpic, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.userpic, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.userpic, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.userpic, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.userpic, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.userpic.Image = ((System.Drawing.Image)(resources.GetObject("userpic.Image")));
            this.userpic.IsCircle = true;
            this.userpic.Location = new System.Drawing.Point(405, 3);
            this.userpic.Name = "userpic";
            this.userpic.Size = new System.Drawing.Size(30, 30);
            this.userpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userpic.TabIndex = 2;
            this.userpic.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.userpic, "");
            this.bunifuToolTip1.SetToolTipIcon(this.userpic, null);
            this.bunifuToolTip1.SetToolTipTitle(this.userpic, "");
            this.userpic.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // bunifuImageButton10
            // 
            this.fade.SetDecoration(this.bunifuImageButton10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton10.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton10.Image")));
            this.bunifuImageButton10.ImageActive = null;
            this.bunifuImageButton10.Location = new System.Drawing.Point(446, 7);
            this.bunifuImageButton10.Name = "bunifuImageButton10";
            this.bunifuImageButton10.Size = new System.Drawing.Size(20, 23);
            this.bunifuImageButton10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton10.TabIndex = 12;
            this.bunifuImageButton10.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton10, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton10, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton10, "");
            this.bunifuImageButton10.Zoom = 10;
            this.bunifuImageButton10.Click += new System.EventHandler(this.bunifuImageButton10_Click);
            // 
            // bunifuImageButton2
            // 
            this.fade.SetDecoration(this.bunifuImageButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(32, 4);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(22, 29);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 8;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton2, "Notification");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton2, "");
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton9
            // 
            this.fade.SetDecoration(this.bunifuImageButton9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton9.Image")));
            this.bunifuImageButton9.ImageActive = null;
            this.bunifuImageButton9.Location = new System.Drawing.Point(60, 5);
            this.bunifuImageButton9.Name = "bunifuImageButton9";
            this.bunifuImageButton9.Size = new System.Drawing.Size(25, 28);
            this.bunifuImageButton9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton9.TabIndex = 11;
            this.bunifuImageButton9.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton9, "System setting");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton9, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton9, "");
            this.bunifuImageButton9.Zoom = 10;
            this.bunifuImageButton9.Click += new System.EventHandler(this.bunifuImageButton9_Click);
            // 
            // lbldesignation
            // 
            this.fade.SetDecoration(this.lbldesignation, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbldesignation, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lbldesignation, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lbldesignation, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lbldesignation, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbldesignation.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesignation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lbldesignation.Location = new System.Drawing.Point(138, 19);
            this.lbldesignation.Name = "lbldesignation";
            this.lbldesignation.Size = new System.Drawing.Size(259, 15);
            this.lbldesignation.TabIndex = 6;
            this.lbldesignation.Text = "Administrator";
            this.lbldesignation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.lbldesignation, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbldesignation, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbldesignation, "");
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(122, 6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 25);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator1, "");
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // lblfullname
            // 
            this.fade.SetDecoration(this.lblfullname, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblfullname, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lblfullname, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lblfullname, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lblfullname, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblfullname.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.lblfullname.Location = new System.Drawing.Point(138, 3);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(259, 18);
            this.lblfullname.TabIndex = 9;
            this.lblfullname.Text = "Administrator";
            this.lblfullname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.lblfullname, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblfullname, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblfullname, "");
            // 
            // panelproducts
            // 
            this.panelproducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.panelproducts.Controls.Add(this.panel4);
            this.panelproducts.Controls.Add(this.panel6);
            this.fade.SetDecoration(this.panelproducts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panelproducts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelproducts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panelproducts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panelproducts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelproducts.Location = new System.Drawing.Point(0, 0);
            this.panelproducts.Name = "panelproducts";
            this.panelproducts.Size = new System.Drawing.Size(1727, 1044);
            this.panelproducts.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.panelproducts, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelproducts, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelproducts, "");
            this.panelproducts.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Controls.Add(this.bunifuFlatButton2);
            this.panel4.Controls.Add(this.flowLayoutPanelprodcategory);
            this.panel4.Controls.Add(this.label2);
            this.fade.SetDecoration(this.panel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1727, 993);
            this.panel4.TabIndex = 21;
            this.bunifuToolTip1.SetToolTip(this.panel4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel4, "");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTransition4.SetDecoration(this.flowLayoutPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.flowLayoutPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.flowLayoutPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.flowLayoutPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.flowLayoutPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1512, 976);
            this.flowLayoutPanel1.TabIndex = 19;
            this.bunifuToolTip1.SetToolTip(this.flowLayoutPanel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.flowLayoutPanel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.flowLayoutPanel1, "");
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fade.SetDecoration(this.bunifuFlatButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuFlatButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuFlatButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Right;
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(1512, 0);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(20, 976);
            this.bunifuFlatButton2.TabIndex = 22;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.bunifuFlatButton2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuFlatButton2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuFlatButton2, "");
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // flowLayoutPanelprodcategory
            // 
            this.bunifuTransition4.SetDecoration(this.flowLayoutPanelprodcategory, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.flowLayoutPanelprodcategory, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.flowLayoutPanelprodcategory, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.flowLayoutPanelprodcategory, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.flowLayoutPanelprodcategory, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.flowLayoutPanelprodcategory.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelprodcategory.Location = new System.Drawing.Point(1532, 0);
            this.flowLayoutPanelprodcategory.Name = "flowLayoutPanelprodcategory";
            this.flowLayoutPanelprodcategory.Size = new System.Drawing.Size(195, 976);
            this.flowLayoutPanelprodcategory.TabIndex = 21;
            this.bunifuToolTip1.SetToolTip(this.flowLayoutPanelprodcategory, "");
            this.bunifuToolTip1.SetToolTipIcon(this.flowLayoutPanelprodcategory, null);
            this.bunifuToolTip1.SetToolTipTitle(this.flowLayoutPanelprodcategory, "");
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(0, 976);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1727, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "No Data Available";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label2, "");
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel12);
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Controls.Add(this.panel2);
            this.fade.SetDecoration(this.panel6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1727, 51);
            this.panel6.TabIndex = 26;
            this.bunifuToolTip1.SetToolTip(this.panel6, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel6, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel6, "");
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label8);
            this.panel12.Controls.Add(this.lblsales);
            this.fade.SetDecoration(this.panel12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(1195, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(337, 51);
            this.panel12.TabIndex = 27;
            this.bunifuToolTip1.SetToolTip(this.panel12, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel12, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel12, "");
            // 
            // label8
            // 
            this.fade.SetDecoration(this.label8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(337, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Total Sales";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bunifuToolTip1.SetToolTip(this.label8, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label8, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label8, "");
            // 
            // lblsales
            // 
            this.fade.SetDecoration(this.lblsales, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblsales, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lblsales, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lblsales, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lblsales, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblsales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblsales.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsales.ForeColor = System.Drawing.Color.Gray;
            this.lblsales.Location = new System.Drawing.Point(0, 27);
            this.lblsales.Name = "lblsales";
            this.lblsales.Size = new System.Drawing.Size(337, 24);
            this.lblsales.TabIndex = 25;
            this.lblsales.Text = "Inventory:";
            this.lblsales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.lblsales, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblsales, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblsales, "");
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.lblinventory);
            this.fade.SetDecoration(this.panel11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(1532, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(195, 51);
            this.panel11.TabIndex = 26;
            this.bunifuToolTip1.SetToolTip(this.panel11, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel11, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel11, "");
            // 
            // label4
            // 
            this.fade.SetDecoration(this.label4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total Inventory";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bunifuToolTip1.SetToolTip(this.label4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label4, "");
            // 
            // lblinventory
            // 
            this.fade.SetDecoration(this.lblinventory, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblinventory, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lblinventory, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lblinventory, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lblinventory, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblinventory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblinventory.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinventory.ForeColor = System.Drawing.Color.Gray;
            this.lblinventory.Location = new System.Drawing.Point(0, 27);
            this.lblinventory.Name = "lblinventory";
            this.lblinventory.Size = new System.Drawing.Size(195, 24);
            this.lblinventory.TabIndex = 23;
            this.lblinventory.Text = "Inventory:";
            this.lblinventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.lblinventory, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblinventory, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblinventory, "");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.bunifuTextBox1);
            this.fade.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 51);
            this.panel2.TabIndex = 20;
            this.bunifuToolTip1.SetToolTip(this.panel2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel2, "");
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "New";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fade.SetDecoration(this.bunifuFlatButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuFlatButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuFlatButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(305, 6);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(120)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(235, 35);
            this.bunifuFlatButton1.TabIndex = 13;
            this.bunifuFlatButton1.Text = "New";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.bunifuFlatButton1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuFlatButton1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuFlatButton1, "");
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuImageButton1
            // 
            this.fade.SetDecoration(this.bunifuImageButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(263, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(36, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 12;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton1, "");
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(120)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTextBox1.BorderRadius = 1;
            this.bunifuTextBox1.BorderThickness = 6;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.fade.SetDecoration(this.bunifuTextBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuTextBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuTextBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuTextBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuTextBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.IconRight")));
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.Location = new System.Drawing.Point(3, 8);
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
            this.bunifuTextBox1.Size = new System.Drawing.Size(254, 35);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.bunifuTextBox1.TabIndex = 0;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginLeft = 5;
            this.bunifuTextBox1.TextPlaceholder = "Quick Search";
            this.bunifuToolTip1.SetToolTip(this.bunifuTextBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuTextBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuTextBox1, "");
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.OnIconRightClick += new System.EventHandler(this.bunifuTextBox1_OnIconRightClick);
            this.bunifuTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuTextBox1_KeyDown);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.sidepanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.sidepanel.Controls.Add(this.panel7);
            this.bunifuTransition4.SetDecoration(this.sidepanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.sidepanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.sidepanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.sidepanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.sidepanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 36);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.PanelColor = System.Drawing.Color.Empty;
            this.sidepanel.ShadowDept = 0;
            this.sidepanel.ShadowTopLeftVisible = false;
            this.sidepanel.Size = new System.Drawing.Size(193, 1044);
            this.sidepanel.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.sidepanel, "");
            this.bunifuToolTip1.SetToolTipIcon(this.sidepanel, null);
            this.bunifuToolTip1.SetToolTipTitle(this.sidepanel, "");
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel65);
            this.panel7.Controls.Add(this.panel8);
            this.fade.SetDecoration(this.panel7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(193, 1044);
            this.panel7.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panel7, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel7, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel7, "");
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnreports);
            this.panel9.Controls.Add(this.btn_stock);
            this.panel9.Controls.Add(this.btn_product);
            this.panel9.Controls.Add(this.btnpostransac);
            this.panel9.Controls.Add(this.btnusers);
            this.panel9.Controls.Add(this.btnuserlog);
            this.panel9.Controls.Add(this.btndashboard);
            this.panel9.Controls.Add(this.panel10);
            this.fade.SetDecoration(this.panel9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 102);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(193, 942);
            this.panel9.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.panel9, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel9, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel9, "");
            // 
            // btnreports
            // 
            this.btnreports.Active = false;
            this.btnreports.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btnreports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnreports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreports.BorderRadius = 0;
            this.btnreports.ButtonText = "              Reports";
            this.btnreports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fade.SetDecoration(this.btnreports, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.btnreports, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btnreports, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnreports, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.btnreports, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnreports.DisabledColor = System.Drawing.Color.Gray;
            this.btnreports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnreports.Iconcolor = System.Drawing.Color.Transparent;
            this.btnreports.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnreports.Iconimage")));
            this.btnreports.Iconimage_right = null;
            this.btnreports.Iconimage_right_Selected = null;
            this.btnreports.Iconimage_Selected = null;
            this.btnreports.IconMarginLeft = 0;
            this.btnreports.IconMarginRight = 0;
            this.btnreports.IconRightVisible = true;
            this.btnreports.IconRightZoom = 0D;
            this.btnreports.IconVisible = true;
            this.btnreports.IconZoom = 80D;
            this.btnreports.IsTab = true;
            this.btnreports.Location = new System.Drawing.Point(7, 212);
            this.btnreports.Name = "btnreports";
            this.btnreports.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnreports.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btnreports.OnHoverTextColor = System.Drawing.Color.White;
            this.btnreports.selected = false;
            this.btnreports.Size = new System.Drawing.Size(186, 53);
            this.btnreports.TabIndex = 27;
            this.btnreports.Text = "              Reports";
            this.btnreports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreports.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnreports.TextFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnreports, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnreports, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnreports, "");
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.Active = false;
            this.btn_stock.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btn_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btn_stock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_stock.BorderRadius = 0;
            this.btn_stock.ButtonText = "              Stocks";
            this.btn_stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fade.SetDecoration(this.btn_stock, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.btn_stock, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btn_stock, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btn_stock, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.btn_stock, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_stock.DisabledColor = System.Drawing.Color.Gray;
            this.btn_stock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_stock.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_stock.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_stock.Iconimage")));
            this.btn_stock.Iconimage_right = null;
            this.btn_stock.Iconimage_right_Selected = null;
            this.btn_stock.Iconimage_Selected = null;
            this.btn_stock.IconMarginLeft = 0;
            this.btn_stock.IconMarginRight = 0;
            this.btn_stock.IconRightVisible = true;
            this.btn_stock.IconRightZoom = 0D;
            this.btn_stock.IconVisible = true;
            this.btn_stock.IconZoom = 80D;
            this.btn_stock.IsTab = true;
            this.btn_stock.Location = new System.Drawing.Point(7, 159);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btn_stock.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btn_stock.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_stock.selected = false;
            this.btn_stock.Size = new System.Drawing.Size(186, 53);
            this.btn_stock.TabIndex = 19;
            this.btn_stock.Text = "              Stocks";
            this.btn_stock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stock.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_stock.TextFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btn_stock, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btn_stock, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btn_stock, "");
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btn_product
            // 
            this.btn_product.Active = false;
            this.btn_product.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btn_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btn_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_product.BorderRadius = 0;
            this.btn_product.ButtonText = "              Products";
            this.btn_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fade.SetDecoration(this.btn_product, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.btn_product, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btn_product, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btn_product, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.btn_product, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_product.DisabledColor = System.Drawing.Color.Gray;
            this.btn_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_product.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_product.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_product.Iconimage")));
            this.btn_product.Iconimage_right = null;
            this.btn_product.Iconimage_right_Selected = null;
            this.btn_product.Iconimage_Selected = null;
            this.btn_product.IconMarginLeft = 0;
            this.btn_product.IconMarginRight = 0;
            this.btn_product.IconRightVisible = true;
            this.btn_product.IconRightZoom = 0D;
            this.btn_product.IconVisible = true;
            this.btn_product.IconZoom = 80D;
            this.btn_product.IsTab = true;
            this.btn_product.Location = new System.Drawing.Point(7, 106);
            this.btn_product.Name = "btn_product";
            this.btn_product.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btn_product.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btn_product.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_product.selected = false;
            this.btn_product.Size = new System.Drawing.Size(186, 53);
            this.btn_product.TabIndex = 18;
            this.btn_product.Text = "              Products";
            this.btn_product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_product.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_product.TextFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btn_product, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btn_product, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btn_product, "");
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btnpostransac
            // 
            this.btnpostransac.Active = false;
            this.btnpostransac.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnpostransac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnpostransac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpostransac.BorderRadius = 0;
            this.btnpostransac.ButtonText = "              POS";
            this.btnpostransac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fade.SetDecoration(this.btnpostransac, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.btnpostransac, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btnpostransac, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnpostransac, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.btnpostransac, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnpostransac.DisabledColor = System.Drawing.Color.Gray;
            this.btnpostransac.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpostransac.Iconcolor = System.Drawing.Color.Transparent;
            this.btnpostransac.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnpostransac.Iconimage")));
            this.btnpostransac.Iconimage_right = null;
            this.btnpostransac.Iconimage_right_Selected = null;
            this.btnpostransac.Iconimage_Selected = null;
            this.btnpostransac.IconMarginLeft = 0;
            this.btnpostransac.IconMarginRight = 0;
            this.btnpostransac.IconRightVisible = true;
            this.btnpostransac.IconRightZoom = 0D;
            this.btnpostransac.IconVisible = true;
            this.btnpostransac.IconZoom = 80D;
            this.btnpostransac.IsTab = false;
            this.btnpostransac.Location = new System.Drawing.Point(7, 53);
            this.btnpostransac.Name = "btnpostransac";
            this.btnpostransac.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnpostransac.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btnpostransac.OnHoverTextColor = System.Drawing.Color.White;
            this.btnpostransac.selected = false;
            this.btnpostransac.Size = new System.Drawing.Size(186, 53);
            this.btnpostransac.TabIndex = 25;
            this.btnpostransac.Text = "              POS";
            this.btnpostransac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpostransac.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnpostransac.TextFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnpostransac, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnpostransac, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnpostransac, "");
            this.btnpostransac.Click += new System.EventHandler(this.btnpostransac_Click);
            // 
            // btnusers
            // 
            this.btnusers.Active = false;
            this.btnusers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btnusers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnusers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnusers.BorderRadius = 0;
            this.btnusers.ButtonText = "              Users";
            this.btnusers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fade.SetDecoration(this.btnusers, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.btnusers, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btnusers, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnusers, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.btnusers, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnusers.DisabledColor = System.Drawing.Color.Gray;
            this.btnusers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnusers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnusers.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnusers.Iconimage")));
            this.btnusers.Iconimage_right = null;
            this.btnusers.Iconimage_right_Selected = null;
            this.btnusers.Iconimage_Selected = null;
            this.btnusers.IconMarginLeft = 0;
            this.btnusers.IconMarginRight = 0;
            this.btnusers.IconRightVisible = true;
            this.btnusers.IconRightZoom = 0D;
            this.btnusers.IconVisible = true;
            this.btnusers.IconZoom = 80D;
            this.btnusers.IsTab = true;
            this.btnusers.Location = new System.Drawing.Point(7, 836);
            this.btnusers.Name = "btnusers";
            this.btnusers.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnusers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btnusers.OnHoverTextColor = System.Drawing.Color.White;
            this.btnusers.selected = false;
            this.btnusers.Size = new System.Drawing.Size(186, 53);
            this.btnusers.TabIndex = 23;
            this.btnusers.Text = "              Users";
            this.btnusers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusers.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnusers.TextFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnusers, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnusers, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnusers, "");
            this.btnusers.Click += new System.EventHandler(this.btnusers_Click);
            // 
            // btnuserlog
            // 
            this.btnuserlog.Active = false;
            this.btnuserlog.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btnuserlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnuserlog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnuserlog.BorderRadius = 0;
            this.btnuserlog.ButtonText = "              User Log";
            this.btnuserlog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fade.SetDecoration(this.btnuserlog, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.btnuserlog, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btnuserlog, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnuserlog, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.btnuserlog, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnuserlog.DisabledColor = System.Drawing.Color.Gray;
            this.btnuserlog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnuserlog.Iconcolor = System.Drawing.Color.Transparent;
            this.btnuserlog.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnuserlog.Iconimage")));
            this.btnuserlog.Iconimage_right = null;
            this.btnuserlog.Iconimage_right_Selected = null;
            this.btnuserlog.Iconimage_Selected = null;
            this.btnuserlog.IconMarginLeft = 0;
            this.btnuserlog.IconMarginRight = 0;
            this.btnuserlog.IconRightVisible = true;
            this.btnuserlog.IconRightZoom = 0D;
            this.btnuserlog.IconVisible = true;
            this.btnuserlog.IconZoom = 80D;
            this.btnuserlog.IsTab = true;
            this.btnuserlog.Location = new System.Drawing.Point(7, 889);
            this.btnuserlog.Name = "btnuserlog";
            this.btnuserlog.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnuserlog.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btnuserlog.OnHoverTextColor = System.Drawing.Color.White;
            this.btnuserlog.selected = false;
            this.btnuserlog.Size = new System.Drawing.Size(186, 53);
            this.btnuserlog.TabIndex = 24;
            this.btnuserlog.Text = "              User Log";
            this.btnuserlog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuserlog.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnuserlog.TextFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnuserlog, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnuserlog, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnuserlog, "");
            this.btnuserlog.Click += new System.EventHandler(this.btnuserlog_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.Active = true;
            this.btndashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btndashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btndashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndashboard.BorderRadius = 0;
            this.btndashboard.ButtonText = "              Dashboard";
            this.btndashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fade.SetDecoration(this.btndashboard, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.btndashboard, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btndashboard, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btndashboard, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.btndashboard, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btndashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btndashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btndashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btndashboard.Iconimage")));
            this.btndashboard.Iconimage_right = null;
            this.btndashboard.Iconimage_right_Selected = null;
            this.btndashboard.Iconimage_Selected = null;
            this.btndashboard.IconMarginLeft = 0;
            this.btndashboard.IconMarginRight = 0;
            this.btndashboard.IconRightVisible = true;
            this.btndashboard.IconRightZoom = 0D;
            this.btndashboard.IconVisible = true;
            this.btndashboard.IconZoom = 80D;
            this.btndashboard.IsTab = true;
            this.btndashboard.Location = new System.Drawing.Point(7, 0);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btndashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.btndashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btndashboard.selected = true;
            this.btndashboard.Size = new System.Drawing.Size(186, 53);
            this.btndashboard.TabIndex = 20;
            this.btndashboard.Text = "              Dashboard";
            this.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btndashboard.TextFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btndashboard, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btndashboard, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btndashboard, "");
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.indicator);
            this.fade.SetDecoration(this.panel10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(7, 942);
            this.panel10.TabIndex = 26;
            this.bunifuToolTip1.SetToolTip(this.panel10, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel10, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel10, "");
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.fade.SetDecoration(this.indicator, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.indicator, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.indicator, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.indicator, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.indicator, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.indicator.Location = new System.Drawing.Point(2, 0);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(4, 53);
            this.indicator.TabIndex = 21;
            this.bunifuToolTip1.SetToolTip(this.indicator, "");
            this.bunifuToolTip1.SetToolTipIcon(this.indicator, null);
            this.bunifuToolTip1.SetToolTipTitle(this.indicator, "");
            // 
            // panel65
            // 
            this.panel65.Controls.Add(this.bunifuPictureBox2);
            this.fade.SetDecoration(this.panel65, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel65, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel65, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel65, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel65, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel65.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel65.Location = new System.Drawing.Point(0, 51);
            this.panel65.Name = "panel65";
            this.panel65.Size = new System.Drawing.Size(193, 51);
            this.panel65.TabIndex = 7;
            this.bunifuToolTip1.SetToolTip(this.panel65, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel65, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel65, "");
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.BorderRadius = 23;
            this.fade.SetDecoration(this.bunifuPictureBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuPictureBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuPictureBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuPictureBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuPictureBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox2.Image")));
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(70, 2);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(46, 46);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 3;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuPictureBox2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuPictureBox2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuPictureBox2, "");
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.bunifuImageButton4);
            this.fade.SetDecoration(this.panel8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(193, 51);
            this.panel8.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panel8, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel8, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel8, "");
            // 
            // bunifuImageButton4
            // 
            this.fade.SetDecoration(this.bunifuImageButton4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(19, 10);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(24, 30);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 0;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton4, "");
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation3;
            this.bunifuTransition1.Interval = 15;
            this.bunifuTransition1.MaxAnimationTime = 2500;
            this.bunifuTransition1.TimeStep = 0.06F;
            // 
            // panelstock
            // 
            this.panelstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.panelstock.Controls.Add(this.flowLayoutPanel2);
            this.panelstock.Controls.Add(this.panel13);
            this.panelstock.Controls.Add(this.label1);
            this.fade.SetDecoration(this.panelstock, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panelstock, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelstock, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panelstock, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panelstock, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelstock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelstock.Location = new System.Drawing.Point(0, 0);
            this.panelstock.Name = "panelstock";
            this.panelstock.Size = new System.Drawing.Size(1727, 1044);
            this.panelstock.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.panelstock, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelstock, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelstock, "");
            this.panelstock.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTransition4.SetDecoration(this.flowLayoutPanel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.flowLayoutPanel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.flowLayoutPanel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.flowLayoutPanel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.flowLayoutPanel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 51);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1727, 976);
            this.flowLayoutPanel2.TabIndex = 19;
            this.bunifuToolTip1.SetToolTip(this.flowLayoutPanel2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.flowLayoutPanel2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.flowLayoutPanel2, "");
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.panel5);
            this.fade.SetDecoration(this.panel13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1727, 51);
            this.panel13.TabIndex = 21;
            this.bunifuToolTip1.SetToolTip(this.panel13, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel13, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel13, "");
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bunifuTextBox2);
            this.panel5.Controls.Add(this.bunifuImageButton3);
            this.fade.SetDecoration(this.panel5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(392, 51);
            this.panel5.TabIndex = 20;
            this.bunifuToolTip1.SetToolTip(this.panel5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel5, "");
            // 
            // bunifuTextBox2
            // 
            this.bunifuTextBox2.AcceptsReturn = false;
            this.bunifuTextBox2.AcceptsTab = false;
            this.bunifuTextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox2.BackgroundImage")));
            this.bunifuTextBox2.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuTextBox2.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBox2.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(120)))));
            this.bunifuTextBox2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTextBox2.BorderRadius = 1;
            this.bunifuTextBox2.BorderThickness = 6;
            this.bunifuTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.fade.SetDecoration(this.bunifuTextBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuTextBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuTextBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuTextBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuTextBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTextBox2.DefaultFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox2.DefaultText = "";
            this.bunifuTextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuTextBox2.HideSelection = true;
            this.bunifuTextBox2.IconLeft = null;
            this.bunifuTextBox2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox2.IconPadding = 10;
            this.bunifuTextBox2.IconRight = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox2.IconRight")));
            this.bunifuTextBox2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox2.Location = new System.Drawing.Point(3, 10);
            this.bunifuTextBox2.MaxLength = 32767;
            this.bunifuTextBox2.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox2.Modified = false;
            this.bunifuTextBox2.Name = "bunifuTextBox2";
            this.bunifuTextBox2.PasswordChar = '\0';
            this.bunifuTextBox2.ReadOnly = false;
            this.bunifuTextBox2.SelectedText = "";
            this.bunifuTextBox2.SelectionLength = 0;
            this.bunifuTextBox2.SelectionStart = 0;
            this.bunifuTextBox2.ShortcutsEnabled = true;
            this.bunifuTextBox2.Size = new System.Drawing.Size(337, 35);
            this.bunifuTextBox2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.bunifuTextBox2.TabIndex = 13;
            this.bunifuTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox2.TextMarginLeft = 5;
            this.bunifuTextBox2.TextPlaceholder = "Quick Search";
            this.bunifuToolTip1.SetToolTip(this.bunifuTextBox2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuTextBox2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuTextBox2, "");
            this.bunifuTextBox2.UseSystemPasswordChar = false;
            this.bunifuTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuTextBox2_KeyDown);
            // 
            // bunifuImageButton3
            // 
            this.fade.SetDecoration(this.bunifuImageButton3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(346, 12);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(36, 33);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 12;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton3, "");
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(0, 1027);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1727, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "No Data Available";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label1, "");
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.panelmain.Controls.Add(this.panelproducts);
            this.panelmain.Controls.Add(this.panelreports);
            this.panelmain.Controls.Add(this.paneldashboard);
            this.panelmain.Controls.Add(this.panelstock);
            this.panelmain.Controls.Add(this.panelusers);
            this.fade.SetDecoration(this.panelmain, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panelmain, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelmain, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panelmain, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panelmain, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(193, 36);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1727, 1044);
            this.panelmain.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.panelmain, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelmain, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelmain, "");
            // 
            // panelreports
            // 
            this.panelreports.Controls.Add(this.panel64);
            this.panelreports.Controls.Add(this.panel39);
            this.panelreports.Controls.Add(this.panel47);
            this.panelreports.Controls.Add(this.panel38);
            this.fade.SetDecoration(this.panelreports, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panelreports, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelreports, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panelreports, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panelreports, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelreports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelreports.Location = new System.Drawing.Point(0, 0);
            this.panelreports.Name = "panelreports";
            this.panelreports.Size = new System.Drawing.Size(1727, 1044);
            this.panelreports.TabIndex = 7;
            this.bunifuToolTip1.SetToolTip(this.panelreports, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelreports, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelreports, "");
            // 
            // panel64
            // 
            this.panel64.Controls.Add(this.panelreportcharts);
            this.panel64.Controls.Add(this.panelexpiredproducts);
            this.panel64.Controls.Add(this.paneldebts);
            this.fade.SetDecoration(this.panel64, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel64, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel64, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel64, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel64, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel64.Location = new System.Drawing.Point(15, 61);
            this.panel64.Name = "panel64";
            this.panel64.Size = new System.Drawing.Size(1712, 983);
            this.panel64.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.panel64, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel64, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel64, "");
            // 
            // panelreportcharts
            // 
            this.panelreportcharts.Controls.Add(this.bunifuImageButton39);
            this.panelreportcharts.Controls.Add(this.bunifuImageButton38);
            this.panelreportcharts.Controls.Add(this.bunifuSeparator23);
            this.panelreportcharts.Controls.Add(this.dateTimePicker2);
            this.panelreportcharts.Controls.Add(this.dateTimePicker1);
            this.panelreportcharts.Controls.Add(this.label47);
            this.panelreportcharts.Controls.Add(this.label44);
            this.panelreportcharts.Controls.Add(this.bunifuDatepicker1);
            this.panelreportcharts.Controls.Add(this.bunifuSeparator20);
            this.panelreportcharts.Controls.Add(this.bunifuImageButton37);
            this.panelreportcharts.Controls.Add(this.label43);
            this.panelreportcharts.Controls.Add(this.bunifuSeparator19);
            this.panelreportcharts.Controls.Add(this.bunifuImageButton36);
            this.panelreportcharts.Controls.Add(this.bunifuImageButton35);
            this.panelreportcharts.Controls.Add(this.bunifuDataViz5);
            this.panelreportcharts.Controls.Add(this.panel67);
            this.panelreportcharts.Controls.Add(this.label30);
            this.panelreportcharts.Controls.Add(this.label6);
            this.panelreportcharts.Controls.Add(this.bunifuSeparator18);
            this.panelreportcharts.Controls.Add(this.bunifuDataViz4);
            this.panelreportcharts.Controls.Add(this.bunifuDropdown4);
            this.panelreportcharts.Controls.Add(this.bunifuSeparator17);
            this.panelreportcharts.Controls.Add(this.label28);
            this.panelreportcharts.Controls.Add(this.panel66);
            this.panelreportcharts.Controls.Add(this.bunifuSeparator16);
            this.panelreportcharts.Controls.Add(this.bunifuDataViz3);
            this.fade.SetDecoration(this.panelreportcharts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panelreportcharts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelreportcharts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panelreportcharts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panelreportcharts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelreportcharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelreportcharts.Location = new System.Drawing.Point(0, 0);
            this.panelreportcharts.Name = "panelreportcharts";
            this.panelreportcharts.Size = new System.Drawing.Size(1712, 983);
            this.panelreportcharts.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.panelreportcharts, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelreportcharts, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelreportcharts, "");
            this.panelreportcharts.Visible = false;
            // 
            // bunifuImageButton39
            // 
            this.fade.SetDecoration(this.bunifuImageButton39, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton39, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton39, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton39, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton39, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton39.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton39.Image")));
            this.bunifuImageButton39.ImageActive = null;
            this.bunifuImageButton39.Location = new System.Drawing.Point(1280, 498);
            this.bunifuImageButton39.Name = "bunifuImageButton39";
            this.bunifuImageButton39.Size = new System.Drawing.Size(28, 39);
            this.bunifuImageButton39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton39.TabIndex = 123;
            this.bunifuImageButton39.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton39, "Print summary report");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton39, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton39, "");
            this.bunifuImageButton39.Zoom = 10;
            this.bunifuImageButton39.Click += new System.EventHandler(this.bunifuImageButton39_Click);
            // 
            // bunifuImageButton38
            // 
            this.fade.SetDecoration(this.bunifuImageButton38, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton38, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton38, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton38, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton38, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton38.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton38.Image")));
            this.bunifuImageButton38.ImageActive = null;
            this.bunifuImageButton38.Location = new System.Drawing.Point(1314, 498);
            this.bunifuImageButton38.Name = "bunifuImageButton38";
            this.bunifuImageButton38.Size = new System.Drawing.Size(28, 39);
            this.bunifuImageButton38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton38.TabIndex = 122;
            this.bunifuImageButton38.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton38, "Print summary report");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton38, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton38, "");
            this.bunifuImageButton38.Zoom = 10;
            // 
            // bunifuSeparator23
            // 
            this.bunifuSeparator23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuSeparator23.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator23.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator23.LineThickness = 1;
            this.bunifuSeparator23.Location = new System.Drawing.Point(820, 500);
            this.bunifuSeparator23.Name = "bunifuSeparator23";
            this.bunifuSeparator23.Size = new System.Drawing.Size(8, 36);
            this.bunifuSeparator23.TabIndex = 121;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator23, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator23, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator23, "");
            this.bunifuSeparator23.Transparency = 255;
            this.bunifuSeparator23.Vertical = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuTransition4.SetDecoration(this.dateTimePicker2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.dateTimePicker2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.dateTimePicker2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.dateTimePicker2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.dateTimePicker2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.dateTimePicker2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(1105, 507);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(169, 23);
            this.dateTimePicker2.TabIndex = 120;
            this.bunifuToolTip1.SetToolTip(this.dateTimePicker2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.dateTimePicker2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.dateTimePicker2, "");
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.bunifuTransition4.SetDecoration(this.dateTimePicker1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.dateTimePicker1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.dateTimePicker1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.dateTimePicker1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.dateTimePicker1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.dateTimePicker1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(893, 507);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 23);
            this.dateTimePicker1.TabIndex = 119;
            this.bunifuToolTip1.SetToolTip(this.dateTimePicker1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.dateTimePicker1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.dateTimePicker1, "");
            // 
            // label47
            // 
            this.label47.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label47.AutoSize = true;
            this.fade.SetDecoration(this.label47, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label47, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label47, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label47, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label47, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label47.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label47.Location = new System.Drawing.Point(1068, 508);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(31, 19);
            this.label47.TabIndex = 118;
            this.label47.Text = "To:";
            this.bunifuToolTip1.SetToolTip(this.label47, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label47, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label47, "");
            // 
            // label44
            // 
            this.label44.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label44.AutoSize = true;
            this.fade.SetDecoration(this.label44, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label44, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label44, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label44, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label44, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label44.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label44.Location = new System.Drawing.Point(842, 508);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(49, 19);
            this.label44.TabIndex = 116;
            this.label44.Text = "From:";
            this.bunifuToolTip1.SetToolTip(this.label44, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label44, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label44, "");
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.bunifuDatepicker1.BorderRadius = 0;
            this.fade.SetDecoration(this.bunifuDatepicker1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuDatepicker1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuDatepicker1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuDatepicker1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuDatepicker1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(567, 502);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(229, 30);
            this.bunifuDatepicker1.TabIndex = 114;
            this.bunifuToolTip1.SetToolTip(this.bunifuDatepicker1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuDatepicker1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuDatepicker1, "");
            this.bunifuDatepicker1.Value = new System.DateTime(2020, 4, 27, 16, 19, 18, 822);
            // 
            // bunifuSeparator20
            // 
            this.bunifuSeparator20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuSeparator20.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator20.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator20.LineThickness = 1;
            this.bunifuSeparator20.Location = new System.Drawing.Point(291, 10);
            this.bunifuSeparator20.Name = "bunifuSeparator20";
            this.bunifuSeparator20.Size = new System.Drawing.Size(8, 949);
            this.bunifuSeparator20.TabIndex = 32;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator20, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator20, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator20, "");
            this.bunifuSeparator20.Transparency = 255;
            this.bunifuSeparator20.Vertical = true;
            // 
            // bunifuImageButton37
            // 
            this.bunifuImageButton37.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fade.SetDecoration(this.bunifuImageButton37, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton37, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton37, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton37, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton37, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton37.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton37.Image")));
            this.bunifuImageButton37.ImageActive = null;
            this.bunifuImageButton37.Location = new System.Drawing.Point(311, 498);
            this.bunifuImageButton37.Name = "bunifuImageButton37";
            this.bunifuImageButton37.Size = new System.Drawing.Size(34, 39);
            this.bunifuImageButton37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton37.TabIndex = 31;
            this.bunifuImageButton37.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton37, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton37, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton37, "");
            this.bunifuImageButton37.Zoom = 10;
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label43.AutoSize = true;
            this.fade.SetDecoration(this.label43, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label43, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label43, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label43, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label43, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label43.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label43.Location = new System.Drawing.Point(355, 508);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(184, 19);
            this.label43.TabIndex = 30;
            this.label43.Text = "Sales for the last 6 hours";
            this.bunifuToolTip1.SetToolTip(this.label43, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label43, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label43, "");
            // 
            // bunifuSeparator19
            // 
            this.bunifuSeparator19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuSeparator19.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator19.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator19.LineThickness = 1;
            this.bunifuSeparator19.Location = new System.Drawing.Point(543, 500);
            this.bunifuSeparator19.Name = "bunifuSeparator19";
            this.bunifuSeparator19.Size = new System.Drawing.Size(8, 36);
            this.bunifuSeparator19.TabIndex = 29;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator19, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator19, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator19, "");
            this.bunifuSeparator19.Transparency = 255;
            this.bunifuSeparator19.Vertical = true;
            // 
            // bunifuImageButton36
            // 
            this.fade.SetDecoration(this.bunifuImageButton36, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton36, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton36, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton36, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton36, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton36.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton36.Image")));
            this.bunifuImageButton36.ImageActive = null;
            this.bunifuImageButton36.Location = new System.Drawing.Point(999, 6);
            this.bunifuImageButton36.Name = "bunifuImageButton36";
            this.bunifuImageButton36.Size = new System.Drawing.Size(34, 39);
            this.bunifuImageButton36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton36.TabIndex = 28;
            this.bunifuImageButton36.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton36, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton36, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton36, "");
            this.bunifuImageButton36.Zoom = 10;
            // 
            // bunifuImageButton35
            // 
            this.bunifuImageButton35.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fade.SetDecoration(this.bunifuImageButton35, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton35, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton35, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton35, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton35, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton35.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton35.Image")));
            this.bunifuImageButton35.ImageActive = null;
            this.bunifuImageButton35.Location = new System.Drawing.Point(311, 6);
            this.bunifuImageButton35.Name = "bunifuImageButton35";
            this.bunifuImageButton35.Size = new System.Drawing.Size(34, 39);
            this.bunifuImageButton35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton35.TabIndex = 24;
            this.bunifuImageButton35.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton35, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton35, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton35, "");
            this.bunifuImageButton35.Zoom = 10;
            // 
            // bunifuDataViz5
            // 
            this.bunifuDataViz5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuDataViz5.animationEnabled = true;
            this.bunifuDataViz5.AxisLineColor = System.Drawing.Color.LightGray;
            this.bunifuDataViz5.AxisXFontColor = System.Drawing.Color.Gray;
            this.bunifuDataViz5.AxisXGridColor = System.Drawing.Color.Gray;
            this.bunifuDataViz5.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDataViz5.AxisYFontColor = System.Drawing.Color.White;
            this.bunifuDataViz5.AxisYGridColor = System.Drawing.Color.White;
            this.bunifuDataViz5.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDataViz5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuDataViz5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition2.SetDecoration(this.bunifuDataViz5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuDataViz5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuDataViz5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.bunifuDataViz5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuDataViz5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuDataViz5.Location = new System.Drawing.Point(311, 543);
            this.bunifuDataViz5.Name = "bunifuDataViz5";
            this.bunifuDataViz5.Size = new System.Drawing.Size(1389, 416);
            this.bunifuDataViz5.TabIndex = 27;
            this.bunifuDataViz5.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme1;
            this.bunifuDataViz5.Title = "";
            this.bunifuToolTip1.SetToolTip(this.bunifuDataViz5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuDataViz5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuDataViz5, "");
            // 
            // panel67
            // 
            this.panel67.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel67.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel67.Controls.Add(this.label41);
            this.panel67.Controls.Add(this.bunifuImageButton34);
            this.panel67.Controls.Add(this.label42);
            this.fade.SetDecoration(this.panel67, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel67, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel67, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel67, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel67, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel67.Location = new System.Drawing.Point(6, 173);
            this.panel67.Name = "panel67";
            this.panel67.Size = new System.Drawing.Size(277, 113);
            this.panel67.TabIndex = 26;
            this.bunifuToolTip1.SetToolTip(this.panel67, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel67, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel67, "");
            // 
            // label41
            // 
            this.fade.SetDecoration(this.label41, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label41, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label41, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label41, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label41, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label41.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.DimGray;
            this.label41.Location = new System.Drawing.Point(11, 82);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(261, 18);
            this.label41.TabIndex = 23;
            this.label41.Text = "In this current month";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.label41, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label41, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label41, "");
            // 
            // bunifuImageButton34
            // 
            this.fade.SetDecoration(this.bunifuImageButton34, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton34, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton34, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton34, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton34, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton34.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton34.Image")));
            this.bunifuImageButton34.ImageActive = null;
            this.bunifuImageButton34.Location = new System.Drawing.Point(15, 13);
            this.bunifuImageButton34.Name = "bunifuImageButton34";
            this.bunifuImageButton34.Size = new System.Drawing.Size(60, 64);
            this.bunifuImageButton34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton34.TabIndex = 22;
            this.bunifuImageButton34.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton34, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton34, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton34, "");
            this.bunifuImageButton34.Zoom = 10;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.fade.SetDecoration(this.label42, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label42, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label42, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label42, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label42, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label42.Font = new System.Drawing.Font("Roboto Lt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label42.Location = new System.Drawing.Point(108, 34);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(165, 23);
            this.label42.TabIndex = 21;
            this.label42.Text = "Sales per category";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.label42, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label42, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label42, "");
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label30.AutoSize = true;
            this.fade.SetDecoration(this.label30, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label30, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label30, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label30, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label30, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label30.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label30.Location = new System.Drawing.Point(1043, 14);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(124, 19);
            this.label30.TabIndex = 25;
            this.label30.Text = "Qty sold per unit";
            this.bunifuToolTip1.SetToolTip(this.label30, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label30, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label30, "");
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.fade.SetDecoration(this.label6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label6.Location = new System.Drawing.Point(351, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Sales per category";
            this.bunifuToolTip1.SetToolTip(this.label6, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label6, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label6, "");
            // 
            // bunifuSeparator18
            // 
            this.bunifuSeparator18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuSeparator18.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator18.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator18.LineThickness = 1;
            this.bunifuSeparator18.Location = new System.Drawing.Point(1180, 6);
            this.bunifuSeparator18.Name = "bunifuSeparator18";
            this.bunifuSeparator18.Size = new System.Drawing.Size(8, 34);
            this.bunifuSeparator18.TabIndex = 23;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator18, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator18, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator18, "");
            this.bunifuSeparator18.Transparency = 255;
            this.bunifuSeparator18.Vertical = true;
            // 
            // bunifuDataViz4
            // 
            this.bunifuDataViz4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuDataViz4.animationEnabled = true;
            this.bunifuDataViz4.AxisLineColor = System.Drawing.Color.LightGray;
            this.bunifuDataViz4.AxisXFontColor = System.Drawing.Color.Gray;
            this.bunifuDataViz4.AxisXGridColor = System.Drawing.Color.Gray;
            this.bunifuDataViz4.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDataViz4.AxisYFontColor = System.Drawing.Color.White;
            this.bunifuDataViz4.AxisYGridColor = System.Drawing.Color.White;
            this.bunifuDataViz4.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDataViz4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuDataViz4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition2.SetDecoration(this.bunifuDataViz4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuDataViz4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuDataViz4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.bunifuDataViz4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuDataViz4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuDataViz4.Location = new System.Drawing.Point(997, 49);
            this.bunifuDataViz4.Name = "bunifuDataViz4";
            this.bunifuDataViz4.Size = new System.Drawing.Size(703, 442);
            this.bunifuDataViz4.TabIndex = 21;
            this.bunifuDataViz4.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme1;
            this.bunifuDataViz4.Title = "";
            this.bunifuToolTip1.SetToolTip(this.bunifuDataViz4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuDataViz4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuDataViz4, "");
            // 
            // bunifuDropdown4
            // 
            this.bunifuDropdown4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuDropdown4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuDropdown4.BorderRadius = 5;
            this.bunifuDropdown4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.fade.SetDecoration(this.bunifuDropdown4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuDropdown4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuDropdown4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuDropdown4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuDropdown4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuDropdown4.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown4.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdown4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown4.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown4.FillDropDown = false;
            this.bunifuDropdown4.FillIndicator = false;
            this.bunifuDropdown4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdown4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuDropdown4.FormattingEnabled = true;
            this.bunifuDropdown4.Icon = null;
            this.bunifuDropdown4.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.bunifuDropdown4.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown4.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuDropdown4.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuDropdown4.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuDropdown4.ItemHeight = 26;
            this.bunifuDropdown4.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuDropdown4.Items.AddRange(new object[] {
            "BG1",
            "BG2",
            "BG3",
            "BG4",
            "None"});
            this.bunifuDropdown4.Location = new System.Drawing.Point(138, 9);
            this.bunifuDropdown4.Name = "bunifuDropdown4";
            this.bunifuDropdown4.Size = new System.Drawing.Size(146, 32);
            this.bunifuDropdown4.TabIndex = 20;
            this.bunifuDropdown4.Text = null;
            this.bunifuToolTip1.SetToolTip(this.bunifuDropdown4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuDropdown4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuDropdown4, "");
            // 
            // bunifuSeparator17
            // 
            this.bunifuSeparator17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuSeparator17.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator17.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator17.LineThickness = 1;
            this.bunifuSeparator17.Location = new System.Drawing.Point(122, 6);
            this.bunifuSeparator17.Name = "bunifuSeparator17";
            this.bunifuSeparator17.Size = new System.Drawing.Size(8, 34);
            this.bunifuSeparator17.TabIndex = 12;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator17, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator17, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator17, "");
            this.bunifuSeparator17.Transparency = 255;
            this.bunifuSeparator17.Vertical = true;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.fade.SetDecoration(this.label28, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label28, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label28, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label28, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label28, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label28.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label28.Location = new System.Drawing.Point(7, 14);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(108, 19);
            this.label28.TabIndex = 11;
            this.label28.Text = "Revenue as of";
            this.bunifuToolTip1.SetToolTip(this.label28, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label28, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label28, "");
            // 
            // panel66
            // 
            this.panel66.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel66.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel66.Controls.Add(this.label31);
            this.panel66.Controls.Add(this.bunifuImageButton33);
            this.panel66.Controls.Add(this.label29);
            this.fade.SetDecoration(this.panel66, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel66, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel66, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel66, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel66, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel66.Location = new System.Drawing.Point(7, 49);
            this.panel66.Name = "panel66";
            this.panel66.Size = new System.Drawing.Size(277, 113);
            this.panel66.TabIndex = 10;
            this.bunifuToolTip1.SetToolTip(this.panel66, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel66, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel66, "");
            // 
            // label31
            // 
            this.fade.SetDecoration(this.label31, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label31, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label31, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label31, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label31, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label31.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.DimGray;
            this.label31.Location = new System.Drawing.Point(11, 82);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(261, 18);
            this.label31.TabIndex = 23;
            this.label31.Text = "In this current month";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.label31, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label31, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label31, "");
            // 
            // bunifuImageButton33
            // 
            this.fade.SetDecoration(this.bunifuImageButton33, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton33, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton33, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton33, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton33, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton33.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton33.Image")));
            this.bunifuImageButton33.ImageActive = null;
            this.bunifuImageButton33.Location = new System.Drawing.Point(15, 13);
            this.bunifuImageButton33.Name = "bunifuImageButton33";
            this.bunifuImageButton33.Size = new System.Drawing.Size(60, 64);
            this.bunifuImageButton33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton33.TabIndex = 22;
            this.bunifuImageButton33.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton33, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton33, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton33, "");
            this.bunifuImageButton33.Zoom = 10;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.fade.SetDecoration(this.label29, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label29, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label29, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label29, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label29, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label29.Font = new System.Drawing.Font("Roboto Lt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label29.Location = new System.Drawing.Point(108, 34);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(165, 23);
            this.label29.TabIndex = 21;
            this.label29.Text = "Sales per category";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.label29, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label29, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label29, "");
            // 
            // bunifuSeparator16
            // 
            this.bunifuSeparator16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuSeparator16.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator16.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator16.LineThickness = 1;
            this.bunifuSeparator16.Location = new System.Drawing.Point(491, 6);
            this.bunifuSeparator16.Name = "bunifuSeparator16";
            this.bunifuSeparator16.Size = new System.Drawing.Size(8, 34);
            this.bunifuSeparator16.TabIndex = 9;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator16, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator16, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator16, "");
            this.bunifuSeparator16.Transparency = 255;
            this.bunifuSeparator16.Vertical = true;
            // 
            // bunifuDataViz3
            // 
            this.bunifuDataViz3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuDataViz3.animationEnabled = true;
            this.bunifuDataViz3.AxisLineColor = System.Drawing.Color.LightGray;
            this.bunifuDataViz3.AxisXFontColor = System.Drawing.Color.Gray;
            this.bunifuDataViz3.AxisXGridColor = System.Drawing.Color.Gray;
            this.bunifuDataViz3.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDataViz3.AxisYFontColor = System.Drawing.Color.White;
            this.bunifuDataViz3.AxisYGridColor = System.Drawing.Color.White;
            this.bunifuDataViz3.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDataViz3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuDataViz3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition2.SetDecoration(this.bunifuDataViz3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuDataViz3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuDataViz3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.bunifuDataViz3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuDataViz3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuDataViz3.Location = new System.Drawing.Point(311, 49);
            this.bunifuDataViz3.Name = "bunifuDataViz3";
            this.bunifuDataViz3.Size = new System.Drawing.Size(680, 442);
            this.bunifuDataViz3.TabIndex = 0;
            this.bunifuDataViz3.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme1;
            this.bunifuDataViz3.Title = "";
            this.bunifuToolTip1.SetToolTip(this.bunifuDataViz3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuDataViz3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuDataViz3, "");
            // 
            // panelexpiredproducts
            // 
            this.panelexpiredproducts.Controls.Add(this.bunifuCustomDataGrid1);
            this.panelexpiredproducts.Controls.Add(this.panel63);
            this.fade.SetDecoration(this.panelexpiredproducts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panelexpiredproducts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelexpiredproducts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panelexpiredproducts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panelexpiredproducts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelexpiredproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelexpiredproducts.Location = new System.Drawing.Point(0, 0);
            this.panelexpiredproducts.Name = "panelexpiredproducts";
            this.panelexpiredproducts.Size = new System.Drawing.Size(1712, 983);
            this.panelexpiredproducts.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.panelexpiredproducts, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelexpiredproducts, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelexpiredproducts, "");
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            this.bunifuCustomDataGrid1.AllowUserToOrderColumns = true;
            this.bunifuCustomDataGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7});
            this.bunifuTransition4.SetDecoration(this.bunifuCustomDataGrid1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuCustomDataGrid1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuCustomDataGrid1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuCustomDataGrid1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.bunifuCustomDataGrid1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(21, 67);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersVisible = false;
            this.bunifuCustomDataGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.bunifuCustomDataGrid1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1063, 638);
            this.bunifuCustomDataGrid1.TabIndex = 90;
            this.bunifuToolTip1.SetToolTip(this.bunifuCustomDataGrid1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuCustomDataGrid1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuCustomDataGrid1, "");
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Prod no.";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 130;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Prod name";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 350;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Rem. stock";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 140;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Cost sale";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            this.dataGridViewTextBoxColumn18.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sale price";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Unit desc";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Category";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Expiry date";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 170;
            // 
            // panel63
            // 
            this.panel63.Controls.Add(this.bunifuImageButton32);
            this.panel63.Controls.Add(this.bunifuImageButton31);
            this.panel63.Controls.Add(this.bunifuTextBox5);
            this.fade.SetDecoration(this.panel63, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel63, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel63, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel63, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel63, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel63.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel63.Location = new System.Drawing.Point(0, 0);
            this.panel63.Name = "panel63";
            this.panel63.Size = new System.Drawing.Size(1712, 48);
            this.panel63.TabIndex = 21;
            this.bunifuToolTip1.SetToolTip(this.panel63, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel63, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel63, "");
            // 
            // bunifuImageButton32
            // 
            this.fade.SetDecoration(this.bunifuImageButton32, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton32, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton32, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton32, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton32, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton32.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton32.Image")));
            this.bunifuImageButton32.ImageActive = null;
            this.bunifuImageButton32.Location = new System.Drawing.Point(373, 10);
            this.bunifuImageButton32.Name = "bunifuImageButton32";
            this.bunifuImageButton32.Size = new System.Drawing.Size(36, 33);
            this.bunifuImageButton32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton32.TabIndex = 13;
            this.bunifuImageButton32.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton32, "Print data");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton32, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton32, "");
            this.bunifuImageButton32.Zoom = 10;
            this.bunifuImageButton32.Click += new System.EventHandler(this.bunifuImageButton32_Click);
            // 
            // bunifuImageButton31
            // 
            this.fade.SetDecoration(this.bunifuImageButton31, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton31, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton31, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton31, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton31, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton31.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton31.Image")));
            this.bunifuImageButton31.ImageActive = null;
            this.bunifuImageButton31.Location = new System.Drawing.Point(331, 10);
            this.bunifuImageButton31.Name = "bunifuImageButton31";
            this.bunifuImageButton31.Size = new System.Drawing.Size(36, 33);
            this.bunifuImageButton31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton31.TabIndex = 12;
            this.bunifuImageButton31.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton31, "Refresh data");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton31, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton31, "");
            this.bunifuImageButton31.Zoom = 10;
            // 
            // bunifuTextBox5
            // 
            this.bunifuTextBox5.AcceptsReturn = false;
            this.bunifuTextBox5.AcceptsTab = false;
            this.bunifuTextBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(123)))));
            this.bunifuTextBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox5.BackgroundImage")));
            this.bunifuTextBox5.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuTextBox5.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBox5.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(120)))));
            this.bunifuTextBox5.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(123)))));
            this.bunifuTextBox5.BorderRadius = 1;
            this.bunifuTextBox5.BorderThickness = 6;
            this.bunifuTextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.fade.SetDecoration(this.bunifuTextBox5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuTextBox5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuTextBox5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuTextBox5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuTextBox5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTextBox5.DefaultFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox5.DefaultText = "";
            this.bunifuTextBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(123)))));
            this.bunifuTextBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuTextBox5.HideSelection = true;
            this.bunifuTextBox5.IconLeft = null;
            this.bunifuTextBox5.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox5.IconPadding = 10;
            this.bunifuTextBox5.IconRight = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox5.IconRight")));
            this.bunifuTextBox5.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox5.Location = new System.Drawing.Point(3, 8);
            this.bunifuTextBox5.MaxLength = 32767;
            this.bunifuTextBox5.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox5.Modified = false;
            this.bunifuTextBox5.Name = "bunifuTextBox5";
            this.bunifuTextBox5.PasswordChar = '\0';
            this.bunifuTextBox5.ReadOnly = false;
            this.bunifuTextBox5.SelectedText = "";
            this.bunifuTextBox5.SelectionLength = 0;
            this.bunifuTextBox5.SelectionStart = 0;
            this.bunifuTextBox5.ShortcutsEnabled = true;
            this.bunifuTextBox5.Size = new System.Drawing.Size(322, 35);
            this.bunifuTextBox5.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.bunifuTextBox5.TabIndex = 0;
            this.bunifuTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox5.TextMarginLeft = 5;
            this.bunifuTextBox5.TextPlaceholder = "Quick Search";
            this.bunifuToolTip1.SetToolTip(this.bunifuTextBox5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuTextBox5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuTextBox5, "");
            this.bunifuTextBox5.UseSystemPasswordChar = false;
            // 
            // paneldebts
            // 
            this.paneldebts.Controls.Add(this.splitterControl1);
            this.paneldebts.Controls.Add(this.panel48);
            this.paneldebts.Controls.Add(this.panel40);
            this.fade.SetDecoration(this.paneldebts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.paneldebts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.paneldebts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.paneldebts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.paneldebts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.paneldebts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldebts.Location = new System.Drawing.Point(0, 0);
            this.paneldebts.Name = "paneldebts";
            this.paneldebts.Size = new System.Drawing.Size(1712, 983);
            this.paneldebts.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.paneldebts, "");
            this.bunifuToolTip1.SetToolTipIcon(this.paneldebts, null);
            this.bunifuToolTip1.SetToolTipTitle(this.paneldebts, "");
            // 
            // splitterControl1
            // 
            this.fade.SetDecoration(this.splitterControl1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.splitterControl1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.splitterControl1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.splitterControl1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.splitterControl1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.splitterControl1.Location = new System.Drawing.Point(879, 0);
            this.splitterControl1.MinExtra = 742;
            this.splitterControl1.MinSize = 183;
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 983);
            this.splitterControl1.TabIndex = 4;
            this.splitterControl1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.splitterControl1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.splitterControl1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.splitterControl1, "");
            // 
            // panel48
            // 
            this.panel48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel48.Controls.Add(this.bunifuDataGridView1);
            this.panel48.Controls.Add(this.bunifuVScrollBar3);
            this.panel48.Controls.Add(this.panel50);
            this.panel48.Controls.Add(this.bunifuSeparator11);
            this.panel48.Controls.Add(this.panel49);
            this.fade.SetDecoration(this.panel48, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel48, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel48, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel48, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel48, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel48.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel48.Location = new System.Drawing.Point(0, 0);
            this.panel48.Name = "panel48";
            this.panel48.Size = new System.Drawing.Size(879, 983);
            this.panel48.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.panel48, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel48, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel48, "");
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowUserToAddRows = false;
            this.bunifuDataGridView1.AllowUserToDeleteRows = false;
            this.bunifuDataGridView1.AllowUserToOrderColumns = true;
            this.bunifuDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.bunifuTransition4.SetDecoration(this.bunifuDataGridView1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuDataGridView1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuDataGridView1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuDataGridView1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.bunifuDataGridView1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.bunifuDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuDataGridView1.DoubleBuffered = true;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(0, 71);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.ReadOnly = true;
            this.bunifuDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.bunifuDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(860, 817);
            this.bunifuDataGridView1.TabIndex = 89;
            this.bunifuToolTip1.SetToolTip(this.bunifuDataGridView1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuDataGridView1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuDataGridView1, "");
            this.bunifuDataGridView1.Click += new System.EventHandler(this.bunifuDataGridView1_Click);
            this.bunifuDataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuDataGridView1_KeyDown);
            this.bunifuDataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bunifuDataGridView1_KeyUp);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "";
            this.dataGridViewTextBoxColumn6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.Width = 17;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Full name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 350;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Address";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 180;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Mobile #";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 140;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.ActiveLinkColor = System.Drawing.Color.IndianRed;
            this.dataGridViewTextBoxColumn10.HeaderText = "email";
            this.dataGridViewTextBoxColumn10.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewTextBoxColumn10.Width = 140;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "id";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 120;
            // 
            // bunifuVScrollBar3
            // 
            this.bunifuVScrollBar3.AllowCursorChanges = true;
            this.bunifuVScrollBar3.AllowHomeEndKeysDetection = false;
            this.bunifuVScrollBar3.AllowIncrementalClickMoves = true;
            this.bunifuVScrollBar3.AllowMouseDownEffects = true;
            this.bunifuVScrollBar3.AllowMouseHoverEffects = true;
            this.bunifuVScrollBar3.AllowScrollingAnimations = true;
            this.bunifuVScrollBar3.AllowScrollKeysDetection = true;
            this.bunifuVScrollBar3.AllowScrollOptionsMenu = true;
            this.bunifuVScrollBar3.AllowShrinkingOnFocusLost = false;
            this.bunifuVScrollBar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar3.BackgroundImage")));
            this.bunifuVScrollBar3.BindingContainer = null;
            this.bunifuVScrollBar3.BorderRadius = 1;
            this.bunifuVScrollBar3.BorderThickness = 1;
            this.bunifuTransition2.SetDecoration(this.bunifuVScrollBar3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuVScrollBar3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuVScrollBar3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.bunifuVScrollBar3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuVScrollBar3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuVScrollBar3.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuVScrollBar3.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar3.LargeChange = 10;
            this.bunifuVScrollBar3.Location = new System.Drawing.Point(860, 71);
            this.bunifuVScrollBar3.Maximum = 100;
            this.bunifuVScrollBar3.Minimum = 0;
            this.bunifuVScrollBar3.MinimumThumbLength = 18;
            this.bunifuVScrollBar3.Name = "bunifuVScrollBar3";
            this.bunifuVScrollBar3.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar3.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuVScrollBar3.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar3.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuVScrollBar3.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuVScrollBar3.ShrinkSizeLimit = 3;
            this.bunifuVScrollBar3.Size = new System.Drawing.Size(17, 817);
            this.bunifuVScrollBar3.SmallChange = 1;
            this.bunifuVScrollBar3.TabIndex = 10;
            this.bunifuVScrollBar3.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuVScrollBar3.ThumbLength = 80;
            this.bunifuVScrollBar3.ThumbMargin = 1;
            this.bunifuVScrollBar3.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.bunifuToolTip1.SetToolTip(this.bunifuVScrollBar3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuVScrollBar3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuVScrollBar3, "");
            this.bunifuVScrollBar3.Value = 0;
            this.bunifuVScrollBar3.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs>(this.bunifuVScrollBar3_Scroll);
            // 
            // panel50
            // 
            this.panel50.Controls.Add(this.label37);
            this.panel50.Controls.Add(this.label20);
            this.panel50.Controls.Add(this.bunifuSeparator12);
            this.fade.SetDecoration(this.panel50, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel50, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel50, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel50, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel50, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel50.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel50.Location = new System.Drawing.Point(0, 888);
            this.panel50.Name = "panel50";
            this.panel50.Size = new System.Drawing.Size(877, 93);
            this.panel50.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.panel50, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel50, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel50, "");
            // 
            // label37
            // 
            this.fade.SetDecoration(this.label37, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label37, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label37, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label37, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label37, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label37.Dock = System.Windows.Forms.DockStyle.Left;
            this.label37.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(0, 20);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(362, 73);
            this.label37.TabIndex = 7;
            this.label37.Text = "Total Collectables:";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label37, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label37, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label37, "");
            // 
            // label20
            // 
            this.fade.SetDecoration(this.label20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label20.Dock = System.Windows.Forms.DockStyle.Right;
            this.label20.Font = new System.Drawing.Font("Roboto Bk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.label20.Location = new System.Drawing.Point(459, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(418, 73);
            this.label20.TabIndex = 6;
            this.label20.Text = "0.00";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.label20, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label20, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label20, "");
            // 
            // bunifuSeparator12
            // 
            this.bunifuSeparator12.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator12.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator12.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator12.LineThickness = 1;
            this.bunifuSeparator12.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator12.Name = "bunifuSeparator12";
            this.bunifuSeparator12.Size = new System.Drawing.Size(877, 20);
            this.bunifuSeparator12.TabIndex = 8;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator12, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator12, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator12, "");
            this.bunifuSeparator12.Transparency = 255;
            this.bunifuSeparator12.Vertical = false;
            // 
            // bunifuSeparator11
            // 
            this.bunifuSeparator11.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator11.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator11.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator11.LineThickness = 1;
            this.bunifuSeparator11.Location = new System.Drawing.Point(0, 51);
            this.bunifuSeparator11.Name = "bunifuSeparator11";
            this.bunifuSeparator11.Size = new System.Drawing.Size(877, 20);
            this.bunifuSeparator11.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator11, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator11, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator11, "");
            this.bunifuSeparator11.Transparency = 255;
            this.bunifuSeparator11.Vertical = false;
            // 
            // panel49
            // 
            this.panel49.Controls.Add(this.bunifuImageButton23);
            this.panel49.Controls.Add(this.bunifuImageButton22);
            this.panel49.Controls.Add(this.bunifuTextBox4);
            this.fade.SetDecoration(this.panel49, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel49, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel49, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel49, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel49, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel49.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel49.Location = new System.Drawing.Point(0, 0);
            this.panel49.Name = "panel49";
            this.panel49.Size = new System.Drawing.Size(877, 51);
            this.panel49.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.panel49, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel49, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel49, "");
            // 
            // bunifuImageButton23
            // 
            this.fade.SetDecoration(this.bunifuImageButton23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton23.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton23.Image")));
            this.bunifuImageButton23.ImageActive = null;
            this.bunifuImageButton23.Location = new System.Drawing.Point(601, 5);
            this.bunifuImageButton23.Name = "bunifuImageButton23";
            this.bunifuImageButton23.Size = new System.Drawing.Size(39, 39);
            this.bunifuImageButton23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton23.TabIndex = 14;
            this.bunifuImageButton23.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton23, "Settle all debts");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton23, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton23, "");
            this.bunifuImageButton23.Zoom = 10;
            this.bunifuImageButton23.Click += new System.EventHandler(this.bunifuImageButton23_Click);
            // 
            // bunifuImageButton22
            // 
            this.fade.SetDecoration(this.bunifuImageButton22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton22.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton22.Image")));
            this.bunifuImageButton22.ImageActive = null;
            this.bunifuImageButton22.Location = new System.Drawing.Point(556, 5);
            this.bunifuImageButton22.Name = "bunifuImageButton22";
            this.bunifuImageButton22.Size = new System.Drawing.Size(39, 39);
            this.bunifuImageButton22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton22.TabIndex = 13;
            this.bunifuImageButton22.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton22, "Print report for all these customers");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton22, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton22, "");
            this.bunifuImageButton22.Zoom = 10;
            this.bunifuImageButton22.Click += new System.EventHandler(this.bunifuImageButton22_Click);
            // 
            // bunifuTextBox4
            // 
            this.bunifuTextBox4.AcceptsReturn = false;
            this.bunifuTextBox4.AcceptsTab = false;
            this.bunifuTextBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTextBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox4.BackgroundImage")));
            this.bunifuTextBox4.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuTextBox4.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBox4.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(120)))));
            this.bunifuTextBox4.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTextBox4.BorderRadius = 1;
            this.bunifuTextBox4.BorderThickness = 6;
            this.bunifuTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.fade.SetDecoration(this.bunifuTextBox4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuTextBox4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuTextBox4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuTextBox4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuTextBox4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTextBox4.DefaultFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox4.DefaultText = "";
            this.bunifuTextBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTextBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuTextBox4.HideSelection = true;
            this.bunifuTextBox4.IconLeft = null;
            this.bunifuTextBox4.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox4.IconPadding = 10;
            this.bunifuTextBox4.IconRight = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox4.IconRight")));
            this.bunifuTextBox4.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox4.Location = new System.Drawing.Point(6, 9);
            this.bunifuTextBox4.MaxLength = 32767;
            this.bunifuTextBox4.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox4.Modified = false;
            this.bunifuTextBox4.Name = "bunifuTextBox4";
            this.bunifuTextBox4.PasswordChar = '\0';
            this.bunifuTextBox4.ReadOnly = false;
            this.bunifuTextBox4.SelectedText = "";
            this.bunifuTextBox4.SelectionLength = 0;
            this.bunifuTextBox4.SelectionStart = 0;
            this.bunifuTextBox4.ShortcutsEnabled = true;
            this.bunifuTextBox4.Size = new System.Drawing.Size(544, 35);
            this.bunifuTextBox4.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.bunifuTextBox4.TabIndex = 1;
            this.bunifuTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox4.TextMarginLeft = 5;
            this.bunifuTextBox4.TextPlaceholder = "Quick Search for full name";
            this.bunifuToolTip1.SetToolTip(this.bunifuTextBox4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuTextBox4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuTextBox4, "");
            this.bunifuTextBox4.UseSystemPasswordChar = false;
            this.bunifuTextBox4.OnIconRightClick += new System.EventHandler(this.bunifuTextBox4_OnIconRightClick);
            this.bunifuTextBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuTextBox4_KeyDown);
            // 
            // panel40
            // 
            this.panel40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel40.Controls.Add(this.bunifuDataGridView2);
            this.panel40.Controls.Add(this.bunifuSeparator10);
            this.panel40.Controls.Add(this.panel44);
            this.panel40.Controls.Add(this.panel41);
            this.fade.SetDecoration(this.panel40, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel40, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel40, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel40, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel40, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel40.Location = new System.Drawing.Point(884, 10);
            this.panel40.MinimumSize = new System.Drawing.Size(183, 813);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(762, 983);
            this.panel40.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.panel40, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel40, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel40, "");
            // 
            // bunifuDataGridView2
            // 
            this.bunifuDataGridView2.AllowCustomTheming = true;
            this.bunifuDataGridView2.AllowUserToAddRows = false;
            this.bunifuDataGridView2.AllowUserToDeleteRows = false;
            this.bunifuDataGridView2.AllowUserToOrderColumns = true;
            this.bunifuDataGridView2.AllowUserToResizeColumns = false;
            this.bunifuDataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.bunifuDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bunifuDataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.bunifuDataGridView2.ColumnHeadersHeight = 40;
            this.bunifuDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column6});
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuDataGridView2.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.bunifuDataGridView2.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.Name = null;
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuTransition2.SetDecoration(this.bunifuDataGridView2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuDataGridView2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuDataGridView2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.bunifuDataGridView2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuDataGridView2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView2.DefaultCellStyle = dataGridViewCellStyle11;
            this.bunifuDataGridView2.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.bunifuDataGridView2.HeaderBackColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView2.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView2.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.Location = new System.Drawing.Point(0, 201);
            this.bunifuDataGridView2.Name = "bunifuDataGridView2";
            this.bunifuDataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuDataGridView2.RowHeadersVisible = false;
            this.bunifuDataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.bunifuDataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.bunifuDataGridView2.RowTemplate.Height = 40;
            this.bunifuDataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView2.Size = new System.Drawing.Size(787, 687);
            this.bunifuDataGridView2.TabIndex = 8;
            this.bunifuDataGridView2.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.bunifuToolTip1.SetToolTip(this.bunifuDataGridView2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuDataGridView2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuDataGridView2, "");
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.FillWeight = 121.8274F;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Product name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 135;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.FillWeight = 121.8274F;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tran Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 102;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.FillWeight = 121.8274F;
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 69;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.FillWeight = 121.8274F;
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 59;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.FillWeight = 12.69036F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Sub total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 99;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "By";
            this.Column6.Name = "Column6";
            this.Column6.Width = 51;
            // 
            // bunifuSeparator10
            // 
            this.bunifuSeparator10.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator10.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator10.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator10.LineThickness = 1;
            this.bunifuSeparator10.Location = new System.Drawing.Point(0, 138);
            this.bunifuSeparator10.Name = "bunifuSeparator10";
            this.bunifuSeparator10.Size = new System.Drawing.Size(760, 20);
            this.bunifuSeparator10.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator10, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator10, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator10, "");
            this.bunifuSeparator10.Transparency = 255;
            this.bunifuSeparator10.Vertical = false;
            // 
            // panel44
            // 
            this.panel44.Controls.Add(this.label39);
            this.panel44.Controls.Add(this.label38);
            this.panel44.Controls.Add(this.bunifuSeparator13);
            this.fade.SetDecoration(this.panel44, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel44, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel44, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel44, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel44, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel44.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel44.Location = new System.Drawing.Point(0, 888);
            this.panel44.Name = "panel44";
            this.panel44.Size = new System.Drawing.Size(760, 93);
            this.panel44.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.panel44, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel44, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel44, "");
            // 
            // label39
            // 
            this.fade.SetDecoration(this.label39, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label39, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label39, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label39, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label39, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label39.Dock = System.Windows.Forms.DockStyle.Left;
            this.label39.Font = new System.Drawing.Font("Roboto Lt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(0, 20);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(136, 73);
            this.label39.TabIndex = 8;
            this.label39.Text = "Collectables:";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label39, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label39, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label39, "");
            // 
            // label38
            // 
            this.fade.SetDecoration(this.label38, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label38, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label38, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label38, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label38, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label38.Dock = System.Windows.Forms.DockStyle.Right;
            this.label38.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.label38.Location = new System.Drawing.Point(316, 20);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(444, 73);
            this.label38.TabIndex = 7;
            this.label38.Text = "0.00";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.label38, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label38, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label38, "");
            // 
            // bunifuSeparator13
            // 
            this.bunifuSeparator13.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator13.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator13.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator13.LineThickness = 1;
            this.bunifuSeparator13.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator13.Name = "bunifuSeparator13";
            this.bunifuSeparator13.Size = new System.Drawing.Size(760, 20);
            this.bunifuSeparator13.TabIndex = 9;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator13, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator13, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator13, "");
            this.bunifuSeparator13.Transparency = 255;
            this.bunifuSeparator13.Vertical = false;
            // 
            // panel41
            // 
            this.panel41.Controls.Add(this.panel43);
            this.panel41.Controls.Add(this.panel42);
            this.fade.SetDecoration(this.panel41, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel41, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel41, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel41, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel41, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel41.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel41.Location = new System.Drawing.Point(0, 0);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(760, 138);
            this.panel41.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.panel41, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel41, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel41, "");
            // 
            // panel43
            // 
            this.panel43.Controls.Add(this.panel51);
            this.panel43.Controls.Add(this.lbldebtfullname);
            this.fade.SetDecoration(this.panel43, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel43, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel43, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel43, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel43, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel43.Location = new System.Drawing.Point(141, 0);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(619, 138);
            this.panel43.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.panel43, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel43, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel43, "");
            // 
            // panel51
            // 
            this.panel51.Controls.Add(this.bunifuImageButton21);
            this.panel51.Controls.Add(this.bunifuImageButton24);
            this.fade.SetDecoration(this.panel51, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel51, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel51, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel51, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel51, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel51.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel51.Location = new System.Drawing.Point(514, 0);
            this.panel51.Name = "panel51";
            this.panel51.Size = new System.Drawing.Size(105, 138);
            this.panel51.TabIndex = 16;
            this.bunifuToolTip1.SetToolTip(this.panel51, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel51, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel51, "");
            // 
            // bunifuImageButton21
            // 
            this.fade.SetDecoration(this.bunifuImageButton21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton21.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton21.Image")));
            this.bunifuImageButton21.ImageActive = null;
            this.bunifuImageButton21.Location = new System.Drawing.Point(10, 95);
            this.bunifuImageButton21.Name = "bunifuImageButton21";
            this.bunifuImageButton21.Size = new System.Drawing.Size(39, 39);
            this.bunifuImageButton21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton21.TabIndex = 12;
            this.bunifuImageButton21.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton21, "Print Report for this customer");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton21, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton21, "");
            this.bunifuImageButton21.Zoom = 10;
            this.bunifuImageButton21.Click += new System.EventHandler(this.bunifuImageButton21_Click);
            // 
            // bunifuImageButton24
            // 
            this.fade.SetDecoration(this.bunifuImageButton24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton24.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton24.Image")));
            this.bunifuImageButton24.ImageActive = null;
            this.bunifuImageButton24.Location = new System.Drawing.Point(55, 95);
            this.bunifuImageButton24.Name = "bunifuImageButton24";
            this.bunifuImageButton24.Size = new System.Drawing.Size(39, 39);
            this.bunifuImageButton24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton24.TabIndex = 15;
            this.bunifuImageButton24.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton24, "Settle this debt");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton24, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton24, "");
            this.bunifuImageButton24.Zoom = 10;
            // 
            // lbldebtfullname
            // 
            this.lbldebtfullname.AutoSize = true;
            this.fade.SetDecoration(this.lbldebtfullname, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbldebtfullname, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lbldebtfullname, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lbldebtfullname, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lbldebtfullname, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbldebtfullname.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldebtfullname.ForeColor = System.Drawing.Color.White;
            this.lbldebtfullname.Location = new System.Drawing.Point(6, 9);
            this.lbldebtfullname.Name = "lbldebtfullname";
            this.lbldebtfullname.Size = new System.Drawing.Size(234, 29);
            this.lbldebtfullname.TabIndex = 3;
            this.lbldebtfullname.Text = "Customer\'s full name";
            this.bunifuToolTip1.SetToolTip(this.lbldebtfullname, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbldebtfullname, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbldebtfullname, "");
            // 
            // panel42
            // 
            this.panel42.Controls.Add(this.bunifuPictureBox1);
            this.fade.SetDecoration(this.panel42, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel42, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel42, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel42, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel42, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel42.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel42.Location = new System.Drawing.Point(0, 0);
            this.panel42.Name = "panel42";
            this.panel42.Size = new System.Drawing.Size(141, 138);
            this.panel42.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.panel42, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel42, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel42, "");
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 64;
            this.fade.SetDecoration(this.bunifuPictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuPictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuPictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuPictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuPictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(8, 4);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(128, 128);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuPictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuPictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuPictureBox1, "");
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // panel39
            // 
            this.fade.SetDecoration(this.panel39, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel39, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel39, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel39, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel39, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel39.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel39.Location = new System.Drawing.Point(15, 51);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(1712, 10);
            this.panel39.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.panel39, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel39, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel39, "");
            // 
            // panel47
            // 
            this.fade.SetDecoration(this.panel47, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel47, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel47, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel47, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel47, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel47.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel47.Location = new System.Drawing.Point(0, 51);
            this.panel47.Name = "panel47";
            this.panel47.Size = new System.Drawing.Size(15, 993);
            this.panel47.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.panel47, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel47, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel47, "");
            // 
            // panel38
            // 
            this.panel38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel38.Controls.Add(this.panel61);
            this.panel38.Controls.Add(this.panel62);
            this.fade.SetDecoration(this.panel38, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel38, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel38, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel38, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel38, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel38.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel38.Location = new System.Drawing.Point(0, 0);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(1727, 51);
            this.panel38.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panel38, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel38, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel38, "");
            // 
            // panel61
            // 
            this.panel61.Controls.Add(this.bunifuFlatButton10);
            this.panel61.Controls.Add(this.bunifuFlatButton9);
            this.panel61.Controls.Add(this.bunifuFlatButton3);
            this.fade.SetDecoration(this.panel61, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel61, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel61, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel61, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel61, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel61.Location = new System.Drawing.Point(0, 8);
            this.panel61.Name = "panel61";
            this.panel61.Size = new System.Drawing.Size(1727, 43);
            this.panel61.TabIndex = 28;
            this.bunifuToolTip1.SetToolTip(this.panel61, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel61, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel61, "");
            // 
            // bunifuFlatButton10
            // 
            this.bunifuFlatButton10.Active = false;
            this.bunifuFlatButton10.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.bunifuFlatButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton10.BorderRadius = 0;
            this.bunifuFlatButton10.ButtonText = "              Charts";
            this.bunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fade.SetDecoration(this.bunifuFlatButton10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuFlatButton10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuFlatButton10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton10.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton10.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton10.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton10.Iconimage")));
            this.bunifuFlatButton10.Iconimage_right = null;
            this.bunifuFlatButton10.Iconimage_right_Selected = null;
            this.bunifuFlatButton10.Iconimage_Selected = null;
            this.bunifuFlatButton10.IconMarginLeft = 0;
            this.bunifuFlatButton10.IconMarginRight = 0;
            this.bunifuFlatButton10.IconRightVisible = true;
            this.bunifuFlatButton10.IconRightZoom = 0D;
            this.bunifuFlatButton10.IconVisible = true;
            this.bunifuFlatButton10.IconZoom = 80D;
            this.bunifuFlatButton10.IsTab = true;
            this.bunifuFlatButton10.Location = new System.Drawing.Point(412, 0);
            this.bunifuFlatButton10.Name = "bunifuFlatButton10";
            this.bunifuFlatButton10.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton10.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.bunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton10.selected = false;
            this.bunifuFlatButton10.Size = new System.Drawing.Size(206, 43);
            this.bunifuFlatButton10.TabIndex = 28;
            this.bunifuFlatButton10.Text = "              Charts";
            this.bunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton10.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.bunifuFlatButton10.TextFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.bunifuFlatButton10, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuFlatButton10, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuFlatButton10, "");
            this.bunifuFlatButton10.Click += new System.EventHandler(this.bunifuFlatButton10_Click);
            // 
            // bunifuFlatButton9
            // 
            this.bunifuFlatButton9.Active = false;
            this.bunifuFlatButton9.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.bunifuFlatButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton9.BorderRadius = 0;
            this.bunifuFlatButton9.ButtonText = "              Expired Products";
            this.bunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fade.SetDecoration(this.bunifuFlatButton9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuFlatButton9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuFlatButton9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton9.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton9.Iconimage")));
            this.bunifuFlatButton9.Iconimage_right = null;
            this.bunifuFlatButton9.Iconimage_right_Selected = null;
            this.bunifuFlatButton9.Iconimage_Selected = null;
            this.bunifuFlatButton9.IconMarginLeft = 0;
            this.bunifuFlatButton9.IconMarginRight = 0;
            this.bunifuFlatButton9.IconRightVisible = true;
            this.bunifuFlatButton9.IconRightZoom = 0D;
            this.bunifuFlatButton9.IconVisible = true;
            this.bunifuFlatButton9.IconZoom = 80D;
            this.bunifuFlatButton9.IsTab = true;
            this.bunifuFlatButton9.Location = new System.Drawing.Point(206, 0);
            this.bunifuFlatButton9.Name = "bunifuFlatButton9";
            this.bunifuFlatButton9.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.bunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton9.selected = false;
            this.bunifuFlatButton9.Size = new System.Drawing.Size(206, 43);
            this.bunifuFlatButton9.TabIndex = 27;
            this.bunifuFlatButton9.Text = "              Expired Products";
            this.bunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton9.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.bunifuFlatButton9.TextFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.bunifuFlatButton9, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuFlatButton9, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuFlatButton9, "");
            this.bunifuFlatButton9.Click += new System.EventHandler(this.bunifuFlatButton9_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Active = true;
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "              Debts";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fade.SetDecoration(this.bunifuFlatButton3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuFlatButton3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuFlatButton3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 80D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = true;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(206, 43);
            this.bunifuFlatButton3.TabIndex = 26;
            this.bunifuFlatButton3.Text = "              Debts";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.bunifuFlatButton3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuFlatButton3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuFlatButton3, "");
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // panel62
            // 
            this.panel62.Controls.Add(this.indicator2);
            this.fade.SetDecoration(this.panel62, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel62, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel62, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel62, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel62, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel62.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel62.Location = new System.Drawing.Point(0, 0);
            this.panel62.Name = "panel62";
            this.panel62.Size = new System.Drawing.Size(1727, 8);
            this.panel62.TabIndex = 29;
            this.bunifuToolTip1.SetToolTip(this.panel62, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel62, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel62, "");
            // 
            // indicator2
            // 
            this.indicator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.fade.SetDecoration(this.indicator2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.indicator2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.indicator2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.indicator2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.indicator2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.indicator2.Location = new System.Drawing.Point(0, 0);
            this.indicator2.Name = "indicator2";
            this.indicator2.Size = new System.Drawing.Size(206, 7);
            this.indicator2.TabIndex = 22;
            this.bunifuToolTip1.SetToolTip(this.indicator2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.indicator2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.indicator2, "");
            // 
            // paneldashboard
            // 
            this.paneldashboard.Controls.Add(this.panel20);
            this.paneldashboard.Controls.Add(this.panel19);
            this.paneldashboard.Controls.Add(this.panel18);
            this.paneldashboard.Controls.Add(this.bunifuSeparator14);
            this.fade.SetDecoration(this.paneldashboard, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.paneldashboard, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.paneldashboard, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.paneldashboard, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.paneldashboard, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.paneldashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldashboard.Location = new System.Drawing.Point(0, 0);
            this.paneldashboard.Name = "paneldashboard";
            this.paneldashboard.Size = new System.Drawing.Size(1727, 1044);
            this.paneldashboard.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.paneldashboard, "");
            this.bunifuToolTip1.SetToolTipIcon(this.paneldashboard, null);
            this.bunifuToolTip1.SetToolTipTitle(this.paneldashboard, "");
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel20.Controls.Add(this.panel29);
            this.panel20.Controls.Add(this.panel45);
            this.panel20.Controls.Add(this.splitterControl2);
            this.panel20.Controls.Add(this.panel27);
            this.panel20.Controls.Add(this.panel28);
            this.panel20.Controls.Add(this.panel22);
            this.panel20.Controls.Add(this.panel23);
            this.fade.SetDecoration(this.panel20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(0, 207);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(1727, 827);
            this.panel20.TabIndex = 19;
            this.bunifuToolTip1.SetToolTip(this.panel20, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel20, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel20, "");
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.bunifuDataViz2);
            this.panel29.Controls.Add(this.panel37);
            this.fade.SetDecoration(this.panel29, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel29, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel29, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel29, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel29, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel29.Location = new System.Drawing.Point(711, 0);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(698, 397);
            this.panel29.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.panel29, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel29, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel29, "");
            // 
            // bunifuDataViz2
            // 
            this.bunifuDataViz2.animationEnabled = true;
            this.bunifuDataViz2.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.bunifuDataViz2.AxisLineColor = System.Drawing.Color.LightGray;
            this.bunifuDataViz2.AxisXFontColor = System.Drawing.Color.Snow;
            this.bunifuDataViz2.AxisXGridColor = System.Drawing.Color.Snow;
            this.bunifuDataViz2.AxisXGridThickness = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.bunifuDataViz2.AxisYFontColor = System.Drawing.Color.Snow;
            this.bunifuDataViz2.AxisYGridColor = System.Drawing.Color.Snow;
            this.bunifuDataViz2.AxisYGridThickness = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.bunifuDataViz2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuDataViz2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition2.SetDecoration(this.bunifuDataViz2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuDataViz2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuDataViz2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.bunifuDataViz2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuDataViz2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuDataViz2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuDataViz2.ForeColor = System.Drawing.Color.Snow;
            this.bunifuDataViz2.Location = new System.Drawing.Point(0, 37);
            this.bunifuDataViz2.Name = "bunifuDataViz2";
            this.bunifuDataViz2.Size = new System.Drawing.Size(698, 360);
            this.bunifuDataViz2.TabIndex = 5;
            this.bunifuDataViz2.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme2;
            this.bunifuDataViz2.Title = "";
            this.bunifuToolTip1.SetToolTip(this.bunifuDataViz2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuDataViz2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuDataViz2, "");
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.panel53);
            this.panel37.Controls.Add(this.bunifuImageButton25);
            this.panel37.Controls.Add(this.label10);
            this.panel37.Controls.Add(this.label36);
            this.fade.SetDecoration(this.panel37, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel37, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel37, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel37, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel37, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel37.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel37.Location = new System.Drawing.Point(0, 0);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(698, 37);
            this.panel37.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.panel37, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel37, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel37, "");
            // 
            // panel53
            // 
            this.panel53.Controls.Add(this.bunifuDropdown1);
            this.fade.SetDecoration(this.panel53, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel53, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel53, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel53, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel53, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel53.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel53.Location = new System.Drawing.Point(531, 0);
            this.panel53.Name = "panel53";
            this.panel53.Size = new System.Drawing.Size(167, 37);
            this.panel53.TabIndex = 20;
            this.bunifuToolTip1.SetToolTip(this.panel53, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel53, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel53, "");
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuDropdown1.BorderRadius = 5;
            this.bunifuDropdown1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.fade.SetDecoration(this.bunifuDropdown1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuDropdown1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuDropdown1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuDropdown1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuDropdown1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuDropdown1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown1.FillDropDown = false;
            this.bunifuDropdown1.FillIndicator = false;
            this.bunifuDropdown1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuDropdown1.FormattingEnabled = true;
            this.bunifuDropdown1.Icon = null;
            this.bunifuDropdown1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.bunifuDropdown1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown1.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuDropdown1.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuDropdown1.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuDropdown1.ItemHeight = 26;
            this.bunifuDropdown1.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuDropdown1.Items.AddRange(new object[] {
            "Today",
            "2 Days",
            "1 Week",
            "This Month"});
            this.bunifuDropdown1.Location = new System.Drawing.Point(2, 2);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.Size = new System.Drawing.Size(163, 32);
            this.bunifuDropdown1.TabIndex = 19;
            this.bunifuDropdown1.Text = null;
            this.bunifuToolTip1.SetToolTip(this.bunifuDropdown1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuDropdown1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuDropdown1, "");
            this.bunifuDropdown1.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown1_SelectedIndexChanged);
            // 
            // bunifuImageButton25
            // 
            this.fade.SetDecoration(this.bunifuImageButton25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton25.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton25.Image")));
            this.bunifuImageButton25.ImageActive = null;
            this.bunifuImageButton25.Location = new System.Drawing.Point(193, 3);
            this.bunifuImageButton25.Name = "bunifuImageButton25";
            this.bunifuImageButton25.Size = new System.Drawing.Size(22, 18);
            this.bunifuImageButton25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton25.TabIndex = 18;
            this.bunifuImageButton25.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton25, "Voided Transactions are not included in this summary");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton25, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton25, "");
            this.bunifuImageButton25.Zoom = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.fade.SetDecoration(this.label10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "Today\'s top selling products";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label10, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label10, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label10, "");
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.fade.SetDecoration(this.label36, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label36, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label36, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label36, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label36, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label36.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.DimGray;
            this.label36.Location = new System.Drawing.Point(6, 19);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(250, 15);
            this.label36.TabIndex = 16;
            this.label36.Text = "Your current top selling products overview";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label36, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label36, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label36, "");
            // 
            // panel45
            // 
            this.panel45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.panel45.Controls.Add(this.bunifuFlatButton8);
            this.panel45.Controls.Add(this.lbllog5);
            this.panel45.Controls.Add(this.bunifuCircleProgressbar5);
            this.panel45.Controls.Add(this.bunifuFlatButton7);
            this.panel45.Controls.Add(this.lbllog4);
            this.panel45.Controls.Add(this.bunifuCircleProgressbar4);
            this.panel45.Controls.Add(this.bunifuFlatButton6);
            this.panel45.Controls.Add(this.lbllog3);
            this.panel45.Controls.Add(this.bunifuCircleProgressbar3);
            this.panel45.Controls.Add(this.bunifuFlatButton5);
            this.panel45.Controls.Add(this.bunifuFlatButton4);
            this.panel45.Controls.Add(this.lbllog2);
            this.panel45.Controls.Add(this.lbllog1);
            this.panel45.Controls.Add(this.bunifuCircleProgressbar2);
            this.panel45.Controls.Add(this.bunifuCircleProgressbar1);
            this.panel45.Controls.Add(this.panel46);
            this.panel45.Controls.Add(this.bunifuSeparator15);
            this.fade.SetDecoration(this.panel45, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel45, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel45, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel45, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel45, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel45.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel45.Location = new System.Drawing.Point(1409, 0);
            this.panel45.Name = "panel45";
            this.panel45.Size = new System.Drawing.Size(284, 397);
            this.panel45.TabIndex = 8;
            this.bunifuToolTip1.SetToolTip(this.panel45, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel45, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel45, "");
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Active = false;
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 7;
            this.bunifuFlatButton8.ButtonText = "1 hr";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fade.SetDecoration(this.bunifuFlatButton8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuFlatButton8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuFlatButton8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            this.bunifuFlatButton8.IconZoom = 0D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(206, 304);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(72, 34);
            this.bunifuFlatButton8.TabIndex = 29;
            this.bunifuFlatButton8.Text = "1 hr";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.bunifuFlatButton8, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuFlatButton8, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuFlatButton8, "");
            // 
            // lbllog5
            // 
            this.fade.SetDecoration(this.lbllog5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbllog5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lbllog5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lbllog5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lbllog5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbllog5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllog5.ForeColor = System.Drawing.Color.DimGray;
            this.lbllog5.Location = new System.Drawing.Point(50, 304);
            this.lbllog5.Name = "lbllog5";
            this.lbllog5.Size = new System.Drawing.Size(150, 41);
            this.lbllog5.TabIndex = 28;
            this.lbllog5.Text = "Recent systems activity, updted every 5 mins.";
            this.lbllog5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.lbllog5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbllog5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbllog5, "");
            // 
            // bunifuCircleProgressbar5
            // 
            this.bunifuCircleProgressbar5.animated = false;
            this.bunifuCircleProgressbar5.animationIterval = 5;
            this.bunifuCircleProgressbar5.animationSpeed = 300;
            this.bunifuCircleProgressbar5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar5.BackgroundImage")));
            this.fade.SetDecoration(this.bunifuCircleProgressbar5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuCircleProgressbar5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuCircleProgressbar5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuCircleProgressbar5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuCircleProgressbar5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCircleProgressbar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar5.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar5.LabelVisible = false;
            this.bunifuCircleProgressbar5.LineProgressThickness = 8;
            this.bunifuCircleProgressbar5.LineThickness = 2;
            this.bunifuCircleProgressbar5.Location = new System.Drawing.Point(10, 304);
            this.bunifuCircleProgressbar5.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar5.MaxValue = 100;
            this.bunifuCircleProgressbar5.Name = "bunifuCircleProgressbar5";
            this.bunifuCircleProgressbar5.ProgressBackColor = System.Drawing.Color.Red;
            this.bunifuCircleProgressbar5.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar5.Size = new System.Drawing.Size(41, 41);
            this.bunifuCircleProgressbar5.TabIndex = 27;
            this.bunifuToolTip1.SetToolTip(this.bunifuCircleProgressbar5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuCircleProgressbar5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuCircleProgressbar5, "");
            this.bunifuCircleProgressbar5.Value = 0;
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Active = false;
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 7;
            this.bunifuFlatButton7.ButtonText = "8 min";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fade.SetDecoration(this.bunifuFlatButton7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuFlatButton7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuFlatButton7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            this.bunifuFlatButton7.IconZoom = 0D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(206, 247);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(72, 34);
            this.bunifuFlatButton7.TabIndex = 26;
            this.bunifuFlatButton7.Text = "8 min";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.bunifuFlatButton7, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuFlatButton7, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuFlatButton7, "");
            // 
            // lbllog4
            // 
            this.fade.SetDecoration(this.lbllog4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbllog4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lbllog4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lbllog4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lbllog4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbllog4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllog4.ForeColor = System.Drawing.Color.DimGray;
            this.lbllog4.Location = new System.Drawing.Point(50, 247);
            this.lbllog4.Name = "lbllog4";
            this.lbllog4.Size = new System.Drawing.Size(150, 41);
            this.lbllog4.TabIndex = 25;
            this.lbllog4.Text = "Recent systems activity, updted every 5 mins.";
            this.lbllog4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.lbllog4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbllog4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbllog4, "");
            // 
            // bunifuCircleProgressbar4
            // 
            this.bunifuCircleProgressbar4.animated = false;
            this.bunifuCircleProgressbar4.animationIterval = 5;
            this.bunifuCircleProgressbar4.animationSpeed = 300;
            this.bunifuCircleProgressbar4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar4.BackgroundImage")));
            this.fade.SetDecoration(this.bunifuCircleProgressbar4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuCircleProgressbar4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuCircleProgressbar4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuCircleProgressbar4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuCircleProgressbar4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCircleProgressbar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar4.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar4.LabelVisible = false;
            this.bunifuCircleProgressbar4.LineProgressThickness = 8;
            this.bunifuCircleProgressbar4.LineThickness = 2;
            this.bunifuCircleProgressbar4.Location = new System.Drawing.Point(10, 247);
            this.bunifuCircleProgressbar4.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar4.MaxValue = 100;
            this.bunifuCircleProgressbar4.Name = "bunifuCircleProgressbar4";
            this.bunifuCircleProgressbar4.ProgressBackColor = System.Drawing.Color.Aqua;
            this.bunifuCircleProgressbar4.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar4.Size = new System.Drawing.Size(41, 41);
            this.bunifuCircleProgressbar4.TabIndex = 24;
            this.bunifuToolTip1.SetToolTip(this.bunifuCircleProgressbar4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuCircleProgressbar4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuCircleProgressbar4, "");
            this.bunifuCircleProgressbar4.Value = 0;
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Active = false;
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 7;
            this.bunifuFlatButton6.ButtonText = "5 min";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fade.SetDecoration(this.bunifuFlatButton6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuFlatButton6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuFlatButton6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            this.bunifuFlatButton6.IconZoom = 0D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(206, 188);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(72, 34);
            this.bunifuFlatButton6.TabIndex = 23;
            this.bunifuFlatButton6.Text = "5 min";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.bunifuFlatButton6, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuFlatButton6, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuFlatButton6, "");
            // 
            // lbllog3
            // 
            this.fade.SetDecoration(this.lbllog3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbllog3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lbllog3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lbllog3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lbllog3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbllog3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllog3.ForeColor = System.Drawing.Color.DimGray;
            this.lbllog3.Location = new System.Drawing.Point(50, 188);
            this.lbllog3.Name = "lbllog3";
            this.lbllog3.Size = new System.Drawing.Size(150, 41);
            this.lbllog3.TabIndex = 22;
            this.lbllog3.Text = "Recent systems activity, updted every 5 mins.";
            this.lbllog3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.lbllog3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbllog3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbllog3, "");
            // 
            // bunifuCircleProgressbar3
            // 
            this.bunifuCircleProgressbar3.animated = false;
            this.bunifuCircleProgressbar3.animationIterval = 5;
            this.bunifuCircleProgressbar3.animationSpeed = 300;
            this.bunifuCircleProgressbar3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar3.BackgroundImage")));
            this.fade.SetDecoration(this.bunifuCircleProgressbar3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuCircleProgressbar3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuCircleProgressbar3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuCircleProgressbar3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuCircleProgressbar3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCircleProgressbar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar3.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar3.LabelVisible = false;
            this.bunifuCircleProgressbar3.LineProgressThickness = 8;
            this.bunifuCircleProgressbar3.LineThickness = 2;
            this.bunifuCircleProgressbar3.Location = new System.Drawing.Point(10, 188);
            this.bunifuCircleProgressbar3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar3.MaxValue = 100;
            this.bunifuCircleProgressbar3.Name = "bunifuCircleProgressbar3";
            this.bunifuCircleProgressbar3.ProgressBackColor = System.Drawing.Color.Lime;
            this.bunifuCircleProgressbar3.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar3.Size = new System.Drawing.Size(41, 41);
            this.bunifuCircleProgressbar3.TabIndex = 21;
            this.bunifuToolTip1.SetToolTip(this.bunifuCircleProgressbar3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuCircleProgressbar3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuCircleProgressbar3, "");
            this.bunifuCircleProgressbar3.Value = 0;
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Active = false;
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 7;
            this.bunifuFlatButton5.ButtonText = "2 min";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fade.SetDecoration(this.bunifuFlatButton5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuFlatButton5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuFlatButton5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            this.bunifuFlatButton5.IconZoom = 0D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(206, 129);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(72, 34);
            this.bunifuFlatButton5.TabIndex = 20;
            this.bunifuFlatButton5.Text = "2 min";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.bunifuFlatButton5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuFlatButton5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuFlatButton5, "");
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Active = false;
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 7;
            this.bunifuFlatButton4.ButtonText = "Just now";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fade.SetDecoration(this.bunifuFlatButton4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuFlatButton4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuFlatButton4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            this.bunifuFlatButton4.IconZoom = 0D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(206, 68);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(72, 34);
            this.bunifuFlatButton4.TabIndex = 19;
            this.bunifuFlatButton4.Text = "Just now";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.bunifuFlatButton4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuFlatButton4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuFlatButton4, "");
            // 
            // lbllog2
            // 
            this.fade.SetDecoration(this.lbllog2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbllog2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lbllog2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lbllog2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lbllog2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbllog2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllog2.ForeColor = System.Drawing.Color.DimGray;
            this.lbllog2.Location = new System.Drawing.Point(50, 129);
            this.lbllog2.Name = "lbllog2";
            this.lbllog2.Size = new System.Drawing.Size(150, 41);
            this.lbllog2.TabIndex = 18;
            this.lbllog2.Text = "Recent systems activity, updted every 5 mins.";
            this.lbllog2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.lbllog2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbllog2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbllog2, "");
            // 
            // lbllog1
            // 
            this.fade.SetDecoration(this.lbllog1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbllog1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lbllog1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lbllog1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lbllog1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbllog1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllog1.ForeColor = System.Drawing.Color.DimGray;
            this.lbllog1.Location = new System.Drawing.Point(50, 71);
            this.lbllog1.Name = "lbllog1";
            this.lbllog1.Size = new System.Drawing.Size(150, 41);
            this.lbllog1.TabIndex = 17;
            this.lbllog1.Text = "Recent systems activity, updted every 5 mins.";
            this.lbllog1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.lbllog1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbllog1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbllog1, "");
            // 
            // bunifuCircleProgressbar2
            // 
            this.bunifuCircleProgressbar2.animated = false;
            this.bunifuCircleProgressbar2.animationIterval = 5;
            this.bunifuCircleProgressbar2.animationSpeed = 300;
            this.bunifuCircleProgressbar2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar2.BackgroundImage")));
            this.fade.SetDecoration(this.bunifuCircleProgressbar2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuCircleProgressbar2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuCircleProgressbar2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuCircleProgressbar2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuCircleProgressbar2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCircleProgressbar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar2.LabelVisible = false;
            this.bunifuCircleProgressbar2.LineProgressThickness = 8;
            this.bunifuCircleProgressbar2.LineThickness = 2;
            this.bunifuCircleProgressbar2.Location = new System.Drawing.Point(10, 129);
            this.bunifuCircleProgressbar2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar2.MaxValue = 100;
            this.bunifuCircleProgressbar2.Name = "bunifuCircleProgressbar2";
            this.bunifuCircleProgressbar2.ProgressBackColor = System.Drawing.Color.Yellow;
            this.bunifuCircleProgressbar2.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar2.Size = new System.Drawing.Size(41, 41);
            this.bunifuCircleProgressbar2.TabIndex = 8;
            this.bunifuToolTip1.SetToolTip(this.bunifuCircleProgressbar2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuCircleProgressbar2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuCircleProgressbar2, "");
            this.bunifuCircleProgressbar2.Value = 0;
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.fade.SetDecoration(this.bunifuCircleProgressbar1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuCircleProgressbar1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuCircleProgressbar1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuCircleProgressbar1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuCircleProgressbar1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.LabelVisible = false;
            this.bunifuCircleProgressbar1.LineProgressThickness = 3;
            this.bunifuCircleProgressbar1.LineThickness = 2;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(10, 68);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(41, 41);
            this.bunifuCircleProgressbar1.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.bunifuCircleProgressbar1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuCircleProgressbar1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuCircleProgressbar1, "");
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // panel46
            // 
            this.panel46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel46.Controls.Add(this.label16);
            this.panel46.Controls.Add(this.label40);
            this.fade.SetDecoration(this.panel46, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel46, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel46, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel46, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel46, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel46.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel46.Location = new System.Drawing.Point(0, 0);
            this.panel46.Name = "panel46";
            this.panel46.Size = new System.Drawing.Size(284, 37);
            this.panel46.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.panel46, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel46, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel46, "");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.fade.SetDecoration(this.label16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label16.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Snow;
            this.label16.Location = new System.Drawing.Point(6, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 18);
            this.label16.TabIndex = 15;
            this.label16.Text = "Recent Activities";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label16, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label16, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label16, "");
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.fade.SetDecoration(this.label40, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label40, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label40, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label40, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label40, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label40.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.DimGray;
            this.label40.Location = new System.Drawing.Point(6, 19);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(270, 15);
            this.label40.TabIndex = 16;
            this.label40.Text = "Recent systems activity, updted every 5 mins.";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label40, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label40, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label40, "");
            // 
            // bunifuSeparator15
            // 
            this.bunifuSeparator15.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator15.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator15.LineThickness = 1;
            this.bunifuSeparator15.Location = new System.Drawing.Point(23, 71);
            this.bunifuSeparator15.Name = "bunifuSeparator15";
            this.bunifuSeparator15.Size = new System.Drawing.Size(17, 274);
            this.bunifuSeparator15.TabIndex = 7;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator15, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator15, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator15, "");
            this.bunifuSeparator15.Transparency = 255;
            this.bunifuSeparator15.Vertical = true;
            // 
            // splitterControl2
            // 
            this.fade.SetDecoration(this.splitterControl2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.splitterControl2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.splitterControl2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.splitterControl2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.splitterControl2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.splitterControl2.Location = new System.Drawing.Point(706, 0);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new System.Drawing.Size(5, 397);
            this.splitterControl2.TabIndex = 7;
            this.splitterControl2.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.splitterControl2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.splitterControl2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.splitterControl2, "");
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.bunifuDataViz1);
            this.panel27.Controls.Add(this.panel36);
            this.fade.SetDecoration(this.panel27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel27.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel27.Location = new System.Drawing.Point(34, 0);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(672, 397);
            this.panel27.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.panel27, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel27, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel27, "");
            // 
            // bunifuDataViz1
            // 
            this.bunifuDataViz1.animationEnabled = true;
            this.bunifuDataViz1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.bunifuDataViz1.AxisLineColor = System.Drawing.Color.LightGray;
            this.bunifuDataViz1.AxisXFontColor = System.Drawing.Color.Snow;
            this.bunifuDataViz1.AxisXGridColor = System.Drawing.Color.Snow;
            this.bunifuDataViz1.AxisXGridThickness = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.bunifuDataViz1.AxisYFontColor = System.Drawing.Color.Snow;
            this.bunifuDataViz1.AxisYGridColor = System.Drawing.Color.Snow;
            this.bunifuDataViz1.AxisYGridThickness = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.bunifuDataViz1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuDataViz1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition2.SetDecoration(this.bunifuDataViz1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuDataViz1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuDataViz1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.bunifuDataViz1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuDataViz1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuDataViz1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuDataViz1.ForeColor = System.Drawing.Color.Snow;
            this.bunifuDataViz1.Location = new System.Drawing.Point(0, 37);
            this.bunifuDataViz1.Name = "bunifuDataViz1";
            this.bunifuDataViz1.Size = new System.Drawing.Size(672, 360);
            this.bunifuDataViz1.TabIndex = 4;
            this.bunifuDataViz1.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme1;
            this.bunifuDataViz1.Title = "";
            this.bunifuToolTip1.SetToolTip(this.bunifuDataViz1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuDataViz1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuDataViz1, "");
            // 
            // panel36
            // 
            this.panel36.Controls.Add(this.panel52);
            this.panel36.Controls.Add(this.bunifuImageButton19);
            this.panel36.Controls.Add(this.label35);
            this.panel36.Controls.Add(this.label34);
            this.fade.SetDecoration(this.panel36, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel36, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel36, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel36, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel36, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel36.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel36.Location = new System.Drawing.Point(0, 0);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(672, 37);
            this.panel36.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.panel36, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel36, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel36, "");
            // 
            // panel52
            // 
            this.panel52.Controls.Add(this.bunifuDropdown2);
            this.fade.SetDecoration(this.panel52, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel52, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel52, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel52, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel52, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel52.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel52.Location = new System.Drawing.Point(499, 0);
            this.panel52.Name = "panel52";
            this.panel52.Size = new System.Drawing.Size(173, 37);
            this.panel52.TabIndex = 19;
            this.bunifuToolTip1.SetToolTip(this.panel52, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel52, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel52, "");
            // 
            // bunifuDropdown2
            // 
            this.bunifuDropdown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuDropdown2.BorderRadius = 5;
            this.bunifuDropdown2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.fade.SetDecoration(this.bunifuDropdown2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuDropdown2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuDropdown2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuDropdown2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuDropdown2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            this.bunifuDropdown2.ItemHeight = 26;
            this.bunifuDropdown2.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuDropdown2.Items.AddRange(new object[] {
            "Weekly",
            "2 Months",
            "3 Months",
            "6 Months",
            "Yearly",
            "Custom"});
            this.bunifuDropdown2.Location = new System.Drawing.Point(5, 2);
            this.bunifuDropdown2.Name = "bunifuDropdown2";
            this.bunifuDropdown2.Size = new System.Drawing.Size(163, 32);
            this.bunifuDropdown2.TabIndex = 18;
            this.bunifuDropdown2.Text = null;
            this.bunifuToolTip1.SetToolTip(this.bunifuDropdown2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuDropdown2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuDropdown2, "");
            this.bunifuDropdown2.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown2_SelectedIndexChanged);
            this.bunifuDropdown2.DropDownClosed += new System.EventHandler(this.bunifuDropdown2_DropDownClosed);
            // 
            // bunifuImageButton19
            // 
            this.fade.SetDecoration(this.bunifuImageButton19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton19.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton19.Image")));
            this.bunifuImageButton19.ImageActive = null;
            this.bunifuImageButton19.Location = new System.Drawing.Point(114, 3);
            this.bunifuImageButton19.Name = "bunifuImageButton19";
            this.bunifuImageButton19.Size = new System.Drawing.Size(22, 18);
            this.bunifuImageButton19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton19.TabIndex = 17;
            this.bunifuImageButton19.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton19, "Voided Transactions are not included in this summary");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton19, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton19, "");
            this.bunifuImageButton19.Zoom = 10;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.fade.SetDecoration(this.label35, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label35, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label35, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label35, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label35, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label35.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Snow;
            this.label35.Location = new System.Drawing.Point(6, 3);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(107, 18);
            this.label35.TabIndex = 15;
            this.label35.Text = "Sales Overview";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label35, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label35, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label35, "");
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.fade.SetDecoration(this.label34, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label34, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label34, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label34, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label34, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label34.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.DimGray;
            this.label34.Location = new System.Drawing.Point(6, 19);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(152, 15);
            this.label34.TabIndex = 16;
            this.label34.Text = "Your year long sales data";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label34, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label34, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label34, "");
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.panel33);
            this.panel28.Controls.Add(this.panel54);
            this.panel28.Controls.Add(this.splitterControl3);
            this.panel28.Controls.Add(this.panel30);
            this.fade.SetDecoration(this.panel28, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel28, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel28, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel28, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel28, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel28.Location = new System.Drawing.Point(34, 397);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(1659, 430);
            this.panel28.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.panel28, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel28, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel28, "");
            // 
            // panel33
            // 
            this.panel33.Controls.Add(this.flowpanelcriticalproducts);
            this.panel33.Controls.Add(this.panel35);
            this.fade.SetDecoration(this.panel33, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel33, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel33, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel33, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel33, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel33.Location = new System.Drawing.Point(677, 0);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(698, 430);
            this.panel33.TabIndex = 10;
            this.bunifuToolTip1.SetToolTip(this.panel33, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel33, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel33, "");
            // 
            // flowpanelcriticalproducts
            // 
            this.flowpanelcriticalproducts.AllowUserToAddRows = false;
            this.flowpanelcriticalproducts.AllowUserToDeleteRows = false;
            this.flowpanelcriticalproducts.AllowUserToOrderColumns = true;
            this.flowpanelcriticalproducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.flowpanelcriticalproducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.flowpanelcriticalproducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.flowpanelcriticalproducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flowpanelcriticalproducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.flowpanelcriticalproducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flowpanelcriticalproducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.flowpanelcriticalproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flowpanelcriticalproducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.bunifuTransition4.SetDecoration(this.flowpanelcriticalproducts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.flowpanelcriticalproducts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.flowpanelcriticalproducts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.flowpanelcriticalproducts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.flowpanelcriticalproducts, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.flowpanelcriticalproducts.DefaultCellStyle = dataGridViewCellStyle15;
            this.flowpanelcriticalproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpanelcriticalproducts.DoubleBuffered = true;
            this.flowpanelcriticalproducts.EnableHeadersVisualStyles = false;
            this.flowpanelcriticalproducts.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.flowpanelcriticalproducts.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
            this.flowpanelcriticalproducts.Location = new System.Drawing.Point(0, 42);
            this.flowpanelcriticalproducts.MultiSelect = false;
            this.flowpanelcriticalproducts.Name = "flowpanelcriticalproducts";
            this.flowpanelcriticalproducts.ReadOnly = true;
            this.flowpanelcriticalproducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.flowpanelcriticalproducts.RowHeadersVisible = false;
            this.flowpanelcriticalproducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.flowpanelcriticalproducts.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.flowpanelcriticalproducts.RowTemplate.Height = 39;
            this.flowpanelcriticalproducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.flowpanelcriticalproducts.Size = new System.Drawing.Size(698, 388);
            this.flowpanelcriticalproducts.TabIndex = 90;
            this.bunifuToolTip1.SetToolTip(this.flowpanelcriticalproducts, "");
            this.bunifuToolTip1.SetToolTipIcon(this.flowpanelcriticalproducts, null);
            this.bunifuToolTip1.SetToolTipTitle(this.flowpanelcriticalproducts, "");
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Product name";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 550;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 120;
            // 
            // panel35
            // 
            this.panel35.Controls.Add(this.bunifuImageButton30);
            this.panel35.Controls.Add(this.bunifuImageButton27);
            this.panel35.Controls.Add(this.label32);
            this.panel35.Controls.Add(this.label33);
            this.fade.SetDecoration(this.panel35, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel35, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel35, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel35, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel35, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel35.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel35.Location = new System.Drawing.Point(0, 0);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(698, 42);
            this.panel35.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panel35, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel35, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel35, "");
            // 
            // bunifuImageButton30
            // 
            this.fade.SetDecoration(this.bunifuImageButton30, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton30, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton30, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton30, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton30, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton30.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton30.Image")));
            this.bunifuImageButton30.ImageActive = null;
            this.bunifuImageButton30.Location = new System.Drawing.Point(124, 3);
            this.bunifuImageButton30.Name = "bunifuImageButton30";
            this.bunifuImageButton30.Size = new System.Drawing.Size(22, 18);
            this.bunifuImageButton30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton30.TabIndex = 20;
            this.bunifuImageButton30.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton30, "Products less than 50 units");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton30, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton30, "");
            this.bunifuImageButton30.Zoom = 10;
            // 
            // bunifuImageButton27
            // 
            this.fade.SetDecoration(this.bunifuImageButton27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton27.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton27.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton27.Image")));
            this.bunifuImageButton27.ImageActive = null;
            this.bunifuImageButton27.Location = new System.Drawing.Point(670, 0);
            this.bunifuImageButton27.Name = "bunifuImageButton27";
            this.bunifuImageButton27.Size = new System.Drawing.Size(28, 42);
            this.bunifuImageButton27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton27.TabIndex = 17;
            this.bunifuImageButton27.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton27, "Print");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton27, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton27, "");
            this.bunifuImageButton27.Zoom = 10;
            this.bunifuImageButton27.Click += new System.EventHandler(this.bunifuImageButton27_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.fade.SetDecoration(this.label32, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label32, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label32, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label32, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label32, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label32.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.DimGray;
            this.label32.Location = new System.Drawing.Point(6, 21);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(238, 15);
            this.label32.TabIndex = 16;
            this.label32.Text = "These products are almost out of stocks";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label32, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label32, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label32, "");
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.fade.SetDecoration(this.label33, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label33, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label33, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label33, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label33, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label33.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Snow;
            this.label33.Location = new System.Drawing.Point(6, 3);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(116, 18);
            this.label33.TabIndex = 15;
            this.label33.Text = "Critical Products";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label33, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label33, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label33, "");
            // 
            // panel54
            // 
            this.panel54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.panel54.Controls.Add(this.flowpanelnearexpire);
            this.panel54.Controls.Add(this.panel55);
            this.fade.SetDecoration(this.panel54, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel54, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel54, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel54, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel54, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel54.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel54.Location = new System.Drawing.Point(1375, 0);
            this.panel54.Name = "panel54";
            this.panel54.Size = new System.Drawing.Size(284, 430);
            this.panel54.TabIndex = 12;
            this.bunifuToolTip1.SetToolTip(this.panel54, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel54, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel54, "");
            // 
            // flowpanelnearexpire
            // 
            this.flowpanelnearexpire.AllowUserToAddRows = false;
            this.flowpanelnearexpire.AllowUserToDeleteRows = false;
            this.flowpanelnearexpire.AllowUserToOrderColumns = true;
            this.flowpanelnearexpire.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.flowpanelnearexpire.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.flowpanelnearexpire.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.flowpanelnearexpire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flowpanelnearexpire.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.flowpanelnearexpire.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flowpanelnearexpire.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.flowpanelnearexpire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flowpanelnearexpire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14});
            this.bunifuTransition4.SetDecoration(this.flowpanelnearexpire, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.flowpanelnearexpire, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.flowpanelnearexpire, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.flowpanelnearexpire, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.flowpanelnearexpire, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.flowpanelnearexpire.DefaultCellStyle = dataGridViewCellStyle19;
            this.flowpanelnearexpire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpanelnearexpire.DoubleBuffered = true;
            this.flowpanelnearexpire.EnableHeadersVisualStyles = false;
            this.flowpanelnearexpire.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.flowpanelnearexpire.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
            this.flowpanelnearexpire.Location = new System.Drawing.Point(0, 42);
            this.flowpanelnearexpire.MultiSelect = false;
            this.flowpanelnearexpire.Name = "flowpanelnearexpire";
            this.flowpanelnearexpire.ReadOnly = true;
            this.flowpanelnearexpire.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.flowpanelnearexpire.RowHeadersVisible = false;
            this.flowpanelnearexpire.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.flowpanelnearexpire.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.flowpanelnearexpire.RowTemplate.Height = 39;
            this.flowpanelnearexpire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.flowpanelnearexpire.Size = new System.Drawing.Size(284, 388);
            this.flowpanelnearexpire.TabIndex = 91;
            this.bunifuToolTip1.SetToolTip(this.flowpanelnearexpire, "");
            this.bunifuToolTip1.SetToolTipIcon(this.flowpanelnearexpire, null);
            this.bunifuToolTip1.SetToolTipTitle(this.flowpanelnearexpire, "");
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Product name";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 260;
            // 
            // panel55
            // 
            this.panel55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel55.Controls.Add(this.bunifuImageButton29);
            this.panel55.Controls.Add(this.bunifuImageButton28);
            this.panel55.Controls.Add(this.label45);
            this.panel55.Controls.Add(this.label46);
            this.fade.SetDecoration(this.panel55, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel55, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel55, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel55, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel55, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel55.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel55.Location = new System.Drawing.Point(0, 0);
            this.panel55.Name = "panel55";
            this.panel55.Size = new System.Drawing.Size(284, 42);
            this.panel55.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.panel55, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel55, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel55, "");
            // 
            // bunifuImageButton29
            // 
            this.fade.SetDecoration(this.bunifuImageButton29, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton29, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton29, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton29, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton29, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton29.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton29.Image")));
            this.bunifuImageButton29.ImageActive = null;
            this.bunifuImageButton29.Location = new System.Drawing.Point(177, 3);
            this.bunifuImageButton29.Name = "bunifuImageButton29";
            this.bunifuImageButton29.Size = new System.Drawing.Size(22, 18);
            this.bunifuImageButton29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton29.TabIndex = 19;
            this.bunifuImageButton29.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton29, "Products displayed are 2 months before their expiration date.");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton29, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton29, "");
            this.bunifuImageButton29.Zoom = 10;
            // 
            // bunifuImageButton28
            // 
            this.fade.SetDecoration(this.bunifuImageButton28, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton28, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton28, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton28, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton28, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton28.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton28.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton28.Image")));
            this.bunifuImageButton28.ImageActive = null;
            this.bunifuImageButton28.Location = new System.Drawing.Point(258, 0);
            this.bunifuImageButton28.Name = "bunifuImageButton28";
            this.bunifuImageButton28.Size = new System.Drawing.Size(26, 42);
            this.bunifuImageButton28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton28.TabIndex = 18;
            this.bunifuImageButton28.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton28, "Print");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton28, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton28, "");
            this.bunifuImageButton28.Zoom = 10;
            this.bunifuImageButton28.Click += new System.EventHandler(this.bunifuImageButton28_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.fade.SetDecoration(this.label45, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label45, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label45, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label45, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label45, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label45.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.Snow;
            this.label45.Location = new System.Drawing.Point(8, 3);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(163, 18);
            this.label45.TabIndex = 15;
            this.label45.Text = "Nearly expired products";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label45, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label45, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label45, "");
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.fade.SetDecoration(this.label46, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label46, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label46, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label46, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label46, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label46.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.DimGray;
            this.label46.Location = new System.Drawing.Point(8, 21);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(232, 15);
            this.label46.TabIndex = 16;
            this.label46.Text = "Products nearing their expiration dates.";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label46, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label46, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label46, "");
            // 
            // splitterControl3
            // 
            this.fade.SetDecoration(this.splitterControl3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.splitterControl3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.splitterControl3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.splitterControl3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.splitterControl3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.splitterControl3.Location = new System.Drawing.Point(672, 0);
            this.splitterControl3.Name = "splitterControl3";
            this.splitterControl3.Size = new System.Drawing.Size(5, 430);
            this.splitterControl3.TabIndex = 11;
            this.splitterControl3.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.splitterControl3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.splitterControl3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.splitterControl3, "");
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.flowpaneltopselling);
            this.panel30.Controls.Add(this.panel31);
            this.fade.SetDecoration(this.panel30, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel30, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel30, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel30, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel30, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel30.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel30.Location = new System.Drawing.Point(0, 0);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(672, 430);
            this.panel30.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.panel30, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel30, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel30, "");
            // 
            // flowpaneltopselling
            // 
            this.flowpaneltopselling.AllowUserToAddRows = false;
            this.flowpaneltopselling.AllowUserToDeleteRows = false;
            this.flowpaneltopselling.AllowUserToOrderColumns = true;
            this.flowpaneltopselling.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.flowpaneltopselling.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.flowpaneltopselling.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.flowpaneltopselling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flowpaneltopselling.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.flowpaneltopselling.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flowpaneltopselling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.flowpaneltopselling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flowpaneltopselling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5});
            this.bunifuTransition4.SetDecoration(this.flowpaneltopselling, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.flowpaneltopselling, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.flowpaneltopselling, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.flowpaneltopselling, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.flowpaneltopselling, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.flowpaneltopselling.DefaultCellStyle = dataGridViewCellStyle23;
            this.flowpaneltopselling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpaneltopselling.DoubleBuffered = true;
            this.flowpaneltopselling.EnableHeadersVisualStyles = false;
            this.flowpaneltopselling.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.flowpaneltopselling.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
            this.flowpaneltopselling.Location = new System.Drawing.Point(0, 42);
            this.flowpaneltopselling.MultiSelect = false;
            this.flowpaneltopselling.Name = "flowpaneltopselling";
            this.flowpaneltopselling.ReadOnly = true;
            this.flowpaneltopselling.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.flowpaneltopselling.RowHeadersVisible = false;
            this.flowpaneltopselling.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.flowpaneltopselling.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.flowpaneltopselling.RowTemplate.Height = 39;
            this.flowpaneltopselling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.flowpaneltopselling.Size = new System.Drawing.Size(672, 388);
            this.flowpaneltopselling.TabIndex = 89;
            this.bunifuToolTip1.SetToolTip(this.flowpaneltopselling, "");
            this.bunifuToolTip1.SetToolTipIcon(this.flowpaneltopselling, null);
            this.bunifuToolTip1.SetToolTipTitle(this.flowpaneltopselling, "");
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 530;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sales (Php)";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.bunifuImageButton26);
            this.panel31.Controls.Add(this.label27);
            this.panel31.Controls.Add(this.label5);
            this.fade.SetDecoration(this.panel31, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel31, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel31, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel31, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel31, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel31.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel31.Location = new System.Drawing.Point(0, 0);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(672, 42);
            this.panel31.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panel31, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel31, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel31, "");
            // 
            // bunifuImageButton26
            // 
            this.fade.SetDecoration(this.bunifuImageButton26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton26.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton26.Image")));
            this.bunifuImageButton26.ImageActive = null;
            this.bunifuImageButton26.Location = new System.Drawing.Point(145, 3);
            this.bunifuImageButton26.Name = "bunifuImageButton26";
            this.bunifuImageButton26.Size = new System.Drawing.Size(22, 18);
            this.bunifuImageButton26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton26.TabIndex = 18;
            this.bunifuImageButton26.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton26, "Voided Transactions are not included in this summary");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton26, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton26, "");
            this.bunifuImageButton26.Zoom = 10;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.fade.SetDecoration(this.label27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label27.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.DimGray;
            this.label27.Location = new System.Drawing.Point(6, 21);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(194, 15);
            this.label27.TabIndex = 16;
            this.label27.Text = "Your top 20 best selling products";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label27, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label27, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label27, "");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.fade.SetDecoration(this.label5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Top Selling Products";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label5, "");
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.fade.SetDecoration(this.panel22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel22.Location = new System.Drawing.Point(0, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(34, 827);
            this.panel22.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panel22, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel22, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel22, "");
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.fade.SetDecoration(this.panel23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel23.Location = new System.Drawing.Point(1693, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(34, 827);
            this.panel23.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.panel23, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel23, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel23, "");
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.bunifuSeparator7);
            this.fade.SetDecoration(this.panel19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(0, 192);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(1727, 15);
            this.panel19.TabIndex = 18;
            this.bunifuToolTip1.SetToolTip(this.panel19, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel19, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel19, "");
            // 
            // bunifuSeparator7
            // 
            this.bunifuSeparator7.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator7.LineThickness = 1;
            this.bunifuSeparator7.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator7.Name = "bunifuSeparator7";
            this.bunifuSeparator7.Size = new System.Drawing.Size(1727, 15);
            this.bunifuSeparator7.TabIndex = 16;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator7, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator7, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator7, "");
            this.bunifuSeparator7.Transparency = 255;
            this.bunifuSeparator7.Vertical = false;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.panel18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel18.Controls.Add(this.bunifuDropdown5);
            this.panel18.Controls.Add(this.panel24);
            this.panel18.Controls.Add(this.panel21);
            this.panel18.Controls.Add(this.panel14);
            this.panel18.Controls.Add(this.panel3);
            this.panel18.Controls.Add(this.panel17);
            this.panel18.Controls.Add(this.panel15);
            this.panel18.Controls.Add(this.panel16);
            this.fade.SetDecoration(this.panel18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1727, 192);
            this.panel18.TabIndex = 17;
            this.bunifuToolTip1.SetToolTip(this.panel18, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel18, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel18, "");
            // 
            // bunifuDropdown5
            // 
            this.bunifuDropdown5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuDropdown5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuDropdown5.BorderRadius = 5;
            this.bunifuDropdown5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.fade.SetDecoration(this.bunifuDropdown5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuDropdown5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuDropdown5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuDropdown5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuDropdown5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuDropdown5.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown5.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdown5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown5.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown5.FillDropDown = false;
            this.bunifuDropdown5.FillIndicator = false;
            this.bunifuDropdown5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdown5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuDropdown5.FormattingEnabled = true;
            this.bunifuDropdown5.Icon = null;
            this.bunifuDropdown5.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.bunifuDropdown5.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown5.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuDropdown5.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuDropdown5.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuDropdown5.ItemHeight = 26;
            this.bunifuDropdown5.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuDropdown5.Items.AddRange(new object[] {
            "BG1",
            "BG2",
            "BG3",
            "BG4",
            "None"});
            this.bunifuDropdown5.Location = new System.Drawing.Point(27, 3);
            this.bunifuDropdown5.Name = "bunifuDropdown5";
            this.bunifuDropdown5.Size = new System.Drawing.Size(95, 32);
            this.bunifuDropdown5.TabIndex = 19;
            this.bunifuDropdown5.Text = null;
            this.bunifuToolTip1.SetToolTip(this.bunifuDropdown5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuDropdown5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuDropdown5, "");
            this.bunifuDropdown5.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown5_SelectedIndexChanged);
            // 
            // panel24
            // 
            this.panel24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel24.Controls.Add(this.label26);
            this.panel24.Controls.Add(this.panel60);
            this.panel24.Controls.Add(this.bunifuSeparator9);
            this.panel24.Controls.Add(this.label22);
            this.panel24.Controls.Add(this.label23);
            this.panel24.Controls.Add(this.bunifuImageButton17);
            this.fade.SetDecoration(this.panel24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel24.Location = new System.Drawing.Point(1459, 44);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(239, 123);
            this.panel24.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.panel24, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel24, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel24, "");
            // 
            // label26
            // 
            this.fade.SetDecoration(this.label26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label26.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.DimGray;
            this.label26.Location = new System.Drawing.Point(18, 95);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(166, 18);
            this.label26.TabIndex = 19;
            this.label26.Text = "All time record";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label26, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label26, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label26, "");
            // 
            // panel60
            // 
            this.panel60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.fade.SetDecoration(this.panel60, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel60, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel60, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel60, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel60, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel60.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel60.Location = new System.Drawing.Point(0, 0);
            this.panel60.Name = "panel60";
            this.panel60.Size = new System.Drawing.Size(7, 123);
            this.panel60.TabIndex = 13;
            this.bunifuToolTip1.SetToolTip(this.panel60, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel60, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel60, "");
            // 
            // bunifuSeparator9
            // 
            this.bunifuSeparator9.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator9.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator9.LineThickness = 1;
            this.bunifuSeparator9.Location = new System.Drawing.Point(12, 84);
            this.bunifuSeparator9.Name = "bunifuSeparator9";
            this.bunifuSeparator9.Size = new System.Drawing.Size(217, 8);
            this.bunifuSeparator9.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator9, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator9, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator9, "");
            this.bunifuSeparator9.Transparency = 255;
            this.bunifuSeparator9.Vertical = false;
            // 
            // label22
            // 
            this.fade.SetDecoration(this.label22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label22.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Snow;
            this.label22.Location = new System.Drawing.Point(71, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(131, 18);
            this.label22.TabIndex = 14;
            this.label22.Text = "307";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.label22, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label22, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label22, "");
            // 
            // label23
            // 
            this.fade.SetDecoration(this.label23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label23.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DimGray;
            this.label23.Location = new System.Drawing.Point(74, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(150, 18);
            this.label23.TabIndex = 13;
            this.label23.Text = "Pending user request";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.label23, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label23, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label23, "");
            // 
            // bunifuImageButton17
            // 
            this.fade.SetDecoration(this.bunifuImageButton17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton17.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton17.Image")));
            this.bunifuImageButton17.ImageActive = null;
            this.bunifuImageButton17.Location = new System.Drawing.Point(12, 9);
            this.bunifuImageButton17.Name = "bunifuImageButton17";
            this.bunifuImageButton17.Size = new System.Drawing.Size(60, 64);
            this.bunifuImageButton17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton17.TabIndex = 12;
            this.bunifuImageButton17.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton17, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton17, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton17, "");
            this.bunifuImageButton17.Zoom = 10;
            // 
            // panel21
            // 
            this.panel21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel21.Controls.Add(this.bunifuImageButton20);
            this.panel21.Controls.Add(this.label19);
            this.panel21.Controls.Add(this.bunifuImageButton15);
            this.panel21.Controls.Add(this.bunifuSeparator8);
            this.panel21.Controls.Add(this.lblcollectables);
            this.panel21.Controls.Add(this.panel56);
            this.panel21.Controls.Add(this.label21);
            this.panel21.Controls.Add(this.bunifuImageButton16);
            this.fade.SetDecoration(this.panel21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel21.Location = new System.Drawing.Point(501, 44);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(205, 123);
            this.panel21.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.panel21, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel21, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel21, "");
            // 
            // bunifuImageButton20
            // 
            this.fade.SetDecoration(this.bunifuImageButton20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton20.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton20.Image")));
            this.bunifuImageButton20.ImageActive = null;
            this.bunifuImageButton20.Location = new System.Drawing.Point(179, 91);
            this.bunifuImageButton20.Name = "bunifuImageButton20";
            this.bunifuImageButton20.Size = new System.Drawing.Size(26, 27);
            this.bunifuImageButton20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton20.TabIndex = 18;
            this.bunifuImageButton20.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton20, "More Details");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton20, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton20, "");
            this.bunifuImageButton20.Zoom = 10;
            // 
            // label19
            // 
            this.fade.SetDecoration(this.label19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label19.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(43, 95);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 18);
            this.label19.TabIndex = 17;
            this.label19.Text = "In this current month";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label19, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label19, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label19, "");
            // 
            // bunifuImageButton15
            // 
            this.fade.SetDecoration(this.bunifuImageButton15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton15.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton15.Image")));
            this.bunifuImageButton15.ImageActive = null;
            this.bunifuImageButton15.Location = new System.Drawing.Point(11, 91);
            this.bunifuImageButton15.Name = "bunifuImageButton15";
            this.bunifuImageButton15.Size = new System.Drawing.Size(26, 27);
            this.bunifuImageButton15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton15.TabIndex = 16;
            this.bunifuImageButton15.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton15, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton15, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton15, "");
            this.bunifuImageButton15.Zoom = 10;
            // 
            // bunifuSeparator8
            // 
            this.bunifuSeparator8.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator8.LineThickness = 1;
            this.bunifuSeparator8.Location = new System.Drawing.Point(12, 84);
            this.bunifuSeparator8.Name = "bunifuSeparator8";
            this.bunifuSeparator8.Size = new System.Drawing.Size(189, 8);
            this.bunifuSeparator8.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator8, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator8, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator8, "");
            this.bunifuSeparator8.Transparency = 255;
            this.bunifuSeparator8.Vertical = false;
            // 
            // lblcollectables
            // 
            this.fade.SetDecoration(this.lblcollectables, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblcollectables, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lblcollectables, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lblcollectables, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lblcollectables, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblcollectables.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcollectables.ForeColor = System.Drawing.Color.Snow;
            this.lblcollectables.Location = new System.Drawing.Point(78, 55);
            this.lblcollectables.Name = "lblcollectables";
            this.lblcollectables.Size = new System.Drawing.Size(124, 18);
            this.lblcollectables.TabIndex = 14;
            this.lblcollectables.Text = "0.00";
            this.lblcollectables.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.lblcollectables, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblcollectables, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblcollectables, "");
            // 
            // panel56
            // 
            this.panel56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.fade.SetDecoration(this.panel56, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel56, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel56, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel56, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel56, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel56.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel56.Location = new System.Drawing.Point(0, 0);
            this.panel56.Name = "panel56";
            this.panel56.Size = new System.Drawing.Size(7, 123);
            this.panel56.TabIndex = 9;
            this.bunifuToolTip1.SetToolTip(this.panel56, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel56, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel56, "");
            // 
            // label21
            // 
            this.fade.SetDecoration(this.label21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label21.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Location = new System.Drawing.Point(74, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(128, 18);
            this.label21.TabIndex = 13;
            this.label21.Text = "Collectables";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.label21, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label21, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label21, "");
            // 
            // bunifuImageButton16
            // 
            this.fade.SetDecoration(this.bunifuImageButton16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton16.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton16.Image")));
            this.bunifuImageButton16.ImageActive = null;
            this.bunifuImageButton16.Location = new System.Drawing.Point(12, 9);
            this.bunifuImageButton16.Name = "bunifuImageButton16";
            this.bunifuImageButton16.Size = new System.Drawing.Size(60, 64);
            this.bunifuImageButton16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton16.TabIndex = 12;
            this.bunifuImageButton16.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton16, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton16, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton16, "");
            this.bunifuImageButton16.Zoom = 10;
            // 
            // panel14
            // 
            this.panel14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel14.Controls.Add(this.label7);
            this.panel14.Controls.Add(this.bunifuImageButton6);
            this.panel14.Controls.Add(this.bunifuSeparator2);
            this.panel14.Controls.Add(this.lblneworders);
            this.panel14.Controls.Add(this.label3);
            this.panel14.Controls.Add(this.bunifuImageButton5);
            this.panel14.Controls.Add(this.panel32);
            this.fade.SetDecoration(this.panel14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel14.Location = new System.Drawing.Point(32, 44);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(205, 123);
            this.panel14.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panel14, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel14, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel14, "");
            // 
            // label7
            // 
            this.fade.SetDecoration(this.label7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(43, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Updated every 5 minutes";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label7, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label7, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label7, "");
            // 
            // bunifuImageButton6
            // 
            this.fade.SetDecoration(this.bunifuImageButton6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(11, 91);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(26, 27);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 16;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton6, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton6, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton6, "");
            this.bunifuImageButton6.Zoom = 10;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(12, 84);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(188, 8);
            this.bunifuSeparator2.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator2, "");
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // lblneworders
            // 
            this.fade.SetDecoration(this.lblneworders, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblneworders, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lblneworders, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lblneworders, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lblneworders, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblneworders.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblneworders.ForeColor = System.Drawing.Color.Snow;
            this.lblneworders.Location = new System.Drawing.Point(78, 55);
            this.lblneworders.Name = "lblneworders";
            this.lblneworders.Size = new System.Drawing.Size(124, 18);
            this.lblneworders.TabIndex = 14;
            this.lblneworders.Text = "0.00";
            this.lblneworders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.lblneworders, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblneworders, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblneworders, "");
            // 
            // label3
            // 
            this.fade.SetDecoration(this.label3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(74, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "New orders";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.label3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label3, "");
            // 
            // bunifuImageButton5
            // 
            this.fade.SetDecoration(this.bunifuImageButton5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(12, 9);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(60, 64);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 12;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton5, "");
            this.bunifuImageButton5.Zoom = 10;
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.fade.SetDecoration(this.panel32, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel32, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel32, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel32, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel32, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel32.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel32.Location = new System.Drawing.Point(0, 0);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(7, 123);
            this.panel32.TabIndex = 7;
            this.bunifuToolTip1.SetToolTip(this.panel32, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel32, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel32, "");
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.bunifuImageButton7);
            this.panel3.Controls.Add(this.bunifuSeparator3);
            this.panel3.Controls.Add(this.lblrevenue);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.bunifuImageButton8);
            this.panel3.Controls.Add(this.panel34);
            this.fade.SetDecoration(this.panel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(267, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 123);
            this.panel3.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.panel3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel3, "");
            // 
            // label9
            // 
            this.fade.SetDecoration(this.label9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(43, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "In this current month";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label9, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label9, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label9, "");
            // 
            // bunifuImageButton7
            // 
            this.fade.SetDecoration(this.bunifuImageButton7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton7.Image")));
            this.bunifuImageButton7.ImageActive = null;
            this.bunifuImageButton7.Location = new System.Drawing.Point(11, 91);
            this.bunifuImageButton7.Name = "bunifuImageButton7";
            this.bunifuImageButton7.Size = new System.Drawing.Size(26, 27);
            this.bunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton7.TabIndex = 16;
            this.bunifuImageButton7.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton7, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton7, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton7, "");
            this.bunifuImageButton7.Zoom = 10;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(12, 84);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(186, 8);
            this.bunifuSeparator3.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator3, "");
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // lblrevenue
            // 
            this.fade.SetDecoration(this.lblrevenue, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblrevenue, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lblrevenue, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lblrevenue, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lblrevenue, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblrevenue.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrevenue.ForeColor = System.Drawing.Color.Snow;
            this.lblrevenue.Location = new System.Drawing.Point(79, 55);
            this.lblrevenue.Name = "lblrevenue";
            this.lblrevenue.Size = new System.Drawing.Size(123, 18);
            this.lblrevenue.TabIndex = 14;
            this.lblrevenue.Text = "0.00";
            this.lblrevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.lblrevenue, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblrevenue, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblrevenue, "");
            // 
            // label11
            // 
            this.fade.SetDecoration(this.label11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(74, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "Revenue";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.label11, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label11, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label11, "");
            // 
            // bunifuImageButton8
            // 
            this.fade.SetDecoration(this.bunifuImageButton8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton8.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton8.Image")));
            this.bunifuImageButton8.ImageActive = null;
            this.bunifuImageButton8.Location = new System.Drawing.Point(12, 9);
            this.bunifuImageButton8.Name = "bunifuImageButton8";
            this.bunifuImageButton8.Size = new System.Drawing.Size(60, 64);
            this.bunifuImageButton8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton8.TabIndex = 12;
            this.bunifuImageButton8.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton8, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton8, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton8, "");
            this.bunifuImageButton8.Zoom = 10;
            // 
            // panel34
            // 
            this.panel34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.fade.SetDecoration(this.panel34, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel34, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel34, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel34, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel34, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel34.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel34.Location = new System.Drawing.Point(0, 0);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(7, 123);
            this.panel34.TabIndex = 8;
            this.bunifuToolTip1.SetToolTip(this.panel34, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel34, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel34, "");
            // 
            // panel17
            // 
            this.panel17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel17.Controls.Add(this.label25);
            this.panel17.Controls.Add(this.bunifuSeparator6);
            this.panel17.Controls.Add(this.panel59);
            this.panel17.Controls.Add(this.label15);
            this.panel17.Controls.Add(this.label18);
            this.panel17.Controls.Add(this.bunifuImageButton13);
            this.fade.SetDecoration(this.panel17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel17.Location = new System.Drawing.Point(1221, 44);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(205, 123);
            this.panel17.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.panel17, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel17, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel17, "");
            // 
            // label25
            // 
            this.fade.SetDecoration(this.label25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label25.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.DimGray;
            this.label25.Location = new System.Drawing.Point(9, 95);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(166, 18);
            this.label25.TabIndex = 19;
            this.label25.Text = "All time record";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label25, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label25, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label25, "");
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator6.LineThickness = 1;
            this.bunifuSeparator6.Location = new System.Drawing.Point(11, 84);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Size = new System.Drawing.Size(189, 8);
            this.bunifuSeparator6.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator6, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator6, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator6, "");
            this.bunifuSeparator6.Transparency = 255;
            this.bunifuSeparator6.Vertical = false;
            // 
            // panel59
            // 
            this.panel59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.fade.SetDecoration(this.panel59, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel59, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel59, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel59, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel59, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel59.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel59.Location = new System.Drawing.Point(0, 0);
            this.panel59.Name = "panel59";
            this.panel59.Size = new System.Drawing.Size(7, 123);
            this.panel59.TabIndex = 12;
            this.bunifuToolTip1.SetToolTip(this.panel59, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel59, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel59, "");
            // 
            // label15
            // 
            this.fade.SetDecoration(this.label15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label15.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Snow;
            this.label15.Location = new System.Drawing.Point(71, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 18);
            this.label15.TabIndex = 14;
            this.label15.Text = "307";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.label15, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label15, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label15, "");
            // 
            // label18
            // 
            this.fade.SetDecoration(this.label18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label18.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DimGray;
            this.label18.Location = new System.Drawing.Point(74, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 18);
            this.label18.TabIndex = 13;
            this.label18.Text = "Users";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.label18, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label18, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label18, "");
            // 
            // bunifuImageButton13
            // 
            this.fade.SetDecoration(this.bunifuImageButton13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton13.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton13.Image")));
            this.bunifuImageButton13.ImageActive = null;
            this.bunifuImageButton13.Location = new System.Drawing.Point(11, 9);
            this.bunifuImageButton13.Name = "bunifuImageButton13";
            this.bunifuImageButton13.Size = new System.Drawing.Size(60, 64);
            this.bunifuImageButton13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton13.TabIndex = 12;
            this.bunifuImageButton13.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton13, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton13, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton13, "");
            this.bunifuImageButton13.Zoom = 10;
            // 
            // panel15
            // 
            this.panel15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel15.Controls.Add(this.label12);
            this.panel15.Controls.Add(this.bunifuImageButton11);
            this.panel15.Controls.Add(this.bunifuSeparator4);
            this.panel15.Controls.Add(this.label13);
            this.panel15.Controls.Add(this.panel57);
            this.panel15.Controls.Add(this.label14);
            this.panel15.Controls.Add(this.bunifuImageButton12);
            this.fade.SetDecoration(this.panel15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel15.Location = new System.Drawing.Point(737, 44);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(205, 123);
            this.panel15.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.panel15, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel15, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel15, "");
            // 
            // label12
            // 
            this.fade.SetDecoration(this.label12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(45, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "In this current date";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label12, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label12, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label12, "");
            // 
            // bunifuImageButton11
            // 
            this.fade.SetDecoration(this.bunifuImageButton11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton11.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton11.Image")));
            this.bunifuImageButton11.ImageActive = null;
            this.bunifuImageButton11.Location = new System.Drawing.Point(13, 91);
            this.bunifuImageButton11.Name = "bunifuImageButton11";
            this.bunifuImageButton11.Size = new System.Drawing.Size(26, 27);
            this.bunifuImageButton11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton11.TabIndex = 16;
            this.bunifuImageButton11.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton11, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton11, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton11, "");
            this.bunifuImageButton11.Zoom = 10;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(14, 84);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(188, 8);
            this.bunifuSeparator4.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator4, "");
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // label13
            // 
            this.fade.SetDecoration(this.label13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Snow;
            this.label13.Location = new System.Drawing.Point(77, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 18);
            this.label13.TabIndex = 14;
            this.label13.Text = "0.00";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.label13, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label13, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label13, "");
            // 
            // panel57
            // 
            this.panel57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.fade.SetDecoration(this.panel57, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel57, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel57, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel57, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel57, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel57.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel57.Location = new System.Drawing.Point(0, 0);
            this.panel57.Name = "panel57";
            this.panel57.Size = new System.Drawing.Size(7, 123);
            this.panel57.TabIndex = 10;
            this.bunifuToolTip1.SetToolTip(this.panel57, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel57, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel57, "");
            // 
            // label14
            // 
            this.fade.SetDecoration(this.label14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label14.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(74, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 18);
            this.label14.TabIndex = 13;
            this.label14.Text = "Voided Trans.";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.label14, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label14, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label14, "");
            // 
            // bunifuImageButton12
            // 
            this.fade.SetDecoration(this.bunifuImageButton12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton12.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton12.Image")));
            this.bunifuImageButton12.ImageActive = null;
            this.bunifuImageButton12.Location = new System.Drawing.Point(14, 9);
            this.bunifuImageButton12.Name = "bunifuImageButton12";
            this.bunifuImageButton12.Size = new System.Drawing.Size(60, 64);
            this.bunifuImageButton12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton12.TabIndex = 12;
            this.bunifuImageButton12.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton12, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton12, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton12, "");
            this.bunifuImageButton12.Zoom = 10;
            // 
            // panel16
            // 
            this.panel16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel16.Controls.Add(this.label24);
            this.panel16.Controls.Add(this.bunifuSeparator5);
            this.panel16.Controls.Add(this.lblcustomercount);
            this.panel16.Controls.Add(this.panel58);
            this.panel16.Controls.Add(this.label17);
            this.panel16.Controls.Add(this.bunifuImageButton14);
            this.fade.SetDecoration(this.panel16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel16.Location = new System.Drawing.Point(980, 44);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(205, 123);
            this.panel16.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.panel16, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel16, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel16, "");
            // 
            // label24
            // 
            this.fade.SetDecoration(this.label24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label24.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.DimGray;
            this.label24.Location = new System.Drawing.Point(10, 95);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(166, 18);
            this.label24.TabIndex = 18;
            this.label24.Text = "All time record";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.label24, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label24, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label24, "");
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator5.LineThickness = 1;
            this.bunifuSeparator5.Location = new System.Drawing.Point(12, 84);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(187, 8);
            this.bunifuSeparator5.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator5, "");
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = false;
            // 
            // lblcustomercount
            // 
            this.fade.SetDecoration(this.lblcustomercount, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblcustomercount, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lblcustomercount, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lblcustomercount, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lblcustomercount, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblcustomercount.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomercount.ForeColor = System.Drawing.Color.Snow;
            this.lblcustomercount.Location = new System.Drawing.Point(78, 55);
            this.lblcustomercount.Name = "lblcustomercount";
            this.lblcustomercount.Size = new System.Drawing.Size(124, 18);
            this.lblcustomercount.TabIndex = 14;
            this.lblcustomercount.Text = "307";
            this.lblcustomercount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.lblcustomercount, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblcustomercount, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblcustomercount, "");
            // 
            // panel58
            // 
            this.panel58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(14)))));
            this.fade.SetDecoration(this.panel58, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel58, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel58, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel58, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel58, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel58.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel58.Location = new System.Drawing.Point(0, 0);
            this.panel58.Name = "panel58";
            this.panel58.Size = new System.Drawing.Size(7, 123);
            this.panel58.TabIndex = 11;
            this.bunifuToolTip1.SetToolTip(this.panel58, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel58, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel58, "");
            // 
            // label17
            // 
            this.fade.SetDecoration(this.label17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label17.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(74, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 18);
            this.label17.TabIndex = 13;
            this.label17.Text = "Customers";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.label17, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label17, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label17, "");
            // 
            // bunifuImageButton14
            // 
            this.fade.SetDecoration(this.bunifuImageButton14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton14.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton14.Image")));
            this.bunifuImageButton14.ImageActive = null;
            this.bunifuImageButton14.Location = new System.Drawing.Point(12, 9);
            this.bunifuImageButton14.Name = "bunifuImageButton14";
            this.bunifuImageButton14.Size = new System.Drawing.Size(60, 64);
            this.bunifuImageButton14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton14.TabIndex = 12;
            this.bunifuImageButton14.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton14, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton14, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton14, "");
            this.bunifuImageButton14.Zoom = 10;
            // 
            // bunifuSeparator14
            // 
            this.bunifuSeparator14.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.bunifuSeparator14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuSeparator14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator14.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator14.LineThickness = 1;
            this.bunifuSeparator14.Location = new System.Drawing.Point(0, 1034);
            this.bunifuSeparator14.Name = "bunifuSeparator14";
            this.bunifuSeparator14.Size = new System.Drawing.Size(1727, 10);
            this.bunifuSeparator14.TabIndex = 20;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator14, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator14, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator14, "");
            this.bunifuSeparator14.Transparency = 255;
            this.bunifuSeparator14.Vertical = false;
            // 
            // panelusers
            // 
            this.panelusers.Controls.Add(this.flowLayoutPaneluser);
            this.panelusers.Controls.Add(this.panel25);
            this.fade.SetDecoration(this.panelusers, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panelusers, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelusers, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panelusers, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panelusers, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelusers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelusers.Location = new System.Drawing.Point(0, 0);
            this.panelusers.Name = "panelusers";
            this.panelusers.Size = new System.Drawing.Size(1727, 1044);
            this.panelusers.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.panelusers, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelusers, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelusers, "");
            this.panelusers.Visible = false;
            // 
            // flowLayoutPaneluser
            // 
            this.flowLayoutPaneluser.AutoScroll = true;
            this.flowLayoutPaneluser.AutoSize = true;
            this.bunifuTransition4.SetDecoration(this.flowLayoutPaneluser, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.flowLayoutPaneluser, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.flowLayoutPaneluser, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.flowLayoutPaneluser, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.fade.SetDecoration(this.flowLayoutPaneluser, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.flowLayoutPaneluser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPaneluser.Location = new System.Drawing.Point(0, 51);
            this.flowLayoutPaneluser.Name = "flowLayoutPaneluser";
            this.flowLayoutPaneluser.Size = new System.Drawing.Size(1727, 993);
            this.flowLayoutPaneluser.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.flowLayoutPaneluser, "");
            this.bunifuToolTip1.SetToolTipIcon(this.flowLayoutPaneluser, null);
            this.bunifuToolTip1.SetToolTipTitle(this.flowLayoutPaneluser, "");
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.panel26);
            this.fade.SetDecoration(this.panel25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel25.Location = new System.Drawing.Point(0, 0);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(1727, 51);
            this.panel25.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panel25, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel25, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel25, "");
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.bunifuDropdown3);
            this.panel26.Controls.Add(this.bunifuImageButton18);
            this.panel26.Controls.Add(this.bunifuTextBox3);
            this.fade.SetDecoration(this.panel26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel26.Location = new System.Drawing.Point(0, 0);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(549, 51);
            this.panel26.TabIndex = 21;
            this.bunifuToolTip1.SetToolTip(this.panel26, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel26, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel26, "");
            // 
            // bunifuDropdown3
            // 
            this.bunifuDropdown3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuDropdown3.BorderRadius = 10;
            this.bunifuDropdown3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.fade.SetDecoration(this.bunifuDropdown3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuDropdown3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuDropdown3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuDropdown3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuDropdown3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuDropdown3.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown3.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdown3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown3.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown3.FillDropDown = false;
            this.bunifuDropdown3.FillIndicator = false;
            this.bunifuDropdown3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuDropdown3.FormattingEnabled = true;
            this.bunifuDropdown3.Icon = null;
            this.bunifuDropdown3.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuDropdown3.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown3.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuDropdown3.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuDropdown3.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuDropdown3.ItemHeight = 26;
            this.bunifuDropdown3.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.bunifuDropdown3.Items.AddRange(new object[] {
            "sample1",
            "sample2",
            "sample3",
            "sample4"});
            this.bunifuDropdown3.Location = new System.Drawing.Point(306, 10);
            this.bunifuDropdown3.Name = "bunifuDropdown3";
            this.bunifuDropdown3.Size = new System.Drawing.Size(234, 32);
            this.bunifuDropdown3.TabIndex = 19;
            this.bunifuDropdown3.Text = null;
            this.bunifuToolTip1.SetToolTip(this.bunifuDropdown3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuDropdown3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuDropdown3, "");
            // 
            // bunifuImageButton18
            // 
            this.fade.SetDecoration(this.bunifuImageButton18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuImageButton18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuImageButton18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton18.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton18.Image")));
            this.bunifuImageButton18.ImageActive = null;
            this.bunifuImageButton18.Location = new System.Drawing.Point(263, 8);
            this.bunifuImageButton18.Name = "bunifuImageButton18";
            this.bunifuImageButton18.Size = new System.Drawing.Size(36, 33);
            this.bunifuImageButton18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton18.TabIndex = 12;
            this.bunifuImageButton18.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton18, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton18, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton18, "");
            this.bunifuImageButton18.Zoom = 10;
            this.bunifuImageButton18.Click += new System.EventHandler(this.bunifuImageButton18_Click);
            // 
            // bunifuTextBox3
            // 
            this.bunifuTextBox3.AcceptsReturn = false;
            this.bunifuTextBox3.AcceptsTab = false;
            this.bunifuTextBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox3.BackgroundImage")));
            this.bunifuTextBox3.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.bunifuTextBox3.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBox3.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(120)))));
            this.bunifuTextBox3.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuTextBox3.BorderRadius = 1;
            this.bunifuTextBox3.BorderThickness = 6;
            this.bunifuTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.fade.SetDecoration(this.bunifuTextBox3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuTextBox3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuTextBox3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuTextBox3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bunifuTextBox3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTextBox3.DefaultFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox3.DefaultText = "";
            this.bunifuTextBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.bunifuTextBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuTextBox3.HideSelection = true;
            this.bunifuTextBox3.IconLeft = null;
            this.bunifuTextBox3.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox3.IconPadding = 10;
            this.bunifuTextBox3.IconRight = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox3.IconRight")));
            this.bunifuTextBox3.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox3.Location = new System.Drawing.Point(3, 8);
            this.bunifuTextBox3.MaxLength = 32767;
            this.bunifuTextBox3.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox3.Modified = false;
            this.bunifuTextBox3.Name = "bunifuTextBox3";
            this.bunifuTextBox3.PasswordChar = '\0';
            this.bunifuTextBox3.ReadOnly = false;
            this.bunifuTextBox3.SelectedText = "";
            this.bunifuTextBox3.SelectionLength = 0;
            this.bunifuTextBox3.SelectionStart = 0;
            this.bunifuTextBox3.ShortcutsEnabled = true;
            this.bunifuTextBox3.Size = new System.Drawing.Size(254, 35);
            this.bunifuTextBox3.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.bunifuTextBox3.TabIndex = 0;
            this.bunifuTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox3.TextMarginLeft = 5;
            this.bunifuTextBox3.TextPlaceholder = "Quick Search";
            this.bunifuToolTip1.SetToolTip(this.bunifuTextBox3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuTextBox3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuTextBox3, "");
            this.bunifuTextBox3.UseSystemPasswordChar = false;
            // 
            // metroContextMenu1
            // 
            this.fade.SetDecoration(this.metroContextMenu1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.metroContextMenu1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.metroContextMenu1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.metroContextMenu1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.metroContextMenu1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshDashboardToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(193, 26);
            this.bunifuToolTip1.SetToolTip(this.metroContextMenu1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.metroContextMenu1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.metroContextMenu1, "");
            // 
            // refreshDashboardToolStripMenuItem
            // 
            this.refreshDashboardToolStripMenuItem.Name = "refreshDashboardToolStripMenuItem";
            this.refreshDashboardToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshDashboardToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.refreshDashboardToolStripMenuItem.Text = "Refresh Dashboard";
            this.refreshDashboardToolStripMenuItem.Click += new System.EventHandler(this.refreshDashboardToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_person_32.png");
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertBlind;
            this.bunifuTransition2.Cursor = null;
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
            this.bunifuTransition2.DefaultAnimation = animation2;
            this.bunifuTransition2.MaxAnimationTime = 2500;
            this.bunifuTransition2.TimeStep = 0.06F;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // fade
            // 
            this.fade.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Transparent;
            this.fade.Cursor = null;
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
            animation1.TransparencyCoeff = 1F;
            this.fade.DefaultAnimation = animation1;
            this.fade.Interval = 5;
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuTransition3
            // 
            this.bunifuTransition3.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition3.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.bunifuTransition3.DefaultAnimation = animation4;
            this.bunifuTransition3.Interval = 15;
            this.bunifuTransition3.MaxAnimationTime = 2500;
            this.bunifuTransition3.TimeStep = 0.06F;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.lblnotifcount;
            // 
            // bunifuTransition4
            // 
            this.bunifuTransition4.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertBlind;
            this.bunifuTransition4.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.bunifuTransition4.DefaultAnimation = animation5;
            this.bunifuTransition4.Interval = 15;
            this.bunifuTransition4.MaxAnimationTime = 2500;
            this.bunifuTransition4.TimeStep = 0.06F;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.sidepanel);
            this.Controls.Add(this.panel1);
            this.fade.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1231, 612);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel68.ResumeLayout(false);
            this.panelaccnt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.networkimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).EndInit();
            this.panelproducts.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.sidepanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel65.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            this.panelstock.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.panelmain.ResumeLayout(false);
            this.panelreports.ResumeLayout(false);
            this.panel64.ResumeLayout(false);
            this.panelreportcharts.ResumeLayout(false);
            this.panelreportcharts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton35)).EndInit();
            this.panel67.ResumeLayout(false);
            this.panel67.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton34)).EndInit();
            this.panel66.ResumeLayout(false);
            this.panel66.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton33)).EndInit();
            this.panelexpiredproducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.panel63.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton31)).EndInit();
            this.paneldebts.ResumeLayout(false);
            this.panel48.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.panel50.ResumeLayout(false);
            this.panel49.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton22)).EndInit();
            this.panel40.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView2)).EndInit();
            this.panel44.ResumeLayout(false);
            this.panel41.ResumeLayout(false);
            this.panel43.ResumeLayout(false);
            this.panel43.PerformLayout();
            this.panel51.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton24)).EndInit();
            this.panel42.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.panel38.ResumeLayout(false);
            this.panel61.ResumeLayout(false);
            this.panel62.ResumeLayout(false);
            this.paneldashboard.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            this.panel37.ResumeLayout(false);
            this.panel37.PerformLayout();
            this.panel53.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton25)).EndInit();
            this.panel45.ResumeLayout(false);
            this.panel46.ResumeLayout(false);
            this.panel46.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel36.ResumeLayout(false);
            this.panel36.PerformLayout();
            this.panel52.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton19)).EndInit();
            this.panel28.ResumeLayout(false);
            this.panel33.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flowpanelcriticalproducts)).EndInit();
            this.panel35.ResumeLayout(false);
            this.panel35.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton27)).EndInit();
            this.panel54.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flowpanelnearexpire)).EndInit();
            this.panel55.ResumeLayout(false);
            this.panel55.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton28)).EndInit();
            this.panel30.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flowpaneltopselling)).EndInit();
            this.panel31.ResumeLayout(false);
            this.panel31.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton26)).EndInit();
            this.panel19.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton17)).EndInit();
            this.panel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton16)).EndInit();
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).EndInit();
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton13)).EndInit();
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton12)).EndInit();
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton14)).EndInit();
            this.panelusers.ResumeLayout(false);
            this.panelusers.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton18)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panelaccnt;
        private Label lblnotifcount;
        private BunifuImageButton bunifuImageButton10;
        private BunifuImageButton bunifuImageButton2;
        private BunifuImageButton bunifuImageButton9;
        private BunifuSeparator bunifuSeparator1;
        private Label lblfullname;
        private BunifuPictureBox userpic;
        private Panel panelproducts;
        private BunifuDragControl bunifuDragControl1;
        private BunifuShadowPanel sidepanel;
        private Panel indicator;
        private BunifuFlatButton btn_stock;
        private BunifuFlatButton btn_product;
        private BunifuFlatButton btndashboard;
        private BunifuImageButton bunifuImageButton4;
        private Label lbltitle;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private BunifuTextBox bunifuTextBox1;
        private BunifuImageButton bunifuImageButton1;
        private BunifuFlatButton bunifuFlatButton1;
        private BunifuTransition bunifuTransition1;
        private BunifuTransition bunifuTransition2;
        private Panel panelmain;
        private Panel panelstock;
        private Panel panel5;
        private BunifuImageButton bunifuImageButton3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private BunifuTextBox bunifuTextBox2;
        private BunifuFlatButton btnusers;
        private BunifuFormFadeTransition bunifuFormFadeTransition1;
        private BunifuFlatButton btnpostransac;
        private BunifuFlatButton btnuserlog;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanelprodcategory;
        private Label label2;
        private BunifuFlatButton bunifuFlatButton2;
        private Label lblinventory;
        private Label label4;
        private Label lblsales;
        private Label label8;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel12;
        private Panel panel11;
        private Panel panel13;
        public Label lbldesignation;
        private Panel paneldashboard;
        private Panel panel14;
        private Label lblneworders;
        private Label label3;
        private BunifuImageButton bunifuImageButton5;
        private BunifuSeparator bunifuSeparator2;
        private BunifuImageButton bunifuImageButton6;
        private Label label7;
        private Panel panel3;
        private Label label9;
        private BunifuImageButton bunifuImageButton7;
        private BunifuSeparator bunifuSeparator3;
        private Label lblrevenue;
        private Label label11;
        private BunifuImageButton bunifuImageButton8;
        private Panel panel15;
        private Label label12;
        private BunifuImageButton bunifuImageButton11;
        private BunifuSeparator bunifuSeparator4;
        private Label label13;
        private Label label14;
        private BunifuImageButton bunifuImageButton12;
        private Panel panel16;
        private BunifuSeparator bunifuSeparator5;
        private Label lblcustomercount;
        private Label label17;
        private BunifuImageButton bunifuImageButton14;
        private Panel panel17;
        private BunifuSeparator bunifuSeparator6;
        private Label label15;
        private Label label18;
        private BunifuImageButton bunifuImageButton13;
        private Panel panel20;
        private Panel panel19;
        private BunifuSeparator bunifuSeparator7;
        private Panel panel18;
        private Panel panel21;
        private Label label19;
        private BunifuImageButton bunifuImageButton15;
        private BunifuSeparator bunifuSeparator8;
        private Label lblcollectables;
        private Label label21;
        private BunifuImageButton bunifuImageButton16;
        private Panel panel23;
        private Panel panel22;
        private Panel panel24;
        private Label label26;
        private BunifuSeparator bunifuSeparator9;
        private Label label22;
        private Label label23;
        private BunifuImageButton bunifuImageButton17;
        private Label label25;
        private Label label24;
        private Panel panelusers;
        private BunifuTransition fade;
        private Panel panel25;
        private Panel panel26;
        private BunifuImageButton bunifuImageButton18;
        private BunifuTextBox bunifuTextBox3;
        private FlowLayoutPanel flowLayoutPaneluser;
        private Panel panel29;
        private Panel panel27;
        private Panel panel28;
        private Panel panel30;
        private Panel panel31;
        private Label label5;
        private Label label27;
        private Panel panel33;
        private Panel panel35;
        private Label label32;
        private Label label33;
        private Panel panel36;
        private Label label35;
        private Label label34;
        private Panel panel37;
        private Label label10;
        private Label label36;
        private BunifuToolTip bunifuToolTip1;
        private BunifuImageButton bunifuImageButton19;
        private BunifuFlatButton btnreports;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private ToolStripMenuItem refreshDashboardToolStripMenuItem;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private BunifuImageButton bunifuImageButton20;
        private Panel panelreports;
        private Panel panel38;
        private BunifuFlatButton bunifuFlatButton3;
        private Panel paneldebts;
        private Panel panel40;
        private Panel panel41;
        private Panel panel42;
        private BunifuPictureBox bunifuPictureBox1;
        private Panel panel43;
        private Panel panel44;
        private BunifuSeparator bunifuSeparator10;
        private Panel panel47;
        private Panel panel48;
        private Panel panel49;
        private BunifuTextBox bunifuTextBox4;
        private BunifuSeparator bunifuSeparator11;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private BunifuImageButton bunifuImageButton21;
        private BunifuImageButton bunifuImageButton22;
        private DevExpress.XtraEditors.SplitterControl splitterControl2;
        private DevExpress.XtraEditors.SplitterControl splitterControl3;
        private ImageList imageList1;
        private BunifuImageButton bunifuImageButton24;
        private BunifuImageButton bunifuImageButton23;
        private Panel panel50;
        private Label label39;
        private Label label37;
        private Label label20;
        private BunifuSeparator bunifuSeparator13;
        private BunifuSeparator bunifuSeparator12;
        private Tulpep.NotificationWindow.PopupNotifier popup;
        private BunifuImageButton bunifuImageButton25;
        private BunifuImageButton bunifuImageButton26;
        private BunifuSeparator bunifuSeparator14;
        private Panel panel45;
        private Panel panel46;
        private Label label16;
        private Label label40;
        private BunifuCircleProgressbar bunifuCircleProgressbar1;
        private BunifuSeparator bunifuSeparator15;
        private BunifuCircleProgressbar bunifuCircleProgressbar2;
        private Label lbllog2;
        private Label lbllog1;
        private BunifuFlatButton bunifuFlatButton7;
        private Label lbllog4;
        private BunifuCircleProgressbar bunifuCircleProgressbar4;
        private BunifuFlatButton bunifuFlatButton6;
        private Label lbllog3;
        private BunifuCircleProgressbar bunifuCircleProgressbar3;
        private BunifuFlatButton bunifuFlatButton5;
        private BunifuFlatButton bunifuFlatButton4;
        private BunifuFlatButton bunifuFlatButton8;
        private Label lbllog5;
        private BunifuCircleProgressbar bunifuCircleProgressbar5;
        private Timer timer1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column6;
        private BunifuVScrollBar bunifuVScrollBar3;
        public Label lbldebtfullname;
        public BunifuDataGridView bunifuDataGridView2;
        public Label label38;
        private BunifuCustomDataGrid bunifuDataGridView1;
        private DataGridViewImageColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewLinkColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private Panel panel51;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown2;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown3;
        private Panel panel53;
        private Panel panel52;
        private Bunifu.DataViz.WinForms.BunifuDataViz bunifuDataViz1;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown1;
        private Bunifu.DataViz.WinForms.BunifuDataViz bunifuDataViz2;
        private BunifuTransition bunifuTransition3;
        private Panel panel54;
        private Panel panel55;
        private Label label45;
        private Label label46;
        private BunifuCustomDataGrid flowpaneltopselling;
        private BunifuCustomDataGrid flowpanelcriticalproducts;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private BunifuImageButton networkimg;
        private BunifuImageButton bunifuImageButton27;
        private BunifuImageButton bunifuImageButton28;
        private BunifuCustomDataGrid flowpanelnearexpire;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private Panel panel60;
        private Panel panel59;
        private Panel panel58;
        private Panel panel57;
        private Panel panel56;
        private Panel panel34;
        private Panel panel32;
        private BunifuImageButton bunifuImageButton29;
        private BunifuFlatButton bunifuFlatButton9;
        private Panel panel61;
        private Panel panel62;
        private Panel indicator2;
        private Panel panel39;
        private Panel panelexpiredproducts;
        private BunifuCustomDataGrid bunifuCustomDataGrid1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column7;
        private BunifuElipse bunifuElipse1;
        private BunifuImageButton bunifuImageButton30;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown5;
        private BunifuTransition bunifuTransition4;
        private Panel panel63;
        private BunifuImageButton bunifuImageButton32;
        private BunifuImageButton bunifuImageButton31;
        private BunifuTextBox bunifuTextBox5;
        private Panel panel64;
        private Panel panel65;
        private BunifuPictureBox bunifuPictureBox2;
        private BunifuFlatButton bunifuFlatButton10;
        private Panel panelreportcharts;
        private Bunifu.DataViz.WinForms.BunifuDataViz bunifuDataViz3;
        private BunifuSeparator bunifuSeparator16;
        private Panel panel66;
        private BunifuSeparator bunifuSeparator17;
        private Label label28;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown4;
        private Label label29;
        private BunifuSeparator bunifuSeparator18;
        private Bunifu.DataViz.WinForms.BunifuDataViz bunifuDataViz4;
        private BunifuImageButton bunifuImageButton33;
        private Label label31;
        private Label label30;
        private Label label6;
        private Panel panel67;
        private Label label41;
        private BunifuImageButton bunifuImageButton34;
        private Label label42;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private Bunifu.DataViz.WinForms.BunifuDataViz bunifuDataViz5;
        private BunifuImageButton bunifuImageButton37;
        private Label label43;
        private BunifuSeparator bunifuSeparator19;
        private BunifuImageButton bunifuImageButton36;
        private BunifuImageButton bunifuImageButton35;
        private BunifuSeparator bunifuSeparator20;
        private BunifuDatepicker bunifuDatepicker1;
        private Label label47;
        private Label label44;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Panel panel68;
        private BunifuSeparator bunifuSeparator21;
        private Label lbltime;
        private Label lbldate;
        private BunifuSeparator bunifuSeparator22;
        private BunifuSeparator bunifuSeparator23;
        private BunifuImageButton bunifuImageButton38;
        private BunifuImageButton bunifuImageButton39;
    }
}

