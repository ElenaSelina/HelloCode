/* Задача 68: Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter m: ");
        string? strM = Console.ReadLine();
        Console.Write("Enter n: ");
        string? strN = Console.ReadLine();

        if (strM == null || strN == null) {
            throw new Exception("illegal argument");
        }

        int m = int.Parse(strM);
        int n = int.Parse(strN);

        Console.WriteLine("Ackermann: " + Ackermann(m, n));
    }

    static int Ackermann(int m, int n)
    {
        return (
            (m == 0) ? n + 1 :
            (n == 0) ? Ackermann(m - 1, 1) :
            Ackermann(m - 1, Ackermann(m, n - 1))
        );
    }
}
