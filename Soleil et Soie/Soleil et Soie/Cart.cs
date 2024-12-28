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
    public partial class Cart : Form
    {
        Form checkout;
        string Username;
        public List<CartItem> items; // A list to hold cart items //public so it can be accessed in UserHomePage
        public Cart(string username)
        {
            InitializeComponent();
            items = new List<CartItem>();
            Username = username;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //this.Close();//closes entire thing
            this.Hide(); //hide instead of close
        }

        public void AddToCart(string name, int quantity, Image img, decimal price)
        {
            // Check if the item already exists in the cart
            var existingItem = items.FirstOrDefault(i => i.Name == name);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity; // Update the quantity
            }
            else
            {
                //add new product
                if (img != null)
                {
                    items.Add(new CartItem { Name = name, Quantity = quantity, Image = img, Price = price });
                }
                else
                {
                    items.Add(new CartItem { Name = name, Quantity = quantity, Image = null, Price = price });
                }
            }

            RefreshCartView(); 
        }

        private void RefreshCartView()
        {

            flowLayoutPanelCart.Controls.Clear(); // Clear current view

            foreach (var item in items)
            {
                // Create a panel for each cart item
                Panel itemPanel = new Panel { Size = new Size(400, 100), Margin = new Padding(5) };

                // Add item details to the panel
                Label nameLabel = new Label { Text = item.Name, AutoSize = true, Location = new Point(10, 10) };
                Label quantityLabel = new Label { Text = "Quantity: " + item.Quantity, AutoSize = true, Location = new Point(10, 40) };
                Label priceLabel = new Label { Text = "Price: "+(item.Price * item.Quantity).ToString("C"), AutoSize = true, Location = new Point(10, 70) };
                PictureBox imageBox = new PictureBox { Image = item.Image, SizeMode = PictureBoxSizeMode.Zoom, Size = new Size(60, 60), Location = new Point(300, 10) };
                labelOrderTotal.Text = (item.Price * item.Quantity).ToString("C");
                labelTax.Text= ((item.Price * item.Quantity)*(decimal)0.15).ToString("C");
                labelGrandTot.Text= ((item.Price * item.Quantity) * (decimal)1.15).ToString("C");
                // Add controls to the panel
                itemPanel.Controls.Add(nameLabel);
                itemPanel.Controls.Add(quantityLabel);
                itemPanel.Controls.Add(priceLabel);
                itemPanel.Controls.Add(imageBox);

                // Add panel to the flow layout
                flowLayoutPanelCart.Controls.Add(itemPanel);
            }
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            checkout = new Checkout(this,Username);
            checkout.Show();
        }
    }
    public class CartItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Image Image { get; set; }
        public decimal Price { get; set; } 
    }
}
