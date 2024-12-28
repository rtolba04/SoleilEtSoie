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
using System.Security.Cryptography;

namespace Soleil_et_Soie
{
    public partial class SignIn : Form
    {
        Controller controllerObj;
        Form userhomepage;
        public SignIn()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        public static string HashPassword(string password) //hashes password for security
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            int num;
            long num2;
            string username;
            string password;
            long phonenumber;
            string email;
            string gender;
            //validation checks
            void ResetErrorLabels()
            {
                labelError1.Visible = false;
                labelError2.Visible = false;
                labelError3.Visible = false;
                labelError4.Visible = false;
                labelError5.Visible = false;
                labelError6.Visible = false;
                labelError7.Visible = false;
            }
            if (int.TryParse(textBoxUserName.Text, out num)) //not digits only
            {
                labelError2.Visible = false;
                labelError3.Visible = false;
                labelError4.Visible = false;
                labelError5.Visible = false;
                labelError6.Visible = false;
                labelError7.Visible = false;
                labelError1.Visible = true;
            }
            else if (textBoxUserName.Text == "") //not null
            {
                labelError1.Visible = false;
                labelError3.Visible = false;
                labelError4.Visible = false;
                labelError5.Visible = false;
                labelError6.Visible = false;
                labelError7.Visible = false;
                labelError2.Visible = true;
            }
            else if (textBoxPassword.Text == "") //not null
            {
                labelError1.Visible = false;
                labelError2.Visible = false;
                labelError4.Visible = false;
                labelError5.Visible = false;
                labelError6.Visible = false;
                labelError7.Visible = false;
                labelError3.Visible = true;
            }
            else if (!(long.TryParse(textBoxPhone.Text, out num2))) //digits only
            {
                labelError1.Visible = false;
                labelError2.Visible = false;
                labelError3.Visible = false;
                labelError4.Visible = false;
                labelError5.Visible = false;
                labelError7.Visible = false;
                labelError6.Visible = true;
            }
            else if (textBoxPhone.Text == "") //not null
            {
                labelError1.Visible = false;
                labelError2.Visible = false;
                labelError3.Visible = false;
                labelError5.Visible = false;
                labelError6.Visible = false;
                labelError7.Visible = false;
                labelError4.Visible = true;
            }
            else if (textBoxPhone.Text.Length != 11) //had 11 digits (valid phone no.)
            {
                labelError1.Visible = false;
                labelError2.Visible = false;
                labelError3.Visible = false;
                labelError4.Visible = false;
                labelError5.Visible = false;
                labelError6.Visible = false;
                labelError7.Visible = true;
            }
            else if (textBoxEmail.Text == "")//not null
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
                ResetErrorLabels();
                //sets user details for insert query
                username = textBoxUserName.Text;
                password = textBoxPassword.Text;
                string hashedpass=HashPassword(password);
                phonenumber = num2;
                email = textBoxEmail.Text;
                if (radioButtonf.Checked == true) { gender = "female"; } 
                else if(radioButtonm.Checked==true) { gender = "male"; }
                else { gender = "NULL"; };
                
                DateTime time = DateTime.Now;
                string datecreated = time.ToString("yyyy-MM-dd"); //sets date in correct format for insert query
                int result = controllerObj.InsertNewUser(username, hashedpass, phonenumber, email, gender , datecreated);
                
                if (result == 0)
                {
                    MessageBox.Show("Could Not Create User Account! Please Contact Our Customer Support");
                }
                else
                {
                    MessageBox.Show("Account Created Successfully! Welcome to Soliel et Soie!");
                    userhomepage = new UserHomePage(username); //opens user home page when user is added to db
                    userhomepage.Show();
                };
            }
        }
    }
}
