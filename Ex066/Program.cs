/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

namespace Task66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter M: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum: " + Sum(M, N));
        }

        static int Sum(int M, int N)
        {
            if (M > N)
            {
                return 0;
            }
            return M + Sum(M + 1, N);
        }
    }
}
