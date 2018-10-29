using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databinding
{
    public partial class Form1 : Form
    {
        OrderService os = new OrderService();
        public string KeyWord { get; set; }

        public static Form1 form1;

        public Form1(){
            InitializeComponent();
            form1 = this;

            os.Orders.Add(new Order("企业", 1, 20,"轰炸机"));
            os.Orders.Add(new Order("光辉", 2, 19,"鱼雷机"));
            os.Orders.Add(new Order("胜利", 3, 19, "防空炮"));
            orderBindingSource.DataSource = os.Orders;
            //绑定查询条件
            queryInput.DataBindings.Add("Text", this, "KeyWord");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = 
                os.Orders.Where(s => s.Name == KeyWord);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            add add = new add();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            orderBindingSource.MoveFirst();
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
           
        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
