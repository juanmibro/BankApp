
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace BankApp
{

    
    /// <summary>
    /// 
    /// </summary>
    public class AccountsController
    {

        
        
        /// <summary>
    /// 
    /// </summary>
        private Customer customer;
        /// <summary>
        /// The accounts
        /// </summary>
        private List<Account> accounts;


        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsController"/> class.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public AccountsController(Customer customer) { 

            this.customer = customer;
            this.accounts = customer.Accounts;

        }
        /// <summary>
        /// Gets the accounts.
        /// </summary>
        /// <returns></returns>
        public List<Account> GetAccounts()
        {
            return accounts;
        }

        /// <summary>
        /// register account
        /// </summary>
        /// <param name="account"></param>
        public void AddAccount(Account account)
        {
            this.accounts.Add(account);
        }

        /// <summary>
        /// unregister account
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public bool RemoveAccount(Account account)
        {
            
            if (account.Balance > 0)
            {
                MessageBox.Show($"The selected account has ${account.Balance:n2}, please withdraw the balance first");
                return false;
            }

            
            return this.accounts.Remove(account);
        }

        /// <summary>
        /// find account from id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Account GetAccountFromId(int id)
        {
           return  this.accounts.Find(account => account.Id == id);
        }

        /// <summary>
        /// Populates the listbox.
        /// </summary>
        /// <param name="listbox">The listbox.</param>
        public void PopulateListbox(ListBox listbox)
        {
            listbox.Items.Clear();
            this.accounts.ForEach(account =>
            {
                listbox.Items.Add(account);
            });
            listbox.Refresh();
        }

        /// <summary>
        /// deposit into account with id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool DepositIntoAccountId(int id, double amount)
        {
            Account selected = GetAccountFromId(id);
            if (selected == null)
            {
                return false;
            }

            selected.Deposit(amount);
            return true;
        }

            
        /// <summary>
        /// withdrawal from account with id        
        /// </summary>
        /// <param name="id"></param>
        /// <param name="amount"></param>
        public void WithdrawFromAccountId(int id, double amount)
        {
            
            //find the account with id
            Account selected = GetAccountFromId(id);
            //if not found, exit
            if (selected == null)
            {
                return;
            }

            //founded, do withdraw.
           
             selected.Withdraw(amount);
           
            
        }


        /// <summary>
        /// function for transference between accounts
        /// </summary>
        /// <param name="accountFrom"></param>
        /// <param name="accountTo"></param>
        /// <param name="amount"></param>
        /// <exception cref="TransferFailedException"></exception>
        public void TransferBetweenAccounts(Account accountFrom, Account accountTo, double amount)
        {
            //check valid arguments
            if (accountFrom == null || accountTo == null || accountFrom.Balance < amount)
            {
                throw new TransferFailedException("Transfer failed: Invalid account or insufficient balance.");
            }

            try
            {
                GetAccountFromId(accountFrom.Id).Withdraw(amount);
                GetAccountFromId(accountTo.Id).Deposit(amount);
            }
            catch (FailedWithdrawalException ex)
            {
                throw new TransferFailedException("Transfer failed: Withdrawal from source account failed.", ex);
            }
        }


        /// <summary>
        /// auxiliar, populate combobox items
        /// </summary>
        /// <param name="cb"></param>
        public void ListAccountsCombo(ComboBox cb)
        {
            cb.Items.Clear();
            this.customer.Accounts.ForEach(account =>
            {
                cb.Items.Add(account);
            });
            cb.Refresh();

        }
        


    }


}
