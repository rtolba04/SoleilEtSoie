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
    public partial class managerial_report : Form
    {
        Controller controllerObj;
        public managerial_report()
        {
            InitializeComponent();
            controllerObj = new Controller();
            int total = controllerObj.get_total_prods_sold();
            textBox1.Text = $"You have sold {total} products.";
            float avg_p = controllerObj.get_avg_price();
            textBox2.Text= $"Average product price was {avg_p} egp.";

        }

        private void min_prod_button_Click(object sender, EventArgs e)
        {
            int min_prod=controllerObj.get_min_prod_sold();
            DataTable dt = controllerObj.get_min_prod_sold_name(min_prod);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void maxprod_button_Click(object sender, EventArgs e)
        {
            int max_prod = controllerObj.get_max_prod_sold();
            DataTable dt = controllerObj.get_min_prod_sold_name(max_prod);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
