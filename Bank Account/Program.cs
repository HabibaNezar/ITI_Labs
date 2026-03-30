using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Checking Account 
            Console.WriteLine("--- Testing Checking Account ---");
            CheckingAccount checkingAcc = new CheckingAccount(10, 1000);
            checkingAcc.credit(500);
            Console.Write("Balance After Credit: ");
            Console.WriteLine(checkingAcc.getBalance());


            checkingAcc.debit(500);
            Console.Write("Balance After Debit: ");
            Console.WriteLine(checkingAcc.getBalance());
            Console.WriteLine();

            // Saving Account
            Console.WriteLine("--- Testing Saving Account ---");
            SavingsAccount savingAcc = new SavingsAccount(1000, 10);
            Console.Write("Interest in my saving Balance: ");
            double myInterest = savingAcc.calculateInterest();
            Console.WriteLine(myInterest);
            Console.Write("Balance after adding interest: ");
            savingAcc.credit(myInterest);
            Console.WriteLine(savingAcc.getBalance());
        }
    }
}
