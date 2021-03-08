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
        public void TestCreateCustomerWorks()
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

        // [Fact]
        // public void TestCreateCustomerWithNumberInNameThrowsException()
        // {
        //     // arrange and act
        //     Customer chuck = new Customer("Chuck1", "Norris", "7894561232", "chuck@norris.com", "77777");
        //     var expected = 
            
        //     // assert
            

        //     // assert
        //     // Assert.Equal(firstName, chuck.FirstName);
        //     // Assert.Equal(lastName, chuck.LastName);
        //     // Assert.Equal(phone, chuck.Phone);
        //     // Assert.Equal(email, chuck.Email);
        //     // Assert.Equal(zip, chuck.Zip);
        // }
    }
}
