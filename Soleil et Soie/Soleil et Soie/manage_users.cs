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
            SignIn f = new SignIn();
            f.Show();
        }

        private void view_pending_button_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.getPending();
            view_pending_dg.DataSource = dt;
            view_pending_dg.Refresh();
        }
    }
}
