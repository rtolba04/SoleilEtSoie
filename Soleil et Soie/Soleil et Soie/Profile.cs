using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Soleil_et_Soie
{
    public partial class Profile : Form
    {
        Controller controllerObj;
        public Profile(string UserName)
        {
            InitializeComponent();
            controllerObj = new Controller();
            labelUserName.Text = UserName; //sets label to username taken from previous form (userhomepage)
        }

        public static string HashPassword(string password) //hashes password for security
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string username, password, address, email;
            long phoneno;
            int num;
            long num2;

            //retrieve previous values
            DataTable userinfo = controllerObj.RetrieveUserInfo(labelUserName.Text);
            DataRow row = userinfo.Rows[0];
            string prevusername = row["UserName"].ToString();
            int userid = (int)row["UserID"];
            string prevpassword = row["Password"].ToString();
            long prevphoneNumber = (long)row["PhoneNumber"];
            string prevaddress;
            if (row["Address"] == DBNull.Value)
            {
                prevaddress = "NULL";
            }
            else
            {
                prevaddress = row["Address"].ToString();
            }
            string prevemail = row["Email"].ToString();
            string date = row["DateCreated"].ToString();
            string usertype = "user";
            string status = "Logged In";
            string gender;
            if (row["Gender"] == DBNull.Value)
            {
                gender = "NULL";
            }
            else
            {
                gender = row["Gender"].ToString();
            }


            //if textbox is empty, sets attribute to previous, else validate and update
            //using same validations as before (similar to signin) except now when null -> prev
            if (textBoxUsername.Text == "")
            {
                username = prevusername;
            }
            else if (int.TryParse(textBoxUsername.Text, out num))
            {
                MessageBox.Show("UserName cannot be made up entirely of numbers");
                username = prevusername;
            }
            else
            {
                username = textBoxUsername.Text;
            }
            if (textBoxPass.Text == "")
            {
                password = prevpassword;
            }
            else
            {
                password = textBoxPass.Text;
            }
            if (textBoxPhone.Text=="")
            {
                phoneno = prevphoneNumber;
            }
            else if (!(long.TryParse(textBoxPhone.Text, out num2)) || textBoxPhone.Text.Length != 11)
            {
                MessageBox.Show("Phone Number Cannot contain Letters and Must be Exactly 11 digits");
                phoneno = prevphoneNumber; //sets as old if invalid phone no entered
            }
            else
            {
                phoneno = num2;
            }
            if (textBoxAddress.Text == "")
            {
                address = prevaddress;
            }
            else
            {
                address = textBoxAddress.Text;
            }
            if (textBoxEmail.Text == "")
            {
                email = prevemail;
            }
            else
            {
                email = textBoxEmail.Text;
            }
            string hashedpass=HashPassword(password);
            int result = controllerObj.UpdateUserDetails(username,userid,hashedpass,phoneno,address,email,date,usertype,status,gender);
            if(result == 0)
            {
                MessageBox.Show("Could Not Update Info, Please Contact Our Customer Support!");
            }
            else
            {
                MessageBox.Show("Info Updated Successfully!");
            }
        }

        private void buttonSaveCard_Click(object sender, EventArgs e)
        {

        }
    }
}
