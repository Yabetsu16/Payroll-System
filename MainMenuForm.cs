using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class MainMenuForm : Form
    {
        
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            Hide();
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm();
            employee.Show();
            Hide();
        }

        private void payrollBtn_Click(object sender, EventArgs e)
        {
            PayrollForm payroll = new PayrollForm();
            payroll.Show();
            Hide();
        }

        private void summaryReportBtn_Click(object sender, EventArgs e)
        {
            SummaryReportForm summary = new SummaryReportForm();
            summary.Show();
            Hide();
        }
    }
}
