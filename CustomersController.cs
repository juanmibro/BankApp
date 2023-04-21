using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace BankApp
{
    /// <summary>
    /// CustomerController
    /// </summary>
    public class CustomersController // Task 1, Controller CLass

    {
        public List<Customer> customers;
        /// <summary>
        /// The database
        /// </summary>
        private StateController database;

        /// <summary>
        /// CustomersController
        /// </summary>
        public CustomersController(StateController database)
        {
            customers = new List<Customer>();
            this.database = database;   
        }

        /// <summary>
        /// Get a list of customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> getCustomers()
        {
            return this.customers;
        }

        /// <summary>
        /// Addd customer
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(Customer customer)
        {
            this.customers.Add(customer);
        }

        /// <summary>
        /// remove customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool RemoveCustomer(Customer customer)
        {
            return this.customers.Remove(customer);
        }

        /// <summary>
        /// list accounts from customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public List<Account> getAccountsFromCustomer(Customer customer)
        {
            return this.customers.Find(c => c.Id == customer.Id).Accounts;
        }

        /// <summary>
        /// populate listbox *auxiliary
        /// </summary>
        /// <param name="listbox"></param>
        public void PopulateList(ListBox listbox)
        {
            listbox.Items.Clear();
            this.customers.ForEach(cust => listbox.Items.Add(cust));
            
        }


        /// <summary>
        /// Saves the state.
        /// </summary>
        public void SaveState()
        {

            this.database.SaveState(customers);
            
            //string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,  "customers.json");
            //File.WriteAllText(path, ObjectToJson(this.customers));
        }

        /// <summary>
        /// Loads the state.
        /// </summary>
        public void LoadState()
        {
            this.customers = database.LoadState();
            
            //string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,  "customers.json");
            //string json = File.ReadAllText(path);
            //List<CustomerAdapter> objects = JsonToObject<List<CustomerAdapter>>(json);
            //foreach (CustomerAdapter obj in objects)
            //{
            //    customers.Add(obj.GetAccount());
            //}
        }

    }
}
