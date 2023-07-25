using System.Collections.Generic;
using System.Media;
// Created by Muhammad Elsoukkary
// Date created June 1st 2023


namespace BasicTimerApp
{
    public partial class Form1 : Form
    {
        private bool isRed = true;
        private Color originalBackColor;
        public Form1()
        {
            InitializeComponent();
            // stores backround color
            originalBackColor = this.BackColor;
        }


        // This tick event handler is called every tick, i.e. whenever
        // th timer fires a tick based on its Interval property setting
        private void secondsTimer_Tick(object sender, EventArgs e)
        {
            SetCurrentSecond();

            // checks if the alarm box was checked and the date and time equal what the user inputted 
            // note that in the code I do not force the user to input the seconds too as it is too much and only allows the program to run the music and colors for 1 second 


            if (checkBoxAlarmActive.Checked && alarmTimeBox.Text == DateTime.Now.ToString("h:mm:tt"))
            {
                // First creating a sound player:
                SoundPlayer alarmPlayer = new SoundPlayer();

                // Set the Location prop to where the sound file is:
                alarmPlayer.SoundLocation = @"C:\Windows\Media\Alarm04.wav";

                // play it:
                //alarmPlayer.Play();

                // Or...
                alarmPlayer.PlayLooping();



                AlarmTimer.Start();

            }
            // handles when the box is unchecked
            else
            {
                // First creating a sound player:
                SoundPlayer alarmPlayer = new SoundPlayer();

                // Set the Location prop to where the sound file is:
                alarmPlayer.SoundLocation = @"C:\Windows\Media\Alarm04.wav";

                // play it:
                //alarmPlayer.Play();

                // Or...
                alarmPlayer.Stop();
                AlarmTimer.Stop();


                BackColor = originalBackColor;

            }

        }

        // A private helper method that we call from both the tick handler
        // and the Form Load event handler
        private void SetCurrentSecond()
        {
            // Get the current time:
            DateTime now = DateTime.Now;

            // Get the second from the current time:
            int currentSecond = now.Second;

            // changes clock to 24 date time

            if (clockChange.Checked)
            {
                lblStarttTime.Text = $"{now:H:mm:ss}";
            }
            else
            {
                lblStarttTime.Text = $"{now:h:mm:ss tt}";
            }


            // Display that in the textbox:
            txtCurrentSecond.Text = currentSecond.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // We'll start the timer as the form loads:
            ClockTimer.Start();


            // Use the current to set the time label:
            DateTime now = DateTime.Now;

            lblStarttTime.Text = $"{now:h:mm:ss tt}";


        }

        private void btnPlayAlarm_Click(object sender, EventArgs e)
        {
            // First creating a sound player:
            SoundPlayer alarmPlayer = new SoundPlayer();

            // Set the Location prop to where the sound file is:
            alarmPlayer.SoundLocation = @"C:\Windows\Media\Alarm04.wav";

            // play it:
            //alarmPlayer.Play();

            // Or...
            alarmPlayer.PlayLooping();
        }

        // This event handler is called whenever the check status changes on the checkbox:
        private void checkBoxAlarmActive_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void clockChange_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {

            // stops the timer and the music and reverts the backround color back to its orginail color 
            AlarmTimer.Stop();

            // First creating a sound player:
            SoundPlayer alarmPlayer = new SoundPlayer();

            // Set the Location prop to where the sound file is:
            alarmPlayer.SoundLocation = @"C:\Windows\Media\Alarm04.wav";

            // play it:
            //alarmPlayer.Play();

            // Or...
            alarmPlayer.Stop();

            BackColor = originalBackColor;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStarttTime_Click(object sender, EventArgs e)
        {

        }

        private void AlarmTimer_Tick(object sender, EventArgs e)
        {
            // swtiches the colors every second 
            if (isRed)
                this.BackColor = Color.Green;
            else
                this.BackColor = Color.Red;

            isRed = !isRed;
        }
    }
}