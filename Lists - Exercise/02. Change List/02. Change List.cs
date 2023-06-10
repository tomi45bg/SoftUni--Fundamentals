using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> list = command.Split(" ").ToList();
                if (list.Count == 2)
                {
                    for (int i = 0; i < integers.Count; i++)
                    {
                        if (integers[i] == int.Parse(list[1]))
                        {
                            integers.RemoveAt(i);
                        }
                    }
                } else
                {
                    integers.Insert(int.Parse(list[2]), int.Parse(list[1]));
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < integers.Count; i++)
            {
                Console.Write(integers[i] + " ");
            }
        }
    }
}