namespace PomodoroAlarm
{
    partial class PomodoroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numUpDownFocusDurationHours = new System.Windows.Forms.NumericUpDown();
            this.numUpDownRestDurationHours = new System.Windows.Forms.NumericUpDown();
            this.lblWarnings = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.numUpDownActivityDurationMinutes = new System.Windows.Forms.NumericUpDown();
            this.numUpDownRestDurationMinutes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStop = new PomodoroAlarm.RoundedButton();
            this.btnStart = new PomodoroAlarm.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownFocusDurationHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRestDurationHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownActivityDurationMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRestDurationMinutes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Focus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(138, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Break:";
            // 
            // numUpDownFocusDurationHours
            // 
            this.numUpDownFocusDurationHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownFocusDurationHours.Location = new System.Drawing.Point(233, 284);
            this.numUpDownFocusDurationHours.Name = "numUpDownFocusDurationHours";
            this.numUpDownFocusDurationHours.Size = new System.Drawing.Size(65, 32);
            this.numUpDownFocusDurationHours.TabIndex = 1;
            this.numUpDownFocusDurationHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numUpDownRestDurationHours
            // 
            this.numUpDownRestDurationHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownRestDurationHours.Location = new System.Drawing.Point(233, 341);
            this.numUpDownRestDurationHours.Name = "numUpDownRestDurationHours";
            this.numUpDownRestDurationHours.Size = new System.Drawing.Size(65, 32);
            this.numUpDownRestDurationHours.TabIndex = 2;
            this.numUpDownRestDurationHours.Tag = "";
            this.numUpDownRestDurationHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWarnings
            // 
            this.lblWarnings.AutoSize = true;
            this.lblWarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblWarnings.Location = new System.Drawing.Point(110, 174);
            this.lblWarnings.Name = "lblWarnings";
            this.lblWarnings.Size = new System.Drawing.Size(90, 24);
            this.lblWarnings.TabIndex = 6;
            this.lblWarnings.Text = "Warnings";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(29, 134);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(334, 37);
            this.progressBar.TabIndex = 7;
            // 
            // numUpDownActivityDurationMinutes
            // 
            this.numUpDownActivityDurationMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownActivityDurationMinutes.Location = new System.Drawing.Point(321, 284);
            this.numUpDownActivityDurationMinutes.Name = "numUpDownActivityDurationMinutes";
            this.numUpDownActivityDurationMinutes.Size = new System.Drawing.Size(65, 32);
            this.numUpDownActivityDurationMinutes.TabIndex = 9;
            this.numUpDownActivityDurationMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numUpDownRestDurationMinutes
            // 
            this.numUpDownRestDurationMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownRestDurationMinutes.Location = new System.Drawing.Point(321, 341);
            this.numUpDownRestDurationMinutes.Name = "numUpDownRestDurationMinutes";
            this.numUpDownRestDurationMinutes.Size = new System.Drawing.Size(65, 32);
            this.numUpDownRestDurationMinutes.TabIndex = 10;
            this.numUpDownRestDurationMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(300, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(389, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(388, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(300, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "h";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblCounter.Font = new System.Drawing.Font("Agency FB", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.White;
            this.lblCounter.Location = new System.Drawing.Point(414, 131);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(114, 42);
            this.lblCounter.TabIndex = 20;
            this.lblCounter.Text = "00:00:00";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(520, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 35);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(-3, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 74);
            this.panel2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bauhaus 93", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(94, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(361, 53);
            this.label8.TabIndex = 22;
            this.label8.Text = "Focus Timer App";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(517, 42);
            this.label7.TabIndex = 15;
            this.label7.Text = "Set your Focus and Break sessions";
            // 
            // btnStop
            // 
            this.btnStop.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnStop.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(304, 417);
            this.btnStop.Name = "btnStop";
            this.btnStop.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnStop.OnHoverButtonColor = System.Drawing.Color.White;
            this.btnStop.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnStop.Size = new System.Drawing.Size(118, 64);
            this.btnStop.TabIndex = 18;
            this.btnStop.Text = "STOP";
            this.btnStop.TextColor = System.Drawing.Color.White;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnStart.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(144, 417);
            this.btnStart.Name = "btnStart";
            this.btnStart.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnStart.OnHoverButtonColor = System.Drawing.Color.White;
            this.btnStart.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnStart.Size = new System.Drawing.Size(118, 64);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "START";
            this.btnStart.TextColor = System.Drawing.Color.White;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // PomodoroForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(551, 493);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numUpDownRestDurationMinutes);
            this.Controls.Add(this.numUpDownActivityDurationMinutes);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblWarnings);
            this.Controls.Add(this.numUpDownRestDurationHours);
            this.Controls.Add(this.numUpDownFocusDurationHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PomodoroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro Alarm";
            this.Load += new System.EventHandler(this.PomodoroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownFocusDurationHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRestDurationHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownActivityDurationMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRestDurationMinutes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpDownFocusDurationHours;
        private System.Windows.Forms.NumericUpDown numUpDownRestDurationHours;
        private System.Windows.Forms.Label lblWarnings;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.NumericUpDown numUpDownActivityDurationMinutes;
        private System.Windows.Forms.NumericUpDown numUpDownRestDurationMinutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private RoundedButton btnStop;
        private RoundedButton btnStart;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

