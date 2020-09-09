using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;

namespace Entity.Models
{
    public class OrderItem : EntityBase
    {
        public OrderItem(int orderItemId) => OrderItemId = orderItemId; 
        public int OrderItemId { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public double? PurchasePrice { get; private set; }

        /// <summary>
        /// Validates the Order Item
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool hasError = false;

            if (Product.Equals(null) || Quantity.Equals(null) || PurchasePrice.Equals(null))
            {
                hasError = true;
            }
            else if (Quantity < 0) hasError = true;

            return hasError;
        }

        public override string ToString()
        {
            return ($"OrderItem {OrderItemId} has a quantity of {Quantity} of type {Product}");
        }

    }
}
