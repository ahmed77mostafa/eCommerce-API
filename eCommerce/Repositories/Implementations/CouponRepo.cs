using eCommerce.Data;
using eCommerce.DTOs;
using eCommerce.Models;
using eCommerce.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Repositories.Implementations
{
    public class CouponRepo : ICouponRepo
    {
        private readonly AppDbContext _context;

        public CouponRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddCoupon(CouponDto couponDto)
        {
            Coupon coupon = new Coupon
            {
                Name = couponDto.Name,
                Precentage = couponDto.Precentage,
            };
            _context.Coupones.Add(coupon);
            _context.SaveChanges();
        }

        public CouponCustomerDto GetCouponById(int id)
        {
            var coupon = _context.Coupones.Include(c => c.Customers).FirstOrDefault(x => x.Id == id);

            if (coupon != null)
            {
                CouponCustomerDto couponCustomerDto = new CouponCustomerDto
                {
                    Name = coupon.Name,
                    Precentage = coupon.Precentage,
                    Customers = coupon.Customers.Select(i => new CustomerDto
                    {
                        Name = i.Name,
                        Email = i.Email,
                        Contact = i.Contact
                    }).ToList()
                };
                return couponCustomerDto;
            }
            return null;
        }

        public List<CouponCustomerDto> GetCoupons()
        {
            var coupons = _context.Coupones.Include(c => c.Customers).Select(i => new CouponCustomerDto
            {
                Name = i.Name,
                Precentage = i.Precentage,
                Customers = i.Customers.Select(c => new CustomerDto
                {
                    Name = c.Name,
                    Email = c.Email,
                    Contact = c.Contact,
                }).ToList()
            }).ToList();

            if (coupons != null)
                return coupons;
            return null;
        }
    }
}
