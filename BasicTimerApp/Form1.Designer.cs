namespace BasicTimerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblCurrentSecond = new Label();
            txtCurrentSecond = new TextBox();
            ClockTimer = new System.Windows.Forms.Timer(components);
            btnPlayAlarm = new Button();
            lblStarttTime = new Label();
            checkBoxAlarmActive = new CheckBox();
            clockChange = new CheckBox();
            alarmTimeBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            AlarmTimer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            SuspendLayout();
            // 
            // lblCurrentSecond
            // 
            lblCurrentSecond.AutoSize = true;
            lblCurrentSecond.Location = new Point(132, 336);
            lblCurrentSecond.Margin = new Padding(4, 0, 4, 0);
            lblCurrentSecond.Name = "lblCurrentSecond";
            lblCurrentSecond.Size = new Size(136, 25);
            lblCurrentSecond.TabIndex = 0;
            lblCurrentSecond.Text = "Current second:";
            // 
            // txtCurrentSecond
            // 
            txtCurrentSecond.Enabled = false;
            txtCurrentSecond.Location = new Point(276, 336);
            txtCurrentSecond.Margin = new Padding(4, 5, 4, 5);
            txtCurrentSecond.Name = "txtCurrentSecond";
            txtCurrentSecond.Size = new Size(68, 31);
            txtCurrentSecond.TabIndex = 1;
            // 
            // ClockTimer
            // 
            ClockTimer.Interval = 1000;
            ClockTimer.Tick += secondsTimer_Tick;
            // 
            // btnPlayAlarm
            // 
            btnPlayAlarm.Location = new Point(671, 332);
            btnPlayAlarm.Margin = new Padding(4, 5, 4, 5);
            btnPlayAlarm.Name = "btnPlayAlarm";
            btnPlayAlarm.Size = new Size(107, 38);
            btnPlayAlarm.TabIndex = 2;
            btnPlayAlarm.Text = "Play alarm";
            btnPlayAlarm.UseVisualStyleBackColor = true;
            btnPlayAlarm.Click += btnPlayAlarm_Click;
            // 
            // lblStarttTime
            // 
            lblStarttTime.AutoSize = true;
            lblStarttTime.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.Point);
            lblStarttTime.Location = new Point(93, 32);
            lblStarttTime.Margin = new Padding(4, 0, 4, 0);
            lblStarttTime.Name = "lblStarttTime";
            lblStarttTime.Size = new Size(653, 133);
            lblStarttTime.TabIndex = 3;
            lblStarttTime.Text = "10:33:15 AM";
            lblStarttTime.Click += lblStarttTime_Click;
            // 
            // checkBoxAlarmActive
            // 
            checkBoxAlarmActive.AutoSize = true;
            checkBoxAlarmActive.Location = new Point(425, 338);
            checkBoxAlarmActive.Margin = new Padding(4, 5, 4, 5);
            checkBoxAlarmActive.Name = "checkBoxAlarmActive";
            checkBoxAlarmActive.Size = new Size(158, 29);
            checkBoxAlarmActive.TabIndex = 4;
            checkBoxAlarmActive.Text = "Is alarm active?";
            checkBoxAlarmActive.UseVisualStyleBackColor = true;
            checkBoxAlarmActive.CheckedChanged += checkBoxAlarmActive_CheckedChanged;
            // 
            // clockChange
            // 
            clockChange.AutoSize = true;
            clockChange.Location = new Point(132, 183);
            clockChange.Margin = new Padding(4, 5, 4, 5);
            clockChange.Name = "clockChange";
            clockChange.Size = new Size(179, 29);
            clockChange.TabIndex = 5;
            clockChange.Text = "Use 24 hour clock";
            clockChange.UseVisualStyleBackColor = true;
            clockChange.CheckedChanged += clockChange_CheckedChanged;
            // 
            // alarmTimeBox
            // 
            alarmTimeBox.Location = new Point(276, 264);
            alarmTimeBox.Name = "alarmTimeBox";
            alarmTimeBox.Size = new Size(150, 31);
            alarmTimeBox.TabIndex = 6;
            alarmTimeBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 267);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 7;
            label1.Text = "Alarm time:";
            // 
            // button1
            // 
            button1.Location = new Point(671, 240);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 8;
            button1.Text = "Stop alarm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AlarmTimer
            // 
            AlarmTimer.Interval = 1000;
            AlarmTimer.Tick += AlarmTimer_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Location = new Point(262, 470);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(258, 25);
            label2.TabIndex = 9;
            label2.Text = "Place holder for error message:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1181, 627);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(alarmTimeBox);
            Controls.Add(clockChange);
            Controls.Add(checkBoxAlarmActive);
            Controls.Add(lblStarttTime);
            Controls.Add(btnPlayAlarm);
            Controls.Add(txtCurrentSecond);
            Controls.Add(lblCurrentSecond);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Timer App";
            Load += button1_Click;
            DoubleClick += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentSecond;
        private TextBox txtCurrentSecond;
        private System.Windows.Forms.Timer ClockTimer;
        private Button btnPlayAlarm;
        private Label lblStarttTime;
        private CheckBox checkBoxAlarmActive;
        private CheckBox clockChange;
        private TextBox alarmTimeBox;
        private Label label1;
        private Button button1;
        private System.Windows.Forms.Timer AlarmTimer;
        private Label label2;
    }
}