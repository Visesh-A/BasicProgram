using FunctionalProgram;
using System;
namespace FunctionalPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose an option to execute\n1.Flip coin \n2.Leap Year \n3.Power Of 2 \n4.Exit");
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
                        Console.WriteLine("Enter year");
                        int lee = Convert.ToInt32(Console.ReadLine());
                        LeapYear year = new LeapYear();
                        year.Leap(lee);
                        break;
                    case 3:
                        Console.WriteLine("Enter Power value");
                        int power = Convert.ToInt32(Console.ReadLine());
                        PowerOf2 powerof = new PowerOf2();
                        powerof.Power(power);
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }

        }
    }
}