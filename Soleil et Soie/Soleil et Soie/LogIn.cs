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
            bool exists = controllerObj.GetLogin(textBoxUserName.Text, textBoxPass.Text);
            if (!exists) {
                labelError.Visible = true;
            }
        }

        private void linkLabelsignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn.Show();
        }
    }
}
