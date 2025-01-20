using eCommerce.Models;

namespace eCommerce.DTOs
{
    public class OrderDto
    {
        public int TotalPrice { get; set; }
    }
    public class OrderProductDto
    {
        public int TotalPrice { get; set; }
        public List<ProductDto> Products { get; set; }
    }
    public class OrderCustomerDto
    {
        public int TotalPrice { get; set; }
        public CustomerDto Customer { get; set; }
    }
    public class OrderCustomerProductsDto
    {
        public int TotalPrice { get; set; }
        public List<ProductDto> Products { get; set; }
        public CustomerDto Customer { get; set; }
    }
}
