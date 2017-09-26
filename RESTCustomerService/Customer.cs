using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTCustomerService
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }
        public int Id { get; set; }

        public Customer()
        {

        }
        public Customer(int id, string firstname, string lastname, int year)
        {
            FirstName = firstname;
            LastName = lastname;
            Year = year;
            Id = id;
        }
    }
}