using eCommerce.Models;

namespace eCommerce.DTOs
{
    public class CouponDto
    {
        public string Name { get; set; }
        public int Precentage { get; set; }
    }
    public class CouponCustomerDto
    {
        public string Name { get; set; }
        public int Precentage { get; set; }
        public List<CustomerDto> Customers { get; set; }
    }
}
