using System.Collections.Generic;

namespace WebStore.Core.Entities
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}