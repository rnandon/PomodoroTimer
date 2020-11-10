using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace PomodoroTimer
{
    public partial class Form1 : Form
    {
        // Initialize static variables to handle timer.
        private static System.Timers.Timer aTimer;
        static bool stop = false;
        static TimeValues timeValue = new TimeValues();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Start the timer, check for existing time left on the clock and input validity.
            if (timeValue.Seconds == 0 && timeValue.Minutes == 0 && timeValue.Hours == 0)
            {
                // Creates an error pop-up if no time is set.
                string messageError = "Invalid time selection. Please use the boxes to create a valid time input.";
                string captionError = "No Time Input";
                MessageBoxButtons buttonsError = MessageBoxButtons.OK;

                MessageBox.Show(messageError, captionError, buttonsError);
                return;
            }
            if (timeValue.TimeRemaining <= 0)
            {
                // Modifies the timer values to reflect the user's settings. 
                timeValue.TimeRemaining = timeValue.Seconds;
                timeValue.TimeRemaining += timeValue.Minutes * 60;
                timeValue.TimeRemaining += timeValue.Hours * 3600;
                timeValue.TimeRemaining *= 1000;
                timeValue.InitialTime = timeValue.TimeRemaining;
                timeValue.NextStepThreshold = timeValue.InitialTime / 100;
            }

            // Begins the timer
            stop = false;
            aTimer = new System.Timers.Timer(100);
            aTimer.Enabled = true;
            aTimer.AutoReset = true;
            aTimer.Elapsed += OnTimedEvent;
        }

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            // Decrement and check TimeRemaining to stop the timer if it is complete or paused.
            timeValue.TimeRemaining -= 100;

            if (timeValue.TimeRemaining < 0)
            {
                aTimer.Stop();
                string messageEnd = "YOUR TIMER IS GOING OFF!!!";
                string captionEnd = "Timer Ended";
                MessageBoxButtons buttonsEnd = MessageBoxButtons.OK;

                MessageBox.Show(messageEnd, captionEnd, buttonsEnd);
            } 
            else if (stop)
            {
                aTimer.Stop();
                string messageStop = "Timer is paused.";
                string captionStop = "Timer Paused";
                MessageBoxButtons buttonsStop = MessageBoxButtons.OK;
                MessageBox.Show(messageStop, captionStop, buttonsStop);
            }
        }

        // Time slider controls
        private void numericUpDownSeconds_ValueChanged(object sender, EventArgs e)
        {
            timeValue.Seconds = numericUpDownSeconds.Value;
        }

        private void numericUpDownMinutes_ValueChanged(object sender, EventArgs e)
        {
            timeValue.Minutes = numericUpDownMinutes.Value;
        }

        private void numericUpDownHours_ValueChanged(object sender, EventArgs e)
        {
            timeValue.Hours = numericUpDownHours.Value;
        }

        // Stop button
        private void pauseTimer_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }

    // TimeValues class, stores seconds, minutes, hours, and 
    // control values used throughout timer.
    public class TimeValues
    {
        public decimal Seconds
        { get; set; }

        public decimal Minutes
        { get; set; }

        public decimal Hours
        { get; set; }

        public decimal TimeRemaining
        { get; set; }

        public decimal InitialTime
        { get; set; }

        public decimal NextStepThreshold
        { get; set; }

        public int CurrentStep
        { get; set; }

        public TimeValues()
        {
            this.Seconds = 0;
            this.Minutes = 0;
            this.Hours = 0;
            this.TimeRemaining = 0;
            this.InitialTime = 0;
            this.NextStepThreshold = 0;
            this.CurrentStep = 0;
        }
    }
}
