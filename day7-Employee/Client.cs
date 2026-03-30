using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_Employee
{
    internal class Client
    {
        // fields
        int _id;
        string _name;
        string _city;

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
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        // constructors
        public Client(int id, string name, string city)
        {
            ID = id;
            Name = name;
            City = city; 
        }

        // methods
        public void ShowClientDetails()
        {
            Console.WriteLine("___ Client Details ___");
            Console.WriteLine($"Client id   : {ID}");
            Console.WriteLine($"Client name : {Name}");
            Console.WriteLine($"Client city : {City}");
            Console.WriteLine();
        }

    }
}
