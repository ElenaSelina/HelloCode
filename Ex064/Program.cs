/* Задача 64: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter natural number: ");
        string? strNum = Console.ReadLine();

        if (strNum == null) {
            return;
        }

        int n = int.Parse(strNum);
        PrintNumbers(n);
    }

    static void PrintNumbers(int n)
    {
        if (n <= 0)
        {
            return;
        }

        Console.Write(n + ", ");
        PrintNumbers(n - 1);
    }
}
