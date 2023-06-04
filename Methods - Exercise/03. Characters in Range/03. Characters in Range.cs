using System;
using System.Linq;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void betweenCharacters(char first, char second)
        {
            if ( (int) first <= (int)second)
            {
                for (int i = first + 1; i < second; i++)
                {
                    Console.Write((char) i + " ");
                }
            } else
            {
                for (int i = second + 1; i < first; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }

        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            betweenCharacters(firstChar, secondChar);
        }
    }
}