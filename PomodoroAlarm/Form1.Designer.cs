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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundedButton1 = new PomodoroAlarm.RoundedButton();
            this.roundedButton2 = new PomodoroAlarm.RoundedButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownFocusDurationHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRestDurationHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownActivityDurationMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRestDurationMinutes)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.lblWarnings.ForeColor = System.Drawing.Color.White;
            this.lblWarnings.Location = new System.Drawing.Point(229, 175);
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
            this.progressBar.Location = new System.Drawing.Point(30, 12);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(517, 42);
            this.label7.TabIndex = 15;
            this.label7.Text = "Set your Focus and Break sessions";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-2, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 61);
            this.panel1.TabIndex = 16;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BorderColor = System.Drawing.Color.PowderBlue;
            this.roundedButton1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.Location = new System.Drawing.Point(30, 403);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.roundedButton1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.roundedButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundedButton1.Size = new System.Drawing.Size(118, 64);
            this.roundedButton1.TabIndex = 17;
            this.roundedButton1.Text = "START";
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            this.roundedButton1.UseVisualStyleBackColor = true;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BorderColor = System.Drawing.Color.PowderBlue;
            this.roundedButton2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton2.Location = new System.Drawing.Point(343, 417);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.roundedButton2.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.roundedButton2.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundedButton2.Size = new System.Drawing.Size(118, 64);
            this.roundedButton2.TabIndex = 18;
            this.roundedButton2.Text = "STOP";
            this.roundedButton2.TextColor = System.Drawing.Color.White;
            this.roundedButton2.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(176, 410);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(79, 57);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnStop.FlatAppearance.BorderSize = 3;
            this.btnStop.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(271, 410);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(79, 57);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // PomodoroForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(551, 493);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numUpDownRestDurationMinutes);
            this.Controls.Add(this.numUpDownActivityDurationMinutes);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblWarnings);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numUpDownRestDurationHours);
            this.Controls.Add(this.numUpDownFocusDurationHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "PomodoroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro Alarm";
            this.Load += new System.EventHandler(this.PomodoroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownFocusDurationHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRestDurationHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownActivityDurationMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRestDurationMinutes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
    }
}

