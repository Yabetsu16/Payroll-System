using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Payroll.Classes;
using CrystalDecisions.CrystalReports.Engine;

namespace Payroll
{
    public partial class PayslipForm : Form
    {
        ReportingClass reporting = new ReportingClass();
        WorkClass work = new WorkClass();
        public int employee_id;

        public PayslipForm()
        {
            InitializeComponent();
        }

        private void Report(string reportName)
        {
            reporting.ShowPaySlip(employee_id);

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

        private void PayslipForm_Load(object sender, EventArgs e)
        {
            Report("PaySlipReport");

            foreach (ToolStrip ts in crystalReportViewer1.Controls.OfType<ToolStrip>())
            {
                foreach (ToolStripButton tsb in ts.Items.OfType<ToolStripButton>())
                {
                    //hacky but should work. you can probably figure out a better method
                    if (tsb.ToolTipText.ToLower().Contains("print"))
                    {
                        //Adding a handler for our propose
                        tsb.Click += new EventHandler(printButton_Click);
                    }
                }
            }

            work.employeeId = employee_id;
            work.GetWorkId();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            work.ResetDay();
            PayrollForm payroll = new PayrollForm();
            payroll.Show();
            Hide();
        }
    }
}
