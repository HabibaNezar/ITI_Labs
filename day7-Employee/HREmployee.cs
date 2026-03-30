using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_Employee
{
    internal class HREmployee:Employee
    {
        // constructor
        public HREmployee(int id, string name, double salary, int n , Client[] clients) :base(id, name, salary, n, clients)
        {
        }
        // methods

        public static HREmployee operator +(HREmployee a, HREmployee b)
        {
            // Combine clients from both employees
            Client[] combinedClients = new Client[a.Clients.Length + b.Clients.Length];
            a.Clients.CopyTo(combinedClients, 0);
            b.Clients.CopyTo(combinedClients, a.Clients.Length);

            // Return a merged HREmployee object
            return new HREmployee(0, $"{a.Name} & {b.Name}", a.Salary + b.Salary, a.Clients.Length + b.Clients.Length, combinedClients);
        }

        // Operator Overloading for '>' and '<'
        public static bool operator >(HREmployee a, HREmployee b)
        {
            return a.Salary > b.Salary;
        }

        public static bool operator <(HREmployee a, HREmployee b)
        {
            return a.Salary < b.Salary;
        }

        // Operator Overloading for '>=' and '<='
        public static bool operator >=(HREmployee a, HREmployee b)
        {
            return a.Salary >= b.Salary;
        }

        public static bool operator <=(HREmployee a, HREmployee b)
        {
            return a.Salary <= b.Salary;
        }
        public override void ShowEmployeeDetails()
        {
            Console.WriteLine($"HREmployee id     : {ID}");
            Console.WriteLine($"HREmployee name   : {Name}");
            Console.WriteLine($"HREmployee salary : {Salary}");
            Console.WriteLine($"HREmployee clients : ");

            for (int i=0; i<Clients.Length; i++)
            {
                if (Clients[i] != null)
                {
                    Clients[i].ShowClientDetails();
                }
                
            }
        }
    }
}
