using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3Lab_visualC_
{
    internal struct Employee:IPayable, IComparable<Employee>
    {
		//private fields
		int id;
		int salary;
		int bonus;
		HiringDate hiringDate;
		Gender gender;
		SecurityPrivileges securityPrivileges;

        // static collection to stored id ==> hashset
        private static HashSet<int> usersId = new HashSet<int>();
		
		// properties
		public int ID
		{
			get { return id; }
			set 
			{
				if (usersId.Contains(value))
				{
					throw new Exception("Id already exist");
				}
				id = value;
				usersId.Add(value);
			}
		}

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)

                {
                    throw new Exception("salary must be > 0");
                }
                salary = value;
            }
        }

        public int Bonus
        {
            get { return bonus; }
            set
            {
                if (value < 0)

                {
                    throw new Exception("bonus must be > 0");
                }
                salary = value;
            }
        }

        //constructors
        public Employee(int _id, int _salary,int _bonus, HiringDate _hiringDate, Gender _gender, SecurityPrivileges _securityPrivileges )
		{
			ID = _id;
			Salary = _salary;
            hiringDate = _hiringDate;
            gender = _gender;
			securityPrivileges = _securityPrivileges;
            Bonus = _bonus;
		}


		// override methods
		public override string ToString()
		{
			return $" Employee ID: {ID} | Salary: {Salary:c} | HiringDate: {hiringDate.Print()} | Gender: {gender} | Security Privileges: {securityPrivileges}";
		}

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            return obj is Employee other && 
				
				Salary == other.Salary &&
                Bonus == other.Bonus &&
                hiringDate == other.hiringDate &&
				gender == other.gender &&
				securityPrivileges == other.securityPrivileges ;
                ;
        }

        public int CalcSalary()
        {
            return Salary + Bonus;
        }

        public int CompareTo(Employee other)
        {
            return Salary.CompareTo(other.Salary);
        }
    }
}
