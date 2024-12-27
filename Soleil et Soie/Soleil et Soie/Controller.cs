using Soleil_et_Soie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Collections;

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

        public bool GetLogin(string username, string password,ref string type) {
            string typequery = "SELECT UserType FROM Users WHERE UserName ='" +username +"';";
            string query = "SELECT COUNT(UserName) FROM Users WHERE UserName ='" +username +"' AND Password ='" +password+"';";
            int result = (int)dbMan.ExecuteScalar(query);
            if (result == 1)
            {
                type = dbMan.ExecuteScalar(typequery).ToString();
                return true;
            }
            else return false;
        }
        public int GetUserID(string username, string password)
        {
            string query = "SELECT UserID FROM Users WHERE UserName ='" + username + "' AND Password ='" + password + "';";
            int id=(int)dbMan.ExecuteScalar(query);
            return id;

        }

        public int InsertNewUser(string un, string pw, long pn, string e, string g, string dc)
        {
            string query;
            if (g == "NULL")
            {
                query = "INSERT INTO Users (UserName, Password, PhoneNumber, Email ,DateCreated, UserType, Status )VALUES ('" + un + "','" + pw + "'," + pn + " ,'" + e + "','" + dc + "' , 'user' , 'Logged In' );";

;
            }
            else {
                query = "INSERT INTO Users (UserName, Password, PhoneNumber, Email,DateCreated, UserType, Status, Gender )VALUES ('" + un + "','" + pw + "'," + pn + ",'" + e + "','"+dc+"', 'user', 'Logged In', '"+g+"');";
            }
            return dbMan.ExecuteNonQuery(query);
        }
        public int subDesign(string desname, string subdate, byte[] b, int desID)
        {
            string query = $"INSERT INTO Designs(DesignID, DesignName, ApprovalDate, SubmissionDate, DesignImage, ApprovalStatus, Designer_ID) VALUES ('1','" + desname + "','" + subdate + "','" + subdate + "','" + b + "','Pending', '" + desID + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable selectDesign()
        {
            string query = "SELECT DesignName FROM Designs;";
            return dbMan.ExecuteReader(query);
        }
        public string autofillcat(string design )
        {
            string query = "SELECT Category FROM Category AND Designs WHERE ;";
            return dbMan.ExecuteReader(query).ToString();
        }

        public int LoggedIn(string username)
        {
            string query = "UPDATE Users SET status = 'Logged In' WHERE UserName = '" + username + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int LoggedOut(string username)
        {
            string query = "UPDATE Users SET status = 'Logged Out' WHERE UserName = '" + username + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable RetrieveUserInfo(string username)
        {
            string query = "SELECT * FROM Users WHERE UserName = '" + username + "';";
            return dbMan.ExecuteReader(query);
        }
        public int UpdateUserDetails(string un, int id, string pw, long pn, string a, string e,string dc, string ut, string s, string g)
        {
            string query;
            if (a == "NULL" && g == "NULL")
            {
                query = "UPDATE Users SET UserName = '" + un + "',Password = '" + pw + "',PhoneNumber = " + pn + " ,Email = '" + e + "',DateCreated = '" + dc + "',UserType = '" + ut + "',Status = '" + s + "' WHERE UserID =" + id + ";";

            }
            else if (a == "NULL")
            {
                query = "UPDATE Users SET UserName = '" + un + "',Password = '" + pw + "',PhoneNumber = " + pn + ",Email = '" + e + "',DateCreated = '" + dc + "',UserType = '" + ut + "',Status = '" + s + "',Gender = '" + g + "' WHERE UserID =" + id + ";";
            }
            else if (g == "NULL")
            {
                query = "UPDATE Users SET UserName = '" + un + "',Password = '" + pw + "',PhoneNumber = " + pn + ",Address = '" + a + "',Email = '" + e + "',DateCreated = '" + dc + "',UserType = '" + ut + "',Status = '" + s + "' WHERE UserID =" + id + ";";
            }
            else
            {
                query = "UPDATE Users SET UserName = '" + un + "',Password = '" + pw + "',PhoneNumber = " + pn + ",Address = '" + a + "',Email = '" + e + "',DateCreated = '" + dc + "',UserType = '" + ut + "',Status = '" + s + "',Gender = '" + g + "' WHERE UserID =" + id + ";";
            }

            return dbMan.ExecuteNonQuery(query);
        }

        //takes byte array, converts it to hexstring, inserts it into db
        public int ChangeProfile(string username,byte[] imagebytes)
        {
            string hexString = BitConverter.ToString(imagebytes).Replace("-", "");
            string query = "UPDATE Users SET ProfilePicture= 0x"+hexString+ " WHERE UserName='"+username+"';";
            return dbMan.ExecuteNonQuery(query);

        }
        //retrieves bytearray from db
        public void ProfilePicture(string username,ref byte[] imgbytes) {
            string query = "SELECT ProfilePicture FROM Users WHERE UserName='" + username + "';";
            if (dbMan.ExecuteScalar(query) != DBNull.Value)
            {
                imgbytes = (byte[])dbMan.ExecuteScalar(query);
            }
            else imgbytes= null;
        }
        public DataTable GetProducts()
        {
            DataTable dt = new DataTable();
            string query = "SELECT P.ProductName, P.Price, D.DesignImage,P.ProductID FROM Designs AS D,Products AS P WHERE P.Design_ID=D.DesignID GROUP BY P.ProductID, P.ProductName, P.Price, D.DesignImage;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable RetrieveAllDesData(int id)
        {
            DataTable dt = new DataTable();
            string query = "SELECT StockQuantity, Description FROM Products WHERE ProductID =" +id+ ";";
            return dbMan.ExecuteReader(query) ;
        } 

        public DataTable GetOrderHistory(string un)
        {
            string query="SELECT P.ProductName, O.OrderDate, O.Status, O.TotalAmount, O.DeliveryDate FROM Products AS P, Orders AS O, ProductOrders AS PO, Users AS U WHERE PO.Product_ID = P.ProductID AND PO.Order_ID=O.OrderID AND O.User_ID=U.UserID AND U.UserName= '" +un+ "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetPendingOrders(string un)
        {
            string query = "SELECT P.ProductName, O.OrderDate, O.TotalAmount, O.DeliveryDate FROM Products AS P, Orders AS O, ProductOrders AS PO, Users AS U WHERE PO.Product_ID = P.ProductID AND PO.Order_ID=O.OrderID AND O.User_ID=U.UserID AND U.UserName= '" + un + "' AND O.Status= 'Out For Delivery' ;";
            return dbMan.ExecuteReader(query);
        }

        public int TempUpdateStock(int quantity, string prod)
        {
            string query = "UPDATE Products SET StockQuantity = " + quantity + " WHERE ProductName = '" + prod + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        //public int tempinsertdesign(byte[] tempdesign)
        //{
        //    string hexString = BitConverter.ToString(tempdesign).Replace("-", "");
        //    string query = "UPDATE Designs SET DesignImage= 0x" + hexString + " WHERE DesignName='test2';";
        //    return dbMan.ExecuteNonQuery(query);
        //}
        //public string autofillsubdate(string design)
        //{

        //}
        //public string autofillcollection(string design)
        //{

        //}
        //public string autofillcollection(string design)
        //{ }
    }
}

