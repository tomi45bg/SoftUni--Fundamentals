using System;
using System.Linq;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void matrix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for(int j = 0; j < number; j++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            matrix(num);
        }
    }
}