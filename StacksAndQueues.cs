using System;
using System.Collections.Generic;

namespace StacksAndDeques
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=====1=====");
            First();
            Console.WriteLine("=====2=====");
            Second();
            Console.WriteLine("=====3=====");
            Third();
            Console.WriteLine("=====4=====");
            Fourth();
            Console.WriteLine("=====5=====");
            Fifth();
        }

        public static void First()
        {
            Queue<int> q = new Queue<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                q.Enqueue(random.Next(-100, 100));
            }
            int lessThanTen = 0;
            foreach (int n in q)
            {
                Console.WriteLine(n);
                if (n < 10)
                {
                    lessThanTen++;
                }
            }
            Console.WriteLine($"Количество чисел < 10: {lessThanTen}.");
        }

        public static void Second()
        {
            Queue<string> employees = new Queue<string>();
            employees.Enqueue("Цезарь 60000");
            employees.Enqueue("Юлиан 90000");
            employees.Enqueue("Антоний 90000");
            employees.Enqueue("Александр 90000");

            double sumOfSalaries = 0;
            int numberOfEmployees = 0;
            foreach (string employee in employees)
            {
                string[] parts = employee.Split(' ');
                string name = parts[0];
                double salary = double.Parse(parts[1]);

                Console.WriteLine(name);

                sumOfSalaries += salary;
                numberOfEmployees++;
            }
            double averageSalary = sumOfSalaries / numberOfEmployees;
            Console.WriteLine($"Средний оклад: {averageSalary}");
        }

        public static void Third()
        {
            Queue<string> processors = new Queue<string>();
            processors.Enqueue("Intel_Celeron 1,6 1");
            processors.Enqueue("Intel_Xenon 3,0 4");
            processors.Enqueue("Intel_Core_I5_10400F 2,9 6");
            processors.Enqueue("AMD_Ryzen_3_2600 3,0 6");
            int multicoreProcessorsNumber = 0;
            foreach (string processor in processors)
            {
                string[] parts = processor.Split(' ');
                string name = parts[0];
                double frequency = double.Parse(parts[1]);
                int cores = int.Parse(parts[2]);

                Console.WriteLine($"Процессор {name} обладает частотой {frequency} Ghz и {cores} ядрами.");

                if (cores > 1)
                {
                    multicoreProcessorsNumber++;
                }
            }
            Console.WriteLine($"Количество многоядерных процессоров: {multicoreProcessorsNumber}");
        }

        public static void Fourth()
        {
            Stack<double> numbers = new Stack<double>();
            numbers.Push(-5.2); numbers.Push(72.3);
            numbers.Push(2.3); numbers.Push(18.4);
            numbers.Push(-16.3);

            double max = numbers.Peek();
            foreach (double n in numbers)
            {
                Console.WriteLine(n);
                if (n > max)
                {
                    max = n;
                }
            }
            Console.WriteLine($"Максимальное число в стеке: {max}");
        }

        public static void Fifth()
        {
            Stack<string> strings = new Stack<string>();
            strings.Push("223"); strings.Push("study");
            strings.Push("hello, group");
            strings.Push("are you ready");
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
            strings.Pop(); strings.Pop();
            Console.WriteLine("После удаления двух элементов из очереди:");
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }
    }
}
