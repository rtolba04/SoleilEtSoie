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
    public partial class adminFunctionalities : Form
    {
        Controller controllerObj;
        public adminFunctionalities()
        {
            InitializeComponent();
            controllerObj= new Controller();
        }

        private void manage_users_button_Click(object sender, EventArgs e)
        {
            manage_users f = new manage_users();
            f.Show();
        }
    }
}
