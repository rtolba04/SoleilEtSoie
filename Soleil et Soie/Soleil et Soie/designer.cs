//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.IO;


//namespace Soleil_et_Soie
//{
//    public partial class designer : Form
//    {
//        int designerID;
//        Controller controllerObj;
//        public designer(int desID, string username)
//        {
//            InitializeComponent();
//            subDate.Text = DateTime.Now.ToString();
//            designerID = desID;
//            label1.Text = "You go " + username;
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            string imagelocation = "";
//            try
//            {
//                OpenFileDialog dialog = new OpenFileDialog();
//                dialog.Filter = "jpg files (*.jpg)|*.jpg| PNG files (*.png)|*.png| All files (*.*)|*.*";
//                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
//                {
//                    imagelocation = dialog.FileName;
//                    picbox.ImageLocation = imagelocation;
//                    picbox.Image = Image.FromFile(imagelocation);  // Load the image from the file
//                    picbox.SizeMode = PictureBoxSizeMode.StretchImage;
//                }
//            }
//            catch (Exception)
//            {
//                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void button3_Click(object sender, EventArgs e)
//        {
//            picbox.Image = null;
//            picbox.ImageLocation = null;
//        }
//        public byte[] ImageToByteArray(Image imageIn)
//        {
//            MemoryStream ms = new MemoryStream();
//            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Or other desired format
//            return ms.ToArray();
//        }

//        private void submitDesign_Click(object sender, EventArgs e)
//        {
//            int x = 0;
//            if (designName.Text == null)
//            {
//                MessageBox.Show("Enter Design Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }
//            if (category.Text == null)
//            {
//                MessageBox.Show("Enter Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }
//            if (int.TryParse(category.Text, out x))
//            {
//                MessageBox.Show("Enter a Valid Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }
//            if (picbox.Image == null)
//            {
//                MessageBox.Show("Enter Design", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }




//            MessageBox.Show("Please select image again", "", MessageBoxButtons.OK);
//            OpenFileDialog dialog = new OpenFileDialog();
//            string imglocation = "";
//            dialog.Filter = "jpg files (*.jpg)|*.jpg| PNG files (*.png)|*.png| All files (*.*)|*.*";
//            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
//            {
//                imglocation = dialog.FileName;
//            }
//            byte[] imageBytes = File.ReadAllBytes(imglocation);
//            DateTime time = DateTime.Now;
//            string submissiondate = time.ToString("yyyy-MM-dd");
//            int submission = controllerObj.subDesign(designName.Text, submissiondate, imageBytes, designerID);
//            if (submission == 0) MessageBox.Show("Design Not Submitted", "Error", MessageBoxButtons.OK);
//            else
//                MessageBox.Show("Design Submitted Successfully", "Success", MessageBoxButtons.OK);
//        }

//        private void subDate_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void InitializeComponent()
//        {
//            this.SuspendLayout();
//            // 
//            // designer
//            // 
//            this.ClientSize = new System.Drawing.Size(731, 453);
//            this.Name = "designer";
//            this.Load += new System.EventHandler(this.designer_Load);
//            this.ResumeLayout(false);

//        }

//        private void designer_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}
