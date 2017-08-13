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
    public partial class RULE2 : Form
    {
        public RULE2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RPS2 R = new RPS2();
            this.Hide();
            R.Show();
        }
    }
}
