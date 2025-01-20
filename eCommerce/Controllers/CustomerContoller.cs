using eCommerce.DTOs;
using eCommerce.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerContoller : ControllerBase
    {
        private readonly ICustomerRepo _customerRepo;

        public CustomerContoller(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }
        [HttpGet]
        public IActionResult GetCustomers()
        {
            var result = _customerRepo.GetCustomers();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetCustomers(int id)
        {
            var result = _customerRepo.GetCustomerById(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddCustomer(CustomrCouponCartOrderDto customerDto)
        {
            _customerRepo.AddCustomerCartOrder(customerDto);
            return Ok();
        }
    }
}
