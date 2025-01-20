using eCommerce.Models;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.DTOs
{
    public class ProductDto
    {
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        public int StockQuantity { get; set; }
    }
    public class ProductOrderDto
    {
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        public int StockQuantity { get; set; }
        public OrderDto Order { get; set; }
    }
}
