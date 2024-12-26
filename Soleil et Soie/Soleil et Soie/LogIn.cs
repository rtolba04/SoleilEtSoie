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
    public partial class LogIn : Form
    {
        Controller controllerObj;
        Form SignIn = new SignIn();
        public LogIn()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string type = "";
            bool exists = controllerObj.GetLogin(textBoxUserName.Text, textBoxPass.Text, ref type);
            if (!exists)
            {
                labelError.Visible = true;
            }
            else if (type == "designer")
            {
                int desID = controllerObj.GetUserID(textBoxUserName.Text, textBoxPass.Text);
                designerhome designerhome = new designerhome( textBoxUserName.Text, desID);
                designerhome.Show();
               // designer des = new designer();
                //des.Show();
                
            }
        }


        private void linkLabelsignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn.Show();
        }
    }
}
