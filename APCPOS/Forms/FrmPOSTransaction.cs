using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using APCPOS.Form_Transparent;
using APCPOS.Messageboxes;
using APCPOS.Properties;
using APCPOS.UserControl;
using static APCPOS.Includes.SqlConfig;
using static System.DateTime;

namespace APCPOS.Forms
{
    public partial class FrmPOSTransaction : Form
    {
        bool debtOpened;
        public static string TranNum;
        private float _linediscounts;
        private static float _subtotal;
        private static float _amntdue;
        private static float _vat;
        private static float _totVat;
        public static bool NewTrans;
        public static bool FillCart;
        private bool _xProductsLoaded;
        public static bool XCustomerLoaded;
        public static bool CustomerRetrieve;
        public static bool Hascustomer;
        public static string CustomerId;
        private int _totQty;
        private static string _prdid;
        public static string XSelectedProdId;
        private static int _prdqty;
        public static string ProdId; 

        public FrmPOSTransaction()
        {

            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                flowpanelproductsearch, new object[] { true });
        }

        private async void FrmPOSTransaction_Load(object sender, EventArgs e)
        {
            bunifuDropdown2.Text = Settings.Default.data_display;
            splashScreenManager1.ShowWaitForm();
            timer1.Start();
            await XLoadUser();
            await XFillCustomer();
            XGetSettings();
            await XFillProducts();
            splashScreenManager1.CloseWaitForm();
        }

        #region Commands

        private void XGetSettings()
        {
            bunifuiOSSwitch1.Value = Settings.Default.en_vat;
            bunifuiOSSwitch2.Value = Settings.Default.en_debt;
            bunifuiOSSwitch3.Value = Settings.Default.direct_print;
            bunifuiOSSwitch4.Value = Settings.Default.hor_flow;
            bunifuiOSSwitch5.Value = Settings.Default.dir_search;
        }
        private async Task XLoadUser()
        {
            UseWaitCursor = true;
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select TOP "+ Settings.Default.data_display + " * from tbl_Users where u_name='" + username + "'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            if (Sqlreader.Read())
            {
                lblfullname.Text = Sqlreader.GetValue(1).ToString();
                userfullname = lblfullname.Text;
                lbldesignation.Text = Sqlreader.GetValue(8).ToString();
                var img = (byte[])(Sqlreader.GetValue(9));
                if (img.Length != 0)
                {
                    userpic.Image = Image.FromStream(new MemoryStream(img));
                }
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            UseWaitCursor = false;
        }
        private void Xf1()
        {
            var payments = new FrmPayments
            {
                lblinvoice = {Text = TranNum},
                lblsubtotal = {Text = _subtotal.ToString("N")},
                lbltax = {Text = _vat.ToString("N")},
                lbltotaltax = {Text = _totVat.ToString("N")},
                AmountDue = _amntdue,
                Totitems = Convert.ToInt32(quantity.Text),
                lblamntdue = {Text = @"Php. " + _amntdue.ToString("N")},
                userpic = {Image = userpic.Image}
            };
            payments.ShowDialog();
            Focus();
        }
        private async void XVoid()
        {
            UseWaitCursor = true;
            var ms = new T_Message();
            var ok = new Frm_OK();
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql =
                "Update tbl_Transaction set tran_stat=@tran_stat Where Inv_Num=@Inv_Num";
            Sqlcmd.Parameters.AddWithValue("@Inv_Num",
                lblinvoice.Text);
            Sqlcmd.Parameters.AddWithValue("@tran_stat",
                "Voided");
            Sqlcmd.Connection = Cnn;
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.ExecuteNonQuery();
            Sqlcmd.Dispose();
            Strsql = "";
            Cnn.Close();
            NewTrans = true;
            FillCart = true;
            CustomerId = null;
            CustomerRetrieve = false;
            ms.Show(this);
            ok.OkDescription = "Error";
            ok.titletxt.Text = @"Void";
            ok.msgtxt.Text = @"Transaction cancelled!";
            ok.ShowDialog();
            ms.Close();
            popup.TitleText = @"Information";
            popup.Image = Resources.information;
            popup.ContentText = @"The last transaction was not successful!";
            popup.Popup();
            UseWaitCursor = false;
            Focus();
        }
        private async Task XFillProducts()
        {
            if (!_xProductsLoaded)
            {
                UseWaitCursor = true;
                await Conopen();
                flowpanelproducts.FlowDirection = Settings.Default.hor_flow ? FlowDirection.TopDown : FlowDirection.LeftToRight;
                Sqlcmd.Parameters.Clear();
                Strsql = "Select TOP " + Settings.Default.data_display + " * from V_Products where prod_fs = '" + "1" + "' AND prod_stock >= 1";
                Sqlcmd.CommandText = Strsql;
                Sqlcmd.Connection = Cnn;
                Sqladapter.SelectCommand = Sqlcmd;
                Sqlreader = Sqlcmd.ExecuteReader();
                flowpanelproducts.Controls.Clear();
                DataTable dt = new DataTable();
                dt.Load(Sqlreader);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var a = new ListTransacProd();
                    byte[] img = (byte[])(dt.Rows[i]["Prod_Img"]);
                    if (img.Length != 0)
                    {
                        MemoryStream ms = new MemoryStream(img);
                        a.bunifuPictureBox1.Image = Image.FromStream(ms);
                    }

                    a.label2.Text = dt.Rows[i]["Prod_Number"].ToString();
                    a.lblprodname.Text = dt.Rows[i]["Prod_Name"].ToString();
                    a.label1.Text = dt.Rows[i]["Prod_Stock"].ToString();
                    a.label6.Text = @"Php. " + dt.Rows[i]["Prod_Price"];
                    flowpanelproducts.Controls.Add(a);
                }

                Sqlcmd.Dispose();
                Sqlreader.Close();
                Cnn.Close();
                Strsql = "";
                bunifuTextBox1.Text = "";
                flowpanelproductsearch.Visible = false;
                _xProductsLoaded = true;
                UseWaitCursor = false;
                bunifuTextBox1.Focus();
            }
        }

