using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
                        buttonFinishOrder.Visible = true;
                        FlowLayoutPanel details = new FlowLayoutPanel();
                        details.Size = new Size(flowLayoutCard.Width, 100);
                        details.FlowDirection = FlowDirection.LeftToRight;
                        details.AutoSize = true;
                        details.Dock = DockStyle.Top;

                        Label holdername = new Label();
                        holdername.Text = "Cardholder name: ";
                        holdername.AutoSize = true;
                        holdername.Margin= new Padding(10);
                        TextBox holdernameBox=new TextBox();
                        holdernameBox.Margin=new Padding(10, 0, 0, 0);

                        Label cardnum = new Label();
                        cardnum.Text = "Card Number: ";
                        cardnum.AutoSize = true;
                        cardnum.Margin= new Padding(10);
                        TextBox cardnumBox = new TextBox();
                        cardnumBox.Margin = new Padding(30, 0, 0, 0);

                        Label cvv = new Label();
                        cvv.Text = "CVV: ";
                        cvv.AutoSize = true;
                        cvv.Margin = new Padding(30, 0, 10, 0);
                        TextBox cvvBox = new TextBox();
                        cvvBox.Margin = new Padding(20,0,20,0);

                        Label ExpDate = new Label();
                        ExpDate.Text = "Expiry Date: (year/month)";
                        ExpDate.AutoSize = true;
                        ExpDate.Margin = new Padding(20, 0, 10, 0);
                        TextBox yearBox = new TextBox();
                        yearBox.Width = 50;
                        yearBox.Margin = new Padding(10);
                        Label slash = new Label();
                        slash.Text = " / ";
                        slash.AutoSize = true;
                        TextBox monthBox = new TextBox();
                        monthBox.Width = 20;
                        monthBox.Margin = new Padding(10);

                        Button savecard=new Button();
                        savecard.Text = "Save card details";
                        savecard.AutoSize = true;

                        savecard.Click += (senders, ev) =>
                        {
                            if (!(holdernameBox.Text == "") && !(cardnumBox.Text == "") && !(cvvBox.Text == "") && !(yearBox.Text == "") && !(monthBox.Text == ""))
                            {
                                SaveCard(holdernameBox.Text, cardnumBox.Text, cvvBox.Text, yearBox.Text, monthBox.Text);
                            }
                            else MessageBox.Show("Please fill in all fields");
                        };

                        details.Controls.Add(holdername);
                        details.Controls.Add (holdernameBox);
                        details.Controls.Add(cardnum);
                        details.Controls.Add(cardnumBox);
                        details.Controls.Add(cvv);
                        details.Controls.Add(cvvBox);
                        details.Controls.Add(ExpDate);
                        details.Controls.Add(yearBox);
                        details.Controls.Add(slash);
                        details.Controls.Add(monthBox);
                        details.Controls.Add(savecard);


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
                    if (radioButtonCash.Checked == true)
                    {
                        buttonFinishOrder.Visible = true;
                    }
                }
            }
        }
        public void SaveCard(string holder,string cardnum, string cvv,string year,string month)
        {
            long CardNum;
            int CVV;
            int YEAR, MONTH;
            if (!(holder.All(c => char.IsLetter(c))))
            { 
                MessageBox.Show("Card holder name cannot contain numbers");
            }
            else if((!(long.TryParse(cardnum,out CardNum))) || cardnum.Length!=16)
            {
                MessageBox.Show("Card number cannot contain characters and should contain 16 digits");
            }
            else if((!(int.TryParse(cvv, out CVV))) || cvv.Length != 3)
            {
                MessageBox.Show("CVV cannot contain characters and consists of 3 digits");
            }
            else if(!(int.TryParse(year, out YEAR)) || !(int.TryParse(month, out MONTH)) || YEAR<2024 || MONTH<1 || MONTH>12)
            {
                MessageBox.Show("Invalid expiry date");
            }
            else
            {
                int EndsIn= int.Parse(cardnum.Substring(cardnum.Length - 4));
                string hashnum = Hash(cardnum);
                string hashcvv = Hash(cvv);
                bool saved = controllerObj.SaveCardDetails(userid, holder,hashnum,hashcvv,YEAR,MONTH,EndsIn);
                if (saved)
                {
                    MessageBox.Show("Card added successfully");
                }
                else MessageBox.Show("Failed to save card");
            }
        }
        public static string Hash(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
