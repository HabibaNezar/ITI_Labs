using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_Employee
{
    internal abstract class Employee
    {
        // fields
        int _id;
        string _name;
        double _salary;
        Client[] _clients;
        
        // properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public Client[] Clients
        {
            get 
            {
                return _clients;
            }
            set { 
                if(_clients == null || value.Length == _clients.Length)
                {
                    _clients = value;
                }
                else
                {
                    Console.WriteLine("The number of clients must match the initialized array size.");
                }
            }
        }
    
        // constructor
        // dfault constructor
        public Employee()
        {

        }

        // parametrized constructor
        public Employee(int id, string name, double salary, int numberOfClients, Client[] clients)
        {
            ID = id;
            Name = name;
            Salary = salary;
            Clients = clients;
        }

        // methods
        // abstract method
        public abstract void ShowEmployeeDetails();

    }
}
