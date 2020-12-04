using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Payroll.Classes;

namespace Payroll
{
    public partial class PayrollForm : Form
    {
        WorkClass work = new WorkClass();
        public int workId;
        public int employeeId;
        public decimal totalDeductions = 0;
        public decimal totalPaySlip = 0;


        public PayrollForm()
        {
            InitializeComponent();
        }

        private void OpenEditPanel()
        {
            editWorkPanel.Visible = true;
        }

        private void CloseEditPanel()
        {
            editWorkPanel.Visible = false;
        }

        private void RefreshDataGridView()
        {
            workDgv.DataSource = null;
            work.ShowWork();
            workDgv.DataSource = work.dataTable;
            workDgv.Columns[1].HeaderText = "Employee ID";
            workDgv.Columns[2].HeaderText = "Firstname";
            workDgv.Columns[3].HeaderText = "Lastname";
            workDgv.Columns[4].HeaderText = "Type";
            workDgv.Columns[5].HeaderText = "Gross";
            workDgv.Columns[6].HeaderText = "Net";
            workDgv.Columns[7].HeaderText = "Allowable Absences";
            workDgv.Columns[8].HeaderText = "Day";
            workDgv.Columns[9].HeaderText = "Cut-of Period";
            workDgv.Columns[10].HeaderText = "Pay Slip";
            workDgv.Columns[11].HeaderText = "Tax";
            workDgv.Columns[12].HeaderText = "SSS";
            workDgv.Columns[13].HeaderText = "Pagibig";
            workDgv.Columns[14].HeaderText = "Philhealth";
            workDgv.Columns[15].HeaderText = "Loans";
            workDgv.Columns[16].HeaderText = "Deductions";
            workDgv.Columns[17].HeaderText = "Remaks";
        }

        private void CreateDataGridViewButton()
        {
            DataGridViewButtonColumn editDgvBtn = new DataGridViewButtonColumn();
            editDgvBtn.HeaderText = "Edit";
            editDgvBtn.Text = "Edit";
            editDgvBtn.Name = "editDgvBtn";
            editDgvBtn.UseColumnTextForButtonValue = true;
            workDgv.Columns.Add(editDgvBtn);
        }

        private void RemoveDataGridViewButton()
        {
            workDgv.Columns.Remove("editDgvBtn");
        }

        private void Computation()
        {
            decimal tax;
            decimal sss;

            if (grossNum.Value <= 20833)
            {
                tax = 0;
            }
            else if (grossNum.Value <= 33333)
            {
                tax = .20m;
            }
            else if (grossNum.Value <= 66667)
            {
                tax = .25m;
            }
            else if (grossNum.Value <= 166667)
            {
                tax = .30m;
            }
            else if (grossNum.Value <= 666667)
            {
                tax = .32m;
            }
            else
            {
                tax = .35m;
            }

            if (grossNum.Value < 1250)
            {
                sss = 36.30m;
            }
            else if (grossNum.Value < 1750)
            {
                sss = 54.50m;
            }
            else if (grossNum.Value < 2250)
            {
                sss = 72.70m;
            }
            else if (grossNum.Value < 2750)
            {
                sss = 90.80m;
            }
            else if (grossNum.Value < 3250)
            {
                sss = 109.00m;
            }
            else if (grossNum.Value < 3750)
            {
                sss = 127.20m;
            }
            else if (grossNum.Value < 4250)
            {
                sss = 145.30m;
            }
            else if (grossNum.Value < 4750)
            {
                sss = 163.50m;
            }
            else if (grossNum.Value < 5250)
            {
                sss = 181.70m;
            }
            else if (grossNum.Value < 5750)
            {
                sss = 199.80m;
            }
            else if (grossNum.Value < 6250)
            {
                sss = 218.00m;
            }
            else if (grossNum.Value < 6750)
            {
                sss = 236.20m;
            }
            else if (grossNum.Value < 7250)
            {
                sss = 254.30m;
            }
            else if (grossNum.Value < 7750)
            {
                sss = 272.50m;
            }
            else if (grossNum.Value < 8250)
            {
                sss = 290.70m;
            }
            else if (grossNum.Value < 8750)
            {
                sss = 308.80m;
            }
            else if (grossNum.Value < 9250)
            {
                sss = 327.00m;
            }
            else if (grossNum.Value < 9750)
            {
                sss = 345.20m;
            }
            else if (grossNum.Value < 10250)
            {
                sss = 363.30m;
            }
            else if (grossNum.Value < 10750)
            {
                sss = 381.50m;
            }
            else if (grossNum.Value < 11250)
            {
                sss = 399.70m;
            }
            else if (grossNum.Value < 11750)
            {
                sss = 417.80m;
            }
            else if (grossNum.Value < 12250)
            {
                sss = 436.00m;
            }
            else if (grossNum.Value < 12750)
            {
                sss = 454.20m;
            }
            else if (grossNum.Value < 13250)
            {
                sss = 472.30m;
            }
            else if (grossNum.Value < 13750)
            {
                sss = 490.50m;
            }
            else if (grossNum.Value < 14250)
            {
                sss = 508.70m;
            }
            else if (grossNum.Value < 14750)
            {
                sss = 526.80m;
            }
            else if (grossNum.Value < 15250)
            {
                sss = 545.00m;
            }
            else if (grossNum.Value < 15750)
            {
                sss = 563.20m;
            }
            else
            {
                sss = 581.30m;
            }

            Console.WriteLine(tax);
            taxNum.Value = grossNum.Value * tax;
            sssNum.Value = sss;
            pagibigNum.Value = grossNum.Value * .02m;

            if (grossNum.Value > 0)
            {
                philhealthNum.Value = 200;
            }
            else
            {
                philhealthNum.Value = 0;
            }

            totalDeductions = taxNum.Value + sssNum.Value +
                pagibigNum.Value + philhealthNum.Value +
                loanNum.Value + otherDeductionNum.Value;

            Console.WriteLine("Total Deduction: " + totalDeductions);

            decimal total = grossNum.Value - totalDeductions;
            if (total < 0)
            {
                total = 0;
            }
            netNum.Value = total;
            totalDeductionLbl.Text = Decimal.Round(totalDeductions, 2).ToString();
        }

