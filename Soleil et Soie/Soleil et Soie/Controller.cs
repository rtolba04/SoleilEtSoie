using Soleil_et_Soie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

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
            type = dbMan.ExecuteScalar(typequery).ToString();
            string query = "SELECT COUNT(UserName) FROM Users WHERE UserName ='" +username +"' AND Password ='" +password+"';";
            int result = (int)dbMan.ExecuteScalar(query);
            return result == 1;
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

        public int createuser(string un,string pw,int pn,string e,string g,string ut, string dc)
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



    }
}

