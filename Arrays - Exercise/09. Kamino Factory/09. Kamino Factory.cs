using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int bestLengthGlobal = 0, bestSum = -1;
            int index = length, counter = 0;
            int[] bestSequence = new int[length];
            bool flag = false;

            while (command != "Clone them!")
            {
                int[] array = command.Split("!").Select(int.Parse).ToArray();
                int startingIndex = -1, sum = 0, length1 = 0;
                int bestLength = 0;
                counter++;

                bool first1 = true;

                for (int i = 0; i < array.Length; i++)
                {

                    if (array[i] == 1)
                    {
                        length1++;
                        sum++;

                        if (length1 >= bestLength)
                        {
                            bestLength = length1;
                            if (first1)
                            {
                                startingIndex = i;
                                first1 = false;
                            }
                        }
                    } else
                    {
                        length1 = 0;
                        first1 = true;
                    }
                }

                if (bestLength >= bestLengthGlobal && startingIndex <= index + 1) 
                {
                    if (sum > bestSum)
                    {
                        bestLengthGlobal = bestLength;
                        bestSum = sum;
                        index = counter;
                        bestSequence = array;
                        flag = true;
                    }

                    if (flag && bestLength != bestLengthGlobal && startingIndex 
                        != index + 1)
                    {

                        bestLengthGlobal = bestLength;
                        bestSum = sum;
                        index = counter;
                        bestSequence = array;
                    }
                }

                command = Console.ReadLine();
            }

            /*
             * 
             * "Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
                "{DNA sequence, joined by space}"
             * 
             */

            Console.WriteLine($"Best DNA sample {index} with sum: {bestSum}.");

            for (int i = 0; i < length; i++)
            {
                Console.Write(bestSequence[i] + " ");
            }
        }
    }
}