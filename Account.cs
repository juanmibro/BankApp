using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;

namespace BankApp
{
    internal class Account
    {
        public enum AccountType  {EVERYDAY,INVESTMENT, OMNI};

        public int Id { get; set; }
        public AccountType Account_type { get; set; }
        public float Amount { set; get; }

        private float Interest { get; set; }

        public float Feed { get; set; }
        public float Overdraft { get; set; }

        public Account(int id ,AccountType account_type = AccountType.EVERYDAY, float amount = 0f, float interest = 0f, float overdraft=0f, float fee = 0f)
        {
            //generate a hex sha1 code for id 
            Id = id;
            Account_type = account_type;
            Amount = amount;

            if (account_type == AccountType.EVERYDAY)
            {
                Interest = 0;
                Feed = 0;
                Overdraft = 0;
            } else if(account_type == AccountType.INVESTMENT)
            {
                Interest = interest;
                Feed = fee;
                Overdraft = overdraft;
            } else if (account_type == AccountType.OMNI)
            {
                Interest = interest;
                Feed = fee;
                Overdraft = overdraft;
            }
            


        }
        public string getinfo()
        {
            //Omni 67; Interest Rate 4 %; Overdraft Limit $100; Fee $10; Balance $560.34;

            StringBuilder sb = new StringBuilder();
            sb.Append( this.Account_type +  this.Id.ToString() + ";");
            sb.Append("Interest Rate: " + 4 + "%;");
            sb.Append("Overdraft Limit: $" + 100 + ";");
            sb.Append("Fee: $" + 10 + ";") ;
            sb.Append("Balance: $" + this.Amount);
            return sb.ToString();
        }

        public override string ToString()
        {
            string message = "";
            if (this.Account_type == AccountType.EVERYDAY)
            {
                message = "EVERYDAY " + this.Id + "; Interest Rate " + this.Interest + "%; Overdraft Limit $" + this.Overdraft + " ; Fee $" + this.Feed + "; Balance $" + this.Amount + ";";
            }
            else if(this.Account_type == AccountType.INVESTMENT)
            {
                message = "INVESTMENT " + this.Id + "; Interest Rate " + this.Interest + "%; Overdraft Limit $" + this.Overdraft + " ; Fee $" + this.Feed + "; Balance $" + this.Amount + ";";
            }
            else if (this.Account_type == AccountType.OMNI)
            {
             //   Omni 67; Interest Rate 4 %; Overdraft Limit $100; Fee $10; Balance $560.34;
                message = "OMNI " + this.Id + "; Interest Rate " + this.Interest + "%; Overdraft Limit $" + this.Overdraft + " ; Fee $" + this.Feed + "; Balance $" + this.Amount +";";

            }

            return message;
        }

        private bool TransactionIsSuccess()
        {
            Random rnd = new Random();
            return rnd.Next(100) >=50 ;
        }

        public string Deposit(float amount)
        {
            this.Amount += amount;
            return this.ToString();
        }

        public string WithDraw(float amount)
        {
            if (!TransactionIsSuccess())
            {
                var type_label = "";
                if (this.Account_type == AccountType.EVERYDAY)
                {
                    type_label = "EVERYDAY";
                } else if (this.Account_type == AccountType.INVESTMENT){
                    type_label = "INVESTMENT";
                }
                else if (this.Account_type == AccountType.OMNI)
                {
                    type_label = "OMNI";
                }
                // “Investment 23; withdrawal $700; transaction failed; fee $10; balance $620”
                var message = type_label + " " + this.Id + ";withdraw $" + amount + "; transaction failed; fee$ " + this.Feed + "; balance $" + this.Amount;
                return message;
            }

            this.Amount -= amount;
            return this.ToString();
        }
    }
}
