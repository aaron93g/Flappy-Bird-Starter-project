using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdStarter
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 10;
        int gravity = 10;
        int score = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            lowerPipe.Left -= pipeSpeed;
            upperPipe.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if(lowerPipe.Right < 0)
            {
                lowerPipe.Left = 900;
                score++;
            }
            if(upperPipe.Right < 0)
            {
                upperPipe.Left = 860;
                score++;
            }

            if(flappyBird.Bounds.IntersectsWith(lowerPipe.Bounds) || 
                flappyBird.Bounds.IntersectsWith(upperPipe.Bounds) || 
                flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game over!!";
        }
    }
}
