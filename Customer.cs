using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{

    
    /// <summary>
    /// 
    /// </summary>
    public abstract class Customer
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { set; get; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { set; get; }
        /// <summary>
        /// Gets or sets the contact details.
        /// </summary>
        /// <value>
        /// The contact details.
        /// </value>
        public string Contact_details { set; get; }
        /// <summary>
        /// Gets or sets the fee.
        /// </summary>
        /// <value>
        /// The fee.
        /// </value>
        public double Fee { set; get; }// this is in public for the testing to work

        /// <summary>
        /// Gets or sets the type of the customer.
        /// </summary>
        /// <value>
        /// The type of the customer.
        /// </value>
        public string CustomerType {set; get; }
        /// <summary>
        /// Gets or sets the accounts.
        /// </summary>
        /// <value>
        /// The accounts.
        /// </value>
        // [JsonConverter(typeof(AccountConverter))]
        public List<Account> Accounts { set; get; }
     

       
    }


    /// <summary>
    /// CustomerAdapter
    /// </summary>
    /// <seealso cref="BankApp.Customer" />
    public class CustomerAdapter : Customer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAdapter"/> class.
        /// </summary>
        public CustomerAdapter()
        {

        }

        //[JsonProperty(PropertyName = "Accounts"), JsonConverter(typeof(AccountConverter))]
        //[JsonProperty(PropertyName = "Accounts"), JsonConverter(typeof(AccountConverter))]
        public List<Account> Accounts { get; set; }
        /// <summary>
        /// Gets the account.
        /// </summary>
        /// <returns></returns>
        public Customer GetAccount()
        {
            if (CustomerType == "Staff")
            {
                Staff staff =  new Staff(Id, Name, Contact_details);
                Accounts.ForEach(account => staff.Accounts.Add(account));
                return staff;
            }else
            {
                Client client = new Client(Id, Name, Contact_details); 
                Accounts.ForEach(account =>  client.Accounts.Add(account));
                return client;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BankApp.Customer" />
    public class Staff: Customer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Staff"/> class.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Name">The name.</param>
        /// <param name="Contact_details">The contact details.</param>
        public Staff(int Id, string Name, string Contact_details)
        {
            this.Id = Id;
            this.Name= Name;
            this.Contact_details = Contact_details;
            this.Accounts= new List<Account>();
            this.Fee= 50.0;
            this.CustomerType = "Staff";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Staff"/> class.
        /// </summary>
        public Staff() {
            this.Fee = 50.0;
            this.CustomerType = "Staff";
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.Name + " (Staff)"; 
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BankApp.Customer" />
    public class Client: Customer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Name">The name.</param>
        /// <param name="Contact_details">The contact details.</param>
        public Client(int Id, string Name,string Contact_details)
        {
            this.Id = Id;
            this.Name = Name;
            this.Contact_details = Contact_details;
            this.Accounts= new List<Account>();
            this.Fee = 0.0;
            this.CustomerType = "Client";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        public Client() { }
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.Name + " (Customer)" ;
        }
}
}
