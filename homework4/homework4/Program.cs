using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 *2、写一个订单管理的控制台程序，能够实现添加订单、删除订单、
 * 修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询）
 * 功能。在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
提示：需要写Order（订单）、OrderDetails（订单明细），
OrderService（订单服务）几个类，
订单数据可以保存在OrderService中一个List中。
 */
namespace homework4
{
    class MyException : ApplicationException
    {
        public MyException(string message) : base(message)
        {

        }
    }

    class Order
    {
        public int number = 0;//订单号
        public string name;//商品名称
        public string customer;//客户
        public Order(string name, string customer)
        {
            this.name = name;
            this.customer = customer;
        }

    }

    class OrderDetails
    {
        
        public int orgPrice = 10;
        public int keyPrice = 3;

        public void BuyOrg(int buyNum)
        {
            Console.WriteLine("总价为："+ buyNum * orgPrice);
        }

        public void BuyKey(int buyNum)
        {
            Console.WriteLine("总价为：" + buyNum * keyPrice);
        }


    }

    class OrderService
    {
        
        public List<Order> list = new List<Order>();
        public void InputOrder(Order order)
        {
            list.Add(order);
            Console.WriteLine("添加成功！");
            QueryOrder(order.number);
            
        }

        public void DeleteOrder(int num)
        {
            bool IsNum = false;
            int count = list.Count;

            if(num < count)
            {
                list.Remove(list[num]);
                Console.WriteLine("删除成功！");
                IsNum = true;
            }

            if (IsNum == false)
                throw new MyException("订单号不存在或者输入错误，请重新输入：");
            

        }

        //修改查找到的订单
        public void UpdateOrder()
        {
            OrderDetails details = new OrderDetails();
            Console.WriteLine("开始修改订单，请输入商品：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入商品购买数目：");
            int buyNum = Convert.ToInt32(Console.ReadLine());
            if (name.Equals("橘子"))
            {
                details.BuyOrg(buyNum);
            }
            else if (name.Equals("钥匙"))
            {
                details.BuyKey(buyNum);
            }

            Console.WriteLine("请输入你的名字：");
            string customer = Console.ReadLine();
        }

        //按订单号查找
        public void QueryOrder(int num)
        {
            Console.WriteLine("订单号：" + list[num].number);
            Console.WriteLine("商品名称：" + list[num].name);
            Console.WriteLine("客户：" + list[num].customer);
        }

        //按客户名字查找
        public void QueryOrder(string customer)
        {
            foreach(Order i in list)
            {
                if (i.customer.Equals(customer))
                {
                    Console.WriteLine("订单号："+ i.number);
                    Console.WriteLine("商品名称：" + i.name);
                    Console.WriteLine("客户：" + i.customer);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OrderDetails details = new OrderDetails();
            Console.WriteLine("出售商品：");
            Console.WriteLine("1.橘子    十元一斤");
            Console.WriteLine("2.钥匙    三元一把");
            Console.WriteLine("开始添加订单，请输入商品：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入商品购买数目：");
            int buyNum = Convert.ToInt32(Console.ReadLine());
            if(name.Equals("橘子"))
            {
                details.BuyOrg(buyNum);
            }
            else if(name.Equals("钥匙"))
                {
                details.BuyKey(buyNum);
            }

            Console.WriteLine("请输入你的名字：");
            string customer = Console.ReadLine();

            Order order = new Order(name, customer);
            OrderService service = new OrderService();
            service.InputOrder(order);
            Console.WriteLine("按订单号码查找订单：");
            int num2 = Convert.ToInt32(Console.ReadLine());
            service.QueryOrder(num2);
            Console.WriteLine("按客户名字查找订单：");
            string customer2 = Console.ReadLine();
            service.QueryOrder(customer2);

            service.UpdateOrder();

            Console.WriteLine("删除订单号：");
            int num3 = Convert.ToInt32(Console.ReadLine());

            try
            {
                service.DeleteOrder(num3);
            }
            catch (MyException e)
            {
                Console.WriteLine("MyException:{0}", e.Message);
                service.DeleteOrder(num2);
            }
        }
}
}
