using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity.DataModels
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            this.addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }


        /// <summary>
        /// Retrieve a customer from its id.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // Create instance of Customer class
            Customer customer = new Customer(customerId);

            customer.FirstName = "Frodo";
            customer.LastName = "Baggins";
            customer.AddressList = addressRepository.RetrieveByCustomerId(customer.CustomerId)
                                    .ToList();

            return customer;
        } 

        /// <summary>
        /// Saves a customer object to the database.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
