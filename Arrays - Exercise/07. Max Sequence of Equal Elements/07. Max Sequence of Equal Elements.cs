using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int largestCount = 1;
            int numberToPrint = 0;
            int[] indexes = new int[array.Length];
            int[] numbers = new int[array.Length];
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; i < array.Length; j++)
                {
                    if (j == array.Length)
                    {
                        if (largestCount == 1)
                        {
                            largestCount = 1;
                            numberToPrint = array[i];
                        }
                        indexes[count] = largestCount;
                        numbers[count] = numberToPrint;
                        count++;

                        i = j - 1;

                        largestCount = 1;
                        numberToPrint = 0;
                        break;
                    }

                    if (array[i] == array[j])
                    {
                        largestCount++;
                        numberToPrint = array[i];
                    } else
                    {
                        if (largestCount == 1)
                        {
                            largestCount = 1;
                            numberToPrint = array[i];
                        }
                        indexes[count] = largestCount;
                        numbers[count] = numberToPrint;
                        count++;

                        i = j - 1;

                        largestCount = 1;
                        numberToPrint = 0;

                        break;
                    }
                }
            }

            int countToPrint = 1;
            int maxNumber = 0;

            for (int i = 0; i < indexes.Length; i++)
            {
                if (indexes[i] > countToPrint)
                {
                    countToPrint = indexes[i];
                    maxNumber = numbers[i];
                }
            }

            for (int i = 0; i < countToPrint; i++)
            {
                Console.Write(maxNumber + " ");
            }
        }
    }
}