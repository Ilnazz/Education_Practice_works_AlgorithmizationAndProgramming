using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
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

        public static void Second()
        {
            List<string> students = new List<string>();
            students.Add("Вадим"); students.Add("Ильмир");
            students.Add("Карим"); students.Add("Дима");
            students.Add("Семен"); students.Add("Никита");
            students.Add("Леонид"); students.Add("Егор");

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i}. {students[i]}");
            }

            students.RemoveAt(1); // Удаление второго студента
            students.Remove("Никита"); // Удаление студента с именем Никита

            Console.WriteLine("Список студентов после удаления 2-го студента и Никиты:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i}. {students[i]}");
            }

            // Удаление студентов, длина имени которых равна 4
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Length == 4)
                {
                    students.RemoveAt(i);
                }
            }

            Console.WriteLine("Список студентов после удаления студентов с длиной имени 4:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i}. {students[i]}");
            }

            students.Add("Николай"); students.Add("Александр");

            Console.WriteLine("Список студентов после добавления 2ух студентов:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i}. {students[i]}");
            }

            students.RemoveRange(1, 2);

            Console.WriteLine("Список студентов после удаления 2ух студентов, начиная с индекса 1:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i}. {students[i]}");
            }
        }

        public static void Third()
        {
            List<string> employees = new List<string>();
            employees.Add("Баранов"); employees.Add("Симонов");
            employees.Add("Аркадьева"); employees.Add("Маланина");
            employees.Add("Беляев"); employees.Add("Петровский");
            employees.Add("Михеева");

            foreach (string employee in employees)
            {
                Console.WriteLine(employee);
            }

            bool thereIsFiveCharactersSurname = false;
            string sixCharactersSurname = "";
            foreach (string employee in employees)
            {
                if (employee.Length == 5)
                {
                    thereIsFiveCharactersSurname = true;
                } else if (employee.Length == 6)
                {
                    sixCharactersSurname = employee;
                }
            }

            if (thereIsFiveCharactersSurname)
            {
                Console.WriteLine("В списке есть сотрудник с фамилией длиной 5 символов.");
            } else
            {
                Console.WriteLine("В списке нет сотрудника с фамилией длиной 5 символов.");
            }

            if (sixCharactersSurname != "")
            {
                Console.WriteLine($"Последняя фамилия в списке, состоящая из 6ти символов: {sixCharactersSurname}");
            } else
            {
                Console.WriteLine("В списке нет сотрудника с длиной фамилией равной 6ти символам.");
            }
        }

        public static void Fourth()
        {
            List<int> numbers = new List<int>();

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int n = random.Next(-10, 10);
                numbers.Add(n);
                Console.WriteLine(n);
            }

            Console.WriteLine("Элементы списка с 1-го по 3-ий:");
            List<int> firstThreeNumbers = numbers.GetRange(0, 3);
            foreach (int n in firstThreeNumbers)
            {
                Console.WriteLine(n);
            }

        }

        public static void Fifth()
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Исходный список случайных чисел:");
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                int n = random.Next(-100, 100);
                numbers.Add(n);
                Console.WriteLine($"{i}. {n}");
            }

            numbers.Reverse(); // Переворачивание списка

            Console.WriteLine("Список после переворачивания:");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"{i}. {numbers[i]}");
            }


            List<int> partOfNumbers = numbers.GetRange(2, 5); // Получение копии подсписка из 5ти чисел
            numbers.RemoveRange(2, 5); // Удаление подсписка из 5ти чисел из списка
            partOfNumbers.Reverse(); // Переворачивание копии подсписка из 5ти чисел
            numbers.InsertRange(2, partOfNumbers); // Вставка подспика обратно в исходный список

            Console.WriteLine("Список после переворачивания 5ти элементов начиная со 2го индекса:");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"{i}. {numbers[i]}");
            }
        }
    }
}
