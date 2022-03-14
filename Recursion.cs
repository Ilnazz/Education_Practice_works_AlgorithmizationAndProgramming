using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Введите числа A и B:");
            int A = int.Parse(Console.ReadLine()),
                B = int.Parse(Console.ReadLine());
            Console.WriteLine(First(A, B));

            Console.WriteLine("Введите числа m и n:");
            int m = int.Parse(Console.ReadLine()),
                n = int.Parse(Console.ReadLine());
            Console.WriteLine(Akkerman(m, n));

            Console.WriteLine("Введите число N:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма цифр числа {N} равна {SumOfDigits(N)}");
            */


        }

        static string First(int A, int B)
        {
            if (A < B)
                return A.ToString() + ", " + First(A + 1, B);
            else if (A > B)
                return A.ToString() + ", " + First(A - 1, B);
            else
                return A.ToString();
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

        static string DigitsRightToLeft(int N)
        {
            if (N < 10)
                return N.ToString();
            return (N % 10).ToString() + DigitsRightToLeft(N / 10);
        }
    }
}
