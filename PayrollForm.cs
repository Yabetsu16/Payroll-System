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
            workDgv.Columns[9].HeaderText = "Tax";
            workDgv.Columns[10].HeaderText = "SSS";
            workDgv.Columns[11].HeaderText = "Pagibig";
            workDgv.Columns[12].HeaderText = "Philhealth";
            workDgv.Columns[13].HeaderText = "Loans";
            workDgv.Columns[14].HeaderText = "Deductions";
            workDgv.Columns[15].HeaderText = "Remaks";
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
                taxNum.Value = Convert.ToDecimal(workDgv.Rows[e.RowIndex].Cells[9].Value);
                sssNum.Value = Convert.ToDecimal(workDgv.Rows[e.RowIndex].Cells[10].Value);
                pagibigNum.Value = Convert.ToDecimal(workDgv.Rows[e.RowIndex].Cells[11].Value);
                philhealthNum.Value = Convert.ToDecimal(workDgv.Rows[e.RowIndex].Cells[12].Value);
                loanNum.Value = Convert.ToDecimal(workDgv.Rows[e.RowIndex].Cells[13].Value);
                otherDeductionNum.Value = Convert.ToDecimal(workDgv.Rows[e.RowIndex].Cells[14].Value);
                deductionRemarksTb.Text = workDgv.Rows[e.RowIndex].Cells[15].Value.ToString();
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            work.SearchWork(searchTb.Text);
        }

        private void PayrollForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            Hide();
        }

        private void fifteenthMonthRb_CheckedChanged(object sender, EventArgs e)
        {
            if (fifteenthMonthRb.Checked)
            {
                decimal subtotal = netNum.Value / 2;
                paySlipNum.Value = subtotal;
                totalPaySlip = paySlipNum.Value;
            }
        }

        private void thirtiethMonthRb_CheckedChanged(object sender, EventArgs e)
        {
            if (thirtiethMonthRb.Checked)
            {
                decimal subtotal = (netNum.Value / 2) * 2;
                paySlipNum.Value = subtotal;
                totalPaySlip = paySlipNum.Value;
            }
        }

        private void grossNum_ValueChanged(object sender, EventArgs e)
        {
            decimal tax;

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

            Console.WriteLine(tax);
            taxNum.Value = grossNum.Value * tax;
            sssNum.Value = grossNum.Value * .36m;
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

        private void editPayrollBtn_Click(object sender, EventArgs e)
        {
            work.workId = workId;
            work.employeeId = employeeId;
            work.grossSalary = (float)grossNum.Value;
            work.allowableAbsences = (float)allAbsencesNum.Value;
            work.day = (int)dayNum.Value;
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
    }
}
