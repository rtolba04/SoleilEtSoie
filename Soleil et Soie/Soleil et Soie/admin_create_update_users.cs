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
            int n1, n2,phone;
            string username, password, email, gender, usertype;
            if (int.TryParse(username_textbox.Text,out n1)) //check username msh kolo arkam
            {
                error1.Visible = true;
                error2.Visible = false;
                error3.Visible = false;
                error4.Visible = false;
                error5.Visible = false;
                error6.Visible = false;

            }
            else if (username_textbox.Text=="")
            {
                error1.Visible = false;
                error2.Visible = true;
                error3.Visible = false;
                error4.Visible = false;
                error5.Visible = false;
                error6.Visible = false;
            }
            else if (pass_textbox.Text=="")
            {
                error1.Visible = false;
                error2.Visible = false;
                error3.Visible = true;
                error4.Visible = false;
                error5.Visible = false;
                error6.Visible = false;
            }
            else if (!(int.TryParse(phone_textbox.Text,out n2)))
            {
                error1.Visible = false;
                error2.Visible = false;
                error3.Visible = false;
                error4.Visible = true;
                error5.Visible = false;
                error6.Visible = false;
            }
            else if (phone_textbox.Text.Length!=11)
            {
                error1.Visible = false;
                error2.Visible = false;
                error3.Visible = false;
                error4.Visible = false;
                error5.Visible = true;
                error6.Visible = false;
            }
            else if (admin_radio.Checked==false && designer_radio.Checked==false)
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
                email=email_textbox.Text;
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

        
    }
}
