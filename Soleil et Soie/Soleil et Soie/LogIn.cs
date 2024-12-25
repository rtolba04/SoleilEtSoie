using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Soleil_et_Soie
{
    public partial class LogIn : Form
    {
        Controller controllerObj;
        Form SignIn = new SignIn();
        Form userhomepage;
        DataTable dt;
        public LogIn()
        {
            InitializeComponent();
            controllerObj = new Controller();
            dt=new DataTable();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string type="";
            bool exists = controllerObj.GetLogin(textBoxUserName.Text, textBoxPass.Text,ref type);
            if (!exists)
            {
                labelError.Visible = true;
            }
            else
            {
                if (type == "user")
                {
                    userhomepage = new UserHomePage(textBoxUserName.Text);
                    userhomepage.Show();
                }
                else if (type == "admin")
                {
                    //this is just for testing
                    MessageBox.Show("You are an admin");
                    adminFunctionalities f = new adminFunctionalities();
                    f.Show();
                }
            }
        }

        private void linkLabelsignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn.Show();
        }

        private void textBoxUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPass.Focus();
            }
        }

        private void textBoxPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string type = "";
                bool exists = controllerObj.GetLogin(textBoxUserName.Text, textBoxPass.Text,ref type);
                if (!exists)
                {
                    labelError.Visible = true;
                }
                else {
                    if (type == "user")
                    {
                        userhomepage = new UserHomePage(textBoxUserName.Text);
                        userhomepage.Show();
                    }
                    else if(type=="admin")
                    {
                        //this is just for testing
                        MessageBox.Show("You are an admin");
                    }
                }
            }
            }
        }
    }

