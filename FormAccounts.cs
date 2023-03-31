using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace BankApp
{

    


    public partial class FormAccounts : Form
    {
        AccountsController controller;

        public FormAccounts(Customer customer)
        {
            InitializeComponent();
            controller = new AccountsController(customer);
            Text = $"Account for : {customer.ToString()}";


        }

        private void FormAccounts_Load(object sender, EventArgs e)
        {
            controller.ListAccounts(this.listAccounts);
            
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            Random random= new Random();
            //add account
            controller.RegisterAccount(new Omni(random.Next(1, 100)));
            controller.ListAccounts(this.listAccounts);
        }

        private void listAccounts_SelectedValueChanged(object sender, EventArgs e)
        {
            //show account info
            lbl_accont_info.Text = ((Account) listAccounts.SelectedItem).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            controller.RegisterAccount(new Everyday(random.Next(1, 100)));
            controller.ListAccounts(this.listAccounts);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            controller.RegisterAccount(new Investment(random.Next(1, 100)));
            controller.ListAccounts(this.listAccounts);
        }

    

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            Account account= (Account) listAccounts.SelectedItem;
            if (account == null)
            {
                MessageBox.Show("Please select an account to operate");
                return; 
            }

            if (controller.UnregisterAccount(account))
            {
                MessageBox.Show("The account has been deleted");
            }
            
            controller.ListAccounts(listAccounts);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {



            Account account = (Account)listAccounts.SelectedItem;
            double amount = Convert.ToDouble(textAmount.Text);

            if (account == null)
            {
                MessageBox.Show("PLease select a account to operate");
                return;
            }

            try
            {
            
                controller.DepositIntoAccount(account, amount);
                MessageBox.Show($"You have deposited ${amount}");
                lbl_accont_info.Text = account.ToString();
            }
            catch (FailedWithdrawalException ex)
            {
                listboxOperations.Items.Add(ex.Message);
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Account account = (Account)listAccounts.SelectedItem;
            double amount = Convert.ToDouble(textAmount.Text);

            if (account == null)
            {
                MessageBox.Show("PLease select a account to operate");
                return;
            }
            try
            {
                controller.WithdrawlFromAccount((Account)listAccounts.SelectedItem, amount);
                MessageBox.Show($"You have withdrawn ${amount}");
                lbl_accont_info.Text = account.ToString();
            }
            catch (FailedWithdrawalException ex)
            {
                listboxOperations.Items.Add(ex.Message);
            }
            }
        }
}
