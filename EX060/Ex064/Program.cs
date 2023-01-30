/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

namespace Task64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            PrintNumbers(N);
        }

        static void PrintNumbers(int N)
        {
            if (N <= 0)
            {
                return;
            }
            Console.Write(N + ", ");
            PrintNumbers(N - 1);
        }
    }
}
