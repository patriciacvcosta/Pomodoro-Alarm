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

namespace PomodoroAlarm
{
    public partial class PomodoroForm : Form
    {
        public PomodoroForm()
        {
            InitializeComponent();
        }

        private void PomodoroForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }


        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int sum = 0;

            var focusDuration = (numUpDownFocusDurationHours.Value * 3600) + (numUpDownActivityDurationMinutes.Value * 60);
            
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(Convert.ToInt32(focusDuration) * 10);

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
            }
            else if (e.Error != null)
            {
                lblWarnings.Text = e.Error.Message;
            }
            else
            {
                //lblTime.Text = e.Result.ToString();
            }
        }

    }
}
