using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {

    class MainClass {
        public static void Main() {
            try {
                Customer customer1 = new Customer(1, "宝多六花");
                Customer customer2 = new Customer(2, "西条茜");

                Goods milk = new Goods(1, "牛奶", 69.9);
                Goods eggs = new Goods(2, "鸡蛋", 4.99);
                Goods apple = new Goods(3, "苹果", 5.59);

                OrderDetail orderDetails1 = new OrderDetail(1, apple, 8);
                OrderDetail orderDetails2 = new OrderDetail(2, eggs, 2333);
                OrderDetail orderDetails3 = new OrderDetail(3, milk, 1);

                Order order1 = new Order(1, customer1);
                Order order2 = new Order(2, customer2);
                Order order3 = new Order(3, customer2);
                order1.AddDetails(orderDetails1);
                order1.AddDetails(orderDetails2);
                order1.AddDetails(orderDetails3);
                //order1.AddOrderDetails(orderDetails3);
                order2.AddDetails(orderDetails2);
                order2.AddDetails(orderDetails3);
                order3.AddDetails(orderDetails3);

                OrderService os = new OrderService();
                os.AddOrder(order1);
                os.AddOrder(order2);
                os.AddOrder(order3);

                Console.WriteLine("获取所有订单：" + "\n");
                List<Order> orders = os.QueryAllOrders();
                foreach (Order od in orders)
                    Console.WriteLine(od.ToString() + "\n");

                string name1 = "宝多六花";
                Console.WriteLine("通过客户姓名查询订单:'宝多六花'");
                //orders = os.QueryByCustomerName("宝多六花");
                var m = from n1 in orders where n1.Customer.Name == name1 select n1;
                foreach (var od in m)
                    Console.WriteLine(od.ToString() + "\n");

                List<OrderDetail> detail = new List < OrderDetail >{ orderDetails1, orderDetails2, orderDetails3 };
                string good1 = "牛奶";
                Console.WriteLine("通过商品查询订单:'牛奶'");
                //orders = os.QueryByGoodsName("牛奶");
                var n = from n2 in detail where n2.Goods.Name == good1 select n2;
                foreach (var od in n)
                    Console.WriteLine(od.ToString()+"\n");

                Console.WriteLine("查询订单金额大于1w元的订单：");
                var w = from x in detail where x.Goods.Price * x.Quantity > 10000 select x;
                foreach (var od in w)
                    Console.WriteLine(od.ToString() + "\n");
                

                Console.WriteLine("删除订单（ID＝2）和Query全部:");
                os.RemoveOrder(2);
                os.QueryAllOrders().ForEach(
                    od => Console.WriteLine(od));

            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
