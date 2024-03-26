using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiadinaStand
{
    public class OrdersDay
    {
        private List<Order> _orders;

        public List<Order> Order
        {
            get { return _orders; }
        }
        public OrdersDay()
        {
            _orders = new List<Order>();
        }

        public void AddOrder()
        {
            foreach (Order o in _orders) 
            {
                if (o.Equals(ordine)) throw new Exception("l'ordine è gia presente");
            }
            _orders.Add(ordine);
        }
    }
}
