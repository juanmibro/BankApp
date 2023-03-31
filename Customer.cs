using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    public abstract class Customer
    {

        public int Id { set; get; }
        public string Name { set; get; }
        public string Contact_details { set; get; }

        public double Fee { set; get; }// this is in public for the testing to work

        public List<Account> Accounts { set; get; }

       
    }

    public class Staff: Customer
    {
        public Staff(int Id, string Name, string Contact_details)
        {
            this.Id = Id;
            this.Name= Name;
            this.Contact_details = Contact_details;
            this.Accounts= new List<Account>();
            this.Fee= 50.0;
        }

        public override string ToString()
        {
            return this.Name + " Staff"; 
        }
    }

    public class Client: Customer
    {
        public Client(int Id, string Name,string Contact_details)
        {
            this.Id = Id;
            this.Name = Name;
            this.Contact_details = Contact_details;
            this.Accounts= new List<Account>();
            this.Fee = 0.0;
        }

        public override string ToString()
        {
            return this.Name + " Customer" ;
        }
}
}
