using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace BankApp
{
    public class CustomersController // Task 1, Controller CLass

    {
        public List<Customer> customers;

        public CustomersController()
        {
            customers = new List<Customer>();
        }

        public List<Customer> getList()
        {
            return this.customers;
        }

        public void AddCustomer(Customer customer)
        {
            this.customers.Add(customer);
        }

        public bool RemoveCustomer(Customer customer)
        {
            return this.customers.Remove(customer);
        }

        public List<Account> getAccounFromCustomer(Customer customer)
        {
            return this.customers.Find(c => c.Id == customer.Id).Accounts;
        }

        public void PopulateList(ListBox listbox)
        {
            listbox.Items.Clear();
            this.customers.ForEach(c => listbox.Items.Add(c));
            
        }

    }
}
