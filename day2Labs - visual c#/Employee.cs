using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2Labs___visual_c_
{
    internal class Employee
    {
        public int ID { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public Gender Gender { get; set; }

        // Constructor
        public Employee(int id, decimal salary, HiringDate hireDate, Gender gender)
        {
            ID = id;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public override string ToString()
        {
            // Notice the :c format specifier for the Salary property
            return $"ID: {ID} | Gender: {Gender} | Salary: {Salary:c} | Hire Date: {HireDate}";
        }

        // Compare state, not identity
        public override bool Equals(object obj)
        {
            if (obj is Employee other)
            {
                return ID == other.ID &&
                       Salary == other.Salary &&
                       HireDate.Equals(other.HireDate) &&
                       Gender == other.Gender;
            }
            return false;
        }

        
    }
}
