using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;

namespace Payroll.Classes
{
    class ReportingClass : ConnectionClass
    {
        public DataTable dataTable = new DataTable();
        public DataSet dataSet = new DataSet();

        public void AddEmployeeReport(int employee_id)
        {
            string query = "INSERT INTO report_tb (employee_id, name, type, job) VALUES " +
            "(@employee_id, " +
            "(SELECT CONCAT(lastname, ', ', firstname) AS name FROM employee_tb WHERE employee_id = @employee_id), " +
            "(SELECT type FROM employee_tb WHERE employee_id = @employee_id), " +
            "(SELECT job FROM employee_tb WHERE employee_id = @employee_id))";

            using (var command = new MySqlCommand())
            {
                OpenConnection();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;

                command.Parameters.Add("@employee_id", MySqlDbType.Int32).Value = employee_id;

                command.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void UpdateEmployeeReport(int employee_id)
        {
            string query = "UPDATE report_tb SET " +
                "name = (SELECT CONCAT(lastname, ', ', firstname) AS name FROM employee_tb WHERE employee_id = @employee_id), " +
                "type = (SELECT type FROM employee_tb WHERE employee_id = @employee_id), " +
                "job = (SELECT job FROM employee_tb WHERE employee_id = @employee_id) " +
                "WHERE employee_id = @employee_id";

            using (var command = new MySqlCommand())
            {
                OpenConnection();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;

                command.Parameters.Add("@employee_id", MySqlDbType.Int32).Value = employee_id;

                command.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void UpdateWorkReport(int employee_id)
        {
            string query = "UPDATE report_tb SET " +
               "gross_salary = (SELECT gross_salary FROM work_tb WHERE emp_id = @employee_id), " +
               "total_deductions = (SELECT SUM(ROUND(tax + sss + pagibig + philhealth + loans + deductions, 2)) " +
               "FROM work_tb WHERE emp_id = @employee_id), " +
               "tax = (SELECT tax FROM work_tb WHERE emp_id = @employee_id)," +
               "sss = (SELECT sss FROM work_tb WHERE emp_id = @employee_id)," +
               "pagibig = (SELECT pagibig FROM work_tb WHERE emp_id = @employee_id)," +
               "philhealth = (SELECT philhealth FROM work_tb WHERE emp_id = @employee_id)," +
               "loans = (SELECT loans FROM work_tb WHERE emp_id = @employee_id)," +
               "deductions = (SELECT deductions FROM work_tb WHERE emp_id = @employee_id)," +
               "remarks = (SELECT deduction_remarks FROM work_tb WHERE emp_id = @employee_id)," +
               "net_salary = (SELECT net_salary FROM work_tb WHERE emp_id = @employee_id) " +
               "WHERE employee_id = @employee_id";

            using (var command = new MySqlCommand())
            {
                OpenConnection();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;

                command.Parameters.Add("@employee_id", MySqlDbType.Int32).Value = employee_id;

                command.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void DeleteEmployeeReport(int employee_id)
        {
            string query = "DELETE FROM report_tb WHERE employee_id = @employee_id";

            using (var command = new MySqlCommand())
            {
                OpenConnection();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;
                command.Parameters.Add("@employee_id", MySqlDbType.Int32).Value = employee_id;

                command.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void ShowReport()
        {
            string query = "SELECT * FROM report_tb";
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataAdapter da = new MySqlDataAdapter();

                cmd.Connection = connectDb;
                cmd.CommandText = query;
                da.SelectCommand = cmd;
                da.Fill(dataTable);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
