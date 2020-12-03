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

        public int userId { set; get; }

        public string firstname { set; get; }

        public string lastname { set; get; }

        public string type { set; get; }

        public string job { set; get; }

        public string username { set; get; }

        public string currentUsername { set; get; }

        public string currentPassword { set; get; }

        public string password { set; get; }

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
                "lastname LIKE '%" + search + "%' OR " +
                "type LIKE '%" + search + "%' OR " +
                "job LIKE '%" + search + "%'";
            dataTable.Clear();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectDb);
            adapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];
        }

        public void AddEmployee()
        {
            Random rand = new Random();
            int randNum = rand.Next(1000, 9999);
            string query = "INSERT INTO employee_tb (firstname, lastname, username, password, type, job) " +
                "VALUES (@firstname, @lastname, @username, @password, @type, @job);";
            query += "INSERT INTO user_tb (username, password, type) " +
                "VALUES (@username, MD5(@password), 'EMPLOYEE')";

            using (var command = new MySqlCommand())
            {
                OpenConnection();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;

                command.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstname;
                command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = lastname + "_" + firstname;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = lastname + "_" + randNum;
                command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
                command.Parameters.Add("@job", MySqlDbType.VarChar).Value = job;

                command.ExecuteNonQuery();
                CloseConnection();
            }

            string query2 = "INSERT INTO work_tb (emp_id) VALUES ((SELECT employee_id FROM employee_tb " +
                "WHERE firstname = @firstname AND lastname = @lastname AND " +
                "username = @username AND password = @password AND type = @type AND job = @job))";

            using (var command = new MySqlCommand())
            {
                OpenConnection();
                command.CommandText = query2;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;

                command.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstname;
                command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = lastname + "_" + firstname;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = lastname + "_" + randNum;
                command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
                command.Parameters.Add("@job", MySqlDbType.VarChar).Value = job;

                command.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void EditEmployee()
        {
            OpenConnection();
            string query = "UPDATE employee_tb SET firstname = @firstname, " +
                "lastname = @lastname, username = @username, " +
                "password = @password, type = @type, job = @job WHERE employee_id = @id;";
            query += "UPDATE user_tb SET username = @username, " +
                "password = MD5(@password) WHERE username = @currentUsername AND password = MD5(@currentPassword)";

            using (var command = new MySqlCommand())
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;

                command.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstname;
                command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
                command.Parameters.Add("@currentUsername", MySqlDbType.VarChar).Value = currentUsername;
                command.Parameters.Add("@currentPassword", MySqlDbType.VarChar).Value = currentPassword;
                command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
                command.Parameters.Add("@job", MySqlDbType.VarChar).Value = job;
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
