using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_Employee
{
    internal class PREmployee:Employee
    {
        
        // constructors
        public PREmployee(int id, string name, double salary, int n, Client[] clients) : base(id, name, salary, n, clients)
        {

        }
        
        // methods
        public override void ShowEmployeeDetails()
        {
            Console.WriteLine($"PREmployee id     : {ID}");
            Console.WriteLine($"PREmployee name   : {Name}");
            Console.WriteLine($"PREmployee salary : {Salary}");
            Console.WriteLine($"PREmployee clients : ");

            for (int i = 0; i < Clients.Length; i++)
            {
                if (Clients[i] != null)
                {
                    Clients[i].ShowClientDetails();
                }
            }
        }
    }
}
