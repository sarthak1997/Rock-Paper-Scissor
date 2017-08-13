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
    public partial class Main : Form
    {
        public static string S;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Choose C = new Choose();
            this.Hide();
           
            C.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            S = textBox1.Text;
        }
    }
}