        private async Task XFillCustomer()
        {
            if (!XCustomerLoaded)
            {
                flowpanelcustomer.FlowDirection = Settings.Default.hor_flow ? FlowDirection.TopDown : FlowDirection.LeftToRight;
                UseWaitCursor = true;
                await Conopen();
                Sqlcmd.Parameters.Clear();
                Strsql = "Select TOP "+ Settings.Default.data_display + " * from v_Customer";
                Sqlcmd.CommandText = Strsql;
                Sqlcmd.Connection = Cnn;
                Sqladapter.SelectCommand = Sqlcmd;
                Sqlreader = Sqlcmd.ExecuteReader();
                flowpanelcustomer.Controls.Clear();
                DataTable dt = new DataTable();
                dt.Load(Sqlreader);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var a = new ListCustomer();
                    //byte[] img = (byte[]) (dt.Rows[i]["cus_img"]);
                    //if (img.Length != 0)
                    //{
                    //    MemoryStream ms = new MemoryStream(img);
                    //    a.bunifuPictureBox1.Image = Image.FromStream(ms);
                    //}
                    a.lblid.Text= dt.Rows[i]["cus_ID"].ToString();
                    a.label2.Text = dt.Rows[i]["cus_address"].ToString();
                    a.lblfullname.Text = dt.Rows[i]["cus_fullname"].ToString();
                    a.label3.Text = dt.Rows[i]["cus_mobile"].ToString();
                    a.label5.Text = dt.Rows[i]["cus_email"].ToString();
                    flowpanelcustomer.Controls.Add(a);
                }

                Sqlcmd.Dispose();
                Sqlreader.Close();
                Cnn.Close();
                Strsql = "";
                bunifuTextBox1.Text = "";
                XCustomerLoaded = true;
                UseWaitCursor = false;
            }
        }
        private async Task XFillCart()
        {
            UseWaitCursor = true;
            _subtotal = 0;
            _totQty = 0;
            _linediscounts = 0;
            await Conopen();
            Strsql = "Select * from V_Receipt where Inv_Num='" + lblinvoice.Text + "'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            flowpanelcart.Rows.Clear();
            while (Sqlreader.Read())
            {
                var qty = Convert.ToInt32(Sqlreader.GetValue(3).ToString());
                _totQty += qty;
                var disc = Convert.ToSingle(Sqlreader.GetValue(4).ToString());
                _linediscounts += disc;
                var subTot = Convert.ToSingle(Sqlreader.GetValue(6).ToString());
                _subtotal += subTot;
                //*********************
                var a = Sqlreader.GetValue(1).ToString();
                var b = Sqlreader.GetValue(2).ToString();
                var c = Sqlreader.GetValue(3).ToString();
                var d = Sqlreader.GetValue(4).ToString();
                var e = Sqlreader.GetValue(5).ToString();
                var f = Sqlreader.GetValue(6).ToString();
                flowpanelcart.Rows.Add( a, b, c, d, e, f);
            }
            linediscounts.Text = _linediscounts.ToString("N");
            subtotal.Text = _subtotal.ToString("N");
            quantity.Text = _totQty.ToString();
            lblline.Text = flowpanelcart.RowCount.ToString();
            //_amntdue= 
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            if (flowpanelcart.RowCount == 0)
            {
                metroTile9.Enabled = false;
                metroTile11.Enabled = false;
            }
            else
            {
                metroTile9.Enabled = true;
                metroTile11.Enabled = true;
            }
            //******************Retrieve VAT****************
            if (Settings.Default.en_vat)
            {
                await Conopen();
                Strsql = "Select * from tbl_vat";
                Sqlcmd.CommandText = Strsql;
                Sqlcmd.Connection = Cnn;
                Sqladapter.SelectCommand = Sqlcmd;
                Sqlreader = Sqlcmd.ExecuteReader();
                if (Sqlreader.Read())
                {
                    _vat = Convert.ToSingle(Sqlreader.GetValue(1));
                    VAT.Text = _vat.ToString("N");
                }

                Sqlcmd.Dispose();
                Sqlreader.Close();
                Cnn.Close();
                Strsql = "";
            }
            else
            {
                _vat = 0;
                VAT.Text = _vat.ToString("N");
            }

            _totVat = _subtotal * _vat;
            total_vat.Text = _totVat.ToString("N");
            _amntdue = (float)Math.Round(_totVat + _subtotal);
            amntdue.Text = @"Php. " + _amntdue.ToString("N");
            FillCart = false;
            UseWaitCursor = false;
            bunifuTextBox1.Text = "";
            bunifuTextBox1.Focus();

        }

        private async Task XSearchProducts()
        {
            flowpanelproducts.FlowDirection = Settings.Default.hor_flow ? FlowDirection.TopDown : FlowDirection.LeftToRight;
            UseWaitCursor = true;
            await Conopen();
            int rescount;
            Sqlcmd.Parameters.Clear();
            Strsql = "Select * from V_Products where Prod_Number+Prod_Barcode+Prod_Name+cat_desc like '%" + bunifuTextBox1.Text + "%' and prod_fs = '" + "1" + "' AND prod_stock >= 1";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(Sqlreader);
            rescount = dt.Rows.Count;
            if (dt.Rows.Count != 0)
            {
                if (dt.Rows.Count != 1)
                {
                    _xProductsLoaded = false;
                    flowpanelproducts.Controls.Clear();
                    for (var i = 0; i < dt.Rows.Count; i++)
                    {
                        var a = new ListTransacProd();
                        byte[] img = (byte[])(dt.Rows[i]["Prod_Img"]);
                        if (img.Length != 0)
                        {
                            MemoryStream ms = new MemoryStream(img);
                            a.bunifuPictureBox1.Image = Image.FromStream(ms);
                        }

                        ProdId = dt.Rows[i]["Prod_Number"].ToString();
                        a.label2.Text = dt.Rows[i]["Prod_Number"].ToString();
                        a.lblprodname.Text = dt.Rows[i]["Prod_Name"].ToString();
                        a.label1.Text = dt.Rows[i]["Prod_Stock"].ToString();
                        a.label6.Text = @"Php. " + dt.Rows[i]["Prod_Price"];
                        flowpanelproducts.Controls.Add(a);
                    }
                }
                else
                {
                    for (var i = 0; i < dt.Rows.Count; i++)
                    {
                        ProdId = dt.Rows[i]["Prod_Number"].ToString();
                    }
                }
                
            }
            else
            {
                _xProductsLoaded = true;
                popup.TitleText = @"Warning";
                popup.Image = Resources.warning;
                popup.ContentText = @"No products found on your query, please try searching again!";
                popup.Popup();
                bunifuTextBox1.Text = "";
                bunifuTextBox1.Focus();
            }

            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            UseWaitCursor = false;
            if (rescount == 1)
            {
                if (TranNum != null)
                {
                    Sqlcmd.Parameters.Clear();
                    await Conopen();
                    Strsql = "Select * from tbl_Transaction_Detail where Inv_Num='" + TranNum + "' AND Prod_Number = '" + ProdId + "'";
                    Sqlcmd.CommandText = Strsql;
                    Sqlcmd.Connection = Cnn;
                    Sqladapter.SelectCommand = Sqlcmd;
                    Sqlreader = Sqlcmd.ExecuteReader();
                    //metroComboBox1.Items.Clear();
                    if (Sqlreader.Read())
                    {
                        var ms = new T_Message();
                        var ok = new Frm_OK();
                        ms.Show(this);
                        ok.OkDescription = "Warn";
                        ok.titletxt.Text = @"Warning";
                        ok.msgtxt.Text = @"This product is already in the cart. Are you trying to modify it's quantity? If so, please select set quantity option in the cart panel.";
                        ok.ShowDialog();
                        ms.Close();
                        ProdId = null;
                        bunifuTextBox1.Text = "";
                        bunifuTextBox1.Focus();
                    }
                    else
                    {
                        var b = new T_Transaction();
                        var a = new FrmAddToCart();
                        a.lblprodID.Text = ProdId;
                        b.Show(this);
                        a.ShowDialog();
                        //c.lblinvoice.Text = a.inv_num;
                        b.Dispose();
                        a.Dispose();
                        Focus();
                        bunifuTextBox1.Text = "";
                        bunifuTextBox1.Focus();
                    }

                    Sqlcmd.Dispose();
                    Sqlreader.Close();
                    Cnn.Close();
                    Strsql = "";
                }
                else
                {
                    var b = new T_Transaction();
                    var a = new FrmAddToCart();
                    a.lblprodID.Text = ProdId;
                    b.Show(this);
                    a.ShowDialog();
                    //c.lblinvoice.Text = a.inv_num;
                    b.Dispose();
                    a.Dispose();
                    Focus();
                    bunifuTextBox1.Text = "";
                    bunifuTextBox1.Focus();
                }
            }
        }

        private async Task XSearchProductsFlyout()
        {
            var openpanel = false;
            UseWaitCursor = true;
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select * from V_Products where Prod_Number+Prod_Barcode+Prod_Name+cat_desc like '%" + bunifuTextBox1.Text + "%' and prod_fs = '" + "1" + "' AND prod_stock >= 1";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            
            DataTable dt = new DataTable();
            dt.Load(Sqlreader);
            if (dt.Rows.Count != 0)
            {
                openpanel = true;
                flowpanelproductsearch.Controls.Clear();
                _xProductsLoaded = false;
                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    var a = new ListTransacProd();
                    var img = (byte[])(dt.Rows[i]["Prod_Img"]);
                    if (img.Length != 0)
                    {
                        var ms = new MemoryStream(img);
                        a.bunifuPictureBox1.Image = Image.FromStream(ms);
                    }
                    ProdId = dt.Rows[i]["Prod_Number"].ToString();
                    a.label2.Text = dt.Rows[i]["Prod_Number"].ToString();
                    a.lblprodname.Text = dt.Rows[i]["Prod_Name"].ToString();
                    a.label1.Text = dt.Rows[i]["Prod_Stock"].ToString();
                    a.label6.Text = @"Php. " + dt.Rows[i]["Prod_Price"];
                    flowpanelproductsearch.Controls.Add(a);
                }
            }
            else
            {
                flowpanelproductsearch.Controls.Clear();
                _xProductsLoaded = true;
                ProdId = null;
                popup.TitleText = @"Warning";
                popup.Image = Resources.warning;
                popup.ContentText = @"No products found on your query, please try searching again!";
                popup.Popup();
                bunifuTextBox1.Text = "";
                bunifuTextBox1.Focus();
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            UseWaitCursor = false;
            if (Settings.Default.dir_search == false)
            {
                flowpanelproductsearch.Top = bunifuTextBox1.Top;
                flowpanelproductsearch.Location = panel23.Location;
                flowpanelproductsearch.Top += 50;
                bunifuTransition1.ShowSync(flowpanelproductsearch);
                bunifuTextBox1.Focus();
            }
            else
            {
                if (flowpanelproductsearch.Controls.Count == 1)
                {
                    if (TranNum != null)
                    {
                        Sqlcmd.Parameters.Clear();
                        await Conopen();
                        Strsql = "Select * from tbl_Transaction_Detail where Inv_Num='" + TranNum + "' AND Prod_Number = '" + ProdId + "'";
                        Sqlcmd.CommandText = Strsql;
                        Sqlcmd.Connection = Cnn;
                        Sqladapter.SelectCommand = Sqlcmd;
                        Sqlreader = Sqlcmd.ExecuteReader();
                        //metroComboBox1.Items.Clear();
                        if (Sqlreader.Read())
                        {
                            var ms = new T_Message();
                            var ok = new Frm_OK();
                            ms.Show(this);
                            ok.OkDescription = "Warn";
                            ok.titletxt.Text = @"Warning";
                            ok.msgtxt.Text = @"This product is already in the cart. Are you trying to modify it's quantity? If so, please select set quantity option in the cart panel.";
                            ok.ShowDialog();
                            ms.Close();
                            ProdId = null;
                            bunifuTextBox1.Text = "";
                            bunifuTextBox1.Focus();
                        }
                        else
                        {
                            var b = new T_Transaction();
                            var a = new FrmAddToCart();
                            a.lblprodID.Text = ProdId;
                            b.Show(this);
                            a.ShowDialog();
                            //c.lblinvoice.Text = a.inv_num;
                            b.Dispose();
                            a.Dispose();
                            Focus();
                            bunifuTextBox1.Text = "";
                            bunifuTextBox1.Focus();
                        }
                        Sqlcmd.Dispose();
                        Sqlreader.Close();
                        Cnn.Close();
                        Strsql = "";
                    }
                    else
                    {
                        var b = new T_Transaction();
                        var a = new FrmAddToCart();
                        a.lblprodID.Text = ProdId;
                        b.Show(this);
                        a.ShowDialog();
                        //c.lblinvoice.Text = a.inv_num;
                        b.Dispose();
                        a.Dispose();
                        Focus();
                        bunifuTextBox1.Text = "";
                        bunifuTextBox1.Focus();
                    }
                    //
                }
                else
                {
                    if (openpanel)
                    {
                        flowpanelproductsearch.Top = bunifuTextBox1.Top;
                        flowpanelproductsearch.Location = panel23.Location;
                        flowpanelproductsearch.Top += 50;
                        bunifuTransition1.ShowSync(flowpanelproductsearch);
                        bunifuTextBox1.Focus();
                    }
                    
                }
            }
        }

        //private async Task XSearchCart()
        //{
        //    await Conopen();
        //    Strsql = "Select * from V_Receipt where Inv_Num='" + lblinvoice.Text + "'";
        //    Sqlcmd.CommandText = Strsql;
        //    Sqlcmd.Connection = Cnn;
        //    Sqladapter.SelectCommand = Sqlcmd;
        //    Sqlreader = Sqlcmd.ExecuteReader();
        //    flowpanelcart.Items.Clear();
        //    while (Sqlreader.Read())
        //    {
        //        var lvi = flowpanelcart.Items.Add(Sqlreader.GetValue(1).ToString());
        //        lvi.SubItems.Add(Sqlreader.GetValue(2).ToString());
        //        lvi.SubItems.Add(Sqlreader.GetValue(3).ToString());
        //        lvi.SubItems.Add(Sqlreader.GetValue(4).ToString());
        //        lvi.SubItems.Add(Sqlreader.GetValue(5).ToString());
        //        lvi.SubItems.Add(Sqlreader.GetValue(6).ToString());
        //    }
        //    Sqlcmd.Dispose();
        //    Sqlreader.Close();
        //    Cnn.Close();
        //    Strsql = "";
        //}

        private async Task XRetrieveCustomerinfo()
        {
            await Conopen();
            Strsql = "Select * from v_Customer where cus_ID = '" + label1.Text + "'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            if (Sqlreader.Read())
            {
                label2.Text = (Sqlreader.GetValue(1).ToString());
                var img = (byte[])(Sqlreader.GetValue(5));
                if (img.Length != 0)
                {
                    bunifuPictureBox1.Image = Image.FromStream(new MemoryStream(img));
                }
                label3.Text= (Sqlreader.GetValue(3).ToString());
                label4.Text = (Sqlreader.GetValue(4).ToString());
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            //CustomerRetrieve = false;
        }
        private static async Task XretriveProduct()
        {
            await Conopen();
            Strsql = "Select * from tbl_Transaction_Detail where Inv_Num='" + TranNum + "'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(Sqlreader);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                _prdid = dt.Rows[i]["Prod_Number"].ToString();
                _prdqty = Convert.ToInt32(dt.Rows[i]["qty"].ToString());
                await Xupdateproduct();
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }
        private static async Task Xupdateproduct()
        {
            int curstock = 0;
            int totqty;
            await Conopen();
            Strsql = "Select * from tbl_Products where prod_number='" + _prdid + "'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            if (Sqlreader.Read())
            {
                curstock = Convert.ToInt32(Sqlreader.GetValue(3).ToString());
            }
            Strsql = "";
            totqty = curstock - _prdqty;
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql =
                "Update tbl_Products set Prod_Stock=@Prod_Stock Where Prod_Number=@Prod_Number";
            Sqlcmd.Parameters.AddWithValue("@Prod_Stock", Convert.ToInt32(totqty));
            Sqlcmd.Parameters.AddWithValue("@Prod_Number", _prdid);
            Sqlcmd.Connection = Cnn;
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.ExecuteNonQuery();
            Sqlcmd.Dispose();
            Strsql = "";
            //prdqty = 0;
            //prdid = "";

        }
        private async Task XSearchCustomer()
        {
            flowpanelcustomer.FlowDirection = Settings.Default.hor_flow ? FlowDirection.TopDown : FlowDirection.LeftToRight;
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select TOP 50 * from v_Customer where cus_id+cus_fullname+cus_address+cus_mobile+cus_email like '%" + bunifuTextBox1.Text + "%' order by cus_lname";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            flowpanelcustomer.Controls.Clear();
            DataTable dt = new DataTable();
            dt.Load(Sqlreader);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var a = new ListCustomer();
                //byte[] img = (byte[]) (dt.Rows[i]["cus_img"]);
                //if (img.Length != 0)
                //{
                //    MemoryStream ms = new MemoryStream(img);
                //    a.bunifuPictureBox1.Image = Image.FromStream(ms);
                //}
                a.lblid.Text = dt.Rows[i]["cus_ID"].ToString();
                a.label2.Text = dt.Rows[i]["cus_address"].ToString();
                a.lblfullname.Text = dt.Rows[i]["cus_fullname"].ToString();
                a.label3.Text = dt.Rows[i]["cus_mobile"].ToString();
                a.label5.Text = dt.Rows[i]["cus_email"].ToString();
                flowpanelcustomer.Controls.Add(a);
            }

            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            XCustomerLoaded = false;
        }
        #endregion
        protected override bool ProcessCmdKey(ref Message message, Keys keyData)
        {
            // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
            switch (keyData)
            {
                case Keys.F1:
                {
                    if (TranNum != null)
                    {
                        Xf1();
                    }
                    //return true;    // indicate that you handled this keystroke
                    break;
                }
                case Keys.F2:
                    break;
                case Keys.F3:
                    break;
                case Keys.F4:
                    break;
                case Keys.F5:
                    bunifuTextBox1_OnIconRightClick(null,null);
                    break;
                case Keys.F6:
                    break;
                case Keys.F7:
                    break;
                case Keys.F8:
                    break;
                case Keys.F9:
                    break;
                case Keys.F10:
                    break;
                case Keys.F11:
                    break;
                case Keys.F12:
                    break;
                case Keys.F13:
                    break;
                case Keys.F14:
                    break;
                case Keys.F15:
                    break;
                case Keys.F16:
                    break;
                case Keys.F17:
                    break;
                case Keys.F18:
                    break;
                case Keys.F19:
                    break;
                case Keys.F20:
                    break;
                case Keys.F21:
                    break;
                case Keys.F22:
                    break;
                case Keys.F23:
                    break;
                case Keys.F24:
                    break;
                case Keys.Escape:
                    var ques = new Frm_Question();
                    var tQues = new T_Question();
                    if (TranNum != null)
                    {
                        tQues.Show(this);
                        ques.msgtxt.Text = @"This action will cancel this transaction, do you want to continue with this action?";
                        ques.titletxt.Text = @"Void confirmation";
                        ques.ShowDialog();
                        if (ques.DialogResult == DialogResult.Yes)
                        {
                            tQues.Close();
                            XSaveToNotif();
                            XVoid();
                            flowpanelcart.Visible = false;
                            flowpanelproducts.Visible = true;
                            flowpanelcustomer.Visible = false;
                            panelaction.Visible = false;
                            panelorder.Visible = true;
                            panelcustomer.Visible = false;
                            indicator.Top = btnorder.Top;
                            indicator.Visible = false;
                            lbltitle.Text = @"POS Transaction(Products)";
                            bunifuTransition1.ShowSync(indicator);
                            bunifuTextBox1.Focus();
                        }
                        else
                        {
                            tQues.Close();
                        }
                    }

                    //
                    break;
            }

            // Call the base class
            return false;
        }

        private void btnaction_Click(object sender, EventArgs e)
        {
            label20.Visible = false;
            flowpaneldebt.Visible = false;
            panelvatsettings.Visible = false;
            flowpanelcart.Visible = true;
            flowpanelproducts.Visible = false;
            flowpanelcustomer.Visible = false;
            panelaction.Visible = true;
            panelorder.Visible = false;
            panelcustomer.Visible = false;
            indicator.Top = btnaction.Top;
            indicator.Visible = false;
            lbltitle.Text = @"POS Transaction(Line)";
            bunifuTransition1.ShowSync(indicator);
            bunifuTextBox1.Focus();
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            label20.Visible = false;
            flowpaneldebt.Visible = false;
            panelvatsettings.Visible = false;
            flowpanelcart.Visible = false;
            flowpanelproducts.Visible = true;
            flowpanelcustomer.Visible = false;
            panelaction.Visible = false;
            panelorder.Visible = true;
            panelcustomer.Visible = false;
            indicator.Top = btnorder.Top;
            indicator.Visible = false;
            lbltitle.Text = @"POS Transaction(Products)";
            bunifuTransition1.ShowSync(indicator);
            bunifuTextBox1.Focus();
        }

        private void btndiscounts_Click(object sender, EventArgs e)
        {
            if (flowpanelcart.RowCount == 0)
            {
                flowpaneldebt.Visible = false;
                label20.Visible = true;
                panelvatsettings.Visible = true;
                flowpanelcart.Visible = false;
                flowpanelproducts.Visible = false;
                flowpanelcustomer.Visible = false;
                panelaction.Visible = false;
                panelorder.Visible = false;
                panelcustomer.Visible = false;
                lbltitle.Text = @"POS Transaction(Settings)";
                indicator.Top = btndiscounts.Top;
                indicator.Visible = false;
                bunifuTransition1.ShowSync(indicator);
            }
            else
            {
                popup.TitleText = @"Error";
                popup.Image = Resources.error;
                popup.ContentText = @"Cannot open settings when there's a Pending transaction!";
                popup.Popup();
            }
            
        }

        private async void FrmPOSTransaction_Activated(object sender, EventArgs e)
        {
            if (Connected)
            {
                timer1.Start();
                lblinvoice.Text = TranNum;
                label1.Text = CustomerId;
                if (NewTrans)
                {
                    lblinvoice.Text = "";
                    TranNum = null;
                    NewTrans = false;
                    _totQty = 0;
                    btnorder_Click(null, null);
                    bunifuTextBox1.Focus();
                    if (bunifuTextBox1.Text != "")
                    {
                        _xProductsLoaded = false;
                        splashScreenManager1.ShowWaitForm();
                        await XFillProducts();
                        splashScreenManager1.CloseWaitForm();
                    }

                    Focus();
                    Refresh();
                }

                if (FillCart)
                {
                    await XFillCart();
                }
                if (CustomerRetrieve)
                {
                    await XRetrieveCustomerinfo();
                    Refresh();
                }
                else
                {
                    CustomerId = null;
                    label1.Text = "";
                    label2.Text = "";
                    bunifuPictureBox1.Image = null;
                    label3.Text = "";
                    label4.Text = "";
                }
            }
            else
            {
                Cnn.Close();
                timer1.Stop();
                var tr = new T_Dashboard();
                var svr = new FrmServerSettings();
                tr.Show(this);
                svr.ShowDialog();
                tr.Dispose();
                Focus();
            }
            

        }

        private async void bunifuTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter) return;
            if (bunifuTextBox1.Text != "")
            {
                if (flowpanelcart.Visible && flowpanelproducts.Visible == false && flowpanelcustomer.Visible == false)
                {
                    await XSearchProductsFlyout();

                }
                else if (flowpanelproducts.Visible && flowpanelcart.Visible == false && flowpanelcustomer.Visible == false)
                {
                    await XSearchProducts();
                    //_xProductsLoaded = false;
                }
                else if (flowpanelcustomer.Visible && flowpanelcart.Visible == false && flowpanelproducts.Visible == false)
                {
                    await XSearchCustomer();
                }
            }

        }

        private async void bunifuTextBox1_OnIconRightClick(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text == "") return;
            if (flowpanelproducts.Visible)
            {
                bunifuTextBox1.Text = "";
                splashScreenManager1.ShowWaitForm();
                await XFillProducts();
                splashScreenManager1.CloseWaitForm();
            }
            else if (flowpanelcustomer.Visible)
            {
                bunifuTextBox1.Text = "";
                splashScreenManager1.ShowWaitForm();
                await XFillCustomer();
                splashScreenManager1.CloseWaitForm();
            }
            else if (flowpanelcart.Visible)
            {
                bunifuTextBox1.Text = "";
                bunifuTransition1.HideSync(flowpanelproductsearch);
            }
            else if (label20.Visible)
            {
                bunifuTextBox1.Text = "";
            }
        }

        private async void btncustomers_Click(object sender, EventArgs e)
        {
            await XFillCustomer();
            label20.Visible = false;
            panelvatsettings.Visible = false;
            flowpanelcart.Visible = false;
            flowpaneldebt.Visible = false;
            flowpanelproducts.Visible = false;
            flowpanelcustomer.Visible = true;
            panelaction.Visible = false;
            panelorder.Visible = false;
            panelcustomer.Visible = true;
            indicator.Top = btncustomers.Top;
            indicator.Visible = false;
            lbltitle.Text = @"POS Transaction(Customers)";
            bunifuTransition1.ShowSync(indicator);
            bunifuTextBox1.Focus();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            if (lblinvoice.Text != "")
            {
                Xf1();
            }
        }

        private void metroTile16_Click(object sender, EventArgs e)
        {

            var a=new T_Transaction();
            var cus=new FrmCustomerAE();
            a.Show(this);
            cus.ShowDialog();
            cus.Dispose();
            a.Dispose();

        }

        private  void metroTile11_Click(object sender, EventArgs e)
        {
            var ques = new Frm_Question();
            var tQues = new T_Question();
            if (lblinvoice.Text == "") return;
            tQues.Show(this);
            ques.msgtxt.Text = @"This action will cancel this transaction, do you want to continue with this action?";
            ques.titletxt.Text = @"Void confirmation";
            ques.ShowDialog();
            if (ques.DialogResult == DialogResult.Yes)
            {
                tQues.Dispose();
                XSaveToNotif();
                XVoid();
                flowpaneldebt.Visible = false;
                flowpanelcart.Visible = false;
                flowpanelproducts.Visible = true;
                flowpanelcustomer.Visible = false;
                panelaction.Visible = false;
                panelorder.Visible = true;
                panelcustomer.Visible = false;
                indicator.Top = btnorder.Top;
                indicator.Visible = false;
                Hascustomer = false;
                lbltitle.Text = @"POS Transaction(Products)";
                bunifuTransition1.ShowSync(indicator);
                //NewTrans = true;
                //FillCart = true;
                //_CustomerRetrieve = false;
                //_CustomerID = null;
            }
            else
            {
                tQues.Dispose();
            }
        }

        private async void XSaveToNotif()
        {
            logaction = username + " has voided a transaction with the transaction number " + lblinvoice.Text +".";
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql =
                "Insert into tbl_notification(not_title, not_desc, not_date) " +
                "Values(@not_title, @not_desc, @not_date)";
            Sqlcmd.Parameters.AddWithValue("@not_title",
                "Voided Transaction");
            Sqlcmd.Parameters.AddWithValue("@not_desc",
                logaction);
            Sqlcmd.Parameters.AddWithValue("@not_date",
                Now.ToString("G"));
            Sqlcmd.Connection = Cnn;
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.ExecuteNonQuery();
            Sqlcmd.Dispose();
            Cnn.Close();
            Strsql = string.Empty;
        }

        private void FrmPOSTransaction_Resize(object sender, EventArgs e)
        {
            if (Width == 1920 && Height == 1080)
            {
                Width = 1920;
                Height = 1080;
            }
            else if (Width == 1366 && Height == 768)
            {
                Width = 1366;
                Height = 768;
            }
        }

        private async void metroTile17_Click(object sender, EventArgs e)
        {
            await XFillCustomer();
        }

        private async void metroTile14_Click(object sender, EventArgs e)
        {
            if (Settings.Default.en_debt)
            {
                if (lblinvoice.Text != "")
                {
                    if (label1.Text != "")
                    {
                        var msg = new T_Message();
                        var tQuestion = new T_Question();
                        var ok = new Frm_OK();
                        var question = new Frm_Question {titletxt = {Text = @"Confirmation"}, msgtxt = {Text = @"This action will save this transaction. Do you want to continue this transaction?"}};
                        tQuestion.Show(this);
                        question.ShowDialog();
                        tQuestion.Close();
                        if (question.DialogResult != DialogResult.Yes) return;
                        Sqlcmd.Parameters.Clear();
                        await Conopen();
                        Strsql =
                            "Update tbl_Transaction set inv_amnt_due=@inv_amnt_due, inv_tax=@inv_tax,inv_tax_tot=@inv_tax_tot, Inv_total=@Inv_total, Inv_Num_of_items=@Inv_Num_of_items, cus_id=@cus_id, tran_stat=@tran_stat Where Inv_Num=@Inv_Num";
                        Sqlcmd.Parameters.AddWithValue("@inv_amnt_due",
                            Convert.ToSingle(subtotal.Text));
                        Sqlcmd.Parameters.AddWithValue("@inv_tax",
                            Convert.ToSingle(_vat));
                        Sqlcmd.Parameters.AddWithValue("@inv_tax_tot",
                            Convert.ToSingle(_totVat));
                        Sqlcmd.Parameters.AddWithValue("@Inv_total",
                            Convert.ToSingle(_amntdue));
                        Sqlcmd.Parameters.AddWithValue("@Inv_Num_of_items",
                            Convert.ToInt32(_totQty));
                        Sqlcmd.Parameters.AddWithValue("@Inv_Num",
                            lblinvoice.Text);
                        Sqlcmd.Parameters.AddWithValue("@cus_id",
                            label1.Text);
                        Sqlcmd.Parameters.AddWithValue("@tran_stat",
                            "Debt");
                        Sqlcmd.Connection = Cnn;
                        Sqlcmd.CommandText = Strsql;
                        Sqlcmd.ExecuteNonQuery();
                        Sqlcmd.Dispose();
                        Strsql = "";
                        Cnn.Close();
                        await XretriveProduct();
                        ok.OkDescription = "Success";
                        ok.titletxt.Text = @"Success";
                        ok.msgtxt.Text = @"Transaction successful! Click OK to send an email report and make sure that this PC has an internet connection.";
                        msg.Show(this);
                        ok.ShowDialog();
                        //Need to send an email
                        NewTrans = true;
                        FillCart = true;
                        CustomerRetrieve = false;
                        CustomerId = null;
                        ok.OkDescription = "Success";
                        ok.titletxt.Text = @"Success";
                        ok.msgtxt.Text = @"Transaction successful!";
                        ok.ShowDialog();
                        msg.Close();
                        flowpanelcart.Visible = false;
                        flowpanelproducts.Visible = true;
                        flowpanelcustomer.Visible = false;
                        panelaction.Visible = false;
                        panelorder.Visible = true;
                        panelcustomer.Visible = false;
                        indicator.Top = btnorder.Top;
                        indicator.Visible = false;
                        lbltitle.Text = @"POS Transaction(Products)";
                        bunifuTransition1.ShowSync(indicator);
                    }
                    else
                    {
                        popup.TitleText = "Warning";
                        popup.Image = Resources.warning;
                        popup.ContentText = "Can't add to debt. Please select first a customer to add this transaction to it's debt!";
                        popup.Popup();
                        Focus();
                    }
                }
                else
                {
                    popup.TitleText = "Warning";
                    popup.Image = Resources.warning;
                    popup.ContentText = "Please Add a product and select a customer first to continue with this transaction!";
                    popup.Popup();
                    Focus();
                }
            }
            else
            {
                popup.TitleText = "Warning";
                popup.Image = Resources.warning;
                popup.ContentText = "Debt is Temporarily disabled, Please try again later.";
                popup.Popup();
            }
        }

        private void metroTile15_Click(object sender, EventArgs e)
        {
            var ques = new Frm_Question();
            var tQues = new T_Question();
            if (label1.Text == "") return;
            tQues.Show(this);
            ques.msgtxt.Text = @"This action will clear the customer's data";
            ques.titletxt.Text = @"Clear data";
            ques.ShowDialog();
            if (ques.DialogResult == DialogResult.Yes)
            {
                
                CustomerRetrieve = false;
                CustomerId = null;
                Hascustomer = false;
                tQues.Dispose();
                Focus();
            }
            else
            {
                tQues.Dispose();
            }
            

        }

        private void bunifuTextBox1_Leave(object sender, EventArgs e)
        {
            if (flowpanelproductsearch.Visible)
            {
                bunifuTextBox1.Text = "";
                flowpanelproductsearch.Visible = false;
                //bunifuTransition1.HideSync(flowpanelproductsearch);
            }
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(bunifuImageButton10, 0, bunifuImageButton10.Height);
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a=new T_Transaction();
            var acc=new FrmAccountSettings();
            a.Show(this);
            acc.ShowDialog();
            acc.Dispose();
            a.Dispose();
        }

        private void bunifuiOSSwitch3_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch3.Value)
            {
                Settings.Default.direct_print = true;
                Settings.Default.Save();
            }
            else Settings.Default.direct_print = false;
            Settings.Default.Save();
        }

        private void bunifuiOSSwitch2_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch2.Value)
            {
                Settings.Default.en_debt = true;
                Settings.Default.Save();
            }
            else Settings.Default.en_debt = false;
            Settings.Default.Save();
        }

        private async void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value)
            {
                Settings.Default.en_vat = true;
                Settings.Default.Save();
                await Conopen();
                Strsql = "Select * from tbl_vat";
                Sqlcmd.CommandText = Strsql;
                Sqlcmd.Connection = Cnn;
                Sqladapter.SelectCommand = Sqlcmd;
                Sqlreader = Sqlcmd.ExecuteReader();
                if (Sqlreader.Read())
                {
                    _vat = Convert.ToSingle(Sqlreader.GetValue(1));
                    VAT.Text = _vat.ToString("N");
                }
                Sqlcmd.Dispose();
                Sqlreader.Close();
                Cnn.Close();
                Strsql = "";
            }
            else Settings.Default.en_vat = false;
            Settings.Default.Save();
            _vat = 0;
            VAT.Text = _vat.ToString("N");
        }

        private void FrmPOSTransaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            XCustomerLoaded = false;
        }

        private void bunifuiOSSwitch4_OnValueChange(object sender, EventArgs e)
        {
            Settings.Default.hor_flow = bunifuiOSSwitch4.Value;
            Settings.Default.Save();
        }

        private async void metroTile8_Click(object sender, EventArgs e)
        {
            if (flowpanelcart.RowCount != 0)
            {
                if (flowpanelcart.RowCount > 1)
                {
                    var transMess=new T_Message();
                    var ques=new Frm_Question();
                    ques.titletxt.Text = @"Confirmation";
                    ques.msgtxt.Text = @"Do you really want to remove this line?";
                    transMess.Show(this);
                    ques.ShowDialog();
                    if (ques.DialogResult != DialogResult.Yes) return;
                    await Conopen();
                    Sqlcmd.Parameters.Clear();
                    Strsql =
                        "Delete from tbl_Transaction_Detail where inv_num='" + lblinvoice.Text +"' and prod_number='" + XSelectedProdId +"'";
                    Sqlcmd.Connection = Cnn;
                    Sqlcmd.CommandText = Strsql;
                    Sqlcmd.ExecuteNonQuery();
                    Sqlcmd.Dispose();
                    Strsql = "";
                    Cnn.Close();
                    transMess.Dispose();
                    await XFillCart();
                }
                else
                {
                    var ques = new Frm_Question();
                    var tQues = new T_Question();
                    if (lblinvoice.Text == "") return;
                    tQues.Show(this);
                    ques.msgtxt.Text = @"This action will cancel this transaction, do you want to continue with this action?";
                    ques.titletxt.Text = @"Void confirmation";
                    ques.ShowDialog();
                    if (ques.DialogResult == DialogResult.Yes)
                    {
                        tQues.Dispose();
                        XVoid();
                        flowpanelcart.Visible = false;
                        flowpanelproducts.Visible = true;
                        flowpanelcustomer.Visible = false;
                        panelaction.Visible = false;
                        panelorder.Visible = true;
                        panelcustomer.Visible = false;
                        indicator.Top = btnorder.Top;
                        indicator.Visible = false;
                        lbltitle.Text = @"POS Transaction(Products)";
                        bunifuTransition1.ShowSync(indicator);
                        //NewTrans = true;
                        //FillCart = true;
                        //_CustomerRetrieve = false;
                        //_CustomerID = null;
                    }
                    else
                    {
                        tQues.Dispose();
                    }
                }
            }
            else
            {
                popup.Image = Resources.error;
                popup.TitleText = @"Information";
                popup.ContentText = @"There are no lines to remove. No transaction has been made yet.";
                popup.Popup();
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
           
        }

        private void flowpanelcart_Click_1(object sender, EventArgs e)
        {
            try
            {
                XSelectedProdId = (string)flowpanelcart.SelectedRows[0].Cells[0].Value;
            }
            catch
            {
                //ignored
            }
        }

        private void flowpanelcart_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                XSelectedProdId = (string)flowpanelcart.SelectedRows[0].Cells[0].Value;
            }
            catch
            {
                //ignored
            }
        }

        private void flowpanelcart_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                XSelectedProdId = (string)flowpanelcart.SelectedRows[0].Cells[0].Value;
            }
            catch
            {
                //ignored
            }
        }

        private void bunifuiOSSwitch5_OnValueChange(object sender, EventArgs e)
        {
            Settings.Default.dir_search = bunifuiOSSwitch5.Value;
            Settings.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = Now.ToString("D");
            lbltime.Text = Now.ToString("h:mm:ss tt");
            XPingServer();
        }
        private void XPingServer()
        {
            try
            {
                var p = new Ping();
                var s = IP_Add;
                var r = p.Send(s);
                networkimg.Image = r != null && r.Status == IPStatus.Success ? Resources.wifi_on : Resources.wifi_off;
            }
            catch
            {
                networkimg.Image = Resources.wifi_off;
                Cnn.Close();
                timer1.Stop();
                var tr = new T_Transaction();
                var svr = new FrmServerSettings();
                tr.Show(this);
                svr.ShowDialog();
                tr.Dispose();
                Focus();
            }

        }

        private void userpic_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(userpic, 0, userpic.Height);
        }

        private void lblfullname_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(lblfullname, 0, lblfullname.Height);
        }

        private void lbldesignation_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(lbldesignation, 0, lbldesignation.Height);
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            if (flowpanelcart.RowCount != 0)
            {
                if (XSelectedProdId != null)
                {
                    var t = new T_Transaction();
                    var dis = new FrmSetLineDiscount();
                    t.Show(this);
                    dis.lblprodname.Text = (string)flowpanelcart.SelectedRows[0].Cells[1].Value;
                    dis.proid = XSelectedProdId;
                    dis.inv_num = lblinvoice.Text;
                    dis.ShowDialog();
                    t.Dispose();
                    XSelectedProdId = null;
                    Focus();
                }
                else
                {
                    popup.Image = Resources.error;
                    popup.TitleText = @"Information";
                    popup.ContentText = @"Please Select a Line and set the discount!";
                    popup.Popup();
                }
            }
            else
            {
                popup.Image = Resources.error;
                popup.TitleText = @"Information";
                popup.ContentText = @"There are no lines. No transaction has been made yet.";
                popup.Popup();
            }
        }

        private void bunifuTextBox1_Enter(object sender, EventArgs e)
        {
            bunifuTextBox1.IconRight = bunifuTextBox1.Text != "" ? Resources.cancel1 : Resources.search;
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            bunifuTextBox1.IconRight = bunifuTextBox1.Text != "" ? Resources.cancel1 : Resources.search;
        }

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.data_display = bunifuDropdown2.Text;
            Settings.Default.Save();
        }

        private void metroTile18_Click(object sender, EventArgs e)
        {
            
            if (debtOpened == false)
            {
                if (CustomerId != null)
                {
                    label20.Visible = false;
                    panelvatsettings.Visible = false;
                    flowpanelcart.Visible = false;
                    flowpaneldebt.Visible = true;
                    flowpanelproducts.Visible = false;
                    flowpanelcustomer.Visible = false;
                    panelaction.Visible = false;
                    panelorder.Visible = false;
                    panelcustomer.Visible = true;
                    indicator.Top = btncustomers.Top;
                    lbltitle.Text = @"POS Transaction(Customers - Debt)";
                    debtOpened = true;
                }
                else
                {
                    popup.Image = Resources.error;
                    popup.TitleText = @"Customer";
                    popup.ContentText = @"Please select a customer first!";
                    popup.Popup();
                }
            }
            else
            {
                flowpaneldebt.Visible = false;
                flowpanelcustomer.Visible = true;
                debtOpened = false;
            }
            
        }

        private void flowpaneldebt_Leave(object sender, EventArgs e)
        {
            
        }

        private void flowpaneldebt_MouseLeave(object sender, EventArgs e)
        {
            flowpaneldebt.Visible = false;
            flowpanelcustomer.Visible = true;
        }
    }
}


//// Case-1 
//// A double value whose fractional part is  
//// less than the halfway between two  
//// consecutive integers 
//Double dx1 = 12.434565d;

//// Output value will be 12 
//Console.WriteLine("Rounded value of " + dx1 +  
//" is " + Math.Round(dx1)); 

//// Case-2 
//// A double value whose fractional part is  
//// greater than the halfway between two  
//// consecutive integers 
//Double dx2 = 12.634565d;

//// Output value will be 13 
//Console.WriteLine("Rounded value of " + dx2 +  
//" is " + Math.Round(dx2)); 

//Percentage computation
//double number = 0.1234;
//Console.WriteLine("The percent format is as : " + number.ToString("P", CultureInfo.InvariantCulture));  
//double no = 0.05;
//Console.WriteLine("The percent format is as : " + no.ToString("P", CultureInfo.InvariantCulture));  

