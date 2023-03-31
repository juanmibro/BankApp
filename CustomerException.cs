using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    public class FailedWithdrawalException : Exception
    {
        //public FailedWithdrawalException(string message) : base(message)
        //{   }

        public FailedWithdrawalException(string AccountType,int Id,  double WithDrawal, double Fee, double Balance): base($"{AccountType} {Id} ; withdrawal ${WithDrawal}; transaction failed; fee ${Fee}; balance ${Balance:N2}")
        {

        }
    }
}
