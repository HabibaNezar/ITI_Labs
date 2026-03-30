using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    internal class CheckingAccount:Account
    {
        // fields
        double fee;

        // properties
        public double Fee
        {
            get { return fee; }
            set { fee = value; }
        }


        // constructor 
        public CheckingAccount(double initialFee, double initialBalance) : base(initialBalance)
        {
            fee = initialFee;
        }

        // member function
        public void Credit(double amount)
        {
            //
            base.credit(amount);
            base.debit(fee);
        }

        public void debit(double amount)
        {
            if (amount + fee > getBalance())
            {
                Console.WriteLine("Debit amount plus fee exceeded account balance.");
            }
            else
            {
                base.debit(amount);
                base.debit(fee);
            }


        }
    }
}
