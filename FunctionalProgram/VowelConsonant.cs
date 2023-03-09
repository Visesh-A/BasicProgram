using System;
using System.ComponentModel.Design;

namespace FunctionalPrograms
{
    internal class VowelsCons
    {
        public void conso(char check)
        {
            switch (check)
            {
                case 'a':
                    Console.WriteLine("a is Vowel");
                    break;
                case 'A':
                    Console.WriteLine("A is Vowel");
                    break;
                case 'e':
                    Console.WriteLine("e is Vowel");
                    break;
                case 'E':
                    Console.WriteLine("E is Vowel");
                    break;
                case 'i':
                    Console.WriteLine("i is Vowel");
                    break;
                case 'I':
                    Console.WriteLine("I is Vowel");
                    break;
                case 'o':
                    Console.WriteLine("o is Vowel");
                    break;
                case 'O':
                    Console.WriteLine("O is Vowel");
                    break;
                case 'u':
                    Console.WriteLine("u is Vowel");
                    break;
                case 'U':
                    Console.WriteLine("U is Vowel");
                    break;
                default:
                    Console.WriteLine("It is a Consonant");
                    break;
            }
        }
    }
}