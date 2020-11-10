using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void gotoForm1_Click(object sender, EventArgs e)
        {
            CountdownForm countDownForm = new CountdownForm();
            countDownForm.Show();
        }

        private void gotoForm2_Click(object sender, EventArgs e)
        {
            CountupTimer countUpForm = new CountupTimer();
            countUpForm.Show();
        }
    }
}
