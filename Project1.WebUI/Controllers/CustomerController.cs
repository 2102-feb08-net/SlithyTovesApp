using Microsoft.AspNetCore.Mvc;
using Project1.BL;


namespace Project1.WebUI.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpPost("newcustomer")]
        public void CreateCustomer(BL.Customer customer)
        {
            _customerRepository.CreateCustomer(customer);
        }

        [HttpGet("customerbyemail/{email}")]
        public BL.Customer GetCustomerByEmail(string email)
        {
            return _customerRepository.GetCustomerByEmail(email);
        }

        [HttpGet("customerbyid/{id}")]
        public BL.Customer GetCustomerById(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }
    }
}