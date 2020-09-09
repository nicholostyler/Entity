using Entity.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntityTests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // arrange
            Customer customer = new Customer("Bilbo", "Baggins");

            string expected = "Baggins, Bilbo";

            // act
            string actual = customer.Name;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LastNameIsEmpty()
        {
            // arrange
            Customer customer = new Customer("Baggins", "Baggins");

            string expected = "Baggins";

            // act
            string actual = customer.Name;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
