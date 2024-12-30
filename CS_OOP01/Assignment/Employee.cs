using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public enum SecurityLevel
    {
        Guest, Developer, secretary, DBA, SecurityOfficer
    }
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        private double salary;
        public double Salary
        {
            get { return salary; }
            set 
            {
                if (value > 1) 
                    salary = value;
            }
        }

        public HiringDate HiringDate { get; set; }

        private char gender;
        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'm' || value == 'f')
                    gender = value;
            }
        }

        public Employee() { }
        public Employee(int id, string name, char gender, SecurityLevel securityLevel,
            double salary, HiringDate hiringDate)
        {
            Id = id;
            Name = name;
            Gender = gender;
            SecurityLevel = securityLevel;
            Salary = salary;
            HiringDate = hiringDate;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}\nName: {1}\nGender: {2}\n" +
                "Salary: {3}\nHiring Date: {4}\nSecurity Level: {5}",
                Id, Name, Gender, Salary,HiringDate, SecurityLevel);
        }

    }
}
