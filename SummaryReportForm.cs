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
            reporting.ShowReport();

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

        private void SummaryReportForm_Load(object sender, EventArgs e)
        {
            Report("MonthlyPayrollReport");
        }
    }
}
