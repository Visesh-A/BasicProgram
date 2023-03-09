using System;
namespace FunctionalProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose an option to execute\n1.Flip coin \n2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter num of flips");
                        int num = Convert.ToInt32(Console.ReadLine());
                        FlipCoin flip = new FlipCoin();
                        flip.Flip(num);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }

        }
    }
}