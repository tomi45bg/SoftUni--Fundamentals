namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            for (int i = 0;i < count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine(sum);
        }
    }
}