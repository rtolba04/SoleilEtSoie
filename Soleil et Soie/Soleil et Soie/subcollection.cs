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
    public partial class subcollection : Form
    {
        Controller obj;
        public subcollection()
        {
            InitializeComponent();
            obj = new Controller();
            DataTable dt = obj.selectDesign();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "DesignName";
            DataTable dtable = obj.selectCollection();
            comboBox2.DataSource = dtable;
            comboBox2.DisplayMember = "CollectionName";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void subcollection_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int colid=obj.getCollid(comboBox2.Text);
            int test = obj.addDesign(comboBox2.Text, colid);
            if (test == 0)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else MessageBox.Show("Design Added", "Done", MessageBoxButtons.OK);



        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Collection Submitted", "Done", MessageBoxButtons.OK);
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int test = obj.removedesfromcol(comboBox1.Text);
            if (test == 0)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            MessageBox.Show("Design Removed!", "Done", MessageBoxButtons.OK);
            return;

        }
    }
}
