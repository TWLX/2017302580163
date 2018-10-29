using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databinding
{
    class OrderService
    {
        public List<Order> Orders;

        public OrderService()
        {
            Orders = new List<Order>();
        }
    }
}
