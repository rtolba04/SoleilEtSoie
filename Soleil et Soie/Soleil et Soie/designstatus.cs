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
    public partial class designstatus : Form
    {
        Controller obj;
        public designstatus()
        {
            InitializeComponent();
            obj = new Controller();
            DataTable dt = new DataTable();
            dt= obj.getallDesigns();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void designstatus_Load(object sender, EventArgs e)
        {

        }
    }
}
