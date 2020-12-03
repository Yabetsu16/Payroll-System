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
        }

        private void RemoveButtonDataGridView()
        {
            employeeDgv.Columns.Remove("editDgvBtn");
            employeeDgv.Columns.Remove("removeDgvBtn");
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
            CreateButtonDataGridView();
            CloseAddPanel();
            CloseEditPanel();
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
                RemoveButtonDataGridView();
                RefreshDataGridView();
                CreateButtonDataGridView();
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

        private void employeeDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    id = (int)employeeDgv.Rows[e.RowIndex].Cells[0].Value;
                    editFirstnameTb.Text = employeeDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                    editLastnameTb.Text = employeeDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                    editTypeComB.SelectedItem = employeeDgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                    OpenEditPanel();
                    Console.WriteLine("ID: " + id);
                }

                if (e.ColumnIndex == 5)
                {
                    Console.WriteLine("Remove Clicked");
                }
            }
            catch (Exception)
            {

                throw;
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
            employees.type = editTypeComB.SelectedItem.ToString();
            employees.EditEmployee();
            RemoveButtonDataGridView();
            RefreshDataGridView();
            CreateButtonDataGridView();
            CloseEditPanel();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            employees.SearchEmployees(searchTb.Text);
        }
    }
}
