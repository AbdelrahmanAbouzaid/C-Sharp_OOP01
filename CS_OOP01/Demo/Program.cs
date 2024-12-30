namespace Demo
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            #region struct
            // struct : value type -> STACK

            //Point p01;
            // Declare For Object From Type 'Pooint'
            // p01: object
            // Allocate UnInitialized 8 Bytes at STACK (int x -> 4 bytes , int y -> 4 bytes)

            //p01.x = 5;
            //p01.y = 10;

            //Console.WriteLine(p01.x);
            //Console.WriteLine(p01.y);

            //p01 = new Point();
            // new : used for select the constructor 
            #endregion

            #region OOP Overview
            // OOP : Object Oriented Programmin
            // Programming Paradim

            //Class : BluePrint Of The Object
            //Object : Specific Insatance From Class

            // 4 Pillars
            //  1. Inheritance
            //  2. Encapsulation
            //  3. Polymorphism
            //  4. Abstraction 
            #endregion

            #region Encapsulation Using Getter Setter Methods
            // Encapsulation
            // Class or Struct
            // Seperate The Data(Attributes) Definition From Its Use
            //[Setter Getter Method - Properties]


            // Employee
            //   1. Emd User Access data itself
            //   2. No Data Validation
            //   3. No Read Only Fild

            // Apply Encapsulation: 
            //  1. Make All Data(Attributes) Private
            //  2. Access Data Through : 
            //      2.1. Setter and Getter Method
            //      2.2. Properties


            //Employee employee = new Employee();
            //employee.id = 1;
            //employee.name = "Ahmed";
            //employee.salary = 20000;


            //Employee employee = new Employee();
            //employee.SetId(1);
            //employee.SetName("Ahmed");
            //employee.SetSalary(20000);

            //Console.WriteLine(employee.GetId());
            //Console.WriteLine(employee.GetName());
            //Console.WriteLine(employee.GetSalary());

            //Employee employee = new Employee(1,"Ahmed",20000);
            //Console.WriteLine(employee); 

            #endregion

            #region Encapsulation Using Prpoerities
            // Apply Encapsolation Using Propeties:
            //  1. Full Properity
            //  2. Automatic Properity
            //  3. Special Properity [Indexer]

            //Employee employee = new Employee();
            //employee.Id = 1;
            //employee.Name = "Ahmed";
            //employee.Salary = 20000;

            //Console.WriteLine(employee.Id);
            //Console.WriteLine(employee.Name);
            //Console.WriteLine(employee.Salary);
            //Console.WriteLine(employee); 
            #endregion

            #region Indexer
            // Indexer : Special Property

            //PhoneBook phoneBook = new PhoneBook(3);
            //phoneBook.AddPerson("Ahmed", 123456, 0);
            //phoneBook.AddPerson("Abdelrahman", 456789, 1);
            ////phoneBook.AddPerson("Omar", 123789, 4); //invalid message

            ////Indexer
            //Console.WriteLine(phoneBook["Ahmed"]);
            //phoneBook["Ahmed"] = 111222;
            //Console.WriteLine(phoneBook["Ahmed"]);

            //Console.WriteLine(phoneBook[456789]);
            //phoneBook[456789] = "Abdo";
            //Console.WriteLine(phoneBook[456789]);

            #endregion

            #region Class
            // Class : Refernce Type -> HEAP

            //Car c01;
            // Declare For Reference(Pointer) From Datatype 'Car'
            // C01 : Can Refer To Object Fom Type 'Car' or Any Data Type Inherite From 'Car'

            // 8 Bytes Will Be Allocated At STACK For The Reference(Pointer)
            // 0 Bytes Will Be Allocated At HEAP

            //c01 = new Car();
            //new
            //Allocate The Number of Required Bytes (16+) At HEAP
            //Inintialized The Allocated Bytes With The Default Value Of Datatypes
            //Call User-Defined Constructor If Exist
            //Assign The Object To The Refernce 
            #endregion

        }
    }
}
