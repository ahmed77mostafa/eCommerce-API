namespace eCommerce.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int NumberOfItems { get; set; }
        public Customer Customer { get; set; }
    }
}
