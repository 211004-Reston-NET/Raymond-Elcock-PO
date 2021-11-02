using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLogic.Entities
{
    public partial class LineItem
    {
        public LineItem()
        {
            LineItemOrders = new HashSet<LineItemOrder>();
        }

        public int LineItemId { get; set; }
        public decimal QuantityNumber { get; set; }
        public int ProductId { get; set; }
        public int StorefrontId { get; set; }

        public virtual Product Product { get; set; }
        public virtual StoreFront Storefront { get; set; }
        public virtual ICollection<LineItemOrder> LineItemOrders { get; set; }
    }
}
