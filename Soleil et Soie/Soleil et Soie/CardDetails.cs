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
    public partial class CardDetails : UserControl
    {
        Controller controllerObj;
        int userID;
        public CardDetails(int userid)
        {
            InitializeComponent();
            controllerObj = new Controller();
            userID = userid;
        }

        private void CardDetails_Load(object sender, EventArgs e)
        {
            DataTable cards= new DataTable();
            cards = controllerObj.GetCards(userID);
            if (cards != null)
            {
                foreach(DataRow row in cards.Rows)
                {
                    FlowLayoutPanel card = new FlowLayoutPanel();
                    card.AutoScroll = true;
                    card.Size = new Size(flowLayoutMain.Width, 30);
                    card.FlowDirection = FlowDirection.LeftToRight;
                    card.AutoSize = true;
                    card.Dock = DockStyle.Top;

                    Label cardlabel=new Label();
                    cardlabel.AutoSize = true;
                    cardlabel.Text = "Card ends in" + row["EndsIn"].ToString();
                    cardlabel.Margin = new Padding(10);

                    RadioButton pickcard = new RadioButton();
                    pickcard.Text = "";
                    pickcard.Margin = new Padding(10);

                    card.Controls.Add(cardlabel);
                    card.Controls.Add(pickcard);

                    flowLayoutMain.Controls.Add(card);
                    flowLayoutMain.BringToFront();
                }
            }
            else
            {
                FlowLayoutPanel details = new FlowLayoutPanel();
                details.AutoScroll = true;
                details.Size = new Size(30, 30);
                details.FlowDirection = FlowDirection.LeftToRight;
                details.AutoSize = true;
                details.Dock = DockStyle.Top;

                Label holdername = new Label();
                holdername.Text = "Cardholder name: ";
                holdername.AutoSize = true;
                holdername.Location = new Point(0, 5);

                Label cardnum= new Label();
                cardnum.Text = "Card Number: ";
                cardnum.AutoSize = true;
                cardnum.Location=new Point(0, 15);

                Label cvv = new Label();
                cvv.Text = "CVV: ";
                cvv.AutoSize = true;
                cvv.Location = new Point(0, 25);

                Label ExpDate = new Label();
                ExpDate.Text = "Expiry Date: ";
                ExpDate.AutoSize = true;
                ExpDate.Location = new Point(0, 35);

                details.Controls.Add(holdername);
                details.Controls.Add(cardnum);
                details.Controls.Add(cvv);
                details.Controls.Add(ExpDate);

                flowLayoutMain.Controls.Add(details);
            }
        }
    }
}
