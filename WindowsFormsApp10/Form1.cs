using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Oil> oils = new List<Oil>
            {
                new Oil
                {
                    Name="A-92",
                    Price=0.90,
                },
                new Oil
                {
                    Name="A-95",
                    Price=1.15,
                },
                new Oil
                {
                    Name="A-98",
                    Price=2,
                },
                new Oil
                {
                    Name="Dizel",
                    Price=0.80,
                },
            };



            oilcomboB.DisplayMember = nameof(Oil.Name);
            oilcomboB.DataSource = oils;



            List<Market> products = new List<Market>
            {
                new Market
                {
                    ProductName="Hot-dog",
                    Price=4,
                },
                 new Market
                {
                    ProductName="Hamburger",
                    Price=5.40,
                },
                  new Market
                {
                    ProductName="Free",
                    Price=7.20,
                },
                   new Market
                {
                    ProductName="Coca-Cola",
                    Price=4.40,
                },


            };

            productcheckedlistB.Items.AddRange(products.ToArray());
        }

        private void oilcomboB_SelectedIndexChanged(object sender, EventArgs e)
        {

            var oil = oilcomboB.SelectedItem as Oil;
            var price = oil.Price;
            CalculateInOil(price);
            pricetxtB.Text = $"{oil.Price}";

        }




        private void moneytxtB_TextChanged(object sender, EventArgs e)
        {
            var oil = oilcomboB.SelectedItem as Oil;
            var price = oil.Price;
            CalculateInOil(price);

        }

        private void litretxtB_TextChanged(object sender, EventArgs e)
        {
            var oil = oilcomboB.SelectedItem as Oil;
            var price = oil.Price;
            CalculateInOil(price);
        }

        public void CalculateInOil(double price)
        {
            var oil = oilcomboB.SelectedItem as Oil;
            oilsumtxtB.Text = moneytxtB.Text;
            try
            {

                if (moneytxtB.Enabled)
                {
                    litretxtB.Text = (int.Parse(moneytxtB.Text) / price).ToString();
                }
                else
                {

                    moneytxtB.Text = (int.Parse(litretxtB.Text) * price).ToString();
                }
            }
            catch (Exception ex)
            {

            }

        }


        private void aznRadioB_CheckedChanged(object sender, EventArgs e)
        {
            moneytxtB.Enabled = true;
            litretxtB.Enabled = false;
            moneytxtB.Text = String.Empty;
            litretxtB.Text = String.Empty;


        }

        private void litrRadioB_CheckedChanged(object sender, EventArgs e)
        {
            moneytxtB.Enabled = false;
            litretxtB.Enabled = true;
            moneytxtB.Text = String.Empty;
            litretxtB.Text = String.Empty;
        }
    }
}
