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
    public partial class detailed_rep : Form
    {
        Controller controllerObj;
        public detailed_rep()
        {
            InitializeComponent();
            controllerObj = new Controller();
            float money_out=controllerObj.get_money_spent();
            float money_in=controllerObj.get_money_made();
            float profit = money_in - money_out;
            textBox1.Text = $"{money_out} egp was spent on materials ";
            textBox2.Text = $"{money_in} egp was made from products sold ";
            textBox3.Text = $"{profit} egp profit was made ";
        }

        //view sale quantities
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.view_sale_quants();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        //view product revenues
        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.view_prod_revenues();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
