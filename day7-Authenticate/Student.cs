using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_Authenticate
{
    internal class Student
    {
        // property
        public int ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Userpass { get; set; }
        public string Email { get; set; }

        // constructors
        public Student(int id, string name, string username, string userpass, string email)
        {
            ID = id;
            Name = name;
            Username = username;
            Userpass = userpass;
            Email = email;
        }

        // methods
        public void Print()
        {
            Console.WriteLine("--- Student Details ---");
            Console.WriteLine($"Stusent id       : {ID}");
            Console.WriteLine($"Stusent name     : {Name}");
            Console.WriteLine($"Stusent userNamr : {Username}");
            Console.WriteLine($"Stusent userPass : {Userpass}");
            Console.WriteLine($"Stusent email    : {Email}");

        }
    }
}
