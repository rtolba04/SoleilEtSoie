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
    public partial class manage_prod : Form
    {
        Controller controllerObj;
        public manage_prod()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.getprods_outofstock();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ProductName";
            comboBox1.ValueMember = "ProductID";
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void restock_prod_button_Click(object sender, EventArgs e)
        {
            int res = controllerObj.restock_prod((int)comboBox1.SelectedValue);
            if (res!=0)
            {
                MessageBox.Show("Product restocked");
            }
            else
                MessageBox.Show("Couldnt restock product");

        }

        private void view_prods_button_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.getprods();
            dataGridView1.DataSource = dt;
        }
    }
}
