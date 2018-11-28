using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace databinding
{
    class OrderService
    {
        public List<Order> Orders;

        public OrderService()
        {
            Orders = new List<Order>();
        }

        public void Add(Order order)
        {
            using (var db = new OrderDB())
            {
                db.Order.Add(order);
                db.SaveChanges();
            }
        }

        public List<Order> GetAllOrders()
        {
            using (var db = new OrderDB())
            {
                return db.Order.ToList<Order>();
            }
        }

        public void Delete(string orderId)
        {
            using (var db = new OrderDB())
            {
                var order = db.Order.SingleOrDefault(o => o.ID == orderId);
       
                db.Order.Remove(order);
                db.SaveChanges();
            }
        }

        public List<Order> GetOrder(string Name)
        {
            using (var db = new OrderDB())
            {
                return db.Order.Where(o => o.Name.Equals(Name)).ToList<Order>();
            }
        }

        public List<Order> QueryByGoods(String product)
        {
            using (var db = new OrderDB())
            {
                var query = db.Order
                  .Where(o => o.Good.Equals(product));
                return query.ToList<Order>();
            }
        }
        //public void Export(List<Order> o)
        //{
        //    //序列化
        //    try
        //    {
        //        FileStream fs = new FileStream("serialiable.xml", FileMode.Create);
        //        XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
        //        xs.Serialize(fs, o);
        //        fs.Close();
        //        string xmlFileName = "serialiable.xml";
        //        string xml = File.ReadAllText(xmlFileName);
        //        Console.WriteLine(xml);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }


        //    Console.WriteLine("序列化成功！");
        //    Console.WriteLine();
        //}

        //public void Import(string file)
        //{
        //    //反序列化
        //    try
        //    {
        //        FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
        //        XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
        //        List<Order> p = (List<Order>)xs.Deserialize(fs);
        //        foreach (Order o in p)
        //        {
        //            Console.WriteLine(o);
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //    Console.WriteLine("反序列化成功！");
        //}
    }
}
