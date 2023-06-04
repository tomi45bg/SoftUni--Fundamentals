using System;
using System.Linq;

namespace _04._Password_Validator
{
    internal class Program
    {
        static bool lengthCheck(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            } else
            {
                return false;
            }
        }

        static bool lettersAndDigits(string password)
        {
            int[] digits = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            char[] smallLetter = new char[26];
            char[] bigLetter = new char[26];

            int count1 = 97, count2 = 65;

            for (int i = 0; i < smallLetter.Length; i++)
            {
                smallLetter[i] = (char)count1;
                count1++;

                bigLetter[i] = (char)count2;
                count2++;
            }

            bool equalsSymbol = false;

            for (int i = 0; i < password.Length; i++)
            {
                int symbol1 = password[i] - '0';
                int symbol2 = password[i];

                for (int j = 0; j < digits.Length; j++)
                {
                    if (digits[j] == symbol1)
                    {
                        equalsSymbol = true;
                    }
                }

                for (int j = 0; j < smallLetter.Length; j++)
                {
                    if (smallLetter[j] == symbol2)
                    {
                        equalsSymbol = true;
                    }

                    if (bigLetter[j] == symbol2)
                    {
                        equalsSymbol = true;
                    }
                }

                if (!equalsSymbol)
                {
                    return false;
                }

                equalsSymbol = false;
            }

            return true;
        }

        static bool countDigits(string password)
        {
            int[] digits = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int count = 0;

            for (int i = 0; i < password.Length; i++)
            {
                int number = password[i] - '0';

                for (int j = 0; j < digits.Length; j++)
                {
                    if (number == digits[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            if (count >= 2)
            {
                return true;
            } else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool error = false;

            bool length = lengthCheck(password);
            if (!length)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                error = true;
            }

            bool checkLetterAndDigits = lettersAndDigits(password);
            if (!checkLetterAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                error = true;
            }

            bool checkOver2Digits = countDigits(password);
            if (!checkOver2Digits)
            {
                Console.WriteLine("Password must have at least 2 digits"); 
                error = true;
            }

            if (!error)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}