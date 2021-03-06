using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Project1.BL;


namespace Project1.WebUI.Controllers
{
    [ApiController]
    [Route("api/customer")]
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

        [HttpGet("customerbyname/{partOfName}")]
        public List<BL.Customer> GetCustomerByName(string partOfName)
        {
            return _customerRepository.GetCustomerByName(partOfName);
        }

        [HttpGet("customerbyid/{id}")]
        public BL.Customer GetCustomerById(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }
    }
}