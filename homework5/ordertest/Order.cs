using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {

    class Order {
        public uint Id { get; set; }
        public Customer Customer { get; set; }
        private List<OrderDetail> details=new List<OrderDetail>();

        public Order(uint orderId, Customer customer) {
            Id = orderId;
            Customer = customer;
        }

        public List<OrderDetail> Details {
            get =>this.details; }

       
        public void AddDetails(OrderDetail orderDetail) {
            if (this.Details.Contains(orderDetail))  {
                throw new Exception($"订单细节：{orderDetail.Id}已存在!");
            }
            details.Add(orderDetail);
        }

        public void RemoveDetails(uint orderDetailId) {
            details.RemoveAll(d =>d.Id==orderDetailId);
        }

        public override string ToString() {
            string result = $"订单号:{Id}, 客户:({Customer})";
            details.ForEach(od => result += "\n\t" + od);
            return result;
        }
    }
}
