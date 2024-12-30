using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class HiringDate
    {
        private int day;

        public int Day
        {
            get { return day; }
            set
            {
                if (value >= 1 && value <= 31)
                    day = value;

            }
        }

        private int month;

        public int Month
        {
            get { return month; }
            set
            {
                if (value >= 1 && value <= 12)
                    month = value;

            }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 1)
                    year = value;

            }
        }



        public HiringDate()
        {
            Day = 1;
            Month = 1;
            Year = 1;
        }
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

    }
}
