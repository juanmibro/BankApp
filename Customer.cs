using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    internal class Customer
    {

        public int Id { set; get; }
        public  string Name { set; get; }
        public string Contact_details { set; get; }

        public List<Account> Accounts { set; get; }

        public Customer(string name, string contact_details)
        {
            Name = name;
            Contact_details = contact_details;
            Accounts = new List<Account>();
        }
    }
}
