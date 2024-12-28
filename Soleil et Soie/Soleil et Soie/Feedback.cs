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
    public partial class Feedback : Form
    {
        Controller controllerObj;
        public Feedback()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.getprods();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ProductName";
            comboBox1.ValueMember = "ProductID";
            DataTable d = controllerObj.view_all_feed();
            comboBox2.DataSource = d;
            comboBox2.DisplayMember = "FeedbackID";
            comboBox2.ValueMember = "FeedbackID";
        }

        private void view_all_feed_button_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.view_all_feed();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        //view product feedback button
        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.view_prod_feed((int)comboBox1.SelectedValue);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void delete_feed_button_Click(object sender, EventArgs e)
        {
            int res = controllerObj.del_feed((int)comboBox2.SelectedValue);
            if (res != 0)
                MessageBox.Show("Feedback deleted");
            else
                MessageBox.Show("couldnt delete feedback");

        }
    }
}
