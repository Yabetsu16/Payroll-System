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
    public partial class TimeKeepingForm : Form
    {
        TimeKeepingClass timeKeeping = new TimeKeepingClass();
        public int id;
        public bool isTimeIn = false;

        public string username;
        public string password;

        public TimeKeepingForm()
        {
            InitializeComponent();
        }

        private void TimeKeepingForm_Load(object sender, EventArgs e)
        {
            timeInBtn.Visible = false;
            timeOutBtn.Visible = false;
            timer1.Start();
            timeKeeping.GetEmployeeId(username, password);
            id = timeKeeping.employeeId;
            timeKeeping.GetTimeKeepingId(id);
            Console.WriteLine("Time Keeping ID: " + timeKeeping.timekeepingId);
            timeKeeping.GetTimeIn();
            timeKeeping.GetTimeOut();
            Console.WriteLine("Time In: " + timeKeeping.timeInDateTime);
            Console.WriteLine("Time Out: " + timeKeeping.timeOutDateTime);

            if (timeKeeping.timeInDateTime == "" && timeKeeping.timeOutDateTime == "")
            {
                isTimeIn = false;
            }
            else if (timeKeeping.timeInDateTime != "" && timeKeeping.timeOutDateTime == "")
            {
                isTimeIn = true;
            }
            else if (timeKeeping.timeInDateTime != "" && timeKeeping.timeOutDateTime != "")
            {
                isTimeIn = false;
            }

            if (isTimeIn)
            {
                timeInBtn.Visible = false;
                timeOutBtn.Visible = true;
            }
            else
            {
                timeInBtn.Visible = true;
                timeOutBtn.Visible = false;
            }

            Console.WriteLine("Timed In: " + isTimeIn);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            currentDateTimeLbl.Text = dateTime.ToString("MMM. dd, yyyy / hh:mm tt");
        }

        private void TimeKeepingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            Hide();
        }

        private void timeInBtn_Click(object sender, EventArgs e)
        {
            timeKeeping.TimeIn();
            MessageBox.Show("You time in at " + currentDateTimeLbl.Text);
            timeOutBtn.Visible = false;
            timeInBtn.Visible = false;
            LoginForm login = new LoginForm();
            login.Show();
            Hide();
        }

        private void timeOutBtn_Click(object sender, EventArgs e)
        {
            timeKeeping.TimeOut();
            MessageBox.Show("You time out at " + currentDateTimeLbl.Text);
            timeOutBtn.Visible = false;
            timeInBtn.Visible = false;
            LoginForm login = new LoginForm();
            login.Show();
            Hide();
        }
    }
}
