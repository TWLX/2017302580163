using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace newClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int clockHour = Convert.ToInt32(hour.Text);
            int clockMinute = Convert.ToInt32(minute.Text);
            label3.Text = DateTime.Now.ToLongTimeString();
            if (DateTime.Now.Hour == clockHour && DateTime.Now.Minute == clockMinute)
            {
                label4.Text = "时间到！！！";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
