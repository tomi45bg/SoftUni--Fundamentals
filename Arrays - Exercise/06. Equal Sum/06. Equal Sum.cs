using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int leftSum = 0, rightSum = 0;
            int numberIndex = 0;
            bool equals = false;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }

                for (int j = i + 1; j < array.Length; j++)
                {
                    rightSum += array[j];
                }

                if (leftSum == rightSum)
                {
                    numberIndex = i;
                    equals = true;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }

            if (!equals)
            {
                Console.WriteLine("no");
            } else
            {
                Console.WriteLine(numberIndex);
            }
        }
    }
}