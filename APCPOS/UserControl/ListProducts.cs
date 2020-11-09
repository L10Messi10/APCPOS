using System;
using System.ComponentModel;
using System.Drawing;

namespace APCPOS.UserControl
{
    public partial class ListProducts : System.Windows.Forms.UserControl
    {
        public ListProducts()
        {
            InitializeComponent();
        }
        #region Properties
        private string _id;
        private string _prodname;
        private string _prodstock;
        private string _prodbarcode;
        private string _produnit;
        private string _prodprice;
        private Image _icon;

        [Category("Custom Props")]
        public string ID
        {
            get => _id;
            set
            {
                _id = value;
                lblID.Text = value;
            }
        }
        [Category("Custom Props")]
        public string Productname
        {
            get => _prodname;
            set
            {
                _prodname = value;
                lblprodname.Text = value;
            }
        }
        [Category("Custom Props")]
        public string Stock
        {
            get => _prodstock;
            set
            {
                _prodstock = value;
                lblstock.Text = value;
            }
        }

        [Category("Custom Props")]
        public string Barcode
        {
            get => _prodbarcode;
            set
            {
                _prodbarcode = value;
                lblbrcode.Text = value;
            }
        }
        [Category("Custom Props")]
        public string Unit
        {
            get => _produnit;
            set
            {
                _produnit = value;
                lblunit.Text = value;
            }
        }
        [Category("Custom Props")]
        public string Price
        {
            get => _prodprice;
            set
            {
                _prodprice = value;
                lblprice.Text = value;
            }
        }

        [Category("Custom Props")]
        public Image Icon
        {
            get => _icon;
            set
            {
                _icon = value;
                bunifuPictureBox1.Image = value;
            }
        }

        #endregion
        private void ListProducts_Load(object sender, EventArgs e)
        {

        }

        private void ListProducts_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(69, 70, 73);
        }

        private void ListProducts_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(29, 32, 38);
        }
    }
}
