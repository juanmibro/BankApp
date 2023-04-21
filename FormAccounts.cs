using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace BankApp
{



    /// <summary>
    /// FormAcounts
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FormAccounts : Form
    {
        AccountsController controller;
        Customer selectedCustomer = null;
        /// <summary>
        /// Initializes a new instance of the <see cref="FormAccounts"/> class.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public FormAccounts(Customer customer)
        {
            InitializeComponent(); //system staff
            controller = new AccountsController(customer); //controler for accounts
           // controller.LoadState();
            Text = $"Account for : {customer}"; //caption title
            selectedCustomer = customer;

        }

        /// <summary>
        /// Updates the controls.
        /// </summary>
        private void UpdateControls()
        {
            controller.PopulateListbox(listAccounts);
        }
        /// <summary>
        /// Handles the Load event of the FormAccounts control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FormAccounts_Load(object sender, EventArgs e)
        {
            // controller.PopulateListbox(this.listAccounts); //list accounts
            UpdateControls();

        }
        /// <summary>
        /// Handles the Click event of the btnAddAccount control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            //add account
            controller.AddAccount(new Omni(random.Next(1, 100)));
            UpdateControls();
        }
        /// <summary>
        /// Handles the SelectedValueChanged event of the listAccounts control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void listAccounts_SelectedValueChanged(object sender, EventArgs e)
        {
            //show account info
            lbl_accont_info.Text = ((Account)listAccounts.SelectedItem).ToString();
        }
        /// <summary>
        /// Handles the Click event of the button4 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            //register a everyday account
            Random random = new Random();
            controller.AddAccount(new Everyday(random.Next(1, 100)));
            UpdateControls();
        }
        /// <summary>
        /// Handles the Click event of the button3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            //register a investment account
            Random random = new Random();
            controller.AddAccount(new Investment(random.Next(1, 100)));
            UpdateControls();
        }


        /// <summary>
        /// Handles the Click event of the btnDeleteAccount control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            Account account = (Account)listAccounts.SelectedItem;
            if (account == null)
            {
                MessageBox.Show("Please select an account to operate");
                return;
            }

            if (controller.RemoveAccount(account))
            {
                MessageBox.Show("The account has been deleted");
            }

            UpdateControls();
        }
        /// <summary>
        /// Handles the Click event of the btnDeposit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //perform a deposit logic

            Account selectedAccount = (Account)listAccounts.SelectedItem;
            double amount = Convert.ToDouble(textAmount.Text);

            if (selectedAccount == null)
            {
                MessageBox.Show("Please select a account to operate");
                return;
            }

            try
            {
                controller.DepositIntoAccountId(selectedAccount.Id, amount);

                MessageBox.Show($"You have deposited ${amount}");
                lbl_accont_info.Text = controller.GetAccountFromId(selectedAccount.Id).ToString();
            }
            catch (FailedWithdrawalException ex)
            {
                listboxOperations.Items.Add(ex.Message);
            }
            UpdateControls();


        }

        /// <summary>
        /// witdraw button logic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Account selected = (Account)listAccounts.SelectedItem; //get selected account from listbox
            double amount = Convert.ToDouble(textAmount.Text); //get amount

            if (selected == null) //if not selected account from listbox?
            {
                MessageBox.Show("Please select a account to operate"); //show warning message
                return; //exit without operations
            }

            try //secure block
            {
                controller.WithdrawFromAccountId(selected.Id, amount); //do withdraw from account id
                MessageBox.Show($"You have withdrawn ${amount}"); //mesage

            }
            catch (FailedWithdrawalException ex)
            {
                listboxOperations.Items.Add(ex.Message); //capture exception from WithdrawFromAccountId...
            }

            lbl_accont_info.Text = controller.GetAccountFromId(selected.Id).ToString(); //get updated info from account
            UpdateControls();
        }


        /// <summary>
        /// btnTrnsference logic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            //center panel
            pnlTransfer.Location = new Point((Size.Width - pnlTransfer.Size.Width) / 2, (Size.Height - pnlTransfer.Size.Height) / 2);
            //show panel
            pnlTransfer.Visible = true;

            //populate account info objets
            controller.ListAccountsCombo(cbAccountFrom);
            controller.ListAccountsCombo(cbAccountTo);
            cbAccountFrom.SelectedIndex = -1; //mark to selected nothing
            cbAccountTo.SelectedIndex = -1;
            cbAccountFrom.Text = "";
            cbAccountTo.Text = "";


            textTransferAmount.Text = 0.ToString();
        }

        /// <summary>
        /// btnDialogCancel logic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDialogCancel_Click(object sender, EventArgs e)
        {
            //hidee panel
            pnlTransfer.Visible = false;
        }

        /// <summary>
        /// btndialogAccept logic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDialogAcept_Click(object sender, EventArgs e)
        {
            //do transference between accounts
            pnlTransfer.Visible = false; //hide panel
            Account selectedFrom = (Account)cbAccountFrom.SelectedItem; //get from account
            Account selectedTo = (Account)cbAccountTo.SelectedItem; // get to account

            Account from = controller.GetAccountFromId(selectedFrom.Id); //get account info from controller
            Account to = controller.GetAccountFromId(selectedTo.Id); //get account info from controller
            double amount = Convert.ToDouble(textTransferAmount.Text); //get amount

            try
            {
                controller.TransferBetweenAccounts(from, to, amount);   //execute transference logic 
                MessageBox.Show($"You have transfered {amount:n2}$ from Account #{from.Id} to Account #{to.Id}");
            }
            catch (FailedWithdrawalException ex)
            {
                listboxOperations.Items.Add(ex.Message);
            }
            catch(TransferFailedException es)
            {
                listboxOperations.Items.Add(es.Message);
            }

            UpdateControls();
        }
        /// <summary>
        /// Handles the FormClosing event of the FormAccounts control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void FormAccounts_FormClosing(object sender, FormClosingEventArgs e)
        {
           // controller.SaveState();
        }
    }
}
