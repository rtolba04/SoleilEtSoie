using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Soleil_et_Soie
{
    public partial class Feedback : Form
    {
        Controller controllerObj;
//<<<<<<< admin3
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
//=======
        DataTable products;
        int UserID;
        string prodname;
        public Feedback(int userid)
        {
            InitializeComponent();
            controllerObj= new Controller();
            products = new DataTable();
            UserID = userid;
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            products = controllerObj.GetProductsFB();
            comboBoxProductFB.DataSource = products;
            comboBoxProductFB.DisplayMember = "ProductName";
            comboBoxProductFB.Refresh();
        }

        private void buttonFeedBack_Click(object sender, EventArgs e)
        {
            decimal rating = numericUpDownRating.Value;
            string message = textBoxFeedback.Text;
            DateTime dateD= DateTime.Now;
            string date= dateD.ToString("yyyy-MM-dd");
            int pid= controllerObj.GetProdID(prodname);
            int result=controllerObj.InsertFeedback(rating, message, pid,date,UserID);
            if (result > 0) MessageBox.Show("Your message has been sent! Thank you.");
            else MessageBox.Show("Failed to send feedback");
        }

        private void comboBoxProductFB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProductFB.SelectedValue != null)
            {
                prodname = comboBoxProductFB.SelectedValue.ToString();
            }
//>>>>>>> main

        }
    }
}
