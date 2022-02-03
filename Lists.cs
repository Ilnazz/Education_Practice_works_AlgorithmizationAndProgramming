using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
        }

        public static void First()
        {
            List<int> numbers = new List<int>();

            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                int n = random.Next(-10, 10);
                numbers.Add(n);
                Console.WriteLine(n);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 5)
                {
                    Console.WriteLine($"Число 5 находится на позиции {i}");
                }
            }

        }
    }
}
