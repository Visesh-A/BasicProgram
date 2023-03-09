using System;
namespace FunctionalPrograms
{
    internal class LargestNum
    {
        public void Largest(int a, int b, int c)
        {
            if (a > b && a > c)
                //return a;
                Console.WriteLine(+a + " is Largest number");
            if (b > a && b > c)
                //return b;
                Console.WriteLine(+b + " is largest number");
            else
                //return c;
                Console.WriteLine(+c + " is largest number");
        }
    }
}