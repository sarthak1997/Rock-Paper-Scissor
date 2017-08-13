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
    public partial class RPS : Form
    {
        public static int count = 2;
        public static int score = 0;
        public static string S = " ";
        public RPS()
        {
            InitializeComponent();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label1.Text = Main.S;
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            userradioButton1.Checked = false;
            userradioButton2.Checked = false;
            userradioButton3.Checked = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            comradioButton4.Checked = false;
            comradioButton5.Checked = false;
            comradioButton6.Checked = false;
        }

        private void userradioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void userradioButton2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void userradioButton3_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count <= 6)
            {
                if (userradioButton1.Checked)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    Random R1 = new Random();
                    int i = R1.Next(1, 4);
                    if (i == 1)
                    {


                        pictureBox2.Visible = true;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                        pictureBox5.Visible = false;
                        pictureBox6.Visible = false;
                        comradioButton4.Checked = true;

                        label4.Text = "DRAW";
                    }
                    else if (i == 2)
                    {

                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                        pictureBox5.Visible = true;
                        pictureBox6.Visible = false;
                        comradioButton5.Checked = true;


                        label4.Text = "YOU LOSE";
                        score = score + 1;
                    }
                    else
                    {

                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                        pictureBox5.Visible = false;
                        pictureBox6.Visible = true;
                        comradioButton6.Checked = true;
                        label4.Text = "YOU WIN THIS TIME";

                    }
                    count = count + 1;
                }
                if (userradioButton2.Checked)
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    Random R2 = new Random();
                    int i = R2.Next(1, 4);
                    if (i == 1)
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = true;

                        pictureBox4.Visible = false;
                        pictureBox5.Visible = false;
                        pictureBox6.Visible = false;
                        comradioButton4.Checked = true;

                        label4.Text = "YOU WIN THIS TIME"; score = score + 1;
                    }
                    else if (i == 2)
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;

                        pictureBox4.Visible = false;
                        pictureBox5.Visible = true;
                        pictureBox6.Visible = false;
                        comradioButton5.Checked = true;
                        label4.Text = "DRAW";
                    }
                    else
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;

                        pictureBox4.Visible = false;
                        pictureBox5.Visible = false;
                        pictureBox6.Visible = true;
                        comradioButton6.Checked = true;
                        label4.Text = "YOU LOSE";
                    }
                    count = count + 1;
                }
                if (userradioButton3.Checked)
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    Random R3 = new Random();
                    int i = R3.Next(1, 4);
                    if (i == 1)
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = false;

                        pictureBox5.Visible = false;
                        pictureBox6.Visible = false;
                        comradioButton4.Checked = true;
                        label4.Text = "YOU LOSE";
                    }
                    else if (i == 2)
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;

                        pictureBox5.Visible = true;
                        pictureBox6.Visible = false;
                        comradioButton5.Checked = true;

                        label4.Text = "YOU WIN THIS TIME"; score = score + 1;
                    }
                    else
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;

                        pictureBox5.Visible = false;
                        pictureBox6.Visible = true;

                        comradioButton6.Checked = true;
                        label4.Text = "DRAW";
                    }
                    count = count + 1;
                }
            }
            else
            {
                Final F = new Final();
                S = score + " ";
                
                F.Show();
                this.Hide();
            }
            

        }
    }
}
