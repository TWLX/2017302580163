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
    public partial class athleteInfo : Form
    {
        public athleteInfo()
        {
            InitializeComponent();
        }

        private void SportmanTable_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“赛事管理系统DataSet.运动员”中。您可以根据需要移动或删除它。
            this.运动员TableAdapter.Fill(this.赛事管理系统DataSet.运动员);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            athleteDetail info = new athleteDetail();
            info.Show(); 
        }
    }
}
