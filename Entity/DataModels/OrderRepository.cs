using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DataModels
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve an order from its id.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int OrderId)
        {
            // Create instance of Order class
            Order order = new Order(OrderId);

            return order;
        }

        /// <summary>
        /// Saves a Order object to the database.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Save(Order order)
        {
            return true;
        }
    }
}
