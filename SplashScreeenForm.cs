using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class SplashScreeenForm : Form
    {
        private int iProgressBarValue = 0;
        public SplashScreeenForm()
        {
            InitializeComponent();
        }

        private void SplashScreeenForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 300;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            iProgressBarValue++;
            switch (iProgressBarValue)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    progressBar1.Value = (iProgressBarValue * 100);
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                case 10:
                    progressBar1.Value = (iProgressBarValue * 100);
                    break;
                case 13:
                    timer1.Stop();
                    timer1.Enabled = false;

                    login.Show();
                    Hide();
                    break;
                default:
                    break;
            }
        }
    }
}
