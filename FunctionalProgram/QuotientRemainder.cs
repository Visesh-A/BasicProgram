using System;
namespace FunctionalPrograms
{
    internal class QuotientRemainder
    {
        public void Quot(int dividend, int diviser)
        {
            int Quotient = dividend / diviser;
            int Remainder = dividend % diviser;
            Console.WriteLine("The Remainder is = " + Remainder);
            Console.WriteLine("The Quotient is = " + Quotient);

        }
    }
}