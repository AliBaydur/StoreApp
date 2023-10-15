namespace Entities.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; } = String.Empty;

        //Collection navigation Property
        public ICollection<Product> Products { get; set; } 
    }
}