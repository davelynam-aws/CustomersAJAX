using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomersAJAX.Models
{
    public class Customer
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Customer(int iD, string name, int age)
        {
            ID = iD;
            Name = name;
            Age = age;
        }
    }
}