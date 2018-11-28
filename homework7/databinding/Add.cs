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
    public partial class add : Form
    {
        OrderService orderService = new OrderService();

        public add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = Name.Text;
     
            int num = Convert.ToInt16(Num.Text);
            String good = Good.Text;

            Order order = new Order(name, "wsng", num, good);
            orderService.Add(order);

            Form1.form1.orderBindingSource.DataSource = orderService.GetAllOrders();
            //Form1.form1.orderBindingSource.Add(new Order(name, id, num, good));
            //Form1.form1.orderBindingSource.EndEdit();

            this.Close();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"g://";
            openFileDialog1.Filter = "txt files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = openFileDialog1.FileName;
            }
        }
    }
}
