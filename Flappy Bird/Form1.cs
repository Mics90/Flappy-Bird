using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void FlappyBird_Load(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 1000;
                score++;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 1150;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                    flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                    flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25)
            {
                endGame();
            }


            if(score > 5)
            {
                pipeSpeed = 15;
            }
            if (score > 20)
            {
                pipeSpeed = 25;
            }
            if (score > 30)
            {
                pipeSpeed = 45;
            }
            if (score > 50)
            {
                pipeSpeed = 65;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += "  Game over!!!";
            restartGame.Visible = true;
            
            exit.Visible = true;
        }

         

       

        private void restartTheGame(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitTheGame(object sender, EventArgs e)
        {
            // Close the game window
            Application.Exit();
        }
    }
}
