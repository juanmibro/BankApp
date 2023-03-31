using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankApp
{
    public partial class FormBank : Form 
    {
        public FormBank()
        {
            InitializeComponent();

        }

        private void btnShowCustomers_Click(object sender, EventArgs e) // Task 1.3.1 
        {
            FormCustomers form = new FormCustomers();
            form.Show();
        }
    }
}
