using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetitonSystem
{
    public partial class TeamInfo : Form
    {
        public TeamInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            athleteInfo sp = new athleteInfo();
            sp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coach coach = new coach();
            coach.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sportTable sTable = new sportTable();
            sTable.Show();
        }
    }
}
