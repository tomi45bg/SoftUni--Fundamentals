using System;
using System.Linq;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static int smallestNumber(int a, int b, int c)
        {
            int smallestNum = int.MaxValue;


            if (a < smallestNum)
            {
                smallestNum = a;
            }

            if (b < smallestNum)
            {
                smallestNum = b;
            }

            if (c < smallestNum)
            {
                smallestNum = c;
            }

            return smallestNum;
        }


        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(smallestNumber(num1, num2, num3));
        }
    }
}