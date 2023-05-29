using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] greaterNumbers = new int[array.Length];
            int counter = 0, wrongCounter = 0;
            bool isGreater = true;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        isGreater = false;
                        wrongCounter++;
                        break;
                    }
                }

                if (isGreater)
                {
                    greaterNumbers[counter] = array[i];
                    counter++;
                } else
                {
                    isGreater = true;
                }
            }

            for (int i = 0; i < greaterNumbers.Length - wrongCounter; i++)
            {
                Console.Write(greaterNumbers[i] + " ");
            }
        }
    }
}