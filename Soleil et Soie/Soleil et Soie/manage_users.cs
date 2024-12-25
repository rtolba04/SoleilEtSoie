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
    public partial class manage_users : Form
    {
        Controller controllerObj;
        public manage_users()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void create_user_button_Click(object sender, EventArgs e)
        {
            admin_create_update_users f = new admin_create_update_users();
            f.Show();
        }


    }
}
