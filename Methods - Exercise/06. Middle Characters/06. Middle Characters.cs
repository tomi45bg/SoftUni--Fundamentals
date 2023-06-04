using System;
using System.Linq;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static string findMiddle(string text)
        {
            string middle = "";

            if (text.Length % 2 != 0)
            {
                middle += text[text.Length / 2];
            } else
            {
                middle += text[text.Length / 2 - 1];
                middle += text[text.Length / 2 ];
            }

            return middle;
        }

        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string middlePart = findMiddle(word);
            Console.WriteLine(middlePart);
        }
    }
}