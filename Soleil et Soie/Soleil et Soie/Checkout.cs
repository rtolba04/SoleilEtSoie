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
        Controller controllerObj;
        string chosencard;
        string address;
        public Checkout(Cart cart,string username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            checkoutcart = new Cart(userName);
            checkoutcart = cart;
            userName= username;
            totalamount=0;
            address = controllerObj.GetAddress(username);
            if (address != null) 
            {
                textBoxAddress.Text = address;
            }
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
                    flowLayoutCard.Controls.Clear();
                    DataTable cards = new DataTable();
                    cards = controllerObj.GetCards(userid);
                    if (cards != null)
                    {
                        foreach (DataRow row in cards.Rows)
                        {
                            FlowLayoutPanel card = new FlowLayoutPanel();
                            card.Size = new Size(100, 100);
                            card.FlowDirection = FlowDirection.LeftToRight;
                            card.AutoSize = true;
                            card.Dock = DockStyle.Top;

                            Label id = new Label();
                            id.Visible = false;
                            id.Size = new Size(1,1);

                            RadioButton pickcard = new RadioButton();
                            pickcard.Text = "Card ends in " +row["EndsIn"].ToString();
                            pickcard.Margin = new Padding(10);
                            pickcard.AutoSize = true;

                            id.Text = row["CardNumber"].ToString();

                            card.Controls.Add(pickcard);
                            card.Controls.Add(id);

                            pickcard.CheckedChanged += (senders, ev) =>
                            {
                                if (pickcard.Checked) 
                                {
                                // Uncheck all other RadioButtons manually
                                foreach (RadioButton rb in flowLayoutCard.Controls
                                             .OfType<FlowLayoutPanel>()
                                             .SelectMany(p => p.Controls.OfType<RadioButton>()))
                                    {
                                        if (rb != pickcard)
                                        {
                                            rb.Checked = false;
                                        }
                                    }

                                    // Update button visibility and chosencard
                                    buttonFinishOrder.Visible = true;
                                    chosencard = id.Text;
                                }
                            };

                            flowLayoutCard.Controls.Add(card);
                        }
                    }
                    else
                    {
                        FlowLayoutPanel details = new FlowLayoutPanel();
                        details.Size = new Size(100, 100);
                        details.FlowDirection = FlowDirection.LeftToRight;
                        details.AutoSize = true;
                        details.Dock = DockStyle.Top;

                        Label holdername = new Label();
                        holdername.Text = "Cardholder name: ";
                        holdername.AutoSize = true;
                        holdername.Margin= new Padding(10);

                        Label cardnum = new Label();
                        cardnum.Text = "Card Number: ";
                        cardnum.AutoSize = true;
                        cardnum.Margin= new Padding(10);

                        Label cvv = new Label();
                        cvv.Text = "CVV: ";
                        cvv.AutoSize = true;
                        cvv.Margin = new Padding(10);

                        Label ExpDate = new Label();
                        ExpDate.Text = "Expiry Date: ";
                        ExpDate.AutoSize = true;
                        ExpDate.Margin = new Padding(10);

                        details.Controls.Add(holdername);
                        details.Controls.Add(cardnum);
                        details.Controls.Add(cvv);
                        details.Controls.Add(ExpDate);

                        flowLayoutCard.Controls.Add(details);
                    }
                    if (flowLayoutCard.Visible == false)
                    {
                        flowLayoutCard.Visible = true;
                    }
                    flowLayoutCard.PerformLayout();
                    flowLayoutCard.Refresh();
                }
                else
                {
                    if (flowLayoutCard.Visible == true)
                    {
                        flowLayoutCard.Hide();
                    }
                }
            }
        }
    }
}
