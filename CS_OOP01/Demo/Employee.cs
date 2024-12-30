using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Employee
    {
        private int id;
        private string name;
        private double salary;

        #region Apply Encapsulation Using Setter Getter Method

        // Apply Encapsulation Using Setter Getter Method

        // Setter Id
        //public void SetId(int id)
        //{
        //    this.id = id;
        //}

        //// Getter Id
        //public int GetId()
        //{
        //    return id;
        //}

        //// Setter Name
        //public void SetName(string name)
        //{
        //    this.name = name;
        //}

        //// Getter Name
        //public string GetName()
        //{
        //    return name;
        //}

        //// Setter Salary
        //public void SetSalary(double salary)
        //{
        //    if (salary > 0)
        //        this.salary = salary;
        //}

        ////Getter Salary
        //public double GetSalary()
        //{
        //    return salary;
        //}
        #endregion

        // Apply Encapsulation Using Properity
        #region 1. Full Property
        //  1. Full Property
        //  propfull
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                    salary = value;
            }
        }
        #endregion

        #region 2. Automatic Property
        // 2. Automatic Property
        // prop

        // CLR : Will Create Private Attribute <Address, Backing Field>
        public string Address { get; set; } 
        #endregion




        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {
            return $"Id: {id} :: Name: {name} :: Salary: {salary}";
        }


    }
}
