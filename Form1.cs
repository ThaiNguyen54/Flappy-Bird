using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Game
{
    public partial class FlappyBirdForm : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;


        public FlappyBirdForm()
        {
            InitializeComponent();
            Load_Corlor();
            
            
        }
        private void Load_Corlor()
        {
            this.BackColor = System.Drawing.Color.Aqua;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            TheFlappyBird.Top += gravity; //TheFlappyBird.Top = TheFlappyBird.Top + gravity
            TopPipe.Left -= pipeSpeed; //TopPipe.Left = TopPipe.Left - pipeSpeed
            BottomPipe.Left -= pipeSpeed; //Bottompipe.Left = Bottompipe.Left - pipeSpeed
            Score.Text = "Score: " + Convert.ToString(score);
            if(BottomPipe.Left < -50)
            {
                BottomPipe.Left = 800;
                score++;
            }
            if (TopPipe.Left < -80)
            {
                TopPipe.Left = 950;
                score++;
            }

            if(TheFlappyBird.Bounds.IntersectsWith(BottomPipe.Bounds) ||
               TheFlappyBird.Bounds.IntersectsWith(TopPipe.Bounds) ||
               TheFlappyBird.Bounds.IntersectsWith(Ground.Bounds)
               ) 
                   
            {
                GameOver();
            }

            if(score > 5)
            {
                pipeSpeed = 15;
            }

            if(score>10)
            {
                pipeSpeed = 20;
            }
            
            if(TheFlappyBird.Top < -25)
            {
                GameOver();
            }


        }

        private void KeyisdownEvent(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void KeyisupEvent(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
         
        private void GameOver()
        {
            gameTimer.Stop();
            Score.Text += " Game over!!!!";
        }
    }
}
