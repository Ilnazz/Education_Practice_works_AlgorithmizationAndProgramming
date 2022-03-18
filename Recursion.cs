using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //First
            //Console.WriteLine("Введите числа A и B:");
            //int A = int.Parse(Console.ReadLine()),
            //    B = int.Parse(Console.ReadLine());
            //First(A, B);
            Console.Write("\nОт -10 до 10: ");
            First(-10, 10);
            Console.Write("\nОт 10 до -10: ");
            First(10, -10);
            Console.WriteLine();

            //Second
            //Console.WriteLine("Введите числа m и n:");
            //int m = int.Parse(Console.ReadLine()),
            //    n = int.Parse(Console.ReadLine());
            //Console.WriteLine(Akkerman(m, n));

            Console.WriteLine($"Аккерман(0, 0): {Akkerman(0, 0)}");
            Console.WriteLine($"Аккерман(0, 1): {Akkerman(0, 1)}");
            Console.WriteLine($"Аккерман(1, 0): {Akkerman(1, 0)}");
            Console.WriteLine($"Аккерман(1, 1): {Akkerman(1, 1)}\n");

            //Third
            //Console.WriteLine("Введите число N:");
            //int N = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Сумма цифр числа {N} равна {SumOfDigits(N)}");
            Console.WriteLine($"Сумма цифр числа 12345 равна {SumOfDigits(12345)}");

            //Fourth
            Console.WriteLine("Цифры числа 12345 справа налево:");
            DigitsRightToLeft(12345);

            //Fifth
            string word = "арозаупаланалапуазора";
            string isPalindrome = IsPalindrome(word) ? "Yes" : "No";
            Console.WriteLine(
                $"Является ли слово \"{word}\" палиндромом: {isPalindrome}");

            string word2 = "шабаш";
            string isPalindrome2 = IsPalindrome(word2) ? "Yes" : "No";
            Console.WriteLine(
                $"Является ли слово \"{word2}\" палиндромом: {isPalindrome2}");

            string word3 = "казаки";
            string isPalindrome3 = IsPalindrome(word3) ? "Yes" : "No";
            Console.WriteLine(
                $"Является ли слово \"{word3}\" палиндромом: {isPalindrome3}");
        }

        static void First(int A, int B)
        {
            if (A < B)
            {
                Console.Write(A);
                Console.Write(", ");
                First(A + 1, B);
            }
            else if (A > B)
            {
                Console.Write(A);
                Console.Write(", ");
                First(A - 1, B);
            }
            else
            {
                Console.Write(A);
            }
        }

        static int Akkerman(int m, int n)
        {
            if (m == 0)
                return n + 1;
            else if (m > 0 && n == 0)
                return Akkerman(m - 1, 1);
            else if (m > 0 && n > 0)
                return Akkerman(m - 1, Akkerman(m, n - 1));
            else
                throw new Exception("Функция не определена при m < 0 или n < 0");
        }

        static int SumOfDigits(int N)
        {
            if (N < 10)
                return N;
            return SumOfDigits(N / 10) + N % 10;
        }

        static void DigitsRightToLeft(int N)
        {
            if (N < 10)
                Console.Write(N);
            else
            {
                Console.Write(N % 10);
                Console.Write(", ");
                DigitsRightToLeft(N / 10);
            }
        }

        static bool IsPalindrome(string word)
        {
            if (word.Length <= 1)
                return true;
            return word[0] == word[word.Length - 1] && IsPalindrome(word.Substring(1, word.Length - 2));

        }
    }
}
