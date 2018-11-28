using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

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

            //os.Orders.Add(new Order("ymd001", 1, 20,"轰炸机"));
            //os.Orders.Add(new Order("", 2, 19,"鱼雷机"));
            //os.Orders.Add(new Order("4396", 3, 19, "防空炮"));

            orderBindingSource.DataSource = os.GetAllOrders();

            //orderBindingSource.DataSource = os.Orders;

            //绑定查询条件
            queryInput.DataBindings.Add("Text", this, "KeyWord");


            //序列化为xml文件
            //os.Export(os.Orders);

            //XSLT转换XML
            //XmlDocument doc = new XmlDocument();
            //doc.Load(@".\serialiable.xml");

            //XslCompiledTransform xc = new XslCompiledTransform();
            //xc.Load(@".\serialiable.xslt");

            //xc.Transform(@".\serialiable.xml","out.html");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            queryOrder();
            //switch (comboBox1.Text)
            //{
            //    case "Name":
            //        orderBindingSource.DataSource = os.Orders.Where(s => s.Name == KeyWord);
            //        break;
            //    case "Good":
            //        orderBindingSource.DataSource = os.Orders.Where(s => s.Good == KeyWord);
            //        break;
            //    case "ID":
            //        orderBindingSource.DataSource = os.Orders.Where(s => s.ID == KeyWord);
            //        break;
            //    case "Num":
            //        int m = Convert.ToInt16(KeyWord);
            //        orderBindingSource.DataSource = os.Orders.Where(s => s.Num == m);
            //        break;
            //}
            
        }
    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            add add = new add();
            add.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            orderBindingSource.MoveFirst();
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            if (orderBindingSource.Current != null)
            {
                Order order = (Order)orderBindingSource.Current;
                os.Delete(order.ID);
                queryOrder();
            }
            else
            {
                MessageBox.Show("No Order is selected!");
            }

            //Delete delete = new Delete();
            //delete.ShowDialog();

        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string rx = "ymd[0-9]{3}";
            string fId = "";
            foreach (var o in os.Orders)
            {
                
                bool ok = Regex.IsMatch(o.Name,rx);
                if(ok == false || o.Name == null)
                {
                    string id = o.ID.ToString();
                    fId += id;
                    fId += " ";
                }
            }
            label4.Text = fId;
        }

        private void queryOrder()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    String text = queryInput.Text;
                    orderBindingSource.DataSource =
                      os.GetOrder(text);
                    break;
                case 2:
                    orderBindingSource.DataSource =
                      os.QueryByGoods(queryInput.Text);
                    break;
                default:
                    orderBindingSource.DataSource = os.GetAllOrders();
                    break;
            }
            orderBindingSource.ResetBindings(false);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool flag = true;//假设不重复
            string repeat = "重复的订单序号为：";
            for(int i = 0;i < os.Orders.Count;i++)
            {
                for(int j = i+1;j < os.Orders.Count;j++)
                {
                    if(os.Orders[i].Name == os.Orders[j].Name)
                    {
                        flag = false;
                        repeat += os.Orders[i].ID.ToString();
                        repeat += " ";
                    }
                }
            }
            if (flag)
            {
                button6.Text = "无重复"; 
            }
            else
            {
                button6.Text = repeat;
            }
        }
    }
}
