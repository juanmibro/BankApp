using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankApp
{/// <summary>
/// 
/// </summary>
    public partial class FormBank : Form 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormBank"/> class.
        /// </summary>
        public FormBank()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Handles the Click event of the btnShowCustomers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnShowCustomers_Click(object sender, EventArgs e) // Task 1.3.1 
        {
            FormCustomers form = new FormCustomers();
            form.Show();
        }
    }
}
