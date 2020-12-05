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

        public void ShowMonthlyReport()
        {
            string query = "SELECT report_id, employee_id, name, type, job, " +
                "gross_salary, total_deductions, tax, sss, " +
                "pagibig, philhealth, loans, deductions, net_salary " +
                "FROM report_tb";
            try
            {
                OpenConnection();
                using (MySqlCommand command = new MySqlCommand())
                {
                    dataTable.Clear();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    command.Connection = connectDb;
                    command.CommandText = query;
                    adapter.SelectCommand = command;
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ShowMonthlyReport: " + ex);
                throw;
            }
            finally
            {
                dataTable.Dispose();
                CloseConnection();
            }
        }

        public void ShowAnnualReport()
        {
            string query = "SELECT report_id, employee_id, name, type, job, " +
                "(ROUND(gross_salary * 12, 2)) AS gross_salary, " +
                "(ROUND(total_deductions * 12, 2)) AS total_deductions, (ROUND(tax * 12, 2)) AS tax, " +
                "(ROUND(sss * 12, 2)) AS sss, (ROUND(pagibig * 12, 2)) AS pagibig, " +
                "(ROUND(philhealth * 12, 2)) AS philhealth, (ROUND(loans * 12, 2)) AS loans, " +
                "(ROUND(deductions * 12, 2)) AS deductions, (ROUND(remarks * 12, 2)) AS remarks, " +
                "(ROUND(net_salary * 12, 2)) AS net_salary FROM report_tb";

            try
            {
                OpenConnection();
                using (MySqlCommand command = new MySqlCommand())
                {
                    dataTable.Clear();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    command.Connection = connectDb;
                    command.CommandText = query;
                    adapter.SelectCommand = command;
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ShowAnnuallyReport: " + ex);
            }
            finally
            {
                dataTable.Dispose();
                CloseConnection();
            }
        }

        public void ShowPaySlip(int employee_id)
        {
            string query = "SELECT employee_tb.employee_id AS employee_id, " +
                "CONCAT(employee_tb.firstname, ', ', employee_tb.lastname) AS name, " +
                "work_tb.gross_salary, work_tb.net_salary, " +
                "work_tb.day, work_tb.cutof_period, work_tb.payslip, " +
                "work_tb.tax, work_tb.sss, work_tb.pagibig, " +
                "work_tb.philhealth, work_tb.loans, " +
                "work_tb.deductions, work_tb.deduction_remarks " +
                "FROM employee_tb " +
                "INNER JOIN work_tb ON employee_tb.employee_id = work_tb.emp_id " +
                "WHERE work_tb.emp_id = " + employee_id + ";";

            dataTable.Clear();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectDb);
            adapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];
        }
    }
}
