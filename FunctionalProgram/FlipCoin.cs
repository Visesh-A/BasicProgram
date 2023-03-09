using System;
namespace FunctionalProgram
{
    public class FlipCoin
    {
        const double VALIDATION_CHECK = 0.5;
        public void Flip(int NumofTimes)
        {
            int head = 0, tail = 0;
            Random random = new Random();
            for (int i = 0; i < NumofTimes; i++)
            {
                double value = random.NextDouble();
                if (value < VALIDATION_CHECK)
                    tail++;
                else
                    head++;
            }
            double headPercentage = (head * 100 / NumofTimes);
            double tailPercentage = (tail * 100 / NumofTimes);
            Console.WriteLine("Head Percentage---->  " + headPercentage + "\n Tail Percentage---->  " + tailPercentage);
        }
    }
}
