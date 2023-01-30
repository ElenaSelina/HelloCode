/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

namespace Task68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ackermann: " + Ackermann(m, n));
        }

        static int Ackermann(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            if (m > 0 && n == 0)
            {
                return Ackermann(m - 1, 1);
            }
            if (m > 0 && n > 0)
            {
                return Ackermann(m - 1, Ackermann(m, n - 1));
            }
            return 0;
        }
    }
}
