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
    public partial class saletrends : Form
    {
        Controller obj;
        public saletrends()
        {
            InitializeComponent();
            obj = new Controller();
            DataTable dt = new DataTable();
            dt=obj.getsales();
            dataGridView1.DataSource = dt;
        }

        private void saletrends_Load(object sender, EventArgs e)
        {

        }
    }
}
