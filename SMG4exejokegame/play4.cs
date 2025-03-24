using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMG4exejokegame
{
    public partial class play4 : Form
    {
                private SoundPlayer player;
        private bool isLooping = false;
        public play4()
        {
            InitializeComponent();
            // Initialize the SoundPlayer with the sound file from resources
            player = new SoundPlayer(Properties.Resources.troll_laugh);
        }

        private void PlayLoopingSound()
        {
            isLooping = true;
            player.PlayLooping();
        }

        private void StopLoopingSound()
        {
            isLooping = false;
            player.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StopLoopingSound();
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void play4_Load(object sender, EventArgs e)
        {
            PlayLoopingSound();
        }
    }
}
