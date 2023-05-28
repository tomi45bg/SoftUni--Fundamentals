using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ").ToArray();
            int rotations = int.Parse(Console.ReadLine());

            string[] arr1 = arr;
            bool finished = false;

            if (arr.Length == rotations)
            {
                finished = true;

                for (int i = 0; i < arr.Length; i++) 
                {
                    Console.Write(arr[i] + " ");
                }
            } else
            {
                for(int i = 0;i < rotations; i++)
                 {
                    var end = arr[0];
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    arr[arr.Length - 1] = end;
                }
            }
             

            if (!finished)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    Console.Write(arr1[i] + " ");
                }
            }
        }
    }
}