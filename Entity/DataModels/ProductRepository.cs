using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DataModels
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve a product from its id.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // Create instance of Customer class
            Product product = new Product(productId);

            return product;
        }

        /// <summary>
        /// Saves a Product object to the database.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Save(Product product)
        {
            bool success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call an insert stored procedure
                        success = true;
                    }
                    else
                    {
                        // Call an update procedure
                        success = false;
                    }
                }
                else
                {
                    success = false;
                }
            }
            else
            {
                success = false;
            }

            return success;
        }
    }
}
