using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soleil_et_Soie
{
    public partial class designerhomepage : Form
    {
        int desID;
        string desName;
        Controller obj;
        public designerhomepage(string designer, int id)
        {
            InitializeComponent();
            obj = new Controller();
            label2.Text = "Hello " + designer + ",";
            desName = designer;
            desID = id;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            createdesign des = new createdesign(desID, desName);
            this.Close();
            des.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editdesign des = new editdesign(desID, desName);
            this.Close();
            des.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int deletedrows = obj.deleteunapproved();
            if (deletedrows == 0) { MessageBox.Show("No Designs have been deleted", "", MessageBoxButtons.OK); }
            else MessageBox.Show(deletedrows + " have been deleted.", "", MessageBoxButtons.OK);
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            designstatus des = new designstatus();
            des.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            collectionHome des = new collectionHome();
            des.Show();
        }

        private void designerhomepage_Load(object sender, EventArgs e)
        {

        }
    }
}

