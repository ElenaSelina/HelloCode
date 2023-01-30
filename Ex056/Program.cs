/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

using System;

namespace Task56
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            int rowWithMinSum = 0;
            int minSum = int.MaxValue;

            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < columns; j++)
                {
                    sum += arr[i, j];
                }

                if (sum < minSum)
                {
                    minSum = sum;
                    rowWithMinSum = i;
                }
            }

            Console.WriteLine("Row with min sum: " + (rowWithMinSum + 1));
        }
    }
}
