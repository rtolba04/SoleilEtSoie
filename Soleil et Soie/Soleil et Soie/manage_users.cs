using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soleil_et_Soie
{
    public partial class manage_users : Form
    {
        Controller controllerObj;
        public manage_users()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.getusers();
            getuserscombo.DataSource= dt;
            getuserscombo.DisplayMember = "Username";
            getuserscombo.ValueMember = "UserID";
            
        }

        private void create_user_button_Click(object sender, EventArgs e)
        {
            admin_create_update_users f = new admin_create_update_users();
            f.Show();
        }

        private void manage_users_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res=controllerObj.delete_user(Convert.ToInt32(getuserscombo.SelectedValue));
            if (res == 0) { MessageBox.Show("failed to delete user"); }
            else { MessageBox.Show("user deleted successfully"); }
            
        }

        private void viewall_button_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.getusers();
            dg.DataSource = dt;
            dg.Refresh();
        }

        //DELETE NOT DEACTIVATE
        private void deactivate_button_Click(object sender, EventArgs e)
        {
            int res = controllerObj.deact_user(Convert.ToInt32(getuserscombo.SelectedValue));
            if (res == 0) { MessageBox.Show("failed to deactivate user"); }
            else { MessageBox.Show("user deactivated successfully"); }
        }
    }
}
