using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soleil_et_Soie
{
    public partial class ProductDetails : Form
    {
        Controller controllerObj;
        string desname;
        int desid;
        int stock;
        decimal unitprice;
        string descrip;
        Image desImg;
        decimal p;
        Cart MyCart;
        Form checkout;
        public ProductDetails(ImageInfo info, Cart Cart,string username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            this.Text = info.name;
            desname = info.name;
            desid = info.productid;
            labelDesName.Text = "Are you ready to add " + desname + " to your wardrobe?";
            DataTable details = controllerObj.RetrieveAllDesData(desid);
            DataRow row = details.Rows[0];
            stock = (int)row["StockQuantity"];
            descrip = row["Description"].ToString();
            labelStock.Text = "Only "+ stock +" left in Stock! Get yours NOW";
            desImg = info.productImage;
            pictureBoxdespic.Image = info.productImage;
            unitprice = info.price;
            labelDescription.Text = descrip;
            MyCart = Cart;
            checkout = new Checkout(MyCart,username);
        }

        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDownQuantity.Value > stock)
            {
                MessageBox.Show("Not Enough Pieces in Stock, Contact Our Customer Support or Wait for the next Drop!");
            }
            else
            {
                p = numericUpDownQuantity.Value * unitprice;
                labelPrice.Text = "Pay " + p.ToString("C");
            }
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            string designName = desname;
            int quantityordered = (int)numericUpDownQuantity.Value;
            Image image= desImg;
            decimal tot_price = p;
            MyCart.Show();

            if (quantityordered>0 && quantityordered<=stock)
            {
                // Add the item to the cart
                MyCart.AddToCart(designName, quantityordered, image, unitprice);
                stock -= quantityordered;
                labelStock.Text = "Only " + stock + " left in Stock! Get yours NOW";
                int result = controllerObj.TempUpdateStock(stock, desname); //temporarily update stock quantity in database to prevent ordering more than available

                // Notify the user
                MessageBox.Show(+quantityordered + " x " + designName + " added to cart!");

                MyCart.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please select a valid quantity before adding to the cart.");
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            string designName = desname;
            int quantityordered = (int)numericUpDownQuantity.Value;
            Image image = desImg;
            decimal tot_price = p;
            if (quantityordered > 0 && quantityordered <= stock)
            {
                // Add the item to the cart
                MyCart.AddToCart(designName, quantityordered, image, unitprice);
                stock -= quantityordered;
                labelStock.Text = "Only " + stock + " left in Stock! Get yours NOW";
                int result = controllerObj.TempUpdateStock(stock, desname); //temporarily update stock quantity in database to prevent ordering more than available
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a valid quantity before adding to the ordering.");
            }
            checkout.Show();
        }
    }
}
