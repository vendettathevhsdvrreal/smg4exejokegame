using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Windows.Forms;

namespace SMG4exejokegame
{
    public partial class beep : Form
    {
        public beep()
        {
            InitializeComponent();
        }

        private void MakeFullScreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void PlayEndSound()
        {
            // Play the end sound from resources
            SoundPlayer endPlayer = new SoundPlayer(Properties.Resources.beeping);
            endPlayer.PlaySync();
            Application.Exit(); // Closes the application
        }

        private void beep_Load(object sender, EventArgs e)
        {
            MakeFullScreen();
            PlayEndSound();
        }
    }
}
