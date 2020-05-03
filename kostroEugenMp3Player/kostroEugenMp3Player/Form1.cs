using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kostroEugenMp3Player
{
    public partial class Form1 : Form
    {
        private mp3Player Mp3player = new mp3Player();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3 ";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Mp3player.open(ofd.FileName);
                }
            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Mp3player.play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Mp3player.stop();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
