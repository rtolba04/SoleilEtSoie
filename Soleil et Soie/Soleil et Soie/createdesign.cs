using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Soleil_et_Soie
{
    public partial class createdesign : Form
    {
        int designerid;
        DBManager dbMan;
        Controller obj;
        public createdesign(int desid, string username)
        {

            InitializeComponent();
            obj = new Controller();
            subdate.Text = DateTime.Now.ToString();
            designerid = desid;
            label2.Text = "You Go " + username;
        }
        private void upload_click(object sender, EventArgs e)
        {
            string imagelocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files (*.jpg)|*.jpg| png files (*.png)|*.png| all files (*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    picbox.ImageLocation = imagelocation;
                    picbox.Image = Image.FromFile(imagelocation);  // load the image from the file
                    picbox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void remove_click(object sender, EventArgs e)
        {
            picbox.Image = null;
            picbox.ImageLocation = null;
        }
        public byte[] ConvertImageToBytes(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Save the image to the memory stream in the desired format (e.g., PNG, JPEG)
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // You can change the format (e.g., PNG, BMP)
                return ms.ToArray(); // Convert the memory stream to a byte array
            }
        }

        

        private void remove_Click_1(object sender, EventArgs e)
        {
            picbox.Image = null;
            picbox.ImageLocation = null;
        }


        private void submit_Click_1(object sender, EventArgs e)
        {
            int x = 0;
    
            if (designname.Text == null)
            {
                MessageBox.Show("Enter Design Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(category.Text, out x))
            {
                MessageBox.Show("Enter a Valid Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (picbox.Image == null)
            {
                MessageBox.Show("Enter Design", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (description.Text == null)
            {
                MessageBox.Show("Enter Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                byte[] imgBytes = ConvertImageToBytes(picbox.Image);

                int y = obj.submitDesign(designname.Text, mats.Text, designerid, subdate.Text);
                int z = obj.submitDesignPic(designname.Text, imgBytes);
                if ((y != 0)&&(z!=0))
                {
                    
                    MessageBox.Show("Design Submitted!", "Well Done", MessageBoxButtons.OK); 
                    return;
                }
                else 
                {
                    MessageBox.Show("Design not Submitted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return;
                }

            }
        }
    }
}
