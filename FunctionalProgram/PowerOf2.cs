using System;
namespace FunctionalPrograms
{
    internal class PowerOf2
    {
        public void Power(int argu)
        {
            for (int i = 0; i < argu && i < 31; i++)
            {
                Console.WriteLine("2^" + i + " = " + Math.Pow(2, i));
            }
        }
    }
}