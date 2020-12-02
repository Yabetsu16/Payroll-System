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

        public void RefreshDataGridView()
        {
            employeeDgv.DataSource = null;
            employees.ShowEmployees();
            employeeDgv.DataSource = employees.dataTable;
            employeeDgv.Columns[0].HeaderText = "Employee ID";
            employeeDgv.Columns[1].HeaderText = "Firstname";
            employeeDgv.Columns[2].HeaderText = "Lastname";
            employeeDgv.Columns[3].HeaderText = "Type";
        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            Hide();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
            addEmployeePanel.Visible = false;
        }

        private void showAddPanelBtn_Click(object sender, EventArgs e)
        {
            OpenAddPanel();
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (firstnameTb.Text != "" || lastnameTb.Text != "" || typeComB.SelectedIndex != 0)
            {
                employees.firstname = firstnameTb.Text;
                employees.lastname = lastnameTb.Text;
                employees.type = typeComB.Text;

                employees.AddEmployee();
                RefreshDataGridView();
                CloseAddPanel();
            }
        }

        private void closeAddPanelBtn_Click(object sender, EventArgs e)
        {
            CloseAddPanel();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            firstnameTb.Clear();
            lastnameTb.Clear();
            typeComB.SelectedIndex = 0;
        }
    }
}
