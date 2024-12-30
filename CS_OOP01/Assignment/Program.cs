using System.Drawing;

namespace Assignment
{
    internal class Program
    {
        public static void SortEmpsByHiringDate(ref Employee[] empArr) 
        { 
            Employee temp = new Employee();
            for (int i = 0; i < empArr?.Length-1 ; i++)
            {
                for (int j = 1; j < empArr.Length; j++)
                {
                    if (empArr[j].HiringDate.Year < empArr[j-1].HiringDate.Year)
                    {
                        temp = empArr[j];
                        empArr[j] = empArr[j - 1];
                        empArr[j - 1] = temp;

                    }
                    else if (empArr[j].HiringDate.Month < empArr[j - 1].HiringDate.Month &&
                        empArr[j].HiringDate.Year < empArr[j - 1].HiringDate.Year)
                    {
                        temp = empArr[j];
                        empArr[j] = empArr[j - 1];
                        empArr[j-1] = temp;
                    }
                    else if (empArr[j].HiringDate.Day < empArr[j - 1].HiringDate.Day &&
                        empArr[j].HiringDate.Month < empArr[j - 1].HiringDate.Month &&
                        empArr[j].HiringDate.Year < empArr[j - 1].HiringDate.Year)
                    {
                        temp = empArr[j];
                        empArr[j] = empArr[j - 1];
                        empArr[j - 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            #region Part1
            #region Q1
            //Person[] people = new Person[3];
            //people[0] = new Person("Abdelrahman",22);
            //people[1] = new Person("Ahmed", 21);
            //people[2] = new Person("Omar", 22);

            //for (int i = 0; i < people?.Length; i++)
            //{
            //    Console.WriteLine(people[i]); // override ToString() method
            //    Console.WriteLine();
            //} 
            #endregion

            #region Q2
            //Point point1 = new Point();
            //Point point2 = new Point();

            //int x1,y1,x2, y2;
            //do
            //{
            //    Console.Write("Enter The first Point x: ");
            //}while (!int.TryParse(Console.ReadLine(),out x1));
            //do
            //{
            //    Console.Write("Enter The first Point y: ");
            //} while (!int.TryParse(Console.ReadLine(), out y1)); 
            //do
            //{
            //    Console.Write("Enter The Second Point x: ");
            //} while (!int.TryParse(Console.ReadLine(), out x2)); 
            //do
            //{
            //    Console.Write("Enter The Second Point y: ");
            //} while (!int.TryParse(Console.ReadLine(), out y2));

            //point1.X = x1;
            //point1.Y = y1;

            //point2.X = x2;
            //point2.Y = y2;

            //double distance = Math.Sqrt(Math.Pow((point2.Y - point1.Y), 2) + Math.Pow((point2.X - point1.X), 2));
            //Console.WriteLine($"Distance: {distance}"); 
            #endregion
            #endregion

            #region Part2
            //Employee employee = new Employee(123,"Abdelrahman",'m',SecurityLevel.Developer,20000,new HiringDate(5,10,2002));
            //Console.WriteLine(employee);

            //Employee[] empArr = new Employee[3];
            //empArr[0] = new Employee(123, "Abdelrahman", 'm', SecurityLevel.DBA, 20000, new HiringDate(5, 10, 2002));
            //empArr[1] = new Employee(456, "Toqa", 'f', SecurityLevel.Guest, 20000, new HiringDate(4, 5, 2003)); 
            //empArr[2] = new Employee(456,"Ahmed",'m',SecurityLevel.SecurityOfficer,20000,new HiringDate(21,7,2003));


            //Employee[] empArr = {
                
            //    new Employee(456,"Toqa",'f',SecurityLevel.Guest,20000,new HiringDate(4,5,2003)),
            //    new Employee(456,"Ahmed",'m',SecurityLevel.SecurityOfficer,20000,new HiringDate(21,7,2003)),
            //    new Employee(123,"Abdelrahman",'m',SecurityLevel.DBA,20000,new HiringDate(5,10,2002)),
            //};

            //for (int i = 0; i < empArr?.Length; i++)
            //{
            //    Console.WriteLine(empArr[i]); //overrride ToString()
            //    Console.WriteLine("===========================");
            //} 



            //// The Best Practice of Sorting By HiringDate using IComparable Interface
            ///
            //SortEmpsByHiringDate(ref empArr);
            //for (int i = 0; i < empArr?.Length; i++)
            //{
            //    Console.WriteLine(empArr[i]); //overrride ToString()
            //    Console.WriteLine("===========================");
            //}

            #endregion

        }
    }
}
