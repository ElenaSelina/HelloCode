/* Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter natural number M: ");
        string? strM = Console.ReadLine();
        Console.Write("Enter natural number N: ");
        string? strN = Console.ReadLine();

        if (strM == null || strN == null) {
            throw new Exception("illegal value");
        }

        int m = int.Parse(strM);
        int n = int.Parse(strN);

        Console.WriteLine("Sum of natural numbers between " + m + " and " + n + " = " + Sum(m, n));
    }

    static int Sum(int m, int n)
    {
        if (m > n)
        {
            return 0;
        }
        return m + Sum(m + 1, n);
    }
}
