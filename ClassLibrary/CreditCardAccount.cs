using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CreditCardAccount
    {
        public int AccountNumber { get; set; }
        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualIntrestRate { get; set; }

        public CreditCardAccount(int accountNumber, Customer customer, decimal balance, bool isPastDue, decimal annualIntrestRate)
        {
            AccountNumber = accountNumber;
            Customer = customer;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualIntrestRate = annualIntrestRate;
        }

        public CreditCardAccount() { }

        public override string ToString()
        {
            return string.Format("\nAccount Number: {0}\n Customer: {1}\nBalance: {2:c}\nIs Past Due: {3}\nAnnual Intrest Rate: {4}%",
                AccountNumber,
                Customer.ToString(),
                Balance,
                IsPastDue,
                AnnualIntrestRate);
        }

    }



}





