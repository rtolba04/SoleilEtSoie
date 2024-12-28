using Soleil_et_Soie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Soleil_et_Soie
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public bool GetLogin(string username, string password, ref string type)
        {
            string typequery = "SELECT UserType FROM Users WHERE UserName ='" + username + "';";
            type = dbMan.ExecuteScalar(typequery).ToString();
            string query = "SELECT COUNT(UserName) FROM Users WHERE UserName ='" + username + "' AND Password ='" + password + "';";
            int result = (int)dbMan.ExecuteScalar(query);
            return result == 1;
        }

        public int InsertNewUser(string un, string pw, int pn, string e, string g, string dc)
        {
            string query;
            if (g == "NULL")
            {
                query = "INSERT INTO Users (UserName, Password, PhoneNumber, Email ,DateCreated, UserType, Status )VALUES ('" + un + "','" + pw + "'," + pn + "'," + e + "'" + dc + "' , 'user' , 'active' );";
            }
            else
            {
                query = "INSERT INTO Users (UserName, Password, PhoneNumber, Email,DateCreated, UserType, Status, Gender )VALUES ('" + un + "','" + pw + "'," + pn + ",'" + e + "','" + dc + "', 'user', 'active', '" + g + "');";
            }
            return dbMan.ExecuteNonQuery(query);
        }

        public int createuser(string un, string pw, int pn, string e, string g, string ut, string dc)
        {
            string query;
            if (g != "NULL")
            {
                query = $"insert into Users(UserName,Password,PhoneNumber,Email,DateCreated,UserType,Status,Gender) values('{un}','{pw}',{pn},'{e}','{dc}','{ut}','active','{g}');";
            }
            else
            {
                query = $"insert into Users(UserName,Password,PhoneNumber,Email,DateCreated,UserType,Status) values('{un}','{pw}',{pn},'{e}','{dc}','{ut}','active');";
            }
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getusers()
        {
            string query = $"select * from Users;";
            return dbMan.ExecuteReader(query);
        }

        public int delete_user(int id)
        {
            string query = $"delete from users where UserID={id};";
            return dbMan.ExecuteNonQuery(query);

        }

        public DataTable getdesign(int des_id)
        {
            string query = $"select DesignName,SubmissionDate,CategoryName,CollectionName,UserName as Designer,MaterialName,Material_Quantity from Designs,Category,Collection,Users,Materials where Designs.DesignID={des_id} AND Category.CategoryID=Designs.DesignCategory_ID and Designs.Collection_ID=Collection.CollectionID and Designs.Designer_ID=Users.UserID and designs.Material_ID=materials.MaterialID";
            return dbMan.ExecuteReader(query);
        }
        public DataRow get_des_by_id(int id)
        {
            string query = $"select * from Designs where DesignID={id};";
            DataTable dt = dbMan.ExecuteReader(query);
            return dt.Rows[0]; //ret first (and only) row
        }

        public DataRow get_mat_by_id(int id)
        {
            string query = $"select * from Materials where MaterialID={id};";
            DataTable dt = dbMan.ExecuteReader(query);
            return dt.Rows[0]; //ret first (and only) row
        }


        public int insert_order_get_id(int req_material_quantity, string orderdate, string deliverydate, int unitcost)
        {
            string query = $@"insert into Orders(UserType,OrderDate,Status,TotalAmount,DeliveryAddress,DeliveryDate) values('vendor','{orderdate}','shipped',({req_material_quantity}*3+200)*{unitcost},'Soleil et Soie','{deliverydate}'); SELECT SCOPE_IDENTITY();";
            object ID = dbMan.ExecuteScalar(query); //will return akher orderid generated (scopeidentity)
            return ID != null ? Convert.ToInt32(ID) : -1;

        }

        public int getvendorid(int mat_id)
        {
            string query = $"select Vendor_ID from Materials where MaterialID ={mat_id};";
            object result = dbMan.ExecuteScalar(query);

            return result != null ? Convert.ToInt32(result) : -1;
        }

        //insert order details (of material)
        public int insert_into_ovm(int order_id, int v_id, int mat_id, int quantity)
        {
            string query = $"insert into Order_Vendor_Material(Order_ID,Vendor_ID,Material_ID,Quantity) values ({order_id},{v_id},{mat_id},{quantity});";
            return dbMan.ExecuteNonQuery(query);
        }

        public int update_mat_quantity(int mat_id, int new_quan)
        {
            string query = $"Update materials set StockQuantity={new_quan} where MaterialID={mat_id};";
            return dbMan.ExecuteNonQuery(query);
        }

        public int update_des_status(string decision, int des_id)
        {
            string query = $"Update Designs set ApprovalStatus='{decision}' where DesignID={des_id};";
            return dbMan.ExecuteNonQuery(query);
        }

        //fucntion to turn bytearray from db to image
        public Image ByteArraytoImage(byte[] imagebytes)
        {
            using (MemoryStream ms = new MemoryStream(imagebytes))
            {
                return Image.FromStream(ms);
            }
        }
        

        //FOR TESTING
        public byte[] ConvertImageToByteArray(string imagePath)
        {
            try
            {
                // Load the image from the file path
                using (Image image = Image.FromFile(imagePath))
                {
                    // Create a memory stream to hold the image bytes
                    using (MemoryStream ms = new MemoryStream())
                    {
                        // Save the image into the memory stream in PNG format
                        image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                        // Return the byte array
                        return ms.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null; // Return null if there's an error
            }
        }

        //TESTING FUNC HA DELETE LATER
        public int addpic(int des_id, byte[] img_bytes)
        {
            // Convert the byte array to a hexadecimal string
            string hexString = BitConverter.ToString(img_bytes).Replace("-", ""); // Remove dashes

            // Build the query, embedding the hex string with the `0x` prefix
            string query = $"UPDATE Designs SET DesignImage = 0x{hexString} WHERE DesignID = {des_id}";

            // Execute the query
            return dbMan.ExecuteNonQuery(query);
        }

        //return byte array for certain design
        public byte[] GetDesignImage(int des_id)
        {
            string query = $"SELECT DesignImage FROM Designs WHERE DesignID = {des_id}";

            // Use ExecuteScalar to fetch the single value
            object result = dbMan.ExecuteScalar(query);

            // Check if the result is not null in the database(dbnull.value) and return it as byte[]
            return result != DBNull.Value ? (byte[])result : null;
        }

        public DataTable get_pending()
        {
            string query = $"select * from Designs where ApprovalStatus='pending'";
            return dbMan.ExecuteReader(query);
        }

        public int insert_product(string des_name,string date_added,int price,int col_id,int cat_id,int des_id)
        {
            string query = $@"insert into Products(ProductName,DateAdded,StockQuantity,Price,Description,Status,Collection_ID,Category_ID,Design_ID) values ('{des_name}','{date_added}',3,{price},'DESCRIPTION','available',{col_id},{cat_id},{des_id});  SELECT SCOPE_IDENTITY();";
            object PID = dbMan.ExecuteScalar(query); //will return akher orderid generated (scopeidentity)
            return PID != null ? Convert.ToInt32(PID) : -1;
        }

        public int insert_prod_mat(int prod_id,int mat_id,int q)
        {
            string query = $"insert into ProductMaterial(Product_ID,Material_ID,QuantityRequired) values ({prod_id},{mat_id},{q});";
            return dbMan.ExecuteNonQuery(query);
        }

        public int add_categ(string name,string desc)
        {
            string query = $"insert into Category(CategoryName,Description) values ('{name}','{desc}');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int reject_des(int des_id)
        {
            string query = $"update Designs set ApprovalStatus='Rejected' where DesignID={des_id};";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getprods()
        {
            string query = $"select * from Products;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getprods_outofstock()
        {
            string query = $"select * from Products where StockQuantity=0;";
            return dbMan.ExecuteReader(query);
        }

        public int restock_prod(int prod_id)
        {
            string query = $"update Products set StockQuantity=10 where ProductID={prod_id};";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable view_all_feed()
        {
            string query = $"select FeedbackID,Rating,FeedbackDate,Comment,UserName,ProductName from Feedback,Users,Products where Feedback.User_FB=Users.UserID and Feedback.Product_FB=Products.ProductID;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable view_prod_feed(int prod_id)
        {
            string query = $"select FeedbackID,Rating,FeedbackDate,Comment,UserName from Feedback,Users where Feedback.User_FB=Users.UserID and Feedback.Product_FB={prod_id};";
            return dbMan.ExecuteReader(query);
        }
        public int del_feed(int feed_id)
        {
            string query = $"delete from Feedback where FeedBackID={feed_id};";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deact_user(int uid)
        {
            string query = $"update Users set Status='inactive' where UserID={uid};";
            return dbMan.ExecuteNonQuery(query);

        }

        //finds min quantity
        public int get_min_prod_sold()
        {
            string query = $"SELECT MIN(TotalQuantity) AS MinTotalQuantity FROM ( SELECT Product_ID, SUM(Quantity) AS TotalQuantity FROM ProductOrders GROUP BY Product_ID) AS ProductTotals;";
            return (int)dbMan.ExecuteScalar(query);

        }

        //get min prod sold name & quantity
        public DataTable get_min_prod_sold_name(int min_quan)
        {
            string query = $"SELECT Products.ProductName,ProductTotals.TotalQuantity FROM (SELECT Product_ID, SUM(Quantity) AS TotalQuantity FROM ProductOrders GROUP BY Product_ID) AS ProductTotals, Products WHERE ProductTotals.Product_ID = Products.ProductID AND TotalQuantity = {min_quan};";
            return dbMan.ExecuteReader(query);
        }

        //finds max quantity
        public int get_max_prod_sold()
        {
            string query = $"SELECT MAX(TotalQuantity) AS MaxTotalQuantity FROM ( SELECT Product_ID, SUM(Quantity) AS TotalQuantity FROM ProductOrders GROUP BY Product_ID) AS ProductTotals;";
            return (int)dbMan.ExecuteScalar(query);
        }

        //get max prod sold name
        public DataTable get_max_prod_sold_name(int max_quan)
        {
            string query = $"SELECT Products.ProductName,ProductTotals.TotalQuantity FROM (SELECT Product_ID, SUM(Quantity) AS TotalQuantity FROM ProductOrders GROUP BY Product_ID) AS ProductTotals, Products WHERE ProductTotals.Product_ID = Products.ProductID AND TotalQuantity ={max_quan};";
            return dbMan.ExecuteReader(query);
        }

        public int get_total_prods_sold()
        {
            string query = $"select sum(Quantity) from ProductOrders;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public float get_avg_price()
        {
            string query = $"select avg(Price) from Products;";
            object res= dbMan.ExecuteScalar(query);
            return Convert.ToSingle(res); //convert to float
        }

        public DataTable view_sale_quants()
        {
            string query = $"SELECT ProductName,SUM(Quantity) AS TotalQuantity FROM ProductOrders,Products where Products.ProductID=ProductOrders.Product_ID GROUP BY Product_ID,ProductName ORDER BY TotalQuantity DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable view_prod_revenues()
        {
            string query = $"select ProductName,sum(ProductOrders.Quantity*Price) as total_revenue from Products,ProductOrders where ProductOrders.Product_ID=Products.ProductID group by ProductName order by total_revenue desc;";
            return dbMan.ExecuteReader(query);
        }

        public float get_money_spent()
        {
            string query = $"select sum(TotalAmount) from Orders where UserType='vendor';";
            object res = dbMan.ExecuteScalar(query);
            return Convert.ToSingle(res); //convert to float
        }

        public float get_money_made()
        {
            string query = $"select sum(TotalAmount) from Orders where UserType!='vendor';";
            object res = dbMan.ExecuteScalar(query);
            return Convert.ToSingle(res); //convert to float
        }

        public DataRow get_user_by_un(string un)
        {
            string query = $"select * from Users where UserName='{un}';";
            DataTable dt = dbMan.ExecuteReader(query);
            return dt.Rows[0]; //ret first (and only) row
        }

        public void update_address(string add,string un)
        {
            string query = $"update Users set Address='{add}' where UserName='{un}';";
            dbMan.ExecuteNonQuery(query);
        }

        public int updateuser(string un,string pw, int pn, string e, string g, string ut, string dc)
        {
            string query;
            if (g != "NULL")
            {
                query = $"UPDATE Users SET Password = '{pw}',PhoneNumber = '{pn}',Email = '{e}',DateCreated = '{dc}',UserType = '{ut}',Status = 'active',Gender = '{g}' WHERE UserName = '{un}';";
            }
            else
            {
                query = $"UPDATE Users SET Password = '{pw}',PhoneNumber = '{pn}',Email = '{e}',DateCreated = '{dc}',UserType = '{ut}',Status = 'active' WHERE UserName = '{un}';";
            }
            return dbMan.ExecuteNonQuery(query);
        }


    }
}
