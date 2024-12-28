using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
        int userid;
        public Profile(string UserName)
        {
            InitializeComponent();
            controllerObj = new Controller();
            labelUserName.Text = UserName; //sets label to username taken from previous form (userhomepage)
            DataTable userinfo = controllerObj.RetrieveUserInfo(labelUserName.Text);
            DataRow row = userinfo.Rows[0];
            userid = (int)row["UserID"];
        }
        //event to notify userhomepage that profile picture was updated
        public event Action<byte[]> ProfilePictureUpdated;

        //hashing password
        public static string HashPassword(string password) //hashes password for security
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        //fucntion to turn bytearray from db to image
        private Image ByteArraytoImage(byte[] imagebytes)
        {
            using (MemoryStream ms = new MemoryStream(imagebytes))
            {
                return Image.FromStream(ms);
            }
        }
        //function to turn image into bytearray to insert into db
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); 
                return ms.ToArray();
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
            userid = (int)row["UserID"];
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
            int year, month;
            long num,num2;
            if (textBoxCardName.Text == "" || textBoxCardNo.Text == "" || textBoxCVV.Text == "" || textBoxExpDateYear.Text == "" || textBoxExpDateMonth.Text == "")
            {
                MessageBox.Show("Card Info Fields Cannot be Empty!");
            }else if (!(textBoxCardName.Text.All(c => char.IsLetter(c))))
            {
                MessageBox.Show("Card holder name cannot contain numbers");
            }
            else if ((!(long.TryParse(textBoxCardNo.Text, out num))) || textBoxCardNo.Text.Length != 16)
            {
                MessageBox.Show("Card number cannot contain characters and should contain 16 digits");
            }
            else if ((!(long.TryParse(textBoxCVV.Text, out num2))) || textBoxCVV.Text.Length != 3)
            {
                MessageBox.Show("CVV cannot contain characters and consists of 3 digits");
            }
            else if (!(int.TryParse(textBoxExpDateYear.Text, out year)) || !(int.TryParse(textBoxExpDateMonth.Text, out month)) || year < 2024 || month < 1 || month > 12)
            {
                MessageBox.Show("Invalid expiry date");
            }
            else
            {
                int EndsIn = int.Parse(textBoxCardNo.Text.Substring(textBoxCardNo.Text.Length - 4));
                string hashedcvv= Hash(textBoxCVV.Text);
                string hashedcardno=Hash(textBoxCardNo.Text);
                if(controllerObj.SaveCardDetails(userid, textBoxCardName.Text, hashedcardno, hashedcvv, year, month, EndsIn))
                {
                    MessageBox.Show("Successfully Added Card");
                }
                else
                {
                    MessageBox.Show("Couldnot Add Card");
                }
            }
        }
        

        private void buttonChangePhoto_Click(object sender, EventArgs e)
        {
            //opens dialog box to pick picture from file
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp", // Filter for image files
                Title = "Select an Image"
            };

            //when user clicks okay in dialog box
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxProfile.Image = Image.FromFile(openFileDialog.FileName);
                    byte[] imagebytes = ImageToByteArray(pictureBoxProfile.Image); //turn image to bytearray
                    //int insert = controllerObj.tempinsertdesign(imagebytes);
                    int insert=controllerObj.ChangeProfile(labelUserName.Text, imagebytes); //call function with byte array
                    if (insert > 0)
                    {
                        //if inserted, fire event profilepictureupdated to change the profile picture in userhomepage without closing profile form 
                        ProfilePictureUpdated?.Invoke(imagebytes);
                        //MessageBox.Show("Profile picture changed");
                    }
                    else MessageBox.Show("Failed to change profile picture");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image");
                }
            }
        }

        //when first loading, retrieve profile picture from db, if it wasnt changed before then its null so it just wont change the current one
        private void Profile_Load(object sender, EventArgs e)
        {
            byte[] imagebytes = new byte[1024];
            controllerObj.ProfilePicture(labelUserName.Text, ref imagebytes);
            if (imagebytes != null)
                pictureBoxProfile.Image = ByteArraytoImage(imagebytes);
        }

        public static string Hash(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
