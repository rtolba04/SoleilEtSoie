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
using System.Security.Cryptography;

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

        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string type="";
            string hashed = HashPassword(textBoxPass.Text);
            bool exists = controllerObj.GetLogin(textBoxUserName.Text, hashed,ref type);
            if (!exists)
            {
                labelError.Visible = true;
            }
            else
            {
                int result = controllerObj.LoggedIn(textBoxUserName.Text);
                if(result == 0)
                {
                    MessageBox.Show("Couldn't Log In! Please Contact Our Customer Support!");
                }
                else
                {
                    MessageBox.Show("Logged In Successfully!");
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
                string hashed = HashPassword(textBoxPass.Text);
                bool exists = controllerObj.GetLogin(textBoxUserName.Text, hashed, ref type);
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

        private void ShowPassPic_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPass.PasswordChar = '\0';
        }

        private void ShowPassPic_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPass.PasswordChar = '*';
        }
    }
    }

