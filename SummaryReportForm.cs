using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Payroll.Classes;
using CrystalDecisions.CrystalReports.Engine;

namespace Payroll
{
    public partial class SummaryReportForm : Form
    {
        ReportingClass reporting = new ReportingClass();

        public SummaryReportForm()
        {
            InitializeComponent();
        }

        private void Report(string reportName)
        {
            if (reportName == "MonthlyPayrollReport")
            {
                reporting.ShowMonthlyReport();

                try
                {
                    ReportDocument reportDocument = new ReportDocument();

                    string reportPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + "\\" + reportName + ".rpt";

                    reportDocument.Load(reportPath);

                    reportDocument.SetDataSource(reporting.dataTable);
                    crystalReportViewer1.ReportSource = reportDocument;
                    crystalReportViewer1.Refresh();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            if (reportName == "AnnualPayrollReport")
            {
                reporting.ShowAnnualReport();

                try
                {
                    ReportDocument reportDocument = new ReportDocument();

                    string reportPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + "\\" + reportName + ".rpt";

                    reportDocument.Load(reportPath);

                    reportDocument.SetDataSource(reporting.dataTable);
                    crystalReportViewer1.ReportSource = reportDocument;
                    crystalReportViewer1.Refresh();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private void monthlyPayrollReportBtn_Click(object sender, EventArgs e)
        {
            Report("MonthlyPayrollReport");
        }

        private void anuallyPayrollReportBtn_Click(object sender, EventArgs e)
        {
            Report("AnnualPayrollReport");
        }

        private void SummaryReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            Hide();
        }
    }
}
