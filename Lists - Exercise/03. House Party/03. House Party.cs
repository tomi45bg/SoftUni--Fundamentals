using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static List<string> execute(int count)
        {
            List<string> names = new List<string>();

            for (int i = 0; i < count; i++)
            {
                string command = Console.ReadLine();
                string[] arr = command.Split(' ').ToArray();

                if (arr.Length == 3)
                {
                    bool notOnList = false;

                    for (int j = 0; j < names.Count; j++)
                    {
                        if (arr[0] == names[j])
                        {
                            notOnList = true;
                            //"{name} is already in the list!"
                            Console.WriteLine($"{arr[0]} is already in the list!");
                            break;
                        }
                    }

                    if (!notOnList)
                    {
                        names.Add(arr[0]);
                    }
                } else
                {
                    bool notOnList = false;

                    for (int j = 0; j < names.Count; j++)
                    {
                        if (arr[0] == names[j])
                        {
                            notOnList = true;
                            names.RemoveAt(j);
                            //"{name} is already in the list!"
                            break;
                        }
                    }

                    if (!notOnList)
                    {
                        Console.WriteLine($"{arr[0]} is not in the list!");
                    }
                }
            }

            return names;
        }

        static void print(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> names = execute(count);
            print(names);
        }
    }
}