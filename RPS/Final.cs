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
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Final_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Violet;
           if((RPS.S).Equals(" "))
            label3.Text = RPS2.S;
           else
            label3.Text = RPS.S;
            
            timer1.Enabled = true;
            timer1.Start();
            
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
                if (this.BackColor == Color.Violet)
                    this.BackColor = Color.DarkBlue;
                else if (this.BackColor == Color.DarkBlue)
                    this.BackColor = Color.DarkGoldenrod;
                else if (this.BackColor == Color.DarkGoldenrod)
                    this.BackColor = Color.HotPink;
                else if (this.BackColor == Color.HotPink)
                    this.BackColor = Color.LavenderBlush;
                else
                    if (this.BackColor == Color.LavenderBlush)
                    this.BackColor = Color.DarkBlue;
                else if (this.BackColor == Color.DarkBlue)
                    this.BackColor = Color.DarkGoldenrod;
                else if (this.BackColor == Color.DarkGoldenrod)
                    this.BackColor = Color.HotPink;
                else if (this.BackColor == Color.HotPink)
                    this.BackColor = Color.LavenderBlush;
                    else if (this.BackColor == Color.LavenderBlush)
                    this.BackColor = Color.DarkBlue;
                else if (this.BackColor == Color.DarkBlue)
                    this.BackColor = Color.DarkGoldenrod;
                else if (this.BackColor == Color.DarkGoldenrod)
                    this.BackColor = Color.HotPink;
                else if (this.BackColor == Color.HotPink)
                    this.BackColor = Color.LavenderBlush;
                    else if (this.BackColor == Color.LavenderBlush)
                    this.BackColor = Color.DarkBlue;
                else if (this.BackColor == Color.DarkBlue)
                    this.BackColor = Color.DarkGoldenrod;
                else if (this.BackColor == Color.DarkGoldenrod)
                    this.BackColor = Color.HotPink;
                else if (this.BackColor == Color.HotPink)
                    this.BackColor = Color.LavenderBlush;
                    else if (this.BackColor == Color.LavenderBlush)
                    this.BackColor = Color.DarkBlue;
                else if (this.BackColor == Color.DarkBlue)
                    this.BackColor = Color.DarkGoldenrod;
                else if (this.BackColor == Color.DarkGoldenrod)
                    this.BackColor = Color.HotPink;
                else if (this.BackColor == Color.HotPink)
                    this.BackColor = Color.LavenderBlush;
            
            
        }
    }
}
