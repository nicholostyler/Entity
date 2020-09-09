using Entity.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace Entity.Models
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer(int customerId)
        {
            this.AddressList = new List<Address>();
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }
        public CustomerType CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(LastName))
                    return FirstName;
                else if (string.IsNullOrEmpty(FirstName))
                    return LastName;
                else
                    return $"{LastName}, {FirstName}";
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Address> AddressList { get; set; }
       
        /// <summary>
        /// Validates the customers data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            
            return ($"Customer: {Name}");
        }

        /// <summary>
        /// Logs the customer to console.
        /// </summary>
        /// <returns></returns>
        public string Log()
        {
            return ($"{CustomerId}: {Name} Email: {EmailAddress} Status {base.ToString()}");
        }
    }

    public enum CustomerType
    {
        Education,
        Business,
        Residental
    }

}
