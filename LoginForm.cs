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
    public partial class LoginForm : Form
    {
        UsersClass users = new UsersClass();
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTb.Text != "" && passwordTb.Text != "")
            {
                users.username = usernameTb.Text;
                users.password = passwordTb.Text;
                bool verify = users.ValidateUser();

                if (verify)
                {
                    MainMenuForm mainMenu = new MainMenuForm();
                    MessageBox.Show("Welcome " + users.username + ".");
                    mainMenu.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or password.");
                }
            }
            else if (usernameTb.Text == "" && passwordTb.Text == "")
            {
                MessageBox.Show("Please enter your username and password.");
            }
            else if (usernameTb.Text == "")
            {
                MessageBox.Show("Please enter your username.");
            }
            else if (passwordTb.Text == "")
            {
                MessageBox.Show("Please enter your password.");
            }
        }

        private void showPasswordCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckB.Checked)
            {
                passwordTb.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTb.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
