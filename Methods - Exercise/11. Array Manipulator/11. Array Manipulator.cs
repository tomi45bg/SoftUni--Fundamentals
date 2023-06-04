using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void firstEvenOdd(int count, int[] array, string evenOrOdd)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            } else
            {
                if (evenOrOdd == "even")
                {
                    int c = 0;
                    int[] ints = new int[count];

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0)
                        {
                            ints[c] = array[i];
                            c++;
                        }

                        if (c == count)
                        {
                            break;
                        }
                    }

                    Console.Write("[");

                    for (int i = 0; i < c; i++)
                    {
                        if (i == c - 1)
                        {
                            Console.Write(ints[i]);
                            break;
                        }

                        Console.Write(ints[i] + ", ");
                    }

                    Console.Write("]");
                    Console.WriteLine();


                }
                else
                {
                    int c = 0;
                    int[] ints = new int[count];

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 1)
                        {
                            ints[c] = array[i];
                            c++;
                        }

                        if (c == count)
                        {
                            break;
                        }
                    }

                    Console.Write("[");

                    for (int i = 0; i < c; i++)
                    {
                        if (i == c - 1)
                        {
                            Console.Write(ints[i]);
                            break;
                        }

                        Console.Write(ints[i] + ", ");
                    }

                    Console.Write("]");
                    Console.WriteLine();

                }
            }
        }

        static void lastEvenOdd(int count, int[] array, string evenOrOdd)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (evenOrOdd == "even")
                {
                    int c = 0;
                    int[] ints = new int[count];

                    for (int i = array.Length - 1; i >= 0; i--)
                    {
                        if (array[i] % 2 == 0)
                        {
                            ints[c] = array[i];
                            c++;
                        }

                        if (c == count)
                        {
                            break;
                        }
                    }

                    Console.Write("[");

                    for (int i = c - 1; i >= 0; i--)
                    {
                        if (i == 0)
                        {
                            Console.Write(ints[i]);
                            break;
                        }

                        Console.Write(ints[i] + ", ");
                    }

                    Console.Write("]");
                    Console.WriteLine();


                }
                else
                {
                    int c = 0;
                    int[] ints = new int[count];

                    for (int i = array.Length - 1; i >= 0; i--)
                    {
                        if (array[i] % 2 == 1)
                        {
                            ints[c] = array[i];
                            c++;
                        }

                        if (c == count)
                        {
                            break;
                        }
                    }

                    Console.Write("[");

                    for (int i = c - 1; i >= 0; i--)
                    {
                        if (i == 0)
                        {
                            Console.Write(ints[i]);
                            break;
                        }

                        Console.Write(ints[i] + ", ");
                    }

                    Console.Write("]");
                    Console.WriteLine();
                }
            }
        }

        static void maxNumber(int[] array, string oddOrEven)
        {
            int maxNum = int.MinValue;
            bool flag = true;
            int maxIndex = 0;

            if (oddOrEven == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        if (array[i] > maxNum)
                        {
                            maxNum = array[i];
                            maxIndex = i;
                            flag = false;
                        }
                    }
                }
            } else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1)
                    {
                        if (array[i] > maxNum)
                        {
                            maxNum = array[i];
                            maxIndex = i;
                            flag = false;
                        }
                    }
                }
            }

            if (flag )
            {
                Console.WriteLine("No matches");
            } else
            {
                Console.WriteLine(maxIndex);
            }
        }

        static void minNumber(int[] array, string oddOrEven)
        {
            int minNum = int.MaxValue;
            bool flag = true;
            int minIndex = 0;

            if (oddOrEven == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        if (array[i] < minNum)
                        {
                            minNum = array[i];
                            minIndex = i;
                            flag = false;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1)
                    {
                        if (array[i] < minNum)
                        {
                            minNum = array[i];
                            minIndex = i;
                            flag = false;
                        }
                    }
                }
            }

            if (flag)
            {
                Console.WriteLine("No matches");
            } else
            {
                Console.WriteLine(minIndex);
            }

            
        }

        public static void exchange(int[] numbers, int index)
        {
            if (index >= 0 && index < numbers.Length)
            {
                int[] tempArray = new int[numbers.Length];

                for (int i = 0; i < numbers.Length; i++)
                {
                    tempArray[i] = numbers[i];
                }
                int counter = 0;

                for (int i = index + 1; i < numbers.Length; i++)
                {
                    numbers[counter] = tempArray[i];
                    counter++;
                }

                for (int i = 0; i <= index; i++)
                {
                    numbers[counter] = tempArray[i];
                    counter++;
                }
            }

            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int[] numbers = line.Split(" ").Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commands = command.Split(" ").ToArray();
                if (commands[0] == "first")
                {
                    if (commands[2] == "even")
                    {
                        int num = int.Parse(commands[1]);
                        firstEvenOdd(num, numbers, commands[2]);
                    } else
                    {
                        int num = int.Parse(commands[1]);
                        firstEvenOdd(num, numbers, commands[2]);
                    }
                }

                if (commands[0] == "last")
                {
                    if (commands[2] == "even")
                    {
                        int num = int.Parse(commands[1]);
                        lastEvenOdd(num, numbers, commands[2]);
                    }
                    else
                    {
                        int num = int.Parse(commands[1]);
                        lastEvenOdd(num, numbers, commands[2]);
                    }
                }

                if (commands[0] == "max")
                {
                    maxNumber(numbers, commands[1]);
                } else if (commands[0] == "min")
                {
                    minNumber(numbers, commands[1]);
                }

                if (commands[0] == "exchange")
                {
                    exchange(numbers, int.Parse(commands[1]));
                }

                command = Console.ReadLine();
            }

            Console.Write("[");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    Console.Write(numbers[i]);
                    break;
                } else
                {
                    Console.Write(numbers[i] + ", ");
                }
            }

            Console.Write("]");

        }
    }
}