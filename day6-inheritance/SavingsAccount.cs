using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_inheritance
{
    internal class SavingsAccount:Account
    {
        //fields
        double interestRate;

        //constructor to asign the initial values
        public SavingsAccount(double intialBalance , double rate):base(intialBalance)
        {
            interestRate = rate;
        }


        // member functions
        public double calculateInterest()
        {
            return (interestRate/100) * getBalance();
        }
    }
}
