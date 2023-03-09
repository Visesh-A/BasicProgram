using System;
namespace FunctionalPrograms
{
    internal class EvenOdd
    {
        public void Even(int a)
        {
            if (a % 2 == 0)
                Console.WriteLine(+a + " It is a Even number");
            else
                Console.WriteLine(+a + " It is Odd number");
        }
    }
}