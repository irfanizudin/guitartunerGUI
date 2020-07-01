using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuGauge1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;      //jika button start ditekan maka timer akan aktif
            button2.Enabled = true;     //jika button start ditekan maka button stop akan enable
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;     //jika button stop ditekan maka timer akan mati
            button2.Enabled = false;    //jika button stop ditekan maka button stop akan disable
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                //mic level
                Random rnd = new Random();              //membuat fungsi random
                int random = rnd.Next(100);             //random angka 1 sampai 100
                bunifuProgressBar1.Value = random;      //hasil random ditampilkan pada progress bar
                bunifuGauge1.Value = random;            //hasil random ditampilkan pada gauge meter

                if (random >= 90)   //pengondisian random untuk mengubah warna progress bar.
                {
                    bunifuProgressBar1.ProgressColor = Color.Red;   //jika nilai random lebih besar atau sama dengan 90 maka warna progress bar menjadi merah
                }
                else
                {
                    bunifuProgressBar1.ProgressColor = Color.Teal;  //jika tidak maka warna progress bar menjadi teal
                }
            
                //frequency
                double[] freq = new double[] { 261.6, 277.2, 293.7, 311.1, 329.6, 349.2, 370.0, 392.0, 415.3, 440.0, 466.2, 493.9, 523.3, 659.2 };  //membuat array frequency nada
                Random rand = new Random();         //membuat fungsi random
                double rando = freq[rand.Next(14)]; //mememasukkan array ke fungsi random
                lbDigitalMeter1.Value = rando;      //menampilkan hasil random pada digitalmeter

                if (rando == 329.6)     //pengondisian random. jika nilai random sama dengan frequency yang ditentukan maka warna panel akan berubah menjadi merah
                {
                    panel3.BackColor = Color.Red;
                }
                else if (rando == 440.0)
                {
                    panel4.BackColor = Color.Red;
                }
                else if (rando == 293.7)
                {
                    panel1.BackColor = Color.Red;
                }
                else if (rando == 392.0)
                {
                    panel2.BackColor = Color.Red;
                }
                else if (rando == 493.9)
                {
                    panel5.BackColor = Color.Red;
                }
                else if (rando == 659.2)
                {
                    panel6.BackColor = Color.Red;
                }
                else
                {
                    panel1.BackColor = Color.LightGray;     //jika tidak warna panel akan berubah menjadi lightgray
                    panel2.BackColor = Color.LightGray;
                    panel3.BackColor = Color.LightGray;
                    panel4.BackColor = Color.LightGray;
                    panel5.BackColor = Color.LightGray;
                    panel6.BackColor = Color.LightGray;
                }


        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }
    }
}
