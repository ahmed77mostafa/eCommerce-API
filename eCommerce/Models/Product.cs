using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        public int StockQuantity { get; set; }
        public Order Order { get; set; }
    }
}
