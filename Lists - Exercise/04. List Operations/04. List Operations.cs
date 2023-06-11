using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace _04._List_Operations
{
    internal class Program
    {
        static void add(List<int> list, string num)
        {
            int number = int.Parse(num);

            if (number < 0 || number > list.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else 
            { 
                list.Add(number);
            }
        }

        static void remove(List<int> list, string num)
        {
            int number = int.Parse(num);

            if (number < 0 || number > list.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                list.RemoveAt(number);
            }
        }

        static void insert(List<int> list, int num, int index)
        {
            if (index < 0 || index > list.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                list.Insert(index, num);
            }
        }

        static void left(List<int> list, int num)
        {
            while (num != 0)
            {
                int currentnumber = list[0];
                list.RemoveAt(0);
                list.Add(currentnumber);
                num--;
            }
        }

        static void right(List<int> list, int num)
        {
            while (num != 0)
            {
                int currentnumber = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                list.Insert(0, currentnumber);
                num--;
            }
        }

        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                List<string> strings = command.Split(" ").ToList();

                if (strings.Count == 2)
                {
                    if (strings[0] == "Add")
                    {
                        add(ints, strings[1]);
                    } else
                    {
                        remove(ints, strings[1]);
                    }
                } else
                {
                    if (strings[0] == "Insert")
                    {
                        int number = int.Parse(strings[1]);
                        int index = int.Parse(strings[2]);

                        insert(ints, number, index);
                    }

                    if (strings[1] == "left")
                    {
                        left(ints, int.Parse(strings[2]));
                    }
                    else 
                    {
                        right(ints, int.Parse(strings[2]));
                    }
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