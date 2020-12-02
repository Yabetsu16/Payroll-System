using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace Payroll.Classes
{
    class UsersClass : ConnectionClass
    {
        MySqlCommand command = new MySqlCommand();
        public string username { set; get; }
        public string password { set; get; }

        public string type { set; get; }

        public int id { set; get; }

        public bool ValidateUser()
        {
            bool check = false;
            string query = "SELECT * FROM user_tb " +
                "WHERE username = @username AND password = MD5(@password)";

            MySqlDataReader reader;

            OpenConnection();

            using (command)
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;

                // Parameters
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    check = true;
                    username = reader.GetString("username");
                    id = reader.GetInt32("user_id");
                }

                CloseConnection();
            }
            return check;
        }
    }
}
