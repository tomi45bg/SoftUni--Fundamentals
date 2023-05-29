using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            int[] firstNum = new int[array.Length];
            int[] secondNum = new int[array.Length];
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == num)
                    {
                        firstNum[count] = array[i];
                        secondNum[count] = array[j];
                        count++;
                    }

                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(firstNum[i] + " " + secondNum[i]);
            }
        }
    }
}