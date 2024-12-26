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
        public UserHomePage(string UserName)
        {
            InitializeComponent();
            controllerObj = new Controller();
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, UserProfile.Width, UserProfile.Height);
            UserProfile.Region = new Region(gp);
            UsernameLabel.Text = UserName;
            userprofile = new Profile(UserName);
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
    }
}
