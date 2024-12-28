using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soleil_et_Soie
{
    public partial class editdesign : Form
    {
        int userid;
        string username;
        Controller obj;
        int designid;
        public editdesign(int id, string name)
        {
            InitializeComponent();
            obj = new Controller();
            userid = id;
            username = name;
            label2.Text = "Edit King " + username + "!";
            DataTable dt = obj.selectDesign();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "DesignName";
            category.Text = obj.autofillcat(comboBox1.Text);
            description.Text = obj.autofilldescription(comboBox1.Text);
         //   picbox.Image = obj.ByteArraytoImage(obj.GetDesignImage(comboBox1.Text));
            mats.Text = obj.autofillmats(comboBox1.Text);
        }

        private void uploadnew_Click(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            designerhomepage home = new designerhomepage(username, userid);
            this.Close();
            home.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            category.Text = obj.autofillcat(comboBox1.Text);
            description.Text = obj.autofilldescription(comboBox1.Text);
            //  byte[] img = (byte[])reader[obj.autofilldesign(comboBox1.Text)];

        }

        private void remove_Click(object sender, EventArgs e)
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

        private void submitnew_Click(object sender, EventArgs e)
        {
            int x = 0;
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
                //    byte[] imgBytes = ConvertImageToBytes(picbox.Image);

                //   // int y = obj.submitDesign(designname.Text, mats.Text, designerid, subdate.Text);
                //    int z = obj.submitDesignPic(designname.Text, imgBytes);
                //    if ((y != 0) && (z != 0))
                //    {

                //        MessageBox.Show("Design Submitted!", "Well Done", MessageBoxButtons.OK);
                //        return;
                //    }
                //    else
                //    {
                //        MessageBox.Show("Design not Submitted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        return;
                //    }

                //}
            }
        }
    }
}
