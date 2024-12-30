using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo
{
    internal struct PhoneBook
    {
        string[] names;
        long[] numbers;
        public PhoneBook(int size)
        {
            this.names = new string[size];
            this.numbers = new long[size];
        }

        public void AddPerson(string name, long number, int index)
        {
            if (index < 0 || index >= names.Length)
            {
                Console.WriteLine("Invalid Index");
                return;
            }
            names[index] = name;
            numbers[index] = number;
        }
        public long GetNumder(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    return numbers[i];
            }
            return -1;
        }
        public void UpdateNumber(string name, long number)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    numbers[i] = number;
            }

        }
        public string GetName(long number)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] == number)
                    return names[i];
            }
            return "Not Found";
        }
        public void UpdateName(long number, string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] == number)
                    names[i] = name;
            }
        }

        //Indexer
        public long this[string name]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        return numbers[i];
                }
                return -1;
            }
            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        numbers[i] = value;
                }
            }
        }
        public string this[long number]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (numbers[i] == number)
                        return names[i];
                }
                return "Not Found";
            }
            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (numbers[i] == number)
                        names[i] = value;
                }
            }
        }
    }
}
