using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLogic.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            StoreOrders = new HashSet<StoreOrder>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }

        public virtual ICollection<StoreOrder> StoreOrders { get; set; }
    }
}
