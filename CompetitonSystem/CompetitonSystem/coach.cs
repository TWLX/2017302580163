using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetitonSystem
{
    public partial class coach : Form
    {
        static string ConStr = "DSN=ws;UID=sa;PWD=root";
        //定义SqlConnection对象实例
        OdbcConnection odbcCon = new OdbcConnection(ConStr);
        public coach()
        {
            InitializeComponent();
        }

        private void coach_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“赛事管理系统DataSet.教练员”中。您可以根据需要移动或删除它。
            this.教练员TableAdapter.Fill(this.赛事管理系统DataSet.教练员);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
            if (MessageBox.Show("确认是否删除？", "警告：操作需谨慎。本条资料一旦删除将不可恢复！", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            string p_no = Convert.ToString(dataGridView1.CurrentRow.Cells[0]);
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            //使用获得的p_no删除数据库的数据
            string SQL = "delete from 教练员 where 编号=" + p_no;
            odbcCon.Open();
            OdbcCommand odbcCom = new OdbcCommand(SQL, odbcCon);
            odbcCon.Close();
            updateData();//删除后刷新datagridview
        }
        public void updateData()
        {
            this.教练员TableAdapter.Update(this.赛事管理系统DataSet.教练员);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateData();
        }
    }
}
