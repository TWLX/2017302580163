using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.Odbc;

namespace CompetitonSystem
{
    public partial class athleteDetail : Form
    {
        //DSN:数据源的名称 UID:sql server登录时的身份sa PWD:登录时的密码root
        //生成连接数据库字符串
        static string ConStr = "DSN=ws;UID=sa;PWD=root";
        //定义SqlConnection对象实例
        OdbcConnection odbcCon = new OdbcConnection(ConStr);

        public athleteDetail()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string info = FindText.Text;
                string SqlStr = "select * from 运动员 where 编号 = " + info;

                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter(SqlStr, odbcCon); //使用Adapter，配置查询语句，并打开连接

                DataSet ds = new DataSet(); //实例化一个新的ds

                odbcAdapter.Fill(ds); //将查询结果放入到ds中

                odbcCon.Close(); //关闭连接

                Sname.Text = ds.Tables[0].Rows[0]["姓名"].ToString();
                Ssex.Text = ds.Tables[0].Rows[0]["性别"].ToString();
                Snum.Text = ds.Tables[0].Rows[0]["编号"].ToString();
                SID.Text = ds.Tables[0].Rows[0]["身份证"].ToString();
                Sgrade.Text = ds.Tables[0].Rows[0]["成绩"].ToString();
                Sgroup.Text = ds.Tables[0].Rows[0]["组别"].ToString();
                SWHgrade.Text = ds.Tables[0].Rows[0]["文化成绩"].ToString();
                Sage.Text = ds.Tables[0].Rows[0]["年龄"].ToString();

                MessageBox.Show("查询成功！");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odbcCon.Open();  //使用command要先open
            try
            {
                string SqlStr = "insert into 运动员(编号,身份证,年龄,性别,组别,姓名,文化成绩,成绩) values('"+Snum.Text+"','"+SID.Text
                    + "','" + Sage.Text + "','" + Ssex.Text + "','" + Sgroup.Text + "','" + Sname.Text + "','" + SWHgrade.Text + "','" + Sgrade.Text + "')";

                OdbcCommand odbcCom = new OdbcCommand(SqlStr, odbcCon);  //使用command，配置SQL和连接字符串

                int status = odbcCom.ExecuteNonQuery(); //执行，返回状态
                MessageBox.Show("执行结果：" + status);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            odbcCon.Close(); //关闭连接
        }
    }
}
