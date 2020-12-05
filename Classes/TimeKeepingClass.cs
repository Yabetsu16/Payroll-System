using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Payroll.Classes
{
    class TimeKeepingClass : ConnectionClass
    {
        WorkClass work = new WorkClass();
        public DataTable dataTable = new DataTable();
        public DataSet dataSet = new DataSet();

        public int employeeId { set; get; }

        public int timekeepingId { set; get; }

        public string timeInDateTime { set; get; }

        public string timeOutDateTime { set; get; }

        public DateTime currentDateTime = DateTime.Now;

        public void ShowTimeKeeping()
        {
            string query = "SELECT * FROM time_keeping_tb WHERE employee_id = " + employeeId + ";";

            dataTable.Clear();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connectDb);
            dataAdapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];
        }

        public void GetEmployeeId(string username, string password)
        {
            string query = "SELECT employee_id FROM employee_tb " +
                "WHERE username = @username AND password = @password";

            MySqlDataReader reader;

            using (var command = new MySqlCommand())
            {
                OpenConnection();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    employeeId = (int)reader[0];
                    
                }

                CloseConnection();
            }
        }

        public void GetTimeKeepingId(int employee_id)
        {
            string query = "SELECT time_keeping_id FROM time_keeping_tb WHERE employee_id = @employee_id";

            MySqlDataReader reader;

            using (var command = new MySqlCommand())
            {
                OpenConnection();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;
                command.Parameters.Add("@employee_id", MySqlDbType.VarChar).Value = employee_id;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    timekeepingId = (int)reader[0];

                }

                CloseConnection();
            }
        }

        public void GetTimeIn()
        {
            string query = "SELECT login_datetime FROM time_keeping_tb " +
                "WHERE time_keeping_id = @timekeepingId AND employee_id = @employeeId";

            MySqlDataReader reader;

            using (var command = new MySqlCommand())
            {
                OpenConnection();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;
                command.Parameters.Add("@employeeId", MySqlDbType.VarChar).Value = employeeId;
                command.Parameters.Add("@timekeepingId", MySqlDbType.VarChar).Value = timekeepingId;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    timeInDateTime = reader[0].ToString();
                }

                CloseConnection();
            }
        }

        public void GetTimeOut()
        {
            string query = "SELECT logout_datetime FROM time_keeping_tb " +
                "WHERE time_keeping_id = @timekeepingId AND employee_id = @employeeId";

            MySqlDataReader reader;

            using (var command = new MySqlCommand())
            {
                OpenConnection();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;
                command.Parameters.Add("@employeeId", MySqlDbType.VarChar).Value = employeeId;
                command.Parameters.Add("@timekeepingId", MySqlDbType.VarChar).Value = timekeepingId;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    timeOutDateTime = reader[0].ToString();
                }

                CloseConnection();
            }
        }

        public void TimeIn()
        {
            string query = "INSERT INTO time_keeping_tb (employee_id, login_datetime) " +
                "VALUES (@employee_id, @timein)";

            using (var command = new MySqlCommand())
            {
                OpenConnection();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;

                command.Parameters.Add("@employee_id", MySqlDbType.Int32).Value = employeeId;
                command.Parameters.Add("@timein", MySqlDbType.VarChar).Value = 
                    currentDateTime.ToString("MMM. dd, yyyy hh:mm tt");

                command.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void TimeOut()
        {
            int day;
            work.employeeId = employeeId;
            work.GetDay();
            day = work.day + 1;

            string query = "UPDATE time_keeping_tb SET logout_datetime = @timeout " +
                "WHERE time_keeping_id = @time_keeping_id AND employee_id = @employee_id; ";
            query += "UPDATE work_tb SET day = @day WHERE emp_id = @employee_id";

            using (var command = new MySqlCommand())
            {
                OpenConnection();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;

                command.Parameters.Add("@employee_id", MySqlDbType.Int32).Value = employeeId;
                command.Parameters.Add("@time_keeping_id", MySqlDbType.Int32).Value = timekeepingId;
                command.Parameters.Add("@timeout", MySqlDbType.VarChar).Value =
                    currentDateTime.ToString("MMM. dd, yyyy hh:mm tt");
                command.Parameters.Add("@day", MySqlDbType.Int32).Value = day;

                command.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void RefreshTimeKeeping(int employeeId)
        {
            string query = "DELETE FROM time_keeping_tb WHERE employee_id = @id";

            using (var command = new MySqlCommand())
            {
                OpenConnection();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = employeeId;

                command.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}
