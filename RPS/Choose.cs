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
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RULE1 R = new RULE1();
            this.Hide();
            R.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RULE2 R = new RULE2();
            this.Hide();
            R.Show();
        }
    }
}
