using System;
using System.Linq;


namespace _02._Vowels_Count
{
    internal class Program
    {
        static int vowelsCount(string word)
        {
            //The vowels in the alphabet are a, e, i, o, u,

            int count = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' , 'A', 'E',
            'I', 'O', 'U' };

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (word[i] == vowels[j])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int count = vowelsCount(word);
            Console.WriteLine(count);
        }
    }
}