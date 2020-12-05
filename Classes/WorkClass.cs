using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Payroll.Classes
{
    class WorkClass : ConnectionClass
    {
        public DataTable dataTable = new DataTable();
        public DataSet dataSet = new DataSet();

        public int workId { set; get; }

        public int employeeId { set; get; }

        public float grossSalary { set; get; }

        public float netSalary { set; get; }

        public float allowableAbsences { set; get; }

        public int day { set; get; }

        public string cutofPeriod { set; get; }

        public float paySlip { set; get; }

        public float tax { set; get; }

        public float sss { set; get; }

        public float pagibig { set; get; }

        public float philhealth { set; get; }

        public float loans { set; get; }

        public float deductions { set; get; }

        public string deductionRemarks { set; get; }

        public void ShowWork()
        {
            string query = "SELECT employee_tb.employee_id, " +
                "CONCAT(employee_tb.firstname, ', ', employee_tb.lastname) AS name, employee_tb.type, " +
                "work_tb.gross_salary, work_tb.net_salary, " +
                "work_tb.allowable_absences, work_tb.day, " +
                "work_tb.cutof_period, work_tb.payslip, " +
                "work_tb.tax, work_tb.sss, work_tb.pagibig, " +
                "work_tb.philhealth, work_tb.loans, " +
                "work_tb.deductions,  work_tb.deduction_remarks " +
                "FROM employee_tb " +
                "INNER JOIN work_tb ON employee_tb.employee_id = work_tb.emp_id;";

            dataTable.Clear();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectDb);
            adapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];
        }

        public void SearchWork(string search)
        {
            string query = "SELECT employee_tb.employee_id, employee_tb.firstname, " +
                "employee_tb.lastname, employee_tb.type, " +
                "work_tb.gross_salary, work_tb.net_salary, " +
                "work_tb.allowable_absences, work_tb.day, " +
                "work_tb.cutof_period, work_tb.payslip, " +
                "work_tb.tax, work_tb.sss, work_tb.pagibig, " +
                "work_tb.philhealth, work_tb.loans, " +
                "work_tb.deductions,  work_tb.deduction_remarks " +
                "FROM employee_tb " +
                "INNER JOIN work_tb ON employee_tb.employee_id = work_tb.emp_id " +
                "WHERE employee_tb.employee_id LIKE '%" + search + "%' OR " +
                "employee_tb.firstname LIKE '%" + search + "%' OR " +
                "employee_tb.lastname LIKE '%" + search + "%' OR " +
                "employee_tb.type LIKE '%" + search + "%';";

            dataTable.Clear();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectDb);
            adapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];
        }

        public void GetWorkId()
        {
            string query = "SELECT work_id FROM work_tb " +
                "WHERE emp_id= @employee_id";

            MySqlDataReader reader;

            using (var command = new MySqlCommand())
            {
                OpenConnection();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;
                command.Parameters.Add("@employee_id", MySqlDbType.Int32).Value = employeeId;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    workId = (int)reader[0];

                }

                CloseConnection();
            }
        }

        public void GetDay()
        {
            string query = "SELECT day FROM work_tb " +
                "WHERE emp_id= @employee_id";

            MySqlDataReader reader;

            using (var command = new MySqlCommand())
            {
                OpenConnection();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;
                command.Parameters.Add("@employee_id", MySqlDbType.Int32).Value = employeeId;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    day = (int)reader[0];
                }

                CloseConnection();
            }
        }

        public void EditWork()
        {
            string query = "UPDATE work_tb SET gross_salary = @gross_salary, " +
                "net_salary = @net_salary, allowable_absences = @allowable_absences, " +
                "day = @day, cutof_period = @cutof_period, payslip = @payslip, tax = @tax, sss = @sss, pagibig = @pagibig, philhealth = @philhealth, " +
                "loans = @loans, deductions = @deductions, " +
                "deduction_remarks = @deduction_remarks " +
                "WHERE emp_id = @employee_id AND work_id = @work_id";

            using (var command = new MySqlCommand())
            {
                OpenConnection();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;

                command.Parameters.Add("@gross_salary", MySqlDbType.Float).Value = grossSalary;
                command.Parameters.Add("@net_salary", MySqlDbType.Float).Value = netSalary;
                command.Parameters.Add("@allowable_absences", MySqlDbType.Int32).Value = allowableAbsences;
                command.Parameters.Add("@day", MySqlDbType.Int32).Value = day;
                command.Parameters.Add("@cutof_period", MySqlDbType.VarChar).Value = cutofPeriod;
                command.Parameters.Add("payslip", MySqlDbType.Float).Value = paySlip;
                command.Parameters.Add("@tax", MySqlDbType.Float).Value = tax;
                command.Parameters.Add("@sss", MySqlDbType.Float).Value = sss;
                command.Parameters.Add("@pagibig", MySqlDbType.Float).Value = pagibig;
                command.Parameters.Add("@philhealth", MySqlDbType.Float).Value = philhealth;
                command.Parameters.Add("@loans", MySqlDbType.Float).Value = loans;
                command.Parameters.Add("@deductions", MySqlDbType.Float).Value = deductions;
                command.Parameters.Add("@deduction_remarks", MySqlDbType.VarChar).Value = deductionRemarks;
                command.Parameters.Add("@employee_id", MySqlDbType.Int32).Value = employeeId;
                command.Parameters.Add("@work_id", MySqlDbType.Int32).Value = workId;

                command.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void ResetDay()
        {
            string query = "UPDATE work_tb SET day = @day " +
                "WHERE emp_id = @employee_id AND work_id = @work_id";

            using (var command = new MySqlCommand())
            {
                OpenConnection();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connectDb;

                command.Parameters.Add("@day", MySqlDbType.Int32).Value = 0;
                command.Parameters.Add("@employee_id", MySqlDbType.Int32).Value = employeeId;
                command.Parameters.Add("@work_id", MySqlDbType.Int32).Value = workId;

                command.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}
