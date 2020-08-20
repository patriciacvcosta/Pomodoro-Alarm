using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PomodoroAlarm
{
    public partial class PomodoroForm : Form
    {
        int focusDurationInSeconds;
        int breakDurationInSeconds;
        bool restartWorker = false;

        bool runningModeOff;

        public PomodoroForm()
        {
            InitializeComponent();
        }

        private void PomodoroForm_Load(object sender, EventArgs e)
        {
            runningModeOff = true;
            SetUpScrollBars();
            SetRunningModeOff(runningModeOff);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            focusDurationInSeconds = hScrollBarFocusTime.Value * 60;
            breakDurationInSeconds = hScrollBarBreakTime.Value * 60;

            if (focusDurationInSeconds == 0 && breakDurationInSeconds == 0)
            {
                lblWarnings.Text = "Please, set your Focus and/or Break duration..";
                lblWarnings.Visible = true;
                SetWarningMessage();
                return;
            }
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
                timer1.Enabled = true;

                runningModeOff = false;
                SetRunningModeOff(runningModeOff);            

            }
            else
            {
                lblWarnings.Text = "The time is still running for another activity...";
                SetWarningMessage();
            }

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (focusDurationInSeconds > 0)
            {
                focusDurationInSeconds--;
                lblCounter.Text = GetHours(focusDurationInSeconds) + ":" + GetMinutes(focusDurationInSeconds) + ":" + GetSeconds(focusDurationInSeconds);
                lblFocusMessage.Visible = true;
            }
            else if (breakDurationInSeconds > 0)
            {
                breakDurationInSeconds--;
                lblCounter.Text = GetHours(breakDurationInSeconds) + ":" + GetMinutes(breakDurationInSeconds) + ":" + GetSeconds(breakDurationInSeconds);
                lblFocusMessage.Visible = false;
                lblBreakMessage.Visible = true;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                backgroundWorker1.ReportProgress(0);
                timer1.Stop();

                runningModeOff = true;
                SetRunningModeOff(runningModeOff);

                lblWarnings.Text = "You cancelled the activity...";
                SetWarningMessage();

            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int totalFocusSeconds = hScrollBarFocusTime.Value * 60;
            int totalBreakSeconds = hScrollBarBreakTime.Value * 60;

            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(totalFocusSeconds * 1000 / 100);

                backgroundWorker1.ReportProgress(i);   //ReportProgress method raises the ProgressChanged event automatically

                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }

            if (breakDurationInSeconds > 0)
            {
                restartWorker = true;

                for (int i = 1; i <= 100; i++)
                {
                    Thread.Sleep(totalBreakSeconds * 1000 / 100);

                    backgroundWorker1.ReportProgress(i);   //ReportProgress method raises the ProgressChanged event automatically

                    if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker1.ReportProgress(0);
                        return;
                    }
                }
            }

        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (restartWorker)
            {
                backgroundWorker1.CancelAsync();
                restartWorker = false;
            }
            if (e.Cancelled)
            {
                lblWarnings.Text = "You cancelled the activity...";
                SetWarningMessage();

            }
            else if (e.Error != null)
            {
                lblWarnings.Text = e.Error.Message;
                SetWarningMessage();

            }
            else
            {
                btnStart.Enabled = true;
            }
        }


        private void HScrollBarFocusTime_Scroll(object sender, ScrollEventArgs e)
        {
            lblFocusTime.Text = hScrollBarFocusTime.Value + " minutes";
            lblFocusTime.Visible = true;
        }
        private void HScrollBarBreakTime_Scroll(object sender, ScrollEventArgs e)
        {
            lblBreakTime.Text = hScrollBarBreakTime.Value + " minutes";
            lblBreakTime.Visible = true;
        }

        private void SetUpScrollBars()
        {
            hScrollBarFocusTime.Minimum = 0;
            hScrollBarFocusTime.Maximum = 124;
            hScrollBarFocusTime.SmallChange = 1;
            hScrollBarFocusTime.LargeChange = 5;

            hScrollBarBreakTime.Minimum = 0;
            hScrollBarBreakTime.Maximum = 124;
            hScrollBarBreakTime.SmallChange = 1;
            hScrollBarBreakTime.LargeChange = 5;
        }

        private string GetSeconds(int durationInSeconds) => (durationInSeconds % 60).ToString("00");
        //{
        //    int seconds = focusDurationInSeconds % 60;

        //    return seconds.ToString("00");

        //    //return seconds > 10 
        //    //    ? seconds.ToString() 
        //    //    : "0" + seconds;
        //}



        private string GetMinutes(int durationInSeconds)
        {
            int minutes;
            int hours = Convert.ToInt32(GetHours(durationInSeconds));

            if (durationInSeconds % 3600 <= 1)
            {
                minutes = durationInSeconds / 60;
                return minutes.ToString("00");
            }

            else
            {
                minutes = durationInSeconds / 60 - hours * 60;
                return minutes.ToString("00");
            }

        }

        private string GetHours(int durationInSeconds)
        {
            int hours = durationInSeconds / 3600;
            return hours.ToString("00");
        }

        private void SetRunningModeOff(bool runningModeOff)
        {
            btnStart.Enabled = runningModeOff;
            btnStop.Enabled = !runningModeOff;

            lblFocusMessage.Visible = !runningModeOff;
            lblBreakMessage.Visible = !runningModeOff;

            hScrollBarFocusTime.Enabled = runningModeOff;
            hScrollBarBreakTime.Enabled = runningModeOff;

            if (runningModeOff)
            {
                lblCounter.Text = "00:00:00";
                backgroundWorker1.ReportProgress(0);

                hScrollBarFocusTime.Value = 0;
                hScrollBarBreakTime.Value = 0;
            }
        }

        private async void SetWarningMessage()
        {
            lblWarnings.Visible = true;
            await Task.Delay(5000);
            lblWarnings.Visible = false;

        }


    }
}
