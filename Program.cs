using System;

namespace CourseWork375_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i <= 7; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0 || number > 200) 
                {
                    sum += number;
                }
            }
            Console.WriteLine($"The sum is:{sum}");
        }
    }
}
