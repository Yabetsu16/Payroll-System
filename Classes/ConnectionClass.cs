using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Payroll.Classes
{
    class ConnectionClass
    {
        public MySqlConnection connectDb;
        
        public ConnectionClass()
        {
            string host = "localhost";
            string database = "payroll_system";
            string username = "root";
            string password = "";
            string port = "3306";

            string connectionString = "datasource = " + host + "; " +
                "database = " + database + "; port = " + port + "; " +
                "username = " + username + "; password = " + password + "; " +
                "sslMode = none;";

            connectDb = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            connectDb.Open();
        }

        public void CloseConnection()
        {
            connectDb.Close();
        }
    }
}
