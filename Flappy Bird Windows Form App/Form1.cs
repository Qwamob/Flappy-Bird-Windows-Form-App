using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form_App
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pipeBot_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            pipeBot.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;           

            if(pipeBot.Left < -150)
            {
                pipeBot.Left = 800;
                score++;
            }

            if(pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }

            if(Bird.Bounds.IntersectsWith(pipeBot.Bounds) ||
                Bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                Bird.Bounds.IntersectsWith(ground.Bounds) //|| Bird.Top < -25
                )
            {
                endGame();
            }

            if (score > 15)
            {
                pipeSpeed = 20;
            }
            else if (score > 10)
            {
                pipeSpeed = 16;
            }
            else if (score > 5)
            {
                pipeSpeed = 12;
            }

        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game Over!!!";
        }
    }
}
