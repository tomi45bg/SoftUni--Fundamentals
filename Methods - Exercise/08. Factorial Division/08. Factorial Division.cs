using System;
using System.Linq;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static int factoriel(int num)
        {
            int fact = 1;

            while (num > 0)
            {
                fact *= num;
                num -= 1;
            }

            return fact;
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int fact1 = factoriel(num1);
            int fact2 = factoriel(num2);
            int fact = fact1 / fact2;

            Console.WriteLine($"{fact:f2}");
        }
    }
}