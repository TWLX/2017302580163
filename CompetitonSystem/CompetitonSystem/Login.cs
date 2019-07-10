using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetitonSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        OdbcConnection odbcCon;
        OdbcCommand odbcCommand;
        OdbcDataAdapter odbcAdapter;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ConStr = "DSN=ws;UID=sa;PWD=root";
                string str = "SELECT * FROM 代表队 " +
                              "WHERE 账号 = '" + textBox1.Text + "' AND 密码 = '" + textBox2.Text + "'";

                odbcCon = new OdbcConnection(ConStr);
                odbcCon.Open();
                odbcCommand = new OdbcCommand();
                odbcCommand.Connection = odbcCon;
                odbcCommand.CommandText = str;
                odbcAdapter = new OdbcDataAdapter(odbcCommand);

                DataSet dataSet = new DataSet();
                odbcAdapter.Fill(dataSet);

                int n = dataSet.Tables[0].Rows.Count;

                if (n == 1)
                {
                    TeamInfo team = new TeamInfo();
                    team.Show();
                }
                else
                {
                    MessageBox.Show("登陆失败！" + "\n" + "身份信息有误，请审核修改后再次登陆");
                }
            }
            catch (OdbcException ee)
            {
                Debug.WriteLine(ee.Message);
            }
            finally
            {
                odbcCon.Close();
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
