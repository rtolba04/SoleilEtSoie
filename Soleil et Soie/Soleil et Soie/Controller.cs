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
using System.Security.Cryptography;
using System.IO;

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

        public bool GetLogin(string username, string password, ref string type) {
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
            string query = "SELECT Category FROM Category AND Designs WHERE Category(CategoryID)=Designs(DesignCategory_ID) AND Designs(DesignName)= '"+design+"' ;";
            return dbMan.ExecuteScalar(query).ToString();
        }
        public string autofilldescription(string design)
        {
            string query = "SELECT Description FROM Designs WHERE Designs(DesignName)= '" + design + "' ;";
            return dbMan.ExecuteScalar(query).ToString();
        }
        public string autofillmats(string design)
        {
            string query = "SELECT Material_Quantity FROM Designs WHERE Designs(DesignName)= '" + design + "' ;";
            return dbMan.ExecuteScalar(query).ToString();
        }
        public string autofilldesign(string design)
        {
            string query = "SELECT DesignImage FROM Designs WHERE Designs(DesignName)= '" + design + "' ;";
            return dbMan.ExecuteScalar(query).ToString();
        }
        //public byte[] GetDesignImage(string desname)
        //{
        //    string query = $"SELECT DesignImage FROM Designs WHERE DesignName = {desname}";

        //    // Use ExecuteScalar to fetch the single value
        //    object result = dbMan.ExecuteScalar(query);

        //    // Check if the result is not null in the database(dbnull.value) and return it as byte[]
        //   // return result != DBNull.Value ? (byte[])result : null;
        //}
        public Image ByteArraytoImage(byte[] imagebytes)
        {
            using (MemoryStream ms = new MemoryStream(imagebytes))
            {
                return Image.FromStream(ms);
            }
        }
        //public int getdesignID(string desname)
        //{
        //    string query = "SELECT DesignID FROM Designs(DesignName)= '" + desname + "' ;";

        //}

        public int LoggedIn(string username)
        {
            string query = "UPDATE Users SET status = 'logged in' WHERE UserName = '" + username + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int LoggedOut(string username)
        {
            string query = "UPDATE Users SET status = 'logged out' WHERE UserName = '" + username + "';";
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
            imgbytes = (byte[])dbMan.ExecuteScalar(query);
        }

        public int getcatid(string cat)
        {
            string query = "SELECT CategoryID FROM Category WHERE CategoryName='" + cat + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int getmaterialid(string cat)
        {
            string query = "SELECT CategoryID FROM Category WHERE CategoryName='" + cat + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int submitDesign(string name, string cat, int desid, string sdate)
        {
            string query = "INSERT INTO Designs (DesignName, ApprovalDate, ApprovalStatus, Designer_ID, SubmissionDate)  VALUES ('"+ name+"', '"+sdate+"', 'Pending', '"+desid+"', '"+sdate+"');";
            return (int)dbMan.ExecuteNonQuery(query);
        }
        public int submitDesignPic(string desname, byte[] imgbytes)
        {

            string hexString = BitConverter.ToString(imgbytes).Replace("-", "");
            string query = "UPDATE Designs SET DesignImage= 0x" + hexString + " WHERE DesignName='" + desname + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deleteunapproved()
        {
            string query = "DELETE FROM Designs WHERE ApprovalStatus='Rejected';";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable getallDesigns() {
            string query = "SELECT DesignID, DesignName, ApprovalStatus FROM Designs;";
            return dbMan.ExecuteReader(query);
        }
        public int createCollection(string name, string season, string sdate, string edate, string description)
        {
            string query = "INSERT INTO Collections (CollectionName, Season, StartDate, EndDate, Description)  VALUES ('" + name + "', '" + season + "', '"+sdate+"','" + edate + "', '" + description + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable selectCollection()
        {
            string query = "SELECT CollectionName FROM Collections;";
            return dbMan.ExecuteReader(query);
        }
        public int getCollid(string colname)
        {
            string query = "SELECT CollectionID FROM Collections WHERE CollectionName='"+colname+"';";
            return (int)dbMan.ExecuteScalar (query);
        }
        public int addDesign(string desname, int id)
        {
            string query = "UPDATE Designs SET Collection_ID='"+id+"' WHERE DesignName='"+desname+"'' ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public int removedesfromcol(string desname)
        {
            string query = "UPDATE Designs SET Collection_ID=null WHERE DesignName='" + desname + "'' ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable getsales()
        {
            string query = "SELECT Product_ID, ProductName, Quantity FROM Products AND ProductOrders WHERE Products(ProductID)=ProductOrders(Product_ID) GROUP BY ProductOrders(Product_ID) DESC";
            return dbMan.ExecuteReader(query);
        }
        public int updatedesign(string desname, int cat, string description, string material, int mats)
        { 
            string query = "UPDATE Designs SET DesignCategory='" + desname + "', DesignCategory_ID= '"+cat+"', Description='"+description+"', Mat
        }


















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

