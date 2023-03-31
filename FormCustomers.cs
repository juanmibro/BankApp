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

        public FormCustomers()
        {
            InitializeComponent();

            controller = new CustomersController(); //3. Design and implement a user interface: Controller implementation

        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            controller.AddCustomer(new Staff(33, "Jhon Wayne", "123 Ny"));
            controller.AddCustomer(new Client(44, "juami Bro", "345 south"));
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
            Random random= new Random();
            if (name.Length == 0)
            {
                MessageBox.Show("Enter the customer name before create a account");
            }

            controller.AddCustomer(new Staff(random.Next(1,200), name, contact_info));
            controller.PopulateList(listCustomers);
           
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            FormAccounts form = new FormAccounts((Customer) listCustomers.SelectedItem);
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
    }
}
