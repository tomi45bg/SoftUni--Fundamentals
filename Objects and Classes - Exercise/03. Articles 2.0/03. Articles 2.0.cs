using System;
using System.Globalization;
using System.Linq;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCommands; i++)
            {
                List<string> text = Console.ReadLine().Split(", ").ToList();
                Article art = new Article(text[0], text[1], text[2]);
                art.Print();
            }
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Print()
        {
            Console.WriteLine($"{Title} - {Content}: {Author}");
        }
    }
}