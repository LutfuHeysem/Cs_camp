using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer
            {
                Id = 1,
                CustomerId = "12345",
                Name = "Engin",
                Surname = "Demirog",
                TcNo = "12345678910"
            };

            CoorporateCustomer customer2 = new CoorporateCustomer 
            { 
                Id = 2,
                CustomerId = "54321",
                CompanyName = "kodlama.io",
                TaxeNo = "123456789"
            };

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

        }
    }
}