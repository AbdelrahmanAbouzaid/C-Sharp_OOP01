using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Person
    {
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (age >= 0)
                    age = value;
            }
        }
        public string Name { get; set; }
        public Person(string name, int age) 
        { 
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name: {Name} :: Age: {Age}";
        }

    }
}
