using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {
    public class Goods {

        public double price;
        public uint Id { get; set; }
        public string Name { get; set; }

        public Goods() { }

        public Goods(uint id, string name, double value) {
            Id = id;
            Name = name;
            Price = value;
        }


        public double Price {
            get { return price; }
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("金额必须大于0!");
                price = value;
            }
        }

        public override string ToString() {
            return $"商品编号:{Id}, 名称:{Name}, 价格:{Price}";
        }
    }
}
