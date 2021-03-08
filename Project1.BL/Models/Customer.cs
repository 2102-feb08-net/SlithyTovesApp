using System.Linq;
using System;


namespace Project1.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        private string _firstName;
        private string _lastName;
        private string _phone;
        private string _email;
        private string _zip;

        public string FirstName 
        {
            get { return _firstName; }
            set 
            {
                if (value.All(char.IsLetter))
                {
                    _firstName = value;
                }
                else 
                {
                    throw new ArgumentException("Invalid first name.  Please enter only letters.");
                }
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value.All(char.IsLetter))
                {
                    _lastName = value;
                }
                else
                {
                    throw new ArgumentException("Invalid last name.  Please enter only letters.");
                }
            }
        }
        public string Phone
        {
            get { return _phone; }
            set
            {
                if (value.All(char.IsDigit) && value.Length == 10)
                {
                    _phone = value;
                }
                else
                {
                    throw new ArgumentException("Invalid phone number.  Please enter a 10-digit number.");
                }
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Contains("@") && value.Contains(".") && value.Length >= 5)
                {
                    _email = value;
                }
                else
                {
                    throw new ArgumentException("Please enter a valid email address.");
                }
            }
        }
        public string Zip
        {
            get { return _zip; }
            set
            {
                if (value.All(char.IsDigit) && value.Length == 5)
                {
                    _zip = value;
                }
                else
                {
                    throw new ArgumentException("Please enter a 5-digit zip code.");
                }
            }
        }

        public Customer()
        {   
        }

        public Customer(int customerId, string firstName, string lastName, string phone, string email, string zip)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Zip = zip;
        }

        public Customer(string firstName, string lastName, string phone, string email, string zip)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Zip = zip;
        }
    }
}