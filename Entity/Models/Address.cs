using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Entity.Models
{
    public class Address : EntityBase
    {
        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public int AddressId { get; set; }
        public AddressType AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }

        public override bool Validate()
        {
            var hasError = false;

            if (PostalCode == null) hasError = true;
            if (PostalCode.Count() > 5) hasError = true;

            return hasError;
        }
    }

    public enum AddressType
    {
        Street,
        POBOX
    }
}
