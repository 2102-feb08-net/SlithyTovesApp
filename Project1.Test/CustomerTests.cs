using System;
using Xunit;
using Project1.BL;
using Microsoft.VisualStudio.CodeCoverage;
using Microsoft.VisualStudio.TestPlatform;

namespace Project1.Test
{
    public class UnitTest1
    {
        [Fact]
        public void CreateCustomerWorks()
        {
            // arrange and act
            Customer chuck = new Customer("Chuck", "Norris", "7894561232", "chuck@norris.com", "77777");

            // assert
            Assert.Equal("Chuck", chuck.FirstName);
            Assert.Equal("Norris", chuck.LastName);
            Assert.Equal("7894561232", chuck.Phone);
            Assert.Equal("chuck@norris.com", chuck.Email);
            Assert.Equal("77777", chuck.Zip);
        }

        [Fact]
        public void CreateCustomerWithSpecialCharactersInFirstNameThrowsException()
        {
            // arrange and act
            Customer customer;
            
            // assert
            Assert.Throws<ArgumentException>(
                () => customer = new Customer("123Chuck!!", "Norris", "7894561232", "chuck@norris.com", "77777"));
        }

        [Fact]
        public void CreateCustomerWithSpecialCharactersInLastNameThrowsException()
        {
            // arrange and act
            Customer customer;
            
            // assert
            Assert.Throws<ArgumentException>(
                () => customer = new Customer("Chuck", "Nor1283%^^&&*ris", "7894561232", "chuck@norris.com", "77777"));
        }

        [Fact]
        public void CreateCustomerWithShortPhoneNumberThrowsException()
        {
            // arrange and act
            Customer customer;
            
            // assert
            Assert.Throws<ArgumentException>(
                () => customer = new Customer("Chuck", "Norris", "78945", "chuck@norris.com", "77777"));
        }

        [Fact]
        public void CreateCustomerWithLongPhoneNumberThrowsException()
        {
            // arrange and act
            Customer customer;
            
            // assert
            Assert.Throws<ArgumentException>(
                () => customer = new Customer("Chuck", "Norris", "78941861581685", "chuck@norris.com", "77777"));
        }

        [Fact]
        public void CreateCustomerWithSpecialCharactersInPhoneNumberThrowsException()
        {
            // arrange and act
            Customer customer;
            
            // assert
            Assert.Throws<ArgumentException>(
                () => customer = new Customer("Chuck", "Norris", "123asd$%^4", "chuck@norris.com", "77777"));
        }

        [Fact]
        public void CreateCustomerWithShortEmailThrowsException()
        {
            // arrange and act
            Customer customer;
            
            // assert
            Assert.Throws<ArgumentException>(
                () => customer = new Customer("Chuck", "Norris", "1234567890", "c@n.", "77777"));
        }

        [Fact]
        public void CreateCustomerWithNoAtInEmailThrowsException()
        {
            // arrange and act
            Customer customer;
            
            // assert
            Assert.Throws<ArgumentException>(
                () => customer = new Customer("Chuck", "Norris", "1234567890", "chuck.norris", "77777"));
        }

        [Fact]
        public void CreateCustomerWithNoDotInEmailThrowsException()
        {
            // arrange and act
            Customer customer;
            
            // assert
            Assert.Throws<ArgumentException>(
                () => customer = new Customer("Chuck", "Norris", "1234567890", "chuck@norris", "77777"));
        }

        [Fact]
        public void CreateCustomerWithLongZipCodeThrowsException()
        {
            // arrange and act
            Customer customer;
            
            // assert
            Assert.Throws<ArgumentException>(
                () => customer = new Customer("Chuck", "Norris", "1234567890", "chuck@norris.com", "7777777"));
        }

        [Fact]
        public void CreateCustomerWithSpecialCharactersInZipCodeThrowsException()
        {
            // arrange and act
            Customer customer;
            
            // assert
            Assert.Throws<ArgumentException>(
                () => customer = new Customer("Chuck", "Norris", "1234567890", "chuck@norris.com", "7#$%7"));
        }
    }
}
