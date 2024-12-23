using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Soleil_et_Soie
{
    public partial class SignIn : Form
    {
        Controller controllerObj;
        public SignIn()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            int num;
            int num2;
            string username;
            string password;
            int phonenumber;
            string email;
            string gender;
            if (int.TryParse(textBoxUserName.Text, out num))
            {
                labelError2.Visible = false;
                labelError3.Visible = false;
                labelError4.Visible = false;
                labelError5.Visible = false;
                labelError6.Visible = false;
                labelError7.Visible = false;
                labelError1.Visible = true;
            }
            else if (textBoxUserName.Text == "")
            {
                labelError1.Visible = false;
                labelError3.Visible = false;
                labelError4.Visible = false;
                labelError5.Visible = false;
                labelError6.Visible = false;
                labelError7.Visible = false;
                labelError2.Visible = true;
            }
            else if (textBoxPassword.Text == "")
            {
                labelError1.Visible = false;
                labelError2.Visible = false;
                labelError4.Visible = false;
                labelError5.Visible = false;
                labelError6.Visible = false;
                labelError7.Visible = false;
                labelError3.Visible = true;
            }
            else if (!(int.TryParse(textBoxPhone.Text, out num2)))
            {
                labelError1.Visible = false;
                labelError2.Visible = false;
                labelError3.Visible = false;
                labelError4.Visible = false;
                labelError5.Visible = false;
                labelError7.Visible = false;
                labelError6.Visible = true;
            }
            else if (textBoxPhone.Text == "")
            {
                labelError1.Visible = false;
                labelError2.Visible = false;
                labelError3.Visible = false;
                labelError5.Visible = false;
                labelError6.Visible = false;
                labelError7.Visible = false;
                labelError4.Visible = true;
            }
            else if (textBoxPhone.Text.Length != 11)
            {
                labelError1.Visible = false;
                labelError2.Visible = false;
                labelError3.Visible = false;
                labelError4.Visible = false;
                labelError5.Visible = false;
                labelError6.Visible = false;
                labelError7.Visible = true;
            }
            else if (textBoxEmail.Text == "")
            {
                labelError1.Visible = false;
                labelError2.Visible = false;
                labelError3.Visible = false;
                labelError4.Visible = false;
                labelError6.Visible = false;
                labelError5.Visible = true;
            }
            else
            {
                username = textBoxUserName.Text;
                password = textBoxPassword.Text;
                phonenumber = num2;
                email = textBoxEmail.Text;
                if (radioButtonf.Checked == true) { gender = "female"; } 
                else if(radioButtonm.Checked==true) { gender = "male"; }
                else { gender = "NULL"; };
                
                DateTime time = DateTime.Now;
                string datecreated = time.ToString("yyyy-MM-dd");
                int result = controllerObj.InsertNewUser(username, password, phonenumber, email, gender , datecreated);
                
                if (result == 0)
                {
                    MessageBox.Show("The insertion of a new user failed");
                }
                else
                {
                    MessageBox.Show("The user is inserted successfully!");
                };
            }
        }
    }
}
