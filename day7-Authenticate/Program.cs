using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_Authenticate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(
                1,
                "Habiba",
                "habiba123",
                "pass123",
                "habiba@email.com"
            );

            Authenticate auth = new Authenticate(s1);

            // login test
            Console.WriteLine(auth.loginMethod("habiba123", "pass123", "habiba@email.com"));
            Console.WriteLine(auth.loginMethod("habiba@email.com", "pass123"));
            Console.WriteLine(auth.loginMethod(1, "pass123"));
            Console.WriteLine(auth.loginMethod(1, "habiba@email.com"));

            Console.WriteLine("------------");

            // forget password
            Console.WriteLine(auth.forgetPassword("habiba123"));
            Console.WriteLine(auth.forgetPassword("habiba@email.com", 1));
            Console.WriteLine(auth.forgetPassword(1));

            Console.WriteLine("------------");

            // reset password
            Console.WriteLine(auth.ResetPassword(1, "pass123", "newpass"));
            Console.WriteLine(auth.loginMethod(1, "newpass"));

            Console.WriteLine("------------");

            s1.Print();
        }
    }
}
