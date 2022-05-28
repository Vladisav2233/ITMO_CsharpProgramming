using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_BankAccountCreatingAndUsingClasses
{
    using System;
    class BankAccount

    {

        public void Populate(long number, decimal balance)
        {
            accNo = number;
            accBal = balance;
            accType = AccountType.Checking;
        }
        public long Number()
        {
            return accNo;
        }
        public decimal Balance()
        {
            return accBal;
        }
        public string Type()
        {
            return accType.ToString();
        }
        private static long NextNumber()
        {
            return nextAccNo++;
        }
        public void Populate(decimal balance)
        {
            accNo = NextNumber();
            accBal = balance;
            accType = AccountType.Checking;
        }

        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo = 124;
    }

}
