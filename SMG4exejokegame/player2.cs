using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMG4exejokegame
{
    public partial class player2 : Form
    {
        private Timer waitTimer;           // 4-minute wait timer
        private Timer countdownTimer;      // 10-second countdown timer
        private Timer animationTimer;      // Animation timer
        private int countdownSeconds = 10;
        private int animationFrame = 0;
        public player2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nyet");
        }

        private void player2_Load(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            // Play looping sound from resources
            SoundPlayer player = new SoundPlayer(Properties.Resources.troll_laugh);
            player.PlayLooping();

            // Start 4-minute wait timer
            timer1 = new Timer();
            timer1.Interval = 60000; // 1 minute
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Stop the wait timer after 4 minutes
            timer1.Stop();

            // Stop the looping sound after 4 minutes
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.cracks3);
            SoundPlayer player = new SoundPlayer(Properties.Resources.troll_laugh);
            player.Stop();
            player2.PlayLooping();

            // Start the 10-second countdown
            StartCountdown();
        }

        private void StartCountdown()
        {
            timer2 = new Timer();
            timer2.Interval = 1000; // 1 second
            timer2.Tick += timer2_Tick;
            timer2.Start();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //nothing
        }

        private void StartAnimatio2()
        {
            pictureBox4.Visible = true;
            timer3 = new Timer();
            timer3.Interval = 100; // 100ms per frame
            timer3.Tick += timer3_Tick;
            timer3.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (countdownSeconds > 0)
            {
                label1.Text = $"Countdown: {countdownSeconds}"; // Show countdown in label
                countdownSeconds--;
            }
            else
            {
                timer2.Stop();
                SoundPlayer player2 = new SoundPlayer();
                // To stop the sound correctly, use Stop()
                player2.Stop();
                StartAnimatio2(); // Start animation after countdown
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            animationFrame++;

            // Change the image to create animation effect
            switch (animationFrame % 4)
            {
                case 0:
                    pictureBox4.Image = Properties.Resources.framehand1;
                    break;
                case 1:
                    pictureBox4.Image = Properties.Resources.framehand2;
                    break;
                case 2:
                    pictureBox4.Image = Properties.Resources.framehand22;
                    break;
                case 3:
                    pictureBox4.Image = Properties.Resources.framehand4;
                    break;
            }

            // Stop animation after 4 seconds (40 frames)
            if (animationFrame > 0.4)
            {
                timer3.Stop();

                // Play end sound after animation
                PlayEndSound();
                OpenNextForm();
            }
        }

        private void PlayEndSound()
        {
            // Play the end sound from resources
            SoundPlayer endPlayer = new SoundPlayer(Properties.Resources.cracks2);
            endPlayer.Play();
        }

        private void OpenNextForm()
        {
            // Hide or close current form
            this.Hide();  // Use this.Close(); if you want to close it completely

            // Open player3 (next form)
            beep f3 = new beep();
            f3.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //nothing
        }
    }
}
