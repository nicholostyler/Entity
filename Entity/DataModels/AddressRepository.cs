using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DataModels
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            address.AddressType = AddressType.POBOX;
            address.StreetLine1 = "Bag End";
            address.StreetLine2 = "Bagshot Row";
            address.City = "Hobbitton";
            address.State = "Shire";
            address.Country = "Middle Earth";
            address.PostalCode = "20619";

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>
            {
                new Address(
                1,
                AddressType.Street,
                "Bag End",
                "Bagshot Row",
                "Hobbitton",
                "Shire",
                "Middle Earth",
                "20619"
                )
            };

            return addressList;
    }

    public bool Save(Address address)
    {
        throw new NotImplementedException();
    }
}
}
