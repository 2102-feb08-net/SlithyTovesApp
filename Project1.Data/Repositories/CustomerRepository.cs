using System;
using System.Linq;
using Project1.BL;


namespace Project1.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Data.Project1Context _context;
            
        public CustomerRepository(Project1Context context)
        {
            _context = context;
        }

        public void CreateCustomer(BL.Customer customer)
        {
            Customer customerToCreate = new Customer() 
                { CustomerId = customer.CustomerId, FirstName = customer.FirstName, LastName = customer.LastName, Phone = customer.Phone, 
                    Email = customer.Email, Zip = customer.Zip };
            
            _context.Add(customerToCreate);
            _context.SaveChanges();
        }

        public BL.Customer GetCustomerByEmail(string email)
        {
            BL.Customer customer = new BL.Customer();
            var query = _context.Customers.FirstOrDefault(e => e.Email == email);
            if (query != null) 
            {
                customer.CustomerId = query.CustomerId;
                customer.FirstName = query.FirstName;
                customer.LastName = query.LastName;
                customer.Phone = query.Phone;
                customer.Email = query.Email;
                customer.Zip = query.Zip;
            }
            else 
            {
                customer.FirstName = null;
                customer.LastName = null;
                customer.Phone = null;
                customer.Email = null;
                customer.Zip = null;
            }
            return customer;
        }

        public BL.Customer GetCustomerById(int id) 
        {
            var result = _context.Customers.Where(c => c.CustomerId == id).First();
            BL.Customer customer = 
                new BL.Customer(result.CustomerId, result.FirstName, result.LastName, result.Phone, result.Email, result.Zip);
            return customer;
        }
    }
}