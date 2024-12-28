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

        }
    }
}
