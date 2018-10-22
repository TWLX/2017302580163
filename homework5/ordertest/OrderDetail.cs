using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {
    public class OrderDetail {
        public uint Id { get; set; }
        public Goods Goods { get; set; }

        public OrderDetail() { }

        public OrderDetail(uint id, Goods goods, uint quantity) {
            this.Id = id;
            this.Goods = goods;
            this.Quantity = quantity;
        }

        public uint Quantity { get; set; }

        public override bool Equals(object obj)
        {
            var detail = obj as OrderDetail;
            return detail != null &&
                Goods.Id==detail.Goods.Id&&
                Quantity == detail.Quantity;
        }

        public override int GetHashCode()
        {
            var hashCode = 1522631281;
            hashCode = hashCode * -1521134295 + Goods.Name.GetHashCode();
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            return hashCode;
        }

        public override string ToString() {
            string result = "";
            result += $"订单细节:{Id}:  ";
            result += Goods + $", 数量:{Quantity}"; 
            return result;
        }


    }
}
