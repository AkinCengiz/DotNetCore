using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3Odev
{
    class EmployeeManager
    {
        public EmployeeManager()
        {
            employees = new List<Employee>()
            {
                new Employee
                {
                    Id = 1, FirstName = "Name1", LastName = "LastName1", Email = "firstnamelastname1@abc.com",
                    City = "İstanbul"
                },
                new Employee
                {
                    Id = 2, FirstName = "Name2", LastName = "LastName2", Email = "firstnamelastname2@abc.com",
                    City = "İstanbul"
                },
                new Employee
                {
                    Id = 3, FirstName = "Name3", LastName = "LastName3", Email = "firstnamelastname3@abc.com",
                    City = "İstanbul"
                },
                new Employee
                {
                    Id = 4, FirstName = "Name4", LastName = "LastName4", Email = "firstnamelastname4@abc.com",
                    City = "İstanbul"
                },
                new Employee
                {
                    Id = 5, FirstName = "Name5", LastName = "LastName5", Email = "firstnamelastname5@abc.com",
                    City = "İstanbul"
                }
            };
        }

        List<Employee> employees;

        public List<Employee> GetAll()
        {
            return employees;
        }

        public void Add(Employee employee)
        {
            employees.Add(employee);
        }
    }
}
