namespace eCommerce.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact {  get; set; }
        public string Email { get; set; }
        public List<Coupon> Coupons { get; set; }
        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public List<Order> Orders { get; set; }
    }
}
