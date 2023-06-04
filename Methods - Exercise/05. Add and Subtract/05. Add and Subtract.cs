using System;
using System.Linq;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static int sum(int a, int b)
        {
            return a + b;
        }

        static int subtract(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int num4 = sum(num1, num2);
            int num5 = subtract(num4, num3);

            Console.WriteLine(num5);
        }
    }
}