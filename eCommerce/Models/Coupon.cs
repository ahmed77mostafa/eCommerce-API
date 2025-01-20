namespace eCommerce.Models
{
    public class Coupon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Precentage { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
