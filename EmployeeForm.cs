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
    public partial class EmployeeForm : Form
    {
        EmployeesClass employees = new EmployeesClass();
        ReportingClass reporting = new ReportingClass();
        TimeKeepingClass timeKeeping = new TimeKeepingClass();
        public int id;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void OpenAddPanel()
        {
            addEmployeePanel.Visible = true;
        }

        private void CloseAddPanel()
        {
            addEmployeePanel.Visible = false;
        }

        private void OpenEditPanel()
        {
            editEmployeePanel.Visible = true;
        }

        private void CloseEditPanel()
        {
            editEmployeePanel.Visible = false;
        }

        private void OpenTimeKeepingPanel()
        {
            timeKeepingPanel.Visible = true;
        }

        private void CloseTimeKeepingPanel()
        {
            timeKeepingPanel.Visible = false;
        }

        private void ClearTextBox()
        {
            firstnameTb.Clear();
            lastnameTb.Clear();
            jobTb.Clear();
            typeComB.SelectedIndex = 0;
        }

        private void CreateButtonDataGridView()
        {
            DataGridViewButtonColumn editDgvBtn = new DataGridViewButtonColumn();
            editDgvBtn.HeaderText = "Edit";
            editDgvBtn.Text = "Edit";
            editDgvBtn.Name = "editDgvBtn";
            editDgvBtn.UseColumnTextForButtonValue = true;
            employeeDgv.Columns.Add(editDgvBtn);

            DataGridViewButtonColumn removeDgvBtn = new DataGridViewButtonColumn();
            removeDgvBtn.HeaderText = "Remove";
            removeDgvBtn.Text = "Remove";
            removeDgvBtn.Name = "removeDgvBtn";
            removeDgvBtn.UseColumnTextForButtonValue = true;
            employeeDgv.Columns.Add(removeDgvBtn);

            DataGridViewButtonColumn timeKeepingDgvBtn = new DataGridViewButtonColumn();
            timeKeepingDgvBtn.HeaderText = "Time Keeping";
            timeKeepingDgvBtn.Text = "View";
            timeKeepingDgvBtn.Name = "timeKeepingDgvBtn";
            timeKeepingDgvBtn.UseColumnTextForButtonValue = true;
            employeeDgv.Columns.Add(timeKeepingDgvBtn);
        }

        private void RemoveButtonDataGridView()
        {
            employeeDgv.Columns.Remove("editDgvBtn");
            employeeDgv.Columns.Remove("removeDgvBtn");
            employeeDgv.Columns.Remove("timeKeepingDgvBtn");
        }

        public void RefreshEmployeeDataGridView()
        {
            employeeDgv.DataSource = null;
            employees.ShowEmployees();
            employeeDgv.DataSource = employees.dataTable;
            employeeDgv.Columns[0].HeaderText = "Employee ID";
            employeeDgv.Columns[1].HeaderText = "Firstname";
            employeeDgv.Columns[2].HeaderText = "Lastname";
            employeeDgv.Columns[3].HeaderText = "Username";
            employeeDgv.Columns[4].HeaderText = "Password";
            employeeDgv.Columns[5].HeaderText = "Type";
            employeeDgv.Columns[6].HeaderText = "Job";
        }

        private void RefreshTimeKeepingDataGridView()
        {
            timeKeepingDgv.DataSource = null;
            timeKeeping.ShowTimeKeeping();
            timeKeepingDgv.DataSource = timeKeeping.dataTable;
            timeKeepingDgv.Columns[0].Visible = false;
            timeKeepingDgv.Columns[1].Visible = false;
            timeKeepingDgv.Columns[2].HeaderText = "Time In";
            timeKeepingDgv.Columns[3].HeaderText = "Time Out";
        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            Hide();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            RefreshEmployeeDataGridView();
            CreateButtonDataGridView();
            CloseAddPanel();
            CloseEditPanel();
            CloseTimeKeepingPanel();
        }

        private void showAddPanelBtn_Click(object sender, EventArgs e)
        {
            CloseEditPanel();
            OpenAddPanel();
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (firstnameTb.Text != "" || lastnameTb.Text != "" || typeComB.SelectedIndex != 0 || jobTb.Text == "")
            {
                employees.firstname = firstnameTb.Text;
                employees.lastname = lastnameTb.Text;
                employees.type = typeComB.Text;
                employees.job = jobTb.Text;
                employees.AddEmployee();
                employees.GetId();
                reporting.AddEmployeeReport(employees.id);
                RemoveButtonDataGridView();
                RefreshEmployeeDataGridView();
                CreateButtonDataGridView();
                CloseAddPanel();
                ClearTextBox();
            }
        }

        private void closeAddPanelBtn_Click(object sender, EventArgs e)
        {
            CloseAddPanel();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void employeeDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7)
                {
                    CloseAddPanel();
                    id = (int)employeeDgv.Rows[e.RowIndex].Cells[0].Value;
                    editFirstnameTb.Text = employeeDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                    editLastnameTb.Text = employeeDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                    editUsernameTb.Text = employeeDgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                    editPasswordTb.Text = employeeDgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                    employees.currentUsername = employeeDgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                    employees.currentPassword = employeeDgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                    editTypeComB.SelectedItem = employeeDgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                    editJob.Text = employeeDgv.Rows[e.RowIndex].Cells[6].Value.ToString();
                    OpenEditPanel();
                    Console.WriteLine("ID: " + id);
                    Console.WriteLine("Username: " + employees.currentUsername);
                    Console.WriteLine("Password: " + employees.currentPassword);
                }

                if (e.ColumnIndex == 8)
                {
                    id = (int)employeeDgv.Rows[e.RowIndex].Cells[0].Value;

                    DialogResult result = MessageBox.Show("Are you sure?",
                        "Remove " + employeeDgv.Rows[e.RowIndex].Cells[2].Value, MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        employees.id = id;
                        employees.RemoveEmployee();
                        reporting.DeleteEmployeeReport(employees.id);
                        RemoveButtonDataGridView();
                        RefreshEmployeeDataGridView();
                        CreateButtonDataGridView();
                    }
                }

                if (e.ColumnIndex == 9)
                {
                    id = (int)employeeDgv.Rows[e.RowIndex].Cells[0].Value;
                    nameTimeKeepingLbl.Text = employeeDgv.Rows[e.RowIndex].Cells[1].Value + " "
                        + employeeDgv.Rows[e.RowIndex].Cells[2].Value;
                    timeKeeping.employeeId = id;
                    OpenTimeKeepingPanel();
                }
            }
            catch
            {
                MessageBox.Show("Please don't click the header");
            }
        }

        private void closeUpdatePanelBtn_Click(object sender, EventArgs e)
        {
            CloseEditPanel();
        }

        private void editEmployeeBtn_Click(object sender, EventArgs e)
        {
            employees.id = id;
            employees.firstname = editFirstnameTb.Text;
            employees.lastname = editLastnameTb.Text;
            employees.username = editUsernameTb.Text;
            employees.password = editPasswordTb.Text;
            employees.type = editTypeComB.SelectedItem.ToString();
            employees.job = editJob.Text;
            employees.EditEmployee();
            reporting.UpdateEmployeeReport(employees.id);
            RemoveButtonDataGridView();
            RefreshEmployeeDataGridView();
            CreateButtonDataGridView();
            CloseEditPanel();
        }

        private void closeTimeKeepingBtn_Click(object sender, EventArgs e)
        {
            CloseTimeKeepingPanel();
        }

        private void timeKeepingPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (timeKeepingPanel.Visible)
            {
                RefreshTimeKeepingDataGridView();
            }
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            employees.SearchEmployees(searchTb.Text);
        }

        private void EmployeeForm_SizeChanged(object sender, EventArgs e)
        {
            timeKeepingPanel.Location = new Point(
                Width / 2 - timeKeepingPanel.Size.Width / 2,
                Height / 2 - timeKeepingPanel.Size.Height / 2);
            timeKeepingPanel.Anchor = AnchorStyles.None;
        }
    }
}
