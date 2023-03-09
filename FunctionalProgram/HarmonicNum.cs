using System;
namespace FunctionalPrograms
{
    public class HarmonicNumber
    {
        public void Harm(double num)
        {
            double count;
            double result = 0;
            for (count = 1; count <= num; count++)
            {
                Console.WriteLine("1/" + count + "+", count);
                result += 1 / count;
            }
            Console.WriteLine("Harmonic value of " + num + " is " + result);
        }
    }
}