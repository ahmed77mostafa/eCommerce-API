using eCommerce.DTOs;

namespace eCommerce.Repositories.Interfaces
{
    public interface ICustomerRepo
    {
        public List<CustomrCouponCartOrderDto> GetCustomers();
        public CustomrCouponCartOrderDto GetCustomerById(int id);
        public void AddCustomerCartOrder(CustomrCouponCartOrderDto customer);
    }
}
