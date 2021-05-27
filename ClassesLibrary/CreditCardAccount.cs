using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        //fields
        //N/A 

        //props
        public int AccountNumber { get; set; }
        public Customer CustomerInfo { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }

        //ctors
        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }

        public CreditCardAccount()
        {

        }
        //methods
        public override string ToString()
        {
            return string.Format("Account Number: {0}\n" +
                "Customer Info: {1}\n" +
                "Balance: {2:c}\n" +
                "Past Due? {3}\n" +
                "Interest Rate: {4}%", AccountNumber, CustomerInfo, Balance, IsPastDue ? "Yes" : "No", AnnualInterestRate);
        }

    }//end class
}//end namespace
