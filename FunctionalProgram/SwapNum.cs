using System;
namespace FunctionalPrograms
{
    internal class Swap
    {
        public void swap(int x, int y)
        {
            Console.WriteLine("Before Swap x = " + x + " y= " + y);
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("After Swap x = " + x + " y = " + y);
        }
    }
}