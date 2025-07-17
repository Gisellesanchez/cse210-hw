using System;
using System.Collections.Generic;

namespace Foundation2
{
    public class Customer
    {
        public string Name { get; set; }
        private Address address { get; set; }


        public Customer(string name, Address address)
        {
            Name = name;
            this.address = address;

        }
        public bool LivesInUSA()
        {
            return address.IsInUSA();
        }
        public string GetName()
        {
            return Name;
        }
        public Address GetAddress()
    {
        return address;
    }
    }
}