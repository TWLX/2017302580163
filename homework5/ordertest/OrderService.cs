using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ordertest {
    public class OrderService { 

        public Dictionary<uint, Order> orderDict;

        public OrderService() {
            orderDict = new Dictionary<uint, Order>();
        }

        public void AddOrder(Order order) {
            if (orderDict.ContainsKey(order.Id))
                throw new Exception($"订单-{order.Id}已存在!");
            orderDict[order.Id] = order;
        }

        public void RemoveOrder(uint orderId) {
            orderDict.Remove(orderId);
            orderDict[orderId] = null;
        }

        public List<Order> QueryAllOrders() {
            return orderDict.Values.ToList();
        }

        //public Order GetById(uint orderId) {
        //    return orderDict[orderId];
        //}

        //public List<Order> QueryByGoodsName(string goodsName) {
        //    List<Order> result = new List<Order>();
        //    foreach(Order order in orderDict.Values){
        //        foreach(OrderDetail detail in order.Details){
        //            if (detail.Goods.Name == goodsName){
        //                result.Add(order);
        //                break;
        //            }
        //        }
        //    }
        //    return result;
        //}


        //public List<Order> QueryByCustomerName(string customerName) {
        //    var query=orderDict.Values
        //        .Where(order => order.Customer.Name == customerName);
        //    return query.ToList();
        //}
    
        public void UpdateCustomer(uint orderId, Customer newCustomer) {
            if (orderDict.ContainsKey(orderId)) {
                orderDict[orderId].Customer = newCustomer;
            } else {
                throw new Exception($"订单-{orderId}不存在!");
            }
        }

        public void Export(List<Order> o){
            {//XmlTextWriter writer;
             //writer = new XmlTextWriter(filename, null);
             ////使用缩进
             //writer.Formatting = Formatting.Indented;
             ////写XML说明
             //writer.WriteStartDocument();

                ////引用样式
                //string PItext = "type ='text/xsl'href = 'book.xsl'";
                //writer.WriteProcessingInstruction("xml - stylesheet", PItext);
                ////文档类型
                //writer.WriteDocType("book", null, null, "<!ENTITY h'hardcover'>");
                ////写入注释
                //writer.WriteComment("sample XML");

                ////写一个元素(根元素)
                //writer.WriteStartElement("order");
                ////属性
                //writer.WriteAttributeString()
                /**
                 *            //构造XML
            var xDoc = new XDocument(new XElement("root",
                new XElement("order", new XText("小李"),
                new XAttribute("Good", "牛奶"))
                ));
            //写入文件
            StreamWriter sw = new StreamWriter(
                new FileStream(@"d:\t.xml", FileMode.Create),
                Encoding.UTF8);
            xDoc.Save(sw);
            xDoc.Save(Console.Out);
                 **/

            }

            //序列化
            try
            {
                FileStream fs = new FileStream("serialiable.xml", FileMode.Create);
                XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
                xs.Serialize(fs, o);
                fs.Close();
                string xmlFileName = "serialiable.xml";
                string xml = File.ReadAllText(xmlFileName);
                Console.WriteLine(xml);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("序列化成功！");
            Console.WriteLine();

        }

        public void Import(string file)
        {
            //反序列化
            try
            {
                FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Order));
                List<Order> p = (List<Order>)xs.Deserialize(fs);
                Console.WriteLine(p);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("反序列化成功");

        }
    }
}
