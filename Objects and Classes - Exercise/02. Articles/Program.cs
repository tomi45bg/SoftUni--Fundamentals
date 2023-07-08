using System;
using System.Globalization;
using System.Linq;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(", ").ToList();
            Article article1 = new Article(data[0], data[1], data[2]);

            int countCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCommands; i++)
            {
                List<string> command = Console.ReadLine().Split(": ").ToList();

                if (command[0] == "Edit")
                {
                    article1.Edit(command[1]);
                } else if (command[0] == "ChangeAuthor")
                {
                    article1.ChangeAuthor(command[1]);
                } else
                {
                    article1.Rename(command[1]);
                }
            }

            article1.Print();
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

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        } 

        public void Print()
        {
            Console.WriteLine($"{Title} - {Content}: {Author}");
        }
    }
}