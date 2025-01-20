using eCommerce.Models;

namespace eCommerce.DTOs
{
    public class CustomerDto
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
    }
    public class CustomrCouponCartOrderDto
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public List<CouponDto> Coupons { get; set; }
        public int ShoppingCartId { get; set; }
        public ShoppingCartDto ShoppingCart { get; set; }
        public List<OrderDto> Orders { get; set; }
    }
}