        private void PayrollForm_Load(object sender, EventArgs e)
        {
            CloseEditPanel();
            CreateDataGridViewButton();
            RefreshDataGridView();
        }

        private void workDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                OpenEditPanel();
                employeeId = (int)workDgv.Rows[e.RowIndex].Cells[1].Value;
                editEmployeeLbl.Text = "Edit " + workDgv.Rows[e.RowIndex].Cells[2].Value.ToString() + " " +
                    workDgv.Rows[e.RowIndex].Cells[3].Value.ToString() + " Payroll";
                grossNum.Value = Convert.ToDecimal(workDgv.Rows[e.RowIndex].Cells[5].Value);
                netNum.Value = Convert.ToDecimal(workDgv.Rows[e.RowIndex].Cells[6].Value);
                allAbsencesNum.Value = (int)workDgv.Rows[e.RowIndex].Cells[7].Value;
                dayNum.Value = (int)workDgv.Rows[e.RowIndex].Cells[8].Value;
                if (workDgv.Rows[e.RowIndex].Cells[9].Value.ToString() == "15th")
                {
                    fifteenthRb.Checked = true;
                }
                else
                {
                    thirtiethRb.Checked = true;
                }
                paySlipNum.Value = Convert.ToDecimal(workDgv.Rows[e.RowIndex].Cells[10].Value);
                taxNum.Value = Convert.ToDecimal(workDgv.Rows[e.RowIndex].Cells[11].Value);
                sssNum.Value = Convert.ToDecimal(workDgv.Rows[e.RowIndex].Cells[12].Value);
                pagibigNum.Value = Convert.ToDecimal(workDgv.Rows[e.RowIndex].Cells[13].Value);
                philhealthNum.Value = Convert.ToDecimal(workDgv.Rows[e.RowIndex].Cells[14].Value);
                loanNum.Value = Convert.ToDecimal(workDgv.Rows[e.RowIndex].Cells[15].Value);
                otherDeductionNum.Value = Convert.ToDecimal(workDgv.Rows[e.RowIndex].Cells[16].Value);
                deductionRemarksTb.Text = workDgv.Rows[e.RowIndex].Cells[17].Value.ToString();
                work.employeeId = employeeId;
                work.GetWorkId();
                workId = work.workId;
                Console.WriteLine("Employee ID: " + employeeId);
                Console.WriteLine("Work ID: " + workId);
            }
        }

        private void closeEditPayrollPanel_Click(object sender, EventArgs e)
        {
            CloseEditPanel();
        }

        private void PayrollForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            Hide();
        }

        private void fifteenthMonthRb_CheckedChanged(object sender, EventArgs e)
        {
            if (fifteenthRb.Checked)
            {
                decimal subtotal = netNum.Value / 2;
                paySlipNum.Value = subtotal;
                totalPaySlip = paySlipNum.Value;
            }
        }

        private void thirtiethMonthRb_CheckedChanged(object sender, EventArgs e)
        {
            if (thirtiethRb.Checked)
            {
                decimal subtotal = (netNum.Value / 2) * 2;
                paySlipNum.Value = subtotal;
                totalPaySlip = paySlipNum.Value;
            }
        }

        private void grossNum_ValueChanged(object sender, EventArgs e)
        {
            Computation();
        }

        private void editPayrollBtn_Click(object sender, EventArgs e)
        {
            work.workId = workId;
            work.employeeId = employeeId;
            work.grossSalary = (float)grossNum.Value;
            work.allowableAbsences = (float)allAbsencesNum.Value;
            work.day = (int)dayNum.Value;
            if (fifteenthRb.Checked)
            {
                work.cutofPeriod = fifteenthRb.Text;
            }
            else
            {
                work.cutofPeriod = thirtiethRb.Text;
            }
            work.paySlip = (float)paySlipNum.Value;
            work.netSalary = (float)netNum.Value;
            work.tax = (float)taxNum.Value;
            work.sss = (float)sssNum.Value;
            work.pagibig = (float)pagibigNum.Value;
            work.philhealth = (float)philhealthNum.Value;
            work.loans = (float)loanNum.Value;
            work.deductions = (float)otherDeductionNum.Value;
            work.deductionRemarks = deductionRemarksTb.Text;
            work.EditWork();
            RemoveDataGridViewButton();
            CreateDataGridViewButton();
            RefreshDataGridView();
        }

        private void otherDeductionNum_ValueChanged(object sender, EventArgs e)
        {
            Computation();
        }

        private void loanNum_ValueChanged(object sender, EventArgs e)
        {
            Computation();
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            work.SearchWork(searchTb.Text);
        }
    }
}
