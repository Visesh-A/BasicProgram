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
                Console.WriteLine("Choose an option to execute\n1.Flip coin \n2.Leap Year \n3.Power Of 2 \n4.Harmonic Number " +
                    "\n5.Prime Factor \n6.Quotient and Remainder \n7.Swap Number \n8.Even or Odd \n9.Vowel and Consonent \n10.Exit");
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
                        Console.WriteLine("Enter value");
                        int number = Convert.ToInt32(Console.ReadLine());
                        HarmonicNumber harmonic = new HarmonicNumber();
                        harmonic.Harm(number);
                        break;
                    case 5:
                        Console.WriteLine("Enter value");
                        int fact = Convert.ToInt32(Console.ReadLine());
                        PrimeFactor primeFactor = new PrimeFactor();
                        primeFactor.Prime(fact);
                        break;
                    case 6:
                        Console.WriteLine("Enter Dividend value");
                        int divi = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Diviser value");
                        int dend = Convert.ToInt32(Console.ReadLine());
                        QuotientRemainder quotientRemainder = new QuotientRemainder();
                        quotientRemainder.Quot(divi, dend);
                        break;
                    case 7:
                        Console.WriteLine("Enetr x value");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter y value");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Swap swap = new Swap();
                        swap.swap(num1, num2);
                        break;
                    case 8:
                        Console.WriteLine("Enetr a number");
                        int b = Convert.ToInt32(Console.ReadLine());
                        EvenOdd evenOdd = new EvenOdd();
                        evenOdd.Even(b);
                        break;
                    case 9:
                        Console.WriteLine("Enter the character");
                        char ch = Convert.ToChar(Console.ReadLine());
                        VowelsCons vowelsCons = new VowelsCons();
                        vowelsCons.conso(ch);
                        break;
                    case 10:
                        flag = false;
                        break;
                }
            }

        }
    }
}