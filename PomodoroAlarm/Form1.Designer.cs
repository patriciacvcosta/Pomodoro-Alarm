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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMaximizeOrNormalize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hScrollBarFocusTime = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBreakTime = new System.Windows.Forms.HScrollBar();
            this.lblFocusTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBreakTime = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.lblFocusMessage = new System.Windows.Forms.Label();
            this.lblWarnings = new System.Windows.Forms.Label();
            this.lblBreakMessage = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnStop = new PomodoroAlarm.RoundedButton();
            this.btnStart = new PomodoroAlarm.RoundedButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Focus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Break:";
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
            this.progressBar.Location = new System.Drawing.Point(24, 147);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(334, 37);
            this.progressBar.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(522, -3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 32);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            this.btnExit.MouseHover += new System.EventHandler(this.BtnExit_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnMaximizeOrNormalize);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 74);
            this.panel2.TabIndex = 17;
            // 
            // btnMaximizeOrNormalize
            // 
            this.btnMaximizeOrNormalize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizeOrNormalize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizeOrNormalize.FlatAppearance.BorderSize = 0;
            this.btnMaximizeOrNormalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizeOrNormalize.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizeOrNormalize.ForeColor = System.Drawing.Color.White;
            this.btnMaximizeOrNormalize.Location = new System.Drawing.Point(488, -3);
            this.btnMaximizeOrNormalize.Name = "btnMaximizeOrNormalize";
            this.btnMaximizeOrNormalize.Size = new System.Drawing.Size(27, 32);
            this.btnMaximizeOrNormalize.TabIndex = 24;
            this.btnMaximizeOrNormalize.Text = "🗖";
            this.btnMaximizeOrNormalize.UseVisualStyleBackColor = false;
            this.btnMaximizeOrNormalize.Click += new System.EventHandler(this.BtnMaximizeOrNormalize_Click);
            this.btnMaximizeOrNormalize.MouseHover += new System.EventHandler(this.BtnMaximizeOrNormalize_MouseHover);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(454, -16);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(27, 45);
            this.btnMinimize.TabIndex = 23;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            this.btnMinimize.MouseHover += new System.EventHandler(this.BtnMinimize_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bauhaus 93", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(116, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(349, 53);
            this.label8.TabIndex = 22;
            this.label8.Text = "FocusTimer App";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(529, 37);
            this.label7.TabIndex = 15;
            this.label7.Text = "Set your Focus and Break sessions";
            // 
            // hScrollBarFocusTime
            // 
            this.hScrollBarFocusTime.Location = new System.Drawing.Point(279, 282);
            this.hScrollBarFocusTime.Name = "hScrollBarFocusTime";
            this.hScrollBarFocusTime.Size = new System.Drawing.Size(220, 27);
            this.hScrollBarFocusTime.TabIndex = 21;
            this.hScrollBarFocusTime.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBarFocusTime_Scroll);
            // 
            // hScrollBarBreakTime
            // 
            this.hScrollBarBreakTime.Location = new System.Drawing.Point(279, 355);
            this.hScrollBarBreakTime.Name = "hScrollBarBreakTime";
            this.hScrollBarBreakTime.Size = new System.Drawing.Size(220, 27);
            this.hScrollBarBreakTime.TabIndex = 22;
            this.hScrollBarBreakTime.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBarBreakTime_Scroll);
            // 
            // lblFocusTime
            // 
            this.lblFocusTime.AutoSize = true;
            this.lblFocusTime.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFocusTime.ForeColor = System.Drawing.Color.White;
            this.lblFocusTime.Location = new System.Drawing.Point(138, 284);
            this.lblFocusTime.Name = "lblFocusTime";
            this.lblFocusTime.Size = new System.Drawing.Size(20, 23);
            this.lblFocusTime.TabIndex = 23;
            this.lblFocusTime.Text = "x";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblBreakTime
            // 
            this.lblBreakTime.AutoSize = true;
            this.lblBreakTime.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakTime.ForeColor = System.Drawing.Color.White;
            this.lblBreakTime.Location = new System.Drawing.Point(138, 357);
            this.lblBreakTime.Name = "lblBreakTime";
            this.lblBreakTime.Size = new System.Drawing.Size(20, 23);
            this.lblBreakTime.TabIndex = 26;
            this.lblBreakTime.Text = "x";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblCounter.Font = new System.Drawing.Font("Agency FB", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.White;
            this.lblCounter.Location = new System.Drawing.Point(409, 144);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(114, 42);
            this.lblCounter.TabIndex = 27;
            this.lblCounter.Text = "00:00:00";
            // 
            // lblFocusMessage
            // 
            this.lblFocusMessage.AutoSize = true;
            this.lblFocusMessage.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFocusMessage.ForeColor = System.Drawing.Color.White;
            this.lblFocusMessage.Location = new System.Drawing.Point(179, 87);
            this.lblFocusMessage.Name = "lblFocusMessage";
            this.lblFocusMessage.Size = new System.Drawing.Size(184, 28);
            this.lblFocusMessage.TabIndex = 28;
            this.lblFocusMessage.Text = "It\'s Focus Time!";
            this.lblFocusMessage.Visible = false;
            // 
            // lblWarnings
            // 
            this.lblWarnings.AutoSize = true;
            this.lblWarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnings.ForeColor = System.Drawing.Color.White;
            this.lblWarnings.Location = new System.Drawing.Point(20, 185);
            this.lblWarnings.Name = "lblWarnings";
            this.lblWarnings.Size = new System.Drawing.Size(86, 22);
            this.lblWarnings.TabIndex = 6;
            this.lblWarnings.Text = "Warnings";
            this.lblWarnings.Visible = false;
            // 
            // lblBreakMessage
            // 
            this.lblBreakMessage.AutoSize = true;
            this.lblBreakMessage.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakMessage.ForeColor = System.Drawing.Color.White;
            this.lblBreakMessage.Location = new System.Drawing.Point(121, 87);
            this.lblBreakMessage.Name = "lblBreakMessage";
            this.lblBreakMessage.Size = new System.Drawing.Size(308, 28);
            this.lblBreakMessage.TabIndex = 29;
            this.lblBreakMessage.Text = "Good job! It\'s Break Time!";
            this.lblBreakMessage.Visible = false;
            // 
            // btnStop
            // 
            this.btnStop.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnStop.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Controls.Add(this.lblBreakMessage);
            this.Controls.Add(this.lblFocusMessage);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lblBreakTime);
            this.Controls.Add(this.lblFocusTime);
            this.Controls.Add(this.hScrollBarBreakTime);
            this.Controls.Add(this.hScrollBarFocusTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblWarnings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PomodoroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro Alarm";
            this.Load += new System.EventHandler(this.PomodoroForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PomodoroForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PomodoroForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PomodoroForm_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar;
        private RoundedButton btnStop;
        private RoundedButton btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.HScrollBar hScrollBarFocusTime;
        private System.Windows.Forms.HScrollBar hScrollBarBreakTime;
        private System.Windows.Forms.Label lblFocusTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBreakTime;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label lblFocusMessage;
        private System.Windows.Forms.Label lblWarnings;
        private System.Windows.Forms.Label lblBreakMessage;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximizeOrNormalize;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

