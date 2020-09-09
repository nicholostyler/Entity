using Entity.Common;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Entity.Models
{
    public class Order : EntityBase, ILoggable
    {
        public Order(int orderId) => OrderId = orderId;

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }

        public override bool Validate()
        {
            var hasError = false;

            if (OrderDate == null) hasError = true;

            return hasError;
        }

        public override string ToString()
        {
            return ($"Order {OrderId} has {OrderItems.Count} items");
        }

        public string Log()
        {
            return ($"Order {OrderId} has {OrderItems.Count} items");
        }
    }
}
