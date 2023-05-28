using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] firstArr = new int[number];
            int[] secondArr = new int[number];

            bool flip = false;

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                int[] split = input.Split(" ").Select(int.Parse).ToArray();
                     
                if (!flip)
                {
                    firstArr[i] = split[0];
                    secondArr[i] = split[1];
                    flip = true;
                } else
                {
                    firstArr[i] = split[1];
                    secondArr[i] = split[0];
                    flip = false;
                }
            }

            for (int i = 0;i < number; i++)
            {
                Console.Write(firstArr[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < number; i++)
            {
                Console.Write(secondArr[i] + " ");
            }
        }
    }
}