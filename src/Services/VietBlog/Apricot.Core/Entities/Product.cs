using Apricot.Core.Entities.Base;

namespace Apricot.Core.Entities
{
    public class Product : Entity
    {
        public Product()
        {
        }

        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }

        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }

        public bool Discontinued { get; set; }

        public int CategoryId { get; set; }
        public string ProductReason { get; set; }

        public Category Category { get; set; }

        public static Product create(int productId, string quantityPerUnity,
            bool discontinued, int categoryId, string productReason,
             string name, decimal? unitPrice = null,
           short? unitsInStock = null, short? unitsOnOrder = null,
           short? ReorderLevel = null)
        {
            var product = new Product
            {
                ProductName = name,
                QuantityPerUnit = quantityPerUnity,
                UnitPrice = unitPrice,
                UnitsInStock = unitsInStock,
                UnitsOnOrder = unitsOnOrder,
                ProductReason = productReason,
                CategoryId = categoryId,
                Discontinued = discontinued,
                ReorderLevel = ReorderLevel,
            };
            return product;
        }
    }
}