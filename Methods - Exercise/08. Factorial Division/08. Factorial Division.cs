using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNum = decimal.Parse(Console.ReadLine());
            decimal secondNum = decimal.Parse(Console.ReadLine());

            if (firstNum == 0)
            {
                firstNum = 1;
            }
            if (secondNum == 0)
            {
                secondNum = 1;
            }

            decimal result = Facturiel(firstNum) / Facturiel(secondNum);

            Console.WriteLine($"{result:f2}");

        }

        private static decimal Facturiel(decimal n)
        {
            decimal sum = 1;

            for (decimal i = n; i > 0; i--)
            {
                sum *= i;
            }

            return sum;
        }
    }
}
