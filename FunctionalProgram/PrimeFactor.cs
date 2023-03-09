using System;
namespace FunctionalPrograms
{
    internal class PrimeFactor
    {
        public void Prime(int N)
        {
            for (int i = 2; i < N; i++)
            {
                int count = 0;
                if (N % i == 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 2)
                        Console.WriteLine("Prime Factor " + i);
                }
            }
        }
    }
}