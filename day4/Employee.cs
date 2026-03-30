using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    // Restrict the Gender field to be only M or F

    public enum Gender
    {
        M, F
    }

    // Assign the security privileges
   

    public enum SecurityLevel {
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
            day = d;
        }
        public void setMonth(int m)
        {
            month = m;
        }
        public void setYear(int y)
        {
            year = y;
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
            Console.WriteLine($"{day} / {month} / {year}");
        }
    }
    internal struct Employee
    {
        int id;
        SecurityLevel security;
        double salary;
        HiringDate hireDate;
        Gender gender;
        string name;

        // Setters
        public void SetID(int empID) { id = empID; }
        public void SetSecurityLevel(SecurityLevel sec) { security = sec; }
        public void SetSalary(double sal) { salary = sal; }
        public void SetGender(Gender g) { gender = g; }
        public void SetHireDate(int d, int m, int y)
        {
            HiringDate hd = new HiringDate();
            hd.setDay(d);
            hd.setMonth(m);
            hd.setYear(y);
            hireDate = hd;
        }
        public  void SetName(string n)
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
