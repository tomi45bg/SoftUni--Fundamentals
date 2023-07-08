using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static List<int> detonations(List<int> numbers, int number, int power)
        {
            int indexBomb = 0, leftDiff = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == number)
                {
                    indexBomb = i;
                    break;
                }
            }
            int index = indexBomb;
            int indexA = indexBomb;

            //left
            for (int i = 1; i <= power; i++)
            {
                if (indexBomb - 1 < 0)
                {
                    break;
                } else
                {
                    numbers.RemoveAt(indexBomb - 1);
                    leftDiff++;
                    indexBomb--;
                }
            }


            //right
            for (int i = 1; i <= power; i++)
            {
                if (index - power + 1 > numbers.Count)
                {
                    break;
                }
                else
                {
                    numbers.RemoveAt(index - power + 1);
                    index++;
                }
            }

            numbers.RemoveAt(indexA - leftDiff);

            return numbers;
        }

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int specialNumber = bomb[0];
            int power = bomb[1];

            numbers = detonations(numbers, specialNumber, power);

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}