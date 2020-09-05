using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
            lblScore.Visible = false;
            lblHigh.Visible = false;
            RESTART.Visible = false;
            HS.Visible = false;
            TEKRARBASLA();
       




        }

       
        

        void gameover()
        {
            int Score = score;
            int HighS = Convert.ToInt32(HS.Text);


            if (Score > HighS)
            {
                HighS = Score;

                HS.Text = HighS.ToString();


           }
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {


                timer1.Enabled = false;
                over.Visible = true;
                lblScore.Visible = true;
                lblHigh.Visible = true;
                HS.Visible = true;
                RESTART.Visible = true;

            }

            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {


                timer1.Enabled = false;
                over.Visible = true;
                lblScore.Visible = true;
                lblHigh.Visible = true;
                HS.Visible = true;
                RESTART.Visible = true;


            }

            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {


                timer1.Enabled = false;
                over.Visible = true;
                lblScore.Visible = true;
                lblHigh.Visible = true;
                HS.Visible = true;
                RESTART.Visible = true;

            }



        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            coinscollection();
            

        }
           
        void moveline(int speed)
        {
            

            if (pictureBox1.Top >= 500)
            { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }

        }




        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(c1.Bounds))
            {

                collectedcoin++;
                score++;
                lblScore.Text = "Score=" + score.ToString();
                lblHigh.Text = "High Score" + enbuyuk.ToString();
                label1.Text = "Coins="+collectedcoin.ToString();
                x = r.Next(0, 200);
                c1.Location = new Point(x, 0);

            }
            if (car.Bounds.IntersectsWith(c2.Bounds))
            {

                collectedcoin++;
                score++;
                lblScore.Text = "Score=" + score.ToString();
                lblHigh.Text = "High Score" + enbuyuk.ToString();
                label1.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(0, 200);
                c2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(c3.Bounds))
            {

                collectedcoin++;
                score++;
                lblScore.Text = "Score=" + score.ToString();
                lblHigh.Text = "High Score" + enbuyuk.ToString();
                label1.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(0, 200);
                c3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(c4.Bounds))
            {

                collectedcoin++;
                score++;
                lblScore.Text = "Score=" + score.ToString();
                lblHigh.Text ="High Score" + enbuyuk.ToString();
                label1.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(0, 200);
                c4.Location = new Point(x, 0);
            }

        }

        int enbuyuk;
        int score = 0; 
        int collectedcoin = 0;
        int x;
        Random r = new Random();
        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0, 200);
                enemy1.Location = new Point(x, 2);

            }
            else { enemy1.Top += speed; }

            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 400);
                enemy2.Location = new Point(x, 5);

            }
            else { enemy2.Top += speed; }

            if (enemy3.Top >= 500)
            {
                x = r.Next(200, 350);
                enemy3.Location = new Point(x, 60);

            }
            else { enemy3.Top += speed; }



        }


        int gamespeed = 0;
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Bİ EVENT NEDEN BELLİ Bİ EVENTTEN SONRA DEVRE DIŞI KALIR
            
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 0)
                    car.Left += -8;


            }

            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 370)
                    car.Left += 8;

            }

            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }

            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }

            }

        }

        private void over_Click(object sender, EventArgs e)
        {

        }
        
        void coins(int speed)
        {


            if (c1.Top >= 500)
            {
                x = r.Next(0, 200);
                c1.Location = new Point(x, 0);

            }
            else { c1.Top += speed; }

            if (c2.Top >= 500)
            {
                x = r.Next(0, 200);
                c2.Location = new Point(x, 0);

            }
            else { c2.Top += speed; }


            if (c3.Top >= 500)
            {
                x = r.Next(50, 300);
                c3.Location = new Point(x, 0);

            }
            else { c3.Top += speed; }


            if (c4.Top >= 500)
            {
                x = r.Next(0,400);
                c4.Location = new Point(x, 0);

            }
            else { c4.Top += speed; }
        }

      
         
        private void TEKRARBASLA()
        {

            over.Visible = false;
            lblScore.Visible = false;
            lblHigh.Visible =false;
            HS.Visible = false;
            RESTART.Visible = false;

            gamespeed = 1;
            score = 0;
        
            enemy1.Location = new Point(12 , 41);
            enemy2.Location = new Point(183 , 44);
            enemy3.Location = new Point(297 , 41);
         
        }

        private void RESTART_Click(object sender, EventArgs e)
        {
            
            TEKRARBASLA();
            
            timer1.Enabled = true;
                    
           
              
        }
    }
}
