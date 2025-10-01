using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FlappyBird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 10;
        int scoure = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer(object sender, EventArgs e)
        {
            bird.Top += gravity;
            alt.Left -= pipeSpeed;
            üst.Left -= pipeSpeed;
            label1.Text = "SCORE:" + scoure;

            if (alt.Left < -150)
            {
                alt.Left = 800;
                scoure++;
            }

            if (üst.Left < -180)
            {
                üst.Left = 950;
                scoure++;
            }

            if (bird.Bounds.IntersectsWith(alt.Bounds) ||
                bird.Bounds.IntersectsWith(üst.Bounds) ||
                bird.Bounds.IntersectsWith(zemin.Bounds) || bird.Top < -25)
            {
                endGame();
            }
        }

        public void endGame()
        {
            timer1.Stop();
            label1.Text = "GAME OVER !!!";
        }

        private void game_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void game_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
    }
}
