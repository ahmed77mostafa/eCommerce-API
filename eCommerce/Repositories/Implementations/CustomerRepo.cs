using eCommerce.Data;
using eCommerce.DTOs;
using eCommerce.Models;
using eCommerce.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Repositories.Implementations
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly AppDbContext _context;

        public CustomerRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddCustomerCartOrder(CustomrCouponCartOrderDto customerDto)
        {
            Customer customer = new Customer
            {
                Name = customerDto.Name,
                Email = customerDto.Email,
                Contact = customerDto.Contact,
                ShoppingCart = new ShoppingCart
                {
                    NumberOfItems = customerDto.ShoppingCart.NumberOfItems,
                },
                Coupons = customerDto.Coupons.Select(c => new Coupon
                {
                    Name = c.Name,
                    Precentage = c.Precentage,
                }).ToList(),
                Orders = customerDto.Orders.Select(o => new Order
                {
                    TotalPrice = o.TotalPrice,
                }).ToList()
            };

            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public CustomrCouponCartOrderDto GetCustomerById(int id)
        {
            var customer = _context.Customers
                .Include(c => c.Coupons)
                .Include(o => o.Orders)
                .Include(s => s.ShoppingCart)
                .FirstOrDefault(c => c.Id == id);
            CustomrCouponCartOrderDto result = new CustomrCouponCartOrderDto
            {
                Name = customer.Name,
                Email = customer.Email,
                Contact = customer.Contact,
                ShoppingCart = new ShoppingCartDto
                {
                    NumberOfItems = customer.ShoppingCart.NumberOfItems,
                },
                Orders = customer.Orders.Select(o => new OrderDto
                {
                    TotalPrice = o.TotalPrice,
                }).ToList(),
                Coupons = customer.Coupons.Select(c => new CouponDto
                {
                    Name = c.Name,
                    Precentage = c.Precentage
                }).ToList(),
            };

            return result;
        }

        public List<CustomrCouponCartOrderDto> GetCustomers()
        {
           var customers = _context.Customers
                .Include(c => c.Coupons)
                .Include(o => o.Orders)
                .Include(s => s.ShoppingCart)
                .Select(i => new CustomrCouponCartOrderDto
                {
                    Name = i.Name,
                    Email = i.Email,
                    Contact = i.Contact,
                    ShoppingCart = new ShoppingCartDto
                    {
                        NumberOfItems = i.ShoppingCart.NumberOfItems,
                    },
                    Orders = i.Orders.Select(o => new OrderDto
                    {
                        TotalPrice = o.TotalPrice,
                    }).ToList(),
                    Coupons = i.Coupons.Select(c => new CouponDto
                    {
                        Name = c.Name,
                        Precentage = c.Precentage
                    }).ToList(),
                }).ToList();
            return customers;
        }
    }
}
