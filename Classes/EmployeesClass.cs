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

        public DataTable dataTable = new DataTable();
        public DataSet dataSet = new DataSet();

        public int id { set; get; }
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

        public void SearchEmployees(string search)
        {
            string query = "SELECT * FROM employee_tb WHERE " +
                "employee_id LIKE '%" + search + "%' OR " +
                "firstname LIKE '%" + search + "%' OR " +
                "lastname LIKE '%" + search + "%' ";
            dataTable.Clear();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectDb);
            adapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];
        }

        public void AddEmployee()
        {
            string query = "INSERT INTO employee_tb (firstname, lastname, type) " +
                "VALUES (@firstname, @lastname, @type)";

            using (var command = new MySqlCommand())
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

        public void EditEmployee()
        {
            OpenConnection();
            string query = "UPDATE employee_tb SET firstname = @firstname, " +
                "lastname = @lastname, type = @type WHERE employee_id = @id";

            using (var command = new MySqlCommand())
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;

                command.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstname;
                command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
                command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                command.ExecuteNonQuery();
                CloseConnection();
            }

        }

        public void RemoveEmployee()
        {
            string query = "DELETE FROM employee_tb WHERE employee_id = @id";

            using (var command = new MySqlCommand())
            {
                OpenConnection();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                command.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}
