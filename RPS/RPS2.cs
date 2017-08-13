using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RPS
{
    public partial class RPS2 : Form
    {
        public Boolean win,draw,lose;
        public static int count=0;
        public static int score = 0;
        public static string S = " ";
        public RPS2()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.timer1.Start();
            button1.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            Random R = new Random();
            int i = R.Next(1, 4);

            int k = R.Next(4, 7);
            
            
                if (i == 1)
                {
                    pictureBox1.Show();
                    pictureBox2.Hide();
                    pictureBox3.Hide();
                    pictureBox4.Hide();
                    pictureBox5.Hide();
                    pictureBox6.Hide();
                    if (k == 4)
                    {
                        draw = true;
                        pictureBox2.Hide();
                        pictureBox3.Hide();
                        pictureBox4.Show();
                        pictureBox5.Hide();
                        pictureBox6.Hide();

                    }
                    if (k == 5)
                    {

                        lose = true;
                        pictureBox2.Hide();
                        pictureBox3.Hide();
                        pictureBox4.Hide();
                        pictureBox5.Show();
                        pictureBox6.Hide();
                    }
                    if (k == 6)
                    {

                        win = true;
                        pictureBox2.Hide();
                        pictureBox3.Hide();
                        pictureBox4.Hide();
                        pictureBox5.Hide();
                        pictureBox6.Show();
                    }

                }
                if (i == 2)
                {
                    pictureBox1.Hide();
                    pictureBox2.Show();
                    pictureBox3.Hide();
                    pictureBox4.Hide();
                    pictureBox5.Hide();
                    pictureBox6.Hide();
                    if (k == 4)
                    {
                        win = true;

                        pictureBox3.Hide();
                        pictureBox4.Show();
                        pictureBox5.Hide();
                        pictureBox6.Hide();

                    }
                    if (k == 5)
                    {

                        draw = true;

                        pictureBox3.Hide();
                        pictureBox4.Hide();
                        pictureBox5.Show();
                        pictureBox6.Hide();
                    }
                    if (k == 6)
                    {

                        lose = true;

                        pictureBox3.Hide();
                        pictureBox4.Hide();
                        pictureBox5.Hide();
                        pictureBox6.Show();
                    }

                }
                if (i == 3)
                {
                    pictureBox1.Hide();
                    pictureBox2.Hide();
                    pictureBox3.Show();
                    pictureBox4.Hide();
                    pictureBox5.Hide();
                    pictureBox6.Hide();
                    if (k == 4)
                    {
                        lose = true;
                        pictureBox2.Hide();

                        pictureBox4.Show();
                        pictureBox5.Hide();
                        pictureBox6.Hide();

                    }
                    if (k == 5)
                    {

                        win = true;
                        pictureBox2.Hide();

                        pictureBox4.Hide();
                        pictureBox5.Show();
                        pictureBox6.Hide();
                    }
                    if (k == 6)
                    {

                        draw = true;
                        pictureBox2.Hide();

                        pictureBox4.Hide();
                        pictureBox5.Hide();
                        pictureBox6.Show();
                    }

                }
                if (count == 6)
                {
                    this.timer1.Stop();
                    this.Hide();
                    Final F = new Final();
                    S = score + " ";
                    F.Show();
                }
            }
        

        private void RPS2_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            label1.Text = Main.S;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (win == true)
                score++;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (draw == true)
                score++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lose == true)
                score++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
