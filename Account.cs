using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace BankApp
{
    public abstract class Account
    {

        public int Id { get; set; }
        public double Balance { get; set; }
        public double Overdraft { get; set; }
        public double Fee { get; set; }
        public double Interest { get; set; }

        public abstract void Withdraw(double Amount);

        public abstract void Deposit(double Amount);

        public abstract void CalculateInterest();
    }



// [X] For information about an omni account with ID 67 we would return a string containing the interest rate, overdraft limit, fee (for failed transaction) and the current balance of the account.The string returned would look something like this:
// [X] “Omni 67; Interest Rate 4%; Overdraft Limit $100; Fee $10; Balance $560.34;”

//For information about a failed withdrawal on an investment account with ID 23, the string returned might look like this:

//“Investment 23; withdrawal $700; transaction failed; fee $10; balance $620” Or for a transaction that calculates interest:
//“Omni 46; Add interest $5.60; balance $1320.43”

    public class Omni : Account
    {

        public Omni(int Id)
        {
            this.Id = Id;
            this.Fee = 10f;
            this.Balance = 0f;
            this.Interest = 4f;
            this.Overdraft = 100f;

        }
        public override void Deposit(double Amount)
        {
            this.Balance += Amount;
        }

    

        public override void Withdraw(double Amount)
        {
            
            if (this.Balance < Amount)
            {

                //fee for failed transactions
                this.Balance -= Fee; //discount a fee for failed transaction
                throw new FailedWithdrawalException("Omni", Id, Amount, Fee, this.Balance);
                
            }
            if (this.Balance > 1000)
            {
                CalculateInterest();
            }
            this.Balance -= Amount;
           

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Omni {this.Id}; ");
            sb.Append($"Interest Rate {this.Interest}%; ");
            sb.Append($"Overdraft Limit ${this.Overdraft}; ");
            sb.Append($"Fee ${this.Fee}; " );
            sb.Append($"Balance ${this.Balance.ToString("F")};");
            return sb.ToString();
        }

        public override void CalculateInterest()
        {
            // interest rates paid only on balances over $1000
            if (this.Balance > 1000f)
            {
                this.Balance += (this.Balance * this.Interest / 100f);
            }
            
        }
    }

    public class Everyday : Account
    {
        public Everyday(int Id)
        {
            this.Id = Id;
            this.Fee = 0f;
            this.Balance = 0f;
            this.Interest = 0f;
            this.Overdraft = 0f;

        }

        public override void Deposit(double Amount)
        {
            this.Balance += Amount;
        }
          

        public override void Withdraw(double Amount)
        {
            if (this.Balance < Amount)
            {
                //this.Balance -= Fee; //no fee
                throw new FailedWithdrawalException("Everyday", Id, Amount, Fee, Balance);
            }
            //this.CalculateInterest();
            this.Balance -= Amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Everyday {this.Id}; ");
            sb.Append($"Interest Rate {this.Interest}%; ");
            sb.Append($"Overdraft Limit ${this.Overdraft}; ");
            sb.Append($"Fee ${this.Fee}; ");
            sb.Append($"Balance ${this.Balance.ToString("F")};");
            return sb.ToString();
        }

        public override void CalculateInterest()
        {
            this.Balance += (this.Balance * this.Interest / 100f);
        }
    }

    public class Investment : Account
    {
        public Investment(int Id)
        {
            this.Id = Id;
            this.Fee = 10f;
            this.Balance = 0f;
            this.Interest = 0f;
            this.Overdraft = 0f;

        }

        public override void Deposit(double Amount)
        {
            this.Balance += Amount;
        }



        public override void Withdraw(double Amount)
        {
            if (this.Balance < Amount)
            {

                this.Balance -= Fee; //discount a fee for failed transaction
                throw new FailedWithdrawalException("Investment", Id, Amount, Fee, this.Balance);
            }
            CalculateInterest();
            this.Balance -= Amount;
                 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Investment {this.Id}; ");
            sb.Append($"Interest Rate {this.Interest}%; ");
            sb.Append($"Overdraft Limit ${this.Overdraft}; ");
            sb.Append($"Fee ${this.Fee}; ");
            sb.Append($"Balance ${this.Balance.ToString("F")};");
            return sb.ToString();
        }

        public override void CalculateInterest()
        {
            this.Balance += (this.Balance * this.Interest / 100f);
        }
    }


}
