using eCommerce.Models;

namespace eCommerce.DTOs
{
    public class ShoppingCartDto
    {
        public int NumberOfItems { get; set; }
    }
    public class ShoppingCartCustomerDto
    {
        public int NumberOfItems { get; set; }
        public CustomerDto Customer { get; set; }
    }
}
