using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace BankApp
{

    //public interface IAccount
    //{
    //    public int Id { get; set; }
    //    public double Balance { get; set; }
    //    public double Overdraft { get; set; }
    //    public double Fee { get; set; }

    //    public double Interest { get; set; }

    //    public string AccountType { get; set; }

    //    public void Withdraw(double amount);

    //    public void Deposit(double amount);

    //    public void CalculateInterest();

    //}

    /// <summary>
    /// 
    /// </summary>
    public abstract class Account
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        /// <value>
        /// The balance.
        /// </value>
        public double Balance { get; set; }
        /// <summary>
        /// Gets or sets the overdraft.
        /// </summary>
        /// <value>
        /// The overdraft.
        /// </value>
        public double Overdraft { get; set; }
        /// <summary>
        /// Gets or sets the fee.
        /// </summary>
        /// <value>
        /// The fee.
        /// </value>
        public double Fee { get; set; }
        /// <summary>
        /// Gets or sets the interest.
        /// </summary>
        /// <value>
        /// The interest.
        /// </value>
        public double Interest { get; set; }
        /// <summary>
        /// Withdraws the specified amount.
        /// </summary>
        /// <param name="Amount">The amount.</param>
        public abstract void Withdraw(double Amount);

        /// <summary>
        /// Deposits the specified amount.
        /// </summary>
        /// <param name="Amount">The amount.</param>
        public abstract void Deposit(double Amount);


        public string AccountType { get; set; }

        

        /// <summary>
        /// Calculates the interest.
        /// </summary>
        public abstract void CalculateInterest();
    }

    
    /// <summary>
    /// 
    /// AccountAdapter
    /// </summary>
    /// <seealso cref="BankApp.Account" />
    public class AccountAdapter: Account    
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAdapter"/> class.
        /// </summary>
        public AccountAdapter() { }

        /// <summary>
        /// Calculates the interest.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public override void CalculateInterest()
        {
            this.Balance += (this.Balance * this.Interest / 100);
        }

        /// <summary>
        /// Deposits the specified amount.
        /// </summary>
        /// <param name="Amount">The amount.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public override void Deposit(double Amount)
        {
            Balance += Amount;
        }
        /// <summary>
        /// Withdraws the specified amount.
        /// </summary>
        /// <param name="Amount">The amount.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public override void Withdraw(double Amount)
        {
            
            if (Balance > 0 && Balance >= Amount)
            {
                Balance -= Amount;
            }
        }
        /// <summary>
        /// Gets the account.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Account getAccount()
        {

            switch (AccountType)
            {
               
                case "Omni": 
                    var omni = new Omni(Id);
                    omni.Balance = Balance;
                    return omni;
                case "Investment": 
                    var investment = new Investment(Id);
                    investment.Balance = Balance;
                    return investment;
                default:  
                    var everyday = new Everyday(Id);
                    everyday.Balance = Balance;
                    return everyday;
            }
            
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BankApp.Account" />
    public class Omni : Account
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Omni"/> class.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        public Omni(int Id)
        {

            this.Id = Id;
            this.Fee = 10f;
            this.Balance = 0f;
            this.Interest = 4f;
            this.Overdraft = 100f;
            this.AccountType = "Omni";
                 

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Omni"/> class.
        /// </summary>
        public Omni() { }
        /// <summary>
        /// Deposits the specified amount.
        /// </summary>
        /// <param name="Amount">The amount.</param>
        public override void Deposit(double Amount)
        {
            this.Balance += Amount;
        }


        /// <summary>
        /// Withdraws the specified amount.
        /// </summary>
        /// <param name="Amount">The amount.</param>
        /// <exception cref="BankApp.FailedWithdrawalException">Omni</exception>
        public override void Withdraw(double Amount)
        {
            
            if (this.Balance < Amount)
            {

                //fee for failed transactions
                this.Balance -= Fee; //discount a fee for failed transaction
                throw new FailedWithdrawalException("Omni", Id, Amount, Fee, this.Balance);
                
            }

            CalculateInterest();
            this.Balance -= Amount;
         

        }
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
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
        /// <summary>
        /// Calculates the interest.
        /// </summary>
        public override void CalculateInterest()
        {
            // interest rates paid only on balances over $1000
            if (this.Balance > 1000f)
            {
                this.Balance += (this.Balance * this.Interest / 100f);
            }
            
        }
    }

    /// <summary>
    /// Everyday Account
    /// </summary>
    /// <seealso cref="BankApp.Account" />
    public class Everyday : Account
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Everyday"/> class.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        public Everyday(int Id)
        {
            this.Id = Id;
            this.Fee = 10f;
            this.Balance = 0f;
            this.Interest = 4f;
            this.Overdraft = 0f;
            this.AccountType = "Everyday";

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Everyday"/> class.
        /// </summary>
        public Everyday() { }

        /// <summary>
        /// Deposits the specified amount.
        /// </summary>
        /// <param name="Amount">The amount.</param>
        public override void Deposit(double Amount)
        {
            this.Balance += Amount;
        }

        /// <summary>
        /// Withdraws the specified amount.
        /// </summary>
        /// <param name="Amount">The amount.</param>
        /// <exception cref="BankApp.FailedWithdrawalException">Everyday</exception>
        public override void Withdraw(double Amount)
        {
            if (this.Balance < Amount)
            {
                this.Balance -= Fee; //no fee
                throw new FailedWithdrawalException("Everyday", Id, Amount, Fee, Balance);
            }
            this.CalculateInterest();
            this.Balance -= Amount;
        }
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
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
        /// <summary>
        /// Calculates the interest.
        /// </summary>
        public override void CalculateInterest()
        {
            this.Balance += (this.Balance * this.Interest / 100f);
        }
    }

    /// <summary>
    /// Investmen Class
    /// </summary>
    /// <seealso cref="BankApp.Account" />
    public class Investment : Account
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Investment"/> class.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        public Investment(int Id)
        {
            this.Id = Id;
            this.Fee = 10f;
            this.Balance = 0f;
            this.Interest = 4f;
            this.Overdraft = 0f;
            this.AccountType = "Investment";

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Investment"/> class.
        /// </summary>
        public Investment() { }


        /// <summary>
        /// Deposits the specified amount.
        /// </summary>
        /// <param name="Amount">The amount.</param>
        public override void Deposit(double Amount)
        {
            this.Balance += Amount;
        }


        /// <summary>
        /// Withdraws the specified amount.
        /// </summary>
        /// <param name="Amount">The amount.</param>
        /// <exception cref="BankApp.FailedWithdrawalException">Investment</exception>
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

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
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
        /// <summary>
        /// Calculates the interest.
        /// </summary>
        public override void CalculateInterest()
        {
            this.Balance += (this.Balance * this.Interest / 100f);
        }
    }


}
