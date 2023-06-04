using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static bool isItPalidrome(int num)
        {
            bool result = true;
            string toNum = num.ToString();
            int count = 1;

            for (int i = 0; i < toNum.Length / 2; i++)
            {
                if (toNum[i] != toNum[toNum.Length - count])
                {
                    result = false;
                    break;
                }

                count++;
            }

            return result;
        }

        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while(command != "END")
            {
                int number = int.Parse(command);
                bool isPalidrome = isItPalidrome(number);

                if (isPalidrome)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                command = Console.ReadLine();
            }
        }
    }
}