using eCommerce.DTOs;

namespace eCommerce.Repositories.Interfaces
{
    public interface ICouponRepo
    {
        public List<CouponCustomerDto> GetCoupons();
        public CouponCustomerDto GetCouponById(int id);
        public void AddCoupon(CouponDto couponDto);
    }
}
