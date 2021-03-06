using System.Collections.Generic;
namespace Project1.BL
{
    public interface ICustomerRepository
    {
        void CreateCustomer(Customer customer);

        BL.Customer GetCustomerByEmail(string email);

        BL.Customer GetCustomerById(int id);
    }
}