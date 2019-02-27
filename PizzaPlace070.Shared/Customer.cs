using System;
using System.Collections;
using System.ComponentModel;

namespace PizzaPlace070.Shared
{
    public class Customer
    {
        public int Id { get; set; }
        private string name;
        public string Name { 
            get;
            set;
        }
        private string street;
        public string Street { 
            get;
            set;
        }
        private string city;
        public String City {
            get;
            set;
        }
    }
}