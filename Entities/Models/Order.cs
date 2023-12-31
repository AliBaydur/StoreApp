using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public ICollection<CartLine> Lines { get; set; } = new List<CartLine>();

        [Required(ErrorMessage = "Name İs Required.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Line1 İs Required.")]
        public string? Line1 { get; set; }
        [Required(ErrorMessage = "Line2 İs Required.")]
        public string? Line2 { get; set; }
        public string? Line3 { get; set; }
        [Required(ErrorMessage = "City İs Required.")]
        public string? City { get; set; }
        public bool GiftWrap { get; set; }
        public bool Shipped { get; set; }
        public DateTime OrderedAt { get; set; } = DateTime.Now;
    }
}