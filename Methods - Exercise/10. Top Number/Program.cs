using System;
using System.Linq;

namespace _10._Top_Number
{
    internal class Program
    {
        static void topNumbers(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int num = i;
                bool isDivisible8 = false;
                bool hasEven = false;
                int sum = 0;

                while (num > 0)
                {
                    sum += num % 10;

                    if ((num % 10) % 2 != 0)
                    {
                        hasEven = true;
                    }

                    num /= 10;
                }

                if (sum % 8 == 0)
                {
                    isDivisible8 = true;
                }

                if (hasEven && isDivisible8)
                {
                    Console.WriteLine(i);
                }

            }
        }

        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            topNumbers(endNumber);
        }
    }
}