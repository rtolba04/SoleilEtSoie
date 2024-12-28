using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Soleil_et_Soie
{
    
    public partial class UserHomePage : Form
    {
        Controller controllerObj;
        Profile userprofile;
        Cart MyCart;
        public UserHomePage(string UserName)
        {
            InitializeComponent();
            if (!DesignMode)
            {
                controllerObj = new Controller();
                UsernameLabel.Text = UserName;
                userprofile = new Profile(UserName);
                DisplayImages();
                MyCart = new Cart(UserName);
            }
            
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, UserProfile.Width, UserProfile.Height);
            UserProfile.Region = new Region(gp);
        }

        //change bytearray to image
        private Image ByteArraytoImage(byte[] imagebytes)
        {
            using (MemoryStream ms = new MemoryStream(imagebytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void CollectionsButton_Click(object sender, EventArgs e)
        {
            CollectionsLayOut.Visible = !CollectionsLayOut.Visible;
        }

        private void CategButton_Click(object sender, EventArgs e)
        {
            CategLayout.Visible = !CategLayout.Visible;
        }
        //function called once event is fired, retreives picture from db
        public void UpdateProfilePicture(byte[] imagebytes) {
            controllerObj.ProfilePicture(UsernameLabel.Text, ref imagebytes);
            if (imagebytes != null)
                UserProfile.Image = ByteArraytoImage(imagebytes);
        }

        private void UserProfile_Click(object sender, EventArgs e)
        {
            //once profile form is opened, subscribe to the event
            userprofile.ProfilePictureUpdated += UpdateProfilePicture;
            userprofile.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            int result = controllerObj.LoggedOut(UsernameLabel.Text);
            this.Close();
        }
        //when form is first loaded, if it was changed before profile picture will change else default stays
        private void UserHomePage_Load(object sender, EventArgs e)
        {
            byte[] imagebytes=new byte[1024];
            controllerObj.ProfilePicture(UsernameLabel.Text, ref imagebytes);
            if (imagebytes != null)
                UserProfile.Image = ByteArraytoImage(imagebytes);
        }

        public void DisplayImages()
        {
            int horizontalspace=30;
            int verticalspace = 20;
            DataTable images=new DataTable();
            List<ImageInfo> products = new List<ImageInfo>(); //list of imageinfo to hold all pictures
            images = controllerObj.GetProducts(); //get table of pictures along with relevant data
            //place each image in the list
            foreach (DataRow row in images.Rows)
            {
                Image image;
                if (row["DesignImage"] != DBNull.Value)
                {
                    image = ByteArraytoImage((byte[])row["DesignImage"]);
                }
                else
                {
                    image = null;
                }
                string productname = row["ProductName"].ToString();
                decimal price =Convert.ToDecimal(row["Price"]);
                int productid = (int)row["ProductID"];
                products.Add(new ImageInfo { productImage = image, name = productname, price = price, productid= productid });
            }
            double ProductsPerRow = Math.Floor((double)ProductsLayout.Width % (250 + 20));
            if (ProductsPerRow == 0) ProductsPerRow = 1;
            int count = 0;
            foreach(ImageInfo imageInfo in products)
            {
                //create mini panel to hold picture, name and price
                Panel product = new Panel();
                product.Size = new Size(200, 300);
                product.Margin=new Padding(horizontalspace);
                //picturebox for product image
                PictureBox prodImage=new PictureBox();
                prodImage.SizeMode = PictureBoxSizeMode.Zoom;
                prodImage.Image = imageInfo.productImage;
                prodImage.Size = new Size(200, 200);
                prodImage.Location= new Point(0,0);

                //make images clickable to go to details form
                prodImage.Click += (sender, e) =>
                {
                    ProductDetails detailsForm = new ProductDetails(imageInfo, MyCart,UsernameLabel.Text);
                    detailsForm.Show();
                };

                //product name label
                Label productname = new Label();
                productname.ForeColor= Color.Black;
                productname.Text = imageInfo.name;
                productname.AutoSize = true;
                productname.Location = new Point((product.Width-(productname.Width/2))/2, prodImage.Height + 5);
                //price label
                Label price = new Label();
                price.ForeColor= Color.Black;
                price.Text = imageInfo.price.ToString("C");
                price.AutoSize = true;
                price.Location = new Point((product.Width - (price.Width/2)) / 2, prodImage.Height + 30);
                //add to mini panel
                product.Controls.Add(prodImage);
                product.Controls.Add(productname);
                product.Controls.Add(price);

                //place mini panel into main one
                ProductsLayout.Controls.Add(product);
                //if we put enough products in one row, wrap and add spacing between rows
                if (++count == ProductsPerRow)
                {
                    ProductsLayout.Controls.Add(new Control() { Height = verticalspace });
                }
            }
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            // Clear default view 
            ProductsLayout.Controls.Clear();

            // Add new panel
            FlowLayoutPanel flowLayoutPanelOrders = new FlowLayoutPanel
            {
                Size = new Size(420, 387),    //properties same as Products Layout
                Location = new Point(122, 52),   
                Margin = new Padding(2)
            };
            this.Controls.Add(flowLayoutPanelOrders);
            flowLayoutPanelOrders.BringToFront();

            //Add button to view history
            Button buttonHistory = new Button
            {
                Text = "View Previous Orders",
                Location = new Point(150,70)
            };
            buttonHistory.AutoSize = true;
            flowLayoutPanelOrders.Controls.Add(buttonHistory);

            //Add DataGridView
            DataGridView dataGridViewHistory = new DataGridView
            {
                Size = new Size(400, 300),  
                Location = new Point(10, 80) 
            };
            dataGridViewHistory.BringToFront();

            //Add Data Grid View
            DataGridView dataGridViewOut = new DataGridView
            {
                Size = new Size(400, 300),
                Location = new Point(10, 80)
            }; //declare before to be able to hide (cannot use before decleration)
            dataGridViewOut.BringToFront();

            //button functionality
            buttonHistory.Click += (s, args) =>
            {
                DataTable dt = controllerObj.GetOrderHistory(UsernameLabel.Text);
                dataGridViewHistory.DataSource = dt;
                dataGridViewHistory.Refresh();
                dataGridViewHistory.Visible = true;
                flowLayoutPanelOrders.Controls.Add(dataGridViewHistory);
                dataGridViewOut.Visible = false;
            };

            //Add Button to view 'out for delivery'
            Button buttonOutForDel = new Button
            {
                Text = "View Orders that are Out for Delivery",
                Location = new Point(200, 70)
            };
            buttonOutForDel.AutoSize = true;
            flowLayoutPanelOrders.Controls.Add(buttonOutForDel);


            //Button functionality
            buttonOutForDel.Click += (s, args) =>
            {
                DataTable dt = controllerObj.GetPendingOrders(UsernameLabel.Text);
                dataGridViewOut.DataSource = dt;
                dataGridViewOut.Refresh();
                dataGridViewOut.Visible = true;
                flowLayoutPanelOrders.Controls.Add(dataGridViewOut);
                dataGridViewHistory.Visible = false;
            };

            //Add Button to view Cart
            Button buttonCart = new Button
            {
                Text = "View Cart",
                Location = new Point(300,70)
            };
            buttonCart.AutoSize = true;
            flowLayoutPanelOrders.Controls.Add(buttonCart);

            //Button functionality
            buttonCart.Click += (s, args) =>
            { 
                MyCart.Show();
            };
        }

        private void UserHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            //return products to db if user clicked out of form
            if (RestockStatus.status == -1)
            {
                foreach (CartItem product in MyCart.items)
                {
                    string name = product.Name;
                    int quantity = product.Quantity;
                    controllerObj.ReturnProduct(name, quantity);
                }
            }
            //logout
            int result = controllerObj.LoggedOut(UsernameLabel.Text);

        }
    }
    //class to hold imageinfo retrieved from db
    public class ImageInfo //public so that it can be used in ProductDetailsForm
    {
        public Image productImage { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int productid { get; set; }
    }

    public static class  RestockStatus
    {
        public static int status = -1;
    }
}
