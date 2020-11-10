using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class CountupTimer : Form
    {
        static decimal secondsElapsed = 0;
        private static System.Timers.Timer timeTracker;
        static bool isStarted = false;
        public CountupTimer()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            // Initializes timer
            timeTracker = new System.Timers.Timer(100);
            timeTracker.Elapsed += OnTimedEvent;
            timeTracker.Start();
            isStarted = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            // Timer updates every .1 seconds, tracking that in secondsElapsed
            secondsElapsed = secondsElapsed + 0.1m;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            // Stop timer and convert seconds to minutes/hours, 
            // format pop-up with time elapsed
            if (isStarted)
            {
                timeTracker.Stop();
                int hours = Convert.ToInt32(Math.Floor(secondsElapsed / 3600));
                secondsElapsed = secondsElapsed - 3600 * hours;
                int minutes = Convert.ToInt32(Math.Floor(secondsElapsed / 60));
                secondsElapsed = secondsElapsed - minutes * 60;
                string message = $"Total time elapsed:\n{secondsElapsed} seconds, {minutes} minutes, {hours} hours.";
                string caption = "Timer Results";
                MessageBoxButtons timerResultsButtons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, timerResultsButtons);
                isStarted = false;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            secondsElapsed = 0;
        }

        private void CountupTimer_Load(object sender, EventArgs e)
        {

        }
    }
}
