using Microsoft.VisualStudio.TestTools.UnitTesting;
using ordertest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        public Dictionary<uint, Order> orderDict;

        public object Search { get; private set; }

        [TestMethod()]
        public void OrderServiceTest()
        {
            orderDict = new Dictionary<uint, Order>();
            Assert.IsNotNull(orderDict);

        }

        [TestMethod()]
        public void AddOrderTest()
        {
            Customer customer1 = new Customer(1, "宝多六花");
            Goods milk = new Goods(1, "牛奶", 69.9);
            OrderDetail orderDetails1 = new OrderDetail(1, milk, 8);
            Order order1 = new Order(1, customer1);
            order1.AddDetails(orderDetails1);

            OrderService os = new OrderService();
            os.AddOrder(order1);

            Assert.AreEqual(order1, os.orderDict[1]);
        }

        [TestMethod()]
        public void RemoveOrderTest()
        {
            Customer customer1 = new Customer(1, "宝多六花");
            Goods milk = new Goods(1, "牛奶", 69.9);
            OrderDetail orderDetails1 = new OrderDetail(1, milk, 8);
            Order order1 = new Order(1, customer1);
            order1.AddDetails(orderDetails1);

            OrderService os = new OrderService();
            os.AddOrder(order1);
            os.RemoveOrder(order1.Id);

            Assert.IsNull(os.orderDict[order1.Id]);
        }

        [TestMethod()]
        public void QueryAllOrdersTest()
        {
            Assert.IsTrue(true);
        }


        [TestMethod()]
        public void ExportTest()
        {
            Customer customer1 = new Customer(1, "宝多六花");
            Goods milk = new Goods(1, "牛奶", 69.9);
            OrderDetail orderDetails1 = new OrderDetail(1, milk, 8);
            Order order1 = new Order(1, customer1);
            order1.AddDetails(orderDetails1);
            List<Order> o = new List<Order> { order1 };
            OrderService os = new OrderService();
            Assert.IsTrue(os.Export(o));
        }

        [TestMethod()]
        public void ImportTest()
        {
            OrderService os = new OrderService();
            Assert.IsTrue(os.Import("serialiable.xml"));
        }
    
    }
}