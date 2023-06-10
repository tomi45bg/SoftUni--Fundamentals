using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int max = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] command1 = new string[2];
                int number = 0;

                int num = 0;
                bool parsing = int.TryParse(command, out num);  
                if (parsing)
                {
                    number = int.Parse(command);

                    for (int i = 0; i < ints.Count; i++)
                    {
                        if (ints[i] + number <= max)
                        {
                            ints[i] += number;
                            break;
                        }
                    }
                } else
                {
                    command1 = command.Split(" ").ToArray();
                    ints.Add(int.Parse(command1[1]));
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < ints.Count; i++)
            {
                Console.Write(ints[i] + " ");
            }
        }
    }
}