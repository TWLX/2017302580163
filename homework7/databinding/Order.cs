using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databinding
{
    public class Order
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Num { get; set; }
        public string Good { get; set; }

        //默认构造函数
        public Order() { }


        public Order(string name, int id, int num,string good)
        {
            Name = name;
            ID = id;
            Num = num;
            Good = good;
        }
    }
}
