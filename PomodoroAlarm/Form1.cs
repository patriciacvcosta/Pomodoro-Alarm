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
using System.Media;

namespace PomodoroAlarm
{
    public partial class PomodoroForm : Form
    {
        int focusDurationInSeconds;
        int breakDurationInSeconds;

        bool alarmIsRinging;
        bool dragWindow = false;

        public PomodoroForm()
        {
            InitializeComponent();
        }
        private void PomodoroForm_Load(object sender, EventArgs e)
        {
            SetUpScrollBars();
            SetRunningModeOff(true);
            alarmIsRinging = false;

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

                SetRunningModeOff(false);

            }
            else
            {
                lblWarnings.Text = "The time is still running for another activity...";
                SetWarningMessage();
            }

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (alarmIsRinging)
            {
                return;
            }
            if (focusDurationInSeconds > 0)
            {
                focusDurationInSeconds--;
                lblCounter.Text = GetMinutes(focusDurationInSeconds) + ":" + GetSeconds(focusDurationInSeconds);
                lblFocusMessage.Visible = true;
                lblBreakMessage.Visible = false;

            }
            else if (breakDurationInSeconds > 0)
            {
                breakDurationInSeconds--;
                lblCounter.Text = GetMinutes(breakDurationInSeconds) + ":" + GetSeconds(breakDurationInSeconds);
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

                SetRunningModeOff(true);
                lblFocusMessage.Visible = false;
                lblBreakMessage.Visible = false;

                lblWarnings.Text = "You cancelled the activity...";
                SetWarningMessage();

            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnExit_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Close", btnExit);
        }
        private void BtnMaximizeOrNormalize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                CenterToScreen();
            }
        }
        private void BtnMaximizeOrNormalize_MouseHover(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                toolTip1.Show("Restore Down", btnMaximizeOrNormalize);
            }
            else
            {
                toolTip1.Show("Maximize", btnMaximizeOrNormalize);
            }
        }
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
        private void BtnMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Minimize", btnMinimize);
        }
        private void PomodoroForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragWindow = true;
        }
        private void PomodoroForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragWindow == true)
            {
                Location = Cursor.Position;

            }
        }
        private void PomodoroForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragWindow = false;

        }
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int totalFocusSeconds = hScrollBarFocusTime.Value * 60;
            int totalBreakSeconds = hScrollBarBreakTime.Value * 60;

            if (focusDurationInSeconds > 0)
            {
                RunProgressBar(e, totalFocusSeconds);

            }

            if (breakDurationInSeconds > 0)
            {
                RunProgressBar(e, totalBreakSeconds);

            }

            backgroundWorker1.ReportProgress(0);
        }
        /// <summary>
        /// The progress bar must go from 1% until 100% completion. It will run as a for loop from 1 to 100, and this number goes to the 
        /// backgroungworker.progress, to report progress and fill up the bar. But, the bar cannot be filled on every second, otherwise it will be 
        /// completed before the actual duration of the task, which can go up to 2 hours. To manage that, we need to use a Thread.Sleep method, to 
        /// hold the status of the progress bar proportionally to the task actual duration. To do that, we have a nested for loop and it will run
        /// from 0 until "miliseconds", which represents 1% of progress on the taskbar. Also, for each %, it will check if there has been a 
        /// cancellation at any point.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="totalSeconds"></param>
        private void RunProgressBar(DoWorkEventArgs e, int totalSeconds)
        {
            for (int i = 1; i <= 100; i++)
            {
                backgroundWorker1.ReportProgress(i);   //ReportProgress method raises the ProgressChanged event automatically

                // How many miliseconds represents 1% of the progress bar (so the progress bar will be filled proportionaly to the task duration. 
                // However, the thread.sleep method has a delay to start and to stop. So, I divided the miliseconds by 2 to compensate that delay
                // that will occur everytime the code goes into the for loop.
                //
                //
                var milisecondsPerPercentage = (totalSeconds + 1) * 1000 / 100 / 2;

                for (int p = 1; p <= milisecondsPerPercentage; p++)
                {
                    if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker1.ReportProgress(0);
                        return;
                    }

                    Thread.Sleep(1);
                }
            }

            RingTheAlarm();
        }
        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                lblWarnings.Text = e.Error.Message;
                SetWarningMessage();

            }
            else if (!e.Cancelled)
            {
                SetRunningModeOff(true);
            }
        }
        private void HScrollBarFocusTime_Scroll(object sender, ScrollEventArgs e)
        {
            lblFocusTime.Text = hScrollBarFocusTime.Value + " minutes";
        }
        private void HScrollBarBreakTime_Scroll(object sender, ScrollEventArgs e)
        {
            lblBreakTime.Text = hScrollBarBreakTime.Value + " minutes";
        }
        private void SetUpScrollBars()
        {
            hScrollBarFocusTime.Value = 25;
            hScrollBarFocusTime.Minimum = 0;
            hScrollBarFocusTime.Maximum = 64;
            hScrollBarFocusTime.SmallChange = 1;
            hScrollBarFocusTime.LargeChange = 5;
            lblFocusTime.Text = hScrollBarFocusTime.Value + " minutes";

            hScrollBarBreakTime.Value = 5;
            hScrollBarBreakTime.Minimum = 0;
            hScrollBarBreakTime.Maximum = 64;
            hScrollBarBreakTime.SmallChange = 1;
            hScrollBarBreakTime.LargeChange = 5;
            lblBreakTime.Text = hScrollBarBreakTime.Value + " minutes";

        }
        /// <summary>
        /// The rest of the modulus operation of the duration in seconds by 60 will give us the number of seconds to output.
        /// Because, when calculating the modulus by 60, we will know if there is any integer rest on the division, and that is the number of seconds.
        /// 120 seconds divided by 60 has a modulus of 0. After one second, it will check 119 % 60, which is 59. I.e, the rest of the modulus operation
        /// is the number of seconds that must be shown.
        /// </summary>
        /// <param name="durationInSeconds"></param>
        /// <returns></returns>
        private string GetSeconds(int durationInSeconds) => (durationInSeconds % 60).ToString("00");
        //{
        //    int seconds = focusDurationInSeconds % 60;

        //    return seconds.ToString("00");

        //    //return seconds > 10 
        //    //    ? seconds.ToString() 
        //    //    : "0" + seconds;
        //}
        /// <summary>
        /// Converts the totalSeconds that does not compound the hours into minutes. First, it will check if the modulus of the totalSeconds per 3600
        /// is less or equal to 1. If it is, it means that there are no rest in the division of totalSeconds/3600, which means that there are not
        /// enough seconds to complete one or more hours OR the number of hours is 1 (3600 sec / 3600 sec <= 1).
        /// Else, means that the modulus is greater than 1, which means that we have 1 or more hours for the task. We have to subtract the number of
        /// seconds from the hours and transform the rest to minutes (multiply the rest by 60).
        /// 
        /// </summary>
        /// <param name="durationInSeconds"></param>
        /// <returns></returns>
        private string GetMinutes(int durationInSeconds)
        {
            int minutes;
            int hours = durationInSeconds / 3600;

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
        private void SetRunningModeOff(bool runningModeOff)
        {
            btnStart.Enabled = runningModeOff;
            btnStop.Enabled = !runningModeOff;

            hScrollBarFocusTime.Enabled = runningModeOff;
            hScrollBarBreakTime.Enabled = runningModeOff;

            if (runningModeOff)
            {
                lblCounter.Text = "00:00";
            }
        }
        private async void SetWarningMessage()
        {
            lblWarnings.Visible = true;
            await Task.Delay(2000);
            lblWarnings.Visible = false;

        }
        /// <summary>
        /// This function creates a SoundPlayer object and uses it to ring a sound located in a specific folder. It will loop the sound for 7seconds
        /// and stop after that. Since it's a thread.sleep, it stops the running code.
        /// It sets the boolean alarmIsRinging to true in order to make the timer tick event to stop while the alarm is ringing.
        /// After the alarm stops, the alarmIsRinging variable is set to false, which will allow the timer to resume.
        /// </summary>
        private void RingTheAlarm()
        {
            try
            {
                alarmIsRinging = true;
                SoundPlayer player = new SoundPlayer(PomodoroAlarm.Properties.Resources.Alarm10);
                player.PlayLooping();
                Thread.Sleep(7000);
                player.Stop();
                alarmIsRinging = false;
            }
            catch
            {
                return;
            }
        }

    }
}
