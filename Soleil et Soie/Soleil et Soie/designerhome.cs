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
    public partial class designerhome : Form
    {
        int desID;
        string desName;
        public designerhome(string designer, int id)
        {
            InitializeComponent();
            label2.Text= "Hello " + designer + ",";
            desName = designer;
            desID = id;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            designer des = new designer(desID,desName);
            des.Show();
        }
    }
}
