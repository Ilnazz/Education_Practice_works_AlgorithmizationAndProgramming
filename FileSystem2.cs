using System;
using System.IO;

namespace FileSystem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Third();
        }

        static void First()
        {
            string filePath = "/Users/232021/Desktop/Файлы/Сотрудники.txt";
            string[] employees = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Введите ФИО и должность {i + 1}-го сотрудника:");
                employees[i] = Console.ReadLine();
            }
            Console.WriteLine("Запись информации в файл.");
            StreamWriter sw = new StreamWriter(filePath);
            foreach (string employee in employees)
            {
                sw.WriteLine(employee);
            }
            sw.Close();

            Console.WriteLine("Чтение информации из файла.");
            StreamReader sr = new StreamReader(filePath);
            String line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }

        static void Second()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine();
            }

            string filePath = "/Users/232021/Desktop/Файлы/Таблица умножения.txt";
            Console.WriteLine("Генерация и запись таблицы умножения в файл.");
            StreamWriter sw = new StreamWriter(filePath);
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    sw.WriteLine($"{i} x {j} = {i * j}");
                }
                sw.WriteLine();
            }
            sw.Close();

            Console.WriteLine("Чтение таблицы умножения из файла.");
            StreamReader sr = new StreamReader(filePath);
            String line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }

        static void Third()
        {
            string filePath = "/Users/232021/Desktop/Файлы/Обращение.txt";
            Console.WriteLine("Запись обращения в файл.");
            StreamWriter sw = new StreamWriter(filePath);
            sw.WriteLine("Привет, 223 группа!");
            sw.WriteLine("Вы очень шумные на парах!");
            sw.WriteLine("Это надо исправлять.");
            sw.Close();
            Console.WriteLine("Обращение записано.");
        }
    }
}
