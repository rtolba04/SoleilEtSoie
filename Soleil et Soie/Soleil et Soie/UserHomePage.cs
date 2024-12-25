using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soleil_et_Soie
{
    public partial class UserHomePage : Form
    {
        Controller controllerObj;
        Form userprofile;
        public UserHomePage(string UserName)
        {
            InitializeComponent();
            controllerObj = new Controller();
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, UserProfile.Width, UserProfile.Height);
            UserProfile.Region = new Region(gp);
            UsernameLabel.Text = UserName;
            userprofile = new Profile();
        }

        private void CollectionsButton_Click(object sender, EventArgs e)
        {
            CollectionsLayOut.Visible = !CollectionsLayOut.Visible;
        }

        private void CategButton_Click(object sender, EventArgs e)
        {
            CategLayout.Visible = !CategLayout.Visible;
        }

        private void UserProfile_Click(object sender, EventArgs e)
        {
            userprofile.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            int result = controllerObj.LoggedOut(UsernameLabel.Text);
            this.Close();
        }
    }
}
