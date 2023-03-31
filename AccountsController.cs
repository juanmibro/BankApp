using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BankApp
{
    public  class AccountsController
    {
        private Customer customer;

        public AccountsController(Customer customer) { 
            this.customer = customer;
        }

        public void RegisterAccount(Account account)
        {
            this.customer.Accounts.Add(account);
        }
        public bool UnregisterAccount(Account account)
        {
            //if (account == null)
            //{
            //    return false;
            //}


            if (account.Balance > 0)
            {
                MessageBox.Show($"The selected account has ${account.Balance:n2}, please withdraw the balance first");
                return false;
            }

            this.customer.Accounts.Remove(account);
            return true;
        }

        public void ListAccounts(ListBox listbox)
        {
            listbox.Items.Clear();
            this.customer.Accounts.ForEach(account =>
            {
                listbox.Items.Add(account);
            });
        }

        public void DepositIntoAccount(Account account, double amount)
        {
            if (account== null)
            {
                MessageBox.Show("Please, select a account to operate");
                return;
            }

            account.Deposit(amount);
        }

        public void WithdrawlFromAccount(Account account, double amount)
        {

            if (account == null)
            {
                MessageBox.Show("Please, select a account to operate");
                return;
            }
            account.Withdraw(amount);
        }
        
    }


}
