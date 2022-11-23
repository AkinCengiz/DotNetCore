using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class CustomerManager
    {
        public CustomerManager()
        {
            customers = new List<Customer>()
            {
                new Customer(){Id = 1,FirstName = "Akın",LastName = "Cengiz",Email = "akin@cngz",City = "İstanbul"},
                new Customer(){Id = 2,FirstName = "Serap",LastName = "Cengiz",Email = "serap@cngz",City = "İstanbul"},
                new Customer(){Id = 3,FirstName = "Bahtınur",LastName = "Cengiz",Email = "bahtinur@cngz",City = "İstanbul"},
                new Customer(){Id = 4,FirstName = "Cansu",LastName = "Cengiz",Email = "cansu@cngz",City = "İstanbul"},
                new Customer(){Id = 5,FirstName = "Aytaç",LastName = "Cengiz",Email = "aytac@cngz",City = "İstanbul"}
            };
        }
        List<Customer> customers;
        public List<Customer> GetAll()
        {
            
            return customers;
        }

        public Customer Add(int id, string firstName, string lastName, string email, string city)
        {
            Customer customer = new Customer
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                City = city
            };
            customers.Add(customer);
            return customer;
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
