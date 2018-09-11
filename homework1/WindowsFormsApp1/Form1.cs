using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = text1.Text;
            double d1 = double.Parse(s1);
            string s2 = text1.Text;
            double d2 = double.Parse(s2);
            double sq = d1 * d2;
            label1.Text = d1 + "和" + d2 + "的积:" + sq;
        }
    }
}
