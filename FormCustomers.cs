using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace BankApp
{
    public partial class FormCustomers : Form   // Task 2, Implement the customer and controller classes forms
    {
        CustomersController controller; // Controller Variable        
       
        /// <summary>
        /// Initializes a new instance of the <see cref="FormCustomers"/> class.
        /// </summary>

        public FormCustomers()
        {
            InitializeComponent();

            controller = new CustomersController(new StateController("customers.json")); //3. Design and implement a user interface: Controller implementation

        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            //controller.AddCustomer(new Staff(33, "Jhon Wayne", "123 Ny"));
            //controller.AddCustomer(new Client(44, "juami Bro", "345 south"));
            controller.LoadState();
            controller.PopulateList(listCustomers);
        }



        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)listCustomers.SelectedItem;
            if (customer == null)
            {
                MessageBox.Show("Select a customer to operate");
                return;
            }


            if (controller.RemoveCustomer(customer))
            {
                MessageBox.Show("Customer has been deleted");
            }
            controller.PopulateList(listCustomers);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            String name = textCustomerName.Text;
            String contact_info = textContactInfo.Text;
            Random random = new Random();
            if (name.Length == 0)
            {
                MessageBox.Show("Enter the customer name before create a account");
            }

            controller.AddCustomer(new Staff(random.Next(1, 200), name, contact_info));
            controller.PopulateList(listCustomers);

        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)listCustomers.SelectedItem; //selected customer to operate accounts

            //check if has selected a customer from listbox
            if (customer == null)
            {
                MessageBox.Show("Please select customer to operate accounts");
                return;
            }

            //show customer's accounts
            FormAccounts form = new FormAccounts(customer);
            form.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textCustomerName.Text;
            String contact_info = textContactInfo.Text;
            Random random = new Random();
            if (name.Length == 0)
            {
                MessageBox.Show("Enter the customer name before create a account");
            }

            controller.AddCustomer(new Client(random.Next(1, 200), name, contact_info));
            controller.PopulateList(listCustomers);
        }

        /// <summary>
        /// Handles the FormClosing event of the FormCustomers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void FormCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save state
            controller.SaveState();
        }
    }
}
