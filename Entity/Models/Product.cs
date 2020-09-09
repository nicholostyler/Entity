using Entity.Common;

namespace Entity.Models
{
    public class Product : EntityBase
    {
        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }

        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }

            set
            {
                ProductName = value;
            }
        }

        /// <summary>
        /// Validates the Product Item
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(ProductName)) hasError = true;
            if (string.IsNullOrWhiteSpace(ProductDescription)) hasError = true;
            if (CurrentPrice == null) hasError = true;

            return hasError;
        }
    }
}
