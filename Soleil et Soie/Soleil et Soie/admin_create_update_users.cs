using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Soleil_et_Soie
{
    public partial class admin_create_update_users : Form
    {
        Controller controllerObj;
        public admin_create_update_users()
        {
            InitializeComponent();
            controllerObj = new Controller();
            error1.Visible = false;
            error2.Visible = false;
            error3.Visible = false;
            error4.Visible = false;
            error5.Visible = false;
            error6.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_button_Click(object sender, EventArgs e)
        {
            int n1, n2, phone;
            string username, password, email, gender, usertype;
            if (int.TryParse(username_textbox.Text, out n1)) //check username msh kolo arkam
            {
                error1.Visible = true;
                error2.Visible = false;
                error3.Visible = false;
                error4.Visible = false;
                error5.Visible = false;
                error6.Visible = false;

            }
            else if (username_textbox.Text == "")
            {
                error1.Visible = false;
                error2.Visible = true;
                error3.Visible = false;
                error4.Visible = false;
                error5.Visible = false;
                error6.Visible = false;
            }
            else if (pass_textbox.Text == "")
            {
                error1.Visible = false;
                error2.Visible = false;
                error3.Visible = true;
                error4.Visible = false;
                error5.Visible = false;
                error6.Visible = false;
            }
            else if (!(int.TryParse(phone_textbox.Text, out n2)))
            {
                error1.Visible = false;
                error2.Visible = false;
                error3.Visible = false;
                error4.Visible = true;
                error5.Visible = false;
                error6.Visible = false;
            }
            else if (phone_textbox.Text.Length != 11)
            {
                error1.Visible = false;
                error2.Visible = false;
                error3.Visible = false;
                error4.Visible = false;
                error5.Visible = true;
                error6.Visible = false;
            }
            else if (admin_radio.Checked == false && designer_radio.Checked == false)
            {
                error1.Visible = false;
                error2.Visible = false;
                error3.Visible = false;
                error4.Visible = false;
                error5.Visible = false;
                error6.Visible = true;
            }
            else
            {
                username = username_textbox.Text;
                password = pass_textbox.Text;
                phone = n2;
                email = email_textbox.Text;
                if (f_radio.Checked == true) { gender = "female"; }
                else if (m_radio.Checked == true) { gender = "male"; }
                else { gender = "NULL"; };

                DateTime time = DateTime.Now;
                string datecreated = time.ToString("yyyy-MM-dd");
                if (admin_radio.Checked == true)
                    usertype = "admin";
                else
                    usertype = "designer";

                int result = controllerObj.createuser(username, password, phone, email, gender, usertype, datecreated);
                if (result == 0)
                {
                    MessageBox.Show("The creation of a new user failed");
                }
                else
                {
                    MessageBox.Show("The user is created and inserted successfully!");
                };
            }



        }

        private void getuserscombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string un = getuserscombo.SelectedValue.ToString();
            DataRow user_row = controllerObj.get_user_by_un(un);
            string pw = user_row["Password"].ToString();
            string pn = user_row["PhoneNumber"].ToString();
            string email = user_row["Email"].ToString();
            string usertype = user_row["UserType"].ToString();
            string gender = user_row["Gender"].ToString();
            pass_textbox.Text = pw;
            phone_textbox.Text = pn;
            email_textbox.Text = email;
            if (gender == "f")
            {
                f_radio.Checked = true;
            }
            else
            {
                m_radio.Checked = true;
            }
            if (usertype == "admin")
            {
                admin_radio.Checked = true;
            }
            else if (usertype == "designer")
            {
                designer_radio.Checked = true;
            }
            else
            {
                admin_radio.Checked = false;
                designer_radio.Checked = false;
            }
        }

        //switched to update mode
        private void button1_Click(object sender, EventArgs e)
        {


            DataTable dt = controllerObj.getusers();
            getuserscombo.DataSource = dt;
            getuserscombo.DisplayMember = "UserName";
            getuserscombo.ValueMember = "UserName";
            if (getuserscombo.SelectedValue != null)
            {
                username_textbox.Text = getuserscombo.SelectedValue.ToString();
            }
            else
            {
                username_textbox.Text = string.Empty; // Set a default value or handle the null case
            }
            username_textbox.ReadOnly = true;
            label5.Visible = true;
            getuserscombo.Visible = true;
            address_label.Visible = true;
            address_textbox.Visible = true;
            f_radio.Enabled = false;
            m_radio.Enabled = false;

        }

        ////update button
        private void button2_Click(object sender, EventArgs e)
        {
            int n1, n2, phone;
            string username, password, email, gender, usertype;
            if (int.TryParse(username_textbox.Text, out n1)) //check username msh kolo arkam
            {
                error1.Visible = true;
                error2.Visible = false;
                error3.Visible = false;
                error4.Visible = false;
                error5.Visible = false;
                error6.Visible = false;

            }
            else if (username_textbox.Text == "")
            {
                error1.Visible = false;
                error2.Visible = true;
                error3.Visible = false;
                error4.Visible = false;
                error5.Visible = false;
                error6.Visible = false;
            }
            else if (pass_textbox.Text == "")
            {
                error1.Visible = false;
                error2.Visible = false;
                error3.Visible = true;
                error4.Visible = false;
                error5.Visible = false;
                error6.Visible = false;
            }
            else if (!(int.TryParse(phone_textbox.Text, out n2)))
            {
                error1.Visible = false;
                error2.Visible = false;
                error3.Visible = false;
                error4.Visible = true;
                error5.Visible = false;
                error6.Visible = false;
            }
            else if (phone_textbox.Text.Length != 11)
            {
                error1.Visible = false;
                error2.Visible = false;
                error3.Visible = false;
                error4.Visible = false;
                error5.Visible = true;
                error6.Visible = false;
            }
            else if (admin_radio.Checked == false && designer_radio.Checked == false)
            {
                error1.Visible = false;
                error2.Visible = false;
                error3.Visible = false;
                error4.Visible = false;
                error5.Visible = false;
                error6.Visible = true;
            }
            else
            {
               username = username_textbox.Text;
                password = pass_textbox.Text;
                phone = n2;
                email = email_textbox.Text;
                if (f_radio.Checked == true) { gender = "female"; }
                else if (m_radio.Checked == true) { gender = "male"; }
                else { gender = "NULL"; };

                DateTime time = DateTime.Now;
                string datecreated = time.ToString("yyyy-MM-dd");
                if (admin_radio.Checked == true)
                    usertype = "admin";
                else
                    usertype = "designer";


                int result = controllerObj.updateuser(username,password, phone, email, gender, usertype, datecreated);
                if (result == 0)
                {
                    MessageBox.Show("The update of a new user failed");
                }
                else
                {
                    MessageBox.Show("The user is updated and inserted successfully!");
                };

                if (address_textbox.Text != "")
                {
                    controllerObj.update_address(address_textbox.Text, username_textbox.Text);
                }

            }


        }



    }
}



