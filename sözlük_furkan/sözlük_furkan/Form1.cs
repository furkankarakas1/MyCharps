using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sözlük_furkan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            StreamWriter ing = File.AppendText("ingilicce.txt");
            StreamWriter tr = File.AppendText("anlam.txt");

            ing.WriteLine(textBox1.Text);
            tr.WriteLine(textBox2.Text);


            ing.Close();
            tr.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamReader ing = new StreamReader("ingilicce.txt");
            StreamReader tr = new StreamReader("anlam.txt");



            int sayı_index = 0;
            string yazı = "";


            while ((yazı=ing.ReadLine()) != null)
            {

                if (yazı==textBox1.Text)
                {
                    break;

                }
                sayı_index++;

            }

            int i = 0;
            string anlamı = "";
            

            while((anlamı=tr.ReadLine())!=null)
            {


                if (i==sayı_index)
                {


                    textBox2.Text = anlamı;


                    break;


                }

                i++;

            }
            ing.Close();
            tr.Close();


        }
    }
}
