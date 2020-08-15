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

        public PomodoroForm()
        {
            InitializeComponent();
        }

        private void PomodoroForm_Load(object sender, EventArgs e)
        {
            SetUpScrollBars();
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }

            focusDurationInSeconds = hScrollBarFocusTime.Value * 60;


            timer1.Enabled = true;

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (focusDurationInSeconds > 0)
            {
                focusDurationInSeconds--;            

                lblCounter.Text = GetHours() + ":" + GetMinutes() + ":" + GetSeconds();

            }
            else
            {
                timer1.Stop();
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;

            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                timer1.Stop();
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int sum = 0;
            
            int totalSeconds = hScrollBarFocusTime.Value * 60;

            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(totalSeconds * 1000 / 100);

                sum += i;

                backgroundWorker1.ReportProgress(i);   //ReportProgress method raises the ProgressChanged event automatically

                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }

            e.Result = sum;
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            //lblWarnings.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblWarnings.Text = "You cancelled the activity";
                lblWarnings.Visible = true;
            }
            else if (e.Error != null)
            {
                lblWarnings.Text = e.Error.Message;
                lblWarnings.Visible = true;

            }
            else
            {
                btnStart.Enabled = true;
                //lblTime.Text = e.Result.ToString();
            }
        }


        private void HScrollBarFocusTime_Scroll(object sender, ScrollEventArgs e)
        {
            lblFocusTime.Text = hScrollBarFocusTime.Value + " minutes";
            lblFocusTime.Visible = true;
        }
        private void HScrollBarBreakTime_Scroll(object sender, ScrollEventArgs e)
        {
            lblBreakTime.Text = hScrollBarFocusTime.Value + " minutes";
            lblBreakTime.Visible = true;
        }



        private void SetUpScrollBars()
        {
            hScrollBarFocusTime.Minimum = 0;
            hScrollBarFocusTime.Maximum = 124;
            hScrollBarFocusTime.SmallChange = 1;
            hScrollBarFocusTime.LargeChange = 5;
        }

        private string GetSeconds() => (focusDurationInSeconds % 60).ToString("00");
        //{
        //    int seconds = focusDurationInSeconds % 60;

        //    return seconds.ToString("00");

        //    //return seconds > 10 
        //    //    ? seconds.ToString() 
        //    //    : "0" + seconds;
        //}



        private string GetMinutes()
        {
            int minutes;
            int hours = Convert.ToInt32(GetHours());

            if (focusDurationInSeconds % 3600 <= 1)
            {
                minutes = focusDurationInSeconds / 60;
                return minutes.ToString("00");
            }

            else
            {
                minutes = focusDurationInSeconds / 60 - hours * 60;
                return minutes.ToString("00");
            }
            
        }

        private string GetHours()
        {
            int hours = focusDurationInSeconds / 3600;
            return hours.ToString("00");
        }
    }
}
