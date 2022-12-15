using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Form1 : Form
    {

        Customer Me;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Me = new Customer("Juanmi", "wellintong city");
            this.Me.Accounts.Add(new Account(1, Account.AccountType.EVERYDAY, 1000));
            this.Me.Accounts.Add(new Account(2, Account.AccountType.INVESTMENT, 80, 0,0,10));
            this.Me.Accounts.Add(new Account(3, Account.AccountType.OMNI, 700,0,0,10));


            foreach (Account account in Me.Accounts)
            {
                listBox1.Items.Add(account);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            // deposit
            Account Selected =  listBox1.SelectedItem as Account;
            String message = Selected.Deposit(float.Parse(txtamount.Text));
            listBox2.Items.Add(message);
            listBox1.Invalidate();
            MessageBox.Show("Deposit with " + txtamount.Text+ ";Amount: " + Selected.Amount);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //withdraw
            Account Selected = listBox1.SelectedItem as Account;
            String message =  Selected.WithDraw(float.Parse(txtamount.Text));
            listBox2.Items.Add(message);

            listBox1.Invalidate();
            MessageBox.Show("Withdraw with " + txtamount.Text + ";Amount: " + Selected.Amount);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
