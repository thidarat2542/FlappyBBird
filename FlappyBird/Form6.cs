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
   
    public partial class Form6 : Form
    {
        bool jumping = false;
        int pipeSpeed = 5;
        int gravity = 5;
        int Inscore = 0;

        public Form6()
        {
            InitializeComponent();
            endText1.Text = "Game Over!";
            endText2.Text = "Your final score is : " + scoreText.Text;
            gameDesigner.Text = "Game Designed By your name here";
            endText1.Visible = false;
            endText2.Visible = false;
            gameDesigner.Visible = false;
            

        }
       
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            FlappyBird.Top += gravity;
            scoreText.Text = "score : " + Inscore;
            endText2.Text = "Your final score is : " + scoreText.Text;
            



            if (pipeBottom.Left < -80)
                {
                    pipeBottom.Left = 1000;
                    Inscore += 1;
                }
         else if (pipeTop.Left < -95)
                {
                    pipeTop.Left = 1100;
                    Inscore += 1;
                }
         if (FlappyBird.Bounds.IntersectsWith(ground.Bounds))
                {
                    endGame();
                }
         else if (FlappyBird.Bounds.IntersectsWith(pipeBottom.Bounds))
                {
                    endGame();
                }
         else if (FlappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                endGame();

            }
            


        } 
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void pipeBottom_Click(object sender, EventArgs e)
        {
        
        
        }
        private void GameKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
               
                jumping = true;
                gravity = -5;
            }
            if (e.KeyCode == Keys.Enter)
            {
                Application.Restart();
                Environment.Exit(0);
            }
           
        }
        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Space)
            {
               
                jumping = false;
                gravity = 5;
            }
            if (e.KeyCode == Keys.Enter)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }
        private void endGame()
        {
            gameTimer.Stop(); 
            endText1.Visible = true;
            endText2.Visible = true;
            gameDesigner.Visible = true;
        }

        private void ground_Click(object sender, EventArgs e)
        {

        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }
    }
}
