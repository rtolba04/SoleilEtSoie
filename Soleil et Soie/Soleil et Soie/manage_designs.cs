using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Soleil_et_Soie
{
    public partial class manage_designs : Form
    {
        Controller controllerObj;
        public manage_designs()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.get_pending();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "DesignName";
            comboBox1.ValueMember = "DesignID";
        }

        private void manage_designs_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int des_id = Convert.ToInt32(comboBox1.SelectedValue);
            DataTable dt = controllerObj.getdesign(des_id);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            
            
            byte[] imageBytes=controllerObj.GetDesignImage(des_id);
            if (imageBytes!=null)
            {
                Image des_pic = controllerObj.ByteArraytoImage(imageBytes);
                pictureBox1.Image = des_pic;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Scale image to fit the PictureBox
            }
            else
                pictureBox1.Image = null;
           
        }

        //clicked accept
        private void button1_Click(object sender, EventArgs e)
        {
          
            int des_id = Convert.ToInt32(comboBox1.SelectedValue);
           
            DataRow des_row = controllerObj.get_des_by_id(des_id);
            int mat_id = Convert.ToInt32(des_row["Material_ID"]);
            int quantity_req = Convert.ToInt32(des_row["Material_Quantity"]); //req q per piece
            DataRow mat_row = controllerObj.get_mat_by_id(mat_id);
            int mat_quantity = Convert.ToInt32(mat_row["StockQuantity"]); //total material in stock
            int mat_unitcost = Convert.ToInt32(mat_row["UnitCost"]);

            DateTime today = DateTime.Now;
            if (mat_quantity < quantity_req * 3) //not enough to make 3 products
            {
                MessageBox.Show("not enough material!");
               
                string orderdate = today.ToString("yyyy-MM-dd");

                string nextDay = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");

                //make material reorder and ship 
                int order_id = controllerObj.insert_order_get_id(quantity_req, orderdate, nextDay, mat_unitcost);
                if (order_id < 0) { MessageBox.Show("couldnt insert order"); }
                else { MessageBox.Show("Material order placed!"); }

                //insert order vendor material details
                int vendorid = controllerObj.getvendorid(mat_id);
                int res = controllerObj.insert_into_ovm(order_id, vendorid, mat_id, quantity_req * 3 + 200);

                if (vendorid != -1 && res != 0)
                {
                    MessageBox.Show("OVM updated!");
                }
                else
                {
                    MessageBox.Show("couldnt update OVM");
                }


                //restock in materials table
                int restock_val = mat_quantity + quantity_req * 3 + 200;
                int mat_res = controllerObj.update_mat_quantity(mat_id, restock_val);
                if (mat_res != 0)
                {
                    MessageBox.Show("material restocked!");
                }
                else
                {
                    MessageBox.Show("couldnt restock material");
                }
            }
            ////now we have enough material
             MessageBox.Show("we now have enough material!");
            DataRow new_mat_row = controllerObj.get_mat_by_id(mat_id);
           
            int new_mat_quantity = Convert.ToInt32(new_mat_row["StockQuantity"]) - quantity_req * 3; //subtracted the req material 
            int mat_update = controllerObj.update_mat_quantity(mat_id, new_mat_quantity);
            if (mat_update != 0)
            {
                MessageBox.Show("material updated!");
            }
            else
            {
                MessageBox.Show("couldnt update material");
            }

            //update design status
            string stat = "approved";
            int stat_res = controllerObj.update_des_status(stat, des_id);
            if (stat_res != 0)
            {
                MessageBox.Show("status uupdated!");
            }
            else
            {
                MessageBox.Show("couldnt update status");
            }

            //add design to product table
            string des_name = des_row["DesignName"].ToString();
            string date_added = today.ToString("yyyy-MM-dd");
            int price = mat_unitcost * quantity_req;
            //string description = des_row["Design_Description"].ToString();
            int col_id = Convert.ToInt32(des_row["Collection_ID"]);
            int cat_id = Convert.ToInt32(des_row["DesignCategory_ID"]);
            //int designer_id = Convert.ToInt32(des_row["Designer_ID"]);



            int prod_id = controllerObj.insert_product(des_name, date_added, price, col_id, cat_id, des_id);
            if (prod_id != 0)
            {
                MessageBox.Show("product added!");
            }
            else
            {
                MessageBox.Show("couldnt add product");
            }
            //insert into product material table

            int n = controllerObj.insert_prod_mat(prod_id, mat_id, quantity_req);
            if (n != 0)
            {
                MessageBox.Show("PM inserted!");
            }
            else
            {
                MessageBox.Show("couldnt insert PM");
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void add_cat_button_Click(object sender, EventArgs e)
        {
            string name=add_cat_textbox.Text;
            string desc=desc_textbox.Text;
            if (add_cat_textbox.Text == "" && desc_textbox.Text == "")
            {
                MessageBox.Show("insert necessary fields to insert category");
            }
            else
            {
                int res = controllerObj.add_categ(name, desc);

                if (res != 0)
                {
                    MessageBox.Show("Category added!");
                }
                else
                {
                    MessageBox.Show("couldnt add category");
                }
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //reject button
        private void button2_Click(object sender, EventArgs e)
        {
            int rej = controllerObj.reject_des((int)comboBox1.SelectedValue);
            if (rej != 0)
            {
                MessageBox.Show("design rejected!");
            }
            else
            {
                MessageBox.Show("couldnt reject design");
            }
        }
    }
}
