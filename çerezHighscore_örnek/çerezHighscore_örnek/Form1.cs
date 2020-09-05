using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace çerezHighscore_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int score = 0;
        int hscore= 0;

        
        private void button1_Click(object sender, EventArgs e)
        {
            score++;

            hscore = int.Parse(HİGHSCORE.Text);




            SCORE.Text = score.ToString();

            if (score > hscore)
            {
                hscore = score;

                HİGHSCORE.Text = hscore.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            score = 0;

            SCORE.Text = score.ToString();

        }
    }
}
