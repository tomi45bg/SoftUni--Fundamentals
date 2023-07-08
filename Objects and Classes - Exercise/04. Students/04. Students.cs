using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < countStudents; i++)
            {
                List<string> texts = Console.ReadLine().Split(" ").ToList();
                Student student = new Student(texts[0], texts[1], float.Parse(texts[2]));
                students.Add(student);
            }

            sortStudents(students);

            for (int i = 0; i < students.Count; i++)
            {
                students[i].Print();
            }
        }

        static void sortStudents(List<Student> students)
        {
            for(int i = 0; i < students.Count; i++) 
            {
                for (int j = i + 1; j < students.Count; j++)
                {
                    if (students[i].Mark < students[j].Mark)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, float mark)
        {
            FirstName = firstName;
            LastName = lastName;
            Mark = mark;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Mark { get; set; }

        public void Print()
        {
            Console.WriteLine($"{FirstName} {LastName}: {Mark:f2}");
        }
    }
}