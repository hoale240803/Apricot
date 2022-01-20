using Apricot.Core.Entities.Base;

namespace Apricot.Core.Entities
{
    public class Category:Entity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public ICollection<Product> Products { get; private set; }

        public static Category Create(int categoryId, string name, string description = null)
        {
            var catetory = new Category
            {
                CategoryName = name,
                Description = description,
                Id = categoryId
            };

            return catetory;

        }
    }
}