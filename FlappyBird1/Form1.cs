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
        int pipeSpeed = 10;
        int gravity = 10;
       

        bool gameOver = false;
        public Form1()
        {
            InitializeComponent();
            pictureBoxGround.Controls.Add(label1);
            label1.Left = 20;
            label1.Top = 25;

            RestartGame();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            playerBox.Text = GameUtils.UserName;
        }
        private void gameTimer(object sender, EventArgs e)
        {

            pictureBoxBird.Top += gravity;
            pictureBoxBottom.Left -= pipeSpeed;
            pictureBoxTop.Left -= pipeSpeed;
            label1.Text = "SCORE: " + GameUtils.Score;

            if (pictureBoxBottom.Left < -150)
            {
                pictureBoxBottom.Left = 800;
                GameUtils.Score++;
            }
            if (pictureBoxTop.Left < -180)
            {
                pictureBoxTop.Left = 950;
                GameUtils.Score++;
            }
            if (pictureBoxBird.Bounds.IntersectsWith(pictureBoxBottom.Bounds) ||
                pictureBoxBird.Bounds.IntersectsWith(pictureBoxTop.Bounds) ||
                pictureBoxBird.Bounds.IntersectsWith(pictureBoxGround.Bounds) || pictureBoxBird.Top < -25)
            {
                EndGame();
            }

            if (GameUtils.Score == 10)
            {
                pipeSpeed = 15;
            }

        }
        public void EndGame()
        {
            timerGameControl.Stop();
            label1.Text = "GAME OVER!  Press R to Restart";
            gameOver = true;
            pictureBoxRestart.Enabled = true;
            pictureBoxRestart.Visible = true;
        }

        private void gameDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }

            if (e.KeyCode == Keys.R && gameOver)
            {
                RestartGame();
            }
        }

        private void gameUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        private void RestartGame()
        {
            gameOver = false;
            pictureBoxBird.Location = new Point(89, 62);
            pictureBoxTop.Left = 800;
            pictureBoxBottom.Left = 1200;

            GameUtils.Score = 0;
            pipeSpeed = 10;

            label1.Text = "SCORE: 0 ";
            pictureBoxRestart.Enabled = false;
            pictureBoxRestart.Visible = false;
            timerGameControl.Start();
         

        }

        private void RestartClickEvent(object sender, EventArgs e)
        {
            RestartGame();
        }

    }
}