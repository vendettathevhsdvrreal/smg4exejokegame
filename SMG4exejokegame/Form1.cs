using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace SMG4exejokegame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int currentValue = 20; // You can change this value based on your needs

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Play a sound
            PlayClickSound();

            // Change image based on the value of currentValue
            switch (currentValue)
            {
                case 20:
                    pictureBox1.Image = Properties.Resources.smg422;  // Replace with your image resource
                    break;
                case 30:
                    pictureBox1.Image = Properties.Resources.smg4222;  // Replace with your image resource
                    break;
                case 40:
                    pictureBox1.Image = Properties.Resources.smg42222;  // Replace with your image resource
                    break;
                case 50:
                    pictureBox1.Image = Properties.Resources.test;  // Replace with your image resource
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.Show();
                    break;
                default:
                    pictureBox1.Image = Properties.Resources.smg42;  // Default image
                    break;
            }

            currentValue += 10;  // Increment currentValue to simulate change (you can change this logic if needed)
            if (currentValue > 50) currentValue = 20;  // Reset the value to 20 if it goes beyond 50 (optional)
        }

        private void PlayClickSound()
        {
            // Load and play the sound (replace "click_sound.wav" with the name of your sound file)
            SoundPlayer player = new SoundPlayer(Properties.Resources.click);  // Use your sound resource here
            player.Play();  // Play the sound asynchronously
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //nothing
        }
    }
}
