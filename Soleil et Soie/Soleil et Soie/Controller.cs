using Soleil_et_Soie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

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
        public int GetUserID(string username, string password)
        {
            string query = "SELECT UserID FROM Users WHERE UserName ='" + username + "' AND Password ='" + password + "';";
            int id=(int)dbMan.ExecuteScalar(query);
            return id;

        }

        public int InsertNewUser(string un, string pw, int pn, string e, string g, string dc)
        {
            string query;
            if (g == "NULL")
            {
                query = "INSERT INTO Users (UserName, Password, PhoneNumber, Email ,DateCreated, UserType, Status )VALUES ('" + un + "','" + pw + "'," + pn + "'," + e + "'"+dc+"' , 'user' , 'active' );";
            }
            else {
                query = "INSERT INTO Users (UserName, Password, PhoneNumber, Email,DateCreated, UserType, Status, Gender )VALUES ('" + un + "','" + pw + "'," + pn + ",'" + e + "','"+dc+"', 'user', 'active', '"+g+"');";
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
        public string autofillcollection(string design)
        {

        }
        public string autofillsubdate(string design)
        {

        }
        public string autofillcollection(string design)
        {

        }
    }
}

