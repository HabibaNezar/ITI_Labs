using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_class
{
    // Restrict the Gender field to be only M or F
    public enum Gender
    {
        M, F
    }

    // Assign the security privileges
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    // Struct to represent the HiringDate
    public struct HiringDate
    {
        int day;
        int month;
        int year;

        // setter
        public void setDay(int d)
        {
            if(d>=1 && d<=31)
            day = d;
            else
            {
                Console.WriteLine("Enter a valid day between 1 and 31");
            }
        }
        public void setMonth(int m)
        {
            if (m >= 1 && m <= 12)
                month = m;
            else
            {
                Console.WriteLine("Enter a valid month between 1 and 12");
            }
        }
        public void setYear(int y)
        {
            if (y >= 2000 && y <= 2026)
                year = y;
            else
            {
                Console.WriteLine("Enter a valid year between 2000 to 2026");
            }
        }


        //getter
        public int getDay()
        {
            return day;
        }
        public int getMonth()
        {
            return month;
        }
        public int getYear()
        {
            return year;
        }
        public void print()
        {
            Console.WriteLine($"{day}/{month}/{year}");
        }
    }
    public class Employee
    {
        int id;
        SecurityLevel security;
        double salary;
        HiringDate hireDate;
        Gender gender;
        string name;

        //constructors

        public Employee()
        {

        }
        public Employee(int i, string n,  int s){
            id = i;
            name = n;
            salary = s;
            Console.WriteLine($"your id is {i} \n yor name is {n} \n your salary is {s}");
        }

        public Employee(SecurityLevel s):this(5, "esraa" , 30000 )
        {
            s = security;
            Console.WriteLine($"your security level is {s}");
        }
        // Setters
        public void SetID(int empID) { id = empID; }
        public void SetSecurityLevel(SecurityLevel sec) { 
            if(!Enum.IsDefined(typeof(SecurityLevel), sec))
            {
                Console.WriteLine("Enter valid Security Level (0: Guest, 1: Developer, 2: Secretary, 3: DBA):");
            }
            else
            {
                security = sec;
            }
        }
        public void SetSalary(double sal) { salary = sal; }
        public void SetGender(Gender g) {
            if (!Enum.IsDefined(typeof(Gender) , g))
            {
                Console.WriteLine("Enter a valid gender just 'M' of 'F'");
            }
            else
            {
                gender = g;
            }
        }
        public void SetHireDate(int d, int m, int y)
        {
            HiringDate hd = new HiringDate();
            hd.setDay(d);
            hd.setMonth(m);
            hd.setYear(y);
            hireDate = hd;
        }
        public void SetName(string n)
        {
            name = n;
        }

        //  Getters
        public int GetID() { return id; }
        public SecurityLevel GetSecurityLevel() { return security; }
        public double GetSalary() { return salary; }
        public Gender GetGender() { return gender; }
        public HiringDate GetHireDate() { return hireDate; }

        public string GetName() { return name; }

        // e- Print Method
        public void Print()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Employee ID    : {id}");
            Console.WriteLine($"Gender         : {(gender == Gender.M ? "Male (M)" : "Female (F)")}");
            Console.WriteLine($"Salary         : ${salary}");

            Console.Write("Hire Date      : ");
            hireDate.print();
            Console.WriteLine();

            Console.WriteLine($"Security Level : {security}");
            Console.WriteLine("-------------------------------");
        }
    }
}
