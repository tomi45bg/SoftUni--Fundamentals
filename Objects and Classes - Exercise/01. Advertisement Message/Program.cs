using System;
using System.Globalization;
using System.Linq;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Phrases – {"Excellent product.", "Such a great product.", "I always use that
                product.", "Best product of its category.", "Exceptional product.", "I can't
                    live without this product."}
•                Events – {"Now I feel good.", "I have succeeded with this product.", "Makes
                    miracles. I am happy of the results!", "I cannot believe but now I feel
                    awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}
•               Authors – {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}
•               Cities – {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}

             * 
             */

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string phrase = "";
                string events = "";
                string author = "";
                string city = "";

                string[] phrases = {"Excellent product.",
                    "Such a great product.", "I always use that product.",
                    "Best product of its category.", "Exceptional product.",
                    "I can't live without this product."};

                string[] eventsAll = {"Now I feel good.",
                    "I have succeeded with this product.",
                    "Makes miracles. I am happy of the results!",
                    "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.",
                    "I feel great!" };

                string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

                string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

                Random random = new Random();

                phrase = phrases[random.Next(phrases.Length)];
                events = eventsAll[random.Next(eventsAll.Length)];
                author = authors[random.Next(authors.Length)];
                city = cities[random.Next(cities.Length)];

                Console.WriteLine($"{phrase} {events} {author} – {city}.");
            }
        }
    }
}