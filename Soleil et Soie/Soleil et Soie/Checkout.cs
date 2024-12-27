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
    public partial class Checkout : Form
    {
        int totalamount;
        int userid;
        string userName;
        Cart checkoutcart;
        CardDetails cardpanel;
        Controller controllerObj;
        public Checkout(Cart cart,string username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            checkoutcart = new Cart(userName);
            checkoutcart = cart;
            userName= username;
            totalamount=0;
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            userid = controllerObj.GetUserNoPass(userName);
            foreach(CartItem product in checkoutcart.items)
            {
                FlowLayoutPanel ProductPanel = new FlowLayoutPanel();
                ProductPanel.FlowDirection = FlowDirection.LeftToRight;
                ProductPanel.Height = 150;
                ProductPanel.Dock = DockStyle.Top;

                PictureBox pictureBoxitem = new PictureBox();
                if (product.Image != null)
                {
                    pictureBoxitem.Image = product.Image;
                }
                pictureBoxitem.Size = new Size(75, 75);
                pictureBoxitem.Location = new Point(0, 38);
                pictureBoxitem.SizeMode= PictureBoxSizeMode.Zoom;
                Label labelitem = new Label();
                labelitem.Text=product.Name;
                labelitem.AutoSize = true;
                labelitem.Location = new Point(80, 38);
                Label Quantity = new Label();
                Quantity.Text="Quantity: "+product.Quantity.ToString();
                Quantity.AutoSize = true;
                Quantity.Location = new Point(80, 48);
                Label Total = new Label();
                Total.Text = "Total: " + (product.Price * product.Quantity).ToString("C");
                Total.AutoSize = true;
                Total.Location = new Point(80, 50);

                totalamount+= (int)(product.Price * product.Quantity);
                ProductPanel.Controls.Add(pictureBoxitem);
                ProductPanel.Controls.Add(labelitem);
                ProductPanel.Controls.Add(Quantity);
                ProductPanel.Controls.Add(Total);

                flowLayoutItems.Controls.Add(ProductPanel);
            }
            labelTotal.Text = "Order Total: " + totalamount.ToString("C");

        }

        private void radioButtonCard_CheckedChanged(object sender, EventArgs e)
        {
            if (userid != -1)
            {
                if (radioButtonCard.Checked)
                {
                    cardpanel= new CardDetails(userid);
                    cardpanel.Dock = DockStyle.Fill;
                    cardpanel.AutoSize = true;
                    flowLayoutCard.Controls.Clear();
                    flowLayoutCard.Controls.Add(cardpanel);
                    flowLayoutCard.Refresh();
                }
                else
                {
                    if (cardpanel.Visible == true)
                    {
                        cardpanel.Hide();
                    }
                }
            }
        }
    }
}
