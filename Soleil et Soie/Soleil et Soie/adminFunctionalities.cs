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

        
        private void button1_Click(object sender, EventArgs e)
        {
            manage_designs f = new manage_designs();
            f.Show();
        }

        private void manage_prod_button_Click(object sender, EventArgs e)
        {
            manage_prod f = new manage_prod();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Feedback f  = new Feedback();   
            f.Show();
        }

        //view managerial report button
        private void button3_Click(object sender, EventArgs e)
        {
            managerial_report f = new managerial_report();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            detailed_rep f = new detailed_rep();
            f.Show();
        }
    }
}
