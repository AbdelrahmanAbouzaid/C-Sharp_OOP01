using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Point
    {
        public int x;
        public int y;

        // Constructor : Special Method
        //              1. Named Like Struct
        //              2. Has No Return Type

        //If you didn't create colnstructor
        //CLR : will Create Parameterless Constructor
        // This Constructor Will Initialize All Attrebutes[Members] with The Default Value

        //public Point()
        //{

        //}

        // This Feature not Avilable in .Net 5.0 C# 9.0
        // This Feature Avilable in .Net 6.0 C# 10.0 and must set initial value for all memders
        // This Feature Avilable in .Net 7.0 C# 11.0 whit autu defauly value
        

        public Point()
        {
            x = 5;
            y = 10;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }






        public override string ToString()
        {
            return $"({x} , {y})";
        }

    }
}
