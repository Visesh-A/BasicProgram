using System;
using System.ComponentModel.Design;

namespace FunctionalPrograms
{
    internal class LeapYear
    {
        public void Leap(int year)
        {
            if (year > 1000)
            {
                int a = (year % 4); int b = (year % 100); int c = (year % 400);
                if ((a == 0 && b != 0) || (c == 0))
                    Console.WriteLine(+year + "  " + " It is a Leap Year");
                else
                    Console.WriteLine(+year + "  " + "It is not a Leap Year");
            }
            else
                Console.WriteLine("Enetr the correct formate year");
        }
    }
}