using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Payroll.Classes
{
    class EmployeesClass : ConnectionClass
    {
        MySqlCommand command = new MySqlCommand();

        public DataTable dataTable = new DataTable();
        public DataSet dataSet = new DataSet();

        public string id { set; get; }
        public string firstname { set; get; }
        public string lastname { set; get; }
        public string type { set; get; }

        public void ShowEmployees()
        {
            string query = "SELECT * FROM employee_tb";
            dataTable.Clear();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectDb);
            adapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];
        }

        public void AddEmployee()
        {
            string query = "INSERT INTO employee_tb (firstname, lastname, type) " +
                "VALUES (@firstname, @lastname, @type)";

            using (command)
            {
                OpenConnection();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;

                command.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstname;
                command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
                command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;

                command.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}
