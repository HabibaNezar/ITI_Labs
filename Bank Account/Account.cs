using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    internal class Account
    {
        // fields
        double accountBalance;

        // properties

        public double Balance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }


        // constructors
        // constructor to assign the initial balance
        public Account(double balance)
        {
            if (balance < 0)
            {
                accountBalance = 0;
            }
            else
            {
                accountBalance = balance;
            }
        }

        // member functions
        public void credit(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Amount to credit must be positive.");
            }
            else
            {
                accountBalance += amount;
            }
        }

        public void debit(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Amount to credit must be positive.");
            }
            if (amount > accountBalance)
            {
                Console.WriteLine("Debit amount exceeded account balance.");
            }
            else
            {
                accountBalance -= amount;

            }
        }
        public double getBalance()
        {
            return accountBalance;
        }

    }
}
